Option Explicit On '---makes us declare a variable before we move on
Public Class frmRegister

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form opens, set the focus in the txtCreateUsername textbox
        Me.ActiveControl = txtCreateUsername
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'what are in the textboxes? Whatever it is, set the appropriate textboxes to the appropriate Application Settings and save them. 
        My.Settings.Username = txtCreateUsername.Text
        My.Settings.Password = txtCreatePassword.Text
        My.Settings.ConfirmPassword = txtConfirmPassword.Text
        My.Settings.PIN = mskCreatePIN.Text
        My.Settings.ConfirmPIN = mskConfirmPIN.Text
        My.Settings.Save()

        'is the username the user listed at least 5 characters? No? Then pop up this message and put the blinking cursor in this textbox.
        If txtCreateUsername.Text.Length < 4 Then
            MessageBox.Show("Please enter a valid username. Your username must be at least 5 characters long", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'puts the blinking cursor into the textbox
            txtCreateUsername.Focus()

            'is the password the user listed at least 5 characters long? No? Then pop up this messange and put the blinking cursor in this textbox. 
        ElseIf Not txtCreatePassword.Text.Length > 4 Then
            MessageBox.Show("Please enter a valid password. Your password needs to be at least 5 characters long", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'puts the blinking cursor into the textbox
            txtCreatePassword.Focus()

            'do the passwords match with each other? No? Then pop up this message and put the blinking cursor in this textbox.
        ElseIf Not txtConfirmPassword.Text = txtCreatePassword.Text Then
            MessageBox.Show("Your passwords did not match witch each other", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'puts the blinking cursor into the textbox
            txtCreatePassword.Focus()


        ElseIf mskCreatePIN.Text = "" Then
            MessageBox.Show("Please create a valid PIN. Your PIN needs to be 4 characters long", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'puts the blinking cursor into the textbox
            mskCreatePIN.Focus()

            'is there a 4-number PIN? No? Then pop up this message and put the blinking cursor in this masked textbox.
        ElseIf Not IsNumeric(mskCreatePIN.Text.Length > 4) Then
            MessageBox.Show("Please create a valid PIN. Your PIN needs to be 4 characters long", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'puts the blinking cursor into the textbox
            mskCreatePIN.Focus()

            'Did the PIN's match up with each other? No? Then put the blinking cursor into the masked textbox. 
        ElseIf Not mskConfirmPIN.Text = mskCreatePIN.Text Then
            MessageBox.Show("Your PIN's did not match with each other", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'puts the blinking cursor into the textbox
            mskCreatePIN.Focus()


        Else
            'is everything good with their Registration Application? Yes?  Then proceed back to the login screen.
            MessageBox.Show("Account has been created. You will be redirected back to the Login Screen")
            Me.Hide()
            frmLogIn.Show()
            Me.Close()

        End If






    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Do you want to cancel? If the user presses 'Yes'send them back to the login page. If not, disregard. 
        If MessageBox.Show("Are you sure? Clicking 'Yes' will send you back to the Login page.", "Chase Bank", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            frmLogIn.Show()
            Me.Close()
        Else

        End If

    End Sub
End Class