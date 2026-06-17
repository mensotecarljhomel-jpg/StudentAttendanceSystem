Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddSubject

    Private lblTitle As Label
    Private lblSubtitle As Label
    Private picIcon As PictureBox

    Private lblSubjectName As Label
    Private lblBatch As Label
    Private lblSchedule As Label
    Public txtSubjectName As TextBox
    Public cboBatch As ComboBox
    Public txtSchedule As TextBox
    Public btnCancel As Button
    Public btnSave As Button

    Private Sub frmAddSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeUI()
    End Sub

    Private Sub InitializeUI()

        Me.SuspendLayout()

        Me.Text = "Add Subject"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ShowIcon = False
        Me.BackColor = Color.FromArgb(244, 242, 252)
        Me.ClientSize = New Size(500, 520)

        '==========================
        ' ICON
        '==========================

        picIcon = New PictureBox()
        picIcon.Size = New Size(64, 64)
        picIcon.Location = New Point(218, 20)
        picIcon.SizeMode = PictureBoxSizeMode.Zoom
        picIcon.BackColor = Color.Transparent
        'picIcon.Image = My.Resources.subject
        Me.Controls.Add(picIcon)

        '==========================
        ' TITLE
        '==========================

        lblTitle = New Label()
        lblTitle.Text = "Add New Subject"
        lblTitle.Font = New Font("Poppins", 18, FontStyle.Bold)
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(130, 100)
        Me.Controls.Add(lblTitle)

        '==========================
        ' SUBTITLE
        '==========================

        lblSubtitle = New Label()
        lblSubtitle.Text = "Register a new subject into the attendance system"
        lblSubtitle.Font = New Font("Poppins", 9)
        lblSubtitle.ForeColor = Color.Gray
        lblSubtitle.AutoSize = False
        lblSubtitle.Size = New Size(500, 25)
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter
        lblSubtitle.Location = New Point(0, 145)
        Me.Controls.Add(lblSubtitle)

        '==========================
        ' SUBJECT NAME
        '==========================

        lblSubjectName = New Label()
        lblSubjectName.Text = "Subject Name"
        lblSubjectName.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblSubjectName.Location = New Point(40, 185)
        lblSubjectName.AutoSize = True
        Me.Controls.Add(lblSubjectName)

        txtSubjectName = New TextBox()
        txtSubjectName.Name = "txtSubjectName"
        txtSubjectName.Size = New Size(420, 32)
        txtSubjectName.Location = New Point(40, 208)
        txtSubjectName.Font = New Font("Poppins", 10)
        Me.Controls.Add(txtSubjectName)


        '==========================
        ' SCHEDULE
        '==========================

        lblSchedule = New Label()
        lblSchedule.Text = "Schedule"
        lblSchedule.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblSchedule.Location = New Point(40, 325)
        lblSchedule.AutoSize = True
        Me.Controls.Add(lblSchedule)

        txtSchedule = New TextBox()
        txtSchedule.Name = "txtSchedule"
        txtSchedule.Size = New Size(420, 32)
        txtSchedule.Location = New Point(40, 348)
        txtSchedule.Font = New Font("Poppins", 10)
        txtSchedule.PlaceholderText = "e.g. Monday 7:30 AM - 8:30 AM"
        Me.Controls.Add(txtSchedule)

        '==========================
        ' BATCH
        '==========================

        lblBatch = New Label()
        lblBatch.Text = "Batch"
        lblBatch.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblBatch.Location = New Point(40, 255)
        lblBatch.AutoSize = True
        Me.Controls.Add(lblBatch)

        cboBatch = New ComboBox()
        cboBatch.Name = "cboBatch"
        cboBatch.DropDownStyle = ComboBoxStyle.DropDownList
        cboBatch.Font = New Font("Poppins", 10)
        cboBatch.Location = New Point(40, 278)
        cboBatch.Size = New Size(420, 32)
        Me.Controls.Add(cboBatch)

        '==========================
        ' CANCEL BUTTON
        '==========================

        btnCancel = New Button()
        btnCancel.Text = "Cancel"
        btnCancel.Size = New Size(150, 42)
        btnCancel.Location = New Point(40, 445)
        btnCancel.Font = New Font("Poppins", 10, FontStyle.Bold)
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.BackColor = Color.Gainsboro
        AddHandler btnCancel.Click, AddressOf btnCancel_Click
        Me.Controls.Add(btnCancel)

        '==========================
        ' SAVE BUTTON
        '==========================

        btnSave = New Button()
        btnSave.Text = "Save Subject"
        btnSave.Size = New Size(150, 42)
        btnSave.Location = New Point(310, 445)
        btnSave.Font = New Font("Poppins", 10, FontStyle.Bold)
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.BackColor = Color.FromArgb(108, 92, 231)
        btnSave.ForeColor = Color.White
        AddHandler btnSave.Click, AddressOf btnSave_Click
        Me.Controls.Add(btnSave)

        LoadBatches()

        Me.ResumeLayout()

    End Sub

    Private Sub LoadBatches()

        Try

            OpenConnection()

            cboBatch.Items.Clear()

            '==========================
            ' Show batch name + school year + semester
            ' so the user knows exactly which batch
            ' they are picking
            '==========================
            Dim cmd As New MySqlCommand(
                "SELECT b.batch_id,
                        CONCAT(b.batch_name,
                               ' | ',
                               sy.school_year,
                               ' ',
                               sy.semester) AS display_name
                 FROM batches b
                 INNER JOIN school_years sy
                 ON b.schoolyear_id = sy.schoolyear_id
                 ORDER BY sy.school_year, sy.semester, b.batch_name",
                Connection
            )

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()

                Dim item As New BatchItem(
                    Convert.ToInt32(reader("batch_id")),
                    reader("display_name").ToString()
                )

                cboBatch.Items.Add(item)

            End While

            reader.Close()
            CloseConnection()

        Catch ex As Exception

            CloseConnection()
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)

        '==========================
        ' VALIDATION
        '==========================

        If txtSubjectName.Text.Trim = "" Then
            MessageBox.Show("Please enter Subject Name.")
            txtSubjectName.Focus()
            Exit Sub
        End If

        If cboBatch.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Batch.")
            cboBatch.Focus()
            Exit Sub
        End If

        Dim selectedBatch As BatchItem =
            DirectCast(cboBatch.SelectedItem, BatchItem)

        Try

            OpenConnection()

            '==========================
            ' CHECK DUPLICATE
            ' Same subject name must not exist
            ' under the same batch
            '==========================

            Dim checkCmd As New MySqlCommand(
                "SELECT COUNT(*) FROM subjects
                 WHERE subject_name = @subject_name
                   AND batch_id     = @batch_id",
                Connection
            )

            checkCmd.Parameters.AddWithValue(
                "@subject_name",
                txtSubjectName.Text.Trim
            )

            checkCmd.Parameters.AddWithValue(
                "@batch_id",
                selectedBatch.BatchID
            )

            Dim total As Integer =
                Convert.ToInt32(checkCmd.ExecuteScalar())

            If total > 0 Then

                MessageBox.Show(
                    "This subject already exists for the selected batch.",
                    "Duplicate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                CloseConnection()
                Exit Sub

            End If

            '==========================
            ' INSERT SUBJECT (adapt to schema)
            '==========================
            ' Check if 'schedule' column exists in subjects table
            Dim hasSchedule As Boolean = False

            Dim colCmd As New MySqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'subjects' AND COLUMN_NAME = 'schedule'", Connection)
            Dim colCount As Integer = Convert.ToInt32(colCmd.ExecuteScalar())

            If colCount > 0 Then hasSchedule = True

            If hasSchedule Then
                Dim insertCmd As New MySqlCommand("INSERT INTO subjects (subject_name, batch_id, schedule) VALUES (@subject_name, @batch_id, @schedule)", Connection)
                insertCmd.Parameters.AddWithValue("@subject_name", txtSubjectName.Text.Trim)
                insertCmd.Parameters.AddWithValue("@batch_id", selectedBatch.BatchID)
                insertCmd.Parameters.AddWithValue("@schedule", txtSchedule.Text.Trim)
                insertCmd.ExecuteNonQuery()
            Else
                Dim insertCmd As New MySqlCommand("INSERT INTO subjects (subject_name, batch_id) VALUES (@subject_name, @batch_id)", Connection)
                insertCmd.Parameters.AddWithValue("@subject_name", txtSubjectName.Text.Trim)
                insertCmd.Parameters.AddWithValue("@batch_id", selectedBatch.BatchID)
                insertCmd.ExecuteNonQuery()
            End If

            CloseConnection()

            MessageBox.Show(
                "Subject added successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Me.Close()

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

End Class

'==========================
' Helper class to store batch_id
' while showing a friendly name
' in the ComboBox
'==========================
Public Class BatchItem

    Public Property BatchID As Integer
    Public Property DisplayName As String

    Public Sub New(id As Integer, name As String)
        BatchID = id
        DisplayName = name
    End Sub

    Public Overrides Function ToString() As String
        Return DisplayName
    End Function

End Class