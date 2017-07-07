Imports System.Data.OleDb

Public Class LectorExcel
    Public Shared Function DameValorCelda(
               nombreFichero As String,
               hoja As String,
               columna As String,
               fila As Integer) As String

        If (Not (IO.File.Exists(nombreFichero))) Then
            Throw New IO.FileNotFoundException("No existe el archivo de Excel indicado")
        End If
        If (String.IsNullOrEmpty(hoja) OrElse
            String.IsNullOrEmpty(columna) OrElse
           fila < 1 OrElse fila > 65536) Then
            Throw New ArgumentException("Argumentos/valores no válidos")
        End If
        Dim cadenaConexion As String =
            "Provider=Microsoft.ACE.OLEDB.12.0;" &
            "Extended Properties='Excel 12.0 Xml;HDR=No';" &
            "Data Source=" & nombreFichero
        ' Configurar la conexión
        Using conex As New OleDbConnection(cadenaConexion)
            ' Creamos un objeto Command
            Dim cmd As OleDbCommand = conex.CreateCommand()
            Dim celda As String = columna & fila
            ' Formatear la consulta SQL
            cmd.CommandText = String.Format(
                "SELECT F1 FROM [{0}${1}:{2}]", hoja, celda, celda)

            MessageBox.Show(cmd.CommandText)
            ' Abrir la consexion
            conex.Open()
            ' Ejecutar la consulta SQL
            Dim valor As Object = cmd.ExecuteScalar()
            ' Devolver el valor convertido a String
            Return Convert.ToString(valor)
        End Using
    End Function
End Class
