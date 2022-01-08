Public Class UserInputForm

    'This form is for the "Enter Incident Name" textbox that appears on program launch

    Public Sub UserInputGoButton_Click(sender As Object, e As EventArgs) Handles UserInputGoButton.Click
        'Hide this box once GO is clicked
        Me.Visible = False

        'Get value of text box and store as UserInput
        'This is referenced as UserInput2 on the MainForm
        Dim UserInput As String = UserInputTextBox.Text.ToUpper

        'Set output string as date and time with hours and minutes
        Dim CustomFormat As String = System.DateTime.Now.ToString("yyyy-MMMM-dd")


        If UserInput.Length < 1 Then
            UserInput = "NOT SET BY USER"
        End If

        'Show main form and set the title as the filename
        Dim Filename As String = CustomFormat + " - " + UserInput

        MainForm.Text = Filename
        MainForm.Show()
    End Sub

    Private Sub UserInputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class