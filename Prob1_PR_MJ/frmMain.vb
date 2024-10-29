Imports System.IO

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ' Define la direccion del directorio donde se ejecuta la aplicacion
            ' y la direccion del archivo donde guardamos los datos.
            Dim projectDirectory As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
            Dim filePath As String = Path.Combine(projectDirectory, "data.csv")

            'Verifica si el archivo "data.csv" ya existe'
            Dim fileExist As Boolean = File.Exists(filePath)

            'Crea el archivo "data.csv" si no existe'
            If Not fileExist Then
                Using writer As StreamWriter = New StreamWriter(filePath)
                    writer.WriteLine("ID, Nombre, Cedula, Dia, Modelo")
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error al crear el documento", "ERROR", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Dim destino As New frmFacturar()

        destino.Show()

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
