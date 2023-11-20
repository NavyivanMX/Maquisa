Public Class frmAgendaVisita

    Dim GBDIA(7) As GroupBox
    Dim LBLFECHAS(7) As Label
    Dim LBLNOMVEND(7) As Label
    Dim LBLCTOT(7) As Label
    Dim LBLCVISITADO(7) As Label
    Dim LBLCVISITAR(7) As Label
    Dim LBLCNODISP(7) As Label
    Dim LBLPROSP(7) As Label
    Dim LBLFINRUTA(7) As Label
    Dim FEC As DateTime
    Dim LRUT As New List(Of String)
    Dim LVEN As New List(Of String)
    Private Sub frmAgendaVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me)
        Me.Icon = frmPrincipal.Icon
        OPLlenaComboBox(CBRUTA, LRUT, LVEN, "SELECT R.CLAVE,V.NOMBRE,R.NOMBRE FROM RUTAS R INNER JOIN VENDEDORES V ON R.VENDEDOR=V.CLAVE WHERE R.ACTIVO=1 ORDER BY R.NOMBRE", frmPrincipal.CadenaConexion)
        LBLNUMPROSPECTO.Text = BDExtraeUnDato("SELECT ISNULL(COUNT(CLAVE),0) FROM PROSPECTOS WHERE RESULTADOPROSPECTO=0", frmPrincipal.CadenaConexion)
        INICIALIZAR()
    End Sub
    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        'If CBRUTA.SelectedIndex = 0 Then
        '    OPMsgError("Favor de seleccionar una ruta")
        '    Return
        'End If
        CARGADATOS()
    End Sub
    Private Sub INICIALIZAR()
        Dim X As Integer
        FEC = InicioSemana(System.DateTime.Now)

        For X = 1 To 6
            GBDIA(X) = New GroupBox
            LBLFECHAS(X) = New Label
            LBLNOMVEND(X) = New Label
            LBLCTOT(X) = New Label
            LBLCVISITADO(X) = New Label
            LBLCVISITAR(X) = New Label
            LBLCNODISP(X) = New Label
            LBLPROSP(X) = New Label
            LBLFINRUTA(X) = New Label

        Next

        GBDIA(1) = GBDIA1
        GBDIA(2) = GBDIA2
        GBDIA(3) = GBDIA3
        GBDIA(4) = GBDIA4
        GBDIA(5) = GBDIA5
        GBDIA(6) = GBDIA6
        For X = 1 To 6
            GBDIA(X).Visible = False
        Next

        LBLFECHAS(1) = LBLFECHAS1
        LBLFECHAS(2) = LBLFECHAS2
        LBLFECHAS(3) = LBLFECHAS3
        LBLFECHAS(4) = LBLFECHAS4
        LBLFECHAS(5) = LBLFECHAS5
        LBLFECHAS(6) = LBLFECHAS6

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



    Private Sub CARGADATOS()

        ''BDExtraeUnDato("SELECT V.NOMBRE FROM  RUTAS R INNER JOIN VENDEDORES V ON V.CLAVE=R.VENDEDOR WHERE  ")
        Dim POS As Integer
        POS = 1
        Dim X As Integer
        For X = 1 To 6
            GBDIA(X).Visible = False
        Next
        Dim DS As New DataSet
        DS = BDLlenaDataSet("EXEC SPAGENDASEMANAL '" + FEC.ToString("dd/MM/yyyy") + "'," + LRUT(CBRUTA.SelectedIndex).ToString + " ", frmPrincipal.CadenaConexion)
        For Each DT As DataTable In DS.Tables
            GBDIA(POS).Visible = True
            LBLNOMVEND(POS).Text = DT.Rows(0).Item(0).ToString
            LBLCTOT(POS).Text = DT.Rows(0).Item(1).ToString
            LBLCVISITADO(POS).Text = DT.Rows(0).Item(2).ToString
            LBLCVISITAR(POS).Text = DT.Rows(0).Item(3).ToString
            LBLCNODISP(POS).Text = DT.Rows(0).Item(4).ToString
            LBLPROSP(POS).Text = DT.Rows(0).Item(5).ToString
            LBLFINRUTA(POS).Text = DT.Rows(0).Item(6).ToString
            LBLFECHAS(POS).Text = DT.Rows(0).Item(7).ToString()
            POS += 1
        Next
    End Sub

    Private Sub MC_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MC.DateChanged
        FEC = InicioSemana(MC.SelectionStart)
    End Sub
    Private Function InicioSemana(ByVal pFec As DateTime) As DateTime
        Dim reg As DateTime
        reg = pFec

        Try

            Dim DS As Integer
            DS = pFec.DayOfWeek
            If DS = 0 Then
                reg = pFec.AddDays(1)
            End If
            If DS >= 2 Then
                reg = pFec.AddDays(-1 * (DS - 1))
            End If
        Catch ex As Exception

        End Try
        Return reg
    End Function

    Private Sub CBRUTA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRUTA.SelectedIndexChanged
        LBLVENDEDOR.Text = LVEN(CBRUTA.SelectedIndex)
    End Sub

    Private Sub BTNAGENDAR_Click(sender As Object, e As EventArgs) Handles BTNAGENDAR.Click
        frmAgendar.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: hacer ventana de prospecto
        'frmAdministrarProspecto.showdialog()
    End Sub

    Private Sub BTNVERDETALLEVISITA_Click(sender As Object, e As EventArgs) Handles BTNVERDETALLEVISITA1.Click, BTNVERDETALLEVISITA2.Click
        frmDetalleAgenda.ShowDialog()
    End Sub


End Class