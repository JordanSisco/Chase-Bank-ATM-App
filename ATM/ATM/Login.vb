'THIS ATM APPLICATION WAS CREATED BY JORDAN SISCO ON 5/16/15
'FOR QUESTIONS AND/OR COMMENTS, CONTACT ME AT jordanpsisco@gmail.com



Option Explicit On '--forces us to declare our variables
Imports System.Text.RegularExpressions  '---Allows us to call and use our application variables between all forms. 
Public Class frmLogIn
    'declare variable as wrngAttempt and set it to 0
    Dim wrngAttempt As Integer = 0
    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form opens, set the focus in the txtUsername textbox
        Me.ActiveControl = txtUsername
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        'if the username in our textbox is equal to the one in our Application settings, and the password in our textbox
        'is equal to the one in our Application settings, then proceed to the PIN form. 
        If txtUsername.Text = My.Settings.Username And txtPassword.Text = My.Settings.ConfirmPassword Then
            'Hides the form, clears the text box, shows the form we want, then closes the old form
            Me.Hide()
            PIN.Show()
            Me.Close()

            'if the user attempts to login and fails 3 times, then show message, and close the application. 
        ElseIf wrngAttempt = 2 Then
            MessageBox.Show("Login failed. You better start running. The apporopriate authorities have been notified of your criminal attempts.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            'display this message if their password/username is wrong.
        ElseIf MessageBox.Show("The username and/or password you entered is wrong", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error) Then
            'each wrong attempt adds 1 to our wrngAttempt variable. Once 3 failed attempts are reached, the application closes.
            wrngAttempt = wrngAttempt + 1
            txtUsername.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure? Clicking 'Yes' will exit this Application.", "Chase Bank", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'Hides the form, clears the text box, shows the form we want, then closes the old form
            Me.Close()
        Else

        End If



    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        'Hides the form, clears the text box, shows the form we want, then closes the old form
        Me.Hide()
        frmRegister.Show()
        Me.Close()


    End Sub
End Class
