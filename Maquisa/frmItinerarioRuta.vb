﻿Public Class frmItinerarioRuta
    Dim CLACLI As New List(Of String)
    Dim CLASUC As New List(Of String)
    Dim CLARUT As New List(Of String)
    Dim CCLIENTE As String
    Dim SUCURSAL, NRUTA As String
    Dim RUTA As Integer
    Dim NCLIENTE As String
    Dim CLACLIENTE, ORD As Integer
    Dim ESTAINICIADO As Integer
    Dim QUERY As String
    Dim DT As New DataTable
    Private Sub frmItinerarioRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        CHECATABLA()

        If ESTAINICIADO = 0 Then
            LIMPIAR()
            ACTIVAR(True)
            CARGASUCURSALES()
            'CARGARUTAS()
            OPCargaX(CLASUC, CBSUC, frmPrincipal.SucursalBase)
        Else
            ACTIVAR(False)
            CARGAR()

        End If

        'LBLSUC.Text = SUCURSAL
        'LBLRUTA.Text = NRUTA 'NOMBRE RUTA 

    End Sub
    Private Sub CARGACLIENTES()
        QUERY = "SELECT CLAVE,NOMBRE FROM CLIENTES WHERE ACTIVO=1 ORDER BY NOMBRE "
        'DT.Clear()
        'DT = BDLlenatabla(QUERY, frmPrincipal.CADENACONEXION)
        OPLlenaComboBox(CBCLI, CLACLI, QUERY, frmPrincipal.CadenaConexion)

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

        Dim SQLGUARDAR As New SqlClient.SqlCommand
        SQLGUARDAR.Connection = frmPrincipal.CONX
        SQLGUARDAR.CommandType = CommandType.StoredProcedure
        SQLGUARDAR.CommandText = "SPCONFIGITINERARIORUTA"
        SQLGUARDAR.Parameters.Add("@SUC", SqlDbType.VarChar).Value = CLASUC(CBSUC.SelectedIndex)
        SQLGUARDAR.Parameters.Add("@RUTA", SqlDbType.Int).Value = CLARUT(CBR.SelectedIndex)
        SQLGUARDAR.Parameters.Add("@DIA", SqlDbType.Int).Value = CBD.SelectedIndex + 1
        SQLGUARDAR.Parameters.Add("@CLIENTE", SqlDbType.Int).Value = CLACLI(CBCLI.SelectedIndex)
        SQLGUARDAR.ExecuteNonQuery()

        CBCLI.Focus()

        'MessageBox.Show("La información agrego correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'LIMPIAR()
        'ACTIVAR(True)
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
        ''PRIMERO BORRAMOS DE LA TABLA EN CUESTION LA RUTA,SUCURSAL,DIA
        Dim DIA As Integer
        DIA = CBD.SelectedIndex + 1
        Dim SQLBORRA As New SqlClient.SqlCommand("DELETE FROM ITINERARIORUTA WHERE SUCURSAL='" + CLASUC(CBSUC.SelectedIndex) + "' AND RUTA=" + CLARUT(CBR.SelectedIndex) + " AND DIA=" + DIA.ToString + " ", frmPrincipal.CONX)
        SQLBORRA.ExecuteNonQuery()
        ''DESPUES NSERTAMOS LO QUE HAY EN EL DGV3


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
    End Sub
  
    Private Sub BTNNIVANT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNIVANT.Click
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
        AGREGAR()
        CARGAR()
        CHECATABLA()
    End Sub

   
    Private Sub BTNQUITAR_Click(sender As Object, e As EventArgs) Handles BTNQUITAR.Click
        DGV3.Rows.RemoveAt(DGV3.CurrentRow.Index)
        'QUITAR()
        'CARGAR()
        CHECATABLA()
    End Sub

   
    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        QUITAR()
        CARGAR()
    End Sub
End Class