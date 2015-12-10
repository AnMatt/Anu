<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Number1 = New System.Windows.Forms.TextBox()
        Me.Number2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Sum = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Substract = New System.Windows.Forms.Label()
        Me.Multiply = New System.Windows.Forms.Label()
        Me.Divide = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sum"
        '
        'Number1
        '
        Me.Number1.Location = New System.Drawing.Point(197, 17)
        Me.Number1.Name = "Number1"
        Me.Number1.Size = New System.Drawing.Size(100, 20)
        Me.Number1.TabIndex = 3
        '
        'Number2
        '
        Me.Number2.Location = New System.Drawing.Point(197, 58)
        Me.Number2.Name = "Number2"
        Me.Number2.Size = New System.Drawing.Size(100, 20)
        Me.Number2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(197, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Sum
        '
        Me.Sum.Location = New System.Drawing.Point(55, 318)
        Me.Sum.Name = "Sum"
        Me.Sum.Size = New System.Drawing.Size(75, 23)
        Me.Sum.TabIndex = 6
        Me.Sum.Text = "Add"
        Me.Sum.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 318)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Substract"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(298, 318)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Mutiply"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(424, 318)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Divide"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Substract
        '
        Me.Substract.AutoSize = True
        Me.Substract.Location = New System.Drawing.Point(52, 150)
        Me.Substract.Name = "Substract"
        Me.Substract.Size = New System.Drawing.Size(52, 13)
        Me.Substract.TabIndex = 10
        Me.Substract.Text = "Substract"
        '
        'Multiply
        '
        Me.Multiply.AutoSize = True
        Me.Multiply.Location = New System.Drawing.Point(52, 188)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(42, 13)
        Me.Multiply.TabIndex = 11
        Me.Multiply.Text = "Multiply"
        '
        'Divide
        '
        Me.Divide.AutoSize = True
        Me.Divide.Location = New System.Drawing.Point(52, 228)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(37, 13)
        Me.Divide.TabIndex = 12
        Me.Divide.Text = "Divide"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(197, 143)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(197, 185)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(197, 228)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 427)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Divide)
        Me.Controls.Add(Me.Multiply)
        Me.Controls.Add(Me.Substract)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Sum)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Number2)
        Me.Controls.Add(Me.Number1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Number1 As TextBox
    Friend WithEvents Number2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Sum As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Substract As Label
    Friend WithEvents Multiply As Label
    Friend WithEvents Divide As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
End Class
