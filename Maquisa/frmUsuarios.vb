Public Class frmUsuarios
    Dim PWD As String
    Dim NIV As Integer
    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        NUEVO(True)
        ACTIVAR(True)
    End Sub
    Private Sub NUEVO(ByVal V As Boolean)
        TXTANT.Text = ""
        TXTNVA.Text = ""
        TXTPWD.Text = ""
        LBLANT.Visible = Not V
        TXTANT.Visible = Not V
        LBLNVA.Visible = Not V
        TXTNVA.Visible = Not V
        BTNELIMINAR.Enabled = Not V
        If V Then
            LBLPWD.Text = "Contraseña"
            TXTPWD.Focus()
        Else
            LBLPWD.Text = "Repetir Contraseña"
            TXTANT.Focus()
        End If
    End Sub
    Private Sub ACTIVAR(ByVal V As Boolean)
        TXTEMP.Enabled = V
        TXTNVA.Enabled = Not V
        TXTANT.Enabled = Not V
        BTNGUARDAR.Enabled = Not V
        TXTPWD.Enabled = Not V
        CBNIV.Enabled = Not V
        If V Then
            TXTANT.Focus()
            TXTANT.SelectAll()
        End If
    End Sub
    Private Sub CARGAR()
        If Not frmPrincipal.CHECACONX() Then
            Exit Sub
        End If
        Dim SQL As New SqlClient.SqlCommand("SELECT PASSWORD,NIVEL FROM USUARIOS WHERE SUCURSAL='" + frmPrincipal.SucursalBase + "'AND USUARIO='" + TXTEMP.Text + "'", frmPrincipal.CONX)
        Dim LECTOR As SqlClient.SqlDataReader
        LECTOR = SQL.ExecuteReader
        PWD = ""
        If LECTOR.Read Then
            PWD = LECTOR(0)
            If LECTOR(1) = 1 Then
                CBNIV.SelectedIndex = 0
            Else
                CBNIV.SelectedIndex = 1
            End If
            LECTOR.Close()
            ACTIVAR(False)
            NUEVO(False)
            'CBNIV.Enabled = False
            Exit Sub
        End If
        LECTOR.Close()
        CBNIV.SelectedIndex = 0
        ACTIVAR(False)
        NUEVO(True)
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        ACTIVAR(True)
        NUEVO(True)
        LIMPIAR()
    End Sub
    Private Function VALIDAR() As Boolean
        If TXTANT.Visible = False Then
            If TXTPWD.Text = "" Then
                MessageBox.Show("Introduzca una contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Return False
            Else
                Return True
            End If
        Else
            If TXTANT.Text = PWD Then
                If TXTNVA.Text = TXTPWD.Text Then
                    Return True
                Else
                    MessageBox.Show("Las contraseñas escritas NO coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Return False
                End If
            Else
                MessageBox.Show("La contraseña anterior NO coincide", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Return False
            End If
        End If
    End Function

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If Not frmPrincipal.CHECACONX() Then
            Exit Sub
        End If
        Dim NIVEL As String
        If Not VALIDACONTRASEÑA(TXTPWD.Text) Then
            MessageBox.Show("La contraseña ya esta siendo usada por otro usuario, favor de ingresar una contraseña diferente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        If VALIDAR() Then
        Else
            Exit Sub
        End If
        If TXTANT.Visible Then
            Dim SQL As New SqlClient.SqlCommand("UPDATE USUARIOS SET PASSWORD='" + TXTPWD.Text + "' WHERE SUCURSAL='" + frmPrincipal.SucursalBase + "' AND USUARIO='" + TXTEMP.Text + "'", frmPrincipal.CONX)
            SQL.ExecuteNonQuery()
        Else
            If CBNIV.SelectedIndex = 0 Then
                NIVEL = "1"
                'ElseIf CBNIV.SelectedIndex = 1 Then
                '    NIVEL = "5"
                'ElseIf CBNIV.SelectedIndex = 2 Then
                '    NIVEL = "10"
            ElseIf CBNIV.SelectedIndex = 1 Then
                NIVEL = "25"
            End If
            Dim SQL As New SqlClient.SqlCommand("INSERT INTO USUARIOS (USUARIO,PASSWORD,EMPRESA,SUCURSAL,NIVEL) VALUES ('" + TXTEMP.Text + "','" + TXTPWD.Text + "',1,'" + frmPrincipal.SucursalBase + "'," + NIVEL.ToString + ")", frmPrincipal.CONX)
            SQL.ExecuteNonQuery()
        End If
        MessageBox.Show("La información del usuario ha sido guardada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ACTIVAR(True)
        NUEVO(True)
    End Sub
    Private Sub TXTEMP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTEMP.KeyPress
        If e.KeyChar = Chr(13) Then
            If TXTEMP.Text = "" Then
            Else
                CARGAR()
            End If
        End If
    End Sub
    Private Sub LIMPIAR()
        TXTEMP.Clear()
        TXTANT.Clear()
        TXTNVA.Clear()
        TXTPWD.Clear()
        CBNIV.SelectedIndex = 0
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        Dim mens As Short
        mens = MessageBox.Show("¿Esta seguro que desea eliminar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If mens = 6 Then
            If Not frmPrincipal.CHECACONX() Then
                Exit Sub
            End If
            Dim sql As New SqlClient.SqlCommand("delete from USUARIOS where USUARIO = @USU AND SUCURSAL='" + frmPrincipal.SucursalBase + "'", frmPrincipal.CONX)
            sql.Parameters.Add("@usu", SqlDbType.VarChar)

            sql.Parameters("@usu").Value = TXTEMP.Text
            sql.ExecuteNonQuery()

            MessageBox.Show("La información ha sido eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            LIMPIAR()
            ACTIVAR(True)
            NUEVO(True)
        End If
    End Sub

    Private Sub frmUsuarios_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Alt + Keys.G Then
            If Not frmPrincipal.CHECACONX() Then
                Exit Sub
            End If
            If BTNGUARDAR.Enabled = False Then
                Exit Sub
            End If
            Dim NIVEL As String
            If VALIDAR() Then
            Else
                Exit Sub
            End If
            If TXTANT.Visible Then
                Dim SQL As New SqlClient.SqlCommand("UPDATE USUARIOS SET PASSWORD='" + TXTPWD.Text + "' WHERE SUCURSAL='" + frmPrincipal.SucursalBase + "' AND USUARIO='" + TXTEMP.Text + "'", frmPrincipal.CONX)
                SQL.ExecuteNonQuery()
            Else
                If CBNIV.SelectedIndex = 0 Then
                    NIVEL = "1"
                Else
                    NIVEL = "25"
                End If
                Dim SQL As New SqlClient.SqlCommand("INSERT INTO USUARIOS (USUARIO,PASSWORD,EMPRESA,SUCURSAL,NIVEL) VALUES ('" + TXTEMP.Text + "','" + TXTPWD.Text + "',1,'" + frmPrincipal.SucursalBase + "'," + NIVEL.ToString + ")", frmPrincipal.CONX)
                SQL.ExecuteNonQuery()
            End If
            MessageBox.Show("La informacion del usuario ha sido guardada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ACTIVAR(True)
            NUEVO(True)
        End If


        If e.KeyCode = Keys.Alt + Keys.E Then
            If Not frmPrincipal.CHECACONX() Then
                Exit Sub
            End If
            If BTNELIMINAR.Enabled = False Then
                Exit Sub
            End If
            Dim mens As Short
            mens = MessageBox.Show("¿Esta seguro que desea eliminar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If mens = 6 Then
                Dim sql As New SqlClient.SqlCommand("delete from USUARIOS where USUARIO = @USU AND SUCURSAK='" + frmPrincipal.SucursalBase + "'", frmPrincipal.CONX)
                sql.Parameters.Add("@usu", SqlDbType.VarChar)

                sql.Parameters("@usu").Value = TXTEMP.Text
                sql.ExecuteNonQuery()

                MessageBox.Show("La información ha sido eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                LIMPIAR()
                ACTIVAR(True)
                NUEVO(True)
            End If
        End If

        If e.KeyCode = Keys.Alt + Keys.C Then
            ACTIVAR(True)
            NUEVO(True)
            LIMPIAR()
        End If

    End Sub

    Private Sub TXTANT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Function VALIDACONTRASEÑA(ByVal CONTRA As String) As Boolean
        Dim pass As String
        frmPrincipal.CHECACONX()
        Dim SQL As New SqlClient.SqlCommand("SELECT PASSWORD FROM USUARIOS WHERE SUCURSAL='" + frmPrincipal.SucursalBase + "'AND PASSWORD='" + CONTRA + "'AND USUARIO<>'" + TXTEMP.Text + "'", frmPrincipal.CONX)
        Dim LECTOR As SqlClient.SqlDataReader
        LECTOR = SQL.ExecuteReader
        pass = ""
        If LECTOR.Read Then
            pass = LECTOR(0)
        End If
        LECTOR.Close()
        If pass <> "" Then
            Return False
        Else
            Return True
        End If

    End Function
End Class