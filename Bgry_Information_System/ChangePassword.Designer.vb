<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OldPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.NewPassLabel = New System.Windows.Forms.Label()
        Me.OldPassLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValidateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.OldUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.OldUserLabel = New System.Windows.Forms.Label()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.NewUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.NewUserLabel = New System.Windows.Forms.Label()
        Me.ConfirmNewPassTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmNewLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(225, 137)
        Me.NewPasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPasswordTextBox.ReadOnly = True
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(162, 20)
        Me.NewPasswordTextBox.TabIndex = 15
        Me.NewPasswordTextBox.Visible = False
        '
        'OldPasswordTextBox
        '
        Me.OldPasswordTextBox.Location = New System.Drawing.Point(225, 137)
        Me.OldPasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.OldPasswordTextBox.Name = "OldPasswordTextBox"
        Me.OldPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.OldPasswordTextBox.Size = New System.Drawing.Size(162, 20)
        Me.OldPasswordTextBox.TabIndex = 14
        '
        'NewPassLabel
        '
        Me.NewPassLabel.AutoSize = True
        Me.NewPassLabel.BackColor = System.Drawing.Color.Transparent
        Me.NewPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPassLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NewPassLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewPassLabel.Location = New System.Drawing.Point(52, 135)
        Me.NewPassLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NewPassLabel.Name = "NewPassLabel"
        Me.NewPassLabel.Size = New System.Drawing.Size(117, 20)
        Me.NewPassLabel.TabIndex = 13
        Me.NewPassLabel.Text = "New Password:"
        Me.NewPassLabel.Visible = False
        '
        'OldPassLabel
        '
        Me.OldPassLabel.AutoSize = True
        Me.OldPassLabel.BackColor = System.Drawing.Color.Transparent
        Me.OldPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldPassLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OldPassLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OldPassLabel.Location = New System.Drawing.Point(52, 137)
        Me.OldPassLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OldPassLabel.Name = "OldPassLabel"
        Me.OldPassLabel.Size = New System.Drawing.Size(110, 20)
        Me.OldPassLabel.TabIndex = 12
        Me.OldPassLabel.Text = "Old Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(166, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Change Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(63, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Barangay Sabang Information System"
        '
        'ValidateButton
        '
        Me.ValidateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ValidateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ValidateButton.Image = CType(resources.GetObject("ValidateButton.Image"), System.Drawing.Image)
        Me.ValidateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ValidateButton.Location = New System.Drawing.Point(96, 191)
        Me.ValidateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ValidateButton.Name = "ValidateButton"
        Me.ValidateButton.Size = New System.Drawing.Size(114, 34)
        Me.ValidateButton.TabIndex = 16
        Me.ValidateButton.Text = "Validate"
        Me.ValidateButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClearButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_eraser_30
        Me.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearButton.Location = New System.Drawing.Point(215, 191)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(119, 34)
        Me.ClearButton.TabIndex = 17
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'OldUsernameTextBox
        '
        Me.OldUsernameTextBox.Location = New System.Drawing.Point(225, 115)
        Me.OldUsernameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.OldUsernameTextBox.Name = "OldUsernameTextBox"
        Me.OldUsernameTextBox.Size = New System.Drawing.Size(162, 20)
        Me.OldUsernameTextBox.TabIndex = 19
        '
        'OldUserLabel
        '
        Me.OldUserLabel.AutoSize = True
        Me.OldUserLabel.BackColor = System.Drawing.Color.Transparent
        Me.OldUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldUserLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OldUserLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OldUserLabel.Location = New System.Drawing.Point(52, 115)
        Me.OldUserLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OldUserLabel.Name = "OldUserLabel"
        Me.OldUserLabel.Size = New System.Drawing.Size(115, 20)
        Me.OldUserLabel.TabIndex = 18
        Me.OldUserLabel.Text = "Old Username:"
        '
        'ChangeButton
        '
        Me.ChangeButton.BackColor = System.Drawing.Color.Azure
        Me.ChangeButton.Image = CType(resources.GetObject("ChangeButton.Image"), System.Drawing.Image)
        Me.ChangeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChangeButton.Location = New System.Drawing.Point(96, 191)
        Me.ChangeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(114, 34)
        Me.ChangeButton.TabIndex = 20
        Me.ChangeButton.Text = "Confirm"
        Me.ChangeButton.UseVisualStyleBackColor = False
        '
        'NewUsernameTextBox
        '
        Me.NewUsernameTextBox.Location = New System.Drawing.Point(225, 115)
        Me.NewUsernameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NewUsernameTextBox.Name = "NewUsernameTextBox"
        Me.NewUsernameTextBox.ReadOnly = True
        Me.NewUsernameTextBox.Size = New System.Drawing.Size(162, 20)
        Me.NewUsernameTextBox.TabIndex = 22
        Me.NewUsernameTextBox.Visible = False
        '
        'NewUserLabel
        '
        Me.NewUserLabel.AutoSize = True
        Me.NewUserLabel.BackColor = System.Drawing.Color.Transparent
        Me.NewUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewUserLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NewUserLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewUserLabel.Location = New System.Drawing.Point(47, 115)
        Me.NewUserLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NewUserLabel.Name = "NewUserLabel"
        Me.NewUserLabel.Size = New System.Drawing.Size(122, 20)
        Me.NewUserLabel.TabIndex = 21
        Me.NewUserLabel.Text = "New Username:"
        Me.NewUserLabel.Visible = False
        '
        'ConfirmNewPassTextBox
        '
        Me.ConfirmNewPassTextBox.Location = New System.Drawing.Point(225, 160)
        Me.ConfirmNewPassTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ConfirmNewPassTextBox.Name = "ConfirmNewPassTextBox"
        Me.ConfirmNewPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmNewPassTextBox.Size = New System.Drawing.Size(162, 20)
        Me.ConfirmNewPassTextBox.TabIndex = 25
        Me.ConfirmNewPassTextBox.Visible = False
        '
        'ConfirmNewLabel
        '
        Me.ConfirmNewLabel.AutoSize = True
        Me.ConfirmNewLabel.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmNewLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmNewLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ConfirmNewLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ConfirmNewLabel.Location = New System.Drawing.Point(47, 158)
        Me.ConfirmNewLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ConfirmNewLabel.Name = "ConfirmNewLabel"
        Me.ConfirmNewLabel.Size = New System.Drawing.Size(176, 20)
        Me.ConfirmNewLabel.TabIndex = 24
        Me.ConfirmNewLabel.Text = "Confirm New Password:"
        Me.ConfirmNewLabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bgry_Information_System.My.Resources.Resources.icon_back_80
        Me.PictureBox1.Location = New System.Drawing.Point(28, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.Bgry_Information_System.My.Resources.Resources.bg5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 245)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ConfirmNewPassTextBox)
        Me.Controls.Add(Me.ConfirmNewLabel)
        Me.Controls.Add(Me.OldUsernameTextBox)
        Me.Controls.Add(Me.OldUserLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.OldPasswordTextBox)
        Me.Controls.Add(Me.OldPassLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NewPasswordTextBox)
        Me.Controls.Add(Me.NewPassLabel)
        Me.Controls.Add(Me.NewUserLabel)
        Me.Controls.Add(Me.NewUsernameTextBox)
        Me.Controls.Add(Me.ValidateButton)
        Me.Controls.Add(Me.ChangeButton)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewPasswordTextBox As TextBox
    Friend WithEvents OldPasswordTextBox As TextBox
    Friend WithEvents NewPassLabel As Label
    Friend WithEvents OldPassLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ValidateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents OldUsernameTextBox As TextBox
    Friend WithEvents OldUserLabel As Label
    Friend WithEvents ChangeButton As Button
    Friend WithEvents NewUsernameTextBox As TextBox
    Friend WithEvents NewUserLabel As Label
    Friend WithEvents ConfirmNewPassTextBox As TextBox
    Friend WithEvents ConfirmNewLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
