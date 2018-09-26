<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblHead = New System.Windows.Forms.Label()
        Me.DGVCat = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LblNm = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LblCad1 = New System.Windows.Forms.Label()
        Me.DGVDate = New System.Windows.Forms.DataGridView()
        Me.PanelDate = New System.Windows.Forms.GroupBox()
        Me.PanelCtgry = New System.Windows.Forms.GroupBox()
        Me.ddlCat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGVCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDate.SuspendLayout()
        Me.PanelCtgry.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblHead
        '
        Me.LblHead.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHead.AutoSize = True
        Me.LblHead.BackColor = System.Drawing.Color.Transparent
        Me.LblHead.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHead.ForeColor = System.Drawing.Color.Navy
        Me.LblHead.Location = New System.Drawing.Point(307, 68)
        Me.LblHead.Name = "LblHead"
        Me.LblHead.Size = New System.Drawing.Size(84, 21)
        Me.LblHead.TabIndex = 0
        Me.LblHead.Text = "Search By"
        '
        'DGVCat
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGVCat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVCat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVCat.BackgroundColor = System.Drawing.Color.White
        Me.DGVCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCat.Location = New System.Drawing.Point(180, 225)
        Me.DGVCat.Name = "DGVCat"
        Me.DGVCat.Size = New System.Drawing.Size(395, 299)
        Me.DGVCat.TabIndex = 1
        Me.DGVCat.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(671, 460)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 41)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.LightCyan
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(659, 507)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Main Menu"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LblNm
        '
        Me.LblNm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNm.AutoSize = True
        Me.LblNm.BackColor = System.Drawing.Color.Transparent
        Me.LblNm.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNm.ForeColor = System.Drawing.Color.Navy
        Me.LblNm.Location = New System.Drawing.Point(698, 21)
        Me.LblNm.Name = "LblNm"
        Me.LblNm.Size = New System.Drawing.Size(0, 19)
        Me.LblNm.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(225, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 50)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 109)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(581, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(526, 132)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 39)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'LblCad1
        '
        Me.LblCad1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCad1.AutoSize = True
        Me.LblCad1.BackColor = System.Drawing.Color.Transparent
        Me.LblCad1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCad1.ForeColor = System.Drawing.Color.Navy
        Me.LblCad1.Location = New System.Drawing.Point(396, 68)
        Me.LblCad1.Name = "LblCad1"
        Me.LblCad1.Size = New System.Drawing.Size(0, 21)
        Me.LblCad1.TabIndex = 22
        '
        'DGVDate
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DGVDate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVDate.BackgroundColor = System.Drawing.Color.White
        Me.DGVDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDate.Location = New System.Drawing.Point(43, 287)
        Me.DGVDate.Name = "DGVDate"
        Me.DGVDate.Size = New System.Drawing.Size(718, 85)
        Me.DGVDate.TabIndex = 2
        Me.DGVDate.Visible = False
        '
        'PanelDate
        '
        Me.PanelDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDate.BackColor = System.Drawing.Color.Transparent
        Me.PanelDate.Controls.Add(Me.TxtDate)
        Me.PanelDate.Controls.Add(Me.Label2)
        Me.PanelDate.Location = New System.Drawing.Point(108, 111)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(396, 111)
        Me.PanelDate.TabIndex = 0
        Me.PanelDate.TabStop = False
        Me.PanelDate.Visible = False
        '
        'PanelCtgry
        '
        Me.PanelCtgry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCtgry.BackColor = System.Drawing.Color.Transparent
        Me.PanelCtgry.Controls.Add(Me.ddlCat)
        Me.PanelCtgry.Controls.Add(Me.Label1)
        Me.PanelCtgry.Location = New System.Drawing.Point(175, 92)
        Me.PanelCtgry.Name = "PanelCtgry"
        Me.PanelCtgry.Size = New System.Drawing.Size(221, 111)
        Me.PanelCtgry.TabIndex = 23
        Me.PanelCtgry.TabStop = False
        Me.PanelCtgry.Visible = False
        '
        'ddlCat
        '
        Me.ddlCat.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlCat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ddlCat.FormattingEnabled = True
        Me.ddlCat.Items.AddRange(New Object() {"Food", "Clothes", "Stationary", "Market", "Entertainment", "Medical", "Transport", "Others", "Income"})
        Me.ddlCat.Location = New System.Drawing.Point(31, 59)
        Me.ddlCat.Name = "ddlCat"
        Me.ddlCat.Size = New System.Drawing.Size(163, 27)
        Me.ddlCat.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 19)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Select the Category"
        '
        'TxtDate
        '
        Me.TxtDate.CalendarFont = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtDate.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDate.Location = New System.Drawing.Point(20, 53)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(249, 26)
        Me.TxtDate.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 19)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Select Your Date"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(789, 545)
        Me.Controls.Add(Me.PanelCtgry)
        Me.Controls.Add(Me.PanelDate)
        Me.Controls.Add(Me.DGVDate)
        Me.Controls.Add(Me.LblCad1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblNm)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DGVCat)
        Me.Controls.Add(Me.LblHead)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expense Manager"
        CType(Me.DGVCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDate.ResumeLayout(False)
        Me.PanelDate.PerformLayout()
        Me.PanelCtgry.ResumeLayout(False)
        Me.PanelCtgry.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHead As Label
    Friend WithEvents DGVCat As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LblNm As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LblCad1 As Label
    Friend WithEvents DGVDate As DataGridView
    Friend WithEvents PanelDate As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelCtgry As GroupBox
    Friend WithEvents ddlCat As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDate As DateTimePicker
End Class
