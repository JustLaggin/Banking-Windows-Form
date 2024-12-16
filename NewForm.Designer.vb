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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' btn_create
        ' 
        btn_create.Location = New Point(170, 796)
        btn_create.Margin = New Padding(4, 5, 4, 5)
        btn_create.Name = "btn_create"
        btn_create.Size = New Size(212, 38)
        btn_create.TabIndex = 0
        btn_create.Text = "Create an Account"
        btn_create.UseVisualStyleBackColor = True
        ' 
        ' txtbox_firstname
        ' 
        txtbox_firstname.Location = New Point(31, 152)
        txtbox_firstname.Margin = New Padding(4, 5, 4, 5)
        txtbox_firstname.Name = "txtbox_firstname"
        txtbox_firstname.Size = New Size(224, 31)
        txtbox_firstname.TabIndex = 1
        ' 
        ' txtbox_lastname
        ' 
        txtbox_lastname.Location = New Point(278, 152)
        txtbox_lastname.Margin = New Padding(4, 5, 4, 5)
        txtbox_lastname.Name = "txtbox_lastname"
        txtbox_lastname.Size = New Size(224, 31)
        txtbox_lastname.TabIndex = 3
        ' 
        ' txtbox_address
        ' 
        txtbox_address.Location = New Point(43, 363)
        txtbox_address.Margin = New Padding(4, 5, 4, 5)
        txtbox_address.Name = "txtbox_address"
        txtbox_address.PlaceholderText = "address"
        txtbox_address.Size = New Size(459, 31)
        txtbox_address.TabIndex = 5
        ' 
        ' datepicker_dob
        ' 
        datepicker_dob.CustomFormat = "yyyy.MM.dd"
        datepicker_dob.Format = DateTimePickerFormat.Custom
        datepicker_dob.Location = New Point(43, 279)
        datepicker_dob.Margin = New Padding(4, 5, 4, 5)
        datepicker_dob.Name = "datepicker_dob"
        datepicker_dob.Size = New Size(224, 31)
        datepicker_dob.TabIndex = 6
        datepicker_dob.Value = New Date(2024, 12, 7, 13, 45, 48, 0)
        ' 
        ' txtbox_username
        ' 
        txtbox_username.Location = New Point(43, 456)
        txtbox_username.Margin = New Padding(4, 5, 4, 5)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.PlaceholderText = "username"
        txtbox_username.Size = New Size(459, 31)
        txtbox_username.TabIndex = 7
        ' 
        ' txtbox_password
        ' 
        txtbox_password.Location = New Point(43, 548)
        txtbox_password.Margin = New Padding(4, 5, 4, 5)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PlaceholderText = "password"
        txtbox_password.Size = New Size(210, 31)
        txtbox_password.TabIndex = 8
        ' 
        ' txtbox_confirmpass
        ' 
        txtbox_confirmpass.Location = New Point(43, 616)
        txtbox_confirmpass.Margin = New Padding(4, 5, 4, 5)
        txtbox_confirmpass.Name = "txtbox_confirmpass"
        txtbox_confirmpass.PlaceholderText = "confirm password"
        txtbox_confirmpass.Size = New Size(210, 31)
        txtbox_confirmpass.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(31, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 27)
        Label1.TabIndex = 10
        Label1.Text = "First Name"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(278, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 27)
        Label2.TabIndex = 11
        Label2.Text = "Last Name"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(31, 247)
        Label3.Name = "Label3"
        Label3.Size = New Size(198, 27)
        Label3.TabIndex = 12
        Label3.Text = "Enter Date of Birth"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(31, 331)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 27)
        Label4.TabIndex = 13
        Label4.Text = "Enter Address"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(31, 424)
        Label5.Name = "Label5"
        Label5.Size = New Size(191, 27)
        Label5.TabIndex = 14
        Label5.Text = "Create a username"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(31, 516)
        Label6.Name = "Label6"
        Label6.Size = New Size(180, 27)
        Label6.TabIndex = 15
        Label6.Text = "Enter a Password"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(31, 584)
        Label7.Name = "Label7"
        Label7.Size = New Size(190, 27)
        Label7.TabIndex = 16
        Label7.Text = "Confirm Password"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' NewForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Black_Aesthetic_Motivational_Quote_Your_Story__5_
        ClientSize = New Size(544, 960)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtbox_confirmpass)
        Controls.Add(txtbox_password)
        Controls.Add(txtbox_username)
        Controls.Add(datepicker_dob)
        Controls.Add(txtbox_address)
        Controls.Add(txtbox_lastname)
        Controls.Add(txtbox_firstname)
        Controls.Add(btn_create)
        Margin = New Padding(4, 5, 4, 5)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
