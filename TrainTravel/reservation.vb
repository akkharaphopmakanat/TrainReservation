Public Class reservation
    Private Sub reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbox_reserve_train.Items.Clear()
        For Each train In main.trainList
            If DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") = train.trainDate Then
                cbox_reserve_train.Items.Add(train.trainNo)
            End If
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            main.reservedSeat.AddLast(New Reserved With {.traveldate = DateTimePicker1.Value.Date.ToString("yyyy/MM/dd"), .seatNumber = Val(cbox_reserve_seat_num.Text), .trainNumber = Val(cbox_reserve_train.Text), .destination = cbox_destination.Text, .price = txtbox_price.Text, .passengerName = txt_oassengername.Text})
            Dim result As DialogResult = MessageBox.Show("Confirm reservation ?", "Confirm", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                For Each block In main.reservedSeat
                    Console.WriteLine(block.traveldate & " " & block.trainNumber & " " & block.seatNumber & " " & block.passengerName)
                    If DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") = block.traveldate Then
                        If block.trainNumber = cbox_reserve_train.Text Then
                            cbox_reserve_seat_num.Items.Remove(block.seatNumber)
                        End If
                    End If
                Next
            End If
        Catch
            MsgBox("Invalid or Incomplete data please try again")
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        cbox_reserve_train.Items.Clear()
        For Each train In main.trainList
            If DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") = train.trainDate Then
                cbox_reserve_train.Items.Add(train.trainNo)
            End If
        Next
    End Sub

    Private Sub cbox_reserve_train_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_reserve_train.SelectedIndexChanged
        cbox_reserve_seat_num.Items.Clear()
        cbox_destination.Items.Clear()

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
        For Each block In main.reservedSeat
            If DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") = block.traveldate Then
                If block.trainNumber = cbox_reserve_train.Text Then
                    cbox_reserve_seat_num.Items.Remove(block.seatNumber)
                End If
            End If
        Next


    End Sub

    Private Sub cbox_destination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_destination.SelectedIndexChanged
        For Each train In main.trainList
            If cbox_reserve_train.Text = train.trainNo Then
                For Each price In train.destination
                    If price = cbox_destination.Text Then
                        txtbox_price.Text = train.destinationPrice(train.destination.IndexOf(price))

                    End If
                Next

            End If
        Next

    End Sub
End Class