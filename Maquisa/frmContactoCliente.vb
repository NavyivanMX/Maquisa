﻿Public Class frmContactoCliente
    Dim CLACLIENTE As New List(Of String)
    Dim DESDEMOSTRAR As Boolean = False
    Private Sub frmContactoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PonerImagenesBotones(Me)
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)


        If Not DESDEMOSTRAR Then
            CARGACLIENTES() '' luego se vuelve a mandar llamare los clientes y se keda en posicion 0
            LIMPIAR()
            ACTIVAR(True)
        Else
            ACTIVAR(False)
        End If

    End Sub
    Private Sub CARGACLIENTES()
        OPLlenaComboBox(CBCLIENTE, CLACLIENTE, "SELECT CLAVE,NOMBRE FROM CLIENTES WHERE ACTIVO = 1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion) '' esto por default te pone en la posicion 0
    End Sub
    Private Sub ACTIVAR(ByVal V As Boolean)
        CBCLIENTE.Enabled = V
        TXTNOM.Enabled = Not V
        TXTPUESTO.Enabled = Not V
        TXTOBSERVACION.Enabled = Not V
        DGV.Enabled = Not V

        BTNGUARDAR.Enabled = Not V
        BTNCANCELAR.Enabled = Not V
        BTNAGREGAR.Enabled = Not V
        BTNQUITAR.Enabled = Not V

        If V Then
            CBCLIENTE.Focus()

        Else
            TXTNOM.Focus()
            TXTNOM.SelectAll()
        End If
    End Sub
    'SUB MOSTRAR , RECIBE  VARIABLE CLAVE CLIENTE INTEGER  DESDE LA VENTANA FRMINFOVISITA2

    Public Sub MOSTRAR(ByVal CLAVECLIENTE As Integer, ByVal NOMBRE As String, ByVal PUESTO As String, ByVal OBSERVACION As String)
        DESDEMOSTRAR = True
        TXTNOM.Text = NOMBRE
        TXTPUESTO.Text = PUESTO
        TXTOBSERVACION.Text = OBSERVACION
        CARGACLIENTES() '' aqui se cargan los clientes
        OPCargaX(CLACLIENTE, CBCLIENTE, CLAVECLIENTE) '' luego ubicas al cliente k venia como parametro
        CARGADATOS()
        ShowDialog()

    End Sub
    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        CARGADATOS()
    End Sub
    Private Sub CARGADATOS()
        ACTIVAR(False)
        Dim QUERY As String
        Dim COLUMNA As Integer
        QUERY = "SELECT NOMBRE,PUESTO,OBSERVACION FROM CONTACTOCLIENTE WHERE CLIENTE= '" + CLACLIENTE(CBCLIENTE.SelectedIndex) + "'"
        COLUMNA = 1
        Try
            Dim DA As New SqlClient.SqlDataAdapter(QUERY, frmPrincipal.CONX)

            Dim DDT As New DataTable
            DA.Fill(DDT)
            DGV.Rows.Clear()
            Dim X As Integer
            For X = 0 To DDT.Rows.Count - 1
                DGV.Rows.Add(1)
                Dim ITEMS As Integer
                ITEMS = DGV.Rows.Count - 1
                DGV.Item(0, ITEMS).Value = DDT.Rows(X).Item(0)
                DGV.Item(1, ITEMS).Value = DDT.Rows(X).Item(1)
                DGV.Item(2, ITEMS).Value = DDT.Rows(X).Item(2)
            Next
            DgvAjusteEncabezado(DGV, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub BTNAGREGAR_Click(sender As Object, e As EventArgs) Handles BTNAGREGAR.Click
        Dim x As Integer
        For x = 0 To DGV.Rows.Count - 1
            If DGV.Item(0, x).Value.ToString = TXTNOM.Text Then
                MessageBox.Show("El contacto ya fue agregado")
                Exit Sub
            End If
        Next
        AGREGAR()
    End Sub
    Private Sub AGREGAR()

        If TXTNOM.Text = "" Or TXTPUESTO.Text = "" Then
            MessageBox.Show("Falta captrurar informacion")
        Else

            DGV.Rows.Add(1)
            Dim ITEMS As Integer
            ITEMS = DGV.Rows.Count - 1
            DGV.Item(0, ITEMS).Value = TXTNOM.Text
            DGV.Item(1, ITEMS).Value = TXTPUESTO.Text
            DGV.Item(2, ITEMS).Value = TXTOBSERVACION.Text
            DgvAjusteEncabezado(DGV, 2)
            ''AJUSTAR LAS COLUMNAS DE DGV PARA QUE LLENE EL ESPACIO DE DGV

            CHECATABLA()
        End If
    End Sub

    Private Sub BTNQUITAR_Click(sender As Object, e As EventArgs) Handles BTNQUITAR.Click
        If DGV.Rows.Count <> 0 Then
            'Cargar la info de la fila seleccionada a TXTNOM y TXTPUESTO, TXTOBSERVACION
            TXTNOM.Text = DGV.Item(0, DGV.CurrentRow.Index).Value.ToString
            TXTPUESTO.Text = DGV.Item(1, DGV.CurrentRow.Index).Value.ToString
            TXTOBSERVACION.Text = DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
            DGV.Rows.RemoveAt(DGV.CurrentRow.Index)
            CHECATABLA()
        Else
            MessageBox.Show("No hay datos para eliminar")
        End If

    End Sub
    Private Sub CHECATABLA()
        If DGV.Rows.Count = 0 Then
            BTNQUITAR.Enabled = False
            'BTNELIMINAR.Enabled = False
            BTNGUARDAR.Enabled = False
        Else
            BTNQUITAR.Enabled = True
            'BTNELIMINAR.Enabled = True
            BTNGUARDAR.Enabled = True
        End If
    End Sub

    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        LIMPIAR()
        DGV.Rows.Clear()
        ACTIVAR(True)
    End Sub

    Private Sub LIMPIAR()
        DGV.Rows.Clear()
        TXTNOM.Text = ""
        TXTPUESTO.Text = ""
        TXTOBSERVACION.Text = ""
        CBCLIENTE.SelectedIndex = 0

    End Sub
    Private Sub LIMPIAR2()
        TXTNOM.Text = ""
        TXTPUESTO.Text = ""
        TXTOBSERVACION.Text = ""
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If Not DGV.Rows.Count > 0 Then
            MessageBox.Show("Debe de agregar por lo menos un subconcepto")
            Exit Sub
        End If

        GUARDAR()
        LIMPIAR()
        ACTIVAR(True)

    End Sub

    Private Sub GUARDAR()

        If Not frmPrincipal.CHECACONX Then
            Try
                OPMsgError("No hay conexion")
            Catch ex As Exception
                Exit Sub
            End Try
        End If


        Dim SQLBORRA As New SqlClient.SqlCommand("", frmPrincipal.CONX)
        SQLBORRA.CommandType = CommandType.Text
        SQLBORRA.CommandText = "DELETE FROM CONTACTOCLIENTE WHERE CLIENTE ='" + CLACLIENTE(CBCLIENTE.SelectedIndex) + "'"
        SQLBORRA.ExecuteNonQuery()



        Dim SQLGUARDAR As New SqlClient.SqlCommand("SPCONTACTOCLIENTE", frmPrincipal.CONX)
        SQLGUARDAR.CommandType = CommandType.StoredProcedure
        SQLGUARDAR.Parameters.Add("@CLIENTE", SqlDbType.Int).Value = CLACLIENTE(CBCLIENTE.SelectedIndex)
        SQLGUARDAR.Parameters.Add("@NOMBRE", SqlDbType.VarChar)
        SQLGUARDAR.Parameters.Add("@PUESTO", SqlDbType.VarChar)
        SQLGUARDAR.Parameters.Add("@OBSERVACION", SqlDbType.VarChar)

        Dim X As Integer

        For X = 0 To DGV.Rows.Count - 1
            SQLGUARDAR.Parameters("@NOMBRE").Value = DGV.Item(0, X).Value.ToString
            SQLGUARDAR.Parameters("@PUESTO").Value = DGV.Item(1, X).Value.ToString
            SQLGUARDAR.Parameters("@OBSERVACION").Value = DGV.Item(2, X).Value.ToString
            Try
                SQLGUARDAR.ExecuteNonQuery()
            Catch ex As Exception
                OPMsgError("Error al intentar guardar los datos, se perdió la información, vuelva a intentarlo")
            End Try
        Next
    End Sub
End Class