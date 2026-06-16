Imports MySql.Data.MySqlClient

Public Class ucStudents

    Private Sub ucStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '==========================
        ' Section Filter
        '==========================
        cboBatchFilter.Items.Clear()

        cboBatchFilter.Items.Add("All Sections")
        cboBatchFilter.Items.Add("Grade 11 - 1")
        cboBatchFilter.Items.Add("Grade 11 - 2")
        cboBatchFilter.Items.Add("Grade 11 - 3")
        cboBatchFilter.Items.Add("Grade 12 - 1")
        cboBatchFilter.Items.Add("Grade 12 - 2")
        cboBatchFilter.Items.Add("Grade 12 - 3")

        cboBatchFilter.SelectedIndex = 0

        SetupStudentGrid()
        LoadStudentsFromDatabase()

    End Sub

    Private Sub SetupStudentGrid()

        With dgvStudents

            .Columns.Clear()

            '==========================
            ' Basic Settings
            '==========================
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = Color.FromArgb(235, 235, 235)

            .EnableHeadersVisualStyles = False

            '==========================
            ' Header Style
            '==========================
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

            .ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(244, 242, 252)

            .ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(107, 114, 128)

            .ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(244, 242, 252)

            .ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.FromArgb(107, 114, 128)

            .ColumnHeadersDefaultCellStyle.Font =
                New Font("Poppins", 9, FontStyle.Bold)

            .ColumnHeadersHeight = 45

            '==========================
            ' Cell Style
            '==========================
            .DefaultCellStyle.BackColor = Color.White

            .DefaultCellStyle.ForeColor = Color.Black

            .DefaultCellStyle.Font =
                New Font("Poppins", 9)

            .DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 230, 255)

            .DefaultCellStyle.SelectionForeColor =
                Color.Black

            .RowTemplate.Height = 48

            '==========================
            ' Columns
            '==========================
            .Columns.Add("StudentID", "STUDENT ID")
            .Columns.Add("LastName", "LAST NAME")
            .Columns.Add("FirstName", "FIRST NAME")
            .Columns.Add("Gender", "GENDER")
            .Columns.Add("Section", "SECTION")
            .Columns.Add("Attendance", "ATTENDANCE")
            .Columns.Add("Status", "STATUS")

            '==========================
            ' Disable Sorting
            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            .Columns("StudentID").SortMode = DataGridViewColumnSortMode.Automatic
            .Columns("LastName").SortMode = DataGridViewColumnSortMode.Automatic

        End With

    End Sub

    Public Sub LoadStudentsFromDatabase()

        Try

            OpenConnection()

            dgvStudents.Rows.Clear()

            Dim query As String =
                "SELECT s.student_number,
                        s.last_name,
                        s.first_name,
                        s.gender,
                        b.batch_name
                 FROM students s
                 INNER JOIN batches b
                 ON s.batch_id = b.batch_id
                 ORDER BY s.student_number"

            Dim cmd As New MySqlCommand(query, Connection)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()

                dgvStudents.Rows.Add(
                    reader("student_number").ToString(),
                    reader("last_name").ToString(),
                    reader("first_name").ToString(),
                    reader("gender").ToString(),
                    reader("batch_name").ToString(),
                    "100%",
                    "Good"
                )

            End While

            reader.Close()
            CloseConnection()

        Catch ex As Exception

            CloseConnection()

            MessageBox.Show(
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub pnlContentStudents_Paint(sender As Object, e As PaintEventArgs) Handles pnlContentStudents.Paint

    End Sub

    Private Sub RoundedPanel1_Paint(sender As Object, e As PaintEventArgs) Handles RoundedPanel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub pnlAddStudent_Click(sender As Object, e As EventArgs) Handles pnlAddStudent.Click
        Dim frm As New frmAddStudent()

        frm.ShowDialog()

        LoadStudentsFromDatabase()

    End Sub

    Private Sub picAddStudent_Click(sender As Object, e As EventArgs) Handles picAddStudent.Click
        Dim frm As New frmAddStudent()

        frm.ShowDialog()

        LoadStudentsFromDatabase()

    End Sub

    Private Sub lblAddStudent_Click(sender As Object, e As EventArgs) Handles lblAddStudent.Click
        Dim frm As New frmAddStudent()

        frm.ShowDialog()

        LoadStudentsFromDatabase()

    End Sub

    Private Sub pnlEditStudent_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlEditStudent.MouseClick
        If dgvStudents.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a student.")

            Exit Sub

        End If

        Dim frm As New frmEditStudent()

        frm.StudentNumber =
            dgvStudents.SelectedRows(0).Cells("StudentID").Value.ToString()

        frm.ShowDialog()

        LoadStudentsFromDatabase()
    End Sub

    Private Sub picEditStudent_MouseClick(sender As Object, e As MouseEventArgs) Handles picEditStudent.MouseClick
        If dgvStudents.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a student.")

            Exit Sub

        End If

        Dim frm As New frmEditStudent()

        frm.StudentNumber =
            dgvStudents.SelectedRows(0).Cells("StudentID").Value.ToString()

        frm.ShowDialog()

        LoadStudentsFromDatabase()
    End Sub

    Private Sub lblEditStudent_MouseClick(sender As Object, e As MouseEventArgs) Handles lblEditStudent.MouseClick
        If dgvStudents.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a student.")

            Exit Sub

        End If

        Dim frm As New frmEditStudent()

        frm.StudentNumber =
            dgvStudents.SelectedRows(0).Cells("StudentID").Value.ToString()

        frm.ShowDialog()

        LoadStudentsFromDatabase()
    End Sub
End Class