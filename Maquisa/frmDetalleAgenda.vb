Public Class frmDetalleAgenda
    Dim IDRUTA As Integer
    Dim Fecha As DateTime
    Private Sub frmDetalleAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        Me.Icon = frmPrincipal.Icon
        LBLNUMPROSPECTO.Text = BDExtraeUnDato("SELECT ISNULL(COUNT(CLAVE),0) FROM PROSPECTOS WHERE RESULTADOPROSPECTO=0", frmPrincipal.CadenaConexion)

    End Sub

    Public Sub MOSTRAR(ByVal PRUTA As Integer, ByVal PFECHA As DateTime)
        IDRUTA = PRUTA
        Fecha = PFECHA
        LBLFECHA.Text = PFECHA
        LBLRUTA.Text = PRUTA
        CARGADATOS()
        Me.ShowDialog()

    End Sub

    Private Sub CARGADATOS()
        Dim QUERY As String
        QUERY = "SELECT VISITA,VENDEDOR,CLIENTE, ORDEN, [RESULTA DOVISITA], [CONTACTOS CLIENTE]  "
        QUERY = QUERY + "FROM [dbo].[VDETALLEAGENDA] WHERE RUTA=" + IDRUTA.ToString + " AND  FECHA>='" + Fecha.ToString + "'  "
        DGV.DataSource = BDLlenaTabla(QUERY, frmPrincipal.CadenaConexion)
        DgvAjusteEncabezado(DGV, 1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BTNAGENDAR_Click(sender As Object, e As EventArgs) Handles BTNAGENDAR.Click
        frmAgendar.ShowDialog()
    End Sub

    Private Sub BTNIZQUIERDA_Click(sender As Object, e As EventArgs) Handles BTNIZQUIERDA.Click
        Me.Close()
    End Sub
End Class