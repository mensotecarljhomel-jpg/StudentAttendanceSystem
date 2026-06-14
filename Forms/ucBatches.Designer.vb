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
        RoundedPanel1 = New RoundedPanel()
        RoundedPanel2 = New RoundedPanel()
        pnlContentBatches.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlContentBatches
        ' 
        pnlContentBatches.BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        pnlContentBatches.Controls.Add(RoundedPanel1)
        pnlContentBatches.Controls.Add(RoundedPanel2)
        pnlContentBatches.Dock = DockStyle.Fill
        pnlContentBatches.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlContentBatches.Location = New Point(0, 0)
        pnlContentBatches.Name = "pnlContentBatches"
        pnlContentBatches.Size = New Size(1396, 786)
        pnlContentBatches.TabIndex = 0
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Location = New Point(35, 84)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(1323, 615)
        RoundedPanel1.TabIndex = 5
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        RoundedPanel2.Location = New Point(42, 84)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(1320, 618)
        RoundedPanel2.TabIndex = 6
        ' 
        ' ucBatches
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(pnlContentBatches)
        Name = "ucBatches"
        Size = New Size(1396, 786)
        pnlContentBatches.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContentBatches As Panel
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel

End Class
