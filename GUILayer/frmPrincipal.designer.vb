<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.cmdProductos = New System.Windows.Forms.Button()
        Me.cmdClientes = New System.Windows.Forms.Button()
        Me.cmdProveedores = New System.Windows.Forms.Button()
        Me.cmdFacturacion = New System.Windows.Forms.Button()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoConsultarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoConsultarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoConsultarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeDeProductosMasVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosPorClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlSesion = New System.Windows.Forms.Panel()
        Me.picAvatar = New System.Windows.Forms.PictureBox()
        Me.cmdCerrarSesion = New System.Windows.Forms.Button()
        Me.lblSesion = New System.Windows.Forms.Label()
        Me.listaAvatares = New System.Windows.Forms.ImageList(Me.components)
        Me.MontosCompradosPorClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrincipal.SuspendLayout()
        Me.pnlSesion.SuspendLayout()
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdProductos
        '
        Me.cmdProductos.Image = CType(resources.GetObject("cmdProductos.Image"), System.Drawing.Image)
        Me.cmdProductos.Location = New System.Drawing.Point(40, 119)
        Me.cmdProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdProductos.Name = "cmdProductos"
        Me.cmdProductos.Size = New System.Drawing.Size(276, 199)
        Me.cmdProductos.TabIndex = 2
        Me.cmdProductos.Text = "Productos"
        Me.cmdProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdProductos.UseVisualStyleBackColor = True
        '
        'cmdClientes
        '
        Me.cmdClientes.Image = CType(resources.GetObject("cmdClientes.Image"), System.Drawing.Image)
        Me.cmdClientes.Location = New System.Drawing.Point(372, 119)
        Me.cmdClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdClientes.Name = "cmdClientes"
        Me.cmdClientes.Size = New System.Drawing.Size(276, 199)
        Me.cmdClientes.TabIndex = 3
        Me.cmdClientes.Text = "Clientes"
        Me.cmdClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdClientes.UseVisualStyleBackColor = True
        '
        'cmdProveedores
        '
        Me.cmdProveedores.Image = CType(resources.GetObject("cmdProveedores.Image"), System.Drawing.Image)
        Me.cmdProveedores.Location = New System.Drawing.Point(40, 368)
        Me.cmdProveedores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdProveedores.Name = "cmdProveedores"
        Me.cmdProveedores.Size = New System.Drawing.Size(276, 199)
        Me.cmdProveedores.TabIndex = 4
        Me.cmdProveedores.Text = "Proveedores"
        Me.cmdProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdProveedores.UseVisualStyleBackColor = True
        '
        'cmdFacturacion
        '
        Me.cmdFacturacion.Image = CType(resources.GetObject("cmdFacturacion.Image"), System.Drawing.Image)
        Me.cmdFacturacion.Location = New System.Drawing.Point(372, 368)
        Me.cmdFacturacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdFacturacion.Name = "cmdFacturacion"
        Me.cmdFacturacion.Size = New System.Drawing.Size(276, 199)
        Me.cmdFacturacion.TabIndex = 5
        Me.cmdFacturacion.Text = "Facturacion"
        Me.cmdFacturacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFacturacion.UseVisualStyleBackColor = True
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoConsultarToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'NuevoConsultarToolStripMenuItem
        '
        Me.NuevoConsultarToolStripMenuItem.Name = "NuevoConsultarToolStripMenuItem"
        Me.NuevoConsultarToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.NuevoConsultarToolStripMenuItem.Text = "Nuevo/Consultar"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoConsultarToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'NuevoConsultarToolStripMenuItem1
        '
        Me.NuevoConsultarToolStripMenuItem1.Name = "NuevoConsultarToolStripMenuItem1"
        Me.NuevoConsultarToolStripMenuItem1.Size = New System.Drawing.Size(195, 26)
        Me.NuevoConsultarToolStripMenuItem1.Text = "Nuevo/Consultar"
        '
        'menuPrincipal
        '
        Me.menuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.FacturacionToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.menuPrincipal.Size = New System.Drawing.Size(689, 28)
        Me.menuPrincipal.TabIndex = 1
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoConsultarToolStripMenuItem3})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'NuevoConsultarToolStripMenuItem3
        '
        Me.NuevoConsultarToolStripMenuItem3.Name = "NuevoConsultarToolStripMenuItem3"
        Me.NuevoConsultarToolStripMenuItem3.Size = New System.Drawing.Size(195, 26)
        Me.NuevoConsultarToolStripMenuItem3.Text = "Nuevo/Consultar"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoConsultarToolStripMenuItem2, Me.ConsultarModificarToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'NuevoConsultarToolStripMenuItem2
        '
        Me.NuevoConsultarToolStripMenuItem2.Name = "NuevoConsultarToolStripMenuItem2"
        Me.NuevoConsultarToolStripMenuItem2.Size = New System.Drawing.Size(216, 26)
        Me.NuevoConsultarToolStripMenuItem2.Text = "Nuevo"
        '
        'ConsultarModificarToolStripMenuItem
        '
        Me.ConsultarModificarToolStripMenuItem.Name = "ConsultarModificarToolStripMenuItem"
        Me.ConsultarModificarToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ConsultarModificarToolStripMenuItem.Text = "Consultar/Modificar"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeClientesToolStripMenuItem, Me.InformeDeProductosMasVendidosToolStripMenuItem, Me.ListadoDeProductosToolStripMenuItem, Me.ProductosPorClientesToolStripMenuItem, Me.ListadoDeProveedoresToolStripMenuItem, Me.MontosCompradosPorClientesToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(296, 26)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de Clientes"
        '
        'InformeDeProductosMasVendidosToolStripMenuItem
        '
        Me.InformeDeProductosMasVendidosToolStripMenuItem.Name = "InformeDeProductosMasVendidosToolStripMenuItem"
        Me.InformeDeProductosMasVendidosToolStripMenuItem.Size = New System.Drawing.Size(296, 26)
        Me.InformeDeProductosMasVendidosToolStripMenuItem.Text = "Productos Mas Vendidos"
        '
        'ListadoDeProductosToolStripMenuItem
        '
        Me.ListadoDeProductosToolStripMenuItem.Name = "ListadoDeProductosToolStripMenuItem"
        Me.ListadoDeProductosToolStripMenuItem.Size = New System.Drawing.Size(296, 26)
        Me.ListadoDeProductosToolStripMenuItem.Text = "Listado de Productos"
        '
        'ProductosPorClientesToolStripMenuItem
        '
        Me.ProductosPorClientesToolStripMenuItem.Name = "ProductosPorClientesToolStripMenuItem"
        Me.ProductosPorClientesToolStripMenuItem.Size = New System.Drawing.Size(296, 26)
        Me.ProductosPorClientesToolStripMenuItem.Text = "Productos Por Clientes"
        '
        'ListadoDeProveedoresToolStripMenuItem
        '
        Me.ListadoDeProveedoresToolStripMenuItem.Name = "ListadoDeProveedoresToolStripMenuItem"
        Me.ListadoDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(296, 26)
        Me.ListadoDeProveedoresToolStripMenuItem.Text = "Listado de Proveedores"
        '
        'pnlSesion
        '
        Me.pnlSesion.BackColor = System.Drawing.Color.Red
        Me.pnlSesion.Controls.Add(Me.picAvatar)
        Me.pnlSesion.Controls.Add(Me.cmdCerrarSesion)
        Me.pnlSesion.Controls.Add(Me.lblSesion)
        Me.pnlSesion.Location = New System.Drawing.Point(0, 31)
        Me.pnlSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSesion.Name = "pnlSesion"
        Me.pnlSesion.Size = New System.Drawing.Size(691, 53)
        Me.pnlSesion.TabIndex = 6
        '
        'picAvatar
        '
        Me.picAvatar.Image = CType(resources.GetObject("picAvatar.Image"), System.Drawing.Image)
        Me.picAvatar.InitialImage = Nothing
        Me.picAvatar.Location = New System.Drawing.Point(12, 2)
        Me.picAvatar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picAvatar.Name = "picAvatar"
        Me.picAvatar.Size = New System.Drawing.Size(47, 49)
        Me.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picAvatar.TabIndex = 7
        Me.picAvatar.TabStop = False
        '
        'cmdCerrarSesion
        '
        Me.cmdCerrarSesion.Location = New System.Drawing.Point(563, 9)
        Me.cmdCerrarSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdCerrarSesion.Name = "cmdCerrarSesion"
        Me.cmdCerrarSesion.Size = New System.Drawing.Size(116, 34)
        Me.cmdCerrarSesion.TabIndex = 7
        Me.cmdCerrarSesion.Text = "Cerrar Sesion"
        Me.cmdCerrarSesion.UseVisualStyleBackColor = True
        '
        'lblSesion
        '
        Me.lblSesion.AutoSize = True
        Me.lblSesion.Location = New System.Drawing.Point(65, 18)
        Me.lblSesion.Name = "lblSesion"
        Me.lblSesion.Size = New System.Drawing.Size(75, 17)
        Me.lblSesion.TabIndex = 7
        Me.lblSesion.Text = "Sin Sesion"
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
        'MontosCompradosPorClientesToolStripMenuItem
        '
        Me.MontosCompradosPorClientesToolStripMenuItem.Name = "MontosCompradosPorClientesToolStripMenuItem"
        Me.MontosCompradosPorClientesToolStripMenuItem.Size = New System.Drawing.Size(296, 26)
        Me.MontosCompradosPorClientesToolStripMenuItem.Text = "Montos Comprados Por Clientes"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(689, 604)
        Me.Controls.Add(Me.pnlSesion)
        Me.Controls.Add(Me.cmdFacturacion)
        Me.Controls.Add(Me.cmdProveedores)
        Me.Controls.Add(Me.cmdClientes)
        Me.Controls.Add(Me.cmdProductos)
        Me.Controls.Add(Me.menuPrincipal)
        Me.MainMenuStrip = Me.menuPrincipal
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(707, 651)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.pnlSesion.ResumeLayout(False)
        Me.pnlSesion.PerformLayout()
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdProductos As System.Windows.Forms.Button
    Friend WithEvents cmdClientes As System.Windows.Forms.Button
    Friend WithEvents cmdProveedores As System.Windows.Forms.Button
    Friend WithEvents cmdFacturacion As System.Windows.Forms.Button
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoConsultarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlSesion As System.Windows.Forms.Panel
    Friend WithEvents lblSesion As System.Windows.Forms.Label
    Friend WithEvents cmdCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoConsultarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents listaAvatares As System.Windows.Forms.ImageList
    Friend WithEvents NuevoConsultarToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformeDeProductosMasVendidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosPorClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MontosCompradosPorClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
