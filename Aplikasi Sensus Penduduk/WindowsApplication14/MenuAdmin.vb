Imports System.Data
Imports System.Data.SqlClient
Public Class MenuAdmin
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim vb = MsgBox("Are you sure Logout ?", vbQuestion + vbYesNo, "Confirmation")
        If vb = vbYes Then
            Close()
            koneksiSQL.Close()

        Else
            Me.Show()
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("For Show Data Click Button Show Data !")
    End Sub

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sensus_penduduk_bootcamp_arcademyDataSet.tbl_regions' table. You can move, or remove it, as needed.
        Me.Tbl_regionsTableAdapter.Fill(Me.Db_sensus_penduduk_bootcamp_arcademyDataSet.tbl_regions)

    End Sub

    Private Sub QutBut_Click(sender As Object, e As EventArgs) Handles QutBut.Click
        Dim vb = MsgBox("Are you sure Logout ?", vbQuestion + vbYesNo, "Confirmation")
        If vb = vbYes Then
            Close()
            koneksiSQL.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub ShowBut_Click(sender As Object, e As EventArgs) Handles ShowBut.Click



    End Sub

    Private Sub SaveBut_Click(sender As Object, e As EventArgs) Handles SaveBut.Click
        If NmDrhBox.Text = "" Then
            MsgBox("Your Data Empty !", MsgBoxStyle.Critical, "Data Empty")
            NmDrhBox.Focus()
        Else
            MessageBox.Show("Save Data Succesfull")
        End If
        Dim cons As New SqlConnection
        Dim cmd As New SqlCommand
        Dim waktumsk
        waktumsk = DateAndTime.Today

        Try
            cons.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Data Rauf non Enkripsi Program\Database Sql Server 2014\db_sensus_penduduk_bootcamp_arcademy.mdf;Integrated Security=True;Connect Timeout=30")
            cons.Open()
            cmd.Connection = cons

            Dim SQLCmd
            SQLCmd = New SqlCommand("Select * From tbl_users where ID")
            cmd.CommandText = "Insert into tbl_regions([name],[created_at],[created_by]) VALUES('" & NmDrhBox.Text & "','" & waktumsk & "','" & SQLCmd & "')"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            cons.Close()
        End Try
    End Sub

    Private Sub DelBut_Click(sender As Object, e As EventArgs) Handles DelBut.Click
        If NmDrhBox.Text = "" Then
            MsgBox("Your Data Empty !", MsgBoxStyle.Critical, "Data Empty")
            NmDrhBox.Focus()
        Else
            MessageBox.Show("Delete Data Succesfull")
        End If
        Dim cons As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            cons.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Data Rauf non Enkripsi Program\Database Sql Server 2014\db_sensus_penduduk_bootcamp_arcademy.mdf;Integrated Security=True;Connect Timeout=30")
            cons.Open()
            cmd.Connection = cons
            cmd.CommandText = "Delete From tbl_regions Where ([name], [created_at],[created_by]) VALUES('" & NmDrhBox.Text & "','" & DateAndTime.Today & "','" & "Select * From tbl_users where  ID" & " ')"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
        Finally
            cons.Close()
        End Try
    End Sub
    Sub ShowData()
        Try
            Call konekdatabase()
            Dim da = New SqlDataAdapter("Select * From tbl_regions", koneksiSQL)
            Dim ds = New DataSet
            da.Fill(ds, "tbl_regions")
            RegionsView.DataSource = ds.Tables("tbl_regions")

        Catch ex As Exception
        End Try
    End Sub
End Class