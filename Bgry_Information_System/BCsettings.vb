Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class BCsettings
    Dim con As New SqlConnection("Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True")
    Dim cmd As SqlCommand
    Private Sub LoadPurpose()
        Try


            Dim con As String = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
            Dim query As String = String.Empty
            query &= "SELECT * FROM Purpose ORDER BY Purpose"
            Dim connection As New SqlConnection(con)
            Dim dataadapter As New SqlDataAdapter(query, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Purpose")
            connection.Close()
            PurposeDataGridView.DataSource = ds
            PurposeDataGridView.DataMember = "Purpose"
            PurposeDataGridView.Columns(0).Visible = False
            PurposeDataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub LoadLogs()
        Try
            Dim con As String = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
            Dim query As String = String.Empty
            query &= "SELECT * FROM Logs"

            Dim connection As New SqlConnection(con)
            Dim dataadapter As New SqlDataAdapter(query, connection)
            Dim ds As New DataSet()
            Dim img As New DataGridViewImageColumn

            connection.Open()
            dataadapter.Fill(ds, "Logs")
            connection.Close()
            LogsDataGridView.DataSource = ds
            LogsDataGridView.DataMember = "Logs"
            LogsDataGridView.Columns(0).Width = 200
            LogsDataGridView.Columns(1).Width = 210
            LogsDataGridView.Columns(2).Width = 200
            LogsDataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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

    Private Sub BCsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLogs()
        GetLogForToolStrip()
        PurposeTextBox.Text = "Enter Additional Purpose Here"
        LoadPurpose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            GetLogForToolStrip()
            Dim datetime = DateAndTime.Now()
            Dim userType As String
            Dim username = logTextBox.Text
            If username = "Guest" Then
                userType = "Guest"
            Else
                userType = "Administrator"
            End If
            Dim action = "Added in Purpose List"
            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand

            Dim query1 As String = String.Empty
            query1 &= "INSERT INTO Logs (Username,Date,Account,Action)"
            query1 &= "VALUES (@Username,@Date,@Account,@Action)"


            con1.ConnectionString = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
            If PurposeTextBox.TextLength = 0 And PurposeTextBox.Text = "" Then
                MessageBox.Show("Add a purpose!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim purpose = PurposeTextBox.Text.ToUpper()
                Dim query As String = "INSERT INTO Purpose (Purpose) VALUES (@Purpose)"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Purpose", purpose)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
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
                MessageBox.Show("Successfully Added!", "Save", MessageBoxButtons.OK)
                PurposeTextBox.Clear()
                LoadPurpose()

            End If
        Catch ex As Exception
            MessageBox.Show("Error on Retrieving Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim row As DataGridViewRow = PurposeDataGridView.CurrentRow
        IdPurpose.Text = row.Cells(0).Value.ToString()
        Try
            If IdPurpose.Text = "" Then
                MessageBox.Show("Please select first what you want to delete", "Deleting Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                Dim action = "Deleted an item from Purpose List"
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
                Dim ID = IdPurpose.Text
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim query As String = String.Empty
                query &= "DELETE FROM Purpose WHERE Id=@ID"
                con.ConnectionString = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
                With cmd
                    .Connection = con
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Id", ID)
                End With
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Successfully Deleted")
                LoadPurpose()
            End If
        Catch ex As Exception
            MessageBox.Show("Error While deleting data." & ex.Message)
        End Try
    End Sub

    Private Sub PurposeTextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurposeTextBox.GotFocus
        PurposeTextBox.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        ContextMenuStrip1.Show(ExportButton, 0, ExportButton.Height)
    End Sub

    Private Sub DataOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataOnlyToolStripMenuItem.Click
        ExportData.Show()
    End Sub

    Private Sub DataWithPicturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataWithPicturesToolStripMenuItem.Click
        ExportDataWPics.Show()
    End Sub
End Class