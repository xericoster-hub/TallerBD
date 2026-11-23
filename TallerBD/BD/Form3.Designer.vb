<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insertar
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
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        t_insercionP2 = New ComboBox()
        t_InsercionPF = New Button()
        t_incercionP1 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBox6 = New TextBox()
        Label7 = New Label()
        TextBox7 = New TextBox()
        b_consultar = New Button()
        b_regresar = New Button()
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
        Panel1.Size = New Size(885, 113)
        Panel1.TabIndex = 7
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
        Label1.Location = New Point(386, 40)
        Label1.Margin = New Padding(0)
        Label1.MaximumSize = New Size(571, 667)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 39)
        Label1.TabIndex = 0
        Label1.Text = "Insertar"
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
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.InfoText
        TextBox2.Location = New Point(348, 206)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 35)
        TextBox2.TabIndex = 37
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Peru
        TextBox3.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.InfoText
        TextBox3.Location = New Point(29, 206)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Escribe la sentencia "
        TextBox3.Size = New Size(297, 35)
        TextBox3.TabIndex = 36
        TextBox3.Text = "Que Quieres Insertar"
        ' 
        ' t_insercionP2
        ' 
        t_insercionP2.Font = New Font("Verdana", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        t_insercionP2.FormattingEnabled = True
        t_insercionP2.Items.AddRange(New Object() {"Tabla1", "Tabla2", "Tabla3"})
        t_insercionP2.Location = New Point(161, 129)
        t_insercionP2.Name = "t_insercionP2"
        t_insercionP2.Size = New Size(165, 34)
        t_insercionP2.TabIndex = 33
        t_insercionP2.Text = "Selecciona"
        ' 
        ' t_InsercionPF
        ' 
        t_InsercionPF.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        t_InsercionPF.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        t_InsercionPF.ForeColor = SystemColors.ButtonHighlight
        t_InsercionPF.Location = New Point(751, 357)
        t_InsercionPF.Margin = New Padding(0)
        t_InsercionPF.Name = "t_InsercionPF"
        t_InsercionPF.Size = New Size(112, 38)
        t_InsercionPF.TabIndex = 32
        t_InsercionPF.Text = "Insertar"
        t_InsercionPF.UseVisualStyleBackColor = False
        ' 
        ' t_incercionP1
        ' 
        t_incercionP1.BackColor = Color.Peru
        t_incercionP1.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        t_incercionP1.ForeColor = SystemColors.InfoText
        t_incercionP1.Location = New Point(31, 128)
        t_incercionP1.Name = "t_incercionP1"
        t_incercionP1.PlaceholderText = "Escribe la sentencia "
        t_incercionP1.Size = New Size(109, 35)
        t_incercionP1.TabIndex = 31
        t_incercionP1.Text = "Tabla:"
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(408, 172)
        Label5.Margin = New Padding(0)
        Label5.MaximumSize = New Size(571, 667)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 26)
        Label5.TabIndex = 38
        Label5.Text = "Id"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(568, 177)
        Label6.Margin = New Padding(0)
        Label6.MaximumSize = New Size(571, 667)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 26)
        Label6.TabIndex = 40
        Label6.Text = "Nombre"
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.White
        TextBox6.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.ForeColor = SystemColors.InfoText
        TextBox6.Location = New Point(533, 206)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(151, 35)
        TextBox6.TabIndex = 39
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(742, 177)
        Label7.Margin = New Padding(0)
        Label7.MaximumSize = New Size(571, 667)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 26)
        Label7.TabIndex = 42
        Label7.Text = "Numero"
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.White
        TextBox7.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox7.ForeColor = SystemColors.InfoText
        TextBox7.Location = New Point(712, 206)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(151, 35)
        TextBox7.TabIndex = 41
        ' 
        ' b_consultar
        ' 
        b_consultar.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        b_consultar.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_consultar.ForeColor = SystemColors.ButtonHighlight
        b_consultar.Location = New Point(617, 357)
        b_consultar.Margin = New Padding(0)
        b_consultar.Name = "b_consultar"
        b_consultar.Size = New Size(112, 49)
        b_consultar.TabIndex = 43
        b_consultar.Text = "CONSULTAR"
        b_consultar.UseVisualStyleBackColor = False
        ' 
        ' b_regresar
        ' 
        b_regresar.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        b_regresar.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_regresar.ForeColor = SystemColors.ButtonHighlight
        b_regresar.Location = New Point(161, 331)
        b_regresar.Margin = New Padding(0)
        b_regresar.Name = "b_regresar"
        b_regresar.Size = New Size(112, 49)
        b_regresar.TabIndex = 44
        b_regresar.Text = "REGRESAR"
        b_regresar.UseVisualStyleBackColor = False
        ' 
        ' Insertar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(886, 450)
        Controls.Add(b_regresar)
        Controls.Add(b_consultar)
        Controls.Add(Label7)
        Controls.Add(TextBox7)
        Controls.Add(Label6)
        Controls.Add(TextBox6)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(t_insercionP2)
        Controls.Add(t_InsercionPF)
        Controls.Add(t_incercionP1)
        Controls.Add(Panel1)
        Name = "Insertar"
        Text = "Insertaaa"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents t_insercionP2 As ComboBox
    Friend WithEvents t_InsercionPF As Button
    Friend WithEvents t_incercionP1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents consultar As Button

    Private Sub t_InsercionPF_Click(sender As Object, e As EventArgs) Handles t_InsercionPF.Click

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents b_consultar As Button
    Friend WithEvents b_regresar As Button

    Private Sub b_consultar_Click(sender As Object, e As EventArgs) Handles b_consultar.Click
        consultas.Show()
        Me.Hide()
    End Sub

    Private Sub b_regresar_Click(sender As Object, e As EventArgs) Handles b_regresar.Click
        Inicio.Show()
        Me.Hide()
    End Sub
End Class
