Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) _
                                                                      As Short
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If GetAsyncKeyState(Keys.F12) Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            Button2.PerformClick()
        End If

        If GetAsyncKeyState(Keys.F11) Then
            Button1.PerformClick()
            Me.Hide()
        End If

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Start()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim text = "The application was unable to start corectly (0xc000007b). Click OK to close the application"
        If (TextBox1.Text = "") Then
            MsgBox(text, MsgBoxStyle.Critical, "explorer.exe - Application Error")
        Else
            MsgBox(TextBox1.Text, MsgBoxStyle.Critical, "explorer.exe - Application Error")

        End If
        Dim rand As New Random
        Timer2.Interval = rand.Next("9000", "29000")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
