Public Class main 'Class Main for Form Main
    Public trainSeat As New LinkedList(Of Integer)      'Declare new LinkedList of Integer named trainSeat in Public access
    Public reservedSeat As New LinkedList(Of Reserved)  'Declare new LinkedList of Class Reserved ชื่อว่า reservedSeat in Public access
    Public trainList As New LinkedList(Of Train)        'Declare new LinkedList of Class Reserved ชื่อว่า reservedSeat in Public access

    Private Sub btn_main_reserve_Click(sender As Object, e As EventArgs) Handles btn_main_reserve.Click
        reservation.Show() 'Show from of class reservation when click button btn_main_reserve
    End Sub

    Private Sub btn_main_edit_Click(sender As Object, e As EventArgs) Handles btn_main_edit.Click
        edit.Show() 'Show from of class edit when click button btn_main_edit
    End Sub

    Private Sub btn_main_check_Click(sender As Object, e As EventArgs) Handles btn_main_check.Click
        Reservedpage.Show() 'Show from of class Reservedpage when click buttonbtn_main_check
    End Sub
End Class

Public Class Reserved 'Declare new class for collect reservation list as object to collect in LinkedList
    Public Property traveldate As Date
    Public Property trainNumber As Integer
    Public Property seatNumber As Integer
    Public Property passengerName As String
    Public Property destination As String
    Public Property price As Single
    'All property above is an attribute of Class Reserved in Public access

End Class

Public Class Train 'Declare new class for collect train list as object to collect in LinkedList
    Public Property trainDate As Date
    Public Property trainNo As Integer
    Public Property trainSeat As Integer
    Public Property destination As List(Of String)
    Public Property destinationPrice As List(Of Single)
    'All property above is an attribute of Class Train in Public access
End Class