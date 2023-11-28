Imports System.Data.SqlClient

Public Class Venta
    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tipo_Pago' Puede moverla o quitarla según sea necesario.
        Me.Tipo_PagoTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Pago)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Tipo_Venta' Puede moverla o quitarla según sea necesario.
        Me.Tipo_VentaTableAdapter.Fill(Me.Floreria20DataSet1.Tipo_Venta)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.Floreria20DataSet1.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet1.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.Floreria20DataSet1.Venta)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tipo_Pago' Puede moverla o quitarla según sea necesario.
        'Me.Tipo_PagoTableAdapter.Fill(Me.Floreria20DataSet.Tipo_Pago)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Tipo_Venta' Puede moverla o quitarla según sea necesario.
        'Me.Tipo_VentaTableAdapter.Fill(Me.Floreria20DataSet.Tipo_Venta)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Cliente' Puede moverla o quitarla según sea necesario.
        'Me.ClienteTableAdapter.Fill(Me.Floreria20DataSet.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Empleado' Puede moverla o quitarla según sea necesario.
        'Me.EmpleadoTableAdapter.Fill(Me.Floreria20DataSet.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'Floreria20DataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.Floreria20DataSet1.Venta)
    End Sub

    Private Sub BtnAgregarVenta_Click(sender As Object, e As EventArgs) Handles BtnAgregarVenta.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Venta(id,fecha_venta,id_cliente,id_tipo_venta,id_tipo_pago,empleado_crea,empleado_actualiza) values (@id,@fecha_venta,@id_cliente,@id_tipo_venta,@id_tipo_pago,@empleado_crea,@empleado_actualiza)", conexionn)
        Dim id As Integer = UltimaVenta()
        xd.Parameters.AddWithValue("@id", id)
        xd.Parameters.AddWithValue("@fecha_venta", DateTimePicker1.Value)
        xd.Parameters.AddWithValue("@id_cliente", CmbxCliente.SelectedValue)
        xd.Parameters.AddWithValue("@id_tipo_venta", CmbxTipoVenta.SelectedValue)
        xd.Parameters.AddWithValue("@id_tipo_pago", CmbxTipoPago.SelectedValue)
        xd.Parameters.AddWithValue("@empleado_crea", 1)
        xd.Parameters.AddWithValue("@empleado_actualiza", 1)
        xd.ExecuteNonQuery()
        xd.Dispose()
        Dim r As DataGridViewRow
        For Each r In DataGridView1.Rows
            xd = New SqlCommand("insert into Detalle_Venta (id_arreglo, cantidad, precio, id_venta, empleado_crea, empleado_actualiza) values (@id_arreglo, @cantidad, @precio, @id_venta, @empleado_crea, @empleado_actualiza)", conexionn)
            xd.Parameters.AddWithValue("@id_arreglo", r.Cells(0).Value)
            xd.Parameters.AddWithValue("@cantidad", r.Cells(3).Value)
            xd.Parameters.AddWithValue("@precio", r.Cells(2).Value)
            xd.Parameters.AddWithValue("@id_venta", id)
            xd.Parameters.AddWithValue("@empleado_crea", 1)
            xd.Parameters.AddWithValue("@empleado_actualiza", 1)
            xd.ExecuteNonQuery()
            xd.Dispose()
        Next
        conexionn.Close()
        MessageBox.Show("Nota Registrada")
        conexionn.Close()
        DataGridView1.Rows.Clear()
    End Sub

    Private Function UltimaVenta() As Integer
        Try
            Dim resultado = Query("SELECT MAX(id) AS Ultimo FROM Venta").Rows(0)(0)

            If Not IsDBNull(resultado) Then
                Return Convert.ToInt32(resultado) + 1
            Else
                Return 1
            End If
        Catch ex As Exception
            ' Manejar el error adecuadamente, por ejemplo, registrando el error o lanzando una excepción
            MessageBox.Show(ex.Message)
            Return 1
        End Try

    End Function

    Public Function Query(ByVal queryy As String) As DataTable
        Dim read As SqlDataAdapter = New SqlDataAdapter(queryy, conexionn)
        Dim dt As DataTable = New DataTable()
        read.Fill(dt)
        read.Dispose()
        Return dt
    End Function


    Private Sub TxtArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtArticulo.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            conexionn.Open()
            Dim resultado As DataTable = Query("select id, nombre, precio from Arreglo where id=" + TxtArticulo.Text)
            Dim id = resultado.Rows(0)("id")
            Dim nombre = resultado.Rows(0)("nombre")
            Dim costo = resultado.Rows(0)("precio")
            DataGridView1.Rows.Add(id, nombre, costo, TxtCantidad.Text)
            conexionn.Close()
        End If
    End Sub


End Class