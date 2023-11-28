Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers

Public Class frmRutaMapaClientes
    Dim DT As New DataTable
    Dim LRUTA As New List(Of String)
    Dim LVEN As New List(Of String)

    Dim LTV As New List(Of GMapProvider)
    Dim PLG As PointLatLng
    Dim PUNTOCLIENTE As GMapMarker

    Dim OLINICIO As GMapOverlay
    Dim OLCLIENTE As GMapOverlay
    Dim OVERLAYRUTAS As GMapOverlay
    Private Sub frmRutaMapaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me)
        Me.Icon = frmPrincipal.Icon

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
        CARGADATOS()
        MAPA.ReloadMap()
        MAPA.Refresh()

    End Sub
    Private Sub CARGADATOS()
        DT = BDLlenaTabla("SELECT D.RUTA,R.NOMBRE NOMBRERUTA,D.CLIENTE,C.NOMBRE NOMBRECLIENTE,C.Latitud,C.Longitud
FROM ITINERARIORUTA D INNER JOIN RUTAS R
ON D.RUTA=R.Clave INNER JOIN CLIENTES C
ON D.CLIENTE=C.Clave", frmPrincipal.CadenaConexion)
        OLINICIO.Markers.Clear()

        Dim x As Integer
        For x = 0 To DT.Rows.Count - 1
            OLINICIO.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(DT.Rows(x).Item(4), DT.Rows(x).Item(5)), Icon2GMarker(DT.Rows(x).Item(0))))
            OLINICIO.Markers(x).ToolTipText = DT.Rows(x).Item(3).ToString
        Next

    End Sub

    Private Sub CBTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTV.SelectedIndexChanged
        RefreshMap(LTV(CBTV.SelectedIndex), TBZOOM.Value)
    End Sub
    Private Sub RefreshMap(ByVal GMP As GMap.NET.MapProviders.GMapProvider, ByVal ZOOM As Integer)
        MAPA.MapProvider = GMP
        MAPA.MinZoom = 3
        MAPA.MaxZoom = 17
        MAPA.Zoom = ZOOM
        MAPA.CanDragMap = True
        MAPA.Manager.Mode = AccessMode.ServerAndCache
        MAPA.Position = New PointLatLng(My.Settings.EmpresaLatitud, My.Settings.EmpresaLongitud)
        'PosicionaEmpresa()
    End Sub
End Class