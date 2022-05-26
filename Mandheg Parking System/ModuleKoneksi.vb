Imports System.Data.SqlClient
Module ModuleKoneksi
    Public Conn As SqlConnection
    Public Das As DataSet
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public MyDB As String

    Sub Koneksi()
        MyDB = "Data Source=BAGAS\SQLEXPRESS;Initial Catalog=Laundry;Integrated Security=true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

End Module
