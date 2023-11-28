Imports System.Data.SqlClient

Public Class Flor
    Private Sub Flor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tipo_Flor' Puede moverla o quitarla según sea necesario.
        Me.Tipo_FlorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Flor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Temporada' Puede moverla o quitarla según sea necesario.
        Me.TemporadaTableAdapter.Fill(Me.Floreria20DataSet1.Temporada)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Flor' Puede moverla o quitarla según sea necesario.
        Me.FlorTableAdapter.Fill(Me.Floreria20DataSet1.Flor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tipo_Flor' Puede moverla o quitarla según sea necesario.
        'Me.Tipo_FlorTableAdapter.Fill(Me.Floreria20DataSet.Tipo_Flor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Temporada' Puede moverla o quitarla según sea necesario.
        'Me.TemporadaTableAdapter.Fill(Me.Floreria20DataSet.Temporada)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Flor' Puede moverla o quitarla según sea necesario.
        Me.FlorTableAdapter.Fill(Me.Floreria20DataSet1.Flor)

    End Sub

    Private Sub BtnAgregarFlor_Click(sender As Object, e As EventArgs) Handles BtnAgregarFlor.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Flor(color,costo,id_temporada_flor,id_tipo_flor,empleado_crea,empleado_actualiza) values (@color,@costo,@id_temporada_flor,@id_tipo_flor,@empleado_crea,@empleado_actualiza)", conexionn)

        'xd.Parameters.AddWithValue("@nombre_flor", TxtNombreFlor.Text)
        xd.Parameters.AddWithValue("@color", TxtColor.Text)
        xd.Parameters.AddWithValue("@costo", TxtCosto.Text)
        xd.Parameters.AddWithValue("@id_temporada_flor", CmbxTemporada.SelectedValue)
        xd.Parameters.AddWithValue("@id_tipo_flor", CmbxTipo.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.FlorTableAdapter.Fill(Me.Floreria20DataSet1.Flor)
    End Sub

    Private Sub BtnActualizarFlor_Click(sender As Object, e As EventArgs) Handles BtnActualizarFlor.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Flor set color=@color,costo=@costo,id_temporada_flor=@id_temporada_flor,id_tipo_flor=@id_tipo_flor,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        'xd.Parameters.AddWithValue("@nombre_flor", TxtNombreFlor.Text)
        xd.Parameters.AddWithValue("@color", TxtColor.Text)
        xd.Parameters.AddWithValue("@costo", TxtCosto.Text)
        xd.Parameters.AddWithValue("@id_temporada_flor", CmbxTemporada.SelectedValue)
        xd.Parameters.AddWithValue("@id_tipo_flor", CmbxTipo.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.FlorTableAdapter.Fill(Me.Floreria20DataSet1.Flor)
    End Sub

    Private Sub BtnEliminarFlor_Click(sender As Object, e As EventArgs) Handles BtnEliminarFlor.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Flor set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.FlorTableAdapter.Fill(Me.Floreria20DataSet1.Flor)
    End Sub
End Class