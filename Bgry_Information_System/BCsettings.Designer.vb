<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCsettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BCsettings))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DataOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataWithPicturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.overalltable = New System.Windows.Forms.TableLayoutPanel()
        Me.logTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.IdPurpose = New System.Windows.Forms.TextBox()
        Me.PurposeTextBox = New System.Windows.Forms.TextBox()
        Me.PurposeDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.LogsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.TopTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.overalltable.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PurposeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TopTablePanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataOnlyToolStripMenuItem, Me.DataWithPicturesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(306, 56)
        '
        'DataOnlyToolStripMenuItem
        '
        Me.DataOnlyToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue
        Me.DataOnlyToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DataOnlyToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DataOnlyToolStripMenuItem.Name = "DataOnlyToolStripMenuItem"
        Me.DataOnlyToolStripMenuItem.Size = New System.Drawing.Size(305, 26)
        Me.DataOnlyToolStripMenuItem.Text = "People Record Data Only"
        '
        'DataWithPicturesToolStripMenuItem
        '
        Me.DataWithPicturesToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue
        Me.DataWithPicturesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DataWithPicturesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DataWithPicturesToolStripMenuItem.Name = "DataWithPicturesToolStripMenuItem"
        Me.DataWithPicturesToolStripMenuItem.Size = New System.Drawing.Size(305, 26)
        Me.DataWithPicturesToolStripMenuItem.Text = "People Record Data with Pictures"
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
        Me.overalltable.Controls.Add(Me.logTextBox, 0, 2)
        Me.overalltable.Controls.Add(Me.StatusStrip2, 1, 2)
        Me.overalltable.Controls.Add(Me.TableLayoutPanel1, 1, 1)
        Me.overalltable.Controls.Add(Me.TopTablePanel, 1, 0)
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
        'logTextBox
        '
        Me.logTextBox.Location = New System.Drawing.Point(3, 739)
        Me.logTextBox.Name = "logTextBox"
        Me.logTextBox.ReadOnly = True
        Me.logTextBox.Size = New System.Drawing.Size(14, 20)
        Me.logTextBox.TabIndex = 66
        Me.logTextBox.Visible = False
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
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.UserTextBox, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 150)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.64311!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.35689!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1384, 586)
        Me.TableLayoutPanel1.TabIndex = 57
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(3, 570)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.ReadOnly = True
        Me.UserTextBox.Size = New System.Drawing.Size(17, 20)
        Me.UserTextBox.TabIndex = 16
        Me.UserTextBox.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.IdPurpose, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.PurposeTextBox, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.PurposeDataGridView, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 20)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(415, 547)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'IdPurpose
        '
        Me.IdPurpose.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.IdPurpose.Location = New System.Drawing.Point(2, 470)
        Me.IdPurpose.Margin = New System.Windows.Forms.Padding(2)
        Me.IdPurpose.Multiline = True
        Me.IdPurpose.Name = "IdPurpose"
        Me.IdPurpose.Size = New System.Drawing.Size(17, 16)
        Me.IdPurpose.TabIndex = 18
        Me.IdPurpose.Visible = False
        '
        'PurposeTextBox
        '
        Me.PurposeTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PurposeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurposeTextBox.Location = New System.Drawing.Point(2, 344)
        Me.PurposeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PurposeTextBox.Multiline = True
        Me.PurposeTextBox.Name = "PurposeTextBox"
        Me.PurposeTextBox.Size = New System.Drawing.Size(411, 42)
        Me.PurposeTextBox.TabIndex = 16
        '
        'PurposeDataGridView
        '
        Me.PurposeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurposeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PurposeDataGridView.Location = New System.Drawing.Point(2, 32)
        Me.PurposeDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.PurposeDataGridView.Name = "PurposeDataGridView"
        Me.PurposeDataGridView.RowTemplate.Height = 24
        Me.PurposeDataGridView.Size = New System.Drawing.Size(411, 308)
        Me.PurposeDataGridView.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISSUED FOR THE PURPOSE OF"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 388)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(415, 80)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_delete_50
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(209, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 76)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "REMOVE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_plus_50
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(2, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 76)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.LogsDataGridView, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(415, 20)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(969, 547)
        Me.TableLayoutPanel4.TabIndex = 17
        '
        'LogsDataGridView
        '
        Me.LogsDataGridView.AllowUserToAddRows = False
        Me.LogsDataGridView.AllowUserToDeleteRows = False
        Me.LogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LogsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogsDataGridView.Location = New System.Drawing.Point(2, 32)
        Me.LogsDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.LogsDataGridView.Name = "LogsDataGridView"
        Me.LogsDataGridView.ReadOnly = True
        Me.LogsDataGridView.RowTemplate.Height = 24
        Me.LogsDataGridView.Size = New System.Drawing.Size(965, 413)
        Me.LogsDataGridView.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "LOGS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ExportButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 447)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(969, 100)
        Me.Panel2.TabIndex = 65
        '
        'ExportButton
        '
        Me.ExportButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ExportButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_database_export_50
        Me.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExportButton.Location = New System.Drawing.Point(794, 11)
        Me.ExportButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(175, 76)
        Me.ExportButton.TabIndex = 5
        Me.ExportButton.Text = "Export Data"
        Me.ExportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExportButton.UseVisualStyleBackColor = False
        '
        'TopTablePanel
        '
        Me.TopTablePanel.ColumnCount = 2
        Me.TopTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TopTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TopTablePanel.Controls.Add(Me.Panel1, 0, 0)
        Me.TopTablePanel.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TopTablePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopTablePanel.Location = New System.Drawing.Point(20, 0)
        Me.TopTablePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.TopTablePanel.Name = "TopTablePanel"
        Me.TopTablePanel.RowCount = 1
        Me.TopTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TopTablePanel.Size = New System.Drawing.Size(1384, 150)
        Me.TopTablePanel.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(170, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1214, 150)
        Me.Panel1.TabIndex = 2
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
        'BCsettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.overalltable)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BCsettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.overalltable.ResumeLayout(False)
        Me.overalltable.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PurposeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TopTablePanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TopTablePanel As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PurposeDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents overalltable As TableLayoutPanel
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusDate As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusTime As ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents IdPurpose As TextBox
    Friend WithEvents PurposeTextBox As TextBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents logTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents LogsDataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ExportButton As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DataOnlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataWithPicturesToolStripMenuItem As ToolStripMenuItem
End Class
