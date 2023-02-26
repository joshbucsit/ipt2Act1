<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistration))
        Me.pnlRegister = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.gbStudent = New System.Windows.Forms.GroupBox()
        Me.pbAddStudPhoto = New System.Windows.Forms.PictureBox()
        Me.pbStudphoto = New System.Windows.Forms.PictureBox()
        Me.txtCourse = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStudDelete = New System.Windows.Forms.Button()
        Me.txtUnits = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnRegAdd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStudentID = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.dtDoR = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.cbSection = New System.Windows.Forms.ComboBox()
        Me.txtFullname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSY = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblDisplayUser = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlRegister.SuspendLayout()
        Me.gbStudent.SuspendLayout()
        CType(Me.pbAddStudPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStudphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlRegister
        '
        Me.pnlRegister.BackgroundImage = CType(resources.GetObject("pnlRegister.BackgroundImage"), System.Drawing.Image)
        Me.pnlRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlRegister.Controls.Add(Me.gbStudent)
        Me.pnlRegister.Controls.Add(Me.txtID)
        Me.pnlRegister.Controls.Add(Me.lblDisplayUser)
        Me.pnlRegister.Controls.Add(Me.btnExit)
        Me.pnlRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRegister.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.pnlRegister.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.pnlRegister.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlRegister.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlRegister.Location = New System.Drawing.Point(0, 0)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Quality = 10
        Me.pnlRegister.Size = New System.Drawing.Size(1224, 487)
        Me.pnlRegister.TabIndex = 4
        '
        'gbStudent
        '
        Me.gbStudent.BackColor = System.Drawing.Color.SlateBlue
        Me.gbStudent.Controls.Add(Me.pbAddStudPhoto)
        Me.gbStudent.Controls.Add(Me.pbStudphoto)
        Me.gbStudent.Controls.Add(Me.txtCourse)
        Me.gbStudent.Controls.Add(Me.Label1)
        Me.gbStudent.Controls.Add(Me.btnStudDelete)
        Me.gbStudent.Controls.Add(Me.txtUnits)
        Me.gbStudent.Controls.Add(Me.btnRegAdd)
        Me.gbStudent.Controls.Add(Me.Label10)
        Me.gbStudent.Controls.Add(Me.txtStudentID)
        Me.gbStudent.Controls.Add(Me.dtDoR)
        Me.gbStudent.Controls.Add(Me.Label2)
        Me.gbStudent.Controls.Add(Me.Label8)
        Me.gbStudent.Controls.Add(Me.cbGender)
        Me.gbStudent.Controls.Add(Me.cbSection)
        Me.gbStudent.Controls.Add(Me.txtFullname)
        Me.gbStudent.Controls.Add(Me.Label7)
        Me.gbStudent.Controls.Add(Me.Label9)
        Me.gbStudent.Controls.Add(Me.cbYear)
        Me.gbStudent.Controls.Add(Me.Label3)
        Me.gbStudent.Controls.Add(Me.Label6)
        Me.gbStudent.Controls.Add(Me.txtAddress)
        Me.gbStudent.Controls.Add(Me.txtSY)
        Me.gbStudent.Controls.Add(Me.Label4)
        Me.gbStudent.Controls.Add(Me.Label5)
        Me.gbStudent.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStudent.ForeColor = System.Drawing.Color.Indigo
        Me.gbStudent.Location = New System.Drawing.Point(12, 88)
        Me.gbStudent.Name = "gbStudent"
        Me.gbStudent.Size = New System.Drawing.Size(1200, 374)
        Me.gbStudent.TabIndex = 57
        Me.gbStudent.TabStop = False
        Me.gbStudent.Text = "Student Data"
        '
        'pbAddStudPhoto
        '
        Me.pbAddStudPhoto.Image = Global.ipt2Act1.My.Resources.Resources.camera
        Me.pbAddStudPhoto.Location = New System.Drawing.Point(122, 147)
        Me.pbAddStudPhoto.Name = "pbAddStudPhoto"
        Me.pbAddStudPhoto.Size = New System.Drawing.Size(44, 45)
        Me.pbAddStudPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAddStudPhoto.TabIndex = 57
        Me.pbAddStudPhoto.TabStop = False
        '
        'pbStudphoto
        '
        Me.pbStudphoto.Image = Global.ipt2Act1.My.Resources.Resources.user__1_
        Me.pbStudphoto.Location = New System.Drawing.Point(21, 42)
        Me.pbStudphoto.Name = "pbStudphoto"
        Me.pbStudphoto.Size = New System.Drawing.Size(150, 150)
        Me.pbStudphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbStudphoto.TabIndex = 56
        Me.pbStudphoto.TabStop = False
        '
        'txtCourse
        '
        Me.txtCourse.BackColor = System.Drawing.SystemColors.Window
        Me.txtCourse.BorderColorFocused = System.Drawing.Color.Transparent
        Me.txtCourse.BorderColorIdle = System.Drawing.Color.Transparent
        Me.txtCourse.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.txtCourse.BorderThickness = 1
        Me.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourse.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.ForeColor = System.Drawing.Color.Indigo
        Me.txtCourse.isPassword = False
        Me.txtCourse.Location = New System.Drawing.Point(777, 165)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(397, 40)
        Me.txtCourse.TabIndex = 5
        Me.txtCourse.Text = "Bachelor of Science in Information Technology"
        Me.txtCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(206, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 23)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Student ID:"
        '
        'btnStudDelete
        '
        Me.btnStudDelete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudDelete.ForeColor = System.Drawing.Color.Indigo
        Me.btnStudDelete.Location = New System.Drawing.Point(21, 271)
        Me.btnStudDelete.Name = "btnStudDelete"
        Me.btnStudDelete.Size = New System.Drawing.Size(150, 42)
        Me.btnStudDelete.TabIndex = 11
        Me.btnStudDelete.Text = "Cancel"
        Me.btnStudDelete.UseVisualStyleBackColor = True
        '
        'txtUnits
        '
        Me.txtUnits.BackColor = System.Drawing.SystemColors.Window
        Me.txtUnits.BorderColorFocused = System.Drawing.Color.Transparent
        Me.txtUnits.BorderColorIdle = System.Drawing.Color.Transparent
        Me.txtUnits.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.txtUnits.BorderThickness = 1
        Me.txtUnits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUnits.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnits.ForeColor = System.Drawing.Color.Indigo
        Me.txtUnits.isPassword = False
        Me.txtUnits.Location = New System.Drawing.Point(812, 283)
        Me.txtUnits.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(363, 40)
        Me.txtUnits.TabIndex = 55
        Me.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRegAdd
        '
        Me.btnRegAdd.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegAdd.ForeColor = System.Drawing.Color.Indigo
        Me.btnRegAdd.Location = New System.Drawing.Point(21, 213)
        Me.btnRegAdd.Name = "btnRegAdd"
        Me.btnRegAdd.Size = New System.Drawing.Size(150, 42)
        Me.btnRegAdd.TabIndex = 10
        Me.btnRegAdd.Text = "Add"
        Me.btnRegAdd.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Lavender
        Me.Label10.Location = New System.Drawing.Point(698, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 23)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Total Units:"
        '
        'txtStudentID
        '
        Me.txtStudentID.BackColor = System.Drawing.SystemColors.Window
        Me.txtStudentID.BorderColorFocused = System.Drawing.Color.Transparent
        Me.txtStudentID.BorderColorIdle = System.Drawing.Color.Transparent
        Me.txtStudentID.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentID.BorderThickness = 1
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.ForeColor = System.Drawing.Color.Indigo
        Me.txtStudentID.isPassword = False
        Me.txtStudentID.Location = New System.Drawing.Point(331, 42)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(1)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(332, 40)
        Me.txtStudentID.TabIndex = 1
        Me.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dtDoR
        '
        Me.dtDoR.CalendarFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDoR.CalendarForeColor = System.Drawing.Color.Indigo
        Me.dtDoR.CalendarTitleForeColor = System.Drawing.Color.Indigo
        Me.dtDoR.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDoR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDoR.Location = New System.Drawing.Point(402, 292)
        Me.dtDoR.Name = "dtDoR"
        Me.dtDoR.Size = New System.Drawing.Size(261, 31)
        Me.dtDoR.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lavender
        Me.Label2.Location = New System.Drawing.Point(206, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Fullname:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Lavender
        Me.Label8.Location = New System.Drawing.Point(202, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 23)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Date of Registration:"
        '
        'cbGender
        '
        Me.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.ForeColor = System.Drawing.Color.Indigo
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(331, 165)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(332, 27)
        Me.cbGender.TabIndex = 4
        '
        'cbSection
        '
        Me.cbSection.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSection.ForeColor = System.Drawing.Color.Indigo
        Me.cbSection.FormattingEnabled = True
        Me.cbSection.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cbSection.Location = New System.Drawing.Point(1067, 228)
        Me.cbSection.Name = "cbSection"
        Me.cbSection.Size = New System.Drawing.Size(108, 27)
        Me.cbSection.TabIndex = 8
        '
        'txtFullname
        '
        Me.txtFullname.BackColor = System.Drawing.SystemColors.Window
        Me.txtFullname.BorderColorFocused = System.Drawing.Color.Transparent
        Me.txtFullname.BorderColorIdle = System.Drawing.Color.Transparent
        Me.txtFullname.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.txtFullname.BorderThickness = 1
        Me.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.ForeColor = System.Drawing.Color.Indigo
        Me.txtFullname.isPassword = False
        Me.txtFullname.Location = New System.Drawing.Point(331, 102)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(332, 40)
        Me.txtFullname.TabIndex = 2
        Me.txtFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Lavender
        Me.Label7.Location = New System.Drawing.Point(973, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Section: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Lavender
        Me.Label9.Location = New System.Drawing.Point(206, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 23)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Gender:"
        '
        'cbYear
        '
        Me.cbYear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbYear.ForeColor = System.Drawing.Color.Indigo
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbYear.Location = New System.Drawing.Point(851, 228)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(108, 27)
        Me.cbYear.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(682, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 23)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lavender
        Me.Label6.Location = New System.Drawing.Point(773, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 23)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Year:"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Indigo
        Me.txtAddress.Location = New System.Drawing.Point(777, 42)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(398, 100)
        Me.txtAddress.TabIndex = 3
        '
        'txtSY
        '
        Me.txtSY.BackColor = System.Drawing.SystemColors.Window
        Me.txtSY.BorderColorFocused = System.Drawing.Color.Transparent
        Me.txtSY.BorderColorIdle = System.Drawing.Color.Transparent
        Me.txtSY.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.txtSY.BorderThickness = 1
        Me.txtSY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSY.ForeColor = System.Drawing.Color.Indigo
        Me.txtSY.isPassword = False
        Me.txtSY.Location = New System.Drawing.Point(331, 228)
        Me.txtSY.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSY.Name = "txtSY"
        Me.txtSY.Size = New System.Drawing.Size(332, 27)
        Me.txtSY.TabIndex = 6
        Me.txtSY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lavender
        Me.Label4.Location = New System.Drawing.Point(682, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 23)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Course:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lavender
        Me.Label5.Location = New System.Drawing.Point(202, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 23)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "School Year:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(12, 9)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(77, 20)
        Me.txtID.TabIndex = 56
        Me.txtID.Visible = False
        '
        'lblDisplayUser
        '
        Me.lblDisplayUser.AutoSize = True
        Me.lblDisplayUser.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayUser.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayUser.ForeColor = System.Drawing.Color.Lavender
        Me.lblDisplayUser.Location = New System.Drawing.Point(440, 23)
        Me.lblDisplayUser.Name = "lblDisplayUser"
        Me.lblDisplayUser.Size = New System.Drawing.Size(235, 41)
        Me.lblDisplayUser.TabIndex = 34
        Me.lblDisplayUser.Text = "Add Student "
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1163, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(49, 30)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 487)
        Me.Controls.Add(Me.pnlRegister)
        Me.Name = "frmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student"
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        Me.gbStudent.ResumeLayout(False)
        Me.gbStudent.PerformLayout()
        CType(Me.pbAddStudPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStudphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlRegister As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStudDelete As System.Windows.Forms.Button
    Friend WithEvents btnRegAdd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblDisplayUser As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFullname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtDoR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSY As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCourse As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUnits As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents gbStudent As System.Windows.Forms.GroupBox
    Friend WithEvents pbStudphoto As System.Windows.Forms.PictureBox
    Friend WithEvents pbAddStudPhoto As System.Windows.Forms.PictureBox
End Class
