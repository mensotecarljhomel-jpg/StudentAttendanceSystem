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

    Public Sub EnsureAttendanceTablesExist()

        Try

            OpenConnection()

            Dim createSessions As String =
                "CREATE TABLE IF NOT EXISTS attendance_sessions (" &
                "session_id INT AUTO_INCREMENT PRIMARY KEY, " &
                "subject_id INT NOT NULL, " &
                "batch_id INT NOT NULL, " &
                "schoolyear_id INT NOT NULL, " &
                "session_date DATE NOT NULL, " &
                "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, " &
                "created_by VARCHAR(100), " &
                "FOREIGN KEY (subject_id) REFERENCES subjects(subject_id) ON DELETE CASCADE, " &
                "FOREIGN KEY (batch_id) REFERENCES batches(batch_id) ON DELETE CASCADE, " &
                "FOREIGN KEY (schoolyear_id) REFERENCES school_years(schoolyear_id) ON DELETE CASCADE" &
                ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;"

            Dim createRecords As String =
                "CREATE TABLE IF NOT EXISTS attendance_records (" &
                "record_id INT AUTO_INCREMENT PRIMARY KEY, " &
                "session_id INT NOT NULL, " &
                "student_number VARCHAR(50) NOT NULL, " &
                "status ENUM('Present','Absent','Excused') NOT NULL DEFAULT 'Present', " &
                "remarks TEXT, " &
                "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, " &
                "FOREIGN KEY (session_id) REFERENCES attendance_sessions(session_id) ON DELETE CASCADE, " &
                "FOREIGN KEY (student_number) REFERENCES students(student_number) ON DELETE CASCADE" &
                ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;"

            Using cmd As New MySql.Data.MySqlClient.MySqlCommand(createSessions, Connection)
                cmd.ExecuteNonQuery()
            End Using

            Using cmd As New MySql.Data.MySqlClient.MySqlCommand(createRecords, Connection)
                cmd.ExecuteNonQuery()
            End Using

            CloseConnection()

        Catch ex As Exception

            CloseConnection()

            MessageBox.Show("Failed to ensure attendance tables: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Sub CloseConnection()

        If Connection.State = ConnectionState.Open Then
            Connection.Close()
        End If

    End Sub

End Module