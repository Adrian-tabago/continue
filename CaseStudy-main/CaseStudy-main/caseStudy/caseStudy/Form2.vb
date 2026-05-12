Public Class Form2
    Public Shared Pendings As Integer = 0
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

        ' VALIDATION
        If txtBoxAddress.Text = "" Or
   txtBoxContact.Text = "" Or
   txtBoxDesc.Text = "" Then

            MessageBox.Show("Please fill in all required fields")
            Exit Sub
        End If

        If rdBtnOthers.Checked And txtBoxComOthers.Text = "" Then
            MessageBox.Show("Please specify complaint type")
            Exit Sub
        End If

        ' GET COMPLAINT TYPE
        If rdBtnOthers.Checked Then
            complaintType = txtBoxComOthers.Text

        ElseIf rdBtnDispute.Checked Then
            complaintType = "Dispute"

        ElseIf rdNoise.Checked Then
            complaintType = "Noise"

        ElseIf rdInfrastructure.Checked Then
            complaintType = "Infrastructure"
        End If

        ' FIND USER
        Dim foundRow As Integer = -1

        For Each row As DataGridViewRow In FormStatus.dataStatus.Rows

            If row.IsNewRow Then Continue For

            If row.Cells(0).Value.ToString() = Form1.usernameGlobal Then
                foundRow = row.Index
                Exit For
            End If

        Next

        Dim overdueStatus As String = "Not Overdue"

        If foundRow = -1 Then

            FormStatus.dataStatus.Rows.Add(
        Form1.usernameGlobal,
        txtBoxAddress.Text,
        txtBoxContact.Text,
        complaintType,
        "Pending",
        dateToday
    )

            FormDashboard.over.Rows.Add(
        Form1.usernameGlobal,
        txtBoxAddress.Text,
        txtBoxContact.Text,
        complaintType,
        "Pending",
        dateToday,
        overdueStatus
    )

            MessageBox.Show("Complaint Added")

        Else

            FormStatus.dataStatus.Rows(foundRow).Cells(0).Value = Form1.usernameGlobal
            FormStatus.dataStatus.Rows(foundRow).Cells(1).Value = txtBoxAddress.Text
            FormStatus.dataStatus.Rows(foundRow).Cells(2).Value = txtBoxContact.Text
            FormStatus.dataStatus.Rows(foundRow).Cells(3).Value = complaintType
            FormStatus.dataStatus.Rows(foundRow).Cells(4).Value = "Pending"
            FormStatus.dataStatus.Rows(foundRow).Cells(5).Value = dateToday

            FormDashboard.over.Rows(foundRow).Cells(0).Value = Form1.usernameGlobal
            FormDashboard.over.Rows(foundRow).Cells(1).Value = txtBoxAddress.Text
            FormDashboard.over.Rows(foundRow).Cells(2).Value = txtBoxContact.Text
            FormDashboard.over.Rows(foundRow).Cells(3).Value = complaintType
            FormDashboard.over.Rows(foundRow).Cells(4).Value = "Pending"
            FormDashboard.over.Rows(foundRow).Cells(5).Value = dateToday
            FormDashboard.over.Rows(foundRow).Cells(6).Value = overdueStatus

            MessageBox.Show("Complaint Updated")

        End If

        Pendings += 1
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Dim frmLogin As New Form1

    End Sub

    Private Sub btnComplain_MouseEnter(sender As Object, e As EventArgs)
        btnComplain.BackColor = Color.White
    End Sub

    Private Sub btnComplain_MouseLeave(sender As Object, e As EventArgs)
        btnComplain.BackColor = Color.White
    End Sub

    Private Sub btnComplain_Click(sender As Object, e As EventArgs)
        FormStatus.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        FormStatus.Show()
        Me.Hide()
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtBoxPass.Clear()
        txtBoxAddress.Clear()
        txtBoxContact.Clear()
        txtBoxDesc.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FormSearch.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub label_Click(sender As Object, e As EventArgs) Handles label.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtBoxPass.Clear()
        txtBoxAddress.Clear()
        txtBoxContact.Clear()
        txtBoxDesc.Clear()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnComplain.Click
        FormStatus.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        FormStatus.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FormSearch.Show()
        Me.Hide()
    End Sub

    Private Sub rdNoise_CheckedChanged(sender As Object, e As EventArgs) Handles rdNoise.CheckedChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtBoxPass.Clear()

        txtBoxAddress.Clear()
        txtBoxContact.Clear()
        txtBoxDesc.Clear()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub rdBtnOthers_CheckedChanged(sender As Object, e As EventArgs) Handles rdBtnOthers.CheckedChanged

    End Sub

    Private Sub over_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub
End Class