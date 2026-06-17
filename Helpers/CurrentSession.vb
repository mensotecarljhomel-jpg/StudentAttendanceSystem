Module CurrentSession

    Public Property Username As String
    Public Property Role As String

    Public Sub SignIn(user As String, roleName As String)
        Username = user
        Role = roleName
    End Sub

    Public Sub SignOut()
        Username = Nothing
        Role = Nothing
    End Sub

    Public ReadOnly Property IsSignedIn As Boolean
        Get
            Return Not String.IsNullOrEmpty(Username)
        End Get
    End Property

End Module
