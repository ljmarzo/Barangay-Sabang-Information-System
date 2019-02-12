Imports System.Data.SqlClient
Public Class Main
    Private Sub TransactionButton_Click(sender As Object, e As EventArgs) Handles TransactionButton.Click
        ContextMenuStrip3.Show(TransactionButton, 0, TransactionButton.Height)

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
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WelcomeLabel.Visible = True
        'UserLabel.Text = Login.AccountComboBox.SelectedItem.ToString() & "!"

        GetLogForToolStrip()

    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        If MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            GetLogForToolStrip()
            Dim datetime = DateAndTime.Now()
            Dim userType As String
            Dim username = logTextBox.Text
            If username = "Guest" Then
                userType = "Guest"
            Else
                userType = "Administrator"
            End If
            Dim action = "Logged Out"
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
            Me.Close()
            Login.Show()

        End If

    End Sub

    Private Sub PeopleButton_Click(sender As Object, e As EventArgs) Handles PeopleButton.Click
        People.Show()
        Me.Hide()
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        Me.Hide()
        BCsettings.Show()
    End Sub


    Private Sub BarangayClearanceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BarangayClearanceToolStripMenuItem1.Click
        Me.Hide()
        BrgyClearance.Show()
    End Sub

    Private Sub CertificateOfIndigencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificateOfIndigencyToolStripMenuItem.Click
        Me.Hide()
        WorkingPermit.Show()
    End Sub
End Class