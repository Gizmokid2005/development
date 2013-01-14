<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteType
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
        Me.lblEnterYachtType = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.cmbYachtType = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'lblEnterYachtType
        '
        Me.lblEnterYachtType.AutoSize = True
        Me.lblEnterYachtType.Location = New System.Drawing.Point(96, 9)
        Me.lblEnterYachtType.Name = "lblEnterYachtType"
        Me.lblEnterYachtType.Size = New System.Drawing.Size(98, 13)
        Me.lblEnterYachtType.TabIndex = 6
        Me.lblEnterYachtType.Text = "Select Yacht Type:"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(143, 74)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(62, 74)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmbYachtType
        '
        Me.cmbYachtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYachtType.FormattingEnabled = True
        Me.cmbYachtType.Items.AddRange(New Object() {"C & C", "Catalina", "Coronado", "Excalibur", "Hans Christian", "Hobie", "Ranger", "Wavelength"})
        Me.cmbYachtType.Location = New System.Drawing.Point(86, 36)
        Me.cmbYachtType.Name = "cmbYachtType"
        Me.cmbYachtType.Size = New System.Drawing.Size(121, 21)
        Me.cmbYachtType.Sorted = True
        Me.cmbYachtType.TabIndex = 7
        '
        'DeleteType
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(279, 124)
        Me.Controls.Add(Me.cmbYachtType)
        Me.Controls.Add(Me.lblEnterYachtType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeleteType"
        Me.Text = "Delete Yacht Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterYachtType As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cmbYachtType As System.Windows.Forms.ComboBox
End Class
