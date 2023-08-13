Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btn_time_Click(sender As Object, e As EventArgs) Handles Btn_time.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Btn_timer_Click(sender As Object, e As EventArgs) Handles Btn_timer.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Btn_alarm_Click(sender As Object, e As EventArgs) Handles Btn_alarm.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Btn_StopWatch_Click(sender As Object, e As EventArgs) Handles Btn_StopWatch.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class
