Imports MySql.Data.MySqlClient
Imports PdfSharpCore.Pdf
Imports PdfSharpCore.Drawing
Imports System.IO

Public Class ucSubjects

    '=================================
    ' Use centralized Database connection
    '=================================
    ' Reuse Database.Connection (defined in Database\Database.vb)

    Private Sub ucSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetupSubjectGrid()
        PopulateSubjectFilter()
        LoadSubjects()

    End Sub

    Private Sub PopulateSubjectFilter()
        cboSubjectFilter.Items.Clear()
        cboSubjectFilter.Items.Add("All Batches")

        Try
            OpenConnection()

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
                        cboSubjectFilter.Items.Add(rdr("batch_name").ToString())
                    End While
                End Using
            End Using

            CloseConnection()
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message)
        End Try

        cboSubjectFilter.SelectedIndex = 0
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
                New System.Drawing.Font("Poppins", 9, System.Drawing.FontStyle.Bold)

            .ColumnHeadersHeight = 45

            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.Font =
                New System.Drawing.Font("Poppins", 9)

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
            OpenConnection()
            ' If there is no active school year, do not restrict by is_active so rows are still visible
            Dim activeCountCmd As New MySqlCommand("SELECT COUNT(*) FROM school_years WHERE IFNULL(is_active,0)=1", Connection)
            Dim activeCount As Integer = Convert.ToInt32(activeCountCmd.ExecuteScalar())

            Dim query As String
            If activeCount > 0 Then
                query =
                    "SELECT
                        s.subject_id,
                        s.subject_name,
                        s.schedule,
                        b.batch_name
                     FROM subjects s
                     INNER JOIN batches b
                     ON s.batch_id = b.batch_id
                     INNER JOIN school_years sy ON b.schoolyear_id = sy.schoolyear_id
                     WHERE IFNULL(sy.is_active,0)=1
                       AND (@filter = 'All Batches' OR b.batch_name = @filter)
                       AND (@search = '' OR s.subject_name LIKE CONCAT('%', @search, '%') OR b.batch_name LIKE CONCAT('%', @search, '%'))"
            Else
                query =
                    "SELECT
                        s.subject_id,
                        s.subject_name,
                        s.schedule,
                        b.batch_name
                     FROM subjects s
                     INNER JOIN batches b
                     ON s.batch_id = b.batch_id
                     INNER JOIN school_years sy ON b.schoolyear_id = sy.schoolyear_id
                     WHERE (@filter = 'All Batches' OR b.batch_name = @filter)
                       AND (@search = '' OR s.subject_name LIKE CONCAT('%', @search, '%') OR b.batch_name LIKE CONCAT('%', @search, '%'))"
            End If

            Dim cmd As New MySqlCommand(query, Connection)
            cmd.Parameters.AddWithValue("@filter", cboSubjectFilter.Text)
            cmd.Parameters.AddWithValue("@search", TextBox1.Text.Trim())
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

            CloseConnection()

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    '------------------------------------------------------------------------------------------------'
    Private Sub pnlPrint_Click(sender As Object, e As EventArgs) Handles pnlPrint.Click
        ExportSubjectsToPdf()

    End Sub

    '------------------------------------------------------------------------------------------------'
    Private Sub pnlDeleteSubject_Click(sender As Object, e As EventArgs) Handles pnlDeleteSubject.Click
        ' Toggle delete mode / confirm delete
        If Not IsDeleteMode_Subjects Then
            IsDeleteMode_Subjects = True
            lblDeleteSubject.Text = "Confirm"
            AddDeleteCheckboxColumn_Subjects()
        Else
            ConfirmAndDeleteSelectedSubjects()
        End If

    End Sub

    '==========================
    ' Delete support for subjects
    '==========================
    Private IsDeleteMode_Subjects As Boolean = False
    Private Const DeleteColumnName_Subjects As String = "chkDeleteSub"

    Private Sub AddDeleteCheckboxColumn_Subjects()
        If dgvSubjects.Columns.Contains(DeleteColumnName_Subjects) Then Exit Sub

        Dim chkColumn As New DataGridViewCheckBoxColumn()
        chkColumn.Name = DeleteColumnName_Subjects
        chkColumn.HeaderText = "SELECT"
        chkColumn.Width = 50

        dgvSubjects.Columns.Insert(0, chkColumn)

        dgvSubjects.ReadOnly = False
        dgvSubjects.SelectionMode = DataGridViewSelectionMode.CellSelect

        For Each col As DataGridViewColumn In dgvSubjects.Columns
            If col.Name <> DeleteColumnName_Subjects Then
                col.ReadOnly = True
            End If
        Next
    End Sub

    Private Sub ConfirmAndDeleteSelectedSubjects()
        dgvSubjects.EndEdit()

        Dim checkedRows As New List(Of DataGridViewRow)

        For Each row As DataGridViewRow In dgvSubjects.Rows
            If dgvSubjects.Columns.Contains(DeleteColumnName_Subjects) Then
                If row.Cells(DeleteColumnName_Subjects).Value IsNot Nothing Then
                    If CBool(row.Cells(DeleteColumnName_Subjects).Value) = True Then
                        checkedRows.Add(row)
                    End If
                End If
            End If
        Next

        If checkedRows.Count = 0 Then
            ResetDeleteMode_Subjects()
            MessageBox.Show("Please select at least one subject.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to delete the selected subjects?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm = DialogResult.No Then Exit Sub

        Try
            OpenConnection()

            For Each row As DataGridViewRow In checkedRows
                Dim subjectID As Integer = Convert.ToInt32(row.Cells("SubjectID").Value)
                Dim query As String = "DELETE FROM subjects WHERE subject_id=@subject_id"
                Using cmd As New MySqlCommand(query, Connection)
                    cmd.Parameters.AddWithValue("@subject_id", subjectID)
                    cmd.ExecuteNonQuery()
                End Using
            Next

            CloseConnection()

            MessageBox.Show("Selected subjects deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        ResetDeleteMode_Subjects()
        LoadSubjects()
    End Sub

    Private Sub ResetDeleteMode_Subjects()
        IsDeleteMode_Subjects = False
        lblDeleteSubject.Text = "Delete"
        If dgvSubjects.Columns.Contains(DeleteColumnName_Subjects) Then
            dgvSubjects.Columns.Remove(DeleteColumnName_Subjects)
        End If
        dgvSubjects.ReadOnly = True
        dgvSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub pnlStartClass_Click(sender As Object, e As EventArgs) Handles pnlStartClass.Click, lblStartClass.Click, picStartClass.Click
        If dgvSubjects.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a subject to start class.")
            Return
        End If

        Dim subjectID As Integer = Convert.ToInt32(dgvSubjects.SelectedRows(0).Cells("SubjectID").Value)

        Dim frm As New StartClass()
        frm.PreselectSubjectID = subjectID

        Dim owner = Me.FindForm()
        If owner IsNot Nothing Then
            frm.ShowDialog(owner)
        Else
            frm.ShowDialog()
        End If
    End Sub

    Private Sub pnlViewRecords_Click(sender As Object, e As EventArgs) Handles pnlViewRecords.Click, lblViewRecords.Click, picViewRecords.Click
        If dgvSubjects.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a subject to view records.")
            Return
        End If

        Dim subjectID As Integer = Convert.ToInt32(dgvSubjects.SelectedRows(0).Cells("SubjectID").Value)

        Dim frm As New frmViewAttendance()
        frm.SubjectID = subjectID
        frm.StartPosition = If(FindForm() IsNot Nothing, FormStartPosition.CenterParent, FormStartPosition.CenterScreen)

        Dim owner = Me.FindForm()
        If owner IsNot Nothing Then
            frm.ShowDialog(owner)
        Else
            frm.ShowDialog()
        End If
    End Sub

    '------------------------------------------------------------------------------------------------'
    Private Sub pnlEditSubject_Click(sender As Object, e As EventArgs) Handles pnlEditSubject.Click
        If dgvSubjects.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a subject.")
            Exit Sub
        End If

        Dim subjectID As Integer = Convert.ToInt32(dgvSubjects.SelectedRows(0).Cells("SubjectID").Value)

        Dim frm As New frmEditSubject()
        frm.SubjectID = subjectID
        frm.StartPosition = If(FindForm() IsNot Nothing, FormStartPosition.CenterParent, FormStartPosition.CenterScreen)

        Dim owner = Me.FindForm()
        If owner IsNot Nothing Then
            frm.ShowDialog(owner)
        Else
            frm.ShowDialog()
        End If

        LoadSubjects()

    End Sub

    '------------------------------------------------------------------------------------------------'
    Private Sub pnlAddSubject_Click(sender As Object, e As EventArgs) Handles pnlAddSubject.Click
        ' Validate: require at least one Batch to exist before adding Subjects
        Try
            OpenConnection()
            Dim batchCountCmd As New MySqlCommand("SELECT COUNT(*) FROM batches", Connection)
            Dim batchCount As Integer = Convert.ToInt32(batchCountCmd.ExecuteScalar())
            CloseConnection()

            If batchCount = 0 Then
                MessageBox.Show("Please create a Batch/Section before adding Subjects.", "Prerequisite Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Catch ex As Exception
            CloseConnection()
            MessageBox.Show(ex.Message)
            Return
        End Try

        Dim frm As New frmAddSubject
        frm.StartPosition = If(FindForm() IsNot Nothing, FormStartPosition.CenterParent, FormStartPosition.CenterScreen)
        frm.ShowDialog()
        LoadSubjects()

    End Sub

    Private Sub pnlAddSubject_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlAddSubject.MouseClick

        Dim frm As New frmAddSubject
        frm.StartPosition = If(FindForm() IsNot Nothing, FormStartPosition.CenterParent, FormStartPosition.CenterScreen)

        Dim owner = FindForm()

        If owner IsNot Nothing Then
            frm.ShowDialog(owner)
        Else
            frm.ShowDialog()
        End If

        LoadSubjects()

    End Sub

    Private Sub ExportSubjectsToPdf()

        Try

            Dim sfd As New SaveFileDialog()

            sfd.Filter = "PDF Files|*.pdf"

            sfd.FileName = "Subjects_Report.pdf"

            If sfd.ShowDialog() <> DialogResult.OK Then Exit Sub

            ' Use PdfSharpCore to generate a simple table-like PDF
            Dim document As New PdfDocument()
            document.Info.Title = "Subject List Report"

            Dim page = document.AddPage()
            page.Size = PdfSharpCore.PageSize.A4
            page.Orientation = PdfSharpCore.PageOrientation.Landscape

            Dim gfx = XGraphics.FromPdfPage(page)
            Dim titleFont = New XFont("Poppins", 16, XFontStyle.Bold)
            Dim font = New XFont("Poppins", 10, XFontStyle.Regular)

            gfx.DrawString("Subject List Report", titleFont, XBrushes.Black, New XRect(0, 10, page.Width, 30), XStringFormats.TopCenter)

            Dim startX As Double = 40
            Dim startY As Double = 50
            Dim rowHeight As Double = 22

            Dim colCount As Integer = dgvSubjects.Columns.Count
            Dim pageWidth As Double = CDbl(page.Width.Point) - 2 * startX
            Dim colWidth As Double = pageWidth / colCount

            ' Draw headers
            Dim x As Double = startX
            For i As Integer = 0 To dgvSubjects.Columns.Count - 1
                Dim hdr = dgvSubjects.Columns(i).HeaderText
                gfx.DrawRectangle(XPens.LightGray, x, startY, colWidth, rowHeight)
                gfx.DrawString(hdr, font, XBrushes.Black, New XRect(x + 4, startY + 4, colWidth - 8, rowHeight - 8), XStringFormats.TopLeft)
                x += colWidth
            Next

            startY += rowHeight

            ' Draw rows
            For Each row As DataGridViewRow In dgvSubjects.Rows
                If row.IsNewRow Then Continue For

                x = startX
                For i As Integer = 0 To dgvSubjects.Columns.Count - 1
                    Dim cellText As String = If(row.Cells(i).Value, "").ToString()
                    gfx.DrawRectangle(XPens.LightGray, x, startY, colWidth, rowHeight)
                    gfx.DrawString(cellText, font, XBrushes.Black, New XRect(x + 4, startY + 4, colWidth - 8, rowHeight - 8), XStringFormats.TopLeft)
                    x += colWidth
                Next

                startY += rowHeight

                If startY + rowHeight > CDbl(page.Height.Point) - 40 Then
                    page = document.AddPage()
                    page.Orientation = PdfSharpCore.PageOrientation.Landscape
                    gfx = XGraphics.FromPdfPage(page)
                    startY = 40
                End If
            Next

            Using fs As New FileStream(sfd.FileName, FileMode.Create)
                document.Save(fs)
            End Using

            MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub pnlAddSubject_Paint(sender As Object, e As PaintEventArgs) Handles pnlAddSubject.Paint

    End Sub
End Class