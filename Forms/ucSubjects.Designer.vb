<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSubjects
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSubjects))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        RoundedPanel6 = New RoundedPanel()
        RoundedPanel5 = New RoundedPanel()
        imgSearch = New PictureBox()
        TextBox1 = New TextBox()
        pnlViewRecords = New RoundedPanel4()
        lblViewRecords = New Label()
        picViewRecords = New PictureBox()
        dgvSubjects = New DataGridView()
        pnlDeleteSubject = New RoundedPanel4()
        lblDeleteSubject = New Label()
        picSubjectDelete = New PictureBox()
        pnlEditSubject = New RoundedPanel4()
        lblEditSubject = New Label()
        picSubjectEdit = New PictureBox()
        pnlAddSubject = New RoundedPanel4()
        lblAddSubject = New Label()
        picSubjectAdd = New PictureBox()
        cboSubjectFilter = New ComboBox()
        pnlPrint = New RoundedPanel4()
        lblPrint = New Label()
        picPrint = New PictureBox()
        pnlContentSubjects = New Panel()
        pnlStartClass = New RoundedPanel4()
        lblStartClass = New Label()
        picStartClass = New PictureBox()
        Label2 = New Label()
        lblBatches = New Label()
        RoundedPanel5.SuspendLayout()
        CType(imgSearch, ComponentModel.ISupportInitialize).BeginInit()
        pnlViewRecords.SuspendLayout()
        CType(picViewRecords, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvSubjects, ComponentModel.ISupportInitialize).BeginInit()
        pnlDeleteSubject.SuspendLayout()
        CType(picSubjectDelete, ComponentModel.ISupportInitialize).BeginInit()
        pnlEditSubject.SuspendLayout()
        CType(picSubjectEdit, ComponentModel.ISupportInitialize).BeginInit()
        pnlAddSubject.SuspendLayout()
        CType(picSubjectAdd, ComponentModel.ISupportInitialize).BeginInit()
        pnlPrint.SuspendLayout()
        CType(picPrint, ComponentModel.ISupportInitialize).BeginInit()
        pnlContentSubjects.SuspendLayout()
        pnlStartClass.SuspendLayout()
        CType(picStartClass, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        RoundedPanel6.Location = New Point(45, 108)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(1320, 618)
        RoundedPanel6.TabIndex = 4
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.BackColor = Color.White
        RoundedPanel5.Controls.Add(imgSearch)
        RoundedPanel5.Controls.Add(TextBox1)
        RoundedPanel5.Controls.Add(pnlViewRecords)
        RoundedPanel5.Controls.Add(dgvSubjects)
        RoundedPanel5.Controls.Add(pnlDeleteSubject)
        RoundedPanel5.Controls.Add(pnlEditSubject)
        RoundedPanel5.Controls.Add(pnlAddSubject)
        RoundedPanel5.Controls.Add(cboSubjectFilter)
        RoundedPanel5.Location = New Point(40, 108)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(1320, 618)
        RoundedPanel5.TabIndex = 3
        ' 
        ' imgSearch
        ' 
        imgSearch.BackColor = Color.Transparent
        imgSearch.Image = CType(resources.GetObject("imgSearch.Image"), Image)
        imgSearch.Location = New Point(30, 17)
        imgSearch.Name = "imgSearch"
        imgSearch.Size = New Size(21, 26)
        imgSearch.SizeMode = PictureBoxSizeMode.Zoom
        imgSearch.TabIndex = 15
        imgSearch.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        TextBox1.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(57, 18)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(192, 30)
        TextBox1.TabIndex = 16
        ' 
        ' pnlViewRecords
        ' 
        pnlViewRecords.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        pnlViewRecords.Controls.Add(lblViewRecords)
        pnlViewRecords.Controls.Add(picViewRecords)
        pnlViewRecords.Cursor = Cursors.Hand
        pnlViewRecords.Location = New Point(927, 18)
        pnlViewRecords.Name = "pnlViewRecords"
        pnlViewRecords.Size = New Size(74, 42)
        pnlViewRecords.TabIndex = 14
        ' 
        ' lblViewRecords
        ' 
        lblViewRecords.AutoSize = True
        lblViewRecords.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblViewRecords.ForeColor = Color.White
        lblViewRecords.Location = New Point(24, 10)
        lblViewRecords.Name = "lblViewRecords"
        lblViewRecords.Size = New Size(42, 23)
        lblViewRecords.TabIndex = 5
        lblViewRecords.Text = "View"
        ' 
        ' picViewRecords
        ' 
        picViewRecords.Location = New Point(4, 11)
        picViewRecords.Name = "picViewRecords"
        picViewRecords.Size = New Size(23, 19)
        picViewRecords.SizeMode = PictureBoxSizeMode.StretchImage
        picViewRecords.TabIndex = 6
        picViewRecords.TabStop = False
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
        ' pnlDeleteSubject
        ' 
        pnlDeleteSubject.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        pnlDeleteSubject.Controls.Add(lblDeleteSubject)
        pnlDeleteSubject.Controls.Add(picSubjectDelete)
        pnlDeleteSubject.Cursor = Cursors.Hand
        pnlDeleteSubject.Location = New Point(1007, 18)
        pnlDeleteSubject.Name = "pnlDeleteSubject"
        pnlDeleteSubject.Size = New Size(94, 42)
        pnlDeleteSubject.TabIndex = 9
        ' 
        ' lblDeleteSubject
        ' 
        lblDeleteSubject.AutoSize = True
        lblDeleteSubject.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeleteSubject.ForeColor = Color.White
        lblDeleteSubject.Location = New Point(24, 10)
        lblDeleteSubject.Name = "lblDeleteSubject"
        lblDeleteSubject.Size = New Size(52, 23)
        lblDeleteSubject.TabIndex = 5
        lblDeleteSubject.Text = "Delete"
        ' 
        ' picSubjectDelete
        ' 
        picSubjectDelete.Image = CType(resources.GetObject("picSubjectDelete.Image"), Image)
        picSubjectDelete.Location = New Point(2, 11)
        picSubjectDelete.Name = "picSubjectDelete"
        picSubjectDelete.Size = New Size(23, 19)
        picSubjectDelete.SizeMode = PictureBoxSizeMode.StretchImage
        picSubjectDelete.TabIndex = 6
        picSubjectDelete.TabStop = False
        ' 
        ' pnlEditSubject
        ' 
        pnlEditSubject.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        pnlEditSubject.Controls.Add(lblEditSubject)
        pnlEditSubject.Controls.Add(picSubjectEdit)
        pnlEditSubject.Cursor = Cursors.Hand
        pnlEditSubject.Location = New Point(1107, 18)
        pnlEditSubject.Name = "pnlEditSubject"
        pnlEditSubject.Size = New Size(64, 42)
        pnlEditSubject.TabIndex = 8
        ' 
        ' lblEditSubject
        ' 
        lblEditSubject.AutoSize = True
        lblEditSubject.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEditSubject.ForeColor = Color.White
        lblEditSubject.Location = New Point(26, 10)
        lblEditSubject.Name = "lblEditSubject"
        lblEditSubject.Size = New Size(35, 23)
        lblEditSubject.TabIndex = 5
        lblEditSubject.Text = "Edit"
        ' 
        ' picSubjectEdit
        ' 
        picSubjectEdit.Image = CType(resources.GetObject("picSubjectEdit.Image"), Image)
        picSubjectEdit.Location = New Point(3, 11)
        picSubjectEdit.Name = "picSubjectEdit"
        picSubjectEdit.Size = New Size(23, 19)
        picSubjectEdit.SizeMode = PictureBoxSizeMode.StretchImage
        picSubjectEdit.TabIndex = 6
        picSubjectEdit.TabStop = False
        ' 
        ' pnlAddSubject
        ' 
        pnlAddSubject.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlAddSubject.Controls.Add(lblAddSubject)
        pnlAddSubject.Controls.Add(picSubjectAdd)
        pnlAddSubject.Cursor = Cursors.Hand
        pnlAddSubject.Location = New Point(1178, 18)
        pnlAddSubject.Name = "pnlAddSubject"
        pnlAddSubject.Size = New Size(123, 42)
        pnlAddSubject.TabIndex = 7
        ' 
        ' lblAddSubject
        ' 
        lblAddSubject.AutoSize = True
        lblAddSubject.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddSubject.ForeColor = Color.White
        lblAddSubject.Location = New Point(26, 10)
        lblAddSubject.Name = "lblAddSubject"
        lblAddSubject.Size = New Size(99, 23)
        lblAddSubject.TabIndex = 5
        lblAddSubject.Text = "Add Subjects"
        ' 
        ' picSubjectAdd
        ' 
        picSubjectAdd.Image = CType(resources.GetObject("picSubjectAdd.Image"), Image)
        picSubjectAdd.Location = New Point(4, 11)
        picSubjectAdd.Name = "picSubjectAdd"
        picSubjectAdd.Size = New Size(23, 19)
        picSubjectAdd.SizeMode = PictureBoxSizeMode.StretchImage
        picSubjectAdd.TabIndex = 6
        picSubjectAdd.TabStop = False
        ' 
        ' cboSubjectFilter
        ' 
        cboSubjectFilter.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        cboSubjectFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboSubjectFilter.Font = New Font("Microsoft Sans Serif", 9.75F)
        cboSubjectFilter.FormattingEnabled = True
        cboSubjectFilter.Location = New Point(273, 20)
        cboSubjectFilter.Name = "cboSubjectFilter"
        cboSubjectFilter.Size = New Size(121, 24)
        cboSubjectFilter.TabIndex = 1
        ' 
        ' pnlPrint
        ' 
        pnlPrint.BackColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        pnlPrint.Controls.Add(lblPrint)
        pnlPrint.Controls.Add(picPrint)
        pnlPrint.Cursor = Cursors.Hand
        pnlPrint.Location = New Point(1129, 60)
        pnlPrint.Name = "pnlPrint"
        pnlPrint.Size = New Size(82, 42)
        pnlPrint.TabIndex = 12
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
        ' pnlContentSubjects
        ' 
        pnlContentSubjects.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        pnlContentSubjects.Controls.Add(pnlPrint)
        pnlContentSubjects.Controls.Add(pnlStartClass)
        pnlContentSubjects.Controls.Add(RoundedPanel5)
        pnlContentSubjects.Controls.Add(Label2)
        pnlContentSubjects.Controls.Add(lblBatches)
        pnlContentSubjects.Controls.Add(RoundedPanel6)
        pnlContentSubjects.Dock = DockStyle.Fill
        pnlContentSubjects.Location = New Point(0, 0)
        pnlContentSubjects.Name = "pnlContentSubjects"
        pnlContentSubjects.Size = New Size(1396, 788)
        pnlContentSubjects.TabIndex = 0
        ' 
        ' pnlStartClass
        ' 
        pnlStartClass.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlStartClass.Controls.Add(lblStartClass)
        pnlStartClass.Controls.Add(picStartClass)
        pnlStartClass.Cursor = Cursors.Hand
        pnlStartClass.Location = New Point(1218, 60)
        pnlStartClass.Name = "pnlStartClass"
        pnlStartClass.Size = New Size(123, 42)
        pnlStartClass.TabIndex = 15
        ' 
        ' lblStartClass
        ' 
        lblStartClass.AutoSize = True
        lblStartClass.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStartClass.ForeColor = Color.White
        lblStartClass.Location = New Point(32, 10)
        lblStartClass.Name = "lblStartClass"
        lblStartClass.Size = New Size(83, 23)
        lblStartClass.TabIndex = 5
        lblStartClass.Text = "Start Class"
        ' 
        ' picStartClass
        ' 
        picStartClass.ErrorImage = CType(resources.GetObject("picStartClass.ErrorImage"), Image)
        picStartClass.Image = CType(resources.GetObject("picStartClass.Image"), Image)
        picStartClass.Location = New Point(4, 11)
        picStartClass.Name = "picStartClass"
        picStartClass.Size = New Size(23, 19)
        picStartClass.SizeMode = PictureBoxSizeMode.StretchImage
        picStartClass.TabIndex = 6
        picStartClass.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        Label2.Location = New Point(40, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(307, 23)
        Label2.TabIndex = 6
        Label2.Text = "Manage subjects and assign them to batches"
        ' 
        ' lblBatches
        ' 
        lblBatches.AutoSize = True
        lblBatches.Font = New Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBatches.Location = New Point(37, 33)
        lblBatches.Name = "lblBatches"
        lblBatches.Size = New Size(111, 37)
        lblBatches.TabIndex = 5
        lblBatches.Text = "Subjects"
        ' 
        ' ucSubjects
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(pnlContentSubjects)
        Name = "ucSubjects"
        Size = New Size(1396, 788)
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        CType(imgSearch, ComponentModel.ISupportInitialize).EndInit()
        pnlViewRecords.ResumeLayout(False)
        pnlViewRecords.PerformLayout()
        CType(picViewRecords, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvSubjects, ComponentModel.ISupportInitialize).EndInit()
        pnlDeleteSubject.ResumeLayout(False)
        pnlDeleteSubject.PerformLayout()
        CType(picSubjectDelete, ComponentModel.ISupportInitialize).EndInit()
        pnlEditSubject.ResumeLayout(False)
        pnlEditSubject.PerformLayout()
        CType(picSubjectEdit, ComponentModel.ISupportInitialize).EndInit()
        pnlAddSubject.ResumeLayout(False)
        pnlAddSubject.PerformLayout()
        CType(picSubjectAdd, ComponentModel.ISupportInitialize).EndInit()
        pnlPrint.ResumeLayout(False)
        pnlPrint.PerformLayout()
        CType(picPrint, ComponentModel.ISupportInitialize).EndInit()
        pnlContentSubjects.ResumeLayout(False)
        pnlContentSubjects.PerformLayout()
        pnlStartClass.ResumeLayout(False)
        pnlStartClass.PerformLayout()
        CType(picStartClass, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents dgvSubjects As DataGridView
    Friend WithEvents pnlDeleteSubject As RoundedPanel4
    Friend WithEvents lblDeleteSubject As Label
    Friend WithEvents picSubjectDelete As PictureBox
    Friend WithEvents pnlEditSubject As RoundedPanel4
    Friend WithEvents lblEditSubject As Label
    Friend WithEvents picSubjectEdit As PictureBox
    Friend WithEvents pnlAddSubject As RoundedPanel4
    Friend WithEvents lblAddSubject As Label
    Friend WithEvents picSubjectAdd As PictureBox
    Friend WithEvents pnlViewRecords As RoundedPanel4
    Friend WithEvents lblViewRecords As Label
    Friend WithEvents picViewRecords As PictureBox
    Friend WithEvents cboSubjectFilter As ComboBox
    Friend WithEvents pnlContentSubjects As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBatches As Label
    Friend WithEvents pnlPrint As RoundedPanel4
    Friend WithEvents lblPrint As Label
    Friend WithEvents picPrint As PictureBox
    Friend WithEvents pnlStartClass As RoundedPanel4
    Friend WithEvents lblStartClass As Label
    Friend WithEvents picStartClass As PictureBox
    Friend WithEvents imgSearch As PictureBox
    Friend WithEvents TextBox1 As TextBox

End Class
