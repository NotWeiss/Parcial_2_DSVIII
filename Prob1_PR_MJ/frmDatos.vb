Public Class frmDatos
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim destino As New frmMain()

        destino.Show()

        Me.Hide()
    End Sub

    Private Sub frmDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class