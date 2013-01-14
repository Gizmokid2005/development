Public Class Form1
    Inherits System.Windows.Forms.Form
    'Author: Michael R. Secord
    'Date: April 20, 2005
    'Purpose: "For the conversion fo US currency to Canadian Dollars, Euros, Pounds, and Yen."
    Const Euro = 0.68218
    Const Pound = 0.50986
    Const Canadian = 1.0238
    Const Yen = 107.28
    Const Australian = 1.13559
    Friend WithEvents radAustralian As System.Windows.Forms.RadioButton
    Const status = "Conversions from http:\\www.xe.com 01/16/08 at 6:30 p.m."

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnconvert As System.Windows.Forms.Button
    Friend WithEvents radyen As System.Windows.Forms.RadioButton
    Friend WithEvents radPounds As System.Windows.Forms.RadioButton
    Friend WithEvents radEuros As System.Windows.Forms.RadioButton
    Friend WithEvents radCanadian As System.Windows.Forms.RadioButton
    Friend WithEvents groCurrencyType As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groCurrencyType = New System.Windows.Forms.GroupBox
        Me.radAustralian = New System.Windows.Forms.RadioButton
        Me.radyen = New System.Windows.Forms.RadioButton
        Me.radPounds = New System.Windows.Forms.RadioButton
        Me.radEuros = New System.Windows.Forms.RadioButton
        Me.radCanadian = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUS = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtConvertedamt = New System.Windows.Forms.TextBox
        Me.btnconvert = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.lblstatus = New System.Windows.Forms.Label
        Me.groCurrencyType.SuspendLayout()
        Me.SuspendLayout()
        '
        'groCurrencyType
        '
        Me.groCurrencyType.Controls.Add(Me.radAustralian)
        Me.groCurrencyType.Controls.Add(Me.radyen)
        Me.groCurrencyType.Controls.Add(Me.radPounds)
        Me.groCurrencyType.Controls.Add(Me.radEuros)
        Me.groCurrencyType.Controls.Add(Me.radCanadian)
        Me.groCurrencyType.Location = New System.Drawing.Point(8, 16)
        Me.groCurrencyType.Name = "groCurrencyType"
        Me.groCurrencyType.Size = New System.Drawing.Size(136, 162)
        Me.groCurrencyType.TabIndex = 1
        Me.groCurrencyType.TabStop = False
        Me.groCurrencyType.Text = "Currency Type"
        '
        'radAustralian
        '
        Me.radAustralian.AutoSize = True
        Me.radAustralian.Location = New System.Drawing.Point(16, 99)
        Me.radAustralian.Name = "radAustralian"
        Me.radAustralian.Size = New System.Drawing.Size(101, 17)
        Me.radAustralian.TabIndex = 4
        Me.radAustralian.Text = "Australian Dollar"
        Me.radAustralian.UseVisualStyleBackColor = True
        '
        'radyen
        '
        Me.radyen.Location = New System.Drawing.Point(16, 119)
        Me.radyen.Name = "radyen"
        Me.radyen.Size = New System.Drawing.Size(104, 24)
        Me.radyen.TabIndex = 0
        Me.radyen.Text = "Yen"
        '
        'radPounds
        '
        Me.radPounds.Location = New System.Drawing.Point(16, 72)
        Me.radPounds.Name = "radPounds"
        Me.radPounds.Size = New System.Drawing.Size(104, 24)
        Me.radPounds.TabIndex = 3
        Me.radPounds.Text = "Pounds"
        '
        'radEuros
        '
        Me.radEuros.Location = New System.Drawing.Point(16, 48)
        Me.radEuros.Name = "radEuros"
        Me.radEuros.Size = New System.Drawing.Size(104, 24)
        Me.radEuros.TabIndex = 2
        Me.radEuros.Text = "Euros"
        '
        'radCanadian
        '
        Me.radCanadian.Location = New System.Drawing.Point(16, 24)
        Me.radCanadian.Name = "radCanadian"
        Me.radCanadian.Size = New System.Drawing.Size(112, 24)
        Me.radCanadian.TabIndex = 1
        Me.radCanadian.Text = "Canadian Dollars"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(200, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "US Dollars:"
        '
        'txtUS
        '
        Me.txtUS.Location = New System.Drawing.Point(176, 40)
        Me.txtUS.Name = "txtUS"
        Me.txtUS.Size = New System.Drawing.Size(88, 20)
        Me.txtUS.TabIndex = 2
        Me.txtUS.Text = "$0.00"
        Me.txtUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(168, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Converted Amount:"
        '
        'txtConvertedamt
        '
        Me.txtConvertedamt.Location = New System.Drawing.Point(176, 112)
        Me.txtConvertedamt.Name = "txtConvertedamt"
        Me.txtConvertedamt.ReadOnly = True
        Me.txtConvertedamt.Size = New System.Drawing.Size(88, 20)
        Me.txtConvertedamt.TabIndex = 0
        Me.txtConvertedamt.TabStop = False
        Me.txtConvertedamt.Text = "0.00"
        Me.txtConvertedamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnconvert
        '
        Me.btnconvert.BackColor = System.Drawing.Color.LawnGreen
        Me.btnconvert.Location = New System.Drawing.Point(16, 184)
        Me.btnconvert.Name = "btnconvert"
        Me.btnconvert.Size = New System.Drawing.Size(75, 23)
        Me.btnconvert.TabIndex = 3
        Me.btnconvert.Text = "&Convert"
        Me.btnconvert.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.LawnGreen
        Me.btnreset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnreset.Location = New System.Drawing.Point(112, 184)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 4
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.LawnGreen
        Me.btnexit.Location = New System.Drawing.Point(208, 184)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 5
        Me.btnexit.Text = "E&xit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'lblstatus
        '
        Me.lblstatus.Location = New System.Drawing.Point(24, 216)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(248, 32)
        Me.lblstatus.TabIndex = 6
        '
        'Form1
        '
        Me.AcceptButton = Me.btnconvert
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.CancelButton = Me.btnreset
        Me.ClientSize = New System.Drawing.Size(304, 261)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnconvert)
        Me.Controls.Add(Me.txtConvertedamt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.groCurrencyType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Currency Converter"
        Me.groCurrencyType.ResumeLayout(False)
        Me.groCurrencyType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblstatus.Text = status
    End Sub
    Friend WithEvents lblstatus As System.Windows.Forms.Label

    Private Sub btnconvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconvert.Click

        If Not IsNumeric(txtUS.Text) Then
            MessageBox.Show("You must enter numeric data", "Numeric Error", MessageBoxButtons.OK)
            txtUS.Focus()

        End If

        If radEuros.Checked Then
            txtConvertedamt.Text = txtUS.Text * Euro
        End If
        If radyen.Checked Then
            txtConvertedamt.Text = txtUS.Text * Yen
        End If
        If radCanadian.Checked Then
            txtConvertedamt.Text = txtUS.Text * Canadian
        End If
        If radPounds.Checked Then
            txtConvertedamt.Text = txtUS.Text * Pound
        End If
        If radAustralian.Checked Then
            txtConvertedamt.Text = txtUS.Text * Australian
        End If
    End Sub
    Friend WithEvents txtConvertedamt As System.Windows.Forms.TextBox
    Friend WithEvents txtUS As System.Windows.Forms.TextBox

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtUS.Text = "$0.00"
        txtConvertedamt.Text = "0.00"
        radEuros.Checked = False
        radyen.Checked = False
        radPounds.Checked = False
        radCanadian.Checked = True
        radAustralian.Checked = False
    End Sub
End Class
