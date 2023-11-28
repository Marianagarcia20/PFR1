Imports System.Data.SqlClient

Public Class HorarioEmpleado
    Private Sub HorarioEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Horario_Empleado' Puede moverla o quitarla según sea necesario.
        Me.Horario_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Horario_Empleado)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Horario_Empleado' Puede moverla o quitarla según sea necesario.
        Me.Horario_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Horario_Empleado)

    End Sub

    Private Sub BtnAgregarHorario_Click(sender As Object, e As EventArgs) Handles BtnAgregarHorario.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Horario_Empleado(hora_entrada,hora_salida) values (@hora_entrada,@hora_salida)", conexionn)

        xd.Parameters.AddWithValue("@hora_entrada", TxtHrE.Text)
        xd.Parameters.AddWithValue("@hora_salida", TxtHrS.Text)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Horario_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Horario_Empleado)
    End Sub

    Private Sub BtnActualizarHorario_Click(sender As Object, e As EventArgs) Handles BtnActualizarHorario.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Horario_Empleado set hora_entrada=@hora_entrada,hora_salida=@hora_salida where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@hora_entrada", TxtHrE.Text)
        xd.Parameters.AddWithValue("@hora_salida", TxtHrS.Text)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Horario_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Horario_Empleado)
    End Sub

    Private Sub BtnEliminarHorario_Click(sender As Object, e As EventArgs) Handles BtnEliminarHorario.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Horario_Empleado set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Horario_EmpleadoTableAdapter.Fill(Me.Floreria20DataSet1.Horario_Empleado)
    End Sub
End Class