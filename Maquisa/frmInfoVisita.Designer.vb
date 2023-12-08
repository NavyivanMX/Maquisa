<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoVisita
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTCOMENTARIO = New System.Windows.Forms.TextBox()
        Me.LBLFECHAFIN = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBLFECHAINI = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBLFECHA = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLVISITA = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLVENDEDOR = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBLCLIENTE = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.LBLHORAREAGENDADO = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLFECHAREAGENDADO = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTNGUARDACOM = New System.Windows.Forms.Button()
        Me.LBLRESVISITA = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BTNIZQUIERDA = New System.Windows.Forms.Button()
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button()
        Me.GB1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(18, 565)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 22)
        Me.Label2.TabIndex = 1182
        Me.Label2.Text = "Comentario:"
        '
        'TXTCOMENTARIO
        '
        Me.TXTCOMENTARIO.Location = New System.Drawing.Point(23, 586)
        Me.TXTCOMENTARIO.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCOMENTARIO.Multiline = True
        Me.TXTCOMENTARIO.Name = "TXTCOMENTARIO"
        Me.TXTCOMENTARIO.Size = New System.Drawing.Size(833, 172)
        Me.TXTCOMENTARIO.TabIndex = 1183
        '
        'LBLFECHAFIN
        '
        Me.LBLFECHAFIN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLFECHAFIN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLFECHAFIN.Location = New System.Drawing.Point(867, 90)
        Me.LBLFECHAFIN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLFECHAFIN.Name = "LBLFECHAFIN"
        Me.LBLFECHAFIN.Size = New System.Drawing.Size(348, 21)
        Me.LBLFECHAFIN.TabIndex = 1195
        Me.LBLFECHAFIN.Text = "."
        Me.LBLFECHAFIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label13.Location = New System.Drawing.Point(749, 89)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 22)
        Me.Label13.TabIndex = 1194
        Me.Label13.Text = "Fin Visita :"
        '
        'LBLFECHAINI
        '
        Me.LBLFECHAINI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLFECHAINI.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLFECHAINI.Location = New System.Drawing.Point(867, 58)
        Me.LBLFECHAINI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLFECHAINI.Name = "LBLFECHAINI"
        Me.LBLFECHAINI.Size = New System.Drawing.Size(348, 21)
        Me.LBLFECHAINI.TabIndex = 1193
        Me.LBLFECHAINI.Text = "."
        Me.LBLFECHAINI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label9.Location = New System.Drawing.Point(725, 57)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 22)
        Me.Label9.TabIndex = 1192
        Me.Label9.Text = "Inicio Visita :"
        '
        'LBLFECHA
        '
        Me.LBLFECHA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLFECHA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLFECHA.Location = New System.Drawing.Point(867, 28)
        Me.LBLFECHA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLFECHA.Name = "LBLFECHA"
        Me.LBLFECHA.Size = New System.Drawing.Size(348, 21)
        Me.LBLFECHA.TabIndex = 1191
        Me.LBLFECHA.Text = "."
        Me.LBLFECHA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(720, 27)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 22)
        Me.Label7.TabIndex = 1190
        Me.Label7.Text = "Fecha Visita :"
        '
        'LBLVISITA
        '
        Me.LBLVISITA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLVISITA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLVISITA.Location = New System.Drawing.Point(145, 19)
        Me.LBLVISITA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLVISITA.Name = "LBLVISITA"
        Me.LBLVISITA.Size = New System.Drawing.Size(348, 30)
        Me.LBLVISITA.TabIndex = 1189
        Me.LBLVISITA.Text = "."
        Me.LBLVISITA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(53, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 22)
        Me.Label5.TabIndex = 1188
        Me.Label5.Text = "# Visita :"
        '
        'LBLVENDEDOR
        '
        Me.LBLVENDEDOR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLVENDEDOR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLVENDEDOR.Location = New System.Drawing.Point(145, 80)
        Me.LBLVENDEDOR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLVENDEDOR.Name = "LBLVENDEDOR"
        Me.LBLVENDEDOR.Size = New System.Drawing.Size(370, 31)
        Me.LBLVENDEDOR.TabIndex = 1199
        Me.LBLVENDEDOR.Text = "."
        Me.LBLVENDEDOR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label10.Location = New System.Drawing.Point(30, 89)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 22)
        Me.Label10.TabIndex = 1198
        Me.Label10.Text = "Vendedor :"
        '
        'LBLCLIENTE
        '
        Me.LBLCLIENTE.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLCLIENTE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLCLIENTE.Location = New System.Drawing.Point(145, 49)
        Me.LBLCLIENTE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLCLIENTE.Name = "LBLCLIENTE"
        Me.LBLCLIENTE.Size = New System.Drawing.Size(534, 30)
        Me.LBLCLIENTE.TabIndex = 1197
        Me.LBLCLIENTE.Text = "."
        Me.LBLCLIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoEllipsis = True
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label12.Location = New System.Drawing.Point(57, 57)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 22)
        Me.Label12.TabIndex = 1196
        Me.Label12.Text = "Cliente :"
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.LBLHORAREAGENDADO)
        Me.GB1.Controls.Add(Me.Label3)
        Me.GB1.Controls.Add(Me.LBLFECHAREAGENDADO)
        Me.GB1.Controls.Add(Me.Label6)
        Me.GB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.GB1.Location = New System.Drawing.Point(1085, 23)
        Me.GB1.Margin = New System.Windows.Forms.Padding(4)
        Me.GB1.Name = "GB1"
        Me.GB1.Padding = New System.Windows.Forms.Padding(4)
        Me.GB1.Size = New System.Drawing.Size(230, 98)
        Me.GB1.TabIndex = 1204
        Me.GB1.TabStop = False
        Me.GB1.Text = "Reagendado"
        '
        'LBLHORAREAGENDADO
        '
        Me.LBLHORAREAGENDADO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLHORAREAGENDADO.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLHORAREAGENDADO.Location = New System.Drawing.Point(77, 47)
        Me.LBLHORAREAGENDADO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLHORAREAGENDADO.Name = "LBLHORAREAGENDADO"
        Me.LBLHORAREAGENDADO.Size = New System.Drawing.Size(148, 38)
        Me.LBLHORAREAGENDADO.TabIndex = 1207
        Me.LBLHORAREAGENDADO.Text = "."
        Me.LBLHORAREAGENDADO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(11, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 22)
        Me.Label3.TabIndex = 1206
        Me.Label3.Text = "Hora"
        '
        'LBLFECHAREAGENDADO
        '
        Me.LBLFECHAREAGENDADO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLFECHAREAGENDADO.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLFECHAREAGENDADO.Location = New System.Drawing.Point(77, 24)
        Me.LBLFECHAREAGENDADO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLFECHAREAGENDADO.Name = "LBLFECHAREAGENDADO"
        Me.LBLFECHAREAGENDADO.Size = New System.Drawing.Size(133, 26)
        Me.LBLFECHAREAGENDADO.TabIndex = 1205
        Me.LBLFECHAREAGENDADO.Text = "."
        Me.LBLFECHAREAGENDADO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(5, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 22)
        Me.Label6.TabIndex = 1204
        Me.Label6.Text = "Fecha "
        '
        'BTNGUARDACOM
        '
        Me.BTNGUARDACOM.BackColor = System.Drawing.SystemColors.Control
        Me.BTNGUARDACOM.BackgroundImage = Global.Maquisa.My.Resources.Resources.BTNGUARDAR
        Me.BTNGUARDACOM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNGUARDACOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDACOM.ForeColor = System.Drawing.Color.Transparent
        Me.BTNGUARDACOM.Location = New System.Drawing.Point(872, 660)
        Me.BTNGUARDACOM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTNGUARDACOM.Name = "BTNGUARDACOM"
        Me.BTNGUARDACOM.Size = New System.Drawing.Size(107, 98)
        Me.BTNGUARDACOM.TabIndex = 1273
        Me.BTNGUARDACOM.UseVisualStyleBackColor = False
        '
        'LBLRESVISITA
        '
        Me.LBLRESVISITA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLRESVISITA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLRESVISITA.Location = New System.Drawing.Point(868, 123)
        Me.LBLRESVISITA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLRESVISITA.Name = "LBLRESVISITA"
        Me.LBLRESVISITA.Size = New System.Drawing.Size(348, 28)
        Me.LBLRESVISITA.TabIndex = 1275
        Me.LBLRESVISITA.Text = "."
        Me.LBLRESVISITA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label15.Location = New System.Drawing.Point(692, 126)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 22)
        Me.Label15.TabIndex = 1274
        Me.Label15.Text = "Resultado Visita:"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(23, 162)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Size = New System.Drawing.Size(1362, 384)
        Me.DGV.TabIndex = 1276
        '
        'BTNIZQUIERDA
        '
        Me.BTNIZQUIERDA.BackColor = System.Drawing.SystemColors.Control
        Me.BTNIZQUIERDA.BackgroundImage = Global.Maquisa.My.Resources.Resources.BTNIZQUIERDA
        Me.BTNIZQUIERDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNIZQUIERDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIZQUIERDA.ForeColor = System.Drawing.Color.Transparent
        Me.BTNIZQUIERDA.Location = New System.Drawing.Point(1145, 660)
        Me.BTNIZQUIERDA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTNIZQUIERDA.Name = "BTNIZQUIERDA"
        Me.BTNIZQUIERDA.Size = New System.Drawing.Size(107, 98)
        Me.BTNIZQUIERDA.TabIndex = 1277
        Me.BTNIZQUIERDA.Text = "&G"
        Me.BTNIZQUIERDA.UseVisualStyleBackColor = False
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNIMPRIMIR.BackgroundImage = Global.Maquisa.My.Resources.Resources.BTNIMPRIMIR
        Me.BTNIMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNIMPRIMIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIMPRIMIR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(1278, 660)
        Me.BTNIMPRIMIR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(107, 98)
        Me.BTNIMPRIMIR.TabIndex = 1278
        Me.BTNIMPRIMIR.Text = "&G"
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = False
        '
        'frmInfoVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1408, 778)
        Me.Controls.Add(Me.BTNIMPRIMIR)
        Me.Controls.Add(Me.BTNIZQUIERDA)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.LBLRESVISITA)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BTNGUARDACOM)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.LBLVENDEDOR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LBLCLIENTE)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LBLFECHAFIN)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LBLFECHAINI)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LBLFECHA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LBLVISITA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTCOMENTARIO)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInfoVisita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info Visita"
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTCOMENTARIO As TextBox
    Friend WithEvents LBLFECHAFIN As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LBLFECHAINI As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LBLFECHA As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBLVISITA As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLVENDEDOR As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLCLIENTE As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GB1 As GroupBox
    Friend WithEvents LBLHORAREAGENDADO As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBLFECHAREAGENDADO As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNGUARDACOM As Button
    Friend WithEvents LBLRESVISITA As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents BTNIZQUIERDA As Button
    Friend WithEvents BTNIMPRIMIR As Button
End Class
