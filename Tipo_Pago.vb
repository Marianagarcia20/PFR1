Imports System.Data.SqlClient
Public Class Tipo_Pago
    Private Sub BtnAgregarTipoPago_Click(sender As Object, e As EventArgs) Handles BtnAgregarTipoPago.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Tipo_Pago(descripcion,empleado_crea,empleado_actualiza) values (@descripcion,@empleado_crea,@empleado_actualiza)", conexionn)

        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTipoPago.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_PagoTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Pago)
    End Sub

    Private Sub Tipo_Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tipo_Pago' Puede moverla o quitarla según sea necesario.
        Me.Tipo_PagoTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Pago)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tipo_Pago' Puede moverla o quitarla según sea necesario.
        Me.Tipo_PagoTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Pago)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tipo_Pago' Puede moverla o quitarla según sea necesario.
        Me.Tipo_PagoTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Pago)

    End Sub

    Private Sub BtnActualizarTipoPago_Click(sender As Object, e As EventArgs) Handles BtnActualizarTipoPago.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Tipo_Pago set descripcion=@descripcion,empleado_crea=@empleado_crea,empleado_actualiza=@empleado_actualiza where id = @id", conexionn)
        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@descripcion", TxtDescripcionTipoPago.Text)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_PagoTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Pago)
    End Sub

    Private Sub BtnEliminarTipoPago_Click(sender As Object, e As EventArgs) Handles BtnEliminarTipoPago.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Tipo_Pago set status=0 where id = @id", conexionn)

        xd.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_PagoTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Pago)
    End Sub
End Class