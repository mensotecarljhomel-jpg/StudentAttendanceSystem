Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class StartClass

    Private cboSubject As ComboBox
    Private lblBatch As Label
    Private lblSchoolYear As Label
    Private lblSemester As Label
    Private dtpDate As DateTimePicker
    Private btnStart As Button
    Private dgvStudents As DataGridView
    Private btnSave As Button
    Private currentSessionID As Integer = 0

    Private Sub StartClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Start Class"

        Me.ClientSize = New Size(900, 600)

        Me.Font = New Font("Poppins", 10)

        InitializeUI()

        LoadSubjects()

        Database.EnsureAttendanceTablesExist()

    End Sub

    Private Sub InitializeUI()

        Dim x As Integer = 20
        Dim y As Integer = 20

        Dim lbl As New Label()
        lbl.Text = "Subject"
        lbl.Location = New Point(x, y)
        lbl.AutoSize = True
        Me.Controls.Add(lbl)

        cboSubject = New ComboBox()
        cboSubject.Location = New Point(x, y + 25)
        cboSubject.Size = New Size(500, 32)
        cboSubject.DropDownStyle = ComboBoxStyle.DropDownList
        AddHandler cboSubject.SelectedIndexChanged, AddressOf cboSubject_SelectedIndexChanged
        Me.Controls.Add(cboSubject)

        lblBatch = New Label()
        lblBatch.Text = "Batch:"
        lblBatch.Location = New Point(x + 520, y)
        lblBatch.AutoSize = True
        Me.Controls.Add(lblBatch)

        lblSchoolYear = New Label()
        lblSchoolYear.Text = "School Year:"
        lblSchoolYear.Location = New Point(x + 520, y + 25)
        lblSchoolYear.AutoSize = True
        Me.Controls.Add(lblSchoolYear)

        lblSemester = New Label()
        lblSemester.Text = "Semester:"
        lblSemester.Location = New Point(x + 520, y + 50)
        lblSemester.AutoSize = True
        Me.Controls.Add(lblSemester)

        Dim lblDate As New Label()
        lblDate.Text = "Date"
        lblDate.Location = New Point(x, y + 70)
        lblDate.AutoSize = True
        Me.Controls.Add(lblDate)

        dtpDate = New DateTimePicker()
        dtpDate.Location = New Point(x, y + 95)
        dtpDate.Format = DateTimePickerFormat.Short
        Me.Controls.Add(dtpDate)

        btnStart = New Button()
        btnStart.Text = "Load Students"
        btnStart.Location = New Point(x + 250, y + 90)
        btnStart.Size = New Size(120, 34)
        AddHandler btnStart.Click, AddressOf btnStart_Click
        Me.Controls.Add(btnStart)

        dgvStudents = New DataGridView()
        dgvStudents.Location = New Point(20, 150)
        dgvStudents.Size = New Size(840, 350)
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.RowHeadersVisible = False
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.Controls.Add(dgvStudents)

        btnSave = New Button()
        btnSave.Text = "Save Attendance"
        btnSave.Location = New Point(740, 520)
        btnSave.Size = New Size(120, 36)
        AddHandler btnSave.Click, AddressOf btnSave_Click
        Me.Controls.Add(btnSave)

    End Sub

    Private Class SubjectItem

        Public Property SubjectID As Integer
        Public Property BatchID As Integer
        Public Property SchoolYearID As Integer
        Public Property DisplayName As String

        Public Sub New(sid As Integer, bid As Integer, syid As Integer, name As String)
            SubjectID = sid
            BatchID = bid
            SchoolYearID = syid
            DisplayName = name
        End Sub

        Public Overrides Function ToString() As String
            Return DisplayName
        End Function

    End Class

    Public PreselectSubjectID As Integer = 0

    Private Sub LoadSubjects()

        Try

            OpenConnection()

            cboSubject.Items.Clear()

            Dim query As String =
                "SELECT s.subject_id, s.subject_name, s.schedule, b.batch_id, b.batch_name, sy.schoolyear_id, sy.school_year, sy.semester " & _
                "FROM subjects s " & _
                "INNER JOIN batches b ON s.batch_id = b.batch_id " & _
                "INNER JOIN school_years sy ON b.schoolyear_id = sy.schoolyear_id " & _
                "ORDER BY sy.school_year, sy.semester, b.batch_name, s.subject_name"

            Dim cmd As New MySqlCommand(query, Connection)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()

                Dim sid = Convert.ToInt32(reader("subject_id"))
                Dim bid = Convert.ToInt32(reader("batch_id"))
                Dim syid = Convert.ToInt32(reader("schoolyear_id"))

                Dim display = String.Format("{0} | {1} | {2} {3}", reader("subject_name").ToString(), reader("batch_name").ToString(), reader("school_year").ToString(), reader("semester").ToString())

                cboSubject.Items.Add(New SubjectItem(sid, bid, syid, display))

            End While

            reader.Close()

            CloseConnection()

        Catch ex As Exception

            CloseConnection()

            MessageBox.Show(ex.Message)

        End Try

        ' If a preselected subject ID was provided, attempt to select it
        If Me.PreselectSubjectID > 0 Then
            For i As Integer = 0 To cboSubject.Items.Count - 1
                Dim it = DirectCast(cboSubject.Items(i), SubjectItem)
                If it.SubjectID = Me.PreselectSubjectID Then
                    cboSubject.SelectedIndex = i
                    ' Automatically load students and create a session with all Present
                    LoadStudentsForBatch(it.BatchID)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub cboSubject_SelectedIndexChanged(sender As Object, e As EventArgs)

        Dim item = TryCast(cboSubject.SelectedItem, SubjectItem)

        If item Is Nothing Then Return

        ' Load meta info
        Try

            OpenConnection()

            Dim query As String = "SELECT b.batch_name, sy.school_year, sy.semester FROM batches b INNER JOIN school_years sy ON b.schoolyear_id = sy.schoolyear_id WHERE b.batch_id=@batch_id"

            Using cmd As New MySqlCommand(query, Connection)

                cmd.Parameters.AddWithValue("@batch_id", item.BatchID)

                Using rdr As MySqlDataReader = cmd.ExecuteReader()

                    If rdr.Read() Then
                        lblBatch.Text = "Batch: " & rdr("batch_name").ToString()
                        lblSchoolYear.Text = "School Year: " & rdr("school_year").ToString()
                        lblSemester.Text = "Semester: " & rdr("semester").ToString()
                    End If

                End Using

            End Using

            CloseConnection()

        Catch ex As Exception

            CloseConnection()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs)

        If cboSubject.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a subject.")
            Return
        End If

        Dim item = DirectCast(cboSubject.SelectedItem, SubjectItem)

        LoadStudentsForBatch(item.BatchID)

    End Sub

    Private Sub LoadStudentsForBatch(batchID As Integer)

        dgvStudents.Columns.Clear()

        dgvStudents.Columns.Add("StudentNumber", "STUDENT ID")
        dgvStudents.Columns.Add("LastName", "LAST NAME")
        dgvStudents.Columns.Add("FirstName", "FIRST NAME")

        Dim statusCol As New DataGridViewComboBoxColumn()
        statusCol.Name = "Status"
        statusCol.HeaderText = "STATUS"
        statusCol.Items.AddRange("Present", "Absent", "Excused")
        statusCol.DefaultCellStyle.NullValue = "Present"

        dgvStudents.Columns.Add(statusCol)

        ' If user changes status to Excused, treat it as Present for attendance calculation on save
        AddHandler dgvStudents.CellValueChanged, AddressOf dgvStudents_CellValueChanged
        AddHandler dgvStudents.CurrentCellDirtyStateChanged, AddressOf dgvStudents_CurrentCellDirtyStateChanged

        ' Query students
        Try

            OpenConnection()

            Dim query As String = "SELECT student_number, last_name, first_name FROM students WHERE batch_id=@batch_id ORDER BY student_number"

            Using cmd As New MySqlCommand(query, Connection)

                cmd.Parameters.AddWithValue("@batch_id", batchID)

                Using rdr As MySqlDataReader = cmd.ExecuteReader()

                    While rdr.Read()

                        dgvStudents.Rows.Add(rdr("student_number").ToString(), rdr("last_name").ToString(), rdr("first_name").ToString(), "Present")

                    End While

                End Using

            End Using

            CloseConnection()

            ' Create an attendance session and insert Present records for all students by default
            Try

                OpenConnection()

                Dim item = DirectCast(cboSubject.SelectedItem, SubjectItem)

                Dim insertSession As New MySqlCommand(
                    "INSERT INTO attendance_sessions (subject_id, batch_id, schoolyear_id, session_date) VALUES (@subject_id, @batch_id, @sy_id, @session_date)",
                    Connection)

                insertSession.Parameters.AddWithValue("@subject_id", item.SubjectID)
                insertSession.Parameters.AddWithValue("@batch_id", item.BatchID)
                insertSession.Parameters.AddWithValue("@sy_id", item.SchoolYearID)
                insertSession.Parameters.AddWithValue("@session_date", dtpDate.Value.Date)

                insertSession.ExecuteNonQuery()

                Dim cmdLast As New MySqlCommand("SELECT LAST_INSERT_ID();", Connection)
                currentSessionID = Convert.ToInt32(cmdLast.ExecuteScalar())

                For Each row As DataGridViewRow In dgvStudents.Rows
                    If row.IsNewRow Then Continue For

                    Dim studentNumber As String = row.Cells("StudentNumber").Value.ToString()

                    ' Treat Excused as Present when inserting default records
                    Dim defaultStatus As String = "Present"

                    Dim insertRecord As New MySqlCommand("INSERT INTO attendance_records (session_id, student_number, status) VALUES (@session_id, @student_number, @status)", Connection)

                    insertRecord.Parameters.AddWithValue("@session_id", currentSessionID)
                    insertRecord.Parameters.AddWithValue("@student_number", studentNumber)
                    insertRecord.Parameters.AddWithValue("@status", defaultStatus)

                    insertRecord.ExecuteNonQuery()

                Next

                CloseConnection()

            Catch ex As Exception

                CloseConnection()

                MessageBox.Show(ex.Message)

            End Try

        Catch ex As Exception

            CloseConnection()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub dgvStudents_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
        If dgvStudents.IsCurrentCellDirty Then
            dgvStudents.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvStudents_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        ' No immediate DB action here; saving will persist changes. Keep this placeholder if immediate behavior is desired later.
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)

        If cboSubject.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a subject first.")
            Return
        End If

        If dgvStudents.Rows.Count = 0 Then
            MessageBox.Show("No students to save.")
            Return
        End If

        Dim item = DirectCast(cboSubject.SelectedItem, SubjectItem)

        Try

            OpenConnection()

            ' Insert session
            Dim insertSession As New MySqlCommand(
                "INSERT INTO attendance_sessions (subject_id, batch_id, schoolyear_id, session_date) VALUES (@subject_id, @batch_id, @sy_id, @session_date)",
                Connection)

            insertSession.Parameters.AddWithValue("@subject_id", item.SubjectID)
            insertSession.Parameters.AddWithValue("@batch_id", item.BatchID)
            insertSession.Parameters.AddWithValue("@sy_id", item.SchoolYearID)
            insertSession.Parameters.AddWithValue("@session_date", dtpDate.Value.Date)

            insertSession.ExecuteNonQuery()

            ' Get last insert id
            Dim cmdLast As New MySqlCommand("SELECT LAST_INSERT_ID();", Connection)
            Dim sessionID As Integer = Convert.ToInt32(cmdLast.ExecuteScalar())

            ' Update attendance_records to reflect any changes (only if we created a session earlier)
            If currentSessionID > 0 Then

                For Each row As DataGridViewRow In dgvStudents.Rows

                    If row.IsNewRow Then Continue For

                    Dim studentNumber As String = row.Cells("StudentNumber").Value.ToString()
                    Dim status As String = row.Cells("Status").Value.ToString()

                    ' Update existing record
                    ' Treat 'Excused' as 'Present' for stored status value (so it counts as present in reports)
                    Dim storeStatus As String = If(status = "Excused", "Present", status)

                    Dim updateCmd As New MySqlCommand("UPDATE attendance_records SET status=@status WHERE session_id=@session_id AND student_number=@student_number", Connection)
                    updateCmd.Parameters.AddWithValue("@status", storeStatus)
                    updateCmd.Parameters.AddWithValue("@session_id", sessionID)
                    updateCmd.Parameters.AddWithValue("@student_number", studentNumber)

                    Dim affected As Integer = updateCmd.ExecuteNonQuery()

                    If affected = 0 Then
                        ' If no record exists (shouldn't happen), insert it
                        Dim insertRecord As New MySqlCommand("INSERT INTO attendance_records (session_id, student_number, status) VALUES (@session_id, @student_number, @status)", Connection)
                        insertRecord.Parameters.AddWithValue("@session_id", sessionID)
                        insertRecord.Parameters.AddWithValue("@student_number", studentNumber)
                        insertRecord.Parameters.AddWithValue("@status", storeStatus)
                        insertRecord.ExecuteNonQuery()
                    End If

                Next

            Else
                ' Fallback: insert new records if we did not previously create session (should not happen)
                For Each row As DataGridViewRow In dgvStudents.Rows
                    If row.IsNewRow Then Continue For
                    Dim studentNumber As String = row.Cells("StudentNumber").Value.ToString()
                    Dim status As String = row.Cells("Status").Value.ToString()
                    Dim insertRecord As New MySqlCommand("INSERT INTO attendance_records (session_id, student_number, status) VALUES (@session_id, @student_number, @status)", Connection)
                    insertRecord.Parameters.AddWithValue("@session_id", sessionID)
                    insertRecord.Parameters.AddWithValue("@student_number", studentNumber)
                    insertRecord.Parameters.AddWithValue("@status", status)
                    insertRecord.ExecuteNonQuery()
                Next
            End If

            CloseConnection()

            MessageBox.Show("Attendance saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        Catch ex As Exception

            CloseConnection()

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

End Class
