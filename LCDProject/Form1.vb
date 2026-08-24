Public Class Form1

    Private m_Connected As Boolean = False
    Friend USB As New ICSharpCode.USBlib.Device

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        InitialiseLCD()
        ConnectToLCD

    End Sub

    Private Sub InitialiseLCD()
        AxUSB_LCD1.WR_P0(1) ' Write '1' to PORT0 (i.e. Endpoint 0, or USB SETUP PORT)
    End Sub

    Private Sub ConnectToLCD()
        m_Connected = AxUSB_LCD1.Find_USB_Device
        Console.WriteLine("Connected: " & m_Connected.ToString)
    End Sub

    Private Sub Toggle_LCD_Enable_Line() ' Toggle PORT1 (i.e. Endpoint 1, or USB DATA PORT)
        AxUSB_LCD1.WR_P1(1)
        AxUSB_LCD1.WR_P1(0)
    End Sub

End Class
