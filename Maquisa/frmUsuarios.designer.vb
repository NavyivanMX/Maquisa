﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTEMP = New System.Windows.Forms.TextBox()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTNVA = New System.Windows.Forms.TextBox()
        Me.LBLNVA = New System.Windows.Forms.Label()
        Me.TXTANT = New System.Windows.Forms.TextBox()
        Me.LBLANT = New System.Windows.Forms.Label()
        Me.TXTPWD = New System.Windows.Forms.TextBox()
        Me.LBLPWD = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBNIV = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(29, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 24)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Usuario"
        '
        'TXTEMP
        '
        Me.TXTEMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTEMP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEMP.Location = New System.Drawing.Point(117, 20)
        Me.TXTEMP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTEMP.MaxLength = 10
        Me.TXTEMP.Name = "TXTEMP"
        Me.TXTEMP.Size = New System.Drawing.Size(173, 25)
        Me.TXTEMP.TabIndex = 0
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNELIMINAR.Image = CType(resources.GetObject("BTNELIMINAR.Image"), System.Drawing.Image)
        Me.BTNELIMINAR.Location = New System.Drawing.Point(226, 258)
        Me.BTNELIMINAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNELIMINAR.TabIndex = 6
        Me.BTNELIMINAR.UseVisualStyleBackColor = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNCANCELAR.Image = CType(resources.GetObject("BTNCANCELAR.Image"), System.Drawing.Image)
        Me.BTNCANCELAR.Location = New System.Drawing.Point(349, 258)
        Me.BTNCANCELAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNCANCELAR.TabIndex = 7
        Me.BTNCANCELAR.UseVisualStyleBackColor = False
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNGUARDAR.Image = CType(resources.GetObject("BTNGUARDAR.Image"), System.Drawing.Image)
        Me.BTNGUARDAR.Location = New System.Drawing.Point(98, 258)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNGUARDAR.TabIndex = 5
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTNVA)
        Me.GroupBox1.Controls.Add(Me.LBLNVA)
        Me.GroupBox1.Controls.Add(Me.TXTANT)
        Me.GroupBox1.Controls.Add(Me.LBLANT)
        Me.GroupBox1.Controls.Add(Me.TXTPWD)
        Me.GroupBox1.Controls.Add(Me.LBLPWD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CBNIV)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 175)
        Me.GroupBox1.TabIndex = 241
        Me.GroupBox1.TabStop = False
        '
        'TXTNVA
        '
        Me.TXTNVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNVA.Location = New System.Drawing.Point(220, 73)
        Me.TXTNVA.MaxLength = 10
        Me.TXTNVA.Name = "TXTNVA"
        Me.TXTNVA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTNVA.Size = New System.Drawing.Size(210, 24)
        Me.TXTNVA.TabIndex = 242
        '
        'LBLNVA
        '
        Me.LBLNVA.AutoSize = True
        Me.LBLNVA.BackColor = System.Drawing.Color.Transparent
        Me.LBLNVA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNVA.Location = New System.Drawing.Point(74, 76)
        Me.LBLNVA.Name = "LBLNVA"
        Me.LBLNVA.Size = New System.Drawing.Size(143, 17)
        Me.LBLNVA.TabIndex = 248
        Me.LBLNVA.Text = "Nueva Contraseña"
        '
        'TXTANT
        '
        Me.TXTANT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTANT.Location = New System.Drawing.Point(221, 42)
        Me.TXTANT.MaxLength = 10
        Me.TXTANT.Name = "TXTANT"
        Me.TXTANT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTANT.Size = New System.Drawing.Size(210, 24)
        Me.TXTANT.TabIndex = 241
        '
        'LBLANT
        '
        Me.LBLANT.AutoSize = True
        Me.LBLANT.BackColor = System.Drawing.Color.Transparent
        Me.LBLANT.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLANT.Location = New System.Drawing.Point(60, 46)
        Me.LBLANT.Name = "LBLANT"
        Me.LBLANT.Size = New System.Drawing.Size(158, 17)
        Me.LBLANT.TabIndex = 247
        Me.LBLANT.Text = "Contraseña Anterior"
        '
        'TXTPWD
        '
        Me.TXTPWD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPWD.Location = New System.Drawing.Point(221, 104)
        Me.TXTPWD.MaxLength = 10
        Me.TXTPWD.Name = "TXTPWD"
        Me.TXTPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPWD.Size = New System.Drawing.Size(210, 24)
        Me.TXTPWD.TabIndex = 243
        '
        'LBLPWD
        '
        Me.LBLPWD.AutoSize = True
        Me.LBLPWD.BackColor = System.Drawing.Color.Transparent
        Me.LBLPWD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPWD.Location = New System.Drawing.Point(63, 106)
        Me.LBLPWD.Name = "LBLPWD"
        Me.LBLPWD.Size = New System.Drawing.Size(155, 17)
        Me.LBLPWD.TabIndex = 246
        Me.LBLPWD.Text = " Repetir Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 245
        Me.Label1.Text = "Nivel"
        '
        'CBNIV
        '
        Me.CBNIV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNIV.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNIV.FormattingEnabled = True
        Me.CBNIV.Items.AddRange(New Object() {"Capturista", "Super administrador"})
        Me.CBNIV.Location = New System.Drawing.Point(221, 135)
        Me.CBNIV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBNIV.Name = "CBNIV"
        Me.CBNIV.Size = New System.Drawing.Size(209, 25)
        Me.CBNIV.TabIndex = 244
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(526, 358)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTEMP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTEMP As System.Windows.Forms.TextBox
    Private WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXTNVA As TextBox
    Friend WithEvents LBLNVA As Label
    Friend WithEvents TXTANT As TextBox
    Friend WithEvents LBLANT As Label
    Friend WithEvents TXTPWD As TextBox
    Friend WithEvents LBLPWD As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBNIV As ComboBox
End Class
