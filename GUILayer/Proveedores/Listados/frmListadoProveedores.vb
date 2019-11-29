Imports Microsoft.Reporting.WinForms
Public Class frmListadoProveedores

    Private Sub frmListadoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rvListadoProveedores.RefreshReport()
        frmClientes.llenarCombo(cmbProvincias, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Provincias"), "nombre", "codProvincia")
        dtpFechaDesde.Value = Date.Now
        dtpFechaHasta.Value = Date.Now
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim db As ProveedoresEntities = New ProveedoresEntities()
        ListadoClientes_ResultBindingSource.DataSource = db.ListadoProveedores(dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date, Integer.Parse(cmbProvincias.SelectedValue))
        Dim parametros As New List(Of ReportParameter)
        parametros.Add(New ReportParameter("fechaDesde", dtpFechaDesde.Value.Date.ToString("yyyy/MM/dd")))
        parametros.Add(New ReportParameter("fechaHasta", dtpFechaHasta.Value.Date.ToString("yyyy/MM/dd")))
        parametros.Add(New ReportParameter("provincia", Integer.Parse(cmbProvincias.SelectedValue)))
        rvListadoProveedores.LocalReport.SetParameters(parametros)
        rvListadoProveedores.RefreshReport()
    End Sub
End Class