Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Public Class frmUbicacionMapa
    Dim LTV As New List(Of GMapProvider)
    Dim PLG As PointLatLng
    Dim PUNTOCLIENTE As GMapMarker
    Dim MARCADO As Boolean
    Dim OLINICIO As GMapOverlay
    Dim OLCLIENTE As GMapOverlay
    Dim OVERLAYRUTAS As GMapOverlay
    Dim DCLI, NCLI As String
    Public Latitud, Longitud As Double
    Private Sub frmUbicacionMapa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPVisualizacionForm(Me)
        Me.Icon = frmPrincipal.Icon
        OLINICIO = New GMapOverlay("MARCAS")
        OLCLIENTE = New GMapOverlay("CLIENTE")
        OVERLAYRUTAS = New GMapOverlay("CLIENTE")

        LTV.Add(GMapProviders.GoogleMap)
        LTV.Add(GMapProviders.GoogleSatelliteMap)
        LTV.Add(GMapProviders.GoogleHybridMap)
        LTV.Add(GMapProviders.GoogleTerrainMap)
        MARCADO = False
        TXTDOM.Text = DCLI
        LBLCLI.Text = NCLI

        PosicionaEmpresa()
        CBTV.SelectedIndex = 0
        MAPA.ShowCenter = False
        MAPA.ReloadMap()
        MAPA.Refresh()
        If Latitud <> 0 And Longitud <> 0 Then
            MARCAR(Latitud, Longitud)
        End If
    End Sub

    Dim LDIR As New List(Of String)
    Dim LLAT As New List(Of String)
    Dim LLONG As New List(Of String)
    Public Sub Mostrar(ByVal vNCli As String, ByVal vDCli As String, ByVal vLatitud As Double, ByVal vLongitud As Double)
        NCLI = vNCli
        DCLI = vDCli
        TXTDOM.Text = DCLI
        Latitud = vLatitud
        Longitud = vLongitud
        If Latitud <> 0 And Longitud <> 0 Then
            Dim ULT As Integer
            DGV.Rows.Add(1)
            ULT = DGV.Rows.Count - 1
            DGV.Item(0, ULT).Value = Latitud
            DGV.Item(1, ULT).Value = Longitud
        End If


        Me.ShowDialog()
    End Sub
    Private Sub PosicionaEmpresa()
        OLINICIO.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(My.Settings.EmpresaLatitud, My.Settings.EmpresaLongitud), GMarkerGoogleType.red_dot))
        MAPA.Overlays.Add(OLINICIO)
        MAPA.Overlays.Add(OLCLIENTE)
        MAPA.Overlays.Add(OVERLAYRUTAS)
    End Sub
    Private Sub MARCAR(ByVal Lat As Double, ByVal Lng As Double)
        OLCLIENTE.Markers.Clear()
        OLCLIENTE.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(Lat, Lng), GMarkerGoogleType.green_dot))
        MARCADO = True
        Try
            ENRUTAR(OLINICIO.Markers(0).Position, New PointLatLng(Lat, Lng))
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ENRUTAR(ByVal Inicio As PointLatLng, ByVal Fin As PointLatLng)
        OVERLAYRUTAS.Routes.Clear()

        Dim ss As New GDirections
        GoogleMapProvider.Instance.ApiKey = My.Settings.GoogleMapProviderApiKey
        GMapProviders.GoogleMap.GetDirections(ss, Inicio, Fin, False, False, False, False, False)
        Dim GMR As New GMapRoute(ss.Route, "Mi Ruta")
        GMR.Duration = ss.DurationValue
        OVERLAYRUTAS.Routes.Clear()
        OVERLAYRUTAS.Routes.Add(GMR)
        MAPA.ZoomAndCenterRoutes("Mi Ruta")
        MAPA.RoutesEnabled = True
        MAPA.Refresh()
    End Sub
    Private Sub EnrutarGrid()
        Dim x As Integer
        If DGV.RowCount < 2 Then
            Exit Sub
        End If
        OLCLIENTE.Markers.Clear()
        OVERLAYRUTAS.Routes.Clear()
        Dim TTotal, DTotal As Double
        TTotal = 0
        DTotal = 0
        For x = 0 To DGV.RowCount - 2
            Dim PIni As New PointLatLng
            Dim PFin As New PointLatLng
            PIni.Lat = DGV.Item(0, x).Value
            PIni.Lng = DGV.Item(1, x).Value

            PFin.Lat = DGV.Item(0, x + 1).Value
            PFin.Lng = DGV.Item(1, x + 1).Value
            Dim ss As New GDirections
            GoogleMapProvider.Instance.ApiKey = My.Settings.GoogleMapProviderApiKey
            GMapProviders.GoogleMap.GetDirections(ss, PIni, PFin, False, False, False, False, False)
            TTotal += CType(ss.DurationValue, Double)
            DTotal += CType(ss.DistanceValue, Double)
            Dim GMR As New GMapRoute(ss.Route, "Mi Ruta")
            GMR.Duration = ss.DurationValue
            OVERLAYRUTAS.Routes.Add(GMR)
            If x = 0 Then
                OLCLIENTE.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(PIni.Lat, PIni.Lng), GMarkerGoogleType.pink_pushpin))
                OLCLIENTE.Markers(x).ToolTipText = "Inicio " + Chr(13) + " T: " + ss.DurationValue.ToString + Chr(12) + " D: " + ss.DistanceValue.ToString
            Else
                OLCLIENTE.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(PIni.Lat, PIni.Lng), GMarkerGoogleType.green_dot))
                OLCLIENTE.Markers(x).ToolTipText = "cliente " + (x).ToString + "/n T: " + ss.DurationValue.ToString + "/n D: " + ss.DistanceValue.ToString
            End If
        Next
        OLCLIENTE.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(DGV.Item(0, DGV.RowCount - 1).Value, DGV.Item(1, DGV.RowCount - 1).Value), GMarkerGoogleType.yellow_big_pause))
        OLCLIENTE.Markers(DGV.RowCount - 1).ToolTipText = "Final " + "/n TT: " + TTotal.ToString + "/n DT: " + DTotal.ToString
        OLCLIENTE.Markers(DGV.RowCount - 1).ToolTipMode = MarkerTooltipMode.Always
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
    End Sub

    Private Sub CBTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTV.SelectedIndexChanged
        RefreshMap(LTV(CBTV.SelectedIndex), TBZOOM.Value)
    End Sub

    Private Sub TBZOOM_Scroll(sender As Object, e As EventArgs) Handles TBZOOM.Scroll
        RefreshMap(LTV(CBTV.SelectedIndex), TBZOOM.Value)
    End Sub

    Private Sub MAPA_Click(sender As Object, e As EventArgs) Handles MAPA.Click
        Dim ULT As Integer
        Dim hj As MouseEventArgs = CType(e, MouseEventArgs)
        If hj.Button = Windows.Forms.MouseButtons.Left Then
            OVERLAYRUTAS.Routes.Clear()
            OLCLIENTE.Markers.Clear()
            Me.Cursor = Cursors.WaitCursor
            PLG = MAPA.FromLocalToLatLng(hj.X, hj.Y)
            DGV.Rows.Add(1)
            ULT = DGV.Rows.Count - 1
            DGV.Item(0, ULT).Value = PLG.Lat
            DGV.Item(1, ULT).Value = PLG.Lng
            MARCAR(PLG.Lat, PLG.Lng)
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub GUARDARIMAGEN(ByVal NM As Integer)
        'Dim bmp As Bitmap
        'Dim c, d As Control
        'c = MAPA
        'd = LBLIMG
        'bmp = New System.Drawing.Bitmap(c.Width, c.Height)
        'c.DrawToBitmap(bmp, c.ClientRectangle)
        'If NM = 1 Then
        '    LBLIMG.Image = bmp
        '    LBLIMG.SizeMode = PictureBoxSizeMode.StretchImage
        'Else
        '    LBLIMG2.Image = bmp
        '    LBLIMG2.SizeMode = PictureBoxSizeMode.StretchImage
        'End If
    End Sub

    Private Sub TXTDOM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDOM.KeyPress
        If e.KeyChar = Chr(13) Then
            If String.IsNullOrEmpty(TXTDOM.Text) Then
            Else
                BUSCADOMICILIO(TXTDOM.Text)
            End If

        End If
    End Sub
    Private Sub BUSCADOMICILIO(ByVal DOM As String)
        Me.Cursor = Cursors.WaitCursor
        Dim LEC As SqlClient.SqlDataReader
        Try
            MAPA.ReloadMap()
            Dim R As String
            R = 0
            Dim SQL As New SqlClient.SqlCommand("SELECT DBO.DGG(@URL)", frmPrincipal.CONX)
            SQL.Parameters.Add("@URL", SqlDbType.VarChar).Value = DOM

            LEC = SQL.ExecuteReader
            If LEC.Read Then
                If LEC(0) Is DBNull.Value Then
                    R = ""
                Else
                    R = LEC(0)
                End If
            End If
            LEC.Close()
            SACARRESULTADOS(R)
            MAPA.ReloadMap()
        Catch ex As Exception
            LEC.Close()
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub SACARRESULTADOS(ByVal RESULTADO As String)
        If RESULTADO.Length < 8 Then
            Exit Sub
        End If
        LDIR.Clear()
        LLAT.Clear()
        LLONG.Clear()
        Dim TH As Boolean
        TH = False
        Dim TEM As String
        Dim CONT, INI, FIN, INIP, FINP, INIL, FINL As Integer
        INIP = 0
        FINP = 0
        CONT = 0


        Dim PARTERES, PARTELOC As String

        Do
            INIP = RESULTADO.LastIndexOf("<result>")
            FINP = RESULTADO.LastIndexOf("</result>")
            If FINP > 0 Then
                CONT = 1
                PARTERES = RESULTADO.Substring(INIP, FINP - INIP + 9)
                TH = True
                INI = PARTERES.LastIndexOf("<formatted_address>")
                FIN = PARTERES.LastIndexOf("</formatted_address>")
                TEM = PARTERES.Substring(INI + 19, FIN - (INI + 19))
                LDIR.Add(TEM)

                INIL = PARTERES.LastIndexOf("<location>")
                FINL = PARTERES.LastIndexOf("</location>")
                PARTELOC = PARTERES.Substring(INIL, FINL - INIL + 10)

                INI = PARTELOC.LastIndexOf("<lat>")
                FIN = PARTELOC.LastIndexOf("</lat>")
                TEM = PARTELOC.Substring(INI + 5, FIN - (INI + 5))
                LLAT.Add(TEM)

                INI = PARTELOC.LastIndexOf("<lng>")
                FIN = PARTELOC.LastIndexOf("</lng>")
                TEM = PARTELOC.Substring(INI + 5, FIN - (INI + 5))
                LLONG.Add(TEM)
                RESULTADO = RESULTADO.Remove(INIP, FINP - INIP + 9)
            Else
                TH = False
            End If
        Loop While TH = True
        If CONT = 0 Then
            INI = RESULTADO.LastIndexOf("<status>")
            FIN = RESULTADO.LastIndexOf("</status>")
            TEM = RESULTADO.Substring(INI + 8, FIN - (INI + 8))
            MessageBox.Show(TEM, "No hay Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim X As Integer
        CBDIR.Items.Clear()
        For X = 0 To LDIR.Count - 1
            CBDIR.Items.Add(LDIR(X))
        Next
        If CBDIR.Items.Count > 0 Then
            CBDIR.SelectedIndex = 0
        End If
    End Sub

    Private Sub CBDIR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBDIR.SelectedIndexChanged
        OVERLAYRUTAS.Routes.Clear()
        OLCLIENTE.Markers.Clear()
        PLG.Lat = LLAT(CBDIR.SelectedIndex)
        PLG.Lng = LLONG(CBDIR.SelectedIndex)
        MARCAR(PLG.Lat, PLG.Lng)
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If DGV.RowCount <= 0 Then
            Return
        Else
            Latitud = DGV.Item(0, DGV.CurrentRow.Index).Value
            Longitud = DGV.Item(1, DGV.CurrentRow.Index).Value
            Me.DialogResult = DialogResult.Yes
            Me.Close()
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        GUARDARIMAGEN(1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        GUARDARIMAGEN(2)
    End Sub
End Class
