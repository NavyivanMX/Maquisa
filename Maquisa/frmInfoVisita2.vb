﻿Public Class frmInfoVisita2
    Public VISITA As Integer
    Dim CLAVECLIENTE As Integer
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
        QUERY = QUERY + "[RESULTADOAGENDAR],[FECHA AGENDAR],[HORA  AGENDAR] ,[OBSERVACION], CVECLI FROM VINFOVISITA "
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
            CLAVECLIENTE = LECTOR(11)

        End If
        LECTOR.Close()

        Dim QUERY2 As String
        QUERY2 = "SELECT REGISTRO,ATENDIO CONTACTO ,PUESTO,OBSERVACION FROM [dbo].[DETALLEVISITAS] WHERE CLAVE='" + VISITA.ToString + "'   "
        DGV.DataSource = BDLlenaTabla(QUERY2, frmPrincipal.CadenaConexion)
        DgvAjusteEncabezado(DGV, 3)

    End Sub

    Private Sub BTNIMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        Dim SQLGUARDACOMENTARIO As New SqlClient.SqlCommand("UPDATE AGENDAVISITARUTA SET OBSERVACION=@COM WHERE VISITA=@VIS ", frmPrincipal.CONX)
        SQLGUARDACOMENTARIO.Parameters.Add("@COM", SqlDbType.VarChar).Value = TXTCOMENTARIO.Text
        SQLGUARDACOMENTARIO.Parameters.Add("@VIS", SqlDbType.Int).Value = LBLVISITA.Text
        SQLGUARDACOMENTARIO.ExecuteNonQuery()
        MessageBox.Show("La información ha sido guardada correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    Private Sub BTNIZQUIERDA_Click(sender As Object, e As EventArgs) Handles BTNIZQUIERDA.Click
        Me.Close()
    End Sub

    Private Sub BTNIZQUIERDA_Click_1(sender As Object, e As EventArgs) Handles BTNIZQUIERDA.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim VCONTCLI As New frmContactoCliente
        'frmContactoCliente.MOSTRAR(DGV.Item(11, DGV.CurrentRow.Index).Value)
        VCONTCLI.MOSTRAR(CLAVECLIENTE, DGV.Item(1, DGV.CurrentRow.Index).Value, DGV.Item(2, DGV.CurrentRow.Index).Value, DGV.Item(3, DGV.CurrentRow.Index).Value)

    End Sub
End Class