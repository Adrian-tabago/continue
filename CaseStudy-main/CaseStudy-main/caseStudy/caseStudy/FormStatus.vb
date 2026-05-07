Public Class FormStatus

    Private Sub FormStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbUpStatus.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtBoxPass.Clear()
        Form2.txtBoxAddress.Clear()
        Form2.txtBoxContact.Clear()
        Form2.txtBoxDesc.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim index As Integer = dataStatus.CurrentCell.ColumnIndex
        If Index = 4 Then
            dataStatus.CurrentCell.Value = CmbUpStatus.Text

        Else
            MessageBox.Show("You can't change that value")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            dataStatus.Rows.RemoveAt(dataStatus.CurrentRow.Index)
        Catch ex As Exception
            MessageBox.Show("Please select a row to delete")
        End Try

    End Sub

    Private Sub dataStatus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataStatus.CellContentClick

    End Sub
End Class