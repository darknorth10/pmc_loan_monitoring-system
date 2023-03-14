Public Class usrctrlloantransaction
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles cashloantab.Click

    End Sub

    Private Sub tabctrlLoanTrans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabctrlLoanTrans.SelectedIndexChanged
        If tabctrlLoanTrans.SelectedTab Is cashloantab Then
            FRMMAIN.lbltext.Text = "Loan Transaction - Cash Loan"

        ElseIf tabctrlLoanTrans.SelectedTab Is rieloantab Then
            FRMMAIN.lbltext.Text = "Loan Transaction - Rice Loan"
        ElseIf tabctrlLoanTrans.SelectedTab Is gcloantab Then
            FRMMAIN.lbltext.Text = "Loan Transaction - Gift Certificate Loan"

        ElseIf tabctrlLoanTrans.SelectedTab Is othertab Then
            FRMMAIN.lbltext.Text = "Loan Transaction - Others"
        End If
    End Sub
End Class
