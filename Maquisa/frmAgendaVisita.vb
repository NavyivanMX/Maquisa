Public Class frmAgendaVisita

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
        GBDIA(1) = GBDIA1
        GBDIA(1) = GBDIA1

        LBLNOMVEND(1) = LBLNOMVEND1
        '
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GBDIA1.Enter

    End Sub


    Private Sub CARGADATOS()

        Dim DS As New DataSet
        DS = BDLlenaDataSet("EXEC SPAGENDASEMANAL '06/11/2023',3", frmPrincipal.CadenaConexion)
        For Each DT As DataTable In DS.Tables

        Next
    End Sub
End Class