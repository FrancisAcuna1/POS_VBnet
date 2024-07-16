<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TotalAmount = New System.Windows.Forms.TextBox()
        Me.Cash = New System.Windows.Forms.TextBox()
        Me.Ok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TotalAmount
        '
        Me.TotalAmount.BackColor = System.Drawing.Color.Silver
        Me.TotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalAmount.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount.Location = New System.Drawing.Point(26, 63)
        Me.TotalAmount.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.ReadOnly = True
        Me.TotalAmount.Size = New System.Drawing.Size(288, 37)
        Me.TotalAmount.TabIndex = 0
        Me.TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cash
        '
        Me.Cash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cash.Location = New System.Drawing.Point(26, 145)
        Me.Cash.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(288, 37)
        Me.Cash.TabIndex = 1
        Me.Cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ok
        '
        Me.Ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ok.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ok.ForeColor = System.Drawing.Color.White
        Me.Ok.Location = New System.Drawing.Point(19, 207)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(157, 43)
        Me.Ok.TabIndex = 2
        Me.Ok.Text = "Ok"
        Me.Ok.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CASH"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(182, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 43)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(344, 266)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.Cash)
        Me.Controls.Add(Me.TotalAmount)
        Me.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Amount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TotalAmount As TextBox
    Friend WithEvents Cash As TextBox
    Friend WithEvents Ok As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
