<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AccountComboBox = New System.Windows.Forms.ComboBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.ChangePassButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barangay Sabang Information System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(49, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(149, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(49, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "User:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(49, 108)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password:"
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(131, 91)
        Me.UserTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.ReadOnly = True
        Me.UserTextBox.Size = New System.Drawing.Size(209, 20)
        Me.UserTextBox.TabIndex = 6
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(131, 111)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(209, 20)
        Me.PasswordTextBox.TabIndex = 7
        '
        'AccountComboBox
        '
        Me.AccountComboBox.FormattingEnabled = True
        Me.AccountComboBox.Items.AddRange(New Object() {"Guest", "Administrator"})
        Me.AccountComboBox.Location = New System.Drawing.Point(131, 71)
        Me.AccountComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AccountComboBox.Name = "AccountComboBox"
        Me.AccountComboBox.Size = New System.Drawing.Size(209, 21)
        Me.AccountComboBox.TabIndex = 8
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LoginButton.Image = CType(resources.GetObject("LoginButton.Image"), System.Drawing.Image)
        Me.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoginButton.Location = New System.Drawing.Point(47, 134)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(291, 41)
        Me.LoginButton.TabIndex = 9
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'ChangePassButton
        '
        Me.ChangePassButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ChangePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChangePassButton.Image = CType(resources.GetObject("ChangePassButton.Image"), System.Drawing.Image)
        Me.ChangePassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChangePassButton.Location = New System.Drawing.Point(47, 180)
        Me.ChangePassButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangePassButton.Name = "ChangePassButton"
        Me.ChangePassButton.Size = New System.Drawing.Size(146, 39)
        Me.ChangePassButton.TabIndex = 10
        Me.ChangePassButton.Text = "Change Password"
        Me.ChangePassButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChangePassButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClearButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_eraser_30
        Me.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearButton.Location = New System.Drawing.Point(197, 180)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(141, 39)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.Bgry_Information_System.My.Resources.Resources.bg5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(391, 239)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ChangePassButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.AccountComboBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents AccountComboBox As ComboBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents ChangePassButton As Button
    Friend WithEvents ClearButton As Button
End Class
