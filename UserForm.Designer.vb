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
        btn_Loan = New Button()
        Label1 = New Label()
        btn_rewards = New Button()
        btn_credit = New Button()
        btn_history = New Button()
        btn_invest = New Button()
        btn_transfer = New Button()
        btn_bills = New Button()
        Lbl_AvailBal = New Label()
        SuspendLayout()
        ' 
        ' btn_withdraw
        ' 
        btn_withdraw.BackColor = Color.Black
        btn_withdraw.BackgroundImageLayout = ImageLayout.None
        btn_withdraw.ForeColor = SystemColors.ButtonFace
        btn_withdraw.Location = New Point(22, 201)
        btn_withdraw.Name = "btn_withdraw"
        btn_withdraw.Size = New Size(75, 23)
        btn_withdraw.TabIndex = 0
        btn_withdraw.Text = "Withdraw"
        btn_withdraw.UseVisualStyleBackColor = False
        ' 
        ' btn_deposit
        ' 
        btn_deposit.BackColor = SystemColors.ActiveCaptionText
        btn_deposit.ForeColor = SystemColors.ButtonFace
        btn_deposit.Location = New Point(132, 201)
        btn_deposit.Name = "btn_deposit"
        btn_deposit.Size = New Size(75, 23)
        btn_deposit.TabIndex = 1
        btn_deposit.Text = "Deposit"
        btn_deposit.UseVisualStyleBackColor = False
        ' 
        ' btn_Loan
        ' 
        btn_Loan.BackColor = SystemColors.ActiveCaptionText
        btn_Loan.ForeColor = SystemColors.ButtonFace
        btn_Loan.Location = New Point(132, 392)
        btn_Loan.Name = "btn_Loan"
        btn_Loan.Size = New Size(75, 23)
        btn_Loan.TabIndex = 2
        btn_Loan.Text = "Loan"
        btn_Loan.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(22, 88)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 22)
        Label1.TabIndex = 4
        Label1.Text = "Available Balance"
        ' 
        ' btn_rewards
        ' 
        btn_rewards.BackColor = SystemColors.ActiveCaptionText
        btn_rewards.ForeColor = SystemColors.ButtonFace
        btn_rewards.Location = New Point(246, 299)
        btn_rewards.Name = "btn_rewards"
        btn_rewards.Size = New Size(75, 23)
        btn_rewards.TabIndex = 5
        btn_rewards.Text = "Rewards"
        btn_rewards.UseVisualStyleBackColor = False
        ' 
        ' btn_credit
        ' 
        btn_credit.BackColor = SystemColors.ActiveCaptionText
        btn_credit.ForeColor = SystemColors.ButtonFace
        btn_credit.Location = New Point(132, 299)
        btn_credit.Name = "btn_credit"
        btn_credit.Size = New Size(75, 23)
        btn_credit.TabIndex = 6
        btn_credit.Text = "Credit"
        btn_credit.UseVisualStyleBackColor = False
        ' 
        ' btn_history
        ' 
        btn_history.BackColor = SystemColors.ActiveCaptionText
        btn_history.ForeColor = SystemColors.ButtonFace
        btn_history.Location = New Point(22, 299)
        btn_history.Name = "btn_history"
        btn_history.Size = New Size(75, 23)
        btn_history.TabIndex = 7
        btn_history.Text = "History"
        btn_history.UseVisualStyleBackColor = False
        ' 
        ' btn_invest
        ' 
        btn_invest.BackColor = SystemColors.ActiveCaptionText
        btn_invest.ForeColor = SystemColors.ButtonFace
        btn_invest.Location = New Point(22, 392)
        btn_invest.Name = "btn_invest"
        btn_invest.Size = New Size(75, 23)
        btn_invest.TabIndex = 8
        btn_invest.Text = "Invest"
        btn_invest.UseVisualStyleBackColor = False
        ' 
        ' btn_transfer
        ' 
        btn_transfer.BackColor = SystemColors.ActiveCaptionText
        btn_transfer.ForeColor = SystemColors.ButtonFace
        btn_transfer.Location = New Point(246, 201)
        btn_transfer.Name = "btn_transfer"
        btn_transfer.Size = New Size(75, 23)
        btn_transfer.TabIndex = 9
        btn_transfer.Text = "Transfer"
        btn_transfer.UseVisualStyleBackColor = False
        ' 
        ' btn_bills
        ' 
        btn_bills.BackColor = SystemColors.ActiveCaptionText
        btn_bills.ForeColor = SystemColors.ButtonFace
        btn_bills.Location = New Point(246, 392)
        btn_bills.Name = "btn_bills"
        btn_bills.Size = New Size(75, 23)
        btn_bills.TabIndex = 10
        btn_bills.Text = "Bills"
        btn_bills.UseVisualStyleBackColor = False
        ' 
        ' Lbl_AvailBal
        ' 
        Lbl_AvailBal.AutoSize = True
        Lbl_AvailBal.Location = New Point(22, 114)
        Lbl_AvailBal.Margin = New Padding(2, 0, 2, 0)
        Lbl_AvailBal.Name = "Lbl_AvailBal"
        Lbl_AvailBal.Size = New Size(41, 15)
        Lbl_AvailBal.TabIndex = 11
        Lbl_AvailBal.Text = "Label2"
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Black_Aesthetic_Motivational_Quote_Your_Story__4_
        ClientSize = New Size(384, 577)
        Controls.Add(Lbl_AvailBal)
        Controls.Add(btn_bills)
        Controls.Add(btn_transfer)
        Controls.Add(btn_invest)
        Controls.Add(btn_history)
        Controls.Add(btn_credit)
        Controls.Add(btn_rewards)
        Controls.Add(Label1)
        Controls.Add(btn_Loan)
        Controls.Add(btn_deposit)
        Controls.Add(btn_withdraw)
        Name = "UserForm"
        Text = "Banking APP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_withdraw As Button
    Friend WithEvents btn_deposit As Button
    Friend WithEvents btn_Loan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_rewards As Button
    Friend WithEvents btn_credit As Button
    Friend WithEvents btn_history As Button
    Friend WithEvents btn_invest As Button
    Friend WithEvents btn_transfer As Button
    Friend WithEvents btn_bills As Button
    Friend WithEvents Lbl_AvailBal As Label
End Class
