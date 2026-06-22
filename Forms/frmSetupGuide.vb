Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class frmSetupGuide
    Inherits Form

    Private lblTitle As Label
    Private pnlBody As Panel
    Private btnClose As Button

    Public Sub New()
        Me.InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Text = "System Setup Guide"
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.ClientSize = New Size(600, 420)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ShowInTaskbar = False

        lblTitle = New Label()
        lblTitle.Text = "System Setup Guide"
        lblTitle.Font = New Font("Poppins", 14, FontStyle.Bold)
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(18, 14)
        Me.Controls.Add(lblTitle)

        pnlBody = New Panel()
        pnlBody.Location = New Point(12, 52)
        pnlBody.Size = New Size(Me.ClientSize.Width - 24, Me.ClientSize.Height - 110)
        pnlBody.AutoScroll = False
        pnlBody.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlBody.BackColor = Color.White
        Me.Controls.Add(pnlBody)

        btnClose = New Button()
        btnClose.Text = "Close"
        btnClose.Size = New Size(90, 30)
        btnClose.Location = New Point(Me.ClientSize.Width - 12 - btnClose.Width, Me.ClientSize.Height - 44)
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        AddHandler btnClose.Click, AddressOf btnClose_Click
        Me.Controls.Add(btnClose)

        ' Load content
        AddHandler Me.Load, AddressOf frmSetupGuide_Load
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmSetupGuide_Load(sender As Object, e As EventArgs)
        PopulateGuide()
    End Sub

    Private Sub PopulateGuide()
        pnlBody.Controls.Clear()

        ' Static content with descriptions per user request
        Dim sections = New List(Of (String, String)) From {
            ("✓ School Year", "Define the active school year and semester for attendance records."),
            ("✓ Batches", "Organize students into sections or class groups."),
            ("✓ Subjects", "Manage the subjects that will be included in attendance monitoring."),
            ("✓ Students", "Maintain student information and section assignments.")
        }

        Dim y As Integer = 6
        For Each s In sections
            Dim title As New Label()
            title.Font = New Font("Poppins", 10, FontStyle.Bold)
            title.ForeColor = Color.FromArgb(34, 197, 94)
            title.Text = s.Item1
            title.Location = New Point(12, y)
            title.AutoSize = True
            pnlBody.Controls.Add(title)
            y += title.Height + 4

            Dim desc As New Label()
            desc.Font = New Font("Poppins", 9)
            desc.ForeColor = Color.FromArgb(107, 114, 128)
            desc.Text = s.Item2
            desc.Location = New Point(14, y)
            desc.AutoSize = True
            ' allow wrapping: set maximum width to panel width minus margins
            desc.MaximumSize = New Size(pnlBody.Width - 28, 0)
            pnlBody.Controls.Add(desc)
            y += desc.Height + 14
        Next
    End Sub
End Class
