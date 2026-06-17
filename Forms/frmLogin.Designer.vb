<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        pnlLoginCard = New RoundedPanel2()
        pnlLogin = New RoundedPanel4()
        lblLogin = New Label()
        pnlPassword = New RoundedPanel3()
        txtPassword = New TextBox()
        lblPass = New Label()
        PictureBox1 = New PictureBox()
        lblpassword = New Label()
        pnlUsername = New RoundedPanel3()
        txtUsername = New TextBox()
        lblUser = New Label()
        picUser = New PictureBox()
        lblUserName = New Label()
        Panel1 = New Panel()
        RoundedPanel41 = New RoundedPanel4()
        picLogo = New PictureBox()
        pnlLoginCard.SuspendLayout()
        pnlLogin.SuspendLayout()
        pnlPassword.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlUsername.SuspendLayout()
        CType(picUser, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.BackColor = Color.White
        pnlLoginCard.Controls.Add(pnlLogin)
        pnlLoginCard.Controls.Add(pnlPassword)
        pnlLoginCard.Controls.Add(lblpassword)
        pnlLoginCard.Controls.Add(pnlUsername)
        pnlLoginCard.Controls.Add(lblUserName)
        pnlLoginCard.Controls.Add(Panel1)
        pnlLoginCard.Controls.Add(RoundedPanel41)
        pnlLoginCard.Controls.Add(picLogo)
        pnlLoginCard.Location = New Point(484, 99)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Size = New Size(428, 590)
        pnlLoginCard.TabIndex = 0
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlLogin.Controls.Add(lblLogin)
        pnlLogin.Cursor = Cursors.Hand
        pnlLogin.Location = New Point(44, 443)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(339, 42)
        pnlLogin.TabIndex = 8
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Font("Poppins", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogin.ForeColor = Color.White
        lblLogin.Location = New Point(135, 8)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(60, 28)
        lblLogin.TabIndex = 5
        lblLogin.Text = "Log In"
        ' 
        ' pnlPassword
        ' 
        pnlPassword.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        pnlPassword.Controls.Add(txtPassword)
        pnlPassword.Controls.Add(lblPass)
        pnlPassword.Controls.Add(PictureBox1)
        pnlPassword.Font = New Font("Poppins", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlPassword.ForeColor = Color.Black
        pnlPassword.Location = New Point(37, 333)
        pnlPassword.Name = "pnlPassword"
        pnlPassword.Size = New Size(355, 43)
        pnlPassword.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Poppins", 11.25F)
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(44, 9)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(300, 23)
        txtPassword.TabIndex = 0
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPass.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblPass.Location = New Point(44, 9)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(166, 26)
        lblPass.TabIndex = 1
        lblPass.Text = "Enter your password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(6, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(29, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' lblpassword
        ' 
        lblpassword.AutoSize = True
        lblpassword.Font = New Font("Poppins", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblpassword.ImageAlign = ContentAlignment.MiddleRight
        lblpassword.Location = New Point(37, 308)
        lblpassword.Name = "lblpassword"
        lblpassword.Size = New Size(79, 22)
        lblpassword.TabIndex = 5
        lblpassword.Text = "PASSWORD"
        ' 
        ' pnlUsername
        ' 
        pnlUsername.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        pnlUsername.Controls.Add(txtUsername)
        pnlUsername.Controls.Add(lblUser)
        pnlUsername.Controls.Add(picUser)
        pnlUsername.Font = New Font("Poppins", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlUsername.ForeColor = Color.Black
        pnlUsername.Location = New Point(37, 248)
        pnlUsername.Name = "pnlUsername"
        pnlUsername.Size = New Size(355, 43)
        pnlUsername.TabIndex = 4
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Poppins", 11.25F)
        txtUsername.ForeColor = Color.Black
        txtUsername.Location = New Point(44, 9)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(300, 23)
        txtUsername.TabIndex = 0
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblUser.Location = New Point(44, 9)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(131, 26)
        lblUser.TabIndex = 1
        lblUser.Text = "Enter Username"
        ' 
        ' picUser
        ' 
        picUser.Image = CType(resources.GetObject("picUser.Image"), Image)
        picUser.Location = New Point(6, 9)
        picUser.Name = "picUser"
        picUser.Size = New Size(29, 24)
        picUser.SizeMode = PictureBoxSizeMode.Zoom
        picUser.TabIndex = 2
        picUser.TabStop = False
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Poppins", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUserName.ImageAlign = ContentAlignment.MiddleRight
        lblUserName.Location = New Point(34, 223)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(74, 22)
        lblUserName.TabIndex = 3
        lblUserName.Text = "USERNAME"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Location = New Point(37, 177)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(355, 1)
        Panel1.TabIndex = 2
        ' 
        ' RoundedPanel41
        ' 
        RoundedPanel41.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        RoundedPanel41.Location = New Point(37, 0)
        RoundedPanel41.Name = "RoundedPanel41"
        RoundedPanel41.Size = New Size(355, 10)
        RoundedPanel41.TabIndex = 1
        ' 
        ' picLogo
        ' 
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(79, 51)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(267, 71)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' frmLogin
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(23), CByte(22), CByte(39))
        ClientSize = New Size(1396, 788)
        Controls.Add(pnlLoginCard)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        pnlLoginCard.ResumeLayout(False)
        pnlLoginCard.PerformLayout()
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        pnlPassword.ResumeLayout(False)
        pnlPassword.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlUsername.ResumeLayout(False)
        pnlUsername.PerformLayout()
        CType(picUser, ComponentModel.ISupportInitialize).EndInit()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLoginCard As RoundedPanel2
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents RoundedPanel41 As RoundedPanel4
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlUsername As RoundedPanel3
    Friend WithEvents lblUserName As Label
    Friend WithEvents picUser As PictureBox
    Friend WithEvents pnlPassword As RoundedPanel3
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblpassword As Label
    Friend WithEvents pnlLogin As RoundedPanel4
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPass As Label
End Class
