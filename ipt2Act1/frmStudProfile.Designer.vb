<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudProfile))
        Me.pnlStudProfile = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblDisplayUser = New System.Windows.Forms.Label()
        Me.btnStudDelete = New System.Windows.Forms.Button()
        Me.btnStudUpdate = New System.Windows.Forms.Button()
        Me.btnStudAdd = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cbFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.gbStudent = New System.Windows.Forms.GroupBox()
        Me.dgStudent = New System.Windows.Forms.DataGridView()
        Me.pnlStudProfile.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbStudent.SuspendLayout()
        CType(Me.dgStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlStudProfile
        '
        Me.pnlStudProfile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStudProfile.BackgroundImage = CType(resources.GetObject("pnlStudProfile.BackgroundImage"), System.Drawing.Image)
        Me.pnlStudProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlStudProfile.Controls.Add(Me.GroupBox1)
        Me.pnlStudProfile.Controls.Add(Me.btnPrint)
        Me.pnlStudProfile.Controls.Add(Me.btnSearch)
        Me.pnlStudProfile.Controls.Add(Me.txtSearch)
        Me.pnlStudProfile.Controls.Add(Me.cbFilter)
        Me.pnlStudProfile.Controls.Add(Me.Label1)
        Me.pnlStudProfile.Controls.Add(Me.lblStatus)
        Me.pnlStudProfile.Controls.Add(Me.gbStudent)
        Me.pnlStudProfile.GradientBottomLeft = System.Drawing.Color.Lavender
        Me.pnlStudProfile.GradientBottomRight = System.Drawing.Color.Lavender
        Me.pnlStudProfile.GradientTopLeft = System.Drawing.Color.White
        Me.pnlStudProfile.GradientTopRight = System.Drawing.Color.White
        Me.pnlStudProfile.Location = New System.Drawing.Point(0, 0)
        Me.pnlStudProfile.Name = "pnlStudProfile"
        Me.pnlStudProfile.Quality = 10
        Me.pnlStudProfile.Size = New System.Drawing.Size(1033, 664)
        Me.pnlStudProfile.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Indigo
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lblDisplayUser)
        Me.GroupBox1.Controls.Add(Me.btnStudDelete)
        Me.GroupBox1.Controls.Add(Me.btnStudUpdate)
        Me.GroupBox1.Controls.Add(Me.btnStudAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(995, 92)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ipt2Act1.My.Resources.Resources.logout_indigo
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Indigo
        Me.Button1.Location = New System.Drawing.Point(917, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 68)
        Me.Button1.TabIndex = 35
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblDisplayUser
        '
        Me.lblDisplayUser.AutoSize = True
        Me.lblDisplayUser.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayUser.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayUser.ForeColor = System.Drawing.Color.Lavender
        Me.lblDisplayUser.Location = New System.Drawing.Point(13, 25)
        Me.lblDisplayUser.Name = "lblDisplayUser"
        Me.lblDisplayUser.Size = New System.Drawing.Size(164, 38)
        Me.lblDisplayUser.TabIndex = 1
        Me.lblDisplayUser.Text = "Welcome"
        '
        'btnStudDelete
        '
        Me.btnStudDelete.BackgroundImage = Global.ipt2Act1.My.Resources.Resources.delete_indigo
        Me.btnStudDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStudDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudDelete.ForeColor = System.Drawing.Color.Lavender
        Me.btnStudDelete.Location = New System.Drawing.Point(826, 13)
        Me.btnStudDelete.Name = "btnStudDelete"
        Me.btnStudDelete.Size = New System.Drawing.Size(85, 68)
        Me.btnStudDelete.TabIndex = 32
        Me.btnStudDelete.UseVisualStyleBackColor = True
        '
        'btnStudUpdate
        '
        Me.btnStudUpdate.BackgroundImage = Global.ipt2Act1.My.Resources.Resources.edit_indigo
        Me.btnStudUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStudUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudUpdate.ForeColor = System.Drawing.Color.Indigo
        Me.btnStudUpdate.Location = New System.Drawing.Point(735, 13)
        Me.btnStudUpdate.Name = "btnStudUpdate"
        Me.btnStudUpdate.Size = New System.Drawing.Size(85, 68)
        Me.btnStudUpdate.TabIndex = 33
        Me.btnStudUpdate.UseVisualStyleBackColor = True
        '
        'btnStudAdd
        '
        Me.btnStudAdd.BackgroundImage = Global.ipt2Act1.My.Resources.Resources.add_indigo
        Me.btnStudAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStudAdd.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnStudAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudAdd.ForeColor = System.Drawing.Color.Lavender
        Me.btnStudAdd.Location = New System.Drawing.Point(644, 13)
        Me.btnStudAdd.Name = "btnStudAdd"
        Me.btnStudAdd.Size = New System.Drawing.Size(85, 68)
        Me.btnStudAdd.TabIndex = 1
        Me.btnStudAdd.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = Global.ipt2Act1.My.Resources.Resources.print_Indigo1
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Lavender
        Me.btnPrint.Location = New System.Drawing.Point(558, 611)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(47, 42)
        Me.btnPrint.TabIndex = 40
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.ipt2Act1.My.Resources.Resources.search_indigo1
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Lavender
        Me.btnSearch.Location = New System.Drawing.Point(505, 611)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(47, 42)
        Me.btnSearch.TabIndex = 39
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(333, 618)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(166, 27)
        Me.txtSearch.TabIndex = 38
        '
        'cbFilter
        '
        Me.cbFilter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilter.FormattingEnabled = True
        Me.cbFilter.Items.AddRange(New Object() {"Name", "Address", "Student ID"})
        Me.cbFilter.Location = New System.Drawing.Point(167, 617)
        Me.cbFilter.Name = "cbFilter"
        Me.cbFilter.Size = New System.Drawing.Size(160, 29)
        Me.cbFilter.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(12, 612)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 38)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Filtering Option:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Indigo
        Me.lblStatus.Location = New System.Drawing.Point(626, 613)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(372, 38)
        Me.lblStatus.TabIndex = 34
        Me.lblStatus.Text = "Male: 0  | Female: 0 | Total: 0"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbStudent
        '
        Me.gbStudent.BackColor = System.Drawing.Color.Indigo
        Me.gbStudent.Controls.Add(Me.dgStudent)
        Me.gbStudent.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStudent.ForeColor = System.Drawing.Color.Lavender
        Me.gbStudent.Location = New System.Drawing.Point(12, 106)
        Me.gbStudent.Name = "gbStudent"
        Me.gbStudent.Size = New System.Drawing.Size(995, 503)
        Me.gbStudent.TabIndex = 0
        Me.gbStudent.TabStop = False
        Me.gbStudent.Text = "Students Information"
        '
        'dgStudent
        '
        Me.dgStudent.BackgroundColor = System.Drawing.Color.White
        Me.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStudent.GridColor = System.Drawing.Color.Indigo
        Me.dgStudent.Location = New System.Drawing.Point(11, 28)
        Me.dgStudent.Name = "dgStudent"
        Me.dgStudent.Size = New System.Drawing.Size(973, 463)
        Me.dgStudent.TabIndex = 0
        '
        'frmStudProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 671)
        Me.Controls.Add(Me.pnlStudProfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudProfile"
        Me.pnlStudProfile.ResumeLayout(False)
        Me.pnlStudProfile.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbStudent.ResumeLayout(False)
        CType(Me.dgStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbStudent As System.Windows.Forms.GroupBox
    Friend WithEvents dgStudent As System.Windows.Forms.DataGridView
    Friend WithEvents lblDisplayUser As System.Windows.Forms.Label
    Friend WithEvents pnlStudProfile As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnStudUpdate As System.Windows.Forms.Button
    Friend WithEvents btnStudDelete As System.Windows.Forms.Button
    Friend WithEvents btnStudAdd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
