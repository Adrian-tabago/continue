Imports System.Xml

Public Class FormStatus

    Public Shared pendings As Integer = 0
    Public Shared under As Integer = 0
    Public Shared resolve As Integer = 0
    Public Shared rejected As Integer = 0
    Private Sub FormStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbUpStatus.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub




    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim index As Integer = dataStatus.CurrentCell.ColumnIndex
        Dim rowIndex As Integer = dataStatus.CurrentCell.RowIndex

        If index = 4 Then

            'UPDATE MAIN GRID
            dataStatus.CurrentCell.Value = CmbUpStatus.Text

            'IF REJECTED -> REMOVE FROM FORM2 GRID
            If CmbUpStatus.Text = "Rejected" Then

                If rowIndex < FormDashboard.over.Rows.Count Then
                    FormDashboard.over.Rows.RemoveAt(rowIndex)
                End If

            Else

                'UPDATE FORM2 GRID
                FormDashboard.over.Rows(rowIndex).Cells(4).Value = CmbUpStatus.Text

            End If

            'RESET COUNTERS
            Form2.Pendings = 0
            under = 0
            resolve = 0

            'COUNT STATUSES
            For Each row As DataGridViewRow In dataStatus.Rows

                If row.IsNewRow Then Continue For

                Dim status As String = Convert.ToString(row.Cells(4).Value)

                If status = "Pending" Then
                    Form2.Pendings += 1

                ElseIf status = "Under Investigation" Then
                    under += 1

                ElseIf status = "Resolved" Then
                    resolve += 1

                ElseIf status = "Rejected" Then
                    rejected += 1
                End If

            Next

        Else
            MessageBox.Show("You can't change that value")
        End If

        Label1.Text = resolve.ToString()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            dataStatus.Rows.RemoveAt(dataStatus.CurrentRow.Index)
        Catch ex As Exception
            MessageBox.Show("Please select a row to delete")
        End Try

    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtBoxPass.Clear()
        Form2.txtBoxAddress.Clear()
        Form2.txtBoxContact.Clear()
        Form2.txtBoxDesc.Clear()
    End Sub

    Private Sub btnComplain_Click_1(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FormSearch.Show()
        Me.Hide()
    End Sub

    Private Sub dataStatus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataStatus.CellContentClick

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        FormSearch.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtBoxPass.Clear()
        Form2.txtBoxAddress.Clear()
        Form2.txtBoxContact.Clear()
        Form2.txtBoxDesc.Clear()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form2.Show()
        Me.Hide()


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormSearch.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtBoxPass.Clear()
        Form2.txtBoxAddress.Clear()
        Form2.txtBoxContact.Clear()
        Form2.txtBoxDesc.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub
End Class