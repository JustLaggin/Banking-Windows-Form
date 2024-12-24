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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        btn_withdraw = New Button()
        btn_deposit = New Button()
        Label1 = New Label()
        btn_history = New Button()
        btn_transfer = New Button()
        Lbl_AvailBal = New Label()
        btn_logout = New Button()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_withdraw
        ' 
        btn_withdraw.BackColor = Color.Black
        btn_withdraw.BackgroundImageLayout = ImageLayout.None
        btn_withdraw.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_withdraw.ForeColor = SystemColors.ButtonFace
        btn_withdraw.Location = New Point(589, 647)
        btn_withdraw.Margin = New Padding(4, 5, 4, 5)
        btn_withdraw.Name = "btn_withdraw"
        btn_withdraw.Size = New Size(194, 75)
        btn_withdraw.TabIndex = 0
        btn_withdraw.Text = "Withdraw"
        btn_withdraw.UseVisualStyleBackColor = False
        ' 
        ' btn_deposit
        ' 
        btn_deposit.BackColor = SystemColors.ActiveCaptionText
        btn_deposit.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_deposit.ForeColor = SystemColors.ButtonFace
        btn_deposit.ImageAlign = ContentAlignment.BottomLeft
        btn_deposit.Location = New Point(795, 647)
        btn_deposit.Margin = New Padding(4, 5, 4, 5)
        btn_deposit.Name = "btn_deposit"
        btn_deposit.Size = New Size(194, 75)
        btn_deposit.TabIndex = 1
        btn_deposit.Text = "Deposit"
        btn_deposit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(799, 330)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 27)
        Label1.TabIndex = 4
        Label1.Text = "Available Balance"
        ' 
        ' btn_history
        ' 
        btn_history.BackColor = SystemColors.ActiveCaptionText
        btn_history.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_history.ForeColor = SystemColors.ButtonFace
        btn_history.Location = New Point(358, 35)
        btn_history.Margin = New Padding(4, 5, 4, 5)
        btn_history.Name = "btn_history"
        btn_history.Size = New Size(146, 38)
        btn_history.TabIndex = 7
        btn_history.Text = "History"
        btn_history.UseVisualStyleBackColor = False
        ' 
        ' btn_transfer
        ' 
        btn_transfer.BackColor = SystemColors.ActiveCaptionText
        btn_transfer.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_transfer.ForeColor = SystemColors.ButtonFace
        btn_transfer.Location = New Point(1004, 647)
        btn_transfer.Margin = New Padding(4, 5, 4, 5)
        btn_transfer.Name = "btn_transfer"
        btn_transfer.Size = New Size(194, 75)
        btn_transfer.TabIndex = 9
        btn_transfer.Text = "Transfer"
        btn_transfer.UseVisualStyleBackColor = False
        ' 
        ' Lbl_AvailBal
        ' 
        Lbl_AvailBal.AutoSize = True
        Lbl_AvailBal.BackColor = Color.Transparent
        Lbl_AvailBal.Font = New Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_AvailBal.ForeColor = SystemColors.Control
        Lbl_AvailBal.Location = New Point(809, 245)
        Lbl_AvailBal.Margin = New Padding(2, 0, 2, 0)
        Lbl_AvailBal.Name = "Lbl_AvailBal"
        Lbl_AvailBal.Size = New Size(179, 81)
        Lbl_AvailBal.TabIndex = 11
        Lbl_AvailBal.Text = "2000"
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = SystemColors.ActiveCaptionText
        btn_logout.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_logout.ForeColor = SystemColors.ButtonFace
        btn_logout.Location = New Point(1274, 951)
        btn_logout.Margin = New Padding(4, 5, 4, 5)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(138, 66)
        btn_logout.TabIndex = 12
        btn_logout.Text = "Logout"
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(765, 266)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 55)
        Label2.TabIndex = 13
        Label2.Text = "₱"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Control
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(795, 443)
        PictureBox2.Margin = New Padding(4, 4, 4, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(194, 195)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(589, 443)
        PictureBox3.Margin = New Padding(4, 4, 4, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(194, 195)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1004, 443)
        PictureBox4.Margin = New Padding(4, 4, 4, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(194, 195)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Black_Aesthetic_Motivational_Quote_Your_Story__7_
        ClientSize = New Size(1432, 1010)
        Controls.Add(btn_logout)
        Controls.Add(Lbl_AvailBal)
        Controls.Add(btn_transfer)
        Controls.Add(btn_history)
        Controls.Add(Label1)
        Controls.Add(btn_deposit)
        Controls.Add(btn_withdraw)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UserForm"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "Banking APP"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_withdraw As Button
    Friend WithEvents btn_deposit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_rewards As Button
    Friend WithEvents btn_credit As Button
    Friend WithEvents btn_history As Button
    Friend WithEvents btn_invest As Button
    Friend WithEvents btn_transfer As Button
    Friend WithEvents Lbl_AvailBal As Label
    Friend WithEvents btn_logout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
