Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class UserForm
    Public id
    Public mybalance
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
                mybalance = READER.GetInt32("balance")
                Lbl_AvailBal.Text = mybalance
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub btn_withdraw_Click(sender As Object, e As EventArgs) Handles btn_withdraw.Click
        Dim change = InputBox("Please enter Amount:", "Withdraw", "")
        If change = "" Then change = 0
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Dim balance
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM banking_database.userinfo where id='" & id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                balance = READER.GetInt32("balance")
                balance -= change
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim Query As String
            Query = "Update banking_database.userinfo SET balance='" & balance & "' where id='" & id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim Query As String
            Dim Timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Query = "insert into banking_database.historyinfo (id,amount,action,receiver,time) Values (" & id & " , -" & change & ", 'Withdraw' , 'Self','" & Timestamp & "')"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Me.reloadform()
    End Sub

    Private Sub btn_deposit_Click(sender As Object, e As EventArgs) Handles btn_deposit.Click
        Dim change = InputBox("Please enter Amount:", "Deposit", "")
        If change = "" Then change = 0
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Dim balance
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT balance FROM banking_database.userinfo where id='" & id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                balance = READER.GetInt32("balance")
                balance += change
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim Query As String
            Query = "Update banking_database.userinfo SET balance='" & balance & "' where id='" & id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim Query As String
            Dim Timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Query = "insert into banking_database.historyinfo (id,amount,action,receiver,time) Values (" & id & " , +" & change & ", 'Deposit' , 'Self','" & Timestamp & "')"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Me.reloadform()
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadform()
    End Sub

    Private Sub btn_transfer_Click(sender As Object, e As EventArgs) Handles btn_transfer.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Dim balance
        Dim checkid = InputBox("Please enter Id:", "Select Reciever", "")
        Dim change
        If checkid = "" Then checkid = -1
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM banking_database.userinfo where id='" & checkid & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                change = InputBox("Please enter amount:", "Select Amount", "")
                If change = "" Then change = 0
                mybalance -= change
                READER.Close()
                Query = "Update banking_database.userinfo SET balance='" & mybalance & "' where id='" & id & "'"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                READER.Close()

                Query = "SELECT balance FROM banking_database.userinfo where id='" & checkid & "'"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                While READER.Read
                    balance = READER.GetInt32("balance")
                    balance += change
                End While
                READER.Close()
                Query = "Update banking_database.userinfo SET balance='" & balance & "' where id='" & checkid & "'"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim Query As String
            Dim Timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Query = "insert into banking_database.historyinfo (id,amount,action,receiver,time) Values (" & id & " , " & change & ", 'Withdraw' ," & checkid & " ,'" & Timestamp & "')"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        reloadform()
    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        If History.Visible = False Then
            History.Show()
        End If

    End Sub
End Class