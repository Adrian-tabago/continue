Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdBtnOthers.Checked = True
        'txtBoxComOthers.ReadOnly = True

        If rdBtnOthers.Checked Then
            txtBoxComOthers.ReadOnly = False
        Else
            txtBoxComOthers.ReadOnly = True
        End If


    End Sub
    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        txtname.Text = Form1.usernameGlobal

    End Sub

    'Private Sub rdBtnOthers_CheckedChanged(sender As Object, e As EventArgs) Handles rdBtnOthers.CheckedChanged

    '    If rdBtnOthers.Checked Then
    '        txtBoxComOthers.ReadOnly = False
    '    Else
    '        txtBoxComOthers.Clear()
    '    End If

    'End Sub

    Public complaintRow As Integer = -1

    Private Sub btnFComplaint_Click(sender As Object, e As EventArgs) Handles btnFComplaint.Click

        Dim complaintType As String = ""
        Dim dateToday As Date = Date.Now

        'VALIDATION
        If txtBoxAddress.Text = "" Or
       txtBoxContact.Text = "" Or
       txtBoxDesc.Text = "" Then

            If txtBoxComOthers.Text = "" Then
                MessageBox.Show("Please fill in the empty fields")
                Exit Sub
            End If

        End If

        'GET COMPLAINT TYPE
        If rdBtnOthers.Checked Then
            complaintType = txtBoxComOthers.Text

        ElseIf rdBtnDispute.Checked Then
            complaintType = "Dispute"

        ElseIf rdNoise.Checked Then
            complaintType = "Noise"

        ElseIf rdInfrastructure.Checked Then
            complaintType = "Infrastructure"
        End If

        'FIND IF USER ALREADY EXISTS
        Dim foundRow As Integer = -1

        For Each row As DataGridViewRow In FormStatus.dataStatus.Rows

            If row.IsNewRow Then Continue For

            If row.Cells(0).Value.ToString() = Form1.usernameGlobal Then
                foundRow = row.Index
                Exit For
            End If

        Next

        'ADD OR UPDATE
        If foundRow = -1 Then

            'ADD NEW ROW
            FormStatus.dataStatus.Rows.Add(
            Form1.usernameGlobal,
            txtBoxAddress.Text,
            txtBoxContact.Text,
            complaintType,
            "Pending",
            dateToday
        )

            MessageBox.Show("Complaint Added")

        Else

            'UPDATE EXISTING ROW
            FormStatus.dataStatus.Rows(foundRow).Cells(1).Value = txtBoxAddress.Text
            FormStatus.dataStatus.Rows(foundRow).Cells(2).Value = txtBoxContact.Text
            FormStatus.dataStatus.Rows(foundRow).Cells(3).Value = complaintType
            FormStatus.dataStatus.Rows(foundRow).Cells(4).Value = "Pending"
            FormStatus.dataStatus.Rows(foundRow).Cells(5).Value = dateToday

            MessageBox.Show("Complaint Updated")

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Dim frmLogin As New Form1

    End Sub

    Private Sub btnComplain_MouseEnter(sender As Object, e As EventArgs) Handles btnComplain.MouseEnter
        btnComplain.BackColor = Color.White
    End Sub

    Private Sub btnComplain_MouseLeave(sender As Object, e As EventArgs) Handles btnComplain.MouseLeave
        btnComplain.BackColor = Color.White
    End Sub

    Private Sub btnComplain_Click(sender As Object, e As EventArgs) Handles btnComplain.Click
        FormStatus.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormStatus.Show()
        Me.Hide()
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtBoxPass.Clear()
        txtBoxAddress.Clear()
        txtBoxContact.Clear()
        txtBoxDesc.Clear()
    End Sub
End Class