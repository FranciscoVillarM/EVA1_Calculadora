
Public Class Calculadora


    Dim operando1 As Double
    Dim operando2 As Double
    Dim operador As String

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Btn0.Click, Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click
        Dim btn As Button = sender
        txtDisplay.Text &= btn.Text
    End Sub

    Private Sub BtnSumar_Click(sender As Object, e As EventArgs) Handles BtnSumar.Click
        Try
            If operador = "+" Then
                Return
            End If
            operando1 = Convert.ToDouble(txtDisplay.Text)
            operador = "+"
            txtDisplay.Text = ""
        Catch ex As FormatException
            MessageBox.Show("Entrada inválida. Por favor, ingrese un número válido.")
        End Try
    End Sub

    Private Sub BtnRestar_Click(sender As Object, e As EventArgs) Handles BtnRestar.Click
        Try
            If operador = "-" Then
                Return
            End If
            operando1 = Convert.ToDouble(txtDisplay.Text)
            operador = "-"
            txtDisplay.Text = ""
        Catch ex As FormatException
            MessageBox.Show("Entrada inválida. Por favor, ingrese un número válido.")
        End Try
    End Sub

    Private Sub BtnMultiplicar_Click(sender As Object, e As EventArgs) Handles BtnMultiplicar.Click
        Try
            If operador = "*" Then
                Return
            End If
            operando1 = Convert.ToDouble(txtDisplay.Text)
            operador = "*"
            txtDisplay.Text = ""
        Catch ex As FormatException
            MessageBox.Show("Entrada inválida. Por favor, ingrese un número válido.")
        End Try
    End Sub

    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles BtnDividir.Click
        Try
            If operador = "/" Then
                Return
            End If
            operando1 = Convert.ToDouble(txtDisplay.Text)
            operador = "/"
            txtDisplay.Text = ""
        Catch ex As FormatException
            MessageBox.Show("Entrada inválida. Por favor, ingrese un número válido.")
        End Try
    End Sub

    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles BtnResultado.Click
        Try
            If operador = "=" Then
                Return
            End If
            operando2 = Convert.ToDouble(txtDisplay.Text)
        Dim resultado As Double
        Select Case operador
            Case "+"
                resultado = operando1 + operando2
            Case "-"
                resultado = operando1 - operando2
            Case "*"
                resultado = operando1 * operando2
            Case "/"
                If operando2 <> 0 Then
                    resultado = operando1 / operando2
                Else
                    MessageBox.Show("División por cero no permitida.")
                End If
            Case Else
                MessageBox.Show("Operador no válido.")
        End Select
            txtDisplay.Text = resultado.ToString()
        Catch ex As FormatException
            MessageBox.Show("Entrada inválida. Por favor, ingrese un número válido.")
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        txtDisplay.Text = ""
        operando1 = 0
        operando2 = 0
        operador = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
