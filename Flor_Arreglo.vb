Imports System.Data.SqlClient

Public Class Flor_Arreglo
    Private Sub Flor_Arreglo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Flor' Puede moverla o quitarla según sea necesario.
        Me.FlorTableAdapter.Fill(Me.Floreria20DataSet1.Flor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Arreglo' Puede moverla o quitarla según sea necesario.
        Me.ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Arreglo)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Flor_Arreglo' Puede moverla o quitarla según sea necesario.
        Me.Flor_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Flor_Arreglo)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Flor' Puede moverla o quitarla según sea necesario.
        Me.Flor_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Flor_Arreglo)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Arreglo' Puede moverla o quitarla según sea necesario.
        'Me.ArregloTableAdapter.Fill(Me.Floreria20DataSet.Arreglo)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Flor_Arreglo' Puede moverla o quitarla según sea necesario.
        Me.Flor_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Flor_Arreglo)

    End Sub

    Private Sub BtnAgregarFlorArreglo_Click(sender As Object, e As EventArgs) Handles BtnAgregarFlorArreglo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Flor_Arreglo(cantidad,id_arreglo,id_flor,empleado_crea,empleado_actualiza) values (@cantidad,@id_arreglo,@id_flor,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@cantidad", TxtCantidadFlorArreglo.Text)
        xd.Parameters.AddWithValue("@id_arreglo", CmbxArreglo.SelectedValue)
        xd.Parameters.AddWithValue("@id_flor", CmbxFlor.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Flor_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Flor_Arreglo)
    End Sub

    Private Sub BtnActualizarFlorArreglo_Click(sender As Object, e As EventArgs) Handles BtnActualizarFlorArreglo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Flor_Arreglo set cantidad=@cantidad,id_arreglo=@id_arreglo,id_flor=@id_flor,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@cantidad", TxtCantidadFlorArreglo.Text)
        xd.Parameters.AddWithValue("@id_arreglo", CmbxArreglo.SelectedValue)
        xd.Parameters.AddWithValue("@id_flor", CmbxFlor.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Flor_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Flor_Arreglo)
    End Sub

    Private Sub BtnEliminarFlorArreglo_Click(sender As Object, e As EventArgs) Handles BtnEliminarFlorArreglo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Flor_Arreglo set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Flor_ArregloTableAdapter.Fill(Me.Floreria20DataSet1.Flor_Arreglo)
    End Sub


End Class