Public Class frmLightBulb
    Inherits System.Windows.Forms.Form
    'Author: Michael Secord
    'Title: Light Bulb
    'Purpose: To simulate the on and off actions of a lightbulb.
    'Date: 5/12/05
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
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents grpLightSwitch As System.Windows.Forms.GroupBox
    Friend WithEvents radon As System.Windows.Forms.RadioButton
    Friend WithEvents radoff As System.Windows.Forms.RadioButton
    Friend WithEvents picLightBulb As System.Windows.Forms.PictureBox
    Friend WithEvents picOn As System.Windows.Forms.PictureBox
    Friend WithEvents picOff As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLightBulb))
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.grpLightSwitch = New System.Windows.Forms.GroupBox()
        Me.radoff = New System.Windows.Forms.RadioButton()
        Me.radon = New System.Windows.Forms.RadioButton()
        Me.picLightBulb = New System.Windows.Forms.PictureBox()
        Me.picOn = New System.Windows.Forms.PictureBox()
        Me.picOff = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpLightSwitch.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblstatus
        '
        Me.lblstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.Location = New System.Drawing.Point(16, 16)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(184, 32)
        Me.lblstatus.TabIndex = 0
        Me.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpLightSwitch
        '
        Me.grpLightSwitch.Controls.AddRange(New System.Windows.Forms.Control() {Me.radoff, Me.radon, Me.picOff, Me.picOn})
        Me.grpLightSwitch.Location = New System.Drawing.Point(264, 32)
        Me.grpLightSwitch.Name = "grpLightSwitch"
        Me.grpLightSwitch.Size = New System.Drawing.Size(96, 100)
        Me.grpLightSwitch.TabIndex = 1
        Me.grpLightSwitch.TabStop = False
        Me.grpLightSwitch.Text = "Light Switch"
        '
        'radoff
        '
        Me.radoff.Location = New System.Drawing.Point(24, 64)
        Me.radoff.Name = "radoff"
        Me.radoff.Size = New System.Drawing.Size(48, 24)
        Me.radoff.TabIndex = 1
        Me.radoff.Text = "Off"
        '
        'radon
        '
        Me.radon.Location = New System.Drawing.Point(24, 24)
        Me.radon.Name = "radon"
        Me.radon.Size = New System.Drawing.Size(48, 24)
        Me.radon.TabIndex = 0
        Me.radon.Text = "On"
        '
        'picLightBulb
        '
        Me.picLightBulb.Location = New System.Drawing.Point(72, 64)
        Me.picLightBulb.Name = "picLightBulb"
        Me.picLightBulb.Size = New System.Drawing.Size(104, 104)
        Me.picLightBulb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLightBulb.TabIndex = 2
        Me.picLightBulb.TabStop = False
        '
        'picOn
        '
        Me.picOn.Image = CType(resources.GetObject("picOn.Image"), System.Drawing.Bitmap)
        Me.picOn.Location = New System.Drawing.Point(72, 32)
        Me.picOn.Name = "picOn"
        Me.picOn.Size = New System.Drawing.Size(16, 16)
        Me.picOn.TabIndex = 3
        Me.picOn.TabStop = False
        Me.picOn.Visible = False
        '
        'picOff
        '
        Me.picOff.Image = CType(resources.GetObject("picOff.Image"), System.Drawing.Bitmap)
        Me.picOff.Location = New System.Drawing.Point(72, 64)
        Me.picOff.Name = "picOff"
        Me.picOff.Size = New System.Drawing.Size(16, 16)
        Me.picOff.TabIndex = 4
        Me.picOff.TabStop = False
        Me.picOff.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(296, 184)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Exit"
        '
        'frmLightBulb
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 216)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.picLightBulb, Me.grpLightSwitch, Me.lblstatus})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLightBulb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Light Bulb"
        Me.grpLightSwitch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub radon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radon.CheckedChanged
        picLightBulb.Image = picOn.Image
        lblstatus.Text = "The light is on."

    End Sub

    Private Sub radoff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radoff.CheckedChanged
        picLightBulb.Image = picOff.Image
        lblstatus.Text = "The light is off."

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub frmLightBulb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblstatus.Text = "The light is off."
        picLightBulb.Image = picOff.Image

    End Sub
End Class
