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
        tempInput = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' tempInput
        ' 
        tempInput.Font = New Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        tempInput.Location = New Point(171, 126)
        tempInput.Name = "tempInput"
        tempInput.PlaceholderText = "Enter temperature"
        tempInput.Size = New Size(424, 29)
        tempInput.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(171, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(424, 45)
        Label1.TabIndex = 1
        Label1.Text = "Temperature Converter"
        ' 
        ' Label2
        ' 
        Label2.AutoEllipsis = True
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(171, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 23)
        Label2.TabIndex = 2
        Label2.Text = "Select Conversion Type"
        ' 
        ' Label3
        ' 
        Label3.AutoEllipsis = True
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(171, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 18)
        Label3.TabIndex = 3
        Label3.Text = "Temperature"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(171, 216)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(135, 19)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "Celsius to Fahrenheit"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(327, 216)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(135, 19)
        RadioButton2.TabIndex = 5
        RadioButton2.TabStop = True
        RadioButton2.Text = "Fahrenheit to Celsius"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(484, 216)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(111, 19)
        RadioButton3.TabIndex = 6
        RadioButton3.TabStop = True
        RadioButton3.Text = "Celsius to Kelvin"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(171, 241)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(111, 19)
        RadioButton4.TabIndex = 7
        RadioButton4.TabStop = True
        RadioButton4.Text = "Kelvin to Celsius"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(171, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(424, 33)
        Button1.TabIndex = 8
        Button1.Text = "Convert"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tempInput)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tempInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Button1 As Button
End Class
