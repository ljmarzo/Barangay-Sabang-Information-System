<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeopleCREATE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PeopleCREATE))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.overalltable = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TopTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InsidePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.CaptureButton = New System.Windows.Forms.Button()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.logTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UnknownPic = New System.Windows.Forms.PictureBox()
        Me.ImageBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.BirthplaceTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.CriminalRecordTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.VoterRadBtn = New System.Windows.Forms.RadioButton()
        Me.NotVoterRadBtn = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.overalltable.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.TopTablePanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InsidePanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UnknownPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
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
        Me.overalltable.Controls.Add(Me.TopTablePanel, 1, 0)
        Me.overalltable.Controls.Add(Me.InsidePanel, 1, 1)
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
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusUser, Me.ToolStripStatusDate, Me.ToolStripStatusTime})
        Me.StatusStrip2.Location = New System.Drawing.Point(20, 745)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1384, 26)
        Me.StatusStrip2.TabIndex = 56
        Me.StatusStrip2.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(45, 21)
        Me.ToolStripStatusLabel1.Text = "User:"
        '
        'ToolStripStatusUser
        '
        Me.ToolStripStatusUser.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusUser.Name = "ToolStripStatusUser"
        Me.ToolStripStatusUser.Size = New System.Drawing.Size(0, 21)
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
        'TopTablePanel
        '
        Me.TopTablePanel.ColumnCount = 2
        Me.TopTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TopTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TopTablePanel.Controls.Add(Me.Panel2, 0, 0)
        Me.TopTablePanel.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TopTablePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopTablePanel.Location = New System.Drawing.Point(20, 0)
        Me.TopTablePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.TopTablePanel.Name = "TopTablePanel"
        Me.TopTablePanel.RowCount = 1
        Me.TopTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TopTablePanel.Size = New System.Drawing.Size(1384, 150)
        Me.TopTablePanel.TabIndex = 58
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(170, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1214, 150)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.Bgry_Information_System.My.Resources.Resources.header1
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1214, 150)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Bgry_Information_System.My.Resources.Resources.icon_back_801
        Me.PictureBox1.Location = New System.Drawing.Point(10, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'InsidePanel
        '
        Me.InsidePanel.ColumnCount = 3
        Me.InsidePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 458.0!))
        Me.InsidePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InsidePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InsidePanel.Controls.Add(Me.Label3, 2, 0)
        Me.InsidePanel.Controls.Add(Me.Label2, 1, 0)
        Me.InsidePanel.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.InsidePanel.Controls.Add(Me.Label1, 0, 0)
        Me.InsidePanel.Controls.Add(Me.TableLayoutPanel1, 1, 2)
        Me.InsidePanel.Controls.Add(Me.TableLayoutPanel5, 2, 2)
        Me.InsidePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InsidePanel.Location = New System.Drawing.Point(20, 150)
        Me.InsidePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.InsidePanel.Name = "InsidePanel"
        Me.InsidePanel.RowCount = 4
        Me.InsidePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.InsidePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.InsidePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 578.0!))
        Me.InsidePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InsidePanel.Size = New System.Drawing.Size(1384, 586)
        Me.InsidePanel.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(924, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "OTHER INFORMATION"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(461, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PERSONAL INFORMATION"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 32)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 255.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(458, 578)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.UserTextBox, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.IdTextBox, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.CaptureButton, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BrowseButton, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ResetButton, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.logTextBox, 1, 3)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 303)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(452, 272)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(3, 153)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.ReadOnly = True
        Me.UserTextBox.Size = New System.Drawing.Size(17, 20)
        Me.UserTextBox.TabIndex = 61
        Me.UserTextBox.Visible = False
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(342, 3)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(12, 20)
        Me.IdTextBox.TabIndex = 8
        Me.IdTextBox.Visible = False
        '
        'CaptureButton
        '
        Me.CaptureButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CaptureButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CaptureButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CaptureButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaptureButton.Image = CType(resources.GetObject("CaptureButton.Image"), System.Drawing.Image)
        Me.CaptureButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CaptureButton.Location = New System.Drawing.Point(115, 2)
        Me.CaptureButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CaptureButton.Name = "CaptureButton"
        Me.CaptureButton.Size = New System.Drawing.Size(222, 46)
        Me.CaptureButton.TabIndex = 57
        Me.CaptureButton.Text = "CAMERA"
        Me.CaptureButton.UseVisualStyleBackColor = False
        '
        'BrowseButton
        '
        Me.BrowseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BrowseButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrowseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseButton.Image = CType(resources.GetObject("BrowseButton.Image"), System.Drawing.Image)
        Me.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BrowseButton.Location = New System.Drawing.Point(115, 52)
        Me.BrowseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(222, 46)
        Me.BrowseButton.TabIndex = 59
        Me.BrowseButton.Text = "BROWSE"
        Me.BrowseButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ResetButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Image = CType(resources.GetObject("ResetButton.Image"), System.Drawing.Image)
        Me.ResetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ResetButton.Location = New System.Drawing.Point(115, 102)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(222, 46)
        Me.ResetButton.TabIndex = 58
        Me.ResetButton.Text = "RESET"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'logTextBox
        '
        Me.logTextBox.Location = New System.Drawing.Point(116, 153)
        Me.logTextBox.Name = "logTextBox"
        Me.logTextBox.ReadOnly = True
        Me.logTextBox.Size = New System.Drawing.Size(16, 20)
        Me.logTextBox.TabIndex = 62
        Me.logTextBox.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(452, 294)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UnknownPic)
        Me.Panel1.Controls.Add(Me.ImageBox1)
        Me.Panel1.Controls.Add(Me.ImageBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(76, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 300)
        Me.Panel1.TabIndex = 0
        '
        'UnknownPic
        '
        Me.UnknownPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UnknownPic.Image = Global.Bgry_Information_System.My.Resources.Resources.Unknown_DP_Icon
        Me.UnknownPic.Location = New System.Drawing.Point(0, 0)
        Me.UnknownPic.Margin = New System.Windows.Forms.Padding(2)
        Me.UnknownPic.Name = "UnknownPic"
        Me.UnknownPic.Size = New System.Drawing.Size(300, 300)
        Me.UnknownPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UnknownPic.TabIndex = 60
        Me.UnknownPic.TabStop = False
        '
        'ImageBox1
        '
        Me.ImageBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageBox1.Enabled = False
        Me.ImageBox1.Location = New System.Drawing.Point(0, 0)
        Me.ImageBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ImageBox1.Name = "ImageBox1"
        Me.ImageBox1.Size = New System.Drawing.Size(300, 300)
        Me.ImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageBox1.TabIndex = 61
        Me.ImageBox1.TabStop = False
        '
        'ImageBox
        '
        Me.ImageBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageBox.Enabled = False
        Me.ImageBox.Location = New System.Drawing.Point(0, 0)
        Me.ImageBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(300, 300)
        Me.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageBox.TabIndex = 59
        Me.ImageBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PHOTO"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(458, 32)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(463, 578)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.SurnameTextBox, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.FirstNameTextBox, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.MiddleNameTextBox, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.AgeTextBox, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.BirthplaceTextBox, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.AddressTextBox, 1, 5)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 6
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(463, 300)
        Me.TableLayoutPanel6.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 40)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "MIDDLE NAME:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "AGE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 26)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ADDRESS:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 26)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "BIRTHPLACE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 26)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "SURNAME:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 26)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "FIRST NAME:"
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SurnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameTextBox.Location = New System.Drawing.Point(165, 2)
        Me.SurnameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(296, 32)
        Me.SurnameTextBox.TabIndex = 1
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(165, 42)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(296, 32)
        Me.FirstNameTextBox.TabIndex = 2
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MiddleNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(165, 82)
        Me.MiddleNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(296, 32)
        Me.MiddleNameTextBox.TabIndex = 3
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(165, 122)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(296, 32)
        Me.AgeTextBox.TabIndex = 4
        '
        'BirthplaceTextBox
        '
        Me.BirthplaceTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BirthplaceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthplaceTextBox.Location = New System.Drawing.Point(165, 162)
        Me.BirthplaceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BirthplaceTextBox.Name = "BirthplaceTextBox"
        Me.BirthplaceTextBox.Size = New System.Drawing.Size(296, 32)
        Me.BirthplaceTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(165, 202)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(296, 96)
        Me.AddressTextBox.TabIndex = 6
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.AddButton, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.ClearButton, 2, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 300)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(463, 278)
        Me.TableLayoutPanel7.TabIndex = 11
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AddButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_add_user_male_50
        Me.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddButton.Location = New System.Drawing.Point(52, 22)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(196, 96)
        Me.AddButton.TabIndex = 10
        Me.AddButton.Text = "ADD"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_eraser_50
        Me.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearButton.Location = New System.Drawing.Point(252, 22)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(196, 96)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "CLEAR"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.CriminalRecordTextBox, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.VoterRadBtn, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.NotVoterRadBtn, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label12, 0, 3)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(924, 35)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 6
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(457, 572)
        Me.TableLayoutPanel5.TabIndex = 12
        '
        'CriminalRecordTextBox
        '
        Me.CriminalRecordTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CriminalRecordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CriminalRecordTextBox.Location = New System.Drawing.Point(30, 162)
        Me.CriminalRecordTextBox.Margin = New System.Windows.Forms.Padding(30, 2, 2, 2)
        Me.CriminalRecordTextBox.Multiline = True
        Me.CriminalRecordTextBox.Name = "CriminalRecordTextBox"
        Me.CriminalRecordTextBox.Size = New System.Drawing.Size(425, 296)
        Me.CriminalRecordTextBox.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(2, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 26)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "VOTER:"
        '
        'VoterRadBtn
        '
        Me.VoterRadBtn.AutoSize = True
        Me.VoterRadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoterRadBtn.ForeColor = System.Drawing.Color.White
        Me.VoterRadBtn.Location = New System.Drawing.Point(75, 42)
        Me.VoterRadBtn.Margin = New System.Windows.Forms.Padding(75, 2, 2, 2)
        Me.VoterRadBtn.Name = "VoterRadBtn"
        Me.VoterRadBtn.Size = New System.Drawing.Size(76, 30)
        Me.VoterRadBtn.TabIndex = 7
        Me.VoterRadBtn.TabStop = True
        Me.VoterRadBtn.Text = "YES"
        Me.VoterRadBtn.UseVisualStyleBackColor = True
        '
        'NotVoterRadBtn
        '
        Me.NotVoterRadBtn.AutoSize = True
        Me.NotVoterRadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotVoterRadBtn.ForeColor = System.Drawing.Color.White
        Me.NotVoterRadBtn.Location = New System.Drawing.Point(75, 82)
        Me.NotVoterRadBtn.Margin = New System.Windows.Forms.Padding(75, 2, 2, 2)
        Me.NotVoterRadBtn.Name = "NotVoterRadBtn"
        Me.NotVoterRadBtn.Size = New System.Drawing.Size(63, 30)
        Me.NotVoterRadBtn.TabIndex = 8
        Me.NotVoterRadBtn.TabStop = True
        Me.NotVoterRadBtn.Text = "NO"
        Me.NotVoterRadBtn.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(2, 120)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(225, 26)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "CRIMINAL RECORD:"
        '
        'Timer2
        '
        '
        'PeopleCREATE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.overalltable)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PeopleCREATE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Create People Record"
        Me.overalltable.ResumeLayout(False)
        Me.overalltable.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.TopTablePanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InsidePanel.ResumeLayout(False)
        Me.InsidePanel.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.UnknownPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents BirthplaceTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents AddButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents NotVoterRadBtn As RadioButton
    Friend WithEvents VoterRadBtn As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CriminalRecordTextBox As TextBox
    Friend WithEvents UnknownPic As PictureBox
    Friend WithEvents TopTablePanel As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents overalltable As TableLayoutPanel
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusDate As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusTime As ToolStripStatusLabel
    Friend WithEvents InsidePanel As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents CaptureButton As Button
    Friend WithEvents BrowseButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageBox1 As PictureBox
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents logTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
End Class
