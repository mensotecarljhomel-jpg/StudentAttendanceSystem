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
        pnlSchoolYearIndicator.Visible = False
        pnlPrintIndicator.Visible = False

        ' Labels
        lblDashboard.ForeColor = InactiveColor
        lblStudents.ForeColor = InactiveColor
        lblSubjects.ForeColor = InactiveColor
        lblBatches.ForeColor = InactiveColor
        lblSchoolYear.ForeColor = InactiveColor
        lblPrint.ForeColor = InactiveColor

        ' White Icons
        picDashboard.Visible = True
        picStudents.Visible = True
        picSubjects.Visible = True
        picBatches.Visible = True
        picSchoolYear.Visible = True
        picPrint.Visible = True

        ' Purple Icons
        picPurpleDashboard.Visible = False
        picPurpleStudents.Visible = False
        picPurpleBatches.Visible = False
        picPurpleSubjects.Visible = False
        picPurpleSchoolYear.Visible = False
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
    ' Open Dashboard
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
    ' Open Students
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

    '==========================
    ' Open Subjects
    '==========================
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

    '==========================
    ' Open Batches
    '==========================
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

    '==========================
    ' Open School Year
    '==========================
    Private Sub OpenSchoolYear()

        If CurrentPage = "SchoolYear" Then Exit Sub

        CurrentPage = "SchoolYear"

        ResetSidebar()

        pnlSchoolYearIndicator.Visible = True
        lblSchoolYear.ForeColor = ActiveColor

        picSchoolYear.Visible = False
        picPurpleSchoolYear.Visible = True

        ScreenIndicator.Text = "School Year"

        LoadPage(New ucSchoolYear())

    End Sub

    '==========================
    ' Open Print
    '==========================
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

    Private Sub picPurpleSubjects_Click(sender As Object, e As EventArgs) Handles picPurpleSubjects.Click
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

    Private Sub picPurpleBatches_Click(sender As Object, e As EventArgs) Handles picPurpleBatches.Click
        OpenBatches()
    End Sub

    '==========================
    ' School Year Clicks
    '==========================
    Private Sub pnlSchoolYearMenu_Click(sender As Object, e As EventArgs) Handles pnlSchoolYear.Click
        OpenSchoolYear()
    End Sub

    Private Sub lblSchoolYear_Click(sender As Object, e As EventArgs) Handles lblSchoolYear.Click
        OpenSchoolYear()
    End Sub

    Private Sub picSchoolYear_Click(sender As Object, e As EventArgs) Handles picSchoolYear.Click
        OpenSchoolYear()
    End Sub

    Private Sub picPurpleSchoolYear_Click(sender As Object, e As EventArgs) Handles picPurpleSchoolYear.Click
        OpenSchoolYear()
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

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub
End Class