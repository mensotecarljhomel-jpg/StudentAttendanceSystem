Imports MySql.Data.MySqlClient

Public Class ucSubjects

    '=================================
    ' MySQL Connection
    '=================================
    Dim conn As New MySqlConnection(
        "server=localhost;user id=root;password=;database=proj_db")

    Private Sub ucSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetupSubjectGrid()
        LoadSubjects()

    End Sub

    Private Sub SetupSubjectGrid()

        With dgvSubjects

            .Columns.Clear()

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

            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.Font =
                New Font("Poppins", 9)

            .DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 230, 255)

            .DefaultCellStyle.SelectionForeColor =
                Color.Black

            .RowTemplate.Height = 70

            '==============================
            ' Columns
            '==============================
            .Columns.Add("SubjectID", "SUBJECT ID")
            .Columns.Add("SubjectName", "SUBJECT NAME")
            .Columns.Add("Schedule", "SCHEDULE")
            .Columns.Add("Batch", "BATCH")

            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        End With

    End Sub

    Private Sub LoadSubjects()

        dgvSubjects.Rows.Clear()

        Try

            conn.Open()

            Dim query As String =
                "SELECT
                    s.subject_id,
                    s.subject_name,
                    s.schedule,
                    b.batch_name
                 FROM subjects s
                 INNER JOIN batches b
                 ON s.batch_id = b.batch_id"

            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()

                dgvSubjects.Rows.Add(
                    reader("subject_id").ToString(),
                    reader("subject_name").ToString(),
                    reader("schedule").ToString(),
                    reader("batch_name").ToString()
                )

            End While

            reader.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            conn.Close()

        End Try

    End Sub

    '------------------------------------------------------------------------------------------------'
    Private Sub pnlPrint_Click(sender As Object, e As EventArgs) Handles pnlPrint.Click

    End Sub

    '------------------------------------------------------------------------------------------------'
    Private Sub pnlDeleteSubject_Click(sender As Object, e As EventArgs) Handles pnlDeleteSubject.Click

    End Sub

    '------------------------------------------------------------------------------------------------'
    Private Sub pnlEditSubject_Click(sender As Object, e As EventArgs) Handles pnlEditSubject.Click

    End Sub

    '------------------------------------------------------------------------------------------------'
    Private Sub pnlAddSubject_Click(sender As Object, e As EventArgs) Handles pnlAddSubject.Click

    End Sub

    Private Sub pnlAddSubject_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlAddSubject.MouseClick




    End Sub
End Class