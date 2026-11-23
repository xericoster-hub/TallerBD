<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar
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
        Panel1 = New Panel()
        Label4 = New Label()
        Label1 = New Label()
        TextBox5 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label6 = New Label()
        TextBox2 = New TextBox()
        Label7 = New Label()
        TextBox3 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        b_regresar = New Button()
        b_consultar = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(89), CByte(71), CByte(17))
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox4)
        Panel1.Location = New Point(1, -1)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(929, 116)
        Panel1.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(658, 141)
        Label4.Margin = New Padding(0)
        Label4.MaximumSize = New Size(571, 667)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 26)
        Label4.TabIndex = 42
        Label4.Text = "Numero"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bauhaus 93", 21F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(389, 42)
        Label1.Margin = New Padding(0)
        Label1.MaximumSize = New Size(571, 667)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 39)
        Label1.TabIndex = 0
        Label1.Text = "Eliminar"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.White
        TextBox5.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox5.ForeColor = SystemColors.InfoText
        TextBox5.Location = New Point(616, 170)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(151, 35)
        TextBox5.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(484, 141)
        Label3.Margin = New Padding(0)
        Label3.MaximumSize = New Size(571, 667)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 26)
        Label3.TabIndex = 40
        Label3.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(318, 141)
        Label2.Margin = New Padding(0)
        Label2.MaximumSize = New Size(571, 667)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 26)
        Label2.TabIndex = 38
        Label2.Text = "Id"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.White
        TextBox4.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.ForeColor = SystemColors.InfoText
        TextBox4.Location = New Point(442, 170)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(151, 35)
        TextBox4.TabIndex = 39
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(701, 193)
        Label5.Margin = New Padding(0)
        Label5.MaximumSize = New Size(571, 667)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 26)
        Label5.TabIndex = 37
        Label5.Text = "Numero"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.InfoText
        TextBox1.Location = New Point(659, 222)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 35)
        TextBox1.TabIndex = 36
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(527, 193)
        Label6.Margin = New Padding(0)
        Label6.MaximumSize = New Size(571, 667)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 26)
        Label6.TabIndex = 35
        Label6.Text = "Nombre"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.InfoText
        TextBox2.Location = New Point(485, 222)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 35)
        TextBox2.TabIndex = 34
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(361, 193)
        Label7.Margin = New Padding(0)
        Label7.MaximumSize = New Size(571, 667)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 26)
        Label7.TabIndex = 33
        Label7.Text = "Id"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.White
        TextBox3.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.InfoText
        TextBox3.Location = New Point(298, 222)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(151, 35)
        TextBox3.TabIndex = 32
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.Peru
        TextBox6.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.ForeColor = SystemColors.InfoText
        TextBox6.Location = New Point(63, 131)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Escribe la sentencia "
        TextBox6.Size = New Size(177, 35)
        TextBox6.TabIndex = 31
        TextBox6.Text = "Que eliminar"
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.Peru
        TextBox7.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox7.ForeColor = SystemColors.InfoText
        TextBox7.Location = New Point(174, 222)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "Escribe la sentencia "
        TextBox7.Size = New Size(96, 35)
        TextBox7.TabIndex = 38
        TextBox7.Text = "Donde"
        ' 
        ' b_regresar
        ' 
        b_regresar.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        b_regresar.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_regresar.ForeColor = SystemColors.ButtonHighlight
        b_regresar.Location = New Point(82, 351)
        b_regresar.Margin = New Padding(0)
        b_regresar.Name = "b_regresar"
        b_regresar.Size = New Size(112, 49)
        b_regresar.TabIndex = 39
        b_regresar.Text = "REGRESAR"
        b_regresar.UseVisualStyleBackColor = False
        ' 
        ' b_consultar
        ' 
        b_consultar.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        b_consultar.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_consultar.ForeColor = SystemColors.ButtonHighlight
        b_consultar.Location = New Point(668, 336)
        b_consultar.Margin = New Padding(0)
        b_consultar.Name = "b_consultar"
        b_consultar.Size = New Size(112, 49)
        b_consultar.TabIndex = 44
        b_consultar.Text = "CONSULTAR"
        b_consultar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        Button1.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(780, 336)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 49)
        Button1.TabIndex = 45
        Button1.Text = "Confirmacion"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Eliminar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(928, 450)
        Controls.Add(Button1)
        Controls.Add(b_consultar)
        Controls.Add(b_regresar)
        Controls.Add(TextBox7)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(TextBox2)
        Controls.Add(Label7)
        Controls.Add(TextBox3)
        Controls.Add(TextBox6)
        Controls.Add(Panel1)
        Name = "Eliminar"
        Text = "Eliminame"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents b_regresar As Button
    Friend WithEvents b_consultar As Button
    Friend WithEvents Button1 As Button
End Class
