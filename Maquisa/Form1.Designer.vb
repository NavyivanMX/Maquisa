﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.SB = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MM1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.S2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RutaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MM2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItinerarioRutasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MM3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapaVendedorRutaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapaClientesEnRutaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MM4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S61 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S66 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KardexVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LBLPRU = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLV = New System.Windows.Forms.Label()
        Me.PBS = New System.Windows.Forms.PictureBox()
        Me.LBLP = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PBCNC = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VERMAP = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SB.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCNC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SB
        '
        Me.SB.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.SB.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.SB.Location = New System.Drawing.Point(0, 536)
        Me.SB.Name = "SB"
        Me.SB.Size = New System.Drawing.Size(1030, 22)
        Me.SB.TabIndex = 47
        Me.SB.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(99, 17)
        Me.ToolStripStatusLabel7.Text = "Mazatlán, Sinaloa"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(52, 17)
        Me.ToolStripStatusLabel8.Text = "Maquisa"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(92, 17)
        Me.ToolStripStatusLabel2.Text = "Versión:  .net 4.0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Orange
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MM1, Me.MM2, Me.MM3, Me.MM4, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1030, 28)
        Me.MenuStrip1.TabIndex = 48
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MM1
        '
        Me.MM1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.S1, Me.S4, Me.ToolStripMenuItem3, Me.S2, Me.S5, Me.ToolStripMenuItem2, Me.RutaToolStripMenuItem})
        Me.MM1.Name = "MM1"
        Me.MM1.Size = New System.Drawing.Size(75, 24)
        Me.MM1.Text = "&Archivo"
        '
        'S1
        '
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(180, 24)
        Me.S1.Text = "Empresa"
        '
        'S4
        '
        Me.S4.Name = "S4"
        Me.S4.Size = New System.Drawing.Size(180, 24)
        Me.S4.Text = "Usuarios"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(177, 6)
        '
        'S2
        '
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(180, 24)
        Me.S2.Text = "Vendedores"
        '
        'S5
        '
        Me.S5.Name = "S5"
        Me.S5.Size = New System.Drawing.Size(180, 24)
        Me.S5.Text = "Clientes"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'RutaToolStripMenuItem
        '
        Me.RutaToolStripMenuItem.Name = "RutaToolStripMenuItem"
        Me.RutaToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.RutaToolStripMenuItem.Text = "Ruta"
        '
        'MM2
        '
        Me.MM2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItinerarioRutasToolStripMenuItem, Me.ContactoClienteToolStripMenuItem, Me.AgendaToolStripMenuItem, Me.AgendarToolStripMenuItem})
        Me.MM2.Name = "MM2"
        Me.MM2.Size = New System.Drawing.Size(113, 24)
        Me.MM2.Text = "&Movimientos"
        '
        'ItinerarioRutasToolStripMenuItem
        '
        Me.ItinerarioRutasToolStripMenuItem.Name = "ItinerarioRutasToolStripMenuItem"
        Me.ItinerarioRutasToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.ItinerarioRutasToolStripMenuItem.Text = "Itinerario Rutas"
        '
        'ContactoClienteToolStripMenuItem
        '
        Me.ContactoClienteToolStripMenuItem.Name = "ContactoClienteToolStripMenuItem"
        Me.ContactoClienteToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.ContactoClienteToolStripMenuItem.Text = "Contacto Cliente"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.AgendaToolStripMenuItem.Text = "Agenda"
        '
        'AgendarToolStripMenuItem
        '
        Me.AgendarToolStripMenuItem.Name = "AgendarToolStripMenuItem"
        Me.AgendarToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.AgendarToolStripMenuItem.Text = "Agendar Visita"
        '
        'MM3
        '
        Me.MM3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MapaVendedorRutaToolStripMenuItem, Me.MapaClientesEnRutaToolStripMenuItem})
        Me.MM3.Name = "MM3"
        Me.MM3.Size = New System.Drawing.Size(84, 24)
        Me.MM3.Text = "&Reportes"
        '
        'MapaVendedorRutaToolStripMenuItem
        '
        Me.MapaVendedorRutaToolStripMenuItem.Name = "MapaVendedorRutaToolStripMenuItem"
        Me.MapaVendedorRutaToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.MapaVendedorRutaToolStripMenuItem.Text = "Mapa Vendedor Ruta"
        '
        'MapaClientesEnRutaToolStripMenuItem
        '
        Me.MapaClientesEnRutaToolStripMenuItem.Name = "MapaClientesEnRutaToolStripMenuItem"
        Me.MapaClientesEnRutaToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.MapaClientesEnRutaToolStripMenuItem.Text = "Mapa Clientes en Ruta"
        '
        'MM4
        '
        Me.MM4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.S61, Me.S66, Me.KardexVentasToolStripMenuItem, Me.CambiarFondoToolStripMenuItem})
        Me.MM4.Name = "MM4"
        Me.MM4.Size = New System.Drawing.Size(64, 24)
        Me.MM4.Text = "Extras"
        '
        'S61
        '
        Me.S61.Name = "S61"
        Me.S61.Size = New System.Drawing.Size(184, 24)
        Me.S61.Text = "Rastreo"
        '
        'S66
        '
        Me.S66.Name = "S66"
        Me.S66.Size = New System.Drawing.Size(184, 24)
        Me.S66.Text = "Perfiles"
        '
        'KardexVentasToolStripMenuItem
        '
        Me.KardexVentasToolStripMenuItem.Name = "KardexVentasToolStripMenuItem"
        Me.KardexVentasToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.KardexVentasToolStripMenuItem.Text = "Kardex Ventas"
        '
        'CambiarFondoToolStripMenuItem
        '
        Me.CambiarFondoToolStripMenuItem.Name = "CambiarFondoToolStripMenuItem"
        Me.CambiarFondoToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.CambiarFondoToolStripMenuItem.Text = "Cambiar Fondo"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        Me.AyudaToolStripMenuItem.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LBLPRU
        '
        Me.LBLPRU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBLPRU.AutoSize = True
        Me.LBLPRU.BackColor = System.Drawing.Color.Transparent
        Me.LBLPRU.Font = New System.Drawing.Font("Arial", 29.75!)
        Me.LBLPRU.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LBLPRU.Location = New System.Drawing.Point(310, 422)
        Me.LBLPRU.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLPRU.Name = "LBLPRU"
        Me.LBLPRU.Size = New System.Drawing.Size(377, 45)
        Me.LBLPRU.TabIndex = 394
        Me.LBLPRU.Text = "VERSION PRUEBA"
        Me.LBLPRU.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(38, 463)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 46)
        Me.Label1.TabIndex = 395
        Me.Label1.Text = "Control Flotilla"
        '
        'LBLV
        '
        Me.LBLV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLV.AutoSize = True
        Me.LBLV.BackColor = System.Drawing.Color.Transparent
        Me.LBLV.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLV.ForeColor = System.Drawing.Color.White
        Me.LBLV.Location = New System.Drawing.Point(419, 484)
        Me.LBLV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLV.MaximumSize = New System.Drawing.Size(150, 27)
        Me.LBLV.Name = "LBLV"
        Me.LBLV.Size = New System.Drawing.Size(129, 27)
        Me.LBLV.TabIndex = 397
        Me.LBLV.Text = "Versión 1.1"
        '
        'PBS
        '
        Me.PBS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBS.BackColor = System.Drawing.Color.Transparent
        Me.PBS.Image = CType(resources.GetObject("PBS.Image"), System.Drawing.Image)
        Me.PBS.Location = New System.Drawing.Point(795, 414)
        Me.PBS.Name = "PBS"
        Me.PBS.Size = New System.Drawing.Size(61, 66)
        Me.PBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBS.TabIndex = 1338
        Me.PBS.TabStop = False
        '
        'LBLP
        '
        Me.LBLP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLP.AutoSize = True
        Me.LBLP.BackColor = System.Drawing.Color.Transparent
        Me.LBLP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLP.ForeColor = System.Drawing.Color.White
        Me.LBLP.Location = New System.Drawing.Point(772, 483)
        Me.LBLP.Name = "LBLP"
        Me.LBLP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LBLP.Size = New System.Drawing.Size(106, 20)
        Me.LBLP.TabIndex = 1337
        Me.LBLP.Text = "Powered by "
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(741, 508)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(177, 20)
        Me.Label3.TabIndex = 1336
        Me.Label3.Text = "Structure Soluciones"
        '
        'PBCNC
        '
        Me.PBCNC.BackColor = System.Drawing.Color.Transparent
        Me.PBCNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCNC.Image = Global.Maquisa.My.Resources.Resources.Logo_Maquisa_2010_Horizontal
        Me.PBCNC.Location = New System.Drawing.Point(12, 39)
        Me.PBCNC.Margin = New System.Windows.Forms.Padding(4)
        Me.PBCNC.Name = "PBCNC"
        Me.PBCNC.Size = New System.Drawing.Size(218, 41)
        Me.PBCNC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCNC.TabIndex = 354
        Me.PBCNC.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 22)
        Me.Label2.TabIndex = 1340
        Me.Label2.Text = "Agenda"
        '
        'VERMAP
        '
        Me.VERMAP.BackColor = System.Drawing.SystemColors.Control
        Me.VERMAP.BackgroundImage = Global.Maquisa.My.Resources.Resources.REQCOMPRA100X100
        Me.VERMAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VERMAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VERMAP.ForeColor = System.Drawing.Color.Transparent
        Me.VERMAP.Location = New System.Drawing.Point(39, 118)
        Me.VERMAP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.VERMAP.Name = "VERMAP"
        Me.VERMAP.Size = New System.Drawing.Size(80, 80)
        Me.VERMAP.TabIndex = 1339
        Me.VERMAP.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 22)
        Me.Label4.TabIndex = 1342
        Me.Label4.Text = "Clientes"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = Global.Maquisa.My.Resources.Resources.REQSERV
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(39, 250)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 1341
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(896, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 22)
        Me.Label5.TabIndex = 1346
        Me.Label5.Text = "Contacto"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImage = Global.Maquisa.My.Resources.Resources.autorizar100X100
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(895, 250)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 80)
        Me.Button2.TabIndex = 1345
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.BackgroundImage = Global.Maquisa.My.Resources.Resources.BTNCORREO
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(895, 118)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 80)
        Me.Button3.TabIndex = 1343
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(899, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 1344
        Me.Label6.Text = "Itinearios"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Maquisa.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1030, 558)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VERMAP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBCNC)
        Me.Controls.Add(Me.PBS)
        Me.Controls.Add(Me.LBLP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBLV)
        Me.Controls.Add(Me.LBLPRU)
        Me.Controls.Add(Me.SB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(644, 500)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maquisa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SB.ResumeLayout(False)
        Me.SB.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCNC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SB As StatusStrip
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MM1 As ToolStripMenuItem
    Friend WithEvents S1 As ToolStripMenuItem
    Friend WithEvents S2 As ToolStripMenuItem
    Friend WithEvents S4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents MM2 As ToolStripMenuItem
    Friend WithEvents MM3 As ToolStripMenuItem
    Friend WithEvents MM4 As ToolStripMenuItem
    Friend WithEvents S61 As ToolStripMenuItem
    Friend WithEvents S66 As ToolStripMenuItem
    Friend WithEvents KardexVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarFondoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents S5 As ToolStripMenuItem
    Friend WithEvents LBLPRU As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLV As Label
    Friend WithEvents PBS As PictureBox
    Friend WithEvents LBLP As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RutaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItinerarioRutasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PBCNC As PictureBox
    Friend WithEvents MapaVendedorRutaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MapaClientesEnRutaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents VERMAP As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
End Class
