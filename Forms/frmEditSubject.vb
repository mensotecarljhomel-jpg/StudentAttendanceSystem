Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmEditSubject
    Inherits Form

    Public SubjectID As Integer = 0

    Private lblTitle As Label
    Private txtSubjectName As TextBox
    Private cboBatch As ComboBox
    Private txtSchedule As TextBox
    Private btnCancel As Button
    Private btnSave As Button

    Private Sub frmEditSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeUI()
        LoadBatches()
        If SubjectID > 0 Then LoadSubject()
    End Sub

    Private Sub InitializeUI()
        Me.SuspendLayout()
        Me.Text = "Edit Subject"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ShowIcon = False
        Me.BackColor = Color.FromArgb(244, 242, 252)
        Me.ClientSize = New Size(500, 520)

        lblTitle = New Label()
        lblTitle.Text = "Edit Subject"
        lblTitle.Font = New Font("Poppins", 18, FontStyle.Bold)
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(130, 20)
        Me.Controls.Add(lblTitle)

        Dim lblSubjectName As New Label()
        lblSubjectName.Text = "Subject Name"
        lblSubjectName.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblSubjectName.Location = New Point(40, 80)
        Me.Controls.Add(lblSubjectName)

        txtSubjectName = New TextBox()
        txtSubjectName.Location = New Point(40, 105)
        txtSubjectName.Size = New Size(420, 32)
        txtSubjectName.Font = New Font("Poppins", 10)
        Me.Controls.Add(txtSubjectName)

        Dim lblBatch As New Label()
        lblBatch.Text = "Batch"
        lblBatch.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblBatch.Location = New Point(40, 150)
        Me.Controls.Add(lblBatch)

        cboBatch = New ComboBox()
        cboBatch.Location = New Point(40, 175)
        cboBatch.Size = New Size(420, 32)
        cboBatch.Font = New Font("Poppins", 10)
        cboBatch.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Controls.Add(cboBatch)

        Dim lblSchedule As New Label()
        lblSchedule.Text = "Schedule"
        lblSchedule.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblSchedule.Location = New Point(40, 220)
        Me.Controls.Add(lblSchedule)

        txtSchedule = New TextBox()
        txtSchedule.Location = New Point(40, 245)
        txtSchedule.Size = New Size(420, 32)
        txtSchedule.Font = New Font("Poppins", 10)
        Me.Controls.Add(txtSchedule)

        btnCancel = New Button()
        btnCancel.Text = "Cancel"
        btnCancel.Size = New Size(150, 42)
        btnCancel.Location = New Point(40, 320)
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.BackColor = Color.Gainsboro
        AddHandler btnCancel.Click, AddressOf btnCancel_Click
        Me.Controls.Add(btnCancel)

        btnSave = New Button()
        btnSave.Text = "Update Subject"
        btnSave.Size = New Size(150, 42)
        btnSave.Location = New Point(310, 320)
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.BackColor = Color.FromArgb(108, 92, 231)
        btnSave.ForeColor = Color.White
        AddHandler btnSave.Click, AddressOf btnSave_Click
        Me.Controls.Add(btnSave)

        Me.ResumeLayout()
    End Sub

    Private Sub LoadBatches()
        Try
            OpenConnection()
            cboBatch.Items.Clear()
            Dim cmd As New MySqlCommand("SELECT b.batch_id, CONCAT(b.batch_name, ' | ', sy.school_year, ' ', sy.semester) AS display_name FROM batches b INNER JOIN school_years sy ON b.schoolyear_id = sy.schoolyear_id ORDER BY sy.school_year, sy.semester, b.batch_name", Connection)
            Using rdr As MySqlDataReader = cmd.ExecuteReader()
                While rdr.Read()
                    Dim item As New BatchItem(Convert.ToInt32(rdr("batch_id")), rdr("display_name").ToString())
                    cboBatch.Items.Add(item)
                End While
            End Using
            CloseConnection()
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadSubject()
        Try
            OpenConnection()
            Dim cmd As New MySqlCommand("SELECT subject_name, schedule, batch_id FROM subjects WHERE subject_id=@id", Connection)
            cmd.Parameters.AddWithValue("@id", SubjectID)
            Using rdr As MySqlDataReader = cmd.ExecuteReader()
                If rdr.Read() Then
                    txtSubjectName.Text = rdr("subject_name").ToString()
                    txtSchedule.Text = If(rdr("schedule") IsNot DBNull.Value, rdr("schedule").ToString(), "")
                    Dim batchId As Integer = Convert.ToInt32(rdr("batch_id"))
                    ' select batch
                    For i As Integer = 0 To cboBatch.Items.Count - 1
                        Dim it = DirectCast(cboBatch.Items(i), BatchItem)
                        If it.BatchID = batchId Then
                            cboBatch.SelectedIndex = i
                            Exit For
                        End If
                    Next
                End If
            End Using
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
        If txtSubjectName.Text.Trim = "" Then
            MessageBox.Show("Please enter Subject Name.")
            txtSubjectName.Focus()
            Return
        End If
        If cboBatch.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Batch.")
            cboBatch.Focus()
            Return
        End If

        Dim selectedBatch = DirectCast(cboBatch.SelectedItem, BatchItem)

        Try
            OpenConnection()
            Dim cmd As New MySqlCommand("UPDATE subjects SET subject_name=@name, batch_id=@batch_id, schedule=@schedule WHERE subject_id=@id", Connection)
            cmd.Parameters.AddWithValue("@name", txtSubjectName.Text.Trim)
            cmd.Parameters.AddWithValue("@batch_id", selectedBatch.BatchID)
            cmd.Parameters.AddWithValue("@schedule", txtSchedule.Text.Trim)
            cmd.Parameters.AddWithValue("@id", SubjectID)
            cmd.ExecuteNonQuery()
            CloseConnection()
            MessageBox.Show("Subject updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
