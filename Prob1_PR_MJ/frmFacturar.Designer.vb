<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnRegresar = New Button()
        txtNombre = New TextBox()
        txtCedula = New TextBox()
        cboDia = New ComboBox()
        grbModelo = New GroupBox()
        radMX3 = New RadioButton()
        radMX2 = New RadioButton()
        radMX1 = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnGuardar = New Button()
        grbModelo.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 415)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(75, 23)
        btnRegresar.TabIndex = 0
        btnRegresar.Text = "Regresar"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(178, 111)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(178, 173)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(100, 23)
        txtCedula.TabIndex = 2
        ' 
        ' cboDia
        ' 
        cboDia.FormattingEnabled = True
        cboDia.Items.AddRange(New Object() {"lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo"})
        cboDia.Location = New Point(168, 235)
        cboDia.Name = "cboDia"
        cboDia.Size = New Size(121, 23)
        cboDia.TabIndex = 3
        ' 
        ' grbModelo
        ' 
        grbModelo.Controls.Add(radMX3)
        grbModelo.Controls.Add(radMX2)
        grbModelo.Controls.Add(radMX1)
        grbModelo.Location = New Point(150, 270)
        grbModelo.Name = "grbModelo"
        grbModelo.Size = New Size(156, 101)
        grbModelo.TabIndex = 4
        grbModelo.TabStop = False
        grbModelo.Text = "Modelo"
        ' 
        ' radMX3
        ' 
        radMX3.AutoSize = True
        radMX3.Location = New Point(51, 72)
        radMX3.Name = "radMX3"
        radMX3.Size = New Size(49, 19)
        radMX3.TabIndex = 2
        radMX3.TabStop = True
        radMX3.Text = "MX3"
        radMX3.UseVisualStyleBackColor = True
        ' 
        ' radMX2
        ' 
        radMX2.AutoSize = True
        radMX2.Location = New Point(51, 47)
        radMX2.Name = "radMX2"
        radMX2.Size = New Size(49, 19)
        radMX2.TabIndex = 1
        radMX2.TabStop = True
        radMX2.Text = "MX2"
        radMX2.UseVisualStyleBackColor = True
        ' 
        ' radMX1
        ' 
        radMX1.AutoSize = True
        radMX1.Location = New Point(51, 22)
        radMX1.Name = "radMX1"
        radMX1.Size = New Size(49, 19)
        radMX1.TabIndex = 0
        radMX1.TabStop = True
        radMX1.Text = "MX1"
        radMX1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(203, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 5
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(206, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 6
        Label2.Text = "Cedula"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(180, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 15)
        Label3.TabIndex = 7
        Label3.Text = "Dia de la Semana"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(375, 415)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 8
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' frmFacturar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(462, 450)
        Controls.Add(btnGuardar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(grbModelo)
        Controls.Add(cboDia)
        Controls.Add(txtCedula)
        Controls.Add(txtNombre)
        Controls.Add(btnRegresar)
        Name = "frmFacturar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmFacturar"
        grbModelo.ResumeLayout(False)
        grbModelo.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents cboDia As ComboBox
    Friend WithEvents grbModelo As GroupBox
    Friend WithEvents radMX3 As RadioButton
    Friend WithEvents radMX2 As RadioButton
    Friend WithEvents radMX1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardar As Button
End Class
