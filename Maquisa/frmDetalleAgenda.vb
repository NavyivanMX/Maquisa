Public Class frmDetalleAgenda
    Private Sub frmDetalleAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        Me.Icon = frmPrincipal.Icon

    End Sub

    Public Sub MOSTRAR(ByVal P1 As Integer, ByVal P2 As String, ByVal P3 As Integer)


    End Sub
End Class