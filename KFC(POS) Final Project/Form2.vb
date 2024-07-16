Public Class Form2
    Public Property ItemName As String
    Public Property ItemPrice As String
    Public Property ItemQuantity As String
    Public Property ValuesUpdated As Boolean = False
    Public Property SubTotal As String



    Public Sub New(ByVal PriceText As String, ByVal Item As String, ByVal clickedButton As Button)
        InitializeComponent()
        ItemName = Item
        ItemPrice = PriceText
        ItemQuantity = "1"
    End Sub

    Public Sub New()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Price.Text = ItemPrice
        Quantity.Text = ItemQuantity
        Price.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(Quantity.Text) OrElse Not IsNumeric(Quantity.Text) OrElse Convert.ToDouble(Quantity.Text) <= 0 Then
            MsgBox("Invalid Input.", MsgBoxStyle.Critical)
        Else
            ItemQuantity = Quantity.Text
            ItemPrice = Price.Text
            ValuesUpdated = True

            Me.Close()
        End If
    End Sub
End Class
