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
        SuspendLayout()
        ' 
        ' btn_withdraw
        ' 
        btn_withdraw.Location = New Point(136, 191)
        btn_withdraw.Name = "btn_withdraw"
        btn_withdraw.Size = New Size(75, 23)
        btn_withdraw.TabIndex = 0
        btn_withdraw.Text = "Withdraw"
        btn_withdraw.UseVisualStyleBackColor = True
        ' 
        ' btn_deposit
        ' 
        btn_deposit.Location = New Point(243, 191)
        btn_deposit.Name = "btn_deposit"
        btn_deposit.Size = New Size(75, 23)
        btn_deposit.TabIndex = 1
        btn_deposit.Text = "Deposit"
        btn_deposit.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(345, 191)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 2
        Button3.Text = "loan"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' tempbox1
        ' 
        tempbox1.Location = New Point(136, 162)
        tempbox1.Name = "tempbox1"
        tempbox1.Size = New Size(284, 23)
        tempbox1.TabIndex = 3
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tempbox1)
        Controls.Add(Button3)
        Controls.Add(btn_deposit)
        Controls.Add(btn_withdraw)
        Name = "UserForm"
        Text = "Banking APP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_withdraw As Button
    Friend WithEvents btn_deposit As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents tempbox1 As TextBox
End Class
