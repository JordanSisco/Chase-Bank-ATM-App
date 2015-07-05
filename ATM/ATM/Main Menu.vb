Option Explicit On 'makes us declare a variable before we are to move on
Public Class frmMainMenu


    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        'when user presses this button, pop up message, if the user clicks yes then re-direct them to the login page. If they press no, disregard.
        If MessageBox.Show("Are you sure? Clicking 'Yes' will send you back to the Login page.", "Chase Bank", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            frmLogIn.Show()
            Me.Close()
        Else

        End If



    End Sub

    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        'sends us to the balance form
        Me.Hide()
        frmBalance.Show()
        Me.Close()

    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        'sends us to the withrdaw form
        Me.Hide()
        frmWithdraw.Show()
        Me.Close()

    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'who signed in? put their name in the label.
        Me.lblTest.Text = My.Settings.Username
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        'sends us to the deposit form.
        Me.Hide()
        frmDeposit.Show()
        Me.Close()

    End Sub

    Private Sub btnFastCash_Click(sender As Object, e As EventArgs) Handles btnFastCash.Click
        'sends us to the fast cash form.
        Me.Hide()
        frmFastCash.Show()
        Me.Close()

    End Sub
End Class