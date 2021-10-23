Public Class edit 'Class Main for Form Edit
    Private Sub btn_edit_add_Click(sender As Object, e As EventArgs) Handles btn_edit_add.Click
        Dim tempdest As New List(Of String) 'Declare new list named "tempdest" for collect tempolary destination data
        Dim tempprice As New List(Of Single) 'Declare new list named "tempprice" for collect tempolary fees data
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                tempdest.Add(row.Cells(0).Value)
                tempprice.Add(row.Cells(1).Value)
            End If
        Next
        'Loop all rows data in DataGridView1 and add value of each row to "tempdest" and "tempprice"
        main.trainList.AddLast(New Train With {.trainDate = DateTimePicker1.Value.Date.ToString("yyyy/MM/dd"), .trainNo = Val(TextBox2.Text), .trainSeat = Val(TextBox3.Text), .destination = tempdest, .destinationPrice = tempprice})
        'Add new train data to the last element of LinkedList of main.trainlist
        btn_edit_find_Click(Nothing, e) 'run function to refresh train list which show on the GUI
    End Sub

    Private Sub btn_edit_find_Click(sender As Object, e As EventArgs) Handles btn_edit_find.Click 'function to refresh train list which show on the GUI
        ListBox1.Items.Clear() 'Clear all item in ListBox1
        For Each train In main.trainList
            If DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") = train.trainDate Then
                ListBox1.Items.Add(train.trainDate & " " & train.trainNo & " " & train.trainSeat)
            End If
        Next
        'Loop all element in LinkedList of main.trainList and add them to ListBox1 using comparation between element's.trainDate and DateTimePicker1's time
    End Sub

    Private Sub btn_edit_remove_Click(sender As Object, e As EventArgs) Handles btn_edit_remove.Click 'function to remove selected train from main.trainList
        Try
            Dim sel() As String = Split(ListBox1.SelectedItem) 'Declare new Array of string to collect temporary data of splitted string
            For Each train In main.trainList
                If train.trainDate = sel(0) AndAlso train.trainNo = sel(1) AndAlso train.trainSeat = sel(2) Then
                    main.trainList.Remove(train)
                    Exit For
                End If
            Next
            'Loop all element in LinkedList of main.trainList and remove that element if selected train in LinkedList ; using comparasion between trainDate , trainNo and trainSeat
            btn_edit_find_Click(Nothing, e) 'run function to refresh train list which show on the GUI
        Catch
            MsgBox("Please select train to remove") 'Catch if code above thrown an exeption
        End Try
    End Sub

End Class