Module Conexiones
    Public Conexion As OleDb.OleDbConnection

    Public Sub AbrirConexion()
        Conexion = New OleDb.OleDbConnection
        Conexion.ConnectionString = "Provider=Microsoft.JET.Oledb.4.0;Data Source=basedatos.mdb;"
        Conexion.Open()

    End Sub

End Module
