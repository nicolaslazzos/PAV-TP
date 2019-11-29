Public Class frmUsuarios
    Friend rowSelected As DataGridViewRow

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabUsuarios.SelectedTab = tabNuevo

        tabUsuarios.TabPages("tabModificar").Enabled = False
        cmdEliminar.Enabled = False
        cmdModificar.Enabled = False

        cmbAvatares.Items.AddRange(Enumerable.Repeat(Of String)("", listaAvatares.Images.Count).ToArray())
        picAvatar.Image = listaAvatares.Images("ninguno")

        llenarCombo(cmbPerfiles, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Perfiles"), "nombre", "idPerfil")
        llenarCombo(cmbPerfilesC, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Perfiles"), "nombre", "idPerfil")
        llenarGrid()
    End Sub

    Public Sub clearComponents()
        'PESTAÑA NUEVO USUARIO
        txtUsuario.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtPasswordRepetida.Text = ""
        cmbPerfiles.Text = ""
        cmbAvatares.Text = ""
        'PESTAÑA MODIFICAR USUARIO
        txtUsuario2.Text = ""
        txtEmail2.Text = ""
        txtPassword2.Text = ""
        txtPasswordRepetida2.Text = ""
        cmbPerfiles2.Text = ""
        cmbAvatares2.Text = ""
    End Sub

    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    Public Sub llenarGrid()
        Dim Str As String = "SELECT u.nombreUsuario, u.email, u.password, u.idAvatar, p.nombre FROM Usuarios u INNER JOIN Perfiles p ON (u.idPerfil = p.idPerfil) WHERE u.bajaLogica='False'"

        Dim source As DataTable
        source = BDHelper.getDBHelper.ConsultaSQL(Str)
        dgvUsuarios.Rows.Clear()
        For Each fila As DataRow In source.Rows
            dgvUsuarios.Rows.Add(New String() {fila.Item("nombreUsuario").ToString, fila.Item("email").ToString, fila.Item("nombre").ToString, fila.Item("password").ToString, fila.Item("idAvatar").ToString})
        Next
    End Sub

    Public Sub llenarGrid(ByVal source As DataTable)
        dgvUsuarios.Rows.Clear()
        For Each fila As DataRow In source.Rows
            dgvUsuarios.Rows.Add(New String() {fila.Item("nombreUsuario").ToString, fila.Item("email").ToString, fila.Item("nombre").ToString, fila.Item("password").ToString, fila.Item("idAvatar").ToString})
        Next
    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick
        cmdEliminar.Enabled = True
        cmdModificar.Enabled = True
        rowSelected = dgvUsuarios.CurrentRow
    End Sub
    Private Sub cmbAvatares_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmbAvatares.DrawItem, cmbAvatares2.DrawItem
        e.DrawBackground()
        e.DrawFocusRectangle()
        If e.Index >= 0 Then
            If e.Index < listaAvatares.Images.Count Then
                Dim img As Image = New Bitmap(listaAvatares.Images(e.Index), New Size(32, 32))
                e.Graphics.DrawImage(img, New PointF(e.Bounds.Left, e.Bounds.Top))
            End If
            e.Graphics.DrawString(String.Format("Avatar {0}", e.Index + 1), e.Font, New SolidBrush(e.ForeColor), e.Bounds.Left + 35, e.Bounds.Top + 9)
        End If
    End Sub

    Private Sub cmbImages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAvatares.SelectedIndexChanged, cmbAvatares2.SelectedIndexChanged
        Dim combo As ComboBox = CType(sender, ComboBox)
        If combo.SelectedIndex >= 0 Then
            picAvatar.Image = listaAvatares.Images(combo.SelectedIndex)
            picAvatar2.Image = listaAvatares.Images(combo.SelectedIndex)
        Else
            picAvatar.Image = Nothing
            picAvatar2.Image = Nothing
        End If
    End Sub

    Private Sub cmdRegistrar_Click(sender As Object, e As EventArgs) Handles cmdRegistrar.Click
        Dim filters As New List(Of Object)
        Dim str As String = "INSERT INTO Usuarios(nombreUsuario,password,email,idPerfil,idAvatar) VALUES(@param1,@param2,@param3,@param4,@param5)"

        If txtUsuario.Text <> String.Empty Then
            filters.Add(txtUsuario.Text)
        Else
            Mensajes.mostrarError("Falta introducir uno o mas campos")
            Return
        End If

        If (txtPassword.Text <> String.Empty) And (txtPasswordRepetida.Text <> String.Empty) And (txtPassword.Text <> txtPasswordRepetida.Text) Then
            Mensajes.mostrarError("Las contrseñas introducidas no coinciden")
            Return
        ElseIf (txtPassword.Text = String.Empty) Or (txtPasswordRepetida.Text = String.Empty) Then
            Mensajes.mostrarError("Falta introducir uno o mas campos")
            Return
        Else
            filters.Add(txtPassword.Text)
        End If

        If txtEmail.Text <> String.Empty Then
            filters.Add(txtEmail.Text)
        Else
            filters.Add(Nothing)
        End If

        If cmbPerfiles.Text <> String.Empty Then
            filters.Add(cmbPerfiles.SelectedValue)
        Else
            filters.Add(Nothing)
        End If

        If cmbAvatares.SelectedIndex.ToString <> String.Empty Then
            filters.Add(cmbAvatares.SelectedIndex)
        Else
            filters.Add(5)
        End If

        BDHelper.getDBHelper.EjecutarSQLConParametros(str, filters.ToArray())

        Mensajes.mostrarAviso("Se ha registrado con exito")

        clearComponents()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim filters As New List(Of Object)
        Dim str As String = "SELECT u.nombreUsuario, u.email, u.password, u.idAvatar, p.nombre FROM Usuarios u INNER JOIN Perfiles p ON (u.idPerfil = p.idPerfil) WHERE u.bajaLogica='False'"

        If txtUsuarioC.Text <> String.Empty Then
            filters.Add(txtUsuarioC.Text)
            str += " AND u.nombreUsuario=@param1"
        Else
            filters.Add(Nothing)
        End If

        If txtEmailC.Text <> String.Empty Then
            filters.Add(txtEmailC.Text)
            str += " AND u.email=@param2"
        Else
            filters.Add(Nothing)
        End If

        If cmbPerfilesC.Text <> String.Empty Then
            filters.Add(cmbPerfilesC.SelectedValue)
            str += " AND u.idPerfil=@param3"
        Else
            filters.Add(Nothing)
        End If

        llenarGrid(BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray()))

        If dgvUsuarios.Rows.Count = 0 Then
            mostrarAviso("No se encontraron coincidencias")
        End If

        cmdModificar.Enabled = False
        cmdEliminar.Enabled = False
    End Sub

    Private Sub cmdVaciarCampos_Click(sender As Object, e As EventArgs) Handles cmdVaciarCampos.Click
        txtUsuarioC.Text = ""
        txtEmailC.Text = ""
        cmbPerfilesC.Text = ""
    End Sub

    'ACA FALTARIA HACER VALIDACIONES PARA QQUE SOLO UN ADMIN PUEDA ELIMINAR, Y QUE NO SE PUEDAN ELIMINAR ENTRE ADMINS O ALGO ASI
    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim filters As New List(Of Object)
        Dim Str As String = "UPDATE Usuarios SET bajaLogica='True' WHERE nombreUsuario=@param1"

        filters.Add(rowSelected.Cells("colUsuario").Value)

        If Mensajes.deseaEliminar = 1 Then
            BDHelper.getDBHelper.EjecutarSQLConParametros(Str, filters.ToArray())
            llenarGrid()
        End If
    End Sub

    'FALTARIA VALIDAR QUE CUANDO SE QUIERA EDITAR UN USUARIO Y NO SEAS ADMIN, TE PIDA LA PASSWORD
    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        tabUsuarios.SelectedTab = tabModificar
        tabUsuarios.TabPages("tabModificar").Enabled = True

        llenarCombo(cmbPerfiles2, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Perfiles"), "nombre", "idPerfil")
        cmbAvatares2.Items.AddRange(Enumerable.Repeat(Of String)("", listaAvatares.Images.Count).ToArray())
        picAvatar2.Image = listaAvatares.Images("ninguno")

        With rowSelected
            txtUsuario2.Text = .Cells("colUsuario").Value
            txtEmail2.Text = .Cells("colEmail").Value
            txtPassword2.Text = .Cells("colPassword").Value
            txtPasswordRepetida2.Text = .Cells("colPassword").Value
            cmbPerfiles2.Text = .Cells("colPerfil").Value
            picAvatar2.Image = listaAvatares.Images(Integer.Parse(.Cells("colAvatar").Value))
        End With
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim filters As New List(Of Object)
        Dim str As String = "UPDATE Usuarios SET email=@param2, password=@param3, idPerfil=@param4, idAvatar=@param5 WHERE nombreUsuario=@param1"

        filters.Add(txtUsuario2.Text)

        If txtEmail2.Text <> String.Empty Then
            filters.Add(txtEmail2.Text)
        Else
            filters.Add(Nothing)
        End If

        If (txtPassword2.Text <> String.Empty) And (txtPasswordRepetida2.Text <> String.Empty) And (txtPassword.Text <> txtPasswordRepetida.Text) Then
            Mensajes.mostrarError("Las contrseñas introducidas no coinciden")
            Return
        ElseIf (txtPassword2.Text = String.Empty) Or (txtPasswordRepetida2.Text = String.Empty) Then
            Mensajes.mostrarError("Falta introducir uno o mas campos")
            Return
        Else
            filters.Add(txtPassword2.Text)
        End If

        If cmbPerfiles2.Text <> String.Empty Then
            filters.Add(cmbPerfiles2.SelectedValue)
        Else
            filters.Add(Nothing)
        End If

        If cmbAvatares2.SelectedIndex.ToString <> -1 Then
            filters.Add(cmbAvatares2.SelectedIndex)
        Else
            filters.Add(Integer.Parse(rowSelected.Cells("colAvatar").Value))
        End If

        If Mensajes.deseaModificar Then
            BDHelper.getDBHelper.EjecutarSQLConParametros(str, filters.ToArray())
        End If

        tabUsuarios.SelectedTab = tabConsultar
        cmdEliminar.Enabled = False
        cmdModificar.Enabled = False
        llenarGrid()
    End Sub

    Private Sub cmdCancelar2_Click(sender As Object, e As EventArgs) Handles cmdCancelar2.Click
        tabUsuarios.SelectedTab = tabConsultar
        tabUsuarios.TabPages("tabModificar").Enabled = False
        clearComponents()
    End Sub
End Class