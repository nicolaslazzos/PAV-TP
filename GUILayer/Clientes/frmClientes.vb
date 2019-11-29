Imports System.Diagnostics
Public Class frmClientes
    Friend rowSelected As DataGridViewRow
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabClientes.SelectedTab = tabNuevo

        tabClientes.TabPages("tabModificar").Enabled = False
        cmdEliminar.Enabled = False
        cmdModificar.Enabled = False
        cmbLocalidad.Enabled = False
        cmbBarrio.Enabled = False
        cmdVerUbicacion.Enabled = False
        cmdAgregar.Enabled = False
        cmdAgregar.Visible = False

        llenarCombo(cmbProvincia, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Provincias"), "nombre", "codProvincia")

        clearComponents()
        dgvClientes.Rows.Clear()
        llenarGrid()
    End Sub

    Public Sub clearComponents()
        'TAB NUEVO
        txtCUIT.Text = ""
        txtRazonSocial.Text = ""
        txtTelefono.Text = ""
        cmbProvincia.Text = ""
        cmbLocalidad.Text = ""
        cmbBarrio.Text = ""
        txtCalle.Text = ""
        txtNumero.Text = ""
        'TAB MODIFICAR
        txtCUIT2.Text = ""
        txtRazonSocial2.Text = ""
        txtTelefono2.Text = ""
        cmbProvincia2.Text = ""
        cmbLocalidad2.Text = ""
        cmbBarrio2.Text = ""
        txtCalle2.Text = ""
        txtNumero2.Text = ""
    End Sub
    Private Sub cmbVaciarCampos_Click(sender As Object, e As EventArgs) Handles cmdVaciarCampos.Click
        clearComponents()
    End Sub
    Friend Sub llenarCombo(ByVal cmb As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cmb.DataSource = source
        cmb.DisplayMember = display
        cmb.ValueMember = value
        cmb.SelectedIndex = -1
    End Sub

    Private Sub cmbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProvincia.SelectionChangeCommitted
        cmbLocalidad.Enabled = True

        Dim filters As New List(Of Object)
        Dim str As String = "SELECT codLocalidad, nombre FROM Localidades WHERE codProvincia=@param1"
        filters.Add(cmbProvincia.SelectedValue.ToString)

        llenarCombo(cmbLocalidad, BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray()), "nombre", "codLocalidad")
    End Sub

    Private Sub cmbLocalidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocalidad.SelectionChangeCommitted
        cmbBarrio.Enabled = True

        Dim filters As New List(Of Object)
        Dim str As String = "SELECT codBarrio, nombre FROM Barrios WHERE codLocalidad=@param1"
        filters.Add(cmbLocalidad.SelectedValue.ToString)

        llenarCombo(cmbBarrio, BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray()), "nombre", "codBarrio")
    End Sub

    Private Sub llenarGrid(ByVal source As DataTable)
        dgvClientes.Rows.Clear()
        For Each fila As DataRow In source.Rows
            dgvClientes.Rows.Add(New String() {fila.Item("CUIT").ToString, fila.Item("razonSocial").ToString, fila.Item("telefono").ToString, fila.Item("Provincia").ToString, fila.Item("Localidad").ToString, fila.Item("Barrio").ToString, fila.Item("calle").ToString, fila.Item("numero").ToString, fila.Item("codProvincia").ToString, fila.Item("codLocalidad").ToString, fila.Item("codBarrio").ToString})
        Next
    End Sub

    Private Sub llenarGrid()
        Dim str As String = "SELECT c.CUIT, c.razonSocial, c.telefono, c.calle, c.numero, b.nombre AS Barrio, l.nombre AS Localidad, p.nombre AS Provincia, p.codProvincia, l.codLocalidad, b.codBarrio"
        str += " FROM Clientes c INNER JOIN Barrios b ON (c.codBarrio = b.codBarrio) INNER JOIN Localidades l ON (l.codLocalidad = b.codLocalidad) INNER JOIN Provincias p ON (p.codProvincia = l.codProvincia) WHERE c.bajaLogica='False'"

        Dim source As DataTable
        source = BDHelper.getDBHelper.ConsultaSQL(str)
        dgvClientes.Rows.Clear()
        For Each fila As DataRow In source.Rows
            dgvClientes.Rows.Add(New String() {fila.Item("CUIT").ToString, fila.Item("razonSocial").ToString, fila.Item("telefono").ToString, fila.Item("Provincia").ToString, fila.Item("Localidad").ToString, fila.Item("Barrio").ToString, fila.Item("calle").ToString, fila.Item("numero").ToString, fila.Item("codProvincia").ToString, fila.Item("codLocalidad").ToString, fila.Item("codBarrio").ToString})
        Next
    End Sub
    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        cmdModificar.Enabled = True
        cmdEliminar.Enabled = True
        cmdVerUbicacion.Enabled = True
        cmdAgregar.Enabled = True
        rowSelected = dgvClientes.CurrentRow
    End Sub
    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim validar As DataTable
        Dim filters As New List(Of Object)
        Dim str As String = "INSERT INTO Clientes (CUIT,razonSocial,telefono,calle,numero,codBarrio,fechaAlta) VALUES (@param1,@param2,@param3,@param4,@param5,@param6,@param7)"

        If txtCUIT.Text <> String.Empty And IsNumeric(txtCUIT.Text) Then
            filters.Add(txtCUIT.Text)
        ElseIf txtCUIT.Text <> String.Empty And Not IsNumeric(txtCUIT.Text) Then
            MessageBox.Show("El numero de CUIT debe contener unicamente numeros!")
            Return
        Else
            MessageBox.Show("Debe ingresar el numero de CUIT!")
            Return
        End If

        If txtRazonSocial.Text <> String.Empty Then
            filters.Add(txtRazonSocial.Text)
        Else
            MessageBox.Show("Debe completar todos los campos!")
            Return
        End If

        If txtTelefono.Text <> String.Empty And Not IsNumeric(txtTelefono.Text) Then
            MessageBox.Show("El numero de telefono debe contener unicamente numeros!")
            Return
        ElseIf txtTelefono.Text = String.Empty Then
            MessageBox.Show("Debe completar todos los campos!")
            Return
        Else
            filters.Add(txtTelefono.Text)
        End If

        If txtCalle.Text <> String.Empty Then
            filters.Add(txtCalle.Text)
        Else
            MessageBox.Show("Debe completar todos los campos!")
            Return
        End If

        If txtNumero.Text <> String.Empty And IsNumeric(txtNumero.Text) Then
            filters.Add(txtNumero.Text)
        ElseIf txtNumero.Text <> String.Empty And Not IsNumeric(txtNumero.Text) Then
            MessageBox.Show("El numero de calle debe contener unicamente numeros!")
            Return
        Else
            filters.Add(0)
        End If

        If cmbBarrio.Text <> String.Empty Then
            filters.Add(cmbBarrio.SelectedValue)
        Else
            MessageBox.Show("Debe completar todos los campos!")
            Return
        End If

        filters.Add(Date.Now.ToString("yyyy/MM/dd"))

        validar = BDHelper.getDBHelper.ConsultaSQL("SELECT CUIT FROM Clientes WHERE CUIT=" & txtCUIT.Text)
        If validar.Rows.Count > 0 Then
            Mensajes.mostrarError("Ya existe un cliente con el CUIT ingresado!")
        Else
            BDHelper.getDBHelper.EjecutarSQLConParametros(str, filters.ToArray())
            llenarGrid()
        End If

    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim filters As New List(Of Object)
        Dim str As String = "SELECT c.CUIT, c.razonSocial, c.telefono, c.calle, c.numero, b.nombre AS Barrio, l.nombre AS Localidad, p.nombre AS Provincia, p.codProvincia, l.codLocalidad, b.codBarrio"
        str += " FROM Clientes c INNER JOIN Barrios b ON (c.codBarrio = b.codBarrio) INNER JOIN Localidades l ON (l.codLocalidad = b.codLocalidad) INNER JOIN Provincias p ON (p.codProvincia = l.codProvincia) WHERE c.bajaLogica='False'"

        If txtCUIT.Text <> String.Empty And IsNumeric(txtCUIT.Text) Then
            filters.Add(txtCUIT.Text)
            str += " AND c.CUIT=@param1"
        ElseIf txtCUIT.Text <> String.Empty And Not IsNumeric(txtCUIT.Text) Then
            MessageBox.Show("El numero de CUIT debe contener unicamente numeros!")
            Return
        Else
            filters.Add(Nothing)
        End If

        If txtRazonSocial.Text <> String.Empty Then
            filters.Add(txtRazonSocial.Text)
            str += " AND c.razonSocial=@param2"
        Else
            filters.Add(Nothing)
        End If

        If txtTelefono.Text <> String.Empty And IsNumeric(txtTelefono.Text) Then
            filters.Add(txtTelefono.Text)
            str += " AND c.telefono=@param3"
        ElseIf txtTelefono.Text <> String.Empty And IsNumeric(txtTelefono.Text) Then
            MessageBox.Show("El numero de telefono debe contener unicamente numeros!")
            Return
        Else
            filters.Add(Nothing)
        End If

        If cmbProvincia.Text <> String.Empty Then
            filters.Add(cmbProvincia.SelectedValue)
            str += " AND p.codProvincia=@param4"
        Else
            filters.Add(Nothing)
        End If

        If cmbLocalidad.Text <> String.Empty Then
            filters.Add(cmbLocalidad.SelectedValue)
            str += " AND l.codLocalidad=@param5"
        Else
            filters.Add(Nothing)
        End If

        If cmbBarrio.Text <> String.Empty Then
            filters.Add(cmbBarrio.SelectedValue)
            str += " AND b.codBarrio=@param5"
        Else
            filters.Add(Nothing)
        End If

        If txtCalle.Text <> String.Empty Then
            filters.Add(txtCalle.Text)
            str += " AND c.calle=@param6"
        Else
            filters.Add(Nothing)
        End If

        If txtNumero.Text <> String.Empty And IsNumeric(txtNumero.Text) Then
            filters.Add(txtNumero.Text)
            str += " AND c.numero=@param7"
        ElseIf txtNumero.Text <> String.Empty And IsNumeric(txtNumero.Text) Then
            MessageBox.Show("El numero de calle debe contener unicamente numeros!")
            Return
        Else
            filters.Add(Nothing)
        End If

        llenarGrid(BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray()))

        If dgvClientes.Rows.Count = 0 Then
            mostrarAviso("No se encontraron coincidencias")
        End If

        cmdModificar.Enabled = False
        cmdEliminar.Enabled = False
        cmdVerUbicacion.Enabled = False
    End Sub
    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim filters As New List(Of Object)
        Dim Str As String = "UPDATE Clientes SET bajaLogica='True' WHERE CUIT=@param1"

        filters.Add(rowSelected.Cells("colCUIT").Value)

        If Mensajes.deseaEliminar = 1 Then
            BDHelper.getDBHelper.EjecutarSQLConParametros(Str, filters.ToArray())
            llenarGrid()
        End If
    End Sub
    Private Sub cmdVerUbicacion_Click(sender As Object, e As EventArgs) Handles cmdVerUbicacion.Click
        Dim selectedRow As DataGridViewRow = dgvClientes.CurrentRow

        Dim calle As String = selectedRow.Cells("colCalle").Value
        Dim numero As String = selectedRow.Cells("colNumero").Value
        Dim barrio As String = selectedRow.Cells("colBarrio").Value
        Dim localidad As String = selectedRow.Cells("colLocalidad").Value
        Dim provincia As String = selectedRow.Cells("colProvincia").Value
        Dim direccion As String = "https://www.google.com.ar/maps/search/" + calle + "+" + numero + ",+" + localidad + ",+" + provincia + "/"

        Process.Start(direccion)
    End Sub
    'PESTAÑA MODIFICAR
    'PESTAÑA MODIFICAR
    'PESTAÑA MODIFICAR
    'PESTAÑA MODIFICAR
    Private Sub cmbProvincia2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProvincia2.SelectionChangeCommitted
        cmbLocalidad2.Enabled = True

        Dim filters As New List(Of Object)
        Dim str As String = "SELECT codLocalidad, nombre FROM Localidades WHERE codProvincia=@param1"
        filters.Add(cmbProvincia2.SelectedValue.ToString)

        llenarCombo(cmbLocalidad2, BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray()), "nombre", "codLocalidad")
    End Sub

    Private Sub cmbLocalidades2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocalidad2.SelectionChangeCommitted
        cmbBarrio2.Enabled = True

        Dim filters As New List(Of Object)
        Dim str As String = "SELECT codBarrio, nombre FROM Barrios WHERE codLocalidad=@param1"
        filters.Add(cmbLocalidad2.SelectedValue.ToString)

        llenarCombo(cmbBarrio2, BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray()), "nombre", "codBarrio")
    End Sub
    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        tabClientes.SelectedTab = tabModificar
        tabClientes.TabPages("tabModificar").Enabled = True

        llenarCombo(cmbProvincia2, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Provincias"), "nombre", "codProvincia")
        llenarCombo(cmbLocalidad2, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Localidades WHERE codProvincia=" & Integer.Parse(rowSelected.Cells("colCodProvincia").Value)), "nombre", "codLocalidad")
        llenarCombo(cmbBarrio2, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Barrios WHERE codLocalidad=" & Integer.Parse(rowSelected.Cells("colCodLocalidad").Value)), "nombre", "codBarrio")

        With rowSelected
            txtCUIT2.Text = .Cells("colCUIT").Value
            txtRazonSocial2.Text = .Cells("colRazonSocial").Value
            txtTelefono2.Text = .Cells("colTelefono").Value
            cmbProvincia2.SelectedValue = Integer.Parse(.Cells("colCodProvincia").Value)
            cmbLocalidad2.SelectedValue = Integer.Parse(.Cells("colCodLocalidad").Value)
            cmbBarrio2.SelectedValue = Integer.Parse(.Cells("colCodBarrio").Value)
            txtCalle2.Text = .Cells("colCalle").Value
            txtNumero2.Text = .Cells("colNumero").Value
        End With

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim filters As New List(Of Object)
        Dim str As String = "UPDATE Clientes SET "

        filters.Add(txtCUIT2.Text)

        If txtRazonSocial2.Text <> String.Empty Then
            str += "razonSocial=@param2, "
            filters.Add(txtRazonSocial2.Text)
        Else
            filters.Add(Nothing)
        End If

        If txtTelefono2.Text <> String.Empty And IsNumeric(txtTelefono2.Text) Then
            str += "telefono=@param3, "
            filters.Add(txtTelefono2.Text)
        ElseIf txtTelefono2.Text <> String.Empty And Not IsNumeric(txtTelefono2.Text) Then
            MessageBox.Show("El numero de telefono debe contener unicamente numeros!")
            Return
        Else
            filters.Add(Nothing)
        End If

        If txtCalle2.Text <> String.Empty Then
            str += "calle=@param4, "
            filters.Add(txtCalle2.Text)
        Else
            filters.Add(Nothing)
        End If

        If txtNumero2.Text <> String.Empty And IsNumeric(txtNumero2.Text) Then
            str += "numero=@param5, "
            filters.Add(txtNumero2.Text)
        ElseIf txtNumero2.Text <> String.Empty And Not IsNumeric(txtNumero2.Text) Then
            MessageBox.Show("El numero de calle debe contener unicamente numeros!")
            Return
        Else
            filters.Add(Nothing)
        End If

        If cmbBarrio2.Text <> String.Empty Then
            str += "codBarrio=@param6 "
            filters.Add(cmbBarrio2.SelectedValue)
        Else
            filters.Add(Nothing)
        End If

        str += "WHERE CUIT=@param1"

        If Mensajes.deseaModificar Then
            BDHelper.getDBHelper.EjecutarSQLConParametros(str, filters.ToArray())
        End If

        tabClientes.SelectedTab = tabNuevo
        cmdEliminar.Enabled = False
        cmdModificar.Enabled = False
        cmdVerUbicacion.Enabled = False
        llenarGrid()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        tabClientes.SelectedTab = tabNuevo
        tabClientes.TabPages("tabModificar").Enabled = False
        clearComponents()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim selectedRow As DataGridViewRow = dgvClientes.CurrentRow
        frmFacturacion.cmbClientes.SelectedValue = selectedRow.Cells("colCUIT").Value
        Me.Close()
    End Sub
End Class