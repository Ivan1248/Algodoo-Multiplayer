#Region "UDP"
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
#End Region
Imports System.IO

'>>>>>>>>>>>>>>>>>>>>Remove integer overflow checks kasnije, unused references

Public Class Form1

    'Ukloniti UpdateList s mjesta koja nisu pingtimer, kasnije
    ' i additionaldata
    'pingiranje - brisanje igrača ne radi

    'Dim watch As Stopwatch = Stopwatch.StartNew()
    '    watch.Start()
    '    watch.Stop()
    '    Output.Text = CStr(watch.ElapsedTicks)

    Const HostPort As Integer = 62831
    Const GuestPort As Integer = 62832

#Region "Varijable"
    Public IsConnected As Boolean = False

    Dim Dir As String = FileIO.SpecialDirectories.MyDocuments & "\Algodoo\Multiplayer"

    'Funkcija programa
    Dim IsHost As Boolean = False

    Dim PAddresses(8) As String
    Dim PNames(8) As String, PStatuses(8) As String, PPings(8) As Integer, PTeams As Boolean() = {True, False, True, False, True, False, True, False}
    Dim PDataQueue(8) As String
    Dim LastPing(8) As Boolean

    Dim LastPlayerIndex As Integer = 0, MyPlayerIndex As Byte = 0

    Dim GamePath As String
    Dim GameName As String
#End Region

    '//////// Program ///////////////////////////////////////////////////////////////////////

#Region "Učitavanje"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With My.Settings
            InternetConnect.Checked = .PortForwarded
            HostIP.Text = .HostAddress
            HostIP.AutoCompleteCustomSource = .AddressCookies
        End With
        Directory.CreateDirectory(Dir)
        FSW.Path = Dir
        StoreAddressInfo()
        AddHandler InternetConnect.CheckedChanged, AddressOf InternetConnect_CheckedChanged
        InternetConnect_CheckedChanged(New Object, New EventArgs)
        FunctionComboBox.SelectedIndex = 0
        AddHandler FunctionComboBox.SelectedIndexChanged, AddressOf FunctionComboBox_SelectedIndexChanged
    End Sub

    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        With My.Settings
            .HostAddress = HostIP.Text
            .AddressCookies = HostIP.AutoCompleteCustomSource
        End With
        If IsConnected Then Disconnect()
    End Sub
#End Region

    '//////// Glavni dio programa ///////////////////////////////////////////////////////////

