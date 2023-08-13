Public Class Form3
    'Private countdownvalue As Integer = 10 'starting value

    Private hr As Integer = 0
    Private sec As Integer = 0
    Private min As Integer = 0
    Private n As Integer = 0

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Interval = 1


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Cmbx_sec.Text = "0" Then
            If sec > 0 Then
                sec -= 1
                lbl_sec.Text = sec.ToString
                lbl_min.Text = min.ToString
                lbl_hr.Text = hr.ToString
                If sec = 0 Then
                    min -= 1

                    lbl_min.Text = min.ToString
                    lbl_hr.Text = hr.ToString
                    If min = 0 Then
                        hr -= 1

                        lbl_hr.Text = hr.ToString

                        min = 60
                    End If
                    sec = 60
                End If


            End If
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        hr = Cmbx_hr.Text
        min = Cmbx_min.Text
        sec = Cmbx_sec.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        Cmbx_hr.Text = 0
        Cmbx_min.Text = 0
        Cmbx_sec.Text = 0
        lbl_hr.Text = 0
        lbl_min.Text = 0
        lbl_sec.Text = 0
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
        Form5.Show()
    End Sub
End Class