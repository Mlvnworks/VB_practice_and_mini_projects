Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Health Index Calculator

        'Declare variables
        Dim clientName As String
        Dim BMI As Single
        Dim weightKg As Single
        Dim heightF As Single
        Dim healthIndex As String



        Try
            ' Get the client Info
            clientName = InputBox("Enter your name")
            weightKg = Single.Parse(InputBox("Enter your weight(Kg): "))
            heightF = Single.Parse(InputBox("Enter your height(m): "))

            ' Convert feet to meter
            heightF = heightF / 3.281

            'Get the BMI using this formula
            BMI = weightKg / (heightF * heightF)



            'Get the client health index
            If BMI < 18.5 Then
                healthIndex = "Underweight"

            ElseIf BMI >= 18.5 And BMI <= 24.9 Then
                healthIndex = "Normal"

            ElseIf BMI >= 25 And BMI <= 29.9 Then
                healthIndex = "Overweight"
            Else
                healthIndex = "Obesity"
            End If

            'Output BMi
            MessageBox.Show("Name: " & clientName & Environment.NewLine &
                            "Weight (kg): " & weightKg & Environment.NewLine &
                            "Height (m): " & heightF & Environment.NewLine &
                            "------------------- Result ---------------------" & Environment.NewLine &
                            "Health Index: " & BMI & "--" & healthIndex
                            )
        Catch ex As Exception
            ' Catch procedure error
            MessageBox.Show("Something went wrong! Please check your input.")
        End Try

    End Sub
End Class
