Imports System.Data.SqlClient
Public Class Login
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If AccountComboBox.SelectedItem = "Administrator" Then
            PasswordTextBox.ReadOnly = False
            UserTextBox.ReadOnly = False
            Login()


        ElseIf AccountComboBox.SelectedItem = "Guest" Then
            MessageBox.Show("Welcome Guest", "Successfully Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Main.Show()
            Save_LogGUest()
        Else : AccountComboBox.SelectedItem = ""
            MessageBox.Show("Please choose the user type", "Unsuccessful Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Save_LogGUest()
        Try
            Dim datetime = DateAndTime.Now()
            Dim username = "Guest"
            Dim userType = AccountComboBox.SelectedItem.ToString()
            Dim action = "Logged in"
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim query As String = String.Empty
            query &= "INSERT INTO Logs (Username,Date,Account,Action)"
            query &= "VALUES (@Username,@Date,@Account,@Action)"


            con.ConnectionString = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
            With cmd
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@Username", username)
                .Parameters.AddWithValue("@Date", datetime)
                .Parameters.AddWithValue("@Account", userType)
                .Parameters.AddWithValue("@Action", action)
            End With

            con.Open()
            cmd.ExecuteNonQuery()
            AccountComboBox.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        UserTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub AccountComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccountComboBox.SelectedIndexChanged
        If Me.AccountComboBox.SelectedIndex = 1 Then
            Me.UserTextBox.ReadOnly = False
            Me.PasswordTextBox.ReadOnly = False
        End If
        If Me.AccountComboBox.SelectedIndex = 0 Then
            Me.UserTextBox.ReadOnly = True
            Me.PasswordTextBox.ReadOnly = True
        End If
    End Sub
    Private Sub Login()
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim Password As String
            Dim Password2 As String
            Dim username As String



            con.ConnectionString = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
            con.Open()

            cmd.Connection = con
            cmd.CommandText = "Select Username, Pass FROM UserAccount WHERE (Username = '" & UserTextBox.Text & "' ) AND (Pass = '" & PasswordTextBox.Text & "')"

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()

                    Password = reader("Pass").ToString()
                    username = reader("Username").ToString()

                    Password2 = PasswordTextBox.Text()

                    If Password = Password2 And username = UserTextBox.Text Then

                        MessageBox.Show("Logged In successfully As " & username, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Main.Show()
                        Me.Hide()
                        Save_Log()
                        UserTextBox.Clear()
                        PasswordTextBox.Clear()

                    End If
                End While

            Else
                MessageBox.Show("Username And Password Do Not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                UserTextBox.Clear()
                PasswordTextBox.Clear()
                UserTextBox.Focus()

            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Save_Log()

        Dim datetime = DateAndTime.Now()
        Dim username = UserTextBox.Text()
        Dim userType = AccountComboBox.SelectedItem.ToString()
        Dim action = "Logged in"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim query As String = String.Empty
        query &= "INSERT INTO Logs (Username,Date,Account,Action)"
        query &= "VALUES (@Username,@Date,@Account,@Action)"


        con.ConnectionString = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@Username", username)
            .Parameters.AddWithValue("@Date", datetime)
            .Parameters.AddWithValue("@Account", userType)
            .Parameters.AddWithValue("@Action", action)
        End With

        con.Open()
        cmd.ExecuteNonQuery()
        AccountComboBox.SelectedIndex = -1
    End Sub

    Private Sub ChangePassButton_Click(sender As Object, e As EventArgs) Handles ChangePassButton.Click
        ChangePassword.Show()
        Me.Hide()
    End Sub
End Class
