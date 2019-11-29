Imports System.Data.SqlClient
Public Class frmFacturacion
    Friend producto As New Producto
    Private Sub frmFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo(cmbTipoFactura, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM TiposFactura"), "nombre", "codTipoFactura")
        llenarCombo(cmbClientes, BDHelper.getDBHelper.ConsultaSQL("SELECT razonSocial, CUIT FROM Clientes WHERE bajaLogica='False'"), "razonSocial", "CUIT")
        llenarCombo(cmbProductos, BDHelper.getDBHelper.ConsultaSQL("SELECT nombre, codProducto FROM Productos WHERE bajaLogica='False'"), "nombre", "codProducto")

        txtFecha.Text = Date.Now.ToString("dd/MM/yyyy")
        txtDescuento.Text = 0
        txtTotal.Text = 0
        txtSubtotal1.Text = 0
        txtNroFactura.Text = ""
    End Sub

    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    Private Sub cmbProductos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbProductos.SelectionChangeCommitted
        Dim filters As New List(Of Object)
        Dim str As String = "SELECT p.precioVenta, p.codTipoProducto, p.nombre AS NombreProd, p.stockActual, u.nombre FROM Productos p INNER JOIN UnidadesMedida u ON (p.codUnidadMedida = u.codUnidad) WHERE codProducto=@param1"
        filters.Add(cmbProductos.SelectedValue)

        Dim source As DataTable
        source = BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray)
        For Each fila As DataRow In source.Rows
            producto.codProducto = cmbProductos.SelectedValue.ToString
            producto.codTipoProducto = Integer.Parse(fila.Item("codTipoProducto"))
            producto.nombre = fila.Item("NombreProd").ToString
            producto.stockActual = Integer.Parse(fila.Item("stockActual"))
            producto.precio = Convert.ToDouble(fila.Item("precioVenta"))
            producto.unidadMedida = fila.Item("nombre").ToString
        Next

        lblStockActual.Text = "Stock Disponible: " & producto.stockActual & " " & producto.unidadMedida
        lblPrecio.Text = "Precio: $ " & producto.precio
    End Sub
    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If txtCantidad.Text <> String.Empty And IsNumeric(txtCantidad.Text) Then
            If txtCantidad.Text > 0 And (txtCantidad.Text <= producto.stockActual) Then
                For Each fila As DataGridViewRow In dgvDetalle.Rows
                    If (producto.codProducto = fila.Cells("colCodProducto").Value) And (producto.codTipoProducto = fila.Cells("colCodTipoProducto").Value) Then
                        fila.Cells("colCantidad").Value = Integer.Parse(fila.Cells("colCantidad").Value) + Integer.Parse(txtCantidad.Text)
                        fila.Cells("colSubtotal").Value = Convert.ToDouble(fila.Cells("colSubtotal").Value) + (producto.precio * Integer.Parse(txtCantidad.Text))
                        txtSubtotal1.Text += (producto.precio * Integer.Parse(txtCantidad.Text))
                        producto.stockActual = (producto.stockActual - Integer.Parse(txtCantidad.Text))
                        lblStockActual.Text = "Stock Disponible: " & producto.stockActual & " " & producto.unidadMedida

                        If Integer.Parse(txtDescuento.Text) = 0 Then
                            txtTotal.Text = txtSubtotal1.Text
                        Else
                            txtTotal.Text = Integer.Parse(txtSubtotal1.Text) - (Integer.Parse(txtDescuento.Text) * Integer.Parse(txtSubtotal1.Text) / 100)
                        End If
                        Return
                    End If
                Next

                dgvDetalle.Rows.Add(New String() {txtCantidad.Text, producto.codProducto, producto.nombre, producto.precio, (producto.precio * Integer.Parse(txtCantidad.Text)), producto.codTipoProducto})
                txtSubtotal1.Text += (producto.precio * Integer.Parse(txtCantidad.Text))
                producto.stockActual = (producto.stockActual - Integer.Parse(txtCantidad.Text))
                lblStockActual.Text = "Stock Disponible: " & producto.stockActual & " " & producto.unidadMedida

                If Integer.Parse(txtDescuento.Text) = 0 Then
                    txtTotal.Text = txtSubtotal1.Text
                Else
                    txtTotal.Text = Integer.Parse(txtSubtotal1.Text) - (Integer.Parse(txtDescuento.Text) * Integer.Parse(txtSubtotal1.Text) / 100)
                End If
            ElseIf txtCantidad.Text < 0 And (txtCantidad.Text <= producto.stockActual) Then
                MessageBox.Show("Solo se permiten valores de 'Cantidad' que sean numeros positivos!")
            ElseIf txtCantidad.Text > 0 And (txtCantidad.Text > producto.stockActual) Then
                MessageBox.Show("La cantidad ingresada excede el el stock disponible!")
            ElseIf txtCantidad.Text = 0 Then
                MessageBox.Show("Debe ingresar una cantidad mayor a cero!")
            End If
        ElseIf txtCantidad.Text <> String.Empty And Not IsNumeric(txtCantidad.Text) Then
            MessageBox.Show("Solo se permiten valores de 'Cantidad' que sean numeros positivos!")
        Else
            MessageBox.Show("Debe ingresar la cantidad de productos que desea agregar a la factura!")
        End If
    End Sub
    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim encabezado As New EncabezadoFactura
        encabezado.codTipoFactura = Integer.Parse(cmbTipoFactura.SelectedValue.ToString)
        encabezado.CUITCliente = cmbClientes.SelectedValue.ToString
        encabezado.fecha = Date.Now.ToString("yyyy/MM/dd")
        encabezado.descuento = Integer.Parse(txtDescuento.Text)
        encabezado.total = Convert.ToDouble(txtTotal.Text)

        Dim listaDetalles As New List(Of DetalleFactura)
        For Each fila As DataGridViewRow In dgvDetalle.Rows
            Dim detalle As New DetalleFactura
            detalle.codTipoFactura = Convert.ToInt32(cmbTipoFactura.SelectedValue)
            detalle.codProducto = Convert.ToString(fila.Cells("colCodProducto").Value)
            detalle.codTipoProducto = Convert.ToString(fila.Cells("colCodTipoProducto").Value)
            detalle.cantidad = Convert.ToInt32(fila.Cells("colCantidad").Value)
            detalle.precioUnitario = Convert.ToDouble(fila.Cells("colPrecioUnitario").Value)
            detalle.subtotal = Convert.ToDouble(fila.Cells("colSubtotal").Value)
            listaDetalles.Add(detalle)
        Next
        guardarFactura(encabezado, listaDetalles)
    End Sub
    Public Sub guardarFactura(ByVal encabezado As EncabezadoFactura, ByVal listaDetalles As List(Of DetalleFactura))
        Dim stringConexion As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DB_Tinesco;user id=sa;password=pav2017"
        Dim conexion As New SqlConnection
        Dim cmdEncabezado As New SqlCommand
        Dim cmdDetalle As New SqlCommand
        Dim miTransaccion As SqlTransaction

        Dim nroFactura As Integer

        conexion.ConnectionString = stringConexion
        conexion.Open()
        miTransaccion = conexion.BeginTransaction

        Try
            Dim strEncabezado As String = "SELECT IDENT_CURRENT('Facturas'); INSERT INTO Facturas(codTipoFactura, CUITCliente, fecha, montoTotal, descuento) "
            strEncabezado += "VALUES(@codTipoFactura, @CUITCliente, @fecha, @total, @descuento); "

            cmdEncabezado = New SqlCommand(strEncabezado, conexion, miTransaccion)

            cmdEncabezado.Parameters.Add("@codTipoFactura", SqlDbType.Int).Value = encabezado.codTipoFactura
            cmdEncabezado.Parameters.Add("@CUITCliente", SqlDbType.BigInt).Value = encabezado.CUITCliente
            cmdEncabezado.Parameters.Add("@fecha", SqlDbType.DateTime).Value = encabezado.fecha
            cmdEncabezado.Parameters.Add("@total", SqlDbType.Money).Value = encabezado.total
            cmdEncabezado.Parameters.Add("@descuento", SqlDbType.Int).Value = encabezado.descuento

            nroFactura = Integer.Parse(cmdEncabezado.ExecuteScalar()) + 1

            For Each detalle As DetalleFactura In listaDetalles
                Dim strDetalle As String = "INSERT INTO DetallesFactura(nroFactura,codTipoFactura,codProducto,codTipoProducto,cantidad,precioUnitario,subtotal) "
                strDetalle += "VALUES(@nroFactura, @codTipoFactura, @codProducto, @codTipoProducto, @cantidad, @precioUnitario, @subtotal); "
                strDetalle += "UPDATE Productos SET stockActual=(stockActual-@cantidad) WHERE codProducto=@codProducto AND codTipoProducto=@codTipoProducto"

                cmdDetalle = New SqlCommand(strDetalle, conexion, miTransaccion)

                cmdDetalle.Parameters.Add("@nroFactura", SqlDbType.Int).Value = nroFactura
                cmdDetalle.Parameters.Add("@codTipoFactura", SqlDbType.Int).Value = detalle.codTipoFactura
                cmdDetalle.Parameters.Add("@codProducto", SqlDbType.VarChar).Value = detalle.codProducto
                cmdDetalle.Parameters.Add("@codTipoProducto", SqlDbType.Int).Value = detalle.codTipoProducto
                cmdDetalle.Parameters.Add("@cantidad", SqlDbType.Int).Value = detalle.cantidad
                cmdDetalle.Parameters.Add("@precioUnitario", SqlDbType.Money).Value = detalle.precioUnitario
                cmdDetalle.Parameters.Add("@subtotal", SqlDbType.Money).Value = detalle.subtotal

                'MessageBox.Show(detalle.codTipoFactura.ToString + "," + detalle.codProducto.ToString + "," + detalle.codTipoProducto.ToString + "," + detalle.cantidad.ToString + "," + detalle.precioUnitario.ToString + "," + detalle.subtotal.ToString)

                cmdDetalle.ExecuteNonQuery()
            Next

            miTransaccion.Commit()
            MessageBox.Show("La factura se guardo exitosamente!")
            txtNroFactura.Text = nroFactura
        Catch ex As Exception
            miTransaccion.Rollback()
            MessageBox.Show("La factura no se guardo correctamente!")
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub

    Private Sub cmdConsultarCliente_Click(sender As Object, e As EventArgs) Handles cmdConsultarCliente.Click
        frmClientes.Show()
        frmClientes.cmdAgregar.Visible = True
    End Sub

    Private Sub cmdConsultarProducto_Click(sender As Object, e As EventArgs) Handles cmdConsultarProducto.Click
        frmProductos.Show()
        frmProductos.cmdAgregar.Visible = True
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        If Mensajes.deseaSalir() = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub cmdNuevaFactura_Click(sender As Object, e As EventArgs) Handles cmdNuevaFactura.Click
        txtNroFactura.Text = ""
        cmbTipoFactura.Text = ""
        cmbClientes.Text = ""
        cmbProductos.Text = ""
        txtCantidad.Text = ""
        dgvDetalle.Rows.Clear()
        txtDescuento.Text = 0
        txtTotal.Text = 0
        txtSubtotal1.Text = 0
        lblStockActual.Text = "Stock Disponible:"
        lblPrecio.Text = "Precio:"
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        If txtDescuento.Text <> String.Empty And IsNumeric(txtDescuento.Text) Then
            If txtDescuento.Text > 0 Then
                txtTotal.Text = Integer.Parse(txtSubtotal1.Text) - (Integer.Parse(txtDescuento.Text) * Integer.Parse(txtSubtotal1.Text) / 100)
            ElseIf txtDescuento.Text < 0 Then
                MessageBox.Show("Solo se permiten valores de 'Descuento' que sean numero positivos menores o iguales a 100!")
            End If
        ElseIf Not IsNumeric(txtDescuento.Text) Then
            MessageBox.Show("Solo se permiten valores de 'Descuento' que sean numero positivos menores o iguales a 100!")
        End If
    End Sub
End Class