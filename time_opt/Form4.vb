Imports System
Imports System.Media
Public Class Form4
    Private hr1 As Integer
    Private min1 As Integer
    Private sec1 As Integer
    Private reason1 As String
    Private hr2 As Integer
    Private min2 As Integer
    Private sec2 As Integer
    Private reason2 As String
    Private hr3 As Integer
    Private min3 As Integer
    Private sec3 As Integer
    Private reason3 As String
    Private hr4 As Integer
    Private min4 As Integer
    Private sec4 As Integer
    Private reason4 As String
    Private hr5 As Integer
    Private min5 As Integer
    Private sec5 As Integer
    Private reason5 As String
    Dim al_song As New SoundPlayer("C:/Users/JARVIS/Downloads/wake_up.wav")
    Dim currentdatetime As DateTime = DateTime.Now
    Dim currentHour As Integer = currentdatetime.Hour
    Dim currentminute As Integer = currentdatetime.Minute
    Dim currentsecond As Integer = currentdatetime.Second

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        Panel2.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Hide()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel2.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer = cmbx_alm_number.Text

        Select Case i
            Case 1
                hr1 = Cmbx_hr.Text
                sec1 = Cmbx_sec.Text
                min1 = Cmbx_min.Text
                reason1 = txt_reason.Text
                lbl_alrm_1.Text = (hr1 & " : " & min1 & " : " & sec1)
                lbl_resn_1.Text = reason1



            Case 2
                hr2 = Cmbx_hr.Text
                sec2 = Cmbx_sec.Text
                min2 = Cmbx_min.Text
                reason2 = txt_reason.Text
                lbl_alrm_2.Text = (hr2 & " : " & min2 & " : " & sec2)
                lbl_resn_2.Text = reason2


            Case 3
                hr3 = Cmbx_hr.Text
                sec3 = Cmbx_sec.Text
                min3 = Cmbx_min.Text
                reason3 = txt_reason.Text
                lbl_alrm_3.Text = (hr3 & " : " & min3 & " : " & sec3)
                lbl_resn_3.Text = reason3


            Case 4
                hr4 = Cmbx_hr.Text
                sec4 = Cmbx_sec.Text
                min4 = Cmbx_min.Text
                reason4 = txt_reason.Text
                lbl_alrm_4.Text = (hr4 & " : " & min4 & " : " & sec4)
                lbl_resn_4.Text = reason4


            Case 5
                hr5 = Cmbx_hr.Text
                sec5 = Cmbx_sec.Text
                min5 = Cmbx_min.Text
                reason5 = txt_reason.Text
                lbl_alrm_5.Text = (hr5 & " : " & min5 & " : " & sec5)
                lbl_resn_5.Text = reason5


            Case Else
                MsgBox("Some thing is missing ")
        End Select
        Panel2.Hide()
    End Sub
    Private Sub Check_Alrm_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Alrm_1.CheckedChanged
        If Check_Alrm_1.Checked = True Then
            Btn_add.Enabled = True
            cmbx_alm_number.Text = 1

        Else
            Btn_add.Enabled = False
            lbl_alrm_1.Text = "---- : ---- : ----"
            lbl_resn_1.Text = "                        "
            cmbx_alm_number.Text = "0"
        End If
    End Sub

    Private Sub Check_Alrm_2_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Alrm_2.CheckedChanged
        If Check_Alrm_2.Checked = True Then
            Btn_add.Enabled = True
            cmbx_alm_number.Text = 2
        Else
            Btn_add.Enabled = False
            lbl_alrm_2.Text = "---- : ---- : ----"
            lbl_resn_2.Text = "                        "
            cmbx_alm_number.Text = "0"
        End If
    End Sub

    Private Sub Check_Alrm_3_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Alrm_3.CheckedChanged
        If Check_Alrm_3.Checked = True Then
            Btn_add.Enabled = True
            cmbx_alm_number.Text = 3
        Else
            Btn_add.Enabled = False
            lbl_alrm_3.Text = "---- : ---- : ----"
            lbl_resn_3.Text = "                        "
            cmbx_alm_number.Text = "0"
        End If
    End Sub

    Private Sub Check_Alrm_4_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Alrm_4.CheckedChanged
        If Check_Alrm_4.Checked = True Then
            Btn_add.Enabled = True
            cmbx_alm_number.Text = 4
        Else
            Btn_add.Enabled = False
            lbl_alrm_4.Text = "---- : ---- : ----"
            lbl_resn_4.Text = "                        "
            cmbx_alm_number.Text = "0"
        End If
    End Sub

    Private Sub Check_Alrm_5_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Alrm_5.CheckedChanged
        If Check_Alrm_5.Checked = True Then
            Btn_add.Enabled = True
            cmbx_alm_number.Text = 5
        Else
            Btn_add.Enabled = False
            lbl_alrm_5.Text = "---- : ---- : ----"
            lbl_resn_5.Text = "                        "
            cmbx_alm_number.Text = "0"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = DateAndTime.Now.ToString(" HH : mm : ss ")
        lbl_am_pm.Text = DateAndTime.Now.ToString("tt")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class