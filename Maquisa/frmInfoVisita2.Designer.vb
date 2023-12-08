<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoVisita2
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLVENDEDOR = New System.Windows.Forms.Label()
        Me.LBLVISITA = New System.Windows.Forms.Label()
        Me.LBLCLIENTE = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLFECHAINI = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLFECHAFIN = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLFECHA = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLRESVISITA = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNIZQUIERDA = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.TXTCOMENTARIO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.LBLHORAREAGENDADO = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.Label()
        Me.LBLFECHAREAGENDADO = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 1284
        Me.Label6.Text = "Visita #:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 1282
        Me.Label5.Text = "Vendedor:"
        '
        'LBLVENDEDOR
        '
        Me.LBLVENDEDOR.AutoSize = True
        Me.LBLVENDEDOR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLVENDEDOR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLVENDEDOR.Location = New System.Drawing.Point(86, 57)
        Me.LBLVENDEDOR.Name = "LBLVENDEDOR"
        Me.LBLVENDEDOR.Size = New System.Drawing.Size(11, 15)
        Me.LBLVENDEDOR.TabIndex = 1283
        Me.LBLVENDEDOR.Text = "."
        '
        'LBLVISITA
        '
        Me.LBLVISITA.AutoSize = True
        Me.LBLVISITA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLVISITA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLVISITA.Location = New System.Drawing.Point(86, 9)
        Me.LBLVISITA.Name = "LBLVISITA"
        Me.LBLVISITA.Size = New System.Drawing.Size(11, 15)
        Me.LBLVISITA.TabIndex = 1285
        Me.LBLVISITA.Text = "."
        '
        'LBLCLIENTE
        '
        Me.LBLCLIENTE.AutoSize = True
        Me.LBLCLIENTE.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCLIENTE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLCLIENTE.Location = New System.Drawing.Point(86, 32)
        Me.LBLCLIENTE.Name = "LBLCLIENTE"
        Me.LBLCLIENTE.Size = New System.Drawing.Size(11, 15)
        Me.LBLCLIENTE.TabIndex = 1287
        Me.LBLCLIENTE.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 1286
        Me.Label2.Text = "Cliente:"
        '
        'LBLFECHAINI
        '
        Me.LBLFECHAINI.AutoSize = True
        Me.LBLFECHAINI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFECHAINI.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLFECHAINI.Location = New System.Drawing.Point(86, 81)
        Me.LBLFECHAINI.Name = "LBLFECHAINI"
        Me.LBLFECHAINI.Size = New System.Drawing.Size(11, 15)
        Me.LBLFECHAINI.TabIndex = 1289
        Me.LBLFECHAINI.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 1288
        Me.Label3.Text = "Hora Ini:"
        '
        'LBLFECHAFIN
        '
        Me.LBLFECHAFIN.AutoSize = True
        Me.LBLFECHAFIN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFECHAFIN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLFECHAFIN.Location = New System.Drawing.Point(86, 105)
        Me.LBLFECHAFIN.Name = "LBLFECHAFIN"
        Me.LBLFECHAFIN.Size = New System.Drawing.Size(11, 15)
        Me.LBLFECHAFIN.TabIndex = 1291
        Me.LBLFECHAFIN.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 1290
        Me.Label4.Text = "Hora Fin:"
        '
        'LBLFECHA
        '
        Me.LBLFECHA.AutoSize = True
        Me.LBLFECHA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFECHA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLFECHA.Location = New System.Drawing.Point(463, 9)
        Me.LBLFECHA.Name = "LBLFECHA"
        Me.LBLFECHA.Size = New System.Drawing.Size(11, 15)
        Me.LBLFECHA.TabIndex = 1293
        Me.LBLFECHA.Text = "."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(406, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 1292
        Me.Label7.Text = "Fecha :"
        '
        'LBLRESVISITA
        '
        Me.LBLRESVISITA.AutoSize = True
        Me.LBLRESVISITA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRESVISITA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLRESVISITA.Location = New System.Drawing.Point(463, 86)
        Me.LBLRESVISITA.Name = "LBLRESVISITA"
        Me.LBLRESVISITA.Size = New System.Drawing.Size(11, 15)
        Me.LBLRESVISITA.TabIndex = 1295
        Me.LBLRESVISITA.Text = "."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(341, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 15)
        Me.Label8.TabIndex = 1294
        Me.Label8.Text = "Resultado Visita:"
        '
        'BTNIZQUIERDA
        '
        Me.BTNIZQUIERDA.BackColor = System.Drawing.SystemColors.Control
        Me.BTNIZQUIERDA.BackgroundImage = Global.Maquisa.My.Resources.Resources.BTNIZQUIERDA
        Me.BTNIZQUIERDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNIZQUIERDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIZQUIERDA.ForeColor = System.Drawing.Color.Transparent
        Me.BTNIZQUIERDA.Location = New System.Drawing.Point(919, 13)
        Me.BTNIZQUIERDA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNIZQUIERDA.Name = "BTNIZQUIERDA"
        Me.BTNIZQUIERDA.Size = New System.Drawing.Size(80, 80)
        Me.BTNIZQUIERDA.TabIndex = 1296
        Me.BTNIZQUIERDA.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(10, 130)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV.Size = New System.Drawing.Size(989, 364)
        Me.DGV.TabIndex = 1297
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNGUARDAR.BackgroundImage = Global.Maquisa.My.Resources.Resources.BTNGUARDAR
        Me.BTNGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNGUARDAR.Location = New System.Drawing.Point(919, 516)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNGUARDAR.TabIndex = 1298
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'TXTCOMENTARIO
        '
        Me.TXTCOMENTARIO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOMENTARIO.Location = New System.Drawing.Point(10, 516)
        Me.TXTCOMENTARIO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCOMENTARIO.MaxLength = 199
        Me.TXTCOMENTARIO.Multiline = True
        Me.TXTCOMENTARIO.Name = "TXTCOMENTARIO"
        Me.TXTCOMENTARIO.Size = New System.Drawing.Size(885, 80)
        Me.TXTCOMENTARIO.TabIndex = 1299
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 497)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 1300
        Me.Label1.Text = "Comentario:"
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.LBLHORAREAGENDADO)
        Me.GB1.Controls.Add(Me.Hora)
        Me.GB1.Controls.Add(Me.LBLFECHAREAGENDADO)
        Me.GB1.Controls.Add(Me.Label10)
        Me.GB1.Location = New System.Drawing.Point(595, 12)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(290, 107)
        Me.GB1.TabIndex = 1301
        Me.GB1.TabStop = False
        Me.GB1.Text = "Reagendado"
        '
        'LBLHORAREAGENDADO
        '
        Me.LBLHORAREAGENDADO.AutoSize = True
        Me.LBLHORAREAGENDADO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHORAREAGENDADO.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLHORAREAGENDADO.Location = New System.Drawing.Point(64, 74)
        Me.LBLHORAREAGENDADO.Name = "LBLHORAREAGENDADO"
        Me.LBLHORAREAGENDADO.Size = New System.Drawing.Size(11, 15)
        Me.LBLHORAREAGENDADO.TabIndex = 1297
        Me.LBLHORAREAGENDADO.Text = "."
        '
        'Hora
        '
        Me.Hora.AutoSize = True
        Me.Hora.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.Location = New System.Drawing.Point(6, 74)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(46, 15)
        Me.Hora.TabIndex = 1296
        Me.Hora.Text = "Hora :"
        '
        'LBLFECHAREAGENDADO
        '
        Me.LBLFECHAREAGENDADO.AutoSize = True
        Me.LBLFECHAREAGENDADO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFECHAREAGENDADO.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLFECHAREAGENDADO.Location = New System.Drawing.Point(64, 35)
        Me.LBLFECHAREAGENDADO.Name = "LBLFECHAREAGENDADO"
        Me.LBLFECHAREAGENDADO.Size = New System.Drawing.Size(11, 15)
        Me.LBLFECHAREAGENDADO.TabIndex = 1295
        Me.LBLFECHAREAGENDADO.Text = "."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 15)
        Me.Label10.TabIndex = 1294
        Me.Label10.Text = "Fecha :"
        '
        'frmInfoVisita2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTCOMENTARIO)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BTNIZQUIERDA)
        Me.Controls.Add(Me.LBLRESVISITA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LBLFECHA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LBLFECHAFIN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBLFECHAINI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBLCLIENTE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBLVISITA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LBLVENDEDOR)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmInfoVisita2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info Visita"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLVENDEDOR As Label
    Friend WithEvents LBLVISITA As Label
    Friend WithEvents LBLCLIENTE As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBLFECHAINI As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBLFECHAFIN As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LBLFECHA As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBLRESVISITA As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BTNIZQUIERDA As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents TXTCOMENTARIO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GB1 As GroupBox
    Friend WithEvents LBLFECHAREAGENDADO As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLHORAREAGENDADO As Label
    Friend WithEvents Hora As Label
End Class
