Public Class DeleteType

    Private Sub DeleteType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me
            'Clear and update Combo Box
            .cmbYachtType.Items.Clear()

            For index As Integer = 0 To Form1.cmbYachtType.Items.Count - 1
                .cmbYachtType.Items.Add(Form1.cmbYachtType.Items.Item(index))
            Next
            .cmbYachtType.Focus()

        End With
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        With Me
            'Check for enter Yacht
            If .cmbYachtType.Text = "" Then
                MessageBox.Show("Please select a Yacht Type to remove!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                .cmbYachtType.Focus()
            End If

            'Delete Current Yacht Type
            Form1.cmbYachtType.Items.Remove(.cmbYachtType.Text)
            cmbYachtType.Items.Remove(.cmbYachtType.Text)

            'Reset Form
            .cmbYachtType.Text = ""
            .cmbYachtType.Focus()
        End With
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Close Form
        Me.Close()
        Me.Dispose()

    End Sub
End Class