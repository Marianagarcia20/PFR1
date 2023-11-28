Imports System.Data.SqlClient
Public Class Cliente
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Cliente)

    End Sub

    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarCliente.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Cliente(nombre,ap_paterno, ap_materno,direccion,celular,empleado_crea,empleado_actualiza) values (@nombre,@ap_paterno, @ap_materno,@direccion,@celular,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@nombre", TxtNombreCliente.Text)
        xd.Parameters.AddWithValue("@ap_paterno", TxtAppCliente.Text)
        xd.Parameters.AddWithValue("@ap_materno", TxtApmCliente.Text)
        xd.Parameters.AddWithValue("@direccion", TxtDireccion.Text)
        xd.Parameters.AddWithValue("@celular", TxtCelular.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Cliente)
    End Sub

    Private Sub BtnActualizarCliente_Click(sender As Object, e As EventArgs) Handles BtnActualizarCliente.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Cliente set nombre=@nombre, ap_paterno=@ap_paterno, ap_materno= @ap_materno,direccion=@direccion, celular=@celular,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@nombre", TxtNombreCliente.Text)
        xd.Parameters.AddWithValue("@ap_paterno", TxtAppCliente.Text)
        xd.Parameters.AddWithValue("@ap_materno", TxtApmCliente.Text)
        xd.Parameters.AddWithValue("@direccion", TxtDireccion.Text)
        xd.Parameters.AddWithValue("@celular", TxtCelular.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Cliente)
    End Sub

    Private Sub BtnEliminarCliente_Click(sender As Object, e As EventArgs) Handles BtnEliminarCliente.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Cliente set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Cliente)
    End Sub
End Class