Imports System.Data.OleDb

Namespace Modelo
    Public Class EmpleadosAccessCRUD
        Implements IEmpleadosCRUD

        Private cadena_conexion As String
        Public avisarEnModicacion As TipoDelAvisarEnModificacion

        Public ReadOnly Property Cantidad As Integer Implements IEmpleadosCRUD.Cantidad
            Get
                Dim comando = ComandoConConexion(cadena_conexion, "SELECT  COUNT(*) FROM Empleado ")
                Cantidad = comando.ExecuteScalar()
                comando.Cerrar()
                Return Cantidad
            End Get
        End Property
        Public Sub Actualizar(empleado As Empleado, empleadoModif As Empleado) Implements IEmpleadosCRUD.Actualizar
            If empleado.nombre = "" Or empleado.apellidos = "" Then
                Throw New ArgumentException()
            End If
            Dim consultaSQL = "UPDATE empleado SET Nombre = @nombre, Apellidos = @apellidos, Genero = @genero,  " _
                           & " Categoria = @categoria, Retribucion_Fija = @retribucionFija  " _
                           & " WHERE Nombre = @nombreABuscar AND Apellidos = @apellidosABuscar ; "

            Dim comando As OleDbCommand = ComandoConConexion(cadena_conexion, consultaSQL)

            comando.AñadirParametro("@nombre", empleadoModif.nombre)
            comando.AñadirParametro("@apellidos", empleadoModif.apellidos)
            comando.AñadirParametro("@genero", empleadoModif.genero, , DbType.Int32)
            comando.AñadirParametro("@categoria", empleadoModif.categoria, , DbType.Int32)
            comando.AñadirParametro("@retribucionFija", empleadoModif.retribucionFija, , DbType.Single)

            comando.AñadirParametro("@nombreABuscar", empleado.nombre)
            comando.AñadirParametro("@apellidosABuscar", empleado.apellidos)

            comando.ExecuteNonQuery()
            comando.Cerrar()

        End Sub
        Public Sub Crear(nuevoEmpleado As Empleado) Implements IEmpleadosCRUD.Crear

            Dim consultaSQL = "INSERT INTO empleado ( Nombre, Apellidos, Genero, Categoria, " _
                            & "Retribucion_Fija ) VALUES (@nombre, @apellidos, @genero, @categoria, @retribucionFija )"

            Dim comando As OleDbCommand = ComandoConConexion(cadena_conexion, consultaSQL)

            comando.AñadirParametro("@nombre", nuevoEmpleado.nombre)
            comando.AñadirParametro("@apellidos", nuevoEmpleado.apellidos)
            comando.AñadirParametro("@genero", nuevoEmpleado.genero, , DbType.Int32)
            comando.AñadirParametro("@categoria", nuevoEmpleado.categoria, , DbType.Int32)
            comando.AñadirParametro("@retribucionFija", nuevoEmpleado.retribucionFija, , DbType.Single)

            comando.ExecuteNonQuery()
            comando.Cerrar()
        End Sub

        Public Function BuscarEmpleados(nombre As String, apellidos As String) As List(Of Empleado) Implements IEmpleadosCRUD.BuscarEmpleados

            Dim consultaSQL = "SELECT Nombre, Apellidos, Genero, Categoria, Retribucion_Fija " _
                    & " FROM Empleado "

            consultaSQL &= SqlWhereNombreApellidos(nombre, apellidos)
            consultaSQL = consultaSQL + " ORDER BY Nombre, Apellidos ASC;"
            Console.WriteLine(consultaSQL)

            BuscarEmpleados = New List(Of Empleado)

            Dim comando = ComandoConConexion(cadena_conexion, consultaSQL)
            Try
                comando.AñadirParametro("@nombre", nombre)
                comando.AñadirParametro("@apellidos", apellidos)

                Dim dataReader As OleDbDataReader = comando.ExecuteReader()
                Do While dataReader.Read()
                    Dim nuevoEmpleado As New Empleado()
                    nuevoEmpleado.nombre = CType(dataReader(0), String)
                    nuevoEmpleado.apellidos = dataReader.GetString(1)
                    nuevoEmpleado.genero = CType(dataReader(2), TipoGenero)
                    nuevoEmpleado.categoria = CType(dataReader(3), TipoCategoria)
                    nuevoEmpleado.retribucionFija = CType(dataReader(4), Single)

                    BuscarEmpleados.Add(nuevoEmpleado)
                Loop
                dataReader.Close()
            Catch ex As Exception
                MessageBox.Show("Error al buscar " & ex.Message)
            End Try
            comando.Cerrar()
        End Function
        Public Sub Eliminar(empleado As Empleado) Implements IEmpleadosCRUD.Eliminar
            If empleado.nombre = "" Or empleado.apellidos = "" Then
                Throw New ArgumentException()
            End If
            Dim consultaSQL = "DELETE FROM empleado   "
            consultaSQL &= SqlWhereNombreApellidos(empleado.nombre, empleado.apellidos)
            Dim comando As OleDbCommand = ComandoConConexion(cadena_conexion, consultaSQL)

            comando.AñadirParametro("@nombre", empleado.nombre)
            comando.AñadirParametro("@apellidos", empleado.apellidos)

            comando.ExecuteNonQuery()
            comando.Cerrar()
            avisarEnModicacion(True)
        End Sub
        Sub Eliminar(empleados As List(Of Empleado)) Implements IEmpleadosCRUD.Eliminar
            For Each empleado In empleados
                Eliminar(empleado)
            Next
            avisarEnModicacion(True)
        End Sub
        Public Sub EstablecerAvisarEnModificacion(funcionDelegada As TipoDelAvisarEnModificacion) Implements IEmpleadosCRUD.EstablecerAvisarEnModificacion
            avisarEnModicacion = funcionDelegada
        End Sub
        Public Sub Grabar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Grabar
            persistenciaEmpleados.Exportar(BuscarEmpleados("", "").ToArray())
            avisarEnModicacion(True)
        End Sub
        ' SI
        Public Sub Restaurar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Restaurar
            cadena_conexion = CrearCadenaConexion(PROVEEDOR_ACCESS, persistenciaEmpleados.nombreFichero)
            avisarEnModicacion(False)
        End Sub

    End Class
End Namespace
