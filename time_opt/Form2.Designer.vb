<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lbl_time = New Label()
        lbl_date = New Label()
        lbl_Am_pm = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' lbl_time
        ' 
        lbl_time.AutoSize = True
        lbl_time.Font = New Font("Sylfaen", 48F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_time.Location = New Point(48, 141)
        lbl_time.Name = "lbl_time"
        lbl_time.Size = New Size(335, 84)
        lbl_time.TabIndex = 0
        lbl_time.Text = "12 : 00 : 00"
        ' 
        ' lbl_date
        ' 
        lbl_date.AutoSize = True
        lbl_date.Font = New Font("Sylfaen", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_date.Location = New Point(77, 235)
        lbl_date.Name = "lbl_date"
        lbl_date.Size = New Size(212, 50)
        lbl_date.TabIndex = 1
        lbl_date.Text = "12 / 00 / 00"
        ' 
        ' lbl_Am_pm
        ' 
        lbl_Am_pm.AutoSize = True
        lbl_Am_pm.Font = New Font("Sylfaen", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_Am_pm.Location = New Point(316, 235)
        lbl_Am_pm.Name = "lbl_Am_pm"
        lbl_Am_pm.Size = New Size(82, 50)
        lbl_Am_pm.TabIndex = 2
        lbl_Am_pm.Text = "----"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sylfaen", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(122, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(333, 84)
        Label4.TabIndex = 3
        Label4.Text = "Time Zone"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sylfaen", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(287, 102)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 39)
        Label6.TabIndex = 9
        Label6.Text = "24 Hours"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(389, 136)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 25)
        Label7.TabIndex = 10
        Label7.Text = "Format"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(271, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(23, 19)
        Label1.TabIndex = 11
        Label1.Text = "In"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(12, 306)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 47)
        Button1.TabIndex = 12
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(158, 306)
        Button2.Name = "Button2"
        Button2.Size = New Size(131, 47)
        Button2.TabIndex = 13
        Button2.Text = "Timer"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.SteelBlue
        Button3.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(308, 306)
        Button3.Name = "Button3"
        Button3.Size = New Size(131, 47)
        Button3.TabIndex = 14
        Button3.Text = "Alarm"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.SteelBlue
        Button4.Font = New Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(457, 306)
        Button4.Name = "Button4"
        Button4.Size = New Size(131, 47)
        Button4.TabIndex = 15
        Button4.Text = "Stop watch"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ClientSize = New Size(600, 375)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(lbl_Am_pm)
        Controls.Add(lbl_date)
        Controls.Add(lbl_time)
        ForeColor = SystemColors.ControlText
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_Am_pm As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
