<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStudents
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucStudents))
        pnlContentStudents = New Panel()
        RoundedPanel1 = New RoundedPanel()
        RoundedPanel41 = New RoundedPanel4()
        txtSearch = New TextBox()
        PictureBox1 = New PictureBox()
        RoundedPanel2 = New RoundedPanel()
        Label2 = New Label()
        Label1 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        pnlContentStudents.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        RoundedPanel41.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlContentStudents
        ' 
        pnlContentStudents.Controls.Add(RoundedPanel1)
        pnlContentStudents.Controls.Add(RoundedPanel2)
        pnlContentStudents.Controls.Add(Label2)
        pnlContentStudents.Controls.Add(Label1)
        pnlContentStudents.Dock = DockStyle.Fill
        pnlContentStudents.Location = New Point(0, 0)
        pnlContentStudents.Name = "pnlContentStudents"
        pnlContentStudents.Size = New Size(1396, 788)
        pnlContentStudents.TabIndex = 0
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(RoundedPanel41)
        RoundedPanel1.Location = New Point(40, 100)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1323, 615)
        RoundedPanel1.TabIndex = 3
        ' 
        ' RoundedPanel41
        ' 
        RoundedPanel41.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        RoundedPanel41.Controls.Add(txtSearch)
        RoundedPanel41.Controls.Add(PictureBox1)
        RoundedPanel41.Location = New Point(26, 18)
        RoundedPanel41.Name = "RoundedPanel41"
        RoundedPanel41.Size = New Size(232, 37)
        RoundedPanel41.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        txtSearch.Location = New Point(29, 9)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(198, 20)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search by name or student ID"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(6, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(22, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        RoundedPanel2.Location = New Point(47, 100)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(1320, 618)
        RoundedPanel2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        Label2.Location = New Point(40, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(394, 23)
        Label2.TabIndex = 2
        Label2.Text = "Manage all enrolled students and their attendance records."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(37, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 37)
        Label1.TabIndex = 1
        Label1.Text = "Students"
        ' 
        ' ucStudents
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        Controls.Add(pnlContentStudents)
        Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "ucStudents"
        Size = New Size(1396, 788)
        pnlContentStudents.ResumeLayout(False)
        pnlContentStudents.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel41.ResumeLayout(False)
        RoundedPanel41.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContentStudents As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents RoundedPanel41 As RoundedPanel4
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
