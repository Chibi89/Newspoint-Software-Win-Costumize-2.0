<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SetGraphicStyleExplorerMode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nickname = New System.Windows.Forms.Label()
        Me.AucLevel = New System.Windows.Forms.Label()
        Me.UpdateLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PSysInfo = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CPanel6 = New Newspoint_Software_Win_Costumize_2._0.CPanel()
        Me.WinBuild = New System.Windows.Forms.Label()
        Me.WinVer = New System.Windows.Forms.Label()
        Me.CPanel5 = New Newspoint_Software_Win_Costumize_2._0.CPanel()
        Me.CL = New System.Windows.Forms.Label()
        Me.Cpu = New System.Windows.Forms.Label()
        Me.Gpu = New System.Windows.Forms.Label()
        Me.Ram = New System.Windows.Forms.Label()
        Me.CPanel4 = New Newspoint_Software_Win_Costumize_2._0.CPanel()
        Me.DevMotherboard = New System.Windows.Forms.Label()
        Me.Mothermodel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3Timer = New System.Windows.Forms.Timer(Me.components)
        Me.HomeLabel = New System.Windows.Forms.Label()
        Me.MicaExLabel = New System.Windows.Forms.Label()
        Me.BRGEXLabel = New System.Windows.Forms.Label()
        Me.SysinfoLabel = New System.Windows.Forms.Label()
        Me.PCenter = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PHome = New System.Windows.Forms.Panel()
        Me.BrgExPanel = New System.Windows.Forms.Panel()
        Me.CPanel3 = New Newspoint_Software_Win_Costumize_2._0.CPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LBRGSTATE = New System.Windows.Forms.Label()
        Me.MExploPanel = New System.Windows.Forms.Panel()
        Me.CPanel1 = New Newspoint_Software_Win_Costumize_2._0.CPanel()
        Me.ButtonRimuovi = New System.Windows.Forms.Button()
        Me.LState = New System.Windows.Forms.Label()
        Me.ButtonRegistra = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelCState = New System.Windows.Forms.Label()
        Me.WinVer_Short = New System.Windows.Forms.Label()
        Me.C_Label = New System.Windows.Forms.Label()
        Me.C_Space = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Progressbar_C = New Newspoint_Software_Win_Costumize_2._0.Progress()
        Me.PMicaEx = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PBRGEX = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SettingLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.effectTextBox = New System.Windows.Forms.TextBox()
        Me.smallBorderTextBox = New System.Windows.Forms.TextBox()
        Me.showLineTextBox = New System.Windows.Forms.TextBox()
        Me.darkRibbonTextBox = New System.Windows.Forms.TextBox()
        Me.aTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PSysInfo.SuspendLayout()
        Me.CPanel6.SuspendLayout()
        Me.CPanel5.SuspendLayout()
        Me.CPanel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCenter.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PHome.SuspendLayout()
        Me.BrgExPanel.SuspendLayout()
        Me.CPanel3.SuspendLayout()
        Me.MExploPanel.SuspendLayout()
        Me.CPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PMicaEx.SuspendLayout()
        Me.PBRGEX.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 60)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "                        Per rendere effettive tutte le modifiche" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "               " &
    "             Devi riavviare il tuo pc, in alternativa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apri il taskmanager e ri" &
    "avvia il processo explorer.exe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SetGraphicStyleExplorerMode
        '
        Me.SetGraphicStyleExplorerMode.AutoSize = True
        Me.SetGraphicStyleExplorerMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.SetGraphicStyleExplorerMode.Location = New System.Drawing.Point(22, 9)
        Me.SetGraphicStyleExplorerMode.Name = "SetGraphicStyleExplorerMode"
        Me.SetGraphicStyleExplorerMode.Size = New System.Drawing.Size(51, 18)
        Me.SetGraphicStyleExplorerMode.TabIndex = 5
        Me.SetGraphicStyleExplorerMode.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(181, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Set Background Image Effect"
        '
        'Nickname
        '
        Me.Nickname.AutoSize = True
        Me.Nickname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Nickname.Location = New System.Drawing.Point(6, 27)
        Me.Nickname.Name = "Nickname"
        Me.Nickname.Size = New System.Drawing.Size(35, 17)
        Me.Nickname.TabIndex = 7
        Me.Nickname.Text = "Nick"
        '
        'AucLevel
        '
        Me.AucLevel.AutoSize = True
        Me.AucLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.AucLevel.Location = New System.Drawing.Point(6, 56)
        Me.AucLevel.Name = "AucLevel"
        Me.AucLevel.Size = New System.Drawing.Size(100, 17)
        Me.AucLevel.TabIndex = 8
        Me.AucLevel.Text = "Livello autorità"
        '
        'UpdateLabel
        '
        Me.UpdateLabel.AutoSize = True
        Me.UpdateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.UpdateLabel.Location = New System.Drawing.Point(6, 82)
        Me.UpdateLabel.Name = "UpdateLabel"
        Me.UpdateLabel.Size = New System.Drawing.Size(87, 17)
        Me.UpdateLabel.TabIndex = 9
        Me.UpdateLabel.Text = "StatoUpdate"
        Me.UpdateLabel.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PSysInfo
        '
        Me.PSysInfo.AutoScroll = True
        Me.PSysInfo.Controls.Add(Me.Label8)
        Me.PSysInfo.Controls.Add(Me.Label7)
        Me.PSysInfo.Controls.Add(Me.Label6)
        Me.PSysInfo.Controls.Add(Me.CPanel6)
        Me.PSysInfo.Controls.Add(Me.CPanel5)
        Me.PSysInfo.Controls.Add(Me.CPanel4)
        Me.PSysInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PSysInfo.Location = New System.Drawing.Point(0, 0)
        Me.PSysInfo.Name = "PSysInfo"
        Me.PSysInfo.Size = New System.Drawing.Size(674, 446)
        Me.PSysInfo.TabIndex = 14
        Me.PSysInfo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label8.Location = New System.Drawing.Point(451, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Primary Component Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label7.Location = New System.Drawing.Point(494, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Motherboard Info"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label6.Location = New System.Drawing.Point(519, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Windows Info"
        '
        'CPanel6
        '
        Me.CPanel6.BackColor = System.Drawing.Color.White
        Me.CPanel6.Controls.Add(Me.WinBuild)
        Me.CPanel6.Controls.Add(Me.WinVer)
        Me.CPanel6.Location = New System.Drawing.Point(181, 54)
        Me.CPanel6.Name = "CPanel6"
        Me.CPanel6.Size = New System.Drawing.Size(429, 123)
        Me.CPanel6.TabIndex = 24
        '
        'WinBuild
        '
        Me.WinBuild.AutoSize = True
        Me.WinBuild.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.WinBuild.Location = New System.Drawing.Point(13, 73)
        Me.WinBuild.Name = "WinBuild"
        Me.WinBuild.Size = New System.Drawing.Size(38, 17)
        Me.WinBuild.TabIndex = 19
        Me.WinBuild.Text = "build"
        '
        'WinVer
        '
        Me.WinVer.AutoSize = True
        Me.WinVer.Location = New System.Drawing.Point(13, 30)
        Me.WinVer.Name = "WinVer"
        Me.WinVer.Size = New System.Drawing.Size(38, 13)
        Me.WinVer.TabIndex = 18
        Me.WinVer.Text = "winver"
        '
        'CPanel5
        '
        Me.CPanel5.BackColor = System.Drawing.Color.White
        Me.CPanel5.Controls.Add(Me.CL)
        Me.CPanel5.Controls.Add(Me.Cpu)
        Me.CPanel5.Controls.Add(Me.Gpu)
        Me.CPanel5.Controls.Add(Me.Ram)
        Me.CPanel5.Location = New System.Drawing.Point(181, 371)
        Me.CPanel5.Name = "CPanel5"
        Me.CPanel5.Size = New System.Drawing.Size(429, 177)
        Me.CPanel5.TabIndex = 23
        '
        'CL
        '
        Me.CL.AutoSize = True
        Me.CL.Location = New System.Drawing.Point(13, 129)
        Me.CL.Name = "CL"
        Me.CL.Size = New System.Drawing.Size(58, 13)
        Me.CL.TabIndex = 22
        Me.CL.Text = "HHD/SSD"
        '
        'Cpu
        '
        Me.Cpu.AutoSize = True
        Me.Cpu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Cpu.Location = New System.Drawing.Point(13, 18)
        Me.Cpu.Name = "Cpu"
        Me.Cpu.Size = New System.Drawing.Size(33, 17)
        Me.Cpu.TabIndex = 15
        Me.Cpu.Text = "Cpu"
        '
        'Gpu
        '
        Me.Gpu.AutoSize = True
        Me.Gpu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Gpu.Location = New System.Drawing.Point(13, 56)
        Me.Gpu.Name = "Gpu"
        Me.Gpu.Size = New System.Drawing.Size(35, 17)
        Me.Gpu.TabIndex = 20
        Me.Gpu.Text = "Gpu"
        '
        'Ram
        '
        Me.Ram.AutoSize = True
        Me.Ram.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Ram.Location = New System.Drawing.Point(13, 93)
        Me.Ram.Name = "Ram"
        Me.Ram.Size = New System.Drawing.Size(32, 17)
        Me.Ram.TabIndex = 21
        Me.Ram.Text = "ram"
        '
        'CPanel4
        '
        Me.CPanel4.BackColor = System.Drawing.Color.White
        Me.CPanel4.Controls.Add(Me.DevMotherboard)
        Me.CPanel4.Controls.Add(Me.Mothermodel)
        Me.CPanel4.Location = New System.Drawing.Point(181, 216)
        Me.CPanel4.Name = "CPanel4"
        Me.CPanel4.Size = New System.Drawing.Size(429, 127)
        Me.CPanel4.TabIndex = 22
        '
        'DevMotherboard
        '
        Me.DevMotherboard.AutoSize = True
        Me.DevMotherboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.DevMotherboard.Location = New System.Drawing.Point(13, 13)
        Me.DevMotherboard.Name = "DevMotherboard"
        Me.DevMotherboard.Size = New System.Drawing.Size(77, 17)
        Me.DevMotherboard.TabIndex = 16
        Me.DevMotherboard.Text = "DevMother"
        '
        'Mothermodel
        '
        Me.Mothermodel.AutoSize = True
        Me.Mothermodel.Location = New System.Drawing.Point(13, 65)
        Me.Mothermodel.Name = "Mothermodel"
        Me.Mothermodel.Size = New System.Drawing.Size(69, 13)
        Me.Mothermodel.TabIndex = 17
        Me.Mothermodel.Text = "MotherModel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 100)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(78, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "System Info"
        '
        'HomeLabel
        '
        Me.HomeLabel.AutoSize = True
        Me.HomeLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeLabel.Location = New System.Drawing.Point(31, 163)
        Me.HomeLabel.Name = "HomeLabel"
        Me.HomeLabel.Size = New System.Drawing.Size(51, 21)
        Me.HomeLabel.TabIndex = 20
        Me.HomeLabel.Text = "Home"
        '
        'MicaExLabel
        '
        Me.MicaExLabel.AutoSize = True
        Me.MicaExLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MicaExLabel.Location = New System.Drawing.Point(31, 191)
        Me.MicaExLabel.Name = "MicaExLabel"
        Me.MicaExLabel.Size = New System.Drawing.Size(102, 21)
        Me.MicaExLabel.TabIndex = 21
        Me.MicaExLabel.Text = "Mica Explorer"
        '
        'BRGEXLabel
        '
        Me.BRGEXLabel.AutoSize = True
        Me.BRGEXLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRGEXLabel.Location = New System.Drawing.Point(31, 223)
        Me.BRGEXLabel.Name = "BRGEXLabel"
        Me.BRGEXLabel.Size = New System.Drawing.Size(111, 21)
        Me.BRGEXLabel.TabIndex = 22
        Me.BRGEXLabel.Text = "Image Explorer"
        '
        'SysinfoLabel
        '
        Me.SysinfoLabel.AutoSize = True
        Me.SysinfoLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SysinfoLabel.Location = New System.Drawing.Point(31, 255)
        Me.SysinfoLabel.Name = "SysinfoLabel"
        Me.SysinfoLabel.Size = New System.Drawing.Size(89, 21)
        Me.SysinfoLabel.TabIndex = 23
        Me.SysinfoLabel.Text = "System Info"
        '
        'PCenter
        '
        Me.PCenter.Controls.Add(Me.PSysInfo)
        Me.PCenter.Controls.Add(Me.PHome)
        Me.PCenter.Controls.Add(Me.PMicaEx)
        Me.PCenter.Controls.Add(Me.Panel1)
        Me.PCenter.Controls.Add(Me.PBRGEX)
        Me.PCenter.Location = New System.Drawing.Point(201, -2)
        Me.PCenter.Name = "PCenter"
        Me.PCenter.Size = New System.Drawing.Size(674, 446)
        Me.PCenter.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(333, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Setting"
        '
        'PHome
        '
        Me.PHome.AutoScroll = True
        Me.PHome.Controls.Add(Me.WinVer_Short)
        Me.PHome.Controls.Add(Me.BrgExPanel)
        Me.PHome.Controls.Add(Me.MExploPanel)
        Me.PHome.Controls.Add(Me.Label9)
        Me.PHome.Controls.Add(Me.LabelCState)
        Me.PHome.Controls.Add(Me.Label1)
        Me.PHome.Controls.Add(Me.C_Label)
        Me.PHome.Controls.Add(Me.Label3)
        Me.PHome.Controls.Add(Me.C_Space)
        Me.PHome.Controls.Add(Me.PictureBox2)
        Me.PHome.Controls.Add(Me.Progressbar_C)
        Me.PHome.Location = New System.Drawing.Point(0, 0)
        Me.PHome.Name = "PHome"
        Me.PHome.Size = New System.Drawing.Size(226, 171)
        Me.PHome.TabIndex = 25
        '
        'BrgExPanel
        '
        Me.BrgExPanel.Controls.Add(Me.PictureBox1)
        Me.BrgExPanel.Controls.Add(Me.CPanel3)
        Me.BrgExPanel.Controls.Add(Me.Label2)
        Me.BrgExPanel.Location = New System.Drawing.Point(228, 324)
        Me.BrgExPanel.Name = "BrgExPanel"
        Me.BrgExPanel.Size = New System.Drawing.Size(389, 128)
        Me.BrgExPanel.TabIndex = 25
        '
        'CPanel3
        '
        Me.CPanel3.BackColor = System.Drawing.Color.White
        Me.CPanel3.Controls.Add(Me.Button3)
        Me.CPanel3.Controls.Add(Me.Button1)
        Me.CPanel3.Controls.Add(Me.LBRGSTATE)
        Me.CPanel3.Location = New System.Drawing.Point(121, 20)
        Me.CPanel3.Name = "CPanel3"
        Me.CPanel3.Size = New System.Drawing.Size(260, 100)
        Me.CPanel3.TabIndex = 17
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(139, 45)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "&Disattiva"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Attiva"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LBRGSTATE
        '
        Me.LBRGSTATE.AutoSize = True
        Me.LBRGSTATE.Location = New System.Drawing.Point(12, 77)
        Me.LBRGSTATE.Name = "LBRGSTATE"
        Me.LBRGSTATE.Size = New System.Drawing.Size(39, 13)
        Me.LBRGSTATE.TabIndex = 11
        Me.LBRGSTATE.Text = "Label3"
        '
        'MExploPanel
        '
        Me.MExploPanel.Controls.Add(Me.SetGraphicStyleExplorerMode)
        Me.MExploPanel.Controls.Add(Me.CPanel1)
        Me.MExploPanel.Location = New System.Drawing.Point(310, 161)
        Me.MExploPanel.Name = "MExploPanel"
        Me.MExploPanel.Size = New System.Drawing.Size(307, 147)
        Me.MExploPanel.TabIndex = 32
        '
        'CPanel1
        '
        Me.CPanel1.BackColor = System.Drawing.Color.White
        Me.CPanel1.Controls.Add(Me.ButtonRimuovi)
        Me.CPanel1.Controls.Add(Me.LState)
        Me.CPanel1.Controls.Add(Me.ButtonRegistra)
        Me.CPanel1.Location = New System.Drawing.Point(39, 30)
        Me.CPanel1.Name = "CPanel1"
        Me.CPanel1.Size = New System.Drawing.Size(262, 113)
        Me.CPanel1.TabIndex = 15
        '
        'ButtonRimuovi
        '
        Me.ButtonRimuovi.Location = New System.Drawing.Point(146, 64)
        Me.ButtonRimuovi.Name = "ButtonRimuovi"
        Me.ButtonRimuovi.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRimuovi.TabIndex = 1
        Me.ButtonRimuovi.Text = "&Rimuovi"
        Me.ButtonRimuovi.UseVisualStyleBackColor = True
        '
        'LState
        '
        Me.LState.AutoSize = True
        Me.LState.Location = New System.Drawing.Point(15, 89)
        Me.LState.Name = "LState"
        Me.LState.Size = New System.Drawing.Size(39, 13)
        Me.LState.TabIndex = 10
        Me.LState.Text = "Label3"
        '
        'ButtonRegistra
        '
        Me.ButtonRegistra.Location = New System.Drawing.Point(65, 64)
        Me.ButtonRegistra.Name = "ButtonRegistra"
        Me.ButtonRegistra.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegistra.TabIndex = 0
        Me.ButtonRegistra.Text = "&Attiva"
        Me.ButtonRegistra.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(432, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "App in primo piano"
        '
        'LabelCState
        '
        Me.LabelCState.AutoSize = True
        Me.LabelCState.BackColor = System.Drawing.SystemColors.Control
        Me.LabelCState.Location = New System.Drawing.Point(104, 102)
        Me.LabelCState.Name = "LabelCState"
        Me.LabelCState.Size = New System.Drawing.Size(39, 13)
        Me.LabelCState.TabIndex = 30
        Me.LabelCState.Text = "Label9"
        '
        'WinVer_Short
        '
        Me.WinVer_Short.AutoSize = True
        Me.WinVer_Short.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.WinVer_Short.Location = New System.Drawing.Point(104, 39)
        Me.WinVer_Short.Name = "WinVer_Short"
        Me.WinVer_Short.Size = New System.Drawing.Size(92, 18)
        Me.WinVer_Short.TabIndex = 29
        Me.WinVer_Short.Text = "WinVerShort"
        '
        'C_Label
        '
        Me.C_Label.AutoSize = True
        Me.C_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.C_Label.Location = New System.Drawing.Point(104, 58)
        Me.C_Label.Name = "C_Label"
        Me.C_Label.Size = New System.Drawing.Size(62, 18)
        Me.C_Label.TabIndex = 28
        Me.C_Label.Text = "C_Label"
        '
        'C_Space
        '
        Me.C_Space.AutoSize = True
        Me.C_Space.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.C_Space.ForeColor = System.Drawing.Color.Black
        Me.C_Space.Location = New System.Drawing.Point(104, 115)
        Me.C_Space.Name = "C_Space"
        Me.C_Space.Size = New System.Drawing.Size(43, 16)
        Me.C_Space.TabIndex = 27
        Me.C_Space.Text = "c Size"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Newspoint_Software_Win_Costumize_2._0.My.Resources.Resources.icons8_windows_10_512
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(3, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 88)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Progressbar_C
        '
        Me.Progressbar_C.Location = New System.Drawing.Point(107, 76)
        Me.Progressbar_C.Name = "Progressbar_C"
        Me.Progressbar_C.Size = New System.Drawing.Size(153, 23)
        Me.Progressbar_C.TabIndex = 25
        '
        'PMicaEx
        '
        Me.PMicaEx.AutoScroll = True
        Me.PMicaEx.Controls.Add(Me.Label15)
        Me.PMicaEx.Controls.Add(Me.Label14)
        Me.PMicaEx.Controls.Add(Me.Label13)
        Me.PMicaEx.Controls.Add(Me.Label12)
        Me.PMicaEx.Controls.Add(Me.Label11)
        Me.PMicaEx.Controls.Add(Me.aTextBox)
        Me.PMicaEx.Controls.Add(Me.darkRibbonTextBox)
        Me.PMicaEx.Controls.Add(Me.showLineTextBox)
        Me.PMicaEx.Controls.Add(Me.smallBorderTextBox)
        Me.PMicaEx.Controls.Add(Me.effectTextBox)
        Me.PMicaEx.Controls.Add(Me.Button2)
        Me.PMicaEx.Controls.Add(Me.Label4)
        Me.PMicaEx.Location = New System.Drawing.Point(41, 289)
        Me.PMicaEx.Name = "PMicaEx"
        Me.PMicaEx.Size = New System.Drawing.Size(200, 100)
        Me.PMicaEx.TabIndex = 25
        Me.PMicaEx.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Setting Mica Explorer"
        '
        'PBRGEX
        '
        Me.PBRGEX.AutoScroll = True
        Me.PBRGEX.Controls.Add(Me.Label5)
        Me.PBRGEX.Location = New System.Drawing.Point(289, 315)
        Me.PBRGEX.Name = "PBRGEX"
        Me.PBRGEX.Size = New System.Drawing.Size(200, 100)
        Me.PBRGEX.TabIndex = 26
        Me.PBRGEX.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Image Explorer Setting"
        '
        'SettingLabel
        '
        Me.SettingLabel.AutoSize = True
        Me.SettingLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingLabel.Location = New System.Drawing.Point(31, 287)
        Me.SettingLabel.Name = "SettingLabel"
        Me.SettingLabel.Size = New System.Drawing.Size(58, 21)
        Me.SettingLabel.TabIndex = 25
        Me.SettingLabel.Text = "Setting"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(473, 373)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'effectTextBox
        '
        Me.effectTextBox.Location = New System.Drawing.Point(156, 154)
        Me.effectTextBox.Name = "effectTextBox"
        Me.effectTextBox.Size = New System.Drawing.Size(100, 20)
        Me.effectTextBox.TabIndex = 2
        '
        'smallBorderTextBox
        '
        Me.smallBorderTextBox.Location = New System.Drawing.Point(156, 195)
        Me.smallBorderTextBox.Name = "smallBorderTextBox"
        Me.smallBorderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.smallBorderTextBox.TabIndex = 3
        '
        'showLineTextBox
        '
        Me.showLineTextBox.Location = New System.Drawing.Point(156, 238)
        Me.showLineTextBox.Name = "showLineTextBox"
        Me.showLineTextBox.Size = New System.Drawing.Size(100, 20)
        Me.showLineTextBox.TabIndex = 4
        '
        'darkRibbonTextBox
        '
        Me.darkRibbonTextBox.Location = New System.Drawing.Point(156, 282)
        Me.darkRibbonTextBox.Name = "darkRibbonTextBox"
        Me.darkRibbonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.darkRibbonTextBox.TabIndex = 5
        '
        'aTextBox
        '
        Me.aTextBox.Location = New System.Drawing.Point(356, 154)
        Me.aTextBox.Name = "aTextBox"
        Me.aTextBox.Size = New System.Drawing.Size(100, 20)
        Me.aTextBox.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(349, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Opacity"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(153, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Effect Panel"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(153, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Small Border"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(153, 222)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Show Line"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(153, 266)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Dark Ribbon"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 443)
        Me.Controls.Add(Me.SettingLabel)
        Me.Controls.Add(Me.PCenter)
        Me.Controls.Add(Me.SysinfoLabel)
        Me.Controls.Add(Me.BRGEXLabel)
        Me.Controls.Add(Me.MicaExLabel)
        Me.Controls.Add(Me.HomeLabel)
        Me.Controls.Add(Me.UpdateLabel)
        Me.Controls.Add(Me.AucLevel)
        Me.Controls.Add(Me.Nickname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        Me.PSysInfo.ResumeLayout(False)
        Me.PSysInfo.PerformLayout()
        Me.CPanel6.ResumeLayout(False)
        Me.CPanel6.PerformLayout()
        Me.CPanel5.ResumeLayout(False)
        Me.CPanel5.PerformLayout()
        Me.CPanel4.ResumeLayout(False)
        Me.CPanel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCenter.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PHome.ResumeLayout(False)
        Me.PHome.PerformLayout()
        Me.BrgExPanel.ResumeLayout(False)
        Me.BrgExPanel.PerformLayout()
        Me.CPanel3.ResumeLayout(False)
        Me.CPanel3.PerformLayout()
        Me.MExploPanel.ResumeLayout(False)
        Me.MExploPanel.PerformLayout()
        Me.CPanel1.ResumeLayout(False)
        Me.CPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PMicaEx.ResumeLayout(False)
        Me.PMicaEx.PerformLayout()
        Me.PBRGEX.ResumeLayout(False)
        Me.PBRGEX.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRegistra As Button
    Friend WithEvents ButtonRimuovi As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SetGraphicStyleExplorerMode As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Nickname As Label
    Friend WithEvents AucLevel As Label
    Friend WithEvents UpdateLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LState As Label
    Friend WithEvents LBRGSTATE As Label
    Friend WithEvents PSysInfo As Windows.Forms.Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WinVer As Label
    Friend WithEvents Mothermodel As Label
    Friend WithEvents DevMotherboard As Label
    Friend WithEvents Cpu As Label
    Friend WithEvents CL As Label
    Friend WithEvents Ram As Label
    Friend WithEvents Gpu As Label
    Friend WithEvents WinBuild As Label
    Friend WithEvents CPanel1 As CPanel
    Friend WithEvents CPanel3 As CPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1Timer As Timer
    Friend WithEvents Panel2Timer As Timer
    Friend WithEvents Panel3Timer As Timer
    Friend WithEvents HomeLabel As Label
    Friend WithEvents MicaExLabel As Label
    Friend WithEvents BRGEXLabel As Label
    Friend WithEvents SysinfoLabel As Label
    Friend WithEvents PCenter As Panel
    Friend WithEvents PHome As Panel
    Friend WithEvents CPanel6 As CPanel
    Friend WithEvents CPanel5 As CPanel
    Friend WithEvents CPanel4 As CPanel
    Friend WithEvents PMicaEx As Panel
    Friend WithEvents PBRGEX As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Progressbar_C As Progress
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents WinVer_Short As Label
    Friend WithEvents C_Label As Label
    Friend WithEvents C_Space As Label
    Friend WithEvents LabelCState As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BrgExPanel As Panel
    Friend WithEvents MExploPanel As Panel
    Friend WithEvents SettingLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents aTextBox As TextBox
    Friend WithEvents darkRibbonTextBox As TextBox
    Friend WithEvents showLineTextBox As TextBox
    Friend WithEvents smallBorderTextBox As TextBox
    Friend WithEvents effectTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
End Class
