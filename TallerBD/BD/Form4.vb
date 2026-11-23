Public Class Eliminar
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub b_consultar_Click(sender As Object, e As EventArgs) Handles b_consultar.Click
        consultas.Show()
        Me.Hide()
    End Sub

    Private Sub b_regresar_Click(sender As Object, e As EventArgs) Handles b_regresar.Click
        Inicio.Show()
        Me.Hide()
    End Sub
End Class