Public Class Form1
    Public Sub Hitung()
        If Man.Checked = True Then
            ANS.Text = Math.Abs(Val(x1.Text) - Val(X2.Text)) + Math.Abs(Val(Y1.Text) - Val(Y2.Text))
        ElseIf Eul.Checked = True Then
            ANS.Text = Math.Sqrt(d:=(Math.Abs(Val(x1.Text) - Val(X2.Text)) * Math.Abs(Val(x1.Text) - Val(X2.Text))) + (Math.Abs(Val(Y1.Text) - Val(Y2.Text)) * Math.Abs(Val(Y1.Text) - Val(Y2.Text))))
        End If
    End Sub
    Private Sub x1_TextChanged(sender As Object, e As EventArgs) Handles x1.TextChanged
        Hitung()
    End Sub

    Private Sub x1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles x1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then e.Handled = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Y1.TextChanged
        Hitung()
    End Sub

    Private Sub X2_TextChanged(sender As Object, e As EventArgs) Handles X2.TextChanged
        Hitung()
    End Sub

    Private Sub Y1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Y1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then e.Handled = True
    End Sub

    Private Sub X2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles X2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then e.Handled = True
    End Sub

    Private Sub Y2_TextChanged(sender As Object, e As EventArgs) Handles Y2.TextChanged
        Hitung()
    End Sub

    Private Sub Y2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Y2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then e.Handled = True
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles ANS.TextChanged

    End Sub

    Private Sub Man_CheckedChanged(sender As Object, e As EventArgs) Handles Man.CheckedChanged
        Hitung()
    End Sub

    Private Sub Eul_CheckedChanged(sender As Object, e As EventArgs) Handles Eul.CheckedChanged
        Hitung()
    End Sub
End Class
