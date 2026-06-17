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
        imgSearch = New PictureBox()
        pnlPrint = New RoundedPanel4()
        lblPrint = New Label()
        picPrint = New PictureBox()
        TextBox1 = New TextBox()
        dgvStudents = New DataGridView()
        pnlDeleteStudent = New RoundedPanel4()
        lblDeleteStudent = New Label()
        picDeleteStudent = New PictureBox()
        pnlEditStudent = New RoundedPanel4()
        lblEditStudent = New Label()
        picEditStudent = New PictureBox()
        pnlAddStudent = New RoundedPanel4()
        lblAddStudent = New Label()
        picAddStudent = New PictureBox()
        cboBatchFilter = New ComboBox()
        RoundedPanel2 = New RoundedPanel()
        Label2 = New Label()
        Label1 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        pnlContentStudents.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        CType(imgSearch, ComponentModel.ISupportInitialize).BeginInit()
        pnlPrint.SuspendLayout()
        CType(picPrint, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlDeleteStudent.SuspendLayout()
        CType(picDeleteStudent, ComponentModel.ISupportInitialize).BeginInit()
        pnlEditStudent.SuspendLayout()
        CType(picEditStudent, ComponentModel.ISupportInitialize).BeginInit()
        pnlAddStudent.SuspendLayout()
        CType(picAddStudent, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlContentStudents
        ' 
        pnlContentStudents.Controls.Add(RoundedPanel1)
        pnlContentStudents.Controls.Add(RoundedPanel2)
        pnlContentStudents.Controls.Add(Label2)
        pnlContentStudents.Controls.Add(Label1)
        pnlContentStudents.Dock = DockStyle.Top
        pnlContentStudents.Location = New Point(0, 0)
        pnlContentStudents.Name = "pnlContentStudents"
        pnlContentStudents.Size = New Size(1396, 788)
        pnlContentStudents.TabIndex = 0
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(imgSearch)
        RoundedPanel1.Controls.Add(pnlPrint)
        RoundedPanel1.Controls.Add(TextBox1)
        RoundedPanel1.Controls.Add(dgvStudents)
        RoundedPanel1.Controls.Add(pnlDeleteStudent)
        RoundedPanel1.Controls.Add(pnlEditStudent)
        RoundedPanel1.Controls.Add(pnlAddStudent)
        RoundedPanel1.Controls.Add(cboBatchFilter)
        RoundedPanel1.Location = New Point(42, 103)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1320, 618)
        RoundedPanel1.TabIndex = 3
        ' 
        ' imgSearch
        ' 
        imgSearch.BackColor = Color.Transparent
        imgSearch.Image = CType(resources.GetObject("imgSearch.Image"), Image)
        imgSearch.Location = New Point(12, 15)
        imgSearch.Name = "imgSearch"
        imgSearch.Size = New Size(21, 26)
        imgSearch.SizeMode = PictureBoxSizeMode.Zoom
        imgSearch.TabIndex = 0
        imgSearch.TabStop = False
        ' 
        ' pnlPrint
        ' 
        pnlPrint.BackColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        pnlPrint.Controls.Add(lblPrint)
        pnlPrint.Controls.Add(picPrint)
        pnlPrint.Cursor = Cursors.Hand
        pnlPrint.Location = New Point(919, 18)
        pnlPrint.Name = "pnlPrint"
        pnlPrint.Size = New Size(82, 42)
        pnlPrint.TabIndex = 10
        ' 
        ' lblPrint
        ' 
        lblPrint.AutoSize = True
        lblPrint.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrint.ForeColor = Color.White
        lblPrint.Location = New Point(34, 10)
        lblPrint.Name = "lblPrint"
        lblPrint.Size = New Size(42, 23)
        lblPrint.TabIndex = 5
        lblPrint.Text = "Print"
        ' 
        ' picPrint
        ' 
        picPrint.Image = CType(resources.GetObject("picPrint.Image"), Image)
        picPrint.Location = New Point(9, 11)
        picPrint.Name = "picPrint"
        picPrint.Size = New Size(23, 19)
        picPrint.SizeMode = PictureBoxSizeMode.StretchImage
        picPrint.TabIndex = 6
        picPrint.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        TextBox1.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(39, 16)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(192, 30)
        TextBox1.TabIndex = 12
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.BackgroundColor = Color.White
        dgvStudents.BorderStyle = BorderStyle.None
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Cursor = Cursors.Hand
        dgvStudents.Location = New Point(10, 91)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersWidth = 51
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(1300, 511)
        dgvStudents.TabIndex = 11
        ' 
        ' pnlDeleteStudent
        ' 
        pnlDeleteStudent.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        pnlDeleteStudent.Controls.Add(lblDeleteStudent)
        pnlDeleteStudent.Controls.Add(picDeleteStudent)
        pnlDeleteStudent.Cursor = Cursors.Hand
        pnlDeleteStudent.Location = New Point(1007, 18)
        pnlDeleteStudent.Name = "pnlDeleteStudent"
        pnlDeleteStudent.Size = New Size(94, 42)
        pnlDeleteStudent.TabIndex = 9
        ' 
        ' lblDeleteStudent
        ' 
        lblDeleteStudent.AutoSize = True
        lblDeleteStudent.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeleteStudent.ForeColor = Color.White
        lblDeleteStudent.Location = New Point(27, 10)
        lblDeleteStudent.Name = "lblDeleteStudent"
        lblDeleteStudent.Size = New Size(52, 23)
        lblDeleteStudent.TabIndex = 5
        lblDeleteStudent.Text = "Delete"
        ' 
        ' picDeleteStudent
        ' 
        picDeleteStudent.Image = CType(resources.GetObject("picDeleteStudent.Image"), Image)
        picDeleteStudent.Location = New Point(2, 11)
        picDeleteStudent.Name = "picDeleteStudent"
        picDeleteStudent.Size = New Size(23, 19)
        picDeleteStudent.SizeMode = PictureBoxSizeMode.StretchImage
        picDeleteStudent.TabIndex = 6
        picDeleteStudent.TabStop = False
        ' 
        ' pnlEditStudent
        ' 
        pnlEditStudent.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        pnlEditStudent.Controls.Add(lblEditStudent)
        pnlEditStudent.Controls.Add(picEditStudent)
        pnlEditStudent.Cursor = Cursors.Hand
        pnlEditStudent.Location = New Point(1107, 18)
        pnlEditStudent.Name = "pnlEditStudent"
        pnlEditStudent.Size = New Size(64, 42)
        pnlEditStudent.TabIndex = 8
        ' 
        ' lblEditStudent
        ' 
        lblEditStudent.AutoSize = True
        lblEditStudent.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEditStudent.ForeColor = Color.White
        lblEditStudent.Location = New Point(26, 10)
        lblEditStudent.Name = "lblEditStudent"
        lblEditStudent.Size = New Size(35, 23)
        lblEditStudent.TabIndex = 5
        lblEditStudent.Text = "Edit"
        ' 
        ' picEditStudent
        ' 
        picEditStudent.Image = CType(resources.GetObject("picEditStudent.Image"), Image)
        picEditStudent.Location = New Point(3, 11)
        picEditStudent.Name = "picEditStudent"
        picEditStudent.Size = New Size(23, 19)
        picEditStudent.SizeMode = PictureBoxSizeMode.StretchImage
        picEditStudent.TabIndex = 6
        picEditStudent.TabStop = False
        ' 
        ' pnlAddStudent
        ' 
        pnlAddStudent.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlAddStudent.Controls.Add(lblAddStudent)
        pnlAddStudent.Controls.Add(picAddStudent)
        pnlAddStudent.Cursor = Cursors.Hand
        pnlAddStudent.Location = New Point(1178, 18)
        pnlAddStudent.Name = "pnlAddStudent"
        pnlAddStudent.Size = New Size(123, 42)
        pnlAddStudent.TabIndex = 7
        ' 
        ' lblAddStudent
        ' 
        lblAddStudent.AutoSize = True
        lblAddStudent.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddStudent.ForeColor = Color.White
        lblAddStudent.Location = New Point(26, 10)
        lblAddStudent.Name = "lblAddStudent"
        lblAddStudent.Size = New Size(94, 23)
        lblAddStudent.TabIndex = 5
        lblAddStudent.Text = "Add Student"
        ' 
        ' picAddStudent
        ' 
        picAddStudent.Image = CType(resources.GetObject("picAddStudent.Image"), Image)
        picAddStudent.Location = New Point(4, 11)
        picAddStudent.Name = "picAddStudent"
        picAddStudent.Size = New Size(23, 19)
        picAddStudent.SizeMode = PictureBoxSizeMode.StretchImage
        picAddStudent.TabIndex = 6
        picAddStudent.TabStop = False
        ' 
        ' cboBatchFilter
        ' 
        cboBatchFilter.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        cboBatchFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboBatchFilter.FormattingEnabled = True
        cboBatchFilter.Location = New Point(256, 18)
        cboBatchFilter.Name = "cboBatchFilter"
        cboBatchFilter.Size = New Size(121, 24)
        cboBatchFilter.TabIndex = 1
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        RoundedPanel2.Location = New Point(47, 103)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(1320, 618)
        RoundedPanel2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "ucStudents"
        Size = New Size(1396, 788)
        pnlContentStudents.ResumeLayout(False)
        pnlContentStudents.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(imgSearch, ComponentModel.ISupportInitialize).EndInit()
        pnlPrint.ResumeLayout(False)
        pnlPrint.PerformLayout()
        CType(picPrint, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlDeleteStudent.ResumeLayout(False)
        pnlDeleteStudent.PerformLayout()
        CType(picDeleteStudent, ComponentModel.ISupportInitialize).EndInit()
        pnlEditStudent.ResumeLayout(False)
        pnlEditStudent.PerformLayout()
        CType(picEditStudent, ComponentModel.ISupportInitialize).EndInit()
        pnlAddStudent.ResumeLayout(False)
        pnlAddStudent.PerformLayout()
        CType(picAddStudent, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContentStudents As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents cboBatchFilter As ComboBox
    Friend WithEvents picAddStudent As PictureBox
    Friend WithEvents lblAddStudent As Label
    Friend WithEvents pnlAddStudent As RoundedPanel4
    Friend WithEvents pnlEditStudent As RoundedPanel4
    Friend WithEvents lblEditStudent As Label
    Friend WithEvents picEditStudent As PictureBox
    Friend WithEvents pnlDeleteStudent As RoundedPanel4
    Friend WithEvents lblDeleteStudent As Label
    Friend WithEvents picDeleteStudent As PictureBox
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents imgSearch As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pnlPrint As RoundedPanel4
    Friend WithEvents lblPrint As Label
    Friend WithEvents picPrint As PictureBox

End Class
