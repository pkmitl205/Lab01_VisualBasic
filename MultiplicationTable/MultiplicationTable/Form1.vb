Public Class Form1
    Private Sub calMultipleTable()
        Dim a As Integer
        Dim b As Integer = NumericUpDown1.Value
        Dim c As Integer
        Dim tmpStr As String = ""
        For a = 1 To 12
            c = a * b
            tmpStr = tmpStr & b.ToString & " X " & a.ToString & "=" & c.ToString & vbCrLf
        Next
        Label1.Text = tmpStr
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        calMultipleTable()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calMultipleTable()
    End Sub
End Class
