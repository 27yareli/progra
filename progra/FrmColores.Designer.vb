<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColores
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
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnAmarillo = New System.Windows.Forms.Button()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnAnaranjado = New System.Windows.Forms.Button()
        Me.btnMorado = New System.Windows.Forms.Button()
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRojo
        '
        Me.btnRojo.Location = New System.Drawing.Point(50, 74)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(89, 23)
        Me.btnRojo.TabIndex = 0
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'btnAmarillo
        '
        Me.btnAmarillo.Location = New System.Drawing.Point(50, 141)
        Me.btnAmarillo.Name = "btnAmarillo"
        Me.btnAmarillo.Size = New System.Drawing.Size(89, 23)
        Me.btnAmarillo.TabIndex = 1
        Me.btnAmarillo.Text = "Amarillo"
        Me.btnAmarillo.UseVisualStyleBackColor = True
        '
        'btnVerde
        '
        Me.btnVerde.Location = New System.Drawing.Point(50, 204)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(89, 23)
        Me.btnVerde.TabIndex = 2
        Me.btnVerde.Text = "Verde"
        Me.btnVerde.UseVisualStyleBackColor = True
        '
        'btnAnaranjado
        '
        Me.btnAnaranjado.Location = New System.Drawing.Point(50, 279)
        Me.btnAnaranjado.Name = "btnAnaranjado"
        Me.btnAnaranjado.Size = New System.Drawing.Size(89, 23)
        Me.btnAnaranjado.TabIndex = 3
        Me.btnAnaranjado.Text = "Anaranjado"
        Me.btnAnaranjado.UseVisualStyleBackColor = True
        '
        'btnMorado
        '
        Me.btnMorado.Location = New System.Drawing.Point(50, 354)
        Me.btnMorado.Name = "btnMorado"
        Me.btnMorado.Size = New System.Drawing.Size(89, 23)
        Me.btnMorado.TabIndex = 4
        Me.btnMorado.Text = "Morado"
        Me.btnMorado.UseVisualStyleBackColor = True
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(235, 74)
        Me.txtColores.Multiline = True
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(456, 303)
        Me.txtColores.TabIndex = 5
        '
        'FrmColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.btnMorado)
        Me.Controls.Add(Me.btnAnaranjado)
        Me.Controls.Add(Me.btnVerde)
        Me.Controls.Add(Me.btnAmarillo)
        Me.Controls.Add(Me.btnRojo)
        Me.Name = "FrmColores"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRojo As Button
    Friend WithEvents btnAmarillo As Button
    Friend WithEvents btnVerde As Button
    Friend WithEvents btnAnaranjado As Button
    Friend WithEvents btnMorado As Button
    Friend WithEvents txtColores As TextBox
End Class
