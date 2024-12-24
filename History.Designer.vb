<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        dgv_history = New DataGridView()
        CType(dgv_history, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_history
        ' 
        dgv_history.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_history.Location = New Point(102, 169)
        dgv_history.Margin = New Padding(4, 5, 4, 5)
        dgv_history.Name = "dgv_history"
        dgv_history.RowHeadersWidth = 62
        dgv_history.Size = New Size(904, 539)
        dgv_history.TabIndex = 0
        ' 
        ' History
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Black_Aesthetic_Motivational_Quote_Your_Story__7_
        ClientSize = New Size(1143, 851)
        Controls.Add(dgv_history)
        Margin = New Padding(4, 5, 4, 5)
        Name = "History"
        Text = "History"
        CType(dgv_history, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_history As DataGridView
End Class
