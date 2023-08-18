Imports NewSoft.Framework.MicaLibrary.MicaEffectMethods
Imports NewSoft.Framework.MicaLibrary.ParameterTypes
Imports NewSoft.Framework.MicaLibrary
Public Class test
    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewSoft.Framework.MicaLibrary.LoadMicaSet.ApplyEffectAllForm(Form1, Color.White, 1, 3)
    End Sub
End Class