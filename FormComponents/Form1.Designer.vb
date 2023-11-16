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
        checkbox = New CheckBox()
        CheckedListBox = New CheckedListBox()
        ComboBox = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        ListBox1 = New ListBox()
        ListView1 = New ListView()
        passwordInput = New MaskedTextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.ImageAlign = ContentAlignment.BottomCenter
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(264, 93)
        Button1.TabIndex = 0
        Button1.Text = "This is button"
        Button1.TextImageRelation = TextImageRelation.TextBeforeImage
        Button1.UseVisualStyleBackColor = False
        ' 
        ' checkbox
        ' 
        checkbox.AutoSize = True
        checkbox.Location = New Point(310, 12)
        checkbox.Name = "checkbox"
        checkbox.Size = New Size(77, 19)
        checkbox.TabIndex = 1
        checkbox.Text = "Tao kaba?"
        checkbox.UseVisualStyleBackColor = True
        ' 
        ' CheckedListBox
        ' 
        CheckedListBox.FormattingEnabled = True
        CheckedListBox.Items.AddRange(New Object() {"Gumising", "Maligo", "Mag ano", "Mag linis"})
        CheckedListBox.Location = New Point(402, 12)
        CheckedListBox.Name = "CheckedListBox"
        CheckedListBox.Size = New Size(201, 76)
        CheckedListBox.TabIndex = 2
        ' 
        ' ComboBox
        ' 
        ComboBox.FormattingEnabled = True
        ComboBox.Items.AddRange(New Object() {"Babae", "Lalake", "Bakla"})
        ComboBox.Location = New Point(626, 12)
        ComboBox.Name = "ComboBox"
        ComboBox.Size = New Size(121, 23)
        ComboBox.TabIndex = 3
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(26, 151)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(255, 157)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 5
        Label1.Text = "This is label"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(376, 158)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(86, 15)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Pindutin moko"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"Yelo", "Sardinas", "Itlog", "Hotdog"})
        ListBox1.Location = New Point(26, 203)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(105, 64)
        ListBox1.TabIndex = 7
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(155, 203)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(121, 97)
        ListView1.TabIndex = 8
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' passwordInput
        ' 
        passwordInput.Location = New Point(299, 226)
        passwordInput.Name = "passwordInput"
        passwordInput.PasswordChar = "*"c
        passwordInput.Size = New Size(100, 23)
        passwordInput.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(302, 258)
        Button2.Name = "Button2"
        Button2.Size = New Size(97, 25)
        Button2.TabIndex = 10
        Button2.Text = "Show"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(passwordInput)
        Controls.Add(ListView1)
        Controls.Add(ListBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox)
        Controls.Add(CheckedListBox)
        Controls.Add(checkbox)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents checkbox As CheckBox
    Friend WithEvents CheckedListBox As CheckedListBox
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents passwordInput As MaskedTextBox
    Friend WithEvents Button2 As Button
End Class
