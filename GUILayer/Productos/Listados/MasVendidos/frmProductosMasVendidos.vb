Imports Microsoft.Reporting.WinForms
Public Class frmProductosMasVendidos
    Private Sub frmProductosMasVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rvProductosMasVendidos.RefreshReport()
        dtpFechaDesde.Value = Date.Now
        dtpFechaHasta.Value = Date.Now
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim db As ProductosMasVendidosEntities = New ProductosMasVendidosEntities()
        ProductosMasVendidos_ResultBindingSource.DataSource = db.ProductosMasVendidos(dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date).ToList
        Dim parametros As New List(Of ReportParameter)
        parametros.Add(New ReportParameter("fechaDesde", dtpFechaDesde.Value.Date.ToString("yyyy/MM/dd")))
        parametros.Add(New ReportParameter("fechaHasta", dtpFechaHasta.Value.Date.ToString("yyyy/MM/dd")))
        rvProductosMasVendidos.LocalReport.SetParameters(parametros)
        rvProductosMasVendidos.RefreshReport()
    End Sub
End Class