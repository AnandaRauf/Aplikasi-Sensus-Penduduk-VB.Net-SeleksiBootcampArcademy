Imports System.Data
Imports System.Data.SqlClient

Public Class registeradmin

    Private Sub RegBut_Click(sender As Object, e As EventArgs) Handles RegBut.Click
        Dim cmd As New SqlCommand
        Dim con As New SqlConnection



        Try



            con.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Data Rauf non Enkripsi Program\Database Sql Server 2014\db_sensus_penduduk_bootcamp_arcademy.mdf;Integrated Security=True;Connect Timeout=30")
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "Insert into tbl_users([Email], [Password], [created_at]) VALUES('" & EmailBox.Text & "','" & PassBox.Text & "', '" & DateAndTime.Today & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Register Succesfull")
            loginadmin.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try


    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, koneksiSQL)

        koneksiSQL.Open()

        command.ExecuteNonQuery()

        koneksiSQL.Close()

    End Sub
    Private Sub QuitBut_Click(sender As Object, e As EventArgs) Handles QuitBut.Click
        Dim vb = MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")
        If vb = vbYes Then

            Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        loginadmin.Show()
        Me.Hide()
    End Sub
End Class