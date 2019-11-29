<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoMontosPorCliente
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.cmbProvincias = New System.Windows.Forms.ComboBox()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.rvMontosPorCliente = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.MontoTotalPorCliente_ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MontoTotalPorCliente_ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbProvincias
        '
        Me.cmbProvincias.FormattingEnabled = True
        Me.cmbProvincias.Location = New System.Drawing.Point(196, 50)
        Me.cmbProvincias.Name = "cmbProvincias"
        Me.cmbProvincias.Size = New System.Drawing.Size(200, 24)
        Me.cmbProvincias.TabIndex = 23
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(12, 53)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(178, 17)
        Me.lblProvincia.TabIndex = 22
        Me.lblProvincia.Text = "Clientes de la provincia de:"
        '
        'rvMontosPorCliente
        '
        ReportDataSource2.Name = "MontosPorClienteDataSet"
        ReportDataSource2.Value = Me.MontoTotalPorCliente_ResultBindingSource
        Me.rvMontosPorCliente.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rvMontosPorCliente.LocalReport.ReportEmbeddedResource = "ProyectoPAV.informeMontosPorCliente.rdlc"
        Me.rvMontosPorCliente.Location = New System.Drawing.Point(15, 85)
        Me.rvMontosPorCliente.Name = "rvMontosPorCliente"
        Me.rvMontosPorCliente.Size = New System.Drawing.Size(1021, 667)
        Me.rvMontosPorCliente.TabIndex = 21
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(924, 32)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(112, 38)
        Me.cmdConsultar.TabIndex = 20
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Location = New System.Drawing.Point(568, 9)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(273, 22)
        Me.dtpFechaHasta.TabIndex = 19
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Location = New System.Drawing.Point(513, 14)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(49, 17)
        Me.lblFechaHasta.TabIndex = 18
        Me.lblFechaHasta.Text = "Hasta:"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Location = New System.Drawing.Point(132, 9)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(264, 22)
        Me.dtpFechaDesde.TabIndex = 17
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Location = New System.Drawing.Point(12, 14)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(114, 17)
        Me.lblFechaDesde.TabIndex = 16
        Me.lblFechaDesde.Text = "Ventas desde el:"
        '
        'MontoTotalPorCliente_ResultBindingSource
        '
        Me.MontoTotalPorCliente_ResultBindingSource.DataSource = GetType(ProyectoPAV.MontoTotalPorCliente_Result)
        '
        'frmListadoMontosPorCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 765)
        Me.Controls.Add(Me.cmbProvincias)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.rvMontosPorCliente)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.lblFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.Controls.Add(Me.lblFechaDesde)
        Me.Name = "frmListadoMontosPorCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monto Total Comprado Por Cada Cliente"
        CType(Me.MontoTotalPorCliente_ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbProvincias As System.Windows.Forms.ComboBox
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents rvMontosPorCliente As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents MontoTotalPorCliente_ResultBindingSource As System.Windows.Forms.BindingSource
End Class
