Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Nuestra aplicacion de RR.HH."

        Modelo_RRHH.Modelo.MessageBox.MostrarMensaje = AddressOf MM
        Dim dbEmpleado = New Modelo_RRHH.Modelo.EmpleadosAccess()
        dbEmpleado.NombreFichero = "C:\Users\sinensia100\Documents\EmpleadosDB.mdb"
        Dim listaCRUD = New Modelo_RRHH.Modelo.EmpleadosListaCRUD()
        listaCRUD.EstablecerAvisarEnModificacion(AddressOf SSSSS)
        listaCRUD.Restaurar(dbEmpleado)
        Dim empleado = listaCRUD.BuscarEmpleados("b", "").Item(0)
        ViewData("Empleado del mes") = empleado.ToString()

        Return View()
    End Function
    Sub MM(str As String)

    End Sub
    Sub SSSSS(bo As Boolean)

    End Sub

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
