
Public Class Reservedpage 'Class Reserved Page
    Public resSelected As String() = {Nothing, Nothing, Nothing} 'Declare new array of string for sub "btn_cancel_Click"
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        refreshlist()
        'When click btn_refresh ; do sub refreshlist().
    End Sub

    Private Sub refreshlist()
        'Declare new sub to refresh reserved list.
        DataGridView1.Rows.Clear()
        'Clear all rows in DataGridView1
        For Each train In main.reservedSeat
            With train
                DataGridView1.Rows.Add(.traveldate.ToString, .trainNumber, .seatNumber, .destination.ToString, .price, .passengerName.ToString)
            End With
        Next
        'Loop all element in LinkedList main.reservedSeat and add all attribute to DataGridView's column of each rows
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        'When click btn_cancel
        For Each res In main.reservedSeat
            If res.traveldate = resSelected(0) AndAlso res.trainNumber = resSelected(1) AndAlso res.seatNumber = resSelected(2) Then
                main.reservedSeat.Remove(res)
                Exit For
            End If
        Next
        'Loop all element in LinkedList main.reservedSeat then remove that elemet if main.reservedSeat contains data of selected DataGridView row's data
        refreshlist() 'Do sub refreshlist()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'When changed selected rows index of DataGridView1
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        resSelected(0) = selectedRow.Cells(0).Value
        resSelected(1) = selectedRow.Cells(1).Value.ToString
        resSelected(2) = selectedRow.Cells(2).Value.ToString
        'Add selected row's column 0-3 data to temporary variable "resSelected" for sub "btn_cancel_Click"
    End Sub
End Class