<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintYachtTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearForNextCharterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.AddYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisplayCountOfYachtTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grpYachtInfo = New System.Windows.Forms.GroupBox
        Me.cmbYachtLength = New System.Windows.Forms.ComboBox
        Me.lblYachtLength = New System.Windows.Forms.Label
        Me.lblYachtType = New System.Windows.Forms.Label
        Me.cmbYachtType = New System.Windows.Forms.ComboBox
        Me.txtResponsibleParty = New System.Windows.Forms.TextBox
        Me.txtHoursWorked = New System.Windows.Forms.TextBox
        Me.lblRespParty = New System.Windows.Forms.Label
        Me.lblHoursChartered = New System.Windows.Forms.Label
        Me.lblPriceOfCharter = New System.Windows.Forms.Label
        Me.txtCalculatedPrice = New System.Windows.Forms.TextBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.printSummaryPage = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.printYachtPage = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog
        Me.MenuStrip1.SuspendLayout()
        Me.grpYachtInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(491, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSummaryToolStripMenuItem, Me.PrintYachtTypesToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.PrintSummaryToolStripMenuItem.Text = "&Print Summary"
        '
        'PrintYachtTypesToolStripMenuItem
        '
        Me.PrintYachtTypesToolStripMenuItem.Name = "PrintYachtTypesToolStripMenuItem"
        Me.PrintYachtTypesToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.PrintYachtTypesToolStripMenuItem.Text = "P&rint Yacht Types"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearForNextCharterToolStripMenuItem, Me.ToolStripSeparator2, Me.AddYachtTypeToolStripMenuItem, Me.RemoveYachtTypeToolStripMenuItem, Me.DisplayCountOfYachtTypesToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearForNextCharterToolStripMenuItem
        '
        Me.ClearForNextCharterToolStripMenuItem.Name = "ClearForNextCharterToolStripMenuItem"
        Me.ClearForNextCharterToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ClearForNextCharterToolStripMenuItem.Text = "&Clear for Next Charter"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(223, 6)
        '
        'AddYachtTypeToolStripMenuItem
        '
        Me.AddYachtTypeToolStripMenuItem.Name = "AddYachtTypeToolStripMenuItem"
        Me.AddYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.AddYachtTypeToolStripMenuItem.Text = "Add &Yacht Type"
        '
        'RemoveYachtTypeToolStripMenuItem
        '
        Me.RemoveYachtTypeToolStripMenuItem.Name = "RemoveYachtTypeToolStripMenuItem"
        Me.RemoveYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.RemoveYachtTypeToolStripMenuItem.Text = "&Remove Yacht Type"
        '
        'DisplayCountOfYachtTypesToolStripMenuItem
        '
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Name = "DisplayCountOfYachtTypesToolStripMenuItem"
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Text = "&Display Count of Yacht Types"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'grpYachtInfo
        '
        Me.grpYachtInfo.Controls.Add(Me.cmbYachtLength)
        Me.grpYachtInfo.Controls.Add(Me.lblYachtLength)
        Me.grpYachtInfo.Controls.Add(Me.lblYachtType)
        Me.grpYachtInfo.Controls.Add(Me.cmbYachtType)
        Me.grpYachtInfo.Location = New System.Drawing.Point(257, 27)
        Me.grpYachtInfo.Name = "grpYachtInfo"
        Me.grpYachtInfo.Size = New System.Drawing.Size(222, 100)
        Me.grpYachtInfo.TabIndex = 3
        Me.grpYachtInfo.TabStop = False
        Me.grpYachtInfo.Text = "Yacht Information"
        '
        'cmbYachtLength
        '
        Me.cmbYachtLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYachtLength.FormattingEnabled = True
        Me.cmbYachtLength.Items.AddRange(New Object() {"22", "24", "30", "32", "36", "38", "45"})
        Me.cmbYachtLength.Location = New System.Drawing.Point(95, 61)
        Me.cmbYachtLength.Name = "cmbYachtLength"
        Me.cmbYachtLength.Size = New System.Drawing.Size(121, 21)
        Me.cmbYachtLength.Sorted = True
        Me.cmbYachtLength.TabIndex = 1
        '
        'lblYachtLength
        '
        Me.lblYachtLength.AutoSize = True
        Me.lblYachtLength.Location = New System.Drawing.Point(6, 64)
        Me.lblYachtLength.Name = "lblYachtLength"
        Me.lblYachtLength.Size = New System.Drawing.Size(83, 13)
        Me.lblYachtLength.TabIndex = 2
        Me.lblYachtLength.Text = "Length of Yacht"
        '
        'lblYachtType
        '
        Me.lblYachtType.AutoSize = True
        Me.lblYachtType.Location = New System.Drawing.Point(6, 22)
        Me.lblYachtType.Name = "lblYachtType"
        Me.lblYachtType.Size = New System.Drawing.Size(74, 13)
        Me.lblYachtType.TabIndex = 3
        Me.lblYachtType.Text = "Type of Yacht"
        '
        'cmbYachtType
        '
        Me.cmbYachtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYachtType.FormattingEnabled = True
        Me.cmbYachtType.Items.AddRange(New Object() {"C & C", "Catalina", "Coronado", "Excalibur", "Hans Christian", "Hobie", "Ranger", "Wavelength"})
        Me.cmbYachtType.Location = New System.Drawing.Point(95, 19)
        Me.cmbYachtType.Name = "cmbYachtType"
        Me.cmbYachtType.Size = New System.Drawing.Size(121, 21)
        Me.cmbYachtType.Sorted = True
        Me.cmbYachtType.TabIndex = 0
        '
        'txtResponsibleParty
        '
        Me.txtResponsibleParty.Location = New System.Drawing.Point(127, 49)
        Me.txtResponsibleParty.Name = "txtResponsibleParty"
        Me.txtResponsibleParty.Size = New System.Drawing.Size(100, 20)
        Me.txtResponsibleParty.TabIndex = 1
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(127, 88)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursWorked.TabIndex = 2
        '
        'lblRespParty
        '
        Me.lblRespParty.AutoSize = True
        Me.lblRespParty.Location = New System.Drawing.Point(12, 52)
        Me.lblRespParty.Name = "lblRespParty"
        Me.lblRespParty.Size = New System.Drawing.Size(95, 13)
        Me.lblRespParty.TabIndex = 3
        Me.lblRespParty.Text = "Responsible Party:"
        '
        'lblHoursChartered
        '
        Me.lblHoursChartered.AutoSize = True
        Me.lblHoursChartered.Location = New System.Drawing.Point(12, 91)
        Me.lblHoursChartered.Name = "lblHoursChartered"
        Me.lblHoursChartered.Size = New System.Drawing.Size(87, 13)
        Me.lblHoursChartered.TabIndex = 5
        Me.lblHoursChartered.Text = "Hours Chartered:"
        '
        'lblPriceOfCharter
        '
        Me.lblPriceOfCharter.AutoSize = True
        Me.lblPriceOfCharter.Location = New System.Drawing.Point(16, 156)
        Me.lblPriceOfCharter.Name = "lblPriceOfCharter"
        Me.lblPriceOfCharter.Size = New System.Drawing.Size(136, 13)
        Me.lblPriceOfCharter.TabIndex = 6
        Me.lblPriceOfCharter.Text = "Calculated Price of Charter:"
        '
        'txtCalculatedPrice
        '
        Me.txtCalculatedPrice.Location = New System.Drawing.Point(158, 153)
        Me.txtCalculatedPrice.Name = "txtCalculatedPrice"
        Me.txtCalculatedPrice.ReadOnly = True
        Me.txtCalculatedPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtCalculatedPrice.TabIndex = 7
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(295, 150)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(376, 150)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'printSummaryPage
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'printYachtPage
        '
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(491, 191)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtCalculatedPrice)
        Me.Controls.Add(Me.lblPriceOfCharter)
        Me.Controls.Add(Me.lblHoursChartered)
        Me.Controls.Add(Me.lblRespParty)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.txtResponsibleParty)
        Me.Controls.Add(Me.grpYachtInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Yacht Chartering"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpYachtInfo.ResumeLayout(False)
        Me.grpYachtInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpYachtInfo As System.Windows.Forms.GroupBox
    Friend WithEvents cmbYachtType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYachtLength As System.Windows.Forms.ComboBox
    Friend WithEvents lblYachtLength As System.Windows.Forms.Label
    Friend WithEvents lblYachtType As System.Windows.Forms.Label
    Friend WithEvents txtResponsibleParty As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents lblRespParty As System.Windows.Forms.Label
    Friend WithEvents lblHoursChartered As System.Windows.Forms.Label
    Friend WithEvents lblPriceOfCharter As System.Windows.Forms.Label
    Friend WithEvents txtCalculatedPrice As System.Windows.Forms.TextBox
    Friend WithEvents PrintSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintYachtTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearForNextCharterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddYachtTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveYachtTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayCountOfYachtTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents printSummaryPage As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents printYachtPage As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As System.Windows.Forms.PrintPreviewDialog

End Class
