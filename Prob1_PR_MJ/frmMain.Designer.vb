<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnFacturar = New Button()
        btnDatos = New Button()
        btnCreditos = New Button()
        btnSalir = New Button()
        lblTitulo = New Label()
        SuspendLayout()
        ' 
        ' btnFacturar
        ' 
        btnFacturar.Location = New Point(198, 183)
        btnFacturar.Name = "btnFacturar"
        btnFacturar.Size = New Size(75, 24)
        btnFacturar.TabIndex = 0
        btnFacturar.Text = "Facturar"
        btnFacturar.UseVisualStyleBackColor = True
        ' 
        ' btnDatos
        ' 
        btnDatos.Location = New Point(198, 212)
        btnDatos.Name = "btnDatos"
        btnDatos.Size = New Size(75, 24)
        btnDatos.TabIndex = 1
        btnDatos.Text = "Datos"
        btnDatos.UseVisualStyleBackColor = True
        ' 
        ' btnCreditos
        ' 
        btnCreditos.Location = New Point(198, 257)
        btnCreditos.Name = "btnCreditos"
        btnCreditos.Size = New Size(75, 24)
        btnCreditos.TabIndex = 2
        btnCreditos.Text = "Creditos"
        btnCreditos.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(198, 286)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 24)
        btnSalir.TabIndex = 3
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(214, 90)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(45, 15)
        lblTitulo.TabIndex = 4
        lblTitulo.Text = "TITULO"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 450)
        Controls.Add(lblTitulo)
        Controls.Add(btnSalir)
        Controls.Add(btnCreditos)
        Controls.Add(btnDatos)
        Controls.Add(btnFacturar)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnFacturar As Button
    Friend WithEvents btnDatos As Button
    Friend WithEvents btnCreditos As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblTitulo As Label

End Class
