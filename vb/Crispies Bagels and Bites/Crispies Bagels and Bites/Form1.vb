Public Class Form1
    Inherits System.Windows.Forms.Form
    'Author: Michael Secord
    'Title: Crispies Bagels and Bites
    'Purpose: To automate the Crispies Bagels and Bites Order form.
    'Date: 5/16/05
    Const bagelprice = 1.25
    Const coffeeprice = 1.25
    Const doughnutprice = 0.75
    Const taxrate = 0.06

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
    Friend WithEvents lblbagel As System.Windows.Forms.Label
    Friend WithEvents lblcoffee As System.Windows.Forms.Label
    Friend WithEvents lbldoughnuts As System.Windows.Forms.Label
    Friend WithEvents nuddoughnuts As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudbagels As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudcoffee As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents lbltax As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblsubtotalprice As System.Windows.Forms.Label
    Friend WithEvents lbltaxtotal As System.Windows.Forms.Label
    Friend WithEvents lbltotalprice As System.Windows.Forms.Label
    Friend WithEvents btncompute As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lblcreamcheese As System.Windows.Forms.Label
    Friend WithEvents lblnone As System.Windows.Forms.Label
    Friend WithEvents lblcheese As System.Windows.Forms.Label
    Friend WithEvents lbljelly As System.Windows.Forms.Label
    Friend WithEvents lblbutter As System.Windows.Forms.Label
    Friend WithEvents nudcheese As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudbutter As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudcreamcheese As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudnone As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudjelly As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.lblbagel = New System.Windows.Forms.Label()
        Me.lblcoffee = New System.Windows.Forms.Label()
        Me.lbldoughnuts = New System.Windows.Forms.Label()
        Me.nuddoughnuts = New System.Windows.Forms.NumericUpDown()
        Me.nudbagels = New System.Windows.Forms.NumericUpDown()
        Me.nudcoffee = New System.Windows.Forms.NumericUpDown()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblsubtotalprice = New System.Windows.Forms.Label()
        Me.lbltaxtotal = New System.Windows.Forms.Label()
        Me.lbltotalprice = New System.Windows.Forms.Label()
        Me.btncompute = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblcreamcheese = New System.Windows.Forms.Label()
        Me.lblnone = New System.Windows.Forms.Label()
        Me.lblcheese = New System.Windows.Forms.Label()
        Me.lbljelly = New System.Windows.Forms.Label()
        Me.lblbutter = New System.Windows.Forms.Label()
        Me.nudnone = New System.Windows.Forms.NumericUpDown()
        Me.nudjelly = New System.Windows.Forms.NumericUpDown()
        Me.nudcheese = New System.Windows.Forms.NumericUpDown()
        Me.nudbutter = New System.Windows.Forms.NumericUpDown()
        Me.nudcreamcheese = New System.Windows.Forms.NumericUpDown()
        CType(Me.nuddoughnuts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudbagels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudcoffee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudnone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudjelly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudcheese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudbutter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudcreamcheese, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblbagel
        '
        Me.lblbagel.ForeColor = System.Drawing.Color.Purple
        Me.lblbagel.Location = New System.Drawing.Point(32, 24)
        Me.lblbagel.Name = "lblbagel"
        Me.lblbagel.Size = New System.Drawing.Size(48, 24)
        Me.lblbagel.TabIndex = 0
        Me.lblbagel.Text = "Bagels"
        Me.lblbagel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcoffee
        '
        Me.lblcoffee.ForeColor = System.Drawing.Color.Purple
        Me.lblcoffee.Location = New System.Drawing.Point(32, 88)
        Me.lblcoffee.Name = "lblcoffee"
        Me.lblcoffee.Size = New System.Drawing.Size(80, 24)
        Me.lblcoffee.TabIndex = 1
        Me.lblcoffee.Text = "Cups of Coffee"
        Me.lblcoffee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldoughnuts
        '
        Me.lbldoughnuts.ForeColor = System.Drawing.Color.Purple
        Me.lbldoughnuts.Location = New System.Drawing.Point(32, 56)
        Me.lbldoughnuts.Name = "lbldoughnuts"
        Me.lbldoughnuts.Size = New System.Drawing.Size(64, 24)
        Me.lbldoughnuts.TabIndex = 2
        Me.lbldoughnuts.Text = "Doughnuts"
        Me.lbldoughnuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nuddoughnuts
        '
        Me.nuddoughnuts.Location = New System.Drawing.Point(136, 56)
        Me.nuddoughnuts.Name = "nuddoughnuts"
        Me.nuddoughnuts.Size = New System.Drawing.Size(64, 20)
        Me.nuddoughnuts.TabIndex = 3
        Me.nuddoughnuts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudbagels
        '
        Me.nudbagels.Location = New System.Drawing.Point(136, 24)
        Me.nudbagels.Name = "nudbagels"
        Me.nudbagels.Size = New System.Drawing.Size(64, 20)
        Me.nudbagels.TabIndex = 4
        Me.nudbagels.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudcoffee
        '
        Me.nudcoffee.Location = New System.Drawing.Point(136, 88)
        Me.nudcoffee.Name = "nudcoffee"
        Me.nudcoffee.Size = New System.Drawing.Size(64, 20)
        Me.nudcoffee.TabIndex = 5
        Me.nudcoffee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblsubtotal
        '
        Me.lblsubtotal.ForeColor = System.Drawing.Color.Purple
        Me.lblsubtotal.Location = New System.Drawing.Point(32, 208)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(56, 16)
        Me.lblsubtotal.TabIndex = 6
        Me.lblsubtotal.Text = "Sub Total"
        Me.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltax
        '
        Me.lbltax.ForeColor = System.Drawing.Color.Purple
        Me.lbltax.Location = New System.Drawing.Point(136, 208)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(52, 16)
        Me.lbltax.TabIndex = 7
        Me.lbltax.Text = "Tax"
        Me.lbltax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotal
        '
        Me.lbltotal.ForeColor = System.Drawing.Color.Purple
        Me.lbltotal.Location = New System.Drawing.Point(240, 208)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(56, 16)
        Me.lbltotal.TabIndex = 8
        Me.lbltotal.Text = "Total"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsubtotalprice
        '
        Me.lblsubtotalprice.ForeColor = System.Drawing.Color.Purple
        Me.lblsubtotalprice.Location = New System.Drawing.Point(40, 248)
        Me.lblsubtotalprice.Name = "lblsubtotalprice"
        Me.lblsubtotalprice.Size = New System.Drawing.Size(40, 16)
        Me.lblsubtotalprice.TabIndex = 9
        Me.lblsubtotalprice.Text = "$0.00"
        Me.lblsubtotalprice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltaxtotal
        '
        Me.lbltaxtotal.ForeColor = System.Drawing.Color.Purple
        Me.lbltaxtotal.Location = New System.Drawing.Point(144, 248)
        Me.lbltaxtotal.Name = "lbltaxtotal"
        Me.lbltaxtotal.Size = New System.Drawing.Size(40, 16)
        Me.lbltaxtotal.TabIndex = 10
        Me.lbltaxtotal.Text = "$0.00"
        Me.lbltaxtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotalprice
        '
        Me.lbltotalprice.ForeColor = System.Drawing.Color.Purple
        Me.lbltotalprice.Location = New System.Drawing.Point(248, 248)
        Me.lbltotalprice.Name = "lbltotalprice"
        Me.lbltotalprice.Size = New System.Drawing.Size(40, 16)
        Me.lbltotalprice.TabIndex = 11
        Me.lbltotalprice.Text = "$0.00"
        Me.lbltotalprice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btncompute
        '
        Me.btncompute.BackColor = System.Drawing.Color.Purple
        Me.btncompute.ForeColor = System.Drawing.Color.Turquoise
        Me.btncompute.Location = New System.Drawing.Point(24, 296)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(80, 32)
        Me.btncompute.TabIndex = 12
        Me.btncompute.Text = "&Compute"
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Purple
        Me.btnreset.ForeColor = System.Drawing.Color.Turquoise
        Me.btnreset.Location = New System.Drawing.Point(120, 296)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(88, 32)
        Me.btnreset.TabIndex = 13
        Me.btnreset.Text = "&Reset"
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Purple
        Me.btnexit.ForeColor = System.Drawing.Color.Turquoise
        Me.btnexit.Location = New System.Drawing.Point(224, 296)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(80, 32)
        Me.btnexit.TabIndex = 14
        Me.btnexit.Text = "E&xit"
        '
        'lblcreamcheese
        '
        Me.lblcreamcheese.ForeColor = System.Drawing.Color.Purple
        Me.lblcreamcheese.Location = New System.Drawing.Point(216, 24)
        Me.lblcreamcheese.Name = "lblcreamcheese"
        Me.lblcreamcheese.Size = New System.Drawing.Size(88, 16)
        Me.lblcreamcheese.TabIndex = 15
        Me.lblcreamcheese.Text = "Cream Cheese"
        Me.lblcreamcheese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblnone
        '
        Me.lblnone.ForeColor = System.Drawing.Color.Purple
        Me.lblnone.Location = New System.Drawing.Point(216, 152)
        Me.lblnone.Name = "lblnone"
        Me.lblnone.Size = New System.Drawing.Size(88, 16)
        Me.lblnone.TabIndex = 16
        Me.lblnone.Text = "None"
        Me.lblnone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcheese
        '
        Me.lblcheese.ForeColor = System.Drawing.Color.Purple
        Me.lblcheese.Location = New System.Drawing.Point(216, 88)
        Me.lblcheese.Name = "lblcheese"
        Me.lblcheese.Size = New System.Drawing.Size(88, 16)
        Me.lblcheese.TabIndex = 17
        Me.lblcheese.Text = "Cheese"
        Me.lblcheese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbljelly
        '
        Me.lbljelly.ForeColor = System.Drawing.Color.Purple
        Me.lbljelly.Location = New System.Drawing.Point(216, 120)
        Me.lbljelly.Name = "lbljelly"
        Me.lbljelly.Size = New System.Drawing.Size(88, 16)
        Me.lbljelly.TabIndex = 18
        Me.lbljelly.Text = "Jelly"
        Me.lbljelly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblbutter
        '
        Me.lblbutter.ForeColor = System.Drawing.Color.Purple
        Me.lblbutter.Location = New System.Drawing.Point(216, 56)
        Me.lblbutter.Name = "lblbutter"
        Me.lblbutter.Size = New System.Drawing.Size(88, 16)
        Me.lblbutter.TabIndex = 19
        Me.lblbutter.Text = "Butter"
        Me.lblbutter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudnone
        '
        Me.nudnone.Location = New System.Drawing.Point(312, 144)
        Me.nudnone.Name = "nudnone"
        Me.nudnone.Size = New System.Drawing.Size(64, 20)
        Me.nudnone.TabIndex = 21
        Me.nudnone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudjelly
        '
        Me.nudjelly.Location = New System.Drawing.Point(312, 112)
        Me.nudjelly.Name = "nudjelly"
        Me.nudjelly.Size = New System.Drawing.Size(64, 20)
        Me.nudjelly.TabIndex = 22
        Me.nudjelly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudcheese
        '
        Me.nudcheese.Location = New System.Drawing.Point(312, 80)
        Me.nudcheese.Name = "nudcheese"
        Me.nudcheese.Size = New System.Drawing.Size(64, 20)
        Me.nudcheese.TabIndex = 23
        Me.nudcheese.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudbutter
        '
        Me.nudbutter.Location = New System.Drawing.Point(312, 48)
        Me.nudbutter.Name = "nudbutter"
        Me.nudbutter.Size = New System.Drawing.Size(64, 20)
        Me.nudbutter.TabIndex = 24
        Me.nudbutter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudcreamcheese
        '
        Me.nudcreamcheese.Location = New System.Drawing.Point(312, 16)
        Me.nudcreamcheese.Name = "nudcreamcheese"
        Me.nudcreamcheese.Size = New System.Drawing.Size(64, 20)
        Me.nudcreamcheese.TabIndex = 25
        Me.nudcreamcheese.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(432, 358)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.nudcreamcheese, Me.nudbutter, Me.nudcheese, Me.nudjelly, Me.nudnone, Me.lblbutter, Me.lbljelly, Me.lblcheese, Me.lblnone, Me.lblcreamcheese, Me.btnexit, Me.btnreset, Me.btncompute, Me.lbltotalprice, Me.lbltaxtotal, Me.lblsubtotalprice, Me.lbltotal, Me.lbltax, Me.lblsubtotal, Me.nudcoffee, Me.nudbagels, Me.nuddoughnuts, Me.lbldoughnuts, Me.lblcoffee, Me.lblbagel})
        Me.ForeColor = System.Drawing.Color.Red
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Crispies Bagel and Bites"
        CType(Me.nuddoughnuts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudbagels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudcoffee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudnone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudjelly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudcheese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudbutter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudcreamcheese, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Close()
    End Sub


    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        lblsubtotalprice.Text = "$0.00"
        lbltaxtotal.Text = "$0.00"
        lbltotalprice.Text = "$0.00"
        nudbagels.Value = 0
        nuddoughnuts.Value = 0
        nudcoffee.Value = 0
        nudcreamcheese.Value = 0
        nudbutter.Value = 0
        nudcheese.Value = 0
        nudjelly.Value = 0
        nudnone.Value = 0

    End Sub

    Private Sub btncompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncompute.Click
        Dim subtotal, tax, total, toppings As Double
        toppings = nudcreamcheese.Value + nudcheese.Value + nudbutter.Value + nudjelly.Value + nudnone.Value
        If nudbagels.Value >= 0 And nudbagels.Value < toppings Then
            MessageBox.Show("You have selcted to many toppings", "Topping Error", MessageBoxButtons.OK)
            nudcreamcheese.Focus()
        ElseIf nudbagels.Value > 0 And nudbagels.Value > toppings Then
            MessageBox.Show("You haven't selcted enough toppings", "Topping Error", MessageBoxButtons.OK)
            nudcreamcheese.Focus()
        Else 'no error
            subtotal = bagelprice * nudbagels.Value + coffeeprice * nudcoffee.Value + doughnutprice * nuddoughnuts.Value
            tax = subtotal * taxrate
            total = tax + subtotal
            lblsubtotalprice.Text = Format$(subtotal, "currency")
            lbltaxtotal.Text = Format$(tax, "currency")
            lbltotalprice.Text = Format$(total, "currency")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
