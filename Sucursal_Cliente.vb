Imports System.Data.SqlClient
Public Class Sucursal_Cliente
    Private Sub Sucursal_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Sucursal' Puede moverla o quitarla según sea necesario.
        Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Sucursal_Cliente' Puede moverla o quitarla según sea necesario.
        Me.Sucursal_ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal_Cliente)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Cliente' Puede moverla o quitarla según sea necesario.
        ' Me.ClienteTableAdapter.Fill(Me.Floreria20DataSet.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Sucursal' Puede moverla o quitarla según sea necesario.
        'Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet.Sucursal)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Sucursal_Cliente' Puede moverla o quitarla según sea necesario.
        Me.Sucursal_ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal_Cliente)

    End Sub

    Private Sub BtnAgregarSucCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarSucCliente.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Sucursal_Cliente (id_sucursal,id_cliente,empleado_crea,empleado_actualiza) values (@id_sucursal,@id_cliente,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue)
        xd.Parameters.AddWithValue("@id_cliente", CmbxCliente.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Sucursal_ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal_Cliente)
    End Sub

    Private Sub BtnActualizarSucCliente_Click(sender As Object, e As EventArgs) Handles BtnActualizarSucCliente.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Sucursal_Cliente set id_sucursal=@id_sucursal,id_cliente=@id_cliente,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue)
        xd.Parameters.AddWithValue("@id_cliente", CmbxCliente.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Sucursal_ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal_Cliente)
    End Sub

    Private Sub BtnEliminarSucCliente_Click(sender As Object, e As EventArgs) Handles BtnEliminarSucCliente.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Sucursal_Cliente set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Sucursal_ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal_Cliente)
    End Sub
End Class