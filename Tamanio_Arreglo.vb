Imports System.Data.SqlClient

Public Class Tamanio_Arreglo
    Private Sub BtnAgregarTA_Click(sender As Object, e As EventArgs) Handles BtnAgregarTA.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Tamanio_Arreglo(descripcion,empleado_crea,empleado_actualiza) values (@descripcion,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTA.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tamanio_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Tamanio_Arreglo)
    End Sub

    Private Sub Tamanio_Arreglo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tamanio_Arreglo' Puede moverla o quitarla según sea necesario.
        Me.Tamanio_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Tamanio_Arreglo)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tamanio_Arreglo' Puede moverla o quitarla según sea necesario.
        Me.Tamanio_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Tamanio_Arreglo)

    End Sub

    Private Sub BtnActualizarTA_Click(sender As Object, e As EventArgs) Handles BtnActualizarTA.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Tamanio_Arreglo set descripcion=@descripcion,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", conexionn)
        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTA.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tamanio_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Tamanio_Arreglo)
    End Sub

    Private Sub BtnEliminarTA_Click(sender As Object, e As EventArgs) Handles BtnEliminarTA.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Tamanio_Arreglo set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tamanio_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Tamanio_Arreglo)
    End Sub
End Class