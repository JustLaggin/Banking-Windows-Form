﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtbox_username = New TextBox()
        txtbbox_password = New TextBox()
        btn_login = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtbox_username
        ' 
        txtbox_username.Location = New Point(226, 97)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.PlaceholderText = "Username"
        txtbox_username.Size = New Size(100, 23)
        txtbox_username.TabIndex = 0
        ' 
        ' txtbbox_password
        ' 
        txtbbox_password.Location = New Point(226, 159)
        txtbbox_password.Name = "txtbbox_password"
        txtbbox_password.PlaceholderText = "Password"
        txtbbox_password.Size = New Size(100, 23)
        txtbbox_password.TabIndex = 1
        ' 
        ' btn_login
        ' 
        btn_login.Location = New Point(235, 242)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(75, 23)
        btn_login.TabIndex = 2
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(178, 311)
        Button1.Name = "Button1"
        Button1.Size = New Size(199, 23)
        Button1.TabIndex = 3
        Button1.Text = "Create New Account"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' form_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(btn_login)
        Controls.Add(txtbbox_password)
        Controls.Add(txtbox_username)
        Name = "form_login"
        Text = "BANKING APP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents txtbbox_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Button1 As Button

End Class
