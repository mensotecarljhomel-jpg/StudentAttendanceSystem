Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddStudent

    Private lblTitle As Label
    Private lblSubtitle As Label

    Private picIcon As PictureBox

    Private lblStudentNumber As Label
    Private lblFirstName As Label
    Private lblLastName As Label
    Private lblGender As Label
    Private lblSection As Label

    Public txtStudentNumber As TextBox
    Public txtFirstName As TextBox
    Public txtLastName As TextBox

    Public cboGender As ComboBox
    Public cboSection As ComboBox

    Public btnCancel As Button
    Public btnSave As Button

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeUI()

    End Sub

    Private Sub InitializeUI()

        Me.SuspendLayout()

        Me.Text = "Add Student"

        Me.StartPosition = FormStartPosition.CenterScreen

        Me.FormBorderStyle = FormBorderStyle.FixedDialog

        Me.MaximizeBox = False
        Me.MinimizeBox = False

        Me.ShowIcon = False

        Me.BackColor = Color.FromArgb(244, 242, 252)

        Me.ClientSize = New Size(500, 610)

        '==========================
        ' ICON
        '==========================

        picIcon = New PictureBox()

        picIcon.Size = New Size(64, 64)

        picIcon.Location = New Point(218, 20)

        picIcon.SizeMode = PictureBoxSizeMode.Zoom

        picIcon.BackColor = Color.Transparent

        'PUT YOUR ICON LATER
        'picIcon.Image = My.Resources.student

        Me.Controls.Add(picIcon)

        '==========================
        ' TITLE
        '==========================

        lblTitle = New Label()

        lblTitle.Text = "Add New Student"

        lblTitle.Font = New Font("Poppins", 18, FontStyle.Bold)

        lblTitle.AutoSize = True

        lblTitle.Location = New Point(135, 100)

        Me.Controls.Add(lblTitle)

        '==========================
        ' SUBTITLE
        '==========================

        lblSubtitle = New Label()

        lblSubtitle.Text = "Register a new student into the attendance system"

        lblSubtitle.Font = New Font("Poppins", 9)

        lblSubtitle.ForeColor = Color.Gray

        lblSubtitle.AutoSize = True

        lblSubtitle.AutoSize = False

        lblSubtitle.Size = New Size(500, 25)

        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter

        lblSubtitle.Location = New Point(0, 145)

        Me.Controls.Add(lblSubtitle)

        '==========================
        ' STUDENT NUMBER
        '==========================

        lblStudentNumber = New Label()

        lblStudentNumber.Text = "Student Number"

        lblStudentNumber.Font =
            New Font("Poppins", 9, FontStyle.Bold)

        lblStudentNumber.Location =
            New Point(40, 175)

        lblStudentNumber.AutoSize = True

        Me.Controls.Add(lblStudentNumber)

        txtStudentNumber = New TextBox()

        txtStudentNumber.Name = "txtStudentNumber"

        txtStudentNumber.Size =
            New Size(420, 32)

        txtStudentNumber.Location =
            New Point(40, 198)

        txtStudentNumber.Font =
            New Font("Poppins", 10)

        Me.Controls.Add(txtStudentNumber)

        '==========================
        ' FIRST NAME
        '==========================

        lblFirstName = New Label()

        lblFirstName.Text = "First Name"

        lblFirstName.Font =
            New Font("Poppins", 9, FontStyle.Bold)

        lblFirstName.Location =
            New Point(40, 245)

        lblFirstName.AutoSize = True

        Me.Controls.Add(lblFirstName)

        txtFirstName = New TextBox()

        txtFirstName.Name = "txtFirstName"

        txtFirstName.Size =
            New Size(420, 32)

        txtFirstName.Location =
            New Point(40, 268)

        txtFirstName.Font =
            New Font("Poppins", 10)

        Me.Controls.Add(txtFirstName)

        '==========================
        ' LAST NAME
        '==========================

        lblLastName = New Label()

        lblLastName.Text = "Last Name"

        lblLastName.Font =
            New Font("Poppins", 9, FontStyle.Bold)

        lblLastName.Location =
            New Point(40, 315)

        lblLastName.AutoSize = True

        Me.Controls.Add(lblLastName)

        txtLastName = New TextBox()

        txtLastName.Name = "txtLastName"

        txtLastName.Size =
            New Size(420, 32)

        txtLastName.Location =
            New Point(40, 338)

        txtLastName.Font =
            New Font("Poppins", 10)

        Me.Controls.Add(txtLastName)

        '==========================
        ' GENDER
        '==========================

        lblGender = New Label()

        lblGender.Text = "Gender"

        lblGender.Font =
            New Font("Poppins", 9, FontStyle.Bold)

        lblGender.Location =
            New Point(40, 385)

        lblGender.AutoSize = True

        Me.Controls.Add(lblGender)

        cboGender = New ComboBox()

        cboGender.Name = "cboGender"

        cboGender.DropDownStyle =
            ComboBoxStyle.DropDownList

        cboGender.Font =
            New Font("Poppins", 10)

        cboGender.Location =
            New Point(40, 408)

        cboGender.Size =
            New Size(420, 32)

        cboGender.Items.Add("Male")
        cboGender.Items.Add("Female")

        Me.Controls.Add(cboGender)

        '==========================
        ' SECTION
        '==========================

        lblSection = New Label()

        lblSection.Text = "Section"

        lblSection.Font =
            New Font("Poppins", 9, FontStyle.Bold)

        lblSection.Location =
            New Point(40, 455)

        lblSection.AutoSize = True

        Me.Controls.Add(lblSection)

        cboSection = New ComboBox()

        cboSection.Name = "cboSection"

        cboSection.DropDownStyle =
            ComboBoxStyle.DropDownList

        cboSection.Font =
            New Font("Poppins", 10)

        cboSection.Location =
            New Point(40, 478)

        cboSection.Size =
            New Size(420, 32)


        Me.Controls.Add(cboSection)

        '==========================
        ' CANCEL BUTTON
        '==========================

        btnCancel = New Button()

        btnCancel.Text = "Cancel"

        btnCancel.Size = New Size(150, 42)

        btnCancel.Location = New Point(40, 545)

        btnCancel.Font =
            New Font("Poppins", 10, FontStyle.Bold)

        btnCancel.FlatStyle =
            FlatStyle.Flat

        btnCancel.FlatAppearance.BorderSize = 0

        btnCancel.BackColor =
            Color.Gainsboro

        AddHandler btnCancel.Click,
            AddressOf btnCancel_Click

        Me.Controls.Add(btnCancel)

        '==========================
        ' SAVE BUTTON
        '==========================

        btnSave = New Button()

        btnSave.Text = "Save Student"

        btnSave.Size = New Size(150, 42)

        btnSave.Location = New Point(310, 545)
        btnSave.Font =
            New Font("Poppins", 10, FontStyle.Bold)

        btnSave.FlatStyle =
            FlatStyle.Flat

        btnSave.FlatAppearance.BorderSize = 0

        btnSave.BackColor =
            Color.FromArgb(108, 92, 231)

        btnSave.ForeColor =
            Color.White

        AddHandler btnSave.Click,
            AddressOf btnSave_Click

        Me.Controls.Add(btnSave)

        LoadBatches()
        Me.ResumeLayout()


    End Sub

    Private Sub LoadBatches()

        Try

            OpenConnection()

            cboSection.Items.Clear()

            Dim cmd As New MySqlCommand(
                "SELECT batch_name FROM batches ORDER BY batch_name",
                Connection
            )

            Dim reader As MySqlDataReader =
                cmd.ExecuteReader()

            While reader.Read()

                cboSection.Items.Add(
                    reader("batch_name").ToString()
                )

            End While

            reader.Close()

            CloseConnection()

        Catch ex As Exception

            CloseConnection()

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnCancel_Click(
        sender As Object,
        e As EventArgs
    )

        Me.Close()

    End Sub

    Private Sub btnSave_Click(
    sender As Object,
    e As EventArgs
)

        '==========================
        ' VALIDATION
        '==========================

        If txtStudentNumber.Text.Trim = "" Then

            MessageBox.Show("Please enter Student Number.")
            txtStudentNumber.Focus()
            Exit Sub

        End If

        If txtFirstName.Text.Trim = "" Then

            MessageBox.Show("Please enter First Name.")
            txtFirstName.Focus()
            Exit Sub

        End If

        If txtLastName.Text.Trim = "" Then

            MessageBox.Show("Please enter Last Name.")
            txtLastName.Focus()
            Exit Sub

        End If

        If cboGender.SelectedIndex = -1 Then

            MessageBox.Show("Please select Gender.")
            cboGender.Focus()
            Exit Sub

        End If

        If cboSection.SelectedIndex = -1 Then

            MessageBox.Show("Please select Section.")
            cboSection.Focus()
            Exit Sub

        End If

        Try

            OpenConnection()

            '==========================
            ' CHECK DUPLICATE
            '==========================

            Dim checkCmd As New MySqlCommand(
            "SELECT COUNT(*) FROM students WHERE student_number=@student_number",
            Connection
        )

            checkCmd.Parameters.AddWithValue(
            "@student_number",
            txtStudentNumber.Text.Trim
        )

            Dim total As Integer =
            Convert.ToInt32(checkCmd.ExecuteScalar())

            If total > 0 Then

                MessageBox.Show(
                "Student Number already exists.",
                "Duplicate",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

                CloseConnection()
                Exit Sub

            End If

            '==========================
            ' GET BATCH ID
            '==========================

            Dim batchCmd As New MySqlCommand(
            "SELECT batch_id FROM batches WHERE batch_name=@batch",
            Connection
        )

            batchCmd.Parameters.AddWithValue(
            "@batch",
            cboSection.Text
        )

            Dim batchID As Object =
            batchCmd.ExecuteScalar()

            If batchID Is Nothing Then

                MessageBox.Show("Invalid section selected.")

                CloseConnection()

                Exit Sub

            End If

            '==========================
            ' INSERT STUDENT
            '==========================

            Dim insertCmd As New MySqlCommand(
            "INSERT INTO students
            (student_number,first_name,last_name,gender,batch_id)
            VALUES
            (@student_number,@first_name,@last_name,@gender,@batch_id)",
            Connection
        )

            insertCmd.Parameters.AddWithValue(
            "@student_number",
            txtStudentNumber.Text.Trim
        )

            insertCmd.Parameters.AddWithValue(
            "@first_name",
            txtFirstName.Text.Trim
        )

            insertCmd.Parameters.AddWithValue(
            "@last_name",
            txtLastName.Text.Trim
        )

            insertCmd.Parameters.AddWithValue(
            "@gender",
            cboGender.Text
        )

            insertCmd.Parameters.AddWithValue(
            "@batch_id",
            Convert.ToInt32(batchID)
        )

            insertCmd.ExecuteNonQuery()

            CloseConnection()

            MessageBox.Show(
            "Student added successfully.",
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