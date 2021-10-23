Public Class reservation 'Class Main for Form Reservation
    Private Sub reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'This sub do automatically when form  "Reservation" load.
        cbox_reserve_train.Items.Clear() 'Clear all item in combobox of cbox_reserve_train
        For Each train In main.trainList
            If DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") = train.trainDate Then
                cbox_reserve_train.Items.Add(train.trainNo)
            End If
        Next
        'Loop all element in LinkedList of main.trainlist and add each element into cbox_reserve_train if date of element and date od DateTimePicker1 are same
    End Sub
    Private Sub btn_res_res_Click(sender As Object, e As EventArgs) Handles btn_res_res.Click
        Try
            'Try all below code and throw and exception if error
            main.reservedSeat.AddLast(New Reserved With {.traveldate = DateTimePicker1.Value.Date.ToString("yyyy/MM/dd"), .seatNumber = Val(cbox_reserve_seat_num.Text), .trainNumber = Val(cbox_reserve_train.Text), .destination = cbox_destination.Text, .price = txtbox_price.Text, .passengerName = txt_oassengername.Text})
            'Add reservation data to the last element of LinkedList of main.reservedSeat
            Dim result As DialogResult = MessageBox.Show("Confirm reservation ?", "Confirm", MessageBoxButtons.YesNo)
            'Declare new MessageBox for confirm reservation

            If result = DialogResult.Yes Then 'if user clicked Yes
                For Each block In main.reservedSeat
                    If DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") = block.traveldate AndAlso block.trainNumber = cbox_reserve_train.Text Then
                        cbox_reserve_seat_num.Items.Remove(block.seatNumber)
                    End If
                Next
                'Loop all element in LinkedList main.reservedSeat and remove all of them from item of cbox_reserve_seat_num if date and train ID are same
            End If
        Catch
            MsgBox("Invalid or Incomplete data please try again") 'Catch if code above throw an exeption
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        'When user change date in DateTimePicker1
        cbox_reserve_train.Items.Clear()
        'Clear all item of cbox_reserve_train
        For Each train In main.trainList
            If DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") = train.trainDate Then
                cbox_reserve_train.Items.Add(train.trainNo)
            End If
        Next
        'Loop all element in LinkedList main.trainList and add them into item of cbox_reserve_train if date of the train same as date selected
    End Sub

    Private Sub cbox_reserve_train_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_reserve_train.SelectedIndexChanged
        'When changed cbox_reserve_train selected index
        cbox_reserve_seat_num.Items.Clear()
        cbox_destination.Items.Clear()
        'Clear all item of cbox_reserve_seat_num and cbox_destination
        For Each train In main.trainList
            If cbox_reserve_train.Text = train.trainNo Then
                For seat = 1 To train.trainSeat
                    cbox_reserve_seat_num.Items.Add(seat)
                Next
                For Each dest In train.destination
                    cbox_destination.Items.Add(dest)
                Next
            End If
        Next
        'Loop all element in LinkedList main.trainList then add seat and destination to item of cbox_reserve_seat_num.Items and cbox_destination.Items 
        'If given Then Train ID are same Of train ID data In LinkedList
        For Each block In main.reservedSeat
            If DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") = block.traveldate Then
                If block.trainNumber = cbox_reserve_train.Text Then
                    cbox_reserve_seat_num.Items.Remove(block.seatNumber)
                End If
            End If
        Next
        'Loop all element in LinkedList main.reservedSeat then remove item from cbox_reserve_seat_num if given trainDate and trainNumber same as reserved train in reserved list

    End Sub

    Private Sub cbox_destination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_destination.SelectedIndexChanged
        'If changed cbox_destination selected index
        For Each train In main.trainList
            'Loop all element in LinkedList main.trainList
            If cbox_reserve_train.Text = train.trainNo Then
                'If loop-element's trainNo same as given value in cbox_reserve_train then
                For Each price In train.destination
                    If price = cbox_destination.Text Then
                        txtbox_price.Text = train.destinationPrice(train.destination.IndexOf(price))

                    End If
                Next
                'Loop all element in list of LinkedList's element main.trainList.destination then set the txtbox_price's value to same loop-index
            End If
        Next

    End Sub
End Class