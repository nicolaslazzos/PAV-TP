<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosMasVendidos
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
        Me.rvProductosMasVendidos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.ProductosMasVendidos_ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ProductosMasVendidos_ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvProductosMasVendidos
        '
        ReportDataSource1.Name = "ProductosMasVendidosDataSet"
        ReportDataSource1.Value = Me.ProductosMasVendidos_ResultBindingSource
        Me.rvProductosMasVendidos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvProductosMasVendidos.LocalReport.ReportEmbeddedResource = "ProyectoPAV.informeProductosMasVendidos.rdlc"
        Me.rvProductosMasVendidos.Location = New System.Drawing.Point(12, 51)
        Me.rvProductosMasVendidos.Name = "rvProductosMasVendidos"
        Me.rvProductosMasVendidos.Size = New System.Drawing.Size(915, 569)
        Me.rvProductosMasVendidos.TabIndex = 11
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(815, 7)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(112, 38)
        Me.cmdConsultar.TabIndex = 10
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Location = New System.Drawing.Point(492, 13)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaHasta.TabIndex = 9
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Location = New System.Drawing.Point(422, 18)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(64, 17)
        Me.lblFechaHasta.TabIndex = 8
        Me.lblFechaHasta.Text = "Hasta el:"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Location = New System.Drawing.Point(132, 13)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaDesde.TabIndex = 7
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Location = New System.Drawing.Point(12, 18)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(114, 17)
        Me.lblFechaDesde.TabIndex = 6
        Me.lblFechaDesde.Text = "Ventas desde el:"
        '
        'ProductosMasVendidos_ResultBindingSource
        '
        Me.ProductosMasVendidos_ResultBindingSource.DataSource = GetType(ProyectoPAV.ProductosMasVendidos_Result)
        '
        'frmProductosMasVendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 632)
        Me.Controls.Add(Me.rvProductosMasVendidos)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.lblFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.Controls.Add(Me.lblFechaDesde)
        Me.Name = "frmProductosMasVendidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos Mas Vendidos"
        CType(Me.ProductosMasVendidos_ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvProductosMasVendidos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents ProductosMasVendidos_ResultBindingSource As System.Windows.Forms.BindingSource
End Class
