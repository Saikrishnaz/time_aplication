<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        components = New ComponentModel.Container()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Btn_add = New Button()
        Panel1 = New Panel()
        Check_Alrm_5 = New CheckBox()
        Check_Alrm_4 = New CheckBox()
        Check_Alrm_3 = New CheckBox()
        Check_Alrm_2 = New CheckBox()
        Check_Alrm_1 = New CheckBox()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        lbl_resn_5 = New Label()
        lbl_resn_4 = New Label()
        lbl_resn_3 = New Label()
        lbl_resn_2 = New Label()
        lbl_resn_1 = New Label()
        lbl_alrm_5 = New Label()
        lbl_alrm_4 = New Label()
        lbl_alrm_3 = New Label()
        lbl_alrm_2 = New Label()
        lbl_alrm_1 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        cmbx_alm_number = New ComboBox()
        Button8 = New Button()
        Button2 = New Button()
        txt_reason = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        Cmbx_sec = New ComboBox()
        Cmbx_min = New ComboBox()
        Cmbx_hr = New ComboBox()
        Label17 = New Label()
        Timer1 = New Timer(components)
        lbl_am_pm = New Label()
        lbl_time = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sylfaen", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(129, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 46)
        Label4.TabIndex = 12
        Label4.Text = "Alarm "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(236, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 46)
        Label5.TabIndex = 13
        Label5.Text = "Alarm "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sylfaen", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(209, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 46)
        Label6.TabIndex = 14
        Label6.Text = "+"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.SteelBlue
        Button4.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(451, 417)
        Button4.Name = "Button4"
        Button4.Size = New Size(131, 47)
        Button4.TabIndex = 23
        Button4.Text = "Stop watch"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.SteelBlue
        Button5.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(314, 417)
        Button5.Name = "Button5"
        Button5.Size = New Size(131, 47)
        Button5.TabIndex = 22
        Button5.Text = "Timer"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.SteelBlue
        Button6.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(177, 417)
        Button6.Name = "Button6"
        Button6.Size = New Size(131, 47)
        Button6.TabIndex = 21
        Button6.Text = "Time"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.SteelBlue
        Button7.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(40, 417)
        Button7.Name = "Button7"
        Button7.Size = New Size(131, 47)
        Button7.TabIndex = 20
        Button7.Text = "Home"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Btn_add
        ' 
        Btn_add.BackColor = Color.SteelBlue
        Btn_add.Enabled = False
        Btn_add.FlatStyle = FlatStyle.Flat
        Btn_add.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_add.Location = New Point(15, 66)
        Btn_add.Name = "Btn_add"
        Btn_add.Size = New Size(153, 55)
        Btn_add.TabIndex = 24
        Btn_add.Text = "ADD"
        Btn_add.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Panel1.Controls.Add(Check_Alrm_5)
        Panel1.Controls.Add(Check_Alrm_4)
        Panel1.Controls.Add(Check_Alrm_3)
        Panel1.Controls.Add(Check_Alrm_2)
        Panel1.Controls.Add(Check_Alrm_1)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(lbl_resn_5)
        Panel1.Controls.Add(lbl_resn_4)
        Panel1.Controls.Add(lbl_resn_3)
        Panel1.Controls.Add(lbl_resn_2)
        Panel1.Controls.Add(lbl_resn_1)
        Panel1.Controls.Add(lbl_alrm_5)
        Panel1.Controls.Add(lbl_alrm_4)
        Panel1.Controls.Add(lbl_alrm_3)
        Panel1.Controls.Add(lbl_alrm_2)
        Panel1.Controls.Add(lbl_alrm_1)
        Panel1.Location = New Point(15, 127)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(589, 284)
        Panel1.TabIndex = 27
        ' 
        ' Check_Alrm_5
        ' 
        Check_Alrm_5.AutoSize = True
        Check_Alrm_5.BackColor = SystemColors.InactiveCaption
        Check_Alrm_5.Font = New Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Check_Alrm_5.Location = New Point(16, 240)
        Check_Alrm_5.Name = "Check_Alrm_5"
        Check_Alrm_5.Size = New Size(171, 31)
        Check_Alrm_5.TabIndex = 22
        Check_Alrm_5.Text = "__ALARM__5"
        Check_Alrm_5.UseVisualStyleBackColor = False
        ' 
        ' Check_Alrm_4
        ' 
        Check_Alrm_4.AutoSize = True
        Check_Alrm_4.BackColor = SystemColors.InactiveCaption
        Check_Alrm_4.Font = New Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Check_Alrm_4.Location = New Point(16, 197)
        Check_Alrm_4.Name = "Check_Alrm_4"
        Check_Alrm_4.Size = New Size(171, 31)
        Check_Alrm_4.TabIndex = 21
        Check_Alrm_4.Text = "__ALARM__4"
        Check_Alrm_4.UseVisualStyleBackColor = False
        ' 
        ' Check_Alrm_3
        ' 
        Check_Alrm_3.AutoSize = True
        Check_Alrm_3.BackColor = SystemColors.InactiveCaption
        Check_Alrm_3.Font = New Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Check_Alrm_3.Location = New Point(16, 157)
        Check_Alrm_3.Name = "Check_Alrm_3"
        Check_Alrm_3.Size = New Size(171, 31)
        Check_Alrm_3.TabIndex = 20
        Check_Alrm_3.Text = "__ALARM__3"
        Check_Alrm_3.UseVisualStyleBackColor = False
        ' 
        ' Check_Alrm_2
        ' 
        Check_Alrm_2.AutoSize = True
        Check_Alrm_2.BackColor = SystemColors.InactiveCaption
        Check_Alrm_2.Font = New Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Check_Alrm_2.Location = New Point(16, 116)
        Check_Alrm_2.Name = "Check_Alrm_2"
        Check_Alrm_2.Size = New Size(171, 31)
        Check_Alrm_2.TabIndex = 19
        Check_Alrm_2.Text = "__ALARM__2"
        Check_Alrm_2.UseVisualStyleBackColor = False
        ' 
        ' Check_Alrm_1
        ' 
        Check_Alrm_1.AutoSize = True
        Check_Alrm_1.BackColor = SystemColors.InactiveCaption
        Check_Alrm_1.Font = New Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Check_Alrm_1.Location = New Point(16, 74)
        Check_Alrm_1.Name = "Check_Alrm_1"
        Check_Alrm_1.Size = New Size(171, 31)
        Check_Alrm_1.TabIndex = 18
        Check_Alrm_1.Text = "__ALARM__1"
        Check_Alrm_1.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = SystemColors.Info
        Label16.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(403, 32)
        Label16.Name = "Label16"
        Label16.Size = New Size(156, 31)
        Label16.TabIndex = 17
        Label16.Text = " : REASON : "
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = SystemColors.Info
        Label15.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(238, 32)
        Label15.Name = "Label15"
        Label15.Size = New Size(118, 31)
        Label15.TabIndex = 16
        Label15.Text = " : TIME : "
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = SystemColors.Info
        Label14.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(16, 32)
        Label14.Name = "Label14"
        Label14.Size = New Size(159, 31)
        Label14.TabIndex = 15
        Label14.Text = " : ALARMS : "
        ' 
        ' lbl_resn_5
        ' 
        lbl_resn_5.AutoSize = True
        lbl_resn_5.BackColor = SystemColors.InactiveCaption
        lbl_resn_5.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_resn_5.Location = New Point(392, 238)
        lbl_resn_5.Name = "lbl_resn_5"
        lbl_resn_5.Size = New Size(182, 31)
        lbl_resn_5.TabIndex = 14
        lbl_resn_5.Text = "                        "
        ' 
        ' lbl_resn_4
        ' 
        lbl_resn_4.AutoSize = True
        lbl_resn_4.BackColor = SystemColors.InactiveCaption
        lbl_resn_4.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_resn_4.Location = New Point(392, 195)
        lbl_resn_4.Name = "lbl_resn_4"
        lbl_resn_4.Size = New Size(182, 31)
        lbl_resn_4.TabIndex = 13
        lbl_resn_4.Text = "                        "
        ' 
        ' lbl_resn_3
        ' 
        lbl_resn_3.AutoSize = True
        lbl_resn_3.BackColor = SystemColors.InactiveCaption
        lbl_resn_3.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_resn_3.Location = New Point(392, 155)
        lbl_resn_3.Name = "lbl_resn_3"
        lbl_resn_3.Size = New Size(182, 31)
        lbl_resn_3.TabIndex = 12
        lbl_resn_3.Text = "                        "
        ' 
        ' lbl_resn_2
        ' 
        lbl_resn_2.AutoSize = True
        lbl_resn_2.BackColor = SystemColors.InactiveCaption
        lbl_resn_2.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_resn_2.Location = New Point(392, 114)
        lbl_resn_2.Name = "lbl_resn_2"
        lbl_resn_2.Size = New Size(182, 31)
        lbl_resn_2.TabIndex = 11
        lbl_resn_2.Text = "                        "
        ' 
        ' lbl_resn_1
        ' 
        lbl_resn_1.AutoSize = True
        lbl_resn_1.BackColor = SystemColors.InactiveCaption
        lbl_resn_1.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_resn_1.Location = New Point(392, 74)
        lbl_resn_1.Name = "lbl_resn_1"
        lbl_resn_1.Size = New Size(182, 31)
        lbl_resn_1.TabIndex = 10
        lbl_resn_1.Text = "                        "
        ' 
        ' lbl_alrm_5
        ' 
        lbl_alrm_5.AutoSize = True
        lbl_alrm_5.BackColor = SystemColors.InactiveCaption
        lbl_alrm_5.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_alrm_5.Location = New Point(210, 238)
        lbl_alrm_5.Name = "lbl_alrm_5"
        lbl_alrm_5.Size = New Size(176, 31)
        lbl_alrm_5.TabIndex = 9
        lbl_alrm_5.Text = "---- : ---- : ----"
        ' 
        ' lbl_alrm_4
        ' 
        lbl_alrm_4.AutoSize = True
        lbl_alrm_4.BackColor = SystemColors.InactiveCaption
        lbl_alrm_4.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_alrm_4.Location = New Point(210, 195)
        lbl_alrm_4.Name = "lbl_alrm_4"
        lbl_alrm_4.Size = New Size(176, 31)
        lbl_alrm_4.TabIndex = 8
        lbl_alrm_4.Text = "---- : ---- : ----"
        ' 
        ' lbl_alrm_3
        ' 
        lbl_alrm_3.AutoSize = True
        lbl_alrm_3.BackColor = SystemColors.InactiveCaption
        lbl_alrm_3.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_alrm_3.Location = New Point(210, 155)
        lbl_alrm_3.Name = "lbl_alrm_3"
        lbl_alrm_3.Size = New Size(176, 31)
        lbl_alrm_3.TabIndex = 7
        lbl_alrm_3.Text = "---- : ---- : ----"
        ' 
        ' lbl_alrm_2
        ' 
        lbl_alrm_2.AutoSize = True
        lbl_alrm_2.BackColor = SystemColors.InactiveCaption
        lbl_alrm_2.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_alrm_2.Location = New Point(210, 114)
        lbl_alrm_2.Name = "lbl_alrm_2"
        lbl_alrm_2.Size = New Size(176, 31)
        lbl_alrm_2.TabIndex = 6
        lbl_alrm_2.Text = "---- : ---- : ----"
        ' 
        ' lbl_alrm_1
        ' 
        lbl_alrm_1.AutoSize = True
        lbl_alrm_1.BackColor = SystemColors.InactiveCaption
        lbl_alrm_1.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_alrm_1.Location = New Point(210, 74)
        lbl_alrm_1.Name = "lbl_alrm_1"
        lbl_alrm_1.Size = New Size(176, 31)
        lbl_alrm_1.TabIndex = 5
        lbl_alrm_1.Text = "---- : ---- : ----"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(cmbx_alm_number)
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(txt_reason)
        Panel2.Controls.Add(Label18)
        Panel2.Controls.Add(Label19)
        Panel2.Controls.Add(Label20)
        Panel2.Controls.Add(Label21)
        Panel2.Controls.Add(Label22)
        Panel2.Controls.Add(Label23)
        Panel2.Controls.Add(Label24)
        Panel2.Controls.Add(Cmbx_sec)
        Panel2.Controls.Add(Cmbx_min)
        Panel2.Controls.Add(Cmbx_hr)
        Panel2.Location = New Point(42, 65)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(540, 366)
        Panel2.TabIndex = 28
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(401, 187)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 22)
        Label1.TabIndex = 32
        Label1.Text = "Alarm number"
        ' 
        ' cmbx_alm_number
        ' 
        cmbx_alm_number.BackColor = Color.SteelBlue
        cmbx_alm_number.Font = New Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        cmbx_alm_number.FormattingEnabled = True
        cmbx_alm_number.Items.AddRange(New Object() {"1", "2", "3", "4", "5", ""})
        cmbx_alm_number.Location = New Point(436, 216)
        cmbx_alm_number.Margin = New Padding(3, 2, 3, 2)
        cmbx_alm_number.Name = "cmbx_alm_number"
        cmbx_alm_number.Size = New Size(51, 26)
        cmbx_alm_number.TabIndex = 31
        cmbx_alm_number.Text = "0"
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.SteelBlue
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.Location = New Point(313, 282)
        Button8.Name = "Button8"
        Button8.Size = New Size(206, 55)
        Button8.TabIndex = 30
        Button8.Text = "Back"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(54, 282)
        Button2.Name = "Button2"
        Button2.Size = New Size(206, 55)
        Button2.TabIndex = 29
        Button2.Text = "Set Alarm"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' txt_reason
        ' 
        txt_reason.Font = New Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_reason.Location = New Point(147, 222)
        txt_reason.Name = "txt_reason"
        txt_reason.Size = New Size(221, 43)
        txt_reason.TabIndex = 28
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = SystemColors.Control
        Label18.Font = New Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(24, 225)
        Label18.Name = "Label18"
        Label18.Size = New Size(117, 35)
        Label18.TabIndex = 27
        Label18.Text = "Reason :"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Sylfaen", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(226, 50)
        Label19.Name = "Label19"
        Label19.Size = New Size(34, 14)
        Label19.TabIndex = 26
        Label19.Text = "Your"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(194, 17)
        Label20.Name = "Label20"
        Label20.Size = New Size(73, 39)
        Label20.TabIndex = 24
        Label20.Text = "Add"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = Color.Transparent
        Label21.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label21.Location = New Point(252, 37)
        Label21.Name = "Label21"
        Label21.Size = New Size(101, 39)
        Label21.TabIndex = 25
        Label21.Text = "Alarm"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.Location = New Point(313, 92)
        Label22.Name = "Label22"
        Label22.Size = New Size(124, 39)
        Label22.TabIndex = 23
        Label22.Text = "Seconds"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label23.Location = New Point(158, 92)
        Label23.Name = "Label23"
        Label23.Size = New Size(129, 39)
        Label23.TabIndex = 22
        Label23.Text = "Minutes"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label24.Location = New Point(20, 92)
        Label24.Name = "Label24"
        Label24.Size = New Size(99, 39)
        Label24.TabIndex = 21
        Label24.Text = "Hours"
        ' 
        ' Cmbx_sec
        ' 
        Cmbx_sec.BackColor = Color.SteelBlue
        Cmbx_sec.Font = New Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Cmbx_sec.FormattingEnabled = True
        Cmbx_sec.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Cmbx_sec.Location = New Point(354, 143)
        Cmbx_sec.Margin = New Padding(3, 2, 3, 2)
        Cmbx_sec.Name = "Cmbx_sec"
        Cmbx_sec.Size = New Size(51, 33)
        Cmbx_sec.TabIndex = 20
        Cmbx_sec.Text = "0"
        ' 
        ' Cmbx_min
        ' 
        Cmbx_min.BackColor = Color.SteelBlue
        Cmbx_min.Font = New Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Cmbx_min.FormattingEnabled = True
        Cmbx_min.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Cmbx_min.Location = New Point(202, 143)
        Cmbx_min.Margin = New Padding(3, 2, 3, 2)
        Cmbx_min.Name = "Cmbx_min"
        Cmbx_min.Size = New Size(51, 33)
        Cmbx_min.TabIndex = 19
        Cmbx_min.Text = "0"
        ' 
        ' Cmbx_hr
        ' 
        Cmbx_hr.BackColor = Color.SteelBlue
        Cmbx_hr.FlatStyle = FlatStyle.Flat
        Cmbx_hr.Font = New Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Cmbx_hr.FormattingEnabled = True
        Cmbx_hr.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Cmbx_hr.Location = New Point(50, 143)
        Cmbx_hr.Margin = New Padding(3, 2, 3, 2)
        Cmbx_hr.Name = "Cmbx_hr"
        Cmbx_hr.Size = New Size(51, 33)
        Cmbx_hr.TabIndex = 18
        Cmbx_hr.Text = "0"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = SystemColors.InactiveCaption
        Label17.Font = New Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(214, 90)
        Label17.Name = "Label17"
        Label17.Size = New Size(157, 31)
        Label17.TabIndex = 18
        Label17.Text = ": Alarm List :"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' lbl_am_pm
        ' 
        lbl_am_pm.AutoSize = True
        lbl_am_pm.BackColor = Color.Transparent
        lbl_am_pm.Font = New Font("Sylfaen", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_am_pm.Location = New Point(570, 48)
        lbl_am_pm.Name = "lbl_am_pm"
        lbl_am_pm.Size = New Size(27, 14)
        lbl_am_pm.TabIndex = 34
        lbl_am_pm.Text = "----"
        ' 
        ' lbl_time
        ' 
        lbl_time.AutoSize = True
        lbl_time.BackColor = Color.Transparent
        lbl_time.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_time.Location = New Point(437, 14)
        lbl_time.Name = "lbl_time"
        lbl_time.Size = New Size(167, 39)
        lbl_time.TabIndex = 33
        lbl_time.Text = "12 : 00 : 00"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ClientSize = New Size(616, 489)
        Controls.Add(lbl_am_pm)
        Controls.Add(Panel2)
        Controls.Add(lbl_time)
        Controls.Add(Panel1)
        Controls.Add(Btn_add)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label17)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Btn_add As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_alrm_5 As Label
    Friend WithEvents lbl_alrm_4 As Label
    Friend WithEvents lbl_alrm_3 As Label
    Friend WithEvents lbl_alrm_2 As Label
    Friend WithEvents lbl_alrm_1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_resn_5 As Label
    Friend WithEvents lbl_resn_4 As Label
    Friend WithEvents lbl_resn_3 As Label
    Friend WithEvents lbl_resn_2 As Label
    Friend WithEvents lbl_resn_1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_reason As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Cmbx_sec As ComboBox
    Friend WithEvents Cmbx_min As ComboBox
    Friend WithEvents Cmbx_hr As ComboBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Check_Alrm_1 As CheckBox
    Friend WithEvents Check_Alrm_5 As CheckBox
    Friend WithEvents Check_Alrm_4 As CheckBox
    Friend WithEvents Check_Alrm_3 As CheckBox
    Friend WithEvents Check_Alrm_2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbx_alm_number As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_am_pm As Label
    Friend WithEvents lbl_time As Label
End Class
