Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmStudentAttendanceReport
    Inherits System.Windows.Forms.Form

    Private dgvReport As DataGridView
    Private lblTitle As Label
    Public StudentNumber As String

    Private Sub frmStudentAttendanceReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Attendance Report"
        Me.ClientSize = New Size(700, 400)
        Me.Font = New Font("Poppins", 10)

        lblTitle = New Label()
        lblTitle.Text = ""
        lblTitle.Location = New Point(10, 10)
        lblTitle.AutoSize = True
        Me.Controls.Add(lblTitle)

        dgvReport = New DataGridView()
        dgvReport.Location = New Point(10, 40)
        dgvReport.Size = New Size(680, 340)
        dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReport.ReadOnly = True
        dgvReport.AllowUserToAddRows = False
        dgvReport.RowHeadersVisible = False
        Me.Controls.Add(dgvReport)

        LoadReport()

    End Sub

    Private Sub LoadReport()
        If String.IsNullOrWhiteSpace(StudentNumber) Then
            MessageBox.Show("No student specified.")
            Me.Close()
            Return
        End If

        Try
            OpenConnection()

            ' Student name
            Dim nameCmd As New MySqlCommand("SELECT CONCAT(last_name, ', ', first_name) AS name FROM students WHERE student_number=@sn", Connection)
            nameCmd.Parameters.AddWithValue("@sn", StudentNumber)
            Dim nameObj = nameCmd.ExecuteScalar()
            If nameObj IsNot Nothing Then lblTitle.Text = "Attendance for: " & nameObj.ToString() & " (" & StudentNumber & ")"

            Dim query As String =
                "SELECT sub.subject_id, sub.subject_name,
                        SUM(CASE WHEN ar.status IN ('Present','Excused') THEN 1 ELSE 0 END) AS presents,
                        SUM(CASE WHEN ar.status = 'Absent' THEN 1 ELSE 0 END) AS absents,
                        SUM(CASE WHEN ar.status = 'Excused' THEN 1 ELSE 0 END) AS excused,
                        COUNT(ar.session_id) AS total_sessions
                 FROM attendance_records ar
                 INNER JOIN attendance_sessions ses ON ar.session_id = ses.session_id
                 INNER JOIN subjects sub ON ses.subject_id = sub.subject_id
                 WHERE ar.student_number = @sn
                 GROUP BY sub.subject_id, sub.subject_name
                 ORDER BY sub.subject_name"

            Dim cmd As New MySqlCommand(query, Connection)
            cmd.Parameters.AddWithValue("@sn", StudentNumber)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            dgvReport.Columns.Clear()
            dgvReport.Columns.Add("Subject", "Subject")
            dgvReport.Columns.Add("Presents", "Presents")
            dgvReport.Columns.Add("Absents", "Absents")
            dgvReport.Columns.Add("Excused", "Excused")
            dgvReport.Columns.Add("Total", "Total")
            dgvReport.Columns.Add("Percent", "Percent")

            While reader.Read()
                Dim presents = Convert.ToInt32(reader("presents"))
                Dim absents = Convert.ToInt32(reader("absents"))
                Dim excused = Convert.ToInt32(reader("excused"))
                Dim total = Convert.ToInt32(reader("total_sessions"))
                Dim pct As Integer = 0
                If total > 0 Then pct = CInt(Math.Round((presents * 100.0) / total))

                dgvReport.Rows.Add(reader("subject_name").ToString(), presents, absents, excused, total, pct.ToString() & "%")
            End While

            reader.Close()

            CloseConnection()

        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
