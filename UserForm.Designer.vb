<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        btn_withdraw = New Button()
        btn_deposit = New Button()
        Button3 = New Button()
        tempbox1 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btn_withdraw
        ' 
        btn_withdraw.Location = New Point(32, 335)
        btn_withdraw.Margin = New Padding(4, 5, 4, 5)
        btn_withdraw.Name = "btn_withdraw"
        btn_withdraw.Size = New Size(107, 38)
        btn_withdraw.TabIndex = 0
        btn_withdraw.Text = "Withdraw"
        btn_withdraw.UseVisualStyleBackColor = True
        ' 
        ' btn_deposit
        ' 
        btn_deposit.Location = New Point(189, 335)
        btn_deposit.Margin = New Padding(4, 5, 4, 5)
        btn_deposit.Name = "btn_deposit"
        btn_deposit.Size = New Size(107, 38)
        btn_deposit.TabIndex = 1
        btn_deposit.Text = "Deposit"
        btn_deposit.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(351, 335)
        Button3.Margin = New Padding(4, 5, 4, 5)
        Button3.Name = "Button3"
        Button3.Size = New Size(107, 38)
        Button3.TabIndex = 2
        Button3.Text = "loan"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' tempbox1
        ' 
        tempbox1.Location = New Point(32, 229)
        tempbox1.Margin = New Padding(4, 5, 4, 5)
        tempbox1.Name = "tempbox1"
        tempbox1.Size = New Size(426, 31)
        tempbox1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Black_Aesthetic_Motivational_Quote_Your_Story__4_
        ClientSize = New Size(543, 962)
        Controls.Add(Label1)
        Controls.Add(tempbox1)
        Controls.Add(Button3)
        Controls.Add(btn_deposit)
        Controls.Add(btn_withdraw)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UserForm"
        Text = "Banking APP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_withdraw As Button
    Friend WithEvents btn_deposit As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents tempbox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
