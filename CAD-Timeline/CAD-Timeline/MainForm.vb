Public Class MainForm

    Public appPath As String = Application.StartupPath()
    Public UserInput2 As String = " "

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start() ' Start the timer
        CurrentDateLabel.Text = System.DateTime.Now.ToString("dddd, MMMM dd yyyy") ' Show the date on the CurrentDateLabel on launch

        'When program launches, create file and insert BEGIN OF FILE string
        Dim appPath As String = Application.StartupPath()

        UserInput2 = Me.Text

        'Gets the date from the UserInputForm and the date is included in UserInput2
        appPath = appPath + "\" + UserInput2 + ".txt"
        My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "File created at: " + appPath, True)
        My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "------BEGIN OF FILE------  " + System.DateTime.Now.ToString("MM/dd/yyyy ") + TimeOfDay.ToString("HH:mm:ss") + " EST", True)
        DisplayTextBox.Text = "File created at: " + appPath

        'MessageBox.Show("The Timestamper program will automatically create a .txt file in the directory: " + appPath + " The file will be named '" + "STAMP-ENTRY " + System.DateTime.Now.ToString("MM-dd-yyyy") + ".txt'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' When the timer ticks, it updates the time display on the form, and the date
        CurrentTimeLabel.Text = TimeOfDay.ToString("HH:mm:ss") + "EST"
        CurrentDateLabel.Text = System.DateTime.Now.ToString("dddd, MMMM dd yyyy") ' This is here so if the program is open while the time ticks over to midnight, it will change the date as well
    End Sub

    ' When Enter is pressed, it will write the date and time along with the contents of the input text box to the display text box
    Private Sub InputTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InputTextBox.KeyDown
        Dim OutputString As String = ""
        If e.KeyCode = Keys.Enter Then
            If InputTextBox.Text <> "" Then ' If the text box is NOT empty then it will continue with appending to the text box
                OutputString = System.DateTime.Now.ToString("MM/dd/yyyy ") + TimeOfDay.ToString("HH:mm:ss") + " EST  |  " + InputTextBox.Text

                OutputString = OutputString.ToUpper()
                DisplayTextBox.AppendText(Environment.NewLine + OutputString)

                appPath = Application.StartupPath()
                appPath = appPath + "\" + UserInput2 + ".txt"

                My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + OutputString, True)
                InputTextBox.Text = ""
            End If
        End If
    End Sub

    ' When attempting to close the form, it will ask and confirm if you want to close it instead of just closing
    Private Sub MainForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MessageBox.Show("Are you sure you want to close the timestamper?", "Timestamper Close Confirmation", MessageBoxButtons.YesNo) = DialogResult.No Then
            ' Cancel the Closing event from closing the form.
            e.Cancel = True
        Else
            Dim appPath As String = Application.StartupPath()
            appPath = appPath + "\" + UserInput2 + ".txt"
            My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "------END  OF  FILE------" + System.DateTime.Now.ToString("MM/dd/yyyy ") + TimeOfDay.ToString("HH:mm:ss") + " EST", True)
            appPath = ""
            UserInput2 = ""
        End If
    End Sub
End Class
