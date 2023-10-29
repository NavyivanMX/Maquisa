Imports System.Text.RegularExpressions
Public Class frmEmpresa
    Public CLAVE As String
     
    Private Sub frmEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        PonerImagenesBotones(Me)
        Me.CLAVE = frmPrincipal.Empresa
        CARGARDATOS()
    End Sub
    Private Sub CARGARDATOS()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If

        Dim SQLSELECT As New SqlClient.SqlCommand("SELECT NOMBRECOMERCIAL,NOMBREFISCAL,RFC,CALLE,NOEXT,NOINT,CP,CIUDAD,ESTADO,TELEFONO,COLONIA,PAIS,ACTIVO FROM EMPRESA WHERE CLAVE = '" + frmPrincipal.Empresa + "'", frmPrincipal.CONX)
        Dim LECTOR As SqlClient.SqlDataReader
        LECTOR = SQLSELECT.ExecuteReader

        If LECTOR.Read() Then
            TXTNOMBRECOMERCIAL.Text = LECTOR(0)
            TXTNOMBREFISCAL.Text = LECTOR(1)
            TXTRFC.Text = LECTOR(2)
            TXTCALLE.Text = LECTOR(3)
            TXTNUMEROEXT.Text = LECTOR(4)
            TXTNUMEROINT.Text = LECTOR(5)
            TXTCP.Text = LECTOR(6)
            TXTCIUDAD.Text = LECTOR(7)
            TXTESTADO.Text = LECTOR(8)
            TXTTELEFONO.Text = LECTOR(9)
            TXTCOLONIA.Text = LECTOR(10)
            TXTPAIS.Text = LECTOR(11)

            If LECTOR(12) = 0 Then
                CBACTIVO.SelectedIndex = 1
            Else
                CBACTIVO.SelectedIndex = 0
            End If

            LECTOR.Close()
        Else
            LECTOR.Close()
            Me.Close()
        End If

    End Sub
    Private Function GUARDARDATOS() As Boolean
        If Not frmPrincipal.CHECACONX Then
            Exit Function
        End If


        'DE LO CONTRARIO HAY QUE GUARDAR LOS DATOS
        Dim SQLUPDATE As New SqlClient.SqlCommand("UPDATE EMPRESA SET NOMBRECOMERCIAL = @NOMBRECOMERCIAL,NOMBREFISCAL=@NOMBREFISCAL,RFC=@RFC,CALLE=@CALLE,NOEXT=@NUMEROEXT,NOINT=@NUMEROINT,CP=@CP,CIUDAD=@CIUDAD,ESTADO=@ESTADO,TELEFONO=@TELEFONO,COLONIA=@COLONIA,PAIS=@PAIS,ACTIVO=@ACTIVO FROM EMPRESA WHERE CLAVE = '" + Me.CLAVE + "'", frmPrincipal.CONX)

        SQLUPDATE.Parameters.Add("@NOMBRECOMERCIAL", SqlDbType.VarChar).Value = TXTNOMBRECOMERCIAL.Text
        SQLUPDATE.Parameters.Add("@NOMBREFISCAL", SqlDbType.VarChar).Value = TXTNOMBREFISCAL.Text
        SQLUPDATE.Parameters.Add("@RFC", SqlDbType.VarChar).Value = TXTRFC.Text
        SQLUPDATE.Parameters.Add("@CALLE", SqlDbType.VarChar).Value = TXTCALLE.Text
        SQLUPDATE.Parameters.Add("@NUMEROEXT", SqlDbType.VarChar).Value = TXTNUMEROEXT.Text
        SQLUPDATE.Parameters.Add("@NUMEROINT", SqlDbType.VarChar).Value = TXTNUMEROINT.Text
        SQLUPDATE.Parameters.Add("@CP", SqlDbType.VarChar).Value = TXTCP.Text
        SQLUPDATE.Parameters.Add("@CIUDAD", SqlDbType.VarChar).Value = TXTCIUDAD.Text
        SQLUPDATE.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = TXTESTADO.Text
        SQLUPDATE.Parameters.Add("@TELEFONO", SqlDbType.VarChar).Value = TXTTELEFONO.Text
        SQLUPDATE.Parameters.Add("@COLONIA", SqlDbType.VarChar).Value = TXTCOLONIA.Text
        SQLUPDATE.Parameters.Add("@PAIS", SqlDbType.VarChar).Value = TXTPAIS.Text
        SQLUPDATE.Parameters.Add("@ACTIVO", SqlDbType.Bit)
        If CBACTIVO.SelectedIndex = 0 Then
            SQLUPDATE.Parameters("@ACTIVO").Value = 1
        Else
            SQLUPDATE.Parameters("@ACTIVO").Value = 0
        End If

        Try
            SQLUPDATE.ExecuteNonQuery()
        Catch ex As Exception
            mensaje_error(ex.ToString)
            Exit Function
        End Try
        mensaje_informacion("Los datos han sido guardados Exitosamente")
        'vs
        OPMsgGuardadoOK()

        Return False
    End Function
    Private Sub TXTRFC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTRFC.KeyPress
        If e.KeyChar = Chr(13) Then
            If String.IsNullOrEmpty(TXTRFC.Text) Then
            Else
                If Regex.IsMatch(Me.TXTRFC.Text, "^([A-Z\s]{4})\d{6}([A-Z\w]{3})$") Then
                    e.Handled = True
                    SendKeys.Send("{TAB}")
                Else
                    MessageBox.Show("Teclee un RFC valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub BTNGUARDAR_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BTNGUARDAR.BackColor = System.Drawing.Color.Transparent
        BTNGUARDAR.Text = ""
        BTNGUARDAR.ForeColor = System.Drawing.Color.White
    End Sub
    Private Function VALIDARRFC() As Boolean
        'If String.IsNullOrEmpty(TXTRFC.Text) Then
        'Else
        '    If Regex.IsMatch(Me.TXTRFC.Text, "^([A-Z\s]{4})\d{6}([A-Z\w]{3})$") Then
        '        Return True
        '        Exit Function
        '    Else
        '        MENSAJE.mensaje_error("Introduzca un RFC valido!!!")
        '        Return False
        '        Exit Function
        '    End If
        'End If

        'Return True
    End Function
    Private Function VALIDARTELEFONO() As Boolean
        'If String.IsNullOrEmpty(TXTRFC.Text) Then
        'Else
        '    If Regex.IsMatch(Me.TXTTELEFONO.Text, "^([0-9]{1,})") Then
        '        Return True
        '        Exit Function
        '    Else
        '        MENSAJE.mensaje_error("Introduzca un telefono valido!!!")
        '        Return False
        '        Exit Function
        '    End If
        'End If
    End Function
    Private Function VALIDARNOMBRE() As Boolean

        If TXTNOMBRECOMERCIAL.Text = "" Or TXTNOMBREFISCAL.Text = "" Then
            OPMsgError("Evite dejar campos en blanco")
            Return False
            Exit Function
        End If


        Return True
    End Function
    Private Sub TXTTELEFONO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTTELEFONO.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TXTNOMBRECOMERCIAL_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTNOMBRECOMERCIAL.KeyPress, TXTNOMBREFISCAL.KeyPress, TXTCALLE.KeyPress, TXTCOLONIA.KeyPress, TXTESTADO.KeyPress, TXTPAIS.KeyPress, TXTTELEFONO.KeyPress, TXTCIUDAD.KeyPress, CBACTIVO.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub TXTNUMEROINT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTNUMEROINT.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TXTNUMEROEXT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTNUMEROEXT.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TXTCP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCP.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub BTNGUARDAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        GUARDARDATOS()

    End Sub


End Class