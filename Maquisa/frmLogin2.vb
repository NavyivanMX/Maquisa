Public Class frmLogin2
    Dim TOCADO2 As Boolean
    Private Sub frmLogin2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        OPVisualizacionForm(Me)
        PonerImagenesBotones(Me)
        If Not frmPrincipal.CHECACONX Then
            frmPrincipal.CONX.Open()
        End If

    End Sub
    Private Sub VALIDAR()
        Dim SQLUSER As New SqlClient.SqlCommand("SELECT U.EMPRESA, S.CLAVE SUCURSAL,U.NIVEL, E.NOMBRECOMERCIAL,E.CIUDAD,U.USUARIO FROM USUARIOS U  INNER JOIN EMPRESA E ON U.EMPRESA=E.CLAVE  INNER JOIN SUCURSALES S ON E.CLAVE=S.EMPRESA WHERE U.PASSWORD='" + TXTPWD.Text + "'", frmPrincipal.CONX)
        Dim LECUSER As SqlClient.SqlDataReader





        LECUSER = SQLUSER.ExecuteReader
        If frmPrincipal.CONX.State = ConnectionState.Closed Or frmPrincipal.CONX.State = ConnectionState.Broken Then
            Try
                frmPrincipal.CONX.Open()
            Catch ex As Exception
                MessageBox.Show("La Conexión NO esta realizada, La Informacion No se ha Guardado, Intente en un momento por Favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        End If
        If LECUSER.Read() Then
            frmPrincipal.SucursalBase = LECUSER(1)
            frmPrincipal.NivelBase = LECUSER(2)
            frmPrincipal.NombreSucursal = LECUSER(3)
            frmPrincipal.Empresa = LECUSER(0)
            frmPrincipal.Ciudad = LECUSER(4)
            frmPrincipal.Usuario = LECUSER(5)
            'test de cambios
            LECUSER.Close()
            Dim myProcesses() As Process
            Dim myProcess As Process
            ' Returns array containing all instances of "Notepad".
            myProcesses = Process.GetProcessesByName("OSK")
            For Each myProcess In myProcesses
                myProcess.CloseMainWindow()
            Next
            'System.Diagnostics.Process.("osk")
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        Else
            MessageBox.Show("Nombre de Usuario y Contraseña NO encontrados favor de Verificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            LECUSER.Close()
        End If
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACEPTAR.Click
        VALIDAR()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim xyz As Short
        xyz = MessageBox.Show("¿Deseas realmente Salir del Sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If xyz <> 6 Then
            Exit Sub
        Else
            Me.DialogResult = Windows.Forms.DialogResult.No
        End If
    End Sub

    Private Sub TXTPWD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTPWD.KeyPress
        If e.KeyChar = Chr(13) Then
            ' If TXTUSER.Text = "" Or TXTPWD.Text = "" Then
            If TXTPWD.Text = "" Then
            Else
                VALIDAR()
            End If
        End If
    End Sub

    Private Sub BTNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTECLADO.Click
        System.Diagnostics.Process.Start("osk")
    End Sub
    Private Sub MODIFICAPWD(ByVal NUM As String)
        'If LBLCANT.Text.Length >= 3 Then
        '    Exit Sub
        'End If
        If TOCADO2 Then
            TXTPWD.Text = TXTPWD.Text + NUM
        Else
            TXTPWD.Text = NUM
        End If
    End Sub

    Private Sub BTN1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN1.Click, BTN0.Click, BTN2.Click, BTN3.Click, BTN4.Click, BTN5.Click, BTN6.Click, BTN7.Click, BTN8.Click, BTN9.Click
        MODIFICAPWD(CType(sender.TAG, String))
        TOCADO2 = True
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        TXTPWD.Text = ""
        TOCADO2 = False
        TXTPWD.Focus()
    End Sub
End Class