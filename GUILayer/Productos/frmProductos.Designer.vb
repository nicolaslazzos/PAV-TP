<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Me.tabProducto = New System.Windows.Forms.TabControl()
        Me.tabNuevo = New System.Windows.Forms.TabPage()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdVaciarCampos = New System.Windows.Forms.Button()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.cmbUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.lblUnidadMedida = New System.Windows.Forms.Label()
        Me.txtStockActual = New System.Windows.Forms.TextBox()
        Me.lblStockActual = New System.Windows.Forms.Label()
        Me.txtStockMin = New System.Windows.Forms.TextBox()
        Me.lblStockMin = New System.Windows.Forms.Label()
        Me.txtStockMax = New System.Windows.Forms.TextBox()
        Me.lblStockMax = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cmbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.lblTipoProducto = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.tabModificar = New System.Windows.Forms.TabPage()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdGuardarCambios = New System.Windows.Forms.Button()
        Me.txtPrecio2 = New System.Windows.Forms.TextBox()
        Me.lblPrecio2 = New System.Windows.Forms.Label()
        Me.cmbUnidadMedida2 = New System.Windows.Forms.ComboBox()
        Me.lblUnidadMedida2 = New System.Windows.Forms.Label()
        Me.txtStockActual2 = New System.Windows.Forms.TextBox()
        Me.lblStockActual2 = New System.Windows.Forms.Label()
        Me.txtStockMin2 = New System.Windows.Forms.TextBox()
        Me.lblStockMin2 = New System.Windows.Forms.Label()
        Me.txtStockMax2 = New System.Windows.Forms.TextBox()
        Me.lblStockMax2 = New System.Windows.Forms.Label()
        Me.txtDescripcion2 = New System.Windows.Forms.TextBox()
        Me.lblDescripcion2 = New System.Windows.Forms.Label()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.cmbTipoProducto2 = New System.Windows.Forms.ComboBox()
        Me.lblTipoProducto2 = New System.Windows.Forms.Label()
        Me.txtCodigo2 = New System.Windows.Forms.TextBox()
        Me.lblCodigo2 = New System.Windows.Forms.Label()
        Me.rbtQuitar = New System.Windows.Forms.RadioButton()
        Me.rbtAgregar = New System.Windows.Forms.RadioButton()
        Me.lblModificarStock = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.tabProducto.SuspendLayout()
        Me.tabNuevo.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabModificar.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabProducto
        '
        Me.tabProducto.Controls.Add(Me.tabNuevo)
        Me.tabProducto.Controls.Add(Me.tabModificar)
        Me.tabProducto.Location = New System.Drawing.Point(12, 12)
        Me.tabProducto.Name = "tabProducto"
        Me.tabProducto.SelectedIndex = 0
        Me.tabProducto.Size = New System.Drawing.Size(1095, 718)
        Me.tabProducto.TabIndex = 25
        '
        'tabNuevo
        '
        Me.tabNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.tabNuevo.Controls.Add(Me.cmdAgregar)
        Me.tabNuevo.Controls.Add(Me.cmdVaciarCampos)
        Me.tabNuevo.Controls.Add(Me.cmdConsultar)
        Me.tabNuevo.Controls.Add(Me.cmdEliminar)
        Me.tabNuevo.Controls.Add(Me.cmdModificar)
        Me.tabNuevo.Controls.Add(Me.cmdNuevo)
        Me.tabNuevo.Controls.Add(Me.dgvProductos)
        Me.tabNuevo.Controls.Add(Me.txtPrecio)
        Me.tabNuevo.Controls.Add(Me.lblPrecio)
        Me.tabNuevo.Controls.Add(Me.cmbUnidadMedida)
        Me.tabNuevo.Controls.Add(Me.lblUnidadMedida)
        Me.tabNuevo.Controls.Add(Me.txtStockActual)
        Me.tabNuevo.Controls.Add(Me.lblStockActual)
        Me.tabNuevo.Controls.Add(Me.txtStockMin)
        Me.tabNuevo.Controls.Add(Me.lblStockMin)
        Me.tabNuevo.Controls.Add(Me.txtStockMax)
        Me.tabNuevo.Controls.Add(Me.lblStockMax)
        Me.tabNuevo.Controls.Add(Me.txtDescripcion)
        Me.tabNuevo.Controls.Add(Me.lblDescripcion)
        Me.tabNuevo.Controls.Add(Me.txtNombre)
        Me.tabNuevo.Controls.Add(Me.lblNombre)
        Me.tabNuevo.Controls.Add(Me.cmbTipoProducto)
        Me.tabNuevo.Controls.Add(Me.lblTipoProducto)
        Me.tabNuevo.Controls.Add(Me.txtCodigo)
        Me.tabNuevo.Controls.Add(Me.lblCodigo)
        Me.tabNuevo.Location = New System.Drawing.Point(4, 25)
        Me.tabNuevo.Name = "tabNuevo"
        Me.tabNuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNuevo.Size = New System.Drawing.Size(1087, 689)
        Me.tabNuevo.TabIndex = 0
        Me.tabNuevo.Text = "Nuevo/Consultar"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(884, 632)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(181, 39)
        Me.cmdAgregar.TabIndex = 42
        Me.cmdAgregar.Text = "Agregar a Factura"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdVaciarCampos
        '
        Me.cmdVaciarCampos.Location = New System.Drawing.Point(806, 252)
        Me.cmdVaciarCampos.Name = "cmdVaciarCampos"
        Me.cmdVaciarCampos.Size = New System.Drawing.Size(144, 39)
        Me.cmdVaciarCampos.TabIndex = 41
        Me.cmdVaciarCampos.Text = "Vaciar Campos"
        Me.cmdVaciarCampos.UseVisualStyleBackColor = True
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(978, 252)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(87, 39)
        Me.cmdConsultar.TabIndex = 40
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(248, 632)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 39)
        Me.cmdEliminar.TabIndex = 39
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(125, 632)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(97, 39)
        Me.cmdModificar.TabIndex = 38
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(22, 632)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(75, 39)
        Me.cmdNuevo.TabIndex = 37
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colTipoProducto, Me.colNombre, Me.colDescripcion, Me.colStockMax, Me.colStockMin, Me.colStockActual, Me.colUnidadMedida, Me.colPrecio})
        Me.dgvProductos.Location = New System.Drawing.Point(22, 313)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowTemplate.Height = 24
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(1043, 303)
        Me.dgvProductos.TabIndex = 36
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        '
        'colTipoProducto
        '
        Me.colTipoProducto.HeaderText = "Tipo"
        Me.colTipoProducto.Name = "colTipoProducto"
        Me.colTipoProducto.ReadOnly = True
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'colDescripcion
        '
        Me.colDescripcion.HeaderText = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        '
        'colStockMax
        '
        Me.colStockMax.HeaderText = "Stock Maximo"
        Me.colStockMax.Name = "colStockMax"
        Me.colStockMax.ReadOnly = True
        '
        'colStockMin
        '
        Me.colStockMin.HeaderText = "Stock Minimo"
        Me.colStockMin.Name = "colStockMin"
        Me.colStockMin.ReadOnly = True
        '
        'colStockActual
        '
        Me.colStockActual.HeaderText = "Stock Actual"
        Me.colStockActual.Name = "colStockActual"
        Me.colStockActual.ReadOnly = True
        '
        'colUnidadMedida
        '
        Me.colUnidadMedida.HeaderText = "Unidad"
        Me.colUnidadMedida.Name = "colUnidadMedida"
        Me.colUnidadMedida.ReadOnly = True
        '
        'colPrecio
        '
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.ReadOnly = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(148, 269)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(121, 22)
        Me.txtPrecio.TabIndex = 35
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(33, 272)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(109, 17)
        Me.lblPrecio.TabIndex = 34
        Me.lblPrecio.Text = "Precio de Venta"
        '
        'cmbUnidadMedida
        '
        Me.cmbUnidadMedida.FormattingEnabled = True
        Me.cmbUnidadMedida.Location = New System.Drawing.Point(148, 229)
        Me.cmbUnidadMedida.Name = "cmbUnidadMedida"
        Me.cmbUnidadMedida.Size = New System.Drawing.Size(121, 24)
        Me.cmbUnidadMedida.TabIndex = 33
        '
        'lblUnidadMedida
        '
        Me.lblUnidadMedida.AutoSize = True
        Me.lblUnidadMedida.Location = New System.Drawing.Point(19, 232)
        Me.lblUnidadMedida.Name = "lblUnidadMedida"
        Me.lblUnidadMedida.Size = New System.Drawing.Size(123, 17)
        Me.lblUnidadMedida.TabIndex = 32
        Me.lblUnidadMedida.Text = "Unidad de Medida"
        '
        'txtStockActual
        '
        Me.txtStockActual.Location = New System.Drawing.Point(594, 189)
        Me.txtStockActual.Name = "txtStockActual"
        Me.txtStockActual.Size = New System.Drawing.Size(100, 22)
        Me.txtStockActual.TabIndex = 31
        '
        'lblStockActual
        '
        Me.lblStockActual.AutoSize = True
        Me.lblStockActual.Location = New System.Drawing.Point(506, 192)
        Me.lblStockActual.Name = "lblStockActual"
        Me.lblStockActual.Size = New System.Drawing.Size(82, 17)
        Me.lblStockActual.TabIndex = 30
        Me.lblStockActual.Text = "StockActual"
        '
        'txtStockMin
        '
        Me.txtStockMin.Location = New System.Drawing.Point(375, 189)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Size = New System.Drawing.Size(100, 22)
        Me.txtStockMin.TabIndex = 29
        '
        'lblStockMin
        '
        Me.lblStockMin.AutoSize = True
        Me.lblStockMin.Location = New System.Drawing.Point(278, 192)
        Me.lblStockMin.Name = "lblStockMin"
        Me.lblStockMin.Size = New System.Drawing.Size(91, 17)
        Me.lblStockMin.TabIndex = 28
        Me.lblStockMin.Text = "Stock Minimo"
        '
        'txtStockMax
        '
        Me.txtStockMax.Location = New System.Drawing.Point(148, 189)
        Me.txtStockMax.Name = "txtStockMax"
        Me.txtStockMax.Size = New System.Drawing.Size(100, 22)
        Me.txtStockMax.TabIndex = 27
        '
        'lblStockMax
        '
        Me.lblStockMax.AutoSize = True
        Me.lblStockMax.Location = New System.Drawing.Point(48, 192)
        Me.lblStockMax.Name = "lblStockMax"
        Me.lblStockMax.Size = New System.Drawing.Size(94, 17)
        Me.lblStockMax.TabIndex = 26
        Me.lblStockMax.Text = "Stock Maximo"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(148, 146)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(327, 22)
        Me.txtDescripcion.TabIndex = 25
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(60, 149)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lblDescripcion.TabIndex = 24
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(148, 104)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(327, 22)
        Me.txtNombre.TabIndex = 23
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(84, 107)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Nombre"
        '
        'cmbTipoProducto
        '
        Me.cmbTipoProducto.FormattingEnabled = True
        Me.cmbTipoProducto.Location = New System.Drawing.Point(148, 62)
        Me.cmbTipoProducto.Name = "cmbTipoProducto"
        Me.cmbTipoProducto.Size = New System.Drawing.Size(327, 24)
        Me.cmbTipoProducto.TabIndex = 21
        '
        'lblTipoProducto
        '
        Me.lblTipoProducto.AutoSize = True
        Me.lblTipoProducto.Location = New System.Drawing.Point(106, 65)
        Me.lblTipoProducto.Name = "lblTipoProducto"
        Me.lblTipoProducto.Size = New System.Drawing.Size(36, 17)
        Me.lblTipoProducto.TabIndex = 20
        Me.lblTipoProducto.Text = "Tipo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(148, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(327, 22)
        Me.txtCodigo.TabIndex = 19
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(90, 24)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo.TabIndex = 18
        Me.lblCodigo.Text = "Codigo"
        '
        'tabModificar
        '
        Me.tabModificar.BackColor = System.Drawing.SystemColors.Control
        Me.tabModificar.Controls.Add(Me.txtCantidad)
        Me.tabModificar.Controls.Add(Me.lblCantidad)
        Me.tabModificar.Controls.Add(Me.lblModificarStock)
        Me.tabModificar.Controls.Add(Me.rbtAgregar)
        Me.tabModificar.Controls.Add(Me.rbtQuitar)
        Me.tabModificar.Controls.Add(Me.cmdCancelar)
        Me.tabModificar.Controls.Add(Me.cmdGuardarCambios)
        Me.tabModificar.Controls.Add(Me.txtPrecio2)
        Me.tabModificar.Controls.Add(Me.lblPrecio2)
        Me.tabModificar.Controls.Add(Me.cmbUnidadMedida2)
        Me.tabModificar.Controls.Add(Me.lblUnidadMedida2)
        Me.tabModificar.Controls.Add(Me.txtStockActual2)
        Me.tabModificar.Controls.Add(Me.lblStockActual2)
        Me.tabModificar.Controls.Add(Me.txtStockMin2)
        Me.tabModificar.Controls.Add(Me.lblStockMin2)
        Me.tabModificar.Controls.Add(Me.txtStockMax2)
        Me.tabModificar.Controls.Add(Me.lblStockMax2)
        Me.tabModificar.Controls.Add(Me.txtDescripcion2)
        Me.tabModificar.Controls.Add(Me.lblDescripcion2)
        Me.tabModificar.Controls.Add(Me.txtNombre2)
        Me.tabModificar.Controls.Add(Me.lblNombre2)
        Me.tabModificar.Controls.Add(Me.cmbTipoProducto2)
        Me.tabModificar.Controls.Add(Me.lblTipoProducto2)
        Me.tabModificar.Controls.Add(Me.txtCodigo2)
        Me.tabModificar.Controls.Add(Me.lblCodigo2)
        Me.tabModificar.Location = New System.Drawing.Point(4, 25)
        Me.tabModificar.Name = "tabModificar"
        Me.tabModificar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabModificar.Size = New System.Drawing.Size(1087, 689)
        Me.tabModificar.TabIndex = 1
        Me.tabModificar.Text = "Modificar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(766, 319)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(120, 39)
        Me.cmdCancelar.TabIndex = 61
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardarCambios
        '
        Me.cmdGuardarCambios.Location = New System.Drawing.Point(910, 319)
        Me.cmdGuardarCambios.Name = "cmdGuardarCambios"
        Me.cmdGuardarCambios.Size = New System.Drawing.Size(157, 39)
        Me.cmdGuardarCambios.TabIndex = 60
        Me.cmdGuardarCambios.Text = "Guardar Cambios"
        Me.cmdGuardarCambios.UseVisualStyleBackColor = True
        '
        'txtPrecio2
        '
        Me.txtPrecio2.Location = New System.Drawing.Point(145, 336)
        Me.txtPrecio2.Name = "txtPrecio2"
        Me.txtPrecio2.Size = New System.Drawing.Size(121, 22)
        Me.txtPrecio2.TabIndex = 59
        '
        'lblPrecio2
        '
        Me.lblPrecio2.AutoSize = True
        Me.lblPrecio2.Location = New System.Drawing.Point(30, 339)
        Me.lblPrecio2.Name = "lblPrecio2"
        Me.lblPrecio2.Size = New System.Drawing.Size(109, 17)
        Me.lblPrecio2.TabIndex = 58
        Me.lblPrecio2.Text = "Precio de Venta"
        '
        'cmbUnidadMedida2
        '
        Me.cmbUnidadMedida2.FormattingEnabled = True
        Me.cmbUnidadMedida2.Location = New System.Drawing.Point(145, 296)
        Me.cmbUnidadMedida2.Name = "cmbUnidadMedida2"
        Me.cmbUnidadMedida2.Size = New System.Drawing.Size(121, 24)
        Me.cmbUnidadMedida2.TabIndex = 57
        '
        'lblUnidadMedida2
        '
        Me.lblUnidadMedida2.AutoSize = True
        Me.lblUnidadMedida2.Location = New System.Drawing.Point(16, 299)
        Me.lblUnidadMedida2.Name = "lblUnidadMedida2"
        Me.lblUnidadMedida2.Size = New System.Drawing.Size(123, 17)
        Me.lblUnidadMedida2.TabIndex = 56
        Me.lblUnidadMedida2.Text = "Unidad de Medida"
        '
        'txtStockActual2
        '
        Me.txtStockActual2.Location = New System.Drawing.Point(591, 189)
        Me.txtStockActual2.Name = "txtStockActual2"
        Me.txtStockActual2.ReadOnly = True
        Me.txtStockActual2.Size = New System.Drawing.Size(100, 22)
        Me.txtStockActual2.TabIndex = 55
        '
        'lblStockActual2
        '
        Me.lblStockActual2.AutoSize = True
        Me.lblStockActual2.Location = New System.Drawing.Point(503, 192)
        Me.lblStockActual2.Name = "lblStockActual2"
        Me.lblStockActual2.Size = New System.Drawing.Size(82, 17)
        Me.lblStockActual2.TabIndex = 54
        Me.lblStockActual2.Text = "StockActual"
        '
        'txtStockMin2
        '
        Me.txtStockMin2.Location = New System.Drawing.Point(372, 189)
        Me.txtStockMin2.Name = "txtStockMin2"
        Me.txtStockMin2.Size = New System.Drawing.Size(100, 22)
        Me.txtStockMin2.TabIndex = 53
        '
        'lblStockMin2
        '
        Me.lblStockMin2.AutoSize = True
        Me.lblStockMin2.Location = New System.Drawing.Point(275, 192)
        Me.lblStockMin2.Name = "lblStockMin2"
        Me.lblStockMin2.Size = New System.Drawing.Size(91, 17)
        Me.lblStockMin2.TabIndex = 52
        Me.lblStockMin2.Text = "Stock Minimo"
        '
        'txtStockMax2
        '
        Me.txtStockMax2.Location = New System.Drawing.Point(145, 189)
        Me.txtStockMax2.Name = "txtStockMax2"
        Me.txtStockMax2.Size = New System.Drawing.Size(100, 22)
        Me.txtStockMax2.TabIndex = 51
        '
        'lblStockMax2
        '
        Me.lblStockMax2.AutoSize = True
        Me.lblStockMax2.Location = New System.Drawing.Point(45, 192)
        Me.lblStockMax2.Name = "lblStockMax2"
        Me.lblStockMax2.Size = New System.Drawing.Size(94, 17)
        Me.lblStockMax2.TabIndex = 50
        Me.lblStockMax2.Text = "Stock Maximo"
        '
        'txtDescripcion2
        '
        Me.txtDescripcion2.Location = New System.Drawing.Point(145, 146)
        Me.txtDescripcion2.Name = "txtDescripcion2"
        Me.txtDescripcion2.Size = New System.Drawing.Size(327, 22)
        Me.txtDescripcion2.TabIndex = 49
        '
        'lblDescripcion2
        '
        Me.lblDescripcion2.AutoSize = True
        Me.lblDescripcion2.Location = New System.Drawing.Point(57, 149)
        Me.lblDescripcion2.Name = "lblDescripcion2"
        Me.lblDescripcion2.Size = New System.Drawing.Size(82, 17)
        Me.lblDescripcion2.TabIndex = 48
        Me.lblDescripcion2.Text = "Descripcion"
        '
        'txtNombre2
        '
        Me.txtNombre2.Location = New System.Drawing.Point(145, 104)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(327, 22)
        Me.txtNombre2.TabIndex = 47
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Location = New System.Drawing.Point(81, 107)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre2.TabIndex = 46
        Me.lblNombre2.Text = "Nombre"
        '
        'cmbTipoProducto2
        '
        Me.cmbTipoProducto2.FormattingEnabled = True
        Me.cmbTipoProducto2.Location = New System.Drawing.Point(145, 62)
        Me.cmbTipoProducto2.Name = "cmbTipoProducto2"
        Me.cmbTipoProducto2.Size = New System.Drawing.Size(327, 24)
        Me.cmbTipoProducto2.TabIndex = 45
        '
        'lblTipoProducto2
        '
        Me.lblTipoProducto2.AutoSize = True
        Me.lblTipoProducto2.Location = New System.Drawing.Point(103, 65)
        Me.lblTipoProducto2.Name = "lblTipoProducto2"
        Me.lblTipoProducto2.Size = New System.Drawing.Size(36, 17)
        Me.lblTipoProducto2.TabIndex = 44
        Me.lblTipoProducto2.Text = "Tipo"
        '
        'txtCodigo2
        '
        Me.txtCodigo2.Location = New System.Drawing.Point(145, 21)
        Me.txtCodigo2.Name = "txtCodigo2"
        Me.txtCodigo2.ReadOnly = True
        Me.txtCodigo2.Size = New System.Drawing.Size(327, 22)
        Me.txtCodigo2.TabIndex = 43
        '
        'lblCodigo2
        '
        Me.lblCodigo2.AutoSize = True
        Me.lblCodigo2.Location = New System.Drawing.Point(87, 24)
        Me.lblCodigo2.Name = "lblCodigo2"
        Me.lblCodigo2.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo2.TabIndex = 42
        Me.lblCodigo2.Text = "Codigo"
        '
        'rbtQuitar
        '
        Me.rbtQuitar.AutoSize = True
        Me.rbtQuitar.Location = New System.Drawing.Point(145, 259)
        Me.rbtQuitar.Name = "rbtQuitar"
        Me.rbtQuitar.Size = New System.Drawing.Size(68, 21)
        Me.rbtQuitar.TabIndex = 62
        Me.rbtQuitar.TabStop = True
        Me.rbtQuitar.Text = "Quitar"
        Me.rbtQuitar.UseVisualStyleBackColor = True
        '
        'rbtAgregar
        '
        Me.rbtAgregar.AutoSize = True
        Me.rbtAgregar.Location = New System.Drawing.Point(145, 232)
        Me.rbtAgregar.Name = "rbtAgregar"
        Me.rbtAgregar.Size = New System.Drawing.Size(80, 21)
        Me.rbtAgregar.TabIndex = 63
        Me.rbtAgregar.TabStop = True
        Me.rbtAgregar.Text = "Agregar"
        Me.rbtAgregar.UseVisualStyleBackColor = True
        '
        'lblModificarStock
        '
        Me.lblModificarStock.AutoSize = True
        Me.lblModificarStock.Location = New System.Drawing.Point(35, 232)
        Me.lblModificarStock.Name = "lblModificarStock"
        Me.lblModificarStock.Size = New System.Drawing.Size(104, 17)
        Me.lblModificarStock.TabIndex = 64
        Me.lblModificarStock.Text = "Modificar Stock"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(254, 236)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(64, 17)
        Me.lblCantidad.TabIndex = 65
        Me.lblCantidad.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(324, 233)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidad.TabIndex = 66
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 740)
        Me.Controls.Add(Me.tabProducto)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.tabProducto.ResumeLayout(False)
        Me.tabNuevo.ResumeLayout(False)
        Me.tabNuevo.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabModificar.ResumeLayout(False)
        Me.tabModificar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabProducto As System.Windows.Forms.TabControl
    Friend WithEvents tabNuevo As System.Windows.Forms.TabPage
    Friend WithEvents cmdVaciarCampos As System.Windows.Forms.Button
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents cmbUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents lblUnidadMedida As System.Windows.Forms.Label
    Friend WithEvents txtStockActual As System.Windows.Forms.TextBox
    Friend WithEvents lblStockActual As System.Windows.Forms.Label
    Friend WithEvents txtStockMin As System.Windows.Forms.TextBox
    Friend WithEvents lblStockMin As System.Windows.Forms.Label
    Friend WithEvents txtStockMax As System.Windows.Forms.TextBox
    Friend WithEvents lblStockMax As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cmbTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoProducto As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents tabModificar As System.Windows.Forms.TabPage
    Friend WithEvents cmdGuardarCambios As System.Windows.Forms.Button
    Friend WithEvents txtPrecio2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecio2 As System.Windows.Forms.Label
    Friend WithEvents cmbUnidadMedida2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblUnidadMedida2 As System.Windows.Forms.Label
    Friend WithEvents txtStockActual2 As System.Windows.Forms.TextBox
    Friend WithEvents lblStockActual2 As System.Windows.Forms.Label
    Friend WithEvents txtStockMin2 As System.Windows.Forms.TextBox
    Friend WithEvents lblStockMin2 As System.Windows.Forms.Label
    Friend WithEvents txtStockMax2 As System.Windows.Forms.TextBox
    Friend WithEvents lblStockMax2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre2 As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre2 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoProducto2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoProducto2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo2 As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo2 As System.Windows.Forms.Label
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStockMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStockMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStockActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblModificarStock As System.Windows.Forms.Label
    Friend WithEvents rbtAgregar As System.Windows.Forms.RadioButton
    Friend WithEvents rbtQuitar As System.Windows.Forms.RadioButton
End Class
