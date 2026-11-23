Public Class Inicio
    Private Sub consultar_Click(sender As Object, e As EventArgs) Handles b_consultar.Click
        consultas.Show()
        Me.Hide()
    End Sub

    Private Sub ins_Click(sender As Object, e As EventArgs) Handles b_insertar.Click
        Insertar.Show()
        Me.Hide()
    End Sub

    Private Sub modific_Click(sender As Object, e As EventArgs) Handles b_modificar.Click
        modificar.Show()
        Me.Hide()
    End Sub

    Private Sub eli_Click(sender As Object, e As EventArgs) Handles b_eliminar.Click
        Eliminar.Show()
        Me.Hide()
    End Sub
End Class
