Imports Microsoft.VisualBasic.Devices
Imports System.Net
Imports System.Diagnostics
Imports System.Environment
Imports System.Security.Principal
Imports Microsoft.Win32
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports NewSoft.Framework.MicaLibrary.MicaEffectMethods
Imports NewSoft.Framework.MicaLibrary.ParameterTypes
Imports NewSoft.Framework.MicaLibrary
Imports System.Reflection
Imports System.Threading
Imports System.Windows.Forms.AxHost
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
#Region "LoadSetting and Variable"
    Public principal As WindowsPrincipal = New WindowsPrincipal(WindowsIdentity.GetCurrent())
    Public updateOpen As String = Application.StartupPath & "Newspoint Software - WinPersonalize.exe"
    Public updateProcess() As Process = Process.GetProcessesByName("Newspoint Software - WinPersonalize")
    Public AEStyle As String = My.SistemaKey.Default.AdvanceExplorerStyle
    Public BEI As String = My.SistemaKey.Default.BackgroundExplorerImage
    Public SFV As String = My.SistemaKey.Default.SoftVersion
    Public SFNAME As String = My.SistemaKey.Default.SFNAME
    Private HostFileVer As String = "http://newspointsoftwar.altervista.org/software_home/Lserver/Win_Costumize/CheckVersion/Ver.txt"
    Private FileVer As String = SFV
    Private opacity1 As Double = 0
    Private opacity2 As Double = 0
    Private opacity3 As Double = 0
    Public Sub CheckUpdaterOpen()
        Try
            If updateProcess.Length < 1 Then
                Process.Start(Application.StartupPath & "updater.exe")
            ElseIf updateProcess.Length > 0 Then
                MessageBox.Show("Updater già in esecuzione", "Newspoint Software - Updater V0.1", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Newspoint Software - Updater V0.1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally

        End Try
    End Sub
    Public Sub CheckUpdate()
        Dim webclient As New WebClient()
        Dim hostver As String = webclient.DownloadString(HostFileVer)
        UpdateLabel.Text = "Stato: controllo il server"
        If FileVer <> hostver Then
            UpdateLabel.Text = $"Stato: Nuova Versione. {FileVer} ===> {hostver}"
            CheckUpdaterOpen()
        ElseIf FileVer = hostver Then
            UpdateLabel.Text = $"Stato: Nessun nuovo aggiornamento"
        End If
    End Sub
    Private Function GetValueFromConfigLine(configLine As String) As String
        ' Ottieni il valore dalla riga del file config.ini (es. "effect=1" -> "1")
        Return configLine.Split("="c)(1)
    End Function
    Private Function IsRunAsAdmin() As Boolean
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function
    Private Function ReadRegistryValue(keyPath As String, valueName As String) As String
        Dim value As String = ""
        Try
            Using key As RegistryKey = Registry.LocalMachine.OpenSubKey(keyPath)
                If key IsNot Nothing Then
                    value = key.GetValue(valueName, "").ToString()
                End If
            End Using
        Catch ex As Exception
            value = ""
        End Try
        Return value
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PHome.Dock = DockStyle.Fill
#Region "mica load Set"
        Try
#Region "MicaEffect"
            LoadMicaSet.ApplyEffectAllForm(Me, Color.Maroon, 0, 3)
#End Region
#Region "Label and state"
            Panel1Timer.Start()
            Panel2Timer.Start()
            Panel3Timer.Start()
            'CheckUpdate()
            If (AEStyle = "true") Then
                LState.Text = "Stato: Effetto attivato"
                LState.ForeColor = Color.DarkGreen
            ElseIf (AEStyle = False) Then
                LState.Text = "Stato: Effetto disattivato"
                LState.ForeColor = Color.DarkRed
            End If
            If (BEI = "true") Then
                LBRGSTATE.Text = "Stato: Effetto attivato"
                LBRGSTATE.ForeColor = Color.DarkGreen
            ElseIf (BEI = "false") Then
                LBRGSTATE.Text = "Stato: Effetto disattivato"
                LBRGSTATE.ForeColor = Color.DarkRed
            End If
            LoadProfileImage()
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Image = Image.FromFile(Application.StartupPath + "\DATA\AWES\BRG\Image\image.png")
#End Region
#Region "Run Admin"
            If IsRunAsAdmin() Then
                ' Inserisci qui il codice dell'applicazione se viene avviata come amministratore
            Else
                MessageBox.Show("L'applicazione deve essere eseguita come amministratore." + vbCrLf +
                    "Verrà riavviata con i privilegi amministrativi.")

                ' Ottieni il percorso dell'eseguibile dell'applicazione corrente
                Dim exePath As String = Application.ExecutablePath

                ' Avvia un nuovo processo dell'applicazione come amministratore
                Dim startInfo As New ProcessStartInfo()
                startInfo.FileName = exePath
                startInfo.Verb = "runas" ' Imposta il verbo su "runas" per eseguire come amministratore
                Try
                    Process.Start(startInfo)
                Catch ex As Exception
                    ' Gestisci eventuali errori durante il riavvio come amministratore
                    MessageBox.Show("Errore durante il riavvio come amministratore: " & ex.Message)
                End Try
            End If
#End Region
#Region "other Setting Style fir winform"
            'If UI_COLLOR = "Dark" Then : SetWindowAttribute(Me.Handle, DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, 1)
            'ElseIf UI_COLLOR = "White" Then : SetWindowAttribute(Me.Handle, DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, 0)
            'End If
            'If UI_PROFILE = "Mica" Then : SetWindowAttribute(Me.Handle, DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, 3)
            'ElseIf UI_PROFILE = "Fluent" Then : SetWindowAttribute(Me.Handle, DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, 2)
            'ElseIf UI_PROFILE = "Flat" Then : SetWindowAttribute(Me.Handle, DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, 4)
            'ElseIf UI_PROFILE = "Dark" Then : SetWindowAttribute(Me.Handle, DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, 1)
            'End If
            'Panel.Dock = DockStyle.Fill
            ' Me.Controls.Add(Panel)
#End Region
        Catch ex As Exception
            MessageBox.Show("Errore nel caricamento delle librerie - " & ex.Message & DialogResult.Yes)
        End Try
#End Region
#Region "set Variable Info"
        Try
#Region "Info Var"
            Dim configFile As String = Application.StartupPath & "\DATA\AWES\ExploStyle\config.ini"
            Dim processorName As String = GetProcessorName()
            Dim graphicsCardName As String = GetGraphicsCardName()
            Dim totalRAM As Double = GetTotalRAM()
            Dim usedRAM As Double = GetUsedRAM()
            Dim hardDiskInfo As String = GetHardDiskInfo()
            Dim rootKey As RegistryHive = RegistryHive.LocalMachine
            Dim subKeyPath As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion"
            Dim subKeyHWPach As String = "HARDWARE\DESCRIPTION\System\CentralProcessor\0"
            Dim subkeyBiosPach As String = "HARDWARE\DESCRIPTION\System\BIOS"
            Dim displayVer As String = ReadRegistryValue(rootKey, subKeyPath, "DisplayVersion")
            Dim editionID As String = ReadRegistryValue(rootKey, subKeyPath, "EditionID")
            Dim BuildBranch As String = ReadRegistryValue(rootKey, subKeyPath, "BuildBranch")
            Dim currentBuild As String = ReadRegistryValue(rootKey, subKeyPath, "CurrentBuild")
            Dim registeredOwner As String = ReadRegistryValue(rootKey, subKeyPath, "RegisteredOwner")
            Dim subBuild As String = ReadRegistryValue(subKeyPath, "UBR")
            Dim connectedAccountName As String = GetConnectedWindowsAccountName()
            Dim osArchitecture As Architecture = RuntimeInformation.OSArchitecture
            Dim cpuArchitecture As String = ""
#End Region
#Region "OS ARCH Info"
            ' Imposta l'opacità desiderata (50%)
            Dim opacity As Single = 0.5F
            Select Case osArchitecture
                Case Architecture.X86
                    cpuArchitecture = "32 bit"
                Case Architecture.X64
                    cpuArchitecture = "64 bit"
                Case Architecture.Arm
                    cpuArchitecture = "ARM"
                Case Architecture.Arm64
                    cpuArchitecture = "ARM64"
                Case Else
                    cpuArchitecture = "Sconosciuta"
            End Select
#End Region
#Region "Load and config.ini"
            Try
                ' Verifica se il file esiste
                If File.Exists(configFile) Then
                    ' Leggi tutte le righe dal file config.ini
                    Dim configLines As String() = File.ReadAllLines(configFile)
                    ' Carica i valori nelle TextBox
                    effectTextBox.Text = GetValueFromConfigLine(configLines(1))
                    smallBorderTextBox.Text = GetValueFromConfigLine(configLines(2))
                    showLineTextBox.Text = GetValueFromConfigLine(configLines(3))
                    darkRibbonTextBox.Text = GetValueFromConfigLine(configLines(4))
                    aTextBox.Text = GetValueFromConfigLine(configLines(9))
                Else
                    MessageBox.Show("File config.ini non trovato.")
                End If
            Catch ex As Exception
                MessageBox.Show("Errore durante il caricamento del file config.ini: " & ex.Message)
            End Try
#End Region
#Region "CPU_BASE Info"
            Using regKey As RegistryKey = Registry.LocalMachine.OpenSubKey(subKeyHWPach)
                If regKey IsNot Nothing Then
                    Dim baseBoardProcessor As String = regKey.GetValue("ProcessorNameString", "").ToString()
                    Dim maxClockSpeed As Integer = CInt(regKey.GetValue("~MHz", 0))
                    Dim maxClockSpeedGHz As Double = maxClockSpeed / 1000.0
                    Cpu.Text = $"CPU: {baseBoardProcessor} ({maxClockSpeedGHz:F2} GHz)"
                Else
                    Cpu.Text = "CPU Sconosciuta"
                End If
            End Using
#End Region
#Region "BiosBase Information"
            Using regKey As RegistryKey = Registry.LocalMachine.OpenSubKey(subkeyBiosPach)
                If regKey IsNot Nothing Then
                    Dim baseBoardManufacturer As String = regKey.GetValue("BaseBoardManufacturer", "").ToString()
                    Dim baseBoardProduct As String = regKey.GetValue("BaseBoardProduct", "").ToString()
                    Dim biosVersion As String = regKey.GetValue("BIOSVersion", "").ToString()
                    Dim biosVendor As String = regKey.GetValue("BIOSVendor", "").ToString()
                    DevMotherboard.Text = $"Dev Motherboard: {baseBoardManufacturer}{vbCrLf}Bios Vendor: {biosVendor}"
                    Mothermodel.Text = $"Model: {baseBoardProduct} - Bios Version: {biosVersion}"
                Else
                End If
            End Using
#End Region
#End Region
#Region "Show Info"
            'DevMotherboard.Text = baseBoardManufacturer
            Nickname.Text = ("Account Windows: " & registeredOwner)
            If (currentBuild > "22000") Then
                Me.Text = $"{SFNAME} - Mode Win11"
                WinVer.Text = $"Edizione: Windows 11 {editionID} - {displayVer} - {cpuArchitecture}"
                WinVer_Short.Text = $"Edizione: Windows 11 {displayVer} - {cpuArchitecture}"
                SetGraphicStyleExplorerMode.Text = $"Activate Advance style for Windows 11"
            ElseIf (currentBuild < "22000" And currentBuild > "19044") Then
                Me.Text = $"{SFNAME} - Mode Win10"
                WinVer.Text = $"Edizione: Windows 10 {editionID} - {displayVer} - {cpuArchitecture}"
                WinVer_Short.Text = $"Edizione: Windows 10 {displayVer} - {cpuArchitecture}"
                SetGraphicStyleExplorerMode.Text = $"Activate Advance style for Windows 10"
            ElseIf (currentBuild < "19044") Then
                Me.Text = $"{SFNAME} - Old Mode Win10 "
                WinVer.Text = $"Edizione: Windows 10 {editionID} - {displayVer} - {cpuArchitecture}"
                WinVer_Short.Text = $"Edizione: Windows 10 {displayVer} - {cpuArchitecture}"
                SetGraphicStyleExplorerMode.Text = $"Activate Advance style for Old Windows 10"
            End If
            WinBuild.Text = $"Build: {currentBuild}.{subBuild} - Ramo: {BuildBranch}"
            '$(MSBuildProjectName)
            If String.IsNullOrEmpty(graphicsCardName) Then
                ' Nessuna scheda video trovata
                Gpu.Text = ("Impossibile recuperare il nome della scheda video.")
            Else
                ' Visualizza il nome della scheda video
                Gpu.Text = $"Scheda video: {graphicsCardName}"
            End If
            Timer1.Start()
            Ram.Text = ("Quantità totale di RAM: " & totalRAM.ToString("0.00") & " GB" & " - in uso: " & usedRAM.ToString("0.00") & " MB")
            CL.Text = (hardDiskInfo)
            UpdateProgressBar()
        Catch ex As Exception
            MessageBox.Show("Errore nel caricamento delle informazioni" & ex.Message & DialogResult.Yes)
        End Try
        If IsAccountAdmin() Then
            AucLevel.Text = ("Tipo: amministratore.")
        Else
            AucLevel.Text = ("Tipo: Normale.")
        End If
    End Sub
#End Region
#Region "GetInfoHW"
    Private Function ReadRegistryValue(rootKey As RegistryHive, subKeyPath As String, valueName As String) As String
        'accedi al valori dei registri
        Using root As RegistryKey = RegistryKey.OpenBaseKey(rootKey, RegistryView.Default)
            Using subKey As RegistryKey = root.OpenSubKey(subKeyPath)
                If subKey IsNot Nothing Then
                    Dim value As Object = subKey.GetValue(valueName)
                    If value IsNot Nothing Then
                        Return value.ToString()
                    End If
                End If
            End Using
        End Using
        Return ""
    End Function
    Private Function GetFileSystemType(driveLetter As String) As String
        'ottieni il filesystem
        Dim drive As DriveInfo = New DriveInfo(driveLetter)
        If drive.IsReady Then
            Return drive.DriveFormat
        Else
            Return ""
        End If
    End Function
    Private Function GetHardDiskModel() As String
        'ottieni il modello del hhd/ssd
        Dim processStartInfo As New ProcessStartInfo()
        processStartInfo.FileName = "wmic"
        processStartInfo.Arguments = "diskdrive get model /format:list"
        processStartInfo.RedirectStandardOutput = True
        processStartInfo.UseShellExecute = False
        processStartInfo.CreateNoWindow = True
        Dim process As Process = Process.Start(processStartInfo)
        Dim output As String = process.StandardOutput.ReadToEnd()
        process.WaitForExit()
        Dim lines As String() = output.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim model As String = ""
        For Each line As String In lines
            If line.StartsWith("Model=") Then
                model = line.Substring(6).Trim()
                Exit For
            End If
        Next
        Return model
    End Function
    Private Sub UpdateProgressBar()
        Dim drive As DriveInfo = New DriveInfo("C")
        Dim totalSize As Double = 0
        Dim freeSpace As Double = 0

        If drive.IsReady Then
            totalSize = drive.TotalSize / (1024 * 1024 * 1024) ' Convert bytes to gigabytes
            freeSpace = drive.AvailableFreeSpace / (1024 * 1024 * 1024) ' Convert bytes to gigabytes

            Dim spaceUsed As Double = totalSize - freeSpace
            Dim spacePercentage As Integer = CInt((spaceUsed / totalSize) * 100)

            ' Imposta il valore della ProgressBar
            Progressbar_C.Value = spacePercentage
            LabelCState.Text = $"{spacePercentage}%"
        End If
    End Sub
    Private Function GetHardDiskInfo() As String
        Dim drive As DriveInfo = New DriveInfo("C")
        Dim driveLetter As String = "C"
        Dim fileSystemType As String = GetFileSystemType(driveLetter)
        Dim model As String = GetHardDiskModel()
        Dim totalSize As Double = 0
        Dim freeSpace As Double = 0
        Dim driveLabel As String = ""
        If drive.IsReady Then
            totalSize = drive.TotalSize / (1024 * 1024 * 1024) ' Convert bytes to gigabytes
            freeSpace = drive.AvailableFreeSpace / (1024 * 1024 * 1024) ' Convert bytes to gigabytes
            driveLabel = drive.VolumeLabel
        End If
        If String.IsNullOrEmpty(driveLabel) Then
            C_Label.Text = $"Disco Locale - {driveLetter}:"
        Else
            C_Label.Text = $"{driveLabel} - {driveLetter}:"
        End If
        C_Space.Text = $"Spazio totale: {totalSize:F2} GB - Spazio libero: {freeSpace:F2} GB"
        Return $"Model Drive C:\ : {model} - FileSystem: {fileSystemType}{vbCrLf} - Spazio totale: {totalSize:F2} GB - Spazio libero: {freeSpace:F2} GB"
    End Function
    Private Function GetTotalRAM() As Double
        Dim computerInfo As New ComputerInfo()
        Dim totalRamInBytes As Long = computerInfo.TotalPhysicalMemory
        Dim totalRamInGB As Double = totalRamInBytes / (1024 * 1024 * 1024)
        Return totalRamInGB
    End Function
    Private Function GetUsedRAM() As Double
        Dim computerInfo As New ComputerInfo()
        Dim usedRamInBytes As Long = computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory
        Dim usedRamInMB As Double = usedRamInBytes / (1024 * 1024)
        Return usedRamInMB
    End Function
    Private Function GetGraphicsCardName() As String
        Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}")
        If registryKey IsNot Nothing Then
            For Each subKeyName As String In registryKey.GetSubKeyNames()
                Dim subKey As RegistryKey = registryKey.OpenSubKey(subKeyName)
                If subKey IsNot Nothing AndAlso subKey.GetValue("DriverDesc") IsNot Nothing Then
                    Dim driverDesc As String = subKey.GetValue("DriverDesc").ToString()
                    subKey.Close()
                    registryKey.Close()
                    Return driverDesc
                End If
                subKey.Close()
            Next
        End If
        If registryKey IsNot Nothing Then
            registryKey.Close()
        End If
        Return ""
    End Function
    Private Function GetWindowsBuildNumber() As String
        Return Environment.GetEnvironmentVariable("OSBuildNumber")
    End Function
    Private Function GetProcessorName() As String
        Return Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")
    End Function
    Private Function GetConnectedWindowsAccountName() As String
        Return Environment.GetEnvironmentVariable("USERNAME")
    End Function
    Private Function IsAccountAdmin() As Boolean
        Dim principal As WindowsPrincipal = New WindowsPrincipal(WindowsIdentity.GetCurrent())
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function
    Private Function GetWindowsEdition() As String
        Dim productName As String = ""

        Using registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")
            If registryKey IsNot Nothing Then
                productName = registryKey.GetValue("ProductName").ToString()
            End If
        End Using

        Return productName
    End Function
