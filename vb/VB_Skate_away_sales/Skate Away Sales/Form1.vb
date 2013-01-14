Public Class Form1
    Inherits System.Windows.Forms.Form
    'Author: Michael R. Secord
    'Title: Skate Away Sales Order Form
    'Purpose: To automate the Sales Order process for Skate Away Sales
    'Date: 4/18/05
    Const price = 100
    Const taxrate = 0.05
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblAccountNumber As System.Windows.Forms.Label
    Friend WithEvents txtAccountNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblBlueboards As System.Windows.Forms.Label
    Friend WithEvents lblYellowboards As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTQty As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents nudBlueBoards As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudYellowBoards As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.lblBlueboards = New System.Windows.Forms.Label()
        Me.lblYellowboards = New System.Windows.Forms.Label()
        Me.nudBlueBoards = New System.Windows.Forms.NumericUpDown()
        Me.nudYellowBoards = New System.Windows.Forms.NumericUpDown()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTQty = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        CType(Me.nudBlueBoards, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYellowBoards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblName.Location = New System.Drawing.Point(8, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(40, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(48, 16)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(152, 16)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.TabIndex = 2
        Me.txtLastName.Text = "Last Name"
        '
        'lblAddress
        '
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAddress.Location = New System.Drawing.Point(0, 48)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(56, 16)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(48, 48)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 20)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCity.Location = New System.Drawing.Point(0, 88)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(32, 16)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "City:"
        '
        'lblState
        '
        Me.lblState.ForeColor = System.Drawing.SystemColors.Control
        Me.lblState.Location = New System.Drawing.Point(136, 88)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 16)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "State:"
        '
        'lblZip
        '
        Me.lblZip.ForeColor = System.Drawing.SystemColors.Control
        Me.lblZip.Location = New System.Drawing.Point(264, 88)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(24, 16)
        Me.lblZip.TabIndex = 7
        Me.lblZip.Text = "Zip:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(32, 80)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.TabIndex = 8
        Me.txtCity.Text = "City"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(168, 80)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(88, 20)
        Me.txtState.TabIndex = 9
        Me.txtState.Text = "State"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(296, 80)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(48, 20)
        Me.txtZip.TabIndex = 10
        Me.txtZip.Text = "Zip"
        '
        'lblAccountNumber
        '
        Me.lblAccountNumber.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAccountNumber.Location = New System.Drawing.Point(416, 8)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(48, 32)
        Me.lblAccountNumber.TabIndex = 11
        Me.lblAccountNumber.Text = "Account Number:"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(472, 16)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.TabIndex = 12
        Me.txtAccountNumber.Text = "Account Number"
        '
        'lblBlueboards
        '
        Me.lblBlueboards.ForeColor = System.Drawing.Color.Blue
        Me.lblBlueboards.Location = New System.Drawing.Point(16, 120)
        Me.lblBlueboards.Name = "lblBlueboards"
        Me.lblBlueboards.Size = New System.Drawing.Size(128, 16)
        Me.lblBlueboards.TabIndex = 13
        Me.lblBlueboards.Text = "Quantity of Blue Boards:"
        '
        'lblYellowboards
        '
        Me.lblYellowboards.ForeColor = System.Drawing.Color.Yellow
        Me.lblYellowboards.Location = New System.Drawing.Point(8, 152)
        Me.lblYellowboards.Name = "lblYellowboards"
        Me.lblYellowboards.Size = New System.Drawing.Size(144, 16)
        Me.lblYellowboards.TabIndex = 14
        Me.lblYellowboards.Text = "Quantity of Yellow Boards:"
        '
        'nudBlueBoards
        '
        Me.nudBlueBoards.BackColor = System.Drawing.Color.Blue
        Me.nudBlueBoards.ForeColor = System.Drawing.Color.White
        Me.nudBlueBoards.Location = New System.Drawing.Point(176, 120)
        Me.nudBlueBoards.Name = "nudBlueBoards"
        Me.nudBlueBoards.Size = New System.Drawing.Size(48, 20)
        Me.nudBlueBoards.TabIndex = 15
        Me.nudBlueBoards.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudYellowBoards
        '
        Me.nudYellowBoards.BackColor = System.Drawing.Color.Yellow
        Me.nudYellowBoards.ForeColor = System.Drawing.Color.Black
        Me.nudYellowBoards.Location = New System.Drawing.Point(176, 152)
        Me.nudYellowBoards.Name = "nudYellowBoards"
        Me.nudYellowBoards.Size = New System.Drawing.Size(48, 20)
        Me.nudYellowBoards.TabIndex = 16
        Me.nudYellowBoards.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblQuantity
        '
        Me.lblQuantity.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQuantity.Location = New System.Drawing.Point(64, 192)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(80, 16)
        Me.lblQuantity.TabIndex = 17
        Me.lblQuantity.Text = "Total Quantity:"
        '
        'btnCompute
        '
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCompute.Location = New System.Drawing.Point(256, 280)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.TabIndex = 18
        Me.btnCompute.Text = "&Compute"
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReset.Location = New System.Drawing.Point(344, 280)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "&Reset"
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExit.Location = New System.Drawing.Point(432, 280)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(288, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "SubTotal"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(400, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Tax"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(475, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 29)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Grand Total"
        '
        'lblTQty
        '
        Me.lblTQty.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTQty.Location = New System.Drawing.Point(184, 192)
        Me.lblTQty.Name = "lblTQty"
        Me.lblTQty.Size = New System.Drawing.Size(24, 16)
        Me.lblTQty.TabIndex = 24
        Me.lblTQty.Text = "0"
        Me.lblTQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSubtotal.Location = New System.Drawing.Point(248, 200)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(80, 16)
        Me.lblSubtotal.TabIndex = 25
        Me.lblSubtotal.Text = "$0.00"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTax.Location = New System.Drawing.Point(336, 200)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(88, 16)
        Me.lblTax.TabIndex = 26
        Me.lblTax.Text = "$0.00"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.SystemColors.Highlight
        Me.lbltotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltotal.Location = New System.Drawing.Point(448, 200)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(72, 16)
        Me.lbltotal.TabIndex = 27
        Me.lbltotal.Text = "$0.00"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(584, 334)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lbltotal, Me.lblTax, Me.lblSubtotal, Me.lblTQty, Me.Label3, Me.Label2, Me.Label1, Me.btnExit, Me.btnReset, Me.btnCompute, Me.lblQuantity, Me.nudYellowBoards, Me.nudBlueBoards, Me.lblYellowboards, Me.lblBlueboards, Me.txtAccountNumber, Me.lblAccountNumber, Me.txtZip, Me.txtState, Me.txtCity, Me.lblZip, Me.lblState, Me.lblCity, Me.txtAddress, Me.lblAddress, Me.txtLastName, Me.txtFirstName, Me.lblName})
        Me.Name = "Form1"
        Me.Text = "Skate Away Sales"
        CType(Me.nudBlueBoards, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYellowBoards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtFirstName.Text = "First Name"
        txtLastName.Text = "Last Name"
        txtAddress.Text = "Address"
        txtAccountNumber.Text = "Account Number"
        txtCity.Text = "City"
        txtState.Text = "State"
        txtZip.Text = "Zip"
        nudBlueBoards.Value = 0
        nudYellowBoards.Value = 0
        lblTQty.Text = "0"
        lblSubtotal.Text = "$0.00"
        lblTax.Text = "$0.00"
        lbltotal.Text = "$0.00"
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim subtotal, tax, total As Double
        lblTQty.Text = nudBlueBoards.Value + nudYellowBoards.Value
        subtotal = lblTQty.Text * price
        tax = subtotal * taxrate
        total = subtotal + tax
        lblSubtotal.Text = Format$(subtotal, "currency")
        lblTax.Text = Format$(tax, "currency")
        lbltotal.Text = Format$(total, "currency")

    End Sub
End Class
