<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteMapa
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
        Me.TBZOOM = New System.Windows.Forms.TrackBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBTV = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBVEN = New System.Windows.Forms.ComboBox()
        Me.LBLVENDEDOR = New System.Windows.Forms.Label()
        Me.MAPA = New GMap.NET.WindowsForms.GMapControl()
        Me.LBLRUTA = New System.Windows.Forms.Label()
        Me.CBRUTA = New System.Windows.Forms.ComboBox()
        Me.RBVEN = New System.Windows.Forms.RadioButton()
        Me.RBRUTA = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTDE = New System.Windows.Forms.DateTimePicker()
        Me.BTNMOSTRAR = New System.Windows.Forms.Button()
        CType(Me.TBZOOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBZOOM
        '
        Me.TBZOOM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBZOOM.LargeChange = 1
        Me.TBZOOM.Location = New System.Drawing.Point(872, 59)
        Me.TBZOOM.Margin = New System.Windows.Forms.Padding(4)
        Me.TBZOOM.Maximum = 17
        Me.TBZOOM.Minimum = 3
        Me.TBZOOM.Name = "TBZOOM"
        Me.TBZOOM.Size = New System.Drawing.Size(225, 56)
        Me.TBZOOM.TabIndex = 1344
        Me.TBZOOM.Value = 16
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(803, 69)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 22)
        Me.Label9.TabIndex = 1345
        Me.Label9.Text = "Zoom"
        '
        'CBTV
        '
        Me.CBTV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTV.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTV.FormattingEnabled = True
        Me.CBTV.Items.AddRange(New Object() {"Camino", "Satelite", "Hibrido", "Terreno"})
        Me.CBTV.Location = New System.Drawing.Point(872, 9)
        Me.CBTV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBTV.Name = "CBTV"
        Me.CBTV.Size = New System.Drawing.Size(225, 30)
        Me.CBTV.TabIndex = 1346
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(735, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 1347
        Me.Label1.Text = "Tipo de Vista"
        '
        'CBVEN
        '
        Me.CBVEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBVEN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBVEN.FormattingEnabled = True
        Me.CBVEN.Items.AddRange(New Object() {"Camino", "Satelite", "Hibrido", "Terreno"})
        Me.CBVEN.Location = New System.Drawing.Point(139, 68)
        Me.CBVEN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBVEN.Name = "CBVEN"
        Me.CBVEN.Size = New System.Drawing.Size(455, 30)
        Me.CBVEN.TabIndex = 1350
        '
        'LBLVENDEDOR
        '
        Me.LBLVENDEDOR.AutoSize = True
        Me.LBLVENDEDOR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLVENDEDOR.Location = New System.Drawing.Point(11, 71)
        Me.LBLVENDEDOR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLVENDEDOR.Name = "LBLVENDEDOR"
        Me.LBLVENDEDOR.Size = New System.Drawing.Size(120, 22)
        Me.LBLVENDEDOR.TabIndex = 1351
        Me.LBLVENDEDOR.Text = "Vendedores"
        '
        'MAPA
        '
        Me.MAPA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MAPA.Bearing = 0!
        Me.MAPA.CanDragMap = False
        Me.MAPA.EmptyTileColor = System.Drawing.Color.Navy
        Me.MAPA.GrayScaleMode = False
        Me.MAPA.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.MAPA.LevelsKeepInMemory = 5
        Me.MAPA.Location = New System.Drawing.Point(15, 123)
        Me.MAPA.Margin = New System.Windows.Forms.Padding(4)
        Me.MAPA.MarkersEnabled = True
        Me.MAPA.MaxZoom = 2
        Me.MAPA.MinZoom = 2
        Me.MAPA.MouseWheelZoomEnabled = True
        Me.MAPA.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.MAPA.Name = "MAPA"
        Me.MAPA.NegativeMode = False
        Me.MAPA.PolygonsEnabled = True
        Me.MAPA.RetryLoadTile = 0
        Me.MAPA.RoutesEnabled = True
        Me.MAPA.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.MAPA.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MAPA.ShowTileGridLines = False
        Me.MAPA.Size = New System.Drawing.Size(1085, 414)
        Me.MAPA.TabIndex = 1358
        Me.MAPA.Zoom = 0R
        '
        'LBLRUTA
        '
        Me.LBLRUTA.AutoSize = True
        Me.LBLRUTA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRUTA.Location = New System.Drawing.Point(68, 71)
        Me.LBLRUTA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLRUTA.Name = "LBLRUTA"
        Me.LBLRUTA.Size = New System.Drawing.Size(63, 22)
        Me.LBLRUTA.TabIndex = 1360
        Me.LBLRUTA.Text = "Rutas"
        '
        'CBRUTA
        '
        Me.CBRUTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBRUTA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRUTA.FormattingEnabled = True
        Me.CBRUTA.Items.AddRange(New Object() {"Camino", "Satelite", "Hibrido", "Terreno"})
        Me.CBRUTA.Location = New System.Drawing.Point(139, 68)
        Me.CBRUTA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBRUTA.Name = "CBRUTA"
        Me.CBRUTA.Size = New System.Drawing.Size(455, 30)
        Me.CBRUTA.TabIndex = 1359
        '
        'RBVEN
        '
        Me.RBVEN.AutoSize = True
        Me.RBVEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBVEN.Location = New System.Drawing.Point(14, 24)
        Me.RBVEN.Name = "RBVEN"
        Me.RBVEN.Size = New System.Drawing.Size(129, 24)
        Me.RBVEN.TabIndex = 1361
        Me.RBVEN.TabStop = True
        Me.RBVEN.Text = "Vendedores"
        Me.RBVEN.UseVisualStyleBackColor = True
        '
        'RBRUTA
        '
        Me.RBRUTA.AutoSize = True
        Me.RBRUTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBRUTA.Location = New System.Drawing.Point(170, 24)
        Me.RBRUTA.Name = "RBRUTA"
        Me.RBRUTA.Size = New System.Drawing.Size(79, 24)
        Me.RBRUTA.TabIndex = 1362
        Me.RBRUTA.TabStop = True
        Me.RBRUTA.Text = "Rutas"
        Me.RBRUTA.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 22)
        Me.Label2.TabIndex = 1363
        Me.Label2.Text = "Fecha"
        '
        'DTDE
        '
        Me.DTDE.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDE.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDE.Location = New System.Drawing.Point(380, 19)
        Me.DTDE.Margin = New System.Windows.Forms.Padding(4)
        Me.DTDE.Name = "DTDE"
        Me.DTDE.Size = New System.Drawing.Size(172, 29)
        Me.DTDE.TabIndex = 1364
        '
        'BTNMOSTRAR
        '
        Me.BTNMOSTRAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNMOSTRAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMOSTRAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNMOSTRAR.Image = Global.Maquisa.My.Resources.Resources.BTNBUSCAR
        Me.BTNMOSTRAR.Location = New System.Drawing.Point(617, 9)
        Me.BTNMOSTRAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTNMOSTRAR.Name = "BTNMOSTRAR"
        Me.BTNMOSTRAR.Size = New System.Drawing.Size(107, 98)
        Me.BTNMOSTRAR.TabIndex = 1365
        Me.BTNMOSTRAR.UseVisualStyleBackColor = False
        '
        'frmReporteMapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 550)
        Me.Controls.Add(Me.BTNMOSTRAR)
        Me.Controls.Add(Me.DTDE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RBRUTA)
        Me.Controls.Add(Me.RBVEN)
        Me.Controls.Add(Me.LBLRUTA)
        Me.Controls.Add(Me.CBRUTA)
        Me.Controls.Add(Me.MAPA)
        Me.Controls.Add(Me.LBLVENDEDOR)
        Me.Controls.Add(Me.CBVEN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBTV)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBZOOM)
        Me.Name = "frmReporteMapa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Rutas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TBZOOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBZOOM As TrackBar
    Friend WithEvents Label9 As Label
    Friend WithEvents CBTV As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBVEN As ComboBox
    Friend WithEvents LBLVENDEDOR As Label
    Friend WithEvents MAPA As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents LBLRUTA As Label
    Friend WithEvents CBRUTA As ComboBox
    Friend WithEvents RBVEN As RadioButton
    Friend WithEvents RBRUTA As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents DTDE As DateTimePicker
    Friend WithEvents BTNMOSTRAR As Button
End Class
