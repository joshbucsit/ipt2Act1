Imports System.Data.OleDb
Public Class frmLogin
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As New OleDbCommand()

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        connect()
        cmd = New OleDbCommand("Select * from tblUser where username = '" & txtUsername.Text & "' and password='" & txtPassword.Text & "'", conn)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "tblUser")

        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim username As String = ""
        Dim fullname As String = ""
        Dim usertype As String = ""

        While dr.Read
            username = dr("username").ToString
            fullname = dr("fullname").ToString
            usertype = dr("type").ToString
        End While

        If ds.Tables("tblUser").Rows.Count = 1 Then
            If usertype = "Admin" Then
                MsgBox("Welcome " & usertype & ", " & fullname)
                frmSettings.lblDisplayUser.Text = "Welcome " & usertype & ", " & fullname & "!"
                frmStudProfile.lblDisplayUser.Text = "Wlecome " & usertype & ", " & fullname & "!"
            ElseIf usertype = "User" Then
                MsgBox("Welcome " & usertype & ", " & fullname)
                frmSettings.lblDisplayUser.Text = "Welcome " & usertype & ", " & fullname & "!"
                frmStudProfile.lblDisplayUser.Text = "Welcome " & usertype & ", " & fullname & "!"
            End If
            frmMain.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect username and password!", MsgBoxStyle.OkOnly, "Login error!")
        End If
    End Sub

    Private Sub btnLogIn_MouseHover(sender As Object, e As EventArgs)
        btnLogIn.ForeColor = Color.Lavender
        btnLogIn.BackColor = Color.Indigo
        btnLogIn.FlatAppearance.BorderColor = Color.Lavender
        btnLogIn.FlatAppearance.BorderSize = 2
    End Sub

    Private Sub btnLogIn_MouseLeave(sender As Object, e As EventArgs)
        btnLogIn.ForeColor = Color.Indigo
        btnLogIn.BackColor = Color.Lavender
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '3s
        Timer1.Interval = 2500
        Timer1.Start()
    End Sub
    Private counter As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Select Case counter
            Case 0
                PictureBox1.Image = Image.FromFile("5.png")
            Case 1
                PictureBox1.Image = Image.FromFile("3.png")
            Case 2
                PictureBox1.Image = Image.FromFile("1.png")
        End Select

        counter = (counter + 1) Mod 3
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs)
        btnExit.BackColor = Color.Red
        btnExit.ForeColor = Color.Indigo
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs)
        btnExit.BackColor = Color.Transparent
        btnExit.ForeColor = Color.Lavender
    End Sub

    
    
    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
