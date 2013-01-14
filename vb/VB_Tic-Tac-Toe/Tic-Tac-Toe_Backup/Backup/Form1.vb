Public Class Form1
    Inherits System.Windows.Forms.Form
    'Author: Michael Secord
    'Title: Tic-Tac-Toe
    'Purpose: To play a 1 player game of Tic-Tac-Toe against the computer.
    'Date: 5/18/05
    Dim Token As Char
    Dim Player As Integer
    Dim x1, x2, x3, x4, x5, x6, x7, x8, x9, o1, o2, o3, o4, o5, o6, o7, o8, o9, GameOver As Boolean
    Dim wins, losses, ties As Integer


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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents groScore As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblties As System.Windows.Forms.Label
    Friend WithEvents lbllosses As System.Windows.Forms.Label
    Friend WithEvents lblwins As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.groScore = New System.Windows.Forms.GroupBox()
        Me.lblties = New System.Windows.Forms.Label()
        Me.lbllosses = New System.Windows.Forms.Label()
        Me.lblwins = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.groScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(120, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tic-Tac-Toe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.Panel2.Location = New System.Drawing.Point(328, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(16, 344)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.Panel3.Location = New System.Drawing.Point(152, 96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(16, 344)
        Me.Panel3.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.Panel5.Location = New System.Drawing.Point(16, 184)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(488, 16)
        Me.Panel5.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.Panel6.Location = New System.Drawing.Point(16, 304)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(488, 16)
        Me.Panel6.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(32, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 72)
        Me.Button1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LimeGreen
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(208, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 72)
        Me.Button2.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LimeGreen
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(384, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 72)
        Me.Button3.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LimeGreen
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(32, 216)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 72)
        Me.Button4.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LimeGreen
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(208, 216)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 72)
        Me.Button5.TabIndex = 9
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LimeGreen
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(384, 216)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 72)
        Me.Button6.TabIndex = 10
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LimeGreen
        Me.Button7.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(32, 344)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 72)
        Me.Button7.TabIndex = 11
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LimeGreen
        Me.Button8.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(208, 344)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 72)
        Me.Button8.TabIndex = 12
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LimeGreen
        Me.Button9.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(384, 344)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(88, 72)
        Me.Button9.TabIndex = 13
        '
        'lblstatus
        '
        Me.lblstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.Location = New System.Drawing.Point(24, 456)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(288, 32)
        Me.lblstatus.TabIndex = 14
        '
        'btnRestart
        '
        Me.btnRestart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRestart.Location = New System.Drawing.Point(384, 456)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.TabIndex = 15
        Me.btnRestart.Text = "&Restart"
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(480, 456)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.TabIndex = 16
        Me.btnQuit.Text = "E&xit"
        '
        'groScore
        '
        Me.groScore.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblties, Me.lbllosses, Me.lblwins, Me.Label4, Me.Label3, Me.Label2})
        Me.groScore.Location = New System.Drawing.Point(536, 32)
        Me.groScore.Name = "groScore"
        Me.groScore.Size = New System.Drawing.Size(176, 112)
        Me.groScore.TabIndex = 17
        Me.groScore.TabStop = False
        Me.groScore.Text = "Scoreboard"
        '
        'lblties
        '
        Me.lblties.Location = New System.Drawing.Point(104, 88)
        Me.lblties.Name = "lblties"
        Me.lblties.Size = New System.Drawing.Size(48, 16)
        Me.lblties.TabIndex = 5
        '
        'lbllosses
        '
        Me.lbllosses.Location = New System.Drawing.Point(104, 56)
        Me.lbllosses.Name = "lbllosses"
        Me.lbllosses.Size = New System.Drawing.Size(48, 16)
        Me.lbllosses.TabIndex = 4
        '
        'lblwins
        '
        Me.lblwins.Location = New System.Drawing.Point(104, 24)
        Me.lblwins.Name = "lblwins"
        Me.lblwins.Size = New System.Drawing.Size(48, 16)
        Me.lblwins.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ties"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Losses"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Wins"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnRestart
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(728, 494)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.groScore, Me.btnQuit, Me.btnRestart, Me.lblstatus, Me.Button9, Me.Button8, Me.Button7, Me.Button6, Me.Button5, Me.Button4, Me.Button3, Me.Button2, Me.Button1, Me.Label1, Me.Panel3, Me.Panel6, Me.Panel5, Me.Panel2})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Tic-Tac-Toe"
        Me.groScore.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RestartGame()
        lblwins.Text = "0"
        lbllosses.Text = "0"
        lblties.Text = "0"

    End Sub

    Private Sub Button1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Text = Token
        Button1.Enabled = False
        x1 = True
        CheckWinner()

    End Sub

    Private Sub Button2_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Text = Token
        Button2.Enabled = False
        x2 = True
        CheckWinner()

    End Sub

    Private Sub Button3_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Text = Token
        Button3.Enabled = False
        x3 = True
        CheckWinner()

    End Sub

    Private Sub Button4_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Text = Token
        Button4.Enabled = False
        x4 = True
        CheckWinner()

    End Sub

    Private Sub Button5_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Text = Token
        Button5.Enabled = False
        x5 = True
        CheckWinner()

    End Sub

    Private Sub Button6_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Text = Token
        Button6.Enabled = False
        x6 = True
        CheckWinner()

    End Sub

    Private Sub Button7_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Text = Token
        Button7.Enabled = False
        x7 = True
        CheckWinner()

    End Sub

    Private Sub Button8_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button8.Text = Token
        Button8.Enabled = False
        x8 = True
        CheckWinner()

    End Sub

    Private Sub Button9_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button9.Text = Token
        Button9.Enabled = False
        x9 = True
        CheckWinner()

    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        'this is called when the Restart button is pressed
        RestartGame()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'this is called whent he Quit button is pressed
        Close()
    End Sub

    Private Sub NextPlayer()
        If Player = 1 Then
            Token = "X"
            If Not GameOver Then
                lblstatus.Text = "Player " & Player & ": " & "" & Token & ""
            End If
            Player = 2
        ElseIf Player = 2 Then
            Token = "O"
            Player = 1
            ComputerPlay()
        End If
    End Sub

    Private Sub DisplayWinner()
        'display winner message
        lblstatus.Text = "Player " & Token & "' is the winner!"
        If Token = "O" Then
            losses = losses + 1
            lbllosses.Text = losses

        ElseIf Token = "X" Then
            wins = wins + 1
            lblwins.Text = wins
        End If

        'disable all the buttons
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False

    End Sub

    Private Sub CheckWinner()
        'check rows
        If Len(Button1.Text & Button2.Text & Button3.Text) > 0 And Button1.Text = Button2.Text And Button2.Text = Button3.Text Then
            Button1.BackColor = Color.Yellow
            Button2.BackColor = Color.Yellow
            Button3.BackColor = Color.Yellow
            DisplayWinner()

        ElseIf Len(Button4.Text & Button5.Text & Button6.Text) > 0 And Button4.Text = Button5.Text And Button5.Text = Button6.Text Then
            Button4.BackColor = Color.Yellow
            Button5.BackColor = Color.Yellow
            Button6.BackColor = Color.Yellow
            DisplayWinner()

        ElseIf Len(Button7.Text & Button8.Text & Button9.Text) > 0 And Button7.Text = Button8.Text And Button8.Text = Button9.Text Then
            Button7.BackColor = Color.Yellow
            Button8.BackColor = Color.Yellow
            Button9.BackColor = Color.Yellow
            DisplayWinner()

            'check columns
        ElseIf Len(Button1.Text & Button4.Text & Button7.Text) > 0 And Button1.Text = Button4.Text And Button4.Text = Button7.Text Then
            Button1.BackColor = Color.Yellow
            Button4.BackColor = Color.Yellow
            Button7.BackColor = Color.Yellow
            DisplayWinner()

        ElseIf Len(Button2.Text & Button5.Text & Button8.Text) > 0 And Button2.Text = Button5.Text And Button5.Text = Button8.Text Then
            Button2.BackColor = Color.Yellow
            Button5.BackColor = Color.Yellow
            Button8.BackColor = Color.Yellow
            DisplayWinner()

        ElseIf Len(Button3.Text & Button6.Text & Button9.Text) > 0 And Button3.Text = Button6.Text And Button6.Text = Button9.Text Then
            Button3.BackColor = Color.Yellow
            Button6.BackColor = Color.Yellow
            Button9.BackColor = Color.Yellow
            DisplayWinner()

            'check diagonals
        ElseIf Len(Button1.Text & Button5.Text & Button5.Text) > 0 And Button1.Text = Button5.Text And Button5.Text = Button9.Text Then
            Button1.BackColor = Color.Yellow
            Button5.BackColor = Color.Yellow
            Button9.BackColor = Color.Yellow
            DisplayWinner()

        ElseIf Len(Button3.Text & Button5.Text & Button7.Text) > 0 And Button3.Text = Button5.Text And Button5.Text = Button7.Text Then
            Button3.BackColor = Color.Yellow
            Button5.BackColor = Color.Yellow
            Button7.BackColor = Color.Yellow
            DisplayWinner()
        ElseIf Not Button1.Enabled And Not Button2.Enabled And Not Button3.Enabled And Not Button4.Enabled And Not Button5.Enabled And Not Button6.Enabled And Not Button7.Enabled And Not Button8.Enabled And Not Button9.Enabled Then
            lblstatus.Text = "Cat's Game!!"
            GameOver = True
            ties = ties + 1
            lblties.Text = ties
        Else
            If Not GameOver Then
                NextPlayer()
            End If
        End If
    End Sub

    Private Sub RestartGame()
        're-enable the buttons
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        'clear the button labels
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        x1 = False
        x2 = False
        x3 = False
        x4 = False
        x5 = False
        x6 = False
        x7 = False
        x8 = False
        x9 = False
        o1 = False
        o2 = False
        o3 = False
        o4 = False
        o5 = False
        o6 = False
        o7 = False
        o8 = False
        o9 = False


        'set the button background colors
        Button1.BackColor = Color.LimeGreen
        Button2.BackColor = Color.LimeGreen
        Button3.BackColor = Color.LimeGreen
        Button4.BackColor = Color.LimeGreen
        Button5.BackColor = Color.LimeGreen
        Button6.BackColor = Color.LimeGreen
        Button7.BackColor = Color.LimeGreen
        Button8.BackColor = Color.LimeGreen
        Button9.BackColor = Color.LimeGreen

        'set up the new game
        lblstatus.Text = "Player " & Player & ": " & "" & Token & ""
        Player = 2
        Token = "O"
        GameOver = False
        NextPlayer()
    End Sub

    Private Sub Button_click(ByVal button)
        button.text = Token
        button.enabled = False
        CheckWinner()
    End Sub

    Private Sub ComputerPlay()
        'Computer plays to win
        If Button1.Enabled AndAlso ((o2 And o3) Or (o4 And o7) Or (o5 And o9)) Then
            o1 = True
            Button_click(Button1)
        ElseIf Button2.Enabled AndAlso ((o1 And o3) Or (o5 And o8)) Then
            o2 = True
            Button_click(Button2)
        ElseIf Button3.Enabled AndAlso ((o1 And o2) Or (o5 And o7) Or (o6 And o9)) Then
            o3 = True
            Button_click(Button3)
        ElseIf Button4.Enabled AndAlso ((o1 And o7) Or (o5 And o6)) Then
            o4 = True
            Button_click(Button4)
        ElseIf Button5.Enabled AndAlso ((o1 And o9) Or (o2 And o8) Or (o3 And o7) Or (o4 And o6)) Then
            o5 = True
            Button_click(Button5)
        ElseIf Button6.Enabled AndAlso ((o3 And o9) Or (o4 And o5)) Then
            o6 = True
            Button_click(Button6)
        ElseIf Button7.Enabled AndAlso ((o1 And o4) Or (o5 And o3) Or (o8 And o9)) Then
            o7 = True
            Button_click(Button7)
        ElseIf Button8.Enabled AndAlso ((o2 And o5) Or (o7 And o9)) Then
            o8 = True
            Button_click(Button8)
        ElseIf Button9.Enabled AndAlso ((o1 And o5) Or (o3 And o6) Or (o7 And o8)) Then
            o9 = True
            Button_click(Button9)

            'Computer blocks eminent win
        ElseIf Button1.Enabled AndAlso ((x2 And x3) Or (x4 And x7) Or (x5 And x9)) Then
            o1 = True
            Button_click(Button1)
        ElseIf Button2.Enabled AndAlso ((x1 And x3) Or (x5 And x8)) Then
            o2 = True
            Button_click(Button2)
        ElseIf Button3.Enabled AndAlso ((x1 And x2) Or (x5 And x7) Or (x6 And x9)) Then
            o3 = True
            Button_click(Button3)
        ElseIf Button4.Enabled AndAlso ((x1 And x7) Or (x5 And x6)) Then
            o4 = True
            Button_click(Button4)
        ElseIf Button5.Enabled AndAlso ((x1 And x9) Or (x2 And x8) Or (x3 And x7) Or (x4 And x6)) Then
            o5 = True
            Button_click(Button5)
        ElseIf Button6.Enabled AndAlso ((x3 And x9) Or (x4 And x5)) Then
            o6 = True
            Button_click(Button6)
        ElseIf Button7.Enabled AndAlso ((x1 And x4) Or (x5 And x3) Or (x8 And x9)) Then
            o7 = True
            Button_click(Button7)
        ElseIf Button8.Enabled AndAlso ((x2 And x5) Or (x7 And x9)) Then
            o8 = True
            Button_click(Button8)
        ElseIf Button9.Enabled AndAlso ((x1 And x5) Or (x3 And x6) Or (x7 And x8)) Then
            o9 = True
            Button_click(Button9)

            'Computer blocks pattern play
        ElseIf Button9.Enabled AndAlso (x8 And x3) Then
            o9 = True
            Button_click(Button9)

        ElseIf Button5.Enabled AndAlso (x1 Or x3 Or x7 Or x9) Then
            o5 = True
            Button_click(Button5)

            'First available square
        ElseIf Button1.Enabled Then
            o1 = True
            Button_click(Button1)
        ElseIf Button2.Enabled Then
            o2 = True
            Button_click(Button2)
        ElseIf Button3.Enabled Then
            o3 = True
            Button_click(Button3)
        ElseIf Button4.Enabled Then
            o4 = True
            Button_click(Button4)
        ElseIf Button5.Enabled Then
            o5 = True
            Button_click(Button5)
        ElseIf Button6.Enabled Then
            o6 = True
            Button_click(Button6)
        ElseIf Button7.Enabled Then
            o7 = True
            Button_click(Button7)
        ElseIf Button8.Enabled Then
            o8 = True
            Button_click(Button8)
        ElseIf Button9.Enabled Then
            o9 = True
            Button_click(Button9)
        End If
    End Sub

End Class
