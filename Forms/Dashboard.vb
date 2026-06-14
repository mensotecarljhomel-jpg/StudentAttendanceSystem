
Public Class Dashboard

    '==========================
    ' Sidebar Colors
    '==========================
    Private ReadOnly ActiveColor As Color = Color.FromArgb(139, 92, 246)
    Private ReadOnly InactiveColor As Color = Color.White

    '==========================
    ' Current Page
    '==========================
    Private CurrentPage As String = ""

    '==========================
    ' Dashboard Load
    '==========================
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Font = New Font("Poppins", 10)

        ResetSidebar()

        OpenDashboard()

    End Sub

    '==========================
    ' Reset Sidebar
    '==========================
    Private Sub ResetSidebar()

        ' Indicators
        pnlDashboardIndicator.Visible = False
        pnlStudentsIndicator.Visible = False
        pnlSubjectsIndicator.Visible = False
        pnlBatchesIndicator.Visible = False
        pnlBatchInfoIndicator.Visible = False
        pnlAbsencesIndicator.Visible = False
        pnlPrintIndicator.Visible = False

        ' Labels
        lblDashboard.ForeColor = InactiveColor
        lblStudents.ForeColor = InactiveColor
        lblSubjects.ForeColor = InactiveColor
        lblBatches.ForeColor = InactiveColor
        lblBatchInfo.ForeColor = InactiveColor
        lbAbsences.ForeColor = InactiveColor
        lblPrint.ForeColor = InactiveColor

        ' White Icons
        picDashboard.Visible = True
        picStudents.Visible = True
        picSubjects.Visible = True
        picBatches.Visible = True
        picBatchInfo.Visible = True
        picAbsences.Visible = True
        picPrint.Visible = True

        ' Purple Icons
        picPurpleDashboard.Visible = False
        picPurpleStudents.Visible = False
        picPurpleBatches.Visible = False
        picPurpleSubjects.Visible = False
        picPurpleBatchInfo.Visible = False
        picPurpleAbsences.Visible = False
        picPurplePrint.Visible = False

    End Sub

    '==========================
    ' Load UserControl
    '==========================
    Private Sub LoadPage(page As UserControl)

        pnlContent.Controls.Clear()

        page.Dock = DockStyle.Fill

        pnlContent.Controls.Add(page)

    End Sub

    '==========================
    ' Dashboard
    '==========================
    Private Sub OpenDashboard()

        If CurrentPage = "Dashboard" Then Exit Sub

        CurrentPage = "Dashboard"

        ResetSidebar()

        pnlDashboardIndicator.Visible = True
        lblDashboard.ForeColor = ActiveColor

        picDashboard.Visible = False
        picPurpleDashboard.Visible = True

        ScreenIndicator.Text = "Dashboard"

        pnlContent.Controls.Clear()

    End Sub

    '==========================
    ' Students
    '==========================
    Private Sub OpenStudents()

        If CurrentPage = "Students" Then Exit Sub

        CurrentPage = "Students"

        ResetSidebar()

        pnlStudentsIndicator.Visible = True
        lblStudents.ForeColor = ActiveColor

        picStudents.Visible = False
        picPurpleStudents.Visible = True

        ScreenIndicator.Text = "Students"

        LoadPage(New ucStudents())

    End Sub
    Private Sub OpenSubjects()

        If CurrentPage = "Subjects" Then Exit Sub

        CurrentPage = "Subjects"

        ResetSidebar()

        pnlSubjectsIndicator.Visible = True
        lblSubjects.ForeColor = ActiveColor

        picSubjects.Visible = False
        picPurpleSubjects.Visible = True

        ScreenIndicator.Text = "Subjects"

        LoadPage(New ucSubjects())

    End Sub

    Private Sub OpenBatches()

        If CurrentPage = "Batches" Then Exit Sub

        CurrentPage = "Batches"

        ResetSidebar()

        pnlBatchesIndicator.Visible = True
lblBatches.ForeColor = ActiveColor

picBatches.Visible = False
picPurpleBatches.Visible = True

ScreenIndicator.Text = "Batches"

