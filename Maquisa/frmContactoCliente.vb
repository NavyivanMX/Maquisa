Public Class frmContactoCliente
    Dim CLACLIENTE As New List(Of String)

    Private Sub frmContactoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PonerImagenesBotones(Me)
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        ACTIVAR(True)

        OPLlenaComboBox(CBCLIENTE, CLACLIENTE, "SELECT CLAVE,NOMBRE FROM CLIENTES WHERE ACTIVO = 1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion)
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
            DgvAjusteEncabezado(DGV, 1)
            DGV.Refresh()
            CHECATABLA()
        End If
    End Sub

    Private Sub BTNQUITAR_Click(sender As Object, e As EventArgs) Handles BTNQUITAR.Click
        DGV.Rows.RemoveAt(DGV.CurrentRow.Index)
        CHECATABLA()
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

        TXTNOM.Text = ""
        TXTPUESTO.Text = ""
        TXTOBSERVACION.Text = ""
    End Sub

    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click

        LIMPIAR()
        DGV.Rows.Clear()
    End Sub


    Private Sub LIMPIAR()
        DGV.Rows.Clear()
        TXTNOM.Text = ""
        TXTPUESTO.Text = ""
        TXTOBSERVACION.Text = ""
        CBCLIENTE.SelectedIndex = 0
        ACTIVAR(True)
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If Not DGV.Rows.Count > 0 Then
            MessageBox.Show("Debe de agregar por lo menos un subconcepto")
            Exit Sub
        End If

        GUARDAR()

        LIMPIAR()
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