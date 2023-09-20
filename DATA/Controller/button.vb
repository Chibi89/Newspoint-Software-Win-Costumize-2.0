Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class BuroundedButton
    Inherits Button
    <DllImport("gdi32.dll", EntryPoint:="CreatePolygonRgn")>
    Private Shared Function CreatePolygonRgn(ByVal lpPoint As Point(), ByVal nCount As Integer, ByVal nPolyFillMode As Integer) As IntPtr
    End Function

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Dim points As Point() = {New Point(0, 15), New Point(15, 0), New Point(Me.Width - 15, 0), New Point(Me.Width, 15),
                                 New Point(Me.Width, Me.Height - 15), New Point(Me.Width - 15, Me.Height),
                                 New Point(15, Me.Height), New Point(0, Me.Height - 15)}

        Me.Region = System.Drawing.Region.FromHrgn(CreatePolygonRgn(points, points.Length, 1))
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Dim points As Point() = {New Point(0, 15), New Point(15, 0), New Point(Me.Width - 15, 0), New Point(Me.Width, 15),
                                 New Point(Me.Width, Me.Height - 15), New Point(Me.Width - 15, Me.Height),
                                 New Point(15, Me.Height), New Point(0, Me.Height - 15)}
        Me.Region = System.Drawing.Region.FromHrgn(CreatePolygonRgn(points, points.Length, 1))
    End Sub
End Class