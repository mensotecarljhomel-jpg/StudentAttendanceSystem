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
        RoundedPanel1 = New RoundedPanel()
        imgSearch = New PictureBox()
        TextBox1 = New TextBox()
        cboBatchFilter = New ComboBox()
        pnlDeleteBatches = New RoundedPanel4()
        lblDeleteBatches = New Label()
        picDeleteBatches = New PictureBox()
        pnlEditBatches = New RoundedPanel4()
        lblEditBatches = New Label()
        picEditBatches = New PictureBox()
        pnlAddBatches = New RoundedPanel4()
        lblAddBatches = New Label()
        picAddBatches = New PictureBox()
        dgvBatches = New DataGridView()
        pnlContentBatches = New Panel()
        Label1 = New Label()
        RoundedPanel1.SuspendLayout()
        CType(imgSearch, ComponentModel.ISupportInitialize).BeginInit()
        pnlDeleteBatches.SuspendLayout()
        CType(picDeleteBatches, ComponentModel.ISupportInitialize).BeginInit()
        pnlEditBatches.SuspendLayout()
        CType(picEditBatches, ComponentModel.ISupportInitialize).BeginInit()
        pnlAddBatches.SuspendLayout()
        CType(picAddBatches, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvBatches, ComponentModel.ISupportInitialize).BeginInit()
        pnlContentBatches.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        RoundedPanel2.Location = New Point(47, 103)
        RoundedPanel2.Margin = New Padding(3, 2, 3, 2)
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
        Label2.Size = New Size(288, 23)
        Label2.TabIndex = 2
        Label2.Text = "Organize students into batches or sections."
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(imgSearch)
        RoundedPanel1.Controls.Add(TextBox1)
        RoundedPanel1.Controls.Add(cboBatchFilter)
        RoundedPanel1.Controls.Add(pnlDeleteBatches)
        RoundedPanel1.Controls.Add(pnlEditBatches)
        RoundedPanel1.Controls.Add(pnlAddBatches)
        RoundedPanel1.Controls.Add(dgvBatches)
        RoundedPanel1.Location = New Point(42, 103)
        RoundedPanel1.Margin = New Padding(3, 2, 3, 2)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1320, 618)
        RoundedPanel1.TabIndex = 3
        ' 
        ' imgSearch
        ' 
        imgSearch.BackColor = Color.Transparent
        imgSearch.Image = CType(resources.GetObject("imgSearch.Image"), Image)
        imgSearch.Location = New Point(25, 19)
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
        TextBox1.Location = New Point(52, 20)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(192, 30)
        TextBox1.TabIndex = 20
        ' 
        ' cboBatchFilter
        ' 
        cboBatchFilter.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        cboBatchFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboBatchFilter.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboBatchFilter.FormattingEnabled = True
        cboBatchFilter.IntegralHeight = False
        cboBatchFilter.Location = New Point(273, 20)
        cboBatchFilter.Name = "cboBatchFilter"
        cboBatchFilter.Size = New Size(121, 30)
        cboBatchFilter.TabIndex = 18
        ' 
        ' pnlDeleteBatches
        ' 
        pnlDeleteBatches.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        pnlDeleteBatches.Controls.Add(lblDeleteBatches)
        pnlDeleteBatches.Controls.Add(picDeleteBatches)
        pnlDeleteBatches.Cursor = Cursors.Hand
        pnlDeleteBatches.Location = New Point(1020, 18)
        pnlDeleteBatches.Name = "pnlDeleteBatches"
        pnlDeleteBatches.Size = New Size(81, 42)
        pnlDeleteBatches.TabIndex = 16
        ' 
        ' lblDeleteBatches
        ' 
        lblDeleteBatches.AutoSize = True
        lblDeleteBatches.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeleteBatches.ForeColor = Color.White
        lblDeleteBatches.Location = New Point(24, 10)
        lblDeleteBatches.Name = "lblDeleteBatches"
        lblDeleteBatches.Size = New Size(52, 23)
        lblDeleteBatches.TabIndex = 5
        lblDeleteBatches.Text = "Delete"
        ' 
        ' picDeleteBatches
        ' 
        picDeleteBatches.Image = CType(resources.GetObject("picDeleteBatches.Image"), Image)
        picDeleteBatches.Location = New Point(2, 11)
        picDeleteBatches.Name = "picDeleteBatches"
        picDeleteBatches.Size = New Size(23, 19)
        picDeleteBatches.SizeMode = PictureBoxSizeMode.StretchImage
        picDeleteBatches.TabIndex = 6
        picDeleteBatches.TabStop = False
        ' 
        ' pnlEditBatches
        ' 
        pnlEditBatches.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        pnlEditBatches.Controls.Add(lblEditBatches)
        pnlEditBatches.Controls.Add(picEditBatches)
        pnlEditBatches.Cursor = Cursors.Hand
        pnlEditBatches.Location = New Point(1107, 18)
        pnlEditBatches.Name = "pnlEditBatches"
        pnlEditBatches.Size = New Size(64, 42)
        pnlEditBatches.TabIndex = 15
        ' 
        ' lblEditBatches
        ' 
        lblEditBatches.AutoSize = True
        lblEditBatches.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEditBatches.ForeColor = Color.White
        lblEditBatches.Location = New Point(26, 10)
        lblEditBatches.Name = "lblEditBatches"
        lblEditBatches.Size = New Size(35, 23)
        lblEditBatches.TabIndex = 5
        lblEditBatches.Text = "Edit"
        ' 
        ' picEditBatches
        ' 
        picEditBatches.Image = CType(resources.GetObject("picEditBatches.Image"), Image)
        picEditBatches.Location = New Point(3, 11)
        picEditBatches.Name = "picEditBatches"
        picEditBatches.Size = New Size(23, 19)
        picEditBatches.SizeMode = PictureBoxSizeMode.StretchImage
        picEditBatches.TabIndex = 6
        picEditBatches.TabStop = False
        ' 
        ' pnlAddBatches
        ' 
        pnlAddBatches.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlAddBatches.Controls.Add(lblAddBatches)
        pnlAddBatches.Controls.Add(picAddBatches)
        pnlAddBatches.Cursor = Cursors.Hand
        pnlAddBatches.Location = New Point(1178, 18)
        pnlAddBatches.Name = "pnlAddBatches"
        pnlAddBatches.Size = New Size(123, 42)
        pnlAddBatches.TabIndex = 14
        ' 
        ' lblAddBatches
        ' 
        lblAddBatches.AutoSize = True
        lblAddBatches.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddBatches.ForeColor = Color.White
        lblAddBatches.Location = New Point(26, 10)
        lblAddBatches.Name = "lblAddBatches"
        lblAddBatches.Size = New Size(96, 23)
        lblAddBatches.TabIndex = 5
        lblAddBatches.Text = "Add Batches"
        ' 
        ' picAddBatches
        ' 
        picAddBatches.Image = CType(resources.GetObject("picAddBatches.Image"), Image)
        picAddBatches.Location = New Point(4, 11)
        picAddBatches.Name = "picAddBatches"
        picAddBatches.Size = New Size(23, 19)
        picAddBatches.SizeMode = PictureBoxSizeMode.StretchImage
        picAddBatches.TabIndex = 6
        picAddBatches.TabStop = False
        ' 
        ' dgvBatches
        ' 
        dgvBatches.AllowUserToAddRows = False
        dgvBatches.AllowUserToDeleteRows = False
        dgvBatches.BackgroundColor = Color.White
        dgvBatches.BorderStyle = BorderStyle.None
        dgvBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBatches.Cursor = Cursors.Hand
        dgvBatches.Location = New Point(10, 91)
        dgvBatches.Margin = New Padding(3, 2, 3, 2)
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
        pnlContentBatches.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        pnlContentBatches.Controls.Add(RoundedPanel1)
        pnlContentBatches.Controls.Add(RoundedPanel2)
        pnlContentBatches.Controls.Add(Label2)
        pnlContentBatches.Controls.Add(Label1)
        pnlContentBatches.Location = New Point(0, 0)
        pnlContentBatches.Margin = New Padding(3, 2, 3, 2)
        pnlContentBatches.Name = "pnlContentBatches"
        pnlContentBatches.Size = New Size(1396, 788)
        pnlContentBatches.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(37, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 37)
        Label1.TabIndex = 1
        Label1.Text = "Batches"
        ' 
        ' ucBatches
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(pnlContentBatches)
        Margin = New Padding(3, 2, 3, 2)
        Name = "ucBatches"
        Size = New Size(1396, 788)
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(imgSearch, ComponentModel.ISupportInitialize).EndInit()
        pnlDeleteBatches.ResumeLayout(False)
        pnlDeleteBatches.PerformLayout()
        CType(picDeleteBatches, ComponentModel.ISupportInitialize).EndInit()
        pnlEditBatches.ResumeLayout(False)
        pnlEditBatches.PerformLayout()
        CType(picEditBatches, ComponentModel.ISupportInitialize).EndInit()
        pnlAddBatches.ResumeLayout(False)
        pnlAddBatches.PerformLayout()
        CType(picAddBatches, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvBatches, ComponentModel.ISupportInitialize).EndInit()
        pnlContentBatches.ResumeLayout(False)
        pnlContentBatches.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents pnlContentBatches As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBatches As DataGridView
    Friend WithEvents pnlDeleteBatches As RoundedPanel4
    Friend WithEvents lblDeleteBatches As Label
    Friend WithEvents picDeleteBatches As PictureBox
    Friend WithEvents pnlEditBatches As RoundedPanel4
    Friend WithEvents lblEditBatches As Label
    Friend WithEvents picEditBatches As PictureBox
    Friend WithEvents pnlAddBatches As RoundedPanel4
    Friend WithEvents lblAddBatches As Label
    Friend WithEvents picAddBatches As PictureBox
    Friend WithEvents cboBatchFilter As ComboBox
    Friend WithEvents imgSearch As PictureBox
    Friend WithEvents TextBox1 As TextBox

End Class
