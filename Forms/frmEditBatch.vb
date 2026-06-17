Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmEditBatch
    Inherits Form

    Public BatchID As Integer = 0

    Private txtBatchName As TextBox
    Private txtAdviser As TextBox
    Private cboSchoolYear As ComboBox
    Private btnSave As Button
    Private btnCancel As Button

    Private Sub frmEditBatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeUI()
        LoadSchoolYears()
        If BatchID > 0 Then LoadBatch()
    End Sub

    Private Sub InitializeUI()
        Me.SuspendLayout()
        Me.Text = "Edit Batch"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ShowIcon = False
        Me.BackColor = Color.FromArgb(244, 242, 252)
        Me.ClientSize = New Size(500, 490)

        Dim lblTitle As New Label()
        lblTitle.Text = "Edit Batch"
        lblTitle.Font = New Font("Poppins", 18, FontStyle.Bold)
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(145, 20)
        Me.Controls.Add(lblTitle)

        Dim lblBatchName As New Label()
        lblBatchName.Text = "Batch Name"
        lblBatchName.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblBatchName.Location = New Point(40, 80)
        Me.Controls.Add(lblBatchName)

        txtBatchName = New TextBox()
        txtBatchName.Location = New Point(40, 105)
        txtBatchName.Size = New Size(420, 32)
        txtBatchName.Font = New Font("Poppins", 10)
        Me.Controls.Add(txtBatchName)

        Dim lblAdviser As New Label()
        lblAdviser.Text = "Adviser"
        lblAdviser.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblAdviser.Location = New Point(40, 150)
        Me.Controls.Add(lblAdviser)

        txtAdviser = New TextBox()
        txtAdviser.Location = New Point(40, 175)
        txtAdviser.Size = New Size(420, 32)
        txtAdviser.Font = New Font("Poppins", 10)
        Me.Controls.Add(txtAdviser)

        Dim lblSchoolYear As New Label()
        lblSchoolYear.Text = "School Year"
        lblSchoolYear.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblSchoolYear.Location = New Point(40, 220)
        Me.Controls.Add(lblSchoolYear)

        cboSchoolYear = New ComboBox()
        cboSchoolYear.Location = New Point(40, 245)
        cboSchoolYear.Size = New Size(420, 32)
        cboSchoolYear.Font = New Font("Poppins", 10)
        cboSchoolYear.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Controls.Add(cboSchoolYear)

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
        btnSave.Text = "Update Batch"
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

    Private Sub LoadSchoolYears()
        Try
            OpenConnection()
            cboSchoolYear.Items.Clear()
            Dim cmd As New MySqlCommand("SELECT schoolyear_id, CONCAT(school_year, ' - ', semester) AS display_name FROM school_years ORDER BY school_year, semester", Connection)
            Using rdr As MySqlDataReader = cmd.ExecuteReader()
                While rdr.Read()
                    Dim item As New SchoolYearItem(Convert.ToInt32(rdr("schoolyear_id")), rdr("display_name").ToString())
                    cboSchoolYear.Items.Add(item)
                End While
            End Using
            CloseConnection()
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadBatch()
        Try
            OpenConnection()
            Dim cmd As New MySqlCommand("SELECT batch_name, adviser, schoolyear_id FROM batches WHERE batch_id=@id", Connection)
            cmd.Parameters.AddWithValue("@id", BatchID)
            Using rdr As MySqlDataReader = cmd.ExecuteReader()
                If rdr.Read() Then
                    txtBatchName.Text = rdr("batch_name").ToString()
                    txtAdviser.Text = rdr("adviser").ToString()
                    Dim syid As Integer = Convert.ToInt32(rdr("schoolyear_id"))
                    For i As Integer = 0 To cboSchoolYear.Items.Count - 1
                        Dim it = DirectCast(cboSchoolYear.Items(i), SchoolYearItem)
                        If it.SchoolYearID = syid Then
                            cboSchoolYear.SelectedIndex = i
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
        If txtBatchName.Text.Trim = "" Then
            MessageBox.Show("Please enter Batch Name.")
            txtBatchName.Focus()
            Return
        End If
        If txtAdviser.Text.Trim = "" Then
            MessageBox.Show("Please enter Adviser.")
            txtAdviser.Focus()
            Return
        End If
        If cboSchoolYear.SelectedIndex = -1 Then
            MessageBox.Show("Please select a School Year.")
            cboSchoolYear.Focus()
            Return
        End If

        Dim selectedSY = DirectCast(cboSchoolYear.SelectedItem, SchoolYearItem)

        Try
            OpenConnection()
            Dim cmd As New MySqlCommand("UPDATE batches SET batch_name=@name, adviser=@adviser, schoolyear_id=@syid WHERE batch_id=@id", Connection)
            cmd.Parameters.AddWithValue("@name", txtBatchName.Text.Trim)
            cmd.Parameters.AddWithValue("@adviser", txtAdviser.Text.Trim)
            cmd.Parameters.AddWithValue("@syid", selectedSY.SchoolYearID)
            cmd.Parameters.AddWithValue("@id", BatchID)
            cmd.ExecuteNonQuery()
            CloseConnection()
            MessageBox.Show("Batch updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
