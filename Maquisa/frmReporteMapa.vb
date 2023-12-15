Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Public Class frmReporteMapa
    Dim LRUTA As New List(Of String)
    Dim LVEN As New List(Of String)

    Dim LTV As New List(Of GMapProvider)
    Dim PLG As PointLatLng
    Dim PUNTOCLIENTE As GMapMarker

    Dim OLINICIO As GMapOverlay
    Dim OLCLIENTE As GMapOverlay
    Dim OVERLAYRUTAS As GMapOverlay
    Dim OLDETALLE As GMapOverlay
    Dim DT As New DataTable

    Private Sub frmReporteMapa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me, frmPrincipal.COLORFUENTE)
        Me.Icon = frmPrincipal.Icon
        OPLlenaComboBox(CBVEN, LVEN, "SELECT CLAVE,NOMBRE FROM VENDEDORES WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de seleccionar", "")
        OPLlenaComboBox(CBRUTA, LRUTA, "SELECT CLAVE,NOMBRE FROM RUTAS WHERE ACTIVO=1 ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Favor de seleccionar", "")
        RBVEN.Checked = True
        MuestraCombobox()

        OLINICIO = New GMapOverlay("MARCAS")
        OLCLIENTE = New GMapOverlay("CLIENTE")
        OVERLAYRUTAS = New GMapOverlay("CLIENTE")
        OLDETALLE = New GMapOverlay("DETALLE")

        LTV.Add(GMapProviders.GoogleMap)
        LTV.Add(GMapProviders.GoogleSatelliteMap)
        LTV.Add(GMapProviders.GoogleHybridMap)
        LTV.Add(GMapProviders.GoogleTerrainMap)




        CBTV.SelectedIndex = 0
        MAPA.ShowCenter = False
        MAPA.ReloadMap()
        MAPA.Refresh()

        CBTV.SelectedIndex = 0
        MAPA2.ShowCenter = False

        MAPA2.Refresh()

    End Sub
    Private Sub MuestraCombobox()
        LBLVENDEDOR.Visible = False
        CBVEN.Visible = False
        LBLRUTA.Visible = False
        CBRUTA.Visible = False

        If RBRUTA.Checked Then
            LBLRUTA.Visible = True
            CBRUTA.Visible = True
        End If

        If RBVEN.Checked Then
            LBLVENDEDOR.Visible = True
            CBVEN.Visible = True
        End If
    End Sub
    Private Sub CARGADATOS()
        Me.Cursor = Cursors.WaitCursor
        Try
            BDEjecutarSql("EXEC SPACTUALIZAICONGEOMARCA @INI,@FIN", frmPrincipal.CadenaConexion, DTDE.Value.Date, DTDE.Value.Date.AddDays(1))
            Dim QUERY As String
            QUERY = ""
            If RBVEN.Checked Then
                If CBVEN.SelectedIndex = 0 Then
                    Return
                End If
                QUERY = " Select D.FECHA,D.LATITUD,D.LONGITUD,D.Icon,TTT=T.NOMBRE +' '+ISNULL(C.NOMBRE,'')+' '+CONVERT(VARCHAR(10),D.FECHA,108),D.ID
                From GEOMARCAS D INNER JOIN TIPOSCHECK T
                ON D.TipoCheckId=T.Clave LEFT JOIN CLIENTES C
                ON D.ClientId=C.Clave Where VendedorId = " + LVEN(CBVEN.SelectedIndex) + " And FECHA >=@INI And FECHA<@FIN ORDER BY D.FECHA"
            End If
            If RBRUTA.Checked Then
                If CBRUTA.SelectedIndex = 0 Then
                    Return
                End If
                QUERY = "Select D.FECHA,D.LATITUD,D.LONGITUD,D.Icon,TTT=T.NOMBRE +' '+ISNULL(C.NOMBRE,'')+' '+CONVERT(VARCHAR(10),D.FECHA,108),D.ID
                From GEOMARCAS D INNER JOIN TIPOSCHECK T
                ON D.TipoCheckId=T.Clave LEFT JOIN CLIENTES C
                ON D.ClientId=C.ClaveWhere D.RUTA = " + LRUTA(CBRUTA.SelectedIndex) + " And FECHA >=@INI And FECHA<@FIN ORDER BY D.FECHA"
            End If

            DT = BDLlenaTabla(QUERY, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTDE.Value.Date.AddDays(1))


            DGV.DataSource = BDLlenaTabla(QUERY, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTDE.Value.Date.AddDays(1))
            DGV.Columns(5).Visible = False
            DGV.Columns(3).Visible = False
            DGV.Columns(2).Visible = False
            DGV.Columns(1).Visible = False
            DGV.Columns(0).Visible = False
            DgvAjusteEncabezado(DGV, 4)

            DGV.Refresh()
            EnrutarGrid()
        Catch ex As Exception

        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub EnrutarGrid()
        OLINICIO.Markers.Clear()
        OLCLIENTE.Markers.Clear()
        OVERLAYRUTAS.Routes.Clear()
        Dim x As Integer
        If DGV.RowCount < 2 Then
            Exit Sub
        End If

        Dim TTotal, DTotal As Double
        TTotal = 0
        DTotal = 0
        For x = 0 To DGV.RowCount - 2
            Dim PIni As New PointLatLng
            Dim PFin As New PointLatLng
            PIni.Lat = DGV.Item(1, x).Value
            PIni.Lng = DGV.Item(2, x).Value

            PFin.Lat = DGV.Item(1, x + 1).Value
            PFin.Lng = DGV.Item(2, x + 1).Value


            Dim ss As New GDirections
            GoogleMapProvider.Instance.ApiKey = My.Settings.GoogleMapProviderApiKey
            GMapProviders.GoogleMap.GetDirections(ss, PIni, PFin, False, False, False, False, False)
            If (ss Is Nothing) Then

                OLCLIENTE.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(PIni.Lat, PIni.Lng), Icon2GMarker(DGV.Item(3, x).Value)))
                OLCLIENTE.Markers(x).ToolTipText = vbNewLine + DGV.Item(4, x).Value.ToString


            Else

                TTotal += CType(ss.DurationValue, Double)
                DTotal += CType(ss.DistanceValue, Double)
                Dim GMR As New GMapRoute(ss.Route, "Mi Ruta")
                GMR.Duration = ss.DurationValue
                OVERLAYRUTAS.Routes.Add(GMR)
                BDEjecutarSql("UPDATE GEOMARCAS SET DISTANCIAMTS='" + ss.DistanceValue.ToString + "',DISTANCIA='" + ss.Distance.ToString + "',TIEMPOSEG ='" + ss.DurationValue.ToString + "',TIEMPO='" + ss.Duration.ToString + "',DireccionInicio='" + ss.StartAddress + "',DireccionFinal='" + ss.EndAddress + "' WHERE ID=" + DGV.Item(5, x).Value.ToString, frmPrincipal.CadenaConexion)
                OLCLIENTE.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(PIni.Lat, PIni.Lng), Icon2GMarker(DGV.Item(3, x).Value)))
                OLCLIENTE.Markers(x).ToolTipText = vbNewLine + DGV.Item(4, x).Value.ToString + vbNewLine + " T: " + ss.DurationValue.ToString + vbNewLine + " D: " + ss.DistanceValue.ToString

            End If

        Next
        OLCLIENTE.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(DGV.Item(1, DGV.RowCount - 1).Value, DGV.Item(2, DGV.RowCount - 1).Value), Icon2GMarker(DGV.Item(3, x).Value)))
        OLCLIENTE.Markers(DGV.RowCount - 1).ToolTipText = vbNewLine + DGV.Item(4, x).Value.ToString + vbNewLine + " Ultimo registro " + vbNewLine + "TT: " + TTotal.ToString + vbNewLine + " DT: " + DTotal.ToString
        'OLCLIENTE.Markers(DGV.RowCount - 1).ToolTipMode = MarkerTooltipMode.Always
        MAPA.Overlays.Add(OLINICIO)
        MAPA.Overlays.Add(OLCLIENTE)
        MAPA.Overlays.Add(OVERLAYRUTAS)
        MAPA.ZoomAndCenterRoutes("Mi Ruta")
        MAPA.RoutesEnabled = True
        MAPA.Refresh()
    End Sub

    Private Sub RefreshMap(ByVal GMP As GMap.NET.MapProviders.GMapProvider, ByVal ZOOM As Integer)
        MAPA.MapProvider = GMP
        MAPA.MinZoom = 3
        MAPA.MaxZoom = 17
        MAPA.Zoom = ZOOM
        MAPA.CanDragMap = True
        MAPA.Manager.Mode = AccessMode.ServerAndCache
        MAPA.Position = New PointLatLng(My.Settings.EmpresaLatitud, My.Settings.EmpresaLongitud)
        PosicionaEmpresa()

        MAPA2.MapProvider = GMP
        MAPA2.MinZoom = 3
        MAPA2.MaxZoom = 17
        MAPA2.Zoom = ZOOM
        MAPA2.CanDragMap = True
        MAPA2.Manager.Mode = AccessMode.ServerAndCache
    End Sub
    Private Sub PosicionaEmpresa()
        OLINICIO.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(My.Settings.EmpresaLatitud, My.Settings.EmpresaLongitud), GMarkerGoogleType.red_dot))
        MAPA.Overlays.Add(OLINICIO)
        MAPA.Overlays.Add(OLCLIENTE)
        MAPA.Overlays.Add(OVERLAYRUTAS)
    End Sub

    Private Sub RBVEN_CheckedChanged(sender As Object, e As EventArgs) Handles RBVEN.CheckedChanged
        MuestraCombobox()
    End Sub

    Private Sub RBRUTA_CheckedChanged(sender As Object, e As EventArgs) Handles RBRUTA.CheckedChanged
        MuestraCombobox()
    End Sub

    Private Sub BTNMOSTRAR_Click(sender As Object, e As EventArgs) Handles BTNMOSTRAR.Click
        If MAPA IsNot Nothing Then
            CARGADATOS()
        End If
    End Sub

    Private Sub CBTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTV.SelectedIndexChanged
        RefreshMap(LTV(CBTV.SelectedIndex), TBZOOM.Value)
    End Sub

    Private Sub TBZOOM_Scroll(sender As Object, e As EventArgs) Handles TBZOOM.Scroll
        RefreshMap(LTV(CBTV.SelectedIndex), TBZOOM.Value)
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        PosicionaDGV()
    End Sub

    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV.SelectionChanged
        PosicionaDGV()
    End Sub

    Private Sub PosicionaDGV()
        If DGV.RowCount <= 0 Then
            Return
        End If
        OLDETALLE.Clear()


        OLDETALLE.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(DGV.Item(1, DGV.CurrentRow.Index).Value, DGV.Item(2, DGV.CurrentRow.Index).Value), Icon2GMarker(DGV.Item(3, DGV.CurrentRow.Index).Value)))
        OLDETALLE.Markers(0).ToolTipText = vbNewLine + DGV.Item(4, DGV.CurrentRow.Index).Value.ToString
        MAPA2.Overlays.Add(OLDETALLE)
        MAPA2.RoutesEnabled = True
        MAPA2.Refresh()
    End Sub
End Class