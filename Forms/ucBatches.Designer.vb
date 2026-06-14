<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBatches
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
        pnlContentBatches = New Panel()
        SuspendLayout()
        ' 
        ' pnlContentBatches
        ' 
        pnlContentBatches.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        pnlContentBatches.Dock = DockStyle.Fill
        pnlContentBatches.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlContentBatches.Location = New Point(0, 0)
        pnlContentBatches.Name = "pnlContentBatches"
        pnlContentBatches.Size = New Size(1396, 786)
        pnlContentBatches.TabIndex = 0
        ' 
        ' ucBatches
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(pnlContentBatches)
        Name = "ucBatches"
        Size = New Size(1396, 786)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContentBatches As Panel

End Class
