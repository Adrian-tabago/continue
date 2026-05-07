<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtBoxPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblNameLogin = New System.Windows.Forms.Label()
        Me.pnlcard = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlcard.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("SimSun", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.Black
        Me.lblPass.Location = New System.Drawing.Point(20, 339)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(147, 27)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(67, 298)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(332, 31)
        Me.txtUsername.TabIndex = 4
        '
        'txtBoxPass
        '
        Me.txtBoxPass.BackColor = System.Drawing.Color.White
        Me.txtBoxPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxPass.ForeColor = System.Drawing.Color.Black
        Me.txtBoxPass.Location = New System.Drawing.Point(67, 369)
        Me.txtBoxPass.Name = "txtBoxPass"
        Me.txtBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxPass.Size = New System.Drawing.Size(332, 31)
        Me.txtBoxPass.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(48, 420)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(363, 60)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblNameLogin
        '
        Me.lblNameLogin.AutoSize = True
        Me.lblNameLogin.Font = New System.Drawing.Font("SimSun", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameLogin.ForeColor = System.Drawing.Color.Black
        Me.lblNameLogin.Location = New System.Drawing.Point(20, 268)
        Me.lblNameLogin.Name = "lblNameLogin"
        Me.lblNameLogin.Size = New System.Drawing.Size(87, 27)
        Me.lblNameLogin.TabIndex = 2
        Me.lblNameLogin.Text = "Name:"
        '
        'pnlcard
        '
        Me.pnlcard.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlcard.Controls.Add(Me.PictureBox2)
        Me.pnlcard.Controls.Add(Me.Label4)
        Me.pnlcard.Controls.Add(Me.Label3)
        Me.pnlcard.Controls.Add(Me.PictureBox3)
        Me.pnlcard.Controls.Add(Me.Panel2)
        Me.pnlcard.Controls.Add(Me.Panel1)
        Me.pnlcard.Controls.Add(Me.Label1)
        Me.pnlcard.Controls.Add(Me.PictureBox1)
        Me.pnlcard.Controls.Add(Me.Label2)
        Me.pnlcard.Controls.Add(Me.lblNameLogin)
        Me.pnlcard.Controls.Add(Me.btnLogin)
        Me.pnlcard.Controls.Add(Me.lblPass)
        Me.pnlcard.Controls.Add(Me.txtBoxPass)
        Me.pnlcard.Controls.Add(Me.txtUsername)
        Me.pnlcard.Location = New System.Drawing.Point(454, 63)
        Me.pnlcard.Name = "pnlcard"
        Me.pnlcard.Size = New System.Drawing.Size(461, 542)
        Me.pnlcard.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.Image = Global.caseStudy.My.Resources.Resources.User_Interface_Login_icon
        Me.PictureBox2.Location = New System.Drawing.Point(157, 439)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(108, 512)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "@2026 Barangay Complaint System."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(188, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 32)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "SYSTEM"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.caseStudy.My.Resources.Resources.circle_icon
        Me.PictureBox3.Location = New System.Drawing.Point(226, 195)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(259, 206)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(195, 2)
        Me.Panel2.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(9, 205)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 2)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(53, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "We are here to serve and make things better."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.caseStudy.My.Resources.Resources.user_icon_in_flat_style_person_icon_client_symbol_vector
        Me.PictureBox1.Location = New System.Drawing.Point(177, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(96, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "BARANGAY COMPLAINT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.caseStudy.My.Resources.Resources._83a28586_5dc6_4343_8466_a5ce4155665f2
        Me.ClientSize = New System.Drawing.Size(1370, 720)
        Me.Controls.Add(Me.pnlcard)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.pnlcard.ResumeLayout(False)
        Me.pnlcard.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtBoxPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblNameLogin As Label
    Friend WithEvents pnlcard As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
