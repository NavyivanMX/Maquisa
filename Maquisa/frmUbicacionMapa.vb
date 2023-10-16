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
        OVERLAYRUTAS.Routes.Clear()
        OLCLIENTE.Markers.Clear()
        Inicializar()
        CBTV.SelectedIndex = 0
        MAPA.ShowCenter = False
        MAPA.ReloadMap()
        MAPA.Refresh()
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
        Me.ShowDialog()
    End Sub
    Private Sub Inicializar()
        Dim LAT, LON As Double
        LAT = 25.792519
        LON = -108.980947
        ''OLINICIO.Markers.Add(New GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed(New PointLatLng(LAT, LON)))
        OLINICIO.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(LAT, LON), GMarkerGoogleType.red_dot))
        MAPA.Overlays.Add(OLINICIO)
        MAPA.Overlays.Add(OLCLIENTE)
        MAPA.Overlays.Add(OVERLAYRUTAS)
    End Sub
    Private Sub MARCAR()
        OLCLIENTE.Markers.Clear()
        Inicializar()
        'Dim cde As New PointLatLng
        'cde.Lat = 1
        'cde.Lng = 2
        'Dim abc As GMapMarker
        'abc = New GMapMarker(New PointLatLng(1, 2))
        'abc.Position = cde

        'PUNTOCLIENTE = New GMapMarkerGoogleGreen(PLG)
        'OLCLIENTE.Markers.Add(PUNTOCLIENTE)
        OLCLIENTE.Markers.Add(New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(PLG.Lat, PLG.Lng), GMarkerGoogleType.green_dot))

        MARCADO = True
        Try
            ENRUTAR()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ENRUTAR()
        'Dim ss As New GDirections
        'GoogleMapProvider.Instance.ApiKey = My.Settings.GoogleMapProviderApiKey
        'GMapProviders.GoogleMap.GetDirections(ss, OLINICIO.Markers(0).Position, OLCLIENTE.Markers(OLCLIENTE.Markers.Count - 1).Position, False, False, False, False, False)
        'Dim GMR As New GMapRoute(ss.Route, "Mi Ruta")
        'GMR.Duration = ss.DurationValue
        'OVERLAYRUTAS.Routes.Clear()
        'OVERLAYRUTAS.Routes.Add(GMR)
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
        MAPA.Position = New PointLatLng(25.792519, -108.980947)
        Inicializar()
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
            MARCAR()
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub GUARDARIMAGEN(ByVal NM As Integer)
        Dim bmp As Bitmap
        Dim c, d As Control
        c = MAPA
        d = LBLIMG
        bmp = New System.Drawing.Bitmap(c.Width, c.Height)
        c.DrawToBitmap(bmp, c.ClientRectangle)
        If NM = 1 Then
            LBLIMG.Image = bmp
            LBLIMG.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            LBLIMG2.Image = bmp
            LBLIMG2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
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
            'Dim url As String
            'url = "https://maps.googleapis.com/maps/api/geocode/xml?key=GOOGLEPROYECTOAPIKEY=" & DOM
            'url = "https://maps.googleapis.com/maps/api/geocode/xml?key=GOOGLEPROYECTOAPIKEY=" & DOM
            'Dim request As System.Net.WebRequest = WebRequest.Create(url)
            'Dim response As HttpWebResponse = request.GetResponse()
            Dim R As String
            R = 0
            'Dim postData As String
            'postData = ""
            'Dim encodingUTF8 As New System.Text.UTF8Encoding
            'Dim postreq As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest) 'original
            'postreq.Timeout = 3000
            'postreq.Method = "POST"
            'postreq.KeepAlive = True
            'Dim postreqstream As Stream = postreq.GetRequestStream
            'postreqstream.Write(encodingUTF8.GetBytes(postData), 0, postData.Length)
            'postreqstream.Close()
            'Dim postResponse As HttpWebResponse
            'postResponse = DirectCast(postreq.GetResponse(), HttpWebResponse)
            'Dim posrreqreader As New StreamReader(postResponse.GetResponseStream())
            'Dim response2 As String = posrreqreader.ReadToEnd
            'R = response2
            Dim SQL As New SqlClient.SqlCommand("SELECT DBO.DGG(@URL)", frmPrincipal.CONX)
            SQL.Parameters.Add("@URL", SqlDbType.VarChar).Value = DOM

            LEC = SQL.ExecuteReader
            If LEC.Read Then
                If LEC(0) Is DBNull.Value Then
                    R = ""
                Else
                    R = LEC(0)
                End If
                'R = LEC(0)
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
        'Dim xDoc As XmlDocument
        'Dim xNodo As XmlNodeList
        'Dim xAtt As XmlElement
        'Dim IND As Integer
        'Dim A, B, C As String
        ''xDoc = New XmlDocument
        'xDoc.Load("C:/DIRECCION2.XML")
        'Try

        '    Dim xmlConfig As XmlDocument
        '    Dim m_nodelist As XmlNodeList
        '    Dim m_node As XmlNode
        '    'Creamos el “XML Document”
        '    xmlConfig = New XmlDocument()
        '    'Cargamos el archivo
        '    xmlConfig.Load("C:/DIRECCION2.XML")
        '    'Obtenemos la lista de los nodos “id”
        '    m_nodelist = xmlConfig.GetElementsByTagName("lat")
        '    'Iniciamos el ciclo de lectura
        '    For Each m_node In m_nodelist
        '        'Obtenemos el atributo del codigo
        '        'Dim mCodigo As String = m_node.Attributes.GetNamedItem("location").Value
        '        'Obtenemos el Elemento Hora
        '        LLAT.Add(m_node.ChildNodes.Item(0).InnerText)
        '        'Obtenemos el Elemento Minuto
        '        'LLONG.Add(m_node.ChildNodes.Item(1).InnerText)
        '    Next
        '    m_nodelist = xmlConfig.GetElementsByTagName("lng")
        '    'Iniciamos el ciclo de lectura
        '    For Each m_node In m_nodelist
        '        'Obtenemos el atributo del codigo
        '        'Dim mCodigo As String = m_node.Attributes.GetNamedItem("location").Value
        '        'Obtenemos el Elemento Hora
        '        LLONG.Add(m_node.ChildNodes.Item(0).InnerText)
        '        'Obtenemos el Elemento Minuto
        '        'LLONG.Add(m_node.ChildNodes.Item(1).InnerText)
        '    Next
        '    m_nodelist = xmlConfig.GetElementsByTagName("formatted_address")
        '    'Iniciamos el ciclo de lectura
        '    For Each m_node In m_nodelist
        '        'Obtenemos el atributo del codigo
        '        'Dim mCodigo As String = m_node.Attributes.GetNamedItem("location").Value
        '        'Obtenemos el Elemento Hora
        '        LDIR.Add(m_node.ChildNodes.Item(0).InnerText)
        '        'Obtenemos el Elemento Minuto
        '        'LLONG.Add(m_node.ChildNodes.Item(1).InnerText)
        '    Next
        'Catch ex As Exception
        'End Try

        'Dim m_xmlr As XmlTextReader

        ''Creamos el XML Reader
        'm_xmlr = New XmlTextReader("C:/DIRECCION2.XML")
        ''Desabilitamos las lineas en blanco, 
        ''ya no las necesitamos
        'm_xmlr.WhitespaceHandling = WhitespaceHandling.None
        ''Leemos el archivo y avanzamos al tag de usuarios
        'm_xmlr.Read()
        ''Leemos el tag usuarios
        'm_xmlr.Read()
        ''Creamos la secuancia que nos permite 
        ''leer el archivo
        'While Not m_xmlr.EOF
        '    'Avanzamos al siguiente tag
        '    m_xmlr.Read()
        '    'si no tenemos el elemento inicial 
        '    'debemos salir del ciclo
        '    If Not m_xmlr.IsStartElement() Then
        '        Exit While
        '    End If
        '    'Obtenemos el elemento codigo
        '    LLAT.Add(m_xmlr.GetAttribute("lat"))
        '    'Read elements firstname and lastname
        '    m_xmlr.Read()
        '    'Obtenemos el elemento del Nombre del Usuario
        '    LLONG.Add(m_xmlr.ReadElementString("lng"))
        '    'Obtenemos el elemento del Apellido del Usuario
        '    LDIR.Add(m_xmlr.ReadElementString("formatted_address"))
        'End While
        ''Cerramos la lactura del archivo
        'm_xmlr.Close()
        ''xDoc = New XmlDocument
        'xDoc.Load("C:/DIRECCION2.XML")


        'xNodo = xDoc.GetElementsByTagName("lat")
        'If xNodo.Count > 0 Then
        '    For Each xAtt In xNodo
        '        A = xAtt.Value
        '        LLAT.Add(A)
        '    Next
        'End If
        'xNodo = xDoc.GetElementsByTagName("lng")
        'If xNodo.Count > 0 Then
        '    For Each xAtt In xNodo
        '        B = xAtt.Value
        '        LLONG.Add(B)
        '    Next
        'End If
        'xNodo = xDoc.GetElementsByTagName("formatted_address")
        'If xNodo.Count > 0 Then
        '    For Each xAtt In xNodo
        '        C = xAtt.Value
        '        LDIR.Add(C)
        '    Next
        'End If

        'Dim reader As XmlTextReader = New XmlTextReader("C:/DIRECCION2.XML")

        'Do While (reader.Read())
        '    If reader.Name = "formatted_address" Then
        '        LDIR.Add(reader.Value)
        '    End If
        '    If reader.Name = "lat" Then
        '        LLAT.Add(reader.Value)
        '    End If
        '    If reader.Name = "lng" Then
        '        LLONG.Add(reader.Value)
        '    End If
        '    Select Case reader.NodeType
        '        Case XmlNodeType.Element 'Mostrar comienzo del elemento.

        '            If reader.HasAttributes Then 'If attributes exist

        '                While reader.MoveToNextAttribute()

        '                End While
        '            End If
        '        Case XmlNodeType.Text 'Mostrar el texto de cada elemento.
        '        Case XmlNodeType.EndElement 'Mostrar final del elemento.

        '    End Select
        'Loop






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
        MARCAR()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        GUARDARIMAGEN(1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        GUARDARIMAGEN(2)
    End Sub
End Class
