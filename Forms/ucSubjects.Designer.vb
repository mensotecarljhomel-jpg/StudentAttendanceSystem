<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSubjects
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlContentSubjects = New Panel()
        RoundedPanel1 = New RoundedPanel()
        RoundedPanel2 = New RoundedPanel()
        pnlContentSubjects.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlContentSubjects
        ' 
        pnlContentSubjects.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        pnlContentSubjects.Controls.Add(RoundedPanel1)
        pnlContentSubjects.Controls.Add(RoundedPanel2)
        pnlContentSubjects.Dock = DockStyle.Fill
        pnlContentSubjects.Location = New Point(0, 0)
        pnlContentSubjects.Name = "pnlContentSubjects"
        pnlContentSubjects.Size = New Size(1396, 788)
        pnlContentSubjects.TabIndex = 0
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Location = New Point(35, 85)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1323, 615)
        RoundedPanel1.TabIndex = 5
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        RoundedPanel2.Location = New Point(42, 85)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(1320, 618)
        RoundedPanel2.TabIndex = 6
        ' 
        ' ucSubjects
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(pnlContentSubjects)
        Name = "ucSubjects"
        Size = New Size(1396, 788)
        pnlContentSubjects.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContentSubjects As Panel
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel

End Class
