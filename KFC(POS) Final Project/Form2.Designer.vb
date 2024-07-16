<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price:"
        '
        'Price
        '
        Me.Price.BackColor = System.Drawing.Color.Silver
        Me.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Price.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.Location = New System.Drawing.Point(29, 58)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(288, 37)
        Me.Price.TabIndex = 1
        Me.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(29, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Add Item"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Quantity
        '
        Me.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Quantity.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity.Location = New System.Drawing.Point(29, 139)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(288, 37)
        Me.Quantity.TabIndex = 6
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(166, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(351, 258)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Quantity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Price As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Quantity As TextBox
    Friend WithEvents Button1 As Button
End Class
