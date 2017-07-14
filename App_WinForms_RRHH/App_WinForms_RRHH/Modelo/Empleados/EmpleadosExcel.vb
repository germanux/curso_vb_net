
Imports System.Data.OleDb

Namespace Modelo
    Public Class EmpleadosExcel
        Inherits EmpleadosBaseOleDB

        Public Overrides Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean

            cadena_conexion = CrearCadenaConexion(PROVEEDOR_EXCEL, NombreFichero) & PROPIEDADES_EXCEL

            consultaSQL = "SELECT * FROM [Hoja1$A2:E65535]"

            Return MyBase.Importar(arrayEmpleados)
        End Function

        Public Overrides Function Exportar(arrayEmpleados() As Empleado) As Boolean
            cadena_conexion = CrearCadenaConexion(PROVEEDOR_EXCEL, NombreFichero) & PROPIEDADES_EXCEL

            consultaSQL = "INSERT INTO [Hoja1$] ( Nombre, Apellidos, Genero, Categoria, Retribucion_Fija ) VALUES (@nombre, @apellidos, @genero, @categoria, @retribucionFija )"

            Return MyBase.Exportar(arrayEmpleados)
        End Function

    End Class

End Namespace