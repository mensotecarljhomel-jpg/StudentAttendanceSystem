Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Font = New Font("Poppins", 10)

        ' Hide indicator when the app starts
        pnlStudentsIndicator.Visible = False
    End Sub

    '==========================
    ' Reset Sidebar
    '==========================
    Private Sub ResetSidebar()

        ' Hide all indicators
        pnlStudentsIndicator.Visible = False

        ' Reset text colors
        lblStudents.ForeColor = Color.White

        ' Later we will reset all icons here
        ' picStudents.Image = My.Resources.students_white

    End Sub

    '==========================
    ' Open Students
    '==========================
    Private Sub OpenStudents()

        ResetSidebar()

        ' Highlight Students
        pnlStudentsIndicator.Visible = True

        ' Change text color
        lblStudents.ForeColor = Color.FromArgb(128, 0, 255)

        ' Later:
        ' picStudents.Image = My.Resources.students_purple

        ' Load Students UserControl
        pnlContent.Controls.Clear()

        Dim studentPage As New ucStudents()
        studentPage.Dock = DockStyle.Fill

        pnlContent.Controls.Add(studentPage)

    End Sub

    '==========================
    ' Click Events
    '==========================

    Private Sub pnlStudentsMenu_Click(sender As Object, e As EventArgs) Handles pnlStudentsMenu.Click
        OpenStudents
    End Sub

    Private Sub lblStudents_Click(sender As Object, e As EventArgs) Handles lblStudents.Click
        OpenStudents
    End Sub

    Private Sub picStudents_Click(sender As Object, e As EventArgs) Handles picStudents.Click
        OpenStudents
    End Sub

    Private Sub picDashboard_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles pnlDashboardMenu.Paint

    End Sub

    Private Sub picSubjects_Click(sender As Object, e As EventArgs) Handles picSubjects.Click

    End Sub
End Class