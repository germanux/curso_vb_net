Public Class EscritorExcel

    Private _excelObj As Object

    Public Shared Sub NuevoExcelFijo(nombreFichero As String)
        Dim oExcel As Object
        Dim oLibro As Object
        Dim oHoja As Object
        ' Comenzar nuevo libro de Excel
        oExcel = CreateObject("Excel.Application")
        oLibro = oExcel.Workbooks.Add
        ' Añadimos datos a la primera hoja del nuevo libro de Excel,
        ' En las 4 primeras celdas, poniendo en negrita las cabeceras
        oHoja = oLibro.Worksheets(1)
        oHoja.Range("A1").Value = "Nombre de pila"
        oHoja.Range("B1").Value = "Apellidos"
        oHoja.Range("A1:B1").Font.Bold = True
        oHoja.Range("A2").value = "Germán"
        oHoja.Range("B2").value = "Caballero Rodriguez"
        ' Guardar el libro y salir de Excel
        oLibro.SaveAs(nombreFichero)
        oExcel.Quit()
    End Sub
End Class
