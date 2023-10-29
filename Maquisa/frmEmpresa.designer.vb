<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpresa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CBACTIVO = New System.Windows.Forms.ComboBox()
        Me.TXTPAIS = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TXTESTADO = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTCP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTNUMEROEXT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTNUMEROINT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTCOLONIA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTCALLE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTCIUDAD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTTELEFONO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTRFC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTNOMBREFISCAL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTNOMBRECOMERCIAL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNGUARDAR.Image = Global.Maquisa.My.Resources.Resources.BTNGUARDAR
        Me.BTNGUARDAR.Location = New System.Drawing.Point(293, 311)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNGUARDAR.TabIndex = 13
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.CBACTIVO)
        Me.GroupBox1.Controls.Add(Me.TXTPAIS)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TXTESTADO)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TXTCP)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TXTNUMEROEXT)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TXTNUMEROINT)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TXTCOLONIA)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXTCALLE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXTCIUDAD)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXTTELEFONO)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXTRFC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXTNOMBREFISCAL)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXTNOMBRECOMERCIAL)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 299)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label12.Location = New System.Drawing.Point(263, 269)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 17)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Activo"
        '
        'CBACTIVO
        '
        Me.CBACTIVO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.CBACTIVO.FormattingEnabled = True
        Me.CBACTIVO.Items.AddRange(New Object() {"SI", "NO"})
        Me.CBACTIVO.Location = New System.Drawing.Point(319, 265)
        Me.CBACTIVO.Name = "CBACTIVO"
        Me.CBACTIVO.Size = New System.Drawing.Size(80, 25)
        Me.CBACTIVO.TabIndex = 58
        '
        'TXTPAIS
        '
        Me.TXTPAIS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTPAIS.Location = New System.Drawing.Point(415, 190)
        Me.TXTPAIS.Name = "TXTPAIS"
        Me.TXTPAIS.Size = New System.Drawing.Size(219, 25)
        Me.TXTPAIS.TabIndex = 54
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label16.Location = New System.Drawing.Point(374, 194)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 17)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "País"
        '
        'TXTESTADO
        '
        Me.TXTESTADO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTESTADO.Location = New System.Drawing.Point(163, 190)
        Me.TXTESTADO.Name = "TXTESTADO"
        Me.TXTESTADO.Size = New System.Drawing.Size(198, 25)
        Me.TXTESTADO.TabIndex = 52
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label15.Location = New System.Drawing.Point(103, 193)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 17)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Estado"
        '
        'TXTCP
        '
        Me.TXTCP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTCP.Location = New System.Drawing.Point(504, 159)
        Me.TXTCP.Name = "TXTCP"
        Me.TXTCP.Size = New System.Drawing.Size(130, 25)
        Me.TXTCP.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label11.Location = New System.Drawing.Point(473, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 17)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "CP"
        '
        'TXTNUMEROEXT
        '
        Me.TXTNUMEROEXT.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTNUMEROEXT.Location = New System.Drawing.Point(367, 159)
        Me.TXTNUMEROEXT.Name = "TXTNUMEROEXT"
        Me.TXTNUMEROEXT.Size = New System.Drawing.Size(94, 25)
        Me.TXTNUMEROEXT.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label10.Location = New System.Drawing.Point(270, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "No. Exterior"
        '
        'TXTNUMEROINT
        '
        Me.TXTNUMEROINT.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTNUMEROINT.Location = New System.Drawing.Point(163, 159)
        Me.TXTNUMEROINT.Name = "TXTNUMEROINT"
        Me.TXTNUMEROINT.Size = New System.Drawing.Size(100, 25)
        Me.TXTNUMEROINT.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label9.Location = New System.Drawing.Point(70, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 17)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "No. Interior"
        '
        'TXTCOLONIA
        '
        Me.TXTCOLONIA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTCOLONIA.Location = New System.Drawing.Point(445, 128)
        Me.TXTCOLONIA.Name = "TXTCOLONIA"
        Me.TXTCOLONIA.Size = New System.Drawing.Size(189, 25)
        Me.TXTCOLONIA.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label8.Location = New System.Drawing.Point(379, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Colonia"
        '
        'TXTCALLE
        '
        Me.TXTCALLE.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTCALLE.Location = New System.Drawing.Point(163, 128)
        Me.TXTCALLE.Name = "TXTCALLE"
        Me.TXTCALLE.Size = New System.Drawing.Size(196, 25)
        Me.TXTCALLE.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(117, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Calle"
        '
        'TXTCIUDAD
        '
        Me.TXTCIUDAD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTCIUDAD.Location = New System.Drawing.Point(422, 221)
        Me.TXTCIUDAD.Name = "TXTCIUDAD"
        Me.TXTCIUDAD.Size = New System.Drawing.Size(212, 25)
        Me.TXTCIUDAD.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(360, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Ciudad"
        '
        'TXTTELEFONO
        '
        Me.TXTTELEFONO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTTELEFONO.Location = New System.Drawing.Point(163, 221)
        Me.TXTTELEFONO.Name = "TXTTELEFONO"
        Me.TXTTELEFONO.Size = New System.Drawing.Size(150, 25)
        Me.TXTTELEFONO.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(91, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Teléfono"
        '
        'TXTRFC
        '
        Me.TXTRFC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTRFC.Location = New System.Drawing.Point(163, 35)
        Me.TXTRFC.Name = "TXTRFC"
        Me.TXTRFC.Size = New System.Drawing.Size(198, 25)
        Me.TXTRFC.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(122, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "RFC"
        '
        'TXTNOMBREFISCAL
        '
        Me.TXTNOMBREFISCAL.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTNOMBREFISCAL.Location = New System.Drawing.Point(163, 97)
        Me.TXTNOMBREFISCAL.Name = "TXTNOMBREFISCAL"
        Me.TXTNOMBREFISCAL.Size = New System.Drawing.Size(471, 25)
        Me.TXTNOMBREFISCAL.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(49, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Nombre Fiscal"
        '
        'TXTNOMBRECOMERCIAL
        '
        Me.TXTNOMBRECOMERCIAL.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTNOMBRECOMERCIAL.Location = New System.Drawing.Point(163, 66)
        Me.TXTNOMBRECOMERCIAL.Name = "TXTNOMBRECOMERCIAL"
        Me.TXTNOMBRECOMERCIAL.Size = New System.Drawing.Size(471, 25)
        Me.TXTNOMBRECOMERCIAL.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(17, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Nombre Comercial"
        '
        'frmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 401)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmpresa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CBACTIVO As ComboBox
    Friend WithEvents TXTPAIS As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TXTESTADO As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TXTCP As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTNUMEROEXT As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTNUMEROINT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTCOLONIA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTCALLE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTCIUDAD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTTELEFONO As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTRFC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTNOMBREFISCAL As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTNOMBRECOMERCIAL As TextBox
    Friend WithEvents Label2 As Label
End Class
