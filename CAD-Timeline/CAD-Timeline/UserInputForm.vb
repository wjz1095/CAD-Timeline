Public Class UserInputForm


    Public DisallowedCharacters As String = "!#$%&/()=?¡¿\/*´'~`{}^@<>;:_¨|°¬+-""[]^¨"

    'This form is for the "Enter Incident Name" textbox that appears on program launch

    Public Sub UserInputTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserInputTextBox.TextChanged


        If UserInputTextBox.Text <> "" Then 'If textbox is NOT empty, we enable the GO button
            UserInputGoButton.Enabled = True

            If UserInputTextBox.Text.IndexOfAny(DisallowedCharacters.ToCharArray) >= 0 Then 'Checking for illegal characters
                MessageBox.Show("You have entered an illegal character. Try again.", "Illegal Character Entered", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Warn user if illegal characters have been entered
                UserInputTextBox.Text = "" 'Clear text box so it doesn't loop forever
                UserInputGoButton.Enabled = False 'Disable GO button if illegal characters are present
            End If
        End If

    End Sub



    Public Sub UserInputGoButton_Click(sender As Object, e As EventArgs) Handles UserInputGoButton.Click
        'Get value of text box and store as UserInput
        'This is referenced as UserInput2 on the MainForm
        Dim UserInput As String = UserInputTextBox.Text.ToUpper

        'Set output string as date and time with hours and minutes
        Dim CustomFormat As String = System.DateTime.Now.ToString("yyyy-MMMM-dd")


       

        'Show main form and set the title as the filename
        Dim Filename As String = CustomFormat + " - " + UserInput

        'Hide this box once GO is clicked
        Me.Visible = False
        MainForm.Text = Filename
        MainForm.Show()

    End Sub

    Private Sub UserInputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    
End Class