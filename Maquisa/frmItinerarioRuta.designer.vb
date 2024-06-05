<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItinerarioRuta
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
        Me.LBLANT = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBR = New System.Windows.Forms.ComboBox()
        Me.CBSUC = New System.Windows.Forms.ComboBox()
        Me.CBD = New System.Windows.Forms.ComboBox()
        Me.DGV3 = New System.Windows.Forms.DataGridView()
        Me.LBLCANT = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNQUITAR = New System.Windows.Forms.Button()
        Me.BTNAGREGAR = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.BTNNIVPROX = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLVENDEDOR = New System.Windows.Forms.Label()
        Me.CBCLI = New System.Windows.Forms.ComboBox()
        Me.BTNNIVANT = New System.Windows.Forms.Button()
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVECLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLANT
        '
        Me.LBLANT.AutoSize = True
        Me.LBLANT.BackColor = System.Drawing.Color.Transparent
        Me.LBLANT.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLANT.Location = New System.Drawing.Point(30, 126)
        Me.LBLANT.Name = "LBLANT"
        Me.LBLANT.Size = New System.Drawing.Size(32, 17)
        Me.LBLANT.TabIndex = 1091
        Me.LBLANT.Text = "Día"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(622, 508)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 1092
        Me.Label1.Text = "Bajar orden"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(622, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 1093
        Me.Label2.Text = "Subir orden"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(9, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 1097
        Me.Label6.Text = "Sucursal"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(73, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 1098
        Me.Label7.Text = "Ruta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label8.Location = New System.Drawing.Point(228, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 17)
        Me.Label8.TabIndex = 1099
        Me.Label8.Text = "Cliente"
        '
        'CBR
        '
        Me.CBR.BackColor = System.Drawing.SystemColors.Control
        Me.CBR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.CBR.FormattingEnabled = True
        Me.CBR.Location = New System.Drawing.Point(117, 20)
        Me.CBR.Name = "CBR"
        Me.CBR.Size = New System.Drawing.Size(350, 25)
        Me.CBR.TabIndex = 1246
        '
        'CBSUC
        '
        Me.CBSUC.BackColor = System.Drawing.SystemColors.Control
        Me.CBSUC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSUC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.CBSUC.FormattingEnabled = True
        Me.CBSUC.Location = New System.Drawing.Point(7, 44)
        Me.CBSUC.Name = "CBSUC"
        Me.CBSUC.Size = New System.Drawing.Size(55, 25)
        Me.CBSUC.TabIndex = 1247
        Me.CBSUC.Visible = False
        '
        'CBD
        '
        Me.CBD.BackColor = System.Drawing.SystemColors.Control
        Me.CBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.CBD.FormattingEnabled = True
        Me.CBD.Items.AddRange(New Object() {"LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO"})
        Me.CBD.Location = New System.Drawing.Point(68, 125)
        Me.CBD.Name = "CBD"
        Me.CBD.Size = New System.Drawing.Size(150, 25)
        Me.CBD.TabIndex = 1250
        '
        'DGV3
        '
        Me.DGV3.AllowUserToAddRows = False
        Me.DGV3.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIENTE, Me.ORDEN, Me.CVECLIENTE})
        Me.DGV3.Location = New System.Drawing.Point(29, 168)
        Me.DGV3.Name = "DGV3"
        Me.DGV3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV3.Size = New System.Drawing.Size(553, 471)
        Me.DGV3.TabIndex = 1251
        '
        'LBLCANT
        '
        Me.LBLCANT.AutoSize = True
        Me.LBLCANT.BackColor = System.Drawing.Color.Transparent
        Me.LBLCANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCANT.Location = New System.Drawing.Point(12, 556)
        Me.LBLCANT.Name = "LBLCANT"
        Me.LBLCANT.Size = New System.Drawing.Size(13, 20)
        Me.LBLCANT.TabIndex = 1252
        Me.LBLCANT.Text = "."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(287, 81)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 35)
        Me.Button1.TabIndex = 1253
        Me.Button1.Text = "Alta Clientes"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNGUARDAR.Location = New System.Drawing.Point(625, 556)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNGUARDAR.TabIndex = 1257
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'BTNQUITAR
        '
        Me.BTNQUITAR.BackColor = System.Drawing.Color.White
        Me.BTNQUITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNQUITAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNQUITAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNQUITAR.Location = New System.Drawing.Point(624, 204)
        Me.BTNQUITAR.Name = "BTNQUITAR"
        Me.BTNQUITAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNQUITAR.TabIndex = 1256
        Me.BTNQUITAR.UseVisualStyleBackColor = False
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.Color.White
        Me.BTNAGREGAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNAGREGAR.Location = New System.Drawing.Point(624, 120)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(80, 78)
        Me.BTNAGREGAR.TabIndex = 1255
        Me.BTNAGREGAR.UseVisualStyleBackColor = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Location = New System.Drawing.Point(582, 15)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNCANCELAR.TabIndex = 1249
        Me.BTNCANCELAR.UseVisualStyleBackColor = False
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNACEPTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNACEPTAR.Location = New System.Drawing.Point(495, 15)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNACEPTAR.TabIndex = 1248
        Me.BTNACEPTAR.UseVisualStyleBackColor = False
        '
        'BTNNIVPROX
        '
        Me.BTNNIVPROX.BackColor = System.Drawing.Color.White
        Me.BTNNIVPROX.BackgroundImage = Global.Maquisa.My.Resources.Resources.BTNIZQUIERDA
        Me.BTNNIVPROX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNNIVPROX.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNIVPROX.ForeColor = System.Drawing.Color.Black
        Me.BTNNIVPROX.Location = New System.Drawing.Point(625, 429)
        Me.BTNNIVPROX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNNIVPROX.Name = "BTNNIVPROX"
        Me.BTNNIVPROX.Size = New System.Drawing.Size(79, 75)
        Me.BTNNIVPROX.TabIndex = 1240
        Me.BTNNIVPROX.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(121, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 1258
        Me.Label3.Text = "Vendedor"
        '
        'LBLVENDEDOR
        '
        Me.LBLVENDEDOR.AutoSize = True
        Me.LBLVENDEDOR.BackColor = System.Drawing.Color.Transparent
        Me.LBLVENDEDOR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLVENDEDOR.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LBLVENDEDOR.Location = New System.Drawing.Point(202, 54)
        Me.LBLVENDEDOR.Name = "LBLVENDEDOR"
        Me.LBLVENDEDOR.Size = New System.Drawing.Size(13, 17)
        Me.LBLVENDEDOR.TabIndex = 1259
        Me.LBLVENDEDOR.Text = "."
        '
        'CBCLI
        '
        Me.CBCLI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBCLI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCLI.BackColor = System.Drawing.SystemColors.Control
        Me.CBCLI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.CBCLI.FormattingEnabled = True
        Me.CBCLI.Items.AddRange(New Object() {"LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO"})
        Me.CBCLI.Location = New System.Drawing.Point(287, 125)
        Me.CBCLI.Name = "CBCLI"
        Me.CBCLI.Size = New System.Drawing.Size(295, 25)
        Me.CBCLI.TabIndex = 1260
        '
        'BTNNIVANT
        '
        Me.BTNNIVANT.BackColor = System.Drawing.Color.White
        Me.BTNNIVANT.BackgroundImage = Global.Maquisa.My.Resources.Resources.BTNDERECHA
        Me.BTNNIVANT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNNIVANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNIVANT.ForeColor = System.Drawing.Color.Black
        Me.BTNNIVANT.Location = New System.Drawing.Point(625, 307)
        Me.BTNNIVANT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNNIVANT.Name = "BTNNIVANT"
        Me.BTNNIVANT.Size = New System.Drawing.Size(79, 74)
        Me.BTNNIVANT.TabIndex = 1241
        Me.BTNNIVANT.UseVisualStyleBackColor = False
        '
        'CLIENTE
        '
        Me.CLIENTE.HeaderText = "CLIENTE"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.ReadOnly = True
        Me.CLIENTE.Width = 400
        '
        'ORDEN
        '
        Me.ORDEN.HeaderText = "ORDEN"
        Me.ORDEN.Name = "ORDEN"
        Me.ORDEN.ReadOnly = True
        Me.ORDEN.Width = 200
        '
        'CVECLIENTE
        '
        Me.CVECLIENTE.HeaderText = "CVECLIENTE"
        Me.CVECLIENTE.Name = "CVECLIENTE"
        Me.CVECLIENTE.ReadOnly = True
        Me.CVECLIENTE.Visible = False
        '
        'frmItinerarioRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 674)
        Me.Controls.Add(Me.CBCLI)
        Me.Controls.Add(Me.LBLVENDEDOR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.BTNQUITAR)
        Me.Controls.Add(Me.BTNAGREGAR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBLCANT)
        Me.Controls.Add(Me.DGV3)
        Me.Controls.Add(Me.CBD)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Controls.Add(Me.CBSUC)
        Me.Controls.Add(Me.CBR)
        Me.Controls.Add(Me.BTNNIVANT)
        Me.Controls.Add(Me.BTNNIVPROX)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLANT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItinerarioRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Itinerario ruta"
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLANT As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents BTNNIVANT As System.Windows.Forms.Button
    Private WithEvents BTNNIVPROX As System.Windows.Forms.Button
    Friend WithEvents CBR As System.Windows.Forms.ComboBox
    Friend WithEvents CBSUC As System.Windows.Forms.ComboBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents CBD As System.Windows.Forms.ComboBox
    Friend WithEvents DGV3 As System.Windows.Forms.DataGridView
    Friend WithEvents LBLCANT As System.Windows.Forms.Label
    Private WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Private WithEvents BTNQUITAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LBLVENDEDOR As Label
    Friend WithEvents CBCLI As ComboBox
    Friend WithEvents CLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents ORDEN As DataGridViewTextBoxColumn
    Friend WithEvents CVECLIENTE As DataGridViewTextBoxColumn
End Class
