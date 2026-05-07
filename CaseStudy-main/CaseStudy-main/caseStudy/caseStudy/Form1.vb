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
End Class
