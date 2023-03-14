Public Class FRMMAIN
    Private Sub FRMMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dock dashboard as initial usercontrol to main panel
        pnlmain.Controls.Clear()
        lbltext.Text = "Dashboard"

        Dim D As New usrctrldashboard()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill


    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btnexit.Click

        Dim res As DialogResult
        res = MsgBox("Do you really want to exit the application?", vbYesNo, "System Confirmation")

        If res = DialogResult.Yes Then
            System.Windows.Forms.Application.Exit()
        End If

    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click

        'dock dashboard usercontrol to main panel
        pnlmain.Controls.Clear()
        lbltext.Text = "Dashboard"

        Dim D As New usrctrldashboard()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill



    End Sub

    Private Sub btnusemanagement_Click(sender As Object, e As EventArgs) Handles btnusemanagement.Click
        'dock user management usercontrol to main panel
        pnlmain.Controls.Clear()

        lbltext.Text = "User Management"
        Dim D As New userctrlusermanagement()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub


    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click


        Dim res As DialogResult
        Dim LoginForm As New frmlogin

        res = MsgBox("Are you sure you want to logout?", vbYesNo, "System Notification")

        If res = DialogResult.Yes Then

            Me.Hide()
            LoginForm.Show()

        End If
    End Sub

    Private Sub btnloantransaction_Click(sender As Object, e As EventArgs) Handles btnloantransaction.Click
        'dock loan transaction usercontrol to main panel
        pnlmain.Controls.Clear()

        lbltext.Text = "Loan Transactions - Cash Loan"
        Dim D As New usrctrlloantransaction()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub
End Class
