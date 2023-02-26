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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnStudAdd = New System.Windows.Forms.Button()
        Me.btnStudUpdate = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnStudDelete = New System.Windows.Forms.Button()
        Me.lblDisplayUser = New System.Windows.Forms.Label()
        Me.gbStudent = New System.Windows.Forms.GroupBox()
        Me.dgStudent = New System.Windows.Forms.DataGridView()
        Me.pnlStudProfile.SuspendLayout()
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
        Me.pnlStudProfile.Controls.Add(Me.Button1)
        Me.pnlStudProfile.Controls.Add(Me.btnStudAdd)
        Me.pnlStudProfile.Controls.Add(Me.btnStudUpdate)
        Me.pnlStudProfile.Controls.Add(Me.lblStatus)
        Me.pnlStudProfile.Controls.Add(Me.btnStudDelete)
        Me.pnlStudProfile.Controls.Add(Me.lblDisplayUser)
        Me.pnlStudProfile.Controls.Add(Me.gbStudent)
        Me.pnlStudProfile.GradientBottomLeft = System.Drawing.Color.Lavender
        Me.pnlStudProfile.GradientBottomRight = System.Drawing.Color.Lavender
        Me.pnlStudProfile.GradientTopLeft = System.Drawing.Color.White
        Me.pnlStudProfile.GradientTopRight = System.Drawing.Color.White
        Me.pnlStudProfile.Location = New System.Drawing.Point(0, 0)
        Me.pnlStudProfile.Name = "pnlStudProfile"
        Me.pnlStudProfile.Quality = 10
        Me.pnlStudProfile.Size = New System.Drawing.Size(1028, 651)
        Me.pnlStudProfile.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ipt2Act1.My.Resources.Resources.logout_indigo
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Indigo
        Me.Button1.Location = New System.Drawing.Point(927, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 68)
        Me.Button1.TabIndex = 35
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnStudAdd
        '
        Me.btnStudAdd.BackgroundImage = Global.ipt2Act1.My.Resources.Resources.add_indigo
        Me.btnStudAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStudAdd.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnStudAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudAdd.ForeColor = System.Drawing.Color.Lavender
        Me.btnStudAdd.Location = New System.Drawing.Point(654, 19)
        Me.btnStudAdd.Name = "btnStudAdd"
        Me.btnStudAdd.Size = New System.Drawing.Size(85, 68)
        Me.btnStudAdd.TabIndex = 1
        Me.btnStudAdd.UseVisualStyleBackColor = True
        '
        'btnStudUpdate
        '
        Me.btnStudUpdate.BackgroundImage = Global.ipt2Act1.My.Resources.Resources.edit_indigo
        Me.btnStudUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStudUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudUpdate.ForeColor = System.Drawing.Color.Indigo
        Me.btnStudUpdate.Location = New System.Drawing.Point(745, 19)
        Me.btnStudUpdate.Name = "btnStudUpdate"
        Me.btnStudUpdate.Size = New System.Drawing.Size(85, 68)
        Me.btnStudUpdate.TabIndex = 33
        Me.btnStudUpdate.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Indigo
        Me.lblStatus.Location = New System.Drawing.Point(456, 589)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(559, 38)
        Me.lblStatus.TabIndex = 34
        Me.lblStatus.Text = "Male: 0  | Female: 0 | Total: 0"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnStudDelete
        '
        Me.btnStudDelete.BackgroundImage = Global.ipt2Act1.My.Resources.Resources.delete_indigo
        Me.btnStudDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStudDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudDelete.ForeColor = System.Drawing.Color.Lavender
        Me.btnStudDelete.Location = New System.Drawing.Point(836, 19)
        Me.btnStudDelete.Name = "btnStudDelete"
        Me.btnStudDelete.Size = New System.Drawing.Size(85, 68)
        Me.btnStudDelete.TabIndex = 32
        Me.btnStudDelete.UseVisualStyleBackColor = True
        '
        'lblDisplayUser
        '
        Me.lblDisplayUser.AutoSize = True
        Me.lblDisplayUser.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayUser.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayUser.ForeColor = System.Drawing.Color.Indigo
        Me.lblDisplayUser.Location = New System.Drawing.Point(9, 34)
        Me.lblDisplayUser.Name = "lblDisplayUser"
        Me.lblDisplayUser.Size = New System.Drawing.Size(164, 38)
        Me.lblDisplayUser.TabIndex = 1
        Me.lblDisplayUser.Text = "Welcome"
        '
        'gbStudent
        '
        Me.gbStudent.BackColor = System.Drawing.Color.Transparent
        Me.gbStudent.Controls.Add(Me.dgStudent)
        Me.gbStudent.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStudent.ForeColor = System.Drawing.Color.Indigo
        Me.gbStudent.Location = New System.Drawing.Point(6, 101)
        Me.gbStudent.Name = "gbStudent"
        Me.gbStudent.Size = New System.Drawing.Size(1009, 486)
        Me.gbStudent.TabIndex = 0
        Me.gbStudent.TabStop = False
        Me.gbStudent.Text = "Students"
        '
        'dgStudent
        '
        Me.dgStudent.BackgroundColor = System.Drawing.Color.White
        Me.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStudent.GridColor = System.Drawing.Color.Indigo
        Me.dgStudent.Location = New System.Drawing.Point(10, 25)
        Me.dgStudent.Name = "dgStudent"
        Me.dgStudent.Size = New System.Drawing.Size(982, 448)
        Me.dgStudent.TabIndex = 11
        '
        'frmStudProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 647)
        Me.Controls.Add(Me.pnlStudProfile)
        Me.Name = "frmStudProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudProfile"
        Me.pnlStudProfile.ResumeLayout(False)
        Me.pnlStudProfile.PerformLayout()
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
End Class
