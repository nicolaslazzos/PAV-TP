<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacion
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
        Me.grpEncabezado = New System.Windows.Forms.GroupBox()
        Me.cmdNuevaFactura = New System.Windows.Forms.Button()
        Me.cmdConsultarCliente = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cmbTipoFactura = New System.Windows.Forms.ComboBox()
        Me.lblTipoFactura = New System.Windows.Forms.Label()
        Me.lblNroFactura = New System.Windows.Forms.Label()
        Me.txtNroFactura = New System.Windows.Forms.TextBox()
        Me.grpDetalle = New System.Windows.Forms.GroupBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblStockActual = New System.Windows.Forms.Label()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdConsultarProducto = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.lblSubtotal1 = New System.Windows.Forms.Label()
        Me.txtSubtotal1 = New System.Windows.Forms.TextBox()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodTipoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpEncabezado.SuspendLayout()
        Me.grpDetalle.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEncabezado
        '
        Me.grpEncabezado.Controls.Add(Me.cmdNuevaFactura)
        Me.grpEncabezado.Controls.Add(Me.cmdConsultarCliente)
        Me.grpEncabezado.Controls.Add(Me.txtFecha)
        Me.grpEncabezado.Controls.Add(Me.cmbClientes)
        Me.grpEncabezado.Controls.Add(Me.lblFecha)
        Me.grpEncabezado.Controls.Add(Me.lblCliente)
        Me.grpEncabezado.Controls.Add(Me.cmbTipoFactura)
        Me.grpEncabezado.Controls.Add(Me.lblTipoFactura)
        Me.grpEncabezado.Controls.Add(Me.lblNroFactura)
        Me.grpEncabezado.Controls.Add(Me.txtNroFactura)
        Me.grpEncabezado.Location = New System.Drawing.Point(12, 12)
        Me.grpEncabezado.Name = "grpEncabezado"
        Me.grpEncabezado.Size = New System.Drawing.Size(830, 188)
        Me.grpEncabezado.TabIndex = 8
        Me.grpEncabezado.TabStop = False
        Me.grpEncabezado.Text = "Encabezado"
        '
        'cmdNuevaFactura
        '
        Me.cmdNuevaFactura.Location = New System.Drawing.Point(660, 30)
        Me.cmdNuevaFactura.Name = "cmdNuevaFactura"
        Me.cmdNuevaFactura.Size = New System.Drawing.Size(151, 35)
        Me.cmdNuevaFactura.TabIndex = 15
        Me.cmdNuevaFactura.Text = "Nueva Factura"
        Me.cmdNuevaFactura.UseVisualStyleBackColor = True
        '
        'cmdConsultarCliente
        '
        Me.cmdConsultarCliente.Location = New System.Drawing.Point(424, 97)
        Me.cmdConsultarCliente.Name = "cmdConsultarCliente"
        Me.cmdConsultarCliente.Size = New System.Drawing.Size(90, 37)
        Me.cmdConsultarCliente.TabIndex = 7
        Me.cmdConsultarCliente.Text = "Consultar"
        Me.cmdConsultarCliente.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(151, 144)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 22)
        Me.txtFecha.TabIndex = 15
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(151, 104)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(255, 24)
        Me.cmbClientes.TabIndex = 14
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(98, 147)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(47, 17)
        Me.lblFecha.TabIndex = 13
        Me.lblFecha.Text = "Fecha"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(94, 107)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(51, 17)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente"
        '
        'cmbTipoFactura
        '
        Me.cmbTipoFactura.FormattingEnabled = True
        Me.cmbTipoFactura.Location = New System.Drawing.Point(151, 66)
        Me.cmbTipoFactura.Name = "cmbTipoFactura"
        Me.cmbTipoFactura.Size = New System.Drawing.Size(100, 24)
        Me.cmbTipoFactura.TabIndex = 11
        '
        'lblTipoFactura
        '
        Me.lblTipoFactura.AutoSize = True
        Me.lblTipoFactura.Location = New System.Drawing.Point(37, 69)
        Me.lblTipoFactura.Name = "lblTipoFactura"
        Me.lblTipoFactura.Size = New System.Drawing.Size(108, 17)
        Me.lblTipoFactura.TabIndex = 10
        Me.lblTipoFactura.Text = "Tipo de Factura"
        '
        'lblNroFactura
        '
        Me.lblNroFactura.AutoSize = True
        Me.lblNroFactura.Location = New System.Drawing.Point(15, 33)
        Me.lblNroFactura.Name = "lblNroFactura"
        Me.lblNroFactura.Size = New System.Drawing.Size(130, 17)
        Me.lblNroFactura.TabIndex = 9
        Me.lblNroFactura.Text = "Numero de Factura"
        '
        'txtNroFactura
        '
        Me.txtNroFactura.Location = New System.Drawing.Point(151, 30)
        Me.txtNroFactura.Name = "txtNroFactura"
        Me.txtNroFactura.ReadOnly = True
        Me.txtNroFactura.Size = New System.Drawing.Size(100, 22)
        Me.txtNroFactura.TabIndex = 8
        '
        'grpDetalle
        '
        Me.grpDetalle.Controls.Add(Me.lblPrecio)
        Me.grpDetalle.Controls.Add(Me.lblStockActual)
        Me.grpDetalle.Controls.Add(Me.cmdAgregar)
        Me.grpDetalle.Controls.Add(Me.cmdConsultarProducto)
        Me.grpDetalle.Controls.Add(Me.txtCantidad)
        Me.grpDetalle.Controls.Add(Me.lblCantidad)
        Me.grpDetalle.Controls.Add(Me.cmbProductos)
        Me.grpDetalle.Controls.Add(Me.lblProducto)
        Me.grpDetalle.Controls.Add(Me.dgvDetalle)
        Me.grpDetalle.Location = New System.Drawing.Point(12, 206)
        Me.grpDetalle.Name = "grpDetalle"
        Me.grpDetalle.Size = New System.Drawing.Size(830, 430)
        Me.grpDetalle.TabIndex = 9
        Me.grpDetalle.TabStop = False
        Me.grpDetalle.Text = "Detalle"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(322, 81)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(52, 17)
        Me.lblPrecio.TabIndex = 8
        Me.lblPrecio.Text = "Precio:"
        '
        'lblStockActual
        '
        Me.lblStockActual.AutoSize = True
        Me.lblStockActual.Location = New System.Drawing.Point(25, 81)
        Me.lblStockActual.Name = "lblStockActual"
        Me.lblStockActual.Size = New System.Drawing.Size(117, 17)
        Me.lblStockActual.TabIndex = 7
        Me.lblStockActual.Text = "Stock Disponible:"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(732, 27)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(80, 37)
        Me.cmdAgregar.TabIndex = 6
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdConsultarProducto
        '
        Me.cmdConsultarProducto.Location = New System.Drawing.Point(424, 27)
        Me.cmdConsultarProducto.Name = "cmdConsultarProducto"
        Me.cmdConsultarProducto.Size = New System.Drawing.Size(90, 37)
        Me.cmdConsultarProducto.TabIndex = 5
        Me.cmdConsultarProducto.Text = "Consultar"
        Me.cmdConsultarProducto.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(633, 34)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(82, 22)
        Me.txtCantidad.TabIndex = 4
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(563, 37)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(64, 17)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Cantidad"
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(96, 34)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(310, 24)
        Me.cmbProductos.TabIndex = 2
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(25, 37)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(65, 17)
        Me.lblProducto.TabIndex = 1
        Me.lblProducto.Text = "Producto"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCantidad, Me.colCodProducto, Me.colNombre, Me.colPrecioUnitario, Me.colSubtotal, Me.colCodTipoProducto})
        Me.dgvDetalle.Location = New System.Drawing.Point(18, 115)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowTemplate.Height = 24
        Me.dgvDetalle.Size = New System.Drawing.Size(794, 296)
        Me.dgvDetalle.TabIndex = 0
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(648, 725)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 17)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total: $"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(710, 722)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(113, 22)
        Me.txtTotal.TabIndex = 10
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(30, 709)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(113, 35)
        Me.cmdGuardar.TabIndex = 11
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(163, 709)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(99, 35)
        Me.cmdCancelar.TabIndex = 12
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(710, 684)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(114, 22)
        Me.txtDescuento.TabIndex = 13
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(628, 687)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(76, 17)
        Me.lblDescuento.TabIndex = 14
        Me.lblDescuento.Text = "Descuento"
        '
        'lblSubtotal1
        '
        Me.lblSubtotal1.AutoSize = True
        Me.lblSubtotal1.Location = New System.Drawing.Point(628, 648)
        Me.lblSubtotal1.Name = "lblSubtotal1"
        Me.lblSubtotal1.Size = New System.Drawing.Size(72, 17)
        Me.lblSubtotal1.TabIndex = 16
        Me.lblSubtotal1.Text = "Subtotal 1"
        '
        'txtSubtotal1
        '
        Me.txtSubtotal1.Location = New System.Drawing.Point(709, 645)
        Me.txtSubtotal1.Name = "txtSubtotal1"
        Me.txtSubtotal1.ReadOnly = True
        Me.txtSubtotal1.Size = New System.Drawing.Size(114, 22)
        Me.txtSubtotal1.TabIndex = 15
        Me.txtSubtotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colCantidad
        '
        Me.colCantidad.HeaderText = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Width = 70
        '
        'colCodProducto
        '
        Me.colCodProducto.HeaderText = "Codigo"
        Me.colCodProducto.Name = "colCodProducto"
        Me.colCodProducto.Width = 110
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Width = 200
        '
        'colPrecioUnitario
        '
        Me.colPrecioUnitario.HeaderText = "Precio Unitario"
        Me.colPrecioUnitario.Name = "colPrecioUnitario"
        '
        'colSubtotal
        '
        Me.colSubtotal.HeaderText = "Subtotal"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.Width = 73
        '
        'colCodTipoProducto
        '
        Me.colCodTipoProducto.HeaderText = "CodTipoProducto"
        Me.colCodTipoProducto.Name = "colCodTipoProducto"
        Me.colCodTipoProducto.Visible = False
        '
        'frmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 756)
        Me.Controls.Add(Me.lblSubtotal1)
        Me.Controls.Add(Me.txtSubtotal1)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.grpDetalle)
        Me.Controls.Add(Me.grpEncabezado)
        Me.Name = "frmFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion"
        Me.grpEncabezado.ResumeLayout(False)
        Me.grpEncabezado.PerformLayout()
        Me.grpDetalle.ResumeLayout(False)
        Me.grpDetalle.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpEncabezado As System.Windows.Forms.GroupBox
    Friend WithEvents cmdConsultarCliente As System.Windows.Forms.Button
    Friend WithEvents txtFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents cmbTipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoFactura As System.Windows.Forms.Label
    Friend WithEvents lblNroFactura As System.Windows.Forms.Label
    Friend WithEvents txtNroFactura As System.Windows.Forms.TextBox
    Friend WithEvents grpDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdConsultarProducto As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents cmdNuevaFactura As System.Windows.Forms.Button
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblStockActual As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal1 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal1 As System.Windows.Forms.TextBox
    Friend WithEvents colCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodTipoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
