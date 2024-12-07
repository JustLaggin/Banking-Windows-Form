Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class NewForm
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            If txtbox_password.Text = txtbox_confirmpass.Text Then
                Query = "INSERT INTO banking_database.userinfo (id,firstname,lastname,birthday,address) Values ((Select COALESCE(MAX(id), 0) + 1 FROM logininfo), '" & txtbox_firstname.Text & "' ,'" & txtbox_lastname.Text & "' , '" & datepicker_dob.Text & "' , '" & txtbox_address.Text & "')"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                READER.Close()
                Query = "INSERT INTO banking_database.logininfo (id,username,password) Values ((SELECT COALESCE(MAX(id), 0) FROM userinfo),'" & txtbox_username.Text & "' ,'" & txtbox_password.Text & "')"
                COMMAND = New MySqlCommand(Query, conn)
                Reader = COMMAND.ExecuteReader
                conn.Close()

                UserForm.Show()
                Me.Close()
            Else
                MessageBox.Show("Password Doesn't Match")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub


End Class