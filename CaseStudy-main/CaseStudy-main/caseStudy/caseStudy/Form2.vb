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

    'Private Sub rdBtnOthers_CheckedChanged(sender As Object, e As EventArgs) Handles rdBtnOthers.CheckedChanged

    '    If rdBtnOthers.Checked Then
    '        txtBoxComOthers.ReadOnly = False
    '    Else
    '        txtBoxComOthers.Clear()
    '    End If

    'End Sub

    Private Sub btnFComplaint_Click(sender As Object, e As EventArgs) Handles btnFComplaint.Click
        Dim frmStatus As New FormStatus
        Dim dateToday As Date = Date.Now


        If txtBoxAddress.Text.Equals("") Or txtBoxContact.Text.Equals("") Or txtBoxDesc.Text.Equals("") Then
            If txtBoxComOthers.Text.Equals("") Then
                MessageBox.Show("Please fill in the empty fields")
            End If
        Else
            If rdBtnOthers.Checked Then
                FormStatus.dataStatus.Rows.Add(Form1.txtUsername.Text, txtBoxAddress.Text, txtBoxContact.Text, txtBoxComOthers.Text, "Pending", dateToday)
            ElseIf rdBtnDispute.Checked Then
                FormStatus.dataStatus.Rows.Add(Form1.txtUsername.Text, txtBoxAddress.Text, txtBoxContact.Text, "Dispute", "Pending", dateToday)

            ElseIf rdNoise.Checked Then
                FormStatus.dataStatus.Rows.Add(Form1.txtUsername.Text, txtBoxAddress.Text, txtBoxContact.Text, "Noise", "Pending", dateToday)

            ElseIf rdInfrastructure.Checked Then
                FormStatus.dataStatus.Rows.Add(Form1.txtUsername.Text, txtBoxAddress.Text, txtBoxContact.Text, "Infrastructure", "Pending", dateToday)
            End If
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub btnSearchFuntion_Click(sender As Object, e As EventArgs)


        MessageBox.Show("BUTTON WORKS")

    End Sub

    Private Sub btnSearchFunction_Click(sender As Object, e As EventArgs) Handles btnSearchFunction.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSearchFunction.Click
        MessageBox.Show("BUTTON WORKS")
    End Sub
End Class