Imports MySql.Data.MySqlClient

Public Class ucBatches

    '==========================
    ' Use centralized Database connection
    '==========================
    ' Reuse Database.Connection (defined in Database\Database.vb)

    Private Sub ucBatches_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetupBatchGrid()
        PopulateBatchFilter()
        LoadBatches()

    End Sub

    Private Sub PopulateBatchFilter()
        cboBatchFilter.Items.Clear()
        cboBatchFilter.Items.Add("All Batches")

        Try
            OpenConnection()

            ' If there is no active school year set in the DB, fall back to showing all batches
            Dim activeCountCmd As New MySqlCommand("SELECT COUNT(*) FROM school_years WHERE IFNULL(is_active,0)=1", Connection)
            Dim activeCount As Integer = Convert.ToInt32(activeCountCmd.ExecuteScalar())

            Dim q As String
            If activeCount > 0 Then
                q = "SELECT DISTINCT b.batch_name FROM batches b INNER JOIN school_years sy ON b.schoolyear_id = sy.schoolyear_id WHERE IFNULL(sy.is_active,0)=1 ORDER BY b.batch_name"
            Else
                q = "SELECT DISTINCT b.batch_name FROM batches b INNER JOIN school_years sy ON b.schoolyear_id = sy.schoolyear_id ORDER BY b.batch_name"
            End If

            Using cmd As New MySqlCommand(q, Connection)
                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()
                        cboBatchFilter.Items.Add(rdr("batch_name").ToString())
                    End While
                End Using
            End Using

            CloseConnection()
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message)
        End Try

        cboBatchFilter.SelectedIndex = 0
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
            OpenConnection()
            ' If there is no active school year set, do not restrict by is_active so rows are still visible
            Dim activeCountCmd As New MySqlCommand("SELECT COUNT(*) FROM school_years WHERE IFNULL(is_active,0)=1", Connection)
            Dim activeCount As Integer = Convert.ToInt32(activeCountCmd.ExecuteScalar())

            Dim query As String
            If activeCount > 0 Then
                query =
                    "SELECT b.batch_id,
                            b.batch_name,
                            b.adviser,
                            sy.school_year
                     FROM batches b
                     INNER JOIN school_years sy
                     ON b.schoolyear_id = sy.schoolyear_id
                     WHERE IFNULL(sy.is_active,0)=1
                       AND (@filter = 'All Batches' OR b.batch_name = @filter)
                       AND (@search = '' OR b.batch_name LIKE CONCAT('%', @search, '%') OR b.adviser LIKE CONCAT('%', @search, '%'))"
            Else
                query =
                    "SELECT b.batch_id,
                            b.batch_name,
                            b.adviser,
                            sy.school_year
                     FROM batches b
                     INNER JOIN school_years sy
                     ON b.schoolyear_id = sy.schoolyear_id
                     WHERE (@filter = 'All Batches' OR b.batch_name = @filter)
                       AND (@search = '' OR b.batch_name LIKE CONCAT('%', @search, '%') OR b.adviser LIKE CONCAT('%', @search, '%'))"
            End If

            Dim cmd As New MySqlCommand(query, Connection)
            cmd.Parameters.AddWithValue("@filter", cboBatchFilter.Text)
            cmd.Parameters.AddWithValue("@search", TextBox1.Text.Trim())

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

                CloseConnection()

                MessageBox.Show(ex.Message)

            Finally

                CloseConnection()

            End Try

    End Sub



    Private Sub pnlContentBatches_Paint(sender As Object, e As PaintEventArgs) Handles pnlContentBatches.Paint

    End Sub

    Private Sub cboBatchFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBatchFilter.SelectedIndexChanged

        LoadBatches()

    End Sub

    Private Sub RoundedPanel1_Paint(sender As Object, e As PaintEventArgs) Handles RoundedPanel1.Paint

    End Sub


    ' MouseClick handler removed to avoid duplicate dialog invocation. Use Click handler below.



    '----------------------------------------------------------------------------------------------------------------'
    ' Refresh button
    Private Sub pnlRefreshBatches_Click(sender As Object, e As EventArgs) Handles pnlRefreshBatches.Click
        LoadBatches()

    End Sub
    '----------------------------------------------------------------------------------------------------------------'

    'Delete Button
    Private Sub pnlDeleteBatches_Click(sender As Object, e As EventArgs) Handles pnlDeleteBatches.Click
        ' Toggle delete mode / confirm delete
        If Not IsDeleteMode_Batches Then
            IsDeleteMode_Batches = True
            lblDeleteBatches.Text = "Confirm"
            AddDeleteCheckboxColumn_Batches()
        Else
            ConfirmAndDeleteSelectedBatches()
        End If

    End Sub

    '==========================
    ' Delete support for batches
    '==========================
    Private IsDeleteMode_Batches As Boolean = False
    Private Const DeleteColumnName_Batches As String = "chkDeleteBatch"

    Private Sub AddDeleteCheckboxColumn_Batches()
        If dgvBatches.Columns.Contains(DeleteColumnName_Batches) Then Exit Sub

        Dim chkColumn As New DataGridViewCheckBoxColumn()
        chkColumn.Name = DeleteColumnName_Batches
        chkColumn.HeaderText = "SELECT"
        chkColumn.Width = 50

        dgvBatches.Columns.Insert(0, chkColumn)

        dgvBatches.ReadOnly = False
        dgvBatches.SelectionMode = DataGridViewSelectionMode.CellSelect

        For Each col As DataGridViewColumn In dgvBatches.Columns
            If col.Name <> DeleteColumnName_Batches Then
                col.ReadOnly = True
            End If
        Next
    End Sub

    Private Sub dgvBatches_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBatches.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        If dgvBatches.Columns.Contains(DeleteColumnName_Batches) Then
            If e.ColumnIndex = dgvBatches.Columns(DeleteColumnName_Batches).Index Then
                dgvBatches.EndEdit()
            End If
        End If
    End Sub

    Private Sub ConfirmAndDeleteSelectedBatches()
        dgvBatches.EndEdit()

        Dim checkedRows As New List(Of DataGridViewRow)

        For Each row As DataGridViewRow In dgvBatches.Rows
            If dgvBatches.Columns.Contains(DeleteColumnName_Batches) Then
                If row.Cells(DeleteColumnName_Batches).Value IsNot Nothing Then
                    If CBool(row.Cells(DeleteColumnName_Batches).Value) = True Then
                        checkedRows.Add(row)
                    End If
                End If
            End If
        Next

        If checkedRows.Count = 0 Then
            ResetDeleteMode_Batches()
            MessageBox.Show("Please select at least one batch.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to delete the selected batches?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm = DialogResult.No Then Exit Sub

        Try
            OpenConnection()

            For Each row As DataGridViewRow In checkedRows
                Dim batchID As Integer = Convert.ToInt32(row.Cells("BatchID").Value)
                Dim query As String = "DELETE FROM batches WHERE batch_id=@batch_id"
                Using cmd As New MySqlCommand(query, Connection)
                    cmd.Parameters.AddWithValue("@batch_id", batchID)
                    cmd.ExecuteNonQuery()
                End Using
            Next

            CloseConnection()

            MessageBox.Show("Selected batches deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        ResetDeleteMode_Batches()
        LoadBatches()
    End Sub

    Private Sub ResetDeleteMode_Batches()
        IsDeleteMode_Batches = False
        lblDeleteBatches.Text = "Delete"
        If dgvBatches.Columns.Contains(DeleteColumnName_Batches) Then
            dgvBatches.Columns.Remove(DeleteColumnName_Batches)
        End If
        dgvBatches.ReadOnly = True
        dgvBatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    '----------------------------------------------------------------------------------------------------------------'
    'Edit Button
    Private Sub pnlEditBatches_Click(sender As Object, e As EventArgs) Handles pnlEditBatches.Click
        If dgvBatches.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a batch.")

            Exit Sub

        End If

        Dim batchID As Integer = Convert.ToInt32(dgvBatches.SelectedRows(0).Cells("BatchID").Value)

        Dim currentName As String = dgvBatches.SelectedRows(0).Cells("BatchName").Value.ToString()

        Dim currentAdviser As String = dgvBatches.SelectedRows(0).Cells("Adviser").Value.ToString()

        Dim frm As New frmEditBatch()
        frm.BatchID = batchID
        frm.StartPosition = If(FindForm() IsNot Nothing, FormStartPosition.CenterParent, FormStartPosition.CenterScreen)

        Dim owner = Me.FindForm()
        If owner IsNot Nothing Then
            frm.ShowDialog(owner)
        Else
            frm.ShowDialog()
        End If

        LoadBatches()

    End Sub

    '----------------------------------------------------------------------------------------------------------------'
    ' Add Button
    Private Sub pnlAddBatches_Click(sender As Object, e As EventArgs) Handles pnlAddBatches.Click
        Dim frm As New frmAddBatch()
        frm.StartPosition = If(FindForm() IsNot Nothing, FormStartPosition.CenterParent, FormStartPosition.CenterScreen)
        Dim owner = Me.FindForm()

        If owner IsNot Nothing Then
            frm.ShowDialog(owner)
        Else
            frm.ShowDialog()
        End If

        LoadBatches()

    End Sub

    Private Sub pnlAddBatches_Paint(sender As Object, e As PaintEventArgs) Handles pnlAddBatches.Paint

    End Sub

    '----------------------------------------------------------------------------------------------------------------'
End Class