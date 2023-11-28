Imports System.Data.SqlClient

Public Class Proveedor
    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tipo_Proveedor' Puede moverla o quitarla según sea necesario.
        Me.Tipo_ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Sucursal' Puede moverla o quitarla según sea necesario.
        Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tipo_Proveedor' Puede moverla o quitarla según sea necesario.
        'Me.Tipo_ProveedorTableAdapter.Fill(Me.Floreria20DataSet.Tipo_Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Sucursal' Puede moverla o quitarla según sea necesario.
        'Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet.Sucursal)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Proveedor)

    End Sub

    Private Sub BtnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles BtnAgregarProveedor.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Proveedor(nombre_empresa,correo,celular,id_sucursal,id_tipo_proveedor,empleado_crea,empleado_actualiza) values (@nombre_empresa,@correo,@celular,@id_sucursal,@id_tipo_proveedor,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@nombre_empresa", TxtNombreProveedor.Text)
        xd.Parameters.AddWithValue("@correo", TxtCorreoProveedor.Text)
        xd.Parameters.AddWithValue("@celular", TxtTelefonoProveedor.Text)
        xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue)
        xd.Parameters.AddWithValue("@id_tipo_proveedor", CmbxTipo.SelectedValue)
        ' Asumiendo que los valores en el ComboBox son de tipo String
        ' xd.Parameters.AddWithValue("@id_tipo_proveedor", CInt(CmbxTipo.SelectedValue))
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Proveedor)
    End Sub

    Private Sub BtnActualizarProveedor_Click(sender As Object, e As EventArgs) Handles BtnActualizarProveedor.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Proveedor set nombre_empresa=@nombre_empresa,correo=@correo,celular=@celular,id_sucursal=@id_sucursal,id_tipo_proveedor=@id_tipo_proveedor,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@nombre_empresa", TxtNombreProveedor.Text)
        xd.Parameters.AddWithValue("@correo", TxtCorreoProveedor.Text)
        xd.Parameters.AddWithValue("@celular", TxtTelefonoProveedor.Text)
        xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue)
        xd.Parameters.AddWithValue("@id_tipo_proveedor", CmbxTipo.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Proveedor)
    End Sub

    Private Sub BtnEliminarProveedor_Click(sender As Object, e As EventArgs) Handles BtnEliminarProveedor.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Proveedor set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ProveedorTableAdapter.Fill(Me.Floreria20DataSet1.Proveedor)
    End Sub
End Class