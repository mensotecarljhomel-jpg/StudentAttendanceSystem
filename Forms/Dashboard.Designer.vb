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
        pnlPrintMenu = New Panel()
        picPurplePrint = New PictureBox()
        lblPrint = New Label()
        picPrint = New PictureBox()
        pnlPrintIndicator = New Panel()
        pnlAbsencesMenu = New Panel()
        picPurpleAbsences = New PictureBox()
        pnlAbsencesIndicator = New Panel()
        lbAbsences = New Label()
        picAbsences = New PictureBox()
        pnlSubjectsMenu = New Panel()
        pnlSubjectsIndicator = New Panel()
        lblSubjects = New Label()
        picSubjects = New PictureBox()
        pnlBatchInfoMenu = New Panel()
        picPurpleBatchInfo = New PictureBox()
        lblBatchInfo = New Label()
        picBatchInfo = New PictureBox()
        pnlBatchInfoIndicator = New Panel()
        pnlBatchesMenu = New Panel()
        picPurpleBatches = New PictureBox()
        pnlBatchesIndicator = New Panel()
        lblBatches = New Label()
        picBatches = New PictureBox()
        PictureBox8 = New PictureBox()
        pnlDashboardMenu = New Panel()
        picPurpleDashboard = New PictureBox()
        pnlDashboardIndicator = New Panel()
        lblDashboard = New Label()
        picDashboard = New PictureBox()
        pnlStudentsMenu = New Panel()
        picPurpleStudents = New PictureBox()
        pnlStudentsIndicator = New Panel()
        picStudents = New PictureBox()
        lblStudents = New Label()
        Label11 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        pnlSeparator1 = New Panel()
        pnlRight = New Panel()
        pnlContent = New Panel()
        Panel2 = New Panel()
        picPurpleSubjects = New PictureBox()
        Panel3 = New Panel()
        Panel4 = New Panel()
        pnlShadow = New Panel()
        pnlSeparator2 = New Panel()
        pnlTopbar = New Panel()
        ScreenIndicator = New Label()
        pnlSidebar.SuspendLayout()
        pnlPrintMenu.SuspendLayout()
        CType(picPurplePrint, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPrint, ComponentModel.ISupportInitialize).BeginInit()
        pnlAbsencesMenu.SuspendLayout()
        CType(picPurpleAbsences, ComponentModel.ISupportInitialize).BeginInit()
        CType(picAbsences, ComponentModel.ISupportInitialize).BeginInit()
        pnlSubjectsMenu.SuspendLayout()
        CType(picSubjects, ComponentModel.ISupportInitialize).BeginInit()
        pnlBatchInfoMenu.SuspendLayout()
        CType(picPurpleBatchInfo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBatchInfo, ComponentModel.ISupportInitialize).BeginInit()
        pnlBatchesMenu.SuspendLayout()
        CType(picPurpleBatches, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBatches, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        pnlDashboardMenu.SuspendLayout()
        CType(picPurpleDashboard, ComponentModel.ISupportInitialize).BeginInit()
        CType(picDashboard, ComponentModel.ISupportInitialize).BeginInit()
        pnlStudentsMenu.SuspendLayout()
        CType(picPurpleStudents, ComponentModel.ISupportInitialize).BeginInit()
        CType(picStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlRight.SuspendLayout()
        pnlContent.SuspendLayout()
        Panel2.SuspendLayout()
        CType(picPurpleSubjects, ComponentModel.ISupportInitialize).BeginInit()
        pnlTopbar.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(23), CByte(22), CByte(39))
        pnlSidebar.Controls.Add(pnlPrintMenu)
        pnlSidebar.Controls.Add(pnlAbsencesMenu)
        pnlSidebar.Controls.Add(pnlSubjectsMenu)
        pnlSidebar.Controls.Add(pnlBatchInfoMenu)
        pnlSidebar.Controls.Add(pnlBatchesMenu)
        pnlSidebar.Controls.Add(PictureBox8)
        pnlSidebar.Controls.Add(pnlDashboardMenu)
        pnlSidebar.Controls.Add(pnlStudentsMenu)
        pnlSidebar.Controls.Add(Label11)
        pnlSidebar.Controls.Add(Label8)
        pnlSidebar.Controls.Add(Label4)
        pnlSidebar.Controls.Add(Panel1)
        pnlSidebar.Controls.Add(Label2)
        pnlSidebar.Controls.Add(pnlSeparator1)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(188, 861)
        pnlSidebar.TabIndex = 3
        ' 
        ' pnlPrintMenu
        ' 
        pnlPrintMenu.Controls.Add(picPurplePrint)
        pnlPrintMenu.Controls.Add(lblPrint)
        pnlPrintMenu.Controls.Add(picPrint)
        pnlPrintMenu.Controls.Add(pnlPrintIndicator)
        pnlPrintMenu.Location = New Point(-2, 594)
        pnlPrintMenu.Name = "pnlPrintMenu"
        pnlPrintMenu.Size = New Size(180, 43)
        pnlPrintMenu.TabIndex = 16
        ' 
        ' picPurplePrint
        ' 
        picPurplePrint.BackColor = Color.Transparent
        picPurplePrint.Image = CType(resources.GetObject("picPurplePrint.Image"), Image)
        picPurplePrint.Location = New Point(17, 3)
        picPurplePrint.Name = "picPurplePrint"
        picPurplePrint.Size = New Size(33, 36)
        picPurplePrint.SizeMode = PictureBoxSizeMode.Zoom
        picPurplePrint.TabIndex = 25
        picPurplePrint.TabStop = False
        picPurplePrint.Visible = False
        ' 
        ' lblPrint
        ' 
        lblPrint.AutoSize = True
        lblPrint.Font = New Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrint.ForeColor = Color.White
        lblPrint.Location = New Point(56, 4)
        lblPrint.Name = "lblPrint"
        lblPrint.Size = New Size(60, 34)
        lblPrint.TabIndex = 23
        lblPrint.Text = "Print"
        ' 
        ' picPrint
        ' 
        picPrint.BackColor = Color.Transparent
        picPrint.Image = CType(resources.GetObject("picPrint.Image"), Image)
        picPrint.Location = New Point(17, 3)
        picPrint.Name = "picPrint"
        picPrint.Size = New Size(33, 36)
        picPrint.SizeMode = PictureBoxSizeMode.Zoom
        picPrint.TabIndex = 22
        picPrint.TabStop = False
        ' 
        ' pnlPrintIndicator
        ' 
        pnlPrintIndicator.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlPrintIndicator.Location = New Point(2, 0)
        pnlPrintIndicator.Name = "pnlPrintIndicator"
        pnlPrintIndicator.Size = New Size(10, 43)
        pnlPrintIndicator.TabIndex = 16
        pnlPrintIndicator.Visible = False
        ' 
        ' pnlAbsencesMenu
        ' 
        pnlAbsencesMenu.Controls.Add(picPurpleAbsences)
        pnlAbsencesMenu.Controls.Add(pnlAbsencesIndicator)
        pnlAbsencesMenu.Controls.Add(lbAbsences)
        pnlAbsencesMenu.Controls.Add(picAbsences)
        pnlAbsencesMenu.Location = New Point(-2, 439)
        pnlAbsencesMenu.Name = "pnlAbsencesMenu"
        pnlAbsencesMenu.Size = New Size(180, 43)
        pnlAbsencesMenu.TabIndex = 14
        ' 
        ' picPurpleAbsences
        ' 
        picPurpleAbsences.BackColor = Color.Transparent
        picPurpleAbsences.Image = CType(resources.GetObject("picPurpleAbsences.Image"), Image)
        picPurpleAbsences.InitialImage = CType(resources.GetObject("picPurpleAbsences.InitialImage"), Image)
        picPurpleAbsences.Location = New Point(19, -1)
        picPurpleAbsences.Name = "picPurpleAbsences"
        picPurpleAbsences.Size = New Size(30, 46)
        picPurpleAbsences.SizeMode = PictureBoxSizeMode.Zoom
        picPurpleAbsences.TabIndex = 21
        picPurpleAbsences.TabStop = False
        picPurpleAbsences.Visible = False
        ' 
        ' pnlAbsencesIndicator
        ' 
        pnlAbsencesIndicator.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlAbsencesIndicator.Location = New Point(2, 1)
        pnlAbsencesIndicator.Name = "pnlAbsencesIndicator"
        pnlAbsencesIndicator.Size = New Size(10, 43)
        pnlAbsencesIndicator.TabIndex = 19
        pnlAbsencesIndicator.Visible = False
        ' 
        ' lbAbsences
        ' 
        lbAbsences.AutoSize = True
        lbAbsences.Font = New Font("Poppins SemiBold", 14.25F, FontStyle.Bold)
        lbAbsences.ForeColor = Color.White
        lbAbsences.Location = New Point(52, 5)
        lbAbsences.Name = "lbAbsences"
        lbAbsences.Size = New Size(110, 34)
        lbAbsences.TabIndex = 18
        lbAbsences.Text = "Absences"
        ' 
        ' picAbsences
        ' 
        picAbsences.BackColor = Color.Transparent
        picAbsences.Image = CType(resources.GetObject("picAbsences.Image"), Image)
        picAbsences.InitialImage = CType(resources.GetObject("picAbsences.InitialImage"), Image)
        picAbsences.Location = New Point(19, -1)
        picAbsences.Name = "picAbsences"
        picAbsences.Size = New Size(30, 46)
        picAbsences.SizeMode = PictureBoxSizeMode.Zoom
        picAbsences.TabIndex = 17
        picAbsences.TabStop = False
        ' 
        ' pnlSubjectsMenu
        ' 
        pnlSubjectsMenu.Controls.Add(picPurpleSubjects)
        pnlSubjectsMenu.Controls.Add(pnlSubjectsIndicator)
        pnlSubjectsMenu.Controls.Add(lblSubjects)
        pnlSubjectsMenu.Controls.Add(picSubjects)
        pnlSubjectsMenu.Location = New Point(-1, 347)
        pnlSubjectsMenu.Name = "pnlSubjectsMenu"
        pnlSubjectsMenu.Size = New Size(180, 43)
        pnlSubjectsMenu.TabIndex = 14
        ' 
        ' pnlSubjectsIndicator
        ' 
        pnlSubjectsIndicator.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlSubjectsIndicator.Location = New Point(1, 0)
        pnlSubjectsIndicator.Name = "pnlSubjectsIndicator"
        pnlSubjectsIndicator.Size = New Size(10, 43)
        pnlSubjectsIndicator.TabIndex = 17
        pnlSubjectsIndicator.Visible = False
        ' 
        ' lblSubjects
        ' 
        lblSubjects.AutoSize = True
        lblSubjects.Font = New Font("Poppins SemiBold", 14.25F, FontStyle.Bold)
        lblSubjects.ForeColor = Color.White
        lblSubjects.Location = New Point(52, 5)
        lblSubjects.Name = "lblSubjects"
        lblSubjects.Size = New Size(98, 34)
        lblSubjects.TabIndex = 15
        lblSubjects.Text = "Subjects"
        ' 
        ' picSubjects
        ' 
        picSubjects.BackColor = Color.Transparent
        picSubjects.Image = CType(resources.GetObject("picSubjects.Image"), Image)
        picSubjects.Location = New Point(17, 3)
        picSubjects.Name = "picSubjects"
        picSubjects.Size = New Size(33, 36)
        picSubjects.SizeMode = PictureBoxSizeMode.Zoom
        picSubjects.TabIndex = 14
        picSubjects.TabStop = False
        ' 
        ' pnlBatchInfoMenu
        ' 
        pnlBatchInfoMenu.Controls.Add(picPurpleBatchInfo)
        pnlBatchInfoMenu.Controls.Add(lblBatchInfo)
        pnlBatchInfoMenu.Controls.Add(picBatchInfo)
        pnlBatchInfoMenu.Controls.Add(pnlBatchInfoIndicator)
        pnlBatchInfoMenu.Location = New Point(-2, 500)
        pnlBatchInfoMenu.Name = "pnlBatchInfoMenu"
        pnlBatchInfoMenu.Size = New Size(180, 43)
        pnlBatchInfoMenu.TabIndex = 13
        ' 
        ' picPurpleBatchInfo
        ' 
        picPurpleBatchInfo.BackColor = Color.Transparent
        picPurpleBatchInfo.Image = CType(resources.GetObject("picPurpleBatchInfo.Image"), Image)
        picPurpleBatchInfo.Location = New Point(18, 3)
        picPurpleBatchInfo.Name = "picPurpleBatchInfo"
        picPurpleBatchInfo.Size = New Size(33, 36)
        picPurpleBatchInfo.SizeMode = PictureBoxSizeMode.Zoom
        picPurpleBatchInfo.TabIndex = 22
        picPurpleBatchInfo.TabStop = False
        picPurpleBatchInfo.Visible = False
        ' 
        ' lblBatchInfo
        ' 
        lblBatchInfo.AutoSize = True
        lblBatchInfo.Font = New Font("Poppins SemiBold", 14.25F, FontStyle.Bold)
        lblBatchInfo.ForeColor = Color.White
        lblBatchInfo.Location = New Point(52, 4)
        lblBatchInfo.Name = "lblBatchInfo"
        lblBatchInfo.Size = New Size(113, 34)
        lblBatchInfo.TabIndex = 20
        lblBatchInfo.Text = "Batch Info"
        ' 
        ' picBatchInfo
        ' 
        picBatchInfo.BackColor = Color.Transparent
        picBatchInfo.Image = CType(resources.GetObject("picBatchInfo.Image"), Image)
        picBatchInfo.Location = New Point(18, 3)
        picBatchInfo.Name = "picBatchInfo"
        picBatchInfo.Size = New Size(33, 36)
        picBatchInfo.SizeMode = PictureBoxSizeMode.Zoom
        picBatchInfo.TabIndex = 19
        picBatchInfo.TabStop = False
        ' 
        ' pnlBatchInfoIndicator
        ' 
        pnlBatchInfoIndicator.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlBatchInfoIndicator.Location = New Point(2, 1)
        pnlBatchInfoIndicator.Name = "pnlBatchInfoIndicator"
        pnlBatchInfoIndicator.Size = New Size(10, 43)
        pnlBatchInfoIndicator.TabIndex = 15
        pnlBatchInfoIndicator.Visible = False
        ' 
        ' pnlBatchesMenu
        ' 
        pnlBatchesMenu.Controls.Add(picPurpleBatches)
        pnlBatchesMenu.Controls.Add(pnlBatchesIndicator)
        pnlBatchesMenu.Controls.Add(lblBatches)
        pnlBatchesMenu.Controls.Add(picBatches)
        pnlBatchesMenu.Location = New Point(0, 289)
        pnlBatchesMenu.Name = "pnlBatchesMenu"
        pnlBatchesMenu.Size = New Size(180, 43)
        pnlBatchesMenu.TabIndex = 14
        ' 
        ' picPurpleBatches
        ' 
        picPurpleBatches.BackColor = Color.Transparent
        picPurpleBatches.Image = CType(resources.GetObject("picPurpleBatches.Image"), Image)
        picPurpleBatches.Location = New Point(20, 3)
        picPurpleBatches.Name = "picPurpleBatches"
        picPurpleBatches.Size = New Size(28, 34)
        picPurpleBatches.SizeMode = PictureBoxSizeMode.Zoom
        picPurpleBatches.TabIndex = 18
        picPurpleBatches.TabStop = False
        picPurpleBatches.Visible = False
        ' 
        ' pnlBatchesIndicator
        ' 
        pnlBatchesIndicator.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlBatchesIndicator.Location = New Point(1, 0)
        pnlBatchesIndicator.Name = "pnlBatchesIndicator"
        pnlBatchesIndicator.Size = New Size(10, 43)
        pnlBatchesIndicator.TabIndex = 17
        pnlBatchesIndicator.Visible = False
        ' 
        ' lblBatches
        ' 
        lblBatches.AutoSize = True
        lblBatches.Font = New Font("Poppins SemiBold", 14.25F, FontStyle.Bold)
        lblBatches.ForeColor = Color.White
        lblBatches.Location = New Point(50, 3)
        lblBatches.Name = "lblBatches"
        lblBatches.Size = New Size(93, 34)
        lblBatches.TabIndex = 13
        lblBatches.Text = "Batches"
        ' 
        ' picBatches
        ' 
        picBatches.BackColor = Color.Transparent
        picBatches.Image = CType(resources.GetObject("picBatches.Image"), Image)
        picBatches.Location = New Point(20, 3)
        picBatches.Name = "picBatches"
        picBatches.Size = New Size(28, 34)
        picBatches.SizeMode = PictureBoxSizeMode.Zoom
        picBatches.TabIndex = 12
        picBatches.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(8, 0)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(171, 99)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 22
        PictureBox8.TabStop = False
        ' 
        ' pnlDashboardMenu
        ' 
        pnlDashboardMenu.Controls.Add(picPurpleDashboard)
        pnlDashboardMenu.Controls.Add(pnlDashboardIndicator)
        pnlDashboardMenu.Controls.Add(lblDashboard)
        pnlDashboardMenu.Controls.Add(picDashboard)
        pnlDashboardMenu.Location = New Point(1, 147)
        pnlDashboardMenu.Name = "pnlDashboardMenu"
        pnlDashboardMenu.Size = New Size(180, 43)
        pnlDashboardMenu.TabIndex = 12
        ' 
        ' picPurpleDashboard
        ' 
        picPurpleDashboard.BackColor = Color.Transparent
        picPurpleDashboard.Image = CType(resources.GetObject("picPurpleDashboard.Image"), Image)
        picPurpleDashboard.Location = New Point(12, 7)
        picPurpleDashboard.Name = "picPurpleDashboard"
        picPurpleDashboard.Size = New Size(42, 32)
        picPurpleDashboard.SizeMode = PictureBoxSizeMode.StretchImage
        picPurpleDashboard.TabIndex = 18
        picPurpleDashboard.TabStop = False
        picPurpleDashboard.Visible = False
        ' 
        ' pnlDashboardIndicator
        ' 
        pnlDashboardIndicator.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlDashboardIndicator.Location = New Point(-1, 0)
        pnlDashboardIndicator.Name = "pnlDashboardIndicator"
        pnlDashboardIndicator.Size = New Size(10, 43)
        pnlDashboardIndicator.TabIndex = 16
        pnlDashboardIndicator.Visible = False
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboard.ForeColor = Color.White
        lblDashboard.Location = New Point(49, 7)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Size = New Size(124, 34)
        lblDashboard.TabIndex = 15
        lblDashboard.Text = "Dashboard"
        ' 
        ' picDashboard
        ' 
        picDashboard.BackColor = Color.Transparent
        picDashboard.Image = CType(resources.GetObject("picDashboard.Image"), Image)
        picDashboard.Location = New Point(12, 7)
        picDashboard.Name = "picDashboard"
        picDashboard.Size = New Size(42, 32)
        picDashboard.SizeMode = PictureBoxSizeMode.StretchImage
        picDashboard.TabIndex = 14
        picDashboard.TabStop = False
        ' 
        ' pnlStudentsMenu
        ' 
        pnlStudentsMenu.Controls.Add(picPurpleStudents)
        pnlStudentsMenu.Controls.Add(pnlStudentsIndicator)
        pnlStudentsMenu.Controls.Add(picStudents)
        pnlStudentsMenu.Controls.Add(lblStudents)
        pnlStudentsMenu.Location = New Point(2, 232)
        pnlStudentsMenu.Name = "pnlStudentsMenu"
        pnlStudentsMenu.Size = New Size(180, 43)
        pnlStudentsMenu.TabIndex = 2
        ' 
        ' picPurpleStudents
        ' 
        picPurpleStudents.BackColor = Color.Transparent
        picPurpleStudents.Image = CType(resources.GetObject("picPurpleStudents.Image"), Image)
        picPurpleStudents.InitialImage = CType(resources.GetObject("picPurpleStudents.InitialImage"), Image)
        picPurpleStudents.Location = New Point(19, 5)
        picPurpleStudents.Name = "picPurpleStudents"
        picPurpleStudents.Size = New Size(27, 34)
        picPurpleStudents.SizeMode = PictureBoxSizeMode.Zoom
        picPurpleStudents.TabIndex = 15
        picPurpleStudents.TabStop = False
        picPurpleStudents.Visible = False
        ' 
        ' pnlStudentsIndicator
        ' 
        pnlStudentsIndicator.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlStudentsIndicator.Location = New Point(-1, 0)
        pnlStudentsIndicator.Name = "pnlStudentsIndicator"
        pnlStudentsIndicator.Size = New Size(10, 43)
        pnlStudentsIndicator.TabIndex = 13
        pnlStudentsIndicator.Visible = False
        ' 
        ' picStudents
        ' 
        picStudents.BackColor = Color.Transparent
        picStudents.Image = CType(resources.GetObject("picStudents.Image"), Image)
        picStudents.InitialImage = CType(resources.GetObject("picStudents.InitialImage"), Image)
        picStudents.Location = New Point(19, 5)
        picStudents.Name = "picStudents"
        picStudents.Size = New Size(27, 34)
        picStudents.SizeMode = PictureBoxSizeMode.Zoom
        picStudents.TabIndex = 11
        picStudents.TabStop = False
        ' 
        ' lblStudents
        ' 
        lblStudents.AutoSize = True
        lblStudents.Font = New Font("Poppins SemiBold", 14.25F, FontStyle.Bold)
        lblStudents.ForeColor = Color.White
        lblStudents.Location = New Point(49, 5)
        lblStudents.Name = "lblStudents"
        lblStudents.Size = New Size(102, 34)
        lblStudents.TabIndex = 10
        lblStudents.Text = "Students"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(145))
        Label11.Location = New Point(23, 572)
        Label11.Name = "Label11"
        Label11.Size = New Size(53, 19)
        Label11.TabIndex = 19
        Label11.Text = "SYSTEM"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(145))
        Label8.Location = New Point(21, 417)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 19)
        Label8.TabIndex = 14
        Label8.Text = "REPORTS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(145))
        Label4.Location = New Point(17, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 19)
        Label4.TabIndex = 7
        Label4.Text = "MANAGEMENT"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.ForeColor = SystemColors.ControlDarkDark
        Panel1.Location = New Point(0, 762)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(190, 1)
        Panel1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(145))
        Label2.Location = New Point(17, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 19)
        Label2.TabIndex = 1
        Label2.Text = "MAIN SYSTEM"
        ' 
        ' pnlSeparator1
        ' 
        pnlSeparator1.BackColor = Color.White
        pnlSeparator1.ForeColor = SystemColors.ControlDarkDark
        pnlSeparator1.Location = New Point(3, 105)
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
        pnlRight.Size = New Size(1396, 861)
        pnlRight.TabIndex = 2
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        pnlContent.Controls.Add(Panel2)
        pnlContent.Controls.Add(pnlShadow)
        pnlContent.Controls.Add(pnlSeparator2)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Font = New Font("Poppins", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlContent.Location = New Point(0, 73)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1396, 788)
        pnlContent.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Panel4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Font = New Font("Poppins", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(0, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1396, 786)
        Panel2.TabIndex = 2
        ' 
        ' picPurpleSubjects
        ' 
        picPurpleSubjects.BackColor = Color.Transparent
        picPurpleSubjects.Image = CType(resources.GetObject("picPurpleSubjects.Image"), Image)
        picPurpleSubjects.Location = New Point(18, 3)
        picPurpleSubjects.Name = "picPurpleSubjects"
        picPurpleSubjects.Size = New Size(33, 36)
        picPurpleSubjects.SizeMode = PictureBoxSizeMode.Zoom
        picPurpleSubjects.TabIndex = 15
        picPurpleSubjects.TabStop = False
        picPurpleSubjects.Visible = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(234), CByte(230), CByte(248))
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1396, 1)
        Panel3.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(242))
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1396, 1)
        Panel4.TabIndex = 0
        ' 
        ' pnlShadow
        ' 
        pnlShadow.BackColor = Color.FromArgb(CByte(234), CByte(230), CByte(248))
        pnlShadow.Dock = DockStyle.Top
        pnlShadow.Location = New Point(0, 1)
        pnlShadow.Name = "pnlShadow"
        pnlShadow.Size = New Size(1396, 1)
        pnlShadow.TabIndex = 1
        ' 
        ' pnlSeparator2
        ' 
        pnlSeparator2.BackColor = Color.FromArgb(CByte(236), CByte(236), CByte(242))
        pnlSeparator2.Dock = DockStyle.Top
        pnlSeparator2.Location = New Point(0, 0)
        pnlSeparator2.Name = "pnlSeparator2"
        pnlSeparator2.Size = New Size(1396, 1)
        pnlSeparator2.TabIndex = 0
        ' 
        ' pnlTopbar
        ' 
        pnlTopbar.BackColor = Color.White
        pnlTopbar.Controls.Add(ScreenIndicator)
        pnlTopbar.Dock = DockStyle.Top
        pnlTopbar.Location = New Point(0, 0)
        pnlTopbar.Name = "pnlTopbar"
        pnlTopbar.Size = New Size(1396, 73)
        pnlTopbar.TabIndex = 0
        ' 
        ' ScreenIndicator
        ' 
        ScreenIndicator.AutoSize = True
        ScreenIndicator.Font = New Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScreenIndicator.Location = New Point(6, 19)
        ScreenIndicator.Name = "ScreenIndicator"
        ScreenIndicator.Size = New Size(136, 37)
        ScreenIndicator.TabIndex = 2
        ScreenIndicator.Text = "Dashboard"
        ' 
        ' Dashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1584, 861)
        Controls.Add(pnlRight)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlPrintMenu.ResumeLayout(False)
        pnlPrintMenu.PerformLayout()
        CType(picPurplePrint, ComponentModel.ISupportInitialize).EndInit()
        CType(picPrint, ComponentModel.ISupportInitialize).EndInit()
        pnlAbsencesMenu.ResumeLayout(False)
        pnlAbsencesMenu.PerformLayout()
        CType(picPurpleAbsences, ComponentModel.ISupportInitialize).EndInit()
        CType(picAbsences, ComponentModel.ISupportInitialize).EndInit()
        pnlSubjectsMenu.ResumeLayout(False)
        pnlSubjectsMenu.PerformLayout()
        CType(picSubjects, ComponentModel.ISupportInitialize).EndInit()
        pnlBatchInfoMenu.ResumeLayout(False)
        pnlBatchInfoMenu.PerformLayout()
        CType(picPurpleBatchInfo, ComponentModel.ISupportInitialize).EndInit()
        CType(picBatchInfo, ComponentModel.ISupportInitialize).EndInit()
        pnlBatchesMenu.ResumeLayout(False)
        pnlBatchesMenu.PerformLayout()
        CType(picPurpleBatches, ComponentModel.ISupportInitialize).EndInit()
        CType(picBatches, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        pnlDashboardMenu.ResumeLayout(False)
        pnlDashboardMenu.PerformLayout()
        CType(picPurpleDashboard, ComponentModel.ISupportInitialize).EndInit()
        CType(picDashboard, ComponentModel.ISupportInitialize).EndInit()
        pnlStudentsMenu.ResumeLayout(False)
        pnlStudentsMenu.PerformLayout()
        CType(picPurpleStudents, ComponentModel.ISupportInitialize).EndInit()
        CType(picStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlRight.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(picPurpleSubjects, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ScreenIndicator As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents pnlStudentsMenu As Panel
    Friend WithEvents lblStudents As Label
    Friend WithEvents picStudents As PictureBox
    Friend WithEvents pnlDashboardMenu As Panel
    Friend WithEvents pnlDashboardIndicator As Panel
    Friend WithEvents lblDashboard As Label
    Friend WithEvents picDashboard As PictureBox
    Friend WithEvents pnlBatchesMenu As Panel
    Friend WithEvents pnlBatchesIndicator As Panel
    Friend WithEvents lblBatches As Label
    Friend WithEvents picBatches As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlSubjectsMenu As Panel
    Friend WithEvents picSubjects As PictureBox
    Friend WithEvents pnlSubjectsIndicator As Panel
    Friend WithEvents lblSubjects As Label
    Friend WithEvents pnlAbsencesMenu As Panel
    Friend WithEvents pnlAbsencesIndicator As Panel
    Friend WithEvents lbAbsences As Label
    Friend WithEvents picAbsences As PictureBox
    Friend WithEvents pnlPrintMenu As Panel
    Friend WithEvents pnlBatchInfoMenu As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlBatchInfoIndicator As Panel
    Friend WithEvents lblBatchInfo As Label
    Friend WithEvents picBatchInfo As PictureBox
    Friend WithEvents lblPrint As Label
    Friend WithEvents picPrint As PictureBox
    Friend WithEvents pnlPrintIndicator As Panel
    Friend WithEvents pnlStudentsIndicator As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents picPurpleDashboard As PictureBox
    Friend WithEvents picPurplePrint As PictureBox
    Friend WithEvents picPurpleAbsences As PictureBox
    Friend WithEvents picPurpleBatchInfo As PictureBox
    Friend WithEvents picPurpleStudents As PictureBox
    Friend WithEvents picPurpleBatches As PictureBox
    Friend WithEvents picPurpleSubjects As PictureBox

End Class