#End Region
#End Region
#Region "ExplorerStyle"
    Private Sub ButtonRegistra_Click(sender As Object, e As EventArgs) Handles ButtonRegistra.Click
        ' Ottieni la radice del progetto
        Dim projectRoot As String = Application.StartupPath + "\DATA\AWES\ExploStyle\"
        ' Costruisci il percorso completo della DLL
        Dim dllPath As String = Path.Combine(projectRoot, "ExplorerBlurMica.dll")
        ' Registra la DLL utilizzando regsvr32
        Dim process As New Process()
        process.StartInfo.FileName = "regsvr32"
        process.StartInfo.Arguments = """" & dllPath & """"
        process.Start()
        process.WaitForExit()
        AEStyle = "true"
        My.SistemaKey.Default.Save()

    End Sub
    Private Sub ButtonRimuovi_Click(sender As Object, e As EventArgs) Handles ButtonRimuovi.Click
        ' Ottieni la radice del progetto
        Dim projectRoot As String = Application.StartupPath + "\DATA\AWES\ExploStyle\"
        ' Costruisci il percorso completo della DLL
        Dim dllPath As String = Path.Combine(projectRoot, "ExplorerBlurMica.dll")
        ' Rimuove la registrazione della DLL utilizzando regsvr32
        Dim process As New Process()
        process.StartInfo.FileName = "regsvr32"
        process.StartInfo.Arguments = "/u """ & dllPath & """"
        process.Start()
        process.WaitForExit()
        AEStyle = "false"
        My.SistemaKey.Default.Save()
        ' Aggiorna lo stato nel label
    End Sub
#End Region
#Region "BackgroundImageExplorer"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ottieni la radice del progetto
        Dim projectRoot As String = Application.StartupPath + "\DATA\AWES\BRG\"
        ' Costruisci il percorso completo della DLL
        Dim dllPath As String = Path.Combine(projectRoot, "ExplorerBgTool.dll")
        ' Rimuove la registrazione della DLL utilizzando regsvr32
        Dim process As New Process()
        process.StartInfo.FileName = "regsvr32"
        process.StartInfo.Arguments = "/u """ & dllPath & """"
        process.Start()
        process.WaitForExit()
        BEI = "true"
        My.SistemaKey.Default.Save()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonRegistra.Click
        Dim projectRoot As String = Application.StartupPath + "\DATA\AWES\BRG\"
        ' Costruisci il percorso completo della DLL
        Dim dllPath As String = Path.Combine(projectRoot, "ExplorerBgTool.dll")
        ' Registra la DLL utilizzando regsvr32
        Dim process As New Process()
        process.StartInfo.FileName = "regsvr32"
        process.StartInfo.Arguments = """" & dllPath & """"
        process.Start()
        process.WaitForExit()
        BEI = "false"
        My.SistemaKey.Default.Save()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonRimuovi.Click
        Dim folderPath As String = Application.StartupPath + "\DATA\AWES\BRG\Image"
        ' Verifica se la cartella esiste
        If System.IO.Directory.Exists(folderPath) Then
            ' Apri l'Esplora file nella cartella specificata
            Process.Start("explorer.exe", folderPath)
        Else
            MessageBox.Show("La cartella specificata non esiste.")
        End If
    End Sub
#End Region
#Region "getimageprofile"
    Private Function GetWindowsAccountProfileImagePath() As String
        Dim profileImagePath As String = ""

        Dim currentUserSid As String = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value
        Dim registryKeyPath As String = $"HKEY_USERS\{currentUserSid}\SOFTWARE\Microsoft\Windows\CurrentVersion\AccountPicture\Users\{currentUserSid}"

        Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey(registryKeyPath)
        If registryKey IsNot Nothing Then
            Dim profileImagePathValue As Object = registryKey.GetValue("AccountPicturePath")
            If profileImagePathValue IsNot Nothing AndAlso TypeOf profileImagePathValue Is String Then
                profileImagePath = DirectCast(profileImagePathValue, String)
            End If
        End If

        Return profileImagePath
    End Function

    Private Function LoadProfileImageFromPath(profileImagePath As String) As Image
        If File.Exists(profileImagePath) Then
            Return Image.FromFile(profileImagePath)
        Else
            Return Nothing
        End If
    End Function
    Private Sub LoadProfileImage()
        Dim profileImagePath As String = GetWindowsAccountProfileImagePath()
        Dim profileImage As Image = LoadProfileImageFromPath(profileImagePath)

        If profileImage IsNot Nothing Then
            ' Carica l'immagine nel PictureBox
            'PictureBox2.Image = profileImage
        Else
            ' L'immagine del profilo non è stata trovata o non esiste
            ' PictureBox2.Image = Nothing
        End If
    End Sub
#End Region
#Region "restartexplorer"
    Private Sub RiavviaExplorer()
        Try
            ' Ottieni il processo Explorer corrente
            Dim currentExplorerProcess As Process = GetExplorerProcess()

            ' Riavvia l'Explorer utilizzando il servizio Windows Shell
            Shell("taskkill /F /IM explorer.exe", AppWinStyle.Hide)
            Shell("explorer.exe", AppWinStyle.NormalFocus)

            ' Attendi che il nuovo processo Explorer si avvii
            Threading.Thread.Sleep(1000)

            ' Chiudi il processo Explorer precedente
            currentExplorerProcess.CloseMainWindow()
            currentExplorerProcess.Close()
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore durante il riavvio dell'Explorer: " & ex.Message)
        End Try
    End Sub

    Private Function GetExplorerProcess() As Process
        Dim explorerProcesses As Process() = Process.GetProcessesByName("explorer")
        Return explorerProcesses.FirstOrDefault()
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim totalRAM As Double = GetTotalRAM()
        Dim usedRAM As Double = GetUsedRAM()
        Ram.Text = ("Quantità totale di RAM: " & totalRAM.ToString("0.00") & " GB" & " - in uso: " & usedRAM.ToString("0.00") & " MB")
    End Sub


#End Region
#Region "graphicStyle"
    Private Function SetImageOpacity(image As Image, opacity As Single) As Image
        ' Crea una bitmap vuota con le stesse dimensioni dell'immagine originale
        Dim bitmap As New Bitmap(image.Width, image.Height)

        ' Imposta le informazioni di risoluzione della bitmap
        bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution)

        ' Crea un oggetto Graphics dalla bitmap
        Using graphics As Graphics = Graphics.FromImage(bitmap)
            ' Crea una matrice di colori con una matrice di colori e opacità ridotta
            Dim colorMatrix As New ColorMatrix()
            colorMatrix.Matrix33 = opacity

            ' Crea un oggetto ImageAttributes e imposta la matrice di colori ad esso
            Dim imageAttributes As New ImageAttributes()
            imageAttributes.SetColorMatrix(colorMatrix)

            ' Disegna l'immagine nella bitmap utilizzando l'oggetto ImageAttributes
            graphics.DrawImage(image, New Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes)
        End Using

        ' Restituisce la bitmap con l'opacità ridotta
        Return bitmap
    End Function
    Private Sub Home_Click(sender As Object, e As EventArgs) Handles HomeLabel.Click
        PHome.Visible = True
        PHome.Dock = DockStyle.Fill
        PMicaEx.Visible = False
        PMicaEx.Dock = DockStyle.None
        PBRGEX.Visible = False
        PBRGEX.Dock = DockStyle.None
        PSysInfo.Visible = False
        PSysInfo.Dock = DockStyle.None
        ' Imposta lo stile dei label
        HomeLabel.Font = New Font(HomeLabel.Font, FontStyle.Underline)
        MicaExLabel.Font = New Font(MicaExLabel.Font, FontStyle.Regular)
        BRGEXLabel.Font = New Font(BRGEXLabel.Font, FontStyle.Regular)
        SysinfoLabel.Font = New Font(SysinfoLabel.Font, FontStyle.Regular)
    End Sub
    Private Sub MicaEx_Click(sender As Object, e As EventArgs) Handles MicaExLabel.Click
        ' Nascondi tutti i subpanel tranne PMicaEx
        PHome.Visible = False
        PHome.Dock = DockStyle.None
        PMicaEx.Visible = True
        PMicaEx.Dock = DockStyle.Fill
        PBRGEX.Visible = False
        PBRGEX.Dock = DockStyle.None
        PSysInfo.Visible = False
        PSysInfo.Dock = DockStyle.None
        ' Imposta lo stile dei label
        HomeLabel.Font = New Font(HomeLabel.Font, FontStyle.Regular)
        MicaExLabel.Font = New Font(MicaExLabel.Font, FontStyle.Underline)
        BRGEXLabel.Font = New Font(BRGEXLabel.Font, FontStyle.Regular)
        SysinfoLabel.Font = New Font(SysinfoLabel.Font, FontStyle.Regular)
    End Sub
    Private Sub BRGEX_Click(sender As Object, e As EventArgs) Handles BRGEXLabel.Click
        ' Nascondi tutti i subpanel tranne PBRGEX
        PHome.Visible = False
        PHome.Dock = DockStyle.None
        PMicaEx.Visible = False
        PMicaEx.Dock = DockStyle.None
        PBRGEX.Visible = True
        PBRGEX.Dock = DockStyle.Fill
        PSysInfo.Visible = False
        PSysInfo.Dock = DockStyle.None
        ' Imposta lo stile dei label
        HomeLabel.Font = New Font(HomeLabel.Font, FontStyle.Regular)
        MicaExLabel.Font = New Font(MicaExLabel.Font, FontStyle.Regular)
        BRGEXLabel.Font = New Font(BRGEXLabel.Font, FontStyle.Underline)
        SysinfoLabel.Font = New Font(SysinfoLabel.Font, FontStyle.Regular)
    End Sub
    Private Sub Sysinfo_Click(sender As Object, e As EventArgs) Handles SysinfoLabel.Click
        ' Nascondi tutti i subpanel tranne PSysinfo
        PHome.Visible = False
        PHome.Dock = DockStyle.None
        PMicaEx.Visible = False
        PMicaEx.Dock = DockStyle.None
        PBRGEX.Visible = False
        PBRGEX.Dock = DockStyle.None
        PSysInfo.Visible = True
        PSysInfo.Dock = DockStyle.Fill
        ' Imposta lo stile dei label
        HomeLabel.Font = New Font(HomeLabel.Font, FontStyle.Regular)
        MicaExLabel.Font = New Font(MicaExLabel.Font, FontStyle.Regular)
        BRGEXLabel.Font = New Font(BRGEXLabel.Font, FontStyle.Regular)
        SysinfoLabel.Font = New Font(SysinfoLabel.Font, FontStyle.Underline)
    End Sub

    Private Sub PMicaEx_Paint(sender As Object, e As PaintEventArgs) Handles PMicaEx.Paint

    End Sub
#End Region
End Class