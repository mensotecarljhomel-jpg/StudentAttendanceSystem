<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddStudent))
        piclogo = New PictureBox()
        CType(piclogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' piclogo
        ' 
        piclogo.Image = CType(resources.GetObject("piclogo.Image"), Image)
        piclogo.Location = New Point(102, -1)
        piclogo.Name = "piclogo"
        piclogo.Size = New Size(280, 90)
        piclogo.SizeMode = PictureBoxSizeMode.Zoom
        piclogo.TabIndex = 0
        piclogo.TabStop = False
        ' 
        ' frmAddStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(242), CByte(252))
        ClientSize = New Size(484, 521)
        Controls.Add(piclogo)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAddStudent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Student"
        CType(piclogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents piclogo As PictureBox
End Class
