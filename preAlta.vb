Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class preAlta
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        MenuPrincipal.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim escribir As New StreamWriter("C:\Users\gcruz\source\repos\examen\prestamos.txt", True)
        escribir.WriteLine(TextBox1.Text + "/" + TextBox2.Text + "/" + TextBox3.Text + "/" + TextBox4.Text + "/" + TextBox5.Text + "/" + TextBox6.Text + "/" + TextBox7.Text + "/" + TextBox8.Text + "/" + TextBox9.Text + "/")
        escribir.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub preAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class