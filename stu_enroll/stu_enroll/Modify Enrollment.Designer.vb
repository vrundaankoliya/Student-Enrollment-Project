<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modify_Enrollment
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
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.txt_sname = New System.Windows.Forms.TextBox
        Me.txt_fname = New System.Windows.Forms.TextBox
        Me.cmb_Enrollment = New System.Windows.Forms.ComboBox
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.txt_fecdate = New System.Windows.Forms.TextBox
        Me.txt_pecdate = New System.Windows.Forms.TextBox
        Me.txt_fecno = New System.Windows.Forms.TextBox
        Me.txt_pecno = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.txt_m2 = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.txt_m1 = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total_marks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Obtained_marks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label30 = New System.Windows.Forms.Label
        Me.txt_school = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.cmb_yearofpassing = New System.Windows.Forms.ComboBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txt_examno = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txt_seatno = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txt_nameofboard = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.cmb_religion = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmb_caste = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmb_handicap = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmb_gender = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_mbno1 = New System.Windows.Forms.TextBox
        Me.txt_phno1 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_pincode1 = New System.Windows.Forms.TextBox
        Me.txt_city1 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_nationality = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmb_month = New System.Windows.Forms.ComboBox
        Me.cmb_year = New System.Windows.Forms.ComboBox
        Me.cmb_date = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_addcor = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_addpar = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_lname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_formno = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_pincode2 = New System.Windows.Forms.TextBox
        Me.txt_city2 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.btn_showdetail2 = New System.Windows.Forms.Button
        Me.btn_showdetail1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(41, 10)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 36)
        Me.btn_update.TabIndex = 37
        Me.btn_update.Text = "Update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(131, 10)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 36)
        Me.btn_delete.TabIndex = 38
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txt_sname
        '
        Me.txt_sname.Location = New System.Drawing.Point(219, 85)
        Me.txt_sname.Name = "txt_sname"
        Me.txt_sname.Size = New System.Drawing.Size(142, 20)
        Me.txt_sname.TabIndex = 5
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(372, 80)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(142, 20)
        Me.txt_fname.TabIndex = 6
        '
        'cmb_Enrollment
        '
        Me.cmb_Enrollment.FormattingEnabled = True
        Me.cmb_Enrollment.Location = New System.Drawing.Point(212, 22)
        Me.cmb_Enrollment.Name = "cmb_Enrollment"
        Me.cmb_Enrollment.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Enrollment.TabIndex = 1
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(213, 10)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 36)
        Me.btn_cancel.TabIndex = 39
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(752, 621)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(51, 19)
        Me.Label36.TabIndex = 229
        Me.Label36.Text = "Date :"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(752, 567)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(51, 19)
        Me.Label35.TabIndex = 228
        Me.Label35.Text = "Date :"
        '
        'txt_fecdate
        '
        Me.txt_fecdate.Location = New System.Drawing.Point(714, 643)
        Me.txt_fecdate.Name = "txt_fecdate"
        Me.txt_fecdate.Size = New System.Drawing.Size(109, 20)
        Me.txt_fecdate.TabIndex = 36
        '
        'txt_pecdate
        '
        Me.txt_pecdate.Location = New System.Drawing.Point(714, 598)
        Me.txt_pecdate.Name = "txt_pecdate"
        Me.txt_pecdate.Size = New System.Drawing.Size(109, 20)
        Me.txt_pecdate.TabIndex = 34
        '
        'txt_fecno
        '
        Me.txt_fecno.Location = New System.Drawing.Point(566, 643)
        Me.txt_fecno.Name = "txt_fecno"
        Me.txt_fecno.Size = New System.Drawing.Size(133, 20)
        Me.txt_fecno.TabIndex = 35
        '
        'txt_pecno
        '
        Me.txt_pecno.Location = New System.Drawing.Point(566, 598)
        Me.txt_pecno.Name = "txt_pecno"
        Me.txt_pecno.Size = New System.Drawing.Size(133, 20)
        Me.txt_pecno.TabIndex = 33
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(569, 621)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(106, 19)
        Me.Label37.TabIndex = 223
        Me.Label37.Text = "FEC Number :"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(569, 567)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(106, 19)
        Me.Label38.TabIndex = 222
        Me.Label38.Text = "PEC Number :"
        '
        'txt_m2
        '
        Me.txt_m2.Location = New System.Drawing.Point(764, 539)
        Me.txt_m2.Name = "txt_m2"
        Me.txt_m2.Size = New System.Drawing.Size(59, 20)
        Me.txt_m2.TabIndex = 32
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(742, 540)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(14, 20)
        Me.Label34.TabIndex = 220
        Me.Label34.Text = "/"
        '
        'txt_m1
        '
        Me.txt_m1.Location = New System.Drawing.Point(675, 540)
        Me.txt_m1.Name = "txt_m1"
        Me.txt_m1.Size = New System.Drawing.Size(61, 20)
        Me.txt_m1.TabIndex = 31
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(550, 540)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(119, 19)
        Me.Label31.TabIndex = 218
        Me.Label31.Text = "Total of Marks :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 673)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 50)
        Me.GroupBox1.TabIndex = 217
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Subject, Me.Total_marks, Me.Obtained_marks})
        Me.DataGridView1.Location = New System.Drawing.Point(212, 539)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(332, 123)
        Me.DataGridView1.TabIndex = 30
        '
        'Subject
        '
        Me.Subject.DataPropertyName = "subject"
        Me.Subject.HeaderText = "Subject"
        Me.Subject.Name = "Subject"
        '
        'Total_marks
        '
        Me.Total_marks.DataPropertyName = "total_marks"
        Me.Total_marks.HeaderText = "Total_marks"
        Me.Total_marks.Name = "Total_marks"
        '
        'Obtained_marks
        '
        Me.Obtained_marks.DataPropertyName = "obtained_marks"
        Me.Obtained_marks.HeaderText = "Obtained_marks"
        Me.Obtained_marks.Name = "Obtained_marks"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(26, 540)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(163, 19)
        Me.Label30.TabIndex = 215
        Me.Label30.Text = "Information of Marks :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_school
        '
        Me.txt_school.Location = New System.Drawing.Point(481, 493)
        Me.txt_school.Name = "txt_school"
        Me.txt_school.Size = New System.Drawing.Size(349, 20)
        Me.txt_school.TabIndex = 29
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(350, 494)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(123, 19)
        Me.Label29.TabIndex = 213
        Me.Label29.Text = "Name of School :"
        '
        'cmb_yearofpassing
        '
        Me.cmb_yearofpassing.FormattingEnabled = True
        Me.cmb_yearofpassing.Location = New System.Drawing.Point(212, 495)
        Me.cmb_yearofpassing.Name = "cmb_yearofpassing"
        Me.cmb_yearofpassing.Size = New System.Drawing.Size(121, 21)
        Me.cmb_yearofpassing.TabIndex = 28
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(69, 494)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(120, 19)
        Me.Label28.TabIndex = 211
        Me.Label28.Text = "Year of Passing :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_examno
        '
        Me.txt_examno.Location = New System.Drawing.Point(696, 460)
        Me.txt_examno.Name = "txt_examno"
        Me.txt_examno.Size = New System.Drawing.Size(134, 20)
        Me.txt_examno.TabIndex = 27
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(710, 438)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(106, 38)
        Me.Label27.TabIndex = 209
        Me.Label27.Text = "Exam Center :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(630, 406)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(0, 13)
        Me.Label26.TabIndex = 208
        '
        'txt_seatno
        '
        Me.txt_seatno.Location = New System.Drawing.Point(551, 460)
        Me.txt_seatno.Name = "txt_seatno"
        Me.txt_seatno.Size = New System.Drawing.Size(134, 20)
        Me.txt_seatno.TabIndex = 26
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(565, 438)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(106, 19)
        Me.Label25.TabIndex = 206
        Me.Label25.Text = "Seat Number :"
        '
        'txt_nameofboard
        '
        Me.txt_nameofboard.Location = New System.Drawing.Point(212, 460)
        Me.txt_nameofboard.Name = "txt_nameofboard"
        Me.txt_nameofboard.Size = New System.Drawing.Size(312, 20)
        Me.txt_nameofboard.TabIndex = 25
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(69, 457)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(120, 19)
        Me.Label24.TabIndex = 204
        Me.Label24.Text = "Name of Board :"
        '
        'cmb_religion
        '
        Me.cmb_religion.FormattingEnabled = True
        Me.cmb_religion.Location = New System.Drawing.Point(569, 411)
        Me.cmb_religion.Name = "cmb_religion"
        Me.cmb_religion.Size = New System.Drawing.Size(116, 21)
        Me.cmb_religion.TabIndex = 24
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(489, 413)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 19)
        Me.Label23.TabIndex = 202
        Me.Label23.Text = "Religion :"
        '
        'cmb_caste
        '
        Me.cmb_caste.FormattingEnabled = True
        Me.cmb_caste.Location = New System.Drawing.Point(372, 414)
        Me.cmb_caste.Name = "cmb_caste"
        Me.cmb_caste.Size = New System.Drawing.Size(101, 21)
        Me.cmb_caste.TabIndex = 23
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(318, 413)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 19)
        Me.Label22.TabIndex = 200
        Me.Label22.Text = "Caste :"
        '
        'cmb_handicap
        '
        Me.cmb_handicap.FormattingEnabled = True
        Me.cmb_handicap.Location = New System.Drawing.Point(719, 377)
        Me.cmb_handicap.Name = "cmb_handicap"
        Me.cmb_handicap.Size = New System.Drawing.Size(111, 21)
        Me.cmb_handicap.TabIndex = 21
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(565, 377)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(152, 57)
        Me.Label21.TabIndex = 198
        Me.Label21.Text = "Physically Hendicap :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmb_gender
        '
        Me.cmb_gender.FormattingEnabled = True
        Me.cmb_gender.Location = New System.Drawing.Point(481, 378)
        Me.cmb_gender.Name = "cmb_gender"
        Me.cmb_gender.Size = New System.Drawing.Size(74, 21)
        Me.cmb_gender.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(410, 380)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 19)
        Me.Label20.TabIndex = 196
        Me.Label20.Text = "Gender :"
        '
        'txt_mbno1
        '
        Me.txt_mbno1.Location = New System.Drawing.Point(651, 199)
        Me.txt_mbno1.Name = "txt_mbno1"
        Me.txt_mbno1.Size = New System.Drawing.Size(179, 20)
        Me.txt_mbno1.TabIndex = 12
        '
        'txt_phno1
        '
        Me.txt_phno1.Location = New System.Drawing.Point(651, 171)
        Me.txt_phno1.Name = "txt_phno1"
        Me.txt_phno1.Size = New System.Drawing.Size(179, 20)
        Me.txt_phno1.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(555, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 19)
        Me.Label15.TabIndex = 185
        Me.Label15.Text = "Mobile No :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(562, 172)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 19)
        Me.Label14.TabIndex = 184
        Me.Label14.Text = "Phone No :"
        '
        'txt_pincode1
        '
        Me.txt_pincode1.Location = New System.Drawing.Point(696, 138)
        Me.txt_pincode1.Name = "txt_pincode1"
        Me.txt_pincode1.Size = New System.Drawing.Size(134, 20)
        Me.txt_pincode1.TabIndex = 10
        '
        'txt_city1
        '
        Me.txt_city1.Location = New System.Drawing.Point(541, 138)
        Me.txt_city1.Name = "txt_city1"
        Me.txt_city1.Size = New System.Drawing.Size(134, 20)
        Me.txt_city1.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(760, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 57)
        Me.Label13.TabIndex = 181
        Me.Label13.Text = "Pincode :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(72, 381)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 180
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(629, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 19)
        Me.Label11.TabIndex = 179
        Me.Label11.Text = "City :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_nationality
        '
        Me.txt_nationality.Location = New System.Drawing.Point(212, 412)
        Me.txt_nationality.Name = "txt_nationality"
        Me.txt_nationality.Size = New System.Drawing.Size(100, 20)
        Me.txt_nationality.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(97, 411)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 19)
        Me.Label10.TabIndex = 177
        Me.Label10.Text = "Nationality :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmb_month
        '
        Me.cmb_month.FormattingEnabled = True
        Me.cmb_month.Location = New System.Drawing.Point(281, 378)
        Me.cmb_month.Name = "cmb_month"
        Me.cmb_month.Size = New System.Drawing.Size(57, 21)
        Me.cmb_month.TabIndex = 176
        '
        'cmb_year
        '
        Me.cmb_year.FormattingEnabled = True
        Me.cmb_year.Location = New System.Drawing.Point(344, 377)
        Me.cmb_year.Name = "cmb_year"
        Me.cmb_year.Size = New System.Drawing.Size(60, 21)
        Me.cmb_year.TabIndex = 175
        '
        'cmb_date
        '
        Me.cmb_date.FormattingEnabled = True
        Me.cmb_date.Location = New System.Drawing.Point(212, 377)
        Me.cmb_date.Name = "cmb_date"
        Me.cmb_date.Size = New System.Drawing.Size(63, 21)
        Me.cmb_date.TabIndex = 174
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(85, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 38)
        Me.Label9.TabIndex = 173
        Me.Label9.Text = "Date of Birth :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_addcor
        '
        Me.txt_addcor.Location = New System.Drawing.Point(212, 254)
        Me.txt_addcor.Multiline = True
        Me.txt_addcor.Name = "txt_addcor"
        Me.txt_addcor.Size = New System.Drawing.Size(312, 110)
        Me.txt_addcor.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 38)
        Me.Label8.TabIndex = 171
        Me.Label8.Text = "Correspondance :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_addpar
        '
        Me.txt_addpar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_addpar.Location = New System.Drawing.Point(212, 111)
        Me.txt_addpar.Multiline = True
        Me.txt_addpar.Name = "txt_addpar"
        Me.txt_addpar.Size = New System.Drawing.Size(312, 108)
        Me.txt_addpar.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(125, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 38)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Address :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Parmanent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(555, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 19)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "Lastname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(401, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 19)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Firstname" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(237, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Surname"
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(527, 79)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(142, 20)
        Me.txt_lname.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 38)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "Name of Applicant :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmb_formno
        '
        Me.cmb_formno.FormattingEnabled = True
        Me.cmb_formno.Location = New System.Drawing.Point(582, 21)
        Me.cmb_formno.Name = "cmb_formno"
        Me.cmb_formno.Size = New System.Drawing.Size(121, 21)
        Me.cmb_formno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(465, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 38)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Form Number :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Enrollment No :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(651, 340)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(179, 20)
        Me.TextBox11.TabIndex = 18
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(651, 312)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(179, 20)
        Me.TextBox12.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(555, 341)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 19)
        Me.Label16.TabIndex = 238
        Me.Label16.Text = "Mobile No :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(562, 313)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 19)
        Me.Label17.TabIndex = 237
        Me.Label17.Text = "Phone No :"
        '
        'txt_pincode2
        '
        Me.txt_pincode2.Location = New System.Drawing.Point(696, 279)
        Me.txt_pincode2.Name = "txt_pincode2"
        Me.txt_pincode2.Size = New System.Drawing.Size(134, 20)
        Me.txt_pincode2.TabIndex = 16
        '
        'txt_city2
        '
        Me.txt_city2.Location = New System.Drawing.Point(541, 279)
        Me.txt_city2.Name = "txt_city2"
        Me.txt_city2.Size = New System.Drawing.Size(134, 20)
        Me.txt_city2.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(760, 252)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 57)
        Me.Label18.TabIndex = 234
        Me.Label18.Text = "Pincode :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(629, 252)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 19)
        Me.Label19.TabIndex = 233
        Me.Label19.Text = "City :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(212, 225)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(218, 23)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Same as Permanent Address"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btn_showdetail2
        '
        Me.btn_showdetail2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_showdetail2.Location = New System.Drawing.Point(719, 16)
        Me.btn_showdetail2.Name = "btn_showdetail2"
        Me.btn_showdetail2.Size = New System.Drawing.Size(113, 28)
        Me.btn_showdetail2.TabIndex = 4
        Me.btn_showdetail2.Text = "Show Details"
        Me.btn_showdetail2.UseVisualStyleBackColor = True
        '
        'btn_showdetail1
        '
        Me.btn_showdetail1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_showdetail1.Location = New System.Drawing.Point(339, 16)
        Me.btn_showdetail1.Name = "btn_showdetail1"
        Me.btn_showdetail1.Size = New System.Drawing.Size(120, 30)
        Me.btn_showdetail1.TabIndex = 2
        Me.btn_showdetail1.Text = "Show Details"
        Me.btn_showdetail1.UseVisualStyleBackColor = True
        '
        'Modify_Enrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 746)
        Me.Controls.Add(Me.btn_showdetail2)
        Me.Controls.Add(Me.btn_showdetail1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_pincode2)
        Me.Controls.Add(Me.txt_city2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_sname)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.cmb_Enrollment)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txt_fecdate)
        Me.Controls.Add(Me.txt_pecdate)
        Me.Controls.Add(Me.txt_fecno)
        Me.Controls.Add(Me.txt_pecno)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txt_m2)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txt_m1)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txt_school)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.cmb_yearofpassing)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txt_examno)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txt_seatno)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_nameofboard)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cmb_religion)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmb_caste)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmb_handicap)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cmb_gender)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_mbno1)
        Me.Controls.Add(Me.txt_phno1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_pincode1)
        Me.Controls.Add(Me.txt_city1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_nationality)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_month)
        Me.Controls.Add(Me.cmb_year)
        Me.Controls.Add(Me.cmb_date)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_addcor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_addpar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_formno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Modify_Enrollment"
        Me.Text = "Modify_Enrollment"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents txt_sname As System.Windows.Forms.TextBox
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Enrollment As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txt_fecdate As System.Windows.Forms.TextBox
    Friend WithEvents txt_pecdate As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecno As System.Windows.Forms.TextBox
    Friend WithEvents txt_pecno As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txt_m2 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txt_m1 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Subject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_marks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Obtained_marks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt_school As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmb_yearofpassing As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_examno As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_seatno As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_nameofboard As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmb_religion As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmb_caste As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmb_handicap As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmb_gender As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_mbno1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_phno1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_pincode1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_city1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_nationality As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_month As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_year As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_date As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_addcor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_addpar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_formno As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_pincode2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_city2 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_showdetail2 As System.Windows.Forms.Button
    Friend WithEvents btn_showdetail1 As System.Windows.Forms.Button
End Class
