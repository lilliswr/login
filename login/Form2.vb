Imports System.Data.OleDb
Imports System.Text
Public Class LoginForm

    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Kembara.accdb") ' nnti masuk db

    Private Sub txtEmaillogin_GotFocus(sender As Object, e As EventArgs) Handles txtEmailLogin.GotFocus
        If txtEmailLogin.Text = "E-mail" Then
            txtEmailLogin.Text = ""
            txtEmailLogin.ForeColor = Color.Black
        End If
    End Sub



    Private Sub txtemailLogin_LostFocus(sender As Object, e As EventArgs) Handles txtEmailLogin.LostFocus
        If txtEmailLogin.Text = "" Then
            txtEmailLogin.Text = "E-mail"
            txtEmailLogin.ForeColor = Color.DarkGray
        End If
    End Sub



    Private Sub txtpasswordlogin_GotFocus(sender As Object, e As EventArgs) Handles txtPasswordLogin.GotFocus
        If txtPasswordLogin.Text = "Password" Then
            txtPasswordLogin.Text = ""
            txtPasswordLogin.PasswordChar = "*"
            txtPasswordLogin.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtpasswordLogin_LostFocus(sender As Object, e As EventArgs) Handles txtPasswordLogin.LostFocus
        If txtPasswordLogin.Text = "" Then
            txtPasswordLogin.Text = "Password"
            txtPasswordLogin.PasswordChar = ""
            txtPasswordLogin.ForeColor = Color.DarkGray
        End If
    End Sub




    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Me.Hide()
        CreateForm.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Kembara.accdb" ' Replace with our db
        Using mycon As New OleDbConnection(connectionString)
            Dim query As String = "SELECT * FROM [User] WHERE [Email] = @Email AND [Password] = @Password"
            Using mycmd As New OleDbCommand(query, mycon)
                mycmd.Parameters.AddWithValue("@Email", txtEmailLogin.Text)
                mycmd.Parameters.AddWithValue("@Password", txtPasswordLogin.Text)

                Try
                    mycon.Open()
                    Dim reader As OleDbDataReader = mycmd.ExecuteReader()
                    If reader.HasRows Then
                        MsgBox("Login Successful!")
                        Me.Hide()
                        Form3.Show() 'nnti tukar masuk form main lps log in
                    Else
                        MsgBox("Invalid email or password. Please try again.")
                    End If
                    txtEmailLogin.Clear()
                    txtPasswordLogin.Clear()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    mycon.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnShow_CheckedChanged(sender As Object, e As EventArgs) Handles btnShow.CheckedChanged
        If btnCreate.Checked = True Then
            txtPasswordLogin.UseSystemPasswordChar = False
        ElseIf btnCreate.Checked = False Then
            txtPasswordLogin.PasswordChar = "*"

        End If
    End Sub
End Class