Option Explicit On '---makes us declare the variable before we move on. 
Public Class frmWithdraw
    Public Shared Property withdraw As String
    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click

        'if the balance is 0 then pop up this message.
        If My.Settings.Balance = "0.00" Then
            MessageBox.Show("Insufficient funds.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            'is there a balance more than 0? Yes? Then dump whatever is in the txtWithdraw txtbox and put into the Application setting called "Withdraw"
            My.Settings.Withdraw -= CDec(txtWithdraw.Text)
            MessageBox.Show("The funds at which you specified have been withdrawn.", "System Message", MessageBoxButtons.OK)
        End If






    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Clears out the textbox, hides the form, brings us another form, and closes the old form. 
        txtWithdraw.Clear()
        Me.Hide()
        frmMainMenu.Show()
        Me.Close()

    End Sub

    Private Sub frmWithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = txtWithdraw
    End Sub
End Class