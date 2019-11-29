Imports Microsoft.Reporting.WinForms
Public Class frmProductosPorCliente

    Private Sub frmProductosPorCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rvProductosPorCliente.RefreshReport()
        frmClientes.llenarCombo(cmbProvincias, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Provincias"), "nombre", "codProvincia")
        frmProductos.llenarCombo(cmbTiposProducto, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM TiposProducto"), "nombre", "codTipoProducto")
        dtpFechaDesde.Value = Date.Now
        dtpFechaHasta.Value = Date.Now
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim db As ProductosPorClienteEntities = New ProductosPorClienteEntities()
        ProductosPorCliente_ResultBindingSource.DataSource = db.ProductosPorCliente(dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date, Integer.Parse(cmbTiposProducto.SelectedValue), Integer.Parse(cmbProvincias.SelectedValue))
        Dim parametros As New List(Of ReportParameter)
        parametros.Add(New ReportParameter("fechaDesde", dtpFechaDesde.Value.Date.ToString("yyyy/MM/dd")))
        parametros.Add(New ReportParameter("fechaHasta", dtpFechaHasta.Value.Date.ToString("yyyy/MM/dd")))
        parametros.Add(New ReportParameter("tipoProducto", Integer.Parse(cmbTiposProducto.SelectedValue)))
        parametros.Add(New ReportParameter("provincia", Integer.Parse(cmbProvincias.SelectedValue)))
        rvProductosPorCliente.LocalReport.SetParameters(parametros)
        rvProductosPorCliente.RefreshReport()
    End Sub
End Class