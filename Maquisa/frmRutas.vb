Public Class frmRutas
    Dim POSICIONAPOSTROFE As Integer
    Dim CLACOB As New List(Of String)
    Dim CLAVEN As New List(Of String)
    Dim QUERY As String

    Private Sub frmRutas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        ACTIVAR(True)
        LIMPIAR()
        CARGASIGRUTA()
        'If Not OPLlenaCombobox(CBCOB, CLACOB, "SELECT SUCURSAL,USUARIO FROM USUARIOS WHERE ACTIVO=1 AND NIVEL=11 ORDER BY USUARIO", frmPrincipal.CadenaConexion) Then
        '    MessageBox.Show("No hay dado de alta ningun empleado / usuario con nivel de cobrador de ruta", "Aviso", MessageBoxButtons.OK)
        '    Me.Close()
        'End If
        If Not OPLlenaComboBox(CBVEN, CLAVEN, "SELECT CLAVE,NOMBRE FROM VENDEDORES WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion) Then
            MessageBox.Show("No hay dado de alta ningun vendedor de ruta", "Aviso", MessageBoxButtons.OK)
            Me.Close()
        End If
    End Sub
    Private Sub CARGASIGRUTA()
        ' Try
        If Not frmPrincipal.CHECACONX() Then
            Exit Sub
        End If
        Dim NUM As Integer
        NUM = 1
        Dim SQLMOV As New SqlClient.SqlCommand("SELECT DBO.SIGRUTA('" + frmPrincipal.SucursalBase + "')", frmPrincipal.CONX)
        Dim LECTOR As SqlClient.SqlDataReader
        LECTOR = SQLMOV.ExecuteReader
        If LECTOR.Read Then
            NUM = LECTOR(0)
            LECTOR.Close()
            TXTCLA.Text = NUM
        Else
            LECTOR.Close()
        End If
        'Catch ex As Exception
        '    Me.Close()
        'End Try
    End Sub

    Private Sub ACTIVAR(ByVal V As Boolean)
        TXTCLA.Enabled = V
        TXTNOM.Enabled = Not V
        CBACT.Enabled = Not V
        BTNGUARDAR.Enabled = Not V
        CBCOB.Enabled = Not V
        CBVEN.Enabled = Not V

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
        CBACT.SelectedIndex = 0
    End Sub
    Private Sub CARGADATOS()
        If Not frmPrincipal.CHECACONX() Then
            Exit Sub
        End If
        'Dim V, C As String
        ACTIVAR(False)
        ' Dim SQLSELECT As New SqlClient.SqlCommand("SELECT R.NOMBRE,R.ACTIVO,E.CLAVE FROM RUTAS R WHERE CLAVE=" + TXTCLA.Text + " AND EMPRESA='" + frmPrincipal.ClaveEmpresa + "' AND SUCURSAL='" + frmPrincipal.ClaveSucursal + "' ", frmPrincipal.CONX)
        QUERY = "SELECT NOMBRE,ACTIVO, VENDEDOR FROM RUTAS  WHERE CLAVE=" + TXTCLA.Text + " AND SUCURSAL='" + frmPrincipal.SucursalBase + "' "
        Dim SQLSELECT As New SqlClient.SqlCommand(QUERY, frmPrincipal.CONX)
        Dim LECTOR As SqlClient.SqlDataReader
        LECTOR = SQLSELECT.ExecuteReader
        If LECTOR.Read Then
            TXTNOM.Text = LECTOR(0).ToString
            If LECTOR(1) = 1 Then
                CBACT.SelectedIndex = 1
            Else
                CBACT.SelectedIndex = 0
            End If
            'V = LECTOR(2)
            'C = LECTOR(3)
            OPCargaX(CLAVEN, CBVEN, LECTOR(2))

        End If
        LECTOR.Close()
        SQLSELECT.Dispose()
    End Sub
    Private Sub GUARDAR()
        If Not frmPrincipal.CHECACONX() Then
            Exit Sub
        End If
        POSICIONAPOSTROFE = 0
        POSICIONAPOSTROFE = TXTNOM.Text.LastIndexOfAny("'")
        If POSICIONAPOSTROFE >= 0 Then
            MessageBox.Show("En registro de NOMBRE hay una apostrofe, favor de quitar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If


        Dim SQLGUARDAR As New SqlClient.SqlCommand
        SQLGUARDAR.Connection = frmPrincipal.CONX
        SQLGUARDAR.CommandType = CommandType.StoredProcedure
        '  SQLGUARDAR.Parameters.Add("@EMP", SqlDbType.VarChar).Value = frmPrincipal.Empresa
        SQLGUARDAR.Parameters.Add("@SUC", SqlDbType.VarChar).Value = frmPrincipal.SucursalBase
        SQLGUARDAR.Parameters.Add("@CLA", SqlDbType.Int).Value = TXTCLA.Text
        SQLGUARDAR.Parameters.Add("@NOM", SqlDbType.VarChar).Value = TXTNOM.Text
        SQLGUARDAR.Parameters.Add("@ACT", SqlDbType.Bit)
        ' SQLGUARDAR.Parameters.Add("@COB", SqlDbType.VarChar).Value = 1
        SQLGUARDAR.Parameters.Add("@VEN", SqlDbType.VarChar).Value = CLAVEN(CBVEN.SelectedIndex)
        If CBACT.SelectedIndex = 0 Then
            SQLGUARDAR.Parameters("@ACT").Value = 1
        Else
            SQLGUARDAR.Parameters("@ACT").Value = 0
        End If

        SQLGUARDAR.CommandText = "SPRUTAS"
        SQLGUARDAR.ExecuteNonQuery()
        MessageBox.Show("La información ha sido guardada correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ACTIVAR(True)
        LIMPIAR()
        CARGASIGRUTA()
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
    End Sub

    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBUSCAR.Click
        frmClsBusqueda.BUSCAR("SELECT CLAVE,NOMBRE,ACTIVO FROM RUTAS WHERE  SUCURSAL='" + frmPrincipal.SucursalBase + "'  ", " AND NOMBRE", " ORDER BY NOMBRE", "Búsqueda de rutas", "Nombre de la ruta", "Ruta(s)", 1, frmPrincipal.CadenaConexion, True)
        If frmClsBusqueda.DialogResult = Windows.Forms.DialogResult.Yes Then
            TXTCLA.Text = frmClsBusqueda.TREG.Rows(0).Item(0).ToString
            CARGADATOS()
        End If
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If TXTNOM.Text = "" Then
            MessageBox.Show("Debe ingresar un nombre de ruta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim xyz As Short
        xyz = MessageBox.Show("¿Desea guardar la información?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If xyz = 6 Then
            GUARDAR()
        End If
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        ACTIVAR(True)
        LIMPIAR()
        CARGASIGRUTA()
    End Sub

    Private Sub TXTNOM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTNOM.KeyPress, CBACT.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub



End Class