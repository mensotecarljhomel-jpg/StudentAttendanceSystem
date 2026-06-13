<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        pnlSidebar = New Panel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        pnlSeparator1 = New Panel()
        pnlRight = New Panel()
        pnlContent = New Panel()
        pnlShadow = New Panel()
        pnlSeparator2 = New Panel()
        pnlTopbar = New Panel()
        Label1 = New Label()
        pnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlRight.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlTopbar.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(23), CByte(22), CByte(39))
        pnlSidebar.Controls.Add(Panel1)
        pnlSidebar.Controls.Add(PictureBox1)
        pnlSidebar.Controls.Add(Label5)
        pnlSidebar.Controls.Add(Label4)
        pnlSidebar.Controls.Add(Label3)
        pnlSidebar.Controls.Add(Label2)
        pnlSidebar.Controls.Add(pnlSeparator1)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(188, 915)
        pnlSidebar.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.ForeColor = SystemColors.ControlDarkDark
        Panel1.Location = New Point(-1, 911)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(190, 1)
        Panel1.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(9, 127)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 32)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(46, 126)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 36)
        Label5.TabIndex = 4
        Label5.Text = "Dashboard"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(145))
        Label4.Location = New Point(12, 371)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 23)
        Label4.TabIndex = 3
        Label4.Text = "MAIN SYSTEM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(145))
        Label3.Location = New Point(12, 259)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 23)
        Label3.TabIndex = 2
        Label3.Text = "MAIN SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(145))
        Label2.Location = New Point(12, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 19)
        Label2.TabIndex = 1
        Label2.Text = "MAIN SYSTEM"
        ' 
        ' pnlSeparator1
        ' 
        pnlSeparator1.BackColor = Color.White
        pnlSeparator1.ForeColor = SystemColors.ControlDarkDark
        pnlSeparator1.Location = New Point(0, 81)
        pnlSeparator1.Name = "pnlSeparator1"
        pnlSeparator1.Size = New Size(190, 1)
        pnlSeparator1.TabIndex = 0
        ' 
        ' pnlRight
        ' 
        pnlRight.Controls.Add(pnlContent)
        pnlRight.Controls.Add(pnlTopbar)
        pnlRight.Dock = DockStyle.Fill
        pnlRight.Location = New Point(188, 0)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(1165, 915)
        pnlRight.TabIndex = 2
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        pnlContent.Controls.Add(pnlShadow)
        pnlContent.Controls.Add(pnlSeparator2)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Font = New Font("Poppins", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlContent.Location = New Point(0, 73)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1165, 842)
        pnlContent.TabIndex = 1
        ' 
        ' pnlShadow
        ' 
        pnlShadow.BackColor = Color.FromArgb(CByte(234), CByte(230), CByte(248))
        pnlShadow.Dock = DockStyle.Top
        pnlShadow.Location = New Point(0, 1)
        pnlShadow.Name = "pnlShadow"
        pnlShadow.Size = New Size(1165, 1)
        pnlShadow.TabIndex = 1
        ' 
        ' pnlSeparator2
        ' 
        pnlSeparator2.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(242))
        pnlSeparator2.Dock = DockStyle.Top
        pnlSeparator2.Location = New Point(0, 0)
        pnlSeparator2.Name = "pnlSeparator2"
        pnlSeparator2.Size = New Size(1165, 1)
        pnlSeparator2.TabIndex = 0
        ' 
        ' pnlTopbar
        ' 
        pnlTopbar.BackColor = Color.White
        pnlTopbar.Controls.Add(Label1)
        pnlTopbar.Dock = DockStyle.Top
        pnlTopbar.Location = New Point(0, 0)
        pnlTopbar.Name = "pnlTopbar"
        pnlTopbar.Size = New Size(1165, 73)
        pnlTopbar.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 37)
        Label1.TabIndex = 2
        Label1.Text = "Dashboard"
        ' 
        ' Dashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1353, 915)
        Controls.Add(pnlRight)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "$"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlRight.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlTopbar.ResumeLayout(False)
        pnlTopbar.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlSeparator1 As Panel
    Friend WithEvents pnlTopbar As Panel
    Friend WithEvents pnlSeparator2 As Panel
    Friend WithEvents pnlShadow As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label

End Class
