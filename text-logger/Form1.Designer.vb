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
        OutputBox = New TextBox()
        newWordInput = New TextBox()
        addBtn = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' OutputBox
        ' 
        OutputBox.Location = New Point(12, 62)
        OutputBox.Multiline = True
        OutputBox.Name = "OutputBox"
        OutputBox.ReadOnly = True
        OutputBox.Size = New Size(776, 376)
        OutputBox.TabIndex = 0
        ' 
        ' newWordInput
        ' 
        newWordInput.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        newWordInput.Location = New Point(12, 21)
        newWordInput.Name = "newWordInput"
        newWordInput.Size = New Size(390, 26)
        newWordInput.TabIndex = 1
        ' 
        ' addBtn
        ' 
        addBtn.Location = New Point(408, 21)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(75, 26)
        addBtn.TabIndex = 2
        addBtn.Text = "Add"
        addBtn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightCoral
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(503, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 26)
        Button1.TabIndex = 3
        Button1.Text = "Clear All"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(addBtn)
        Controls.Add(newWordInput)
        Controls.Add(OutputBox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OutputBox As TextBox
    Friend WithEvents newWordInput As TextBox
    Friend WithEvents addBtn As Button
    Friend WithEvents Button1 As Button
End Class
