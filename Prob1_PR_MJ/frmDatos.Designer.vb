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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        lblPrecios = New Label()
        lblRegistro = New Label()
        ComboBox1 = New ComboBox()
        btnCargar = New Button()
        lblDia = New Label()
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(37, 71)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(188, 71)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(339, 71)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(70, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 4
        Label1.Text = "MX1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(223, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 5
        Label2.Text = "MX2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(374, 53)
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
        lblPrecios.Location = New Point(216, 21)
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
        ' frmDatos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(477, 450)
        Controls.Add(lblDia)
        Controls.Add(btnCargar)
        Controls.Add(ComboBox1)
        Controls.Add(lblRegistro)
        Controls.Add(lblPrecios)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnRegresar)
        Name = "frmDatos"
        Text = "frmDatos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblPrecios As Label
    Friend WithEvents lblRegistro As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents lblDia As Label
End Class
