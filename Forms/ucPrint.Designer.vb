<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPrint
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
        pnlContentPrint = New Panel()
        SuspendLayout()
        ' 
        ' pnlContentPrint
        ' 
        pnlContentPrint.Dock = DockStyle.Fill
        pnlContentPrint.Location = New Point(0, 0)
        pnlContentPrint.Name = "pnlContentPrint"
        pnlContentPrint.Size = New Size(1396, 788)
        pnlContentPrint.TabIndex = 0
        ' 
        ' ucPrint
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        Controls.Add(pnlContentPrint)
        Name = "ucPrint"
        Size = New Size(1396, 788)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContentPrint As Panel

End Class
