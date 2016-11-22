<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enrollment_Details
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_ok = New System.Windows.Forms.Button
        Me.cmb_year_admission = New System.Windows.Forms.ComboBox
        Me.cmb_cour_year = New System.Windows.Forms.ComboBox
        Me.cmb_course = New System.Windows.Forms.ComboBox
        Me.cmb_faculty = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_collegecode = New System.Windows.Forms.ComboBox
        Me.cmb_coursecode = New System.Windows.Forms.ComboBox
        Me.cmb_facultycode = New System.Windows.Forms.ComboBox
        Me.cmb_collegename = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_ok)
        Me.GroupBox1.Location = New System.Drawing.Point(198, 452)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 100)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(206, 35)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(99, 44)
        Me.btn_cancel.TabIndex = 9
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(63, 35)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(96, 44)
        Me.btn_ok.TabIndex = 8
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'cmb_year_admission
        '
        Me.cmb_year_admission.FormattingEnabled = True
        Me.cmb_year_admission.Location = New System.Drawing.Point(515, 380)
        Me.cmb_year_admission.Name = "cmb_year_admission"
        Me.cmb_year_admission.Size = New System.Drawing.Size(121, 21)
        Me.cmb_year_admission.TabIndex = 7
        '
        'cmb_cour_year
        '
        Me.cmb_cour_year.FormattingEnabled = True
        Me.cmb_cour_year.Location = New System.Drawing.Point(515, 264)
        Me.cmb_cour_year.Name = "cmb_cour_year"
        Me.cmb_cour_year.Size = New System.Drawing.Size(121, 21)
        Me.cmb_cour_year.TabIndex = 4
        '
        'cmb_course
        '
        Me.cmb_course.FormattingEnabled = True
        Me.cmb_course.Location = New System.Drawing.Point(211, 205)
        Me.cmb_course.Name = "cmb_course"
        Me.cmb_course.Size = New System.Drawing.Size(425, 21)
        Me.cmb_course.TabIndex = 2
        '
        'cmb_faculty
        '
        Me.cmb_faculty.FormattingEnabled = True
        Me.cmb_faculty.Location = New System.Drawing.Point(210, 99)
        Me.cmb_faculty.Name = "cmb_faculty"
        Me.cmb_faculty.Size = New System.Drawing.Size(426, 21)
        Me.cmb_faculty.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(372, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 19)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Year of Admission :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(50, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 19)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Name of College :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "College Code :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(396, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Course Year :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Course Code :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Courses :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Faculty Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Faculty :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 34)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Welcome to the  'Enrollment' section." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please select the details from the followi" & _
            "ng options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmb_collegecode
        '
        Me.cmb_collegecode.FormattingEnabled = True
        Me.cmb_collegecode.Location = New System.Drawing.Point(211, 378)
        Me.cmb_collegecode.Name = "cmb_collegecode"
        Me.cmb_collegecode.Size = New System.Drawing.Size(121, 21)
        Me.cmb_collegecode.TabIndex = 6
        '
        'cmb_coursecode
        '
        Me.cmb_coursecode.FormattingEnabled = True
        Me.cmb_coursecode.Location = New System.Drawing.Point(210, 266)
        Me.cmb_coursecode.Name = "cmb_coursecode"
        Me.cmb_coursecode.Size = New System.Drawing.Size(121, 21)
        Me.cmb_coursecode.TabIndex = 3
        '
        'cmb_facultycode
        '
        Me.cmb_facultycode.FormattingEnabled = True
        Me.cmb_facultycode.Location = New System.Drawing.Point(210, 150)
        Me.cmb_facultycode.Name = "cmb_facultycode"
        Me.cmb_facultycode.Size = New System.Drawing.Size(121, 21)
        Me.cmb_facultycode.TabIndex = 1
        '
        'cmb_collegename
        '
        Me.cmb_collegename.FormattingEnabled = True
        Me.cmb_collegename.Location = New System.Drawing.Point(210, 325)
        Me.cmb_collegename.Name = "cmb_collegename"
        Me.cmb_collegename.Size = New System.Drawing.Size(426, 21)
        Me.cmb_collegename.TabIndex = 5
        '
        'Enrollment_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 606)
        Me.Controls.Add(Me.cmb_collegename)
        Me.Controls.Add(Me.cmb_facultycode)
        Me.Controls.Add(Me.cmb_coursecode)
        Me.Controls.Add(Me.cmb_collegecode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmb_year_admission)
        Me.Controls.Add(Me.cmb_cour_year)
        Me.Controls.Add(Me.cmb_course)
        Me.Controls.Add(Me.cmb_faculty)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Enrollment_Details"
        Me.Text = "Enrollment_Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents cmb_year_admission As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cour_year As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_course As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_faculty As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_collegecode As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_coursecode As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_facultycode As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_collegename As System.Windows.Forms.ComboBox
End Class
