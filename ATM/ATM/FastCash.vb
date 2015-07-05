Option Explicit On '---makes us declare the variable before moving on.
Public Class frmFastCash
    'Open CD/DVD drive
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hWndCallBack As Integer) As Integer

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Hides the form, shows the form we want, then closes the old form
        Me.Hide()
        frmMainMenu.Show()
        Me.Close()

    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        'If the our total balance is $0 then an error message will pop up saying we have insufficient funds. If not, proceed with the withdrawal.
        If My.Settings.Balance = "0.00" Then
            MessageBox.Show("Insufficient funds.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'is there at least $20.00 in our total balance? Then open the cd drive and withdraw the money.
            mciSendString("set cdaudio door open", 0, 0, 0)
            My.Settings.Withdraw -= "20.00"
            MessageBox.Show("Thanks " & My.Settings.Username & ". You withdrew 20.00.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'after customer dismisses the messagebox, the cd drive closes.
            mciSendString("set cdaudio door closed", 0, 0, 0)
        End If

    End Sub

    Private Sub btn40_Click(sender As Object, e As EventArgs) Handles btn40.Click
        'If the our total balance is $0 then an error message will pop up saying we have insufficient funds. If not, proceed with the withdrawal.
        If My.Settings.Balance = "0.00" Then
            MessageBox.Show("Insufficient funds.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            My.Settings.Withdraw -= "40.00"
            MessageBox.Show("Thanks " & My.Settings.Username & ". You withdrew 40.00.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btn60_Click(sender As Object, e As EventArgs) Handles btn60.Click
        'If the our total balance is $0 then an error message will pop up saying we have insufficient funds. If not, proceed with the withdrawal.
        If My.Settings.Balance = "0.00" Then
            MessageBox.Show("Insufficient funds.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            My.Settings.Withdraw -= "60.00"
            MessageBox.Show("Thanks " & My.Settings.Username & ". You withdrew 60.00.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class