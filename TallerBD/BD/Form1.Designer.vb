<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        EtiBienvenida = New Label()
        b_consultar = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel1 = New Panel()
        b_insertar = New Button()
        b_modificar = New Button()
        b_eliminar = New Button()
        Label1 = New Label()
        b_salida = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' EtiBienvenida
        ' 
        EtiBienvenida.BackColor = Color.Transparent
        EtiBienvenida.Font = New Font("Bauhaus 93", 21F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EtiBienvenida.ForeColor = Color.White
        EtiBienvenida.Location = New Point(312, 35)
        EtiBienvenida.Margin = New Padding(0)
        EtiBienvenida.MaximumSize = New Size(571, 667)
        EtiBienvenida.Name = "EtiBienvenida"
        EtiBienvenida.Size = New Size(208, 53)
        EtiBienvenida.TabIndex = 0
        EtiBienvenida.Text = "BIENVENIDO"
        ' 
        ' b_consultar
        ' 
        b_consultar.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        b_consultar.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_consultar.ForeColor = SystemColors.ButtonHighlight
        b_consultar.Location = New Point(357, 192)
        b_consultar.Margin = New Padding(0)
        b_consultar.Name = "b_consultar"
        b_consultar.Size = New Size(112, 49)
        b_consultar.TabIndex = 1
        b_consultar.Text = "CONSULTAR"
        b_consultar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(89), CByte(71), CByte(17))
        Panel1.Controls.Add(EtiBienvenida)
        Panel1.Location = New Point(0, 1)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(841, 107)
        Panel1.TabIndex = 5
        ' 
        ' b_insertar
        ' 
        b_insertar.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        b_insertar.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_insertar.ForeColor = SystemColors.ButtonHighlight
        b_insertar.Location = New Point(357, 283)
        b_insertar.Margin = New Padding(0)
        b_insertar.Name = "b_insertar"
        b_insertar.Size = New Size(112, 49)
        b_insertar.TabIndex = 6
        b_insertar.Text = "INSERTAR"
        b_insertar.UseVisualStyleBackColor = False
        ' 
        ' b_modificar
        ' 
        b_modificar.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        b_modificar.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_modificar.ForeColor = SystemColors.ButtonHighlight
        b_modificar.Location = New Point(357, 380)
        b_modificar.Margin = New Padding(0)
        b_modificar.Name = "b_modificar"
        b_modificar.Size = New Size(112, 49)
        b_modificar.TabIndex = 7
        b_modificar.Text = "MODIFICAR"
        b_modificar.UseVisualStyleBackColor = False
        ' 
        ' b_eliminar
        ' 
        b_eliminar.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        b_eliminar.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_eliminar.ForeColor = SystemColors.ButtonHighlight
        b_eliminar.Location = New Point(357, 475)
        b_eliminar.Margin = New Padding(0)
        b_eliminar.Name = "b_eliminar"
        b_eliminar.Size = New Size(112, 49)
        b_eliminar.TabIndex = 8
        b_eliminar.Text = "ELIMINAR"
        b_eliminar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(344, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 28)
        Label1.TabIndex = 9
        Label1.Text = "SELECCIONA:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' b_salida
        ' 
        b_salida.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        b_salida.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_salida.ForeColor = SystemColors.ButtonHighlight
        b_salida.Location = New Point(681, 448)
        b_salida.Margin = New Padding(0)
        b_salida.Name = "b_salida"
        b_salida.Size = New Size(112, 49)
        b_salida.TabIndex = 21
        b_salida.Text = "SALIR"
        b_salida.UseVisualStyleBackColor = False
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(241), CByte(220))
        ClientSize = New Size(839, 519)
        Controls.Add(b_salida)
        Controls.Add(Label1)
        Controls.Add(b_eliminar)
        Controls.Add(b_modificar)
        Controls.Add(b_insertar)
        Controls.Add(Panel1)
        Controls.Add(b_consultar)
        ForeColor = SystemColors.ActiveCaptionText
        Margin = New Padding(3, 4, 3, 4)
        Name = "Inicio"
        Text = "Inicio"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EtiBienvenida As Label
    Friend WithEvents b_consultar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents b_insertar As Button
    Friend WithEvents b_modificar As Button
    Friend WithEvents b_eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents b_salida As Button

End Class
