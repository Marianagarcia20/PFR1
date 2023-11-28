Imports System.Data.SqlClient

Public Class Tipo_Flor
    Private Sub Tipo_Flor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tipo_Flor' Puede moverla o quitarla según sea necesario.
        Me.Tipo_FlorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Flor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tipo_Flor' Puede moverla o quitarla según sea necesario.
        Me.Tipo_FlorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Flor)

    End Sub

    Private Sub BtnAgregarTF_Click(sender As Object, e As EventArgs) Handles BtnAgregarTF.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Tipo_Flor(descripcion) values (@descripcion)", conexionn)

        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTF.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_FlorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Flor)

    End Sub

    Private Sub BtnActualizarTF_Click(sender As Object, e As EventArgs) Handles BtnActualizarTF.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Tipo_Flor set descripcion=@descripcion where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTF.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_FlorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Flor)
    End Sub

    Private Sub BtnEliminarTF_Click(sender As Object, e As EventArgs) Handles BtnEliminarTF.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Tipo_Flor set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_FlorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Flor)
    End Sub
End Class