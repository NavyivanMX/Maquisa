Public Class Mensajes

    Public Sub New()

    End Sub

    Public Function mensaje_informacion(ByVal mensaje As String)
        MessageBox.Show(mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Function

    Public Function mensaje_advertencia(ByVal mensaje As String)
        MessageBox.Show(mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Function

    Public Function mensaje_error(ByVal mensaje As String)
        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Function

    Public Function mensaje_confirmacion(ByVal mensaje As String) As Short
        Dim respuesta As Short
        respuesta = MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Return respuesta
    End Function

End Class
