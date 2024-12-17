<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        txtbox_password = New TextBox()
        btn_login = New Button()
        btn_NewAcc = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtbox_username
        ' 
        txtbox_username.Location = New Point(91, 163)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.PlaceholderText = "Type your username"
        txtbox_username.Size = New Size(200, 23)
        txtbox_username.TabIndex = 0
        ' 
        ' txtbox_password
        ' 
        txtbox_password.Location = New Point(91, 230)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PlaceholderText = "Type your password"
        txtbox_password.Size = New Size(200, 23)
        txtbox_password.TabIndex = 1
        txtbox_password.UseSystemPasswordChar = True
        ' 
        ' btn_login
        ' 
        btn_login.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_login.Location = New Point(91, 286)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(199, 23)
        btn_login.TabIndex = 2
        btn_login.Text = "LOGIN"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' btn_NewAcc
        ' 
        btn_NewAcc.Location = New Point(91, 494)
        btn_NewAcc.Name = "btn_NewAcc"
        btn_NewAcc.Size = New Size(199, 23)
        btn_NewAcc.TabIndex = 3
        btn_NewAcc.Text = "Create New Account"
        btn_NewAcc.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(80, 139)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 25)
        Label1.TabIndex = 4
        Label1.Text = "Username"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(80, 206)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 25)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(80, 467)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 19)
        Label3.TabIndex = 6
        Label3.Text = "Don't have an account?"
        ' 
        ' form_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Black_Aesthetic_Motivational_Quote_Your_Story__4_
        ClientSize = New Size(380, 578)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_NewAcc)
        Controls.Add(btn_login)
        Controls.Add(txtbox_password)
        Controls.Add(txtbox_username)
        Name = "form_login"
        Text = "BANKING APP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_NewAcc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
