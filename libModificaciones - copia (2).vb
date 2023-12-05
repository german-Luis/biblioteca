Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class libModificaciones
    Dim cadena As String
    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged
        Label7.Text = Label7.Text + DomainUpDown1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aux As FileStream
        aux = File.Create("C:\Users\gcruz\source\repos\examen\aux.txt")
        aux.Close()
        Dim escribir As New StreamWriter("C:\Users\gcruz\source\repos\examen\aux.txt", True)
        Dim leer As New StreamReader("C:\Users\gcruz\source\repos\examen\libros.txt")

        Dim datos As String = TextBox2.Text + "/" + TextBox3.Text + "/" + TextBox4.Text + "/" + TextBox5.Text + "/"
        While leer.Peek <> -1
            Dim linea As String = leer.ReadLine()
            If linea = cadena Then
                escribir.WriteLine(datos)
            Else
                escribir.WriteLine(linea)
            End If


        End While
        leer.Close()
        escribir.Close()
        My.Computer.FileSystem.DeleteFile("C:\Users\gcruz\source\repos\examen\libros.txt")
        My.Computer.FileSystem.RenameFile("C:\Users\gcruz\source\repos\examen\aux.txt", "libros.txt")

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim leer As New StreamReader("C:\Users\gcruz\source\repos\examen\libros.txt")



        While leer.Peek <> -1
            Dim registro(6) As String
            Dim linea As String = leer.ReadLine()
            Dim palabra As String = ""
            Dim comparacion As String = "/"
            Dim a As Integer = 0
            If String.IsNullOrEmpty(linea) Then
                Continue While
            End If
            For i As Integer = 0 To linea.Length - 1

                If linea(i).ToString = comparacion Then
                    registro(a) = palabra
                    a = a + 1
                    palabra = ""
                Else
                    palabra += linea(i)
                End If
            Next
            If (registro(0) = TextBox1.Text) Then
                TextBox2.Text = registro(0)
                TextBox3.Text = registro(1)
                TextBox4.Text = registro(2)
                TextBox5.Text = registro(3)

            End If
        End While
        leer.Close()

        cadena = TextBox2.Text + "/" + TextBox3.Text + "/" + +TextBox4.Text + "/" + TextBox5.Text + "/"
    End Sub
End Class