<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Label5 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        lbl_m_sec = New Label()
        lbl_sec = New Label()
        lbl_min = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(285, 45)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 46)
        Label5.TabIndex = 16
        Label5.Text = "Watch"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sylfaen", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(215, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 46)
        Label4.TabIndex = 15
        Label4.Text = "Stop"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(257, 55)
        Label6.Name = "Label6"
        Label6.Size = New Size(38, 22)
        Label6.TabIndex = 17
        Label6.Text = "The"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.SteelBlue
        Button4.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(451, 414)
        Button4.Name = "Button4"
        Button4.Size = New Size(131, 47)
        Button4.TabIndex = 26
        Button4.Text = "Timer"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.SteelBlue
        Button5.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(314, 414)
        Button5.Name = "Button5"
        Button5.Size = New Size(131, 47)
        Button5.TabIndex = 25
        Button5.Text = "Alarm"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.SteelBlue
        Button6.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(177, 414)
        Button6.Name = "Button6"
        Button6.Size = New Size(131, 47)
        Button6.TabIndex = 24
        Button6.Text = "Time"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.SteelBlue
        Button7.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(40, 414)
        Button7.Name = "Button7"
        Button7.Size = New Size(131, 47)
        Button7.TabIndex = 23
        Button7.Text = "Home"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.SteelBlue
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(228, 314)
        Button3.Name = "Button3"
        Button3.Size = New Size(164, 55)
        Button3.TabIndex = 22
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(440, 314)
        Button2.Name = "Button2"
        Button2.Size = New Size(153, 55)
        Button2.TabIndex = 21
        Button2.Text = "Stop"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(29, 314)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 55)
        Button1.TabIndex = 20
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.BackColor = Color.Teal
        Label22.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.Location = New Point(383, 117)
        Label22.Name = "Label22"
        Label22.Size = New Size(194, 39)
        Label22.TabIndex = 29
        Label22.Text = "Mili-Seconds"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.BackColor = Color.Teal
        Label23.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label23.Location = New Point(60, 117)
        Label23.Name = "Label23"
        Label23.Size = New Size(129, 39)
        Label23.TabIndex = 28
        Label23.Text = "Minutes"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.BackColor = Color.Teal
        Label24.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label24.Location = New Point(223, 117)
        Label24.Name = "Label24"
        Label24.Size = New Size(124, 39)
        Label24.TabIndex = 27
        Label24.Text = "Seconds"
        ' 
        ' lbl_m_sec
        ' 
        lbl_m_sec.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        lbl_m_sec.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_m_sec.Location = New Point(383, 178)
        lbl_m_sec.Name = "lbl_m_sec"
        lbl_m_sec.Size = New Size(124, 39)
        lbl_m_sec.TabIndex = 32
        lbl_m_sec.Text = "00"
        lbl_m_sec.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_sec
        ' 
        lbl_sec.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        lbl_sec.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_sec.Location = New Point(228, 178)
        lbl_sec.Name = "lbl_sec"
        lbl_sec.Size = New Size(129, 39)
        lbl_sec.TabIndex = 31
        lbl_sec.Text = "00"
        lbl_sec.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_min
        ' 
        lbl_min.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        lbl_min.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_min.Location = New Point(90, 178)
        lbl_min.Name = "lbl_min"
        lbl_min.Size = New Size(99, 39)
        lbl_min.TabIndex = 30
        lbl_min.Text = "00"
        lbl_min.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label7.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(188, 178)
        Label7.Name = "Label7"
        Label7.Size = New Size(44, 39)
        Label7.TabIndex = 33
        Label7.Text = " : "
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label8.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(348, 178)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 39)
        Label8.TabIndex = 34
        Label8.Text = " : "
        ' 
        ' Timer1
        ' 
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ClientSize = New Size(616, 489)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(lbl_m_sec)
        Controls.Add(lbl_sec)
        Controls.Add(lbl_min)
        Controls.Add(Label22)
        Controls.Add(Label23)
        Controls.Add(Label24)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lbl_m_sec As Label
    Friend WithEvents lbl_sec As Label
    Friend WithEvents lbl_min As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
End Class
