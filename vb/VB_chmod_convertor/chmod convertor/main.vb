Public Class main
    'Project:       CHMOD Converto
    'Date:          April 2009
    'Programmer:    Michael Secord
    'Description:   This project is designed to convert all values of 
    '               chmod.
    Dim ch1, ch2, ch3, ch4, ch5, ch6, ch7, ch8, ch9 As Integer
    Dim c1, c2, c3, c4, c5, c6, c7, c8, c9 As String

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConvert2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert2.Click
        With Me
            Dim strCh As String = .txtChmod.Text
            Dim str1 As String = "---"
            Dim str2 As String = "---"
            Dim str3 As String = "---"
            If .txtChmod.Text.Length <> 3 Then
                MessageBox.Show("Field should be 3 digits!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                .txtChmod.Focus()
                Exit Sub
            End If
            If strCh.Chars(0) = "0" Then
                .chk1.Checked = False
                .chk4.Checked = False
                .chk7.Checked = False
                str1 = "---"
            End If
            If strCh.Chars(0) = "1" Then
                .chk1.Checked = False
                .chk4.Checked = False
                .chk7.Checked = True
                str1 = "--x"
            End If
            If strCh.Chars(0) = "2" Then
                .chk1.Checked = False
                .chk4.Checked = True
                .chk7.Checked = False
                str1 = "-w-"
            End If
            If strCh.Chars(0) = "3" Then
                .chk1.Checked = False
                .chk4.Checked = True
                .chk7.Checked = True
                str1 = "-wx"
            End If
            If strCh.Chars(0) = "4" Then
                .chk1.Checked = True
                .chk4.Checked = False
                .chk7.Checked = False
                str1 = "r--"
            End If
            If strCh.Chars(0) = "5" Then
                .chk1.Checked = True
                .chk4.Checked = False
                .chk7.Checked = True
                str1 = "r-x"
            End If
            If strCh.Chars(0) = "6" Then
                .chk1.Checked = True
                .chk4.Checked = True
                .chk7.Checked = False
                str1 = "rw-"
            End If
            If strCh.Chars(0) = "7" Then
                .chk1.Checked = True
                .chk4.Checked = True
                .chk7.Checked = True
                str1 = "rwx"
            End If

            If strCh.Chars(1) = "0" Then
                .chk2.Checked = False
                .chk5.Checked = False
                .chk8.Checked = False
                str2 = "---"
            End If
            If strCh.Chars(1) = "1" Then
                .chk2.Checked = False
                .chk5.Checked = False
                .chk8.Checked = True
                str2 = "--x"
            End If
            If strCh.Chars(1) = "2" Then
                .chk2.Checked = False
                .chk5.Checked = True
                .chk8.Checked = False
                str2 = "-w-"
            End If
            If strCh.Chars(1) = "3" Then
                .chk2.Checked = False
                .chk5.Checked = True
                .chk8.Checked = True
                str2 = "-wx"
            End If
            If strCh.Chars(1) = "4" Then
                .chk2.Checked = True
                .chk5.Checked = False
                .chk8.Checked = False
                str2 = "r--"
            End If
            If strCh.Chars(1) = "5" Then
                .chk2.Checked = True
                .chk5.Checked = False
                .chk8.Checked = True
                str2 = "r-x"
            End If
            If strCh.Chars(1) = "6" Then
                .chk2.Checked = True
                .chk5.Checked = True
                .chk8.Checked = False
                str2 = "rw-"
            End If
            If strCh.Chars(1) = "7" Then
                .chk2.Checked = True
                .chk5.Checked = True
                .chk8.Checked = True
                str2 = "rwx"
            End If

            If strCh.Chars(2) = "0" Then
                .chk3.Checked = False
                .chk6.Checked = False
                .chk9.Checked = False
                str3 = "---"
            End If
            If strCh.Chars(2) = "1" Then
                .chk3.Checked = False
                .chk6.Checked = False
                .chk9.Checked = True
                str3 = "--x"
            End If
            If strCh.Chars(2) = "2" Then
                .chk3.Checked = False
                .chk6.Checked = True
                .chk9.Checked = False
                str3 = "-w-"
            End If
            If strCh.Chars(2) = "3" Then
                .chk3.Checked = False
                .chk6.Checked = True
                .chk9.Checked = True
                str3 = "-wx"
            End If
            If strCh.Chars(2) = "4" Then
                .chk3.Checked = True
                .chk6.Checked = False
                .chk9.Checked = False
                str3 = "r--"
            End If
            If strCh.Chars(2) = "5" Then
                .chk3.Checked = True
                .chk6.Checked = False
                .chk9.Checked = True
                str3 = "r-x"
            End If
            If strCh.Chars(2) = "6" Then
                .chk3.Checked = True
                .chk6.Checked = True
                .chk9.Checked = False
                str3 = "rw-"
            End If
            If strCh.Chars(2) = "7" Then
                .chk3.Checked = True
                .chk6.Checked = True
                .chk9.Checked = True
                str3 = "rwx"
            End If
            .txtString.Text = str1 + str2 + str3
        End With
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        With Me
            If .chk1.Checked Then
                .ch1 = 4
                .c1 = "r"
            Else
                .chk1.Checked = False
                .ch1 = 0
                .c1 = "-"
            End If
            If .chk2.Checked Then
                .ch2 = 4
                .c2 = "r"
            Else
                .chk2.Checked = False
                .ch2 = 0
                .c2 = "-"
            End If
            If .chk3.Checked Then
                .ch3 = 4
                .c3 = "r"
            Else
                .chk3.Checked = False
                .ch3 = 0
                .c3 = "-"
            End If
            If .chk4.Checked Then
                .ch4 = 2
                .c4 = "w"
            Else
                .chk4.Checked = False
                .ch4 = 0
                .c4 = "-"
            End If
            If .chk5.Checked Then
                .ch5 = 2
                .c5 = "w"
            Else
                .chk5.Checked = False
                .ch5 = 0
                .c5 = "-"
            End If
            If .chk6.Checked Then
                .ch6 = 2
                .c6 = "w"
            Else
                .chk6.Checked = False
                .ch6 = 0
                .c6 = "-"
            End If
            If .chk7.Checked Then
                .ch7 = 1
                .c7 = "x"
            Else
                .chk7.Checked = False
                .ch7 = 0
                .c7 = "-"
            End If
            If .chk8.Checked Then
                .ch8 = 1
                .c8 = "x"
            Else
                .chk8.Checked = False
                .ch8 = 0
                .c8 = "-"
            End If
            If .chk9.Checked Then
                .ch9 = 1
                .c9 = "x"
            Else
                .chk9.Checked = False
                .ch9 = 0
                .c9 = "-"
            End If

            .txtChmod.Text = .ch1 + .ch4 + .ch7 & .ch2 + .ch5 + .ch8 & .ch3 + .ch6 + .ch9
            .txtString.Text = .c1 & .c4 & .c7 & .c2 & .c5 & .c8 & .c3 & .c6 & .c9
        End With
    End Sub

    Private Sub btnConvert3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert3.Click
        With Me
            Dim strString As String = .txtString.Text
            Dim p1, p2, p3, p4, p5, p6, p7, p8, p9 As Integer
            If .txtString.Text.Length < 9 Then
                MessageBox.Show("String must be 9 Characters!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If
            If strString.Chars(0) = "r" Then
                .chk1.Checked = True
                p1 = 4
            End If
            If strString.Chars(0) = "-" Then
                .chk1.Checked = False
                p1 = 0
            End If

            If strString.Chars(3) = "r" Then
                .chk2.Checked = True
                p2 = 4
            End If
            If strString.Chars(3) = "-" Then
                .chk2.Checked = False
                p2 = 0
            End If

            If strString.Chars(6) = "r" Then
                .chk3.Checked = True
                p3 = 4
            End If
            If strString.Chars(6) = "-" Then
                .chk3.Checked = False
                p3 = 0
            End If

            If strString.Chars(1) = "w" Then
                .chk4.Checked = True
                p4 = 2
            End If
            If strString.Chars(1) = "-" Then
                .chk4.Checked = False
                p4 = 0
            End If

            If strString.Chars(4) = "w" Then
                .chk5.Checked = True
                p5 = 2
            End If
            If strString.Chars(4) = "-" Then
                .chk5.Checked = False
                p5 = 0
            End If

            If strString.Chars(7) = "w" Then
                .chk6.Checked = True
                p6 = 2
            End If
            If strString.Chars(7) = "-" Then
                .chk6.Checked = False
                p6 = 0
            End If

            If strString.Chars(2) = "x" Then
                .chk7.Checked = True
                p7 = 1
            End If
            If strString.Chars(2) = "-" Then
                .chk7.Checked = False
                p7 = 0
            End If

            If strString.Chars(5) = "x" Then
                .chk8.Checked = True
                p8 = 1
            End If
            If strString.Chars(5) = "-" Then
                .chk8.Checked = False
                p8 = 0
            End If

            If strString.Chars(8) = "x" Then
                .chk9.Checked = True
                p9 = 1
            End If
            If strString.Chars(8) = "-" Then
                .chk9.Checked = False
                p9 = 0
            End If
            .txtChmod.Text = p1 + p4 + p7 & p2 + p5 + p8 & p3 + p6 + p9
        End With
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        With Me
            .chk1.Checked = False
            .chk2.Checked = False
            .chk3.Checked = False
            .chk4.Checked = False
            .chk5.Checked = False
            .chk6.Checked = False
            .chk7.Checked = False
            .chk8.Checked = False
            .chk9.Checked = False
            .txtChmod.Text = ""
            .txtString.Text = ""
        End With
    End Sub
End Class
