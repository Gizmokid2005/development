Public Class Form1
    Inherits System.Windows.Forms.Form
    Const high = 9
    Const low = 1
    Dim num, tries, totaltries, correct As Integer
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
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents lblinstructions As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbltries As System.Windows.Forms.Label
    Friend WithEvents lblcorrect As System.Windows.Forms.Label
    Friend WithEvents lblaverage As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents picred As System.Windows.Forms.PictureBox
    Friend WithEvents picyellow As System.Windows.Forms.PictureBox
    Friend WithEvents picnone As System.Windows.Forms.PictureBox
    Friend WithEvents picstatus As System.Windows.Forms.PictureBox
    Friend WithEvents picgreen As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.lblinstructions = New System.Windows.Forms.Label()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblaverage = New System.Windows.Forms.Label()
        Me.lblcorrect = New System.Windows.Forms.Label()
        Me.lbltries = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.picred = New System.Windows.Forms.PictureBox()
        Me.picyellow = New System.Windows.Forms.PictureBox()
        Me.picgreen = New System.Windows.Forms.PictureBox()
        Me.picstatus = New System.Windows.Forms.PictureBox()
        Me.picnone = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblinstructions
        '
        Me.lblinstructions.ForeColor = System.Drawing.Color.Yellow
        Me.lblinstructions.Location = New System.Drawing.Point(312, 72)
        Me.lblinstructions.Name = "lblinstructions"
        Me.lblinstructions.Size = New System.Drawing.Size(144, 40)
        Me.lblinstructions.TabIndex = 0
        Me.lblinstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtnumber
        '
        Me.txtnumber.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtnumber.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumber.ForeColor = System.Drawing.Color.Yellow
        Me.txtnumber.Location = New System.Drawing.Point(264, 160)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(40, 34)
        Me.txtnumber.TabIndex = 1
        Me.txtnumber.Text = "0"
        Me.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btncheck
        '
        Me.btncheck.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btncheck.ForeColor = System.Drawing.Color.Aqua
        Me.btncheck.Location = New System.Drawing.Point(16, 24)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(96, 32)
        Me.btncheck.TabIndex = 2
        Me.btncheck.Text = "&Check Answer"
        '
        'btnexit
        '
        Me.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnexit.Location = New System.Drawing.Point(24, 80)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(80, 32)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "E&xit"
        '
        'lblstatus
        '
        Me.lblstatus.ForeColor = System.Drawing.Color.Yellow
        Me.lblstatus.Location = New System.Drawing.Point(8, 16)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(176, 48)
        Me.lblstatus.TabIndex = 4
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Maroon
        Me.btnreset.ForeColor = System.Drawing.Color.Aqua
        Me.btnreset.Location = New System.Drawing.Point(24, 136)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(80, 23)
        Me.btnreset.TabIndex = 5
        Me.btnreset.Text = "&Reset"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblstatus})
        Me.GroupBox1.Location = New System.Drawing.Point(216, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 72)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label7, Me.Label6, Me.Label5, Me.lblaverage, Me.lblcorrect, Me.lbltries})
        Me.GroupBox2.Location = New System.Drawing.Point(88, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 112)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(288, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 32)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Average Times"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label6.Location = New System.Drawing.Point(160, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Correct"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tries"
        '
        'lblaverage
        '
        Me.lblaverage.Location = New System.Drawing.Point(288, 72)
        Me.lblaverage.Name = "lblaverage"
        Me.lblaverage.Size = New System.Drawing.Size(40, 16)
        Me.lblaverage.TabIndex = 2
        Me.lblaverage.Text = "0"
        Me.lblaverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcorrect
        '
        Me.lblcorrect.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblcorrect.Location = New System.Drawing.Point(160, 72)
        Me.lblcorrect.Name = "lblcorrect"
        Me.lblcorrect.Size = New System.Drawing.Size(48, 16)
        Me.lblcorrect.TabIndex = 1
        Me.lblcorrect.Text = "0"
        Me.lblcorrect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltries
        '
        Me.lbltries.Location = New System.Drawing.Point(24, 72)
        Me.lbltries.Name = "lbltries"
        Me.lbltries.Size = New System.Drawing.Size(40, 16)
        Me.lbltries.TabIndex = 0
        Me.lbltries.Text = "0"
        Me.lbltries.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(208, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 56)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "The Guessing Game"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnexit, Me.btnreset, Me.btncheck})
        Me.GroupBox3.Location = New System.Drawing.Point(576, 312)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 176)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'picred
        '
        Me.picred.Image = CType(resources.GetObject("picred.Image"), System.Drawing.Bitmap)
        Me.picred.Location = New System.Drawing.Point(24, 72)
        Me.picred.Name = "picred"
        Me.picred.Size = New System.Drawing.Size(40, 32)
        Me.picred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picred.TabIndex = 10
        Me.picred.TabStop = False
        Me.picred.Visible = False
        '
        'picyellow
        '
        Me.picyellow.Image = CType(resources.GetObject("picyellow.Image"), System.Drawing.Bitmap)
        Me.picyellow.Location = New System.Drawing.Point(24, 112)
        Me.picyellow.Name = "picyellow"
        Me.picyellow.Size = New System.Drawing.Size(40, 32)
        Me.picyellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picyellow.TabIndex = 11
        Me.picyellow.TabStop = False
        Me.picyellow.Visible = False
        '
        'picgreen
        '
        Me.picgreen.Image = CType(resources.GetObject("picgreen.Image"), System.Drawing.Bitmap)
        Me.picgreen.Location = New System.Drawing.Point(24, 152)
        Me.picgreen.Name = "picgreen"
        Me.picgreen.Size = New System.Drawing.Size(40, 32)
        Me.picgreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picgreen.TabIndex = 12
        Me.picgreen.TabStop = False
        Me.picgreen.Visible = False
        '
        'picstatus
        '
        Me.picstatus.Location = New System.Drawing.Point(328, 144)
        Me.picstatus.Name = "picstatus"
        Me.picstatus.Size = New System.Drawing.Size(88, 80)
        Me.picstatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picstatus.TabIndex = 13
        Me.picstatus.TabStop = False
        '
        'picnone
        '
        Me.picnone.Location = New System.Drawing.Point(24, 192)
        Me.picnone.Name = "picnone"
        Me.picnone.Size = New System.Drawing.Size(40, 32)
        Me.picnone.TabIndex = 14
        Me.picnone.TabStop = False
        Me.picnone.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.Label1, Me.Label2})
        Me.GroupBox4.Location = New System.Drawing.Point(560, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(152, 144)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Key"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label3.Location = New System.Drawing.Point(24, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Green = Correct"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red = High"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(24, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Yellow = Low"
        '
        'Form1
        '
        Me.AcceptButton = Me.btncheck
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.CancelButton = Me.btnexit
        Me.ClientSize = New System.Drawing.Size(728, 502)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox4, Me.picnone, Me.picstatus, Me.picgreen, Me.picyellow, Me.picred, Me.GroupBox3, Me.Label4, Me.GroupBox2, Me.GroupBox1, Me.txtnumber, Me.lblinstructions})
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Guessing Game"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
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
        average = 0

    End Sub

    Private Sub btncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheck.Click
        If Not IsNumeric(txtnumber.Text) Then
            MessageBox.Show("You must enter a number.", "Alpha-Numeric Error", MessageBoxButtons.OK)
        ElseIf txtnumber.Text > high Or txtnumber.Text < low Then
            MessageBox.Show("You must enter a number between " & low & " and " & high & ".", "Numeric Error", MessageBoxButtons.OK)
        Else
            tries = tries + 1
            totaltries = totaltries + 1
            lbltries.Text = tries
            If txtnumber.Text = num Then 'correct answer
                lblstatus.Text = "Correct!!"
                correct = correct + 1
                lblcorrect.Text = correct
                lblaverage.Text = totaltries / correct
                tries = 0
                btncheck.Enabled = False
                btnreset.Enabled = True
            End If
            If txtnumber.Text = num Then
                lblstatus.Text = "Correct!! You guessed my Number."
                picstatus.Image = picgreen.Image
            ElseIf txtnumber.Text > num Then
                lblstatus.Text = "You're too high."
                picstatus.Image = picred.Image
            ElseIf txtnumber.Text < num Then
                lblstatus.Text = "You're too low."
                picstatus.Image = picyellow.Image
            End If
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
        txtnumber.Text = "0"
        btncheck.Enabled = True
        btnreset.Enabled = False
        picstatus.Image = picnone.Image


    End Sub

    Public Sub reset()
        lblinstructions.Text = "Guess My Number" & ControlChars.NewLine & "Between " & low & " and " & high & "."
        lblstatus.Text = "Enter Your Guess"
        Randomize()
        num = Int(Rnd() * (high - low + 1) + low)
    End Sub
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
