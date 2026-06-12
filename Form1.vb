Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim numero1 As Integer
        Dim numero2 As Integer
        numero1 = txtNumero1.Text
        numero2 = txtNumero2.Text
        lblMostrar.Text = "El número mayor es: " & DeterminarMayor(numero1, numero2)
    End Sub
    Private Function DeterminarMayor(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim mayor As Integer
        If num1 > num2 Then
            mayor = num1
        Else
            mayor = num2
        End If
        Return mayor
    End Function
End Class
