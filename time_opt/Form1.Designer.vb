<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Btn_alarm = New Button()
        Btn_StopWatch = New Button()
        Btn_time = New Button()
        Btn_timer = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Btn_alarm
        ' 
        Btn_alarm.BackColor = Color.SteelBlue
        Btn_alarm.BackgroundImage = CType(resources.GetObject("Btn_alarm.BackgroundImage"), Image)
        Btn_alarm.BackgroundImageLayout = ImageLayout.Zoom
        Btn_alarm.Font = New Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_alarm.ForeColor = Color.White
        Btn_alarm.Location = New Point(169, 297)
        Btn_alarm.Name = "Btn_alarm"
        Btn_alarm.Size = New Size(141, 137)
        Btn_alarm.TabIndex = 0
        Btn_alarm.Text = "Alram"
        Btn_alarm.TextAlign = ContentAlignment.BottomCenter
        Btn_alarm.TextImageRelation = TextImageRelation.TextBeforeImage
        Btn_alarm.UseVisualStyleBackColor = False
        ' 
        ' Btn_StopWatch
        ' 
        Btn_StopWatch.BackColor = Color.SteelBlue
        Btn_StopWatch.BackgroundImage = CType(resources.GetObject("Btn_StopWatch.BackgroundImage"), Image)
        Btn_StopWatch.BackgroundImageLayout = ImageLayout.Zoom
        Btn_StopWatch.Font = New Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_StopWatch.ForeColor = Color.White
        Btn_StopWatch.Location = New Point(354, 297)
        Btn_StopWatch.Name = "Btn_StopWatch"
        Btn_StopWatch.Size = New Size(146, 137)
        Btn_StopWatch.TabIndex = 1
        Btn_StopWatch.Text = "Stop Watch"
        Btn_StopWatch.TextAlign = ContentAlignment.BottomCenter
        Btn_StopWatch.TextImageRelation = TextImageRelation.TextBeforeImage
        Btn_StopWatch.UseVisualStyleBackColor = False
        ' 
        ' Btn_time
        ' 
        Btn_time.BackColor = Color.SteelBlue
        Btn_time.BackgroundImage = CType(resources.GetObject("Btn_time.BackgroundImage"), Image)
        Btn_time.BackgroundImageLayout = ImageLayout.Zoom
        Btn_time.Font = New Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_time.ForeColor = Color.White
        Btn_time.Location = New Point(169, 137)
        Btn_time.Name = "Btn_time"
        Btn_time.Size = New Size(148, 138)
        Btn_time.TabIndex = 2
        Btn_time.Text = "Time"
        Btn_time.TextAlign = ContentAlignment.BottomCenter
        Btn_time.TextImageRelation = TextImageRelation.TextBeforeImage
        Btn_time.UseVisualStyleBackColor = False
        ' 
        ' Btn_timer
        ' 
        Btn_timer.BackColor = Color.SteelBlue
        Btn_timer.BackgroundImage = CType(resources.GetObject("Btn_timer.BackgroundImage"), Image)
        Btn_timer.BackgroundImageLayout = ImageLayout.Zoom
        Btn_timer.Font = New Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_timer.ForeColor = Color.White
        Btn_timer.Location = New Point(352, 137)
        Btn_timer.Name = "Btn_timer"
        Btn_timer.Size = New Size(148, 138)
        Btn_timer.TabIndex = 3
        Btn_timer.Text = "Timer"
        Btn_timer.TextAlign = ContentAlignment.BottomCenter
        Btn_timer.TextImageRelation = TextImageRelation.TextBeforeImage
        Btn_timer.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SimSun", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(126, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 48)
        Label1.TabIndex = 4
        Label1.Text = "Clock"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("SimSun", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(288, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 48)
        Label2.TabIndex = 5
        Label2.Text = "Machine"
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSize = True
        BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ClientSize = New Size(616, 489)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Btn_timer)
        Controls.Add(Btn_time)
        Controls.Add(Btn_StopWatch)
        Controls.Add(Btn_alarm)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_alarm As Button
    Friend WithEvents Btn_StopWatch As Button
    Friend WithEvents Btn_time As Button
    Friend WithEvents Btn_timer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
