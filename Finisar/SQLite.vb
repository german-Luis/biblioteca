Namespace Finisar
    Friend Class SQLite
        Friend Class SQLiteConnection
            Friend ConnectionString As String

            Friend Sub Open()
                Throw New NotImplementedException()
            End Sub

            Friend Sub close()
                Throw New NotImplementedException()
            End Sub
        End Class

        Friend Class SQLiteDataAdapter
            Private v As String
            Private conecion As SQLiteConnection

            Public Sub New(v As String, conecion As SQLiteConnection)
                Me.v = v
                Me.conecion = conecion
            End Sub

            Friend Sub Fill(ds As DataSet)
                Throw New NotImplementedException()
            End Sub
        End Class
    End Class
End Namespace
