Public Class Form5

    Private min As Integer = 0
    Private sec As Integer = 0
    Private m_sec As Integer = 0
    Dim i As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer1.Start()
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Timer1.Enabled = False
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
        Form4.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = i
        m_sec += 1
        lbl_m_sec.Text = m_sec.ToString()
        If m_sec > 100 Then
            sec += 1
            lbl_sec.Text = sec.ToString
            If sec > 60 Then
                min += 1
                lbl_min.Text = min.ToString
                If min > 60 Then
                    min = 0
                End If
                sec = 0
            End If
            m_sec = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lbl_min.Text = "00"
        lbl_sec.Text = "00"
        lbl_m_sec.Text = "00"
    End Sub
End Class