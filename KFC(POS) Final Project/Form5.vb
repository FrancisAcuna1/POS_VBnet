Imports MySql.Data.MySqlClient

Public Class Form5
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim SDA As MySqlDataAdapter
    Dim dbDataset As New DataTable
    Dim bSource As New BindingSource

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password='';database=kfc(POS)_db"

        Try
            MysqlConn.Open()
            Dim query As String = "SELECT * FROM `products`"
            Command = New MySqlCommand(query, MysqlConn)
            SDA = New MySqlDataAdapter(Command)
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Close()
        End Try
    End Sub
End Class
