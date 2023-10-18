<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensaje
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMensaje))
        Me.BTNOK = New System.Windows.Forms.Button
        Me.LBLMSG = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BTNOK
        '
        Me.BTNOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BTNOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNOK.Location = New System.Drawing.Point(138, 112)
        Me.BTNOK.Name = "BTNOK"
        Me.BTNOK.Size = New System.Drawing.Size(126, 57)
        Me.BTNOK.TabIndex = 0
        Me.BTNOK.Text = "Aceptar"
        Me.BTNOK.UseVisualStyleBackColor = True
        '
        'LBLMSG
        '
        Me.LBLMSG.AutoSize = True
        Me.LBLMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMSG.Location = New System.Drawing.Point(31, 42)
        Me.LBLMSG.Name = "LBLMSG"
        Me.LBLMSG.Size = New System.Drawing.Size(101, 31)
        Me.LBLMSG.TabIndex = 1
        Me.LBLMSG.Text = "Label1"
        '
        'frmMensaje
        '
        Me.AcceptButton = Me.BTNOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 199)
        Me.Controls.Add(Me.LBLMSG)
        Me.Controls.Add(Me.BTNOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMensaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNOK As System.Windows.Forms.Button
    Friend WithEvents LBLMSG As System.Windows.Forms.Label
End Class
