Public Class Form1
    ' Collection to store TaskRows
    Public toDoCollection As New List(Of Task.TaskRow)

    ' Task class definition
    Public Class Task
        ' Task properties
        Public name As String
        Public deadline As Date
        Public important As Boolean
        Public is_doned As Boolean

        ' TaskRow class definition to represent each task as a row
        Public Class TaskRow
            Public tasknameLabel As New Label()
            Public taskDeadline As New Label()
            Public taskImportant As New Label()
            Public taskDoned As CheckBox
            Public taskDeleteBtn As New Button()

            ' Constructor for TaskRow
            Public Sub New(_tasknameLabel As Label, _taskDeadline As Label, _taskImportant As Label, _taskDoned As CheckBox, _taskDeleteBtn As Button)
                tasknameLabel = _tasknameLabel
                taskDeadline = _taskDeadline
                taskImportant = _taskImportant
                taskDoned = _taskDoned
                taskDeleteBtn = _taskDeleteBtn
            End Sub

        End Class

        ' Constructor for Task
        Public Sub New(_name As String, _deadline As Date, _important As Boolean, _is_doned As Boolean)
            name = _name
            deadline = _deadline
            important = _important
            is_doned = _is_doned
        End Sub

        ' Function to convert Task to TaskRow
        Public Function convertToRow()
            ' Creating labels and checkbox for TaskRow
            Dim tasknameLabel As New Label()
            tasknameLabel.Text = name

            Dim taskDeadline As New Label()
            taskDeadline.Text = deadline.ToString() ' Convert deadline to string for label text

            Dim taskImportant As New Label()
            If important Then
                taskImportant.Text = "Important"
            Else
                taskImportant.Text = ""
            End If


            Dim taskIsDoned As New CheckBox()
            taskIsDoned.Checked = is_doned

            Dim taskDeleteBtn As New Button()
            taskDeleteBtn.Text = "Delete"

            ' Creating new TaskRow object and returning it
            Dim newTaskRow As New Task.TaskRow(tasknameLabel, taskDeadline, taskImportant, taskIsDoned, taskDeleteBtn)
            Return newTaskRow
        End Function

        ' Output task list on UI
        Public Sub showTasks(collection As List(Of Task.TaskRow), table As DataGridView)
            table.Rows.Clear()
            For i As Integer = 0 To collection.Count - 1
                table.Rows.Add(collection(i).tasknameLabel.Text, collection(i).taskDeadline.Text, collection(i).taskImportant.Text, collection(i).taskDoned.Checked, collection(i).taskDeleteBtn)
            Next
        End Sub
    End Class

    Public Sub deleteTaskItem(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = toDoList.Columns("deleteBtns").Index Then
            toDoList.Rows.RemoveAt(e.RowIndex)
            toDoCollection.RemoveAt(e.RowIndex)
        End If
    End Sub

    Public Sub markTask(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    ' Form load event handler
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear table rows when form loads
        toDoList.Rows.Clear()

        ' Add Delete task handler
        AddHandler toDoList.CellContentClick, AddressOf deleteTaskItem

        'Mark task as doned
        AddHandler toDoList.CellContentClick, AddressOf markTask
    End Sub

    ' Submit button click event handler
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        ' Variables to store input values
        Dim name As String
        Dim deadline As Date
        Dim important As Boolean

        ' Retrieve input values from form controls
        name = taskNameInput.Text
        deadline = deadlineInput.Value
        important = importantRadio.Checked

        ' Create a new Task object with input values and convert it to TaskRow, then add it to the collection
        Dim newTask As New Task(name, deadline, important, False)

        'Add new task
        If important Then
            toDoCollection.Insert(0, newTask.convertToRow())
        Else
            toDoCollection.Add(newTask.convertToRow())
        End If

        ' Output tasks 
        newTask.showTasks(toDoCollection, toDoList)
    End Sub
End Class
