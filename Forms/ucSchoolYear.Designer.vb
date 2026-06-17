<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSchoolYear
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
        pnlContentAbsences = New Panel()
        SuspendLayout()
        ' 
        ' pnlContentAbsences
        ' 
        pnlContentAbsences.Dock = DockStyle.Fill
        pnlContentAbsences.Location = New Point(0, 0)
        pnlContentAbsences.Name = "pnlContentAbsences"
        pnlContentAbsences.Size = New Size(1396, 788)
        pnlContentAbsences.TabIndex = 0
        ' 
        ' ucAbsences
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        Controls.Add(pnlContentAbsences)
        Name = "ucAbsences"
        Size = New Size(1396, 788)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContentAbsences As Panel

End Class
