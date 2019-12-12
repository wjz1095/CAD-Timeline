Public Class UserInputForm

    Public Sub UserInputGoButton_Click(sender As Object, e As EventArgs) Handles UserInputGoButton.Click
        'Hide this box
        Me.Visible = False

        Dim UserInput As String = UserInputTextBox.Text.ToUpper
        'Show main form and set the title as the filename
        MainForm.Text = System.DateTime.Now.ToString("MM-dd-yyyy") + " - " + UserInput
        MainForm.Show()
    End Sub
End Class