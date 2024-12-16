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
        tempbox1 = New TextBox()
        Label1 = New Label()
        btn_rewards = New Button()
        btn_credit = New Button()
        btn_savings = New Button()
        btn_invest = New Button()
        btn_transfer = New Button()
        btn_bills = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btn_withdraw
        ' 
        btn_withdraw.BackColor = Color.Black
        btn_withdraw.BackgroundImageLayout = ImageLayout.None
        btn_withdraw.ForeColor = SystemColors.ButtonFace
        btn_withdraw.Location = New Point(32, 335)
        btn_withdraw.Margin = New Padding(4, 5, 4, 5)
        btn_withdraw.Name = "btn_withdraw"
        btn_withdraw.Size = New Size(107, 38)
        btn_withdraw.TabIndex = 0
        btn_withdraw.Text = "Withdraw"
        btn_withdraw.UseVisualStyleBackColor = False
        ' 
        ' btn_deposit
        ' 
        btn_deposit.BackColor = SystemColors.ActiveCaptionText
        btn_deposit.ForeColor = SystemColors.ButtonFace
        btn_deposit.Location = New Point(189, 335)
        btn_deposit.Margin = New Padding(4, 5, 4, 5)
        btn_deposit.Name = "btn_deposit"
        btn_deposit.Size = New Size(107, 38)
        btn_deposit.TabIndex = 1
        btn_deposit.Text = "Deposit"
        btn_deposit.UseVisualStyleBackColor = False
        ' 
        ' btn_Loan
        ' 
        btn_Loan.BackColor = SystemColors.ActiveCaptionText
        btn_Loan.ForeColor = SystemColors.ButtonFace
        btn_Loan.Location = New Point(351, 335)
        btn_Loan.Margin = New Padding(4, 5, 4, 5)
        btn_Loan.Name = "btn_Loan"
        btn_Loan.Size = New Size(107, 38)
        btn_Loan.TabIndex = 2
        btn_Loan.Text = "Loan"
        btn_Loan.UseVisualStyleBackColor = False
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
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(32, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 32)
        Label1.TabIndex = 4
        Label1.Text = "Available Balance"
        ' 
        ' btn_rewards
        ' 
        btn_rewards.BackColor = SystemColors.ActiveCaptionText
        btn_rewards.ForeColor = SystemColors.ButtonFace
        btn_rewards.Location = New Point(32, 499)
        btn_rewards.Margin = New Padding(4, 5, 4, 5)
        btn_rewards.Name = "btn_rewards"
        btn_rewards.Size = New Size(107, 38)
        btn_rewards.TabIndex = 5
        btn_rewards.Text = "Rewards"
        btn_rewards.UseVisualStyleBackColor = False
        ' 
        ' btn_credit
        ' 
        btn_credit.BackColor = SystemColors.ActiveCaptionText
        btn_credit.ForeColor = SystemColors.ButtonFace
        btn_credit.Location = New Point(189, 499)
        btn_credit.Margin = New Padding(4, 5, 4, 5)
        btn_credit.Name = "btn_credit"
        btn_credit.Size = New Size(107, 38)
        btn_credit.TabIndex = 6
        btn_credit.Text = "Credit"
        btn_credit.UseVisualStyleBackColor = False
        ' 
        ' btn_savings
        ' 
        btn_savings.BackColor = SystemColors.ActiveCaptionText
        btn_savings.ForeColor = SystemColors.ButtonFace
        btn_savings.Location = New Point(351, 499)
        btn_savings.Margin = New Padding(4, 5, 4, 5)
        btn_savings.Name = "btn_savings"
        btn_savings.Size = New Size(107, 38)
        btn_savings.TabIndex = 7
        btn_savings.Text = "Savings"
        btn_savings.UseVisualStyleBackColor = False
        ' 
        ' btn_invest
        ' 
        btn_invest.BackColor = SystemColors.ActiveCaptionText
        btn_invest.ForeColor = SystemColors.ButtonFace
        btn_invest.Location = New Point(32, 653)
        btn_invest.Margin = New Padding(4, 5, 4, 5)
        btn_invest.Name = "btn_invest"
        btn_invest.Size = New Size(107, 38)
        btn_invest.TabIndex = 8
        btn_invest.Text = "Invest"
        btn_invest.UseVisualStyleBackColor = False
        ' 
        ' btn_transfer
        ' 
        btn_transfer.BackColor = SystemColors.ActiveCaptionText
        btn_transfer.ForeColor = SystemColors.ButtonFace
        btn_transfer.Location = New Point(189, 653)
        btn_transfer.Margin = New Padding(4, 5, 4, 5)
        btn_transfer.Name = "btn_transfer"
        btn_transfer.Size = New Size(107, 38)
        btn_transfer.TabIndex = 9
        btn_transfer.Text = "Transfer"
        btn_transfer.UseVisualStyleBackColor = False
        ' 
        ' btn_bills
        ' 
        btn_bills.BackColor = SystemColors.ActiveCaptionText
        btn_bills.ForeColor = SystemColors.ButtonFace
        btn_bills.Location = New Point(351, 653)
        btn_bills.Margin = New Padding(4, 5, 4, 5)
        btn_bills.Name = "btn_bills"
        btn_bills.Size = New Size(107, 38)
        btn_bills.TabIndex = 10
        btn_bills.Text = "Bills"
        btn_bills.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 25)
        Label2.TabIndex = 11
        Label2.Text = "Label2"
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Black_Aesthetic_Motivational_Quote_Your_Story__4_
        ClientSize = New Size(548, 962)
        Controls.Add(Label2)
        Controls.Add(btn_bills)
        Controls.Add(btn_transfer)
        Controls.Add(btn_invest)
        Controls.Add(btn_savings)
        Controls.Add(btn_credit)
        Controls.Add(btn_rewards)
        Controls.Add(Label1)
        Controls.Add(tempbox1)
        Controls.Add(btn_Loan)
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
    Friend WithEvents btn_Loan As Button
    Friend WithEvents tempbox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_rewards As Button
    Friend WithEvents btn_credit As Button
    Friend WithEvents btn_savings As Button
    Friend WithEvents btn_invest As Button
    Friend WithEvents btn_transfer As Button
    Friend WithEvents btn_bills As Button
    Friend WithEvents Label2 As Label
End Class
