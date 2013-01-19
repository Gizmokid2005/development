Public Class Mastermind
    Inherits System.Windows.Forms.Form
    'Author: Michael Secord
    'Title: Mastermind Game
    'Purpose: To entertain.
    'Date: 5/11/05
    Const high = 9
    Const low = 1
    Dim num, num2, num3, num4, tries, totaltries, correct As Integer
    Dim average As Double

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
    Friend WithEvents txtnumber As System.Windows.Forms.TextBox
    Friend WithEvents btncheck As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbltries As System.Windows.Forms.Label
    Friend WithEvents lblcorrect As System.Windows.Forms.Label
    Friend WithEvents lblaverage As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents groguess As System.Windows.Forms.GroupBox
    Friend WithEvents txtnumber2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber3 As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber4 As System.Windows.Forms.TextBox
    Friend WithEvents grokey As System.Windows.Forms.GroupBox
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Mastermind))
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblaverage = New System.Windows.Forms.Label()
        Me.lblcorrect = New System.Windows.Forms.Label()
        Me.lbltries = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.groguess = New System.Windows.Forms.GroupBox()
        Me.txtnumber4 = New System.Windows.Forms.TextBox()
        Me.txtnumber3 = New System.Windows.Forms.TextBox()
        Me.txtnumber2 = New System.Windows.Forms.TextBox()
        Me.grokey = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.groguess.SuspendLayout()
        Me.grokey.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnumber
        '
        Me.txtnumber.BackColor = System.Drawing.Color.White
        Me.txtnumber.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumber.ForeColor = System.Drawing.Color.Black
        Me.txtnumber.Location = New System.Drawing.Point(32, 40)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(40, 52)
        Me.txtnumber.TabIndex = 1
        Me.txtnumber.Text = "0"
        Me.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btncheck
        '
        Me.btncheck.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btncheck.ForeColor = System.Drawing.Color.Aqua
        Me.btncheck.Location = New System.Drawing.Point(16, 88)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(96, 48)
        Me.btncheck.TabIndex = 2
        Me.btncheck.Text = "&Check Answer"
        '
        'btnexit
        '
        Me.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnexit.Location = New System.Drawing.Point(24, 144)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(80, 32)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "E&xit"
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Maroon
        Me.btnreset.ForeColor = System.Drawing.Color.Aqua
        Me.btnreset.Location = New System.Drawing.Point(24, 24)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(80, 56)
        Me.btnreset.TabIndex = 5
        Me.btnreset.Text = "&Start"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label7, Me.Label6, Me.Label5, Me.lblaverage, Me.lblcorrect, Me.lbltries})
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(552, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 176)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Score"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 32)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Average Times"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label6.Location = New System.Drawing.Point(8, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Correct"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tries"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblaverage
        '
        Me.lblaverage.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaverage.Location = New System.Drawing.Point(120, 136)
        Me.lblaverage.Name = "lblaverage"
        Me.lblaverage.Size = New System.Drawing.Size(40, 16)
        Me.lblaverage.TabIndex = 2
        Me.lblaverage.Text = "0"
        Me.lblaverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcorrect
        '
        Me.lblcorrect.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrect.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblcorrect.Location = New System.Drawing.Point(112, 80)
        Me.lblcorrect.Name = "lblcorrect"
        Me.lblcorrect.Size = New System.Drawing.Size(48, 16)
        Me.lblcorrect.TabIndex = 1
        Me.lblcorrect.Text = "0"
        Me.lblcorrect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltries
        '
        Me.lbltries.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltries.Location = New System.Drawing.Point(120, 32)
        Me.lbltries.Name = "lbltries"
        Me.lbltries.Size = New System.Drawing.Size(40, 16)
        Me.lbltries.TabIndex = 0
        Me.lbltries.Text = "0"
        Me.lbltries.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(408, 56)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Figure Me Out"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnexit, Me.btnreset, Me.btncheck})
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(584, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 184)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'groguess
        '
        Me.groguess.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtnumber4, Me.txtnumber3, Me.txtnumber2, Me.txtnumber})
        Me.groguess.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groguess.Location = New System.Drawing.Point(32, 96)
        Me.groguess.Name = "groguess"
        Me.groguess.Size = New System.Drawing.Size(336, 120)
        Me.groguess.TabIndex = 10
        Me.groguess.TabStop = False
        Me.groguess.Text = "Guess"
        '
        'txtnumber4
        '
        Me.txtnumber4.BackColor = System.Drawing.Color.White
        Me.txtnumber4.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumber4.ForeColor = System.Drawing.Color.Black
        Me.txtnumber4.Location = New System.Drawing.Point(272, 40)
        Me.txtnumber4.Name = "txtnumber4"
        Me.txtnumber4.Size = New System.Drawing.Size(40, 52)
        Me.txtnumber4.TabIndex = 4
        Me.txtnumber4.Text = "0"
        Me.txtnumber4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumber3
        '
        Me.txtnumber3.BackColor = System.Drawing.Color.White
        Me.txtnumber3.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumber3.ForeColor = System.Drawing.Color.Black
        Me.txtnumber3.Location = New System.Drawing.Point(184, 40)
        Me.txtnumber3.Name = "txtnumber3"
        Me.txtnumber3.Size = New System.Drawing.Size(40, 52)
        Me.txtnumber3.TabIndex = 3
        Me.txtnumber3.Text = "0"
        Me.txtnumber3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumber2
        '
        Me.txtnumber2.BackColor = System.Drawing.Color.White
        Me.txtnumber2.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumber2.ForeColor = System.Drawing.Color.Black
        Me.txtnumber2.Location = New System.Drawing.Point(112, 40)
        Me.txtnumber2.Name = "txtnumber2"
        Me.txtnumber2.Size = New System.Drawing.Size(40, 52)
        Me.txtnumber2.TabIndex = 2
        Me.txtnumber2.Text = "0"
        Me.txtnumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grokey
        '
        Me.grokey.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label1})
        Me.grokey.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grokey.Location = New System.Drawing.Point(72, 248)
        Me.grokey.Name = "grokey"
        Me.grokey.Size = New System.Drawing.Size(272, 96)
        Me.grokey.TabIndex = 11
        Me.grokey.TabStop = False
        Me.grokey.Text = "Key"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(24, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Green = Right number, Right place"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red = Right number, Wrong place"
        '
        'lblstatus
        '
        Me.lblstatus.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.Location = New System.Drawing.Point(8, 384)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(528, 96)
        Me.lblstatus.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(400, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Mastermind
        '
        Me.AcceptButton = Me.btncheck
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.CancelButton = Me.btnexit
        Me.ClientSize = New System.Drawing.Size(728, 502)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1, Me.lblstatus, Me.grokey, Me.groguess, Me.GroupBox3, Me.Label4, Me.GroupBox2})
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mastermind"
        Me.Text = "Mastermind"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.groguess.ResumeLayout(False)
        Me.grokey.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        'Gracefully closes the program
        Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reset()
        tries = 0
        correct = 0
        average = 0.0
        btncheck.Enabled = False
        btnreset.Enabled = True


    End Sub

    Private Sub btncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheck.Click
        If Not IsNumeric(txtnumber.Text) Or Not IsNumeric(txtnumber2.Text) Or Not IsNumeric(txtnumber3.Text) Or Not IsNumeric(txtnumber4.Text) Then
            MessageBox.Show("You must enter a number.", "Alpha-Numeric Error", MessageBoxButtons.OK)
        ElseIf (txtnumber.Text > high Or txtnumber.Text < low) And (txtnumber2.Text > high Or txtnumber2.Text < low) Or (txtnumber3.Text > high Or txtnumber3.Text < low) Or (txtnumber4.Text > high Or txtnumber4.Text < low) Then
            MessageBox.Show("You must enter a number between " & low & " and " & high & ".", "Numeric Error", MessageBoxButtons.OK)
        Else
            tries = tries + 1
            totaltries = totaltries + 1
            lbltries.Text = tries
            If txtnumber.Text = num Then 'correct answer
                txtnumber.BackColor = Color.LawnGreen
            ElseIf (txtnumber.Text = num2 Or txtnumber.Text = num3 Or txtnumber.Text = num4) Then
                txtnumber.BackColor = Color.Red
            Else
                txtnumber.BackColor = Color.White
            End If
            If txtnumber2.Text = num2 Then 'correct answer
                txtnumber2.BackColor = Color.LawnGreen
            ElseIf (txtnumber2.Text = num Or txtnumber2.Text = num3 Or txtnumber2.Text = num4) Then
                txtnumber2.BackColor = Color.Red
            Else
                txtnumber2.BackColor = Color.White
            End If
            If txtnumber3.Text = num3 Then 'correct answer
                txtnumber3.BackColor = Color.LawnGreen
            ElseIf (txtnumber3.Text = num2 Or txtnumber3.Text = num Or txtnumber3.Text = num4) Then
                txtnumber3.BackColor = Color.Red
            Else
                txtnumber3.BackColor = Color.White
            End If
            If txtnumber4.Text = num4 Then 'correct answer
                txtnumber4.BackColor = Color.LawnGreen
            ElseIf (txtnumber4.Text = num2 Or txtnumber4.Text = num3 Or txtnumber4.Text = num) Then
                txtnumber4.BackColor = Color.Red
            Else
                txtnumber4.BackColor = Color.White
            End If
            If (txtnumber.Text = num And txtnumber2.Text = num2 And txtnumber3.Text = num3 And txtnumber4.Text = num4) Then
                lblstatus.Text = "Correct!!  Press Start to Play Again."
                correct = correct + 1
                lblcorrect.Text = correct
                average = totaltries / correct
                lblaverage.Text = average
                tries = 0
                btncheck.Enabled = False
                btnreset.Enabled = True
            Else
                lblstatus.Text = "Try Again!"
            End If
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
        txtnumber.Text = "0"
        txtnumber2.Text = "0"
        txtnumber3.Text = "0"
        txtnumber4.Text = "0"
        btncheck.Enabled = True
        btnreset.Enabled = False
        lblstatus.Text = "Enter your Numbers and Press 'Check Answer'."
        lbltries.Text = 0

    End Sub

    Public Sub reset()
        lblstatus.Text = "Press Start to Begin!"
        Randomize()
        num = Int(Rnd() * (high - low + 1) + low)
        num2 = Int(Rnd() * (high - low + 1) + low)
        num3 = Int(Rnd() * (high - low + 1) + low)
        num4 = Int(Rnd() * (high - low + 1) + low)
        btncheck.Enabled = False
        txtnumber.BackColor = Color.White
        txtnumber.Text = 0
        txtnumber2.BackColor = Color.White
        txtnumber.Text = 0
        txtnumber3.BackColor = Color.White
        txtnumber.Text = 0
        txtnumber4.BackColor = Color.White
        txtnumber.Text = 0
    End Sub
    Friend WithEvents btnreset As System.Windows.Forms.Button

End Class
