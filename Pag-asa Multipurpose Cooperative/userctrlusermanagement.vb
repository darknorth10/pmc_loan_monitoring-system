Public Class userctrlusermanagement
    Private Sub userctrlusermanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtconfirmpass.TextChanged

    End Sub

    Private Sub btnadduser_Click(sender As Object, e As EventArgs) Handles btnadduser.Click
        If txtreguser.Text = "" Or txtregpass.Text = "" Or txtconfirmpass.Text = "" Or cbout.Text = "" Or cbostatus.Text = "" Then
            MsgBox("All fields are required", vbCritical, "Error")
        Else

            If txtregpass.Text = txtconfirmpass.Text Then

                'mysql configs
                con.ConnectionString = My.Settings.pmc_dbConnectionString
                cmd.Connection = con

                'open connection
                con.Open()

                cmd.CommandText = "select * from user_table where username = @un and type = @ut"

                Dim a = cmd.Parameters

                a.Clear()
                a.AddWithValue("un", txtreguser.Text)
                a.AddWithValue("ut", cbout.Text)

                'execute
                cmd.ExecuteNonQuery()

                dr = cmd.ExecuteReader()

                If dr.HasRows Then
                    MsgBox("User already exist", vbCritical, "Error")
                    txtreguser.Text = ""
                    txtreguser.Focus()
                    con.Close()
                Else
                    con.Close()
                    con.Open()

                    cmd.CommandText = "insert into user_table values (Null,@un, @pw, @ut, @st)"

                    Dim b = cmd.Parameters

                    b.Clear()
                    b.AddWithValue("un", txtreguser.Text)
                    b.AddWithValue("pw", txtregpass.Text)
                    b.AddWithValue("ut", cbout.Text)
                    b.AddWithValue("st", cbostatus.Text)
                    'execute
                    cmd.ExecuteNonQuery()

                    dr = cmd.ExecuteReader()

                    MsgBox("Success Adding User", vbInformation, "Success")
                    con.Close()
                    txtreguser.Text = ""
                    txtregpass.Text = ""
                    txtconfirmpass.Text = ""
                    cbout.Text = ""
                    cbostatus.Text = ""

                End If
            Else
                MsgBox("password does not match", vbCritical, "error")


            End If
        End If
    End Sub
End Class
