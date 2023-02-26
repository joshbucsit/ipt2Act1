Imports System.Data.OleDb
Public Class frmMain

    Private Sub btnDashboard_MouseHover(sender As Object, e As EventArgs) Handles btnDashboard.MouseHover
        btnDashboard.BackColor = Color.Indigo
        btnDashboard.ForeColor = Color.Lavender
    End Sub

    Private Sub btnDashboard_MouseLeave(sender As Object, e As EventArgs) Handles btnDashboard.MouseLeave
        btnDashboard.BackColor = Color.Transparent

    End Sub

    Private Sub btnStudentProfile_MouseHover(sender As Object, e As EventArgs) Handles btnStudentProfile.MouseHover
        btnStudentProfile.BackColor = Color.Indigo
        btnStudentProfile.ForeColor = Color.Lavender
    End Sub

    Private Sub btnStudentProfile_MouseLeave(sender As Object, e As EventArgs) Handles btnStudentProfile.MouseLeave
        btnStudentProfile.BackColor = Color.Transparent

    End Sub

    Private Sub btnSettings_MouseHover(sender As Object, e As EventArgs) Handles btnSettings.MouseHover
        btnSettings.BackColor = Color.Indigo
        btnSettings.ForeColor = Color.Lavender
    End Sub

    Private Sub btnSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
        btnSettings.BackColor = Color.Transparent
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        btnExit.BackColor = Color.Indigo
        btnExit.ForeColor = Color.Lavender
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = Color.Transparent
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmLogin.Show()
        frmLogin.txtUsername.Text = ""
        frmLogin.txtPassword.Text = ""
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

    End Sub

   
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        pnlMain.Controls.Clear()
        frmSettings.TopLevel = False
        pnlMain.Controls.Add(frmSettings)
        frmSettings.BringToFront()
        frmSettings.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmSettings.Show()
    End Sub

    Private Sub btnStudentProfile_Click(sender As Object, e As EventArgs) Handles btnStudentProfile.Click
        pnlMain.Controls.Clear()
        frmStudProfile.TopLevel = False
        pnlMain.Controls.Add(frmStudProfile)
        frmStudProfile.Dock = DockStyle.Fill
        frmStudProfile.BringToFront()
        frmStudProfile.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmStudProfile.Show()

        frmStudProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

    End Sub
End Class