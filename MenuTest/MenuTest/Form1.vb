Option Explicit On
Option Strict On
Imports Microsoft.VisualBasic.CompilerServices

Public Class Frm_Calculator
    Dim OperatorSign As String
    Dim Operand1, Operand2 As Double
    Dim Result As Double
    Dim SignPressed As Boolean = False

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        show_Number("0")
    End Sub


    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        show_Number("1")
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        show_Number("2")
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        show_Number("3")
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        show_Number("4")
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        show_Number("5")
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        show_Number("6")
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        show_Number("7")
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        show_Number("8")
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        show_Number("9")
    End Sub

    Private Sub btn_Dot_Click(sender As Object, e As EventArgs) Handles btn_Dot.Click
        If InStr(txt_Output.Text, ".") = 0 Then
            show_Number(".")
        End If
    End Sub

    Private Sub btn_C_Click(sender As Object, e As EventArgs) Handles btn_C.Click
        txt_Output.Text = "0"
    End Sub

    Private Sub btn_CE_Click(sender As Object, e As EventArgs) Handles btn_CE.Click
        txt_Output.Text = "0"
    End Sub

    Private Sub btn_BS_Click(sender As Object, e As EventArgs) Handles btn_BS.Click
        txt_Output.Text = Mid(txt_Output.Text, 1, txt_Output.Text.Length - 1)
        If txt_Output.Text = "" Then
            txt_Output.Text = "0"
        End If
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        SignPressed = True
        OperatorSign = "+"
        Operand1 = CDbl(txt_Output.Text)
    End Sub

    Private Sub btn_Sub_Click(sender As Object, e As EventArgs) Handles btn_Sub.Click
        SignPressed = True
        OperatorSign = "-"
        Operand1 = CDbl(txt_Output.Text)
    End Sub

    Private Sub btn_Mul_Click(sender As Object, e As EventArgs) Handles btn_Mul.Click
        SignPressed = True
        OperatorSign = "*"
        Operand1 = CDbl(txt_Output.Text)
    End Sub

    Private Sub btn_Dev_Click(sender As Object, e As EventArgs) Handles btn_Dev.Click
        SignPressed = True
        OperatorSign = "/"
        Operand1 = CDbl(txt_Output.Text)

    End Sub

    Private Sub btn_sqrt_Click(sender As Object, e As EventArgs) Handles btn_sqrt.Click
        SignPressed = True
        OperatorSign = "sqrt"
        Operand1 = CDbl(txt_Output.Text)
    End Sub

    Private Sub btn_DevX_Click(sender As Object, e As EventArgs) Handles btn_DevX.Click
        SignPressed = True
        OperatorSign = "1/x"
        Operand1 = CDbl(txt_Output.Text)
    End Sub

    Private Sub show_Number(ByVal input As String)
        If SignPressed = True Then
            SignPressed = False
            txt_Output.Text = ""
        End If

        If txt_Output.Text = "0" Then
            txt_Output.Text = input
        Else
            txt_Output.Text += input
        End If
    End Sub

    Private Sub btn_Equal_Click(sender As Object, e As EventArgs) Handles btn_Equal.Click
        Operand2 = CDbl(txt_Output.Text)

        If OperatorSign = "+" Then
            Result = Operand1 + Operand2
        End If

        If OperatorSign = "-" Then
            Result = Operand1 - Operand2
        End If

        If OperatorSign = "*" Then
            Result = Operand1 * Operand2
        End If

        If OperatorSign = "/" Then
            Result = Operand1 / Operand2
        End If

        If OperatorSign = "-/+" Then
            Result = -Val(txt_Output.Text)
        End If

        If OperatorSign = "sqrt" Then
            Result = Math.Sqrt(Val(txt_Output.Text))
        End If

        If OperatorSign = "1/x" Then
            Result = 1 / (Val(txt_Output.Text))
        End If

        txt_Output.Text = CType(Result, String)
    End Sub
End Class