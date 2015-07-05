Option Explicit On
Public Class frmDeposit

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        'Is there anything in the textbox? No? Then pop up this message box.
        If txtDeposit.Text.Length < 0 Then
            MessageBox.Show("You have not specified the amount you wish to deposit.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Re-direct the user back to the text box
            txtDeposit.Focus()

        Else
            'Deposit the amount specified. After amount is deposited to my.settings.deposit, then message box pops up.
            My.Settings.Deposit += CDec(txtDeposit.Text)
            MessageBox.Show("The funds at which you specified have been deposited.", "System Message", MessageBoxButtons.OK)
        End If

    End Sub
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        'Hides the form, clears the text box, shows the form we want, then closes the old form
        Me.Hide()
        txtDeposit.Clear()
        frmMainMenu.Show()
        Me.Close()

    End Sub

    Private Sub frmDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = txtDeposit
    End Sub
End Class