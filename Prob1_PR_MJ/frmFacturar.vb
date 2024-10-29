Imports System.IO
Imports System.Numerics

Public Class frmFacturar
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim destino As New frmMain()

        destino.Show()

        Me.Hide()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim data As New Dictionary(Of String, String)

        data.Add("nombre", txtNombre.Text)
        data.Add("cedula", txtCedula.Text)
        data.Add("dia", cboDia.Text)

        If radMX1.Checked() Then
            data.Add("modelo", "X1")
        ElseIf radMX2.Checked() Then
            data.Add("modelo", "X2")
        ElseIf radMX3.Checked() Then
            data.Add("modelo", "X3")
        End If

        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse String.IsNullOrWhiteSpace(txtCedula.Text) Then
            MessageBox.Show("Rellene los campos", "ERROR", MessageBoxButtons.OK)
            Exit Sub
        End If
        Try
            Dim directorio As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
            Dim filePath As String = Path.Combine(directorio, "data.csv")
            Dim id As Integer = File.ReadAllLines(filePath).Length

            Using writer As StreamWriter = New StreamWriter(filePath, True)
                ' Genera un ID único basado en la cantidad de líneas en el archivo (puedes mejorar esto)
                writer.WriteLine($"{id}, {data("nombre")}, {data("cedula")}, {data("dia")}, {data("modelo")}")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al guardar lo datos", "ERROR", MessageBoxButtons.OK)
        End Try

    End Sub
End Class