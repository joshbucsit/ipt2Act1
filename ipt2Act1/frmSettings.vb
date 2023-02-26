Imports System.Data.OleDb
Public Class frmSettings
    Function loadUsers()
        Dim da As New OleDbDataAdapter("Select * from tblUser", conn)
        Dim ds As New DataSet
        da.Fill(ds, "tblUser")
        dgUsers.DataSource = ds.Tables("tblUser").DefaultView
        Return True
    End Function

    Function clearInput()
        txtUsername.Clear()
        txtPassword.Clear()
        txtFullname.Clear()
        cmdAccountType.SelectedIndex = -1
        Return True
    End Function

    Function disableInput()
        txtFullname.Enabled = False
        txtPassword.Enabled = False
        txtUsername.Enabled = False
        cmdAccountType.Enabled = False
        Return True
    End Function


    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            loadUsers()

            dgUsers.Font = New Font("Century Gothic", 14)
            dgUsers.ForeColor = Color.Indigo

            dgUsers.Columns("username").HeaderText = "Username"
            dgUsers.Columns("username").ReadOnly = True

            dgUsers.Columns("password").HeaderText = "Password"
            dgUsers.Columns("password").ReadOnly = True

            dgUsers.Columns("fullname").HeaderText = "Full Name"
            dgUsers.Columns("fullname").ReadOnly = True

            dgUsers.Columns("type").HeaderText = "User Type"
            dgUsers.Columns("fullname").ReadOnly = True

            dgUsers.Columns("password").Visible = False

            disableInput()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If btnNew.Text = "New" Then
            btnNew.Text = "Add"
            btnDelete.Text = "Cancel"
            clearInput()


            txtUsername.Enabled = True
            txtPassword.Enabled = True
            txtFullname.Enabled = True
            cmdAccountType.Enabled = True
            txtUsername.Focus()
        ElseIf btnNew.Text = "Add" Then
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter

            conn.Open()

            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO tblUser  VALUES   ('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & txtFullname.Text & "', '" & cmdAccountType.Text & "')"

            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@Fullname", txtFullname.Text)
            cmd.Parameters.AddWithValue("@AccountType", cmdAccountType.Text)

            Dim msgSave = MsgBox("Are you sure you want to save?", MsgBoxStyle.YesNo, "Save user?")
            If msgSave = MsgBoxResult.Yes Then
                cmd.ExecuteNonQuery()
            End If
            loadUsers()
            clearInput()
            btnDelete.Text = "Delete"
            disableInput()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "Cancel" Then
            clearInput()
            btnDelete.Text = "Delete"
            btnNew.Text = "New"
            disableInput()
        ElseIf btnDelete.Text = "Delete" Then
            connect()
            Dim cmd As New OleDbCommand("Delete * from tblUser where username='" & txtUsername.Text & "'", conn)

            Dim msgSave = MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "Confirm delete?")
            If msgSave = MsgBoxResult.Yes Then
                cmd.ExecuteNonQuery()
            End If

            loadUsers()
            clearInput()

        End If
    End Sub

    Private Sub dgUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsers.CellContentClick

    End Sub

    Private Sub dgUsers_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsers.CellEnter
        btnNew.Text = "New"
        btnDelete.Text = "Delete"
        txtUsername.Text = dgUsers.CurrentRow.Cells(0).Value.ToString
        txtPassword.Text = dgUsers.CurrentRow.Cells(1).Value.ToString
        txtFullname.Text = dgUsers.CurrentRow.Cells(2).Value.ToString
        cmdAccountType.Text = dgUsers.CurrentRow.Cells(3).Value.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class