Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports Emgu.CV
Imports Emgu.CV.UI
Imports Emgu.CV.Structure
Public Class PeopleEDIT
    Dim cap As New Capture()
    Dim con As New SqlConnection("Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True")
    Dim cmd As SqlCommand
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ToolStripStatusTime.Text = "Time: " & TimeOfDay.ToString("hh:mm tt")
    End Sub
    Private Sub GetLogForToolStrip()
        Timer2.Enabled = True
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
                ToolStripStatusUser.Text = "User: " & dr.GetValue(0)
                logTextBox.Text = "" & dr.GetValue(0)
                dr.Close()
            Catch ex As Exception
                MsgBox("" + ex.Message)
                dr.Close()
            End Try
        End With

        con.Close()
    End Sub
    Private Sub PeopleEDIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLogForToolStrip()
        People.ClickPeople()

        Dim row As DataGridViewRow = People.PeopleDataGridView.CurrentRow
        IdTextBox.Text = row.Cells(0).Value.ToString()
        SurnameTextBox.Text = row.Cells(1).Value.ToString()
        FirstNameTextBox.Text = row.Cells(2).Value.ToString()
        MiddleNameTextBox.Text = row.Cells(3).Value.ToString()
        AgeTextBox1.Text = row.Cells(4).Value.ToString()
        BirthplaceTextBox.Text = row.Cells(5).Value.ToString()
        AddressTextBox.Text = row.Cells(6).Value.ToString()
        If row.Cells(7).Value.ToString() = "YES" Then
            VoterRadBtn.Checked = True
        ElseIf row.Cells(7).Value.ToString() = "NO" Then
            NotVoterRadBtn.Checked = True
        End If
        CriminalRecordTextBox.Text = row.Cells(8).Value.ToString()
        cmd = New SqlCommand("Select Picture from Record where Id='" & People.PeopleDataGridView.CurrentRow.Cells(0).Value() & "'", con)
        con.Open()
        Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
        con.Close()
        If Not imageData Is Nothing Then
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                RETimage.BringToFront()
                RETimage.Image = Image.FromStream(ms, True)
            End Using
        End If

        If SurnameTextBox.Text = "" And FirstNameTextBox.Text = "" And
            MiddleNameTextBox.Text = "" And
            AgeTextBox1.Text = "" And
            BirthplaceTextBox.Text = "" And
            AddressTextBox.Text = "" And
            VoterRadBtn.Checked = False And
            NotVoterRadBtn.Checked = False And
            CriminalRecordTextBox.Text = "" And
            RETimage.Image Is Nothing And
            ImageBox.Image Is Nothing And
            ImageBox1.Image Is Nothing Then
            MessageBox.Show("Error in retrieving data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            People.Show()
            Me.Close()
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ImageBox1.Image = cap.QueryFrame.ToBitmap()
    End Sub


    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            People.ClickPeople()

            If SurnameTextBox.Text = "" Then
                MessageBox.Show("Please enter surname", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SurnameTextBox.Focus()
            ElseIf FirstNameTextBox.Text = "" Then
                MessageBox.Show("Please enter first name", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FirstNameTextBox.Focus()
            ElseIf AgeTextBox1.Text = "" Then
                MessageBox.Show("Please enter age", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AgeTextBox1.Focus()
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
            ElseIf ImageBox1.Enabled = False And ImageBox.Enabled = False And RETimage.Enabled = False Then
                MessageBox.Show("Add Image!", "Error", MessageBoxButtons.OK)
            Else

                GetLogForToolStrip()
                Dim datetime = DateAndTime.Now()
                Dim userType As String
                Dim username = logTextBox.Text
                If username = "Guest" Then
                    userType = "Guest"
                Else
                    userType = "Administrator"
                End If
                Dim action = "Updated a Record"
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


                Dim Id = IdTextBox.Text
                Dim surname = SurnameTextBox.Text.ToUpper()
                Dim firstname = FirstNameTextBox.Text.ToUpper()
                Dim middlename = MiddleNameTextBox.Text.ToUpper()
                Dim age = AgeTextBox1.Text
                Dim birthplace = BirthplaceTextBox.Text.ToUpper()
                Dim address = AddressTextBox.Text.ToUpper()
                Dim mi = ""
                If MiddleNameTextBox.Text = "" Then
                    mi = ""
                Else
                    mi = MiddleNameTextBox.Text.Substring(0, 1).ToUpper() & "."
                End If
                Dim voter As String = ""
                If VoterRadBtn.Checked = True Then
                    voter = VoterRadBtn.Text
                ElseIf NotVoterRadBtn.Checked = True Then
                    voter = NotVoterRadBtn.Text
                End If

                Dim criminalrecord = CriminalRecordTextBox.Text.ToUpper()



                If ImageBox1.Enabled = False And RETimage.Enabled = False Then
                    Dim query As String = "UPDATE Record SET Surname=@Surname,Firstname=@Firstname,Middlename=@Middlename,Age=@Age,Birthplace=@Birthplace,Address=@Address,Voter=@Voter,Criminalrecord=@CriminalRecord,Picture=@Picture,MiddleInitial=@MiddleInitial where Id = @id"
                    Dim cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@Id", Id)
                    cmd.Parameters.AddWithValue("@Surname", surname)
                    cmd.Parameters.AddWithValue("@Firstname", firstname)
                    cmd.Parameters.AddWithValue("@Middlename", middlename)
                    cmd.Parameters.AddWithValue("@Age", age)
                    cmd.Parameters.AddWithValue("@Birthplace", birthplace)
                    cmd.Parameters.AddWithValue("@Address", address)
                    cmd.Parameters.AddWithValue("@Voter", voter)
                    cmd.Parameters.AddWithValue("@CriminalRecord", criminalrecord)
                    Dim ms As New MemoryStream()
                    ImageBox.Image.Save(ms, ImageBox.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim image As New SqlParameter("@Picture", SqlDbType.Image)
                    image.Value = data
                    cmd.Parameters.Add(image)
                    cmd.Parameters.AddWithValue("@MiddleInitial", mi)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK)
                    SurnameTextBox.Clear()
                    FirstNameTextBox.Clear()
                    MiddleNameTextBox.Clear()
                    AgeTextBox1.Clear()
                    BirthplaceTextBox.Clear()
                    AddressTextBox.Clear()
                    VoterRadBtn.Checked = False
                    NotVoterRadBtn.Checked = False
                    ImageBox.Visible = False
                    ImageBox1.Visible = False
                    ImageBox.Image = Nothing
                    RETimage.Image = Nothing
                    ImageBox1.Image = Nothing
                    CriminalRecordTextBox.Text = ""
                    Me.Hide()
                    People.Show()


                ElseIf ImageBox1.Enabled = False And ImageBox.Enabled = False Then
                    Dim query As String = "UPDATE Record SET Surname=@Surname,Firstname=@Firstname,Middlename=@Middlename,Age=@Age,Birthplace=@Birthplace,Address=@Address,Voter=@Voter,Criminalrecord=@CriminalRecord,MiddleInitial=@MiddleInitial where Id = @id"
                    Dim cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@Id", Id)
                    cmd.Parameters.AddWithValue("@Surname", surname)
                    cmd.Parameters.AddWithValue("@Firstname", firstname)
                    cmd.Parameters.AddWithValue("@Middlename", middlename)
                    cmd.Parameters.AddWithValue("@Age", age)
                    cmd.Parameters.AddWithValue("@Birthplace", birthplace)
                    cmd.Parameters.AddWithValue("@Address", address)
                    cmd.Parameters.AddWithValue("@Voter", voter)
                    cmd.Parameters.AddWithValue("@CriminalRecord", criminalrecord)
                    cmd.Parameters.AddWithValue("@MiddleInitial", mi)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK)
                    SurnameTextBox.Clear()
                    FirstNameTextBox.Clear()
                    MiddleNameTextBox.Clear()
                    AgeTextBox1.Clear()
                    BirthplaceTextBox.Clear()
                    AddressTextBox.Clear()
                    VoterRadBtn.Checked = False
                    NotVoterRadBtn.Checked = False
                    CriminalRecordTextBox.Text = ""
                    ImageBox.Visible = False
                    ImageBox1.Visible = False
                    ImageBox.Image = Nothing
                    RETimage.Image = Nothing
                    ImageBox1.Image = Nothing
                    Me.Hide()
                    People.Show()

                ElseIf ImageBox.Enabled = False And RETimage.Enabled = False Then
                    Dim query As String = "UPDATE Record SET Surname=@Surname,Firstname=@Firstname,Middlename=@Middlename,Age=@Age,Birthplace=@Birthplace,Address=@Address,Voter=@Voter,Criminalrecord=@CriminalRecord,Picture=@Picture,MiddleInitial=@MiddleInitial where Id = @id"
                    Dim cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@Id", Id)
                    cmd.Parameters.AddWithValue("@Surname", surname)
                    cmd.Parameters.AddWithValue("@Firstname", firstname)
                    cmd.Parameters.AddWithValue("@Middlename", middlename)
                    cmd.Parameters.AddWithValue("@Age", age)
                    cmd.Parameters.AddWithValue("@Birthplace", birthplace)
                    cmd.Parameters.AddWithValue("@Address", address)
                    cmd.Parameters.AddWithValue("@Voter", voter)
                    cmd.Parameters.AddWithValue("@CriminalRecord", criminalrecord)
                    Dim ms As New MemoryStream()
                    ImageBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim image As New SqlParameter("@Picture", SqlDbType.Image)
                    image.Value = data
                    cmd.Parameters.Add(image)
                    cmd.Parameters.AddWithValue("@MiddleInitial", mi)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    MessageBox.Show("Successfully Updated!", "Updated", MessageBoxButtons.OK)
                    SurnameTextBox.Clear()
                    FirstNameTextBox.Clear()
                    MiddleNameTextBox.Clear()
                    AgeTextBox1.Clear()
                    BirthplaceTextBox.Clear()
                    AddressTextBox.Clear()
                    VoterRadBtn.Checked = False
                    NotVoterRadBtn.Checked = False
                    ImageBox.Visible = False
                    ImageBox1.Visible = False
                    ImageBox.Image = Nothing
                    RETimage.Image = Nothing
                    ImageBox1.Image = Nothing
                    CriminalRecordTextBox.Text = ""
                    Me.Hide()
                    People.ShowPeopleList()
                    People.Show()


                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click

        Try
            Dim ofd As New OpenFileDialog
            ImageBox.BringToFront()
            ImageBox.Visible = True
            ImageBox.Enabled = True
            ImageBox1.Enabled = False

            If ofd.ShowDialog = DialogResult.OK Then
                ImageBox.Image = Image.FromFile(ofd.FileName)
                ImageBox.Enabled = True
                ImageBox1.Enabled = False
                ImageBox1.Visible = False
                RETimage.Image = Nothing
                RETimage.Enabled = False

                ImageBox1.Image = Nothing
            Else
                MsgBox("Please choose an image")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CaptureButton_Click(sender As Object, e As EventArgs) Handles CaptureButton.Click
        Try
            If CaptureButton.Text = "CAMERA" Then
                ImageBox1.Visible = True
                ImageBox1.Enabled = True
                ImageBox1.BringToFront()
                ImageBox.Visible = False
                ImageBox.Visible = False
                RETimage.Visible = False
                Timer1.Start()
                RETimage.Image = Nothing
                RETimage.Enabled = False
                ImageBox.Image = Nothing
                ImageBox1.BringToFront()
                CaptureButton.Text = "CAPTURE"
            ElseIf CaptureButton.Text = "CAPTURE" Then
                ImageBox.Visible = False
                RETimage.Visible = False
                Timer1.Stop()
                RETimage.Image = Nothing
                ImageBox.Image = Nothing
                ImageBox.Enabled = False
                RETimage.Enabled = False
                ImageBox1.BringToFront()
                CaptureButton.Text = "CAMERA"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ImageBox.Image = Nothing
        ImageBox1.Image = Nothing
        RETimage.Visible = True
        RETimage.Image = My.Resources.Unknown_DP_Icon
        RETimage.Enabled = True
        ImageBox.Enabled = False
        ImageBox1.Enabled = False

    End Sub

    Private Sub BackPic_Click(sender As Object, e As EventArgs) Handles BackPic.Click
        People.ShowPeopleList()
        People.Show()
        Me.Close()

    End Sub

    Private Sub AgeTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AgeTextBox1.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SurnameTextBox.Text = ""
        FirstNameTextBox.Text = ""
        MiddleNameTextBox.Text = ""
        AgeTextBox1.Text = ""
        BirthplaceTextBox.Text = ""
        AddressTextBox.Text = ""
        VoterRadBtn.Checked = False
        NotVoterRadBtn.Checked = False
        CriminalRecordTextBox.Text = ""
        RETimage.Image = My.Resources.Unknown_DP_Icon
        ImageBox.Image = Nothing
        ImageBox1.Image = Nothing



    End Sub

    Private Sub overalltable_Paint(sender As Object, e As PaintEventArgs) Handles overalltable.Paint

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusUser.Click

    End Sub
End Class