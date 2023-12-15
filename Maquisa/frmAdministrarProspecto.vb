Public Class frmAdministrarProspecto
    Private Sub frmAdministrarProspecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        Me.Icon = frmPrincipal.Icon
        CARGADATOS()
    End Sub
    Private Sub CARGADATOS()
        Dim QUERY As String
        QUERY = "SELECT VISITA,VENDEDOR,CLIENTE, ORDEN, [RESULTA DOVISITA], [CONTACTOS CLIENTE]  "
        QUERY = QUERY + "FROM [dbo].[VDETALLEAGENDA] WHERE RUTA=" + IDRUTA.ToString + " AND  FECHA2>=@INI AND FECHA2<@FIN"
        DGV.DataSource = BDLlenaTabla(QUERY, frmPrincipal.CadenaConexion, Fecha.Date, Fecha.Date.AddDays(1))
        DgvAjusteEncabezado(DGV, 1)
    End Sub
End Class