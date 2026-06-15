Imports MySql.Data.MySqlClient

Module Database

    Public Connection As New MySqlConnection(
        "server=localhost;" &
        "database=proj_db;" &
        "uid=root;" &
        "password=;"
    )

    Public Sub OpenConnection()

        Try

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

        Catch ex As Exception

            MessageBox.Show(
                "Database Connection Error: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Public Sub CloseConnection()

        If Connection.State = ConnectionState.Open Then
            Connection.Close()
        End If

    End Sub

End Module