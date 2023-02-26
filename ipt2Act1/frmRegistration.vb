Imports System.Data.OleDb
Public Class frmRegistration

    Private Sub btnStudDelete_Click(sender As Object, e As EventArgs) Handles btnStudDelete.Click
        Me.Close()
    End Sub

    Private Sub btnRegAdd_Click(sender As Object, e As EventArgs) Handles btnRegAdd.Click

        Dim yearNSection As String = cbYear.Text + cbSection.Text
        If btnRegAdd.Text = "Add" Then
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

                cmd.ExecuteNonQuery()
                Me.Close()

            End If
            conn.Close()

        ElseIf btnRegAdd.Text = "Update" Then

            'Try
            connect()
                Dim upd As New OleDbCommand("UPDATE tblStudent set [student_ID] = @studentID, [fullName] = @fullname, [address] = @address, [gender] = @gender, [coursemajor] = @coursemajor, [schoolYear] = @schoolYear, [yearNsection] = @yearNSection, [dateOfRegistration] = @dateOfRegistration, [totalUnits] = @totalUnits WHERE ID = @ID", conn)

                'Dim msgSave = MsgBox("Are you sure you want to update?", MsgBoxStyle.YesNo, "Update student data?")
                'If msgSave = MsgBoxResult.Yes Then

                upd.Parameters.AddWithValue("@ID", CInt(txtID.Text))
                upd.Parameters.AddWithValue("@student_ID", CType(txtStudentID.Text, String)) '1
                upd.Parameters.AddWithValue("@fullName", CType(txtFullname.Text, String)) '2
                upd.Parameters.AddWithValue("@address", CType(txtAddress.Text, String)) '3
                upd.Parameters.AddWithValue("@gender", CType(cbGender.Text, String)) '4
                upd.Parameters.AddWithValue("@coursemajor", CType(txtCourse.Text, String)) '5
                upd.Parameters.AddWithValue("@schoolYear", CType(txtSY.Text, String)) '6
                upd.Parameters.AddWithValue("@yearNsection", CType(yearNSection, String)) '7
                upd.Parameters.AddWithValue("@dateOfRegistration", CDate(dtDoR.Text)) '8
                upd.Parameters.AddWithValue("@totalUnits", CInt(txtUnits.Text)) '9


                upd.ExecuteNonQuery()
                Me.Close()

                conn.Close()

            ' Catch ex As Exception
            'MessageBox.Show("Error updating student record: " & ex.Message)
            '
            'End Try

        End If

    End Sub

    Private Sub frmRegistration_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Enabled = True
        frmStudProfile.loadStudents()
        frmStudProfile.displayStatus()

    End Sub

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.Enabled = False
    End Sub
End Class