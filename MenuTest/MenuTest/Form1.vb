Option Explicit On
Option Strict On

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim btn_Cal As Integer
        Dim lbl_result As String
        btn_Cal = CInt(TextBox1.Text)

        If (Val(TextBox1.Text) >= 1) And (Val(TextBox1.Text) <= 15) Then
            lbl_result = CType((Val(TextBox1.Text) * 2), String)
        ElseIf (Val(TextBox1.Text) >= 16) And (Val(TextBox1.Text) <= 25) Then
            lbl_result = CType((Val(TextBox1.Text) * 3), String)
        ElseIf (Val(TextBox1.Text) >= 26) And (Val(TextBox1.Text) <= 35) Then
            lbl_result = CType((Val(TextBox1.Text) * 4), String)
        ElseIf (Val(TextBox1.Text) >= 36) And (Val(TextBox1.Text) <= 100) Then
            lbl_result = CType((Val(TextBox1.Text) * 5), String)
        ElseIf (Val(TextBox1.Text) > 100) Then
            lbl_result = CType((Val(TextBox1.Text) * 6), String)
        End If
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        Label1.Text = lbl_result
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) = False And TextBox1.Text <> "" Then
            MessageBox.Show("ป้อนข้อมูลเฉพาะตัวเลขเท่านั้น.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MessageBox.Show("สร้างโดย นายภากร รุจิเรขเสรีกุล 58030205", "About")
    End Sub
End Class