
Public Class Reservedpage
    Public resSelected As String() = {Nothing, Nothing, Nothing}
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        refreshlist()
    End Sub

    Private Sub refreshlist()
        DataGridView1.Rows.Clear()
        For Each train In main.reservedSeat
            With train
                DataGridView1.Rows.Add(.traveldate.ToString, .trainNumber, .seatNumber, .destination.ToString, .price, .passengerName.ToString)
            End With
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each res In main.reservedSeat
            If res.traveldate = resSelected(0) AndAlso res.trainNumber = resSelected(1) AndAlso res.seatNumber = resSelected(2) Then
                main.reservedSeat.Remove(res)
                Exit For
            End If
        Next
        refreshlist()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        MsgBox(selectedRow.Cells(0).Value.ToString)
        resSelected(0) = selectedRow.Cells(0).Value.ToString
        resSelected(1) = selectedRow.Cells(1).Value.ToString
        resSelected(2) = selectedRow.Cells(2).Value.ToString

    End Sub
End Class