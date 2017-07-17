Imports System.Data.OleDb

Namespace Modelo
    Public Class EmpleadosAccess
        Inherits EmpleadosBaseOleDB

        Public Overrides Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean

            cadena_conexion = CrearCadenaConexion(PROVEEDOR_ACCESS, NombreFichero)

            consultaSQL = "SELECT Nombre, Apellidos, Genero, Categoria, Retribucion_Fija " _
                    & " FROM Empleado  ORDER BY Nombre, Apellidos ASC; "

            Return MyBase.Importar(arrayEmpleados)
        End Function

        Public Overrides Function Exportar(arrayEmpleados() As Empleado) As Boolean

            cadena_conexion = CrearCadenaConexion(PROVEEDOR_ACCESS, NombreFichero)

            consultaSQL = "INSERT INTO empleado ( Nombre, Apellidos, Genero, Categoria, " _
                            & "Retribucion_Fija ) VALUES (@nombre, @apellidos, @genero, @categoria, @retribucionFija )"

            Return MyBase.Exportar(arrayEmpleados)
        End Function
    End Class

End Namespace
