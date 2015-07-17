<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.FunctionPanel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FunctionComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.HostIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.InternetConnect = New System.Windows.Forms.CheckBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TestCB = New System.Windows.Forms.CheckBox()
        Me.AddressInfoButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GameLabel = New System.Windows.Forms.Label()
        Me.StatusPanel = New System.Windows.Forms.Panel()
        Me.SettingsPanel = New System.Windows.Forms.Panel()
        Me.FwdNames = New System.Windows.Forms.CheckBox()
        Me.Sound = New System.Windows.Forms.CheckBox()
        Me.Teams = New System.Windows.Forms.CheckBox()
        Me.FwdPing = New System.Windows.Forms.CheckBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.ReadyButton = New System.Windows.Forms.Button()
        Me.Input = New System.Windows.Forms.TextBox()
        Me.TeamButton = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PlayerColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PingColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KickButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.PingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AddressesMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FSW = New System.IO.FileSystemWatcher()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.InternetBGW = New System.ComponentModel.BackgroundWorker()
        Me.TimeoutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ReadSendBGW = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyAddressesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectionReliabilityTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FunctionPanel.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SettingsPanel.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.KickMenu.SuspendLayout()
        Me.AddressesMenu.SuspendLayout()
        CType(Me.FSW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 24)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(467, 312)
        Me.FlowLayoutPanel2.TabIndex = 9
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.FunctionPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(467, 52)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.NameTB)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 37)
        Me.Panel1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Player name:"
        '
        'NameTB
        '
        Me.NameTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Algodoo_Multiplayer.My.MySettings.Default, "PlayerName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NameTB.Location = New System.Drawing.Point(0, 17)
        Me.NameTB.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.NameTB.MaxLength = 16
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(100, 20)
        Me.NameTB.TabIndex = 4
        Me.NameTB.Text = Global.Algodoo_Multiplayer.My.MySettings.Default.PlayerName
        Me.ToolTip.SetToolTip(Me.NameTB, "A label used to identify you")
        '
        'FunctionPanel
        '
        Me.FunctionPanel.AutoSize = True
        Me.FunctionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FunctionPanel.Controls.Add(Me.Label7)
        Me.FunctionPanel.Controls.Add(Me.FunctionComboBox)
        Me.FunctionPanel.Location = New System.Drawing.Point(112, 6)
        Me.FunctionPanel.Name = "FunctionPanel"
        Me.FunctionPanel.Size = New System.Drawing.Size(100, 37)
        Me.FunctionPanel.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Network function:"
        '
        'FunctionComboBox
        '
        Me.FunctionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FunctionComboBox.FormattingEnabled = True
        Me.FunctionComboBox.IntegralHeight = False
        Me.FunctionComboBox.ItemHeight = 13
        Me.FunctionComboBox.Items.AddRange(New Object() {"Client", "Host"})
        Me.FunctionComboBox.Location = New System.Drawing.Point(0, 16)
        Me.FunctionComboBox.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FunctionComboBox.MaxDropDownItems = 2
        Me.FunctionComboBox.Name = "FunctionComboBox"
        Me.FunctionComboBox.Size = New System.Drawing.Size(100, 21)
        Me.FunctionComboBox.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.FunctionComboBox, "Network function")
        '
        'Panel6
        '
        Me.Panel6.AutoSize = True
        Me.Panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel6.Controls.Add(Me.HostIP)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Location = New System.Drawing.Point(218, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(100, 37)
        Me.Panel6.TabIndex = 14
        '
        'HostIP
        '
        Me.HostIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.HostIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.HostIP.Location = New System.Drawing.Point(0, 17)
        Me.HostIP.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.HostIP.MaxLength = 16
        Me.HostIP.Name = "HostIP"
        Me.HostIP.Size = New System.Drawing.Size(100, 20)
        Me.HostIP.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.HostIP, "The IP address of the host." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Make sure the host is in a local or an emulated loca" & _
        "l network.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Host address:"
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.InternetConnect)
        Me.Panel2.Controls.Add(Me.ConnectButton)
        Me.Panel2.Location = New System.Drawing.Point(324, 6)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(86, 40)
        Me.Panel2.TabIndex = 15
        '
        'InternetConnect
        '
        Me.InternetConnect.AutoSize = True
        Me.InternetConnect.Location = New System.Drawing.Point(1, -1)
        Me.InternetConnect.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.InternetConnect.Name = "InternetConnect"
        Me.InternetConnect.Size = New System.Drawing.Size(85, 17)
        Me.InternetConnect.TabIndex = 8
        Me.InternetConnect.Text = "Forward port"
        Me.ToolTip.SetToolTip(Me.InternetConnect, "This feature enables you to directly connect clients behind NATs." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This feature r" & _
        "equires UPnP to be enabled on your router.")
        Me.InternetConnect.UseVisualStyleBackColor = True
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(0, 16)
        Me.ConnectButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Padding = New System.Windows.Forms.Padding(1)
        Me.ConnectButton.Size = New System.Drawing.Size(78, 24)
        Me.ConnectButton.TabIndex = 6
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Controls.Add(Me.TestCB)
        Me.Panel3.Controls.Add(Me.AddressInfoButton)
        Me.Panel3.Location = New System.Drawing.Point(413, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(48, 40)
        Me.Panel3.TabIndex = 17
        '
        'TestCB
        '
        Me.TestCB.AutoSize = True
        Me.TestCB.Location = New System.Drawing.Point(1, 0)
        Me.TestCB.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.TestCB.Name = "TestCB"
        Me.TestCB.Size = New System.Drawing.Size(47, 17)
        Me.TestCB.TabIndex = 16
        Me.TestCB.Text = "Test"
        Me.TestCB.UseVisualStyleBackColor = True
        '
        'AddressInfoButton
        '
        Me.AddressInfoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.AddressInfoButton.Location = New System.Drawing.Point(0, 16)
        Me.AddressInfoButton.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.AddressInfoButton.Name = "AddressInfoButton"
        Me.AddressInfoButton.Size = New System.Drawing.Size(34, 24)
        Me.AddressInfoButton.TabIndex = 6
        Me.AddressInfoButton.Text = "Addr."
        Me.AddressInfoButton.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel4.Controls.Add(Me.GameLabel)
        Me.Panel4.Controls.Add(Me.StatusPanel)
        Me.Panel4.Controls.Add(Me.SettingsPanel)
        Me.Panel4.Controls.Add(Me.Panel16)
        Me.Panel4.Enabled = False
        Me.Panel4.Location = New System.Drawing.Point(0, 55)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(9, 6, 9, 9)
        Me.Panel4.Size = New System.Drawing.Size(454, 257)
        Me.Panel4.TabIndex = 9
        '
        'GameLabel
        '
        Me.GameLabel.BackColor = System.Drawing.SystemColors.Control
        Me.GameLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GameLabel.Location = New System.Drawing.Point(9, 3)
        Me.GameLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.GameLabel.Name = "GameLabel"
        Me.GameLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.GameLabel.Size = New System.Drawing.Size(432, 20)
        Me.GameLabel.TabIndex = 15
        Me.GameLabel.Text = "[Game not selected]"
        Me.ToolTip.SetToolTip(Me.GameLabel, "A game can be selected either by clicking here and browsing for the scene file or" & _
        " dragging and dropping it also here.")
        '
        'StatusPanel
        '
        Me.StatusPanel.AutoSize = True
        Me.StatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusPanel.Location = New System.Drawing.Point(9, 248)
        Me.StatusPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.StatusPanel.Name = "StatusPanel"
        Me.StatusPanel.Size = New System.Drawing.Size(436, 0)
        Me.StatusPanel.TabIndex = 18
        '
        'SettingsPanel
        '
        Me.SettingsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SettingsPanel.BackColor = System.Drawing.SystemColors.Control
        Me.SettingsPanel.Controls.Add(Me.FwdNames)
        Me.SettingsPanel.Controls.Add(Me.Sound)
        Me.SettingsPanel.Controls.Add(Me.Teams)
        Me.SettingsPanel.Controls.Add(Me.FwdPing)
        Me.SettingsPanel.Enabled = False
        Me.SettingsPanel.Location = New System.Drawing.Point(9, 225)
        Me.SettingsPanel.Name = "SettingsPanel"
        Me.SettingsPanel.Size = New System.Drawing.Size(432, 20)
        Me.SettingsPanel.TabIndex = 17
        '
        'FwdNames
        '
        Me.FwdNames.AutoSize = True
        Me.FwdNames.Checked = True
        Me.FwdNames.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FwdNames.Location = New System.Drawing.Point(177, 3)
        Me.FwdNames.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.FwdNames.Name = "FwdNames"
        Me.FwdNames.Size = New System.Drawing.Size(85, 17)
        Me.FwdNames.TabIndex = 11
        Me.FwdNames.Text = "Write names"
        Me.FwdNames.UseVisualStyleBackColor = True
        '
        'Sound
        '
        Me.Sound.AutoSize = True
        Me.Sound.Enabled = False
        Me.Sound.Location = New System.Drawing.Point(268, 3)
        Me.Sound.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Sound.Name = "Sound"
        Me.Sound.Size = New System.Drawing.Size(57, 17)
        Me.Sound.TabIndex = 10
        Me.Sound.Text = "Sound"
        Me.Sound.UseVisualStyleBackColor = True
        '
        'Teams
        '
        Me.Teams.AutoSize = True
        Me.Teams.Location = New System.Drawing.Point(4, 3)
        Me.Teams.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Teams.Name = "Teams"
        Me.Teams.Size = New System.Drawing.Size(82, 17)
        Me.Teams.TabIndex = 9
        Me.Teams.Text = "Team game"
        Me.Teams.UseVisualStyleBackColor = True
        '
        'FwdPing
        '
        Me.FwdPing.AutoSize = True
        Me.FwdPing.Checked = True
        Me.FwdPing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FwdPing.Location = New System.Drawing.Point(92, 3)
        Me.FwdPing.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.FwdPing.Name = "FwdPing"
        Me.FwdPing.Size = New System.Drawing.Size(79, 17)
        Me.FwdPing.TabIndex = 8
        Me.FwdPing.Text = "Write pings"
        Me.FwdPing.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel16.Controls.Add(Me.Output)
        Me.Panel16.Controls.Add(Me.ReadyButton)
        Me.Panel16.Controls.Add(Me.Input)
        Me.Panel16.Controls.Add(Me.TeamButton)
        Me.Panel16.Controls.Add(Me.ListView1)
        Me.Panel16.Controls.Add(Me.StartButton)
        Me.Panel16.Location = New System.Drawing.Point(9, 26)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(433, 193)
        Me.Panel16.TabIndex = 13
        '
        'Output
        '
        Me.Output.BackColor = System.Drawing.SystemColors.Window
        Me.Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Output.Location = New System.Drawing.Point(0, 0)
        Me.Output.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.ReadOnly = True
        Me.Output.Size = New System.Drawing.Size(213, 162)
        Me.Output.TabIndex = 1
        '
        'ReadyButton
        '
        Me.ReadyButton.Enabled = False
        Me.ReadyButton.Location = New System.Drawing.Point(292, 168)
        Me.ReadyButton.Name = "ReadyButton"
        Me.ReadyButton.Size = New System.Drawing.Size(67, 25)
        Me.ReadyButton.TabIndex = 11
        Me.ReadyButton.Text = "Ready"
        Me.ToolTip.SetToolTip(Me.ReadyButton, "Switch ready")
        Me.ReadyButton.UseVisualStyleBackColor = True
        '
        'Input
        '
        Me.Input.BackColor = System.Drawing.SystemColors.Window
        Me.Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Input.Location = New System.Drawing.Point(0, 161)
        Me.Input.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Input.MaxLength = 128
        Me.Input.Multiline = True
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(213, 32)
        Me.Input.TabIndex = 1
        '
        'TeamButton
        '
        Me.TeamButton.Location = New System.Drawing.Point(219, 168)
        Me.TeamButton.Name = "TeamButton"
        Me.TeamButton.Size = New System.Drawing.Size(67, 25)
        Me.TeamButton.TabIndex = 11
        Me.TeamButton.Text = "Team"
        Me.ToolTip.SetToolTip(Me.TeamButton, "Switch team")
        Me.TeamButton.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PlayerColumn, Me.StatusColumn, Me.PingColumn})
        Me.ListView1.ContextMenuStrip = Me.KickMenu
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16})
        Me.ListView1.Location = New System.Drawing.Point(219, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Scrollable = False
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(213, 162)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'PlayerColumn
        '
        Me.PlayerColumn.Text = "Player"
        Me.PlayerColumn.Width = 90
        '
        'StatusColumn
        '
        Me.StatusColumn.Text = "Status"
        Me.StatusColumn.Width = 80
        '
        'PingColumn
        '
        Me.PingColumn.Text = "Ping"
        Me.PingColumn.Width = 40
        '
        'KickMenu
        '
        Me.KickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KickButton})
        Me.KickMenu.Name = "KickMenu"
        Me.KickMenu.Size = New System.Drawing.Size(97, 26)
        '
        'KickButton
        '
        Me.KickButton.Name = "KickButton"
        Me.KickButton.Size = New System.Drawing.Size(96, 22)
        Me.KickButton.Text = "Kick"
        '
        'StartButton
        '
        Me.StartButton.AutoSize = True
        Me.StartButton.Enabled = False
        Me.StartButton.Location = New System.Drawing.Point(366, 168)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(67, 25)
        Me.StartButton.TabIndex = 11
        Me.StartButton.Text = "Start"
        Me.ToolTip.SetToolTip(Me.StartButton, "Send start signal to all clients and start game")
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'PingTimer
        '
        Me.PingTimer.Enabled = True
        Me.PingTimer.Interval = 1000
        '
        'AddressesMenu
        '
        Me.AddressesMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1})
        Me.AddressesMenu.Name = "ContextMenuStrip1"
        Me.AddressesMenu.ShowImageMargin = False
        Me.AddressesMenu.Size = New System.Drawing.Size(36, 10)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(32, 6)
        '
        'FSW
        '
        Me.FSW.EnableRaisingEvents = True
        Me.FSW.Filter = "out"
        Me.FSW.NotifyFilter = System.IO.NotifyFilters.LastWrite
        Me.FSW.SynchronizingObject = Me
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 10000
        Me.ToolTip.InitialDelay = 500
        Me.ToolTip.ReshowDelay = 100
        '
        'InternetBGW
        '
        '
        'TimeoutTimer
        '
        Me.TimeoutTimer.Interval = 2000
        '
        'ReadSendBGW
        '
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Algodoo scene files|*.phz;*.phn|.phi packages|*.phi"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(502, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyAddressesToolStripMenuItem, Me.ConectionReliabilityTestToolStripMenuItem, Me.ToolStripMenuItem1, Me.SettingsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'MyAddressesToolStripMenuItem
        '
        Me.MyAddressesToolStripMenuItem.Name = "MyAddressesToolStripMenuItem"
        Me.MyAddressesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MyAddressesToolStripMenuItem.Text = "My addresses"
        '
        'ConectionReliabilityTestToolStripMenuItem
        '
        Me.ConectionReliabilityTestToolStripMenuItem.Name = "ConectionReliabilityTestToolStripMenuItem"
        Me.ConectionReliabilityTestToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ConectionReliabilityTestToolStripMenuItem.Text = "Conection test"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(148, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(502, 338)
        Me.ContextMenuStrip = Me.AddressesMenu
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Algodoo Multiplayer"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FunctionPanel.ResumeLayout(False)
        Me.FunctionPanel.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.SettingsPanel.ResumeLayout(False)
        Me.SettingsPanel.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.KickMenu.ResumeLayout(False)
        Me.AddressesMenu.ResumeLayout(False)
        CType(Me.FSW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Input As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents PlayerColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents ReadyButton As System.Windows.Forms.Button
    Friend WithEvents PingColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents PingTimer As System.Windows.Forms.Timer
    Friend WithEvents Output As System.Windows.Forms.TextBox
    Friend WithEvents AddressesMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TeamButton As System.Windows.Forms.Button
    Friend WithEvents FSW As System.IO.FileSystemWatcher
    Friend WithEvents KickMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents KickButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents GameLabel As System.Windows.Forms.Label
    Friend WithEvents SettingsPanel As System.Windows.Forms.Panel
    Friend WithEvents Sound As System.Windows.Forms.CheckBox
    Friend WithEvents Teams As System.Windows.Forms.CheckBox
    Friend WithEvents FwdPing As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents InternetBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimeoutTimer As System.Windows.Forms.Timer
    Friend WithEvents ReadSendBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusPanel As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FwdNames As System.Windows.Forms.CheckBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NameTB As System.Windows.Forms.TextBox
    Friend WithEvents FunctionPanel As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FunctionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents HostIP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents InternetConnect As System.Windows.Forms.CheckBox
    Friend WithEvents ConnectButton As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TestCB As System.Windows.Forms.CheckBox
    Friend WithEvents AddressInfoButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyAddressesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConectionReliabilityTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
