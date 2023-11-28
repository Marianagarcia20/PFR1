Imports System.Data.SqlClient

Public Class Compra
    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Flor' Puede moverla o quitarla según sea necesario.
        Me.FlorTableAdapter.Fill(Me.Floreria20DataSet1.Flor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Compra_Flor' Puede moverla o quitarla según sea necesario.
        Me.Compra_FlorTableAdapter.Fill(Me.Floreria20DataSet1.Compra_Flor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        'Me.ProveedorTableAdapter.Fill(Me.Floreria20DataSet.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Compra' Puede moverla o quitarla según sea necesario.
        'Me.CompraTableAdapter.Fill(Me.Floreria20DataSet.Compra)

    End Sub

    Private Sub BtnAgregarCompra_Click(sender As Object, e As EventArgs) Handles BtnAgregarCompra.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Compra_Flor(fecha_surtido,precio,cantidad,id_proveedor,id_flor,empleado_crea,empleado_actualiza) values (@fecha_surtido,@precio,@cantidad,@id_proveedor,@id_flor,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@fecha_surtido", DateTimePicker1.Value)
        xd.Parameters.AddWithValue("@precio", TxtPrecio.Text)
        xd.Parameters.AddWithValue("@cantidad", TxtCantidad.Text)
        xd.Parameters.AddWithValue("@id_proveedor", CmbxProveedor.SelectedValue)
        xd.Parameters.AddWithValue("@id_flor", CmbxFlor.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Compra_FlorTableAdapter.Fill(Me.Floreria20DataSet1.Compra_Flor)
    End Sub

    Private Sub BtnActualizarCompra_Click(sender As Object, e As EventArgs) Handles BtnActualizarCompra.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Compra_Flor set fecha_surtido=@fecha_surtido, precio=@precio,cantidad=@cantidad,id_proveedor=@id_proveedor, id_flor=@id_flor, empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id= @id", conexionn)


        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@fecha_surtido", DateTimePicker1.Value)
        xd.Parameters.AddWithValue("@precio", TxtPrecio.Text)
        xd.Parameters.AddWithValue("@cantidad", TxtCantidad.Text)
        xd.Parameters.AddWithValue("@id_proveedor", CmbxProveedor.SelectedValue)
        xd.Parameters.AddWithValue("@id_flor", CmbxFlor.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Compra_FlorTableAdapter.Fill(Me.Floreria20DataSet1.Compra_Flor)
    End Sub

    Private Sub BtnEliminarCompra_Click(sender As Object, e As EventArgs) Handles BtnEliminarCompra.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Compra_Flor set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Compra_FlorTableAdapter.Fill(Me.Floreria20DataSet1.Compra_Flor)
    End Sub


End Class