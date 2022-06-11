<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInputForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInputForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserInputTextBox = New System.Windows.Forms.TextBox()
        Me.UserInputGoButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NEW ACTIVE INCIDENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UserInputTextBox
        '
        Me.UserInputTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UserInputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInputTextBox.Location = New System.Drawing.Point(13, 52)
        Me.UserInputTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserInputTextBox.MaxLength = 250
        Me.UserInputTextBox.Multiline = True
        Me.UserInputTextBox.Name = "UserInputTextBox"
        Me.UserInputTextBox.Size = New System.Drawing.Size(686, 82)
        Me.UserInputTextBox.TabIndex = 0
        '
        'UserInputGoButton
        '
        Me.UserInputGoButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UserInputGoButton.Enabled = False
        Me.UserInputGoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.UserInputGoButton.Location = New System.Drawing.Point(0, 186)
        Me.UserInputGoButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserInputGoButton.Name = "UserInputGoButton"
        Me.UserInputGoButton.Size = New System.Drawing.Size(712, 78)
        Me.UserInputGoButton.TabIndex = 1
        Me.UserInputGoButton.Text = "SUBMIT"
        Me.UserInputGoButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(445, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Illegal characters: #%&{}\<>*?/$!:@+=`|"
        '
        'UserInputForm
        '
        Me.AcceptButton = Me.UserInputGoButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(712, 264)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserInputGoButton)
        Me.Controls.Add(Me.UserInputTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserInputForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timestamper | Incident Name"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserInputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserInputGoButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
