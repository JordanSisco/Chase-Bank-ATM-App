Option Explicit On '---makes us declare a variable before moving on.
Public Class frmBalance

    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'adds up our withdrawn and deposit balances to our overall total balance. The overall balance is put into the label marked as "lblBalance.Text".
        My.Settings.Balance = My.Settings.Deposit + My.Settings.Withdraw
        lblBalance.Text = FormatNumber(My.Settings.Balance)




    End Sub
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click

        'Hides the form, shows the form we want, then closes the old form
        Me.Hide()
        frmMainMenu.Show()
        Me.Close()

    End Sub
End Class