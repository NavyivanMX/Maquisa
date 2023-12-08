<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleAgenda
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
        Me.LBLVISITADOS = New System.Windows.Forms.Button()
        Me.BTNEDITAR = New System.Windows.Forms.Button()
        Me.LBLNUMPROSPECTO = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNADMINPROSPECTO = New System.Windows.Forms.Button()
        Me.LBLFECHA = New System.Windows.Forms.Label()
        Me.LBL1 = New System.Windows.Forms.Label()
        Me.BTNIZQUIERDA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLRUTA = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LBLVENDEDOR = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLVISITAS = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLVISITADOS
        '
        Me.LBLVISITADOS.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LBLVISITADOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLVISITADOS.ForeColor = System.Drawing.Color.Black
        Me.LBLVISITADOS.Location = New System.Drawing.Point(691, 13)
        Me.LBLVISITADOS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LBLVISITADOS.Name = "LBLVISITADOS"
        Me.LBLVISITADOS.Size = New System.Drawing.Size(140, 77)
        Me.LBLVISITADOS.TabIndex = 1172
        Me.LBLVISITADOS.Text = "AGENDAR"
        Me.LBLVISITADOS.UseVisualStyleBackColor = False
        '
        'BTNEDITAR
        '
        Me.BTNEDITAR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNEDITAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEDITAR.ForeColor = System.Drawing.Color.Black
        Me.BTNEDITAR.Location = New System.Drawing.Point(215, 16)
        Me.BTNEDITAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNEDITAR.Name = "BTNEDITAR"
        Me.BTNEDITAR.Size = New System.Drawing.Size(140, 77)
        Me.BTNEDITAR.TabIndex = 1173
        Me.BTNEDITAR.Text = "EDITAR"
        Me.BTNEDITAR.UseVisualStyleBackColor = False
        '
        'LBLNUMPROSPECTO
        '
        Me.LBLNUMPROSPECTO.AutoSize = True
        Me.LBLNUMPROSPECTO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LBLNUMPROSPECTO.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LBLNUMPROSPECTO.Location = New System.Drawing.Point(999, 97)
        Me.LBLNUMPROSPECTO.Name = "LBLNUMPROSPECTO"
        Me.LBLNUMPROSPECTO.Size = New System.Drawing.Size(13, 17)
        Me.LBLNUMPROSPECTO.TabIndex = 1179
        Me.LBLNUMPROSPECTO.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(859, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 1178
        Me.Label2.Text = "# Prospecto Pend"
        '
        'BTNADMINPROSPECTO
        '
        Me.BTNADMINPROSPECTO.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNADMINPROSPECTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNADMINPROSPECTO.ForeColor = System.Drawing.Color.Black
        Me.BTNADMINPROSPECTO.Location = New System.Drawing.Point(857, 13)
        Me.BTNADMINPROSPECTO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNADMINPROSPECTO.Name = "BTNADMINPROSPECTO"
        Me.BTNADMINPROSPECTO.Size = New System.Drawing.Size(140, 77)
        Me.BTNADMINPROSPECTO.TabIndex = 1177
        Me.BTNADMINPROSPECTO.Text = "ADMIN PROSPECTO"
        Me.BTNADMINPROSPECTO.UseVisualStyleBackColor = False
        '
        'LBLFECHA
        '
        Me.LBLFECHA.AutoSize = True
        Me.LBLFECHA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.LBLFECHA.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LBLFECHA.Location = New System.Drawing.Point(95, 103)
        Me.LBLFECHA.Name = "LBLFECHA"
        Me.LBLFECHA.Size = New System.Drawing.Size(16, 22)
        Me.LBLFECHA.TabIndex = 1182
        Me.LBLFECHA.Text = "."
        '
        'LBL1
        '
        Me.LBL1.AutoSize = True
        Me.LBL1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.LBL1.Location = New System.Drawing.Point(21, 104)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(71, 22)
        Me.LBL1.TabIndex = 1181
        Me.LBL1.Text = "Fecha:"
        '
        'BTNIZQUIERDA
        '
        Me.BTNIZQUIERDA.BackColor = System.Drawing.SystemColors.Control
        Me.BTNIZQUIERDA.BackgroundImage = Global.Maquisa.My.Resources.Resources.BTNIZQUIERDA
        Me.BTNIZQUIERDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNIZQUIERDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIZQUIERDA.ForeColor = System.Drawing.Color.Transparent
        Me.BTNIZQUIERDA.Location = New System.Drawing.Point(17, 12)
        Me.BTNIZQUIERDA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNIZQUIERDA.Name = "BTNIZQUIERDA"
        Me.BTNIZQUIERDA.Size = New System.Drawing.Size(80, 80)
        Me.BTNIZQUIERDA.TabIndex = 1271
        Me.BTNIZQUIERDA.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(12, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 22)
        Me.Label1.TabIndex = 1272
        Me.Label1.Text = "Doble Click para ver Info. Visita"
        '
        'LBLRUTA
        '
        Me.LBLRUTA.AutoSize = True
        Me.LBLRUTA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.LBLRUTA.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LBLRUTA.Location = New System.Drawing.Point(287, 104)
        Me.LBLRUTA.Name = "LBLRUTA"
        Me.LBLRUTA.Size = New System.Drawing.Size(16, 22)
        Me.LBLRUTA.TabIndex = 1274
        Me.LBLRUTA.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(230, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 22)
        Me.Label4.TabIndex = 1273
        Me.Label4.Text = "Ruta:"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 158)
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
        Me.DGV.Size = New System.Drawing.Size(1009, 476)
        Me.DGV.TabIndex = 1275
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(446, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 77)
        Me.Button1.TabIndex = 1276
        Me.Button1.Text = "REPORTE DEL DIA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LBLVENDEDOR
        '
        Me.LBLVENDEDOR.AutoSize = True
        Me.LBLVENDEDOR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.LBLVENDEDOR.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LBLVENDEDOR.Location = New System.Drawing.Point(536, 105)
        Me.LBLVENDEDOR.Name = "LBLVENDEDOR"
        Me.LBLVENDEDOR.Size = New System.Drawing.Size(16, 22)
        Me.LBLVENDEDOR.TabIndex = 1278
        Me.LBLVENDEDOR.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(425, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 22)
        Me.Label5.TabIndex = 1277
        Me.Label5.Text = "Vendedor:"
        '
        'LBLVISITAS
        '
        Me.LBLVISITAS.AutoSize = True
        Me.LBLVISITAS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.LBLVISITAS.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LBLVISITAS.Location = New System.Drawing.Point(536, 133)
        Me.LBLVISITAS.Name = "LBLVISITAS"
        Me.LBLVISITAS.Size = New System.Drawing.Size(16, 22)
        Me.LBLVISITAS.TabIndex = 1280
        Me.LBLVISITAS.Text = "."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(425, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 22)
        Me.Label6.TabIndex = 1279
        Me.Label6.Text = "Visitados:"
        '
        'frmDetalleAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.LBLVISITAS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LBLVENDEDOR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.LBLRUTA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNIZQUIERDA)
        Me.Controls.Add(Me.LBLFECHA)
        Me.Controls.Add(Me.LBL1)
        Me.Controls.Add(Me.LBLNUMPROSPECTO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNADMINPROSPECTO)
        Me.Controls.Add(Me.BTNEDITAR)
        Me.Controls.Add(Me.LBLVISITADOS)
        Me.Name = "frmDetalleAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Detalle Agenda"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLVISITADOS As Button
    Friend WithEvents BTNEDITAR As Button
    Friend WithEvents LBLNUMPROSPECTO As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNADMINPROSPECTO As Button
    Friend WithEvents LBLFECHA As Label
    Friend WithEvents LBL1 As Label
    Friend WithEvents BTNIZQUIERDA As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLRUTA As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents LBLVENDEDOR As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLVISITAS As Label
    Friend WithEvents Label6 As Label
End Class
