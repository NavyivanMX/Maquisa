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

        LTV.Add(GMapProviders.GoogleMap)
        LTV.Add(GMapProviders.GoogleSatelliteMap)
        LTV.Add(GMapProviders.GoogleHybridMap)
        LTV.Add(GMapProviders.GoogleTerrainMap)
        MAPA.Overlays.Add(OLINICIO)
        CBTV.SelectedIndex = 0
        MAPA.ShowCenter = False
        MAPA.ReloadMap()e 
        MAPA.Refresh()

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
        Dim QUERY As String
        QUERY = ""
        If RBVEN.Checked Then
            If CBVEN.SelectedIndex = 0 Then
                Return
            End If
            QUERY = " Select D.FECHA,D.LATITUD,D.LONGITUD,D.Icon From GEOMARCAS D Where VendedorId = " + LVEN(CBVEN.SelectedIndex) + " And FECHA >=@INI And FECHA<@FIN ORDER BY D.FECHA"
        End If
        If RBRUTA.Checked Then
            If CBRUTA.SelectedIndex = 0 Then
                Return
            End If
            QUERY = "Select D.FECHA,D.LATITUD,D.LONGITUD,D.Icon From GEOMARCAS D Where D.RUTA = " + LRUTA(CBRUTA.SelectedIndex) + " And FECHA >=@INI And FECHA<@FIN ORDER BY D.FECHA"
        End If
        Dim DT As New DataTable
        DT = BDLlenaTabla(QUERY, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTDE.Value.Date.AddDays(1))
        OLINICIO.Markers.Clear()

        Dim x As Integer
        For x = 0 To DT.Rows.Count - 1
            OLINICIO.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(DT.Rows(x).Item(1), DT.Rows(x).Item(2)), Icon2GMarker(DT.Rows(x).Item(3))))
        Next
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
        CARGADATOS()
    End Sub

    Private Sub CBTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTV.SelectedIndexChanged
        RefreshMap(LTV(CBTV.SelectedIndex), TBZOOM.Value)
    End Sub

    Private Sub TBZOOM_Scroll(sender As Object, e As EventArgs) Handles TBZOOM.Scroll
        RefreshMap(LTV(CBTV.SelectedIndex), TBZOOM.Value)
    End Sub
End Class