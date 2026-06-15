Imports System.Drawing
Imports System.Windows.Forms

Public Class UIFactory

    '==========================
    ' COLORS
    '==========================

    Public Shared ReadOnly BackgroundColor As Color =
        Color.FromArgb(244, 242, 252)

    Public Shared ReadOnly CardColor As Color =
        Color.White

    Public Shared ReadOnly PrimaryColor As Color =
        Color.FromArgb(108, 92, 231)

    Public Shared ReadOnly SecondaryText As Color =
        Color.FromArgb(120, 120, 150)

    Public Shared ReadOnly DarkText As Color =
        Color.FromArgb(45, 45, 45)

    Public Shared ReadOnly BorderColor As Color =
        Color.FromArgb(225, 225, 235)

    '==========================
    ' TITLE LABEL
    '==========================

    Public Shared Function CreateTitle(
        text As String,
        x As Integer,
        y As Integer
    ) As Label

        Dim lbl As New Label

        lbl.AutoSize = True
        lbl.Text = text
        lbl.Location = New Point(x, y)
        lbl.Font = New Font("Poppins", 18, FontStyle.Bold)
        lbl.ForeColor = DarkText

        Return lbl

    End Function

    '==========================
    ' NORMAL LABEL
    '==========================

    Public Shared Function CreateLabel(
        text As String,
        x As Integer,
        y As Integer,
        Optional size As Integer = 10,
        Optional bold As Boolean = False
    ) As Label

        Dim lbl As New Label

        lbl.AutoSize = True
        lbl.Text = text
        lbl.Location = New Point(x, y)

        If bold Then
            lbl.Font = New Font("Poppins", size, FontStyle.Bold)
        Else
            lbl.Font = New Font("Poppins", size, FontStyle.Regular)
        End If

        lbl.ForeColor = DarkText

        Return lbl

    End Function

    '==========================
    ' SUBTITLE
    '==========================

    Public Shared Function CreateSubtitle(
        text As String,
        x As Integer,
        y As Integer
    ) As Label

        Dim lbl As New Label

        lbl.AutoSize = True
        lbl.Text = text
        lbl.Location = New Point(x, y)
        lbl.Font = New Font("Poppins", 10)
        lbl.ForeColor = SecondaryText

        Return lbl

    End Function

    '==========================
    ' TEXTBOX
    '==========================

    Public Shared Function CreateTextBox(
        x As Integer,
        y As Integer,
        width As Integer,
        Optional placeholder As String = ""
    ) As TextBox

        Dim txt As New TextBox

        txt.Location = New Point(x, y)
        txt.Size = New Size(width, 35)

        txt.Font = New Font("Poppins", 10)

        txt.PlaceholderText = placeholder

        Return txt

    End Function

    '==========================
    ' COMBOBOX
    '==========================

    Public Shared Function CreateComboBox(
        x As Integer,
        y As Integer,
        width As Integer
    ) As ComboBox

        Dim cbo As New ComboBox

        cbo.Location = New Point(x, y)
        cbo.Size = New Size(width, 35)

        cbo.Font = New Font("Poppins", 10)

        cbo.DropDownStyle = ComboBoxStyle.DropDownList

        Return cbo

    End Function

    '==========================
    ' BUTTON
    '==========================

    Public Shared Function CreateButton(
        text As String,
        x As Integer,
        y As Integer,
        width As Integer,
        Optional backColor As Color = Nothing
    ) As Button

        Dim btn As New Button

        btn.Text = text

        btn.Location = New Point(x, y)

        btn.Size = New Size(width, 42)

        btn.FlatStyle = FlatStyle.Flat

        btn.FlatAppearance.BorderSize = 0

        btn.Font = New Font("Poppins", 10, FontStyle.Bold)

        If backColor = Nothing Then
            btn.BackColor = PrimaryColor
        Else
            btn.BackColor = backColor
        End If

        btn.ForeColor = Color.White

        btn.Cursor = Cursors.Hand

        Return btn

    End Function

    '==========================
    ' PICTUREBOX
    '==========================

    Public Shared Function CreatePictureBox(
        x As Integer,
        y As Integer,
        width As Integer,
        height As Integer
    ) As PictureBox

        Dim pic As New PictureBox

        pic.Location = New Point(x, y)

        pic.Size = New Size(width, height)

        pic.SizeMode = PictureBoxSizeMode.Zoom

        pic.BackColor = Color.Transparent

        Return pic

    End Function

    '==========================
    ' PANEL
    '==========================

    Public Shared Function CreatePanel(
        x As Integer,
        y As Integer,
        width As Integer,
        height As Integer,
        Optional color As Color = Nothing
    ) As Panel

        Dim pnl As New Panel

        pnl.Location = New Point(x, y)

        pnl.Size = New Size(width, height)

        If color = Nothing Then
            pnl.BackColor = CardColor
        Else
            pnl.BackColor = color
        End If

        Return pnl

    End Function

    '==========================
    ' HORIZONTAL LINE
    '==========================

    Public Shared Function CreateDivider(
        x As Integer,
        y As Integer,
        width As Integer
    ) As Panel

        Dim pnl As New Panel

        pnl.Location = New Point(x, y)

        pnl.Size = New Size(width, 1)

        pnl.BackColor = BorderColor

        Return pnl

    End Function

End Class