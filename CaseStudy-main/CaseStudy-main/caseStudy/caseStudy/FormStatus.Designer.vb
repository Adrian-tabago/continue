<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStatus
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStatus))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dataStatus = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmbUpStatus = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dataStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(1121, 566)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(148, 49)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dataStatus
        '
        Me.dataStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataStatus.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dataStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataStatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataStatus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataStatus.ColumnHeadersHeight = 40
        Me.dataStatus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Status, Me.Column5})
        Me.dataStatus.EnableHeadersVisualStyles = False
        Me.dataStatus.GridColor = System.Drawing.SystemColors.GrayText
        Me.dataStatus.Location = New System.Drawing.Point(306, 119)
        Me.dataStatus.MultiSelect = False
        Me.dataStatus.Name = "dataStatus"
        Me.dataStatus.ReadOnly = True
        Me.dataStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataStatus.RowHeadersVisible = False
        Me.dataStatus.RowHeadersWidth = 62
        Me.dataStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataStatus.Size = New System.Drawing.Size(963, 390)
        Me.dataStatus.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Name"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Address"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Contact"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Category"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Status
        '
        Me.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 8
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Date"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CmbUpStatus
        '
        Me.CmbUpStatus.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CmbUpStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUpStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUpStatus.FormattingEnabled = True
        Me.CmbUpStatus.Items.AddRange(New Object() {"Pending", "Under Investigation", "Resolved"})
        Me.CmbUpStatus.Location = New System.Drawing.Point(878, 515)
        Me.CmbUpStatus.Name = "CmbUpStatus"
        Me.CmbUpStatus.Size = New System.Drawing.Size(193, 45)
        Me.CmbUpStatus.TabIndex = 21
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Green
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(1121, 510)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(148, 50)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "Update Status"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(950, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox11)
        Me.Panel1.Controls.Add(Me.PictureBox13)
        Me.Panel1.Controls.Add(Me.PictureBox14)
        Me.Panel1.Controls.Add(Me.PictureBox15)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(1, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 753)
        Me.Panel1.TabIndex = 70
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(6, 550)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(42, 35)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 60
        Me.PictureBox6.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(6, 29)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(42, 35)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 70
        Me.PictureBox11.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(6, 84)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(42, 35)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 69
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(6, 147)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(42, 35)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 68
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(6, 211)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(42, 35)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 60
        Me.PictureBox15.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(23, 540)
        Me.Button2.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 45)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Window
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(23, 210)
        Me.Button3.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 36)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Window
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(13, 146)
        Me.Button5.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(157, 36)
        Me.Button5.TabIndex = 61
        Me.Button5.Text = "Status"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.Window
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.Location = New System.Drawing.Point(34, 84)
        Me.Button10.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(157, 45)
        Me.Button10.TabIndex = 59
        Me.Button10.Text = "Summary"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.SystemColors.Window
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.Location = New System.Drawing.Point(34, 20)
        Me.Button11.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(157, 46)
        Me.Button11.TabIndex = 57
        Me.Button11.Text = "Complain"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.Color.Silver
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(34, 525)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(214, 3)
        Me.FlowLayoutPanel1.TabIndex = 53
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.PictureBox26)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Location = New System.Drawing.Point(1, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1384, 109)
        Me.Panel4.TabIndex = 71
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(145, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(989, 65)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "E-Reklamo Baranggay Complaint System"
        '
        'PictureBox26
        '
        Me.PictureBox26.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox26.Image = Global.caseStudy.My.Resources.Resources._809ad8b0_c11f_4f72_a430_4c9186257b0b_removebg_preview
        Me.PictureBox26.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(136, 122)
        Me.PictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox26.TabIndex = 44
        Me.PictureBox26.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(36, 52)
        Me.Button1.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(465, 46)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Efficient + Transparent + Accessible"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormStatus
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1281, 717)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.CmbUpStatus)
        Me.Controls.Add(Me.dataStatus)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "FormStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormStatus"
        CType(Me.dataStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As Button
    Friend WithEvents dataStatus As DataGridView
    Friend WithEvents CmbUpStatus As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox26 As PictureBox
    Friend WithEvents Button1 As Button
End Class
