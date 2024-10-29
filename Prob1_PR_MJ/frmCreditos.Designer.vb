<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreditos
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblPC = New Label()
        lblUser = New Label()
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(161, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 15)
        Label1.TabIndex = 1
        Label1.Text = "Desarrollo de Software VIII"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(209, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 2
        Label2.Text = "1LS-132"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(151, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 15)
        Label3.TabIndex = 3
        Label3.Text = "Reynaldo Pedroza (8-964-809)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(190, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 15)
        Label4.TabIndex = 4
        Label4.Text = "Jean Moreno ()"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(201, 177)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 5
        Label5.Text = "29/10/2024"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(196, 211)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 15)
        Label6.TabIndex = 6
        Label6.Text = "Problema #1"
        ' 
        ' lblPC
        ' 
        lblPC.AutoSize = True
        lblPC.Location = New Point(224, 289)
        lblPC.Name = "lblPC"
        lblPC.Size = New Size(22, 15)
        lblPC.TabIndex = 7
        lblPC.Text = "PC"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Location = New Point(221, 325)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(29, 15)
        lblUser.TabIndex = 8
        lblUser.Text = "user"
        ' 
        ' frmCreditos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(474, 450)
        Controls.Add(lblUser)
        Controls.Add(lblPC)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnRegresar)
        Name = "frmCreditos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmCreditos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPC As Label
    Friend WithEvents lblUser As Label
End Class
