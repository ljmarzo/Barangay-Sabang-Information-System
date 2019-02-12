Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports Emgu.CV
Imports Emgu.CV.UI
Imports Emgu.CV.Structure
Public Class PeopleCREATE
    Inherits System.Windows.Forms.Form
    Dim cap As New Capture()
    Dim con As New SqlConnection("Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True")
    Dim cmd As SqlCommand

    Private Sub CaptureButton_Click(sender As Object, e As EventArgs) Handles CaptureButton.Click
        Try
            If CaptureButton.Text = "CAMERA" Then
                ImageBox1.Visible = True
                ImageBox1.Enabled = True
                ImageBox1.BringToFront()
                UnknownPic.Visible = False
                ImageBox.Visible = False
                Timer1.Start()
                ImageBox.Image = Nothing
                CaptureButton.Text = "CAPTURE"
            ElseIf CaptureButton.Text = "CAPTURE" Then
                Timer1.Stop()
                UnknownPic.Visible = False
                ImageBox.Image = Nothing
                ImageBox.Enabled = False
                CaptureButton.Text = "CAMERA"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Try
            Dim ofd As New OpenFileDialog
            ImageBox.Visible = True
            ImageBox.BringToFront()
            ImageBox.Enabled = True
            ImageBox1.Enabled = False
            If ofd.ShowDialog = DialogResult.OK Then
                ImageBox.Enabled = True
                ImageBox1.Enabled = False
                ImageBox1.Visible = False
                UnknownPic.Visible = False
                ImageBox.Image = Image.FromFile(ofd.FileName)
                ImageBox1.Image = Nothing
            Else
                MsgBox("Please choose image")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ImageBox.Image = Nothing
        ImageBox1.Image = Nothing
        UnknownPic.Visible = True
        UnknownPic.BringToFront()

    End Sub
    Private Sub SaveLog()

        GetLogForToolStrip()
        Dim datetime = DateAndTime.Now()
        Dim userType As String
        Dim username = logTextBox.Text
        If username = "Guest" Then
            userType = "Guest"
        Else
            userType = "Administrator"
        End If
        Dim action = "Saved Record"
        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand

        Dim query1 As String = String.Empty
        query1 &= "INSERT INTO Logs (Username,Date,Account,Action)"
        query1 &= "VALUES (@Username,@Date,@Account,@Action)"


        con1.ConnectionString = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
        With cmd1
            .Connection = con1
            .CommandType = CommandType.Text
            .CommandText = query1
            .Parameters.AddWithValue("@Username", username)
            .Parameters.AddWithValue("@Date", datetime)
            .Parameters.AddWithValue("@Account", userType)
            .Parameters.AddWithValue("@Action", action)
        End With

        con1.Open()
        cmd1.ExecuteNonQuery()



    End Sub
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            If SurnameTextBox.Text = "" Then
                MessageBox.Show("Please enter surname", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SurnameTextBox.Focus()
            ElseIf FirstNameTextBox.Text = "" Then
                MessageBox.Show("Please enter first name", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FirstNameTextBox.Focus()
            ElseIf AgeTextBox.Text = "" Then
                MessageBox.Show("Please enter age", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AgeTextBox.Focus()
            ElseIf BirthplaceTextBox.Text = "" Then
                MessageBox.Show("Please enter birthplace", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BirthplaceTextBox.Focus()
            ElseIf AddressTextBox.Text = "" Then
                MessageBox.Show("Please enter address", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AddressTextBox.Focus()
            ElseIf VoterRadBtn.Checked = False And NotVoterRadBtn.Checked = False Then
                MessageBox.Show("Please indicate whether he/she is a voter", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                VoterRadBtn.Focus()
            ElseIf ImageBox.Image Is Nothing And ImageBox1.Image Is Nothing Then
                ImageBox.Image = My.Resources.Unknown_DP_Icon

            ElseIf ImageBox1.Enabled = False And ImageBox.Enabled = False Then
                MessageBox.Show("Add Image!", "Error", MessageBoxButtons.OK)

            Else
                SaveLog()

                Dim surname = SurnameTextBox.Text.ToUpper()
                Dim firstname = FirstNameTextBox.Text.ToUpper()
                Dim middlename = MiddleNameTextBox.Text.ToUpper()
                Dim age = AgeTextBox.Text
                Dim birthplace = BirthplaceTextBox.Text.ToUpper()
                Dim address = AddressTextBox.Text.ToUpper()
                Dim voter = ""
                Dim mi = ""
                If MiddleNameTextBox.Text = "" Then
                    mi = ""
                Else
                    mi = MiddleNameTextBox.Text.Substring(0, 1).ToUpper() & "."
                End If
                Dim delete = 0

                If VoterRadBtn.Checked = True Then
                    voter = VoterRadBtn.Text
                ElseIf NotVoterRadBtn.Checked = True Then
                    voter = NotVoterRadBtn.Text
                End If

                Dim criminalrecord = CriminalRecordTextBox.Text

                Dim query As String = "INSERT INTO Record (Surname,Firstname,Middlename,Age,Birthplace,Address,Voter,CriminalRecord,MiddleInitial,[Delete],Picture) VALUES (@Surname,@Firstname,@Middlename,@Age,@Birthplace,@Address,@Voter,@CriminalRecord,@MiddleInitial,@Delete,@Picture)"
                Dim cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Surname", surname)
                cmd.Parameters.AddWithValue("@Firstname", firstname)
                cmd.Parameters.AddWithValue("@Middlename", middlename)
                cmd.Parameters.AddWithValue("@Age", age)
                cmd.Parameters.AddWithValue("@Birthplace", birthplace)
                cmd.Parameters.AddWithValue("@Address", address)
                cmd.Parameters.AddWithValue("@Voter", voter)
                cmd.Parameters.AddWithValue("@CriminalRecord", criminalrecord)
                cmd.Parameters.AddWithValue("@MiddleInitial", mi)
                cmd.Parameters.AddWithValue("@Delete", delete)
                If ImageBox.Enabled = True And ImageBox1.Enabled = False Then
                    Dim ms As New MemoryStream()
                    ImageBox.Image.Save(ms, ImageBox.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim image As New SqlParameter("@Picture", SqlDbType.Image)
                    image.Value = data
                    cmd.Parameters.Add(image)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    MessageBox.Show("Successfully Added!", "Save", MessageBoxButtons.OK)
                    SurnameTextBox.Clear()
                    FirstNameTextBox.Clear()
                    MiddleNameTextBox.Clear()
                    AgeTextBox.Clear()
                    BirthplaceTextBox.Clear()
                    AddressTextBox.Clear()
                    VoterRadBtn.Checked = False
                    NotVoterRadBtn.Checked = False
                    ImageBox.Visible = False
                    ImageBox1.Visible = False
                    ImageBox1.Image = Nothing
                    ImageBox.Image = Nothing
                    UnknownPic.Visible = True
                ElseIf ImageBox1.Enabled = True And ImageBox.Enabled = False Then
                    Dim ms As New MemoryStream()
                    ImageBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim image As New SqlParameter("@Picture", SqlDbType.Image)
                    image.Value = data
                    cmd.Parameters.Add(image)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    MessageBox.Show("Successfully Added!", "Save", MessageBoxButtons.OK)
                    SurnameTextBox.Clear()
                    FirstNameTextBox.Clear()
                    MiddleNameTextBox.Clear()
                    AgeTextBox.Clear()
                    BirthplaceTextBox.Clear()
                    AddressTextBox.Clear()
                    VoterRadBtn.Checked = False
                    NotVoterRadBtn.Checked = False
                    ImageBox.Visible = False
                    ImageBox1.Visible = False
                    ImageBox1.Image = Nothing
                    ImageBox.Image = Nothing
                    UnknownPic.Visible = True

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SurnameTextBox.Text = ""
        FirstNameTextBox.Text = ""
        MiddleNameTextBox.Text = ""
        AgeTextBox.Text = ""
        BirthplaceTextBox.Text = ""
        AddressTextBox.Text = ""
        VoterRadBtn.Checked = False
        NotVoterRadBtn.Checked = False
        CriminalRecordTextBox.Text = ""
        UnknownPic.Visible = True
        UnknownPic.BringToFront()
        ImageBox.Image = Nothing
        ImageBox1.Image = Nothing
        ImageBox.Enabled = False
        ImageBox1.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        People.ShowPeopleList()
        People.Show()

        Me.Close()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ToolStripStatusTime.Text = "Time: " & TimeOfDay.ToString("hh:mm tt")
    End Sub
    Private Sub GetLogForToolStrip()
        Timer1.Enabled = True
        ToolStripStatusDate.Text = "Date: " & Date.Now.ToString("MM/dd/yyyy")
        'ToolStripStatusTime.Text = "Time: " & TimeOfDay.ToString("hh:mm")

        Dim Username = UserTextBox.Text
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim query As String = String.Empty
        query &= "SELECT MAX(Username) FROM Logs"
        con.ConnectionString = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@Username", Username)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            Try
                dr.Read()
                ToolStripStatusUser.Text = "" & dr.GetValue(0)
                logTextBox.Text = "" & dr.GetValue(0)
                dr.Close()
            Catch ex As Exception
                MsgBox("" + ex.Message)
                dr.Close()
            End Try
        End With

        con.Close()
    End Sub
    Private Sub PeopleCREATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLogForToolStrip()
        SurnameTextBox.Focus()
        CriminalRecordTextBox.Text = "N/A"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ImageBox1.Image = cap.QueryFrame.ToBitmap()
    End Sub

    Private Sub AgeTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AgeTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

End Class