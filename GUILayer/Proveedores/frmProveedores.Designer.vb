﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Me.tabProveedores = New System.Windows.Forms.TabControl()
        Me.tabNuevo = New System.Windows.Forms.TabPage()
        Me.cmdVerUbicacion = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.colCUIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBarrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodBarrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCUIT = New System.Windows.Forms.MaskedTextBox()
        Me.cmdVaciarCampos = New System.Windows.Forms.Button()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.cmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.cmbBarrio = New System.Windows.Forms.ComboBox()
        Me.lblBarrio = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.lblNumeroCalle = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.lblCUIT = New System.Windows.Forms.Label()
        Me.tabModificar = New System.Windows.Forms.TabPage()
        Me.txtCUIT2 = New System.Windows.Forms.MaskedTextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial2 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.txtCalle2 = New System.Windows.Forms.TextBox()
        Me.cmbLocalidad2 = New System.Windows.Forms.ComboBox()
        Me.cmbBarrio2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbProvincia2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabProveedores.SuspendLayout()
        Me.tabNuevo.SuspendLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabModificar.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabProveedores
        '
        Me.tabProveedores.Controls.Add(Me.tabNuevo)
        Me.tabProveedores.Controls.Add(Me.tabModificar)
        Me.tabProveedores.Location = New System.Drawing.Point(16, 15)
        Me.tabProveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.tabProveedores.Name = "tabProveedores"
        Me.tabProveedores.SelectedIndex = 0
        Me.tabProveedores.Size = New System.Drawing.Size(1087, 715)
        Me.tabProveedores.TabIndex = 0
        '
        'tabNuevo
        '
        Me.tabNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.tabNuevo.Controls.Add(Me.cmdVerUbicacion)
        Me.tabNuevo.Controls.Add(Me.cmdEliminar)
        Me.tabNuevo.Controls.Add(Me.cmdModificar)
        Me.tabNuevo.Controls.Add(Me.cmdNuevo)
        Me.tabNuevo.Controls.Add(Me.dgvProveedores)
        Me.tabNuevo.Controls.Add(Me.txtCUIT)
        Me.tabNuevo.Controls.Add(Me.cmdVaciarCampos)
        Me.tabNuevo.Controls.Add(Me.cmdConsultar)
        Me.tabNuevo.Controls.Add(Me.txtTelefono)
        Me.tabNuevo.Controls.Add(Me.txtRazonSocial)
        Me.tabNuevo.Controls.Add(Me.txtNumero)
        Me.tabNuevo.Controls.Add(Me.txtCalle)
        Me.tabNuevo.Controls.Add(Me.cmbLocalidad)
        Me.tabNuevo.Controls.Add(Me.cmbBarrio)
        Me.tabNuevo.Controls.Add(Me.lblBarrio)
        Me.tabNuevo.Controls.Add(Me.lblLocalidad)
        Me.tabNuevo.Controls.Add(Me.lblProvincia)
        Me.tabNuevo.Controls.Add(Me.cmbProvincia)
        Me.tabNuevo.Controls.Add(Me.lblNumeroCalle)
        Me.tabNuevo.Controls.Add(Me.lblCalle)
        Me.tabNuevo.Controls.Add(Me.lblTelefono)
        Me.tabNuevo.Controls.Add(Me.lblRazonSocial)
        Me.tabNuevo.Controls.Add(Me.lblCUIT)
        Me.tabNuevo.Location = New System.Drawing.Point(4, 25)
        Me.tabNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.tabNuevo.Name = "tabNuevo"
        Me.tabNuevo.Padding = New System.Windows.Forms.Padding(4)
        Me.tabNuevo.Size = New System.Drawing.Size(1079, 686)
        Me.tabNuevo.TabIndex = 0
        Me.tabNuevo.Text = "Nuevo/Consultar"
        '
        'cmdVerUbicacion
        '
        Me.cmdVerUbicacion.Location = New System.Drawing.Point(923, 630)
        Me.cmdVerUbicacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdVerUbicacion.Name = "cmdVerUbicacion"
        Me.cmdVerUbicacion.Size = New System.Drawing.Size(139, 39)
        Me.cmdVerUbicacion.TabIndex = 69
        Me.cmdVerUbicacion.Text = "Ver Ubicacion"
        Me.cmdVerUbicacion.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(251, 630)
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(85, 39)
        Me.cmdEliminar.TabIndex = 68
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(128, 630)
        Me.cmdModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(103, 39)
        Me.cmdModificar.TabIndex = 67
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(19, 630)
        Me.cmdNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(88, 39)
        Me.cmdNuevo.TabIndex = 66
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'dgvProveedores
        '
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.AllowUserToDeleteRows = False
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCUIT, Me.colRazonSocial, Me.colTelefono, Me.colProvincia, Me.colLocalidad, Me.colBarrio, Me.colCalle, Me.colNumero, Me.colCodProvincia, Me.colCodLocalidad, Me.colCodBarrio})
        Me.dgvProveedores.Location = New System.Drawing.Point(19, 268)
        Me.dgvProveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.ReadOnly = True
        Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedores.Size = New System.Drawing.Size(1043, 340)
        Me.dgvProveedores.TabIndex = 65
        '
        'colCUIT
        '
        Me.colCUIT.HeaderText = "CUIT"
        Me.colCUIT.Name = "colCUIT"
        Me.colCUIT.ReadOnly = True
        '
        'colRazonSocial
        '
        Me.colRazonSocial.HeaderText = "Razon Social"
        Me.colRazonSocial.Name = "colRazonSocial"
        Me.colRazonSocial.ReadOnly = True
        '
        'colTelefono
        '
        Me.colTelefono.HeaderText = "Telefeno"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.ReadOnly = True
        '
        'colProvincia
        '
        Me.colProvincia.HeaderText = "Provincia"
        Me.colProvincia.Name = "colProvincia"
        Me.colProvincia.ReadOnly = True
        '
        'colLocalidad
        '
        Me.colLocalidad.HeaderText = "Localidad"
        Me.colLocalidad.Name = "colLocalidad"
        Me.colLocalidad.ReadOnly = True
        '
        'colBarrio
        '
        Me.colBarrio.HeaderText = "Barrio"
        Me.colBarrio.Name = "colBarrio"
        Me.colBarrio.ReadOnly = True
        '
        'colCalle
        '
        Me.colCalle.HeaderText = "Calle"
        Me.colCalle.Name = "colCalle"
        Me.colCalle.ReadOnly = True
        '
        'colNumero
        '
        Me.colNumero.HeaderText = "Numero Calle"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.ReadOnly = True
        '
        'colCodProvincia
        '
        Me.colCodProvincia.HeaderText = "codProvincia"
        Me.colCodProvincia.Name = "colCodProvincia"
        Me.colCodProvincia.ReadOnly = True
        Me.colCodProvincia.Visible = False
        '
        'colCodLocalidad
        '
        Me.colCodLocalidad.HeaderText = "codLocalidad"
        Me.colCodLocalidad.Name = "colCodLocalidad"
        Me.colCodLocalidad.ReadOnly = True
        Me.colCodLocalidad.Visible = False
        '
        'colCodBarrio
        '
        Me.colCodBarrio.HeaderText = "codBarrio"
        Me.colCodBarrio.Name = "colCodBarrio"
        Me.colCodBarrio.ReadOnly = True
        Me.colCodBarrio.Visible = False
        '
        'txtCUIT
        '
        Me.txtCUIT.Location = New System.Drawing.Point(112, 19)
        Me.txtCUIT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCUIT.Mask = "99999999999"
        Me.txtCUIT.Name = "txtCUIT"
        Me.txtCUIT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCUIT.Size = New System.Drawing.Size(205, 22)
        Me.txtCUIT.TabIndex = 64
        '
        'cmdVaciarCampos
        '
        Me.cmdVaciarCampos.Location = New System.Drawing.Point(808, 205)
        Me.cmdVaciarCampos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdVaciarCampos.Name = "cmdVaciarCampos"
        Me.cmdVaciarCampos.Size = New System.Drawing.Size(144, 39)
        Me.cmdVaciarCampos.TabIndex = 63
        Me.cmdVaciarCampos.Text = "Vaciar Campos"
        Me.cmdVaciarCampos.UseVisualStyleBackColor = True
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(976, 205)
        Me.cmdConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(85, 39)
        Me.cmdConsultar.TabIndex = 62
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(113, 98)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(260, 22)
        Me.txtTelefono.TabIndex = 61
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(113, 59)
        Me.txtRazonSocial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(260, 22)
        Me.txtRazonSocial.TabIndex = 60
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(648, 221)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(79, 22)
        Me.txtNumero.TabIndex = 59
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(392, 221)
        Me.txtCalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(165, 22)
        Me.txtCalle.TabIndex = 58
        '
        'cmbLocalidad
        '
        Me.cmbLocalidad.FormattingEnabled = True
        Me.cmbLocalidad.Location = New System.Drawing.Point(113, 179)
        Me.cmbLocalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLocalidad.Name = "cmbLocalidad"
        Me.cmbLocalidad.Size = New System.Drawing.Size(204, 24)
        Me.cmbLocalidad.TabIndex = 57
        '
        'cmbBarrio
        '
        Me.cmbBarrio.FormattingEnabled = True
        Me.cmbBarrio.Location = New System.Drawing.Point(113, 221)
        Me.cmbBarrio.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBarrio.Name = "cmbBarrio"
        Me.cmbBarrio.Size = New System.Drawing.Size(204, 24)
        Me.cmbBarrio.TabIndex = 56
        '
        'lblBarrio
        '
        Me.lblBarrio.AutoSize = True
        Me.lblBarrio.Location = New System.Drawing.Point(59, 225)
        Me.lblBarrio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBarrio.Name = "lblBarrio"
        Me.lblBarrio.Size = New System.Drawing.Size(46, 17)
        Me.lblBarrio.TabIndex = 55
        Me.lblBarrio.Text = "Barrio"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(35, 183)
        Me.lblLocalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(69, 17)
        Me.lblLocalidad.TabIndex = 54
        Me.lblLocalidad.Text = "Localidad"
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(39, 141)
        Me.lblProvincia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(66, 17)
        Me.lblProvincia.TabIndex = 53
        Me.lblProvincia.Text = "Provincia"
        '
        'cmbProvincia
        '
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(113, 137)
        Me.cmbProvincia.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(204, 24)
        Me.cmbProvincia.TabIndex = 52
        '
        'lblNumeroCalle
        '
        Me.lblNumeroCalle.AutoSize = True
        Me.lblNumeroCalle.Location = New System.Drawing.Point(581, 225)
        Me.lblNumeroCalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroCalle.Name = "lblNumeroCalle"
        Me.lblNumeroCalle.Size = New System.Drawing.Size(58, 17)
        Me.lblNumeroCalle.TabIndex = 51
        Me.lblNumeroCalle.Text = "Numero"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(344, 225)
        Me.lblCalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(39, 17)
        Me.lblCalle.TabIndex = 50
        Me.lblCalle.Text = "Calle"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(41, 100)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblTelefono.TabIndex = 49
        Me.lblTelefono.Text = "Telefeno"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(13, 61)
        Me.lblRazonSocial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(91, 17)
        Me.lblRazonSocial.TabIndex = 48
        Me.lblRazonSocial.Text = "Razon Social"
        '
        'lblCUIT
        '
        Me.lblCUIT.AutoSize = True
        Me.lblCUIT.Location = New System.Drawing.Point(65, 24)
        Me.lblCUIT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCUIT.Name = "lblCUIT"
        Me.lblCUIT.Size = New System.Drawing.Size(39, 17)
        Me.lblCUIT.TabIndex = 47
        Me.lblCUIT.Text = "CUIT"
        '
        'tabModificar
        '
        Me.tabModificar.BackColor = System.Drawing.SystemColors.Control
        Me.tabModificar.Controls.Add(Me.txtCUIT2)
        Me.tabModificar.Controls.Add(Me.cmdCancelar)
        Me.tabModificar.Controls.Add(Me.cmdGuardar)
        Me.tabModificar.Controls.Add(Me.txtTelefono2)
        Me.tabModificar.Controls.Add(Me.txtRazonSocial2)
        Me.tabModificar.Controls.Add(Me.txtNumero2)
        Me.tabModificar.Controls.Add(Me.txtCalle2)
        Me.tabModificar.Controls.Add(Me.cmbLocalidad2)
        Me.tabModificar.Controls.Add(Me.cmbBarrio2)
        Me.tabModificar.Controls.Add(Me.Label1)
        Me.tabModificar.Controls.Add(Me.Label2)
        Me.tabModificar.Controls.Add(Me.Label3)
        Me.tabModificar.Controls.Add(Me.cmbProvincia2)
        Me.tabModificar.Controls.Add(Me.Label4)
        Me.tabModificar.Controls.Add(Me.Label5)
        Me.tabModificar.Controls.Add(Me.Label6)
        Me.tabModificar.Controls.Add(Me.Label7)
        Me.tabModificar.Controls.Add(Me.Label8)
        Me.tabModificar.Location = New System.Drawing.Point(4, 25)
        Me.tabModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.tabModificar.Name = "tabModificar"
        Me.tabModificar.Padding = New System.Windows.Forms.Padding(4)
        Me.tabModificar.Size = New System.Drawing.Size(1079, 686)
        Me.tabModificar.TabIndex = 1
        Me.tabModificar.Text = "Modificar"
        '
        'txtCUIT2
        '
        Me.txtCUIT2.Location = New System.Drawing.Point(108, 18)
        Me.txtCUIT2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCUIT2.Mask = "99999999999"
        Me.txtCUIT2.Name = "txtCUIT2"
        Me.txtCUIT2.ReadOnly = True
        Me.txtCUIT2.Size = New System.Drawing.Size(205, 22)
        Me.txtCUIT2.TabIndex = 87
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(785, 204)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 39)
        Me.cmdCancelar.TabIndex = 86
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(908, 204)
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(149, 39)
        Me.cmdGuardar.TabIndex = 85
        Me.cmdGuardar.Text = "Guardar Cambios"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(108, 97)
        Me.txtTelefono2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(260, 22)
        Me.txtTelefono2.TabIndex = 84
        '
        'txtRazonSocial2
        '
        Me.txtRazonSocial2.Location = New System.Drawing.Point(108, 59)
        Me.txtRazonSocial2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRazonSocial2.Name = "txtRazonSocial2"
        Me.txtRazonSocial2.Size = New System.Drawing.Size(260, 22)
        Me.txtRazonSocial2.TabIndex = 83
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(643, 222)
        Me.txtNumero2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(79, 22)
        Me.txtNumero2.TabIndex = 82
        '
        'txtCalle2
        '
        Me.txtCalle2.Location = New System.Drawing.Point(387, 222)
        Me.txtCalle2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCalle2.Name = "txtCalle2"
        Me.txtCalle2.Size = New System.Drawing.Size(165, 22)
        Me.txtCalle2.TabIndex = 81
        '
        'cmbLocalidad2
        '
        Me.cmbLocalidad2.FormattingEnabled = True
        Me.cmbLocalidad2.Location = New System.Drawing.Point(108, 180)
        Me.cmbLocalidad2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLocalidad2.Name = "cmbLocalidad2"
        Me.cmbLocalidad2.Size = New System.Drawing.Size(204, 24)
        Me.cmbLocalidad2.TabIndex = 80
        '
        'cmbBarrio2
        '
        Me.cmbBarrio2.FormattingEnabled = True
        Me.cmbBarrio2.Location = New System.Drawing.Point(108, 222)
        Me.cmbBarrio2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBarrio2.Name = "cmbBarrio2"
        Me.cmbBarrio2.Size = New System.Drawing.Size(204, 24)
        Me.cmbBarrio2.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 224)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Barrio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 182)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Localidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Provincia"
        '
        'cmbProvincia2
        '
        Me.cmbProvincia2.FormattingEnabled = True
        Me.cmbProvincia2.Location = New System.Drawing.Point(108, 138)
        Me.cmbProvincia2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProvincia2.Name = "cmbProvincia2"
        Me.cmbProvincia2.Size = New System.Drawing.Size(204, 24)
        Me.cmbProvincia2.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(577, 224)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Numero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 224)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Calle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 101)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Telefeno"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 59)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Razon Social"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "CUIT"
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 731)
        Me.Controls.Add(Me.tabProveedores)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        Me.tabProveedores.ResumeLayout(False)
        Me.tabNuevo.ResumeLayout(False)
        Me.tabNuevo.PerformLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabModificar.ResumeLayout(False)
        Me.tabModificar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabProveedores As TabControl
    Friend WithEvents tabNuevo As TabPage
    Friend WithEvents tabModificar As TabPage
    Friend WithEvents txtCUIT As MaskedTextBox
    Friend WithEvents cmdVaciarCampos As Button
    Friend WithEvents cmdConsultar As Button
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents cmbLocalidad As ComboBox
    Friend WithEvents cmbBarrio As ComboBox
    Friend WithEvents lblBarrio As Label
    Friend WithEvents lblLocalidad As Label
    Friend WithEvents lblProvincia As Label
    Friend WithEvents cmbProvincia As ComboBox
    Friend WithEvents lblNumeroCalle As Label
    Friend WithEvents lblCalle As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents lblCUIT As Label
    Friend WithEvents dgvProveedores As DataGridView
    Friend WithEvents cmdVerUbicacion As Button
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents txtCUIT2 As MaskedTextBox
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents txtTelefono2 As TextBox
    Friend WithEvents txtRazonSocial2 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents txtCalle2 As TextBox
    Friend WithEvents cmbLocalidad2 As ComboBox
    Friend WithEvents cmbBarrio2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbProvincia2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents colCUIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRazonSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTelefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProvincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBarrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodProvincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodBarrio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
