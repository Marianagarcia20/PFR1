Imports System.Data.SqlClient
Public Class Tipo_Venta
    Private Sub Tipo_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tipo_Venta' Puede moverla o quitarla según sea necesario.
        Me.Tipo_VentaTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Venta)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tipo_Venta' Puede moverla o quitarla según sea necesario.
        Me.Tipo_VentaTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Venta)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tipo_Arreglo' Puede moverla o quitarla según sea necesario.
        'Me.Tipo_ArregloTableAdapter.Fill(Me.Floreria20DataSet.Tipo_Arreglo)

    End Sub

    Private Sub BtnAgregarTipoArreglo_Click(sender As Object, e As EventArgs) Handles BtnAgregarTipoArreglo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Tipo_Venta(descripcion,empleado_crea,empleado_actualiza) values (@descripcion,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTipoVenta.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_VentaTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Venta)
    End Sub

    Private Sub BtnActualizarTipoArreglo_Click(sender As Object, e As EventArgs) Handles BtnActualizarTipoArreglo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Tipo_Venta set descripcion=@descripcion,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", conexionn)
        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTipoVenta.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_VentaTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Venta)
    End Sub

    Private Sub BtnEliminarTipoArreglo_Click(sender As Object, e As EventArgs) Handles BtnEliminarTipoArreglo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Tipo_Venta set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_VentaTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Venta)
    End Sub
End Class