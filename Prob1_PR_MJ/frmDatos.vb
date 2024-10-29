Public Class frmDatos
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim destino As New frmMain()

        destino.Show()

        Me.Hide()
    End Sub

    Private Sub frmDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim precioMX1 As Decimal
        Dim precioMX2 As Decimal
        Dim precioMX3 As Decimal

        precioMX1 = txtPrecioMX1.Text
        precioMX2 = txtPrecioMX2.Text
        precioMX3 = txtPrecioMX3.Text



    End Sub
End Class