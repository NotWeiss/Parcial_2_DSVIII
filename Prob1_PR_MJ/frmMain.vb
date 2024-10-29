Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Dim destino As New frmFacturar()

        destino.show()

        Me.Hide()
    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        Dim destino As New frmDatos()

        destino.Show()

        Me.Hide()
    End Sub

    Private Sub btnCreditos_Click(sender As Object, e As EventArgs) Handles btnCreditos.Click
        Dim destino As New frmCreditos()

        destino.Show()

        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class
