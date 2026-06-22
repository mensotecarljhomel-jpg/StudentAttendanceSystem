Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

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

    ' Public method to refresh dashboard data when school year changes
    Public Sub RefreshDashboard()
        If CurrentPage <> "Dashboard" Then Return
        Try
            BuildDashboard()
        Catch ex As Exception
            ' non-fatal
        End Try
    End Sub

    ' helper to draw rounded rectangles
    Private Sub FillRoundedRect(g As Graphics, brush As Brush, rect As Rectangle, radius As Integer)
        Using path As New GraphicsPath()
            Dim d = radius * 2
            path.AddArc(rect.Left, rect.Top, d, d, 180, 90)
            path.AddArc(rect.Right - d, rect.Top, d, d, 270, 90)
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
            path.AddArc(rect.Left, rect.Bottom - d, d, d, 90, 90)
            path.CloseFigure()
            g.FillPath(brush, path)
        End Using
    End Sub

    ' create rounded graphics path
    Private Function CreateRoundedPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d = radius * 2
        path.AddArc(rect.Left, rect.Top, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Top, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub SetRoundedRegion(ctrl As Control, radius As Integer)
        If ctrl Is Nothing Then Return
        Dim r As Rectangle = New Rectangle(0, 0, ctrl.Width, ctrl.Height)
        Using p As GraphicsPath = CreateRoundedPath(r, radius)
            ctrl.Region = New Region(p)
        End Using
    End Sub

    Private Sub DrawRoundedBorder(g As Graphics, rect As Rectangle, radius As Integer, pen As Pen)
        Using p As GraphicsPath = CreateRoundedPath(rect, radius)
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.DrawPath(pen, p)
        End Using
    End Sub

    '==========================
    ' Dashboard UI Builder
    '==========================
    Private Sub BuildDashboard()
        ' Clear existing controls
        pnlContent.Controls.Clear()

        pnlContent.AutoScroll = True

        Dim margin As Integer = 24
        ' extra vertical space reserved for showing selected School Year
        Dim topOffset As Integer = 28
        Dim cardH As Integer = 96
        Dim spacing As Integer = 12

        ' Fetch live stats from DB
        Dim totalStudents As Integer = 0
        Dim totalBatches As Integer = 0
        Dim totalSubjects As Integer = 0
        Dim totalAtRisk As Integer = 0
        Dim activeSchoolYearId As Integer = 0
        Dim activeSchoolYearLabel As String = "(none)"

        Try
            OpenConnection()

            ' determine active school year (if any)
            Try
                Dim syCmd As New MySqlCommand("SELECT schoolyear_id, school_year FROM school_years WHERE IFNULL(is_active,0)=1 LIMIT 1", Connection)
                Using syR = syCmd.ExecuteReader()
                    If syR.Read() Then
                        activeSchoolYearId = Convert.ToInt32(syR("schoolyear_id"))
                        activeSchoolYearLabel = syR("school_year").ToString()
                    End If
                End Using
            Catch
                activeSchoolYearId = 0
            End Try

            If activeSchoolYearId > 0 Then
                Dim s1 As New MySqlCommand("SELECT COUNT(*) FROM students s INNER JOIN batches b ON s.batch_id = b.batch_id WHERE b.schoolyear_id = @sy", Connection)
                s1.Parameters.AddWithValue("@sy", activeSchoolYearId)
                Dim obj1 = s1.ExecuteScalar()
                If obj1 IsNot Nothing Then Integer.TryParse(obj1.ToString(), totalStudents)
            Else
                Dim cmd1 As New MySqlCommand("SELECT COUNT(*) FROM students", Connection)
                Dim obj1 = cmd1.ExecuteScalar()
                If obj1 IsNot Nothing Then Integer.TryParse(obj1.ToString(), totalStudents)
            End If

            If activeSchoolYearId > 0 Then
                Dim cmd2 As New MySqlCommand("SELECT COUNT(*) FROM batches WHERE schoolyear_id = @sy", Connection)
                cmd2.Parameters.AddWithValue("@sy", activeSchoolYearId)
                Dim obj2 = cmd2.ExecuteScalar()
                If obj2 IsNot Nothing Then Integer.TryParse(obj2.ToString(), totalBatches)
            Else
                Dim cmd2 As New MySqlCommand("SELECT COUNT(*) FROM batches", Connection)
                Dim obj2 = cmd2.ExecuteScalar()
                If obj2 IsNot Nothing Then Integer.TryParse(obj2.ToString(), totalBatches)
            End If

            ' Count subjects relevant to the selected school year by looking at attendance sessions
            If activeSchoolYearId > 0 Then

                Dim cmd3 As New MySqlCommand(
        "SELECT COUNT(*)
         FROM subjects s
         INNER JOIN batches b
            ON s.batch_id = b.batch_id
         WHERE b.schoolyear_id = @sy",
         Connection)

                cmd3.Parameters.AddWithValue("@sy", activeSchoolYearId)

                Dim obj3 = cmd3.ExecuteScalar()

                If obj3 IsNot Nothing Then
                    Integer.TryParse(obj3.ToString(), totalSubjects)
                End If

            Else

                Dim cmd3 As New MySqlCommand("SELECT COUNT(*) FROM subjects", Connection)

                Dim obj3 = cmd3.ExecuteScalar()

                If obj3 IsNot Nothing Then
                    Integer.TryParse(obj3.ToString(), totalSubjects)
                End If

            End If

            ' students at risk: students who have <75% attendance in any subject
            Dim atRiskSql As String =
                "SELECT COUNT(DISTINCT t.student_number) FROM (" &
                "SELECT ar.student_number, ses.subject_id, " &
                "SUM(CASE WHEN ar.status IN ('Present','Excused') THEN 1 ELSE 0 END) AS presents, " &
                "COUNT(ar.record_id) AS total " &
                "FROM attendance_records ar " &
                "INNER JOIN attendance_sessions ses ON ar.session_id = ses.session_id "

            If activeSchoolYearId > 0 Then
                atRiskSql &= " WHERE ses.schoolyear_id = @sy "
            End If

            atRiskSql &= " GROUP BY ar.student_number, ses.subject_id " &
                "HAVING total > 0 AND (presents/total) < 0.75) t"

            Dim cmd4 As New MySqlCommand(atRiskSql, Connection)
            If activeSchoolYearId > 0 Then cmd4.Parameters.AddWithValue("@sy", activeSchoolYearId)
            Dim obj4 = cmd4.ExecuteScalar()
            If obj4 IsNot Nothing Then Integer.TryParse(obj4.ToString(), totalAtRisk)

        Catch ex As Exception
            ' on error, leave counts as zero and show a non-blocking message
            MessageBox.Show("Dashboard DB error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            CloseConnection()
        End Try

        Dim stats As New List(Of (String, String, Color)) From {
            ("Total students", totalStudents.ToString(), ActiveColor),
            ("Sections", totalBatches.ToString(), ActiveColor),
            ("Subjects", totalSubjects.ToString(), ActiveColor),
            ("Students at risk", totalAtRisk.ToString(), Color.FromArgb(220, 38, 38))
        }

        ' Display currently selected School Year at the top of the Dashboard
        Dim syLabel As New Label()
        syLabel.Font = New Font("Poppins", 10, FontStyle.Bold)
        syLabel.ForeColor = Color.FromArgb(31, 41, 55)
        If activeSchoolYearId > 0 Then
            syLabel.Text = "School Year: " & activeSchoolYearLabel
        Else
            syLabel.Text = "School Year: (none active)"
        End If
        syLabel.AutoSize = True
        syLabel.Location = New Point(margin, 6)
        pnlContent.Controls.Add(syLabel)

        ' layout: four equal-width cards filling available width
        Dim cardsContainerWidth = pnlContent.ClientSize.Width - margin * 2
        Dim cardWDynamic = CInt((cardsContainerWidth - (spacing * 3)) / 4)
        Dim x As Integer = margin
        For i As Integer = 0 To stats.Count - 1
            Dim s = stats(i)
            Dim p As New RoundedPanel2()
            p.Size = New Size(cardWDynamic, cardH)
            p.Location = New Point(x, margin + topOffset)
            p.BackColor = Color.White
            p.Margin = New Padding(6)
            p.Padding = New Padding(12)

            Dim title As New Label()
            title.Text = s.Item1
            title.Font = New Font("Poppins", 9)
            title.ForeColor = Color.FromArgb(75, 85, 99)
            title.AutoSize = True
            title.Location = New Point(16, 12)

            Dim val As New Label()
            val.Text = s.Item2
            val.Font = New Font("Poppins", 22, FontStyle.Bold)
            val.ForeColor = s.Item3
            val.AutoSize = True
            val.Location = New Point(16, 40)

            p.Controls.Add(title)
            p.Controls.Add(val)

            pnlContent.Controls.Add(p)

            x += p.Width + spacing
        Next

        ' The Setup Guide will be added by AddSetupGuideCard called from OpenDashboard

        ' Section header
        ' No extra top gap reserved (setup guide shown as dialog) - place content higher
        Dim extraTop As Integer = 0
        Dim headerY = margin + topOffset + cardH + 20 + extraTop
        Dim header As New Label()
        header.Text = "Attendance per subject - by section"
        header.Font = New Font("Poppins", 11, FontStyle.Bold)
        header.ForeColor = Color.FromArgb(51, 65, 85)
        header.Location = New Point(margin, headerY)
        header.AutoSize = True
        pnlContent.Controls.Add(header)


        ' Add subject cards grid (2 columns) - load from DB
        Dim subjectsStartY = headerY + 36
        Dim cardW As Integer = (pnlContent.ClientSize.Width - margin * 2 - spacing) \ 2

        Dim subjects As New List(Of (Integer, String))
        Try
            OpenConnection()
            Dim subjCmd As MySqlCommand
            If activeSchoolYearId > 0 Then
                subjCmd = New MySqlCommand(
"SELECT s.subject_id,
        s.subject_name
 FROM subjects s
 INNER JOIN batches b
     ON s.batch_id = b.batch_id
 WHERE b.schoolyear_id = @sy
 ORDER BY s.subject_name",
 Connection)

                subjCmd.Parameters.AddWithValue("@sy", activeSchoolYearId)
            Else
                subjCmd = New MySqlCommand(
"SELECT subject_id, subject_name
 FROM subjects
 ORDER BY subject_name",
 Connection)
            End If

            Using rdr As MySqlDataReader = subjCmd.ExecuteReader()
                While rdr.Read()
                    subjects.Add((Convert.ToInt32(rdr("subject_id")), rdr("subject_name").ToString()))
                End While
            End Using
            CloseConnection()
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show("Failed to load subjects: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Dim colW = cardW
        Dim left = margin
        Dim top = subjectsStartY
        Dim col = 0

        For Each subj In subjects
            Dim sid = subj.Item1
            Dim sname = subj.Item2

            ' get sessions held and per-batch attendance
            Dim sessionsHeld As Integer = 0
            Dim sectionStats As New List(Of (String, Integer, Integer))

            Try
                OpenConnection()
                Dim scmd As MySqlCommand
                If activeSchoolYearId > 0 Then
                    scmd = New MySqlCommand("SELECT COUNT(DISTINCT session_id) FROM attendance_sessions WHERE subject_id=@sid AND schoolyear_id = @sy", Connection)
                    scmd.Parameters.AddWithValue("@sid", sid)
                    scmd.Parameters.AddWithValue("@sy", activeSchoolYearId)
                Else
                    scmd = New MySqlCommand("SELECT COUNT(DISTINCT session_id) FROM attendance_sessions WHERE subject_id=@sid", Connection)
                    scmd.Parameters.AddWithValue("@sid", sid)
                End If
                Dim sObj = scmd.ExecuteScalar()
                If sObj IsNot Nothing Then Integer.TryParse(sObj.ToString(), sessionsHeld)

                Dim perSql As String = "SELECT b.batch_name AS batch_name, " &
                                       "SUM(CASE WHEN ar.status IN ('Present','Excused') THEN 1 ELSE 0 END) AS presents, " &
                                       "COUNT(ar.record_id) AS total " &
                                       "FROM attendance_sessions ses " &
                                       "LEFT JOIN attendance_records ar ON ses.session_id = ar.session_id " &
                                       "LEFT JOIN batches b ON ses.batch_id = b.batch_id " &
                                       "WHERE ses.subject_id = @sid "

                If activeSchoolYearId > 0 Then
                    perSql &= " AND ses.schoolyear_id = @sy "
                End If

                perSql &= " GROUP BY b.batch_id, b.batch_name"

                Dim pCmd As New MySqlCommand(perSql, Connection)
                pCmd.Parameters.AddWithValue("@sid", sid)
                If activeSchoolYearId > 0 Then pCmd.Parameters.AddWithValue("@sy", activeSchoolYearId)
                Using pr As MySqlDataReader = pCmd.ExecuteReader()
                    While pr.Read()
                        Dim batchName = If(pr("batch_name") IsNot DBNull.Value, pr("batch_name").ToString(), "")
                        Dim presents = 0
                        Dim total = 0
                        If pr("presents") IsNot DBNull.Value Then Integer.TryParse(pr("presents").ToString(), presents)
                        If pr("total") IsNot DBNull.Value Then Integer.TryParse(pr("total").ToString(), total)
                        sectionStats.Add((batchName, presents, total))
                    End While
                End Using

                CloseConnection()
            Catch ex As Exception
                CloseConnection()
                ' Continue - show card with no attendance data
            End Try

            Dim card As New RoundedPanel2()
            card.Size = New Size(colW, 120)
            card.Location = New Point(left + col * (colW + spacing), top)
            card.BackColor = Color.White
            card.Margin = New Padding(6)
            card.Padding = New Padding(12)

            Dim lblTitle As New Label()
            lblTitle.Text = sname
            lblTitle.Font = New Font("Poppins", 11, FontStyle.Bold)
            lblTitle.ForeColor = Color.FromArgb(17, 24, 39)
            lblTitle.AutoSize = True
            lblTitle.Location = New Point(10, 6)
            card.Controls.Add(lblTitle)

            Dim sessionsLbl As New Label()
            sessionsLbl.Text = sessionsHeld.ToString() & " sessions held"
            sessionsLbl.Font = New Font("Poppins", 8)
            sessionsLbl.ForeColor = Color.FromArgb(107, 114, 128)
            sessionsLbl.AutoSize = True
            sessionsLbl.Location = New Point(10, 32)
            card.Controls.Add(sessionsLbl)

            ' If no sectionStats, show no data message
            If sectionStats.Count = 0 Then
                Dim nodata As New Label()
                nodata.Text = "No attendance data available."
                nodata.Font = New Font("Poppins", 9)
                nodata.ForeColor = Color.FromArgb(107, 114, 128)
                nodata.AutoSize = True
                nodata.Location = New Point(10, 64)
                card.Controls.Add(nodata)
            Else
                Dim rowY = 60
                For Each rs In sectionStats
                    Dim batchName = rs.Item1
                    Dim presents = rs.Item2
                    Dim total = rs.Item3

                    Dim rPanel As New RoundedPanel3()
                    rPanel.Size = New Size(colW - 24, 28)
                    rPanel.Location = New Point(10, rowY)
                    rPanel.BackColor = Color.Transparent

                    Dim lblSec As New Label()
                    lblSec.Text = batchName
                    lblSec.Font = New Font("Poppins", 9)
                    lblSec.ForeColor = Color.FromArgb(31, 41, 55)
                    lblSec.AutoSize = True
                    lblSec.Location = New Point(4, 4)
                    rPanel.Controls.Add(lblSec)

                    Dim pcts As Single = 0
                    If total > 0 Then pcts = CSng(presents) / CSng(total)

                    Dim barColor As Color = ActiveColor
                    If total = 0 Then
                        barColor = Color.FromArgb(203, 213, 225)
                    ElseIf pcts >= 0.8F Then
                        barColor = ActiveColor
                    ElseIf pcts >= 0.75F Then
                        barColor = Color.FromArgb(255, 167, 38) ' amber
                    Else
                        barColor = Color.FromArgb(220, 38, 38) ' red
                    End If

                    AddHandler rPanel.Paint, Sub(s, pe)
                                                 Dim g = pe.Graphics
                                                 g.SmoothingMode = SmoothingMode.AntiAlias
                                                 Dim totalW = rPanel.ClientSize.Width - 160
                                                 Dim pct = Math.Min(1.0F, pcts)
                                                 Dim barRect = New RectangleF(140, 9, totalW, 8)
                                                 Using bgBrush = New SolidBrush(Color.FromArgb(241, 245, 249))
                                                     g.FillRectangle(bgBrush, barRect)
                                                 End Using
                                                 Using fgBrush = New SolidBrush(barColor)
                                                     g.FillRectangle(fgBrush, New RectangleF(barRect.X, barRect.Y, barRect.Width * pct, barRect.Height))
                                                 End Using
                                                 ' badge
                                                 Dim badge = String.Format("{0} / {1}", presents, total)
                                                 Using bfont = New Font("Poppins", 8)
                                                     Dim size = g.MeasureString(badge, bfont)
                                                     Dim bx = rPanel.ClientSize.Width - CInt(size.Width) - 12
                                                     Using brsh = New SolidBrush(Color.FromArgb(244, 242, 252))
                                                         Dim rect = New Rectangle(bx, 0, CInt(size.Width) + 12, rPanel.Height)
                                                         FillRoundedRect(g, brsh, rect, 8)
                                                         Using pf = New SolidBrush(Color.FromArgb(17, 24, 39))
                                                             g.DrawString(badge, bfont, pf, bx + 6, 6)
                                                         End Using
                                                     End Using
                                                 End Using
                                             End Sub

                    card.Controls.Add(rPanel)
                    rowY += 36
                Next
            End If

            pnlContent.Controls.Add(card)

            col += 1
            If col >= 2 Then
                col = 0
                top += card.Height + spacing
                left = margin
            End If
        Next

        ' Students at risk container
        ' Find the bottom of the last subject card
        Dim lastSubjectBottom As Integer = subjectsStartY

        For Each ctrl As Control In pnlContent.Controls
            If TypeOf ctrl Is RoundedPanel2 Then

                ' Ignore the top statistics cards
                If ctrl.Top >= subjectsStartY Then
                    If ctrl.Bottom > lastSubjectBottom Then
                        lastSubjectBottom = ctrl.Bottom
                    End If
                End If

            End If
        Next

        Dim riskY As Integer = lastSubjectBottom + 20 ' ensure some spacing after attendance cards
        Dim riskContainer As New RoundedPanel2()
        riskContainer.Location = New Point(margin, riskY)
        riskContainer.Size = New Size(pnlContent.ClientSize.Width - margin * 2, 420)
        riskContainer.BackColor = Color.White
        riskContainer.Padding = New Padding(12)

        ' Students At Risk title
        Dim riskTitle As New Label()
        riskTitle.Text = "Students At Risk"
        riskTitle.Font = New Font("Poppins", 11, FontStyle.Bold)
        riskTitle.ForeColor = Color.FromArgb(17, 24, 39)
        riskTitle.Location = New Point(16, 12)
        riskTitle.AutoSize = True
        riskContainer.Controls.Add(riskTitle)

        ' Legend will be added below title
        Dim legendPanel As New RoundedPanel4()
        legendPanel.Location = New Point(16, 44)
        legendPanel.Size = New Size(420, 40)
        legendPanel.BackColor = Color.White
        legendPanel.BorderStyle = BorderStyle.None

        Dim lg1 As New Label()
        lg1.Text = "80%+ Good"
        lg1.Font = New Font("Poppins", 8)
        lg1.ForeColor = Color.FromArgb(17, 24, 39)
        lg1.BackColor = Color.FromArgb(220, 255, 220)
        lg1.Padding = New Padding(8, 4, 8, 4)
        lg1.Location = New Point(0, 6)
        lg1.AutoSize = True
        legendPanel.Controls.Add(lg1)

        Dim lg2 As New Label()
        lg2.Text = "75-79% Warning"
        lg2.Font = New Font("Poppins", 8)
        lg2.ForeColor = Color.FromArgb(17, 24, 39)
        lg2.BackColor = Color.FromArgb(255, 245, 225)
        lg2.Padding = New Padding(8, 4, 8, 4)
        lg2.Location = New Point(140, 6)
        lg2.AutoSize = True
        legendPanel.Controls.Add(lg2)

        Dim lg3 As New Label()
        lg3.Text = "Below 75% At Risk"
        lg3.Font = New Font("Poppins", 8)
        lg3.ForeColor = Color.FromArgb(17, 24, 39)
        lg3.BackColor = Color.FromArgb(255, 235, 238)
        lg3.Padding = New Padding(8, 4, 8, 4)
        lg3.Location = New Point(320, 6)
        lg3.AutoSize = True
        legendPanel.Controls.Add(lg3)

        riskContainer.Controls.Add(legendPanel)

        ' DataGridView inside container (styled to match ucStudents)
        Dim dgvRisk As New DataGridView()
        dgvRisk.Location = New Point(16, 96)
        dgvRisk.Size = New Size(riskContainer.Width - 32, riskContainer.Height - 110)
        dgvRisk.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
        dgvRisk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRisk.AllowUserToAddRows = False
        dgvRisk.AllowUserToDeleteRows = False
        dgvRisk.ReadOnly = True
        dgvRisk.RowHeadersVisible = False
        dgvRisk.BackgroundColor = Color.White
        dgvRisk.BorderStyle = BorderStyle.None
        dgvRisk.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRisk.GridColor = Color.FromArgb(235, 235, 235)
        dgvRisk.EnableHeadersVisualStyles = False
        dgvRisk.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        dgvRisk.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 227, 247) ' #E9E3F7
        dgvRisk.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(91, 97, 120) ' #5B6178
        dgvRisk.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(233, 227, 247)
        dgvRisk.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(91, 97, 120)
        dgvRisk.ColumnHeadersDefaultCellStyle.Font = New Font("Poppins", 9, FontStyle.Bold)
        dgvRisk.ColumnHeadersHeight = 40

        dgvRisk.DefaultCellStyle.BackColor = Color.White
        dgvRisk.DefaultCellStyle.ForeColor = Color.FromArgb(17, 24, 39)
        dgvRisk.DefaultCellStyle.Font = New Font("Poppins", 9)
        dgvRisk.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235)
        dgvRisk.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvRisk.RowTemplate.Height = 38
        dgvRisk.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235)
        dgvRisk.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        dgvRisk.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 252)
        dgvRisk.RowsDefaultCellStyle.BackColor = Color.White
        dgvRisk.EnableHeadersVisualStyles = False
        ' modern selection color
        dgvRisk.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235)
        dgvRisk.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvRisk.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235)
        dgvRisk.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        dgvRisk.Columns.Add("Student", "Student")
        dgvRisk.Columns.Add("Section", "Section")
        dgvRisk.Columns.Add("Subject", "Subject")
        dgvRisk.Columns.Add("AttendancePct", "Attendance %")
        dgvRisk.Columns.Add("SessionsAttended", "Sessions Attended")
        dgvRisk.Columns.Add("Status", "Status")

        ' populate rows from DB
        Try
            OpenConnection()

            Dim sql As String =
                "SELECT s.student_number, CONCAT(s.last_name, ', ', s.first_name) AS name, b.batch_name, su.subject_name, " &
                "SUM(CASE WHEN ar.status IN ('Present','Excused') THEN 1 ELSE 0 END) AS presents, " &
                "COUNT(ar.record_id) AS total_sessions, " &
                "(SUM(CASE WHEN ar.status IN ('Present','Excused') THEN 1 ELSE 0 END) / COUNT(ar.record_id)) AS pct " &
                "FROM attendance_records ar " &
                "INNER JOIN attendance_sessions ses ON ar.session_id = ses.session_id " &
                "INNER JOIN students s ON ar.student_number = s.student_number " &
                "INNER JOIN batches b ON s.batch_id = b.batch_id " &
                "INNER JOIN subjects su ON ses.subject_id = su.subject_id "

            If activeSchoolYearId > 0 Then
                sql &= "WHERE ses.schoolyear_id = @sy "
            End If

            sql &= "GROUP BY ar.student_number, su.subject_id " &
                "HAVING total_sessions > 0 AND pct < 0.75 " &
                "ORDER BY pct ASC"

            Dim cmdRisk As New MySqlCommand(sql, Connection)
            If activeSchoolYearId > 0 Then cmdRisk.Parameters.AddWithValue("@sy", activeSchoolYearId)
            Using rdr As MySqlDataReader = cmdRisk.ExecuteReader()
                While rdr.Read()
                    Dim name = If(rdr("name") IsNot DBNull.Value, rdr("name").ToString(), "")
                    Dim batch = If(rdr("batch_name") IsNot DBNull.Value, rdr("batch_name").ToString(), "")
                    Dim subjName = If(rdr("subject_name") IsNot DBNull.Value, rdr("subject_name").ToString(), "")
                    Dim presents = If(rdr("presents") IsNot DBNull.Value, Convert.ToInt32(rdr("presents")), 0)
                    Dim total = If(rdr("total_sessions") IsNot DBNull.Value, Convert.ToInt32(rdr("total_sessions")), 0)
                    Dim pct = 0
                    If total > 0 Then pct = CInt(Math.Round((presents * 100.0) / total))
                    Dim status = If(pct < 75, "At Risk", "")

                    dgvRisk.Rows.Add(name, batch, subjName, pct.ToString() & "%", presents.ToString() & " / " & total.ToString(), status)
                End While
            End Using

            CloseConnection()
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show("Failed to load students at risk: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        ' alternating row colors
        dgvRisk.RowsDefaultCellStyle.BackColor = Color.White
        dgvRisk.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 252)

        ' ensure header styling matches other pages
        dgvRisk.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(244, 242, 252)
        dgvRisk.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(107, 114, 128)
        dgvRisk.EnableHeadersVisualStyles = False

        riskContainer.Controls.Add(dgvRisk)
        pnlContent.Controls.Add(riskContainer)

        pnlContent.AutoScrollMinSize =
    New Size(0, riskContainer.Bottom + 50)

    End Sub

    Private Sub AddSetupGuideCard()
        ' Check progress: SchoolYear, Batches, Subjects, Students, Attendance
        Dim hasSchoolYear As Boolean = False
        Dim hasBatches As Boolean = False
        Dim hasSubjects As Boolean = False
        Dim hasStudents As Boolean = False
        Dim hasAttendance As Boolean = False

        Try
            OpenConnection()

            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM school_years WHERE IFNULL(is_active,0)=1", Connection)
            Dim o1 = cmd.ExecuteScalar()
            If o1 IsNot Nothing Then hasSchoolYear = Convert.ToInt32(o1) > 0

            Dim cmd2 As New MySqlCommand("SELECT COUNT(*) FROM batches", Connection)
            Dim o2 = cmd2.ExecuteScalar()
            If o2 IsNot Nothing Then hasBatches = Convert.ToInt32(o2) > 0

            Dim cmd3 As New MySqlCommand("SELECT COUNT(*) FROM subjects", Connection)
            Dim o3 = cmd3.ExecuteScalar()
            If o3 IsNot Nothing Then hasSubjects = Convert.ToInt32(o3) > 0

            Dim cmd4 As New MySqlCommand("SELECT COUNT(*) FROM students", Connection)
            Dim o4 = cmd4.ExecuteScalar()
            If o4 IsNot Nothing Then hasStudents = Convert.ToInt32(o4) > 0

            Dim cmd5 As New MySqlCommand("SELECT COUNT(*) FROM attendance_sessions", Connection)
            Dim o5 = cmd5.ExecuteScalar()
            If o5 IsNot Nothing Then hasAttendance = Convert.ToInt32(o5) > 0

        Catch
            ' silent fallback - assume false on error
        Finally
            CloseConnection()
        End Try
        ' Create a guide card inside pnlContent named "setupGuideCard"
        ' Remove existing guide if present
        For Each c In pnlContent.Controls.OfType(Of Control)().ToList()
            If c.Name = "setupGuideCard" Then pnlContent.Controls.Remove(c)
        Next

        Dim guide As New RoundedPanel2()
        guide.Name = "setupGuideCard"
        guide.Size = New Size(320, 140)
        guide.BackColor = Color.White

        ' Position to the right of the section header (avoid overlapping cards)
        Dim margin As Integer = 24
        Dim cardH As Integer = 96
        Dim headerY As Integer = margin + cardH + 20
        Dim xPos As Integer = Math.Max(margin, pnlContent.ClientSize.Width - guide.Width - margin)
        Dim yPos As Integer = headerY
        guide.Location = New Point(xPos, yPos)
        guide.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        guide.Padding = New Padding(12)

        ' Try to load guide icon from common asset paths
        Dim iconImage As Image = Nothing
        Try
            Dim possiblePaths As String() = {
                "assets\icons\guide.png",
                "assets/icons/guide.png",
                "Assets\\icons\\guide.png",
                "icons\\guide.png",
                "images\\guide.png",
                "Resources\\guide.png",
                "resources\\guide.png"
            }
            For Each rel In possiblePaths
                Dim p As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rel)
                If System.IO.File.Exists(p) Then
                    iconImage = Image.FromFile(p)
                    Exit For
                End If
            Next
        Catch
            iconImage = Nothing
        End Try

        If iconImage IsNot Nothing Then
            Dim pb As New PictureBox()
            pb.Size = New Size(36, 36)
            pb.SizeMode = PictureBoxSizeMode.Zoom
            pb.Location = New Point(12, 12)
            pb.Image = iconImage
            guide.Controls.Add(pb)

            Dim title As New Label()
            title.Text = "System Setup Guide"
            title.Font = New Font("Poppins", 12, FontStyle.Bold)
            title.ForeColor = Color.FromArgb(51, 65, 85)
            title.Location = New Point(56, 12)
            title.AutoSize = True
            guide.Controls.Add(title)
        Else
            Dim title As New Label()
            title.Text = "System Setup Guide"
            title.Font = New Font("Poppins", 12, FontStyle.Bold)
            title.ForeColor = Color.FromArgb(51, 65, 85)
            title.Location = New Point(16, 12)
            title.AutoSize = True
            guide.Controls.Add(title)
        End If

        Dim items = New List(Of (String, Boolean)) From {
            ("School Year", hasSchoolYear),
            ("Batches", hasBatches),
            ("Subjects", hasSubjects),
            ("Students", hasStudents),
            ("Attendance", hasAttendance)
        }

        Dim y As Integer = 44
        For Each it In items
            Dim lbl As New Label()
            lbl.Font = New Font("Poppins", 10)
            lbl.ForeColor = If(it.Item2, Color.FromArgb(34, 197, 94), Color.FromArgb(107, 114, 128))
            lbl.Text = If(it.Item2, "✓ " & it.Item1, "○ " & it.Item1)
            lbl.Location = New Point(18, y)
            lbl.AutoSize = True
            guide.Controls.Add(lbl)
            y += 28
        Next

        ' Highlight the next step
        Dim nextStep As String = ""
        If Not hasSchoolYear Then
            nextStep = "School Year"
        ElseIf Not hasBatches Then
            nextStep = "Batches"
        ElseIf Not hasSubjects Then
            nextStep = "Subjects"
        ElseIf Not hasStudents Then
            nextStep = "Students"
        ElseIf Not hasAttendance Then
            nextStep = "Attendance"
        End If

        If nextStep <> "" Then
            Dim hint As New Label()
            hint.Font = New Font("Poppins", 9, FontStyle.Italic)
            hint.ForeColor = Color.FromArgb(107, 114, 128)
            hint.Text = "Next: " & nextStep
            hint.Location = New Point(18, y + 6)
            hint.AutoSize = True
            guide.Controls.Add(hint)
        End If

        pnlContent.Controls.Add(guide)
    End Sub

    Private Sub ToggleSetupGuide()
        ' Open the modal setup guide form
        Try
            Using f As New frmSetupGuide()
                f.StartPosition = FormStartPosition.CenterParent
                f.ShowDialog(Me)
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to open Setup Guide: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        ' ensure content background matches theme
        Try
            pnlContent.BackColor = Color.FromArgb(244, 242, 252) ' light lavender background (#F4F2FC)
        Catch
        End Try

        ' Build the dynamic dashboard UI
        Try
            BuildDashboard()
        Catch ex As Exception
            MessageBox.Show("BuildDashboard error: " & ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Note: Setup guide panel is shown when user clicks the top "Set Up Guide" button

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

    ' Top Set Up Guide click handlers - toggle the guide panel in the dashboard
    Private Sub pnlGuide_Click(sender As Object, e As EventArgs)
        ToggleSetupGuide()
    End Sub

    Private Sub lblGuide_Click(sender As Object, e As EventArgs)
        ToggleSetupGuide()
    End Sub

    Private Sub picGuide_Click(sender As Object, e As EventArgs)
        ToggleSetupGuide()
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

            ' Try to load the profile icon from the project assets and place it to the right of the username
            Try
                Dim targetRel As String = System.IO.Path.Combine("assets", "icons", "profile.png")
                Dim userImg As Image = Nothing

                ' Start from the app base directory and walk up a few levels to find the project root
                Dim dir = New System.IO.DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
                For i As Integer = 0 To 6
                    If dir Is Nothing Then Exit For
                    Dim candidate = System.IO.Path.Combine(dir.FullName, targetRel)
                    If System.IO.File.Exists(candidate) Then
                        userImg = Image.FromFile(candidate)
                        Exit For
                    End If
                    dir = dir.Parent
                Next

                If userImg Is Nothing Then
                    ' fallback: try base dir directly for a loose profile.png
                    Dim candidate2 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profile.png")
                    If System.IO.File.Exists(candidate2) Then userImg = Image.FromFile(candidate2)
                End If

                If userImg IsNot Nothing Then
                    Dim picUser As New PictureBox()
                    picUser.Name = "picLoggedUser"
                    picUser.SizeMode = PictureBoxSizeMode.Zoom
                    picUser.Size = New Size(48, 48)
                    ' ensure labels have their measured size by performing layout
                    lblUser.PerformLayout()
                    ' place to the right of the username label, but keep inside sidebar
                    Dim px = lblUser.Left + lblUser.Width + 40
                    If px + picUser.Width > pnlSidebar.ClientSize.Width - 8 Then
                        px = pnlSidebar.ClientSize.Width - picUser.Width - 8
                    End If
                    picUser.Location = New Point(px, lblUser.Top - 2)
                    picUser.Image = userImg
                    pnlSidebar.Controls.Add(picUser)
                    picUser.BringToFront()
                End If
            Catch ex As Exception
                ' ignore image load errors, but keep a trace in debug
                System.Diagnostics.Debug.WriteLine("Profile icon load failed: " & ex.Message)
            End Try

            ' Ensure the existing designer Log Out label remains inside pnlLogout and wire its click
            AddHandler pnlLogout.Click, AddressOf pnlLogout_Click
            AddHandler Label1.Click, AddressOf pnlLogout_Click
            AddHandler lblUser.Click, AddressOf pnlNoop_Click
            AddHandler lblRole.Click, AddressOf pnlNoop_Click
            ' wire top guide click handlers
            AddHandler pnlGuide.Click, AddressOf pnlGuide_Click
            AddHandler lblGuide.Click, AddressOf lblGuide_Click
            AddHandler picGuide.Click, AddressOf picGuide_Click
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