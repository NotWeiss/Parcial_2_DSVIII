<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatos
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
        txtPrecioMX1 = New TextBox()
        txtPrecioMX2 = New TextBox()
        txtPrecioMX3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        lblPrecios = New Label()
        lblRegistro = New Label()
        ComboBox1 = New ComboBox()
        btnCargar = New Button()
        lblDia = New Label()
        btnActualizar = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' txtPrecioMX1
        ' 
        txtPrecioMX1.Location = New Point(37, 57)
        txtPrecioMX1.Name = "txtPrecioMX1"
        txtPrecioMX1.Size = New Size(100, 23)
        txtPrecioMX1.TabIndex = 1
        ' 
        ' txtPrecioMX2
        ' 
        txtPrecioMX2.Location = New Point(188, 57)
        txtPrecioMX2.Name = "txtPrecioMX2"
        txtPrecioMX2.Size = New Size(100, 23)
        txtPrecioMX2.TabIndex = 2
        ' 
        ' txtPrecioMX3
        ' 
        txtPrecioMX3.Location = New Point(339, 57)
        txtPrecioMX3.Name = "txtPrecioMX3"
        txtPrecioMX3.Size = New Size(100, 23)
        txtPrecioMX3.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(70, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 4
        Label1.Text = "MX1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(223, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 5
        Label2.Text = "MX2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(374, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 6
        Label3.Text = "MX3"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 174)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(452, 220)
        DataGridView1.TabIndex = 7
        ' 
        ' lblPrecios
        ' 
        lblPrecios.AutoSize = True
        lblPrecios.Location = New Point(216, 12)
        lblPrecios.Name = "lblPrecios"
        lblPrecios.Size = New Size(45, 15)
        lblPrecios.TabIndex = 8
        lblPrecios.Text = "Precios"
        ' 
        ' lblRegistro
        ' 
        lblRegistro.AutoSize = True
        lblRegistro.Location = New Point(211, 120)
        lblRegistro.Name = "lblRegistro"
        lblRegistro.Size = New Size(55, 15)
        lblRegistro.TabIndex = 9
        lblRegistro.Text = "Registros"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo"})
        ComboBox1.Location = New Point(125, 145)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 10
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(258, 145)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(75, 23)
        btnCargar.TabIndex = 11
        btnCargar.Text = "Cargar"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' lblDia
        ' 
        lblDia.AutoSize = True
        lblDia.Location = New Point(22, 149)
        lblDia.Name = "lblDia"
        lblDia.Size = New Size(97, 15)
        lblDia.TabIndex = 12
        lblDia.Text = "Dia de la Semana"
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(175, 86)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(130, 23)
        btnActualizar.TabIndex = 13
        btnActualizar.Text = "Actualizar Precios"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' frmDatos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(477, 450)
        Controls.Add(btnActualizar)
        Controls.Add(lblDia)
        Controls.Add(btnCargar)
        Controls.Add(ComboBox1)
        Controls.Add(lblRegistro)
        Controls.Add(lblPrecios)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPrecioMX3)
        Controls.Add(txtPrecioMX2)
        Controls.Add(txtPrecioMX1)
        Controls.Add(btnRegresar)
        Name = "frmDatos"
        Text = "frmDatos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtPrecioMX1 As TextBox
    Friend WithEvents txtPrecioMX2 As TextBox
    Friend WithEvents txtPrecioMX3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblPrecios As Label
    Friend WithEvents lblRegistro As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents lblDia As Label
    Friend WithEvents btnActualizar As Button
End Class
