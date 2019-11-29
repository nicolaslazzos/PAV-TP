<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoClientes
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
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.rvListadoClientes = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ListadoClientes_ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListadoClientes_ResultBindingSource
        '
        Me.ListadoClientes_ResultBindingSource.DataSource = GetType(ProyectoPAV.ListadoClientes_Result)
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Location = New System.Drawing.Point(12, 19)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(144, 17)
        Me.lblFechaDesde.TabIndex = 0
        Me.lblFechaDesde.Text = "Fecha de Alta Desde:"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Location = New System.Drawing.Point(162, 14)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaDesde.TabIndex = 1
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Location = New System.Drawing.Point(422, 19)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(140, 17)
        Me.lblFechaHasta.TabIndex = 2
        Me.lblFechaHasta.Text = "Fecha de Alta Hasta:"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Location = New System.Drawing.Point(568, 14)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaHasta.TabIndex = 3
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(920, 8)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(112, 38)
        Me.cmdConsultar.TabIndex = 4
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'rvListadoClientes
        '
        ReportDataSource1.Name = "ClientesDataSet"
        ReportDataSource1.Value = Me.ListadoClientes_ResultBindingSource
        Me.rvListadoClientes.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvListadoClientes.LocalReport.ReportEmbeddedResource = "ProyectoPAV.listadoClientes.rdlc"
        Me.rvListadoClientes.Location = New System.Drawing.Point(12, 52)
        Me.rvListadoClientes.Name = "rvListadoClientes"
        Me.rvListadoClientes.Size = New System.Drawing.Size(1020, 516)
        Me.rvListadoClientes.TabIndex = 5
        '
        'frmListadoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 580)
        Me.Controls.Add(Me.rvListadoClientes)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.lblFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.Controls.Add(Me.lblFechaDesde)
        Me.Name = "frmListadoClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Clientes"
        CType(Me.ListadoClientes_ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents rvListadoClientes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ListadoClientes_ResultBindingSource As System.Windows.Forms.BindingSource
End Class
