<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRutaMapaClientes
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
        Me.MAPA = New GMap.NET.WindowsForms.GMapControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBTV = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBZOOM = New System.Windows.Forms.TrackBar()
        CType(Me.TBZOOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MAPA.Location = New System.Drawing.Point(13, 65)
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
        Me.MAPA.Size = New System.Drawing.Size(735, 460)
        Me.MAPA.TabIndex = 1359
        Me.MAPA.Zoom = 0R
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 1361
        Me.Label1.Text = "Tipo de Vista"
        '
        'CBTV
        '
        Me.CBTV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTV.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTV.FormattingEnabled = True
        Me.CBTV.Items.AddRange(New Object() {"Camino", "Satelite", "Hibrido", "Terreno"})
        Me.CBTV.Location = New System.Drawing.Point(145, 14)
        Me.CBTV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBTV.Name = "CBTV"
        Me.CBTV.Size = New System.Drawing.Size(225, 30)
        Me.CBTV.TabIndex = 1360
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(413, 11)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 22)
        Me.Label9.TabIndex = 1363
        Me.Label9.Text = "Zoom"
        '
        'TBZOOM
        '
        Me.TBZOOM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBZOOM.LargeChange = 1
        Me.TBZOOM.Location = New System.Drawing.Point(482, 1)
        Me.TBZOOM.Margin = New System.Windows.Forms.Padding(4)
        Me.TBZOOM.Maximum = 17
        Me.TBZOOM.Minimum = 3
        Me.TBZOOM.Name = "TBZOOM"
        Me.TBZOOM.Size = New System.Drawing.Size(225, 56)
        Me.TBZOOM.TabIndex = 1362
        Me.TBZOOM.Value = 16
        '
        'frmRutaMapaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 529)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBZOOM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBTV)
        Me.Controls.Add(Me.MAPA)
        Me.Name = "frmRutaMapaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mapa de Clientes Ruta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TBZOOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MAPA As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents Label1 As Label
    Friend WithEvents CBTV As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBZOOM As TrackBar
End Class
