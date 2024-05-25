Public Class frmAgendar
    Dim CLACLI As New List(Of String)
    Dim CLASUC As New List(Of String)
    Dim CLARUT As New List(Of String)
    Dim CLAVEN As Integer
    Dim NUM As Integer
    Private Sub frmAgendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        CARGASIGVISITA()
        OPCargaX(CLASUC, CBSUC, frmPrincipal.SucursalBase)
        CARGARUTAS()
        CARGACLIENTES()

    End Sub
    Private Sub CARGARUTAS()
        Dim QUERY As String
        QUERY = "SELECT CLAVE,NOMBRE FROM RUTAS WHERE ACTIVO=1  ORDER BY NOMBRE"
        OPLlenaComboBox(CBR, CLARUT, QUERY, frmPrincipal.CadenaConexion)
    End Sub
    Private Sub CARGACLIENTES()
        Dim QUERY As String
        QUERY = "SELECT CLAVE,NOMBRE FROM CLIENTES WHERE ACTIVO=1  ORDER BY NOMBRE "
        OPLlenaComboBox(CBCLI, CLACLI, QUERY, frmPrincipal.CadenaConexion, "SELECCIONA CLIENTE", "")
    End Sub

    Private Sub CBR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBR.SelectedIndexChanged
        LBLVENDEDOR.Text = BDExtraeUnDato("SELECT V.NOMBRE VENDEDOR FROM RUTAS R INNER JOIN VENDEDORES V ON R.VENDEDOR=V.CLAVE WHERE R.CLAVE=" + CLARUT(CBR.SelectedIndex).ToString + " ", frmPrincipal.CadenaConexion)
        CLAVEN = BDExtraeUnDato("SELECT VENDEDOR FROM RUTAS WHERE CLAVE=" + CLARUT(CBR.SelectedIndex).ToString + " ", frmPrincipal.CadenaConexion)

    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        GUARDAR()
        LIMPIAR()
    End Sub

    Private Sub LIMPIAR()
        OPCargaX(CLASUC, CBSUC, frmPrincipal.SucursalBase)
        If CBR.SelectedIndex <> -1 Then
            CBR.SelectedIndex = 0
        End If
        If CBCLI.SelectedIndex <> -1 Then
            CBCLI.SelectedIndex = 0
        End If
        DTFECHA.Value = Now
        TXTORDEN.Text = "0"
        TXTOBS.Text = ""
        LBLVENDEDOR.Text = ""
        CARGASIGVISITA()
    End Sub
    Private Sub GUARDAR()
        If Not frmPrincipal.CHECACONX() Then
            Exit Sub
        End If

        Dim SQLGUARDAR As New SqlClient.SqlCommand
        SQLGUARDAR.Connection = frmPrincipal.CONX
        SQLGUARDAR.CommandType = CommandType.StoredProcedure

        SQLGUARDAR.Parameters.Add("@SUC", SqlDbType.VarChar).Value = frmPrincipal.SucursalBase
        SQLGUARDAR.Parameters.Add("@VISITA", SqlDbType.Int).Value = NUM
        SQLGUARDAR.Parameters.Add("@RUTA", SqlDbType.Int).Value = CLARUT(CBR.SelectedIndex)
        SQLGUARDAR.Parameters.Add("@CLIENTE", SqlDbType.Int).Value = CLACLI(CBCLI.SelectedIndex)
        SQLGUARDAR.Parameters.Add("@VENDEDOR", SqlDbType.Int).Value = CLAVEN
        SQLGUARDAR.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = DTFECHA.Text
        SQLGUARDAR.Parameters.Add("@ORDEN", SqlDbType.Int).Value = TXTORDEN.Text
        SQLGUARDAR.Parameters.Add("@DIA", SqlDbType.Int).Value = 0
        SQLGUARDAR.Parameters.Add("@OBS", SqlDbType.VarChar).Value = TXTOBS.Text

        SQLGUARDAR.CommandText = "SPAGENDARVISITA"
        SQLGUARDAR.ExecuteNonQuery()
        MessageBox.Show("La información ha sido guardada correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CLIENTES As New frmClientes
        CLIENTES.ShowDialog()
        CARGACLIENTES()
    End Sub
    Private Sub CARGASIGVISITA()
        If Not frmPrincipal.CHECACONX() Then
            Exit Sub
        End If

        NUM = 1
        Dim SQLMOV As New SqlClient.SqlCommand("SELECT dbo.SIGVISITAAGENDA()", frmPrincipal.CONX)
        Dim LECTOR As SqlClient.SqlDataReader
        LECTOR = SQLMOV.ExecuteReader
        If LECTOR.Read Then
            NUM = LECTOR(0)
            LECTOR.Close()
            LBLNUMVISITA.Text = NUM
        Else
            LECTOR.Close()
        End If
    End Sub
End Class