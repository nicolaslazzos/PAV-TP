<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoProductos
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
        Me.ListadoProductos_ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rvListadoProductos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.lblTipoProducto = New System.Windows.Forms.Label()
        Me.lblStockMayorA = New System.Windows.Forms.Label()
        Me.cmbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.txtStockMenorA = New System.Windows.Forms.TextBox()
        Me.txtStockMayorA = New System.Windows.Forms.TextBox()
        Me.lblStockMenorA = New System.Windows.Forms.Label()
        CType(Me.ListadoProductos_ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListadoProductos_ResultBindingSource
        '
        Me.ListadoProductos_ResultBindingSource.DataSource = GetType(ProyectoPAV.ListadoProductos_Result)
        '
        'rvListadoProductos
        '
        ReportDataSource1.Name = "ProductosDataSet"
        ReportDataSource1.Value = Me.ListadoProductos_ResultBindingSource
        Me.rvListadoProductos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvListadoProductos.LocalReport.ReportEmbeddedResource = "ProyectoPAV.listadoProductos.rdlc"
        Me.rvListadoProductos.Location = New System.Drawing.Point(12, 76)
        Me.rvListadoProductos.Name = "rvListadoProductos"
        Me.rvListadoProductos.Size = New System.Drawing.Size(1311, 656)
        Me.rvListadoProductos.TabIndex = 17
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(1211, 32)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(112, 38)
        Me.cmdConsultar.TabIndex = 16
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Location = New System.Drawing.Point(492, 12)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaHasta.TabIndex = 15
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Location = New System.Drawing.Point(422, 17)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(64, 17)
        Me.lblFechaHasta.TabIndex = 14
        Me.lblFechaHasta.Text = "Hasta el:"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Location = New System.Drawing.Point(174, 12)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaDesde.TabIndex = 13
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Location = New System.Drawing.Point(12, 17)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(156, 17)
        Me.lblFechaDesde.TabIndex = 12
        Me.lblFechaDesde.Text = "Fecha de alta desde el:"
        '
        'lblTipoProducto
        '
        Me.lblTipoProducto.AutoSize = True
        Me.lblTipoProducto.Location = New System.Drawing.Point(12, 49)
        Me.lblTipoProducto.Name = "lblTipoProducto"
        Me.lblTipoProducto.Size = New System.Drawing.Size(121, 17)
        Me.lblTipoProducto.TabIndex = 18
        Me.lblTipoProducto.Text = "Tipo de Producto:"
        '
        'lblStockMayorA
        '
        Me.lblStockMayorA.AutoSize = True
        Me.lblStockMayorA.Location = New System.Drawing.Point(384, 49)
        Me.lblStockMayorA.Name = "lblStockMayorA"
        Me.lblStockMayorA.Size = New System.Drawing.Size(102, 17)
        Me.lblStockMayorA.TabIndex = 19
        Me.lblStockMayorA.Text = "Stock mayor a:"
        '
        'cmbTipoProducto
        '
        Me.cmbTipoProducto.FormattingEnabled = True
        Me.cmbTipoProducto.Location = New System.Drawing.Point(139, 46)
        Me.cmbTipoProducto.Name = "cmbTipoProducto"
        Me.cmbTipoProducto.Size = New System.Drawing.Size(163, 24)
        Me.cmbTipoProducto.TabIndex = 20
        '
        'txtStockMenorA
        '
        Me.txtStockMenorA.Location = New System.Drawing.Point(749, 46)
        Me.txtStockMenorA.Name = "txtStockMenorA"
        Me.txtStockMenorA.Size = New System.Drawing.Size(100, 22)
        Me.txtStockMenorA.TabIndex = 21
        '
        'txtStockMayorA
        '
        Me.txtStockMayorA.Location = New System.Drawing.Point(492, 46)
        Me.txtStockMayorA.Name = "txtStockMayorA"
        Me.txtStockMayorA.Size = New System.Drawing.Size(100, 22)
        Me.txtStockMayorA.TabIndex = 23
        '
        'lblStockMenorA
        '
        Me.lblStockMenorA.AutoSize = True
        Me.lblStockMenorA.Location = New System.Drawing.Point(640, 49)
        Me.lblStockMenorA.Name = "lblStockMenorA"
        Me.lblStockMenorA.Size = New System.Drawing.Size(103, 17)
        Me.lblStockMenorA.TabIndex = 22
        Me.lblStockMenorA.Text = "Stock menor a:"
        '
        'frmListadoProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 744)
        Me.Controls.Add(Me.txtStockMayorA)
        Me.Controls.Add(Me.lblStockMenorA)
        Me.Controls.Add(Me.txtStockMenorA)
        Me.Controls.Add(Me.cmbTipoProducto)
        Me.Controls.Add(Me.lblStockMayorA)
        Me.Controls.Add(Me.lblTipoProducto)
        Me.Controls.Add(Me.rvListadoProductos)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.lblFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.Controls.Add(Me.lblFechaDesde)
        Me.Name = "frmListadoProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Productos"
        CType(Me.ListadoProductos_ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvListadoProductos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents lblTipoProducto As System.Windows.Forms.Label
    Friend WithEvents lblStockMayorA As System.Windows.Forms.Label
    Friend WithEvents cmbTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents txtStockMenorA As System.Windows.Forms.TextBox
    Friend WithEvents txtStockMayorA As System.Windows.Forms.TextBox
    Friend WithEvents lblStockMenorA As System.Windows.Forms.Label
    Friend WithEvents ListadoProductos_ResultBindingSource As System.Windows.Forms.BindingSource
End Class
