Imports System.Net
Imports Newspoint_Software_Win_Costumize_2._0.MicaEffect.Methods
Imports Newspoint_Software_Win_Costumize_2._0.MicaEffect.ParameterTypes
Imports Newspoint_Software_Win_Costumize_2._0.Variable

Public Class USR_REG_MDL
    Private Sub USR_REG_MDL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = SFNAME
        Dim bounds As MARGINS = New MARGINS
        Dim hwnd As IntPtr = Handle
        With bounds
            .cxLeftWidth = 0
            .cxRightWidth = 0
            .cyTopHeight = Screen.PrimaryScreen.Bounds.Height - 60
            .cyBottomHeight = 0
        End With
        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, bounds)
        Me.BackColor = Color.Black
        Dim Panel As New Panel
        With Panel
            .Size = New Size(Me.Width, Me.Height - 60)
            .Location = New Point(0, 0)
            .Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Bottom
            .BackColor = Color.FromKnownColor(KnownColor.Control)
        End With
        'SetWindowAttribute(Me.Handle, DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, 1)
        'SetWindowAttribute(Me.Handle, DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, 2)
        SetWindowAttribute(Me.Handle, DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, 3)
        SetWindowAttribute(Me.Handle, DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, 1)
        'SetWindowAttribute(Me.Handle, DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, 4)
        'Panel.Dock = DockStyle.Fill
        ' Me.Controls.Add(Panel)
    End Sub
End Class