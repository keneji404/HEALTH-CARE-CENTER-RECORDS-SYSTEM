Imports MySql.Data.MySqlClient

Public Class MYDB_CONNECTION

    Private ReadOnly dbConnection As New MySqlConnection("server='localhost';user='root';password='';port='3306';database='healthcenter';Integrated security='SSPI';")

    ReadOnly Property GetConnection() As MySqlConnection
        Get

            Return dbConnection

        End Get
    End Property

    Sub OpenConnection()

        If dbConnection.State = ConnectionState.Closed Then

            dbConnection.Open()

        End If
    End Sub

    Sub ClosedConnection()

        If dbConnection.State = ConnectionState.Open Then

            dbConnection.Close()

        End If
    End Sub
End Class
Public Class Class1

End Class
