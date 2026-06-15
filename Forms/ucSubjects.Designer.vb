<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSubjects))
        RoundedPanel2 = New RoundedPanel()
        pnlContentSubjects = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        RoundedPanel1 = New RoundedPanel()
        pnlContentStudents = New Panel()
        pnlContentBatches = New Panel()
        RoundedPanel5 = New RoundedPanel()
        dgvSubjects = New DataGridView()
        pnlRefreshBatches = New RoundedPanel4()
        lblRefreshBatch = New Label()
        PictureBox1 = New PictureBox()
        pnlDeleteBatch = New RoundedPanel4()
        lblDeleteBatch = New Label()
        PictureBox2 = New PictureBox()
        pnlEditBatch = New RoundedPanel4()
        lblEditBatch = New Label()
        PictureBox3 = New PictureBox()
        pnlAddBatch = New RoundedPanel4()
        lblAddBatch = New Label()
        PictureBox4 = New PictureBox()
        cboSubjectFilter = New ComboBox()
        RoundedPanel41 = New RoundedPanel4()
        TextBox1 = New TextBox()
        PictureBox5 = New PictureBox()
        RoundedPanel6 = New RoundedPanel()
        Label4 = New Label()
        Label3 = New Label()
        RoundedPanel4 = New RoundedPanel()
        dgvStudents = New DataGridView()
        pnlRefreshStudent = New RoundedPanel4()
        lblRefreshStudent = New Label()
        picRefreshStudent = New PictureBox()
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
        pnlSearch = New RoundedPanel4()
        lblSearch = New TextBox()
        imgSearch = New PictureBox()
        RoundedPanel3 = New RoundedPanel()
        Label2 = New Label()
        Label1 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        pnlContentSubjects.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        pnlContentStudents.SuspendLayout()
        pnlContentBatches.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        CType(dgvSubjects, ComponentModel.ISupportInitialize).BeginInit()
        pnlRefreshBatches.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlDeleteBatch.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlEditBatch.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        pnlAddBatch.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel41.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel4.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlRefreshStudent.SuspendLayout()
        CType(picRefreshStudent, ComponentModel.ISupportInitialize).BeginInit()
        pnlDeleteStudent.SuspendLayout()
        CType(picDeleteStudent, ComponentModel.ISupportInitialize).BeginInit()
        pnlEditStudent.SuspendLayout()
        CType(picEditStudent, ComponentModel.ISupportInitialize).BeginInit()
        pnlAddStudent.SuspendLayout()
        CType(picAddStudent, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearch.SuspendLayout()
        CType(imgSearch, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        RoundedPanel2.Location = New Point(42, 90)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(1320, 618)
        RoundedPanel2.TabIndex = 6
        ' 
        ' pnlContentSubjects
        ' 
        pnlContentSubjects.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        pnlContentSubjects.Controls.Add(Label5)
        pnlContentSubjects.Controls.Add(Label6)
        pnlContentSubjects.Controls.Add(RoundedPanel1)
        pnlContentSubjects.Controls.Add(RoundedPanel2)
        pnlContentSubjects.Dock = DockStyle.Fill
        pnlContentSubjects.Location = New Point(0, 0)
        pnlContentSubjects.Name = "pnlContentSubjects"
        pnlContentSubjects.Size = New Size(1396, 788)
        pnlContentSubjects.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label5.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        Label5.Location = New Point(42, 55)
        Label5.Name = "Label5"
        Label5.Size = New Size(374, 20)
        Label5.TabIndex = 6
        Label5.Text = "Manage course subjects assigned to each batch."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(39, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 31)
        Label6.TabIndex = 5
        Label6.Text = "Subjects"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(pnlContentStudents)
        RoundedPanel1.Location = New Point(35, 90)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1323, 615)
        RoundedPanel1.TabIndex = 5
        ' 
        ' pnlContentStudents
        ' 
        pnlContentStudents.Controls.Add(pnlContentBatches)
        pnlContentStudents.Controls.Add(RoundedPanel4)
        pnlContentStudents.Controls.Add(RoundedPanel3)
        pnlContentStudents.Controls.Add(Label2)
        pnlContentStudents.Controls.Add(Label1)
        pnlContentStudents.Dock = DockStyle.Fill
        pnlContentStudents.Location = New Point(0, 0)
        pnlContentStudents.Name = "pnlContentStudents"
        pnlContentStudents.Size = New Size(1323, 615)
        pnlContentStudents.TabIndex = 1
        ' 
        ' pnlContentBatches
        ' 
        pnlContentBatches.Controls.Add(RoundedPanel5)
        pnlContentBatches.Controls.Add(RoundedPanel6)
        pnlContentBatches.Controls.Add(Label4)
        pnlContentBatches.Controls.Add(Label3)
        pnlContentBatches.Location = New Point(-37, -87)
        pnlContentBatches.Name = "pnlContentBatches"
        pnlContentBatches.Size = New Size(1396, 788)
        pnlContentBatches.TabIndex = 5
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.BackColor = Color.White
        RoundedPanel5.Controls.Add(dgvSubjects)
        RoundedPanel5.Controls.Add(pnlRefreshBatches)
        RoundedPanel5.Controls.Add(pnlDeleteBatch)
        RoundedPanel5.Controls.Add(pnlEditBatch)
        RoundedPanel5.Controls.Add(pnlAddBatch)
        RoundedPanel5.Controls.Add(cboSubjectFilter)
        RoundedPanel5.Controls.Add(RoundedPanel41)
        RoundedPanel5.Location = New Point(40, 100)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(1323, 615)
        RoundedPanel5.TabIndex = 3
        ' 
        ' dgvSubjects
        ' 
        dgvSubjects.AllowUserToAddRows = False
        dgvSubjects.AllowUserToDeleteRows = False
        dgvSubjects.BackgroundColor = Color.White
        dgvSubjects.BorderStyle = BorderStyle.None
        dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSubjects.Cursor = Cursors.Hand
        dgvSubjects.Location = New Point(10, 82)
        dgvSubjects.MultiSelect = False
        dgvSubjects.Name = "dgvSubjects"
        dgvSubjects.ReadOnly = True
        dgvSubjects.RowHeadersWidth = 51
        dgvSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSubjects.Size = New Size(1300, 511)
        dgvSubjects.TabIndex = 11
        ' 
        ' pnlRefreshBatches
        ' 
        pnlRefreshBatches.BackColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        pnlRefreshBatches.Controls.Add(lblRefreshBatch)
        pnlRefreshBatches.Controls.Add(PictureBox1)
        pnlRefreshBatches.Cursor = Cursors.Hand
        pnlRefreshBatches.Location = New Point(928, 18)
        pnlRefreshBatches.Name = "pnlRefreshBatches"
        pnlRefreshBatches.Size = New Size(86, 42)
        pnlRefreshBatches.TabIndex = 10
        ' 
        ' lblRefreshBatch
        ' 
        lblRefreshBatch.AutoSize = True
        lblRefreshBatch.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRefreshBatch.ForeColor = Color.White
        lblRefreshBatch.Location = New Point(24, 10)
        lblRefreshBatch.Name = "lblRefreshBatch"
        lblRefreshBatch.Size = New Size(75, 20)
        lblRefreshBatch.TabIndex = 5
        lblRefreshBatch.Text = "Refresh"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(4, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(23, 19)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' pnlDeleteBatch
        ' 
        pnlDeleteBatch.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        pnlDeleteBatch.Controls.Add(lblDeleteBatch)
        pnlDeleteBatch.Controls.Add(PictureBox2)
        pnlDeleteBatch.Cursor = Cursors.Hand
        pnlDeleteBatch.Location = New Point(1020, 18)
        pnlDeleteBatch.Name = "pnlDeleteBatch"
        pnlDeleteBatch.Size = New Size(81, 42)
        pnlDeleteBatch.TabIndex = 9
        ' 
        ' lblDeleteBatch
        ' 
        lblDeleteBatch.AutoSize = True
        lblDeleteBatch.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeleteBatch.ForeColor = Color.White
        lblDeleteBatch.Location = New Point(24, 10)
        lblDeleteBatch.Name = "lblDeleteBatch"
        lblDeleteBatch.Size = New Size(64, 20)
        lblDeleteBatch.TabIndex = 5
        lblDeleteBatch.Text = "Delete"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(2, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(23, 19)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' pnlEditBatch
        ' 
        pnlEditBatch.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        pnlEditBatch.Controls.Add(lblEditBatch)
        pnlEditBatch.Controls.Add(PictureBox3)
        pnlEditBatch.Cursor = Cursors.Hand
        pnlEditBatch.Location = New Point(1107, 18)
        pnlEditBatch.Name = "pnlEditBatch"
        pnlEditBatch.Size = New Size(64, 42)
        pnlEditBatch.TabIndex = 8
        ' 
        ' lblEditBatch
        ' 
        lblEditBatch.AutoSize = True
        lblEditBatch.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEditBatch.ForeColor = Color.White
        lblEditBatch.Location = New Point(26, 10)
        lblEditBatch.Name = "lblEditBatch"
        lblEditBatch.Size = New Size(42, 20)
        lblEditBatch.TabIndex = 5
        lblEditBatch.Text = "Edit"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 11)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(23, 19)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' pnlAddBatch
        ' 
        pnlAddBatch.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlAddBatch.Controls.Add(lblAddBatch)
        pnlAddBatch.Controls.Add(PictureBox4)
        pnlAddBatch.Cursor = Cursors.Hand
        pnlAddBatch.Location = New Point(1178, 18)
        pnlAddBatch.Name = "pnlAddBatch"
        pnlAddBatch.Size = New Size(123, 42)
        pnlAddBatch.TabIndex = 7
        ' 
        ' lblAddBatch
        ' 
        lblAddBatch.AutoSize = True
        lblAddBatch.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddBatch.ForeColor = Color.White
        lblAddBatch.Location = New Point(26, 10)
        lblAddBatch.Name = "lblAddBatch"
        lblAddBatch.Size = New Size(116, 20)
        lblAddBatch.TabIndex = 5
        lblAddBatch.Text = "Add Batches"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(4, 11)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(23, 19)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        ' 
        ' cboSubjectFilter
        ' 
        cboSubjectFilter.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        cboSubjectFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboSubjectFilter.Font = New Font("Microsoft Sans Serif", 9.75F)
        cboSubjectFilter.FormattingEnabled = True
        cboSubjectFilter.Location = New Point(273, 20)
        cboSubjectFilter.Name = "cboSubjectFilter"
        cboSubjectFilter.Size = New Size(121, 28)
        cboSubjectFilter.TabIndex = 1
        ' 
        ' RoundedPanel41
        ' 
        RoundedPanel41.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        RoundedPanel41.Controls.Add(TextBox1)
        RoundedPanel41.Controls.Add(PictureBox5)
        RoundedPanel41.Cursor = Cursors.Hand
        RoundedPanel41.Location = New Point(26, 18)
        RoundedPanel41.Name = "RoundedPanel41"
        RoundedPanel41.Size = New Size(232, 37)
        RoundedPanel41.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        TextBox1.Location = New Point(29, 9)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(198, 19)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Search Subjects..."
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(6, 4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(22, 29)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        RoundedPanel6.Location = New Point(47, 100)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(1320, 618)
        RoundedPanel6.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label4.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        Label4.Location = New Point(40, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(334, 20)
        Label4.TabIndex = 2
        Label4.Text = "Organize students into batches or sections."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(37, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 31)
        Label3.TabIndex = 1
        Label3.Text = "Batches"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BackColor = Color.White
        RoundedPanel4.Controls.Add(dgvStudents)
        RoundedPanel4.Controls.Add(pnlRefreshStudent)
        RoundedPanel4.Controls.Add(pnlDeleteStudent)
        RoundedPanel4.Controls.Add(pnlEditStudent)
        RoundedPanel4.Controls.Add(pnlAddStudent)
        RoundedPanel4.Controls.Add(cboBatchFilter)
        RoundedPanel4.Controls.Add(pnlSearch)
        RoundedPanel4.Location = New Point(40, 100)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(1323, 615)
        RoundedPanel4.TabIndex = 3
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
        ' pnlRefreshStudent
        ' 
        pnlRefreshStudent.BackColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        pnlRefreshStudent.Controls.Add(lblRefreshStudent)
        pnlRefreshStudent.Controls.Add(picRefreshStudent)
        pnlRefreshStudent.Cursor = Cursors.Hand
        pnlRefreshStudent.Location = New Point(928, 18)
        pnlRefreshStudent.Name = "pnlRefreshStudent"
        pnlRefreshStudent.Size = New Size(86, 42)
        pnlRefreshStudent.TabIndex = 10
        ' 
        ' lblRefreshStudent
        ' 
        lblRefreshStudent.AutoSize = True
        lblRefreshStudent.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRefreshStudent.ForeColor = Color.White
        lblRefreshStudent.Location = New Point(24, 10)
        lblRefreshStudent.Name = "lblRefreshStudent"
        lblRefreshStudent.Size = New Size(75, 20)
        lblRefreshStudent.TabIndex = 5
        lblRefreshStudent.Text = "Refresh"
        ' 
        ' picRefreshStudent
        ' 
        picRefreshStudent.Image = CType(resources.GetObject("picRefreshStudent.Image"), Image)
        picRefreshStudent.Location = New Point(4, 11)
        picRefreshStudent.Name = "picRefreshStudent"
        picRefreshStudent.Size = New Size(23, 19)
        picRefreshStudent.SizeMode = PictureBoxSizeMode.StretchImage
        picRefreshStudent.TabIndex = 6
        picRefreshStudent.TabStop = False
        ' 
        ' pnlDeleteStudent
        ' 
        pnlDeleteStudent.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        pnlDeleteStudent.Controls.Add(lblDeleteStudent)
        pnlDeleteStudent.Controls.Add(picDeleteStudent)
        pnlDeleteStudent.Cursor = Cursors.Hand
        pnlDeleteStudent.Location = New Point(1020, 18)
        pnlDeleteStudent.Name = "pnlDeleteStudent"
        pnlDeleteStudent.Size = New Size(81, 42)
        pnlDeleteStudent.TabIndex = 9
        ' 
        ' lblDeleteStudent
        ' 
        lblDeleteStudent.AutoSize = True
        lblDeleteStudent.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeleteStudent.ForeColor = Color.White
        lblDeleteStudent.Location = New Point(24, 10)
        lblDeleteStudent.Name = "lblDeleteStudent"
        lblDeleteStudent.Size = New Size(64, 20)
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
        lblEditStudent.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEditStudent.ForeColor = Color.White
        lblEditStudent.Location = New Point(26, 10)
        lblEditStudent.Name = "lblEditStudent"
        lblEditStudent.Size = New Size(42, 20)
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
        lblAddStudent.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddStudent.ForeColor = Color.White
        lblAddStudent.Location = New Point(26, 10)
        lblAddStudent.Name = "lblAddStudent"
        lblAddStudent.Size = New Size(111, 20)
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
        cboBatchFilter.Location = New Point(273, 20)
        cboBatchFilter.Name = "cboBatchFilter"
        cboBatchFilter.Size = New Size(121, 28)
        cboBatchFilter.TabIndex = 1
        ' 
        ' pnlSearch
        ' 
        pnlSearch.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        pnlSearch.Controls.Add(lblSearch)
        pnlSearch.Controls.Add(imgSearch)
        pnlSearch.Cursor = Cursors.Hand
        pnlSearch.Location = New Point(26, 18)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Size = New Size(232, 37)
        pnlSearch.TabIndex = 0
        ' 
        ' lblSearch
        ' 
        lblSearch.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        lblSearch.BorderStyle = BorderStyle.None
        lblSearch.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearch.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        lblSearch.Location = New Point(29, 9)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(198, 19)
        lblSearch.TabIndex = 1
        lblSearch.Text = "Search by name or student ID"
        ' 
        ' imgSearch
        ' 
        imgSearch.BackColor = Color.Transparent
        imgSearch.Image = CType(resources.GetObject("imgSearch.Image"), Image)
        imgSearch.Location = New Point(6, 4)
        imgSearch.Name = "imgSearch"
        imgSearch.Size = New Size(22, 29)
        imgSearch.SizeMode = PictureBoxSizeMode.Zoom
        imgSearch.TabIndex = 0
        imgSearch.TabStop = False
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        RoundedPanel3.Location = New Point(47, 100)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(1320, 618)
        RoundedPanel3.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        Label2.Location = New Point(40, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(398, 20)
        Label2.TabIndex = 2
        Label2.Text = "Manage all enrolled students and their attendance records."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(37, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 31)
        Label1.TabIndex = 1
        Label1.Text = "Students"
        ' 
        ' ucSubjects
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(pnlContentSubjects)
        Name = "ucSubjects"
        Size = New Size(1396, 788)
        pnlContentSubjects.ResumeLayout(False)
        pnlContentSubjects.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        pnlContentStudents.ResumeLayout(False)
        pnlContentStudents.PerformLayout()
        pnlContentBatches.ResumeLayout(False)
        pnlContentBatches.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        CType(dgvSubjects, ComponentModel.ISupportInitialize).EndInit()
        pnlRefreshBatches.ResumeLayout(False)
        pnlRefreshBatches.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlDeleteBatch.ResumeLayout(False)
        pnlDeleteBatch.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlEditBatch.ResumeLayout(False)
        pnlEditBatch.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        pnlAddBatch.ResumeLayout(False)
        pnlAddBatch.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel41.ResumeLayout(False)
        RoundedPanel41.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel4.ResumeLayout(False)
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlRefreshStudent.ResumeLayout(False)
        pnlRefreshStudent.PerformLayout()
        CType(picRefreshStudent, ComponentModel.ISupportInitialize).EndInit()
        pnlDeleteStudent.ResumeLayout(False)
        pnlDeleteStudent.PerformLayout()
        CType(picDeleteStudent, ComponentModel.ISupportInitialize).EndInit()
        pnlEditStudent.ResumeLayout(False)
        pnlEditStudent.PerformLayout()
        CType(picEditStudent, ComponentModel.ISupportInitialize).EndInit()
        pnlAddStudent.ResumeLayout(False)
        pnlAddStudent.PerformLayout()
        CType(picAddStudent, ComponentModel.ISupportInitialize).EndInit()
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        CType(imgSearch, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents pnlContentSubjects As Panel
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents pnlContentStudents As Panel
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents pnlRefreshStudent As RoundedPanel4
    Friend WithEvents lblRefreshStudent As Label
    Friend WithEvents picRefreshStudent As PictureBox
    Friend WithEvents pnlDeleteStudent As RoundedPanel4
    Friend WithEvents lblDeleteStudent As Label
    Friend WithEvents picDeleteStudent As PictureBox
    Friend WithEvents pnlEditStudent As RoundedPanel4
    Friend WithEvents lblEditStudent As Label
    Friend WithEvents picEditStudent As PictureBox
    Friend WithEvents pnlAddStudent As RoundedPanel4
    Friend WithEvents lblAddStudent As Label
    Friend WithEvents picAddStudent As PictureBox
    Friend WithEvents cboBatchFilter As ComboBox
    Friend WithEvents pnlSearch As RoundedPanel4
    Friend WithEvents lblSearch As TextBox
    Friend WithEvents imgSearch As PictureBox
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlContentBatches As Panel
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents dgvSubjects As DataGridView
    Friend WithEvents pnlRefreshBatches As RoundedPanel4
    Friend WithEvents lblRefreshBatch As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlDeleteBatch As RoundedPanel4
    Friend WithEvents lblDeleteBatch As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pnlEditBatch As RoundedPanel4
    Friend WithEvents lblEditBatch As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pnlAddBatch As RoundedPanel4
    Friend WithEvents lblAddBatch As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents cboSubjectFilter As ComboBox
    Friend WithEvents RoundedPanel41 As RoundedPanel4
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
