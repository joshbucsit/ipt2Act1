Imports System.Data.OleDb
Imports System.IO

Public Class frmStudProfile

    Function loadStudents()
        Dim da As New OleDbDataAdapter("Select * from tblStudent ORDER BY ID ASC", conn)
        Dim ds As New DataSet
        da.Fill(ds, "tblStudent")
        dgStudent.DataSource = ds.Tables("tblStudent").DefaultView
        Return True
    End Function

    Function displayStatus()
        Dim totalMale As Integer
        Dim totalFemale As Integer
        Dim totalStudent As Integer

        Dim da1 As New OleDb.OleDbDataAdapter("SELECT * FROM tblStudent WHERE gender = 'Male'", conn)
        Dim dt1 As New DataTable

        da1.Fill(dt1)
        totalMale = dt1.Rows.Count

        Dim da2 As New OleDb.OleDbDataAdapter("SELECT * FROM tblStudent WHERE gender = 'Female'", conn)
        Dim dt2 As New DataTable

        da2.Fill(dt2)
        totalFemale = dt2.Rows.Count

        totalStudent = totalMale + totalFemale

        lblStatus.Text = "Male: " & totalMale & " | " & "Female: " & totalFemale & " | " & "Total: " & totalStudent

        Return True

    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmStudProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadStudents()

        dgStudent.Font = New Font("Century Gothic", 10)
        dgStudent.ForeColor = Color.Indigo


        dgStudent.Columns("ID").Width = 40
        dgStudent.Columns("ID").HeaderText = "Nos."
        dgStudent.Columns("ID").ReadOnly = True

        dgStudent.Columns("student_ID").Width = 140
        dgStudent.Columns("student_ID").HeaderText = "Student ID"
        dgStudent.Columns("student_ID").ReadOnly = True

        dgStudent.Columns("fullName").Width = 180
        dgStudent.Columns("fullName").HeaderText = "Full Name"
        dgStudent.Columns("fullName").ReadOnly = True

        dgStudent.Columns("address").Width = 180
        dgStudent.Columns("address").HeaderText = "Address"
        dgStudent.Columns("address").ReadOnly = True

        dgStudent.Columns("gender").Width = 80
        dgStudent.Columns("gender").HeaderText = "Gender"
        dgStudent.Columns("gender").ReadOnly = True

        dgStudent.Columns("coursemajor").Width = 120
        dgStudent.Columns("coursemajor").HeaderText = "Course/Major"
        dgStudent.Columns("coursemajor").ReadOnly = True


        dgStudent.Columns("yearNsection").Width = 60
        dgStudent.Columns("yearNsection").HeaderText = "Yr & Sec"
        dgStudent.Columns("yearNsection").ReadOnly = True
        dgStudent.Columns("yearNsection").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgStudent.Columns("dateOfRegistration").Width = 150
        dgStudent.Columns("dateOfRegistration").HeaderText = "Date of Registration"
        dgStudent.Columns("dateOfRegistration").ReadOnly = True
        dgStudent.Columns("dateOfRegistration").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgStudent.Columns("schoolYear").Width = 100
        dgStudent.Columns("schoolYear").HeaderText = "School Year"
        dgStudent.Columns("schoolYear").ReadOnly = True
        dgStudent.Columns("schoolYear").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgStudent.Columns("totalUnits").Width = 60
        dgStudent.Columns("totalUnits").HeaderText = "Total Units"
        dgStudent.Columns("totalUnits").ReadOnly = True
        dgStudent.Columns("totalUnits").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        displayStatus()

    End Sub

    Private Sub btnStudAdd_Click(sender As Object, e As EventArgs) Handles btnStudAdd.Click
        frmRegistration.Show()
        frmRegistration.pbStudphoto.Image = My.Resources.user__1_
        frmRegistration.txtStudentID.Text = ""
        frmRegistration.txtFullname.Text = ""
        frmRegistration.txtAddress.Text = ""
        frmRegistration.cbGender.Text = ""
        frmRegistration.txtCourse.Text = ""
        frmRegistration.txtSY.Text = ""
        frmRegistration.cbYear.Text = ""
        frmRegistration.cbSection.Text = ""
        frmRegistration.dtDoR.Text = ""
        frmRegistration.txtUnits.Text = ""

        frmRegistration.txtStudentID.Focus()

    End Sub

    Private Sub btnStudDelete_Click(sender As Object, e As EventArgs) Handles btnStudDelete.Click
        Dim cmd As New OleDb.OleDbCommand("DELETE * from tblStudent WHERE student_ID = '" & dgStudent.CurrentRow.Cells(1).Value & "'", conn)
        Dim msgSave = MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "Confirm delete?")
        If msgSave = MsgBoxResult.Yes Then
            connect()
            cmd.ExecuteNonQuery()
        End If
        'Deletes the photo ID of the student
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\StudentID\" & frmRegistration.txtStudentID.Text & ".jpg") = True Then
            Kill(Application.StartupPath & "\StudentID\" & frmRegistration.txtStudentID.Text & ".jpg")
        End If
        loadStudents()
    End Sub

    Private Sub dgStudent_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgStudent.CellEnter

        Dim yNs As String
        Dim year As String
        Dim section As String


        frmRegistration.txtID.Text = Integer.Parse(dgStudent.CurrentRow.Cells(0).Value.ToString)
        frmRegistration.txtStudentID.Text = dgStudent.CurrentRow.Cells(1).Value.ToString
        frmRegistration.txtFullname.Text = dgStudent.CurrentRow.Cells(2).Value.ToString
        frmRegistration.txtAddress.Text = dgStudent.CurrentRow.Cells(3).Value.ToString
        frmRegistration.cbGender.Text = dgStudent.CurrentRow.Cells(4).Value.ToString
        frmRegistration.txtCourse.Text = dgStudent.CurrentRow.Cells(5).Value.ToString
        frmRegistration.txtSY.Text = dgStudent.CurrentRow.Cells(6).Value.ToString

        yNs = dgStudent.CurrentRow.Cells(7).Value.ToString

        Dim arryNs As Char() = yNs.ToCharArray()
        year = arryNs(0)
        section = arryNs(1)
        frmRegistration.cbYear.Text = year
        frmRegistration.cbSection.Text = section

        frmRegistration.dtDoR.Text = dgStudent.CurrentRow.Cells(8).Value.ToString
        frmRegistration.txtUnits.Text = dgStudent.CurrentRow.Cells(9).Value.ToString

        'Display the picture of the student
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\StudentID\" & frmRegistration.txtStudentID.Text & ".jpg") = False Then
            frmRegistration.pbStudphoto.Image = My.Resources.user__1_
            Exit Sub
        End If

        'Set the picture to the picture box
        Dim savepicture As String
        savepicture = Application.StartupPath & "\StudentID\" & frmRegistration.txtStudentID.Text & ".jpg"

        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(savepicture, IO.FileMode.Open, IO.FileAccess.Read)
        frmRegistration.pbStudphoto.Image = System.Drawing.Image.FromStream(fs)
        fs.Dispose()

    End Sub

    Private Sub btnStudUpdate_Click(sender As Object, e As EventArgs) Handles btnStudUpdate.Click
        frmRegistration.Show()
        frmRegistration.btnRegAdd.Text = "Update"
        frmRegistration.lblDisplayUser.Text = "Update Student Data"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbFilter.Text = "Name" Then
            Dim da As New OleDbDataAdapter("Select * from tblStudent Where fullName like '%" & txtSearch.Text & "%' order by ID asc", conn)
            Dim dset As New DataSet
            da.Fill(dset, "tblStudent")
            dgStudent.DataSource = dset.Tables("tblStudent").DefaultView
        ElseIf cbFilter.Text = "Address" Then
            Dim da As New OleDbDataAdapter("Select * from tblStudent Where address like '%" & txtSearch.Text & "%' order by ID asc", conn)
            Dim dset As New DataSet
            da.Fill(dset, "tblStudent")
            dgStudent.DataSource = dset.Tables("tblStudent").DefaultView
        ElseIf cbFilter.Text = "Student ID" Then
            Dim da As New OleDbDataAdapter("Select * from tblStudent Where student_ID like '%" & txtSearch.Text & "%' order by ID asc", conn)
            Dim dset As New DataSet
            da.Fill(dset, "tblStudent")
            dgStudent.DataSource = dset.Tables("tblStudent").DefaultView
        End If


    End Sub

End Class