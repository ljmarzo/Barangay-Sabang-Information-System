Imports System.Data.SqlClient
Imports System.IO
Public Class People
    Inherits System.Windows.Forms.Form
    Dim con As New SqlConnection("Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True")
    Dim cmd As SqlCommand

    Public Sub ShowPeopleList()
        Try
            Dim con As String = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
            Dim query As String = String.Empty
            query &= "SELECT Id,Surname,Firstname,Middlename,Age,Birthplace,Address,Voter,CriminalRecord,Picture FROM Record WHERE [Delete] = 0 ORDER BY Surname"



            Dim connection As New SqlConnection(con)
            Dim dataadapter As New SqlDataAdapter(query, connection)
            Dim ds As New DataSet()
            Dim img As New DataGridViewImageColumn



            connection.Open()
            dataadapter.Fill(ds, "Record")
            connection.Close()
            PeopleDataGridView.DataSource = ds
            PeopleDataGridView.DataMember = "Record"
            PeopleDataGridView.Columns(0).Visible = False
            PeopleDataGridView.Columns(1).Width = 100
            PeopleDataGridView.Columns(2).Width = 150
            PeopleDataGridView.Columns(3).Width = 100
            PeopleDataGridView.Columns(4).Width = 50
            PeopleDataGridView.Columns(5).Width = 150
            PeopleDataGridView.Columns(6).Width = 150
            PeopleDataGridView.Columns(7).Width = 50
            PeopleDataGridView.Columns(8).Width = 150
            PeopleDataGridView.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            img = PeopleDataGridView.Columns(9)
            img.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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

    Public Sub People_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLogForToolStrip()
        ShowPeopleList()
        CreateButton.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True




    End Sub


    Public Sub ClickPeople()
        Dim row As DataGridViewRow = PeopleDataGridView.CurrentRow

        IdTextBox.Text = row.Cells(0).Value.ToString()
        NameTextBox.Text = row.Cells(1).Value.ToString() & ", " & row.Cells(2).Value.ToString() & " " & row.Cells(3).Value.ToString()
        AgeTextBox.Text = row.Cells(4).Value.ToString()
        BirthplaceTextBox.Text = row.Cells(5).Value.ToString()
        AddressTextBox.Text = row.Cells(6).Value.ToString()
        VoterTextBox.Text = row.Cells(7).Value.ToString()
        CriminalRecordTextBox.Text = row.Cells(8).Value.ToString()
        cmd = New SqlCommand("Select Picture from Record where Id='" & PeopleDataGridView.CurrentRow.Cells(0).Value() & "'", con)
        con.Open()
        Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
        con.Close()
        If Not imageData Is Nothing Then
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                PreviewPictureBox.Image = Image.FromStream(ms, True)
            End Using
        End If
    End Sub
    Public Sub PeopleDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PeopleDataGridView.CellClick
        ClickPeople()

    End Sub

    Public Sub SearchSurname()
        Dim con As SqlConnection = New SqlConnection("Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = "SELECT Id,Surname,Firstname,Middlename,Age,Birthplace,Address,Voter,CriminalRecord,Picture FROM Record WHERE [Delete] = 0 AND Surname  Like'" & SearchTextBox.Text & "%'"
            End With
            adapt.SelectCommand = cmd
            adapt.Fill(dt)

            Dim img As New DataGridViewImageColumn

            PeopleDataGridView.DataSource = dt

            PeopleDataGridView.Columns(0).Width = 100
            PeopleDataGridView.Columns(1).Width = 100
            PeopleDataGridView.Columns(2).Width = 150
            PeopleDataGridView.Columns(3).Width = 100
            PeopleDataGridView.Columns(4).Width = 100
            PeopleDataGridView.Columns(5).Width = 100
            PeopleDataGridView.Columns(6).Width = 100
            PeopleDataGridView.Columns(7).Width = 100
            PeopleDataGridView.Columns(8).Width = 100
            PeopleDataGridView.Columns(9).Width = 100
            img = PeopleDataGridView.Columns(9)
            img.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adapt.Dispose()
        con.Close()
    End Sub
    Public Sub SearchFirstname()
        Dim con As SqlConnection = New SqlConnection("Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = "SELECT Id,Surname,Firstname,Middlename,Age,Birthplace,Address,Voter,CriminalRecord,Picture FROM Record WHERE [Delete] = 0 AND Firstname  Like'" & SearchTextBox.Text & "%'"
            End With
            adapt.SelectCommand = cmd
            adapt.Fill(dt)

            Dim img As New DataGridViewImageColumn

            PeopleDataGridView.DataSource = dt

            PeopleDataGridView.Columns(0).Width = 100
            PeopleDataGridView.Columns(1).Width = 100
            PeopleDataGridView.Columns(2).Width = 150
            PeopleDataGridView.Columns(3).Width = 100
            PeopleDataGridView.Columns(4).Width = 100
            PeopleDataGridView.Columns(5).Width = 100
            PeopleDataGridView.Columns(6).Width = 100
            PeopleDataGridView.Columns(7).Width = 100
            PeopleDataGridView.Columns(8).Width = 100
            PeopleDataGridView.Columns(9).Width = 100
            img = PeopleDataGridView.Columns(9)
            img.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adapt.Dispose()
        con.Close()
    End Sub


    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If SearchComboBox.SelectedItem = "Surname" Then
            SearchSurname()
        Else
            SearchFirstname()
        End If
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Me.Hide()
        PeopleCREATE.Show()

    End Sub
    Private Sub DeleteCell()
        Dim ID = IdTextBox.Text
        Dim delete = 1
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim query As String = String.Empty
        query &= "UPDATE Record SET [Delete] = @Delete WHERE Id=@Id"
        con.ConnectionString = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@Delete", delete)
            .Parameters.AddWithValue("@Id", ID)
        End With
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show("Successfully Deleted")
        ShowPeopleList()

        GetLogForToolStrip()
        Dim datetime = DateAndTime.Now()
        Dim userType As String
        Dim username = logTextBox.Text
        If username = "Guest" Then
            userType = "Guest"
        Else
            userType = "Administrator"
        End If
        Dim action = "Deleted a Record"
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
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If IdTextBox.Text = "" Then
                MessageBox.Show("Please select first what you want to delete", "Deleting Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim row As DataGridViewRow = PeopleDataGridView.CurrentRow
                Dim question As String = "Are you sure you want to delete " & row.Cells(1).Value.ToString() & ", " & row.Cells(2).Value.ToString() & " " & row.Cells(3).Value.ToString() & "?"
                If MessageBox.Show(question, "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then

                    DeleteCell()
                    Refresh()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting data." & ex.Message)
        End Try
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            If IdTextBox.Text = "" Then
                MessageBox.Show("Please select first what you want to edit", "Edit Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                PeopleEDIT.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while processing." & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Main.Show()
        Me.Hide()
    End Sub
    Private Sub RefreshForm()
        ShowPeopleList()
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        BirthplaceTextBox.Text = ""
        AddressTextBox.Text = ""
        VoterTextBox.Text = ""
        CriminalRecordTextBox.Text = ""
        SearchComboBox.Text = "Surname"
        SearchTextBox.Text = ""
        SearchTextBox.Focus()

        PreviewPictureBox.Image = My.Resources.Unknown_DP_Icon
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        RefreshForm()
    End Sub



    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
End Class