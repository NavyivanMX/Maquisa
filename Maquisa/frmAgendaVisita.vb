﻿Public Class frmAgendaVisita

    Dim GBDIA(6) As GroupBox
    Dim LBLNOMVEND(6) As Label
    Dim LBLCTOT(6) As Label
    Dim LBLCVISITADO(6) As Label
    Dim LBLCVISITAR(6) As Label
    Dim LBLCNODISP(6) As Label
    Dim LBLPROSP(6) As Label
    Dim LBLFINRUTA(6) As Label
    Private Sub frmAgendaVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me)
        Me.Icon = frmPrincipal.Icon
        INICIALIZAR()
    End Sub
    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        CARGADATOS
    End Sub
    Private Sub INICIALIZAR()
        GBDIA(1) = GBDIA1
        GBDIA(2) = GBDIA2
        GBDIA(3) = GBDIA3
        GBDIA(4) = GBDIA4
        GBDIA(5) = GBDIA5
        GBDIA(6) = GBDIA6

        LBLNOMVEND(1) = LBLNOMVEND1
        LBLNOMVEND(2) = LBLNOMVEND2
        LBLNOMVEND(3) = LBLNOMVEND3
        LBLNOMVEND(4) = LBLNOMVEND4
        LBLNOMVEND(5) = LBLNOMVEND5
        LBLNOMVEND(6) = LBLNOMVEND6

        LBLCTOT(1) = LBLCTOT1
        LBLCTOT(2) = LBLCTOT2
        LBLCTOT(3) = LBLCTOT3
        LBLCTOT(4) = LBLCTOT4
        LBLCTOT(5) = LBLCTOT5
        LBLCTOT(6) = LBLCTOT6

        LBLCVISITADO(1) = LBLCVISITADO1
        LBLCVISITADO(2) = LBLCVISITADO2
        LBLCVISITADO(3) = LBLCVISITADO3
        LBLCVISITADO(4) = LBLCVISITADO4
        LBLCVISITADO(5) = LBLCVISITADO5
        LBLCVISITADO(6) = LBLCVISITADO6

        LBLCVISITAR(1) = LBLCVISITAR1
        LBLCVISITAR(2) = LBLCVISITAR2
        LBLCVISITAR(3) = LBLCVISITAR3
        LBLCVISITAR(4) = LBLCVISITAR4
        LBLCVISITAR(5) = LBLCVISITAR5
        LBLCVISITAR(6) = LBLCVISITAR6

        LBLCNODISP(1) = LBLCNODISP1
        LBLCNODISP(2) = LBLCNODISP2
        LBLCNODISP(3) = LBLCNODISP3
        LBLCNODISP(4) = LBLCNODISP4
        LBLCNODISP(5) = LBLCNODISP5
        LBLCNODISP(6) = LBLCNODISP6

        LBLPROSP(1) = LBLPROSP1
        LBLPROSP(2) = LBLPROSP2
        LBLPROSP(3) = LBLPROSP3
        LBLPROSP(4) = LBLPROSP4
        LBLPROSP(5) = LBLPROSP5
        LBLPROSP(6) = LBLPROSP6

        LBLFINRUTA(1) = LBLFINRUTA1
        LBLFINRUTA(2) = LBLFINRUTA2
        LBLFINRUTA(3) = LBLFINRUTA3
        LBLFINRUTA(4) = LBLFINRUTA4
        LBLFINRUTA(5) = LBLFINRUTA5
        LBLFINRUTA(6) = LBLFINRUTA6


    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GBDIA1.Enter

    End Sub


    Private Sub CARGADATOS()

        Dim DS As New DataSet
        DS = BDLlenaDataSet("EXEC SPAGENDASEMANAL '06/11/2023',3", frmPrincipal.CadenaConexion)
        For Each DT As DataTable In DS.Tables

        Next
    End Sub

    Private Sub Label75_Click(sender As Object, e As EventArgs) Handles LBLCNODISP6.Click

    End Sub
End Class