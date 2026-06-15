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
        LoadSampleStudents()

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
            '==========================
            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        End With

    End Sub

    Private Sub LoadSampleStudents()

        dgvStudents.Rows.Clear()

        dgvStudents.Rows.Add("2025-0001", "Cruz", "Juan", "Male", "Grade 11 - 1", "96%", "Good")
        dgvStudents.Rows.Add("2025-0002", "Santos", "Maria", "Female", "Grade 11 - 1", "92%", "Good")
        dgvStudents.Rows.Add("2025-0003", "Reyes", "John", "Male", "Grade 11 - 2", "83%", "Warning")
        dgvStudents.Rows.Add("2025-0004", "Garcia", "Anne", "Female", "Grade 11 - 2", "88%", "Good")
        dgvStudents.Rows.Add("2025-0005", "Dela Cruz", "Mark", "Male", "Grade 11 - 3", "78%", "Dropout Risk")

        dgvStudents.Rows.Add("2025-0006", "Torres", "Angela", "Female", "Grade 11 - 3", "95%", "Good")
        dgvStudents.Rows.Add("2025-0007", "Mendoza", "Joshua", "Male", "Grade 12 - 1", "82%", "Warning")
        dgvStudents.Rows.Add("2025-0008", "Navarro", "Sophia", "Female", "Grade 12 - 1", "75%", "Dropout Risk")
        dgvStudents.Rows.Add("2025-0009", "Castillo", "Daniel", "Male", "Grade 12 - 2", "91%", "Good")
        dgvStudents.Rows.Add("2025-0010", "Villanueva", "Claire", "Female", "Grade 12 - 3", "98%", "Good")

    End Sub

    Private Sub pnlContentStudents_Paint(sender As Object, e As PaintEventArgs) Handles pnlContentStudents.Paint

    End Sub
End Class
