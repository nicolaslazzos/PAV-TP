Imports Microsoft.Reporting.WinForms
Public Class frmListadoClientes
    Private Sub frmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rvListadoClientes.RefreshReport()
        dtpFechaDesde.Value = Date.Now
        dtpFechaHasta.Value = Date.Now
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim db As TinescoEntities = New TinescoEntities()
        ListadoClientes_ResultBindingSource.DataSource = db.ListadoClientes(dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date).ToList
        Dim parametros As New List(Of ReportParameter)
        parametros.Add(New ReportParameter("fechaDesde", dtpFechaDesde.Value.Date.ToString("yyyy/MM/dd")))
        parametros.Add(New ReportParameter("fechaHasta", dtpFechaHasta.Value.Date.ToString("yyyy/MM/dd")))
        rvListadoClientes.LocalReport.SetParameters(parametros)
        rvListadoClientes.RefreshReport()
    End Sub
End Class