<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTextoAEncryptar = New System.Windows.Forms.TextBox()
        Me.txtDesencryptar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEncriptarCadena = New System.Windows.Forms.Button()
        Me.btnDesencriptarCadena = New System.Windows.Forms.Button()
        Me.lbEncrypter = New System.Windows.Forms.TextBox()
        Me.txtTextoDesencriptado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escriba lo que se va encryptar"
        '
        'txtTextoAEncryptar
        '
        Me.txtTextoAEncryptar.Location = New System.Drawing.Point(30, 62)
        Me.txtTextoAEncryptar.Multiline = True
        Me.txtTextoAEncryptar.Name = "txtTextoAEncryptar"
        Me.txtTextoAEncryptar.Size = New System.Drawing.Size(617, 75)
        Me.txtTextoAEncryptar.TabIndex = 1
        '
        'txtDesencryptar
        '
        Me.txtDesencryptar.Location = New System.Drawing.Point(32, 268)
        Me.txtDesencryptar.Multiline = True
        Me.txtDesencryptar.Name = "txtDesencryptar"
        Me.txtDesencryptar.Size = New System.Drawing.Size(616, 76)
        Me.txtDesencryptar.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Escriba lo que va a deshencryptar:"
        '
        'btnEncriptarCadena
        '
        Me.btnEncriptarCadena.Location = New System.Drawing.Point(464, 37)
        Me.btnEncriptarCadena.Name = "btnEncriptarCadena"
        Me.btnEncriptarCadena.Size = New System.Drawing.Size(183, 23)
        Me.btnEncriptarCadena.TabIndex = 6
        Me.btnEncriptarCadena.Text = "Encriptar Cadena"
        Me.btnEncriptarCadena.UseVisualStyleBackColor = True
        '
        'btnDesencriptarCadena
        '
        Me.btnDesencriptarCadena.Location = New System.Drawing.Point(465, 239)
        Me.btnDesencriptarCadena.Name = "btnDesencriptarCadena"
        Me.btnDesencriptarCadena.Size = New System.Drawing.Size(183, 23)
        Me.btnDesencriptarCadena.TabIndex = 7
        Me.btnDesencriptarCadena.Text = "Desencriptar Cadena"
        Me.btnDesencriptarCadena.UseVisualStyleBackColor = True
        '
        'lbEncrypter
        '
        Me.lbEncrypter.Location = New System.Drawing.Point(31, 143)
        Me.lbEncrypter.Multiline = True
        Me.lbEncrypter.Name = "lbEncrypter"
        Me.lbEncrypter.ReadOnly = True
        Me.lbEncrypter.Size = New System.Drawing.Size(617, 81)
        Me.lbEncrypter.TabIndex = 8
        '
        'txtTextoDesencriptado
        '
        Me.txtTextoDesencriptado.Location = New System.Drawing.Point(31, 350)
        Me.txtTextoDesencriptado.Multiline = True
        Me.txtTextoDesencriptado.Name = "txtTextoDesencriptado"
        Me.txtTextoDesencriptado.ReadOnly = True
        Me.txtTextoDesencriptado.Size = New System.Drawing.Size(617, 81)
        Me.txtTextoDesencriptado.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 444)
        Me.Controls.Add(Me.txtTextoDesencriptado)
        Me.Controls.Add(Me.lbEncrypter)
        Me.Controls.Add(Me.btnDesencriptarCadena)
        Me.Controls.Add(Me.btnEncriptarCadena)
        Me.Controls.Add(Me.txtDesencryptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTextoAEncryptar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Escriba lo que se va encryptar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTextoAEncryptar As System.Windows.Forms.TextBox
    Friend WithEvents txtDesencryptar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEncriptarCadena As System.Windows.Forms.Button
    Friend WithEvents btnDesencriptarCadena As System.Windows.Forms.Button
    Friend WithEvents lbEncrypter As System.Windows.Forms.TextBox
    Friend WithEvents txtTextoDesencriptado As System.Windows.Forms.TextBox

End Class
