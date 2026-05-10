Public Class Form1
    Public Shared usernameGlobal As String = ""


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text.Equals("") Or txtBoxPass.Text.Equals("") Then

            MessageBox.Show("Please fill in all fields")

        Else
            Form1.usernameGlobal = txtUsername.Text

            'OPEN FORM2
            Form2.Show()

            Me.Hide()

        End If

    End Sub

    Private Sub pnlcard_Paint(sender As Object, e As PaintEventArgs) Handles pnlcard.Paint

    End Sub

    Private Sub lblNameLogin_Click(sender As Object, e As EventArgs) Handles lblNameLogin.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
