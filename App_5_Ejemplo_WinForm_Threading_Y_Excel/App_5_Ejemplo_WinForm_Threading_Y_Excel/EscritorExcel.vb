Public Class EscritorExcel

    Private _excelObj As Object

    Public Shared Sub NuevoExcelFijo(nombreFichero As String)
        Dim oExcel As Object
        Dim oLibro As Object
        Dim oHoja As Object
        ' Creamos un objeto cuyo contenido es una instancia de Excel
        oExcel = CreateObject("Excel.Application")
        ' Comenzar nuevo libro de Excel
        oLibro = oExcel.Workbooks.Add
        oHoja = oLibro.Worksheets(1)

        Dim ArrayDatos(99, 2) As String
        Dim r As Integer
        For r = 0 To 99
            ArrayDatos(r, 0) = "FACTURA_" & Format(r, "0000")
            ArrayDatos(r, 1) = Rnd() * 1000
            ArrayDatos(r, 2) = ArrayDatos(r, 1) * 0.21
        Next
        oHoja.Range("A1:C1").Value = New String() {"ID FACTURA", "Precio", "I.V.A."}
        oHoja.Range("A2").Resize(100, 3).Value = ArrayDatos

        ' Guardar el libro y salir de Excel
        oLibro.SaveAs(nombreFichero)
        oExcel.Quit()
    End Sub
    Public Shared Sub NuevoExcelFijo_2(nombreFichero As String)
        Dim oExcel As Object
        Dim oLibro As Object
        Dim oHoja As Object
        ' Creamos un objeto cuyo contenido es una
        ' instancia de Excel
        oExcel = CreateObject("Excel.Application")
        ' Comenzar nuevo libro de Excel
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
