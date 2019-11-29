Module Mensajes
    Public Function deseaEliminar()
        Dim respuesta As Integer = MsgBox("Esta seguro que desea eliminar?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Advertencia")
        Return respuesta
    End Function

    Public Function deseaModificar()
        Dim respuesta As Integer = MsgBox("Esta seguro que desea guardar los cambios?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Advertencia")
        Return respuesta
    End Function

    Public Function deseaSalir()
        Dim respuesta As Integer = MsgBox("Esta seguro que desea salir?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Aviso")
        Return respuesta
    End Function

    Public Sub mostrarAviso(ByVal mensaje As String)
        MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub mostrarError(ByVal mensaje As String)
        MessageBox.Show(mensaje, "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Module
