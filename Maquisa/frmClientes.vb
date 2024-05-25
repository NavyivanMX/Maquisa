Public Class frmClientes
    Dim LTIPO As New List(Of String)
    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        CBACT.SelectedIndex = 0
        ACTIVAR(True)
        TXTCLA.Text = CARGACLI() ''ESTO SE DESACTIVO
        OPLlenaComboBox(CBTIPO, LTIPO, "SELECT CLAVE,NOMBRE FROM  TIPOCLIENTE WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        OPCargaX(LTIPO, CBTIPO, 1)
    End Sub
    Dim LATITUD, LONGITUD As Double
    Private Function CARGACLI() As Integer
        'Try
        '    frmPrincipal.CHECACONX()
        '    Dim NUM As Integer
        '    NUM = 1
        '    Dim SQLMOV As New SqlClient.SqlCommand("SELECT DBO.SIGCLIENTE()", frmPrincipal.CONX)
        '    Dim LECTOR As SqlClient.SqlDataReader
        '    LECTOR = SQLMOV.ExecuteReader
        '    If LECTOR.Read Then
        '        NUM = LECTOR(0)
        '        LECTOR.Close()
        '        Return NUM
        '    Else
        '        LECTOR.Close()
        '        Return NUM
        '    End If
        'Catch ex As Exception
        '    Exit Function
        'End Try
    End Function

    Public Sub MOSTRAR(ByVal CNOMBRE As String, ByVal CDIRECCION As String)
        TXTNOM.Text = CNOMBRE
        TXTDIR.Text = CDIRECCION
        CBACT.SelectedIndex = 0
        ACTIVAR(False)
        TXTCLA.Text = CARGACLI()
        OPLlenaComboBox(CBTIPO, LTIPO, "SELECT CLAVE,NOMBRE FROM  TIPOCLIENTE WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de Seleccionar", "")
        OPCargaX(LTIPO, CBTIPO, 1)
        Me.ShowDialog()
    End Sub

    Private Sub ACTIVAR(ByVal V As Boolean)
        TXTCLA.Enabled = V
        TXTNOM.Enabled = Not V
        TXTDIR.Enabled = Not V
        TXTTEL.Enabled = Not V
        TXTCEL.Enabled = Not V
        TXTMAIL.Enabled = Not V
        CBTIPO.Enabled = Not V
        CBACT.Enabled = Not V
        BTNGUARDAR.Enabled = Not V
        BTNELIMINAR.Enabled = False
        If V Then
            TXTCLA.SelectAll()
            TXTCLA.Focus()
        Else
            TXTNOM.SelectAll()
            TXTNOM.Focus()
        End If
    End Sub
    Private Sub LIMPIAR()
        TXTNOM.Text = ""
        TXTDIR.Text = ""
        TXTTEL.Text = ""
        TXTCEL.Text = ""
        TXTMAIL.Text = ""
        CBACT.Text = ""
        TXTCLA.Text = CARGACLI()
    End Sub
    Private Sub CARGADATOS()
        If Not frmPrincipal.CHECACONX() Then
            Exit Sub
        End If
        ACTIVAR(False)
        LATITUD = 0
        LONGITUD = 0
        Dim QUERY As String
        QUERY = "SELECT CLAVE,NOMBRE,DIRECCION,TELEFONO,CELULAR,MAIL,ACTIVO,LATITUD,LONGITUD,TIPO FROM CLIENTES WHERE CLAVE='" + TXTCLA.Text + "' "
        Dim SQLSELECT As New SqlClient.SqlCommand(QUERY, frmPrincipal.CONX)
        Dim LECTOR As SqlClient.SqlDataReader
        LECTOR = SQLSELECT.ExecuteReader
        If LECTOR.Read Then
            TXTNOM.Text = LECTOR(1).ToString
            TXTDIR.Text = LECTOR(2).ToString
            TXTTEL.Text = LECTOR(3).ToString
            TXTCEL.Text = LECTOR(4).ToString
            TXTMAIL.Text = LECTOR(5).ToString

            If CType(LECTOR(6), Boolean) = True Then
                CBACT.SelectedIndex = 0
            Else
                CBACT.SelectedIndex = 1
            End If
            LATITUD = LECTOR(7).ToString
            LONGITUD = LECTOR(8).ToString
            OPCargaX(LTIPO, CBTIPO, LECTOR(9).ToString)
            BTNELIMINAR.Enabled = True
        End If
        LECTOR.Close()
    End Sub

    Private Sub TXTNOM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTNOM.KeyPress, TXTDIR.KeyPress, TXTTEL.KeyPress, TXTCEL.KeyPress, TXTMAIL.KeyPress, CBACT.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub CANCELAR()
        LIMPIAR()
        ACTIVAR(True)
        TXTCLA.Text = CARGACLI()
    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        CANCELAR()
    End Sub

    Private Sub TXTCLA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCLA.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            CARGADATOS()
        End If
        TXTNOM.Focus()
    End Sub
    Private Sub GUARDAR()
        If TXTNOM.Text = "" Or TXTDIR.Text = "" Or TXTTEL.Text = "" Or TXTCEL.Text = "" Or TXTMAIL.Text = "" Then
            MessageBox.Show("Falta ingresar infomación importante del cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If CBTIPO.SelectedIndex = 0 Then
            OPMsgError("Favor de seleccionar tipo de cliente")
            Return
        End If
        Dim xyz As Short
        xyz = MessageBox.Show("¿Desea guardar la información?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If xyz <> 6 Then
            Exit Sub
        End If
        If Not frmPrincipal.CHECACONX() Then
            Exit Sub
        End If
        Dim SQLGUARDAR As New SqlClient.SqlCommand
        SQLGUARDAR.Connection = frmPrincipal.CONX
        SQLGUARDAR.CommandTimeout = 300
        SQLGUARDAR.CommandType = CommandType.StoredProcedure

        SQLGUARDAR.Parameters.Add("@CLA", SqlDbType.Int).Value = CType(TXTCLA.Text, Integer)
        SQLGUARDAR.Parameters.Add("@TIPO", SqlDbType.Int).Value = LTIPO(CBTIPO.SelectedIndex)
        SQLGUARDAR.Parameters.Add("@NOM", SqlDbType.VarChar, 100).Value = TXTNOM.Text
        SQLGUARDAR.Parameters.Add("@DIR", SqlDbType.VarChar, 200).Value = TXTDIR.Text
        SQLGUARDAR.Parameters.Add("@TEL", SqlDbType.VarChar, 200).Value = TXTTEL.Text
        SQLGUARDAR.Parameters.Add("@CEL", SqlDbType.VarChar, 200).Value = TXTCEL.Text
        SQLGUARDAR.Parameters.Add("@MAIL", SqlDbType.VarChar, 50).Value = TXTMAIL.Text

        SQLGUARDAR.Parameters.Add("@LAT", SqlDbType.Float).Value = LATITUD
        SQLGUARDAR.Parameters.Add("@LON", SqlDbType.Float).Value = LONGITUD

        SQLGUARDAR.Parameters.Add("@ACT", SqlDbType.Bit)


        If CBACT.SelectedIndex = 0 Then
            SQLGUARDAR.Parameters("@ACT").Value = 1
        Else
            SQLGUARDAR.Parameters("@ACT").Value = 0
        End If
        frmPrincipal.CHECACONX()
        SQLGUARDAR.CommandText = "SPCLIENTE"
        SQLGUARDAR.ExecuteNonQuery()
        SQLGUARDAR.Dispose()
        MessageBox.Show("La información ha sido guardada correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ACTIVAR(True)
        LIMPIAR()
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        GUARDAR()
    End Sub
    Private Sub ELIMINAR()
        Dim xyz As Short
        xyz = MessageBox.Show("¿Esta seguro que desea eliminar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If xyz = 6 Then
            Try
                If Not frmPrincipal.CHECACONX() Then
                    Exit Sub
                End If
                Dim SQLELIMINAR As New SqlClient.SqlCommand
                SQLELIMINAR.Connection = frmPrincipal.CONX
                SQLELIMINAR.CommandText = "DELETE FROM CLIENTES WHERE TIENDA='" + frmPrincipal.SucursalBase + "' AND CLAVE=" + TXTCLA.Text
                SQLELIMINAR.ExecuteNonQuery()
                MessageBox.Show("La información ha sido eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            LIMPIAR()
            ACTIVAR(True)
            TXTCLA.Text = CARGACLI()
        End If
    End Sub
    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        ELIMINAR()
    End Sub
    Private Sub BUSCAR()
        frmClsBusqueda.BUSCAR("SELECT CLAVE,NOMBRE,ACTIVO FROM CLIENTES", " WHERE NOMBRE", " ORDER BY NOMBRE", "Búsqueda de cientes ", "Nombre del cliente", "Cliente(s)", 1, frmPrincipal.CadenaConexion, True)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            TXTCLA.Text = frmClsBusqueda.TREG.Rows(0).Item(0).ToString
            CARGADATOS()
        End If
    End Sub
    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
        BUSCAR()
    End Sub

    Private Sub VERMAP_Click(sender As Object, e As EventArgs) Handles VERMAP.Click
        Dim VDCLI As New frmUbicacionMapa
        VDCLI.Mostrar(TXTNOM.Text, TXTDIR.Text, LATITUD, LONGITUD)
        If VDCLI.DialogResult = DialogResult.Yes Then
            LATITUD = VDCLI.Latitud
            LONGITUD = VDCLI.Longitud
        End If
    End Sub

    Private Sub BTNITINERARIO_Click(sender As Object, e As EventArgs) Handles BTNITINERARIO.Click
        Dim VITINERARIO As New frmItinerarioRuta
        VITINERARIO.MOSTRAR(TXTCLA.Text)
    End Sub

    Private Sub BTNCONTACTOS_Click(sender As Object, e As EventArgs) Handles BTNCONTACTOS.Click
        Dim vCONTACTOS As New frmContactoCliente
        vCONTACTOS.MOSTRAR(TXTCLA.Text, "", "", "")
    End Sub

    Private Sub frmClientes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Alt + Keys.G Then
            If TXTNOM.Enabled = False Then
                Exit Sub
            End If
            GUARDAR()
        End If

        If e.KeyCode = Keys.Alt + Keys.E Then
            If BTNELIMINAR.Enabled = False Then
                Exit Sub
            End If
            ELIMINAR()
        End If

        If e.KeyCode = Keys.Alt + Keys.C Then
            CANCELAR()
        End If

        If e.KeyCode = Keys.Alt + Keys.B Then
            BUSCAR()
        End If
    End Sub






End Class