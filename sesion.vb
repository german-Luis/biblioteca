Public Class sesion
    Dim iniciar As Integer = 0
    Private Sub sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (iniciar = 1) Then
            ProgressBar1.Increment(30)
            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                Me.Hide()
                MenuPrincipal.Show()
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        iniciar = 1

            MsgBox("El usuario o contraseña son incorrectos!.")
            TextBox1.Text = ""
            TextBox2.Text = ""


    End Sub
End Class