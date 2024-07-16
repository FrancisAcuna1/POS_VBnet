Public Class Form3
    Public Property totalPayable As Decimal
    Public Property CashAmount As String
    Public Property Change As Decimal
    Public Sub New(ByVal totalPayable As Decimal)
        InitializeComponent()
        Me.totalPayable = totalPayable
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalAmount.Text = totalPayable
        TotalAmount.ReadOnly = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        If String.IsNullOrEmpty(Cash.Text) OrElse Not IsNumeric(Cash.Text) OrElse Convert.ToDouble(Cash.Text) <= 0 Then
            MsgBox("Invalid Input.", MsgBoxStyle.Critical)

        ElseIf Convert.ToDouble(Cash.Text) < Convert.ToDouble(TotalAmount.Text) Then
            MsgBox("Insuffecient Amount of Cash.", MsgBoxStyle.Critical)

        Else
            totalPayable = TotalAmount.Text
            CashAmount = Cash.Text
            Dim Change As Decimal = Decimal.Parse(CashAmount - totalPayable)
            Me.Hide()

            Dim form4Instance As New Form4(Change, CashAmount, totalPayable)
            form4Instance.ShowDialog()



        End If
    End Sub
End Class