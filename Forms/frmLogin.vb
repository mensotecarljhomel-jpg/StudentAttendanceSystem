Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Wire placeholder label clicks to focus corresponding textboxes
        AddHandler lblUser.Click, AddressOf lblUser_Click
        AddHandler lblPass.Click, AddressOf lblPass_Click

        ' Wire textbox focus events to show/hide placeholders
        AddHandler txtUsername.GotFocus, AddressOf txtUsername_GotFocus
        AddHandler txtUsername.LostFocus, AddressOf txtUsername_LostFocus
        AddHandler txtUsername.TextChanged, AddressOf txtUsername_TextChanged

        AddHandler txtPassword.GotFocus, AddressOf txtPassword_GotFocus
        AddHandler txtPassword.LostFocus, AddressOf txtPassword_LostFocus
        AddHandler txtPassword.TextChanged, AddressOf txtPassword_TextChanged

        ' Ensure initial placeholder visibility
        UpdateUsernamePlaceholder()
        UpdatePasswordPlaceholder()
    End Sub

    Private Sub pnlLogin_Click(sender As Object, e As EventArgs) Handles pnlLogin.Click, lblLogin.Click
        DoLogin()
    End Sub

    Private Sub DoLogin()
        ' Basic validation
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please enter username.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Focus()
            Return
        End If

        ' Authenticate against database users table (supports users or tbl_users)
        Try
            OpenConnection()

            Dim tableCmd As New MySql.Data.MySqlClient.MySqlCommand(
                "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME IN ('users','tbl_users') LIMIT 1",
                Connection)

            Dim tableNameObj = tableCmd.ExecuteScalar()
            If tableNameObj Is Nothing OrElse String.IsNullOrEmpty(tableNameObj.ToString()) Then
                MessageBox.Show("No users table found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim tableName As String = tableNameObj.ToString()

            Dim authQuery As String = "SELECT COUNT(*) FROM " & tableName & " WHERE username = @u AND password = @p"
            Dim authCmd As New MySql.Data.MySqlClient.MySqlCommand(authQuery, Connection)
            authCmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
            authCmd.Parameters.AddWithValue("@p", txtPassword.Text)

            Dim matched As Integer = Convert.ToInt32(authCmd.ExecuteScalar())

            If matched > 0 Then
                ' Read role if available
                Dim role As String = ""
                Try
                    Dim roleCmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT role FROM " & tableName & " WHERE username=@u LIMIT 1", Connection)
                    roleCmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
                    Dim roleObj = roleCmd.ExecuteScalar()
                    If roleObj IsNot Nothing Then role = roleObj.ToString()
                Catch
                    role = ""
                End Try

                ' Set current session
                CurrentSession.SignIn(txtUsername.Text.Trim(), role)

                ' Successful login
                Dim dash As New Dashboard()
                dash.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Clear()
                txtPassword.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs)
        txtUsername.Focus()
    End Sub

    Private Sub lblPass_Click(sender As Object, e As EventArgs)
        txtPassword.Focus()
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs)
        lblUser.Visible = False
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs)
        UpdateUsernamePlaceholder()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs)
        If txtUsername.TextLength > 0 Then
            lblUser.Visible = False
        Else
            UpdateUsernamePlaceholder()
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs)
        lblPass.Visible = False
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs)
        UpdatePasswordPlaceholder()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)
        If txtPassword.TextLength > 0 Then
            lblPass.Visible = False
        Else
            UpdatePasswordPlaceholder()
        End If
    End Sub

    Private Sub UpdateUsernamePlaceholder()
        lblUser.Visible = String.IsNullOrEmpty(txtUsername.Text)
    End Sub

    Private Sub UpdatePasswordPlaceholder()
        lblPass.Visible = String.IsNullOrEmpty(txtPassword.Text)
    End Sub
End Class