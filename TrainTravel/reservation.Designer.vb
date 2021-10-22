<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtbox_price = New System.Windows.Forms.TextBox()
        Me.cbox_reserve_seat_num = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbox_destination = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbox_reserve_train = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_oassengername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtbox_price
        '
        Me.txtbox_price.Enabled = False
        Me.txtbox_price.Location = New System.Drawing.Point(12, 194)
        Me.txtbox_price.Name = "txtbox_price"
        Me.txtbox_price.Size = New System.Drawing.Size(259, 20)
        Me.txtbox_price.TabIndex = 1
        '
        'cbox_reserve_seat_num
        '
        Me.cbox_reserve_seat_num.FormattingEnabled = True
        Me.cbox_reserve_seat_num.Location = New System.Drawing.Point(12, 113)
        Me.cbox_reserve_seat_num.Name = "cbox_reserve_seat_num"
        Me.cbox_reserve_seat_num.Size = New System.Drawing.Size(259, 21)
        Me.cbox_reserve_seat_num.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seat Number"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 222)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Make Reservation"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbox_destination
        '
        Me.cbox_destination.FormattingEnabled = True
        Me.cbox_destination.Location = New System.Drawing.Point(12, 153)
        Me.cbox_destination.Name = "cbox_destination"
        Me.cbox_destination.Size = New System.Drawing.Size(259, 21)
        Me.cbox_destination.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Destination"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 34)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(259, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'cbox_reserve_train
        '
        Me.cbox_reserve_train.FormattingEnabled = True
        Me.cbox_reserve_train.Location = New System.Drawing.Point(12, 74)
        Me.cbox_reserve_train.Name = "cbox_reserve_train"
        Me.cbox_reserve_train.Size = New System.Drawing.Size(259, 21)
        Me.cbox_reserve_train.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Train No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fare"
        '
        'txt_oassengername
        '
        Me.txt_oassengername.Location = New System.Drawing.Point(12, 236)
        Me.txt_oassengername.Name = "txt_oassengername"
        Me.txt_oassengername.Size = New System.Drawing.Size(259, 20)
        Me.txt_oassengername.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Passenger Name"
        '
        'reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 276)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_oassengername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbox_reserve_train)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbox_destination)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbox_reserve_seat_num)
        Me.Controls.Add(Me.txtbox_price)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "reservation"
        Me.Text = "Reservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbox_price As TextBox
    Friend WithEvents cbox_reserve_seat_num As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cbox_destination As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbox_reserve_train As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_oassengername As TextBox
    Friend WithEvents Label1 As Label
End Class
