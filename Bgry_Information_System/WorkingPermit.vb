Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class WorkingPermit
    Dim con As New SqlConnection("Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True")
    Dim cmd As SqlCommand
    Dim userName As String
    Dim Age As String
    Dim Address As String
    Dim Birthplace As String
    Dim userImg As Image
    Dim surname As String
    Dim no1 As String = ""
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


    Public Sub WorkingPermit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLogForToolStrip()
        SearchTextBox.Focus()
        SearchComboBox.Text = "Surname"
        ShowPeopleList()
        Try
            Dim con As New SqlConnection("Data Source =  LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True")
            Dim cmd As SqlCommand
            cmd = New SqlCommand("Select Count(*) from Logs where Action ='Printed a Brgy Working Permit' and year(date) =  YEAR(getdate()) ", con)
            con.Open()
            Dim no As Integer = cmd.ExecuteScalar()
            con.Close()

            no = no + 1
            If no.ToString.Length() = 1 Then

                no1 = "0000" & no
            ElseIf no.ToString.Length = 2 Then
                no1 = "000" & no
            ElseIf no.ToString.Length = 3 Then
                no1 = "00" & no
            ElseIf no.ToString.Length = 4 Then
                no1 = "0" & no
            ElseIf no.ToString.Length = 5 Then
                no1 = no

            End If

            logTextBox.Text = Date.Now.ToString("yy") & "-" & no1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub SearchSurname()
        Dim con As SqlConnection = New SqlConnection("Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As DataTable

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

    Public Sub ClickPeople()
        Dim row As DataGridViewRow = PeopleDataGridView.CurrentRow

        'userName = row.Cells(2).Value.ToString() & " " & row.Cells(3).Value.ToString(1) & " " & row.Cells(1).Value.ToString()
        'Age = row.Cells(4).Value.ToString()
        'Birthplace = row.Cells(5).Value.ToString()
        'Address = row.Cells(6).Value.ToString()
        'surname = row.Cells(1).Value.ToString()
        'cmd = New SqlCommand("Select Picture from Record where Id='" & PeopleDataGridView.CurrentRow.Cells(0).Value() & "'", con)
        'con.Open()
        'Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
        'con.Close()
        'If Not imageData Is Nothing Then
        '    Using ms As New MemoryStream(imageData, 0, imageData.Length)
        '        ms.Write(imageData, 0, imageData.Length)
        '        userImg = Image.FromStream(ms, True)
        '    End Using
        'End If
        TextBox2.Text = row.Cells(1).Value.ToString()
    End Sub
    Public Sub PeopleDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PeopleDataGridView.CellClick
        ClickPeople()

    End Sub
    Public Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If SearchComboBox.SelectedItem = "Surname" Then
            SearchSurname()
        Else
            SearchFirstname()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PreviewButton.Click
        'ShowPeopleList()
        Try

            If logTextBox.Text <> Date.Now.ToString("yy") & "-" & no1 Then
                MessageBox.Show("Error!", "Error Preview", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Main.Show()
            Else
                Dim oRpt As New CrystalReport3



            'change textobject during runtime


            Dim textObj2 As CrystalDecisions.CrystalReports.Engine.TextObject = oRpt.Section5.ReportObjects("No")
            textObj2.Text = logTextBox.Text
            CrystalReportViewer1.SelectionFormula = "{Record.Surname}= '" & TextBox2.Text.ToString() & "'"
            CrystalReportViewer1.ReportSource = oRpt
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()
        End If





            'If SearchTextBox.Text = "" Then
            '    MessageBox.Show("Please enter name to be searched", "Error Preview", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If

            'If SearchComboBox.SelectedItem = "Firstname" Then
            '    Dim oRpt As New CrystalReport2
            '    Dim textObj1 As CrystalDecisions.CrystalReports.Engine.TextObject = oRpt.Section4.ReportObjects("Purpose")
            '    Dim textObj2 As CrystalDecisions.CrystalReports.Engine.TextObject = oRpt.Section5.ReportObjects("No")


            '    'change textobject during runtime
            '    textObj1.Text = PurposeComboBox.Text
            '    textObj2.Text = logTextBox.Text

            '    CrystalReportViewer1.SelectionFormula = "{Record.Firstname}= '" & SearchTextBox.Text.ToString() & "'"
            '    CrystalReportViewer1.ReportSource = oRpt

            '    CrystalReportViewer1.Refresh()
            '    CrystalReportViewer1.RefreshReport()

            'Else

            '    Dim oRpt As New CrystalReport2
            '    Dim textObj1 As CrystalDecisions.CrystalReports.Engine.TextObject = oRpt.Section4.ReportObjects("Purpose")
            '    Dim textObj2 As CrystalDecisions.CrystalReports.Engine.TextObject = oRpt.Section5.ReportObjects("No")

            '    'change textobject during runtime
            '    textObj1.Text = PurposeComboBox.Text
            '    textObj2.Text = logTextBox.Text
            '    CrystalReportViewer1.SelectionFormula = "{Record.Surname}='" & SearchTextBox.Text.ToString() & "'"
            '    CrystalReportViewer1.ReportSource = oRpt

            '    CrystalReportViewer1.Refresh()
            '    CrystalReportViewer1.RefreshReport()

            'End If
        Catch ex As Exception
            MessageBox.Show("Error on previewing document.", "Error Preview", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            Dim oRpt As New CrystalReport3



            'change textobject during runtime
            Dim textObj2 As CrystalDecisions.CrystalReports.Engine.TextObject = oRpt.Section5.ReportObjects("No")
            textObj2.Text = logTextBox.Text
            CrystalReportViewer1.SelectionFormula = "{Record.Surname}= '" & TextBox2.Text.ToString() & "'"
            CrystalReportViewer1.ReportSource = oRpt
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.PrintReport()

            Dim pD As New PrintDialog()
            Dim dr = pD.ShowDialog()
            If (dr = DialogResult.OK) Then

                GetLogForToolStrip()
                Dim datetime = DateAndTime.Now()
                Dim userType As String
                Dim username = logTextBox.Text
                If username = "Guest" Then
                    userType = "Guest"
                Else
                    userType = "Administrator"
                End If
                Dim action = "Printed a Brgy Working Permit"
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
                SearchComboBox.Text = "Surname"
                ShowPeopleList()
                Try
                    Dim con As New SqlConnection("Data Source =  LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True")
                    Dim cmd As SqlCommand
                    cmd = New SqlCommand("Select Count(*) from Logs where Action ='Printed a Brgy Working Permit' and year(date) =  YEAR(getdate()) ", con)
                    con.Open()
                    Dim no As Integer = cmd.ExecuteScalar()
                    con.Close()

                    no = no + 1
                    If no.ToString.Length() = 1 Then

                        no1 = "0000" & no
                    ElseIf no.ToString.Length = 2 Then
                        no1 = "000" & no
                    ElseIf no.ToString.Length = 3 Then
                        no1 = "00" & no
                    ElseIf no.ToString.Length = 4 Then
                        no1 = "0" & no
                    ElseIf no.ToString.Length = 5 Then
                        no1 = no

                    End If

                    logTextBox.Text = Date.Now.ToString("yy") & "-" & no1

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show("Error on printing document.", "Error Preview", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ShowPeopleList()
        SearchTextBox.Focus()
        SearchComboBox.Text = "Surname"
        SearchTextBox.Text = ""

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub
End Class