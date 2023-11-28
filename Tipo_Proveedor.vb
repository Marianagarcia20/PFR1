Imports System.Data.SqlClient

Public Class Tipo_Proveedor
    Private Sub Tipo_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tipo_Proveedor' Puede moverla o quitarla según sea necesario.
        Me.Tipo_ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tipo_Proveedor' Puede moverla o quitarla según sea necesario.
        Me.Tipo_ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Proveedor)

    End Sub

    Private Sub BtnAgregarTipoP_Click(sender As Object, e As EventArgs) Handles BtnAgregarTipoP.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Tipo_Proveedor(descripcion,empleado_crea,empleado_actualiza) values (@descripcion,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTP.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Proveedor)
    End Sub

    Private Sub BtnActualizarTipoP_Click(sender As Object, e As EventArgs) Handles BtnActualizarTipoP.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Tipo_Proveedor set descripcion=@descripcion,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", conexionn)
        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTP.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Proveedor)
    End Sub

    Private Sub BtnEliminarTipoP_Click(sender As Object, e As EventArgs) Handles BtnEliminarTipoP.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Tipo_Proveedor set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Proveedor)
    End Sub
End Class