Public Class ucBatches

    Private Sub ucBatches_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '==========================
        ' Batch Filter
        '==========================
        cboBatchFilter.Items.Clear()

        cboBatchFilter.Items.Add("All Batches")
        cboBatchFilter.Items.Add("Grade 11 - 1")
        cboBatchFilter.Items.Add("Grade 11 - 2")
        cboBatchFilter.Items.Add("Grade 11 - 3")
        cboBatchFilter.Items.Add("Grade 12 - 1")
        cboBatchFilter.Items.Add("Grade 12 - 2")
        cboBatchFilter.Items.Add("Grade 12 - 3")

        cboBatchFilter.SelectedIndex = 0

        SetupBatchGrid()
        LoadSampleBatches()

    End Sub

    Private Sub SetupBatchGrid()

        With dgvBatches

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

            .RowTemplate.Height = 75

            '==========================
            ' Columns
            '==========================
            .Columns.Add("BatchID", "BATCH ID")
            .Columns.Add("BatchName", "BATCH NAME")
            .Columns.Add("Adviser", "ADVISER")
            .Columns.Add("StudentCount", "STUDENT COUNT")
            .Columns.Add("SubjectCount", "SUBJECT COUNT")
            .Columns.Add("Attendance", "AVERAGE ATTENDANCE")
            .Columns.Add("Status", "STATUS")

            '==========================
            ' Disable Sorting
            '==========================
            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        End With

    End Sub

    Private Sub LoadSampleBatches()

        dgvBatches.Rows.Clear()

        dgvBatches.Rows.Add("G11-1", "Grade 11 - 1", "Mr. Santos", "35", "8", "96%", "Outstanding")

        dgvBatches.Rows.Add("G11-2", "Grade 11 - 2", "Ms. Reyes", "32", "8", "83%", "Satisfied")

        dgvBatches.Rows.Add("G11-3", "Grade 11 - 3", "Mr. Bautista", "38", "8", "91%", "Outstanding")

        dgvBatches.Rows.Add("G12-1", "Grade 12 - 1", "Mr. Cruz", "30", "7", "77%", "Unsatisfied")

        dgvBatches.Rows.Add("G12-2", "Grade 12 - 2", "Ms. Villanueva", "31", "7", "85%", "Satisfied")

        dgvBatches.Rows.Add("G12-3", "Grade 12 - 3", "Mr. Dela Rosa", "29", "6", "94%", "Outstanding")

    End Sub

    Private Sub dgvBatches_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub pnlContentBatches_Paint(sender As Object, e As PaintEventArgs) Handles pnlContentBatches.Paint

    End Sub

    Private Sub cboBatchFilter_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboBatchFilter_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlAddBatches_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlAddBatches.MouseClick

    End Sub
End Class