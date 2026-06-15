<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBatches
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBatches))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        RoundedPanel2 = New RoundedPanel()
        Label2 = New Label()
        lblSearch = New TextBox()
        imgSearch = New PictureBox()
        cboBatchFilter = New ComboBox()
        pnlSearch = New RoundedPanel4()
        lblAddBatch = New Label()
        picAddStudent = New PictureBox()
        pnlAddBatch = New RoundedPanel4()
        lblEditBatch = New Label()
        picEditStudent = New PictureBox()
        pnlEditBatch = New RoundedPanel4()
        lblDeleteBatch = New Label()
        picDeleteStudent = New PictureBox()
        pnlDeleteBatch = New RoundedPanel4()
        lblRefreshBatch = New Label()
        picRefreshStudent = New PictureBox()
        pnlRefreshBatches = New RoundedPanel4()
        RoundedPanel1 = New RoundedPanel()
        dgvBatches = New DataGridView()
        pnlContentBatches = New Panel()
        Label1 = New Label()
        CType(imgSearch, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearch.SuspendLayout()
        CType(picAddStudent, ComponentModel.ISupportInitialize).BeginInit()
        pnlAddBatch.SuspendLayout()
        CType(picEditStudent, ComponentModel.ISupportInitialize).BeginInit()
        pnlEditBatch.SuspendLayout()
        CType(picDeleteStudent, ComponentModel.ISupportInitialize).BeginInit()
        pnlDeleteBatch.SuspendLayout()
        CType(picRefreshStudent, ComponentModel.ISupportInitialize).BeginInit()
        pnlRefreshBatches.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        CType(dgvBatches, ComponentModel.ISupportInitialize).BeginInit()
        pnlContentBatches.SuspendLayout()
        SuspendLayout()
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
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        Label2.Location = New Point(40, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(334, 20)
        Label2.TabIndex = 2
        Label2.Text = "Organize students into batches or sections."
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
        lblSearch.Text = "Manage batches..."
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
        ' cboBatchFilter
        ' 
        cboBatchFilter.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        cboBatchFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboBatchFilter.Font = New Font("Microsoft Sans Serif", 9.75F)
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
        ' pnlAddBatch
        ' 
        pnlAddBatch.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlAddBatch.Controls.Add(lblAddBatch)
        pnlAddBatch.Controls.Add(picAddStudent)
        pnlAddBatch.Cursor = Cursors.Hand
        pnlAddBatch.Location = New Point(1178, 18)
        pnlAddBatch.Name = "pnlAddBatch"
        pnlAddBatch.Size = New Size(123, 42)
        pnlAddBatch.TabIndex = 7
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
        ' pnlEditBatch
        ' 
        pnlEditBatch.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        pnlEditBatch.Controls.Add(lblEditBatch)
        pnlEditBatch.Controls.Add(picEditStudent)
        pnlEditBatch.Cursor = Cursors.Hand
        pnlEditBatch.Location = New Point(1107, 18)
        pnlEditBatch.Name = "pnlEditBatch"
        pnlEditBatch.Size = New Size(64, 42)
        pnlEditBatch.TabIndex = 8
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
        ' pnlDeleteBatch
        ' 
        pnlDeleteBatch.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        pnlDeleteBatch.Controls.Add(lblDeleteBatch)
        pnlDeleteBatch.Controls.Add(picDeleteStudent)
        pnlDeleteBatch.Cursor = Cursors.Hand
        pnlDeleteBatch.Location = New Point(1020, 18)
        pnlDeleteBatch.Name = "pnlDeleteBatch"
        pnlDeleteBatch.Size = New Size(81, 42)
        pnlDeleteBatch.TabIndex = 9
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
        ' pnlRefreshBatches
        ' 
        pnlRefreshBatches.BackColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        pnlRefreshBatches.Controls.Add(lblRefreshBatch)
        pnlRefreshBatches.Controls.Add(picRefreshStudent)
        pnlRefreshBatches.Cursor = Cursors.Hand
        pnlRefreshBatches.Location = New Point(928, 18)
        pnlRefreshBatches.Name = "pnlRefreshBatches"
        pnlRefreshBatches.Size = New Size(86, 42)
        pnlRefreshBatches.TabIndex = 10
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(dgvBatches)
        RoundedPanel1.Controls.Add(pnlRefreshBatches)
        RoundedPanel1.Controls.Add(pnlDeleteBatch)
        RoundedPanel1.Controls.Add(pnlEditBatch)
        RoundedPanel1.Controls.Add(pnlAddBatch)
        RoundedPanel1.Controls.Add(cboBatchFilter)
        RoundedPanel1.Controls.Add(pnlSearch)
        RoundedPanel1.Location = New Point(40, 100)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1323, 615)
        RoundedPanel1.TabIndex = 3
        ' 
        ' dgvBatches
        ' 
        dgvBatches.AllowUserToAddRows = False
        dgvBatches.AllowUserToDeleteRows = False
        dgvBatches.BackgroundColor = Color.White
        dgvBatches.BorderStyle = BorderStyle.None
        dgvBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBatches.Cursor = Cursors.Hand
        dgvBatches.Location = New Point(10, 82)
        dgvBatches.MultiSelect = False
        dgvBatches.Name = "dgvBatches"
        dgvBatches.ReadOnly = True
        dgvBatches.RowHeadersWidth = 51
        dgvBatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBatches.Size = New Size(1300, 511)
        dgvBatches.TabIndex = 11
        ' 
        ' pnlContentBatches
        ' 
        pnlContentBatches.Controls.Add(RoundedPanel1)
        pnlContentBatches.Controls.Add(RoundedPanel2)
        pnlContentBatches.Controls.Add(Label2)
        pnlContentBatches.Controls.Add(Label1)
        pnlContentBatches.Location = New Point(8, 8)
        pnlContentBatches.Name = "pnlContentBatches"
        pnlContentBatches.Size = New Size(1396, 788)
        pnlContentBatches.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(37, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 31)
        Label1.TabIndex = 1
        Label1.Text = "Batches"
        ' 
        ' ucBatches
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlContentBatches)
        Name = "ucBatches"
        Size = New Size(1396, 788)
        CType(imgSearch, ComponentModel.ISupportInitialize).EndInit()
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        CType(picAddStudent, ComponentModel.ISupportInitialize).EndInit()
        pnlAddBatch.ResumeLayout(False)
        pnlAddBatch.PerformLayout()
        CType(picEditStudent, ComponentModel.ISupportInitialize).EndInit()
        pnlEditBatch.ResumeLayout(False)
        pnlEditBatch.PerformLayout()
        CType(picDeleteStudent, ComponentModel.ISupportInitialize).EndInit()
        pnlDeleteBatch.ResumeLayout(False)
        pnlDeleteBatch.PerformLayout()
        CType(picRefreshStudent, ComponentModel.ISupportInitialize).EndInit()
        pnlRefreshBatches.ResumeLayout(False)
        pnlRefreshBatches.PerformLayout()
        RoundedPanel1.ResumeLayout(False)
        CType(dgvBatches, ComponentModel.ISupportInitialize).EndInit()
        pnlContentBatches.ResumeLayout(False)
        pnlContentBatches.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSearch As TextBox
    Friend WithEvents imgSearch As PictureBox
    Friend WithEvents cboBatchFilter As ComboBox
    Friend WithEvents pnlSearch As RoundedPanel4
    Friend WithEvents lblAddBatch As Label
    Friend WithEvents picAddStudent As PictureBox
    Friend WithEvents pnlAddBatch As RoundedPanel4
    Friend WithEvents lblEditBatch As Label
    Friend WithEvents picEditStudent As PictureBox
    Friend WithEvents pnlEditBatch As RoundedPanel4
    Friend WithEvents lblDeleteBatch As Label
    Friend WithEvents picDeleteStudent As PictureBox
    Friend WithEvents pnlDeleteBatch As RoundedPanel4
    Friend WithEvents lblRefreshBatch As Label
    Friend WithEvents picRefreshStudent As PictureBox
    Friend WithEvents pnlRefreshBatches As RoundedPanel4
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents dgvBatches As DataGridView
    Friend WithEvents pnlContentBatches As Panel
    Friend WithEvents Label1 As Label

End Class
