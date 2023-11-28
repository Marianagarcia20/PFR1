Imports System.Data.SqlClient
Public Class Sucursal
    Private Sub BtnAgregarSucursal_Click(sender As Object, e As EventArgs) Handles BtnAgregarSucursal.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Sucursal(direccion) values (@direccion)", conexionn)

        xd.Parameters.AddWithValue("@direccion", TxtDireccion.Text)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal)
    End Sub

    Private Sub Sucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Sucursal' Puede moverla o quitarla según sea necesario.
        Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Sucursal' Puede moverla o quitarla según sea necesario.
        Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal)

    End Sub

    Private Sub BtnActualizarSucursal_Click(sender As Object, e As EventArgs) Handles BtnActualizarSucursal.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Sucursal set direccion=@direccion where id=@id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@direccion", TxtDireccion.Text)

        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal)
    End Sub

    Private Sub BtnEliminarSucursal_Click(sender As Object, e As EventArgs) Handles BtnEliminarSucursal.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Sucursal set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal)
    End Sub
End Class