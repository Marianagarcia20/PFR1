Imports System.Data.SqlClient

Public Class Temporada
    Private Sub Temporada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Temporada' Puede moverla o quitarla según sea necesario.
        Me.TemporadaTableAdapter.Fill(Me.Floreria20DataSet1.Temporada)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Temporada' Puede moverla o quitarla según sea necesario.
        Me.TemporadaTableAdapter.Fill(Me.Floreria20DataSet1.Temporada)

    End Sub

    Private Sub BtnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnAgregarTemporada.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Temporada(descripcion,empleado_crea,empleado_actualiza) values (@descripcion,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionT.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.TemporadaTableAdapter.Fill(Me.Floreria20DataSet1.Temporada)
    End Sub

    Private Sub BtnActualizarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnActualizarTemporada.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Temporada set descripcion=@descripcion,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionT.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.TemporadaTableAdapter.Fill(Me.Floreria20DataSet1.Temporada)
    End Sub

    Private Sub BtnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnEliminarTemporada.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Temporada set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.TemporadaTableAdapter.Fill(Me.Floreria20DataSet1.Temporada)


    End Sub
End Class