Public Class Form1
    Private Sub btnHelloWorld_Click(sender As Object, e As EventArgs) Handles btnHelloWorld.Click
        MessageBox.Show("Hello World", "Geeting",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information)
    End Sub
End Class
