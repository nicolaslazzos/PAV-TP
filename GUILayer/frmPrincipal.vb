Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlSesion.Width = Me.Width
        menuPrincipal.Visible = False
        cmdCerrarSesion.Enabled = False
        cmdProductos.Enabled = False
        cmdClientes.Enabled = False
        cmdProveedores.Enabled = False
        cmdFacturacion.Enabled = False
        frmLogin.Show(Me)
    End Sub
    Private Sub NuevoConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoConsultarToolStripMenuItem.Click
        frmProductos.ShowDialog()
    End Sub

    Private Sub NuevoConsultarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoConsultarToolStripMenuItem1.Click
        frmClientes.ShowDialog()
    End Sub

    Private Sub cmdProductos_Click(sender As Object, e As EventArgs) Handles cmdProductos.Click
        frmProductos.ShowDialog()
    End Sub

    Private Sub cmdClientes_Click(sender As Object, e As EventArgs) Handles cmdClientes.Click
        frmClientes.ShowDialog()
    End Sub

    Private Sub cmdProveedores_Click(sender As Object, e As EventArgs) Handles cmdProveedores.Click
        frmProveedores.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Close(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Mensajes.deseaSalir = 1 Then
            cmdCerrarSesion.PerformClick()
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Public Sub actualizarSesion(ByVal sesion As String, ByVal avatar As Integer)
        lblSesion.Text = sesion
        picAvatar.Image = listaAvatares.Images(avatar)
        pnlSesion.BackColor = Color.LimeGreen

        menuPrincipal.Visible = True
        cmdCerrarSesion.Enabled = True
        cmdProductos.Enabled = True
        cmdClientes.Enabled = True
        cmdProveedores.Enabled = True
        cmdFacturacion.Enabled = True
    End Sub

    Private Sub cmdCerrarSesion_Click(sender As Object, e As EventArgs) Handles cmdCerrarSesion.Click
        lblSesion.Text = "Sin Sesion"
        picAvatar.Image = listaAvatares.Images(5)
        pnlSesion.BackColor = Color.Red

        menuPrincipal.Visible = False
        cmdCerrarSesion.Enabled = False
        cmdProductos.Enabled = False
        cmdClientes.Enabled = False
        cmdProveedores.Enabled = False
        cmdFacturacion.Enabled = False
        frmLogin.Show(Me)
    End Sub

    Private Sub NuevoConsultarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NuevoConsultarToolStripMenuItem2.Click
        frmUsuarios.ShowDialog()
    End Sub
    Private Sub ConsultarModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarModificarToolStripMenuItem.Click
        frmUsuarios.ShowDialog()
    End Sub
    Private Sub NuevoConsultarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles NuevoConsultarToolStripMenuItem3.Click
        frmProveedores.ShowDialog()
    End Sub

    Private Sub cmdFacturacion_Click(sender As Object, e As EventArgs) Handles cmdFacturacion.Click
        frmFacturacion.ShowDialog()
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        frmListadoClientes.ShowDialog()
    End Sub

    Private Sub InformeDeProductosMasVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeDeProductosMasVendidosToolStripMenuItem.Click
        frmProductosMasVendidos.ShowDialog()
    End Sub

    Private Sub ListadoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProductosToolStripMenuItem.Click
        frmListadoProductos.ShowDialog()
    End Sub

    Private Sub ProductosPorClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosPorClientesToolStripMenuItem.Click
        frmProductosPorCliente.ShowDialog()
    End Sub

    Private Sub ListadoDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProveedoresToolStripMenuItem.Click
        frmListadoProveedores.ShowDialog()
    End Sub

    Private Sub MontosCompradosPorClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MontosCompradosPorClientesToolStripMenuItem.Click
        frmListadoMontosPorCliente.ShowDialog()
    End Sub
End Class
