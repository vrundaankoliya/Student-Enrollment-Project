<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Export_Student_Data
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
        Me.chbx_data = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_cancel_ex = New System.Windows.Forms.Button
        Me.btn_ok_ex = New System.Windows.Forms.Button
        Me.cmb_year_admi_ex = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_nameofclg_ex = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_collagecode_ex = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_coursecode_ex = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_course_ex = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_facultycode_ex = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_faculty_ex = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chbx_data
        '
        Me.chbx_data.AutoSize = True
        Me.chbx_data.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbx_data.Location = New System.Drawing.Point(256, 460)
        Me.chbx_data.Name = "chbx_data"
        Me.chbx_data.Size = New System.Drawing.Size(132, 23)
        Me.chbx_data.TabIndex = 7
        Me.chbx_data.Text = "Export All Data"
        Me.chbx_data.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancel_ex)
        Me.GroupBox1.Controls.Add(Me.btn_ok_ex)
        Me.GroupBox1.Location = New System.Drawing.Point(201, 504)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 72)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'btn_cancel_ex
        '
        Me.btn_cancel_ex.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel_ex.Location = New System.Drawing.Point(135, 19)
        Me.btn_cancel_ex.Name = "btn_cancel_ex"
        Me.btn_cancel_ex.Size = New System.Drawing.Size(75, 36)
        Me.btn_cancel_ex.TabIndex = 1
        Me.btn_cancel_ex.Text = "Cancel"
        Me.btn_cancel_ex.UseVisualStyleBackColor = True
        '
        'btn_ok_ex
        '
        Me.btn_ok_ex.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok_ex.Location = New System.Drawing.Point(36, 19)
        Me.btn_ok_ex.Name = "btn_ok_ex"
        Me.btn_ok_ex.Size = New System.Drawing.Size(75, 36)
        Me.btn_ok_ex.TabIndex = 0
        Me.btn_ok_ex.Text = "Ok"
        Me.btn_ok_ex.UseVisualStyleBackColor = True
        '
        'cmb_year_admi_ex
        '
        Me.cmb_year_admi_ex.FormattingEnabled = True
        Me.cmb_year_admi_ex.Location = New System.Drawing.Point(214, 399)
        Me.cmb_year_admi_ex.Name = "cmb_year_admi_ex"
        Me.cmb_year_admi_ex.Size = New System.Drawing.Size(121, 21)
        Me.cmb_year_admi_ex.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(59, 399)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 19)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Year of Admission :"
        '
        'txt_nameofclg_ex
        '
        Me.txt_nameofclg_ex.Location = New System.Drawing.Point(214, 348)
        Me.txt_nameofclg_ex.Name = "txt_nameofclg_ex"
        Me.txt_nameofclg_ex.Size = New System.Drawing.Size(361, 20)
        Me.txt_nameofclg_ex.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(66, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 19)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Name of College :"
        '
        'txt_collagecode_ex
        '
        Me.txt_collagecode_ex.Location = New System.Drawing.Point(216, 297)
        Me.txt_collagecode_ex.Name = "txt_collagecode_ex"
        Me.txt_collagecode_ex.Size = New System.Drawing.Size(120, 20)
        Me.txt_collagecode_ex.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(88, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "College Code :"
        '
        'txt_coursecode_ex
        '
        Me.txt_coursecode_ex.Location = New System.Drawing.Point(215, 248)
        Me.txt_coursecode_ex.Name = "txt_coursecode_ex"
        Me.txt_coursecode_ex.Size = New System.Drawing.Size(121, 20)
        Me.txt_coursecode_ex.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(91, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Course Code :"
        '
        'cmb_course_ex
        '
        Me.cmb_course_ex.FormattingEnabled = True
        Me.cmb_course_ex.Location = New System.Drawing.Point(214, 200)
        Me.cmb_course_ex.Name = "cmb_course_ex"
        Me.cmb_course_ex.Size = New System.Drawing.Size(361, 21)
        Me.cmb_course_ex.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Course :"
        '
        'txt_facultycode_ex
        '
        Me.txt_facultycode_ex.Location = New System.Drawing.Point(215, 153)
        Me.txt_facultycode_ex.Name = "txt_facultycode_ex"
        Me.txt_facultycode_ex.Size = New System.Drawing.Size(121, 20)
        Me.txt_facultycode_ex.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Faculty Code :"
        '
        'cmb_faculty_ex
        '
        Me.cmb_faculty_ex.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_faculty_ex.FormattingEnabled = True
        Me.cmb_faculty_ex.Location = New System.Drawing.Point(214, 107)
        Me.cmb_faculty_ex.Name = "cmb_faculty_ex"
        Me.cmb_faculty_ex.Size = New System.Drawing.Size(362, 21)
        Me.cmb_faculty_ex.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Faculty :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 34)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Welcome to the  'Export Student Details' section." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please select the details from" & _
            " the following options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Export_Student_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 610)
        Me.Controls.Add(Me.chbx_data)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmb_year_admi_ex)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_nameofclg_ex)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_collagecode_ex)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_coursecode_ex)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_course_ex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_facultycode_ex)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_faculty_ex)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Export_Student_Data"
        Me.Text = "Export Student Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chbx_data As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancel_ex As System.Windows.Forms.Button
    Friend WithEvents btn_ok_ex As System.Windows.Forms.Button
    Friend WithEvents cmb_year_admi_ex As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_nameofclg_ex As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_collagecode_ex As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_coursecode_ex As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_course_ex As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_facultycode_ex As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_faculty_ex As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
