Imports System.IO

Public Class frmDatos
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim destino As New frmMain()

        destino.Show()

        Me.Hide()
    End Sub

    Private Sub frmDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim directorio As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
            Dim filePath As String = Path.Combine(directorio, "precio.csv")

            If File.Exists(filePath) Then
                Dim lines As String() = File.ReadAllLines(filePath)
                Dim precios(3) As String

                Dim loops As Integer = 0

                For Each line In lines
                    Dim columns As String() = line.Split(","c)
                    precios(loops) = columns(2)
                    loops += 1
                Next

                txtPrecioMX1.Text = precios(0)
                txtPrecioMX2.Text = precios(1)
                txtPrecioMX3.Text = precios(2)
            End If
        Catch ex As Exception

        End Try

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

        If String.IsNullOrWhiteSpace(precioMX1) OrElse String.IsNullOrWhiteSpace(precioMX2) OrElse String.IsNullOrWhiteSpace(precioMX3) Then
            MessageBox.Show("Rellene los campos", "ERROR", MessageBoxButtons.OK)
            Exit Sub
        End If
        Try
            Dim directorio As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
            Dim filePath As String = Path.Combine(directorio, "precio.csv")

            Using writer As StreamWriter = New StreamWriter(filePath)
                ' Genera un ID único basado en la cantidad de líneas en el archivo (puedes mejorar esto)
                writer.WriteLine($"{"1"}, {"X1"}, {precioMX1}")
                writer.WriteLine($"{"2"}, {"X2"}, {precioMX2}")
                writer.WriteLine($"{"3"}, {"X3"}, {precioMX3}")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al guardar lo datos", "ERROR", MessageBoxButtons.OK)
        End Try

    End Sub
End Class