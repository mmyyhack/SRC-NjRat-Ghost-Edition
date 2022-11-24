<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Builder
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Builder))
        Me.host = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.port = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Idr = New System.Windows.Forms.CheckBox()
        Me.dir = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.exe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VN = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bsod = New System.Windows.Forms.CheckBox()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.Isf = New System.Windows.Forms.CheckBox()
        Me.Isu = New System.Windows.Forms.CheckBox()
        Me.klen = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.HiddenP = New System.Windows.Forms.NumericUpDown()
        Me.HiddenH = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.firewall = New System.Windows.Forms.CheckBox()
        Me.hide = New System.Windows.Forms.CheckBox()
        Me.schedule = New System.Windows.Forms.CheckBox()
        Me.PortTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.KillProc = New System.Windows.Forms.CheckBox()
        Me.TaskMGR = New System.Windows.Forms.CheckBox()
        Me.VirtualBOX = New System.Windows.Forms.CheckBox()
        Me.VMWare = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ANYRUN = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.klen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.HiddenP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'host
        '
        Me.host.BackColor = System.Drawing.Color.Black
        Me.host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.host.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.host.ForeColor = System.Drawing.Color.White
        Me.host.Location = New System.Drawing.Point(9, 33)
        Me.host.Name = "host"
        Me.host.Size = New System.Drawing.Size(163, 20)
        Me.host.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Host"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(175, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'port
        '
        Me.port.BackColor = System.Drawing.Color.Black
        Me.port.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.port.ForeColor = System.Drawing.Color.White
        Me.port.Location = New System.Drawing.Point(178, 33)
        Me.port.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(69, 20)
        Me.port.TabIndex = 3
        Me.port.Value = New Decimal(New Integer() {1177, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ExeName"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Idr)
        Me.GroupBox1.Controls.Add(Me.dir)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.exe)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.VN)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 144)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Install Options"
        '
        'Idr
        '
        Me.Idr.AutoSize = True
        Me.Idr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Idr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idr.ForeColor = System.Drawing.Color.White
        Me.Idr.Location = New System.Drawing.Point(196, 12)
        Me.Idr.Name = "Idr"
        Me.Idr.Size = New System.Drawing.Size(54, 18)
        Me.Idr.TabIndex = 14
        Me.Idr.Text = "Copy"
        Me.Idr.UseVisualStyleBackColor = True
        '
        'dir
        '
        Me.dir.BackColor = System.Drawing.Color.Black
        Me.dir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dir.Enabled = False
        Me.dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dir.ForeColor = System.Drawing.Color.White
        Me.dir.FormattingEnabled = True
        Me.dir.Items.AddRange(New Object() {"%TEMP%", "%AppData%", "%UserProfile%", "%AllUsersProfile%", "%WinDir%"})
        Me.dir.Location = New System.Drawing.Point(6, 73)
        Me.dir.Name = "dir"
        Me.dir.Size = New System.Drawing.Size(241, 22)
        Me.dir.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Directory"
        '
        'exe
        '
        Me.exe.BackColor = System.Drawing.Color.Black
        Me.exe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.exe.Enabled = False
        Me.exe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exe.ForeColor = System.Drawing.Color.White
        Me.exe.Location = New System.Drawing.Point(6, 32)
        Me.exe.Name = "exe"
        Me.exe.Size = New System.Drawing.Size(241, 20)
        Me.exe.TabIndex = 5
        Me.exe.Text = "SearchApp.exe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "VicTim Identity"
        '
        'VN
        '
        Me.VN.BackColor = System.Drawing.Color.Black
        Me.VN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VN.ForeColor = System.Drawing.Color.White
        Me.VN.Location = New System.Drawing.Point(6, 115)
        Me.VN.Name = "VN"
        Me.VN.Size = New System.Drawing.Size(240, 20)
        Me.VN.TabIndex = 10
        Me.VN.Text = "HacKed By Ghost"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(499, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 44)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Build"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 18)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Change Icon"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(170, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'bsod
        '
        Me.bsod.AutoSize = True
        Me.bsod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bsod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsod.ForeColor = System.Drawing.Color.White
        Me.bsod.Location = New System.Drawing.Point(6, 43)
        Me.bsod.Name = "bsod"
        Me.bsod.Size = New System.Drawing.Size(115, 18)
        Me.bsod.TabIndex = 11
        Me.bsod.Text = "Protect Process"
        Me.bsod.UseVisualStyleBackColor = True
        '
        'T1
        '
        Me.T1.BackColor = System.Drawing.Color.Black
        Me.T1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T1.ForeColor = System.Drawing.Color.White
        Me.T1.Location = New System.Drawing.Point(563, 385)
        Me.T1.Multiline = True
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(100, 20)
        Me.T1.TabIndex = 12
        Me.T1.Visible = False
        '
        'Isf
        '
        Me.Isf.AutoSize = True
        Me.Isf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Isf.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Isf.ForeColor = System.Drawing.Color.White
        Me.Isf.Location = New System.Drawing.Point(6, 67)
        Me.Isf.Name = "Isf"
        Me.Isf.Size = New System.Drawing.Size(113, 18)
        Me.Isf.TabIndex = 13
        Me.Isf.Text = "Copy To StartUp"
        Me.Isf.UseVisualStyleBackColor = True
        '
        'Isu
        '
        Me.Isu.AutoSize = True
        Me.Isu.Checked = True
        Me.Isu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Isu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Isu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Isu.ForeColor = System.Drawing.Color.White
        Me.Isu.Location = New System.Drawing.Point(6, 91)
        Me.Isu.Name = "Isu"
        Me.Isu.Size = New System.Drawing.Size(106, 18)
        Me.Isu.TabIndex = 14
        Me.Isu.Text = "Registy StarUp"
        Me.Isu.UseVisualStyleBackColor = True
        '
        'klen
        '
        Me.klen.BackColor = System.Drawing.Color.Black
        Me.klen.ForeColor = System.Drawing.Color.White
        Me.klen.Location = New System.Drawing.Point(170, 231)
        Me.klen.Maximum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.klen.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.klen.Name = "klen"
        Me.klen.Size = New System.Drawing.Size(48, 20)
        Me.klen.TabIndex = 15
        Me.klen.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 14)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "KeyLogs Size KB"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.HiddenP)
        Me.GroupBox2.Controls.Add(Me.HiddenH)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.host)
        Me.GroupBox2.Controls.Add(Me.port)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 109)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Connection Options"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Encrypted info"
        '
        'HiddenP
        '
        Me.HiddenP.BackColor = System.Drawing.Color.Black
        Me.HiddenP.Enabled = False
        Me.HiddenP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HiddenP.ForeColor = System.Drawing.Color.White
        Me.HiddenP.Location = New System.Drawing.Point(177, 74)
        Me.HiddenP.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.HiddenP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HiddenP.Name = "HiddenP"
        Me.HiddenP.Size = New System.Drawing.Size(69, 20)
        Me.HiddenP.TabIndex = 5
        Me.HiddenP.Value = New Decimal(New Integer() {1177, 0, 0, 0})
        '
        'HiddenH
        '
        Me.HiddenH.BackColor = System.Drawing.Color.Black
        Me.HiddenH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HiddenH.Enabled = False
        Me.HiddenH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HiddenH.ForeColor = System.Drawing.Color.White
        Me.HiddenH.Location = New System.Drawing.Point(8, 74)
        Me.HiddenH.Name = "HiddenH"
        Me.HiddenH.Size = New System.Drawing.Size(163, 20)
        Me.HiddenH.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.firewall)
        Me.GroupBox3.Controls.Add(Me.hide)
        Me.GroupBox3.Controls.Add(Me.schedule)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.klen)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.bsod)
        Me.GroupBox3.Controls.Add(Me.Isf)
        Me.GroupBox3.Controls.Add(Me.Isu)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(269, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 258)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extra Options"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(6, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 20)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "MicrosoftEdgeUpdateTaskMachine"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 14)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Name Task"
        '
        'firewall
        '
        Me.firewall.AutoSize = True
        Me.firewall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.firewall.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firewall.ForeColor = System.Drawing.Color.White
        Me.firewall.Location = New System.Drawing.Point(6, 208)
        Me.firewall.Name = "firewall"
        Me.firewall.Size = New System.Drawing.Size(125, 18)
        Me.firewall.TabIndex = 19
        Me.firewall.Text = "Firewall Exception"
        Me.firewall.UseVisualStyleBackColor = True
        '
        'hide
        '
        Me.hide.AutoSize = True
        Me.hide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hide.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hide.ForeColor = System.Drawing.Color.White
        Me.hide.Location = New System.Drawing.Point(6, 184)
        Me.hide.Name = "hide"
        Me.hide.Size = New System.Drawing.Size(90, 18)
        Me.hide.TabIndex = 18
        Me.hide.Text = "Hide Server"
        Me.hide.UseVisualStyleBackColor = True
        '
        'schedule
        '
        Me.schedule.AutoSize = True
        Me.schedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.schedule.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schedule.ForeColor = System.Drawing.Color.White
        Me.schedule.Location = New System.Drawing.Point(6, 115)
        Me.schedule.Name = "schedule"
        Me.schedule.Size = New System.Drawing.Size(107, 18)
        Me.schedule.TabIndex = 17
        Me.schedule.Text = "Shedule Tasks"
        Me.schedule.UseVisualStyleBackColor = True
        '
        'PortTimer
        '
        Me.PortTimer.Interval = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.KillProc)
        Me.GroupBox4.Controls.Add(Me.TaskMGR)
        Me.GroupBox4.Controls.Add(Me.VirtualBOX)
        Me.GroupBox4.Controls.Add(Me.VMWare)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox4.Controls.Add(Me.ANYRUN)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(499, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(224, 209)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Extra Options 2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(6, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 14)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Process to kill"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(149, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "1"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(5, 156)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(213, 20)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Text = "Exsample.exe"
        '
        'KillProc
        '
        Me.KillProc.AutoSize = True
        Me.KillProc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KillProc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KillProc.ForeColor = System.Drawing.Color.White
        Me.KillProc.Location = New System.Drawing.Point(6, 115)
        Me.KillProc.Name = "KillProc"
        Me.KillProc.Size = New System.Drawing.Size(91, 18)
        Me.KillProc.TabIndex = 26
        Me.KillProc.Text = "Kill Process"
        Me.KillProc.UseVisualStyleBackColor = True
        '
        'TaskMGR
        '
        Me.TaskMGR.AutoSize = True
        Me.TaskMGR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TaskMGR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskMGR.ForeColor = System.Drawing.Color.White
        Me.TaskMGR.Location = New System.Drawing.Point(6, 91)
        Me.TaskMGR.Name = "TaskMGR"
        Me.TaskMGR.Size = New System.Drawing.Size(94, 18)
        Me.TaskMGR.TabIndex = 25
        Me.TaskMGR.Text = "Kill Taskmgr"
        Me.TaskMGR.UseVisualStyleBackColor = True
        '
        'VirtualBOX
        '
        Me.VirtualBOX.AutoSize = True
        Me.VirtualBOX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VirtualBOX.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VirtualBOX.ForeColor = System.Drawing.Color.White
        Me.VirtualBOX.Location = New System.Drawing.Point(6, 67)
        Me.VirtualBOX.Name = "VirtualBOX"
        Me.VirtualBOX.Size = New System.Drawing.Size(107, 18)
        Me.VirtualBOX.TabIndex = 24
        Me.VirtualBOX.Text = "Anti VirtualBox"
        Me.VirtualBOX.UseVisualStyleBackColor = True
        '
        'VMWare
        '
        Me.VMWare.AutoSize = True
        Me.VMWare.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VMWare.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VMWare.ForeColor = System.Drawing.Color.White
        Me.VMWare.Location = New System.Drawing.Point(6, 43)
        Me.VMWare.Name = "VMWare"
        Me.VMWare.Size = New System.Drawing.Size(97, 18)
        Me.VMWare.TabIndex = 23
        Me.VMWare.Text = "Anti VMWare"
        Me.VMWare.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(196, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 14)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "(S)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 14)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Sleep Thread"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.Black
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown1.Location = New System.Drawing.Point(142, 182)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown1.TabIndex = 20
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ANYRUN
        '
        Me.ANYRUN.AutoSize = True
        Me.ANYRUN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ANYRUN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ANYRUN.ForeColor = System.Drawing.Color.White
        Me.ANYRUN.Location = New System.Drawing.Point(6, 19)
        Me.ANYRUN.Name = "ANYRUN"
        Me.ANYRUN.Size = New System.Drawing.Size(96, 18)
        Me.ANYRUN.TabIndex = 21
        Me.ANYRUN.Text = "Anti ANY.RUN"
        Me.ANYRUN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Builder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(730, 273)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Builder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Builder"
        CType(Me.port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.klen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.HiddenP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents host As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents port As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents exe As System.Windows.Forms.TextBox
    Friend WithEvents dir As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VN As System.Windows.Forms.TextBox
    Friend WithEvents bsod As System.Windows.Forms.CheckBox
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Isf As System.Windows.Forms.CheckBox
    Friend WithEvents Idr As System.Windows.Forms.CheckBox
    Friend WithEvents Isu As System.Windows.Forms.CheckBox
    Friend WithEvents klen As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents HiddenP As NumericUpDown
    Friend WithEvents HiddenH As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents firewall As CheckBox
    Friend WithEvents hide As CheckBox
    Friend WithEvents schedule As CheckBox
    Friend WithEvents PortTimer As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents KillProc As CheckBox
    Friend WithEvents TaskMGR As CheckBox
    Friend WithEvents VirtualBOX As CheckBox
    Friend WithEvents VMWare As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ANYRUN As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label12 As Label
End Class
