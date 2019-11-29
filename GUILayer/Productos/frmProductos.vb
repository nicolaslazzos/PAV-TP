Public Class frmProductos
    Friend rowSelected As DataGridViewRow

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabProducto.SelectedTab = tabNuevo

        tabProducto.TabPages("tabModificar").Enabled = False
        cmdModificar.Enabled = False
        cmdEliminar.Enabled = False
        cmdAgregar.Enabled = False
        cmdAgregar.Visible = False

        llenarCombo(cmbTipoProducto, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM TiposProducto"), "nombre", "codTipoProducto")
        llenarCombo(cmbUnidadMedida, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM UnidadesMedida"), "nombre", "codUnidad")

        clearComponents()
        dgvProductos.Rows.Clear()
        llenarGrid()
    End Sub

    Private Sub clearComponents()
        'TAB NUEVO
        txtCodigo.Text = ""
        cmbTipoProducto.Text = ""
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtStockMax.Text = ""
        txtStockMin.Text = ""
        txtStockActual.Text = ""
        cmbUnidadMedida.Text = ""
        txtPrecio.Text = ""
        'TAB MODIFICAR
        txtCodigo2.Text = ""
        cmbTipoProducto2.Text = ""
        txtNombre2.Text = ""
        txtDescripcion2.Text = ""
        txtStockMax2.Text = ""
        txtStockMin2.Text = ""
        txtStockActual2.Text = ""
        cmbUnidadMedida2.Text = ""
        txtPrecio2.Text = ""
        txtCantidad.Text = ""
        rbtAgregar.Checked = False
        rbtQuitar.Checked = False
    End Sub

    Private Sub cmbVaciarCampos_Click(sender As Object, e As EventArgs) Handles cmdVaciarCampos.Click
        clearComponents()
    End Sub
    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub
    Private Sub llenarGrid(ByVal source As DataTable)
        dgvProductos.Rows.Clear()
        For Each fila As DataRow In source.Rows
            dgvProductos.Rows.Add(New String() {fila.Item("CodProducto").ToString, fila.Item("NombreTipoProducto").ToString, fila.Item("NombreProducto").ToString, fila.Item("DescripcionProducto").ToString, fila.Item("StockMax").ToString, fila.Item("StockMin").ToString, fila.Item("StockActual").ToString, fila.Item("NombreUnidadMedida").ToString, fila.Item("PrecioVenta").ToString})
        Next
    End Sub

    Private Sub llenarGrid()
        Dim Str As String = "SELECT p.codProducto AS CodProducto, tp.nombre AS NombreTipoProducto, p.nombre AS NombreProducto, p.descripcion AS DescripcionProducto, "
        Str &= "p.stockMax AS StockMax, p.stockMin AS StockMin, p.stockActual AS StockActual, um.nombre AS NombreUnidadMedida, p.precioVenta AS PrecioVenta "
        Str &= "FROM Productos p INNER JOIN TiposProducto tp ON (p.codTipoProducto = tp.codTipoProducto) INNER JOIN UnidadesMedida um ON (p.codUnidadMedida = um.codUnidad) WHERE p.bajaLogica='False'"

        Dim source As DataTable
        source = BDHelper.getDBHelper.ConsultaSQL(Str)
        dgvProductos.Rows.Clear()
        For Each fila As DataRow In source.Rows
            dgvProductos.Rows.Add(New String() {fila.Item("CodProducto").ToString, fila.Item("NombreTipoProducto").ToString, fila.Item("NombreProducto").ToString, fila.Item("DescripcionProducto").ToString, fila.Item("StockMax").ToString, fila.Item("StockMin").ToString, fila.Item("StockActual").ToString, fila.Item("NombreUnidadMedida").ToString, fila.Item("PrecioVenta").ToString})
        Next
    End Sub
    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
        cmdEliminar.Enabled = True
        cmdModificar.Enabled = True
        cmdAgregar.Enabled = True
        rowSelected = dgvProductos.CurrentRow
    End Sub
    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim validar As DataTable
        Dim filters As New List(Of Object)
        Dim str As String = "INSERT INTO Productos(codProducto, codTipoProducto, nombre, descripcion, stockActual, stockMax, stockMin, codUnidadMedida, precioVenta, fechaAlta) VALUES(@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10)"

        If txtCodigo.Text <> String.Empty Then
            filters.Add(txtCodigo.Text)
        Else
            Mensajes.mostrarError("Debe ingresar el codigo del producto!")
            Return
        End If

        If cmbTipoProducto.Text <> String.Empty Then
            filters.Add(cmbTipoProducto.SelectedValue)
        Else
            MessageBox.Show("Debe seleccionar que tipo de producto es!")
            Return
        End If

        If txtNombre.Text <> String.Empty Then
            filters.Add(txtNombre.Text)
        Else
            MessageBox.Show("Debe ingresar el nombre del producto!")
            Return
        End If

        filters.Add(txtDescripcion.Text)

        If IsNumeric(txtStockMax.Text) And IsNumeric(txtStockMin.Text) And IsNumeric(txtStockActual.Text) Then
            If txtStockMax.Text >= 0 And txtStockMin.Text >= 0 And txtStockActual.Text >= 0 Then
                filters.Add(txtStockActual.Text)
                filters.Add(txtStockMax.Text)
                filters.Add(txtStockMin.Text)
            Else
                MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
                Return
            End If
        Else
            MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
            Return
        End If

        If cmbUnidadMedida.Text <> String.Empty Then
            filters.Add(cmbUnidadMedida.SelectedValue)
        Else
            MessageBox.Show("Debe seleccionar una unidad de medida!")
            Return
        End If

        If IsNumeric(txtPrecio.Text) Then
            If txtPrecio.Text >= 0 Then
                filters.Add(txtPrecio.Text)
            Else
                MessageBox.Show("Solo se aceptan valores de 'Precio' que sean numeros positivos!")
                Return
            End If
        Else
            MessageBox.Show("Solo se aceptan valores de 'Precio' que sean numeros positivos!")
            Return
        End If

        filters.Add(Date.Now.ToString("yyyy/MM/dd"))

        validar = BDHelper.getDBHelper.ConsultaSQL("SELECT codProducto FROM Productos WHERE codProducto='" & txtCodigo.Text & "'")
        If validar.Rows.Count > 0 Then
            Mensajes.mostrarError("Ya existe un producto con el Codigo ingresado!")
        Else
            BDHelper.getDBHelper.EjecutarSQLConParametros(str, filters.ToArray())
            llenarGrid()
        End If
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim filters As New List(Of Object)
        Dim str As String = "SELECT p.codProducto AS CodProducto, tp.nombre AS NombreTipoProducto, p.nombre AS NombreProducto, p.descripcion AS DescripcionProducto, "
        str &= "p.stockMax AS StockMax, p.stockMin AS StockMin, p.stockActual AS StockActual, um.nombre AS NombreUnidadMedida, p.precioVenta AS PrecioVenta "
        str &= "FROM Productos p INNER JOIN TiposProducto tp ON (p.codTipoProducto = tp.codTipoProducto) INNER JOIN UnidadesMedida um ON (p.codUnidadMedida = um.codUnidad) WHERE p.bajaLogica='False'"

        If txtCodigo.Text <> String.Empty Then
            filters.Add(txtCodigo.Text)
            str += " AND p.codProducto=@param1"
        Else
            filters.Add(Nothing)
        End If

        If cmbTipoProducto.Text <> String.Empty Then
            filters.Add(cmbTipoProducto.SelectedValue)
            str += " AND p.codTipoProducto=@param2"
        Else
            filters.Add(Nothing)
        End If

        If txtNombre.Text <> String.Empty Then
            filters.Add(txtNombre.Text)
            str += " AND p.nombre=@param3"
        Else
            filters.Add(Nothing)
        End If

        If txtDescripcion.Text <> String.Empty Then
            filters.Add(txtDescripcion.Text)
            str += " AND p.descripcion=@param4"
        Else
            filters.Add(Nothing)
        End If

        If txtStockMax.Text <> String.Empty And IsNumeric(txtStockMax.Text) Then
            If txtStockMax.Text >= 0 Then
                filters.Add(txtStockMax.Text)
                str += " AND p.stockMax=@param5"
            Else
                MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
                Return
            End If
        ElseIf txtStockMax.Text <> String.Empty And Not IsNumeric(txtStockMax.Text) Then
            MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
            Return
        Else
            filters.Add(Nothing)
        End If

        If txtStockMin.Text <> String.Empty And IsNumeric(txtStockMin.Text) Then
            If txtStockMin.Text >= 0 Then
                filters.Add(txtStockMin.Text)
                str += " AND p.stockMin=@param6"
            Else
                MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
                Return
            End If
        ElseIf txtStockMin.Text <> String.Empty And Not IsNumeric(txtStockMin.Text) Then
            MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
            Return
        Else
            filters.Add(Nothing)
        End If

        If txtStockActual.Text <> String.Empty And IsNumeric(txtStockActual.Text) Then
            If txtStockActual.Text >= 0 Then
                filters.Add(txtStockActual.Text)
                str += " AND p.stockActual=@param7"
            Else
                MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
                Return
            End If
        ElseIf txtStockActual.Text <> String.Empty And Not IsNumeric(txtStockActual.Text) Then
            MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
            Return
        Else
            filters.Add(Nothing)
        End If

        If cmbUnidadMedida.Text <> String.Empty Then
            filters.Add(cmbUnidadMedida.SelectedValue)
            str += " AND p.codUnidadMedida=@param8"
        Else
            filters.Add(Nothing)
        End If

        If txtPrecio.Text <> String.Empty And IsNumeric(txtPrecio.Text) Then
            If txtPrecio.Text >= 0 Then
                filters.Add(txtPrecio.Text)
                str += " AND p.precioVenta=@param9"
            Else
                MessageBox.Show("Solo de aceptan valores de 'Precio' que sean numeros positivos!")
                Return
            End If
        ElseIf txtPrecio.Text <> String.Empty And Not IsNumeric(txtPrecio.Text) Then
            MessageBox.Show("Solo de aceptan valores de 'Precio' que sean numeros positivos!")
            Return
        Else
            filters.Add(Nothing)
        End If

        llenarGrid(BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray()))

        If dgvProductos.Rows.Count = 0 Then
            mostrarAviso("No se encontraron coincidencias")
        End If

        cmdModificar.Enabled = False
        cmdEliminar.Enabled = False
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim filters As New List(Of Object)
        Dim Str As String = "UPDATE Productos SET bajaLogica='True' WHERE codProducto=@param1"

        filters.Add(rowSelected.Cells("colCodigo").Value)

        If Mensajes.deseaEliminar = 1 Then
            BDHelper.getDBHelper.EjecutarSQLConParametros(Str, filters.ToArray())
            llenarGrid()
        End If
    End Sub
    'PESTAÑA MODIFICAR
    'PESTAÑA MODIFICAR
    'PESTAÑA MODIFICAR
    'PESTAÑA MODIFICAR
    Private Sub tabModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        tabProducto.SelectedTab = tabModificar
        tabProducto.TabPages("tabModificar").Enabled = True

        llenarCombo(cmbTipoProducto2, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM TiposProducto"), "nombre", "codTipoProducto")
        llenarCombo(cmbUnidadMedida2, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM UnidadesMedida"), "nombre", "codUnidad")

        With rowSelected
            txtCodigo2.Text = .Cells("colCodigo").Value
            cmbTipoProducto2.Text = .Cells("colTipoProducto").Value
            txtNombre2.Text = .Cells("colNombre").Value
            txtDescripcion2.Text = .Cells("colDescripcion").Value
            txtStockMax2.Text = .Cells("colStockMax").Value
            txtStockMin2.Text = .Cells("colStockMin").Value
            txtStockActual2.Text = .Cells("colStockActual").Value
            cmbUnidadMedida2.Text = .Cells("colUnidadMedida").Value
            txtPrecio2.Text = .Cells("colPrecio").Value
        End With
    End Sub

    Private Sub cmdGuardarCambios_Click(sender As Object, e As EventArgs) Handles cmdGuardarCambios.Click
        Dim filters As New List(Of Object)
        Dim str As String = "UPDATE Productos SET codTipoProducto=@param2, nombre=@param3, descripcion=@param4, stockMax=@param5, "
        str += "stockMin=@param6, stockActual=@param7, codUnidadMedida=@param8, precioVenta=@param9 WHERE codProducto=@param1"

        filters.Add(txtCodigo2.Text)

        If cmbTipoProducto2.Text <> String.Empty Then
            filters.Add(cmbTipoProducto2.SelectedValue)
        Else
            filters.Add(Nothing)
        End If

        If txtNombre2.Text <> String.Empty Then
            filters.Add(txtNombre2.Text)
        Else
            filters.Add("")
        End If

        If txtDescripcion2.Text <> String.Empty Then
            filters.Add(txtDescripcion2.Text)
        Else
            filters.Add("")
        End If

        If txtStockMax2.Text <> String.Empty And IsNumeric(txtStockMax2.Text) Then
            If txtStockMax2.Text >= 0 Then
                filters.Add(txtStockMax2.Text)
            Else
                MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
                Return
            End If
        ElseIf txtStockMax2.Text <> String.Empty And Not IsNumeric(txtStockMax2.Text) Then
            MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
            Return
        Else
            filters.Add(0)
        End If

        If txtStockMin2.Text <> String.Empty And IsNumeric(txtStockMin2.Text) Then
            If txtStockMin2.Text >= 0 Then
                filters.Add(txtStockMin2.Text)
            Else
                MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
                Return
            End If
        ElseIf txtStockMin2.Text <> String.Empty And Not IsNumeric(txtStockMin2.Text) Then
            MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
            Return
        Else
            filters.Add(0)
        End If

        If txtCantidad.Text = String.Empty Then
            filters.Add(txtStockActual2.Text)
        ElseIf txtCantidad.Text <> String.Empty And IsNumeric(txtCantidad.Text) And (rbtAgregar.Checked Or rbtQuitar.Checked) Then
            If txtCantidad.Text >= 0 Then
                Dim nuevoStock As Integer
                If rbtAgregar.Checked Then
                    nuevoStock = Integer.Parse(txtStockActual2.Text) + Integer.Parse(txtCantidad.Text)
                    filters.Add(nuevoStock)
                End If
                If rbtQuitar.Checked And (txtStockActual2.Text >= txtCantidad.Text) Then
                    nuevoStock = Integer.Parse(txtStockActual2.Text) - Integer.Parse(txtCantidad.Text)
                    filters.Add(nuevoStock)
                ElseIf rbtQuitar.Checked And (txtStockActual2.Text < txtCantidad.Text) Then
                    MessageBox.Show("No se puede quitar mas cantidad de stock que la existente!")
                    Return
                End If
            Else
                MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
                Return
            End If
        ElseIf txtCantidad.Text <> String.Empty And Not IsNumeric(txtCantidad.Text) Then
            MessageBox.Show("Solo de aceptan valores de 'Stock' que sean numeros positivos!")
            Return
        ElseIf txtCantidad.Text <> String.Empty And Not rbtAgregar.Checked And Not rbtQuitar.Checked Then
            MessageBox.Show("Debe seleccionar si desea agregar o quitar la cantidad de stock indicada!")
            Return
        End If

        If cmbUnidadMedida2.Text <> String.Empty Then
            filters.Add(cmbUnidadMedida2.SelectedValue)
        Else
            filters.Add(Nothing)
        End If

        If txtPrecio2.Text <> String.Empty And IsNumeric(txtPrecio2.Text) Then
            If txtPrecio2.Text >= 0 Then
                filters.Add(txtPrecio2.Text)
            Else
                MessageBox.Show("Solo de aceptan valores de 'Precio' que sean numeros positivos!")
                Return
            End If
        ElseIf txtPrecio2.Text <> String.Empty And Not IsNumeric(txtPrecio2.Text) Then
            MessageBox.Show("Solo de aceptan valores de 'Precio' que sean numeros positivos!")
            Return
        Else
            filters.Add(0)
        End If

        If Mensajes.deseaModificar Then
            BDHelper.getDBHelper.EjecutarSQLConParametros(str, filters.ToArray())
        End If

        tabProducto.SelectedTab = tabNuevo
        cmdEliminar.Enabled = False
        cmdModificar.Enabled = False
        llenarGrid()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        tabProducto.SelectedTab = tabNuevo
        tabProducto.TabPages("tabModificar").Enabled = False
        clearComponents()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim selectedRow As DataGridViewRow = dgvProductos.CurrentRow
        frmFacturacion.cmbProductos.SelectedValue = selectedRow.Cells("colCodigo").Value

        Dim filters As New List(Of Object)
        Dim str As String = "SELECT p.precioVenta, p.codTipoProducto, p.nombre AS NombreProd, p.stockActual, u.nombre FROM Productos p INNER JOIN UnidadesMedida u ON (p.codUnidadMedida = u.codUnidad) WHERE codProducto=@param1"
        filters.Add(selectedRow.Cells("colCodigo").Value.ToString)

        Dim source As DataTable
        source = BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray)
        For Each fila As DataRow In source.Rows
            frmFacturacion.producto.codProducto = selectedRow.Cells("colCodigo").Value.ToString
            frmFacturacion.producto.codTipoProducto = Integer.Parse(fila.Item("codTipoProducto"))
            frmFacturacion.producto.nombre = fila.Item("NombreProd").ToString
            frmFacturacion.producto.stockActual = Integer.Parse(fila.Item("stockActual"))
            frmFacturacion.producto.precio = Convert.ToDouble(fila.Item("precioVenta"))
            frmFacturacion.producto.unidadMedida = fila.Item("nombre").ToString
        Next

        frmFacturacion.lblStockActual.Text = "Stock Disponible: " & frmFacturacion.producto.stockActual & " " & frmFacturacion.producto.unidadMedida
        frmFacturacion.lblPrecio.Text = "Precio: $ " & frmFacturacion.producto.precio

        Me.Close()
    End Sub
End Class