Imports Microsoft.Reporting.WinForms
Public Class frmListadoProductos

    Private Sub frmListadoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rvListadoProductos.RefreshReport()
        frmProductos.llenarCombo(cmbTipoProducto, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM TiposProducto"), "nombre", "codTipoProducto")
        dtpFechaDesde.Value = Date.Now
        dtpFechaHasta.Value = Date.Now
        txtStockMayorA.Text = ""
        txtStockMenorA.Text = ""
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim db As ProductosEntities = New ProductosEntities()
        ListadoProductos_ResultBindingSource.DataSource = db.ListadoProductos(dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date, Integer.Parse(cmbTipoProducto.SelectedValue), Integer.Parse(txtStockMayorA.Text), Integer.Parse(txtStockMenorA.Text)).ToList
        Dim parametros As New List(Of ReportParameter)
        parametros.Add(New ReportParameter("fechaDesde", dtpFechaDesde.Value.Date.ToString("yyyy/MM/dd")))
        parametros.Add(New ReportParameter("fechaHasta", dtpFechaHasta.Value.Date.ToString("yyyy/MM/dd")))
        parametros.Add(New ReportParameter("tipoProducto", Integer.Parse(cmbTipoProducto.SelectedValue)))
        parametros.Add(New ReportParameter("stockMayorA", Integer.Parse(txtStockMayorA.Text)))
        parametros.Add(New ReportParameter("stockMenorA", Integer.Parse(txtStockMenorA.Text)))
        rvListadoProductos.LocalReport.SetParameters(parametros)
        rvListadoProductos.RefreshReport()
    End Sub
End Class