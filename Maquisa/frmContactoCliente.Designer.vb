﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContactoCliente
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTNOM = New System.Windows.Forms.TextBox()
        Me.CBCLIENTE = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTPUESTO = New System.Windows.Forms.TextBox()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNQUITAR = New System.Windows.Forms.Button()
        Me.BTNAGREGAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUESTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTOBSERVACION = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(52, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 1162
        Me.Label4.Text = "Nombre"
        '
        'TXTNOM
        '
        Me.TXTNOM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTNOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNOM.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTNOM.Location = New System.Drawing.Point(119, 127)
        Me.TXTNOM.MaxLength = 300
        Me.TXTNOM.Name = "TXTNOM"
        Me.TXTNOM.Size = New System.Drawing.Size(754, 25)
        Me.TXTNOM.TabIndex = 2
        '
        'CBCLIENTE
        '
        Me.CBCLIENTE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBCLIENTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCLIENTE.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.CBCLIENTE.FormattingEnabled = True
        Me.CBCLIENTE.Location = New System.Drawing.Point(106, 44)
        Me.CBCLIENTE.Name = "CBCLIENTE"
        Me.CBCLIENTE.Size = New System.Drawing.Size(692, 25)
        Me.CBCLIENTE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(47, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 1163
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(60, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1166
        Me.Label2.Text = "Puesto"
        '
        'TXTPUESTO
        '
        Me.TXTPUESTO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTPUESTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPUESTO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTPUESTO.Location = New System.Drawing.Point(119, 174)
        Me.TXTPUESTO.MaxLength = 300
        Me.TXTPUESTO.Name = "TXTPUESTO"
        Me.TXTPUESTO.Size = New System.Drawing.Size(754, 25)
        Me.TXTPUESTO.TabIndex = 3
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCANCELAR.BackColor = System.Drawing.Color.White
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNCANCELAR.Location = New System.Drawing.Point(919, 399)
        Me.BTNCANCELAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNCANCELAR.TabIndex = 1172
        Me.BTNCANCELAR.Text = "&C"
        Me.BTNCANCELAR.UseVisualStyleBackColor = False
        '
        'BTNQUITAR
        '
        Me.BTNQUITAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNQUITAR.BackColor = System.Drawing.Color.White
        Me.BTNQUITAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNQUITAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNQUITAR.Location = New System.Drawing.Point(919, 312)
        Me.BTNQUITAR.Name = "BTNQUITAR"
        Me.BTNQUITAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNQUITAR.TabIndex = 1171
        Me.BTNQUITAR.UseVisualStyleBackColor = False
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNAGREGAR.BackColor = System.Drawing.Color.White
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNAGREGAR.Location = New System.Drawing.Point(919, 228)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(80, 78)
        Me.BTNAGREGAR.TabIndex = 5
        Me.BTNAGREGAR.UseVisualStyleBackColor = False
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNGUARDAR.Location = New System.Drawing.Point(919, 487)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNGUARDAR.TabIndex = 1169
        Me.BTNGUARDAR.Text = "&G"
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBUSCAR.BackColor = System.Drawing.Color.White
        Me.BTNBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSCAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNBUSCAR.Location = New System.Drawing.Point(842, 13)
        Me.BTNBUSCAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(85, 77)
        Me.BTNBUSCAR.TabIndex = 1
        Me.BTNBUSCAR.Text = "&B"
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMBRE, Me.PUESTO, Me.OBSERVACION})
        Me.DGV.Location = New System.Drawing.Point(28, 296)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV.Size = New System.Drawing.Size(875, 271)
        Me.DGV.TabIndex = 6
        '
        'NOMBRE
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NOMBRE.DefaultCellStyle = DataGridViewCellStyle5
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 300
        '
        'PUESTO
        '
        Me.PUESTO.HeaderText = "PUESTO"
        Me.PUESTO.Name = "PUESTO"
        Me.PUESTO.ReadOnly = True
        Me.PUESTO.Width = 150
        '
        'OBSERVACION
        '
        Me.OBSERVACION.HeaderText = "OBSERVACION"
        Me.OBSERVACION.Name = "OBSERVACION"
        Me.OBSERVACION.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(17, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 1175
        Me.Label3.Text = "Observacion"
        '
        'TXTOBSERVACION
        '
        Me.TXTOBSERVACION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTOBSERVACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTOBSERVACION.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.TXTOBSERVACION.Location = New System.Drawing.Point(119, 219)
        Me.TXTOBSERVACION.MaxLength = 300
        Me.TXTOBSERVACION.Multiline = True
        Me.TXTOBSERVACION.Name = "TXTOBSERVACION"
        Me.TXTOBSERVACION.Size = New System.Drawing.Size(754, 50)
        Me.TXTOBSERVACION.TabIndex = 4
        '
        'frmContactoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 585)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTOBSERVACION)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.BTNQUITAR)
        Me.Controls.Add(Me.BTNAGREGAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTPUESTO)
        Me.Controls.Add(Me.CBCLIENTE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTNOM)
        Me.MinimumSize = New System.Drawing.Size(1032, 624)
        Me.Name = "frmContactoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacto-Cliente"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTNOM As TextBox
    Friend WithEvents CBCLIENTE As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTPUESTO As TextBox
    Private WithEvents BTNCANCELAR As Button
    Private WithEvents BTNQUITAR As Button
    Friend WithEvents BTNAGREGAR As Button
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents BTNBUSCAR As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents PUESTO As DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACION As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTOBSERVACION As TextBox
End Class
