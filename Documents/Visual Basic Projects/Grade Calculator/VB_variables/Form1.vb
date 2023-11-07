Public Class Form1
    ' Initialize gradeAv variable
    Dim gradeAvTotal As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial value of gradeAv
        gradeAvTotal = 0
    End Sub

    Private Sub show_total()
        ' Intialize single data type variables for single parse assignments
        Dim subject1GradeValue As Single
        Dim subject2GradeValue As Single
        Dim subject3GradeValue As Single

        ' If failed to parse the whole data will be 0
        If Not Single.TryParse(subject1Grade.Text, subject1GradeValue) Or Not Single.TryParse(subject2Grade.Text, subject2GradeValue) Or Not Single.TryParse(subject3Grade.Text, subject3GradeValue) Then
            subject1GradeValue = 0
            subject2GradeValue = 0
            subject3GradeValue = 0
        End If

        ' Calculate total grade aversge
        gradeAvTotal = (subject1GradeValue + subject2GradeValue + subject3GradeValue) / 3

        ' Output total average to gradeAv text field
        gradeAv.Text = gradeAvTotal
    End Sub

    Private Sub subject1Grade_TextChanged(sender As Object, e As EventArgs) Handles subject1Grade.TextChanged
        show_total()
    End Sub

    Private Sub subject2Grade_TextChanged(sender As Object, e As EventArgs) Handles subject2Grade.TextChanged
        show_total()
    End Sub

    Private Sub subject3Grade_TextChanged(sender As Object, e As EventArgs) Handles subject3Grade.TextChanged
        show_total()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Reset fields
        subject1Grade.Text = 0
        subject2Grade.Text = 0
        subject3Grade.Text = 0
        studentName.Text = ""
        course.Text = ""

        show_total()
    End Sub
End Class
