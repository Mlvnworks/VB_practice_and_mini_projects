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
        Label2 = New Label()
        taskNameInput = New TextBox()
        deadlineInput = New DateTimePicker()
        Label3 = New Label()
        submitBtn = New Button()
        toDoList = New DataGridView()
        taskName = New DataGridViewTextBoxColumn()
        deadlines = New DataGridViewTextBoxColumn()
        prioritize = New DataGridViewTextBoxColumn()
        done = New DataGridViewCheckBoxColumn()
        deleteBtns = New DataGridViewButtonColumn()
        importantRadio = New CheckBox()
        CType(toDoList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 23.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 36)
        Label1.TabIndex = 0
        Label1.Text = "To-Do-List Application"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(39, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 1
        Label2.Text = "Task name"
        ' 
        ' taskNameInput
        ' 
        taskNameInput.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        taskNameInput.Location = New Point(39, 145)
        taskNameInput.Name = "taskNameInput"
        taskNameInput.PlaceholderText = "Enter task name"
        taskNameInput.Size = New Size(320, 27)
        taskNameInput.TabIndex = 2
        ' 
        ' deadlineInput
        ' 
        deadlineInput.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        deadlineInput.Location = New Point(39, 226)
        deadlineInput.Name = "deadlineInput"
        deadlineInput.Size = New Size(315, 27)
        deadlineInput.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(39, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 20)
        Label3.TabIndex = 5
        Label3.Text = "deadline"
        ' 
        ' submitBtn
        ' 
        submitBtn.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        submitBtn.Location = New Point(42, 300)
        submitBtn.Name = "submitBtn"
        submitBtn.Size = New Size(312, 35)
        submitBtn.TabIndex = 6
        submitBtn.Text = "Submit Task"
        submitBtn.UseVisualStyleBackColor = True
        ' 
        ' toDoList
        ' 
        toDoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        toDoList.Columns.AddRange(New DataGridViewColumn() {taskName, deadlines, prioritize, done, deleteBtns})
        toDoList.Location = New Point(376, 115)
        toDoList.Name = "toDoList"
        toDoList.RowTemplate.Height = 25
        toDoList.Size = New Size(471, 220)
        toDoList.TabIndex = 7
        ' 
        ' taskName
        ' 
        taskName.HeaderText = "Task name"
        taskName.Name = "taskName"
        taskName.ReadOnly = True
        ' 
        ' deadlines
        ' 
        deadlines.HeaderText = "Deadline"
        deadlines.Name = "deadlines"
        deadlines.ReadOnly = True
        ' 
        ' prioritize
        ' 
        prioritize.HeaderText = ""
        prioritize.Name = "prioritize"
        prioritize.ReadOnly = True
        ' 
        ' done
        ' 
        done.HeaderText = "Doned"
        done.Name = "done"
        ' 
        ' deleteBtns
        ' 
        deleteBtns.HeaderText = "delete"
        deleteBtns.Name = "deleteBtns"
        deleteBtns.ReadOnly = True
        deleteBtns.Text = "Delete"
        deleteBtns.UseColumnTextForButtonValue = True
        ' 
        ' importantRadio
        ' 
        importantRadio.AutoSize = True
        importantRadio.Location = New Point(250, 120)
        importantRadio.Name = "importantRadio"
        importantRadio.Size = New Size(79, 19)
        importantRadio.TabIndex = 8
        importantRadio.Text = "Important"
        importantRadio.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(859, 455)
        Controls.Add(importantRadio)
        Controls.Add(toDoList)
        Controls.Add(submitBtn)
        Controls.Add(Label3)
        Controls.Add(deadlineInput)
        Controls.Add(taskNameInput)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(toDoList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents taskNameInput As TextBox
    Friend WithEvents deadlineInput As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents submitBtn As Button
    Public WithEvents toDoList As DataGridView
    Friend WithEvents taskName As DataGridViewTextBoxColumn
    Friend WithEvents deadlines As DataGridViewTextBoxColumn
    Friend WithEvents prioritize As DataGridViewTextBoxColumn
    Friend WithEvents done As DataGridViewCheckBoxColumn
    Friend WithEvents deleteBtns As DataGridViewButtonColumn
    Friend WithEvents importantRadio As CheckBox
End Class
