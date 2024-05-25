<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgendar
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBCLI = New System.Windows.Forms.ComboBox()
        Me.LBLVENDEDOR = New System.Windows.Forms.Label()
        Me.DTFECHA = New System.Windows.Forms.DateTimePicker()
        Me.LBLNUMVISITA = New System.Windows.Forms.Label()
        Me.CBR = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXTORDEN = New System.Windows.Forms.TextBox()
        Me.TXTOBS = New System.Windows.Forms.TextBox()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.CBSUC = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 22)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Clave"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 22)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Ruta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 22)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Vendedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(310, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 22)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 22)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Orden"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 22)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(128, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 22)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Observacion"
        '
        'CBCLI
        '
        Me.CBCLI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBCLI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCLI.BackColor = System.Drawing.SystemColors.Control
        Me.CBCLI.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.CBCLI.FormattingEnabled = True
        Me.CBCLI.Items.AddRange(New Object() {"LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO"})
        Me.CBCLI.Location = New System.Drawing.Point(132, 175)
        Me.CBCLI.Name = "CBCLI"
        Me.CBCLI.Size = New System.Drawing.Size(350, 25)
        Me.CBCLI.TabIndex = 1262
        '
        'LBLVENDEDOR
        '
        Me.LBLVENDEDOR.AutoSize = True
        Me.LBLVENDEDOR.BackColor = System.Drawing.Color.Transparent
        Me.LBLVENDEDOR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLVENDEDOR.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LBLVENDEDOR.Location = New System.Drawing.Point(133, 111)
        Me.LBLVENDEDOR.Name = "LBLVENDEDOR"
        Me.LBLVENDEDOR.Size = New System.Drawing.Size(13, 17)
        Me.LBLVENDEDOR.TabIndex = 1261
        Me.LBLVENDEDOR.Text = "."
        '
        'DTFECHA
        '
        Me.DTFECHA.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFECHA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFECHA.Location = New System.Drawing.Point(379, 23)
        Me.DTFECHA.Name = "DTFECHA"
        Me.DTFECHA.Size = New System.Drawing.Size(99, 26)
        Me.DTFECHA.TabIndex = 1264
        '
        'LBLNUMVISITA
        '
        Me.LBLNUMVISITA.AutoSize = True
        Me.LBLNUMVISITA.BackColor = System.Drawing.Color.Transparent
        Me.LBLNUMVISITA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLNUMVISITA.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LBLNUMVISITA.Location = New System.Drawing.Point(91, 32)
        Me.LBLNUMVISITA.Name = "LBLNUMVISITA"
        Me.LBLNUMVISITA.Size = New System.Drawing.Size(13, 17)
        Me.LBLNUMVISITA.TabIndex = 1265
        Me.LBLNUMVISITA.Text = "."
        '
        'CBR
        '
        Me.CBR.BackColor = System.Drawing.SystemColors.Control
        Me.CBR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.CBR.FormattingEnabled = True
        Me.CBR.Location = New System.Drawing.Point(132, 71)
        Me.CBR.Name = "CBR"
        Me.CBR.Size = New System.Drawing.Size(350, 25)
        Me.CBR.TabIndex = 1266
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(599, 24)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 35)
        Me.Button1.TabIndex = 1267
        Me.Button1.Text = "Alta Clientes"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TXTORDEN
        '
        Me.TXTORDEN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTORDEN.Location = New System.Drawing.Point(131, 140)
        Me.TXTORDEN.Name = "TXTORDEN"
        Me.TXTORDEN.Size = New System.Drawing.Size(45, 25)
        Me.TXTORDEN.TabIndex = 1268
        Me.TXTORDEN.Text = "0"
        Me.TXTORDEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTOBS
        '
        Me.TXTOBS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTOBS.Location = New System.Drawing.Point(132, 249)
        Me.TXTOBS.Multiline = True
        Me.TXTOBS.Name = "TXTOBS"
        Me.TXTOBS.Size = New System.Drawing.Size(539, 111)
        Me.TXTOBS.TabIndex = 1269
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNGUARDAR.Location = New System.Drawing.Point(337, 384)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNGUARDAR.TabIndex = 1270
        Me.BTNGUARDAR.Text = "&G"
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'CBSUC
        '
        Me.CBSUC.BackColor = System.Drawing.SystemColors.Control
        Me.CBSUC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSUC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.CBSUC.FormattingEnabled = True
        Me.CBSUC.Location = New System.Drawing.Point(28, 401)
        Me.CBSUC.Name = "CBSUC"
        Me.CBSUC.Size = New System.Drawing.Size(55, 25)
        Me.CBSUC.TabIndex = 1271
        Me.CBSUC.Visible = False
        '
        'frmAgendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 485)
        Me.Controls.Add(Me.CBSUC)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.TXTOBS)
        Me.Controls.Add(Me.TXTORDEN)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBR)
        Me.Controls.Add(Me.LBLNUMVISITA)
        Me.Controls.Add(Me.DTFECHA)
        Me.Controls.Add(Me.CBCLI)
        Me.Controls.Add(Me.LBLVENDEDOR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MinimumSize = New System.Drawing.Size(770, 524)
        Me.Name = "frmAgendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agendar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBCLI As ComboBox
    Friend WithEvents LBLVENDEDOR As Label
    Friend WithEvents DTFECHA As DateTimePicker
    Friend WithEvents LBLNUMVISITA As Label
    Friend WithEvents CBR As ComboBox
    Private WithEvents Button1 As Button
    Friend WithEvents TXTORDEN As TextBox
    Friend WithEvents TXTOBS As TextBox
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents CBSUC As ComboBox
End Class
