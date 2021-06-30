Public Class MainForm

    Public appPath As String = Application.StartupPath() 'Get startup path for application for file writing purposes
    Public UserInput2 As String = " " 'Set popup window when program first launches to have a blank text box on launch
    Public localZone As TimeZone = TimeZone.CurrentTimeZone 'Create object to pull timezone from
    Public currentTZ As String = localZone.StandardName 'Get current timezone
    Private mswStartTime As New Stopwatch 'For elapsed time counting

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Get and set timezone, write this to the appropriate locations
        Dim currentDate As DateTime = DateTime.Now

        'Variables for time logging at creation of file
        'Dim currentTZ As String = localZone.StandardName 'We get this in the PUBLIC section above so all classes can read it, no need to enable here, leaving for debugging purposes
        Dim localTime As String = currentDate.ToString()
        Dim daylightActive As Boolean = localZone.IsDaylightSavingTime(currentDate)
        Dim currentUTC As DateTime = localZone.ToUniversalTime(currentDate)
        Dim currentOffset As TimeSpan = localZone.GetUtcOffset(currentDate)

        'Debugging outputs
        'Console.WriteLine("Local TZ: " + currentTZ)
        'Console.WriteLine("Local time: " + localTime)
        'Console.WriteLine("Daylight Active? " + daylightActive.ToString())
        'Console.WriteLine("UTC Time: " + currentUTC.ToString())
        'Console.WriteLine("UTC Offset: " + currentOffset.ToString())

        'Start main timer and display current time on screen
        Timer1.Interval = 1000 'Timer interval to 1 second per tick
        Timer1.Start() ' Start the timer, NOT the stopwatch, this is for the on screen current time display
        CurrentDateLabel.Text = System.DateTime.Now.ToString("dddd, MMMM dd yyyy") ' Show the date on the CurrentDateLabel on launch

        'Get current time and store in variable, begin elapsed time counter
        mswStartTime.Start()

        'When program launches, create file and insert BEGIN OF FILE string
        Dim appPath As String = Application.StartupPath()

        UserInput2 = Me.Text

        'Gets the date from the UserInputForm and the date is included in UserInput2
        appPath = appPath + "\" + UserInput2 + ".txt"
        My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "File created at: " + appPath, True)
        My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + " ", True) 'Blank line to separate info

        'Write time data to file
        My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "Local TZ:     " + currentTZ, True)
        My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "Local time:   " + localTime, True)
        My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "DST active?   " + daylightActive.ToString(), True)
        My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "UTC Time:     " + currentUTC.ToString(), True)
        My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "UTC Offset:   " + currentOffset.ToString(), True)
        My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + " ", True) 'Blank line to separate info

        'Write BEGIN OF FILE to file
        My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "------BEGIN OF FILE------  " + System.DateTime.Now.ToString("yyyy-MMMM-dd ") + TimeOfDay.ToString("HH:mm:ss ") + currentTZ, True)
        DisplayTextBox.Text = "File created at: " + appPath

        'MessageBox.Show("The Timestamper program will automatically create a .txt file in the directory: " + appPath + " The file will be named '" + "STAMP-ENTRY " + System.DateTime.Now.ToString("MM-dd-yyyy") + ".txt'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' When the timer ticks, it updates the time display on the form, date, and elapsed time since program started
        CurrentTimeLabel.Text = TimeOfDay.ToString("HH:mm:ss")
        CurrentDateLabel.Text = System.DateTime.Now.ToString("dddd, MMMM dd yyyy") ' This is here so if the program is open while the time ticks over to midnight, it will change the date as well
        ElapsedTimeLabel.Text = mswStartTime.Elapsed.Hours.ToString("0#") & ":" & mswStartTime.Elapsed.Minutes.ToString("0#") & ":" & mswStartTime.Elapsed.Seconds.ToString("0#")
    End Sub

    ' When Enter is pressed, it will write the date and time along with the contents of the input text box to the display text box
    Private Sub InputTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InputTextBox.KeyDown
        Dim OutputString As String = ""
        If e.KeyCode = Keys.Enter Then
            If InputTextBox.Text <> "" Then ' If the text box is NOT empty then it will continue with appending to the text box
                OutputString = System.DateTime.Now.ToString("yyyy-MMMM-dd") + " " + TimeOfDay.ToString("HH:mm:ss") + " > " + InputTextBox.Text

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
        If MessageBox.Show("Are you sure you want to close the program?", "Program Close Confirmation", MessageBoxButtons.YesNo) = DialogResult.No Then
            ' Cancel the Closing event from closing the form.
            e.Cancel = True
        Else
            mswStartTime.Stop() 'Stop stopwatch
            Timer1.Stop() 'Stop timer when form closes in the event it did not stop on its own

            'Convert stopwatch time to remove milliseconds
            Dim ts As TimeSpan = mswStartTime.Elapsed
            Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds)

            'Write closing file statements
            Dim appPath As String = Application.StartupPath()
            appPath = appPath + "\" + UserInput2 + ".txt" 'Get path of the running program to write the file to
            My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "------END  OF  FILE------  " + System.DateTime.Now.ToString("yyyy-MMMM-dd ") + TimeOfDay.ToString("HH:mm:ss ") + currentTZ, True)
            My.Computer.FileSystem.WriteAllText(appPath, Environment.NewLine + "ELAPSED TIME: " + elapsedTime, True)

            appPath = ""
            UserInput2 = "" 'Set popup window for new incident to blank text box
            Application.Exit()
            End
        End If
    End Sub

    Private Sub NewIncidentButton_Click(sender As Object, e As EventArgs) Handles NewIncidentButton.Click
        'When this button is clicked, it opens a new version of the timestamper while leaving the current one running
        Dim NewIncident As String = Application.ExecutablePath

        Process.Start(NewIncident)
    End Sub


    Private Sub FontSizeTrackBar_Scroll(sender As Object, e As EventArgs) Handles FontSizeTrackBar.Scroll
        If FontSizeTrackBar.Value = 0 Then
            DisplayTextBox.Font = New Font("Microsoft Sans Serif", 6, FontStyle.Bold)
            InputTextBox.Font = New Font("Microsoft Sans Serif", 6, FontStyle.Bold)
            ElapsedTimeLabel.Font = New Font("Microsoft Sans Serif", 6, FontStyle.Bold)
        End If
        If FontSizeTrackBar.Value = 1 Then
            DisplayTextBox.Font = New Font("Microsoft Sans Serif", 7, FontStyle.Bold)
            InputTextBox.Font = New Font("Microsoft Sans Serif", 7, FontStyle.Bold)
            ElapsedTimeLabel.Font = New Font("Microsoft Sans Serif", 7, FontStyle.Bold)
        End If
        If FontSizeTrackBar.Value = 2 Then
            DisplayTextBox.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
            InputTextBox.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
            ElapsedTimeLabel.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        End If
        If FontSizeTrackBar.Value = 3 Then
            DisplayTextBox.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            InputTextBox.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            ElapsedTimeLabel.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        End If
        If FontSizeTrackBar.Value = 4 Then
            DisplayTextBox.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
            InputTextBox.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
            ElapsedTimeLabel.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        End If
        If FontSizeTrackBar.Value = 5 Then
            DisplayTextBox.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
            InputTextBox.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
            ElapsedTimeLabel.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
        End If
        If FontSizeTrackBar.Value = 6 Then
            DisplayTextBox.Font = New Font("Microsoft Sans Serif", 24, FontStyle.Bold)
            InputTextBox.Font = New Font("Microsoft Sans Serif", 24, FontStyle.Bold)
            ElapsedTimeLabel.Font = New Font("Microsoft Sans Serif", 24, FontStyle.Bold)
        End If
        If FontSizeTrackBar.Value = 7 Then
            DisplayTextBox.Font = New Font("Microsoft Sans Serif", 28, FontStyle.Bold)
            InputTextBox.Font = New Font("Microsoft Sans Serif", 28, FontStyle.Bold)
            ElapsedTimeLabel.Font = New Font("Microsoft Sans Serif", 28, FontStyle.Bold)
        End If
    End Sub


    Private Sub TextColorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TextColorToolStripMenuItem1.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = DisplayTextBox.ForeColor

        If (cDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            DisplayTextBox.ForeColor = cDialog.Color

            'This is here as the text color will not update unless the background color is updated. This just tricks it into working
            DisplayTextBox.BackColor = DisplayTextBox.BackColor
        End If
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = DisplayTextBox.BackColor

        If (cDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            DisplayTextBox.BackColor = cDialog.Color
        End If
    End Sub

    Private Sub FlightRadar24ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlightRadar24ToolStripMenuItem.Click
        Dim webAddress As String = "https://www.flightradar24.com/40.56,-74.68/11"
        Process.Start(webAddress)
    End Sub

    Private Sub GoogleMapsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleMapsToolStripMenuItem.Click
        Dim webAddress As String = "https://www.google.com/maps/@40.507796,-74.850641,13z"
        Process.Start(webAddress)
    End Sub

    Private Sub IaRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IaRToolStripMenuItem.Click
        Dim webAddress As String = "https://dashboard.iamresponding.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub OnlineStopwatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlineStopwatchToolStripMenuItem.Click
        Dim webAddress As String = "https://www.timeanddate.com/stopwatch/"
        Process.Start(webAddress)
    End Sub

    Private Sub OnlineStopwatch2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlineStopwatch2ToolStripMenuItem.Click
        Dim webAddress As String = "https://www.estopwatch.net/"
        Process.Start(webAddress)
    End Sub

    Private Sub CurrentFileLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentFileLocationToolStripMenuItem.Click
        Dim appPath As String = Application.StartupPath()
        Process.Start(appPath)
    End Sub

    Private Sub StartTimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartTimerToolStripMenuItem.Click
        'Start timer
        mswStartTime.Start()
        ElapsedTimeLabel.Text = mswStartTime.Elapsed.Hours.ToString("0#") & ":" & mswStartTime.Elapsed.Minutes.ToString("0#") & ":" & mswStartTime.Elapsed.Seconds.ToString("0#")
    End Sub

    Private Sub StopTimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopTimerToolStripMenuItem.Click
        'Stop timer
        'Update stopwatch label to show time
        mswStartTime.Stop()
        ElapsedTimeLabel.Text = mswStartTime.Elapsed.Hours.ToString("0#") & ":" & mswStartTime.Elapsed.Minutes.ToString("0#") & ":" & mswStartTime.Elapsed.Seconds.ToString("0#")
    End Sub

    Private Sub ResetTimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetTimerToolStripMenuItem.Click
        'Stop Timer
        'Reset timer to 0
        'Do NOT start timer back up
        mswStartTime.Reset()
        ElapsedTimeLabel.Text = mswStartTime.Elapsed.Hours.ToString("0#") & ":" & mswStartTime.Elapsed.Minutes.ToString("0#") & ":" & mswStartTime.Elapsed.Seconds.ToString("0#")
    End Sub

    Private Sub ClockTextColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClockTextColorToolStripMenuItem.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = CurrentTimeLabel.ForeColor

        If (cDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            CurrentTimeLabel.ForeColor = cDialog.Color
            CurrentDateLabel.ForeColor = cDialog.Color
            ElapsedTimeLabel.ForeColor = cDialog.Color
        End If


    End Sub

    Private Sub ClockBGColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClockBGColorToolStripMenuItem.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = CurrentTimeLabel.BackColor

        If (cDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            CurrentTimeLabel.BackColor = cDialog.Color
            CurrentDateLabel.BackColor = cDialog.Color
            ElapsedTimeLabel.BackColor = cDialog.Color
        End If



    End Sub
End Class
