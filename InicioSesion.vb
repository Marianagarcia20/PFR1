Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.SqlClient

Public Class InicioSesion
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim comando As New SqlCommand
        If String.IsNullOrEmpty(TxtUsuario.Text) Then
            TxtUsuario.Select()
            MsgBox("Favor de llenar todos los campos solicitados")
        ElseIf String.IsNullOrEmpty(TxtContrasena.Text) Then
            TxtContrasena.Select()
            MsgBox("Favor de llenar todos los campos solicitados")
        ElseIf String.IsNullOrEmpty(TxtContrasena.Text & TxtUsuario.Text) Then
            TxtUsuario.Select()

        Else
            conexionn.Open()
            Dim consulta As String = "Select id from Empleado where usuario='" & TxtUsuario.Text & "'and contrasenia='" & TxtContrasena.Text & "'"
            comando = New SqlCommand(consulta, conexionn)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            If lector.HasRows Then
                While lector.Read
                    MsgBox("Se inicio la sesion")
                    Dim frmMenu As Menu = New Menu()
                    Me.Hide()
                    frmMenu.Show()
                End While
            Else
                MsgBox("El usuario no existe o datos incorrectos")
            End If
            conexionn.Close()
        End If
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Empleado.ShowDialog()
    End Sub
End Class