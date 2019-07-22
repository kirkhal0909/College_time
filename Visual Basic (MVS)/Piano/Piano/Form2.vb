Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB1.Text = My.Forms.Form1.TB1.Text
        TB2.Text = My.Forms.Form1.TB2.Text
    End Sub

    Private Sub TB1_TextChanged(sender As Object, e As EventArgs) Handles TB1.TextChanged
        My.Forms.Form1.TB1.Text = TB1.Text
    End Sub

    Private Sub TB2_TextChanged(sender As Object, e As EventArgs) Handles TB2.TextChanged
        My.Forms.Form1.TB2.Text = TB2.Text
    End Sub
End Class