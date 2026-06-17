Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddBatch

    Private lblTitle As Label
    Private lblSubtitle As Label
    Private picIcon As PictureBox

    Private lblBatchName As Label
    Private lblAdviser As Label
    Private lblSchoolYear As Label

    Public txtBatchName As TextBox
    Public txtAdviser As TextBox
    Public cboSchoolYear As ComboBox

    Public btnCancel As Button
    Public btnSave As Button

    Private Sub frmAddBatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeUI()
    End Sub

    Private Sub InitializeUI()

        Me.SuspendLayout()

        Me.Text = "Add Batch"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ShowIcon = False
        Me.BackColor = Color.FromArgb(244, 242, 252)
        Me.ClientSize = New Size(500, 490)

        '==========================
        ' ICON
        '==========================

        picIcon = New PictureBox()
        picIcon.Size = New Size(64, 64)
        picIcon.Location = New Point(218, 20)
        picIcon.SizeMode = PictureBoxSizeMode.Zoom
        picIcon.BackColor = Color.Transparent
        'picIcon.Image = My.Resources.batch
        Me.Controls.Add(picIcon)

        '==========================
        ' TITLE
        '==========================

        lblTitle = New Label()
        lblTitle.Text = "Add New Batch"
        lblTitle.Font = New Font("Poppins", 18, FontStyle.Bold)
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(145, 100)
        Me.Controls.Add(lblTitle)

        '==========================
        ' SUBTITLE
        '==========================

        lblSubtitle = New Label()
        lblSubtitle.Text = "Register a new batch into the attendance system"
        lblSubtitle.Font = New Font("Poppins", 9)
        lblSubtitle.ForeColor = Color.Gray
        lblSubtitle.AutoSize = False
        lblSubtitle.Size = New Size(500, 25)
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter
        lblSubtitle.Location = New Point(0, 145)
        Me.Controls.Add(lblSubtitle)

        '==========================
        ' BATCH NAME
        '==========================

        lblBatchName = New Label()
        lblBatchName.Text = "Batch Name"
        lblBatchName.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblBatchName.Location = New Point(40, 185)
        lblBatchName.AutoSize = True
        Me.Controls.Add(lblBatchName)

        txtBatchName = New TextBox()
        txtBatchName.Name = "txtBatchName"
        txtBatchName.Size = New Size(420, 32)
        txtBatchName.Location = New Point(40, 208)
        txtBatchName.Font = New Font("Poppins", 10)
        Me.Controls.Add(txtBatchName)

        '==========================
        ' ADVISER
        '==========================

        lblAdviser = New Label()
        lblAdviser.Text = "Adviser"
        lblAdviser.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblAdviser.Location = New Point(40, 255)
        lblAdviser.AutoSize = True
        Me.Controls.Add(lblAdviser)

        txtAdviser = New TextBox()
        txtAdviser.Name = "txtAdviser"
        txtAdviser.Size = New Size(420, 32)
        txtAdviser.Location = New Point(40, 278)
        txtAdviser.Font = New Font("Poppins", 10)
        Me.Controls.Add(txtAdviser)

        '==========================
        ' SCHOOL YEAR
        '==========================

        lblSchoolYear = New Label()
        lblSchoolYear.Text = "School Year"
        lblSchoolYear.Font = New Font("Poppins", 9, FontStyle.Bold)
        lblSchoolYear.Location = New Point(40, 325)
        lblSchoolYear.AutoSize = True
        Me.Controls.Add(lblSchoolYear)

        cboSchoolYear = New ComboBox()
        cboSchoolYear.Name = "cboSchoolYear"
        cboSchoolYear.DropDownStyle = ComboBoxStyle.DropDownList
        cboSchoolYear.Font = New Font("Poppins", 10)
        cboSchoolYear.Location = New Point(40, 348)
        cboSchoolYear.Size = New Size(420, 32)
        Me.Controls.Add(cboSchoolYear)

        '==========================
        ' CANCEL BUTTON
        '==========================

        btnCancel = New Button()
        btnCancel.Text = "Cancel"
        btnCancel.Size = New Size(150, 42)
        btnCancel.Location = New Point(40, 415)
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
        btnSave.Text = "Save Batch"
        btnSave.Size = New Size(150, 42)
        btnSave.Location = New Point(310, 415)
        btnSave.Font = New Font("Poppins", 10, FontStyle.Bold)
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.BackColor = Color.FromArgb(108, 92, 231)
        btnSave.ForeColor = Color.White
        AddHandler btnSave.Click, AddressOf btnSave_Click
        Me.Controls.Add(btnSave)

        LoadSchoolYears()

        Me.ResumeLayout()

    End Sub

    Private Sub LoadSchoolYears()

        Try

            OpenConnection()

            cboSchoolYear.Items.Clear()

            '==========================
            ' Show school_year + semester
            ' so the user picks the exact term
            '==========================
            Dim cmd As New MySqlCommand(
                "SELECT schoolyear_id,
                        CONCAT(school_year, ' - ', semester) AS display_name
                 FROM school_years
                 ORDER BY school_year, semester",
                Connection
            )

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()

                Dim item As New SchoolYearItem(
                    Convert.ToInt32(reader("schoolyear_id")),
                    reader("display_name").ToString()
                )

                cboSchoolYear.Items.Add(item)

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

        If txtBatchName.Text.Trim = "" Then
            MessageBox.Show("Please enter Batch Name.")
            txtBatchName.Focus()
            Exit Sub
        End If

        If txtAdviser.Text.Trim = "" Then
            MessageBox.Show("Please enter Adviser.")
            txtAdviser.Focus()
            Exit Sub
        End If

        If cboSchoolYear.SelectedIndex = -1 Then
            MessageBox.Show("Please select a School Year.")
            cboSchoolYear.Focus()
            Exit Sub
        End If

        Dim selectedSY As SchoolYearItem =
            DirectCast(cboSchoolYear.SelectedItem, SchoolYearItem)

        Try

            OpenConnection()

            '==========================
            ' CHECK DUPLICATE
            ' Same batch name must not exist
            ' under the same school year term
            '==========================

            Dim checkCmd As New MySqlCommand(
                "SELECT COUNT(*) FROM batches
                 WHERE batch_name     = @batch_name
                   AND schoolyear_id  = @schoolyear_id",
                Connection
            )

            checkCmd.Parameters.AddWithValue(
                "@batch_name",
                txtBatchName.Text.Trim
            )

            checkCmd.Parameters.AddWithValue(
                "@schoolyear_id",
                selectedSY.SchoolYearID
            )

            Dim total As Integer =
                Convert.ToInt32(checkCmd.ExecuteScalar())

            If total > 0 Then

                MessageBox.Show(
                    "This batch already exists for the selected school year.",
                    "Duplicate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                CloseConnection()
                Exit Sub

            End If

            '==========================
            ' INSERT BATCH
            '==========================

            Dim insertCmd As New MySqlCommand(
                "INSERT INTO batches (batch_name, adviser, schoolyear_id)
                 VALUES (@batch_name, @adviser, @schoolyear_id)",
                Connection
            )

            insertCmd.Parameters.AddWithValue(
                "@batch_name",
                txtBatchName.Text.Trim
            )

            insertCmd.Parameters.AddWithValue(
                "@adviser",
                txtAdviser.Text.Trim
            )

            insertCmd.Parameters.AddWithValue(
                "@schoolyear_id",
                selectedSY.SchoolYearID
            )

            insertCmd.ExecuteNonQuery()

            CloseConnection()

            MessageBox.Show(
                "Batch added successfully.",
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
' Helper class to store schoolyear_id
' while showing a friendly name
' in the ComboBox
'==========================
Public Class SchoolYearItem

    Public Property SchoolYearID As Integer
    Public Property DisplayName As String

    Public Sub New(id As Integer, name As String)
        SchoolYearID = id
        DisplayName = name
    End Sub

    Public Overrides Function ToString() As String
        Return DisplayName
    End Function

End Class
