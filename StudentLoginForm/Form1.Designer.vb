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
        Label1 = New Label()
        usernameInput = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        passwordInput = New TextBox()
        loginBtn = New Button()
        cancelBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(208, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 40)
        Label1.TabIndex = 0
        Label1.Text = "Student Login Form"
        ' 
        ' usernameInput
        ' 
        usernameInput.BackColor = SystemColors.InactiveCaption
        usernameInput.Font = New Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        usernameInput.Location = New Point(208, 134)
        usernameInput.Name = "usernameInput"
        usernameInput.PlaceholderText = "Enter username"
        usernameInput.Size = New Size(361, 29)
        usernameInput.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AccessibleRole = AccessibleRole.ButtonMenu
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(208, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 20)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AccessibleRole = AccessibleRole.ButtonMenu
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(208, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' passwordInput
        ' 
        passwordInput.BackColor = SystemColors.InactiveCaption
        passwordInput.Font = New Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        passwordInput.ForeColor = SystemColors.WindowText
        passwordInput.Location = New Point(208, 229)
        passwordInput.Name = "passwordInput"
        passwordInput.PlaceholderText = "Enter password"
        passwordInput.Size = New Size(361, 29)
        passwordInput.TabIndex = 4
        ' 
        ' loginBtn
        ' 
        loginBtn.BackColor = SystemColors.ActiveCaptionText
        loginBtn.Font = New Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        loginBtn.ForeColor = SystemColors.ButtonHighlight
        loginBtn.Location = New Point(208, 291)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(361, 39)
        loginBtn.TabIndex = 5
        loginBtn.Text = "Log in"
        loginBtn.UseVisualStyleBackColor = False
        ' 
        ' cancelBtn
        ' 
        cancelBtn.BackColor = SystemColors.ActiveBorder
        cancelBtn.Font = New Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        cancelBtn.Location = New Point(208, 345)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(361, 35)
        cancelBtn.TabIndex = 6
        cancelBtn.Text = "Cancel"
        cancelBtn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cancelBtn)
        Controls.Add(loginBtn)
        Controls.Add(passwordInput)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(usernameInput)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents usernameInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents passwordInput As TextBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents cancelBtn As Button
End Class
