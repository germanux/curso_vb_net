Namespace Modelo
    Module Constantes
        Public Const CADENA_CONEX_EXCEL As String = "Provider=Microsoft.ACE.OLEDB.12.0;" &
            "Extended Properties='Excel 12.0 Xml;HDR=No';" &
            "Data Source="
        Public Const CADENA_CONEX_ACCESS As String = "Provider=Microsoft.Jet.OLEDB.4.0;" _
            & "Data Source=" ' Justo despues tiene que ir el nombre del fichero
    End Module
End Namespace