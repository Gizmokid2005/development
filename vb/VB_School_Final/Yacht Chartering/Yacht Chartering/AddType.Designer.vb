<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddType
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblEnterYachtType = New System.Windows.Forms.Label
        Me.txtEnterYacht = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(59, 74)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(140, 74)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblEnterYachtType
        '
        Me.lblEnterYachtType.AutoSize = True
        Me.lblEnterYachtType.Location = New System.Drawing.Point(93, 9)
        Me.lblEnterYachtType.Name = "lblEnterYachtType"
        Me.lblEnterYachtType.Size = New System.Drawing.Size(93, 13)
        Me.lblEnterYachtType.TabIndex = 2
        Me.lblEnterYachtType.Text = "Enter Yacht Type:"
        '
        'txtEnterYacht
        '
        Me.txtEnterYacht.Location = New System.Drawing.Point(59, 35)
        Me.txtEnterYacht.Name = "txtEnterYacht"
        Me.txtEnterYacht.Size = New System.Drawing.Size(156, 20)
        Me.txtEnterYacht.TabIndex = 3
        '
        'AddType
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(269, 115)
        Me.Controls.Add(Me.txtEnterYacht)
        Me.Controls.Add(Me.lblEnterYachtType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddType"
        Me.Text = "Add Yacht Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblEnterYachtType As System.Windows.Forms.Label
    Friend WithEvents txtEnterYacht As System.Windows.Forms.TextBox
End Class
