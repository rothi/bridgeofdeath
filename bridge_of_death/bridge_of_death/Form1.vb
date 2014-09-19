Public Class frmBridge

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click

        Dim strName As String = "Ian Roth"
        Dim strGuessName As String = Me.txtName.Text

        Dim strQuest As String = "To Seek the Holy Grail"
        Dim strGuessQuest As String = Me.txtQuest.Text

        Dim strColor As String = "Blue"
        Dim strGuessColor As String = Me.txtColor.Text

        If strGuessName <> "Ian Roth" Then
            Me.lblAnswer.Text = "Wrong Name. You Die"

        ElseIf strGuessQuest <> "To Seek the Holy Grail" Then
            Me.lblAnswer.Text = "That Isn't Your Quest. You Die"

        ElseIf strGuessColor <> "Blue" Then
            Me.lblAnswer.Text = "That Isn't Your Favorite Color. You Die"

        ElseIf strGuessColor = "Blue" Then
            Me.lblAnswer.Text = "You May Pass"

        End If
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Me.lblAnswer.Text = ""
        Me.txtName.Text = ""
        Me.txtQuest.Text = ""
        Me.txtColor.Text = ""
    End Sub
End Class
