<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayTextBox = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CurrentTimeLabel = New System.Windows.Forms.Label()
        Me.CurrentDateLabel = New System.Windows.Forms.Label()
        Me.NewIncidentButton = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TextColorButton = New System.Windows.Forms.Button()
        Me.BackgroundColorButton = New System.Windows.Forms.Button()
        Me.FontSizeTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.FontSizeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputTextBox
        '
        Me.InputTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.InputTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.InputTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputTextBox.Location = New System.Drawing.Point(0, 541)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(934, 20)
        Me.InputTextBox.TabIndex = 1
        '
        'DisplayTextBox
        '
        Me.DisplayTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayTextBox.Location = New System.Drawing.Point(0, 37)
        Me.DisplayTextBox.Multiline = True
        Me.DisplayTextBox.Name = "DisplayTextBox"
        Me.DisplayTextBox.ReadOnly = True
        Me.DisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DisplayTextBox.Size = New System.Drawing.Size(934, 498)
        Me.DisplayTextBox.TabIndex = 2
        Me.DisplayTextBox.TabStop = False
        '
        'Timer1
        '
        '
        'CurrentTimeLabel
        '
        Me.CurrentTimeLabel.AutoSize = True
        Me.CurrentTimeLabel.BackColor = System.Drawing.Color.LightCoral
        Me.CurrentTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentTimeLabel.Location = New System.Drawing.Point(92, 7)
        Me.CurrentTimeLabel.Name = "CurrentTimeLabel"
        Me.CurrentTimeLabel.Size = New System.Drawing.Size(104, 25)
        Me.CurrentTimeLabel.TabIndex = 2
        Me.CurrentTimeLabel.Text = "00:00:00"
        '
        'CurrentDateLabel
        '
        Me.CurrentDateLabel.AutoSize = True
        Me.CurrentDateLabel.BackColor = System.Drawing.Color.LightCoral
        Me.CurrentDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDateLabel.Location = New System.Drawing.Point(241, 7)
        Me.CurrentDateLabel.Name = "CurrentDateLabel"
        Me.CurrentDateLabel.Size = New System.Drawing.Size(300, 25)
        Me.CurrentDateLabel.TabIndex = 3
        Me.CurrentDateLabel.Text = "Wednesday, March 2, 2018"
        '
        'NewIncidentButton
        '
        Me.NewIncidentButton.BackColor = System.Drawing.Color.GreenYellow
        Me.NewIncidentButton.Location = New System.Drawing.Point(0, 0)
        Me.NewIncidentButton.Name = "NewIncidentButton"
        Me.NewIncidentButton.Size = New System.Drawing.Size(86, 38)
        Me.NewIncidentButton.TabIndex = 4
        Me.NewIncidentButton.Text = "New Incident"
        Me.NewIncidentButton.UseVisualStyleBackColor = False
        '
        'ColorDialog1
        '
        Me.ColorDialog1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'TextColorButton
        '
        Me.TextColorButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextColorButton.Location = New System.Drawing.Point(609, 0)
        Me.TextColorButton.Name = "TextColorButton"
        Me.TextColorButton.Size = New System.Drawing.Size(75, 38)
        Me.TextColorButton.TabIndex = 5
        Me.TextColorButton.TabStop = False
        Me.TextColorButton.Text = "Text Color"
        Me.TextColorButton.UseVisualStyleBackColor = True
        '
        'BackgroundColorButton
        '
        Me.BackgroundColorButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackgroundColorButton.Location = New System.Drawing.Point(690, 0)
        Me.BackgroundColorButton.Name = "BackgroundColorButton"
        Me.BackgroundColorButton.Size = New System.Drawing.Size(73, 38)
        Me.BackgroundColorButton.TabIndex = 6
        Me.BackgroundColorButton.TabStop = False
        Me.BackgroundColorButton.Text = "Background Color"
        Me.BackgroundColorButton.UseVisualStyleBackColor = True
        '
        'FontSizeTrackBar
        '
        Me.FontSizeTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FontSizeTrackBar.Location = New System.Drawing.Point(818, 0)
        Me.FontSizeTrackBar.Name = "FontSizeTrackBar"
        Me.FontSizeTrackBar.Size = New System.Drawing.Size(104, 45)
        Me.FontSizeTrackBar.TabIndex = 8
        Me.FontSizeTrackBar.TabStop = False
        Me.FontSizeTrackBar.Value = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(769, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Font Size:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackgroundColorButton)
        Me.Controls.Add(Me.TextColorButton)
        Me.Controls.Add(Me.NewIncidentButton)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.CurrentDateLabel)
        Me.Controls.Add(Me.CurrentTimeLabel)
        Me.Controls.Add(Me.DisplayTextBox)
        Me.Controls.Add(Me.FontSizeTrackBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "MainForm"
        Me.Text = "Timestamper"
        CType(Me.FontSizeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DisplayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CurrentTimeLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentDateLabel As System.Windows.Forms.Label
    Friend WithEvents NewIncidentButton As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents TextColorButton As System.Windows.Forms.Button
    Friend WithEvents BackgroundColorButton As System.Windows.Forms.Button
    Friend WithEvents FontSizeTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
