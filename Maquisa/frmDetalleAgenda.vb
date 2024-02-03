Public Class frmDetalleAgenda
    Dim IDRUTA As Integer
    Dim Fecha As DateTime
    Private Sub frmDetalleAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        Me.Icon = frmPrincipal.Icon
        LBLNUMPROSPECTO.Text = BDExtraeUnDato("SELECT ISNULL(COUNT(CLAVE),0) FROM PROSPECTOS WHERE RESULTADOPROSPECTO=0", frmPrincipal.CadenaConexion)

    End Sub

    Public Sub MOSTRAR(ByVal PRUTA As Integer, ByVal PFECHA As DateTime, ByVal PVENDEDOR As String, ByVal PVISITADOS As String)
        IDRUTA = PRUTA
        Fecha = PFECHA
        LBLFECHA.Text = PFECHA.ToString("dd/MM/yyyy")
        LBLRUTA.Text = PRUTA
        LBLVENDEDOR.Text = PVENDEDOR
        LBLVISITAS.Text = PVISITADOS
        CARGADATOS()
        Me.ShowDialog()

    End Sub

    Private Sub CARGADATOS()
        Dim QUERY As String
        QUERY = "SELECT VISITA,VENDEDOR,CLIENTE, ORDEN, [RESULTA DOVISITA], [CONTACTOS CLIENTE]  "
        QUERY = QUERY + "FROM [dbo].[VDETALLEAGENDA] WHERE RUTA=" + IDRUTA.ToString + " AND  FECHA2>=@INI AND FECHA2<@FIN"
        DGV.DataSource = BDLlenaTabla(QUERY, frmPrincipal.CadenaConexion, Fecha.Date, Fecha.Date.AddDays(1))
        DgvAjusteEncabezado(DGV, 1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BTNAGENDAR_Click(sender As Object, e As EventArgs) Handles LBLVISITADOS.Click
        frmAgendar.ShowDialog()
    End Sub



    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        frmInfoVisita2.VISITA = DGV.Item(0, DGV.CurrentRow.Index).Value.ToString
        frmInfoVisita2.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim QUER As String
        QUER = "SELECT *, VISITADOS='" + LBLVISITAS.Text + "' FROM VRTPVISITA "
        QUER = QUER + " WHERE FECHA='" + LBLFECHA.Text + "' AND VENDEDOR='" + LBLVENDEDOR.Text + "' ORDER BY FECHAINI ASC"
        Dim REPI As New rptReporteDiaVendedor
        MOSTRARREPORTE(REPI, "Reporte del Dia Vendedor", BDLlenaTabla(QUER, frmPrincipal.CadenaConexion), "")


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub


    Private Sub BTNIZQUIERDA_Click(sender As Object, e As EventArgs) Handles BTNIZQUIERDA.Click
        Me.Close()

    End Sub

    Private Sub BTNADMINPROSPECTO_Click(sender As Object, e As EventArgs) Handles BTNADMINPROSPECTO.Click
        frmAdministrarProspecto.ShowDialog()
    End Sub
End Class