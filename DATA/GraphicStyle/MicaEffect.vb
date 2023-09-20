Imports System.Runtime.InteropServices

Public Class MicaEffect
    Public Class ParameterTypes
        <Flags>
        Public Enum DWMWINDOWATTRIBUTE
            DWMWA_USE_IMMERSIVE_DARK_MODE = 20
            DWMWA_SYSTEMBACKDROP_TYPE = 38
        End Enum

        <StructLayout(LayoutKind.Sequential)>
        Public Structure MARGINS
            Public cxLeftWidth As Integer
            Public cxRightWidth As Integer
            Public cyTopHeight As Integer
            Public cyBottomHeight As Integer
        End Structure
    End Class

    Public Class Methods
        <DllImport("DwmApi.dll")>
        Public Shared Function DwmExtendFrameIntoClientArea(ByVal hwnd As IntPtr, ByRef pMarInset As ParameterTypes.MARGINS) As Integer
        End Function

        <DllImport("dwmapi.dll")>
        Public Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal dwAttribute As ParameterTypes.DWMWINDOWATTRIBUTE, ByRef pvAttribute As Integer, ByVal cbAttribute As Integer) As Integer
        End Function

        Public Shared Function ExtendFrame(ByVal hwnd As IntPtr, ByVal margins As ParameterTypes.MARGINS) As Integer
            Return DwmExtendFrameIntoClientArea(hwnd, margins)
        End Function

        Public Shared Function SetWindowAttribute(ByVal hwnd As IntPtr, ByVal attribute As ParameterTypes.DWMWINDOWATTRIBUTE, ByVal parameter As Integer) As Integer
            Return DwmSetWindowAttribute(hwnd, attribute, parameter, Marshal.SizeOf(Of Integer)())
        End Function
    End Class
End Class
