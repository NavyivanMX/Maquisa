Public Class frmInfoVisita2
    Public VISITA As Integer
    Private Sub frmInfoVisita2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me)
        Me.Icon = frmPrincipal.Icon
        CARGADATOS()
        GB1.Visible = False
    End Sub
    Private Sub CARGADATOS()
        If Not frmPrincipal.CHECACONX() Then
            Exit Sub
        End If
        'ACTIVAR(False)
        Dim QUERY As String
        QUERY = "SELECT [VISITA],[CLIENTE],[VENDEDOR],[INI VISITA],[FIN VISITA] ,[FECHA] ,[RESULTADO VISITA], "
        QUERY = QUERY + "[RESULTADOAGENDAR],[FECHA AGENDAR],[HORA  AGENDAR] ,[OBSERVACION] FROM VINFOVISITA "
        QUERY = QUERY + " WHERE VISITA ='" + VISITA.ToString + "' "
        Dim SQLSELECT As New SqlClient.SqlCommand(QUERY, frmPrincipal.CONX)
        Dim LECTOR As SqlClient.SqlDataReader
        LECTOR = SQLSELECT.ExecuteReader
        If LECTOR.Read Then
            LBLVISITA.Text = LECTOR(0)
            LBLCLIENTE.Text = LECTOR(1)
            LBLVENDEDOR.Text = LECTOR(2)

            If LECTOR(3).ToString <> "01 Ene 2023 00:00:00:000" Then
                LBLFECHAINI.Text = LECTOR(3)
            End If

            If LECTOR(4).ToString <> "01 Ene 2023 00:00:00:000" Then
                LBLFECHAFIN.Text = LECTOR(4)
            End If

            LBLFECHA.Text = LECTOR(5)
            LBLRESVISITA.Text = LECTOR(6)
            If LECTOR(7) = 1 Then
                GB1.Visible = True
                LBLFECHAREAGENDADO.Text = LECTOR(8)
                LBLHORAREAGENDADO.Text = LECTOR(9)
            End If
            TXTCOMENTARIO.Text = LECTOR(10)
            'If CType(LECTOR(4), Boolean) Then
            '        LBLFOL.Text = "SI"
            '        LBLDE.Visible = True
            '        LBLX1.Visible = True
            '        LBLA.Visible = True
            '        LBLX2.Visible = True
            '        LBLDE.Text = LECTOR(5)
            '        LBLA.Text = LECTOR(6)
            '    Else
            '        LBLFOL.Text = "NO"
            '        LBLDE.Visible = False
            '        LBLX1.Visible = False
            '        LBLA.Visible = False
            '        LBLX2.Visible = False
            '    End If
            '    If CType(LECTOR(7), Boolean) Then
            '        LBLR.Text = "SI"
            '        LBLX.Visible = False
            '        LBLAR.Visible = False
            '    Else
            '        LBLX.Visible = True
            '        LBLAR.Visible = True
            '        LBLAR.Text = LECTOR(8)
            '        LBLR.Text = "NO"

            '    End If
            '    LBLCOM.Text = LECTOR(9)
            '    If LECTOR(10) = "1" Then
            '        LBLREV.Text = "SI"
            '    ElseIf LECTOR(10) = "0" Then
            '        LBLREV.Text = "NO"
            '    End If
        End If
        LECTOR.Close()

        Dim QUERY2 As String
        QUERY2 = "SELECT REGISTRO,ATENDIO CONTACTO ,PUESTO,OBSERVACION FROM [dbo].[DETALLEVISITAS] WHERE CLAVE='" + VISITA.ToString + "'   "
        DGV.DataSource = BDLlenaTabla(QUERY2, frmPrincipal.CadenaConexion)
        DgvAjusteEncabezado(DGV, 3)

    End Sub

    Private Sub BTNIMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        Dim SQLGUARDACOMENTARIO As New SqlClient.SqlCommand("UPDATE AGENDAVISITARUTA SET OBSERVACION=@COM ", frmPrincipal.CONX)
        SQLGUARDACOMENTARIO.Parameters.Add("@COM", SqlDbType.VarChar).Value = TXTCOMENTARIO.Text
        SQLGUARDACOMENTARIO.ExecuteNonQuery()
        MessageBox.Show("La información ha sido guardada correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    Private Sub BTNIZQUIERDA_Click(sender As Object, e As EventArgs) Handles BTNIZQUIERDA.Click
        Me.Close()
    End Sub

    Private Sub BTNIZQUIERDA_Click_1(sender As Object, e As EventArgs) Handles BTNIZQUIERDA.Click
        Me.Close()
    End Sub
End Class