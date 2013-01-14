Public Class GPA
    Inherits System.Windows.Forms.Form
    'Author: Michael Secord
    'Title: GPA Calculator
    'Purpose: To determine a Grade Point Average using only letter grades.
    'Date: 5/16/05

    Const A As Decimal = 4.0
    Const A2 As Decimal = 3.7
    Const B1 As Decimal = 3.3
    Const B2 As Decimal = 3.0
    Const B3 As Decimal = 2.7
    Const C1 As Decimal = 2.3
    Const C2 As Decimal = 2.0
    Const C3 As Decimal = 1.7
    Const D1 As Decimal = 1.3
    Const D2 As Decimal = 1.0
    Const D3 As Decimal = 0.7
    Const F1 As Decimal = 0.0
    Dim number, grade As Decimal
    Dim gpa As Decimal



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
    Friend WithEvents comGPA As System.Windows.Forms.ComboBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtgrades As System.Windows.Forms.TextBox
    Friend WithEvents txtletter As System.Windows.Forms.TextBox
    Friend WithEvents txtgpa As System.Windows.Forms.TextBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GPA))
        Me.comGPA = New System.Windows.Forms.ComboBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnreset = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtgrades = New System.Windows.Forms.TextBox
        Me.txtletter = New System.Windows.Forms.TextBox
        Me.txtgpa = New System.Windows.Forms.TextBox
        Me.btnexit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'comGPA
        '
        Me.comGPA.BackColor = System.Drawing.Color.Navy
        Me.comGPA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comGPA.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comGPA.ForeColor = System.Drawing.Color.White
        Me.comGPA.Items.AddRange(New Object() {"A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F"})
        Me.comGPA.Location = New System.Drawing.Point(232, 60)
        Me.comGPA.Name = "comGPA"
        Me.comGPA.Size = New System.Drawing.Size(121, 26)
        Me.comGPA.TabIndex = 1
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnadd.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(152, 112)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(112, 32)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "&Add Grade"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of Grades Entered:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Grade Letter Average:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Grade Point Average (GPA):"
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnreset.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(88, 344)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(88, 32)
        Me.btnreset.TabIndex = 3
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Enter A Letter Grade:"
        '
        'txtgrades
        '
        Me.txtgrades.BackColor = System.Drawing.Color.Navy
        Me.txtgrades.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrades.ForeColor = System.Drawing.Color.White
        Me.txtgrades.Location = New System.Drawing.Point(264, 184)
        Me.txtgrades.Name = "txtgrades"
        Me.txtgrades.ReadOnly = True
        Me.txtgrades.Size = New System.Drawing.Size(72, 26)
        Me.txtgrades.TabIndex = 7
        Me.txtgrades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtletter
        '
        Me.txtletter.BackColor = System.Drawing.Color.Navy
        Me.txtletter.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtletter.ForeColor = System.Drawing.Color.White
        Me.txtletter.Location = New System.Drawing.Point(264, 232)
        Me.txtletter.Name = "txtletter"
        Me.txtletter.ReadOnly = True
        Me.txtletter.Size = New System.Drawing.Size(72, 26)
        Me.txtletter.TabIndex = 8
        Me.txtletter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtgpa
        '
        Me.txtgpa.BackColor = System.Drawing.Color.Navy
        Me.txtgpa.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgpa.ForeColor = System.Drawing.Color.White
        Me.txtgpa.Location = New System.Drawing.Point(264, 280)
        Me.txtgpa.Name = "txtgpa"
        Me.txtgpa.ReadOnly = True
        Me.txtgpa.Size = New System.Drawing.Size(72, 26)
        Me.txtgpa.TabIndex = 9
        Me.txtgpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnexit.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(240, 344)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(88, 32)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "E&xit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'GPA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(376, 398)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.txtgpa)
        Me.Controls.Add(Me.txtletter)
        Me.Controls.Add(Me.txtgrades)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.comGPA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GPA"
        Me.Text = "GPA Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtgrades.Text = "0"
        txtletter.Text = "NA"
        txtgpa.Text = "NA"
        comGPA.Text = "A"
        gpa = 0
        grade = 0
        number = 0

    End Sub

    Private Sub GPA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtgrades.Text = "0"
        txtletter.Text = "NA"
        txtgpa.Text = "NA"
        comGPA.Text = "A"

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Close()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If comGPA.Text = "A" Then
            grade = grade + A
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number


        ElseIf (comGPA.Text = "A-") Then
            grade = grade + A2
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number

        ElseIf (comGPA.Text = "B+") Then
            grade = grade + B1
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number

        ElseIf (comGPA.Text = "B") Then
            grade = grade + B2
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number

        ElseIf (comGPA.Text = "B-") Then
            grade = grade + B3
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number

        ElseIf (comGPA.Text = "C+") Then
            grade = grade + C1
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number

        ElseIf (comGPA.Text = "C") Then
            grade = grade + C2
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number

        ElseIf (comGPA.Text = "C-") Then
            grade = grade + C3
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number

        ElseIf (comGPA.Text = "D+") Then
            grade = grade + D1
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number

        ElseIf (comGPA.Text = "D") Then
            grade = grade + D2
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number

        ElseIf (comGPA.Text = "D-") Then
            grade = grade + D3
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number

        ElseIf (comGPA.Text = "F") Then
            grade = grade + F1
            number = number + 1
            txtgrades.Text = number
            txtgpa.Text = grade / number
        End If

        If txtgpa.Text = 4.0 Then
            txtletter.Text = "A"
        ElseIf txtgpa.Text >= 3.7 And txtgpa.Text < 4.0 Then
            txtletter.Text = "A-"
        ElseIf txtgpa.Text >= 3.3 And txtgpa.Text < 3.699 Then
            txtletter.Text = "B+"
        ElseIf txtgpa.Text >= 3.0 And txtgpa.Text < 3.299 Then
            txtletter.Text = "B"
        ElseIf txtgpa.Text >= 2.7 And txtgpa.Text < 2.999 Then
            txtletter.Text = "B-"
        ElseIf txtgpa.Text >= 2.3 And txtgpa.Text < 2.699 Then
            txtletter.Text = "C+"
        ElseIf txtgpa.Text >= 2.0 And txtgpa.Text < 2.299 Then
            txtletter.Text = "C"
        ElseIf txtgpa.Text >= 1.7 And txtgpa.Text < 1.999 Then
            txtletter.Text = "C-"
        ElseIf txtgpa.Text >= 1.3 And txtgpa.Text < 1.699 Then
            txtletter.Text = "D+"
        ElseIf txtgpa.Text >= 1.0 And txtgpa.Text < 1.299 Then
            txtletter.Text = "D"
        ElseIf txtgpa.Text >= 0.7 And txtgpa.Text < 0.999 Then
            txtletter.Text = "D-"
        ElseIf txtgpa.Text >= 0 And txtgpa.Text < 0.699 Then
            txtletter.Text = "F"

        End If
    End Sub

End Class
