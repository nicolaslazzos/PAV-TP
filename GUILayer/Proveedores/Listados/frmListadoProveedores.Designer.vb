<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoProveedores
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
        Me.ListadoClientes_ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rvListadoProveedores = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.cmbProvincias = New System.Windows.Forms.ComboBox()
        Me.lblProvincia = New System.Windows.Forms.Label()
        CType(Me.ListadoClientes_ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListadoClientes_ResultBindingSource
        '
        Me.ListadoClientes_ResultBindingSource.DataSource = GetType(ProyectoPAV.ListadoClientes_Result)
        '
        'rvListadoProveedores
        '
        ReportDataSource1.Name = "ProveedoresDataSet"
        ReportDataSource1.Value = Me.ListadoClientes_ResultBindingSource
        Me.rvListadoProveedores.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvListadoProveedores.LocalReport.ReportEmbeddedResource = "ProyectoPAV.listadoProveedores.rdlc"
        Me.rvListadoProveedores.Location = New System.Drawing.Point(12, 90)
        Me.rvListadoProveedores.Name = "rvListadoProveedores"
        Me.rvListadoProveedores.Size = New System.Drawing.Size(1042, 570)
        Me.rvListadoProveedores.TabIndex = 11
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(942, 36)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(112, 38)
        Me.cmdConsultar.TabIndex = 10
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Location = New System.Drawing.Point(464, 13)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaHasta.TabIndex = 9
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Location = New System.Drawing.Point(394, 18)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(64, 17)
        Me.lblFechaHasta.TabIndex = 8
        Me.lblFechaHasta.Text = "Hasta el:"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Location = New System.Drawing.Point(174, 13)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaDesde.TabIndex = 7
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Location = New System.Drawing.Point(12, 18)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(156, 17)
        Me.lblFechaDesde.TabIndex = 6
        Me.lblFechaDesde.Text = "Fecha de alta desde el:"
        '
        'cmbProvincias
        '
        Me.cmbProvincias.FormattingEnabled = True
        Me.cmbProvincias.Location = New System.Drawing.Point(174, 50)
        Me.cmbProvincias.Name = "cmbProvincias"
        Me.cmbProvincias.Size = New System.Drawing.Size(200, 24)
        Me.cmbProvincias.TabIndex = 16
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(38, 53)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(130, 17)
        Me.lblProvincia.TabIndex = 17
        Me.lblProvincia.Text = " De la provincia de:"
        '
        'frmListadoProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 672)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.cmbProvincias)
        Me.Controls.Add(Me.rvListadoProveedores)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.lblFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.Controls.Add(Me.lblFechaDesde)
        Me.Name = "frmListadoProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Proveedores"
        CType(Me.ListadoClientes_ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvListadoProveedores As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents cmbProvincias As System.Windows.Forms.ComboBox
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents ListadoClientes_ResultBindingSource As System.Windows.Forms.BindingSource
End Class
