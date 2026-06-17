Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmViewAttendance
    Inherits Form

    Public SubjectID As Integer = 0

    Private dgv As DataGridView
    Private btnClose As Button

    Private Sub frmViewAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeUI()
        LoadRecords()
    End Sub

    Private Sub InitializeUI()

        Me.SuspendLayout()

        Me.Text = "View Attendance Records"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ClientSize = New Size(900, 600)

        dgv = New DataGridView()
        dgv.Location = New Point(20, 60)
        dgv.Size = New Size(860, 480)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Me.Controls.Add(dgv)

        btnClose = New Button()
        btnClose.Text = "Close"
        btnClose.Location = New Point(760, 550)
        btnClose.Size = New Size(120, 30)

        AddHandler btnClose.Click, AddressOf btnClose_Click

        Me.Controls.Add(btnClose)

        Me.ResumeLayout()

    End Sub

    Private Sub LoadRecords()

        dgv.Columns.Clear()

        dgv.Columns.Add("StudentID", "STUDENT ID")
        dgv.Columns.Add("StudentName", "STUDENT")
        dgv.Columns.Add("Date", "DATE")
        dgv.Columns.Add("Status", "STATUS")

        Try

            OpenConnection()

            Dim query As String =
            "SELECT
                s.student_number,
                CONCAT(s.last_name, ', ', s.first_name) AS student_name,
                a.attendance_date,
                a.status
             FROM attendance a
             INNER JOIN students s
                 ON a.student_id = s.student_id
             WHERE a.subject_id = @subject_id
             ORDER BY a.attendance_date DESC"

            Dim cmd As New MySqlCommand(query, Connection)

            cmd.Parameters.AddWithValue("@subject_id", SubjectID)

            Using rdr As MySqlDataReader = cmd.ExecuteReader()

                While rdr.Read()

                    dgv.Rows.Add(
                        rdr("student_number").ToString(),
                        rdr("student_name").ToString(),
                        Convert.ToDateTime(
                            rdr("attendance_date")
                        ).ToString("yyyy-MM-dd"),
                        rdr("status").ToString()
                    )

                End While

            End Using

            CloseConnection()

        Catch ex As Exception

            CloseConnection()

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnClose_Click(
        sender As Object,
        e As EventArgs
    )

        Me.Close()

    End Sub

End Class