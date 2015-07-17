Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class UDPCommunicator

    Public SendPort As Integer = 62831


    Private receivingClient As UdpClient
    Private sendingClient As UdpClient
    Private receivingThread As Thread

    Delegate Sub AddMessage(Data As String, Address As String)

    Dim _messageDelegate As AddMessage

    Sub New(messageDelegate As AddMessage)
        _messageDelegate = messageDelegate
    End Sub

    Public Sub ConnectUDP(port As Integer)
        sendingClient = New UdpClient() With {.EnableBroadcast = True}
        receivingClient = New UdpClient(port)
        receivingThread = New Thread(New ThreadStart(AddressOf Receiver)) With {.IsBackground = True}
        receivingThread.Start()
    End Sub
    Public Sub DisconnectUDP()
        sendingClient.Close()
        receivingThread.Abort()
        receivingClient.Close()
    End Sub

    Public Sub Receiver()
        Dim endPoint As IPEndPoint = Nothing ' = New IPEndPoint(IPAddress.Any, port)
        While True
            Dim data As Byte() = receivingClient.Receive(endPoint)
            Form1.Invoke(_messageDelegate, Encoding.ASCII.GetString(data), endPoint.Address.ToString)
        End While
    End Sub

    Public Sub SendData(ByVal DataStr As String, Address As String)
        Dim data() As Byte = Encoding.ASCII.GetBytes(DataStr)
        sendingClient.Send(data, data.Length, Address, SendPort)
    End Sub

End Class
