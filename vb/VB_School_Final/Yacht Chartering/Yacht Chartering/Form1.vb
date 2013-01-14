Public Class Form1
    'Project:       Yacht Chartering
    'Authors:       Michael Secord
    '               Nicholas Rounsville
    '               Terry Shrum
    'Date:          March 2008
    'Description:   To calculate the total charges for a Yacht Charter based on hours worked,
    '               type of yacht, and length of yacht.

    'Declare Variables
    Private numHours, numTotalEarned, numCharters, numTotalAmtEarned, numTotalHours, numAvgHours As Decimal

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Open About
        About.ShowDialog()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        With Me

            'Check for Responsible Name
            If .txtResponsibleParty.Text = "" Then
                MessageBox.Show("Please enter in a Responsible party name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                .txtResponsibleParty.Focus()
                Exit Sub
            End If

            'Check for number of hours worked
            If .txtHoursWorked.Text = "" Then
                MessageBox.Show("Please enter in the number of hours worked.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                .txtHoursWorked.Focus()
                Exit Sub
            End If
            Try
                'Parse Hours Worked
                .numHours = Decimal.Parse(.txtHoursWorked.Text)
                .numHours > 0
            Catch ex As Exception
                MessageBox.Show("Enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                .txtHoursWorked.Focus()
                Exit Sub
            End Try


            'Check for Yacht Type
            If .cmbYachtType.SelectedIndex = -1 Then
                MessageBox.Show("Please select a type of Yacht.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                .cmbYachtType.Focus()
                Exit Sub
            End If

            'Check for Length of Yacht
            If .cmbYachtLength.SelectedIndex = -1 Then
                MessageBox.Show("Please select a length of Yacht.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                .cmbYachtLength.Focus()
                Exit Sub
            End If

            'Calculate Rate
            Select Case .cmbYachtLength.Text
                Case Is = 22
                    .numTotalEarned += (.numHours * 95.0)
                Case Is = 24
                    .numTotalEarned += (.numHours * 137.0)
                Case Is = 30
                    .numTotalEarned += (.numHours * 160.0)
                Case Is = 32
                    .numTotalEarned += (.numHours * 192.0)
                Case Is = 36
                    .numTotalEarned += (.numHours * 250.0)
                Case Is = 38
                    .numTotalEarned += (.numHours * 400.0)
                Case Is = 45
                    .numTotalEarned += (.numHours * 550.0)
            End Select
            'Update Running Totals
            .numCharters += 1
            .numTotalAmtEarned += .numTotalEarned
            .numTotalHours += .numHours
            .numAvgHours = (.numTotalHours / .numCharters)

            'Display Amount Earned
            .txtCalculatedPrice.Text = .numTotalEarned.ToString("C")
        End With
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        With Me
            'Clear all Entry Fields
            .txtHoursWorked.Text = ""
            .txtResponsibleParty.Text = ""
            .txtCalculatedPrice.Text = ""
            .cmbYachtLength.SelectedIndex = -1
            .cmbYachtType.SelectedIndex = -1

            'Clear all variables
            .numHours = 0
            .numTotalEarned = 0
        End With
    End Sub

    Private Sub ClearForNextCharterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearForNextCharterToolStripMenuItem.Click
        With Me
            'Clear all Entry Fields
            .txtHoursWorked.Text = ""
            .txtResponsibleParty.Text = ""
            .cmbYachtLength.SelectedIndex = -1
            .cmbYachtType.SelectedIndex = -1

            'Clear all variables
            .numHours = 0
            .numTotalEarned = 0
        End With
    End Sub

    Private Sub AddYachtTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddYachtTypeToolStripMenuItem.Click
        'Open Add yacht Form
        AddType.ShowDialog()

    End Sub

    Private Sub RemoveYachtTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveYachtTypeToolStripMenuItem.Click
        'Open Remove Yacht Form
        DeleteType.ShowDialog()
    End Sub

    Private Sub DisplayCountOfYachtTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayCountOfYachtTypesToolStripMenuItem.Click
        'Display yacht Type Count
        With Me
            MessageBox.Show("Number of Yacht Types: " & .cmbYachtType.Items.Count, "Number of Yacht Types", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End With
    End Sub

    Private Sub printSummaryPage_PrintPage(ByVal sender As System.Object, _
    ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printSummaryPage.PrintPage
        'Handles Print Summary Function

        Dim printfont As New Font("Arial", 12)
        Dim headingfont As New Font("Arial Black", 14)
        Dim lineHeightSingle As Single = printfont.GetHeight + 2
        Dim horizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim verticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim printLineString As String
        Dim rightMargin As Integer = e.MarginBounds.Right


        'Set up and display heading lines.
        printLineString = "Yacht Chartering Summary Report"
        e.Graphics.DrawString(printLineString, headingfont, Brushes.Black, _
        horizontalPrintLocationSingle, verticalPrintLocationSingle)
        printLineString = "By: Michael Secord, Nick Rounsville, Terry Shrum"
        verticalPrintLocationSingle += lineHeightSingle
        e.Graphics.DrawString(printLineString, headingfont, Brushes.Black, _
        horizontalPrintLocationSingle, verticalPrintLocationSingle)

        'Blank line between heading and detail
        verticalPrintLocationSingle += lineHeightSingle * 2
        'Setup detail

        rightMargin = 320

        printLineString = "Number of Charters: "
        e.Graphics.DrawString(printLineString, printfont, Brushes.Black, _
        horizontalPrintLocationSingle, verticalPrintLocationSingle)

        printLineString = Me.numCharters
        e.Graphics.DrawString(printLineString, printfont, Brushes.Black, _
        rightMargin, verticalPrintLocationSingle)
        verticalPrintLocationSingle += lineHeightSingle

        printLineString = "Total Revenue: "
        e.Graphics.DrawString(printLineString, printfont, Brushes.Black, _
        horizontalPrintLocationSingle, verticalPrintLocationSingle)

        printLineString = Me.numTotalAmtEarned.ToString("C")
        e.Graphics.DrawString(printLineString, printfont, Brushes.Black, _
        rightMargin, verticalPrintLocationSingle)
        verticalPrintLocationSingle += lineHeightSingle

        printLineString = "Average Hours per Charter: "
        e.Graphics.DrawString(printLineString, printfont, Brushes.Black, _
        horizontalPrintLocationSingle, verticalPrintLocationSingle)

        printLineString = Me.numAvgHours
        e.Graphics.DrawString(printLineString, printfont, Brushes.Black, _
        rightMargin, verticalPrintLocationSingle)
    End Sub

    Private Sub PrintSummaryToolStripMenuItem_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles PrintSummaryToolStripMenuItem.Click
        'Run Print Routine
        With Me
            .PrintPreviewDialog1.Document = .printSummaryPage
            Me.PrintPreviewDialog1.ShowDialog()

        End With
    End Sub

    Private Sub printYachtPage_PrintPage(ByVal sender As System.Object, _
   ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printYachtPage.PrintPage
        'Handles Print Summary Function

        Dim printfont As New Font("Arial", 12)
        Dim headingfont As New Font("Arial Black", 14)
        Dim lineHeightSingle As Single = printfont.GetHeight + 2
        Dim horizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim verticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim printLineString As String

        'Set up and display heading lines.
        printLineString = "Yacht Chartering Yacht Type Report"
        e.Graphics.DrawString(printLineString, headingfont, Brushes.Black, _
        horizontalPrintLocationSingle, verticalPrintLocationSingle)
        printLineString = "By: Michael Secord, Nick Rounsville, Terry Shrum"
        verticalPrintLocationSingle += lineHeightSingle
        e.Graphics.DrawString(printLineString, headingfont, Brushes.Black, _
        horizontalPrintLocationSingle, verticalPrintLocationSingle)

        'Blank line between heading and detail
        verticalPrintLocationSingle += lineHeightSingle * 2
        For index As Integer = 0 To Me.cmbYachtType.Items.Count - 1
            'Setup line
            printLineString = Me.cmbYachtType.Items(index)

            'Send line to graphics page object
            e.Graphics.DrawString(printLineString, printfont, Brushes.Black, _
    horizontalPrintLocationSingle, verticalPrintLocationSingle)

            'Increment for next line
            verticalPrintLocationSingle += lineHeightSingle

        Next index

    End Sub

    Private Sub PrintYachtTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintYachtTypesToolStripMenuItem.Click
        'Run print routine
        Me.PrintPreviewDialog2.Document = Me.printYachtPage
        Me.PrintPreviewDialog2.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Gracefully closes Program
        Me.Close()
    End Sub
End Class
