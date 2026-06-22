Public Class ucSchoolYear

    Private Sub ucSchoolYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Font = New Font("Poppins", 10)

        EnsureIsActiveColumn()

        SetupGrid()

        PopulateSchoolYearFilter()
        LoadSchoolYears()

    End Sub

    Private Sub PopulateSchoolYearFilter()
        ' ensure the combobox on the designer exists
        If Not Me.Controls.ContainsKey("cboSchoolYearFilter") Then Return

        Dim cbo = CType(Me.Controls.Find("cboSchoolYearFilter", True)(0), ComboBox)
        cbo.Items.Clear()
        cbo.Items.Add("All Years")
        ' No-op adjustment: keep filter population behavior unchanged

        Try
            OpenConnection()
            Dim q As String = "SELECT DISTINCT school_year FROM school_years ORDER BY school_year DESC"
            Using cmd As New MySql.Data.MySqlClient.MySqlCommand(q, Connection)
                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()
                        cbo.Items.Add(rdr("school_year").ToString())
                    End While
                End Using
            End Using
            CloseConnection()
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message)
        End Try

        cbo.SelectedIndex = 0
    End Sub

    Private Sub EnsureIsActiveColumn()
        Try
            OpenConnection()
            Dim alter As String = "ALTER TABLE school_years ADD COLUMN IF NOT EXISTS is_active TINYINT(1) DEFAULT 0"
            Using cmd As New MySql.Data.MySqlClient.MySqlCommand(alter, Connection)
                cmd.ExecuteNonQuery()
            End Using
            CloseConnection()
        Catch ex As Exception
            CloseConnection()
            ' Ignore - older MySQL may not support IF NOT EXISTS in ALTER; proceed
        End Try
    End Sub

    Private Sub SetupGrid()
        With dgvSchoolYear
            .Columns.Clear()
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            .Columns.Add("SchoolYearID", "ID")
            .Columns.Add("SchoolYear", "SCHOOL YEAR")
            .Columns.Add("Semester", "SEMESTER")
            .Columns.Add("IsActive", "ACTIVE")

            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        End With
    End Sub

    Private Sub LoadSchoolYears()
        dgvSchoolYear.Rows.Clear()

        Try
            OpenConnection()

            Dim query As String = "SELECT schoolyear_id, school_year, semester, IFNULL(is_active,0) AS is_active FROM school_years ORDER BY school_year DESC, semester"

            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(query, Connection)

            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                dgvSchoolYear.Rows.Add(reader("schoolyear_id").ToString(), reader("school_year").ToString(), reader("semester").ToString(), If(Convert.ToInt32(reader("is_active")) = 1, "Yes", "No"))
            End While

            reader.Close()

            CloseConnection()
            ' Apply consistent Students-style DataGridView styling after data load
            StyleSchoolYearGrid(dgvSchoolYear)

            ' Re-apply selection colors in case data binding overwrote them
            dgvSchoolYear.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 230, 255)
            dgvSchoolYear.DefaultCellStyle.SelectionForeColor = Color.Black
            dgvSchoolYear.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 230, 255)
            dgvSchoolYear.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Ensure styling is applied after columns and data are loaded
    Private Sub StyleSchoolYearGrid(dgv As DataGridView)
        dgv.SuspendLayout()
        Try
            ' Match DataGridView styling used on the Batches page for visual consistency
            dgv.EnableHeadersVisualStyles = False
            dgv.BorderStyle = BorderStyle.None
            dgv.BackgroundColor = Color.White
            dgv.GridColor = Color.FromArgb(235, 235, 235)
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            dgv.RowHeadersVisible = False
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv.AllowUserToResizeRows = False
            dgv.AllowUserToAddRows = False

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(244, 242, 252) ' #F4F2FC (matches Batches)
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(107, 114, 128) ' #6B7280
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(244, 242, 252)
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(107, 114, 128)
            dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Poppins", 9.0F, FontStyle.Bold)
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            ' Add a bit more vertical padding to header to match Batches proportions
            dgv.ColumnHeadersDefaultCellStyle.Padding = New Padding(12, 6, 12, 6)
            dgv.ColumnHeadersHeight = 45
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            dgv.RowsDefaultCellStyle.BackColor = Color.White
            dgv.RowsDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34)
            dgv.RowsDefaultCellStyle.Font = New Font("Poppins", 9.0F, FontStyle.Regular)
            dgv.DefaultCellStyle.Font = New Font("Poppins", 9.0F, FontStyle.Regular)
            dgv.DefaultCellStyle.ForeColor = Color.Black

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 230, 255)
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 230, 255)
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.Black

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 246, 253) ' #F8F6FD

            dgv.RowTemplate.Height = 75
            dgv.DefaultCellStyle.Padding = New Padding(10, 12, 10, 12)

            For Each row As DataGridViewRow In dgv.Rows
                row.Height = 75
            Next

            dgv.AllowUserToResizeColumns = True

            dgv.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
            dgv.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single
            dgv.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None

            For Each col As DataGridViewColumn In dgv.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
                col.MinimumWidth = 70
                col.HeaderCell.Style.Padding = New Padding(12, 0, 12, 0)
                If col.ValueType IsNot Nothing AndAlso (col.ValueType.IsAssignableFrom(GetType(Integer)) OrElse col.ValueType.IsAssignableFrom(GetType(Decimal))) Then
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Else
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End If
            Next
        Finally
            dgv.ResumeLayout()
        End Try
    End Sub

    Private Sub pnlAddSchoolYear_Click(sender As Object, e As EventArgs) Handles pnlAddSchoolYear.Click
        Dim frm As New frmAddSchoolYear()
        frm.StartPosition = If(FindForm() IsNot Nothing, FormStartPosition.CenterParent, FormStartPosition.CenterScreen)
        frm.ShowDialog()
        LoadSchoolYears()
    End Sub

    Private Sub pnlEditSchoolYear_Click(sender As Object, e As EventArgs) Handles pnlEditSchoolYear.Click
        If dgvSchoolYear.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a school year.")
            Return
        End If

        Dim id As Integer = Convert.ToInt32(dgvSchoolYear.SelectedRows(0).Cells("SchoolYearID").Value)

        Dim frm As New frmAddSchoolYear()
        frm.SchoolYearID = id
        frm.StartPosition = If(FindForm() IsNot Nothing, FormStartPosition.CenterParent, FormStartPosition.CenterScreen)
        frm.ShowDialog()
        LoadSchoolYears()
    End Sub

    Private Sub pnlDeleteSchoolYear_Click(sender As Object, e As EventArgs) Handles pnlDeleteSchoolYear.Click
        ' Toggle delete mode / confirm delete
        If Not IsDeleteMode_SchoolYear Then
            IsDeleteMode_SchoolYear = True
            lblDeleteSchoolYear.Text = "Confirm"
            AddDeleteCheckboxColumn_SchoolYear()
        Else
            ConfirmAndDeleteSelectedSchoolYears()
        End If
    End Sub

    '==========================
    ' Delete support for school years
    '==========================
    Private IsDeleteMode_SchoolYear As Boolean = False
    Private Const DeleteColumnName_SchoolYear As String = "chkDeleteSY"

    Private Sub AddDeleteCheckboxColumn_SchoolYear()
        If dgvSchoolYear.Columns.Contains(DeleteColumnName_SchoolYear) Then Exit Sub

        Dim chkColumn As New DataGridViewCheckBoxColumn()
        chkColumn.Name = DeleteColumnName_SchoolYear
        chkColumn.HeaderText = "SELECT"
        chkColumn.Width = 50

        dgvSchoolYear.Columns.Insert(0, chkColumn)

        dgvSchoolYear.ReadOnly = False
        dgvSchoolYear.SelectionMode = DataGridViewSelectionMode.CellSelect

        For Each col As DataGridViewColumn In dgvSchoolYear.Columns
            If col.Name <> DeleteColumnName_SchoolYear Then
                col.ReadOnly = True
            End If
        Next
    End Sub

    Private Sub dgvSchoolYear_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchoolYear.CellContentClick
        If e.RowIndex < 0 Then Return

        If dgvSchoolYear.Columns.Contains(DeleteColumnName_SchoolYear) Then
            If e.ColumnIndex = dgvSchoolYear.Columns(DeleteColumnName_SchoolYear).Index Then
                dgvSchoolYear.EndEdit()
            End If
        End If
    End Sub

    Private Sub ConfirmAndDeleteSelectedSchoolYears()
        dgvSchoolYear.EndEdit()

        Dim checkedRows As New List(Of DataGridViewRow)

        For Each row As DataGridViewRow In dgvSchoolYear.Rows
            If dgvSchoolYear.Columns.Contains(DeleteColumnName_SchoolYear) Then
                If row.Cells(DeleteColumnName_SchoolYear).Value IsNot Nothing Then
                    If CBool(row.Cells(DeleteColumnName_SchoolYear).Value) = True Then
                        checkedRows.Add(row)
                    End If
                End If
            End If
        Next

        If checkedRows.Count = 0 Then
            ResetDeleteMode_SchoolYear()
            MessageBox.Show("Please select at least one school year.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm = MessageBox.Show("Delete selected school years?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Return

        Try
            OpenConnection()
            For Each row As DataGridViewRow In checkedRows
                Dim id As Integer = Convert.ToInt32(row.Cells("SchoolYearID").Value)
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM school_years WHERE schoolyear_id=@id", Connection)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            Next
            CloseConnection()
            MessageBox.Show("Selected school years deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message)
        End Try

        ResetDeleteMode_SchoolYear()
        LoadSchoolYears()
    End Sub

    Private Sub ResetDeleteMode_SchoolYear()
        IsDeleteMode_SchoolYear = False
        lblDeleteSchoolYear.Text = "Delete"
        If dgvSchoolYear.Columns.Contains(DeleteColumnName_SchoolYear) Then
            dgvSchoolYear.Columns.Remove(DeleteColumnName_SchoolYear)
        End If
        dgvSchoolYear.ReadOnly = True
        dgvSchoolYear.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    ' Double click toggles active
    Private Sub dgvSchoolYear_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchoolYear.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim id As Integer = Convert.ToInt32(dgvSchoolYear.Rows(e.RowIndex).Cells("SchoolYearID").Value)

        Try
            OpenConnection()

            ' Set all to inactive
            Dim resetCmd As New MySql.Data.MySqlClient.MySqlCommand("UPDATE school_years SET is_active=0", Connection)
            resetCmd.ExecuteNonQuery()

            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand("UPDATE school_years SET is_active=1 WHERE schoolyear_id=@id", Connection)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()

            CloseConnection()
            dgvSchoolYear.RowTemplate.Height = 75
            MessageBox.Show("School year activated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message)
        End Try

        LoadSchoolYears()
    End Sub

    Private Sub lblSearch_TextChanged(sender As Object, e As EventArgs)
        ' Use TextBox1 (designer) as search input if present
        Dim searchText As String = ""
        If Me.Controls.ContainsKey("TextBox1") Then
            searchText = CType(Me.Controls.Find("TextBox1", True)(0), TextBox).Text.Trim().ToLower()
        End If

        For Each row As DataGridViewRow In dgvSchoolYear.Rows
            row.Visible = True
            If Not String.IsNullOrWhiteSpace(searchText) Then
                Dim text = searchText
                Dim match = row.Cells("SchoolYear").Value.ToString().ToLower().Contains(text) OrElse row.Cells("Semester").Value.ToString().ToLower().Contains(text)
                row.Visible = match
            End If
        Next
    End Sub

End Class

