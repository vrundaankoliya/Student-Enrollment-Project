<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashbord1
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnEnrollment = New System.Windows.Forms.Button
        Me.btnSubject = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnFaculty = New System.Windows.Forms.Button
        Me.btnCourse = New System.Windows.Forms.Button
        Me.btnCollege = New System.Windows.Forms.Button
        Me.btnUser = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTotalCollege = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblTotalFaculty = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblTotalSubject = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTotalCourse = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTotalEnrollment = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1286, 564)
        Me.Panel1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnEnrollment)
        Me.GroupBox1.Controls.Add(Me.btnSubject)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnFaculty)
        Me.GroupBox1.Controls.Add(Me.btnCourse)
        Me.GroupBox1.Controls.Add(Me.btnCollege)
        Me.GroupBox1.Controls.Add(Me.btnUser)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1262, 536)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dashbord"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.stu_enroll.My.Resources.Resources.images_4
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(538, 49)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(73, 72)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnEnrollment
        '
        Me.btnEnrollment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrollment.Image = Global.stu_enroll.My.Resources.Resources.Groups_Meeting_Dark_icon
        Me.btnEnrollment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEnrollment.Location = New System.Drawing.Point(198, 338)
        Me.btnEnrollment.Name = "btnEnrollment"
        Me.btnEnrollment.Size = New System.Drawing.Size(147, 148)
        Me.btnEnrollment.TabIndex = 5
        Me.btnEnrollment.Text = "Enrollment"
        Me.btnEnrollment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEnrollment.UseVisualStyleBackColor = True
        '
        'btnSubject
        '
        Me.btnSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubject.Image = Global.stu_enroll.My.Resources.Resources.Books_1_icon
        Me.btnSubject.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSubject.Location = New System.Drawing.Point(32, 338)
        Me.btnSubject.Name = "btnSubject"
        Me.btnSubject.Size = New System.Drawing.Size(147, 148)
        Me.btnSubject.TabIndex = 4
        Me.btnSubject.Text = "Subject"
        Me.btnSubject.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSubject.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.stu_enroll.My.Resources.Resources.Courses_icon
        Me.Button1.Location = New System.Drawing.Point(32, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 148)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Course"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnFaculty
        '
        Me.btnFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaculty.Image = Global.stu_enroll.My.Resources.Resources.accounts
        Me.btnFaculty.Location = New System.Drawing.Point(198, 184)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.Size = New System.Drawing.Size(147, 148)
        Me.btnFaculty.TabIndex = 3
        Me.btnFaculty.Text = "Faculty"
        Me.btnFaculty.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFaculty.UseVisualStyleBackColor = True
        '
        'btnCourse
        '
        Me.btnCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourse.Image = Global.stu_enroll.My.Resources.Resources.Courses_icon
        Me.btnCourse.Location = New System.Drawing.Point(32, 211)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Size = New System.Drawing.Size(107, 76)
        Me.btnCourse.TabIndex = 2
        Me.btnCourse.Text = "Course"
        Me.btnCourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCourse.UseVisualStyleBackColor = True
        '
        'btnCollege
        '
        Me.btnCollege.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollege.Image = Global.stu_enroll.My.Resources.Resources.college
        Me.btnCollege.Location = New System.Drawing.Point(198, 30)
        Me.btnCollege.Name = "btnCollege"
        Me.btnCollege.Size = New System.Drawing.Size(147, 148)
        Me.btnCollege.TabIndex = 1
        Me.btnCollege.Text = "College"
        Me.btnCollege.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCollege.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Image = Global.stu_enroll.My.Resources.Resources.Person_Male_Light_icon
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUser.Location = New System.Drawing.Point(32, 30)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(147, 148)
        Me.btnUser.TabIndex = 0
        Me.btnUser.Text = "User"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalCollege)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblTotalFaculty)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblTotalSubject)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblTotalCourse)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblTotalEnrollment)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(617, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 352)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summery"
        '
        'lblTotalCollege
        '
        Me.lblTotalCollege.AutoSize = True
        Me.lblTotalCollege.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCollege.Location = New System.Drawing.Point(194, 236)
        Me.lblTotalCollege.Name = "lblTotalCollege"
        Me.lblTotalCollege.Size = New System.Drawing.Size(127, 17)
        Me.lblTotalCollege.TabIndex = 16
        Me.lblTotalCollege.Text = "Total Enrollment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 51)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Total College" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTotalFaculty
        '
        Me.lblTotalFaculty.AutoSize = True
        Me.lblTotalFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFaculty.Location = New System.Drawing.Point(194, 195)
        Me.lblTotalFaculty.Name = "lblTotalFaculty"
        Me.lblTotalFaculty.Size = New System.Drawing.Size(127, 17)
        Me.lblTotalFaculty.TabIndex = 14
        Me.lblTotalFaculty.Text = "Total Enrollment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total Faculty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTotalSubject
        '
        Me.lblTotalSubject.AutoSize = True
        Me.lblTotalSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSubject.Location = New System.Drawing.Point(194, 155)
        Me.lblTotalSubject.Name = "lblTotalSubject"
        Me.lblTotalSubject.Size = New System.Drawing.Size(127, 17)
        Me.lblTotalSubject.TabIndex = 12
        Me.lblTotalSubject.Text = "Total Enrollment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(194, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Subject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 9
        '
        'lblTotalCourse
        '
        Me.lblTotalCourse.AutoSize = True
        Me.lblTotalCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCourse.Location = New System.Drawing.Point(194, 119)
        Me.lblTotalCourse.Name = "lblTotalCourse"
        Me.lblTotalCourse.Size = New System.Drawing.Size(127, 17)
        Me.lblTotalCourse.TabIndex = 8
        Me.lblTotalCourse.Text = "Total Enrollment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Course"
        '
        'lblTotalEnrollment
        '
        Me.lblTotalEnrollment.AutoSize = True
        Me.lblTotalEnrollment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEnrollment.Location = New System.Drawing.Point(194, 85)
        Me.lblTotalEnrollment.Name = "lblTotalEnrollment"
        Me.lblTotalEnrollment.Size = New System.Drawing.Size(127, 17)
        Me.lblTotalEnrollment.TabIndex = 6
        Me.lblTotalEnrollment.Text = "Total Enrollment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Enrollment"
        '
        'frmDashbord1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 564)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmDashbord1"
        Me.Text = "frmDashbord"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCollege As System.Windows.Forms.Button
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents btnCourse As System.Windows.Forms.Button
    Friend WithEvents btnSubject As System.Windows.Forms.Button
    Friend WithEvents btnFaculty As System.Windows.Forms.Button
    Friend WithEvents btnEnrollment As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalEnrollment As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCourse As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSubject As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTotalFaculty As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCollege As System.Windows.Forms.Label
End Class
