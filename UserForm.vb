Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class UserForm
    Public id
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub reloadform()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Dim newbalance
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT balance FROM banking_database.userinfo where id='" & id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim balance = READER.GetInt32("balance")
                Lbl_AvailBal.Text = balance
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        tempbox1.Clear()
    End Sub
    Private Sub btn_withdraw_Click(sender As Object, e As EventArgs) Handles btn_withdraw.Click
        Dim change = InputBox("Please enter Amount:", "Withdraw", "")
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Dim newbalance
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM banking_database.userinfo where id='" & id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim balance = READER.GetInt32("balance")
                newbalance = balance - change
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim Query As String
            Query = "Update banking_database.userinfo SET balance='" & newbalance & "' where id='" & id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data updated")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Me.reloadform()
    End Sub

    Private Sub btn_deposit_Click(sender As Object, e As EventArgs) Handles btn_deposit.Click
        Dim change = InputBox("Please enter Amount:", "Deposit", "")
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Dim newbalance
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT balance FROM banking_database.userinfo where id='" & id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim balance = READER.GetInt32("balance")
                newbalance = balance + change
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim Query As String
            Query = "Update banking_database.userinfo SET balance='" & newbalance & "' where id='" & id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data updated")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Me.reloadform()
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Dim newbalance
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT balance FROM banking_database.userinfo where id='" & id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim balance = READER.GetInt32("balance")
                Lbl_AvailBal.Text = balance
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub


End Class