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
        Me.S2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.S5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.S8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.S14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.S21 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MM2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MM3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MM4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S61 = New System.Windows.Forms.ToolStripMenuItem()
        Me.S66 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KardexVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PBCNC = New System.Windows.Forms.PictureBox()
        Me.SB.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PBCNC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SB
        '
        Me.SB.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.SB.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.SB.Location = New System.Drawing.Point(0, 441)
        Me.SB.Name = "SB"
        Me.SB.Size = New System.Drawing.Size(628, 22)
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
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MM1, Me.MM2, Me.MM3, Me.MM4, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(628, 28)
        Me.MenuStrip1.TabIndex = 48
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MM1
        '
        Me.MM1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.S1, Me.S2, Me.S3, Me.S4, Me.ToolStripMenuItem3, Me.S5, Me.S7, Me.ToolStripMenuItem1, Me.S8, Me.S9, Me.S10, Me.S11, Me.S12, Me.ToolStripMenuItem2, Me.S14, Me.ToolStripSeparator1, Me.S21})
        Me.MM1.Name = "MM1"
        Me.MM1.Size = New System.Drawing.Size(75, 24)
        Me.MM1.Text = "&Archivo"
        '
        'S1
        '
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(267, 24)
        Me.S1.Text = "Empresa"
        '
        'S2
        '
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(267, 24)
        Me.S2.Text = "Empleados"
        '
        'S3
        '
        Me.S3.Name = "S3"
        Me.S3.Size = New System.Drawing.Size(267, 24)
        Me.S3.Text = "Cajeras"
        '
        'S4
        '
        Me.S4.Name = "S4"
        Me.S4.Size = New System.Drawing.Size(267, 24)
        Me.S4.Text = "Usuarios"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(264, 6)
        '
        'S5
        '
        Me.S5.Name = "S5"
        Me.S5.Size = New System.Drawing.Size(267, 24)
        Me.S5.Text = "Clientes"
        '
        'S7
        '
        Me.S7.Name = "S7"
        Me.S7.Size = New System.Drawing.Size(267, 24)
        Me.S7.Text = "Precios Clientes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(264, 6)
        '
        'S8
        '
        Me.S8.Name = "S8"
        Me.S8.Size = New System.Drawing.Size(267, 24)
        Me.S8.Text = "Unidades"
        '
        'S9
        '
        Me.S9.Name = "S9"
        Me.S9.Size = New System.Drawing.Size(267, 24)
        Me.S9.Text = "Grupos"
        '
        'S10
        '
        Me.S10.Name = "S10"
        Me.S10.Size = New System.Drawing.Size(267, 24)
        Me.S10.Text = "Sub Grupos"
        '
        'S11
        '
        Me.S11.Name = "S11"
        Me.S11.Size = New System.Drawing.Size(267, 24)
        Me.S11.Text = "Productos"
        '
        'S12
        '
        Me.S12.Name = "S12"
        Me.S12.Size = New System.Drawing.Size(267, 24)
        Me.S12.Text = "Equivalencias de productos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(264, 6)
        '
        'S14
        '
        Me.S14.Name = "S14"
        Me.S14.Size = New System.Drawing.Size(267, 24)
        Me.S14.Text = "Proveedores"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(264, 6)
        '
        'S21
        '
        Me.S21.Name = "S21"
        Me.S21.Size = New System.Drawing.Size(267, 24)
        Me.S21.Text = "Deshabilitar usuarios"
        '
        'MM2
        '
        Me.MM2.Name = "MM2"
        Me.MM2.Size = New System.Drawing.Size(113, 24)
        Me.MM2.Text = "&Movimientos"
        '
        'MM3
        '
        Me.MM3.Name = "MM3"
        Me.MM3.Size = New System.Drawing.Size(84, 24)
        Me.MM3.Text = "&Reportes"
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
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PBCNC
        '
        Me.PBCNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCNC.Image = Global.Maquisa.My.Resources.Resources.MaquisaFondo
        Me.PBCNC.Location = New System.Drawing.Point(191, 70)
        Me.PBCNC.Margin = New System.Windows.Forms.Padding(4)
        Me.PBCNC.Name = "PBCNC"
        Me.PBCNC.Size = New System.Drawing.Size(217, 329)
        Me.PBCNC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCNC.TabIndex = 354
        Me.PBCNC.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Maquisa.My.Resources.Resources.FondoForms
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(628, 463)
        Me.Controls.Add(Me.PBCNC)
        Me.Controls.Add(Me.SB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(644, 502)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maquisa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SB.ResumeLayout(False)
        Me.SB.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents S3 As ToolStripMenuItem
    Friend WithEvents S4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents S7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents S8 As ToolStripMenuItem
    Friend WithEvents S9 As ToolStripMenuItem
    Friend WithEvents S10 As ToolStripMenuItem
    Friend WithEvents S11 As ToolStripMenuItem
    Friend WithEvents S12 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents S14 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents S21 As ToolStripMenuItem
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
    Friend WithEvents PBCNC As PictureBox
End Class
