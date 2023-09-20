Imports System.Windows.Forms

Public Class ToggleButton
    Inherits Button

    Private _isChecked As Boolean = False

    Public Property IsChecked() As Boolean
        Get
            Return _isChecked
        End Get
        Set(ByVal value As Boolean)
            _isChecked = value
            UpdateAppearance()
        End Set
    End Property

    Public Sub New()
        ' Imposta l'aspetto iniziale
        UpdateAppearance()
        AddHandler Me.Click, AddressOf ToggleButtonClick
    End Sub

    Private Sub UpdateAppearance()
        If _isChecked Then
            Me.BackColor = Color.Green
            Me.Text = "ON"
        Else
            Me.BackColor = Color.Red
            Me.Text = "OFF"
        End If
    End Sub

    Private Sub ToggleButtonClick(sender As Object, e As EventArgs)
        _isChecked = Not _isChecked
        UpdateAppearance()
    End Sub
End Class