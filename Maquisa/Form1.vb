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
    Dim VERSION As String
    Dim LIGA As String
    Public IP As String
    Public DTRIFA As New DataTable
    Public LTIC As New List(Of String)
    Dim RES As Boolean
    Public VCFD As String
    Public Sistema, EmisorBase As String
    Public Direccion As String
    Public Perfil As Integer

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ciudad = "Mazatlán, Sin."
        IP = "structureserver2.noip.me"
        VERSION = "BETA"
        Sistema = "Maquisa"
        CadenaConexion = "Data Source=" + IP + ",1433;Network Library=DBMSSOCN;Initial Catalog=MAQUISA;User ID=MarosILocal;Password=Loco*1234"
        CONX.ConnectionString = CadenaConexion
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
        CentrarLogo(PBCNC.Width, PBCNC.Height)
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
End Class
