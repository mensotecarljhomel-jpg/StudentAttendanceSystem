Imports System.Drawing.Drawing2D

Public Class RoundedPanel2
    Inherits Panel

    Public Sub New()
        Me.DoubleBuffered = True
        Me.ResizeRedraw = True
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)

        Dim path As New GraphicsPath()
        Dim radius As Integer = 15
        Dim d As Integer = radius * 2

        path.StartFigure()
        path.AddArc(0, 0, d, d, 180, 90)
        path.AddArc(Me.Width - d, 0, d, d, 270, 90)
        path.AddArc(Me.Width - d, Me.Height - d, d, d, 0, 90)
        path.AddArc(0, Me.Height - d, d, d, 90, 90)
        path.CloseFigure()

        Me.Region = New Region(path)
    End Sub
End Class