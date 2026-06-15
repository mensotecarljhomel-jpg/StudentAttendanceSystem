Public Class ucSubjects

    Private Sub ucSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '==========================
        ' Subject Filter
        '==========================
        cboSubjectFilter.Items.Clear()

        cboSubjectFilter.Items.Add("All Subjects")
        cboSubjectFilter.Items.Add("Mathematics")
        cboSubjectFilter.Items.Add("Science")
        cboSubjectFilter.Items.Add("English")
        cboSubjectFilter.Items.Add("Filipino")
        cboSubjectFilter.Items.Add("History")
        cboSubjectFilter.Items.Add("Arts")

        cboSubjectFilter.SelectedIndex = 0

        SetupSubjectGrid()
        LoadSampleSubjects()

    End Sub

    Private Sub SetupSubjectGrid()

        With dgvSubjects

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

            .RowTemplate.Height = 70


            '==========================
            ' Columns
            '==========================
            .Columns.Add("SubjectName", "SUBJECT NAME")
            .Columns.Add("Schedule", "SCHEDULE")
            .Columns.Add("Batch", "BATCH")

            '==========================
            ' Disable Sorting
            '==========================
            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        End With

    End Sub

    Private Sub LoadSampleSubjects()

        dgvSubjects.Rows.Clear()

        dgvSubjects.Rows.Add("Mathematics", "Mon 7:30 AM - 8:30 AM", "Grade 11 - 1")
        dgvSubjects.Rows.Add("English", "Mon 8:30 AM - 9:30 AM", "Grade 11 - 1")
        dgvSubjects.Rows.Add("Science", "Tue 7:30 AM - 8:30 AM", "Grade 11 - 2")
        dgvSubjects.Rows.Add("Filipino", "Tue 8:30 AM - 9:30 AM", "Grade 11 - 2")
        dgvSubjects.Rows.Add("ICT", "Wed 1:00 PM - 2:00 PM", "Grade 12 - 1")
        dgvSubjects.Rows.Add("Programming", "Thu 7:30 AM - 9:00 AM", "Grade 12 - 2")
        dgvSubjects.Rows.Add("Database Management", "Thu 9:00 AM - 10:30 AM", "Grade 12 - 2")
        dgvSubjects.Rows.Add("Web Development", "Fri 1:00 PM - 2:30 PM", "Grade 12 - 3")
        dgvSubjects.Rows.Add("Computer Networks", "Fri 2:30 PM - 4:00 PM", "Grade 12 - 3")
        dgvSubjects.Rows.Add("Physical Education", "Sat 8:00 AM - 10:00 AM", "Grade 11 - 3")

    End Sub

End Class