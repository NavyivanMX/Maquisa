Public Class frmPrincipal
    Public CONX As New SqlClient.SqlConnection
    Public CadenaConexion As String
    Public SucursalBase As String
    Public Regimen As String
    Public Serie As String
    Public NivelBase, Tipo As Integer
    Public NombreSucursal As String
    Public Empresa As String
    Public NombreComun As String
    Public Usuario As String
    Public Ciudad As String
    Public PagoTarjeta As Boolean
    Public CorteXX As Boolean
    Dim VERSION, BD, USER, PASS As String
    Dim LIGA As String
    Public IP As String
    Public DTRIFA As New DataTable
    Public LTIC As New List(Of String)
    Dim RES As Boolean
    Public VCFD As String
    Public Sistema, EmisorBase As String
    Public Direccion As String
    Public Perfil As Integer


    Public COLORFUENTE As System.Drawing.Color

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ciudad = "Mazatlán, Sin."
         IP = "structureserver2.noip.me"
        BD = "MAQUISA"
        USER = "MAROSILOCAL"
        PASS = "Loco*1234"
        Empresa = 1
        VERSION = "1.8"
        Sistema = "MAQUISA"
        'COLORFUENTE = My.Settings.COLORDEFAULT
        COLORFUENTE = Color.Black
        CENTRARHORIZONTALABEL(LBLV)

        If BD <> "MAQUISA" Then
            LBLPRU.Visible = True
            CENTRARHORIZONTALABEL(LBLV)
        End If

        LBLV.Text = "Versión " + VERSION


        CadenaConexion = "Data Source=" + IP + ",1433;Network Library=DBMSSOCN;Initial Catalog=" + BD + ";User ID=" + USER + ";Password=" + PASS + ""
        CONX.ConnectionString = CadenaConexion



        If Not CHECACONX() Then
            Dim VAYU As New frmAyuda
            VAYU.Show()
            MessageBox.Show("No se puede Conectar con el Servidor, Intente en un Momento Por Favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        Else
            INICIAR()
        End If

    End Sub




    Private Sub INICIAR()
        PonerFondo()
        If VERIFICAVERSION() Then
            If Not VERIFICAUBICACION() Then
                Me.Close()
                Exit Sub
            End If
            Dim vSes As New frmLogin2
            vSes.ShowDialog()
            If vSes.DialogResult = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("Bienvenido al Sistema Control de Flotilla MAQUISA Bernal y Valdez: " + Usuario, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)



            Else
                Me.Close()
            End If
        Else
            frmLigaVersion.MOSTRAR(LIGA, "C:\NUEVAVERSION\MAQUISA.RAR", "Actualización MAQUISA")
            Me.Close()
        End If
    End Sub


    Private Function VERIFICAVERSION() As Boolean
        Try

            Dim VER As String
            Dim SQL As New SqlClient.SqlCommand("Select VERSION,LIGA FROM VERSIONES WHERE SISTEMA='WIN'", Me.CONX)
            Dim LEC As SqlClient.SqlDataReader
            LEC = SQL.ExecuteReader
            If LEC.Read Then
                VER = LEC(0)
                LIGA = LEC(1)
                LEC.Close()
                If VER = VERSION Then
                    Return True
                Else
                    Return False
                End If
            Else
                LEC.Close()
                Return False
            End If
        Catch ex As Exception
            Return True
        End Try
    End Function
    Private Function VERIFICAUBICACION() As Boolean
        Return True
        Dim FL As New System.IO.FileInfo(Application.ExecutablePath)
        Dim ORIGEN As String

        ORIGEN = FL.DirectoryName + "\MAQUISA.exe"
        If FL.DirectoryName <> "C:\" Then
            MessageBox.Show("El archivo NO se encuentra en la unidad disco local C: se creará una copia, favor de cerrar todas las aplicaciones", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Try

                System.IO.File.Delete("C:\MAQUISA.exe")
            Catch ex As Exception

            End Try

            System.IO.File.Copy(ORIGEN, "C:\MAQUISA.exe")
            Try
                System.IO.File.Delete(ORIGEN)
            Catch ex As Exception

            End Try

            CreateShortCut("Acceso Directo a Camaronera", "C:\MAQUISA.exe", True)
            Return False
        End If
        Return True
    End Function
    Private Sub CreateShortCut(ByVal strLinkName_ As String, ByVal strTargetPath_ As String _
              , ByVal blnDesktop_ As Boolean, Optional ByVal strPath_ As String = "" _
              , Optional ByVal strArguments_ As String = "" _
              , Optional ByVal strDescription_ As String = "" _
              , Optional ByVal strHotKey_ As String = "" _
              , Optional ByVal strIconLocation_ As String = "" _
              , Optional ByVal strWorkingDirectory_ As String = "")

        Dim shell As Object = CreateObject("WScript.shell")
        Dim link As Object

        If blnDesktop_ Then
            Dim DesktopPath As Object = shell.SpecialFolders("Desktop")
            link = shell.CreateShortcut _
               (DesktopPath & "\" & strLinkName_ & ".lnk")
        Else
            link = shell.CreateShortcut _
               (strPath_ & "\" & strLinkName_ & ".lnk")
        End If
        Try
            With link
                ' Argumentos
                .Description = strLinkName_              ' Nombre del Acceso directo
                .TargetPath = strTargetPath_             ' Destino
                .WindowStyle = 1                         ' Ejecutar
                .Save()
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click

    End Sub

    Private Sub S5_Click(sender As Object, e As EventArgs) Handles S5.Click
        Dim VCLI As New frmClientes
        VCLI.ShowDialog()
    End Sub
    Private Sub CentrarLogo(ByVal Ancho As Integer, ByVal Largo As Integer)
        '217, 329
        Dim AP, LP, PIA, PIL As Integer
        AP = Me.Size.Width
        LP = Me.Size.Height

        PIA = ((AP - Ancho) / 2) - 25
        PIL = ((LP - Largo) / 2) - 20

        Dim POS As System.Drawing.Point
        POS.X = PIA
        POS.Y = PIL
        PBCNC.Location = POS
    End Sub

    Private Sub frmPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'CentrarLogo(PBCNC.Width, PBCNC.Height)    ****POR LO PRONTO NO CENTRAREMOS LOGO
    End Sub

    Private Sub RutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RutaToolStripMenuItem.Click
        Dim ARUTA As New frmRutas
        ARUTA.ShowDialog()
    End Sub

    Private Sub ItinerarioRutasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItinerarioRutasToolStripMenuItem.Click
        Dim MITINERARIO As New frmItinerarioRuta
        MITINERARIO.ShowDialog()
    End Sub

    Private Sub CambiarFondoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarFondoToolStripMenuItem.Click
        Dim URL As String
        Dim ofd As New OpenFileDialog
        ofd.Title = "Buscar archivo de imagen *.png"
        ofd.DefaultExt = ".png"
        'ofd.Filter = "Archivo Imagen (*.jpg)|*.jpg"
        ofd.Filter = "Archivos de Imagen (*.png)|*.png|" + Chr(34) + "Archivos de Imagen (*.jpg)|*.jpg|" + Chr(34) + "Archivos de Imagen (*.jpeg)|*.jpeg|" + Chr(34) + "Todos los archivos(*.*)|*.*;"
        ofd.FilterIndex = 1
        ofd.FileName = ""
        URL = ""
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.RutaFondo = ofd.FileName
            My.Settings.Save()
        End If
        PonerFondo()
    End Sub
    Public Sub PonerFondo()
        If My.Settings.RutaFondo <> "" Then
            Try
                Me.BackgroundImage = Image.FromFile(My.Settings.RutaFondo)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub MapaVendedorRutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapaVendedorRutaToolStripMenuItem.Click
        Dim VMVR As New frmReporteMapa
        VMVR.ShowDialog()
    End Sub

    Private Sub ContactoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactoClienteToolStripMenuItem.Click
        Dim VCC As New frmContactoCliente
        VCC.ShowDialog()
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem.Click
        Dim VMAGE As New frmAgendaVisita
        VMAGE.ShowDialog()
    End Sub

    Private Sub AgendarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendarToolStripMenuItem.Click
        Dim VAVIS As New frmAgendar
        VAVIS.ShowDialog()
    End Sub

    Private Sub MapaClientesEnRutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapaClientesEnRutaToolStripMenuItem.Click
        Dim VRMC As New frmRutaMapaClientes
        VRMC.ShowDialog()
    End Sub

    Private Sub S1_Click(sender As Object, e As EventArgs) Handles S1.Click
        frmEmpresa.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SB.Items(1).Text = "Maquisa   " + Format(Now, "hh:mm:ss tt")
    End Sub



    Public Function CHECACONX() As Boolean
        If Me.CONX.State = ConnectionState.Closed Or Me.CONX.State = ConnectionState.Broken Then
            Try
                Me.CONX.Open()
            Catch ex As Exception
                MessageBox.Show("La conexión NO esta realizada, la informacion no se ha procesado, intente en un momento por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End Try
        End If
        Return True
    End Function

    Private Sub S2_Click(sender As Object, e As EventArgs) Handles S2.Click
        Dim AVEND As New frmVendedor
        AVEND.ShowDialog()
    End Sub



    Private Sub S4_Click(sender As Object, e As EventArgs) Handles S4.Click
        Dim AUSU As New frmUsuarios
        AUSU.ShowDialog()
    End Sub
End Class
