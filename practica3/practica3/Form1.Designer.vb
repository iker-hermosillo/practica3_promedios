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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Materia1 = New System.Windows.Forms.TextBox()
        Me.Materia5 = New System.Windows.Forms.TextBox()
        Me.Materia4 = New System.Windows.Forms.TextBox()
        Me.Materia3 = New System.Windows.Forms.TextBox()
        Me.Materia2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soc. y cultura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matemáticas IV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Inglés"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Med. y Tec. IV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(405, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 4
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(31, 177)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(77, 13)
        Me.label6.TabIndex = 5
        Me.label6.Text = "Or. Vocacional"
        '
        'Materia1
        '
        Me.Materia1.Location = New System.Drawing.Point(173, 35)
        Me.Materia1.Name = "Materia1"
        Me.Materia1.Size = New System.Drawing.Size(100, 20)
        Me.Materia1.TabIndex = 6
        '
        'Materia5
        '
        Me.Materia5.Location = New System.Drawing.Point(173, 177)
        Me.Materia5.Name = "Materia5"
        Me.Materia5.Size = New System.Drawing.Size(100, 20)
        Me.Materia5.TabIndex = 7
        '
        'Materia4
        '
        Me.Materia4.Location = New System.Drawing.Point(173, 140)
        Me.Materia4.Name = "Materia4"
        Me.Materia4.Size = New System.Drawing.Size(100, 20)
        Me.Materia4.TabIndex = 8
        '
        'Materia3
        '
        Me.Materia3.Location = New System.Drawing.Point(173, 104)
        Me.Materia3.Name = "Materia3"
        Me.Materia3.Size = New System.Drawing.Size(100, 20)
        Me.Materia3.TabIndex = 9
        '
        'Materia2
        '
        Me.Materia2.Location = New System.Drawing.Point(173, 68)
        Me.Materia2.Name = "Materia2"
        Me.Materia2.Size = New System.Drawing.Size(100, 20)
        Me.Materia2.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(344, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Promedio:"
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(371, 68)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(36, 37)
        Me.resultado.TabIndex = 12
        Me.resultado.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 41)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "calcular promedio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 237)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Materia2)
        Me.Controls.Add(Me.Materia3)
        Me.Controls.Add(Me.Materia4)
        Me.Controls.Add(Me.Materia5)
        Me.Controls.Add(Me.Materia1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents Materia1 As TextBox
    Friend WithEvents Materia5 As TextBox
    Friend WithEvents Materia4 As TextBox
    Friend WithEvents Materia3 As TextBox
    Friend WithEvents Materia2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents resultado As Label
    Friend WithEvents Button1 As Button
End Class
