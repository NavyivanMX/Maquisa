<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.MM3 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.SB.Location = New System.Drawing.Point(0, 662)
        Me.SB.Name = "SB"
        Me.SB.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SB.Size = New System.Drawing.Size(1373, 25)
        Me.SB.TabIndex = 47
        Me.SB.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(126, 20)
        Me.ToolStripStatusLabel7.Text = "Mazatlán, Sinaloa"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(65, 20)
        Me.ToolStripStatusLabel8.Text = "Maquisa"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 20)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(115, 20)
        Me.ToolStripStatusLabel2.Text = "Versión:  .net 4.0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MM1, Me.MM2, Me.MM3, Me.MM4, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1373, 33)
        Me.MenuStrip1.TabIndex = 48
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MM1
        '
        Me.MM1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.S1, Me.S4, Me.ToolStripMenuItem3, Me.S2, Me.S5, Me.ToolStripMenuItem2, Me.RutaToolStripMenuItem})
        Me.MM1.Name = "MM1"
        Me.MM1.Size = New System.Drawing.Size(92, 29)
        Me.MM1.Text = "&Archivo"
        '
        'S1
        '
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(196, 30)
        Me.S1.Text = "Empresa"
        '
        'S4
        '
        Me.S4.Name = "S4"
        Me.S4.Size = New System.Drawing.Size(196, 30)
        Me.S4.Text = "Usuarios"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(193, 6)
        '
        'S2
        '
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(196, 30)
        Me.S2.Text = "Vendedores"
        '
        'S5
        '
        Me.S5.Name = "S5"
        Me.S5.Size = New System.Drawing.Size(196, 30)
        Me.S5.Text = "Clientes"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(193, 6)
        '
        'RutaToolStripMenuItem
        '
        Me.RutaToolStripMenuItem.Name = "RutaToolStripMenuItem"
        Me.RutaToolStripMenuItem.Size = New System.Drawing.Size(196, 30)
        Me.RutaToolStripMenuItem.Text = "Ruta"
        '
        'MM2
        '
        Me.MM2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItinerarioRutasToolStripMenuItem})
        Me.MM2.Name = "MM2"
        Me.MM2.Size = New System.Drawing.Size(140, 29)
        Me.MM2.Text = "&Movimientos"
        '
        'ItinerarioRutasToolStripMenuItem
        '
        Me.ItinerarioRutasToolStripMenuItem.Name = "ItinerarioRutasToolStripMenuItem"
        Me.ItinerarioRutasToolStripMenuItem.Size = New System.Drawing.Size(227, 30)
        Me.ItinerarioRutasToolStripMenuItem.Text = "Itinerario Rutas"
        '
        'MM3
        '
        Me.MM3.Name = "MM3"
        Me.MM3.Size = New System.Drawing.Size(104, 29)
        Me.MM3.Text = "&Reportes"
        '
        'MM4
        '
        Me.MM4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.S61, Me.S66, Me.KardexVentasToolStripMenuItem, Me.CambiarFondoToolStripMenuItem})
        Me.MM4.Name = "MM4"
        Me.MM4.Size = New System.Drawing.Size(78, 29)
        Me.MM4.Text = "Extras"
        '
        'S61
        '
        Me.S61.Name = "S61"
        Me.S61.Size = New System.Drawing.Size(227, 30)
        Me.S61.Text = "Rastreo"
        '
        'S66
        '
        Me.S66.Name = "S66"
        Me.S66.Size = New System.Drawing.Size(227, 30)
        Me.S66.Text = "Perfiles"
        '
        'KardexVentasToolStripMenuItem
        '
        Me.KardexVentasToolStripMenuItem.Name = "KardexVentasToolStripMenuItem"
        Me.KardexVentasToolStripMenuItem.Size = New System.Drawing.Size(227, 30)
        Me.KardexVentasToolStripMenuItem.Text = "Kardex Ventas"
        '
        'CambiarFondoToolStripMenuItem
        '
        Me.CambiarFondoToolStripMenuItem.Name = "CambiarFondoToolStripMenuItem"
        Me.CambiarFondoToolStripMenuItem.Size = New System.Drawing.Size(227, 30)
        Me.CambiarFondoToolStripMenuItem.Text = "Cambiar Fondo"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(81, 29)
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
        Me.LBLPRU.Location = New System.Drawing.Point(105, 470)
        Me.LBLPRU.Name = "LBLPRU"
        Me.LBLPRU.Size = New System.Drawing.Size(467, 57)
        Me.LBLPRU.TabIndex = 394
        Me.LBLPRU.Text = "VERSION PRUEBA"
        Me.LBLPRU.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 29.75!)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(168, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 57)
        Me.Label1.TabIndex = 395
        Me.Label1.Text = "Control Flotilla"
        Me.Label1.Visible = False
        '
        'LBLV
        '
        Me.LBLV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBLV.AutoSize = True
        Me.LBLV.BackColor = System.Drawing.Color.Transparent
        Me.LBLV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLV.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LBLV.Location = New System.Drawing.Point(279, 551)
        Me.LBLV.Name = "LBLV"
        Me.LBLV.Size = New System.Drawing.Size(144, 29)
        Me.LBLV.TabIndex = 397
        Me.LBLV.Text = "Versión 1.1"
        '
        'PBS
        '
        Me.PBS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBS.BackColor = System.Drawing.Color.Transparent
        Me.PBS.Image = CType(resources.GetObject("PBS.Image"), System.Drawing.Image)
        Me.PBS.Location = New System.Drawing.Point(1060, 510)
        Me.PBS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PBS.Name = "PBS"
        Me.PBS.Size = New System.Drawing.Size(81, 81)
        Me.PBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBS.TabIndex = 1338
        Me.PBS.TabStop = False
        '
        'LBLP
        '
        Me.LBLP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLP.AutoSize = True
        Me.LBLP.BackColor = System.Drawing.Color.Transparent
        Me.LBLP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLP.ForeColor = System.Drawing.Color.White
        Me.LBLP.Location = New System.Drawing.Point(1037, 594)
        Me.LBLP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLP.Name = "LBLP"
        Me.LBLP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LBLP.Size = New System.Drawing.Size(120, 25)
        Me.LBLP.TabIndex = 1337
        Me.LBLP.Text = "Powered by "
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(996, 625)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(193, 25)
        Me.Label3.TabIndex = 1336
        Me.Label3.Text = "Structure Soluciones"
        '
        'PBCNC
        '
        Me.PBCNC.BackColor = System.Drawing.Color.Transparent
        Me.PBCNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCNC.Image = Global.Maquisa.My.Resources.Resources.Logo_Maquisa_2010_Horizontal
        Me.PBCNC.Location = New System.Drawing.Point(29, 58)
        Me.PBCNC.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PBCNC.Name = "PBCNC"
        Me.PBCNC.Size = New System.Drawing.Size(619, 139)
        Me.PBCNC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCNC.TabIndex = 354
        Me.PBCNC.TabStop = False
        Me.PBCNC.Visible = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Maquisa.My.Resources.Resources.wallpaper1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1373, 687)
        Me.Controls.Add(Me.PBS)
        Me.Controls.Add(Me.LBLP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBLV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLPRU)
        Me.Controls.Add(Me.PBCNC)
        Me.Controls.Add(Me.SB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(853, 607)
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
End Class
