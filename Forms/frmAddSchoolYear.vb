Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddSchoolYear
    Inherits Form

    Public SchoolYearID As Integer = 0

    Private lblTitle As Label
    Private txtSchoolYear As TextBox
    Private cboSemester As ComboBox
    Private btnCancel As Button
    Private btnSave As Button

    Private Sub frmAddSchoolYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeUI()

        If SchoolYearID > 0 Then
            LoadSchoolYear()
        End If

    End Sub

    Private Sub InitializeUI()

        Me.SuspendLayout()

        Me.Text = If(SchoolYearID > 0, "Edit School Year", "Add School Year")
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ShowIcon = False
        Me.BackColor = Color.FromArgb(244, 242, 252)
        Me.ClientSize = New Size(420, 240)

        lblTitle = New Label()
        lblTitle.Text = If(SchoolYearID > 0, "Edit School Year", "Add School Year")
        lblTitle.Font = New Font("Poppins", 14, FontStyle.Bold)
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(20, 20)
        Me.Controls.Add(lblTitle)

        Dim lblSY As New Label()
        lblSY.Text = "School Year"
        lblSY.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblSY.Location = New Point(20, 60)
        lblSY.AutoSize = True
        Me.Controls.Add(lblSY)

        txtSchoolYear = New TextBox()
        txtSchoolYear.Location = New Point(20, 85)
        txtSchoolYear.Size = New Size(360, 30)
        txtSchoolYear.Font = New Font("Poppins", 10)
        Me.Controls.Add(txtSchoolYear)

        Dim lblSem As New Label()
        lblSem.Text = "Semester"
        lblSem.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblSem.Location = New Point(20, 120)
        lblSem.AutoSize = True
        Me.Controls.Add(lblSem)

        cboSemester = New ComboBox()
        cboSemester.Location = New Point(20, 145)
        cboSemester.Size = New Size(200, 30)
        cboSemester.Font = New Font("Poppins", 10)
        cboSemester.DropDownStyle = ComboBoxStyle.DropDownList
        cboSemester.Items.Add("1")
        cboSemester.Items.Add("2")
        cboSemester.Items.Add("Summer")
        Me.Controls.Add(cboSemester)

        btnCancel = New Button()
        btnCancel.Text = "Cancel"
        btnCancel.Size = New Size(120, 36)
        btnCancel.Location = New Point(20, 185)
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.BackColor = Color.Gainsboro
        AddHandler btnCancel.Click, AddressOf btnCancel_Click
        Me.Controls.Add(btnCancel)

        btnSave = New Button()
        btnSave.Text = If(SchoolYearID > 0, "Update", "Save")
        btnSave.Size = New Size(120, 36)
        btnSave.Location = New Point(260, 185)
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.BackColor = Color.FromArgb(108, 92, 231)
        btnSave.ForeColor = Color.White
        AddHandler btnSave.Click, AddressOf btnSave_Click
        Me.Controls.Add(btnSave)

        Me.ResumeLayout()

    End Sub

    Private Sub LoadSchoolYear()
        Try
            OpenConnection()

            Dim cmd As New MySqlCommand("SELECT school_year, semester FROM school_years WHERE schoolyear_id=@id", Connection)
            cmd.Parameters.AddWithValue("@id", SchoolYearID)

            Using rdr As MySqlDataReader = cmd.ExecuteReader()
                If rdr.Read() Then
                    txtSchoolYear.Text = rdr("school_year").ToString()
                    cboSemester.Text = rdr("semester").ToString()
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

        If txtSchoolYear.Text.Trim = "" Then
            MessageBox.Show("Please enter school year.")
            txtSchoolYear.Focus()
            Return
        End If

        If cboSemester.SelectedIndex = -1 Then
            MessageBox.Show("Please select semester.")
            cboSemester.Focus()
            Return
        End If

        Try
            OpenConnection()

            If SchoolYearID = 0 Then
                Dim cmd As New MySqlCommand("INSERT INTO school_years (school_year, semester, is_active) VALUES (@sy, @sem, 0)", Connection)
                cmd.Parameters.AddWithValue("@sy", txtSchoolYear.Text.Trim)
                cmd.Parameters.AddWithValue("@sem", cboSemester.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("School year added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim cmd As New MySqlCommand("UPDATE school_years SET school_year=@sy, semester=@sem WHERE schoolyear_id=@id", Connection)
                cmd.Parameters.AddWithValue("@sy", txtSchoolYear.Text.Trim)
                cmd.Parameters.AddWithValue("@sem", cboSemester.Text)
                cmd.Parameters.AddWithValue("@id", SchoolYearID)
                cmd.ExecuteNonQuery()
                MessageBox.Show("School year updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CloseConnection()

            Me.Close()

        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class

