<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.btn_main_reserve = New System.Windows.Forms.Button()
        Me.btn_main_check = New System.Windows.Forms.Button()
        Me.btn_main_edit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_main_reserve
        '
        Me.btn_main_reserve.Location = New System.Drawing.Point(12, 12)
        Me.btn_main_reserve.Name = "btn_main_reserve"
        Me.btn_main_reserve.Size = New System.Drawing.Size(416, 62)
        Me.btn_main_reserve.TabIndex = 0
        Me.btn_main_reserve.Text = "Reservation"
        Me.btn_main_reserve.UseVisualStyleBackColor = True
        '
        'btn_main_check
        '
        Me.btn_main_check.Location = New System.Drawing.Point(12, 80)
        Me.btn_main_check.Name = "btn_main_check"
        Me.btn_main_check.Size = New System.Drawing.Size(416, 62)
        Me.btn_main_check.TabIndex = 1
        Me.btn_main_check.Text = "Reserved List"
        Me.btn_main_check.UseVisualStyleBackColor = True
        '
        'btn_main_edit
        '
        Me.btn_main_edit.Location = New System.Drawing.Point(12, 148)
        Me.btn_main_edit.Name = "btn_main_edit"
        Me.btn_main_edit.Size = New System.Drawing.Size(416, 62)
        Me.btn_main_edit.TabIndex = 2
        Me.btn_main_edit.Text = "Edit Train"
        Me.btn_main_edit.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 221)
        Me.Controls.Add(Me.btn_main_edit)
        Me.Controls.Add(Me.btn_main_check)
        Me.Controls.Add(Me.btn_main_reserve)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_main_reserve As Button
    Friend WithEvents btn_main_check As Button
    Friend WithEvents btn_main_edit As Button
End Class
