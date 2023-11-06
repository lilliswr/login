Imports Guna.UI2.AnimatorNS
Imports Guna.UI2.WinForms
Imports System.Data.OleDb
Imports System.Text

Public Class CreateForm


    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Kembara.accdb") ' nnti masuk db

    Private Sub LblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click

        Me.Hide()
        LoginForm.Show()
    End Sub









    Private Sub txtEmailCreate_GotFocus(sender As Object, e As EventArgs) Handles txtEmailCreate.GotFocus

        If txtEmailCreate.Text = "E-mail" Then
            txtEmailCreate.Text = ""
            txtEmailCreate.ForeColor = Color.Black
        End If
    End Sub



    Private Sub txtemailCreate_LostFocus(sender As Object, e As EventArgs) Handles txtEmailCreate.LostFocus
        If txtEmailCreate.Text = "" Then
            txtEmailCreate.Text = "E-mail"
            txtEmailCreate.ForeColor = Color.DarkGray
        End If
    End Sub


    Private Sub txtdob_GotFocus(sender As Object, e As EventArgs) Handles txtDOB.GotFocus
        If txtDOB.Text = "Date of Birth" Then
            txtDOB.Text = ""
            txtDOB.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtdob_LostFocus(sender As Object, e As EventArgs) Handles txtDOB.LostFocus
        If txtDOB.Text = "" Then
            txtDOB.Text = "Date of Birth"
            txtDOB.ForeColor = Color.DarkGray
        End If
    End Sub



    Private Sub txtName_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus
        If txtName.Text = "Name" Then
            txtName.Text = ""
            txtName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtName_LostFocus(sender As Object, e As EventArgs) Handles txtName.LostFocus
        If txtName.Text = "" Then
            txtName.Text = "Name"
            txtName.ForeColor = Color.DarkGray
        End If
    End Sub


    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Kembara.accdb" ' Replace dngn db
        Using mycon As New OleDbConnection(connectionString)
            Dim query As String = "INSERT INTO [User]([Email], [USERName], DOB, [Password]) VALUES (@Email, @USERName, @DOB, @Password)"
            Using mycmd As New OleDbCommand(query, mycon)
                mycmd.Parameters.AddWithValue("@Email", txtEmailCreate.Text)
                mycmd.Parameters.AddWithValue("@USERName", txtName.Text)
                mycmd.Parameters.AddWithValue("@DOB", txtDOB.Text)
                mycmd.Parameters.AddWithValue("@Password", txtPasswordCreate.Text)

                Try
                    mycon.Open()
                    mycmd.ExecuteNonQuery()
                    txtEmailCreate.Clear()
                    txtName.Clear()
                    txtDOB.Clear()
                    txtPasswordCreate.Clear()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    mycon.Close()
                End Try
            End Using
        End Using
        MsgBox("YOUR ACCOUNT HAVE BEEN CREATED!")
    End Sub

    Private Sub txtPasswordCreate_GotFocus(sender As Object, e As EventArgs) Handles txtPasswordCreate.GotFocus
        If txtPasswordCreate.Text = "Password" Then
            txtPasswordCreate.Text = ""
            txtPasswordCreate.PasswordChar = ""
            txtPasswordCreate.ForeColor = Color.Black
        End If

        CheckPasswordRequirements()


    End Sub


    Private Sub CheckPasswordRequirements()
        Dim password As String = txtPasswordCreate.Text

        ' Check if the password meets the criteria
        Dim hasUpperCase As Boolean = False
        Dim hasLowerCase As Boolean = False
        Dim hasDigit As Boolean = False
        Dim hasSpecialChar As Boolean = False



        For Each c As Char In password
            If Char.IsUpper(c) Then
                hasUpperCase = True
            ElseIf Char.IsLower(c) Then
                hasLowerCase = True
            ElseIf Char.IsDigit(c) Then
                hasDigit = True
            ElseIf Not Char.IsLetterOrDigit(c) Then
                hasSpecialChar = True
            End If
        Next

        If Not (hasUpperCase AndAlso hasLowerCase AndAlso hasDigit AndAlso hasSpecialChar AndAlso password.Length >= 12) Then
            ' Display a red label indicating that the password does not meet the criteria
            lblPasswordError1.ForeColor = Color.Red
            lblPasswordError1.Text = "Password should be at least 12 characters long 
and contain at least one uppercase letter, 
one lowercase letter, one digit, and one special character."
        Else
            ' Clear the red label if the password meets the criteria
            lblPasswordError1.Text = ""
        End If
    End Sub







End Class