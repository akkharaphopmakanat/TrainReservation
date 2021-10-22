Public Class edit
    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim tempdest As New List(Of String)
        Dim tempprice As New List(Of Single)
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                tempdest.Add(row.Cells(0).Value)
                tempprice.Add(row.Cells(1).Value)
            End If
        Next


        main.trainList.AddLast(New Train With {.trainDate = DateTimePicker1.Value.Date.ToString("yyyy/MM/dd"), .trainNo = Val(TextBox2.Text), .trainSeat = Val(TextBox3.Text), .destination = tempdest, .destinationPrice = tempprice})
        Button4_Click(Nothing, e)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        For Each train In main.trainList
            If DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") = train.trainDate Then
                ListBox1.Items.Add(train.trainDate & " " & train.trainNo & " " & train.trainSeat)
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim sel() As String = Split(ListBox1.SelectedItem)
            For Each train In main.trainList
                If train.trainDate = sel(0) AndAlso train.trainNo = sel(1) AndAlso train.trainSeat = sel(2) Then
                    main.trainList.Remove(train)
                    Exit For
                End If
            Next

            For Each train In main.trainList
                Console.WriteLine(train.trainDate & " " & train.trainNo & " " & train.trainSeat)
            Next
            Button4_Click(Nothing, e)
        Catch

        End Try
    End Sub

End Class