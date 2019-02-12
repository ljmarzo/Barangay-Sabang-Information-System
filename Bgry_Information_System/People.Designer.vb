<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class People
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(People))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.overalltable = New System.Windows.Forms.TableLayoutPanel()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CriminalRecordTextBox = New System.Windows.Forms.TextBox()
        Me.VoterTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PreviewPictureBox = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.logTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.BirthplaceTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.PeopleDataGridView = New System.Windows.Forms.DataGridView()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TopTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.overalltable.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip2.SuspendLayout()
        Me.TopTablePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.overalltable.Controls.Add(Me.UserTextBox, 0, 1)
        Me.overalltable.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.overalltable.Controls.Add(Me.StatusStrip2, 1, 2)
        Me.overalltable.Controls.Add(Me.TopTablePanel, 1, 0)
        Me.overalltable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.overalltable.Location = New System.Drawing.Point(0, 0)
        Me.overalltable.Name = "overalltable"
        Me.overalltable.RowCount = 3
        Me.overalltable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.overalltable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.overalltable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.overalltable.Size = New System.Drawing.Size(1424, 771)
        Me.overalltable.TabIndex = 56
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(3, 153)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.ReadOnly = True
        Me.UserTextBox.Size = New System.Drawing.Size(4, 20)
        Me.UserTextBox.TabIndex = 17
        Me.UserTextBox.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PeopleDataGridView, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(20, 150)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1384, 586)
        Me.TableLayoutPanel2.TabIndex = 57
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(824, 50)
        Me.TableLayoutPanel3.TabIndex = 11
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_search_30__1_
        Me.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchButton.Location = New System.Drawing.Point(577, 3)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(194, 44)
        Me.SearchButton.TabIndex = 57
        Me.SearchButton.Text = "SEARCH"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!)
        Me.SearchTextBox.Location = New System.Drawing.Point(203, 14)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(368, 33)
        Me.SearchTextBox.TabIndex = 12
        '
        'SearchComboBox
        '
        Me.SearchComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SearchComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchComboBox.FormattingEnabled = True
        Me.SearchComboBox.Items.AddRange(New Object() {"Surname", "First Name"})
        Me.SearchComboBox.Location = New System.Drawing.Point(3, 14)
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.Size = New System.Drawing.Size(194, 33)
        Me.SearchComboBox.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.Image = Global.Bgry_Information_System.My.Resources.Resources.icons8_available_updates_50
        Me.PictureBox2.Location = New System.Drawing.Point(777, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Padding = New System.Windows.Forms.Padding(3)
        Me.PictureBox2.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 59
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(837, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(544, 31)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "PREVIEW"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel1, 0, 3)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(834, 50)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(550, 536)
        Me.TableLayoutPanel4.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "PERSONAL INFORMATION"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox5, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.PreviewPictureBox, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(550, 200)
        Me.TableLayoutPanel5.TabIndex = 7
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CriminalRecordTextBox)
        Me.GroupBox5.Controls.Add(Me.VoterTextBox)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(203, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(344, 194)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "OTHER INFORMATION"
        '
        'CriminalRecordTextBox
        '
        Me.CriminalRecordTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CriminalRecordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CriminalRecordTextBox.Location = New System.Drawing.Point(3, 71)
        Me.CriminalRecordTextBox.Multiline = True
        Me.CriminalRecordTextBox.Name = "CriminalRecordTextBox"
        Me.CriminalRecordTextBox.ReadOnly = True
        Me.CriminalRecordTextBox.Size = New System.Drawing.Size(338, 120)
        Me.CriminalRecordTextBox.TabIndex = 8
        '
        'VoterTextBox
        '
        Me.VoterTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoterTextBox.Location = New System.Drawing.Point(76, 16)
        Me.VoterTextBox.Name = "VoterTextBox"
        Me.VoterTextBox.ReadOnly = True
        Me.VoterTextBox.Size = New System.Drawing.Size(152, 26)
        Me.VoterTextBox.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "CRIMINAL RECORD:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(2, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 20)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "VOTER:"
        '
        'PreviewPictureBox
        '
        Me.PreviewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PreviewPictureBox.Image = Global.Bgry_Information_System.My.Resources.Resources.Unknown_DP_Icon
        Me.PreviewPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PreviewPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.PreviewPictureBox.Name = "PreviewPictureBox"
        Me.PreviewPictureBox.Size = New System.Drawing.Size(200, 200)
        Me.PreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PreviewPictureBox.TabIndex = 6
        Me.PreviewPictureBox.TabStop = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.logTextBox, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.IdTextBox, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.NameTextBox, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.AgeTextBox, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.BirthplaceTextBox, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.AddressTextBox, 1, 3)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 220)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 5
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(550, 200)
        Me.TableLayoutPanel6.TabIndex = 8
        '
        'logTextBox
        '
        Me.logTextBox.Location = New System.Drawing.Point(3, 163)
        Me.logTextBox.Name = "logTextBox"
        Me.logTextBox.ReadOnly = True
        Me.logTextBox.Size = New System.Drawing.Size(16, 20)
        Me.logTextBox.TabIndex = 63
        Me.logTextBox.Visible = False
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(253, 163)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(12, 20)
        Me.IdTextBox.TabIndex = 8
        Me.IdTextBox.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AGE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ADDRESS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "BIRTHPLACE:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(253, 3)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(294, 32)
        Me.NameTextBox.TabIndex = 9
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(253, 43)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.ReadOnly = True
        Me.AgeTextBox.Size = New System.Drawing.Size(294, 32)
        Me.AgeTextBox.TabIndex = 10
        '
        'BirthplaceTextBox
        '
        Me.BirthplaceTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BirthplaceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthplaceTextBox.Location = New System.Drawing.Point(253, 83)
        Me.BirthplaceTextBox.Name = "BirthplaceTextBox"
        Me.BirthplaceTextBox.ReadOnly = True
        Me.BirthplaceTextBox.Size = New System.Drawing.Size(294, 32)
        Me.BirthplaceTextBox.TabIndex = 11
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(253, 123)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.Size = New System.Drawing.Size(294, 32)
        Me.AddressTextBox.TabIndex = 12
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.DeleteButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EditButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CreateButton, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 420)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(550, 100)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(369, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(178, 94)
        Me.DeleteButton.TabIndex = 17
        Me.DeleteButton.Text = "DELETE"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EditButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Image = CType(resources.GetObject("EditButton.Image"), System.Drawing.Image)
        Me.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditButton.Location = New System.Drawing.Point(186, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(177, 94)
        Me.EditButton.TabIndex = 16
        Me.EditButton.Text = "EDIT"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CreateButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateButton.Image = CType(resources.GetObject("CreateButton.Image"), System.Drawing.Image)
        Me.CreateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreateButton.Location = New System.Drawing.Point(3, 3)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(177, 94)
        Me.CreateButton.TabIndex = 15
        Me.CreateButton.Text = "CREATE NEW"
        Me.CreateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'PeopleDataGridView
        '
        Me.PeopleDataGridView.AllowUserToAddRows = False
        Me.PeopleDataGridView.AllowUserToDeleteRows = False
        Me.PeopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PeopleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeopleDataGridView.Location = New System.Drawing.Point(0, 50)
        Me.PeopleDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.PeopleDataGridView.Name = "PeopleDataGridView"
        Me.PeopleDataGridView.ReadOnly = True
        Me.PeopleDataGridView.RowTemplate.Height = 24
        Me.PeopleDataGridView.Size = New System.Drawing.Size(824, 536)
        Me.PeopleDataGridView.TabIndex = 10
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
        'TopTablePanel
        '
        Me.TopTablePanel.ColumnCount = 2
        Me.TopTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TopTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TopTablePanel.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TopTablePanel.Controls.Add(Me.Panel1, 1, 0)
        Me.TopTablePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopTablePanel.Location = New System.Drawing.Point(20, 0)
        Me.TopTablePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.TopTablePanel.Name = "TopTablePanel"
        Me.TopTablePanel.RowCount = 1
        Me.TopTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TopTablePanel.Size = New System.Drawing.Size(1384, 150)
        Me.TopTablePanel.TabIndex = 58
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(170, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1214, 150)
        Me.Panel1.TabIndex = 1
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
        'People
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1424, 771)
        Me.Controls.Add(Me.overalltable)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "People"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "People"
        Me.overalltable.ResumeLayout(False)
        Me.overalltable.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.TopTablePanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EditButton As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchComboBox As ComboBox
    Friend WithEvents PeopleDataGridView As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents CriminalRecordTextBox As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents VoterTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PreviewPictureBox As PictureBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents BirthplaceTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DeleteButton As Button
    Friend WithEvents CreateButton As Button
    Friend WithEvents ToolStripStatusDate As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusTime As ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusUser As ToolStripStatusLabel
    Friend WithEvents overalltable As TableLayoutPanel
    Friend WithEvents TopTablePanel As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents logTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
End Class
