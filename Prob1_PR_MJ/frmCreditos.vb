Public Class frmCreditos
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim destino As New frmMain()

        destino.Show()

        Me.Hide()
    End Sub

    Private Sub frmCreditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPC.Text = Environ("COMPUTERNAME")
        lblUser.Text = Environ("USERNAME")
    End Sub
End Class