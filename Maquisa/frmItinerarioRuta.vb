Public Class frmItinerarioRuta
    Dim CLACLI As New List(Of String)
    Dim CLASUC As New List(Of String)
    Dim CLARUT As New List(Of String)
    Dim CLADIA As New List(Of String)
    Dim CCLIENTE As String
    Dim SUCURSAL, NRUTA As String
    Dim RUTA As Integer
    Dim NCLIENTE As String
    Dim CLACLIENTE, ORD As Integer
    Dim ESTAINICIADO As Integer
    Dim QUERY As String
    Dim DT As New DataTable
    Dim CLAVECLIENTE As String
    Public MSG As New Mensajes
    Private Sub frmItinerarioRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        CHECATABLA()
        CARGASUCURSALES()
        CARGACLIENTES()
        CARGADIAS()
        If ESTAINICIADO = 0 Then
            LIMPIAR()
            ACTIVAR(True)
            OPCargaX(CLASUC, CBSUC, frmPrincipal.SucursalBase)
        ElseIf ESTAINICIADO = 2 Then
            LIMPIAR()
            ACTIVAR(True)
            OPCargaX(CLACLI, CBCLI, CLAVECLIENTE)
        Else
            ACTIVAR(False)
            CARGAR()
        End If

    End Sub
    Private Sub CARGACLIENTES()
        Dim QUERY As String
        QUERY = "SELECT CLAVE,NOMBRE FROM CLIENTES WHERE ACTIVO=1 ORDER BY NOMBRE "
        OPLlenaComboBox(CBCLI, CLACLI, QUERY, frmPrincipal.CadenaConexion)
    End Sub
    Private Sub CARGADIAS()
        Dim QUERY As String
        QUERY = "SELECT CLAVE,NOMBRE FROM DIASSEMANA WHERE ACTIVO=1  ORDER BY CLAVE ASC "
        OPLlenaComboBox(CBD, CLADIA, QUERY, frmPrincipal.CadenaConexion)
    End Sub
    Private Sub CARGASUCURSALES()
        OPLlenaComboBox(CBSUC, CLASUC, "SELECT CLAVE,NOMBRE FROM SUCURSALES WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion)
    End Sub
    Private Sub ACTIVAR(ByRef V As Boolean)
        CBSUC.Enabled = V
        CBR.Enabled = V
        BTNACEPTAR.Enabled = V
        BTNCANCELAR.Enabled = Not V
        CBD.Enabled = Not V
        CBCLI.Enabled = Not V
        BTNAGREGAR.Enabled = Not V
        BTNQUITAR.Enabled = Not V
    End Sub
    Private Sub CARGARUTAS()
        OPLlenaComboBox(CBR, CLARUT, "SELECT CLAVE,NOMBRE FROM RUTAS WHERE ACTIVO=1 AND SUCURSAL ='" + CLASUC(CBSUC.SelectedIndex) + "' ORDER BY NOMBRE", frmPrincipal.CadenaConexion)
    End Sub
    Public Sub INFO(ByVal SUC As String, ByVal R As Integer)
        SUCURSAL = SUC
        RUTA = R
        CARGASUCURSALES()
        OPCargaX(CLASUC, CBSUC, SUCURSAL)
        OPCargaX(CLARUT, CBR, RUTA)
        ESTAINICIADO = 1
        Me.ShowDialog()
    End Sub
    Public Sub MOSTRAR(ByVal CLI As String)
        CLAVECLIENTE = CLI
        ESTAINICIADO = 2
        Me.ShowDialog()
    End Sub
    Private Sub LIMPIAR()
        OPCargaX(CLASUC, CBSUC, frmPrincipal.SucursalBase)
        If CBR.SelectedIndex <> -1 Then
            CBR.SelectedIndex = 0
        End If
        LBLVENDEDOR.Text = ""
        DGV3.DataSource = Nothing
        DGV3.Rows.Clear()
        DGV3.Refresh()

    End Sub
    Private Sub AGREGAR(ByVal NOMCLIENTE As String, CVECLIENTE As Integer)

        If CBCLI.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK)
            Exit Sub
        End If
        If CBCLI.Items.Count <= 0 Then
            Return
        End If

        'CANDADO PARA VER SI CLIENTES YA FUE AGREGADO A LA RUTA

        Dim X As Integer
        For X = 0 To DGV3.Rows.Count - 1
            If DGV3.Item(2, X).Value = CLACLI(CBCLI.SelectedIndex) Then
                MessageBox.Show("El cliente ya fue agregado a la ruta", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
        Next

        'agregar a la tabla
        DGV3.Rows.Add(1)
        Dim ITEMS As Integer
        ITEMS = DGV3.Rows.Count - 1
        DGV3.Item(0, ITEMS).Value = NOMCLIENTE
        DGV3.Item(1, ITEMS).Value = SIGORDEN()
        DGV3.Item(2, ITEMS).Value = CLACLI(CBCLI.SelectedIndex)

        CBCLI.Focus()

    End Sub

    Private Sub CARGAR()
        Dim QUERY As String
        Dim DIA As Integer

        DIA = CLADIA(CBD.SelectedIndex)
        QUERY = "SELECT C.NOMBRE CLIENTE,CI.ORDEN,CI.CLIENTE FROM ITINERARIORUTA CI INNER JOIN CLIENTEs C ON  CI.CLIENTE=C.CLAVE WHERE CI.SUCURSAL='" + CLASUC(CBSUC.SelectedIndex).ToString + "' AND CI.RUTA=" + CLARUT(CBR.SelectedIndex).ToString + " AND C.ACTIVO=1 AND CI.DIA=" + DIA.ToString + " ORDER BY ORDEN"
        Dim DA As New SqlClient.SqlDataAdapter(QUERY, frmPrincipal.CONX)
        Dim DDT As New DataTable
        DA.Fill(DDT)
        DGV3.Rows.Clear()
        Dim X As Integer
        Dim ITEMS As Integer
        For X = 0 To DDT.Rows.Count - 1
            DGV3.Rows.Add(1)
            ITEMS = DGV3.Rows.Count - 1
            DGV3.Item(0, ITEMS).Value = DDT.Rows(X).Item(0)
            DGV3.Item(1, ITEMS).Value = DDT.Rows(X).Item(1)
            DGV3.Item(2, ITEMS).Value = DDT.Rows(X).Item(2)
        Next
        CHECATABLA()

        DGV3.Columns(2).Visible = False
        DgvAjusteEncabezado(DGV3, 0)

        LBLVENDEDOR.Text = BDExtraeUnDato("SELECT V.NOMBRE VENDEDOR FROM RUTAS R INNER JOIN VENDEDORES V ON R.VENDEDOR=V.CLAVE WHERE R.CLAVE=" + CLARUT(CBR.SelectedIndex).ToString + " ", frmPrincipal.CadenaConexion)

    End Sub
    Private Function SIGORDEN()
        Dim ORDEN As Integer
        ORDEN = 0
        If DGV3.Rows.Count <> 0 Then

            For X = 0 To DGV3.Rows.Count - 1
                If (DGV3.Item(1, X).Value) >= ORDEN Then
                    ORDEN = DGV3.Item(1, X).Value + 1
                End If
0
            Next
        End If
        Return ORDEN
    End Function

    Private Sub CBSUC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBSUC.SelectedIndexChanged
        CARGARUTAS()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        ACTIVAR(True)
        LIMPIAR()
        CHECATABLA()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACEPTAR.Click

        ACTIVAR(False)
        CBD.SelectedIndex = 0
        CARGAR()
        CHECATABLA()
        CBD.Focus()
        If ESTAINICIADO = 2 Then
            OPCargaX(CLACLI, CBCLI, CLAVECLIENTE)
        End If
    End Sub
    Private Sub CBD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBD.SelectedIndexChanged
        CARGAR()
        CHECATABLA()
        CBCLI.Focus()
    End Sub
    Private Sub QUITAR()

        DGV3.Rows.RemoveAt(DGV3.CurrentRow.Index)

    End Sub

    Private Sub BTNNIVANT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNIVANT.Click


        ' Verificar si la fila seleccionada no es la primera
        If DGV3.CurrentRow.Index = 0 Then
            Return
        End If

        ' Obtener el índice de la fila seleccionada y el índice de la fila destino
        Dim filaActual As Integer = DGV3.CurrentRow.Index
        Dim filaDestino As Integer = filaActual - 1

        ' Intercambiar las filas
        Dim temp As DataGridViewRow = DGV3.Rows(filaActual)
        DGV3.Rows.RemoveAt(filaActual)
        DGV3.Rows.Insert(filaDestino, temp)

        ' Ajustar la selección a la nueva posición de la fila
        DGV3.ClearSelection()
        DGV3.Rows(filaDestino).Selected = True
        DGV3.CurrentCell = DGV3.Rows(filaDestino).Cells(0)

        ' Actualizar la columna "Orden" para que sea consecutiva
        For i As Integer = 0 To DGV3.Rows.Count - 1
            DGV3.Rows(i).Cells("ORDEN").Value = i + 1
        Next
    End Sub
    Private Sub BTNNIVPROX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNIVPROX.Click

        ' Verificar si la fila seleccionada no es la última
        If DGV3.CurrentRow.Index = DGV3.Rows.Count - 1 Then
            Return
        End If

        ' Obtener el índice de la fila seleccionada y el índice de la fila destino
        Dim filaActual As Integer = DGV3.CurrentRow.Index
        Dim filaDestino As Integer = filaActual + 1

        ' Intercambiar las filas
        Dim temp As DataGridViewRow = DGV3.Rows(filaActual)
        DGV3.Rows.RemoveAt(filaActual)
        DGV3.Rows.Insert(filaDestino, temp)

        ' Ajustar la selección a la nueva posición de la fila
        DGV3.ClearSelection()
        DGV3.Rows(filaDestino).Selected = True
        DGV3.CurrentCell = DGV3.Rows(filaDestino).Cells(0)

        ' Actualizar la columna "Orden" para que sea consecutiva
        For i As Integer = 0 To DGV3.Rows.Count - 1
            DGV3.Rows(i).Cells("ORDEN").Value = i + 1
        Next

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CLIENTES As New frmClientes
        CLIENTES.ShowDialog()
        CARGACLIENTES()
    End Sub

    Private Sub CHECATABLA()

        If DGV3.Rows.Count = 0 Then
            BTNQUITAR.Enabled = False
            BTNNIVANT.Enabled = False
            BTNNIVPROX.Enabled = False
            BTNGUARDAR.Enabled = False
        Else
            BTNQUITAR.Enabled = True
            BTNNIVANT.Enabled = True
            BTNNIVPROX.Enabled = True
            BTNGUARDAR.Enabled = True
        End If

    End Sub


    Private Sub BTNAGREGAR_Click(sender As Object, e As EventArgs) Handles BTNAGREGAR.Click
        AGREGAR(CBCLI.Text, CLACLI(CBCLI.SelectedIndex))
        CHECATABLA()
    End Sub



    Private Sub BTNQUITAR_Click(sender As Object, e As EventArgs) Handles BTNQUITAR.Click
        QUITAR()
        CHECATABLA()
    End Sub

    Private Sub GUARDAR()
        Dim DIA As Integer
        DIA = CLADIA(CBD.SelectedIndex)
        Dim SQLBORRA As New SqlClient.SqlCommand("DELETE FROM ITINERARIORUTA WHERE SUCURSAL='" + CLASUC(CBSUC.SelectedIndex) + "' AND RUTA=" + CLARUT(CBR.SelectedIndex) + " AND DIA=" + DIA.ToString + " ", frmPrincipal.CONX)
        SQLBORRA.ExecuteNonQuery()

        Dim SQLGUARDAR As New SqlClient.SqlCommand
        SQLGUARDAR.Connection = frmPrincipal.CONX
        SQLGUARDAR.CommandType = CommandType.StoredProcedure
        SQLGUARDAR.CommandText = "[SPCONFIGITINERARIORUTA]"
        SQLGUARDAR.Parameters.Add("@SUC", SqlDbType.VarChar)
        SQLGUARDAR.Parameters.Add("@RUTA", SqlDbType.Int)
        SQLGUARDAR.Parameters.Add("@DIA", SqlDbType.Int)
        SQLGUARDAR.Parameters.Add("@CLIENTE", SqlDbType.Int)
        SQLGUARDAR.Parameters.Add("@ORD", SqlDbType.Int)
        For X = 0 To DGV3.Rows.Count - 1
            SQLGUARDAR.Parameters("@SUC").Value = CLASUC(CBSUC.SelectedIndex)
            SQLGUARDAR.Parameters("@RUTA").Value = CLARUT(CBR.SelectedIndex)
            SQLGUARDAR.Parameters("@DIA").Value = DIA.ToString
            SQLGUARDAR.Parameters("@CLIENTE").Value = DGV3.Item(2, X).Value
            SQLGUARDAR.Parameters("@ORD").Value = DGV3.Item(1, X).Value
            SQLGUARDAR.ExecuteNonQuery()
        Next

        Dim SGLEDITAAGENDA As New SqlClient.SqlCommand
        SGLEDITAAGENDA.Connection = frmPrincipal.CONX
        SGLEDITAAGENDA.CommandType = CommandType.StoredProcedure
        SGLEDITAAGENDA.CommandText = "[SPREGENERADORAGENDAVISITA]"
        SGLEDITAAGENDA.Parameters.Add("@SUC", SqlDbType.VarChar).Value = CLASUC(CBSUC.SelectedIndex)
        SGLEDITAAGENDA.Parameters.Add("@DIA", SqlDbType.Int).Value = DIA.ToString
        SGLEDITAAGENDA.Parameters.Add("@RUTA", SqlDbType.Int).Value = CLARUT(CBR.SelectedIndex)
        SGLEDITAAGENDA.ExecuteNonQuery()

    End Sub


    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        GUARDAR()

        MessageBox.Show("La información agrego correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        If MSG.mensaje_confirmacion("¿Desea Cambiar otro orden?") <> 6 Then
            LIMPIAR()
            ACTIVAR(True)
        End If



    End Sub
End Class