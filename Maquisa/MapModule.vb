﻿Module MapModule

    Public Function Icon2GMarker(ByVal Icon As Integer) As GMap.NET.WindowsForms.Markers.GMarkerGoogleType
        Select Case Icon
            Case 1
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.arrow
            Case 2
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue
            Case 3
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_small
            Case 4
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_dot
            Case 5
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin
            Case 6
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.brown_small
            Case 7
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.gray_small
            Case 8
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green
            Case 9
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green_small
            Case 10
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green_dot
            Case 11
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green_pushpin
            Case 12
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green_big_go
            Case 13
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.yellow
            Case 14
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.yellow_small
            Case 15
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.yellow_dot
            Case 16
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.yellow_big_pause
            Case 17
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.yellow_pushpin
            Case 18
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.lightblue
            Case 19
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.lightblue_dot
            Case 20
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.lightblue_pushpin
            Case 21
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.orange
            Case 22
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.orange_small
            Case 23
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.orange_dot
            Case 24
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.pink
            Case 25
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.pink_dot
            Case 26
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.pink_pushpin
            Case 27
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.purple
            Case 28
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.purple_small
            Case 29
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.purple_dot
            Case 30
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.purple_pushpin
            Case 31
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red
            Case 32
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_small
            Case 33
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot
            Case 34
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_pushpin
            Case 35
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_big_stop
            Case 36
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.black_small
            Case 37
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.white_small
            Case Else
                Return GMap.NET.WindowsForms.Markers.GMarkerGoogleType.none
        End Select

    End Function

End Module