Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnEmpleado_Click(sender As Object, e As EventArgs) Handles BtnEmpleado.Click
        Empleado.ShowDialog()
    End Sub

    Private Sub BtnPuestos_Click(sender As Object, e As EventArgs) Handles BtnPuestos.Click
        FrmCargoEmpleado.ShowDialog()
    End Sub

    Private Sub BtnHorarios_Click(sender As Object, e As EventArgs) Handles BtnHorarios.Click
        HorarioEmpleado.ShowDialog()
    End Sub

    Private Sub BtnSucursales_Click(sender As Object, e As EventArgs) Handles BtnSucursales.Click
        Sucursal.ShowDialog()
    End Sub

    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles BtnProveedores.Click
        Proveedor.ShowDialog()
    End Sub

    Private Sub BtnTProveedor_Click(sender As Object, e As EventArgs) Handles BtnTProveedor.Click
        Tipo_Proveedor.ShowDialog()
    End Sub

    Private Sub BtnSurtido_Click(sender As Object, e As EventArgs) Handles BtnSurtido.Click
        Compra.ShowDialog()
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Cliente.ShowDialog()
    End Sub

    Private Sub BtnClienteSuc_Click(sender As Object, e As EventArgs) Handles BtnClienteSuc.Click
        Sucursal_Cliente.ShowDialog()

    End Sub

    Private Sub BtnFlores_Click(sender As Object, e As EventArgs) Handles BtnFlores.Click
        Flor.ShowDialog()
    End Sub

    Private Sub BtnTFlor_Click(sender As Object, e As EventArgs) Handles BtnTFlor.Click
        Tipo_Flor.ShowDialog()
    End Sub

    Private Sub BtnTemporadas_Click(sender As Object, e As EventArgs) Handles BtnTemporadas.Click
        Temporada.ShowDialog()
    End Sub

    Private Sub BtnArreglos_Click(sender As Object, e As EventArgs) Handles BtnArreglos.Click
        Arreglo.ShowDialog()
    End Sub

    Private Sub BtnFlorArreglo_Click(sender As Object, e As EventArgs) Handles BtnFlorArreglo.Click
        Flor_Arreglo.ShowDialog()
    End Sub

    Private Sub BtnTArreglo_Click(sender As Object, e As EventArgs) Handles BtnTArreglo.Click
        Tipo_Arreglo.ShowDialog()
    End Sub

    Private Sub BtnTamArreglo_Click(sender As Object, e As EventArgs) Handles BtnTamArreglo.Click
        Tamanio_Arreglo.ShowDialog()
    End Sub

    Private Sub BtnVenta_Click(sender As Object, e As EventArgs) Handles BtnVenta.Click
        Venta.ShowDialog()
    End Sub

    Private Sub BtnTVenta_Click(sender As Object, e As EventArgs) Handles BtnTVenta.Click
        Tipo_Venta.ShowDialog()
    End Sub

    Private Sub BtnTPago_Click(sender As Object, e As EventArgs) Handles BtnTPago.Click
        Tipo_Pago.ShowDialog()
    End Sub
End Class