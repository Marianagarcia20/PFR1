Imports System.Data.SqlClient

Public Class Arreglo
    Private Sub Arreglo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tamanio_Arreglo' Puede moverla o quitarla según sea necesario.
        Me.Tamanio_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Tamanio_Arreglo)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tipo_Arreglo' Puede moverla o quitarla según sea necesario.
        Me.Tipo_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Arreglo)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Arreglo' Puede moverla o quitarla según sea necesario.
        Me.ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Arreglo)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tamanio_Arreglo' Puede moverla o quitarla según sea necesario.
        'Me.Tamanio_ArregloTableAdapter.Fill(Me.Floreria20DataSet.Tamanio_Arreglo)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tipo_Arreglo' Puede moverla o quitarla según sea necesario.
        'Me.Tipo_ArregloTableAdapter.Fill(Me.Floreria20DataSet.Tipo_Arreglo)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Arreglo' Puede moverla o quitarla según sea necesario.
        Me.ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Arreglo)

    End Sub

    Private Sub BtnAgregarArreglo_Click(sender As Object, e As EventArgs) Handles BtnAgregarArreglo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Arreglo(nombre,color,precio,id_tipo_arreglo,id_tamanio_arreglo,empleado_crea,empleado_actualiza) values (@nombre,@color,@precio,@id_tipo_arreglo,@id_tamanio_arreglo,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@nombre", TxtNombreArreglo.Text)
        xd.Parameters.AddWithValue("@color", TxtColorArreglo.Text)
        xd.Parameters.AddWithValue("@precio", TxtPrecioArreglo.Text)
        xd.Parameters.AddWithValue("@id_tipo_arreglo", CmbxTipoArreglo.SelectedValue)
        xd.Parameters.AddWithValue("@id_tamanio_arreglo", CmbxTamanio.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Arreglo)
    End Sub

    Private Sub BtnActualizarArreglo_Click(sender As Object, e As EventArgs) Handles BtnActualizarArreglo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Arreglo set nombre=@nombre,color=@color, precio=@precio,id_tipo_arreglo=@id_tipo_arreglo,id_tamanio_arreglo=@id_tamanio_arreglo,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id= @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@nombre", TxtNombreArreglo.Text)
        xd.Parameters.AddWithValue("@color", TxtColorArreglo.Text)
        xd.Parameters.AddWithValue("@precio", TxtPrecioArreglo.Text)
        xd.Parameters.AddWithValue("@id_tipo_arreglo", CmbxTipoArreglo.SelectedValue)
        xd.Parameters.AddWithValue("@id_tamanio_arreglo", CmbxTamanio.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Arreglo)
    End Sub

    Private Sub BtnEliminarArreglo_Click(sender As Object, e As EventArgs) Handles BtnEliminarArreglo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Arreglo set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Arreglo)
    End Sub
End Class