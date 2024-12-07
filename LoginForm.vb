Imports MySql.Data.MySqlClient

Public Class form_login
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM logininfo WHERE username = '" & txtbox_username.Text & "' AND password = '" & txtbox_password.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                UserForm.Show()
                Me.Close()
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are duplicate!")
            Else
                MessageBox.Show("Username and password are incorrect!")
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewForm.Show()
        Me.Close()
    End Sub

    Private Sub Txtbox_password_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txtbox_password.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            btn_login.PerformClick()
            e.Handled = True
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