#Region "Primanje, slanje, čitanje i pisanje"
    Private Sub FSW_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FSW.Changed
        With ReadSendBGW
            If Not .IsBusy Then
                .RunWorkerAsync(e.FullPath)
            End If
        End With
    End Sub
    Private Sub ReadSendBGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ReadSendBGW.DoWork
            Try
                Dim Data As String = File.ReadAllText(Dir & "\out")
                File.Delete(CStr(e.Argument))
                Dim LastLine As Char() = Data.Substring(Data.LastIndexOf(Chr(10))).ToCharArray
                'Dim replaces As New List(Of Object)
            If IsHost OrElse TestCB.Checked Then
                For i = 0 To LastLine.Length - 1
                    If LastLine(i) = "{"c AndAlso LastLine.Length - i - 3 > 0 AndAlso LastLine(i + 1) = "I"c AndAlso LastLine(i + 2) = "}"c Then
                        LastLine(i) = "1"c
                        LastLine(i + 1) = " "c
                        LastLine(i + 2) = " "c

                        'Data(i + 1) = IntToChar(MyPlayerIndex)

                        i += 2 ''''''''''popraviti^^^^^^^^^^^^^^
                    End If
                Next
                If IsHost Then
                    For i = 1 To LastPlayerIndex
                        UDPComm.SendData("A" + New String(LastLine), PAddresses(i))
                    Next
                Else
                    UDPComm.SendData("A" + New String(LastLine), HostIP.Text)
                End If
            Else
                UDPComm.SendData("A" + New String(LastLine), HostIP.Text)
            End If
        Catch ex As Exception
            Media.SystemSounds.Beep.Play()
            'e.Result = ex.Message
        End Try
    End Sub
    Private Function _IntToChar(ByVal i As Integer) As Char
        Return ChrW(AscW("0"c) + i)
    End Function

    Private Sub MessageReceived(ByVal HData As String, ByVal Address As String)
        Dim Data As String = HData.Remove(0, 1)
        'If HData(0) <> "p" Then
        '    Output.AppendText(vbNewLine & "_in: " & HData & vbNewLine)
        'End If
        Select Case HData(0)
            Case "A"c 'za Algodoo
                If IsHost Then
                    Dim oi As Integer = GetIndexByAddress(Address)
                    Dim Tin As Boolean = False
                    Dim Tpos As Integer = -1
                    Dim Ipos As New List(Of Integer)
                    'Dim Splits As New List(Of String)

                    For i = 0 To HData.Length - 1
                        If HData(i) = "{"c AndAlso HData.Length - i - 3 > 0 AndAlso HData(i + 2) = "}"c Then
                            Select Case HData(i + 1)
                                Case "T"c
                                    Tpos = i 'Data > HData
                                    Tin = True
                                    i += 2
                                Case "I"c
                                    Ipos.Add(i)
                                    i += 2
                            End Select
                        End If
                    Next
                    Dim HDataC As Char() = HData.ToCharArray
                    For i = 1 To LastPlayerIndex 'popraviti
                        If i <> oi Then 'da se ne šalje natrag
                            Dim si As Integer = GetSubjectiveIndex(i, oi)
                            For Each pos As Integer In Ipos
                                HDataC(pos) = _IntToChar(si)
                                HDataC(pos + 1) = " "c
                                HDataC(pos + 2) = " "c
                            Next
                            'For j = 0 To 2
                            'HDataC(Tpos + j) = dly(j)
                            'Next
                            If Tin Then
                                Dim dly As String = ((PPings(i) + PPings(oi)) / 2).ToString '.PadLeft(3, "0")
                                For j = 0 To 2
                                    HDataC(Tpos + j) = dly(j)
                                Next
                            End If
                            UDPComm.SendData(HDataC, PAddresses(i))
                        End If
                    Next
                    For Each pos As Integer In Ipos
                        HDataC(pos) = _IntToChar(oi)
                        HDataC(pos + 1) = " "c
                        HDataC(pos + 2) = " "c
                    Next
                    If Tin Then
                        Dim hdly As String = (PPings(oi) / 2).ToString.PadLeft(3, "0"c)
                        For j = 0 To 2
                            HDataC(Tpos + j) = hdly(j)
                        Next
                    End If
                    Write(New String(HDataC, 1, HDataC.Length - 1))
                Else
                    Write(Data)
                End If
                ' AdditionalData = String.Empty
            Case "p"c 'ping
                If IsHost Then
                    Dim i As Integer = GetIndexByAddress(Address)
                    'Thread.Sleep(30)
                    Dim ping As Long = PingWatch.ElapsedMilliseconds
                    LastPing(i) = True
                    PPings(i) = CInt(If(ping < 1000, ping, 999))
                    'Dim png As New System.Net.NetworkInformation.Ping
                    'MsgBox(png.Send(Address).RoundtripTime)
                    UpdateList()
                    SendList()
                Else
                    UDPComm.SendData("p", Address)
                End If
            Case "c"c 'spajanje, ime(H)/lista(C)
                If IsHost Then
                    If LastPlayerIndex < 8 Then
                        Dim NameNotTaken As Boolean = True
                        For i = 0 To LastPlayerIndex
                            If PNames(i) = Data Then
                                NameNotTaken = False
                                UDPComm.SendData("xConnection failed: Player name taken.", Address)
                                Exit For
                            End If
                        Next
                        If NameNotTaken Then
                            If Address <> PublicIPAddress Then
                                AddPlayer(Data, Address)
                                UDPComm.SendData("ch", Address)
                                SendList()
                                SendSetup()
                            End If
                        Else
                            UDPComm.SendData("xConnection failed: All player places are taken.", Address)
                        End If
                    End If
                Else
                    If Data = "h" Then TimeoutTimer.Enabled = False
                End If
            Case "x"c 'prekid veze
                If IsHost Then
                    RemovePlayer(GetIndexByAddress(Address))
                ElseIf IsConnected Then
                    Disconnect()
                    MsgBox(vbNewLine & Data)
                End If
            Case "l"c 'lista C
                Dim items As String() = Data.Split(Chr(13)) 'vbCr
                MyPlayerIndex = CByte(items.Last)
                LastPlayerIndex = items.Length - 2
                For i = 0 To LastPlayerIndex
                    Dim subits As String() = items(i).Split(Chr(10)) 'vbLf
                    PNames(i) = subits(0)
                    PStatuses(i) = subits(1)
                    PPings(i) = CShort(subits(2))
                Next
                UpdateList()
            Case "t"c 'tim H
                ChangeTeam(GetIndexByAddress(Address))
                SendList()
            Case "m"c 'poruka
                If IsHost Then
                    Dim indx = GetIndexByAddress(Address)
                    For i = 1 To LastPlayerIndex
                        If i <> indx Then
                            UDPComm.SendData(HData, PAddresses(i))
                        End If
                    Next
                End If
                Output.AppendText(vbNewLine & Data)
            Case "g"c 'SetUp C
                If IsHost Then
                    Select Case Data
                        Case "f"
                            PStatuses(GetIndexByAddress(Address)) = "Game found"
                        Case "r"
                            PStatuses(GetIndexByAddress(Address)) = "Ready"
                        Case Else
                            PStatuses(GetIndexByAddress(Address)) = "Game not found"
                    End Select
                    UpdateList()
                    SendList()
                Else
                    Dim Settings As String() = Data.Split(Chr(13)) 'vbCr
                    MsgBox(Settings(0))
                    GameName = Settings(1)
                    Teams.Checked = CBool(Settings(2))
                    FwdPing.Checked = CBool(Settings(3))
                    OpenFileDialog.FileName = GameName
                    GameLabel.Text = "[""" & GameName & """ - Click to browse or drop the file here.]"
                    ReadyButton.Enabled = False
                End If
            Case "s"c
                Try
                    Process.Start(GamePath)
                Catch : End Try
        End Select
    End Sub

    Private Sub Write(ByVal Content As String)
        Try
            File.WriteAllText(Dir & "\in", Content)
        Catch
            System.Media.SystemSounds.Beep.Play()
        End Try
    End Sub



#End Region

#Region "Uređivanje i slanje liste igrača"
    Private Sub AddPlayer(ByVal Name As String, ByVal Address As String)
        LastPlayerIndex += 1
        LastPing(LastPlayerIndex) = True
        PNames(LastPlayerIndex) = Name
        PAddresses(LastPlayerIndex) = Address
        PStatuses(LastPlayerIndex) = "Game not found"
        UpdateList()
    End Sub
    Private Sub RemovePlayer(ByVal index As Integer)
        If index <> 8 Then ' 8 dolazi ako ne postoji
            LastPlayerIndex -= 1
            For i = index To LastPlayerIndex
                PNames(i) = PNames(i + 1)
            Next
            UpdateList()
        End If
    End Sub
    Private Sub UpdateList()
        For i = 0 To LastPlayerIndex
            With ListView1.Items(i)
                Dim ForeColor = If(Teams.Checked, If(PTeams(i), Color.Navy, Color.DarkRed), Color.Black)
                Dim BackColor = Output.BackColor
                Dim Font = Output.Font
                With .SubItems
                    .Clear()
                    .Add(PNames(i), ForeColor, BackColor, Font)
                    .Add(PStatuses(i), ForeColor, BackColor, Font)
                    .Add(CStr(PPings(i)), ForeColor, BackColor, Font)
                End With
            End With
        Next
        For i = LastPlayerIndex + 1 To 7
            With ListView1.Items(i)
                .SubItems.Clear()
            End With
        Next
    End Sub
    Private Sub SendList()
        Dim list As String = ""
        For i = 0 To LastPlayerIndex
            list &= PNames(i) & vbLf & PStatuses(i) & vbLf & PPings(i) & vbCr
        Next
        For i = 1 To LastPlayerIndex
            UDPComm.SendData("l" & list & CStr(i), PAddresses(i))
        Next
    End Sub

    Private Sub ChangeTeam(ByVal i As Integer)
        PTeams(i) = Not PTeams(i)
        UpdateList()
    End Sub

#End Region

#Region "Indeksi"
    Private Function GetIndexByAddress(ByVal Address As String) As Integer
        For i = 0 To LastPlayerIndex
            If Address = PAddresses(i) Then
                Return i
            End If
        Next
        Return 8
    End Function

    Private Function GetSubjectiveIndex(ByVal index As Integer, Optional ByVal subject As Integer = 0) As Integer
        If subject = 0 Then subject = MyPlayerIndex
        Return If(index > subject, index, (index + 1) Mod (subject + 1)) 'dividing by zero
    End Function
    Private Function GetObjectiveIndex(ByVal index As Integer, Optional ByVal subject As Integer = 0) As Integer
        If subject = 0 Then subject = MyPlayerIndex
        Return If(index > subject OrElse subject = 0, index, index - 1)
    End Function
#End Region

#Region "Ostalo"
    Private Sub SendSetup()

    End Sub
#End Region

    '//////// Povezivanje ///////////////////////////////////////////////////////////////////

#Region "UDP"
    Dim UDPComm As New UDPCommunicator(AddressOf MessageReceived)
#End Region

#Region "Internet"
    Dim PublicIPAddress As String
    Private Sub InternetConnect_CheckedChanged(sender As Object, e As EventArgs)
        InternetConnect.Enabled = False
        If Not InternetBGW.IsBusy Then InternetBGW.RunWorkerAsync(InternetConnect.Checked)
    End Sub
    Private Sub InternetBGWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles InternetBGW.DoWork
        Dim mappings As NATUPNPLib.IStaticPortMappingCollection = New NATUPNPLib.UPnPNATClass().StaticPortMappingCollection
        e.Result = True
        If CBool(e.Argument) Then
            'StoreAddressInfo()
            Try
                mappings.Add(HostPort, "UDP", HostPort, AddressInfo(2), True, "Algodoo Connector Host")
                mappings.Add(GuestPort, "UDP", GuestPort, AddressInfo(2), True, "Algodoo Connector Guest")
                PublicIPAddress = mappings.Item(GuestPort, "UDP").ExternalIPAddress
                My.Settings.PortForwarded = True
            Catch ex As Exception
                My.Settings.PortForwarded = False
                e.Result = False
            End Try
        Else
            Try
                My.Settings.PortForwarded = False
                mappings.Remove(HostPort, "UDP")
                mappings.Remove(GuestPort, "UDP")
            Catch
            End Try
        End If
    End Sub
    Private Sub InternetBGWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles InternetBGW.RunWorkerCompleted
        If Not CBool(e.Result) Then
            MsgBox("Unable to forward port" & vbNewLine & "Make sure that UPnP is enabled on your router and that ports " & HostPort & " and " & GuestPort & " are not forwarded to some other computer connected to the router. You can also try to disable and reenable UPnP on the router.")
            InternetConnect.Checked = False
        End If
        InternetConnect.Enabled = True
    End Sub
#End Region

#Region "Adrese"
    Dim AddressInfo As List(Of String) = New List(Of String)
    Private Sub StoreAddressInfo()
        AddressInfo.Clear()
        Dim adapters = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        For Each adapter In adapters
            If adapter.OperationalStatus = NetworkInformation.OperationalStatus.Up Then
                Dim addresses = adapter.GetIPProperties.UnicastAddresses.ToArray
                For Each address In addresses
                    If address.Address.AddressFamily = AddressFamily.InterNetwork Then
                        AddressInfo.Add(adapter.Name)
                        AddressInfo.Add(adapter.Description)
                        AddressInfo.Add(address.Address.ToString)
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub
#End Region

    '//////// Spajanje, dugme za spajanje ///////////////////////////////////////////////////

#Region "Dugme za spajanje i TimeoutTimer"
    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        If IsConnected Then
            Disconnect()
        Else
            Connect()
        End If
        UpdateList()
    End Sub
    Private Sub Connect()
        If NameTB.Text.Length <> 0 Then
            If AddressIsValid(HostIP.Text) Then
                UDPComm.SendPort = If(IsHost, GuestPort, HostPort)
                LastPlayerIndex = 0
                UDPComm.ConnectUDP(If(IsHost, HostPort, GuestPort))
                'Console.Beep(120, 80)
                'Console.Beep(200, 120)
                PNames(0) = NameTB.Text
                If IsHost Then
                    StartButton.Enabled = True
                    PStatuses(0) = "Idle"
                    'PingTimer.Enabled = True
                    SettingsPanel.Enabled = True
                Else
                    PStatuses(0) = String.Empty
                    UDPComm.SendData("c" & NameTB.Text, HostIP.Text)
                    If Not TestCB.Checked Then TimeoutTimer.Enabled = True
                End If
                Panel4.Enabled = True
                NameTB.ReadOnly = True
                HostIP.ReadOnly = True
                FunctionComboBox.Enabled = False
                ConnectButton.Text = "Disconnect"
                IsConnected = True
                FSW.EnableRaisingEvents = True
            Else
                MsgBox("Invalid IP address.")
            End If
        Else
            MsgBox("No name entered.")
        End If
    End Sub
    Private Sub Disconnect()
        If IsHost Then
            For i = 1 To LastPlayerIndex
                UDPComm.SendData("xConnection failed: Host is offline.", PAddresses(i))
            Next
        Else
            UDPComm.SendData("x", HostIP.Text)
        End If
        FSW.EnableRaisingEvents = False
        IsConnected = False
        UDPComm.DisconnectUDP()
        'Console.Beep(180, 80)
        'Console.Beep(120, 80)
        'PingTimer.Enabled = False
        Panel4.Enabled = False
        NameTB.ReadOnly = False
        HostIP.ReadOnly = False
        FunctionComboBox.Enabled = True
        ConnectButton.Text = "Connect"
        StartButton.Enabled = False
        LastPlayerIndex = 0
        SettingsPanel.Enabled = False
        With ListView1
            For i = 0 To 7
                .Items(i).SubItems.Clear()
            Next
        End With
        ReDim PAddresses(8)
    End Sub

    Private Sub ConnectTimeout() Handles TimeoutTimer.Tick
        If IsConnected Then
            Disconnect()
            Output.AppendText(vbNewLine & "Connection failed: No response.")
        End If
        TimeoutTimer.Enabled = False
    End Sub
#End Region

    '//////// GUI, dostupno korisniku ///////////////////////////////////////////////////////

#Region "Gornji dio"
    Private Sub FunctionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        IsHost = FunctionComboBox.SelectedIndex = 1
        HostIP.Enabled = Not IsHost
        If IsHost Then
            HostIP.Clear()
            AddressInfoButton.Enabled = True
        Else
            HostIP.Text = My.Settings.AddressCookies.Item(My.Settings.AddressCookies.Count - 1)
        End If
    End Sub

    Private Sub AddressTextBox_Leave(sender As Object, e As EventArgs) Handles HostIP.Leave
        HostIP.Text = HostIP.Text.Trim
        If AddressIsValid(HostIP.Text) Then
            With HostIP.AutoCompleteCustomSource
                .Add(HostIP.Text)
                Dim lastindex = .Count - 1
                If lastindex > 0 Then
                    For i = 0 To lastindex - 1
                        .Item(i) = .Item(i + 1)
                    Next
                End If
                If lastindex = 6 Then
                    .RemoveAt(6)
                End If
            End With
        End If
    End Sub
    Private Function AddressIsValid(ByVal addr As String) As Boolean

        If addr = "localhost" OrElse addr = "" Then Return True
        If addr = "0.0.0.0" Then Return False

        Dim add = addr.Split("."c)
        If add.Length = 4 Then
            For Each a As String In add
                Dim n As Integer = 256
                If Not Integer.TryParse(a, n) OrElse n > 255 Then
                    Return False
                End If
            Next
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub AddressInfoButton_Click(sender As Object, e As MouseEventArgs) Handles AddressInfoButton.MouseClick ', AddressInfoButton.Click
        AddressesMenu.Show(MousePosition.X - e.X, MousePosition.Y - e.Y)
    End Sub
    Private Sub AddressesMenu_Click(sender As Object, e As EventArgs) Handles AddressesMenu.Click
        AddressesMenu.Close()
    End Sub
    Private Sub AddressesMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AddressesMenu.Opening
        AddressesMenu.Items.Clear()

        Dim Label As New ToolStripLabel
        With Label
            .Text = "List of your addresses"
            .Margin = New Padding(0, 6, 0, 4)
        End With
        'Label.Font = New Font(Label.Font, FontStyle.Bold)
        With AddressesMenu.Items
            .Add(Label)
            .Add(New ToolStripSeparator)
        End With

        StoreAddressInfo()

        For i = 0 To AddressInfo.Count \ 2
            Dim Lab As New ToolStripLabel
            With Lab
                .Text = AddressInfo(i)
                .Margin = New Padding(0, 4, 0, 0)
                i += 1
                .ToolTipText = AddressInfo(i)
            End With
            AddressesMenu.Items.Add(Lab)

            i += 1

            Dim Addr As New ToolStripTextBox()
            With Addr
                .Text = AddressInfo(i)
                .ReadOnly = True
                .BackColor = Color.FromKnownColor(KnownColor.Window)
                .Margin = New Padding(0, 0, 0, 4)
            End With
            AddressesMenu.Items.Add(Addr)
        Next
        If InternetConnect.Checked And InternetConnect.Enabled Then
            Dim Lab As New ToolStripLabel
            With Lab
                .Text = "Internet"
                .Margin = New Padding(0, 4, 0, 0)
                .ToolTipText = "Public availability via UPnP"
            End With
            AddressesMenu.Items.Add(Lab)

            Dim Addr As New ToolStripTextBox()
            With Addr
                .Text = PublicIPAddress
                .ReadOnly = True
                .BackColor = Color.FromKnownColor(KnownColor.Window)
                .Margin = New Padding(0, 0, 0, 4)
            End With
            AddressesMenu.Items.Add(Addr)
        End If

    End Sub
#End Region

#Region "Donja dugmad"
    Private Sub TeamButton_Click(sender As Object, e As EventArgs) Handles TeamButton.Click
        If IsHost Then
            ChangeTeam(0)
        Else
            If Not TimeoutTimer.Enabled Then UDPComm.SendData("t", HostIP.Text)
        End If
    End Sub
    Private Sub ReadyButton_Click(sender As Object, e As EventArgs) Handles ReadyButton.Click
        If IsHost Then
            PStatuses(0) = "Ready"
            SendList()
        Else
            If Not TimeoutTimer.Enabled Then UDPComm.SendData("gr", HostIP.Text)
        End If
    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Try
            For i = 1 To LastPlayerIndex
                UDPComm.SendData("s", PAddresses(i))
            Next
            Process.Start(GamePath)
        Catch : End Try
    End Sub
#End Region

#Region "ListView i Input i Output"
    Private Sub ListView1_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles ListView1.ColumnWidthChanging
        e.Cancel = True
        e.NewWidth = Me.ListView1.Columns(e.ColumnIndex).Width
    End Sub
    Private Sub KickMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles KickMenu.Opening
        'If IsHost Then
        'KickButton.Enabled = ListView1.SelectedIndices(0) <= LastPlayerIndex AndAlso ListView1.SelectedIndices(0) <> 0
        'Else
        'e.Cancel = True
        'End If

        If Not IsHost OrElse ListView1.SelectedIndices(0) > LastPlayerIndex Then
            e.Cancel = True
        Else
            KickButton.Enabled = ListView1.SelectedIndices(0) <> 0
        End If
    End Sub
    Private Sub KickButton_Click(sender As Object, e As EventArgs) Handles KickButton.Click
        If IsHost Then
            Dim i = ListView1.SelectedIndices(0)
            UDPComm.SendData("xDisconnected: Kicked.", PAddresses(i))
            RemovePlayer(i)
            SendList()
        End If
    End Sub

    Private Sub Input_KeyDown(sender As Object, e As KeyEventArgs) Handles Input.KeyDown
        If e.KeyCode = Keys.Enter And Not e.Shift Then
            Dim message = NameTB.Text & ": " & Input.Text
            If IsHost Then
                For i = 1 To LastPlayerIndex
                    UDPComm.SendData("m" & message, PAddresses(i))
                Next
            Else
                UDPComm.SendData("m" & message, HostIP.Text)
            End If
            Output.AppendText(vbNewLine & message)
            Input.Clear()
            e.SuppressKeyPress = True
        End If
    End Sub
#End Region

    Private Sub Team_CheckedChanged(sender As Object, e As EventArgs) Handles Teams.CheckedChanged
        SendGameInfo()
        UpdateList()
    End Sub

    Private Sub FPing_CheckedChanged(sender As Object, e As EventArgs) Handles FwdPing.CheckedChanged
        SendGameInfo()
    End Sub
    Private Sub SendGameInfo()
        If GameName <> String.Empty Then
            For i = 1 To LastPlayerIndex
                UDPComm.SendData("g" & vbCr & GameName & vbCr & CByte(Teams.Checked).ToString & vbCr & CByte(FwdPing.Checked).ToString, PAddresses(i))
            Next
        End If
    End Sub

    '//////// Tajmeri ///////////////////////////////////////////////////////////////////////

#Region "Ping-tajmer"
    Dim PingWatch As Stopwatch = Stopwatch.StartNew()
    Private Sub PingTimer_Tick(sender As Object, e As EventArgs) Handles PingTimer.Tick
        If IsHost Then
            PingWatch.Restart()
            For i = 1 To LastPlayerIndex
                If LastPing(i) Then
                    UDPComm.SendData("p", PAddresses(i))
                    LastPing(i) = False
                Else
                    UDPComm.SendData("xDisconnected: High latency", PAddresses(i))
                    RemovePlayer(i)
                End If
            Next
            UpdateList()
            SendList()
        End If
        If FwdNames.Checked OrElse FwdPing.Checked Then
            Dim sb As New StringBuilder(128, 200)
            If FwdNames.Checked Then
                sb.Append("scene.my.names = [""")
                sb.Append(PNames(MyPlayerIndex))
                For i = 0 To LastPlayerIndex
                    If i <> MyPlayerIndex Then
                        sb.Append(""",""")
                        sb.Append(PNames(i))
                    End If
                Next
                For i = LastPlayerIndex + 1 To 7
                    sb.Append(""",""")
                Next
                sb.Append("""]; ")
            End If
            If FwdPing.Checked Then
                sb.Append("scene.my.pings = [")
                sb.Append(PPings(MyPlayerIndex))
                For i = 0 To LastPlayerIndex
                    If i <> MyPlayerIndex Then
                        sb.Append(",")
                        sb.Append(PPings(i))
                    End If
                Next
                For i = LastPlayerIndex + 1 To 7
                    sb.Append(",0")
                Next
                sb.Append("]; ")
            End If
            Try : File.WriteAllText(Dir & "\in_", sb.ToString)
            Catch : Console.Beep(440, 100) : End Try
        End If
    End Sub
#End Region

    Private Sub GameLabel_Click(sender As Object, e As EventArgs) Handles GameLabel.Click
        If Not TestCB.Checked Then OpenFileDialog.ShowDialog()
    End Sub

    Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        GamePath = OpenFileDialog.FileName
        If IsHost Then
            GameName = Path.GetFileNameWithoutExtension(GamePath)
            SendGameInfo()
            GameLabel.Text = GameName
        Else
            If GameName = Path.GetFileNameWithoutExtension(GamePath) Then
                Dim result = MessageBox.Show("The file you selected doesn't have the same name as the one on host's system. Are you sure this is the same game?", "Different file name", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    UDPComm.SendData("gf", HostIP.Text)
                    GameLabel.Text = GameName
                    ReadyButton.Enabled = True
                End If
            End If
        End If
    End Sub

    'Private Sub ReadSendBGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ReadSendBGW.RunWorkerCompleted
    '    Output.Text = CStr(e.Result)
    'End Sub

End Class
