Public Class main
    Public trainSeat As New LinkedList(Of Integer)
    Public reservedSeat As New LinkedList(Of Reserved)
    Public trainList As New LinkedList(Of Train)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_main_reserve_Click(sender As Object, e As EventArgs) Handles btn_main_reserve.Click
        reservation.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        edit.Show()
    End Sub

    Private Sub btn_main_check_Click(sender As Object, e As EventArgs) Handles btn_main_check.Click
        Reservedpage.Show()
    End Sub
End Class

Public Class Reserved
    Public Property traveldate As Date
    Public Property trainNumber As Integer
    Public Property seatNumber As Integer
    Public Property passengerName As String
    Public Property destination As String
    Public Property price As Single

End Class

Public Class Train
    Public Property trainDate As Date
    Public Property trainNo As Integer
    Public Property trainSeat As Integer
    Public Property destination As List(Of String)
    Public Property destinationPrice As List(Of Single)
End Class