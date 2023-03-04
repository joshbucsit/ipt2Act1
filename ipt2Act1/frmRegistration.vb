Imports System.Data.OleDb
Imports System.IO

Public Class frmRegistration
    Dim yearNSection As String
    Private Sub btnStudDelete_Click(sender As Object, e As EventArgs) Handles btnStudDelete.Click
        Me.Close()
    End Sub

    Private Sub btnRegAdd_Click(sender As Object, e As EventArgs) Handles btnRegAdd.Click
        yearNSection = cbYear.Text + cbSection.Text
        If btnRegAdd.Text = "Save" Then
            Dim cmd As New OleDb.OleDbCommand("INSERT INTO tblStudent ([student_ID], [fullname], [address], [gender], [coursemajor], [schoolyear], [yearNsection], [dateOfRegistration], [totalUnits]) VALUES (@student_ID, @fullname, @address, @gender, @coursemajor, @schoolyear, @yearNsection, @dateOfRegistration, @totalUnits)", conn)

            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter

            connect()

            cmd.Parameters.AddWithValue("@student_ID", CType(txtStudentID.Text, String)) '1
            cmd.Parameters.AddWithValue("@fullName", CType(txtFullname.Text, String)) '2
            cmd.Parameters.AddWithValue("@address", CType(txtAddress.Text, String)) '3
            cmd.Parameters.AddWithValue("@gender", CType(cbGender.Text, String)) '4
            cmd.Parameters.AddWithValue("@coursemajor", CType(txtCourse.Text, String)) '5
            cmd.Parameters.AddWithValue("@schoolYear", CType(txtSY.Text, String)) '6
            cmd.Parameters.AddWithValue("@yearNsection", CType(yearNSection, String)) '7
            cmd.Parameters.AddWithValue("@dateOfRegistration", CType(dtDoR.Text, Date)) '8
            cmd.Parameters.AddWithValue("@totalUnits", CType(txtUnits.Text, Integer)) '9

            Dim msgSave = MsgBox("Are you sure you want to save?", MsgBoxStyle.YesNo, "Save user?")
            If msgSave = MsgBoxResult.Yes Then

                'save the picture
                Dim savepicture As String
                savepicture = Application.StartupPath & "\StudentID\" & txtStudentID.Text & ".jpg"
                pbStudphoto.Image.Save(savepicture)


                cmd.ExecuteNonQuery()
                Me.Close()

            End If



            conn.Close()

        ElseIf btnRegAdd.Text = "Update" Then
            yearNSection = cbYear.Text + cbSection.Text

            Try
                connect()
                Dim upd As New OleDbCommand("UPDATE tblStudent set [student_ID] = @studentID, [fullName] = @fullname, [address] = @address, [gender] = @gender, [coursemajor] = @coursemajor, [schoolYear] = @schoolYear, [yearNsection] = @yearNSection, [dateOfRegistration] = @dateOfRegistration, [totalUnits] = @totalUnits WHERE student_ID = '" & txtStudentID.Text & "'", conn)

                Dim msgSave = MsgBox("Are you sure you want to update?", MsgBoxStyle.YesNo, "Update student data?")
                If msgSave = MsgBoxResult.Yes Then

                    upd.Parameters.AddWithValue("@student_ID", CStr(txtStudentID.Text)) '1
                    upd.Parameters.AddWithValue("@fullName", CStr(txtFullname.Text)) '2
                    upd.Parameters.AddWithValue("@address", CStr(txtAddress.Text)) '3
                    upd.Parameters.AddWithValue("@gender", CStr(cbGender.Text)) '4
                    upd.Parameters.AddWithValue("@coursemajor", CStr(txtCourse.Text)) '5
                    upd.Parameters.AddWithValue("@schoolYear", CStr(txtSY.Text)) '6
                    upd.Parameters.AddWithValue("@yearNsection", CStr(yearNSection)) '7
                    upd.Parameters.AddWithValue("@dateOfRegistration", CDate(dtDoR.Text)) '8
                    upd.Parameters.AddWithValue("@totalUnits", CInt(txtUnits.Text)) '9


                    'save the picture
                    Dim savepicture As String
                    savepicture = Application.StartupPath & "\StudentID\" & txtStudentID.Text & ".jpg"
                    pbStudphoto.Image.Save(savepicture)

                    upd.ExecuteNonQuery()


                    Me.Close()


                    conn.Close()
                End If

            Catch ex As Exception
                MessageBox.Show("Error updating student record: " & ex.Message)
            End Try

        End If

    End Sub

    Private Sub frmRegistration_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Enabled = True
        frmStudProfile.loadStudents()
        frmStudProfile.displayStatus()

    End Sub

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.Enabled = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.pnlRegister.BorderStyle = BorderStyle.FixedSingle
        Me.pnlRegister.BackColor = Color.Indigo

    End Sub

    Private Sub pbAddStudPhoto_Click(sender As Object, e As EventArgs) Handles pbAddStudPhoto.Click
        If btnRegAdd.Text = "Add" And txtStudentID.Text = "" Then
            MsgBox("Please fill out ID number first!", MsgBoxStyle.Exclamation)
        ElseIf btnRegAdd.Text = "Update" Then
            Using pbAddStudPhoto As OpenFileDialog = New OpenFileDialog()
                If pbAddStudPhoto.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pbStudphoto.Image = Image.FromFile(pbAddStudPhoto.FileName)
                End If
            End Using
        Else
            Using pbAddStudPhoto As OpenFileDialog = New OpenFileDialog()
                If pbAddStudPhoto.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pbStudphoto.Image = Image.FromFile(pbAddStudPhoto.FileName)
                End If
            End Using
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        btnExit.BackColor = Color.Red
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = Color.Transparent
    End Sub


End Class