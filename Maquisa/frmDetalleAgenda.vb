Public Class frmDetalleAgenda
    Dim IDRUTA As Integer
    Dim Fecha As DateTime
    Private Sub frmDetalleAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        Me.Icon = frmPrincipal.Icon
        LBLNUMPROSPECTO.Text = BDExtraeUnDato("SELECT ISNULL(COUNT(CLAVE),0) FROM PROSPECTOS WHERE RESULTADOPROSPECTO=0", frmPrincipal.CadenaConexion)

    End Sub

    Public Sub MOSTRAR(ByVal PRUTA As Integer, ByVal PFECHA As DateTime, ByVal PVENDEDOR As String)
        IDRUTA = PRUTA
        Fecha = PFECHA
        LBLFECHA.Text = PFECHA
        LBLRUTA.Text = PRUTA
        LBLVENDEDOR.TEXT = PVENDEDOR
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
        'frmAgendar.ShowDialog()
    End Sub

    'Private Sub BTNIZQUIERDA_Click(sender As Object, e As EventArgs) Handles BTNIZQUIERDA.Clicks
    '    Me.Close()
    'End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        'frmInfoVisita.VISITA = DGV.Item(0, DGV.CurrentRow.Index).Value.ToString
        ''  Dim VINFOV As New frmInfoVisita
        '' VINFOV.ShowDialog()
        'frmInfoVisita.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim QUER As String
        QUER = "SELECT * FROM VRTPVISITA WHERE FECHA='" + LBLFECHA.Text + "' AND VENDEDOR='" + LBLVENDEDOR.Text + "' "
        Dim REPI As New rptReporteDiaVendedor
        MOSTRARREPORTE(REPI, "Reporte del Dia Vendedor", BDLlenaTabla(QUER, frmPrincipal.CadenaConexion), "")
    End Sub
End Class