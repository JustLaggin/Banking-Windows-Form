<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btn_create = New Button()
        txtbox_firstname = New TextBox()
        txtbox_lastname = New TextBox()
        txtbox_address = New TextBox()
        datepicker_dob = New DateTimePicker()
        txtbox_username = New TextBox()
        txtbox_password = New TextBox()
        txtbox_confirmpass = New TextBox()
        SuspendLayout()
        ' 
        ' btn_create
        ' 
        btn_create.Location = New Point(167, 320)
        btn_create.Name = "btn_create"
        btn_create.Size = New Size(158, 23)
        btn_create.TabIndex = 0
        btn_create.Text = "Create acc"
        btn_create.UseVisualStyleBackColor = True
        ' 
        ' txtbox_firstname
        ' 
        txtbox_firstname.Location = New Point(167, 117)
        txtbox_firstname.Name = "txtbox_firstname"
        txtbox_firstname.PlaceholderText = "Firstname"
        txtbox_firstname.Size = New Size(158, 23)
        txtbox_firstname.TabIndex = 1
        ' 
        ' txtbox_lastname
        ' 
        txtbox_lastname.Location = New Point(167, 146)
        txtbox_lastname.Name = "txtbox_lastname"
        txtbox_lastname.PlaceholderText = "Lastname"
        txtbox_lastname.Size = New Size(158, 23)
        txtbox_lastname.TabIndex = 3
        ' 
        ' txtbox_address
        ' 
        txtbox_address.Location = New Point(167, 175)
        txtbox_address.Name = "txtbox_address"
        txtbox_address.PlaceholderText = "address"
        txtbox_address.Size = New Size(158, 23)
        txtbox_address.TabIndex = 5
        ' 
        ' datepicker_dob
        ' 
        datepicker_dob.CustomFormat = "yyyy.MM.dd"
        datepicker_dob.Format = DateTimePickerFormat.Custom
        datepicker_dob.Location = New Point(167, 204)
        datepicker_dob.Name = "datepicker_dob"
        datepicker_dob.Size = New Size(158, 23)
        datepicker_dob.TabIndex = 6
        datepicker_dob.Value = New Date(2024, 12, 7, 13, 45, 48, 0)
        ' 
        ' txtbox_username
        ' 
        txtbox_username.Location = New Point(167, 233)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.PlaceholderText = "username"
        txtbox_username.Size = New Size(158, 23)
        txtbox_username.TabIndex = 7
        ' 
        ' txtbox_password
        ' 
        txtbox_password.Location = New Point(167, 262)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PlaceholderText = "password"
        txtbox_password.Size = New Size(158, 23)
        txtbox_password.TabIndex = 8
        ' 
        ' txtbox_confirmpass
        ' 
        txtbox_confirmpass.Location = New Point(167, 291)
        txtbox_confirmpass.Name = "txtbox_confirmpass"
        txtbox_confirmpass.PlaceholderText = "confirm password"
        txtbox_confirmpass.Size = New Size(158, 23)
        txtbox_confirmpass.TabIndex = 9
        ' 
        ' NewForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtbox_confirmpass)
        Controls.Add(txtbox_password)
        Controls.Add(txtbox_username)
        Controls.Add(datepicker_dob)
        Controls.Add(txtbox_address)
        Controls.Add(txtbox_lastname)
        Controls.Add(txtbox_firstname)
        Controls.Add(btn_create)
        Name = "NewForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_create As Button
    Friend WithEvents txtbox_firstname As TextBox
    Friend WithEvents txtbox_lastname As TextBox
    Friend WithEvents txtbox_address As TextBox
    Friend WithEvents datepicker_dob As DateTimePicker
    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents txtbox_confirmpass As TextBox
End Class
