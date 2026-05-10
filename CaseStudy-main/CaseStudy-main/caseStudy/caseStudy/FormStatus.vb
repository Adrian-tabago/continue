Imports System.Xml

Public Class FormStatus

    Public Shared pendings As Integer = 0
    Public Shared under As Integer = 0
    Public Shared resolve As Integer = 0
    Private Sub FormStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbUpStatus.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub




    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim index As Integer = dataStatus.CurrentCell.ColumnIndex
        Dim rowIndex As Integer = dataStatus.CurrentCell.RowIndex

        If index = 4 Then

            'UPDATE NORMAL GRID
            dataStatus.CurrentCell.Value = CmbUpStatus.Text

            'UPDATE OVER GRID TOO
            Form2.over.Rows(rowIndex).Cells(4).Value = CmbUpStatus.Text



            'RESET COUNTERS (MUST BE OUTSIDE LOOP)
            Form2.Pendings = 0
            under = 0
            resolve = 0

            'LOOP ALL ROWS
            For Each row As DataGridViewRow In dataStatus.Rows

                If row.IsNewRow Then Continue For

                Dim status As String = Convert.ToString(row.Cells(4).Value)

                If status = "Pending" Then
                    Form2.Pendings += 1

                ElseIf status = "Under Investigation" Then
                    under += 1

                ElseIf status = "Resolved" Then
                    resolve += 1
                End If

            Next

        Else
            MessageBox.Show("You can't change that value")
        End If

        Label1.Text = resolve

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            dataStatus.Rows.RemoveAt(dataStatus.CurrentRow.Index)
        Catch ex As Exception
            MessageBox.Show("Please select a row to delete")
        End Try

    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtBoxPass.Clear()
        Form2.txtBoxAddress.Clear()
        Form2.txtBoxContact.Clear()
        Form2.txtBoxDesc.Clear()
    End Sub

    Private Sub btnComplain_Click_1(sender As Object, e As EventArgs) Handles btnComplain.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormSearch.Show()
        Me.Hide()
    End Sub

    Private Sub dataStatus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataStatus.CellContentClick

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class