<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.overalltable = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.logTextBox = New System.Windows.Forms.TextBox()
        Me.PeopleButton = New System.Windows.Forms.Button()
        Me.TransactionButton = New System.Windows.Forms.Button()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BarangayClearanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndigencyFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BarangayClearanceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificateOfIndigencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.overalltable.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'overalltable
        '
        Me.overalltable.BackColor = System.Drawing.Color.Transparent
        Me.overalltable.BackgroundImage = CType(resources.GetObject("overalltable.BackgroundImage"), System.Drawing.Image)
        Me.overalltable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.overalltable.ColumnCount = 3
        Me.overalltable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.overalltable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.overalltable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.overalltable.Controls.Add(Me.StatusStrip2, 1, 2)
        Me.overalltable.Controls.Add(Me.TableLayoutPanel1, 1, 1)
        Me.overalltable.Controls.Add(Me.Panel1, 1, 0)
        Me.overalltable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.overalltable.Location = New System.Drawing.Point(0, 0)
        Me.overalltable.Name = "overalltable"
        Me.overalltable.RowCount = 3
        Me.overalltable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.overalltable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.overalltable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.overalltable.Size = New System.Drawing.Size(1424, 771)
        Me.overalltable.TabIndex = 58
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StatusStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusUser, Me.ToolStripStatusDate, Me.ToolStripStatusTime})
        Me.StatusStrip2.Location = New System.Drawing.Point(20, 745)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1384, 26)
        Me.StatusStrip2.TabIndex = 56
        Me.StatusStrip2.Text = "StatusStrip1"
        '
        'ToolStripStatusUser
        '
        Me.ToolStripStatusUser.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusUser.Name = "ToolStripStatusUser"
        Me.ToolStripStatusUser.Size = New System.Drawing.Size(45, 21)
        Me.ToolStripStatusUser.Text = "User:"
        Me.ToolStripStatusUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusDate
        '
        Me.ToolStripStatusDate.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusDate.Name = "ToolStripStatusDate"
        Me.ToolStripStatusDate.Size = New System.Drawing.Size(45, 21)
        Me.ToolStripStatusDate.Text = "Date:"
        '
        'ToolStripStatusTime
        '
        Me.ToolStripStatusTime.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusTime.Name = "ToolStripStatusTime"
        Me.ToolStripStatusTime.Size = New System.Drawing.Size(47, 21)
        Me.ToolStripStatusTime.Text = "Time:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.logTextBox, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.PeopleButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TransactionButton, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SettingsButton, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LogoutButton, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.UserTextBox, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 153)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1378, 580)
        Me.TableLayoutPanel1.TabIndex = 57
        '
        'logTextBox
        '
        Me.logTextBox.Location = New System.Drawing.Point(3, 543)
        Me.logTextBox.Name = "logTextBox"
        Me.logTextBox.ReadOnly = True
        Me.logTextBox.Size = New System.Drawing.Size(16, 20)
        Me.logTextBox.TabIndex = 64
        Me.logTextBox.Visible = False
        '
        'PeopleButton
        '
        Me.PeopleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PeopleButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeopleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PeopleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeopleButton.ForeColor = System.Drawing.Color.Black
        Me.PeopleButton.Image = CType(resources.GetObject("PeopleButton.Image"), System.Drawing.Image)
        Me.PeopleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PeopleButton.Location = New System.Drawing.Point(461, 42)
        Me.PeopleButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PeopleButton.Name = "PeopleButton"
        Me.PeopleButton.Size = New System.Drawing.Size(455, 96)
        Me.PeopleButton.TabIndex = 2
        Me.PeopleButton.Text = "PEOPLE"
        Me.PeopleButton.UseVisualStyleBackColor = False
        '
        'TransactionButton
        '
        Me.TransactionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TransactionButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TransactionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionButton.ForeColor = System.Drawing.Color.Black
        Me.TransactionButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_documents_80
        Me.TransactionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionButton.Location = New System.Drawing.Point(461, 142)
        Me.TransactionButton.Margin = New System.Windows.Forms.Padding(2)
        Me.TransactionButton.Name = "TransactionButton"
        Me.TransactionButton.Size = New System.Drawing.Size(455, 96)
        Me.TransactionButton.TabIndex = 3
        Me.TransactionButton.Text = "TRANSACTION"
        Me.TransactionButton.UseVisualStyleBackColor = False
        '
        'SettingsButton
        '
        Me.SettingsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsButton.ForeColor = System.Drawing.Color.Black
        Me.SettingsButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_services_80
        Me.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingsButton.Location = New System.Drawing.Point(461, 242)
        Me.SettingsButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(455, 96)
        Me.SettingsButton.TabIndex = 4
        Me.SettingsButton.Text = "SETTINGS"
        Me.SettingsButton.UseVisualStyleBackColor = False
        '
        'LogoutButton
        '
        Me.LogoutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LogoutButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.ForeColor = System.Drawing.Color.Black
        Me.LogoutButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_exit_80
        Me.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutButton.Location = New System.Drawing.Point(461, 342)
        Me.LogoutButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(455, 96)
        Me.LogoutButton.TabIndex = 8
        Me.LogoutButton.Text = "LOGOUT"
        Me.LogoutButton.UseVisualStyleBackColor = False
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(3, 343)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.ReadOnly = True
        Me.UserTextBox.Size = New System.Drawing.Size(17, 20)
        Me.UserTextBox.TabIndex = 9
        Me.UserTextBox.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(20, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1384, 150)
        Me.Panel1.TabIndex = 58
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.Bgry_Information_System.My.Resources.Resources.header1
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1384, 150)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'BarangayClearanceToolStripMenuItem
        '
        Me.BarangayClearanceToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BarangayClearanceToolStripMenuItem.Name = "BarangayClearanceToolStripMenuItem"
        Me.BarangayClearanceToolStripMenuItem.Size = New System.Drawing.Size(277, 34)
        Me.BarangayClearanceToolStripMenuItem.Text = "Barangay Clearance"
        '
        'IndigencyFormToolStripMenuItem
        '
        Me.IndigencyFormToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.IndigencyFormToolStripMenuItem.Name = "IndigencyFormToolStripMenuItem"
        Me.IndigencyFormToolStripMenuItem.Size = New System.Drawing.Size(277, 34)
        Me.IndigencyFormToolStripMenuItem.Text = "Indigency Form"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangayClearanceToolStripMenuItem, Me.IndigencyFormToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(278, 72)
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangayClearanceToolStripMenuItem1, Me.CertificateOfIndigencyToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(327, 72)
        '
        'BarangayClearanceToolStripMenuItem1
        '
        Me.BarangayClearanceToolStripMenuItem1.BackColor = System.Drawing.Color.SteelBlue
        Me.BarangayClearanceToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.BarangayClearanceToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.BarangayClearanceToolStripMenuItem1.Name = "BarangayClearanceToolStripMenuItem1"
        Me.BarangayClearanceToolStripMenuItem1.Size = New System.Drawing.Size(326, 34)
        Me.BarangayClearanceToolStripMenuItem1.Text = "Barangay Clearance"
        '
        'CertificateOfIndigencyToolStripMenuItem
        '
        Me.CertificateOfIndigencyToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue
        Me.CertificateOfIndigencyToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.CertificateOfIndigencyToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CertificateOfIndigencyToolStripMenuItem.Name = "CertificateOfIndigencyToolStripMenuItem"
        Me.CertificateOfIndigencyToolStripMenuItem.Size = New System.Drawing.Size(326, 34)
        Me.CertificateOfIndigencyToolStripMenuItem.Text = "Barangay Working Permit"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.overalltable)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay Sabang Information System"
        Me.overalltable.ResumeLayout(False)
        Me.overalltable.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TransactionButton As Button
    Friend WithEvents overalltable As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PeopleButton As Button
    Friend WithEvents SettingsButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusDate As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusTime As ToolStripStatusLabel
    Friend WithEvents logTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BarangayClearanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndigencyFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents BarangayClearanceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CertificateOfIndigencyToolStripMenuItem As ToolStripMenuItem
End Class
