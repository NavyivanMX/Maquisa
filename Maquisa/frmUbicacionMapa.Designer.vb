﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUbicacionMapa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MAPA = New GMap.NET.WindowsForms.GMapControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLCLI = New System.Windows.Forms.Label()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBDIR = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTDOM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBTV = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBZOOM = New System.Windows.Forms.TrackBar()
        Me.LBLIMG2 = New System.Windows.Forms.PictureBox()
        Me.LBLIMG = New System.Windows.Forms.PictureBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBZOOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLIMG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBLIMG, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MAPA.Location = New System.Drawing.Point(12, 155)
        Me.MAPA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.MAPA.Size = New System.Drawing.Size(1110, 794)
        Me.MAPA.TabIndex = 1343
        Me.MAPA.Zoom = 0R
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(694, 1045)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(434, 27)
        Me.Label6.TabIndex = 1342
        Me.Label6.Text = "Click para establecer ubicación - ruta"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(694, 1017)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(535, 27)
        Me.Label5.TabIndex = 1341
        Me.Label5.Text = "Zoom con la rueda o la barra superior derecha"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(694, 991)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(467, 27)
        Me.Label4.TabIndex = 1340
        Me.Label4.Text = "Botón derecho de mouse mueve el mapa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LBLCLI
        '
        Me.LBLCLI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBLCLI.AutoSize = True
        Me.LBLCLI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCLI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LBLCLI.Location = New System.Drawing.Point(12, 1029)
        Me.LBLCLI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLCLI.Name = "LBLCLI"
        Me.LBLCLI.Size = New System.Drawing.Size(354, 28)
        Me.LBLCLI.TabIndex = 1339
        Me.LBLCLI.Text = "Narciso Ivan Cisneros Acosta"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNGUARDAR.BackColor = System.Drawing.Color.White
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.Black
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.Location = New System.Drawing.Point(1222, 957)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(153, 100)
        Me.BTNGUARDAR.TabIndex = 1338
        Me.BTNGUARDAR.Text = "GUARDAR"
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DGV.Location = New System.Drawing.Point(1138, 103)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.DGV.Size = New System.Drawing.Size(338, 305)
        Me.DGV.TabIndex = 1337
        '
        'Column1
        '
        Me.Column1.HeaderText = "X"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Y"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Button16
        '
        Me.Button16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button16.BackColor = System.Drawing.Color.White
        Me.Button16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.Black
        Me.Button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button16.Location = New System.Drawing.Point(1138, 417)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(153, 52)
        Me.Button16.TabIndex = 1334
        Me.Button16.Text = "Mapa 1"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(1332, 417)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(144, 52)
        Me.Button8.TabIndex = 1333
        Me.Button8.Text = "Mapa 2"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 27)
        Me.Label3.TabIndex = 1332
        Me.Label3.Text = "Resultados"
        '
        'CBDIR
        '
        Me.CBDIR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDIR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDIR.FormattingEnabled = True
        Me.CBDIR.Items.AddRange(New Object() {"Camino", "Satelite", "Hibrido", "Terreno"})
        Me.CBDIR.Location = New System.Drawing.Point(154, 106)
        Me.CBDIR.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CBDIR.Name = "CBDIR"
        Me.CBDIR.Size = New System.Drawing.Size(974, 35)
        Me.CBDIR.TabIndex = 1331
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(862, 27)
        Me.Label2.TabIndex = 1330
        Me.Label2.Text = "Domicilio (Calle, Colonia, Locacion, No Exterior. No incluir Nte,Sur,Ote,Pte)  "
        '
        'TXTDOM
        '
        Me.TXTDOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDOM.Location = New System.Drawing.Point(12, 52)
        Me.TXTDOM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTDOM.Name = "TXTDOM"
        Me.TXTDOM.Size = New System.Drawing.Size(901, 35)
        Me.TXTDOM.TabIndex = 1329
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(920, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 27)
        Me.Label1.TabIndex = 1328
        Me.Label1.Text = "Tipo de Vista"
        '
        'CBTV
        '
        Me.CBTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTV.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTV.FormattingEnabled = True
        Me.CBTV.Items.AddRange(New Object() {"Camino", "Satelite", "Hibrido", "Terreno"})
        Me.CBTV.Location = New System.Drawing.Point(924, 54)
        Me.CBTV.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CBTV.Name = "CBTV"
        Me.CBTV.Size = New System.Drawing.Size(253, 35)
        Me.CBTV.TabIndex = 1327
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1200, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 27)
        Me.Label9.TabIndex = 1326
        Me.Label9.Text = "Zoom"
        '
        'TBZOOM
        '
        Me.TBZOOM.LargeChange = 1
        Me.TBZOOM.Location = New System.Drawing.Point(1190, 52)
        Me.TBZOOM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBZOOM.Maximum = 17
        Me.TBZOOM.Minimum = 3
        Me.TBZOOM.Name = "TBZOOM"
        Me.TBZOOM.Size = New System.Drawing.Size(286, 69)
        Me.TBZOOM.TabIndex = 1325
        Me.TBZOOM.Value = 16
        '
        'LBLIMG2
        '
        Me.LBLIMG2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLIMG2.Location = New System.Drawing.Point(1138, 723)
        Me.LBLIMG2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LBLIMG2.Name = "LBLIMG2"
        Me.LBLIMG2.Size = New System.Drawing.Size(338, 225)
        Me.LBLIMG2.TabIndex = 1336
        Me.LBLIMG2.TabStop = False
        '
        'LBLIMG
        '
        Me.LBLIMG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLIMG.Location = New System.Drawing.Point(1138, 489)
        Me.LBLIMG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LBLIMG.Name = "LBLIMG"
        Me.LBLIMG.Size = New System.Drawing.Size(338, 225)
        Me.LBLIMG.TabIndex = 1335
        Me.LBLIMG.TabStop = False
        '
        'frmUbicacionMapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1490, 1092)
        Me.Controls.Add(Me.MAPA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBLCLI)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.LBLIMG2)
        Me.Controls.Add(Me.LBLIMG)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBDIR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTDOM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBTV)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBZOOM)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmUbicacionMapa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubicación Mapa"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBZOOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLIMG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBLIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MAPA As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LBLCLI As Label
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents LBLIMG2 As PictureBox
    Friend WithEvents LBLIMG As PictureBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CBDIR As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTDOM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBTV As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBZOOM As TrackBar
End Class