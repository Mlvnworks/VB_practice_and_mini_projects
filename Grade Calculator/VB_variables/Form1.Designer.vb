<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        studentName = New TextBox()
        course = New TextBox()
        subject1Grade = New TextBox()
        subject2Grade = New TextBox()
        subject3Grade = New TextBox()
        gradeAv = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkRed
        Button1.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.Info
        Button1.Location = New Point(320, 344)
        Button1.Name = "Button1"
        Button1.Size = New Size(284, 42)
        Button1.TabIndex = 0
        Button1.Text = "Clear Fields"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.WindowFrame
        Label1.Location = New Point(94, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 22)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.WindowFrame
        Label2.Location = New Point(94, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 22)
        Label2.TabIndex = 2
        Label2.Text = "Course"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.WindowFrame
        Label3.Location = New Point(94, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 22)
        Label3.TabIndex = 3
        Label3.Text = "Subject 1 Grade:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonHighlight
        Label4.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.WindowFrame
        Label4.Location = New Point(94, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 22)
        Label4.TabIndex = 4
        Label4.Text = "Subject 2 Grade:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonHighlight
        Label5.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.WindowFrame
        Label5.Location = New Point(94, 234)
        Label5.Name = "Label5"
        Label5.Size = New Size(164, 22)
        Label5.TabIndex = 5
        Label5.Text = "Subject 3 Grade:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ButtonHighlight
        Label6.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.WindowFrame
        Label6.Location = New Point(94, 284)
        Label6.Name = "Label6"
        Label6.Size = New Size(153, 22)
        Label6.TabIndex = 6
        Label6.Text = "Total Grade Av:"
        ' 
        ' studentName
        ' 
        studentName.BackColor = SystemColors.Menu
        studentName.Font = New Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        studentName.Location = New Point(320, 73)
        studentName.Name = "studentName"
        studentName.Size = New Size(284, 29)
        studentName.TabIndex = 7
        studentName.Tag = ""
        ' 
        ' course
        ' 
        course.BackColor = SystemColors.Menu
        course.Font = New Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        course.Location = New Point(320, 111)
        course.Name = "course"
        course.Size = New Size(284, 29)
        course.TabIndex = 8
        ' 
        ' subject1Grade
        ' 
        subject1Grade.BackColor = SystemColors.Menu
        subject1Grade.Font = New Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        subject1Grade.Location = New Point(320, 162)
        subject1Grade.Name = "subject1Grade"
        subject1Grade.Size = New Size(284, 29)
        subject1Grade.TabIndex = 9
        ' 
        ' subject2Grade
        ' 
        subject2Grade.BackColor = SystemColors.Menu
        subject2Grade.Font = New Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        subject2Grade.Location = New Point(320, 196)
        subject2Grade.Name = "subject2Grade"
        subject2Grade.Size = New Size(284, 29)
        subject2Grade.TabIndex = 10
        ' 
        ' subject3Grade
        ' 
        subject3Grade.BackColor = SystemColors.Menu
        subject3Grade.Font = New Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        subject3Grade.Location = New Point(320, 233)
        subject3Grade.Name = "subject3Grade"
        subject3Grade.Size = New Size(284, 29)
        subject3Grade.TabIndex = 11
        ' 
        ' gradeAv
        ' 
        gradeAv.BorderStyle = BorderStyle.None
        gradeAv.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        gradeAv.ImeMode = ImeMode.NoControl
        gradeAv.Location = New Point(320, 283)
        gradeAv.Name = "gradeAv"
        gradeAv.PlaceholderText = "0.00"
        gradeAv.ReadOnly = True
        gradeAv.Size = New Size(284, 22)
        gradeAv.TabIndex = 12
        gradeAv.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(gradeAv)
        Controls.Add(subject3Grade)
        Controls.Add(subject2Grade)
        Controls.Add(subject1Grade)
        Controls.Add(course)
        Controls.Add(studentName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        ForeColor = SystemColors.WindowFrame
        Name = "Form1"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents studentName As TextBox
    Friend WithEvents course As TextBox
    Friend WithEvents subject1Grade As TextBox
    Friend WithEvents subject2Grade As TextBox
    Friend WithEvents subject3Grade As TextBox
    Friend WithEvents gradeAv As TextBox
End Class
