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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtBoxPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblNameLogin = New System.Windows.Forms.Label()
        Me.pnlcard = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlcard.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Font = New System.Drawing.Font("Yu Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.Black
        Me.lblPass.Location = New System.Drawing.Point(62, 339)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(118, 27)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(29, 298)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(370, 31)
        Me.txtUsername.TabIndex = 4
        '
        'txtBoxPass
        '
        Me.txtBoxPass.BackColor = System.Drawing.Color.White
        Me.txtBoxPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxPass.ForeColor = System.Drawing.Color.Black
        Me.txtBoxPass.Location = New System.Drawing.Point(29, 369)
        Me.txtBoxPass.Name = "txtBoxPass"
        Me.txtBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxPass.Size = New System.Drawing.Size(370, 31)
        Me.txtBoxPass.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(111, 429)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(208, 53)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblNameLogin
        '
        Me.lblNameLogin.AutoSize = True
        Me.lblNameLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblNameLogin.Font = New System.Drawing.Font("Yu Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameLogin.ForeColor = System.Drawing.Color.Black
        Me.lblNameLogin.Location = New System.Drawing.Point(62, 268)
        Me.lblNameLogin.Name = "lblNameLogin"
        Me.lblNameLogin.Size = New System.Drawing.Size(77, 27)
        Me.lblNameLogin.TabIndex = 2
        Me.lblNameLogin.Text = "Name:"
        '
        'pnlcard
        '
        Me.pnlcard.BackColor = System.Drawing.Color.Transparent
        Me.pnlcard.BackgroundImage = CType(resources.GetObject("pnlcard.BackgroundImage"), System.Drawing.Image)
        Me.pnlcard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlcard.Controls.Add(Me.PictureBox2)
        Me.pnlcard.Controls.Add(Me.PictureBox6)
        Me.pnlcard.Controls.Add(Me.lblNameLogin)
        Me.pnlcard.Controls.Add(Me.PictureBox5)
        Me.pnlcard.Controls.Add(Me.Label4)
        Me.pnlcard.Controls.Add(Me.Label3)
        Me.pnlcard.Controls.Add(Me.Panel1)
        Me.pnlcard.Controls.Add(Me.Label1)
        Me.pnlcard.Controls.Add(Me.Label2)
        Me.pnlcard.Controls.Add(Me.btnLogin)
        Me.pnlcard.Controls.Add(Me.lblPass)
        Me.pnlcard.Controls.Add(Me.txtBoxPass)
        Me.pnlcard.Controls.Add(Me.txtUsername)
        Me.pnlcard.Location = New System.Drawing.Point(-1, 1)
        Me.pnlcard.Name = "pnlcard"
        Me.pnlcard.Size = New System.Drawing.Size(435, 506)
        Me.pnlcard.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = Global.caseStudy.My.Resources.Resources._809ad8b0_c11f_4f72_a430_4c9186257b0b_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(142, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 124)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(29, 339)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 27)
        Me.PictureBox6.TabIndex = 19
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(29, 268)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 27)
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
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
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(156, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 32)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "SYSTEM"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(3, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 2)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(41, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "We are here to serve and make things better."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(70, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "BARANGAY COMPLAINT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(432, 505)
        Me.Controls.Add(Me.pnlcard)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.pnlcard.ResumeLayout(False)
        Me.pnlcard.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtBoxPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblNameLogin As Label
    Friend WithEvents pnlcard As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
