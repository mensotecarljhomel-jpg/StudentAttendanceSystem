Imports System.Drawing.Printing
Imports System.IO
Imports System.Reflection.Metadata
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class ucStudents

    Private Sub ucStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '==========================
        ' Grid Setup
        ' MUST run before anything that can trigger
        ' LoadStudentsFromDatabase() (e.g. setting
        ' cboBatchFilter.SelectedIndex below), otherwise
        ' Rows.Add() runs against a grid with 0 columns.
        '==========================
        SetupStudentGrid()

        '==========================
        ' Search Box Styling
        '==========================
        SetupSearchBox()

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

        ' NOTE: this line fires cboBatchFilter_SelectedIndexChanged
        ' immediately, which calls LoadStudentsFromDatabase().
        ' That's fine now because SetupStudentGrid() already ran above,
        ' so the grid already has its columns. (No need for a separate
        ' explicit LoadStudentsFromDatabase() call after this anymore —
        ' the SelectedIndexChanged event already does it.)
        cboBatchFilter.SelectedIndex = 0

    End Sub

    Private Sub SetupStudentGrid()

        With dgvStudents

            .Columns.Clear()

            '==========================
            ' Basic Settings
            '==========================

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ReadOnly = True

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
    New System.Drawing.Font(
        "Poppins",
        9,
        System.Drawing.FontStyle.Bold
    )

            .ColumnHeadersHeight = 45

            '==========================
            ' Cell Style
            '==========================
            .DefaultCellStyle.BackColor = Color.White

            .DefaultCellStyle.ForeColor = Color.Black

            .DefaultCellStyle.Font =
    New System.Drawing.Font("Poppins", 9)
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

    '==========================
    ' Search Box Setup
    ' (one-time styling — must NOT live inside
    ' txtSearch_TextChanged, or it reapplies and
    ' fights the user on every keystroke)
    '==========================
    Private Sub SetupSearchBox()

        TextBox1.BackColor = Color.FromArgb(244, 242, 252)
        TextBox1.ForeColor = Color.FromArgb(107, 114, 128)
        TextBox1.BorderStyle = BorderStyle.None

        TextBox1.Font = New System.Drawing.Font(
    "Poppins",
    10,
    System.Drawing.FontStyle.Regular
)

        TextBox1.Text = "Search by name or student ID"

    End Sub

    Public Sub LoadStudentsFromDatabase()

        Try

            OpenConnection()

            dgvStudents.Rows.Clear()

            Dim searchTerm As String = TextBox1.Text.Trim()

            If searchTerm = "Search by name or student ID" Then
                searchTerm = ""
            End If

            Dim query As String =
                "SELECT s.student_number,
                        s.last_name,
                        s.first_name,
                        s.gender,
                        b.batch_name
                 FROM students s
                 INNER JOIN batches b
                 ON s.batch_id = b.batch_id
                 WHERE (@batch = 'All Sections' OR b.batch_name = @batch)
                   AND (@search = ''
                        OR s.student_number LIKE CONCAT('%', @search, '%')
                        OR s.last_name LIKE CONCAT('%', @search, '%')
                        OR s.first_name LIKE CONCAT('%', @search, '%'))
                 ORDER BY s.student_number"

            Dim cmd As New MySqlCommand(query, Connection)

            cmd.Parameters.AddWithValue("@batch", cboBatchFilter.Text)
            cmd.Parameters.AddWithValue("@search", searchTerm)

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

    '==========================
    ' Class Variables
    '==========================
    Private IsDeleteMode As Boolean = False
    Private Const DeleteColumnName As String = "chkDelete"

    '==========================
    ' Delete Button Click
    '==========================
    Private Sub pnlDeleteStudent_Click(sender As Object, e As EventArgs) Handles pnlDeleteStudent.Click

        If Not IsDeleteMode Then

            IsDeleteMode = True

            lblDeleteStudent.Text = "Confirm"

            AddDeleteCheckboxColumn()

        Else

            ConfirmAndDeleteSelectedStudents()

        End If

    End Sub
    Private Sub ExportStudentsToPdf()

        Try

            Dim sfd As New SaveFileDialog()

            sfd.Filter = "PDF Files|*.pdf"

            sfd.FileName = "Students_Report.pdf"

            If sfd.ShowDialog() <> DialogResult.OK Then Exit Sub

            Dim doc As New iTextSharp.text.Document(
    iTextSharp.text.PageSize.A4.Rotate()
)

            PdfWriter.GetInstance(
            doc,
            New FileStream(
                sfd.FileName,
                FileMode.Create
            )
        )

            doc.Open()

            Dim title As New Paragraph(
            "Student Attendance Report"
        )

            title.Alignment = Element.ALIGN_CENTER

            title.SpacingAfter = 20

            doc.Add(title)

            Dim table As New PdfPTable(
            dgvStudents.Columns.Count
        )

            table.WidthPercentage = 100

            ' Headers
            For Each col As DataGridViewColumn In dgvStudents.Columns

                table.AddCell(col.HeaderText)

            Next

            ' Rows
            For Each row As DataGridViewRow In dgvStudents.Rows

                If Not row.IsNewRow Then

                    For Each cell As DataGridViewCell In row.Cells

                        table.AddCell(
                        If(cell.Value, "").ToString()
                    )

                    Next

                End If

            Next

            doc.Add(table)

            doc.Close()

            MessageBox.Show(
            "PDF generated successfully!",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    '==========================
    ' Add Checkbox Column
    '==========================
    Private Sub AddDeleteCheckboxColumn()
        If dgvStudents.Columns.Contains(DeleteColumnName) Then Exit Sub

        Dim chkColumn As New DataGridViewCheckBoxColumn()

        chkColumn.Name = DeleteColumnName

        chkColumn.HeaderText = "SELECT"

        chkColumn.Width = 50

        dgvStudents.Columns.Insert(0, chkColumn)

        dgvStudents.ReadOnly = False
        dgvStudents.SelectionMode = DataGridViewSelectionMode.CellSelect

        For Each col As DataGridViewColumn In dgvStudents.Columns

            If col.Name <> DeleteColumnName Then

                col.ReadOnly = True

            End If

        Next

    End Sub

    '==========================
    ' Checkbox Commit Fix
    '==========================
    Private Sub dgvStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        If dgvStudents.Columns.Contains(DeleteColumnName) Then
            If e.ColumnIndex = dgvStudents.Columns(DeleteColumnName).Index Then
                dgvStudents.EndEdit()
            End If
        End If

    End Sub

    '==========================
    ' Confirm And Delete
    '==========================
    Private Sub ConfirmAndDeleteSelectedStudents()

        dgvStudents.EndEdit()

        Dim checkedRows As New List(Of DataGridViewRow)

        For Each row As DataGridViewRow In dgvStudents.Rows

            If row.Cells(DeleteColumnName).Value IsNot Nothing Then

                If CBool(row.Cells(DeleteColumnName).Value) = True Then

                    checkedRows.Add(row)

                End If

            End If

        Next

        If checkedRows.Count = 0 Then
            ResetDeleteMode()
            MessageBox.Show("Please select at least one student.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to delete the selected students?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm = DialogResult.No Then Exit Sub

        Try

            OpenConnection()

            For Each row As DataGridViewRow In checkedRows

                Dim studentNumber As String = row.Cells("StudentID").Value.ToString()

                Dim query As String = "DELETE FROM students WHERE student_number=@student_number"

                Using cmd As New MySqlCommand(query, Connection)
                    cmd.Parameters.AddWithValue("@student_number", studentNumber)
                    cmd.ExecuteNonQuery()
                End Using

            Next

            CloseConnection()

            MessageBox.Show("Selected students deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            CloseConnection()

            MessageBox.Show(ex.Message)

            Exit Sub

        End Try

        ResetDeleteMode()

        LoadStudentsFromDatabase()

    End Sub

    '==========================
    ' Reset Delete Mode
    '==========================
    Private Sub ResetDeleteMode()

        IsDeleteMode = False

        lblDeleteStudent.Text = "Delete"

        If dgvStudents.Columns.Contains(DeleteColumnName) Then
            dgvStudents.Columns.Remove(DeleteColumnName)
        End If

        dgvStudents.ReadOnly = True
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub cboBatchFilter_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboBatchFilter.SelectedIndexChanged

        ' Defensive guard: never touch the grid before it has columns
        If dgvStudents.Columns.Count = 0 Then Exit Sub

        LoadStudentsFromDatabase()

    End Sub

    Private Sub pnlSearch_Paint(sender As Object, e As PaintEventArgs) Handles TextBox1.Paint, TextBox1.Paint

    End Sub

    Private Sub imgSearch_Click(sender As Object, e As EventArgs) Handles imgSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox1.TextChanged

        ' Defensive guard: never touch the grid before it has columns
        If dgvStudents.Columns.Count = 0 Then Exit Sub

        LoadStudentsFromDatabase()

    End Sub

    Private Sub txtSearch_Enter(
        sender As Object,
        e As EventArgs
    ) Handles TextBox1.Enter, TextBox1.Enter

        If TextBox1.Text = "Search by name or student ID" Then

            TextBox1.Text = ""

            TextBox1.ForeColor = Color.Black

        End If

    End Sub


    Private Sub txtSearch_Leave(
        sender As Object,
        e As EventArgs
    ) Handles TextBox1.Leave, TextBox1.Leave

        If TextBox1.Text.Trim = "" Then

            TextBox1.Text = "Search by name or student ID"

            TextBox1.ForeColor =
                Color.FromArgb(107, 114, 128)

        End If

    End Sub

    Private Sub lblDeleteStudent_MouseClick(sender As Object, e As MouseEventArgs) Handles lblDeleteStudent.MouseClick
        If Not IsDeleteMode Then

            IsDeleteMode = True

            lblDeleteStudent.Text = "Confirm"

            AddDeleteCheckboxColumn()

        Else

            ConfirmAndDeleteSelectedStudents()

        End If
    End Sub

    Private Sub picDeleteStudent_MouseClick(sender As Object, e As MouseEventArgs) Handles picDeleteStudent.MouseClick
        If Not IsDeleteMode Then

            IsDeleteMode = True

            lblDeleteStudent.Text = "Confirm"

            AddDeleteCheckboxColumn()

        Else

            ConfirmAndDeleteSelectedStudents()

        End If
    End Sub

    Private Sub pnlPrint_Click(
    sender As Object,
    e As EventArgs
) Handles pnlPrint.Click

        ExportStudentsToPdf()

    End Sub
End Class