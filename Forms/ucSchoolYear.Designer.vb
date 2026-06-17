<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSchoolYear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSchoolYear))
        pnlContentSchoolYear = New Panel()
        RoundedPanel1 = New RoundedPanel()
        cboSchoolYearFilter = New ComboBox()
        pnlDeleteSchoolYear = New RoundedPanel4()
        lblDeleteSchoolYear = New Label()
        picDeleteSchoolYear = New PictureBox()
        pnlEditSchoolYear = New RoundedPanel4()
        lblEditSchoolYear = New Label()
        picEditSchoolYear = New PictureBox()
        pnlAddSchoolYear = New RoundedPanel4()
        lblAddSchoolYear = New Label()
        picAddSchoolYear = New PictureBox()
        dgvSchoolYear = New DataGridView()
        RoundedPanel2 = New RoundedPanel()
        Label2 = New Label()
        Label1 = New Label()
        imgSearch = New PictureBox()
        TextBox1 = New TextBox()
        RoundedPanel1.SuspendLayout()
        pnlDeleteSchoolYear.SuspendLayout()
        CType(picDeleteSchoolYear, ComponentModel.ISupportInitialize).BeginInit()
        pnlEditSchoolYear.SuspendLayout()
        CType(picEditSchoolYear, ComponentModel.ISupportInitialize).BeginInit()
        pnlAddSchoolYear.SuspendLayout()
        CType(picAddSchoolYear, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvSchoolYear, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgSearch, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlContentSchoolYear
        ' 
        pnlContentSchoolYear.Dock = DockStyle.Fill
        pnlContentSchoolYear.Location = New Point(0, 0)
        pnlContentSchoolYear.Name = "pnlContentSchoolYear"
        pnlContentSchoolYear.Size = New Size(1396, 788)
        pnlContentSchoolYear.TabIndex = 0
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(imgSearch)
        RoundedPanel1.Controls.Add(TextBox1)
        RoundedPanel1.Controls.Add(cboSchoolYearFilter)
        RoundedPanel1.Controls.Add(pnlDeleteSchoolYear)
        RoundedPanel1.Controls.Add(pnlEditSchoolYear)
        RoundedPanel1.Controls.Add(pnlAddSchoolYear)
        RoundedPanel1.Controls.Add(dgvSchoolYear)
        RoundedPanel1.Location = New Point(38, 120)
        RoundedPanel1.Margin = New Padding(3, 2, 3, 2)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1320, 618)
        RoundedPanel1.TabIndex = 7
        ' 
        ' cboSchoolYearFilter
        ' 
        cboSchoolYearFilter.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        cboSchoolYearFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboSchoolYearFilter.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboSchoolYearFilter.FormattingEnabled = True
        cboSchoolYearFilter.IntegralHeight = False
        cboSchoolYearFilter.Location = New Point(273, 20)
        cboSchoolYearFilter.Name = "cboSchoolYearFilter"
        cboSchoolYearFilter.Size = New Size(121, 30)
        cboSchoolYearFilter.TabIndex = 18
        ' 
        ' pnlDeleteSchoolYear
        ' 
        pnlDeleteSchoolYear.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        pnlDeleteSchoolYear.Controls.Add(lblDeleteSchoolYear)
        pnlDeleteSchoolYear.Controls.Add(picDeleteSchoolYear)
        pnlDeleteSchoolYear.Cursor = Cursors.Hand
        pnlDeleteSchoolYear.Location = New Point(1020, 18)
        pnlDeleteSchoolYear.Name = "pnlDeleteSchoolYear"
        pnlDeleteSchoolYear.Size = New Size(81, 42)
        pnlDeleteSchoolYear.TabIndex = 16
        ' 
        ' lblDeleteSchoolYear
        ' 
        lblDeleteSchoolYear.AutoSize = True
        lblDeleteSchoolYear.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeleteSchoolYear.ForeColor = Color.White
        lblDeleteSchoolYear.Location = New Point(24, 10)
        lblDeleteSchoolYear.Name = "lblDeleteSchoolYear"
        lblDeleteSchoolYear.Size = New Size(52, 23)
        lblDeleteSchoolYear.TabIndex = 5
        lblDeleteSchoolYear.Text = "Delete"
        ' 
        ' picDeleteSchoolYear
        ' 
        picDeleteSchoolYear.Image = CType(resources.GetObject("picDeleteSchoolYear.Image"), Image)
        picDeleteSchoolYear.Location = New Point(2, 11)
        picDeleteSchoolYear.Name = "picDeleteSchoolYear"
        picDeleteSchoolYear.Size = New Size(23, 19)
        picDeleteSchoolYear.SizeMode = PictureBoxSizeMode.StretchImage
        picDeleteSchoolYear.TabIndex = 6
        picDeleteSchoolYear.TabStop = False
        ' 
        ' pnlEditSchoolYear
        ' 
        pnlEditSchoolYear.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        pnlEditSchoolYear.Controls.Add(lblEditSchoolYear)
        pnlEditSchoolYear.Controls.Add(picEditSchoolYear)
        pnlEditSchoolYear.Cursor = Cursors.Hand
        pnlEditSchoolYear.Location = New Point(1107, 18)
        pnlEditSchoolYear.Name = "pnlEditSchoolYear"
        pnlEditSchoolYear.Size = New Size(64, 42)
        pnlEditSchoolYear.TabIndex = 15
        ' 
        ' lblEditSchoolYear
        ' 
        lblEditSchoolYear.AutoSize = True
        lblEditSchoolYear.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEditSchoolYear.ForeColor = Color.White
        lblEditSchoolYear.Location = New Point(26, 10)
        lblEditSchoolYear.Name = "lblEditSchoolYear"
        lblEditSchoolYear.Size = New Size(35, 23)
        lblEditSchoolYear.TabIndex = 5
        lblEditSchoolYear.Text = "Edit"
        ' 
        ' picEditSchoolYear
        ' 
        picEditSchoolYear.Image = CType(resources.GetObject("picEditSchoolYear.Image"), Image)
        picEditSchoolYear.Location = New Point(3, 11)
        picEditSchoolYear.Name = "picEditSchoolYear"
        picEditSchoolYear.Size = New Size(23, 19)
        picEditSchoolYear.SizeMode = PictureBoxSizeMode.StretchImage
        picEditSchoolYear.TabIndex = 6
        picEditSchoolYear.TabStop = False
        ' 
        ' pnlAddSchoolYear
        ' 
        pnlAddSchoolYear.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlAddSchoolYear.Controls.Add(lblAddSchoolYear)
        pnlAddSchoolYear.Controls.Add(picAddSchoolYear)
        pnlAddSchoolYear.Cursor = Cursors.Hand
        pnlAddSchoolYear.Location = New Point(1178, 18)
        pnlAddSchoolYear.Name = "pnlAddSchoolYear"
        pnlAddSchoolYear.Size = New Size(123, 42)
        pnlAddSchoolYear.TabIndex = 14
        ' 
        ' lblAddSchoolYear
        ' 
        lblAddSchoolYear.AutoSize = True
        lblAddSchoolYear.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddSchoolYear.ForeColor = Color.White
        lblAddSchoolYear.Location = New Point(26, 10)
        lblAddSchoolYear.Name = "lblAddSchoolYear"
        lblAddSchoolYear.Size = New Size(94, 23)
        lblAddSchoolYear.TabIndex = 5
        lblAddSchoolYear.Text = "Add Student"
        ' 
        ' picAddSchoolYear
        ' 
        picAddSchoolYear.Image = CType(resources.GetObject("picAddSchoolYear.Image"), Image)
        picAddSchoolYear.Location = New Point(4, 11)
        picAddSchoolYear.Name = "picAddSchoolYear"
        picAddSchoolYear.Size = New Size(23, 19)
        picAddSchoolYear.SizeMode = PictureBoxSizeMode.StretchImage
        picAddSchoolYear.TabIndex = 6
        picAddSchoolYear.TabStop = False
        ' 
        ' dgvSchoolYear
        ' 
        dgvSchoolYear.AllowUserToAddRows = False
        dgvSchoolYear.AllowUserToDeleteRows = False
        dgvSchoolYear.BackgroundColor = Color.White
        dgvSchoolYear.BorderStyle = BorderStyle.None
        dgvSchoolYear.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSchoolYear.Cursor = Cursors.Hand
        dgvSchoolYear.Location = New Point(17, 92)
        dgvSchoolYear.Margin = New Padding(3, 2, 3, 2)
        dgvSchoolYear.MultiSelect = False
        dgvSchoolYear.Name = "dgvSchoolYear"
        dgvSchoolYear.ReadOnly = True
        dgvSchoolYear.RowHeadersWidth = 51
        dgvSchoolYear.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSchoolYear.Size = New Size(1300, 511)
        dgvSchoolYear.TabIndex = 11
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        RoundedPanel2.Location = New Point(43, 120)
        RoundedPanel2.Margin = New Padding(3, 2, 3, 2)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(1320, 618)
        RoundedPanel2.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(150))
        Label2.Location = New Point(36, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(288, 23)
        Label2.TabIndex = 6
        Label2.Text = "Organize students into batches or sections."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 37)
        Label1.TabIndex = 5
        Label1.Text = "School Year"
        ' 
        ' imgSearch
        ' 
        imgSearch.BackColor = Color.Transparent
        imgSearch.Image = CType(resources.GetObject("imgSearch.Image"), Image)
        imgSearch.Location = New Point(29, 19)
        imgSearch.Name = "imgSearch"
        imgSearch.Size = New Size(21, 26)
        imgSearch.SizeMode = PictureBoxSizeMode.Zoom
        imgSearch.TabIndex = 19
        imgSearch.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        TextBox1.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(56, 20)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(192, 30)
        TextBox1.TabIndex = 20
        ' 
        ' ucSchoolYear
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        Controls.Add(RoundedPanel1)
        Controls.Add(RoundedPanel2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pnlContentSchoolYear)
        Name = "ucSchoolYear"
        Size = New Size(1396, 788)
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        pnlDeleteSchoolYear.ResumeLayout(False)
        pnlDeleteSchoolYear.PerformLayout()
        CType(picDeleteSchoolYear, ComponentModel.ISupportInitialize).EndInit()
        pnlEditSchoolYear.ResumeLayout(False)
        pnlEditSchoolYear.PerformLayout()
        CType(picEditSchoolYear, ComponentModel.ISupportInitialize).EndInit()
        pnlAddSchoolYear.ResumeLayout(False)
        pnlAddSchoolYear.PerformLayout()
        CType(picAddSchoolYear, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvSchoolYear, ComponentModel.ISupportInitialize).EndInit()
        CType(imgSearch, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlContentSchoolYear As Panel
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents cboSchoolYearFilter As ComboBox
    Friend WithEvents pnlRefreshSchoolYear As RoundedPanel4
    Friend WithEvents lblRefreshSchoolYear As Label
    Friend WithEvents picRefreshSchoolYear As PictureBox
    Friend WithEvents pnlDeleteSchoolYear As RoundedPanel4
    Friend WithEvents lblDeleteSchoolYear As Label
    Friend WithEvents picDeleteSchoolYear As PictureBox
    Friend WithEvents pnlEditSchoolYear As RoundedPanel4
    Friend WithEvents lblEditSchoolYear As Label
    Friend WithEvents picEditSchoolYear As PictureBox
    Friend WithEvents pnlAddSchoolYear As RoundedPanel4
    Friend WithEvents lblAddSchoolYear As Label
    Friend WithEvents picAddSchoolYear As PictureBox
    Friend WithEvents dgvSchoolYear As DataGridView
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents imgSearch As PictureBox
    Friend WithEvents TextBox1 As TextBox

End Class
