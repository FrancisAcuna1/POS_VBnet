Imports MySql.Data.MySqlClient
Public Class Form4
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private change As Decimal
    Public Property TotalChange As Decimal
    Public Property CashAmount As String
    Public Property TotalPayable As String


    Public Sub New(change As Decimal, cashAmount As String, totalPayable As String)
        InitializeComponent()
        Me.TotalChange = change
        Me.CashAmount = cashAmount
        Me.TotalPayable = totalPayable
    End Sub



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Use Me.TotalChange wherever you want to access the property value
        Dim ChangeAmount As String = ($"₱{TotalChange}.00")
        textBox1.Text = ChangeAmount
        textBox1.ReadOnly = True
    End Sub


    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=kfc(POS)_db"

        Dim Reader As MySqlDataReader
        Dim DateSales As String = Date.Now()
        Dim AmountPayable As String = TotalPayable
        Dim changeamount As String = TotalChange
        Dim CashTendered As String = CashAmount
        Try
            Dim sql As String = "INSERT INTO `products`(`date_of_sales`, `Amount_Payable`, `Cash_Tendered`, `Change_Amount`) VALUES ('" & DateSales & "','" & AmountPayable & "','" & CashTendered & "','" & changeamount & "')"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            Reader = COMMAND.ExecuteReader
            conn.Close()
            Dim form1Instance As Form1 = DirectCast(Application.OpenForms("Form1"), Form1)
            If form1Instance IsNot Nothing Then
                form1Instance.ClearDataGridValue()
            End If


            MsgBox("Item's Successfully Purchase!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Unable to Connect Database, Upload the Mysql file first in Localhost Php MyAdmin!", MsgBoxStyle.Information)
            conn.Close()
        End Try


        Me.Close()
    End Sub

End Class


