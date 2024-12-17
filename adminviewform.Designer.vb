<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminviewform
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
        dgv_customers = New DataGridView()
        btn_delete = New Button()
        txtbox_iddelete = New TextBox()
        CType(dgv_customers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_customers
        ' 
        dgv_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_customers.Location = New Point(82, 56)
        dgv_customers.Name = "dgv_customers"
        dgv_customers.Size = New Size(461, 269)
        dgv_customers.TabIndex = 0
        ' 
        ' btn_delete
        ' 
        btn_delete.Location = New Point(82, 331)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(75, 23)
        btn_delete.TabIndex = 1
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' txtbox_iddelete
        ' 
        txtbox_iddelete.Location = New Point(163, 332)
        txtbox_iddelete.Name = "txtbox_iddelete"
        txtbox_iddelete.PlaceholderText = "Input Id Here"
        txtbox_iddelete.Size = New Size(380, 23)
        txtbox_iddelete.TabIndex = 2
        ' 
        ' adminviewform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtbox_iddelete)
        Controls.Add(btn_delete)
        Controls.Add(dgv_customers)
        Name = "adminviewform"
        Text = "adminviewform"
        CType(dgv_customers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_customers As DataGridView
    Friend WithEvents btn_delete As Button
    Friend WithEvents txtbox_iddelete As TextBox
End Class
