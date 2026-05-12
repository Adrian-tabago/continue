<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSearch
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSearch))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cmbSearchCategory = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPending = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(767, 148)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(151, 35)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cmbSearchCategory
        '
        Me.cmbSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchCategory.FormattingEnabled = True
        Me.cmbSearchCategory.Items.AddRange(New Object() {"All", "Noise", "Dispute", "Infrastructure", "Others"})
        Me.cmbSearchCategory.Location = New System.Drawing.Point(613, 148)
        Me.cmbSearchCategory.Name = "cmbSearchCategory"
        Me.cmbSearchCategory.Size = New System.Drawing.Size(121, 29)
        Me.cmbSearchCategory.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.dgvPending)
        Me.Panel2.Controls.Add(Me.cmbSearchCategory)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Location = New System.Drawing.Point(307, 144)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(946, 452)
        Me.Panel2.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(718, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 134)
        Me.Panel1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(30, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 39)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Rejected"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Button7)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(493, 259)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 134)
        Me.Panel5.TabIndex = 9
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(31, 88)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(141, 29)
        Me.Button7.TabIndex = 0
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Under-Investigation"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(261, 259)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 134)
        Me.Panel4.TabIndex = 9
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(31, 88)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 29)
        Me.Button6.TabIndex = 0
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Resolved"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(31, 259)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 134)
        Me.Panel3.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(29, 88)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 29)
        Me.Button4.TabIndex = 0
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pending"
        '
        'dgvPending
        '
        Me.dgvPending.AllowUserToAddRows = False
        Me.dgvPending.AllowUserToDeleteRows = False
        Me.dgvPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPending.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPending.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPending.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPending.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPending.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPending.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvPending.EnableHeadersVisualStyles = False
        Me.dgvPending.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvPending.Location = New System.Drawing.Point(31, 12)
        Me.dgvPending.MultiSelect = False
        Me.dgvPending.Name = "dgvPending"
        Me.dgvPending.ReadOnly = True
        Me.dgvPending.RowHeadersVisible = False
        Me.dgvPending.RowHeadersWidth = 62
        Me.dgvPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPending.Size = New System.Drawing.Size(887, 125)
        Me.dgvPending.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contact"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.PictureBox26)
        Me.Panel6.Controls.Add(Me.Button8)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1477, 109)
        Me.Panel6.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(145, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(989, 65)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "E-Reklamo Baranggay Complaint System"
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
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.Location = New System.Drawing.Point(36, 52)
        Me.Button8.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(465, 46)
        Me.Button8.TabIndex = 76
        Me.Button8.Text = "Efficient + Transparent + Accessible"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.PictureBox7)
        Me.Panel7.Controls.Add(Me.PictureBox11)
        Me.Panel7.Controls.Add(Me.PictureBox13)
        Me.Panel7.Controls.Add(Me.PictureBox14)
        Me.Panel7.Controls.Add(Me.PictureBox15)
        Me.Panel7.Controls.Add(Me.Button9)
        Me.Panel7.Controls.Add(Me.Button10)
        Me.Panel7.Controls.Add(Me.Button11)
        Me.Panel7.Controls.Add(Me.Button12)
        Me.Panel7.Controls.Add(Me.Button13)
        Me.Panel7.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel7.ForeColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(0, 104)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(288, 753)
        Me.Panel7.TabIndex = 73
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(3, 341)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(42, 35)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 60
        Me.PictureBox7.TabStop = False
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
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.Window
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.Location = New System.Drawing.Point(23, 337)
        Me.Button9.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(147, 45)
        Me.Button9.TabIndex = 67
        Me.Button9.Text = "Logout"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.Window
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.Location = New System.Drawing.Point(23, 210)
        Me.Button10.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(147, 36)
        Me.Button10.TabIndex = 63
        Me.Button10.Text = "Search"
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
        Me.Button11.Location = New System.Drawing.Point(13, 146)
        Me.Button11.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(157, 36)
        Me.Button11.TabIndex = 61
        Me.Button11.Text = "Status"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.SystemColors.Window
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button12.Location = New System.Drawing.Point(34, 84)
        Me.Button12.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(157, 45)
        Me.Button12.TabIndex = 59
        Me.Button12.Text = "Summary"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.SystemColors.Window
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button13.Location = New System.Drawing.Point(34, 20)
        Me.Button13.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(157, 46)
        Me.Button13.TabIndex = 57
        Me.Button13.Text = "Complain"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.Color.Silver
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(34, 322)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(214, 3)
        Me.FlowLayoutPanel1.TabIndex = 53
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(134, 106)
        Me.Button2.Margin = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(465, 38)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "Welcome, Admin"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1264, 619)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Button2)
        Me.Name = "FormSearch"
        Me.Text = "Formsearch"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmbSearchCategory As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPending As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox26 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
