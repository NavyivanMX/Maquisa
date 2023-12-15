Public Class frmAdministrarProspecto
    Private Sub frmAdministrarProspecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        Me.Icon = frmPrincipal.Icon
        CARGADATOS()
    End Sub
    Private Sub CARGADATOS()
        Dim QUERY As String
        QUERY = "SELECT  Marcar = CONVERT(BIT,0),P.Clave, P.Nombre, V.NOMBRE Vendedor,TP.NOMBRE [Tipo Prospecto],P.Domicilio, convert(char,P.fechaini,103) Fecha, DBO.OBSPROSPECTOS (P.CLAVE) Observaciones"
        QUERY = QUERY + " FROM PROSPECTOS P   INNER JOIN VENDEDORES V ON P.VENDEDOR=V.CLAVE  INNER JOIN TIPOPROSPECTO TP ON TP.CLAVE=P.TipoProspecto   WHERE P.RESULTADOPROSPECTO=0  "
        DGV.DataSource = BDLlenaTabla(QUERY, frmPrincipal.CadenaConexion)

        DgvAjusteEncabezado(DGV, 7)
        DGV.Columns(1).ReadOnly = True
        DGV.Columns(2).ReadOnly = True
        DGV.Columns(3).ReadOnly = True
        DGV.Columns(4).ReadOnly = True
        DGV.Columns(5).ReadOnly = True
        DGV.Columns(6).ReadOnly = True
        DGV.Columns(7).ReadOnly = True

    End Sub
End Class