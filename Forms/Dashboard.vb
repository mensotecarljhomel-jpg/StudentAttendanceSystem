Public Class Dashboard

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click

        Try

            OpenConnection()

            MessageBox.Show(
                "Database Connected Successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            CloseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class