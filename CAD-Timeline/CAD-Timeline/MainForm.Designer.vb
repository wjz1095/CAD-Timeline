﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.NightModeCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'InputTextBox
        '
        Me.InputTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.InputTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.InputTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputTextBox.Location = New System.Drawing.Point(0, 557)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(854, 20)
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
        Me.DisplayTextBox.Size = New System.Drawing.Size(854, 514)
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
        Me.CurrentDateLabel.Location = New System.Drawing.Point(266, 7)
        Me.CurrentDateLabel.Name = "CurrentDateLabel"
        Me.CurrentDateLabel.Size = New System.Drawing.Size(163, 25)
        Me.CurrentDateLabel.TabIndex = 3
        Me.CurrentDateLabel.Text = "March 2, 2018"
        '
        'NewIncidentButton
        '
        Me.NewIncidentButton.BackColor = System.Drawing.Color.GreenYellow
        Me.NewIncidentButton.Location = New System.Drawing.Point(0, 3)
        Me.NewIncidentButton.Name = "NewIncidentButton"
        Me.NewIncidentButton.Size = New System.Drawing.Size(86, 31)
        Me.NewIncidentButton.TabIndex = 4
        Me.NewIncidentButton.Text = "New Incident"
        Me.NewIncidentButton.UseVisualStyleBackColor = False
        '
        'ColorDialog1
        '
        Me.ColorDialog1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'NightModeCheckBox
        '
        Me.NightModeCheckBox.AutoSize = True
        Me.NightModeCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NightModeCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.NightModeCheckBox.Location = New System.Drawing.Point(0, 540)
        Me.NightModeCheckBox.Name = "NightModeCheckBox"
        Me.NightModeCheckBox.Size = New System.Drawing.Size(854, 17)
        Me.NightModeCheckBox.TabIndex = 5
        Me.NightModeCheckBox.Text = "Night Mode"
        Me.NightModeCheckBox.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(854, 577)
        Me.Controls.Add(Me.NightModeCheckBox)
        Me.Controls.Add(Me.NewIncidentButton)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.CurrentDateLabel)
        Me.Controls.Add(Me.CurrentTimeLabel)
        Me.Controls.Add(Me.DisplayTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(870, 616)
        Me.Name = "MainForm"
        Me.Text = "Timestamper"
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
    Friend WithEvents NightModeCheckBox As System.Windows.Forms.CheckBox

End Class
