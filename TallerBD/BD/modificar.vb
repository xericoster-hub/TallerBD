Public Class modificar
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub t_incercionP1_TextChanged(sender As Object, e As EventArgs) Handles t_incercionP1.TextChanged

    End Sub

    Private Sub b_regresar_Click(sender As Object, e As EventArgs) Handles b_regresar.Click
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub b_consultar_Click(sender As Object, e As EventArgs) Handles b_consultar.Click
        consultas.Show()
        Me.Hide()
    End Sub
End Class