Imports System.Data.SqlClient

Public Class FrmCargoEmpleado
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Puesto_Empleado' Puede moverla o quitarla según sea necesario.
        Me.Puesto_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Puesto_Empleado)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Cargo_Empleado' Puede moverla o quitarla según sea necesario.
        Me.Puesto_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Puesto_Empleado)

    End Sub

    Private Sub BtnAgregarCargo_Click(sender As Object, e As EventArgs) Handles BtnAgregarCargo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Puesto_Empleado(descripcion,salario) values (@descripcion,@salario)", conexionn)

        xd.Parameters.AddWithValue("@descripcion", TxtDescripcion.Text)
        xd.Parameters.AddWithValue("@salario", TxtSalario.Text)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Puesto_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Puesto_Empleado)
    End Sub

    Private Sub BtnActualizarCargo_Click(sender As Object, e As EventArgs) Handles BtnActualizarCargo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Puesto_Empleado set descripcion=@descripcion, salario=@salario where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@descripcion", TxtDescripcion.Text)
        xd.Parameters.AddWithValue("@salario", TxtSalario.Text)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Puesto_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Puesto_Empleado)

    End Sub

    Private Sub BtnEliminarCargo_Click(sender As Object, e As EventArgs) Handles BtnEliminarCargo.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Puesto_Empleado set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Puesto_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Puesto_Empleado)

    End Sub


End Class
