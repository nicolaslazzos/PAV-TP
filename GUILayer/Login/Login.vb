Public Class frmLogin
    Dim flagSalir As Boolean = True

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Focus()
    End Sub
    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim str As String
        Dim tabla As DataTable

        If txtUsuario.Text = String.Empty Or txtPassword.Text = String.Empty Then
            Mensajes.mostrarError("Olvido ingresar usuario y/o contraseña")
        Else
            str = "SELECT u.idAvatar, p.nombre AS Perfil FROM Usuarios u INNER JOIN Perfiles p ON (u.idPerfil = p.idPerfil) WHERE u.nombreUsuario='" & txtUsuario.Text & "'"
            tabla = BDHelper.getDBHelper.ConsultaSQL(str)
            If tabla.Rows.Count > 0 Then
                frmPrincipal.actualizarSesion("Usuario: " & txtUsuario.Text & " | Perfil: " & tabla.Rows(0).Item("Perfil").ToString, tabla.Rows(0).Item("idAvatar").ToString)
                flagSalir = False
                Me.Close()
            Else
                Mensajes.mostrarError("Usuario y/o password incorrectos")
                txtUsuario.Focus()
            End If
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        End
    End Sub

    Private Sub frmLogin_Close(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If flagSalir Then
            If Mensajes.deseaSalir() = 1 Then
                End
            Else
                e.Cancel = True
            End If
        End If
    End Sub

End Class