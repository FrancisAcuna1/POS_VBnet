<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.Ok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.BackColor = System.Drawing.Color.ForestGreen
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBox1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.ForeColor = System.Drawing.Color.Black
        Me.textBox1.Location = New System.Drawing.Point(28, 51)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(262, 39)
        Me.textBox1.TabIndex = 0
        '
        'Ok
        '
        Me.Ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ok.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ok.ForeColor = System.Drawing.Color.White
        Me.Ok.Location = New System.Drawing.Point(28, 151)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(262, 43)
        Me.Ok.TabIndex = 1
        Me.Ok.Text = "Ok"
        Me.Ok.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your Change Is"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Thanks for Pruchasing..."
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 218)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.textBox1)
        Me.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textBox1 As TextBox
    Friend WithEvents Ok As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
