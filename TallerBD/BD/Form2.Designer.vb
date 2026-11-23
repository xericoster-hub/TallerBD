<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultas
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
        Label1 = New Label()
        seleccion_t1 = New Button()
        seleccion_t3 = New Button()
        seleccion_t2 = New Button()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        b_regresar = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(89), CByte(71), CByte(17))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(921, 111)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bauhaus 93", 21F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(380, 32)
        Label1.Margin = New Padding(0)
        Label1.MaximumSize = New Size(571, 667)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 53)
        Label1.TabIndex = 0
        Label1.Text = "CONSULTAS"
        ' 
        ' seleccion_t1
        ' 
        seleccion_t1.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        seleccion_t1.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        seleccion_t1.ForeColor = SystemColors.ButtonHighlight
        seleccion_t1.Location = New Point(140, 169)
        seleccion_t1.Margin = New Padding(0)
        seleccion_t1.Name = "seleccion_t1"
        seleccion_t1.Size = New Size(112, 49)
        seleccion_t1.TabIndex = 7
        seleccion_t1.Text = "Tabla 1"
        seleccion_t1.UseVisualStyleBackColor = False
        ' 
        ' seleccion_t3
        ' 
        seleccion_t3.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        seleccion_t3.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        seleccion_t3.ForeColor = SystemColors.ButtonHighlight
        seleccion_t3.Location = New Point(140, 407)
        seleccion_t3.Margin = New Padding(0)
        seleccion_t3.Name = "seleccion_t3"
        seleccion_t3.Size = New Size(112, 49)
        seleccion_t3.TabIndex = 8
        seleccion_t3.Text = "Tabla 3"
        seleccion_t3.UseVisualStyleBackColor = False
        ' 
        ' seleccion_t2
        ' 
        seleccion_t2.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        seleccion_t2.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        seleccion_t2.ForeColor = SystemColors.ButtonHighlight
        seleccion_t2.Location = New Point(140, 286)
        seleccion_t2.Margin = New Padding(0)
        seleccion_t2.Name = "seleccion_t2"
        seleccion_t2.Size = New Size(112, 49)
        seleccion_t2.TabIndex = 9
        seleccion_t2.Text = "Tabla 2"
        seleccion_t2.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.Menu
        DataGridView1.Location = New Point(303, 169)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(526, 324)
        DataGridView1.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(389, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 28)
        Label2.TabIndex = 11
        Label2.Text = "SELECCIONA:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' b_regresar
        ' 
        b_regresar.BackColor = Color.FromArgb(CByte(115), CByte(62), CByte(32))
        b_regresar.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        b_regresar.ForeColor = SystemColors.ButtonHighlight
        b_regresar.Location = New Point(21, 462)
        b_regresar.Margin = New Padding(0)
        b_regresar.Name = "b_regresar"
        b_regresar.Size = New Size(112, 49)
        b_regresar.TabIndex = 21
        b_regresar.Text = "REGRESAR"
        b_regresar.UseVisualStyleBackColor = False
        ' 
        ' consultas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(241), CByte(220))
        ClientSize = New Size(914, 600)
        Controls.Add(b_regresar)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(seleccion_t2)
        Controls.Add(seleccion_t3)
        Controls.Add(seleccion_t1)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "consultas"
        Text = "Consulta"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents seleccion_t1 As Button
    Friend WithEvents seleccion_t3 As Button
    Friend WithEvents seleccion_t2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents b_regresar As Button
End Class
