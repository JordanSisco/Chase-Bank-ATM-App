Option Explicit On '---makes us declare a variable before we are to move on.
Public Class PIN
    'declare variable as wrngAttempt and set it to 0
    Dim wrngAttempt As Integer = 0
    Private Sub PIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form opens, set the focus in the txtPINEnter textbox
        Me.ActiveControl = txtPINEnter
    End Sub
    Private Sub btnPINEnter_Click(sender As Object, e As EventArgs) Handles btnPINEnter.Click
        'if the PIN in our textbox is equal to the one in our Application settings, then proceed to the Main Menu form
        If txtPINEnter.Text = My.Settings.ConfirmPIN Then
            'Hides the form, clears the text box, shows the form we want, then closes the old form
            Me.Hide()
            frmMainMenu.Show()
            Me.Close()

            'if the user attempts to login and fails 3 times, then show message, and close the application. 
        ElseIf wrngAttempt = 2 Then
            MessageBox.Show("Login failed. You better start running. The apporopriate authorities have been notified of your criminal attempts.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            'display this message if their PIN is wrong.
        ElseIf MessageBox.Show("The PIN you have entered is invalid", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error) Then
            'each wrong attempt adds 1 to our wrngAttempt variable. Once 3 failed attempts are reached, the application closes.
            wrngAttempt = wrngAttempt + 1
            txtPINEnter.Focus()


        End If


    End Sub
    Private Sub btnPINExit_Click(sender As Object, e As EventArgs) Handles btnPINExit.Click
        If MessageBox.Show("Are you sure? Clicking 'Yes' will send you back to the Login page.", "Chase Bank", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'Hides the form, clears the text box, shows the form we want, then closes the old form
            Me.Hide()
            frmLogIn.Show()
            Me.Close()
        Else

        End If
    End Sub
End Class