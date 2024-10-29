Public Class frmFacturar
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim destino As New frmMain()

        destino.Show()

        Me.Hide()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String
        Dim cedula As String
        Dim dia As String
        Dim modelo As Integer

        nombre = txtNombre.Text
        cedula = txtCedula.Text
        dia = cboDia.Text

        If radMX1.Checked() Then
            modelo = 1
        ElseIf radMX2.Checked() Then
            modelo = 2
        ElseIf radMX3.Checked() Then
            modelo = 3
        End If


    End Sub
End Class