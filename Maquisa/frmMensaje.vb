Public Class frmMensaje
    Public Sub MOSTRAR(ByVal T1 As String, ByVal T2 As String)
        LBLMSG.Text = "Su Cambio:  $ " + T2
        Me.Text = T1
        BTNOK.Focus()
        Me.ShowDialog()
    End Sub

    Private Sub BTNOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNOK.Click
        Me.Close()
    End Sub

    Private Sub frmMensaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
    End Sub
End Class