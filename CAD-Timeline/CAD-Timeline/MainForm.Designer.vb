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
        Me.FontSizeTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TextColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlightRadar24ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleMapsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IaRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.FontSizeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputTextBox
        '
        Me.InputTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.InputTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.InputTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputTextBox.Location = New System.Drawing.Point(0, 535)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(934, 26)
        Me.InputTextBox.TabIndex = 1
        '
        'DisplayTextBox
        '
        Me.DisplayTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.CurrentDateLabel.Size = New System.Drawing.Size(342, 25)
        Me.CurrentDateLabel.TabIndex = 3
        Me.CurrentDateLabel.Text = "Wednesday, February 28, 2021"
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
        'FontSizeTrackBar
        '
        Me.FontSizeTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FontSizeTrackBar.Location = New System.Drawing.Point(829, 0)
        Me.FontSizeTrackBar.Name = "FontSizeTrackBar"
        Me.FontSizeTrackBar.Size = New System.Drawing.Size(104, 45)
        Me.FontSizeTrackBar.TabIndex = 8
        Me.FontSizeTrackBar.TabStop = False
        Me.FontSizeTrackBar.Value = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(781, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Font Size:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LinksToolStripMenuItem, Me.TextColorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(628, 7)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(153, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TextColorToolStripMenuItem
        '
        Me.TextColorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextColorToolStripMenuItem1, Me.BackgroundColorToolStripMenuItem})
        Me.TextColorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TextColorToolStripMenuItem.Name = "TextColorToolStripMenuItem"
        Me.TextColorToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.TextColorToolStripMenuItem.Text = "Customization"
        '
        'TextColorToolStripMenuItem1
        '
        Me.TextColorToolStripMenuItem1.Name = "TextColorToolStripMenuItem1"
        Me.TextColorToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.TextColorToolStripMenuItem1.Text = "Text Color"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'LinksToolStripMenuItem
        '
        Me.LinksToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LinksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FlightRadar24ToolStripMenuItem, Me.GoogleMapsToolStripMenuItem, Me.IaRToolStripMenuItem})
        Me.LinksToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinksToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LinksToolStripMenuItem.Name = "LinksToolStripMenuItem"
        Me.LinksToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.LinksToolStripMenuItem.Text = "Links"
        '
        'FlightRadar24ToolStripMenuItem
        '
        Me.FlightRadar24ToolStripMenuItem.Name = "FlightRadar24ToolStripMenuItem"
        Me.FlightRadar24ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FlightRadar24ToolStripMenuItem.Text = "FlightRadar24"
        '
        'GoogleMapsToolStripMenuItem
        '
        Me.GoogleMapsToolStripMenuItem.Name = "GoogleMapsToolStripMenuItem"
        Me.GoogleMapsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GoogleMapsToolStripMenuItem.Text = "Google Maps"
        '
        'IaRToolStripMenuItem
        '
        Me.IaRToolStripMenuItem.Name = "IaRToolStripMenuItem"
        Me.IaRToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IaRToolStripMenuItem.Text = "IaR"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NewIncidentButton)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.CurrentDateLabel)
        Me.Controls.Add(Me.CurrentTimeLabel)
        Me.Controls.Add(Me.DisplayTextBox)
        Me.Controls.Add(Me.FontSizeTrackBar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "MainForm"
        Me.Text = "Timestamper"
        CType(Me.FontSizeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents FontSizeTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LinksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlightRadar24ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoogleMapsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IaRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
