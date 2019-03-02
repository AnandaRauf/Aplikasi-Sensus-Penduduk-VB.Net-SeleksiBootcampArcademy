Imports System.Data
Imports System.Data.SqlClient
Public Class loginadmin
    Private Sub LogBut_Click(sender As Object, e As EventArgs) Handles LogBut.Click
        Call konekdatabase()
        Dim SQLCmd As New SqlCommand
        Dim DR As SqlDataReader
        SQLCmd = New SqlCommand("Select * From tbl_users where  Email='" & EmailBox.Text & "' and Password='" & PassBox.Text & "'", koneksiSQL)

        DR = SQLCmd.ExecuteReader

        If DR.Read Then

            EmailBox.Focus()
            PassBox.Focus()
            MsgBox("Login Succesfull !")
            Me.Hide()
            MenuAdmin.Show()


        Else
            MsgBox("Sorry Login Failed ! Wrong Email & Password !")

            EmailBox.Clear()

            PassBox.Clear()

            EmailBox.Focus()
        End If
    End Sub
    Private Sub QuitBut_Click(sender As Object, e As EventArgs) Handles QuitBut.Click
        Dim vb = MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")
        If vb = vbYes Then

            Close()
        Else
            Me.Show()
        End If
    End Sub

End Class