Namespace Modelo
    ' Nuevo tipo de variable, inventado por nosotros. 
    Public Structure Empleado
        Public nombre As String
        Public apellidos As String
        Public genero As TipoGenero
        Public categoria As TipoCategoria
        Public retribucionFija As Single

        'Public Sub New()
        '    nombre = ""
        '    apellidos = ""
        '    genero = TipoGenero.Hermafrodita
        '    categoria = TipoCategoria.Administrativo
        '    retribucionFija = 0
        'End Sub
        ' Constructor
        Public Sub New(nuevoNombre As String, nuevoApell As String, nuevoGenero As TipoGenero, nuevaCategoria As TipoCategoria, nuevaRetribucion As Single)
            nombre = nuevoNombre
            apellidos = nuevoApell
            genero = nuevoGenero
            categoria = nuevaCategoria
            retribucionFija = nuevaRetribucion
            Console.Write("Se ha creado el nuevo empleado " + nombre)
        End Sub
        Function NombreCompleto() As String
            Return nombre & " " & apellidos
        End Function
        Function RellenarConRegistro(ByVal textoRegistro As String) As Boolean

            Dim arrayCampos() As String = textoRegistro.Split(CType(",", Char))

            If arrayCampos.Length = 5 Then
                nombre = arrayCampos(0)
                apellidos = arrayCampos(1)
                genero = CType(Integer.Parse(arrayCampos(2)), TipoGenero)
                categoria = CType(Integer.Parse(arrayCampos(3)), TipoCategoria)
                retribucionFija = Single.Parse(arrayCampos(4))
                Console.WriteLine(ToString())
                Return True
            Else
                Console.WriteLine("Error al leer empleado " & textoRegistro)
                Return False
            End If
        End Function
        Overrides Function ToString() As String
            Return NombreCompleto() + " " & genero.ToString() & " " & categoria.ToString()
        End Function
    End Structure
End Namespace