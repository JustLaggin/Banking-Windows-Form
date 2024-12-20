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
        btn_history = New Button()
        btn_transfer = New Button()
        btn_bills = New Button()
        Lbl_AvailBal = New Label()
        btn_logout = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btn_withdraw
        ' 
        btn_withdraw.BackColor = Color.Black
        btn_withdraw.BackgroundImageLayout = ImageLayout.None
        btn_withdraw.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_withdraw.ForeColor = SystemColors.ButtonFace
        btn_withdraw.Location = New Point(186, 269)
        btn_withdraw.Name = "btn_withdraw"
        btn_withdraw.Size = New Size(158, 107)
        btn_withdraw.TabIndex = 0
        btn_withdraw.Text = "Withdraw"
        btn_withdraw.UseVisualStyleBackColor = False
        ' 
        ' btn_deposit
        ' 
        btn_deposit.BackColor = SystemColors.ActiveCaptionText
        btn_deposit.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_deposit.ForeColor = SystemColors.ButtonFace
        btn_deposit.ImageAlign = ContentAlignment.BottomLeft
        btn_deposit.Location = New Point(22, 269)
        btn_deposit.Name = "btn_deposit"
        btn_deposit.Size = New Size(158, 107)
        btn_deposit.TabIndex = 1
        btn_deposit.Text = "Deposit"
        btn_deposit.UseVisualStyleBackColor = False
        ' 
        ' btn_Loan
        ' 
        btn_Loan.BackColor = SystemColors.ActiveCaptionText
        btn_Loan.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Loan.ForeColor = SystemColors.ButtonFace
        btn_Loan.Location = New Point(22, 428)
        btn_Loan.Name = "btn_Loan"
        btn_Loan.Size = New Size(158, 107)
        btn_Loan.TabIndex = 2
        btn_Loan.Text = "Loan"
        btn_Loan.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(208, 199)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 19)
        Label1.TabIndex = 4
        Label1.Text = "Available Balance"
        ' 
        ' btn_history
        ' 
        btn_history.BackColor = SystemColors.ActiveCaptionText
        btn_history.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_history.ForeColor = SystemColors.ButtonFace
        btn_history.Location = New Point(350, 428)
        btn_history.Name = "btn_history"
        btn_history.Size = New Size(153, 107)
        btn_history.TabIndex = 7
        btn_history.Text = "History"
        btn_history.UseVisualStyleBackColor = False
        ' 
        ' btn_transfer
        ' 
        btn_transfer.BackColor = SystemColors.ActiveCaptionText
        btn_transfer.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_transfer.ForeColor = SystemColors.ButtonFace
        btn_transfer.Location = New Point(350, 269)
        btn_transfer.Name = "btn_transfer"
        btn_transfer.Size = New Size(153, 107)
        btn_transfer.TabIndex = 9
        btn_transfer.Text = "Transfer"
        btn_transfer.UseVisualStyleBackColor = False
        ' 
        ' btn_bills
        ' 
        btn_bills.BackColor = SystemColors.ActiveCaptionText
        btn_bills.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_bills.ForeColor = SystemColors.ButtonFace
        btn_bills.Location = New Point(186, 428)
        btn_bills.Name = "btn_bills"
        btn_bills.Size = New Size(158, 107)
        btn_bills.TabIndex = 10
        btn_bills.Text = "Bills"
        btn_bills.UseVisualStyleBackColor = False
        ' 
        ' Lbl_AvailBal
        ' 
        Lbl_AvailBal.AutoSize = True
        Lbl_AvailBal.BackColor = Color.Transparent
        Lbl_AvailBal.Font = New Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_AvailBal.ForeColor = SystemColors.Control
        Lbl_AvailBal.Location = New Point(208, 144)
        Lbl_AvailBal.Margin = New Padding(2, 0, 2, 0)
        Lbl_AvailBal.Name = "Lbl_AvailBal"
        Lbl_AvailBal.Size = New Size(120, 55)
        Lbl_AvailBal.TabIndex = 11
        Lbl_AvailBal.Text = "2000"
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = SystemColors.ActiveCaptionText
        btn_logout.ForeColor = SystemColors.ButtonFace
        btn_logout.Location = New Point(397, 595)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(96, 40)
        btn_logout.TabIndex = 12
        btn_logout.Text = "Logout"
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(176, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 37)
        Label2.TabIndex = 13
        Label2.Text = "₱"
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Black_Aesthetic_Motivational_Quote_Your_Story__4_
        ClientSize = New Size(515, 647)
        Controls.Add(btn_logout)
        Controls.Add(Lbl_AvailBal)
        Controls.Add(btn_bills)
        Controls.Add(btn_transfer)
        Controls.Add(btn_history)
        Controls.Add(Label1)
        Controls.Add(btn_Loan)
        Controls.Add(btn_deposit)
        Controls.Add(btn_withdraw)
        Controls.Add(Label2)
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
    Friend WithEvents btn_logout As Button
    Friend WithEvents Label2 As Label
End Class
