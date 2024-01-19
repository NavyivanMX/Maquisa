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

    Private Sub BTNQUITAR_Click(sender As Object, e As EventArgs) Handles BTNQUITAR.Click
        Dim X As Integer
        Dim QUERY As String
        Dim CLAVE As Integer

        For X = 0 To DGV.Rows.Count - 1
            If DGV.Item(0, X).Value = True Then
                Try
                    CLAVE = DGV.Item(1, X).Value
                    QUERY = "UPDATE PROSPECTOS SET RESULTADOPROSPECTO=2 WHERE CLAVE=" + CLAVE.ToString + " "
                    BDEjecutarSql(QUERY, frmPrincipal.CadenaConexion)
                Catch ex As Exception
                    OPMsgError("Paso un detalle, avisar a Structure Soluciones")
                End Try
            End If
        Next

        CARGADATOS()
    End Sub

    Private Sub BTNACLIENTE_Click(sender As Object, e As EventArgs) Handles BTNACLIENTE.Click
        Dim X As Integer
        Dim QUERY As String
        Dim CLAVE As Integer

        For X = 0 To DGV.Rows.Count - 1
            If DGV.Item(0, X).Value = True Then
                Try
                    CLAVE = DGV.Item(1, X).Value
                    frmClientes.MOSTRAR(DGV.Item(2, X).Value, DGV.Item(5, X).Value)
                    QUERY = "UPDATE PROSPECTOS SET RESULTADOPROSPECTO=1 WHERE CLAVE=" + CLAVE.ToString + " "
                    BDEjecutarSql(QUERY, frmPrincipal.CadenaConexion)
                Catch ex As Exception
                    OPMsgError("Paso un detalle, avisar a Structure Soluciones")
                End Try
            End If
        Next

        CARGADATOS()
    End Sub
End Class