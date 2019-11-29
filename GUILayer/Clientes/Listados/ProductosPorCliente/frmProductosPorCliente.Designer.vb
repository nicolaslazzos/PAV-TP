<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosPorCliente
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ProductosPorCliente_ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rvProductosPorCliente = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.lblTipoProducto = New System.Windows.Forms.Label()
        Me.cmbTiposProducto = New System.Windows.Forms.ComboBox()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.cmbProvincias = New System.Windows.Forms.ComboBox()
        CType(Me.ProductosPorCliente_ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductosPorCliente_ResultBindingSource
        '
        Me.ProductosPorCliente_ResultBindingSource.DataSource = GetType(ProyectoPAV.ProductosPorCliente_Result)
        '
        'rvProductosPorCliente
        '
        ReportDataSource1.Name = "ProductosPorClienteDataSet"
        ReportDataSource1.Value = Me.ProductosPorCliente_ResultBindingSource
        Me.rvProductosPorCliente.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvProductosPorCliente.LocalReport.ReportEmbeddedResource = "ProyectoPAV.listadoProductosPorCliente.rdlc"
        Me.rvProductosPorCliente.Location = New System.Drawing.Point(12, 90)
        Me.rvProductosPorCliente.Name = "rvProductosPorCliente"
        Me.rvProductosPorCliente.Size = New System.Drawing.Size(1254, 721)
        Me.rvProductosPorCliente.TabIndex = 11
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(1154, 37)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(112, 38)
        Me.cmdConsultar.TabIndex = 10
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Location = New System.Drawing.Point(568, 14)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaHasta.TabIndex = 9
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Location = New System.Drawing.Point(513, 19)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(49, 17)
        Me.lblFechaHasta.TabIndex = 8
        Me.lblFechaHasta.Text = "Hasta:"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Location = New System.Drawing.Point(132, 14)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaDesde.TabIndex = 7
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Location = New System.Drawing.Point(12, 19)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(114, 17)
        Me.lblFechaDesde.TabIndex = 6
        Me.lblFechaDesde.Text = "Ventas desde el:"
        '
        'lblTipoProducto
        '
        Me.lblTipoProducto.AutoSize = True
        Me.lblTipoProducto.Location = New System.Drawing.Point(12, 54)
        Me.lblTipoProducto.Name = "lblTipoProducto"
        Me.lblTipoProducto.Size = New System.Drawing.Size(121, 17)
        Me.lblTipoProducto.TabIndex = 12
        Me.lblTipoProducto.Text = "Tipo de Producto:"
        '
        'cmbTiposProducto
        '
        Me.cmbTiposProducto.FormattingEnabled = True
        Me.cmbTiposProducto.Location = New System.Drawing.Point(139, 51)
        Me.cmbTiposProducto.Name = "cmbTiposProducto"
        Me.cmbTiposProducto.Size = New System.Drawing.Size(193, 24)
        Me.cmbTiposProducto.TabIndex = 13
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(384, 54)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(178, 17)
        Me.lblProvincia.TabIndex = 14
        Me.lblProvincia.Text = "Clientes de la provincia de:"
        '
        'cmbProvincias
        '
        Me.cmbProvincias.FormattingEnabled = True
        Me.cmbProvincias.Location = New System.Drawing.Point(568, 51)
        Me.cmbProvincias.Name = "cmbProvincias"
        Me.cmbProvincias.Size = New System.Drawing.Size(200, 24)
        Me.cmbProvincias.TabIndex = 15
        '
        'frmProductosPorCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 823)
        Me.Controls.Add(Me.cmbProvincias)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.cmbTiposProducto)
        Me.Controls.Add(Me.lblTipoProducto)
        Me.Controls.Add(Me.rvProductosPorCliente)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.lblFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.Controls.Add(Me.lblFechaDesde)
        Me.Name = "frmProductosPorCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos Mas Comprados Por Cada Cliente"
        CType(Me.ProductosPorCliente_ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvProductosPorCliente As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents lblTipoProducto As System.Windows.Forms.Label
    Friend WithEvents cmbTiposProducto As System.Windows.Forms.ComboBox
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents cmbProvincias As System.Windows.Forms.ComboBox
    Friend WithEvents ProductosPorCliente_ResultBindingSource As System.Windows.Forms.BindingSource
End Class
