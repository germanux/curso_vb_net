Public Class FormCalculoFiguras
    Private Sub numAncho_ValueChanged(sender As Object, e As EventArgs) Handles numAncho.ValueChanged, numAlto.ValueChanged
        Dim rectangulo As Rectangulo = New Rectangulo(numAlto.Value, numAncho.Value)

        numArea.Value = rectangulo.CalcularArea()
        numPerimetro.Value = rectangulo.CalcularPerimetro()
    End Sub
    Private Sub numRadio_ValueChanged(sender As Object, e As EventArgs) Handles numRadio.ValueChanged
        Dim circulo As Circulo = New Circulo(numRadio.Value, Nothing)

        numArea.Value = circulo.CalcularArea()
        numPerimetro.Value = circulo.CalcularPerimetro()
    End Sub
    Private Sub radioButton_CheckedChanged(sender As Object, e As EventArgs) Handles radRectangulo.CheckedChanged
        grupoRectangulo.Visible = radRectangulo.Checked
        grupoCirculo.Visible = radCirculo.Checked
    End Sub

End Class
