<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Timer1 = New Timer(components)
        Cmbx_hr = New ComboBox()
        Cmbx_min = New ComboBox()
        Cmbx_sec = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lbl_hr = New Label()
        lbl_min = New Label()
        lbl_sec = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Cmbx_hr
        ' 
        Cmbx_hr.BackColor = Color.SteelBlue
        Cmbx_hr.FlatStyle = FlatStyle.Flat
        Cmbx_hr.Font = New Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Cmbx_hr.FormattingEnabled = True
        Cmbx_hr.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Cmbx_hr.Location = New Point(84, 91)
        Cmbx_hr.Margin = New Padding(3, 2, 3, 2)
        Cmbx_hr.Name = "Cmbx_hr"
        Cmbx_hr.Size = New Size(51, 33)
        Cmbx_hr.TabIndex = 0
        Cmbx_hr.Text = "0"
        ' 
        ' Cmbx_min
        ' 
        Cmbx_min.BackColor = Color.SteelBlue
        Cmbx_min.Font = New Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Cmbx_min.FormattingEnabled = True
        Cmbx_min.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Cmbx_min.Location = New Point(272, 91)
        Cmbx_min.Margin = New Padding(3, 2, 3, 2)
        Cmbx_min.Name = "Cmbx_min"
        Cmbx_min.Size = New Size(51, 33)
        Cmbx_min.TabIndex = 1
        Cmbx_min.Text = "0"
        ' 
        ' Cmbx_sec
        ' 
        Cmbx_sec.BackColor = Color.SteelBlue
        Cmbx_sec.Font = New Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Cmbx_sec.FormattingEnabled = True
        Cmbx_sec.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Cmbx_sec.Location = New Point(474, 91)
        Cmbx_sec.Margin = New Padding(3, 2, 3, 2)
        Cmbx_sec.Name = "Cmbx_sec"
        Cmbx_sec.Size = New Size(51, 33)
        Cmbx_sec.TabIndex = 2
        Cmbx_sec.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(54, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 39)
        Label1.TabIndex = 3
        Label1.Text = "Hours"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(228, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 39)
        Label2.TabIndex = 4
        Label2.Text = "Minutes"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(433, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 39)
        Label3.TabIndex = 5
        Label3.Text = "Seconds"
        ' 
        ' lbl_hr
        ' 
        lbl_hr.AutoSize = True
        lbl_hr.Font = New Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_hr.Location = New Point(153, 148)
        lbl_hr.Name = "lbl_hr"
        lbl_hr.Size = New Size(64, 48)
        lbl_hr.TabIndex = 6
        lbl_hr.Text = "00"
        ' 
        ' lbl_min
        ' 
        lbl_min.AutoSize = True
        lbl_min.Font = New Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_min.Location = New Point(259, 148)
        lbl_min.Name = "lbl_min"
        lbl_min.Size = New Size(64, 48)
        lbl_min.TabIndex = 7
        lbl_min.Text = "00"
        ' 
        ' lbl_sec
        ' 
        lbl_sec.AutoSize = True
        lbl_sec.Font = New Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_sec.Location = New Point(369, 148)
        lbl_sec.Name = "lbl_sec"
        lbl_sec.Size = New Size(64, 48)
        lbl_sec.TabIndex = 8
        lbl_sec.Text = "00"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(330, 148)
        Label7.Name = "Label7"
        Label7.Size = New Size(33, 48)
        Label7.TabIndex = 9
        Label7.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(224, 148)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 48)
        Label8.TabIndex = 10
        Label8.Text = ":"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(25, 278)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 55)
        Button1.TabIndex = 11
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(436, 278)
        Button2.Name = "Button2"
        Button2.Size = New Size(153, 55)
        Button2.TabIndex = 12
        Button2.Text = "Stop"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.SteelBlue
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(224, 278)
        Button3.Name = "Button3"
        Button3.Size = New Size(164, 55)
        Button3.TabIndex = 13
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.SteelBlue
        Button4.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(447, 378)
        Button4.Name = "Button4"
        Button4.Size = New Size(131, 47)
        Button4.TabIndex = 19
        Button4.Text = "Stop watch"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.SteelBlue
        Button5.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(310, 378)
        Button5.Name = "Button5"
        Button5.Size = New Size(131, 47)
        Button5.TabIndex = 18
        Button5.Text = "Alarm"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.SteelBlue
        Button6.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(173, 378)
        Button6.Name = "Button6"
        Button6.Size = New Size(131, 47)
        Button6.TabIndex = 17
        Button6.Text = "Time"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.SteelBlue
        Button7.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(36, 378)
        Button7.Name = "Button7"
        Button7.Size = New Size(131, 47)
        Button7.TabIndex = 16
        Button7.Text = "Home"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(36, 213)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(542, 17)
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.TabIndex = 20
        ProgressBar1.Value = 100
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ClientSize = New Size(616, 467)
        Controls.Add(ProgressBar1)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(lbl_sec)
        Controls.Add(lbl_min)
        Controls.Add(lbl_hr)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Cmbx_sec)
        Controls.Add(Cmbx_min)
        Controls.Add(Cmbx_hr)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Cmbx_hr As ComboBox
    Friend WithEvents Cmbx_min As ComboBox
    Friend WithEvents Cmbx_sec As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_hr As Label
    Friend WithEvents lbl_min As Label
    Friend WithEvents lbl_sec As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
