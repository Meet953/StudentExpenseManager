<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmdAdmincancel = New System.Windows.Forms.Button()
        Me.CmdAdminLogin = New System.Windows.Forms.Button()
        Me.UserLabel2 = New System.Windows.Forms.Label()
        Me.UserLabel1 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.UserPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Pic = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(105, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(377, 60)
        Me.PictureBox1.TabIndex = 29
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
        Me.PictureBox2.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(107, 83)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CmdAdmincancel)
        Me.GroupBox1.Controls.Add(Me.CmdAdminLogin)
        Me.GroupBox1.Controls.Add(Me.UserLabel2)
        Me.GroupBox1.Controls.Add(Me.UserLabel1)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.TxtUserName)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.UserPictureBox)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 202)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'CmdAdmincancel
        '
        Me.CmdAdmincancel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CmdAdmincancel.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdmincancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdAdmincancel.Image = CType(resources.GetObject("CmdAdmincancel.Image"), System.Drawing.Image)
        Me.CmdAdmincancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAdmincancel.Location = New System.Drawing.Point(338, 143)
        Me.CmdAdmincancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdAdmincancel.Name = "CmdAdmincancel"
        Me.CmdAdmincancel.Size = New System.Drawing.Size(97, 40)
        Me.CmdAdmincancel.TabIndex = 39
        Me.CmdAdmincancel.Text = "     &Cancel"
        Me.CmdAdmincancel.UseVisualStyleBackColor = True
        '
        'CmdAdminLogin
        '
        Me.CmdAdminLogin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CmdAdminLogin.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdminLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdAdminLogin.Image = CType(resources.GetObject("CmdAdminLogin.Image"), System.Drawing.Image)
        Me.CmdAdminLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAdminLogin.Location = New System.Drawing.Point(237, 143)
        Me.CmdAdminLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdAdminLogin.Name = "CmdAdminLogin"
        Me.CmdAdminLogin.Size = New System.Drawing.Size(97, 40)
        Me.CmdAdminLogin.TabIndex = 38
        Me.CmdAdminLogin.Text = "        &Login"
        Me.CmdAdminLogin.UseVisualStyleBackColor = True
        '
        'UserLabel2
        '
        Me.UserLabel2.AutoSize = True
        Me.UserLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UserLabel2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserLabel2.Location = New System.Drawing.Point(236, 76)
        Me.UserLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserLabel2.Name = "UserLabel2"
        Me.UserLabel2.Size = New System.Drawing.Size(86, 23)
        Me.UserLabel2.TabIndex = 37
        Me.UserLabel2.Text = "Password :"
        '
        'UserLabel1
        '
        Me.UserLabel1.AutoSize = True
        Me.UserLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UserLabel1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserLabel1.Location = New System.Drawing.Point(236, 16)
        Me.UserLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserLabel1.Name = "UserLabel1"
        Me.UserLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UserLabel1.TabIndex = 36
        Me.UserLabel1.Text = "User Name :"
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.Azure
        Me.TxtPassword.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtPassword.Location = New System.Drawing.Point(237, 103)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtPassword.Size = New System.Drawing.Size(200, 25)
        Me.TxtPassword.TabIndex = 35
        '
        'TxtUserName
        '
        Me.TxtUserName.BackColor = System.Drawing.Color.Azure
        Me.TxtUserName.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtUserName.Location = New System.Drawing.Point(235, 43)
        Me.TxtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(200, 26)
        Me.TxtUserName.TabIndex = 34
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(37, 166)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(124, 24)
        Me.LinkLabel1.TabIndex = 33
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create an Account"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserPictureBox
        '
        Me.UserPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.UserPictureBox.ErrorImage = Nothing
        Me.UserPictureBox.Image = CType(resources.GetObject("UserPictureBox.Image"), System.Drawing.Image)
        Me.UserPictureBox.Location = New System.Drawing.Point(29, 20)
        Me.UserPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UserPictureBox.Name = "UserPictureBox"
        Me.UserPictureBox.Size = New System.Drawing.Size(132, 139)
        Me.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPictureBox.TabIndex = 32
        Me.UserPictureBox.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(146, 319)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(292, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 32
        Me.ProgressBar1.Visible = False
        '
        'Pic
        '
        Me.Pic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic.BackColor = System.Drawing.Color.Transparent
        Me.Pic.BackgroundImage = CType(resources.GetObject("Pic.BackgroundImage"), System.Drawing.Image)
        Me.Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic.Image = CType(resources.GetObject("Pic.Image"), System.Drawing.Image)
        Me.Pic.Location = New System.Drawing.Point(75, 306)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(52, 50)
        Me.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic.TabIndex = 35
        Me.Pic.TabStop = False
        Me.Pic.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(555, 368)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmdAdmincancel As Button
    Friend WithEvents CmdAdminLogin As Button
    Friend WithEvents UserLabel2 As Label
    Friend WithEvents UserLabel1 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents UserPictureBox As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Pic As PictureBox
End Class
