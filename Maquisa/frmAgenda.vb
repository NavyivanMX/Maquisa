Public Class frmAgenda
    Dim LPDS As New List(Of FlowLayoutPanel)
    Dim LPSS As New List(Of FlowLayoutPanel)
    Dim LPSM As New List(Of FlowLayoutPanel)
    Dim LBLSD As New List(Of Label)
    Dim LBLSS As New List(Of Label)
    Dim LBLSM As New List(Of FlowLayoutPanel)
    Dim BTNM(42) As Button

    Dim BTNS(42) As Button
    Dim LNVS(42) As Integer
    Dim LNSS(42) As Integer
    Dim LDS(7) As Label

    Dim BTND(120) As Button
    Dim LNVD(120) As String
    Dim LSVD(120) As String
    Dim LTTT(120) As ToolTip
    Dim LNC(42) As Integer
    Dim LNM(42) As Integer
    Dim LFC(42) As DateTime
    Dim LNV(42) As Label
    '   Dim LLB(42) As ListBox
    Dim LLV(42) As ListView
    Dim LLCS(42, 50) As Integer
    Dim LLCV(42, 50) As Integer
    Dim DTP As New DataTable
    Dim LSUC As New List(Of String)
    Dim LORI As New List(Of String)
    Dim LDES As New List(Of String)
    Dim LTRE As New List(Of String)
    Dim LEVI As New List(Of String)
    Dim LTV As New List(Of String)
    Dim TTT As ToolTip
    Dim DTTVV As DataTable
    Private Sub frmAgenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If frmPrincipal.CATALOGOCARGADO Then
        Me.Icon = frmPrincipal.Icon
        OPVisualizacionForm(Me)
        'MC.FirstDayOfWeek = Day.Sunday
        TabPage1.Visible = False
        TTT = New ToolTip
        TTT.IsBalloon = True

        MC.MaxSelectionCount = 7
        CARGARVIAJES()
        CARGAINICIO() '' se carga esto en el load ''' ... se supone que ya NO tengo k recargar las sucursales

        'MessageBox.Show(LSUC.Count.ToString) '' cuantas sucursales se cargarton
        INICIALIZAR() '' se i nicializan los disa semanas y años
        OPCIONESBASE() '' se inicializan los parametros de entrada
        '' se cargan los dias mese i años
        CARGAMES()
        CARGADIA(MC.SelectionStart)
        CARGASEMANA()

        'INICIALIZARFLP()
        'Dim AB As Integer
        'AB = FirstDayOfWeek.System
        'DIASEMANA(AB)
        'MsgBox(DIASEMANA(FirstDayOfWeek.System))
        'Else
        'MessageBox.Show("Los viajes aun no han sido cargados, por favor espere...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'Me.Close()
        'End If




       
    End Sub
    Public Sub CARGADIA(ByVal FEC As DateTime)
        Me.Refresh()
        Dim DVT As New DataView
        Dim CCTT As Integer
        LPDS.Clear()
        'For X = 0 To 119
        '    BTND(X).Text = ""
        '    BTND(X).Visible = False
        'Next
        DGV3.Rows.Clear()
        Dim UR As Integer
        Dim ETIHORA As String
        'LABELDIA.Text = Format(MC.SelectionStart, "dddd") + " " + MC.SelectionStart.ToShortDateString
        LABELDIA2.Text = Format(MC.SelectionStart, "dddd") + " " + MC.SelectionStart.ToShortDateString
        Dim ren As Integer
        ren = DGV3.RowCount
        For X = 0 To 23
            DGV3.Rows.Add()
            UR = DGV3.Rows.Count - 1
            If X < 10 Then
                ETIHORA = "0" + X.ToString + ":00"
            Else
                ETIHORA = X.ToString + ":00"
            End If
            DGV3.Item(0, X).Value = ETIHORA
            '' aqui es hace el filtros de los viajes a x hora
            DVT = New DataView(DVD.ToTable, "FECHA = '" + Format(FEC, "dd/MM/yyy") + "' AND HORA='" + X.ToString + "'", "HORA", DataViewRowState.CurrentRows)
            If DVT.ToTable.Rows.Count <= 0 Then
                '' comentar toda esta seccion si solo saldran las horas donde SI haya informacion

            Else


                For Y = 0 To DVT.ToTable.Rows.Count - 1 '' aqui veo el primer viaje a esa hora
                    If Y > 4 Then
                        'Exit For
                    Else
                        'BTND((X * 5) + Y).Visible = True
                        'BTND((X * 5) + Y).Text = DVT.ToTable.Rows(Y).Item(0)
                        'LSVD((X * 5) + Y) = DVT.ToTable.Rows(Y).Item(10)
                        'LNVD((X * 5) + Y) = DVT.ToTable.Rows(Y).Item(11)
                        'TTT.SetToolTip(BTND((X * 5) + Y), DVT.ToTable.Rows(Y).Item(14))
                        'CCTT = DVT.ToTable.Rows(Y).Item(1)
                        'Color.FromArgb(CCTT)
                        'BTND((X * 5) + Y).BackColor = Color.FromArgb(CCTT)
                    End If
                    'If Y > 10 Then
                    'Else
                    '' aqui tronaba... el dgv3 solo tiene 10 columnas
                    '' el if dice si es mayor a 10.. 
                    '' cuando llega a 10
                    If (Y + 1) > DGV3.ColumnCount Then '' con esto lo limita al no de columnas del dgv.. por eso ya no truena
                        '' otra solucion es agregar la columna 11...
                        '' saludos

                    Else
                        'DGV3.Item(Y + 1, UR).Value = DVT.ToTable.Rows(Y).Item(0)
                        'DGV3.Item(Y + 1, UR).ToolTipText = DVT.ToTable.Rows(Y).Item(14)
                        'CCTT = DVT.ToTable.Rows(Y).Item(1)
                        'Color.FromArgb(CCTT)
                        'DGV3.Item(Y + 1, UR).Style = ESTILO(Color.FromArgb(CCTT), Color.Black)
                        'DGV3.Item(Y + 1, UR).Tag = "S" + DVT.ToTable.Rows(Y).Item(10).ToString + "-V" + DVT.ToTable.Rows(Y).Item(11).ToString
                        'DGV3.Columns(Y + 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                        DGV3.Item(Y + 1, X).Value = DVT.ToTable.Rows(Y).Item(0) '' se intenta guardar en la columna 10+1  = 11 que NO existe... y por eso tronaba...
                        DGV3.Item(Y + 1, X).ToolTipText = DVT.ToTable.Rows(Y).Item(14)
                        CCTT = DVT.ToTable.Rows(Y).Item(1)
                        Color.FromArgb(CCTT)
                        DGV3.Item(Y + 1, UR).Style = DgvCellEstilo(Color.FromArgb(CCTT), Color.Black)
                        DGV3.Item(Y + 1, UR).Tag = "S" + DVT.ToTable.Rows(Y).Item(10).ToString + "-V" + DVT.ToTable.Rows(Y).Item(11).ToString
                        DGV3.Columns(Y + 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        ' End If

                    End If

                Next
            End If
        Next

    End Sub
    Dim DVI As DataView
    Private Sub INFOVIAJE()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        'Dim QUERY As String
        'QUERY = "SELECT S.NOMBRECOMERCIAL [Sucursal],D.NV [No. Viaje],TC.NOMBRE [Tipo Carro],DBO.CARROVIAJE(D.EMPRESASUBRENTA,D.CARRO) [Carro],N.FECHA Fecha,D.FECHARENTADE [Fecha Renta De],D.FECHARENTAH [Fecha Renta Hasta],CONVERT(VARCHAR(10),D.HRARENTADE,108)[Hora De],CONVERT(VARCHAR(10),D.HRARENTAH,108)[Hora Hasta],O.NOMBRE [Origen],L.NOMBRE Destino,TR.NOMBRE [Tipo Renta],D.CANTIDAD Cantidad,D.PRECIOSUGERIDO [Precio Sugerido],D.PRECIOCOTIZACION [Precio Cotización],EV.NOMBRE Estatus,TV.NOMBRE [Tipo Viaje],Viaje='NV'+CONVERT(VARCHAR(100),D.NV) +'-'+DBO.CARROVIAJE(D.EMPRESASUBRENTA,D.CARRO)+'-'+O.NOMBRECORTO+'-'+TR.NOMBREC+'-'+DBO.CHOFERESENVIAJE(D.EMPRESA ,D.SUCURSAL,D.NV),D.CHOFERASIGNADO [Chofer Asignado] FROM TEMPVIAJE N INNER JOIN VIAJE D ON N.EMPRESA=D.EMPRESA AND N.SUCURSAL=D.SUCURSAL AND N.NV=D.NV  INNER JOIN SUCURSAL S ON D.SUCURSAL=S.CLAVE INNER JOIN TIPOCARRO TC ON D.TIPOCARRO=TC.CLAVE INNER JOIN CARROS C ON D.CARRO=C.CLAVE INNER JOIN DESTINOSVIAJES O ON D.ORIGEN=O.CLAVE INNER JOIN DESTINOSVIAJES L ON D.DESTINO=L.CLAVE INNER JOIN TIPORENTA TR ON D.TIPORENTA=TR.CLAVE INNER JOIN TIPOVIAJE TV ON D.TIPOVIAJE=TV.CLAVE INNER JOIN STATUSVIAJE EV ON D.ESTATUS=EV.CLAVE"
        Dim OP As String
        Dim REG As String
        OP = "FECHA>='01/01/2015'"
        REG = ""
        If CBSUC.SelectedIndex <> 0 Then
            REG += " AND SUCURSAL=" + LSUC(CBSUC.SelectedIndex)
        End If
        If CBORI.SelectedIndex <> 0 Then
            REG += " AND ORIGEN=" + LORI(CBORI.SelectedIndex)
        End If
        If CBDES.SelectedIndex <> 0 Then
            REG += " AND DESTINO=" + LDES(CBDES.SelectedIndex)
        End If
        If CBTR.SelectedIndex <> 0 Then
            REG += " AND TIPORENTA=" + LTRE(CBTR.SelectedIndex)
        End If
        If CBEVI.SelectedIndex <> 0 Then
            REG += " AND ESTATUSVIAJE=" + LEVI(CBEVI.SelectedIndex)
        End If
        If CBTV.SelectedIndex <> 0 Then
            REG += " AND TIPOVIAJE=" + LTV(CBTV.SelectedIndex)
        End If
        If CBCAR.SelectedIndex = 1 Then
            REG += " AND CARROASIGNADO=1"
        End If
        If CBCAR.SelectedIndex = 2 Then
            REG += " AND CARROASIGNADO=0"
        End If
        If CBCHO.SelectedIndex = 1 Then
            REG += " AND CHOFERASIGNADO=1"
        End If

        If CBCHO.SelectedIndex = 2 Then
            REG += " AND CHOFERASIGNADO=0"
        End If
        DVI = New DataView(DTP, OP + REG, "HORA", DataViewRowState.CurrentRows)
        DGV2.DataSource = DVI.ToTable
    End Sub
    Private Function DIASEMANA(ByVal DIA As Integer) As String
        If DIA = 0 Then
            Return "Domingo"
        End If
        If DIA = 1 Then
            Return "Lunes"
        End If
        If DIA = 2 Then
            Return "Martes"
        End If
        If DIA = 3 Then
            Return "Miércoles"
        End If
        If DIA = 4 Then
            Return "Jueves"
        End If
        If DIA = 5 Then
            Return "Viernes"
        End If
        If DIA = 6 Then
            Return "Sábado"
        End If
        Return ""
    End Function
    Public Sub CARGASEMANA()
        Dim DVT As New DataView
        Dim CCTT As Integer
        LPDS.Clear()
        For X = 0 To 41
            BTNS(X).Text = ""
            BTNS(X).Visible = False
        Next

        Dim DS As Integer
        DS = MC.SelectionStart.DayOfWeek
        'MC.SelectionStart.Date.AddDays(DS * -1)
    
        DGV4.Columns.Clear()
        DGV4.Columns.Add(DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 0).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 0).Day.ToString, DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 0).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 0).Day.ToString)
        DGV4.Columns.Add(DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 1).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 1).Day.ToString, DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 1).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 1).Day.ToString)
        DGV4.Columns.Add(DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 2).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 2).Day.ToString, DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 2).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 2).Day.ToString)
        DGV4.Columns.Add(DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 3).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 3).Day.ToString, DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 3).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 3).Day.ToString)
        DGV4.Columns.Add(DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 4).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 4).Day.ToString, DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 4).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 4).Day.ToString)
        DGV4.Columns.Add(DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 5).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 5).Day.ToString, DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 5).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 5).Day.ToString)
        DGV4.Columns.Add(DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 6).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 6).Day.ToString, DIASEMANA(MC.SelectionStart.Date.AddDays((DS * -1) + 6).DayOfWeek) + " " + MC.SelectionStart.Date.AddDays((DS * -1) + 6).Day.ToString)
        '(DS * -1) vs (DS - 1)
        'DGV4.Columns.Add("Domingo " + MC.SelectionStart.Date.AddDays((DS - 1) + 0).Day.ToString, "Domingo " + MC.SelectionStart.Date.AddDays((DS - 1) + 0).Day.ToString)
        'DGV4.Columns.Add("Lunes " + MC.SelectionStart.Date.AddDays((DS - 1) + 1).Day.ToString, "Lunes " + MC.SelectionStart.Date.AddDays((DS - 1) + 1).Day.ToString)
        'DGV4.Columns.Add("Martes" + MC.SelectionStart.Date.AddDays((DS - 1) + 2).Day.ToString, "Martes " + MC.SelectionStart.Date.AddDays((DS - 1) + 2).Day.ToString)
        'DGV4.Columns.Add("Miércoles " + MC.SelectionStart.Date.AddDays((DS - 1) + 3).Day.ToString, "Miércoles " + MC.SelectionStart.Date.AddDays((DS - 1) + 3).Day.ToString)
        'DGV4.Columns.Add("Jueves " + MC.SelectionStart.Date.AddDays((DS - 1) + 4).Day.ToString, "Jueves " + MC.SelectionStart.Date.AddDays((DS - 1) + 4).Day.ToString)
        'DGV4.Columns.Add("Viernes" + MC.SelectionStart.Date.AddDays((DS - 1) + 5).Day.ToString, "Viernes " + MC.SelectionStart.Date.AddDays((DS - 1) + 5).Day.ToString)
        'DGV4.Columns.Add("Sábado " + MC.SelectionStart.Date.AddDays((DS - 1) + 6).Day.ToString, "Sábado " + MC.SelectionStart.Date.AddDays((DS - 1) + 6).Day.ToString)
        Dim nsemana As Integer
        nsemana = DateDiff(DateInterval.WeekOfYear, MC.SelectionStart, New DateTime(MC.SelectionStart.Year, 1, 1))
        nsemana = nsemana * -1
        LBLSEMANA.Text = "Semana # " + nsemana.ToString + ". Del " + Format(MC.SelectionStart.Date.AddDays((DS * -1)), "dd/MM/yyy") + " al " + Format(MC.SelectionStart.Date.AddDays((DS * -1) + 6), "dd/MM/yyy")
        Dim SEG As Integer
        Dim LFEC As String
        For X = 0 To 6            
            LDS(X).Text = MC.SelectionStart.Date.AddDays((DS * -1) + X).Day.ToString
            LFEC = Format(MC.SelectionStart.Date.AddDays((DS * -1) + X), "dd/MM/yyy")
            DVT = New DataView(DVS.ToTable, "FECHA = '" + LFEC + "'", "HORA", DataViewRowState.CurrentRows)
            If DVT.ToTable.Rows.Count <= 0 Then
            Else
                For Y = 0 To DVT.ToTable.Rows.Count - 1
                    If Y > DGV4.Rows.Count - 1 Then
                        DGV4.Rows.Add()            
                    End If
                    'If Y > 6 Then
                    '    Exit For
                    'Else

                    'End If
                    'SEG = (X * 6) + Y
                    'BTNS((X * 6) + Y).Visible = True
                    'BTNS((X * 6) + Y).Text = DVT.ToTable.Rows(Y).Item(0)
                    'LNSS((X * 6) + Y) = DVT.ToTable.Rows(Y).Item(10)
                    'LNVS((X * 6) + Y) = DVT.ToTable.Rows(Y).Item(11)
                    'TTT.SetToolTip(BTNS((X * 6) + Y), DVT.ToTable.Rows(Y).Item(14))
                    'CCTT = DVT.ToTable.Rows(Y).Item(1)
                    'Color.FromArgb(CCTT)
                    'BTNS((X * 6) + Y).BackColor = Color.FromArgb(CCTT)
                    Dim algo As String
                    algo = DVT.ToTable.Rows(Y).Item(0).ToString
                    DGV4.Item(X, Y).Value = DVT.ToTable.Rows(Y).Item(0)
                    DGV4.Item(X, Y).ToolTipText = DVT.ToTable.Rows(Y).Item(14)
                    CCTT = DVT.ToTable.Rows(Y).Item(1)
                    Color.FromArgb(CCTT)
                    DGV4.Item(X, Y).Style = DgvCellEstilo(Color.FromArgb(CCTT), Color.Black)
                    DGV4.Item(X, Y).Tag = "S" + DVT.ToTable.Rows(Y).Item(10).ToString + "-V" + DVT.ToTable.Rows(Y).Item(11).ToString
                    DGV4.Columns(X).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Next
            End If
        Next
    End Sub
    Public Sub CARGAMES()
        Dim DS As Integer
        Dim INIMES, FINMES As DateTime
        INIMES = CType("01/" & Format(MC.SelectionStart.Date, "MM") & "/" & MC.SelectionStart.Year, Date)
        FINMES = (INIMES.AddMonths(1)).AddDays(-1)
        LBLI.Text = INIMES.ToShortDateString
        LBLF.Text = FINMES.ToShortDateString
        DS = INIMES.DayOfWeek
        If DS = 0 Then
            DS = 7
        End If
        LBLMES.Text = Format(MC.SelectionStart, "MMMM").ToUpper
        Dim CONT As Integer
        CONT = 1
        Dim X As Integer
        For X = 0 To 41
            BTNM(X).Visible = True
        Next
        For X = DS - 1 To 0 Step -1
            LNC(X) = INIMES.AddDays(CONT * -1).Day
            LNM(X) = INIMES.AddDays(CONT * -1).Month
            LFC(X) = INIMES.AddDays(CONT * -1)
            CONT += 1
            BTNM(X).Visible = False
        Next

        '0 DOMINGO
        '6 SABADO

        'For X = DS To 41
        For X = DS To 41
            LNC(X) = INIMES.AddDays(X - DS).Day
            LNM(X) = INIMES.AddDays(X - DS).Month
            LFC(X) = INIMES.AddDays(X - DS)
        Next

        For X = 0 To 41
            BTNM(X).Text = LNC(X).ToString
        Next

        For X = DS + INIMES.DaysInMonth(INIMES.Year, INIMES.Month) To 41
            BTNM(X).Visible = False
        Next
        Dim DVT As New DataView
        Dim CCTT As Integer
        Dim Y As Integer
        For X = 0 To 41
            For Y = 0 To 19
                LLCS(X, Y) = 0
                LLCV(X, Y) = 0
            Next
            LNV(X).Text = ""
            'LLB(X).Items.Clear()
            LLV(X).Items.Clear()
            DVT = New DataView(DVM.ToTable, "FECHA = '" + Format(LFC(X), "dd/MM/yyyy") + "'", "HORA", DataViewRowState.CurrentRows)
            If DVT.ToTable.Rows.Count <= 0 Then
                'LLB(X).Visible = False
                LLV(X).Visible = False
            Else
                'LLB(X).Visible = True
                LLV(X).Visible = True
                LNV(X).Text = ".:" + DVT.ToTable.Rows.Count.ToString
                For Y = 0 To DVT.ToTable.Rows.Count - 1
                    'LLB(X).Items.Add(DVT.ToTable.Rows(Y).Item(13))
                    LLV(X).Items.Add(DVT.ToTable.Rows(Y).Item(13))
                    CCTT = DVT.ToTable.Rows(Y).Item(1)
                    LLV(X).Items(Y).ForeColor = Color.FromArgb(CCTT)
                    LLCS(X, Y) = DVT.ToTable.Rows(Y).Item(10)
                    LLCV(X, Y) = DVT.ToTable.Rows(Y).Item(11)
                    TTT.SetToolTip(LLV(X), Y + 1)
                    'TTT.SetToolTip(LLV(X).Items(Y), DVT.ToTable.Rows(Y).Item(13))
                Next
            End If
        Next



    End Sub
    Private Sub INICIALIZAR()
        BTNM(0) = BTN1
        BTNM(1) = BTN2
        BTNM(2) = BTN3
        BTNM(3) = BTN4
        BTNM(4) = BTN5
        BTNM(5) = BTN6
        BTNM(6) = BTN7
        BTNM(7) = BTN8
        BTNM(8) = BTN9
        BTNM(9) = BTN10
        BTNM(10) = BTN11
        BTNM(11) = BTN12
        BTNM(12) = BTN13
        BTNM(13) = BTN14
        BTNM(14) = BTN15
        BTNM(15) = BTN16
        BTNM(16) = BTN17
        BTNM(17) = BTN18
        BTNM(18) = BTN19
        BTNM(19) = BTN20
        BTNM(20) = BTN21
        BTNM(21) = BTN22
        BTNM(22) = BTN23
        BTNM(23) = BTN24
        BTNM(24) = BTN25
        BTNM(25) = BTN26
        BTNM(26) = BTN27
        BTNM(27) = BTN28
        BTNM(28) = BTN29
        BTNM(29) = BTN30
        BTNM(30) = BTN31
        BTNM(31) = BTN32
        BTNM(32) = BTN33
        BTNM(33) = BTN34
        BTNM(34) = BTN35
        BTNM(35) = BTN36
        BTNM(36) = BTN37
        BTNM(37) = BTN38
        BTNM(38) = BTN39
        BTNM(39) = BTN40
        BTNM(40) = BTN41
        BTNM(41) = BTN42
        LNV(0) = LNV1
        LNV(1) = LNV2
        LNV(2) = LNV3
        LNV(3) = LNV4
        LNV(4) = LNV5
        LNV(5) = LNV6
        LNV(6) = LNV7
        LNV(7) = LNV8
        LNV(8) = LNV9
        LNV(9) = LNV10
        LNV(10) = LNV11
        LNV(11) = LNV12
        LNV(12) = LNV13
        LNV(13) = LNV14
        LNV(14) = LNV15
        LNV(15) = LNV16
        LNV(16) = LNV17
        LNV(17) = LNV18
        LNV(18) = LNV19
        LNV(19) = LNV20
        LNV(20) = LNV21
        LNV(21) = LNV22
        LNV(22) = LNV23
        LNV(23) = LNV24
        LNV(24) = LNV25
        LNV(25) = LNV26
        LNV(26) = LNV27
        LNV(27) = LNV28
        LNV(28) = LNV29
        LNV(29) = LNV30
        LNV(30) = LNV31
        LNV(31) = LNV32
        LNV(32) = LNV33
        LNV(33) = LNV34
        LNV(34) = LNV35
        LNV(35) = LNV36
        LNV(36) = LNV37
        LNV(37) = LNV38
        LNV(38) = LNV39
        LNV(39) = LNV40
        LNV(40) = LNV41
        LNV(41) = LNV42

        'LLB(0) = LB1
        'LLB(1) = LB2
        'LLB(2) = LB3
        'LLB(3) = LB4
        'LLB(4) = LB5
        'LLB(5) = LB6
        'LLB(6) = LB7
        'LLB(7) = LB8
        'LLB(8) = LB9
        'LLB(9) = LB10
        'LLB(10) = LB11
        'LLB(11) = LB12
        'LLB(12) = LB13
        'LLB(13) = LB14
        'LLB(14) = LB15
        'LLB(15) = LB16
        'LLB(16) = LB17
        'LLB(17) = LB18
        'LLB(18) = LB19
        'LLB(19) = LB20
        'LLB(20) = LB21
        'LLB(21) = LB22
        'LLB(22) = LB23
        'LLB(23) = LB24
        'LLB(24) = LB25
        'LLB(25) = LB26
        'LLB(26) = LB27
        'LLB(27) = LB28
        'LLB(28) = LB29
        'LLB(29) = LB30
        'LLB(30) = LB31
        'LLB(31) = LB32
        'LLB(32) = LB33
        'LLB(33) = LB34
        'LLB(34) = LB35
        'LLB(35) = LB36
        'LLB(36) = LB37
        'LLB(37) = LB38
        'LLB(38) = LB39
        'LLB(39) = LB40
        'LLB(40) = LB41
        'LLB(41) = LB42

        LLV(0) = LV1
        LLV(1) = LV2
        LLV(2) = LV3
        LLV(3) = LV4
        LLV(4) = LV5
        LLV(5) = LV6
        LLV(6) = LV7
        LLV(7) = LV8
        LLV(8) = LV9
        LLV(9) = LV10
        LLV(10) = LV11
        LLV(11) = LV12
        LLV(12) = LV13
        LLV(13) = LV14
        LLV(14) = LV15
        LLV(15) = LV16
        LLV(16) = LV17
        LLV(17) = LV18
        LLV(18) = LV19
        LLV(19) = LV20
        LLV(20) = LV21
        LLV(21) = LV22
        LLV(22) = LV23
        LLV(23) = LV24
        LLV(24) = LV25
        LLV(25) = LV26
        LLV(26) = LV27
        LLV(27) = LV28
        LLV(28) = LV29
        LLV(29) = LV30
        LLV(30) = LV31
        LLV(31) = LV32
        LLV(32) = LV33
        LLV(33) = LV34
        LLV(34) = LV35
        LLV(35) = LV36
        LLV(36) = LV37
        LLV(37) = LV38
        LLV(38) = LV39
        LLV(39) = LV40
        LLV(40) = LV41
        LLV(41) = LV42

        'BTND(0) = BD1
        'BTND(1) = BD2
        'BTND(2) = BD3
        'BTND(3) = BD4
        'BTND(4) = BD5
        'BTND(5) = BD6
        'BTND(6) = BD7
        'BTND(7) = BD8
        'BTND(8) = BD9
        'BTND(9) = BD10
        'BTND(10) = BD11
        'BTND(11) = BD12
        'BTND(12) = BD13
        'BTND(13) = BD14
        'BTND(14) = BD15
        'BTND(15) = BD16
        'BTND(16) = BD17
        'BTND(17) = BD18
        'BTND(18) = BD19
        'BTND(19) = BD20
        'BTND(20) = BD21
        'BTND(21) = BD22
        'BTND(22) = BD23
        'BTND(23) = BD24
        'BTND(24) = BD25
        'BTND(25) = BD26
        'BTND(26) = BD27
        'BTND(27) = BD28
        'BTND(28) = BD29
        'BTND(29) = BD30
        'BTND(30) = BD31
        'BTND(31) = BD32
        'BTND(32) = BD33
        'BTND(33) = BD34
        'BTND(34) = BD35
        'BTND(35) = BD36
        'BTND(36) = BD37
        'BTND(37) = BD38
        'BTND(38) = BD39
        'BTND(39) = BD40
        'BTND(40) = BD41
        'BTND(41) = BD42
        'BTND(42) = BD43
        'BTND(43) = BD44
        'BTND(44) = BD45
        'BTND(45) = BD46
        'BTND(46) = BD47
        'BTND(47) = BD48
        'BTND(48) = BD49
        'BTND(49) = BD50
        'BTND(50) = BD51
        'BTND(51) = BD52
        'BTND(52) = BD53
        'BTND(53) = BD54
        'BTND(54) = BD55
        'BTND(55) = BD56
        'BTND(56) = BD57
        'BTND(57) = BD58
        'BTND(58) = BD59
        'BTND(59) = BD60
        'BTND(60) = BD61
        'BTND(61) = BD62
        'BTND(62) = BD63
        'BTND(63) = BD64
        'BTND(64) = BD65
        'BTND(65) = BD66
        'BTND(66) = BD67
        'BTND(67) = BD68
        'BTND(68) = BD69
        'BTND(69) = BD70
        'BTND(70) = BD71
        'BTND(71) = BD72
        'BTND(72) = BD73
        'BTND(73) = BD74
        'BTND(74) = BD75
        'BTND(75) = BD76
        'BTND(76) = BD77
        'BTND(77) = BD78
        'BTND(78) = BD79
        'BTND(79) = BD80
        'BTND(80) = BD81
        'BTND(81) = BD82
        'BTND(82) = BD83
        'BTND(83) = BD84
        'BTND(84) = BD85
        'BTND(85) = BD86
        'BTND(86) = BD87
        'BTND(87) = BD88
        'BTND(88) = BD89
        'BTND(89) = BD90
        'BTND(90) = BD91
        'BTND(91) = BD92
        'BTND(92) = BD93
        'BTND(93) = BD94
        'BTND(94) = BD95
        'BTND(95) = BD96
        'BTND(96) = BD97
        'BTND(97) = BD98
        'BTND(98) = BD99
        'BTND(99) = BD100
        'BTND(100) = BD101
        'BTND(101) = BD102
        'BTND(102) = BD103
        'BTND(103) = BD104
        'BTND(104) = BD105
        'BTND(105) = BD106
        'BTND(106) = BD107
        'BTND(107) = BD108
        'BTND(108) = BD109
        'BTND(109) = BD110
        'BTND(110) = BD111
        'BTND(111) = BD112
        'BTND(112) = BD113
        'BTND(113) = BD114
        'BTND(114) = BD115
        'BTND(115) = BD116
        'BTND(116) = BD117
        'BTND(117) = BD118
        'BTND(118) = BD119
        'BTND(119) = BD120


        BTNS(0) = BS1
        BTNS(1) = BS2
        BTNS(2) = BS3
        BTNS(3) = BS4
        BTNS(4) = BS5
        BTNS(5) = BS6
        BTNS(6) = BS7
        BTNS(7) = BS8
        BTNS(8) = BS9
        BTNS(9) = BS10
        BTNS(10) = BS11
        BTNS(11) = BS12
        BTNS(12) = BS13
        BTNS(13) = BS14
        BTNS(14) = BS15
        BTNS(15) = BS16
        BTNS(16) = BS17
        BTNS(17) = BS18
        BTNS(18) = BS19
        BTNS(19) = BS20
        BTNS(20) = BS21
        BTNS(21) = BS22
        BTNS(22) = BS23
        BTNS(23) = BS24
        BTNS(24) = BS25
        BTNS(25) = BS26
        BTNS(26) = BS27
        BTNS(27) = BS28
        BTNS(28) = BS29
        BTNS(29) = BS30
        BTNS(30) = BS31
        BTNS(31) = BS32
        BTNS(32) = BS33
        BTNS(33) = BS34
        BTNS(34) = BS35
        BTNS(35) = BS36
        BTNS(36) = BS37
        BTNS(37) = BS38
        BTNS(38) = BS39
        BTNS(39) = BS40
        BTNS(40) = BS41
        BTNS(41) = BS42


        LDS(0) = LDS1
        LDS(1) = LDS2
        LDS(2) = LDS3
        LDS(3) = LDS4
        LDS(4) = LDS5
        LDS(5) = LDS6
        LDS(6) = LDS7
    End Sub
    Public Sub CARGARVIAJES()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        Dim QUERY As String
        QUERY = "SELECT * FROM VTEMPVIAJE2 "
        DTP = BDLlenaTabla(QUERY, frmPrincipal.CadenaConexion)
        'DGV.DataSource = DTP
    End Sub
    Public Sub CARGAINICIO()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If

        CBCAR.SelectedIndex = 0
        CBCHO.SelectedIndex = 0
        OPLlenaComboBox(CBSUC, LSUC, "SELECT CLAVE,NOMBRECOMERCIAL FROM SUCURSAL WHERE ACTIVO=1 ORDER BY NOMBRECOMERCIAL", frmPrincipal.CadenaConexion, "Todos", "")
        OPLlenaComboBox(CBORI, LORI, "SELECT CLAVE,NOMBRE FROM DESTINOSVIAJES WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Todos", "")
        OPLlenaComboBox(CBDES, LDES, "SELECT CLAVE,NOMBRE FROM DESTINOSVIAJES WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Todos", "")
        OPLlenaComboBox(CBTR, LTRE, "SELECT CLAVE,NOMBRE FROM TIPORENTA WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Todos", "")
        OPLlenaComboBox(CBEVI, LEVI, "SELECT CLAVE,NOMBRE FROM STATUSVIAJE WHERE ACTIVO=1 AND CLAVE<>4 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Todos", "")
        OPLlenaComboBox(CBTV, LTV, "SELECT CLAVE,NOMBRE FROM TIPOVIAJE WHERE ACTIVO=1 AND CLAVE<>3 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Todos", "")
        OPCargaX(LSUC, CBSUC, frmPrincipal.SucursalBase)
        OPCIONESBASE()
    End Sub
    Dim DV As DataView
    Dim DVD As DataView
    Dim DVS As DataView
    Dim DVM As DataView
    Private Sub OPCIONESBASE()
        Dim REG, O1, O2, O3 As String
        REG = ""
        O1 = ""
        O2 = ""
        O3 = ""
        'If OPC = 1 Then
        O1 = "FECHA='" + Format(MC.SelectionStart.Date, "dd/MM/yyyy") + "'"
        'End If
        'If OPC = 2 Then
        Dim DS As Integer
        DS = MC.SelectionStart.DayOfWeek
        'MC.SelectionStart.Date.AddDays(DS * -1)
        O2 = "FECHA>='" + Format(MC.SelectionStart.Date.AddDays(DS * -1), "dd/MM/yyyy") + "' AND FECHA<'" + Format(MC.SelectionStart.Date.AddDays(DS * -1).AddDays(7), "dd/MM/yyyy") + "'"
        'MC.SelectionStart = MC.SelectionStart.Date
        'MC.SelectionEnd = MC.SelectionStart.Date.AddDays(7)
        ' End If
        'O3 = "FECHA>='" + CType("01/" & Format(MC.SelectionStart.Date, "MM") & "/" & MC.SelectionStart.Year, Date) + "' AND " + "FECHA<'" + CType("01/" & Format(MC.SelectionStart.Date.AddMonths(1), "MM") & "/" & MC.SelectionStart.Year, Date) + "'"
        O3 = "FECHA>='" + CType("01/" & Format(MC.SelectionStart.Date, "MM") & "/" & MC.SelectionStart.Year, Date) + "' AND " + "FECHA<'" + CType("01/" & Format(MC.SelectionStart.Date.AddMonths(1), "MM") & "/" & MC.SelectionStart.AddMonths(1).Year, Date) + "'"
        If CBSUC.SelectedIndex <> 0 Then
            REG += " AND SUCURSAL=" + LSUC(CBSUC.SelectedIndex)
        End If
        If CBORI.SelectedIndex <> 0 Then
            REG += " AND ORIGEN=" + LORI(CBORI.SelectedIndex)
        End If
        If CBDES.SelectedIndex <> 0 Then
            REG += " AND DESTINO=" + LDES(CBDES.SelectedIndex)
        End If
        If CBTR.SelectedIndex <> 0 Then
            REG += " AND TIPORENTA=" + LTRE(CBTR.SelectedIndex)
        End If
        If CBEVI.SelectedIndex <> 0 Then
            REG += " AND ESTATUSVIAJE=" + LEVI(CBEVI.SelectedIndex)
        End If
        If CBTV.SelectedIndex <> 0 Then
            REG += " AND TIPOVIAJE=" + LTV(CBTV.SelectedIndex)
        End If
        If CBCAR.SelectedIndex = 1 Then
            REG += " AND CARROASIGNADO=1"
        End If
        If CBCAR.SelectedIndex = 2 Then
            REG += " AND CARROASIGNADO=0"
        End If
        If CBCHO.SelectedIndex = 1 Then
            REG += " AND CHOFERASIGNADO=1"
        End If
        If CBCHO.SelectedIndex = 2 Then
            REG += " AND CHOFERASIGNADO=0"
        End If
        DV = New DataView(DTP, O3 + REG, "HORA", DataViewRowState.CurrentRows)
        DVD = New DataView(DTP, O1 + REG, "HORA", DataViewRowState.CurrentRows)
        DVS = New DataView(DTP, O2 + REG, "HORA", DataViewRowState.CurrentRows)
        DVM = New DataView(DTP, O3 + REG, "HORA", DataViewRowState.CurrentRows)

        'DGV.DataSource = DV
        INFOVIAJE()
    End Sub


    Private Sub INICIALIZARFLP()
        Dim X As Integer



        'LPDS(X).Controls.Clear()


        For X = 0 To 6
            Dim VFLP As New FlowLayoutPanel
            Dim SZ As Size
            SZ.Width = 130
            SZ.Height = 500
            VFLP.Size = SZ
            Dim VBTN As New Button

            LPSS.Add(VFLP)
            Dim LBL As New Label
            LBL.Text = "DIASEMANA: " + (X + 1).ToString
            LPSS(X).Controls.Add(LBL)
            LPSS(X).Controls.Add(VBTN)
            VBTN.Text = "VIAJE 3 -" + (X + 1).ToString
            LPSS(X).Controls.Add(VBTN)
            VBTN.Text = "VIAJE 4 -" + (X + 1).ToString

        Next




    End Sub

    Private Sub MC_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MC.DateChanged
        Try
            LBLMES.Text = Format(MC.SelectionStart, "MMMM").ToUpper
            OPCIONESBASE()
            CARGAMES()
            CARGADIA(MC.SelectionStart)
            CARGASEMANA()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CBSUC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTR.SelectedIndexChanged, CBSUC.SelectedIndexChanged, CBORI.SelectedIndexChanged, CBEVI.SelectedIndexChanged, CBDES.SelectedIndexChanged, CBCHO.SelectedIndexChanged, CBCAR.SelectedIndexChanged, CBTV.SelectedIndexChanged
        Try
            OPCIONESBASE()
            CARGAMES()
            CARGADIA(MC.SelectionStart)
            CARGASEMANA()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub BTN1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN1.Click, BTN2.Click, BTN3.Click, BTN4.Click, BTN5.Click, BTN6.Click, BTN7.Click, BTN8.Click, BTN9.Click, BTN10.Click, BTN11.Click, BTN12.Click, BTN13.Click, BTN14.Click, BTN15.Click, BTN16.Click, BTN17.Click, BTN18.Click, BTN19.Click, BTN20.Click, BTN21.Click, BTN22.Click, BTN23.Click, BTN24.Click, BTN25.Click, BTN26.Click, BTN27.Click, BTN28.Click, BTN29.Click, BTN30.Click, BTN31.Click, BTN32.Click, BTN33.Click, BTN34.Click, BTN35.Click, BTN36.Click, BTN37.Click, BTN38.Click, BTN39.Click, BTN40.Click, BTN41.Click, BTN42.Click
        LBLMES.Text = LFC(CType(sender.TAG, Integer)).Month.ToString
        LBLMES.Text = Format(MC.SelectionStart, "MMMM").ToUpper
        MC.SelectionStart = LFC(CType(sender.TAG, Integer))
        Try
            OPCIONESBASE()
            CARGAMES()
            CARGADIA(LFC(CType(sender.TAG, Integer)))
            CARGASEMANA()
        Catch ex As Exception

        End Try

    End Sub

    Dim SUC, VI As Integer
    Private Sub BD1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'SUC = LSVD(CType(sender.TAG, Integer))
        'VI = LNVD(TypeOf sender.TAG Is Integer)
        ''frmDetalleAgenda.MOSTRAR(1, LSVD(CType(sender.TAG, Integer)), LNVD(CType(sender.TAG, Integer)))
        'frmDetalleAgenda.MOSTRAR(1, SUC, VI)
    End Sub


    Private Sub LV1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV1.Click, LV2.Click, LV3.Click, LV4.Click, LV5.Click, LV6.Click, LV7.Click, LV8.Click, LV9.Click, LV10.Click, LV11.Click, LV12.Click, LV13.Click, LV14.Click, LV15.Click, LV16.Click, LV17.Click, LV18.Click, LV19.Click, LV20.Click, LV21.Click, LV22.Click, LV23.Click, LV24.Click, LV25.Click, LV26.Click, LV27.Click, LV28.Click, LV29.Click, LV30.Click, LV31.Click, LV32.Click, LV33.Click, LV34.Click, LV35.Click, LV36.Click, LV37.Click, LV38.Click, LV39.Click, LV40.Click, LV41.Click, LV42.Click
        'LBLMES.Text = LFC(CType(sender.TAG, Integer)).ToShortDateString
        'CARGADIA(LFC(CType(sender.TAG, Integer)))

        'frmDetalleAgenda.MOSTRAR(1, LLCS(CType(sender.TAG, Integer), DatoLVSeleccionado(sender)), LLCV(CType(sender.TAG, Integer), CType(sender, ListView).SelectedItems.Count - 1))
        ' frmDetalleAgenda.MOSTRAR(1, LLCS(CType(sender.TAG, Integer), DatoLVSeleccionado(sender)), LLCV(CType(sender.TAG, Integer), DatoLVSeleccionado(sender)))
    End Sub

    Private Function DatoLVSeleccionado(ByRef LV As ListView) As Integer
        ' Al hacer doble click en un elemento del listview
        For X = 0 To LV.Items.Count - 1
            If LV.Items(X).Selected = True Then
                Return X
            End If
        Next
        Return 0
    End Function

    Dim PSS As Integer
    Private Sub BS1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BS1.Click, BS2.Click, BS3.Click, BS4.Click, BS5.Click, BS6.Click, BS7.Click, BS8.Click, BS9.Click, BS10.Click, BS11.Click, BS12.Click, BS13.Click, BS14.Click, BS15.Click, BS16.Click, BS17.Click, BS18.Click, BS19.Click, BS20.Click, BS21.Click, BS22.Click, BS23.Click, BS24.Click, BS25.Click, BS26.Click, BS27.Click, BS28.Click, BS29.Click, BS30.Click, BS31.Click, BS32.Click, BS33.Click, BS34.Click, BS35.Click, BS36.Click, BS37.Click, BS38.Click, BS39.Click, BS40.Click, BS41.Click, BS42.Click
        'PSS = CType(sender.TAG, Integer)
        'SUC = LNSS(PSS)
        'VI = LNVS(PSS)
        'frmDetalleAgenda.MOSTRAR(1, SUC, VI)
    End Sub

    Private Sub BTNMOSTRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMOSTRAR.Click
        Try
            OPCIONESBASE()
            CARGAMES()
            CARGADIA(MC.SelectionStart)
            CARGASEMANA()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'frmAyudaEstadoViaje.ShowDialog()
    End Sub
    Public Sub ACTUALIZARPORCAMBIO()
        '' METODO QUE SE EJECUTA CADA QUE MODIFICO UN VIAJE DESDE LA AGENDA
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        CARGAINICIO()
        CARGARVIAJES()
        INICIALIZAR()
        CBCAR.SelectedIndex = 0
        CBCHO.SelectedIndex = 0
        OPCIONESBASE()
        CARGAMES()
        CARGADIA(MC.SelectionStart)
        CARGASEMANA()
    End Sub
    Dim TAGDGV, SSUC, SVI As String
    Private Sub DGV3_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV3.CellDoubleClick
        'TAGDGV = DGV3.Item(DGV3.CurrentCell.ColumnIndex, DGV3.CurrentRow.Index).Tag
        'If String.IsNullOrEmpty(TAGDGV) Then
        '    Exit Sub
        'End If
        'Dim INI, FIN As Integer
        'INI = 1
        'FIN = TAGDGV.LastIndexOf("-")

        'SSUC = TAGDGV.Substring(INI, FIN - INI)
        'INI = FIN + 2
        'FIN = TAGDGV.Length
        'SVI = TAGDGV.Substring(INI, FIN - INI)
        'frmDetalleAgenda.MOSTRAR(1, SSUC, SVI)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV3.CellContentClick

    End Sub

    Private Sub DGV4_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV4.CellDoubleClick
        'TAGDGV = DGV4.Item(DGV4.CurrentCell.ColumnIndex, DGV4.CurrentRow.Index).Tag
        'If String.IsNullOrEmpty(TAGDGV) Then
        '    Exit Sub
        'End If
        'Dim INI, FIN As Integer
        'INI = 1
        'FIN = TAGDGV.LastIndexOf("-")

        'SSUC = TAGDGV.Substring(INI, FIN - INI)
        'INI = FIN + 2
        'FIN = TAGDGV.Length
        'SVI = TAGDGV.Substring(INI, FIN - INI)
        'frmDetalleAgenda.MOSTRAR(1, SSUC, SVI)
    End Sub

    Private Sub BTNACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACEPTAR.Click
        ACTUALIZARPORCAMBIO()
    End Sub
End Class