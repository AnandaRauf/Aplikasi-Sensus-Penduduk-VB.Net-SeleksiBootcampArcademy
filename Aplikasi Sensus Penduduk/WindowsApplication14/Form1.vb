Public Class Menu_Utama
    Private Sub AboutAppsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAppsToolStripMenuItem.Click
        MessageBox.Show("Version 1.0.0")
        MessageBox.Show("Developed By Ananda Rauf Maududi")
        MessageBox.Show("Developed Date: 03 March 2019")
        MessageBox.Show("Thanks For Using This Apps Desktop")
    End Sub

    Private Sub InstagramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstagramToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.Instagram.com/anandarauf08")
        MessageBox.Show("Thanks For Supporting Me ^-^")
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Me.Hide()
        registeradmin.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        loginadmin.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Dim vb = MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")
        If vb = vbYes Then

            Close()
        Else
            Me.Show()
        End If
    End Sub
End Class
