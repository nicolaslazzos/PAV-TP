<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.tabUsuarios = New System.Windows.Forms.TabControl()
        Me.tabNuevo = New System.Windows.Forms.TabPage()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdRegistrar = New System.Windows.Forms.Button()
        Me.picAvatar = New System.Windows.Forms.PictureBox()
        Me.cmbAvatares = New System.Windows.Forms.ComboBox()
        Me.lblAvatar = New System.Windows.Forms.Label()
        Me.cmbPerfiles = New System.Windows.Forms.ComboBox()
        Me.lblPerfil = New System.Windows.Forms.Label()
        Me.txtPasswordRepetida = New System.Windows.Forms.TextBox()
        Me.lblPasswordRepetida = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.tabConsultar = New System.Windows.Forms.TabPage()
        Me.cmdVaciarCampos = New System.Windows.Forms.Button()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.colUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPerfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAvatar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbPerfilesC = New System.Windows.Forms.ComboBox()
        Me.lblPerfilC = New System.Windows.Forms.Label()
        Me.txtEmailC = New System.Windows.Forms.TextBox()
        Me.lblEmailC = New System.Windows.Forms.Label()
        Me.txtUsuarioC = New System.Windows.Forms.TextBox()
        Me.lblUsuarioC = New System.Windows.Forms.Label()
        Me.tabModificar = New System.Windows.Forms.TabPage()
        Me.cmdCancelar2 = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.picAvatar2 = New System.Windows.Forms.PictureBox()
        Me.cmbAvatares2 = New System.Windows.Forms.ComboBox()
        Me.lblAvatar2 = New System.Windows.Forms.Label()
        Me.cmbPerfiles2 = New System.Windows.Forms.ComboBox()
        Me.lblPerfil2 = New System.Windows.Forms.Label()
        Me.txtPasswordRepetida2 = New System.Windows.Forms.TextBox()
        Me.lblPasswordRepetida2 = New System.Windows.Forms.Label()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.lblPassword2 = New System.Windows.Forms.Label()
        Me.txtEmail2 = New System.Windows.Forms.TextBox()
        Me.lblEmail2 = New System.Windows.Forms.Label()
        Me.txtUsuario2 = New System.Windows.Forms.TextBox()
        Me.lblUsuario2 = New System.Windows.Forms.Label()
        Me.listaAvatares = New System.Windows.Forms.ImageList(Me.components)
        Me.tabUsuarios.SuspendLayout()
        Me.tabNuevo.SuspendLayout()
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConsultar.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabModificar.SuspendLayout()
        CType(Me.picAvatar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabUsuarios
        '
        Me.tabUsuarios.Controls.Add(Me.tabNuevo)
        Me.tabUsuarios.Controls.Add(Me.tabConsultar)
        Me.tabUsuarios.Controls.Add(Me.tabModificar)
        Me.tabUsuarios.Location = New System.Drawing.Point(12, 12)
        Me.tabUsuarios.Name = "tabUsuarios"
        Me.tabUsuarios.SelectedIndex = 0
        Me.tabUsuarios.Size = New System.Drawing.Size(669, 445)
        Me.tabUsuarios.TabIndex = 0
        '
        'tabNuevo
        '
        Me.tabNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.tabNuevo.Controls.Add(Me.cmdCancelar)
        Me.tabNuevo.Controls.Add(Me.cmdRegistrar)
        Me.tabNuevo.Controls.Add(Me.picAvatar)
        Me.tabNuevo.Controls.Add(Me.cmbAvatares)
        Me.tabNuevo.Controls.Add(Me.lblAvatar)
        Me.tabNuevo.Controls.Add(Me.cmbPerfiles)
        Me.tabNuevo.Controls.Add(Me.lblPerfil)
        Me.tabNuevo.Controls.Add(Me.txtPasswordRepetida)
        Me.tabNuevo.Controls.Add(Me.lblPasswordRepetida)
        Me.tabNuevo.Controls.Add(Me.txtPassword)
        Me.tabNuevo.Controls.Add(Me.lblPassword)
        Me.tabNuevo.Controls.Add(Me.txtEmail)
        Me.tabNuevo.Controls.Add(Me.lblEmail)
        Me.tabNuevo.Controls.Add(Me.txtUsuario)
        Me.tabNuevo.Controls.Add(Me.lblUsuario)
        Me.tabNuevo.Location = New System.Drawing.Point(4, 25)
        Me.tabNuevo.Name = "tabNuevo"
        Me.tabNuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNuevo.Size = New System.Drawing.Size(661, 416)
        Me.tabNuevo.TabIndex = 0
        Me.tabNuevo.Text = "Nuevo"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(368, 366)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(84, 31)
        Me.cmdCancelar.TabIndex = 14
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdRegistrar
        '
        Me.cmdRegistrar.Location = New System.Drawing.Point(263, 366)
        Me.cmdRegistrar.Name = "cmdRegistrar"
        Me.cmdRegistrar.Size = New System.Drawing.Size(90, 31)
        Me.cmdRegistrar.TabIndex = 13
        Me.cmdRegistrar.Text = "Registrar"
        Me.cmdRegistrar.UseVisualStyleBackColor = True
        '
        'picAvatar
        '
        Me.picAvatar.Location = New System.Drawing.Point(316, 206)
        Me.picAvatar.Name = "picAvatar"
        Me.picAvatar.Size = New System.Drawing.Size(136, 130)
        Me.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAvatar.TabIndex = 12
        Me.picAvatar.TabStop = False
        '
        'cmbAvatares
        '
        Me.cmbAvatares.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAvatares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAvatares.FormattingEnabled = True
        Me.cmbAvatares.IntegralHeight = False
        Me.cmbAvatares.ItemHeight = 35
        Me.cmbAvatares.Location = New System.Drawing.Point(157, 206)
        Me.cmbAvatares.Name = "cmbAvatares"
        Me.cmbAvatares.Size = New System.Drawing.Size(140, 41)
        Me.cmbAvatares.TabIndex = 11
        '
        'lblAvatar
        '
        Me.lblAvatar.AutoSize = True
        Me.lblAvatar.Location = New System.Drawing.Point(102, 209)
        Me.lblAvatar.Name = "lblAvatar"
        Me.lblAvatar.Size = New System.Drawing.Size(49, 17)
        Me.lblAvatar.TabIndex = 10
        Me.lblAvatar.Text = "Avatar"
        '
        'cmbPerfiles
        '
        Me.cmbPerfiles.FormattingEnabled = True
        Me.cmbPerfiles.Location = New System.Drawing.Point(157, 166)
        Me.cmbPerfiles.Name = "cmbPerfiles"
        Me.cmbPerfiles.Size = New System.Drawing.Size(205, 24)
        Me.cmbPerfiles.TabIndex = 9
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.Location = New System.Drawing.Point(111, 169)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(40, 17)
        Me.lblPerfil.TabIndex = 8
        Me.lblPerfil.Text = "Perfil"
        '
        'txtPasswordRepetida
        '
        Me.txtPasswordRepetida.Location = New System.Drawing.Point(157, 127)
        Me.txtPasswordRepetida.Name = "txtPasswordRepetida"
        Me.txtPasswordRepetida.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordRepetida.Size = New System.Drawing.Size(205, 22)
        Me.txtPasswordRepetida.TabIndex = 7
        '
        'lblPasswordRepetida
        '
        Me.lblPasswordRepetida.AutoSize = True
        Me.lblPasswordRepetida.Location = New System.Drawing.Point(20, 130)
        Me.lblPasswordRepetida.Name = "lblPasswordRepetida"
        Me.lblPasswordRepetida.Size = New System.Drawing.Size(131, 17)
        Me.lblPasswordRepetida.TabIndex = 6
        Me.lblPasswordRepetida.Text = "Repetir Contraseña"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(157, 90)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(205, 22)
        Me.txtPassword.TabIndex = 5
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(70, 93)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(81, 17)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Contraseña"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(157, 53)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(249, 22)
        Me.txtEmail.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(104, 56)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(47, 17)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "E-Mail"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(157, 17)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(205, 22)
        Me.txtUsuario.TabIndex = 1
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(20, 20)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(131, 17)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Nombre de Usuario"
        '
        'tabConsultar
        '
        Me.tabConsultar.BackColor = System.Drawing.SystemColors.Control
        Me.tabConsultar.Controls.Add(Me.cmdVaciarCampos)
        Me.tabConsultar.Controls.Add(Me.cmdConsultar)
        Me.tabConsultar.Controls.Add(Me.cmdEliminar)
        Me.tabConsultar.Controls.Add(Me.cmdModificar)
        Me.tabConsultar.Controls.Add(Me.dgvUsuarios)
        Me.tabConsultar.Controls.Add(Me.cmbPerfilesC)
        Me.tabConsultar.Controls.Add(Me.lblPerfilC)
        Me.tabConsultar.Controls.Add(Me.txtEmailC)
        Me.tabConsultar.Controls.Add(Me.lblEmailC)
        Me.tabConsultar.Controls.Add(Me.txtUsuarioC)
        Me.tabConsultar.Controls.Add(Me.lblUsuarioC)
        Me.tabConsultar.Location = New System.Drawing.Point(4, 25)
        Me.tabConsultar.Name = "tabConsultar"
        Me.tabConsultar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsultar.Size = New System.Drawing.Size(661, 416)
        Me.tabConsultar.TabIndex = 1
        Me.tabConsultar.Text = "Consultar"
        '
        'cmdVaciarCampos
        '
        Me.cmdVaciarCampos.Location = New System.Drawing.Point(411, 83)
        Me.cmdVaciarCampos.Name = "cmdVaciarCampos"
        Me.cmdVaciarCampos.Size = New System.Drawing.Size(121, 34)
        Me.cmdVaciarCampos.TabIndex = 35
        Me.cmdVaciarCampos.Text = "Vaciar Campos"
        Me.cmdVaciarCampos.UseVisualStyleBackColor = True
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(548, 83)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(97, 34)
        Me.cmdConsultar.TabIndex = 34
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(122, 359)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(83, 37)
        Me.cmdEliminar.TabIndex = 33
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(18, 359)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(85, 37)
        Me.cmdModificar.TabIndex = 32
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUsuario, Me.colEmail, Me.colPerfil, Me.colPassword, Me.colAvatar})
        Me.dgvUsuarios.Location = New System.Drawing.Point(17, 138)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowTemplate.Height = 24
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(628, 204)
        Me.dgvUsuarios.TabIndex = 31
        '
        'colUsuario
        '
        Me.colUsuario.HeaderText = "Nombre de Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.ReadOnly = True
        Me.colUsuario.Width = 125
        '
        'colEmail
        '
        Me.colEmail.HeaderText = "E-Mail"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Width = 165
        '
        'colPerfil
        '
        Me.colPerfil.HeaderText = "Perfil"
        Me.colPerfil.Name = "colPerfil"
        Me.colPerfil.ReadOnly = True
        Me.colPerfil.Width = 138
        '
        'colPassword
        '
        Me.colPassword.HeaderText = "Password"
        Me.colPassword.Name = "colPassword"
        Me.colPassword.ReadOnly = True
        Me.colPassword.Visible = False
        '
        'colAvatar
        '
        Me.colAvatar.HeaderText = "Avatar"
        Me.colAvatar.Name = "colAvatar"
        Me.colAvatar.ReadOnly = True
        Me.colAvatar.Visible = False
        '
        'cmbPerfilesC
        '
        Me.cmbPerfilesC.FormattingEnabled = True
        Me.cmbPerfilesC.Location = New System.Drawing.Point(152, 93)
        Me.cmbPerfilesC.Name = "cmbPerfilesC"
        Me.cmbPerfilesC.Size = New System.Drawing.Size(205, 24)
        Me.cmbPerfilesC.TabIndex = 30
        '
        'lblPerfilC
        '
        Me.lblPerfilC.AutoSize = True
        Me.lblPerfilC.Location = New System.Drawing.Point(106, 96)
        Me.lblPerfilC.Name = "lblPerfilC"
        Me.lblPerfilC.Size = New System.Drawing.Size(40, 17)
        Me.lblPerfilC.TabIndex = 29
        Me.lblPerfilC.Text = "Perfil"
        '
        'txtEmailC
        '
        Me.txtEmailC.Location = New System.Drawing.Point(152, 56)
        Me.txtEmailC.Name = "txtEmailC"
        Me.txtEmailC.Size = New System.Drawing.Size(237, 22)
        Me.txtEmailC.TabIndex = 28
        '
        'lblEmailC
        '
        Me.lblEmailC.AutoSize = True
        Me.lblEmailC.Location = New System.Drawing.Point(99, 59)
        Me.lblEmailC.Name = "lblEmailC"
        Me.lblEmailC.Size = New System.Drawing.Size(47, 17)
        Me.lblEmailC.TabIndex = 27
        Me.lblEmailC.Text = "E-Mail"
        '
        'txtUsuarioC
        '
        Me.txtUsuarioC.Location = New System.Drawing.Point(152, 20)
        Me.txtUsuarioC.Name = "txtUsuarioC"
        Me.txtUsuarioC.Size = New System.Drawing.Size(205, 22)
        Me.txtUsuarioC.TabIndex = 26
        '
        'lblUsuarioC
        '
        Me.lblUsuarioC.AutoSize = True
        Me.lblUsuarioC.Location = New System.Drawing.Point(15, 23)
        Me.lblUsuarioC.Name = "lblUsuarioC"
        Me.lblUsuarioC.Size = New System.Drawing.Size(131, 17)
        Me.lblUsuarioC.TabIndex = 25
        Me.lblUsuarioC.Text = "Nombre de Usuario"
        '
        'tabModificar
        '
        Me.tabModificar.BackColor = System.Drawing.SystemColors.Control
        Me.tabModificar.Controls.Add(Me.cmdCancelar2)
        Me.tabModificar.Controls.Add(Me.cmdGuardar)
        Me.tabModificar.Controls.Add(Me.picAvatar2)
        Me.tabModificar.Controls.Add(Me.cmbAvatares2)
        Me.tabModificar.Controls.Add(Me.lblAvatar2)
        Me.tabModificar.Controls.Add(Me.cmbPerfiles2)
        Me.tabModificar.Controls.Add(Me.lblPerfil2)
        Me.tabModificar.Controls.Add(Me.txtPasswordRepetida2)
        Me.tabModificar.Controls.Add(Me.lblPasswordRepetida2)
        Me.tabModificar.Controls.Add(Me.txtPassword2)
        Me.tabModificar.Controls.Add(Me.lblPassword2)
        Me.tabModificar.Controls.Add(Me.txtEmail2)
        Me.tabModificar.Controls.Add(Me.lblEmail2)
        Me.tabModificar.Controls.Add(Me.txtUsuario2)
        Me.tabModificar.Controls.Add(Me.lblUsuario2)
        Me.tabModificar.Location = New System.Drawing.Point(4, 25)
        Me.tabModificar.Name = "tabModificar"
        Me.tabModificar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabModificar.Size = New System.Drawing.Size(661, 416)
        Me.tabModificar.TabIndex = 2
        Me.tabModificar.Text = "Modificar"
        '
        'cmdCancelar2
        '
        Me.cmdCancelar2.Location = New System.Drawing.Point(366, 368)
        Me.cmdCancelar2.Name = "cmdCancelar2"
        Me.cmdCancelar2.Size = New System.Drawing.Size(84, 31)
        Me.cmdCancelar2.TabIndex = 29
        Me.cmdCancelar2.Text = "Cancelar"
        Me.cmdCancelar2.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(202, 368)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(149, 31)
        Me.cmdGuardar.TabIndex = 28
        Me.cmdGuardar.Text = "Guardar Cambios"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'picAvatar2
        '
        Me.picAvatar2.Location = New System.Drawing.Point(314, 208)
        Me.picAvatar2.Name = "picAvatar2"
        Me.picAvatar2.Size = New System.Drawing.Size(136, 130)
        Me.picAvatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAvatar2.TabIndex = 27
        Me.picAvatar2.TabStop = False
        '
        'cmbAvatares2
        '
        Me.cmbAvatares2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAvatares2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAvatares2.FormattingEnabled = True
        Me.cmbAvatares2.IntegralHeight = False
        Me.cmbAvatares2.ItemHeight = 35
        Me.cmbAvatares2.Location = New System.Drawing.Point(155, 208)
        Me.cmbAvatares2.Name = "cmbAvatares2"
        Me.cmbAvatares2.Size = New System.Drawing.Size(140, 41)
        Me.cmbAvatares2.TabIndex = 26
        '
        'lblAvatar2
        '
        Me.lblAvatar2.AutoSize = True
        Me.lblAvatar2.Location = New System.Drawing.Point(100, 211)
        Me.lblAvatar2.Name = "lblAvatar2"
        Me.lblAvatar2.Size = New System.Drawing.Size(49, 17)
        Me.lblAvatar2.TabIndex = 25
        Me.lblAvatar2.Text = "Avatar"
        '
        'cmbPerfiles2
        '
        Me.cmbPerfiles2.FormattingEnabled = True
        Me.cmbPerfiles2.Location = New System.Drawing.Point(155, 168)
        Me.cmbPerfiles2.Name = "cmbPerfiles2"
        Me.cmbPerfiles2.Size = New System.Drawing.Size(205, 24)
        Me.cmbPerfiles2.TabIndex = 24
        '
        'lblPerfil2
        '
        Me.lblPerfil2.AutoSize = True
        Me.lblPerfil2.Location = New System.Drawing.Point(109, 171)
        Me.lblPerfil2.Name = "lblPerfil2"
        Me.lblPerfil2.Size = New System.Drawing.Size(40, 17)
        Me.lblPerfil2.TabIndex = 23
        Me.lblPerfil2.Text = "Perfil"
        '
        'txtPasswordRepetida2
        '
        Me.txtPasswordRepetida2.Location = New System.Drawing.Point(155, 129)
        Me.txtPasswordRepetida2.Name = "txtPasswordRepetida2"
        Me.txtPasswordRepetida2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordRepetida2.Size = New System.Drawing.Size(205, 22)
        Me.txtPasswordRepetida2.TabIndex = 22
        '
        'lblPasswordRepetida2
        '
        Me.lblPasswordRepetida2.AutoSize = True
        Me.lblPasswordRepetida2.Location = New System.Drawing.Point(18, 132)
        Me.lblPasswordRepetida2.Name = "lblPasswordRepetida2"
        Me.lblPasswordRepetida2.Size = New System.Drawing.Size(131, 17)
        Me.lblPasswordRepetida2.TabIndex = 21
        Me.lblPasswordRepetida2.Text = "Repetir Contraseña"
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(155, 92)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(205, 22)
        Me.txtPassword2.TabIndex = 20
        '
        'lblPassword2
        '
        Me.lblPassword2.AutoSize = True
        Me.lblPassword2.Location = New System.Drawing.Point(68, 95)
        Me.lblPassword2.Name = "lblPassword2"
        Me.lblPassword2.Size = New System.Drawing.Size(81, 17)
        Me.lblPassword2.TabIndex = 19
        Me.lblPassword2.Text = "Contraseña"
        '
        'txtEmail2
        '
        Me.txtEmail2.Location = New System.Drawing.Point(155, 55)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(249, 22)
        Me.txtEmail2.TabIndex = 18
        '
        'lblEmail2
        '
        Me.lblEmail2.AutoSize = True
        Me.lblEmail2.Location = New System.Drawing.Point(102, 58)
        Me.lblEmail2.Name = "lblEmail2"
        Me.lblEmail2.Size = New System.Drawing.Size(47, 17)
        Me.lblEmail2.TabIndex = 17
        Me.lblEmail2.Text = "E-Mail"
        '
        'txtUsuario2
        '
        Me.txtUsuario2.Location = New System.Drawing.Point(155, 19)
        Me.txtUsuario2.Name = "txtUsuario2"
        Me.txtUsuario2.ReadOnly = True
        Me.txtUsuario2.Size = New System.Drawing.Size(205, 22)
        Me.txtUsuario2.TabIndex = 16
        '
        'lblUsuario2
        '
        Me.lblUsuario2.AutoSize = True
        Me.lblUsuario2.Location = New System.Drawing.Point(18, 22)
        Me.lblUsuario2.Name = "lblUsuario2"
        Me.lblUsuario2.Size = New System.Drawing.Size(131, 17)
        Me.lblUsuario2.TabIndex = 15
        Me.lblUsuario2.Text = "Nombre de Usuario"
        '
        'listaAvatares
        '
        Me.listaAvatares.ImageStream = CType(resources.GetObject("listaAvatares.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.listaAvatares.TransparentColor = System.Drawing.Color.Transparent
        Me.listaAvatares.Images.SetKeyName(0, "male1")
        Me.listaAvatares.Images.SetKeyName(1, "male2")
        Me.listaAvatares.Images.SetKeyName(2, "male3")
        Me.listaAvatares.Images.SetKeyName(3, "female1")
        Me.listaAvatares.Images.SetKeyName(4, "female2")
        Me.listaAvatares.Images.SetKeyName(5, "ninguno")
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 469)
        Me.Controls.Add(Me.tabUsuarios)
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.tabUsuarios.ResumeLayout(False)
        Me.tabNuevo.ResumeLayout(False)
        Me.tabNuevo.PerformLayout()
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConsultar.ResumeLayout(False)
        Me.tabConsultar.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabModificar.ResumeLayout(False)
        Me.tabModificar.PerformLayout()
        CType(Me.picAvatar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabUsuarios As System.Windows.Forms.TabControl
    Friend WithEvents tabNuevo As System.Windows.Forms.TabPage
    Friend WithEvents tabConsultar As System.Windows.Forms.TabPage
    Friend WithEvents tabModificar As System.Windows.Forms.TabPage
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents picAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents lblAvatar As System.Windows.Forms.Label
    Friend WithEvents cmbPerfiles As System.Windows.Forms.ComboBox
    Friend WithEvents lblPerfil As System.Windows.Forms.Label
    Friend WithEvents txtPasswordRepetida As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordRepetida As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents listaAvatares As System.Windows.Forms.ImageList
    Friend WithEvents cmbAvatares As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdRegistrar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar2 As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents picAvatar2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbAvatares2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblAvatar2 As System.Windows.Forms.Label
    Friend WithEvents cmbPerfiles2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblPerfil2 As System.Windows.Forms.Label
    Friend WithEvents txtPasswordRepetida2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordRepetida2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword2 As System.Windows.Forms.Label
    Friend WithEvents txtEmail2 As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail2 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario2 As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario2 As System.Windows.Forms.Label
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents cmbPerfilesC As System.Windows.Forms.ComboBox
    Friend WithEvents lblPerfilC As System.Windows.Forms.Label
    Friend WithEvents txtEmailC As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailC As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioC As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuarioC As System.Windows.Forms.Label
    Friend WithEvents cmdVaciarCampos As System.Windows.Forms.Button
    Friend WithEvents colUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPerfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPassword As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAvatar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
