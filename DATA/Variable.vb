Imports Newspoint_Software_Win_Costumize_2._0.Setup
Imports Newspoint_Software_Win_Costumize_2._0.Form1
Public Class Variable
    Dim VenditoreR As My.SistemaKey
    Dim SistemaKey As My.SistemaKey
    'Language Setting 
    Public Shared UI_Language As String = My.SistemaKey.Default.Language
    'UI Setting statment
    Public Shared UI_COLLOR As String = My.SistemaKey.Default.ColorProfile
    Public Shared UI_PROFILE As String = My.SistemaKey.Default.UserProfile
    'Dichiaro variabbili per ambiente controlli
    Public Shared Scelta As RadioButton
    Public Shared SceltaCombo As ComboBox
    Public Shared registryKeyBox As TextBox
    'personalizzo la dichiarazione vero o falso + altri valori nominali
    Public Shared ResolutionYes As Boolean = DialogResult.Yes
    Public Shared ResolutionNo As Boolean = DialogResult.No
    Public Shared V As Boolean = True
    Public Shared F As Boolean = False
    Public Shared Threesec As Integer = 3000
    Public Shared onesec As Integer = 1000
    Public Shared twusec As Integer = 2000
    Public Shared one As Integer = 100
    Public Shared twu As Integer = 200
    Public Shared three As Integer = 300
    Public Shared aCapo As String = vbCrLf
    Public Shared SiNo As String = vbYesNo
    Public Shared risultatoOK As String = MsgBoxResult.Ok
    Public Shared risultatoNO As String = MsgBoxResult.No
    Public Shared stileSiNo As String = MsgBoxStyle.YesNo
    Public Shared stileinformation As String = MsgBoxStyle.Information
    'ricerca Stato File di Sistema
    Public Shared KeyServiceFileByLicense As String = Application.StartupPath + "\LicenseKey.inf"
    Public Shared StatoAltriSettaggi As String = My.Computer.FileSystem.FileExists(Application.StartupPath = "\RegistrationCompanyPC\VenditoreR.setting")
    'Public Shared statoDirAltriSettaggi As String = My.Computer.FileSystem.FileExists(VenditoreR.Default.DirectorySettings.ToString)
    ' Public Shared TROVA_FILE As Object = My.Computer.FileSystem.FileExists((StatoAltriSettaggi) Or (statoDirAltriSettaggi))
    'dichiarazione stati 
    'Public Shared WPhase As String = (My.Settings.WizardPhase.ToString)
    'Public Shared Phase As String = (My.Settings.WizardPhase = "0")
    'Public Shared Phase1 As String = (My.Settings.WizardPhase = "1")
    'Public Shared Phase2 As String = (My.Settings.WizardPhase = "2")
    'Public Shared Phase3 As String = (My.Settings.WizardPhase = "3")
    'Public Shared Phase4 As String = (My.Settings.WizardPhase = "4")
    'dichiarazione variabili ambiente winzard
    Public CONTA_CARATTERI As Boolean = (Text.Length.ToString)
    Public Shared SYS_DIR As String = Environment.SystemDirectory
    Public Shared SYS_NAME As String = Environment.MachineName
    Public Shared SYS_HOST As String = Environment.UserDomainName
    Public Shared SYS_OS = Environment.OSVersion
    Public Shared TOTAL_PHYSICAL_MEMORY = My.Computer.Info.TotalPhysicalMemory
    Public Shared SYS_HEIGHT = My.Computer.Screen.Bounds.Height
    Public Shared SYS_WIDTH = My.Computer.Screen.Bounds.Width
    Public Shared SYS_RESOLUTION As String = $"Risoluzione schermo: {SYS_HEIGHT} x {SYS_WIDTH}"
    Public Shared userName = My.User.Name
    '--------sola lettura 
    Public Shared WORD_GRA As String = FontStyle.Bold
    Public Shared WORD_NOR As String = FontStyle.Regular
    Public ReadOnly Wsieze_ As String = Font.Size.ToString
    Public ReadOnly Sieze12_ As String = (Font.Size = 12)
    Public ReadOnly Sieze9_ As String = (Font.Size = 9)
    Public ReadOnly Sieze10_ As String = (Font.Size = 10)
    Public ReadOnly Sieze14_ As String = (Font.Size = 14)
    Public ReadOnly Sieze16_ As String = (Font.Size = 16)
    Public ReadOnly Sieze18_ As String = (Font.Size = 18)
    Public ReadOnly Sieze20_ As String = (Font.Size = 20)
    Public ReadOnly Sieze22_ As String = (Font.Size = 22)
    Public ReadOnly Sieze24_ As String = (Font.Size = 24)
    '--------valori pubblici
    'Public Shared KeyLocal As String = HomeF.key.Text
    Public Shared WGra As Object = FontStyle.Bold
    Public Shared WNor As Object = FontStyle.Regular
    Public Shared WUnder As Boolean = FontStyle.Underline
    Public ReadOnly Wsieze As String = Font.Size.ToString
    Public ReadOnly Sieze12 As String = (Font.Size = 12)
    Public ReadOnly Sieze9 As String = (Font.Size = 9)
    Public ReadOnly Sieze10 As String = (Font.Size = 10)
    Public ReadOnly Sieze14 As String = (Font.Size = 14)
    Public ReadOnly Sieze16 As String = (Font.Size = 16)
    Public ReadOnly Sieze18 As String = (Font.Size = 18)
    Public ReadOnly Sieze20 As String = (Font.Size = 20)
    Public ReadOnly Sieze22 As String = (Font.Size = 22)
    Public ReadOnly Sieze24 As String = (Font.Size = 24)
    '---------------Registry Key Ready and Write declaration------------
    'Public Shared LicenseKey As String = My.Settings.LicenseKey.ToString
    Public Shared ValoreChiave As String = ""
    '-------------------------
    'variable generic
    Public Shared SFNAME As String = My.SistemaKey.Default.SFNAME
    Public Shared LoadContinuePro As Object = ProgressBarStyle.Marquee
    Public Shared LoadStatment As Object = ProgressBarStyle.Continuous
    Public Shared LoadBlock As Object = ProgressBarStyle.Blocks
    'nextword variable 
    Public Shared FONTSIZE = 8
    Public Shared Lstate As String = "0"
    Public Shared Rstate As String = "0"
    Public Shared Cstate As String = "0"
    Public Shared CALLstate As String = "0"
    Public Shared hisotryAlni As String = ""
    Public Shared lstateLabel As String = ""
    'end generic variable
    Public Shared Sub SaveChange()
        My.SistemaKey.Default.Save()
    End Sub
End Class