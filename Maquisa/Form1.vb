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

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SB.Items(1).Text = "Maquisa   " + Format(Now, "hh:mm:ss tt")
    End Sub
End Class
