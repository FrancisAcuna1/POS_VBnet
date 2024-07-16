
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label77.Text = Date.Now.ToString("MMM dd, yyyy hh:mm:ss")
    End Sub

    Private Sub Item_Click(sender As Object, e As EventArgs) Handles Button20.Click, Button19.Click, Button18.Click, Button9.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button25.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button10.Click, Button27.Click, Button28.Click, Button29.Click, Button26.Click, Button30.Click, Button31.Click, Button32.Click
        Dim Item As String = GetPriceText(sender)
        Dim PriceText As String = GetItemText(sender)
        Dim form2Instance As New Form2(Item, PriceText, DirectCast(sender, Button))

        form2Instance.ShowDialog()
        If form2Instance.ValuesUpdated Then
            Dim Qty As Integer = Integer.Parse(form2Instance.Quantity.Text)
            Dim Price As Decimal = Decimal.Parse(form2Instance.Price.Text)
            Dim Subtotal As String = ($"{Qty * Price}.00")
            DataGridView1.Rows.Add(form2Instance.ItemName, Price, Qty, Subtotal)

            Dim TotalPayable As Decimal = 0
            For i As Integer = 0 To DataGridView1.RowCount - 1
                Dim CellSubTotal As Decimal = Val(DataGridView1.Rows(i).Cells(3).Value)
                TotalPayable += CellSubTotal
            Next

            Dim CountItem As Integer = DataGridView1.RowCount
            Label76.Text = CountItem
            Label73.Text = ($"₱{TotalPayable}.00")

        End If
    End Sub

    Private Function GetPriceText(button As Button) As String
        Select Case button.Name
            Case "Button20"
                Return Label45.Text
            Case "Button19"
                Return Label43.Text
            Case "Button18"
                Return Label41.Text
            Case "Button9"
                Return Label21.Text
            Case "Button24"
                Return Label54.Text
            Case "Button23"
                Return Label52.Text
            Case "Button22"
                Return Label50.Text
            Case "Button21"
                Return Label48.Text
            Case "Button25"
                Return Label56.Text
            Case "Button11"
                Return Label27.Text
            Case "Button12"
                Return Label29.Text
            Case "Button13"
                Return Label31.Text
            Case "Button14"
                Return Label33.Text
            Case "Button15"
                Return Label35.Text
            Case "Button16"
                Return Label37.Text
            Case "Button17"
                Return Label39.Text
            Case "Button10"
                Return Label23.Text
            Case "Button27"
                Return Label60.Text
            Case "Button28"
                Return Label62.Text
            Case "Button29"
                Return Label64.Text
            Case "Button26"
                Return Label58.Text
            Case "Button30"
                Return Label66.Text
            Case "Button31"
                Return Label68.Text
            Case "Button32"
                Return Label70.Text

        End Select
    End Function


    Private Function GetItemText(button As Button) As String
        Select Case button.Name
            Case "Button20"
                Return Label44.Text
            Case "Button19"
                Return Label42.Text
            Case "Button18"
                Return Label40.Text
            Case "Button9"
                Return Label20.Text
            Case "Button24"
                Return Label53.Text
            Case "Button23"
                Return Label51.Text
            Case "Button22"
                Return Label49.Text
            Case "Button21"
                Return Label47.Text
            Case "Button25"
                Return Label55.Text
            Case "Button11"
                Return Label26.Text
            Case "Button12"
                Return Label28.Text
            Case "Button13"
                Return Label30.Text
            Case "Button14"
                Return Label38.Text
            Case "Button15"
                Return Label36.Text
            Case "Button16"
                Return Label34.Text
            Case "Button17"
                Return Label32.Text
            Case "Button10"
                Return Label22.Text
            Case "Button27"
                Return Label59.Text
            Case "Button28"
                Return Label61.Text
            Case "Button29"
                Return Label63.Text
            Case "Button26"
                Return Label57.Text
            Case "Button30"
                Return Label65.Text
            Case "Button31"
                Return Label67.Text
            Case "Button32"
                Return Label69.Text

        End Select
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim form2Instance As New Form2()
        form2Instance.ShowDialog()

        If form2Instance.ValuesUpdated Then
            Dim Qty As String = Integer.Parse(form2Instance.Quantity.Text)
            Dim Price As String = Decimal.Parse(form2Instance.Price.Text)
            Dim Subtotal As String = Qty * Price
            DataGridView1.Rows.Add(form2Instance.ItemName, Price, Qty, Subtotal)
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If DataGridView1.Rows.Count > 0 Then

            Dim result = MsgBox("You want to Clear your Order list?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                Me.DataGridView1.Rows.Clear()
                Label76.Text = "0"
                Label73.Text = "₱0.00"
            End If
        Else
            MsgBox("There are no items in the order list!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If DataGridView1.Rows.Count > 0 Then
            Dim TotalPayable As Decimal = Decimal.Parse(Label73.Text.Replace("₱", "").Replace(",", ""))

            Dim form3Instance As New Form3(TotalPayable)
            form3Instance.ShowDialog()
        Else
            MsgBox("There are no items in the order list.", MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub ClearDataGridValue()
        DataGridView1.Rows.Clear()
        UpdateTotalAndItemCount()
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            DataGridView1.ClearSelection()
            DataGridView1.Rows(e.RowIndex).Selected = True
            ContextMenuStrip1.Show(DataGridView1, e.Location)
        End If
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result = MsgBox("Do you want to Delete this Item?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    DataGridView1.Rows.Remove(row)
                Next
                UpdateTotalAndItemCount()
            End If
        End If
    End Sub

    Private Sub UpdateTotalAndItemCount()
        Dim TotalPayable As Decimal = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim CellSubTotal As Decimal = Val(row.Cells(3).Value)
            TotalPayable += CellSubTotal
        Next
        Dim CountItem As Integer = DataGridView1.Rows.Count
        Label76.Text = CountItem
        Label73.Text = $"₱{TotalPayable}.00"
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim form5Instance As New Form5()
        form5Instance.ShowDialog()
    End Sub


End Class
