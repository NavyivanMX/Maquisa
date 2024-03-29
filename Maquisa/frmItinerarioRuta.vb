﻿Public Class frmItinerarioRuta
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

    Public MSG As New Mensajes
    Private Sub frmItinerarioRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        CHECATABLA()

        If ESTAINICIADO = 0 Then
            LIMPIAR()
            ACTIVAR(True)
            CARGASUCURSALES()
            CARGADIAS()
            OPCargaX(CLASUC, CBSUC, frmPrincipal.SucursalBase)
        Else
            ACTIVAR(False)
            CARGAR()

        End If




        'LBLSUC.Text = SUCURSAL
        'LBLRUTA.Text = NRUTA 'NOMBRE RUTA 

    End Sub
    Private Sub CARGACLIENTES()
        QUERY = "SELECT CLAVE,NOMBRE FROM CLIENTES WHERE ACTIVO=1 AND CLAVE NOT IN (select CLIENTE FROM ITINERARIORUTA WHERE SUCURSAL='" + CLASUC(CBSUC.SelectedIndex) + "' AND RUTA='" + CLARUT(CBR.SelectedIndex) + "' AND DIA='" + (CBD.SelectedIndex + 1).ToString + "') ORDER BY NOMBRE "

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
    Private Sub LIMPIAR()
        OPCargaX(CLASUC, CBSUC, frmPrincipal.SucursalBase)
        If CBR.SelectedIndex <> -1 Then
            CBR.SelectedIndex = 0
        End If
        LBLVENDEDOR.Text = ""
        DGV3.DataSource = Nothing
        DGV3.Rows.Clear()
        DGV3.Refresh()
        'CBCLIENTES.Text = ""
    End Sub
    Private Sub AGREGAR()
        Dim POSCLI As Integer
        POSCLI = CBCLI.SelectedIndex
        Dim SQLGUARDAR As New SqlClient.SqlCommand
        SQLGUARDAR.Connection = frmPrincipal.CONX
        SQLGUARDAR.CommandType = CommandType.StoredProcedure
        SQLGUARDAR.CommandText = "SPCONFIGITINERARIORUTA"
        SQLGUARDAR.Parameters.Add("@SUC", SqlDbType.VarChar).Value = CLASUC(CBSUC.SelectedIndex)
        SQLGUARDAR.Parameters.Add("@RUTA", SqlDbType.Int).Value = CLARUT(CBR.SelectedIndex)
        SQLGUARDAR.Parameters.Add("@DIA", SqlDbType.Int).Value = CBD.SelectedIndex + 1
        SQLGUARDAR.Parameters.Add("@CLIENTE", SqlDbType.Int).Value = CLACLI(POSCLI)
        SQLGUARDAR.ExecuteNonQuery()

        CBCLI.Items.RemoveAt(POSCLI)
        CLACLI.RemoveAt(POSCLI)
        CBCLI.Focus()


    End Sub
    'Private Sub BUSCAR()
    '    Dim QUERY As String
    '    QUERY = "SELECT CLAVE,NOMBRE CLIENTE FROM CLIENTE WHERE SUCURSAL = '" + CLASUC(CBSUC.SelectedIndex) + "' AND RUTA = " + CLARUT(CBR.SelectedIndex) + " AND NOMBRE LIKE '%" + CBCLIENTES.Text + "%'"
    '    OPLlenaCombobox(CBCLIENTES, CLACLI, QUERY, frmPrincipal.CADENACONEXION)
    '    CBCLIENTES.DroppedDown = True
    'End Sub
    Private Sub CARGAR()
        Dim QUERY As String
        Dim DIA As Integer

        DIA = CBD.SelectedIndex + 1
        QUERY = "SELECT C.NOMBRE CLIENTE,CI.ORDEN,CI.CLIENTE FROM ITINERARIORUTA CI INNER JOIN CLIENTEs C ON  CI.CLIENTE=C.CLAVE WHERE CI.SUCURSAL='" + CLASUC(CBSUC.SelectedIndex).ToString + "' AND CI.RUTA=" + CLARUT(CBR.SelectedIndex).ToString + " AND C.ACTIVO=1 AND CI.DIA=" + DIA.ToString + " ORDER BY ORDEN"
        DGV3.DataSource = BDLlenaTabla(QUERY, frmPrincipal.CadenaConexion)
        DGV3.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV3.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV3.Columns(2).Visible = False

        LBLVENDEDOR.Text = BDExtraeUnDato("SELECT V.NOMBRE VENDEDOR FROM RUTAS R INNER JOIN VENDEDORES V ON R.VENDEDOR=V.CLAVE WHERE R.CLAVE=" + CLARUT(CBR.SelectedIndex).ToString + " ", frmPrincipal.CadenaConexion)

        CARGACLIENTES()

    End Sub
    Private Function SIGORDEN()
        Dim ORDEN As Integer
        For X = 0 To DGV3.Rows.Count - 1
            ORDEN = DGV3.Item(1, X).Value.ToString() + 1
        Next
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
    End Sub
    Private Sub CBD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBD.SelectedIndexChanged
        CARGAR()
        CHECATABLA()
        CBCLI.Focus()
    End Sub
    Private Sub QUITAR()

        Dim DIA As Integer
        DIA = CBD.SelectedIndex + 1
        Dim SQLBORRA As New SqlClient.SqlCommand("DELETE FROM ITINERARIORUTA WHERE SUCURSAL='" + CLASUC(CBSUC.SelectedIndex) + "' AND RUTA=" + CLARUT(CBR.SelectedIndex) + " AND DIA=" + DIA.ToString + " ", frmPrincipal.CONX)
        SQLBORRA.ExecuteNonQuery()



        Dim SQLGUARDAR As New SqlClient.SqlCommand
        SQLGUARDAR.Connection = frmPrincipal.CONX
        SQLGUARDAR.CommandType = CommandType.StoredProcedure
        SQLGUARDAR.CommandText = "[SPMUEVEQUITACLIENTEITINERARIO]"
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
            SQLGUARDAR.Parameters("@ORD").Value = X + 1
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

    Private Sub BTNNIVANT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNIVANT.Click
        If DGV3.CurrentRow.Index = 0 Then
            Return
        End If
        Dim FILA As Integer = DGV3.CurrentRow.Index ''FILA = A LA FILA SELECCIONADA
        Dim PROXFILA As Integer = DGV3.CurrentRow.Index - 1 ''EN ESTE CASO LA FILA QUE SELECCIONASTE LA VA A SUBIR, A LA ACTUAL - 1

        Dim FORIGEN As DataGridViewRow = DGV3.Rows(FILA)
        Dim FDESTINO As DataGridViewRow = DGV3.Rows(PROXFILA)

        Dim DATAORIGEN As Object() = New Object(FORIGEN.Cells.Count - 1) {} ''CARGAR LOS VALORES DE LAS CELDAS A COPIAR
        Dim DATADESTINO As Object() = New Object(FDESTINO.Cells.Count - 1) {}

        'HACER EL CAMBIO
        For CONT = 0 To DATADESTINO.Length - 1
            DATAORIGEN(CONT) = FORIGEN.Cells(CONT).Value
            DATADESTINO(CONT) = FDESTINO.Cells(CONT).Value
        Next

        For CONT = 0 To DATAORIGEN.Length - 1
            DGV3.Rows(FILA).Cells(CONT).Value = DATADESTINO(CONT)
            DGV3.Rows(FILA - 1).Cells(CONT).Value = DATAORIGEN(CONT)
        Next

        DGV3.CurrentCell = DGV3.Rows(PROXFILA).Cells(0)
        'QUITAR()
        'CARGAR()
    End Sub
    Private Sub BTNNIVPROX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNIVPROX.Click
        Dim FILA As Integer = DGV3.CurrentRow.Index ''FILA = A LA FILA SELECCIONADA
        Dim PROXFILA As Integer = DGV3.CurrentRow.Index + 1 ''EN ESTE CASO LA FILA QUE SELECCIONASTE LA VA A BAJAR, A LA ACTUAL + 1

        Dim FORIGEN As DataGridViewRow = DGV3.Rows(FILA)
        Dim FDESTINO As DataGridViewRow = DGV3.Rows(PROXFILA)

        Dim DATAORIGEN As Object() = New Object(FORIGEN.Cells.Count - 1) {} ''CARGAR LOS VALORES DE LAS CELDAS A COPIAR
        Dim DATADESTINO As Object() = New Object(FDESTINO.Cells.Count - 1) {}

        'HACER EL CAMBIO
        For CONT = 0 To DATADESTINO.Length - 1
            DATAORIGEN(CONT) = FORIGEN.Cells(CONT).Value
            DATADESTINO(CONT) = FDESTINO.Cells(CONT).Value
        Next

        For CONT = 0 To DATAORIGEN.Length - 1
            DGV3.Rows(FILA).Cells(CONT).Value = DATADESTINO(CONT)
            DGV3.Rows(FILA + 1).Cells(CONT).Value = DATAORIGEN(CONT)
        Next
        DGV3.CurrentCell = DGV3.Rows(PROXFILA).Cells(0)
        'QUITAR()
        'CARGAR()
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
        If CBCLI.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK)
            Exit Sub
        End If
        If CBCLI.Items.Count <= 0 Then
            Return
        End If
        AGREGAR()
        CARGAR()
        CHECATABLA()
    End Sub



    Private Sub BTNQUITAR_Click(sender As Object, e As EventArgs) Handles BTNQUITAR.Click
        CLACLI.Add(DGV3.Item(2, DGV3.CurrentRow.Index).Value.ToString)
        CBCLI.Items.Add(DGV3.Item(0, DGV3.CurrentRow.Index).Value.ToString)
        DGV3.Rows.RemoveAt(DGV3.CurrentRow.Index)


        QUITAR()
        CARGAR()
        CHECATABLA()
    End Sub


    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        QUITAR()
        ' CARGAR()
        MessageBox.Show("La información agrego correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        If MSG.mensaje_confirmacion("¿Desea Cambiar otro orden?") <> 6 Then
            LIMPIAR()
            ACTIVAR(True)
        End If



    End Sub
End Class