Imports System.Data.SqlClient
Public Class ChangePassword
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidateButton.Visible = True
        OldUserLabel.Visible = True
        OldPassLabel.Visible = True
        OldUsernameTextBox.Visible = True
        OldPasswordTextBox.Visible = True
        ConfirmNewLabel.Visible = False
        ConfirmNewPassTextBox.Visible = False
        NewPasswordTextBox.Visible = False
        NewUsernameTextBox.Visible = False
        NewPassLabel.Visible = False
        NewUserLabel.Visible = False
        ChangeButton.Visible = False
    End Sub


    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        OldPasswordTextBox.Clear()
        OldUsernameTextBox.Clear()
        NewPasswordTextBox.Clear()
        NewUsernameTextBox.Clear()
    End Sub

    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim Password As String
            Dim Password2 As String
            Dim username As String



            con.ConnectionString = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
            con.Open()

            cmd.Connection = con
            cmd.CommandText = "Select Username, Pass FROM UserAccount WHERE (Username = '" & OldUsernameTextBox.Text & "' ) AND (Pass = '" & OldPasswordTextBox.Text & "')"

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()

                    Password = reader("Pass").ToString()
                    username = reader("Username").ToString()

                    Password2 = OldPasswordTextBox.Text()

                    If Password = Password2 And username = OldUsernameTextBox.Text Then
                        MessageBox.Show("Successfully retrieve account.", "Account Retrieve", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ValidateButton.Visible = False
                        OldUserLabel.Visible = False
                        OldPassLabel.Visible = False
                        OldUsernameTextBox.Visible = False
                        OldPasswordTextBox.Visible = False
                        ConfirmNewLabel.Visible = True
                        ConfirmNewPassTextBox.Visible = True
                        NewPasswordTextBox.Visible = True
                        NewPasswordTextBox.ReadOnly = False
                        NewUsernameTextBox.ReadOnly = False
                        NewUsernameTextBox.Visible = True
                        NewPassLabel.Visible = True
                        NewUserLabel.Visible = True
                        ChangeButton.Visible = True
                    End If
                End While
            Else
                MessageBox.Show("Username And Password Do Not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                OldUsernameTextBox.Clear()
                OldPasswordTextBox.Clear()
                OldUsernameTextBox.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        Try
            If (NewPasswordTextBox.Text <> ConfirmNewPassTextBox.Text) Then
                MessageBox.Show("New password and confirm new password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                NewPasswordTextBox.Clear()
                ConfirmNewPassTextBox.Clear()
                NewPasswordTextBox.Focus()
            Else
                Dim NewUser = NewUsernameTextBox.Text
                Dim NewPass = NewPasswordTextBox.Text
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand


                Dim query As String = String.Empty
                query &= "UPDATE UserAccount SET Username=@Username,Pass=@Pass"

                con.ConnectionString = "Data Source = LJMARZO-PC; Initial Catalog = BrgySabangInfo; Integrated Security = True"
                With cmd
                    .Connection = con
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Username", NewUser)
                    .Parameters.AddWithValue("@Pass", NewPass)
                End With

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Successfully Updated!")
                Login.Show()
                Save_Log()
                Me.Hide()
                OldPasswordTextBox.Clear()
                OldUsernameTextBox.Clear()
                NewPasswordTextBox.Clear()
                NewUsernameTextBox.Clear()
                ConfirmNewLabel.Visible = False
                ConfirmNewPassTextBox.Visible = False
                ValidateButton.Visible = True
                OldUsernameTextBox.Visible = True
                OldPasswordTextBox.Visible = True
                ChangeButton.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Save_Log()
        Dim datetime = DateAndTime.Now()
        Dim username = NewUsernameTextBox.Text()
        Dim userType = "Administrator"
        Dim action = "Change username/password."
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

    End Sub

    Private Sub OldUserLabel_Click(sender As Object, e As EventArgs) Handles OldUserLabel.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub NewPassLabel_Click(sender As Object, e As EventArgs) Handles NewPassLabel.Click

    End Sub

    Private Sub OldPassLabel_Click(sender As Object, e As EventArgs) Handles OldPassLabel.Click

    End Sub
End Class