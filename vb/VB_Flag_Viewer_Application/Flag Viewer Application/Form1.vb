Public Class Form1
    'Project:     Chapter 2 Exercise 2
    'Programmer:  Michael Secord
    'Date:        January 2008
    'Description: This project uses check boxes and radio buttons to change 
    '             a picture box and text boxes.
    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'Exit the Project
        Me.Close()
    End Sub

    Private Sub usRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usRadio.CheckedChanged
        'Select the US Flag
        flagPictureBox.Image = usPictureBox.Image
        Me.countryLabel.Text = "United States"
    End Sub

    Private Sub japanRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles japanRadio.CheckedChanged
        'Select the Japanese Flag
        flagPictureBox.Image = japanPictureBox.Image
        Me.countryLabel.Text = "Japan"
    End Sub

    Private Sub canadaRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles canadaRadio.CheckedChanged
        'Select the Canadian Flag
        flagPictureBox.Image = canadaPictureBox.Image
        Me.countryLabel.Text = "Canada"
    End Sub

    Private Sub mexicoRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mexicoRadio.CheckedChanged
        'Select the Mexican Flag
        flagPictureBox.Image = mexicoPictureBox.Image
        Me.countryLabel.Text = "Mexico"
    End Sub

    Private Sub titleCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles titleCheckBox.CheckedChanged
        'Set Visibility of the Title
        Me.titleLabel.Visible = titleCheckBox.Checked
    End Sub

    Private Sub countryCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countryCheckBox.CheckedChanged
        'Set Visibility of the Country Name
        Me.countryLabel.Visible = countryCheckBox.Checked
    End Sub

    Private Sub programmerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles programmerCheckBox.CheckedChanged
        'Set Visibility of the Programmer Name
        Me.programmerLabel.Visible = programmerCheckBox.Checked
    End Sub
End Class
