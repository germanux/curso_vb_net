Imports System.Data.OleDb
Imports System.Data.Common

Namespace Modelo
    Public Class EmpleadosDataSetCRUD
        Implements IEmpleadosCRUD

        Private cadena_conexion As String
        Public avisarEnModicacion As TipoDelAvisarEnModificacion
        Private adaptadorBD As OleDbDataAdapter
        Private dataSet As DataSet
        Private tablaEmpleados As DataTable

        Public Sub Restaurar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Restaurar

            cadena_conexion = CrearCadenaConexion(PROVEEDOR_ACCESS, persistenciaEmpleados.nombreFichero)
            adaptadorBD = New OleDbDataAdapter()
            dataSet = New DataSet()
            Dim consultaSQL = "SELECT Id, Nombre, Apellidos, Genero, Categoria, Retribucion_Fija " _
                    & " FROM Empleado  ORDER BY Nombre, Apellidos ASC; "
            Dim comandoSelect = ComandoConConexion(cadena_conexion, consultaSQL)
            adaptadorBD.SelectCommand = comandoSelect

            Dim mapeoTabla As New DataTableMapping("Empleado", "TablaEmpleados")
            mapeoTabla.ColumnMappings.Add(New DataColumnMapping("Nombre", "Nombre"))
            mapeoTabla.ColumnMappings.Add(New DataColumnMapping("Apellidos", "Apellidos"))
            mapeoTabla.ColumnMappings.Add(New DataColumnMapping("Genero", "Genero"))
            mapeoTabla.ColumnMappings.Add(New DataColumnMapping("Categoria", "Categoria"))
            mapeoTabla.ColumnMappings.Add(New DataColumnMapping("Retribucion_Fija", "Retribucion_Fija"))

            adaptadorBD.TableMappings.Add(mapeoTabla)

            adaptadorBD.FillSchema(dataSet, SchemaType.Mapped)
            Dim numFilas As Integer = adaptadorBD.Fill(dataSet, "TablaEmpleados") ' Table1

            tablaEmpleados = dataSet.Tables("TablaEmpleados")
            Dim strMensaje = "Numero de filas: " & numFilas &
                            ", número de columnas: " & dataSet.Tables("TablaEmpleados").Columns.Count &
                            vbCrLf
            For Each columna As DataColumn In tablaEmpleados.Columns
                strMensaje &= ", columna " & columna.ColumnName & " (" & columna.DataType.ToString() & ") "
            Next
            MessageBox.Show(strMensaje)
            comandoSelect.Cerrar()
        End Sub

        Public Sub Grabar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Grabar
            persistenciaEmpleados.Exportar(BuscarEmpleados("", "").ToArray())
            avisarEnModicacion(True)
        End Sub


        Public ReadOnly Property Cantidad As Integer Implements IEmpleadosCRUD.Cantidad
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Public Sub Actualizar(empleado As Empleado, empleadoModif As Empleado) Implements IEmpleadosCRUD.Actualizar
            Throw New NotImplementedException()
        End Sub

        Public Sub Crear(nuevoEmpleado As Empleado) Implements IEmpleadosCRUD.Crear

            Dim nuevoRegistro As DataRow = tablaEmpleados.NewRow()
            ' nuevoRegistro(0) ES EL ID
            'nuevoRegistro(0) = 0
            nuevoRegistro(1) = nuevoEmpleado.nombre
            nuevoRegistro(2) = nuevoEmpleado.apellidos
            nuevoRegistro(3) = nuevoEmpleado.genero
            nuevoRegistro(4) = nuevoEmpleado.categoria
            nuevoRegistro(5) = nuevoEmpleado.retribucionFija
            tablaEmpleados.Rows.Add(nuevoRegistro)
        End Sub

        Public Sub Eliminar(empleados As List(Of Empleado)) Implements IEmpleadosCRUD.Eliminar
            Throw New NotImplementedException()
        End Sub

        Public Sub Eliminar(empleado As Empleado) Implements IEmpleadosCRUD.Eliminar
            Throw New NotImplementedException()
        End Sub

        Public Sub EstablecerAvisarEnModificacion(funcionDelegada As TipoDelAvisarEnModificacion) Implements IEmpleadosCRUD.EstablecerAvisarEnModificacion
            avisarEnModicacion = funcionDelegada
        End Sub

        Public Function BuscarEmpleados(nombre As String, apellidos As String) As List(Of Empleado) Implements IEmpleadosCRUD.BuscarEmpleados
            If nombre = "" And apellidos = "" Then
                Return TodosEmpleados()
            Else
                Return FiltroEmpleados(nombre, apellidos) ' Luego lo cambiamos
            End If
        End Function
        Function TodosEmpleados() As List(Of Empleado)
            TodosEmpleados = New List(Of Empleado)
            Dim lectorTabla As DataTableReader = tablaEmpleados.CreateDataReader()

            While lectorTabla.Read()
                Dim nuevoEmpleado As New Empleado()
                nuevoEmpleado.nombre = CType(lectorTabla("nombre"), String)
                nuevoEmpleado.apellidos = lectorTabla("apellidos")
                nuevoEmpleado.genero = CType(lectorTabla("genero"), TipoGenero)
                nuevoEmpleado.categoria = CType(lectorTabla("categoria"), TipoCategoria)
                nuevoEmpleado.retribucionFija = CType(lectorTabla("Retribucion_Fija"), Single)

                TodosEmpleados.Add(nuevoEmpleado)
            End While
        End Function
        Function FiltroEmpleados(nombre As String, apellidos As String) As List(Of Empleado)
            FiltroEmpleados = New List(Of Empleado)
            Dim vistaFiltrada As DataView = New DataView(tablaEmpleados)
            vistaFiltrada.Sort = "Nombre ASC, Apellidos ASC"
            vistaFiltrada.RowFilter = SqlWhereNombreApellidos(nombre, apellidos).Replace("WHERE", "").Replace("@nombre", "'" & nombre & "'").Replace("@apellidos", "'" & apellidos & "'")

            For Each filaRegistro As DataRowView In vistaFiltrada
                Dim nuevoEmpleado As New Empleado()
                nuevoEmpleado.nombre = CType(filaRegistro("nombre"), String)
                nuevoEmpleado.apellidos = filaRegistro("apellidos")
                nuevoEmpleado.genero = CType(filaRegistro("genero"), TipoGenero)
                nuevoEmpleado.categoria = CType(filaRegistro("categoria"), TipoCategoria)
                nuevoEmpleado.retribucionFija = CType(filaRegistro("Retribucion_Fija"), Single)

                FiltroEmpleados.Add(nuevoEmpleado)
            Next
        End Function
    End Class
End Namespace
