Imports System.Data.SqlClient
Public Class Empleado
    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Puesto_Empleado' Puede moverla o quitarla según sea necesario.
        Me.Puesto_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Puesto_Empleado)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Horario_Empleado' Puede moverla o quitarla según sea necesario.
        Me.Horario_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Horario_Empleado)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Sucursal' Puede moverla o quitarla según sea necesario.
        Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Sucursal' Puede moverla o quitarla según sea necesario.
        'Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet1.Sucursal)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Sucursal' Puede moverla o quitarla según sea necesario.
        'Me.SucursalTableAdapter.Fill(Me.Floreria20DataSet.Sucursal)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Cargo_Empleado' Puede moverla o quitarla según sea necesario.
        'Me.Cargo_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet.Cargo_Empleado)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Horario_Empleado' Puede moverla o quitarla según sea necesario.
        'Me.Horario_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet.Horario_Empleado)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Empleado)

    End Sub

    Private Sub BtnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnAgregarEmpleado.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Empleado(nombre,ap_paterno,ap_materno,direccion,celular,usuario,contrasenia,id_sucursal, id_puesto_empleado, id_horario_empleado,empleado_crea,empleado_actualiza) values (@nombre,@ap_paterno,@ap_materno,@direccion,@celular,@usuario,@contrasenia,@id_sucursal,@id_puesto_empleado, @id_horario_empleado,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@nombre", TxtNombreEmpleado.Text)
        xd.Parameters.AddWithValue("@ap_paterno", TxtAPEmpleado.Text)
        xd.Parameters.AddWithValue("@ap_materno", TxtAMEmpleado.Text)
        xd.Parameters.AddWithValue("@direccion", TxtDireccionEmpleado.Text)
        xd.Parameters.AddWithValue("@celular", TxtTelefonoEmpleado.Text)
        xd.Parameters.AddWithValue("@usuario", TxtUsuario.Text)
        xd.Parameters.AddWithValue("@contrasenia", TxtContrasenia.Text)
        xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue)
        xd.Parameters.AddWithValue("@id_puesto_empleado", CmbxCargo.SelectedValue)
        xd.Parameters.AddWithValue("@id_horario_empleado", CmbxHorario.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Empleado)
    End Sub

    Private Sub BtnActualizarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnActualizarEmpleado.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Empleado set nombre=@nombre, ap_paterno=@ap_paterno,ap_materno=@ap_materno,direccion=@direccion, celular=@celular,usuario=@usuario, contrasenia=@contrasenia,id_sucursal=@id_sucursal, id_puesto_empleado= @id_puesto_empleado, id_horario_empleado=@id_horario_empleado,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@nombre", TxtNombreEmpleado.Text)
        xd.Parameters.AddWithValue("@ap_paterno", TxtAPEmpleado.Text)
        xd.Parameters.AddWithValue("@ap_materno", TxtAMEmpleado.Text)
        xd.Parameters.AddWithValue("@direccion", TxtDireccionEmpleado.Text)
        xd.Parameters.AddWithValue("@celular", TxtTelefonoEmpleado.Text)
        xd.Parameters.AddWithValue("@usuario", TxtUsuario.Text)
        xd.Parameters.AddWithValue("@contrasenia", TxtContrasenia.Text)
        xd.Parameters.AddWithValue("@id_sucursal", CmbxSucursal.SelectedValue)
        xd.Parameters.AddWithValue("@id_puesto_empleado", CmbxCargo.SelectedValue)
        xd.Parameters.AddWithValue("@id_horario_empleado", CmbxHorario.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Empleado)
    End Sub

    Private Sub BtnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnEliminarEmpleado.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Empleado set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Empleado)
    End Sub


End Class