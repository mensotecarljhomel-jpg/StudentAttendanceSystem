Imports MySql.Data.MySqlClient

Public Class ucBatches

    '==========================
    ' MySQL Connection
    '==========================
    Dim conn As New MySqlConnection(
        "server=localhost;user id=root;password=;database=proj_db")

    Private Sub ucBatches_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetupBatchGrid()

        cboBatchFilter.Items.Clear()

        cboBatchFilter.Items.Add("All Batches")
        cboBatchFilter.Items.Add("Grade 11 - 1")
        cboBatchFilter.Items.Add("Grade 11 - 2")
        cboBatchFilter.Items.Add("Grade 11 - 3")
        cboBatchFilter.Items.Add("Grade 12 - 1")
        cboBatchFilter.Items.Add("Grade 12 - 2")
        cboBatchFilter.Items.Add("Grade 12 - 3")

        cboBatchFilter.SelectedIndex = 0

        'Remove this line
        'LoadBatches()

    End Sub

    Private Sub SetupBatchGrid()

        With dgvBatches

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
            .DefaultCellStyle.Font = New Font("Poppins", 9)

            .DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 230, 255)

            .DefaultCellStyle.SelectionForeColor = Color.Black

            .RowTemplate.Height = 75

            '==========================
            ' Columns
            '==========================
            .Columns.Add("BatchID", "BATCH ID")
            .Columns.Add("BatchName", "BATCH NAME")
            .Columns.Add("Adviser", "ADVISER")
            .Columns.Add("SchoolYear", "SCHOOL YEAR")

            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        End With

    End Sub

    Private Sub LoadBatches()

        dgvBatches.Rows.Clear()

        Try

            conn.Open()

            Dim query As String =
                "SELECT b.batch_id,
                        b.batch_name,
                        b.adviser,
                        sy.school_year
                 FROM batches b
                 INNER JOIN school_years sy
                 ON b.schoolyear_id = sy.schoolyear_id"

            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()

                dgvBatches.Rows.Add(
                    reader("batch_id").ToString(),
                    reader("batch_name").ToString(),
                    reader("adviser").ToString(),
                    reader("school_year").ToString()
                )

            End While

            reader.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub dgvBatches_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub pnlContentBatches_Paint(sender As Object, e As PaintEventArgs) Handles pnlContentBatches.Paint

    End Sub

    Private Sub cboBatchFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBatchFilter.SelectedIndexChanged

        LoadBatches()

    End Sub

    Private Sub RoundedPanel1_Paint(sender As Object, e As PaintEventArgs) Handles RoundedPanel1.Paint

    End Sub


    Private Sub pnlAddBatches_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlAddBatches.MouseClick
        Dim frm As New frmAddBatch()
        frm.ShowDialog()
        LoadBatches()
    End Sub



    '----------------------------------------------------------------------------------------------------------------'
    ' Refresh button
    Private Sub pnlRefreshBatches_Click(sender As Object, e As EventArgs) Handles pnlRefreshBatches.Click

    End Sub
    '----------------------------------------------------------------------------------------------------------------'

    'Delete Button
    Private Sub pnlDeleteBatches_Click(sender As Object, e As EventArgs) Handles pnlDeleteBatches.Click

    End Sub

    '----------------------------------------------------------------------------------------------------------------'
    'Edit Button
    Private Sub pnlEditBatches_Click(sender As Object, e As EventArgs) Handles pnlEditBatches.Click

    End Sub

    '----------------------------------------------------------------------------------------------------------------'
    ' Add Button
    Private Sub pnlAddBatches_Click(sender As Object, e As EventArgs) Handles pnlAddBatches.Click

    End Sub

    Private Sub pnlAddBatches_Paint(sender As Object, e As PaintEventArgs) Handles pnlAddBatches.Paint

    End Sub

    '----------------------------------------------------------------------------------------------------------------'
End Class