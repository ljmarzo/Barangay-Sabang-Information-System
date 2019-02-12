<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BrgyClearance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrgyClearance))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStripStatusTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.PurposeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TopTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PeopleDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PreviewButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchComboBox = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.overalltable = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.logTextBox = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TopTablePanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.overalltable.SuspendLayout()
        Me.SuspendLayout()
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
        'ToolStripStatusTime
        '
        Me.ToolStripStatusTime.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusTime.Name = "ToolStripStatusTime"
        Me.ToolStripStatusTime.Size = New System.Drawing.Size(47, 21)
        Me.ToolStripStatusTime.Text = "Time:"
        '
        'ToolStripStatusDate
        '
        Me.ToolStripStatusDate.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusDate.Name = "ToolStripStatusDate"
        Me.ToolStripStatusDate.Size = New System.Drawing.Size(45, 21)
        Me.ToolStripStatusDate.Text = "Date:"
        '
        'ToolStripStatusUser
        '
        Me.ToolStripStatusUser.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusUser.Name = "ToolStripStatusUser"
        Me.ToolStripStatusUser.Size = New System.Drawing.Size(45, 21)
        Me.ToolStripStatusUser.Text = "User:"
        Me.ToolStripStatusUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StatusStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusUser, Me.ToolStripStatusDate, Me.ToolStripStatusTime})
        Me.StatusStrip2.Location = New System.Drawing.Point(20, 741)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1380, 26)
        Me.StatusStrip2.TabIndex = 56
        Me.StatusStrip2.Text = "StatusStrip1"
        '
        'PurposeComboBox
        '
        Me.PurposeComboBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PurposeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurposeComboBox.FormattingEnabled = True
        Me.PurposeComboBox.Location = New System.Drawing.Point(0, 21)
        Me.PurposeComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PurposeComboBox.Name = "PurposeComboBox"
        Me.PurposeComboBox.Size = New System.Drawing.Size(422, 33)
        Me.PurposeComboBox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-1, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ISSUED FOR THE PURPOSE FOR:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PurposeComboBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 54)
        Me.Panel1.TabIndex = 40
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
        Me.TopTablePanel.Size = New System.Drawing.Size(1380, 150)
        Me.TopTablePanel.TabIndex = 58
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(170, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1210, 150)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.Bgry_Information_System.My.Resources.Resources.header1
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1210, 150)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PeopleDataGridView
        '
        Me.PeopleDataGridView.AllowUserToAddRows = False
        Me.PeopleDataGridView.AllowUserToDeleteRows = False
        Me.PeopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PeopleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeopleDataGridView.Location = New System.Drawing.Point(2, 2)
        Me.PeopleDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.PeopleDataGridView.Name = "PeopleDataGridView"
        Me.PeopleDataGridView.ReadOnly = True
        Me.PeopleDataGridView.RowTemplate.Height = 24
        Me.PeopleDataGridView.Size = New System.Drawing.Size(818, 468)
        Me.PeopleDataGridView.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(835, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(542, 31)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "PREVIEW"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PreviewButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PrintButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 472)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(822, 60)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'PreviewButton
        '
        Me.PreviewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PreviewButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PreviewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviewButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_preview_pane_301
        Me.PreviewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PreviewButton.Location = New System.Drawing.Point(424, 2)
        Me.PreviewButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PreviewButton.Name = "PreviewButton"
        Me.PreviewButton.Size = New System.Drawing.Size(196, 50)
        Me.PreviewButton.TabIndex = 38
        Me.PreviewButton.Text = "PREVIEW"
        Me.PreviewButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PrintButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_print_30
        Me.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintButton.Location = New System.Drawing.Point(624, 2)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(196, 50)
        Me.PrintButton.TabIndex = 39
        Me.PrintButton.Text = "PRINT"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_search_30__1_
        Me.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchButton.Location = New System.Drawing.Point(575, 3)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(194, 44)
        Me.SearchButton.TabIndex = 57
        Me.SearchButton.Text = "SEARCH"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!)
        Me.SearchTextBox.Location = New System.Drawing.Point(203, 3)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(366, 33)
        Me.SearchTextBox.TabIndex = 12
        '
        'SearchComboBox
        '
        Me.SearchComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchComboBox.FormattingEnabled = True
        Me.SearchComboBox.Items.AddRange(New Object() {"Surname", "First Name"})
        Me.SearchComboBox.Location = New System.Drawing.Point(3, 3)
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.Size = New System.Drawing.Size(194, 33)
        Me.SearchComboBox.TabIndex = 11
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.SearchButton, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.SearchTextBox, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.SearchComboBox, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox2, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(822, 50)
        Me.TableLayoutPanel3.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_available_updates_50
        Me.PictureBox2.Location = New System.Drawing.Point(775, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Padding = New System.Windows.Forms.Padding(3)
        Me.PictureBox2.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.UserTextBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CrystalReportViewer1, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(20, 150)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1380, 582)
        Me.TableLayoutPanel2.TabIndex = 57
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(825, 53)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.ReadOnly = True
        Me.UserTextBox.Size = New System.Drawing.Size(4, 20)
        Me.UserTextBox.TabIndex = 18
        Me.UserTextBox.Visible = False
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.PeopleDataGridView, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 50)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(822, 532)
        Me.TableLayoutPanel7.TabIndex = 17
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(834, 52)
        Me.CrystalReportViewer1.Margin = New System.Windows.Forms.Padding(2)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(544, 528)
        Me.CrystalReportViewer1.TabIndex = 19
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
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
        Me.overalltable.Controls.Add(Me.TextBox2, 0, 2)
        Me.overalltable.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.overalltable.Controls.Add(Me.StatusStrip2, 1, 2)
        Me.overalltable.Controls.Add(Me.TopTablePanel, 1, 0)
        Me.overalltable.Controls.Add(Me.TextBox1, 1, 2)
        Me.overalltable.Controls.Add(Me.logTextBox, 0, 1)
        Me.overalltable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.overalltable.Location = New System.Drawing.Point(0, 0)
        Me.overalltable.Name = "overalltable"
        Me.overalltable.RowCount = 3
        Me.overalltable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.overalltable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.overalltable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.overalltable.Size = New System.Drawing.Size(1420, 767)
        Me.overalltable.TabIndex = 58
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(3, 735)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(14, 20)
        Me.TextBox2.TabIndex = 67
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1403, 735)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(14, 20)
        Me.TextBox1.TabIndex = 66
        Me.TextBox1.Visible = False
        '
        'logTextBox
        '
        Me.logTextBox.Location = New System.Drawing.Point(3, 153)
        Me.logTextBox.Name = "logTextBox"
        Me.logTextBox.ReadOnly = True
        Me.logTextBox.Size = New System.Drawing.Size(14, 20)
        Me.logTextBox.TabIndex = 65
        Me.logTextBox.Visible = False
        '
        'Timer1
        '
        '
        'BrgyClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1420, 767)
        Me.Controls.Add(Me.overalltable)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BrgyClearance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay Clearance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TopTablePanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.overalltable.ResumeLayout(False)
        Me.overalltable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripStatusTime As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusDate As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusUser As ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents PurposeComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TopTablePanel As TableLayoutPanel
    Friend WithEvents PeopleDataGridView As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PreviewButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchComboBox As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents overalltable As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents logTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TextBox2 As TextBox
End Class