LoadPage(New ucBatches())

    End Sub

    Private Sub OpenBatchInfo()

        If CurrentPage = "BatchInfo" Then Exit Sub

        CurrentPage = "BatchInfo"

        ResetSidebar()

        pnlBatchInfoIndicator.Visible = True
        lblBatchInfo.ForeColor = ActiveColor

        picBatchInfo.Visible = False
        picPurpleBatchInfo.Visible = True

        ScreenIndicator.Text = "Batch Info"

        LoadPage(New ucBatchInfo())

    End Sub

    Private Sub OpenAbsences()

        If CurrentPage = "Absences" Then Exit Sub

        CurrentPage = "Absences"

        ResetSidebar()

        pnlAbsencesIndicator.Visible = True
        lbAbsences.ForeColor = ActiveColor

        picAbsences.Visible = False
        picPurpleAbsences.Visible = True

        ScreenIndicator.Text = "Absences"

        LoadPage(New ucAbsences())

    End Sub

    Private Sub OpenPrint()

        If CurrentPage = "Print" Then Exit Sub

        CurrentPage = "Print"

        ResetSidebar()

        pnlPrintIndicator.Visible = True
        lblPrint.ForeColor = ActiveColor

        picPrint.Visible = False
        picPurplePrint.Visible = True

        ScreenIndicator.Text = "Print"

        LoadPage(New ucPrint())

    End Sub

    '==========================
    ' Dashboard Clicks
    '==========================
    '==========================
    ' Dashboard Clicks
    '==========================
    Private Sub pnlDashboardMenu_Click(sender As Object, e As EventArgs) Handles pnlDashboardMenu.Click
        OpenDashboard()
    End Sub

    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        OpenDashboard()
    End Sub

    Private Sub picDashboard_Click(sender As Object, e As EventArgs) Handles picDashboard.Click
        OpenDashboard()
    End Sub

    Private Sub picPurpleDashboard_Click(sender As Object, e As EventArgs) Handles picPurpleDashboard.Click
        OpenDashboard()
    End Sub

    '==========================
    ' Students Clicks
    '==========================
    Private Sub pnlStudentsMenu_Click(sender As Object, e As EventArgs) Handles pnlStudentsMenu.Click
        OpenStudents()
    End Sub

    Private Sub lblStudents_Click(sender As Object, e As EventArgs) Handles lblStudents.Click
        OpenStudents()
    End Sub

    Private Sub picStudents_Click(sender As Object, e As EventArgs) Handles picStudents.Click
        OpenStudents()
    End Sub

    Private Sub picPurpleStudents_Click(sender As Object, e As EventArgs) Handles picPurpleStudents.Click
        OpenStudents()
    End Sub

    '==========================
    ' Subjects Clicks
    '==========================
    Private Sub pnlSubjectsMenu_Click(sender As Object, e As EventArgs) Handles pnlSubjectsMenu.Click
        OpenSubjects()
    End Sub

    Private Sub lblSubjects_Click(sender As Object, e As EventArgs) Handles lblSubjects.Click
        OpenSubjects()
    End Sub

    Private Sub picSubjects_Click(sender As Object, e As EventArgs) Handles picSubjects.Click
        OpenSubjects()
    End Sub

    Private Sub picPurpleSubjects_Click(sender As Object, e As EventArgs)
        OpenSubjects()
    End Sub

    '==========================
    ' Batches Clicks
    '==========================
    Private Sub pnlBatchesMenu_Click(sender As Object, e As EventArgs) Handles pnlBatchesMenu.Click
        OpenBatches()
    End Sub

    Private Sub lblBatches_Click(sender As Object, e As EventArgs) Handles lblBatches.Click
        OpenBatches()
    End Sub

    Private Sub picBatches_Click(sender As Object, e As EventArgs) Handles picBatches.Click
        OpenBatches()
    End Sub

    Private Sub picPurpleBatches_Click(sender As Object, e As EventArgs)
        OpenBatches()
    End Sub

    '==========================
    ' Batch Info Clicks
    '==========================
    Private Sub pnlBatchInfoMenu_Click(sender As Object, e As EventArgs) Handles pnlBatchInfoMenu.Click
        OpenBatchInfo()
    End Sub

    Private Sub lblBatchInfo_Click(sender As Object, e As EventArgs) Handles lblBatchInfo.Click
        OpenBatchInfo()
    End Sub

    Private Sub picBatchInfo_Click(sender As Object, e As EventArgs) Handles picBatchInfo.Click
        OpenBatchInfo()
    End Sub

    Private Sub picPurpleBatchInfo_Click(sender As Object, e As EventArgs) Handles picPurpleBatchInfo.Click
        OpenBatchInfo()
    End Sub

    '==========================
    ' Absences Clicks
    '==========================
    Private Sub pnlAbsencesMenu_Click(sender As Object, e As EventArgs) Handles pnlAbsencesMenu.Click
        OpenAbsences()
    End Sub

    Private Sub lbAbsences_Click(sender As Object, e As EventArgs) Handles lbAbsences.Click
        OpenAbsences()
    End Sub

    Private Sub picAbsences_Click(sender As Object, e As EventArgs) Handles picAbsences.Click
        OpenAbsences()
    End Sub

    Private Sub picPurpleAbsences_Click(sender As Object, e As EventArgs) Handles picPurpleAbsences.Click
        OpenAbsences()
    End Sub

    '==========================
    ' Print Clicks
    '==========================
    Private Sub pnlPrintMenu_Click(sender As Object, e As EventArgs) Handles pnlPrintMenu.Click
        OpenPrint()
    End Sub

    Private Sub lblPrint_Click(sender As Object, e As EventArgs) Handles lblPrint.Click
        OpenPrint()
    End Sub

    Private Sub picPrint_Click(sender As Object, e As EventArgs) Handles picPrint.Click
        OpenPrint()
    End Sub

    Private Sub picPurplePrint_Click(sender As Object, e As EventArgs) Handles picPurplePrint.Click
        OpenPrint()
    End Sub


End Class