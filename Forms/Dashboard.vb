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
    ' (duplicate Dashboard_Load removed; full implementation preserved near end of file)

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

        ' Labels
        lblDashboard.ForeColor = InactiveColor
        lblStudents.ForeColor = InactiveColor
        lblSubjects.ForeColor = InactiveColor
        lblBatches.ForeColor = InactiveColor
        lblSchoolYear.ForeColor = InactiveColor

        ' White Icons
        picDashboard.Visible = True
        picStudents.Visible = True
        picSubjects.Visible = True
        picBatches.Visible = True
        picSchoolYear.Visible = True

        ' Purple Icons
        picPurpleDashboard.Visible = False
        picPurpleStudents.Visible = False
        picPurpleBatches.Visible = False
        picPurpleSubjects.Visible = False
        picPurpleSchoolYear.Visible = False

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

        ' Print screen removed from sidebar in this build.
        ' Keep method present as stub in case it is reintroduced later.
        If CurrentPage = "Print" Then Exit Sub
        CurrentPage = "Print"
        ResetSidebar()
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
    ' Print-related sidebar handlers removed (controls not present in designer)

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint

    End Sub

    '==========================
    ' Logout handling and display
    '==========================
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Font = New Font("Poppins", 10)

        ResetSidebar()

        ' Setup logout area
        Try
            ' Add username and role labels into pnlLogout
            Dim lblUser As New Label()
            lblUser.Name = "lblLoggedUser"
            lblUser.AutoSize = True
            lblUser.Font = New Font("Poppins", 9, FontStyle.Regular)
            lblUser.ForeColor = Color.White
            lblUser.Location = New Point(8, 4)
            lblUser.Text = If(String.IsNullOrEmpty(CurrentSession.Username), "", CurrentSession.Username)

            Dim lblRole As New Label()
            lblRole.Name = "lblLoggedRole"
            lblRole.AutoSize = True
            lblRole.Font = New Font("Poppins", 8, FontStyle.Italic)
            lblRole.ForeColor = Color.White
            lblRole.Location = New Point(8, 20)
            lblRole.Text = If(String.IsNullOrEmpty(CurrentSession.Role), "", CurrentSession.Role)

            ' Place username and role above the logout panel (outside of pnlLogout)
            Dim offset As Integer = 8
            Dim topPosition As Integer = Math.Max(8, pnlLogout.Top - 60)

            lblUser.Location = New Point(pnlLogout.Left + 2, topPosition)
            lblRole.Location = New Point(pnlLogout.Left + 2, topPosition + 18)

            ' Add to sidebar so they are visually above the logout button
            pnlSidebar.Controls.Add(lblUser)
            pnlSidebar.Controls.Add(lblRole)

            ' Ensure the existing designer Log Out label remains inside pnlLogout and wire its click
            AddHandler pnlLogout.Click, AddressOf pnlLogout_Click
            AddHandler Label1.Click, AddressOf pnlLogout_Click
            AddHandler lblUser.Click, AddressOf pnlNoop_Click
            AddHandler lblRole.Click, AddressOf pnlNoop_Click
        Catch
            ' silent fallback
        End Try

        OpenDashboard()
    End Sub

    Private Sub pnlNoop_Click(sender As Object, e As EventArgs)
        ' placeholder - don't navigate when clicking username/role
    End Sub

    Private Sub pnlLogout_Click(sender As Object, e As EventArgs)
        Try
            CurrentSession.SignOut()
        Catch
        End Try

        Dim f As New frmLogin()
        f.Show()
        Me.Close()
    End Sub
End Class