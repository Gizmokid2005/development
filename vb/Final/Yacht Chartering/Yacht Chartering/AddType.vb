Public Class AddType

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        With Me
            'Check for Entered Text
            If .txtEnterYacht.Text = "" Then
                MessageBox.Show("Please Enter a yacht type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'Check for Duplicate Values
            If Form1.cmbYachtType.Items.Contains(.txtEnterYacht.Text) Then
                MessageBox.Show("This Yacht Type already exists!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                .txtEnterYacht.Focus()
            End If

            'Add Yacht type to group box
            Form1.cmbYachtType.Items.Add(.txtEnterYacht.Text)

            'Reset Focus
            .txtEnterYacht.Text = ""
            .txtEnterYacht.Focus()
        End With
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        With Me
            'Cancel Entry
            Me.Close()
            Me.Dispose()
        End With
    End Sub
End Class