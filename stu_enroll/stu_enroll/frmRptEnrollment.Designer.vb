<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptEnrollment
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
        Me.components = New System.ComponentModel.Container
        Me.btn_Exit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dataGrid = New System.Windows.Forms.DataGridView
        Me.EnrollmentID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CollegeID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CourseID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FacultyID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FormNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.City1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PinCode1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MobileNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhoneNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.City2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PinCode2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MobileNo2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhoneNo2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateOfBirth = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Handicape = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nationality = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cast = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubCast = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Minority = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Religion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameOfBoard = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeatNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExamCenter = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YearOfPassing = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameOfSchool = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalMarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObtainMarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PECNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PECDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdEnrollment = New System.Windows.Forms.GroupBox
        Me.frmPrint = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtObtainMarksTo = New System.Windows.Forms.TextBox
        Me.txtObtainMarksFrom = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPassingYear = New System.Windows.Forms.TextBox
        Me.cmbSearch = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdEnrollment.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Exit
        '
        Me.btn_Exit.Image = Global.stu_enroll.My.Resources.Resources._32px_Crystal_Clear_action_button_cancel
        Me.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exit.Location = New System.Drawing.Point(30, 191)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(79, 30)
        Me.btn_Exit.TabIndex = 8
        Me.btn_Exit.Text = "  Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.stu_enroll.My.Resources.Resources._32px_Crystal_Clear_action_viewmagfit
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(30, 155)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(79, 30)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "    Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdEnrollment)
        Me.SplitContainer1.Size = New System.Drawing.Size(1029, 510)
        Me.SplitContainer1.SplitterDistance = 764
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dataGrid)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(764, 510)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enrollment"
        '
        'dataGrid
        '
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EnrollmentID, Me.CollegeID, Me.CourseID, Me.FacultyID, Me.FormNo, Me.FirstName, Me.MiddleName, Me.LastName, Me.Address1, Me.City1, Me.PinCode1, Me.MobileNo1, Me.PhoneNo1, Me.Address2, Me.City2, Me.PinCode2, Me.MobileNo2, Me.PhoneNo2, Me.DateOfBirth, Me.Gender, Me.Handicape, Me.Nationality, Me.Cast, Me.SubCast, Me.Minority, Me.Religion, Me.NameOfBoard, Me.SeatNumber, Me.ExamCenter, Me.YearOfPassing, Me.NameOfSchool, Me.TotalMarks, Me.ObtainMarks, Me.PECNumber, Me.PECDate, Me.FECNumber, Me.FECDate})
        Me.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGrid.Location = New System.Drawing.Point(3, 16)
        Me.dataGrid.MultiSelect = False
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGrid.Size = New System.Drawing.Size(758, 491)
        Me.dataGrid.TabIndex = 0
        '
        'EnrollmentID
        '
        Me.EnrollmentID.DataPropertyName = "EnrollmentID"
        Me.EnrollmentID.HeaderText = "EnrollmentID"
        Me.EnrollmentID.Name = "EnrollmentID"
        '
        'CollegeID
        '
        Me.CollegeID.DataPropertyName = "CollegeID"
        Me.CollegeID.HeaderText = "CollegeID"
        Me.CollegeID.Name = "CollegeID"
        Me.CollegeID.Visible = False
        '
        'CourseID
        '
        Me.CourseID.DataPropertyName = "CourseID"
        Me.CourseID.HeaderText = "CourseID"
        Me.CourseID.Name = "CourseID"
        '
        'FacultyID
        '
        Me.FacultyID.DataPropertyName = "FacultyID"
        Me.FacultyID.HeaderText = "FacultyID"
        Me.FacultyID.Name = "FacultyID"
        '
        'FormNo
        '
        Me.FormNo.DataPropertyName = "FormNo"
        Me.FormNo.HeaderText = "FormNo"
        Me.FormNo.Name = "FormNo"
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "FirstName"
        Me.FirstName.Name = "FirstName"
        '
        'MiddleName
        '
        Me.MiddleName.DataPropertyName = "MiddleName"
        Me.MiddleName.HeaderText = "MiddleName"
        Me.MiddleName.Name = "MiddleName"
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "LastName"
        Me.LastName.Name = "LastName"
        '
        'Address1
        '
        Me.Address1.DataPropertyName = "Address1"
        Me.Address1.HeaderText = "Address1"
        Me.Address1.Name = "Address1"
        '
        'City1
        '
        Me.City1.DataPropertyName = "City1"
        Me.City1.HeaderText = "City1"
        Me.City1.Name = "City1"
        '
        'PinCode1
        '
        Me.PinCode1.DataPropertyName = "PinCode1"
        Me.PinCode1.HeaderText = "PinCode1"
        Me.PinCode1.Name = "PinCode1"
        '
        'MobileNo1
        '
        Me.MobileNo1.DataPropertyName = "MobileNo1"
        Me.MobileNo1.HeaderText = "MobileNo"
        Me.MobileNo1.Name = "MobileNo1"
        '
        'PhoneNo1
        '
        Me.PhoneNo1.DataPropertyName = "PhoneNo1"
        Me.PhoneNo1.HeaderText = "PhoneNo1"
        Me.PhoneNo1.Name = "PhoneNo1"
        '
        'Address2
        '
        Me.Address2.DataPropertyName = "Address2"
        Me.Address2.HeaderText = "Address2"
        Me.Address2.Name = "Address2"
        '
        'City2
        '
        Me.City2.DataPropertyName = "City2"
        Me.City2.HeaderText = "City2"
        Me.City2.Name = "City2"
        '
        'PinCode2
        '
        Me.PinCode2.DataPropertyName = "PinCode2"
        Me.PinCode2.HeaderText = "PinCode2"
        Me.PinCode2.Name = "PinCode2"
        '
        'MobileNo2
        '
        Me.MobileNo2.DataPropertyName = "MobileNo2"
        Me.MobileNo2.HeaderText = "MobileNo2"
        Me.MobileNo2.Name = "MobileNo2"
        '
        'PhoneNo2
        '
        Me.PhoneNo2.DataPropertyName = "PhoneNo2"
        Me.PhoneNo2.HeaderText = "PhoneNo2"
        Me.PhoneNo2.Name = "PhoneNo2"
        '
        'DateOfBirth
        '
        Me.DateOfBirth.DataPropertyName = "DateOfBirth"
        Me.DateOfBirth.HeaderText = "DateOfBirth"
        Me.DateOfBirth.Name = "DateOfBirth"
        '
        'Gender
        '
        Me.Gender.DataPropertyName = "Gender"
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        '
        'Handicape
        '
        Me.Handicape.DataPropertyName = "Handicape"
        Me.Handicape.HeaderText = "Handicape"
        Me.Handicape.Name = "Handicape"
        '
        'Nationality
        '
        Me.Nationality.DataPropertyName = "Nationality"
        Me.Nationality.HeaderText = "Nationality"
        Me.Nationality.Name = "Nationality"
        '
        'Cast
        '
        Me.Cast.DataPropertyName = "Cast"
        Me.Cast.HeaderText = "Cast"
        Me.Cast.Name = "Cast"
        '
        'SubCast
        '
        Me.SubCast.DataPropertyName = "SubCast"
        Me.SubCast.HeaderText = "SubCast"
        Me.SubCast.Name = "SubCast"
        '
        'Minority
        '
        Me.Minority.DataPropertyName = "Minority"
        Me.Minority.HeaderText = "Minority"
        Me.Minority.Name = "Minority"
        '
        'Religion
        '
        Me.Religion.DataPropertyName = "Religion"
        Me.Religion.HeaderText = "Religion"
        Me.Religion.Name = "Religion"
        '
        'NameOfBoard
        '
        Me.NameOfBoard.DataPropertyName = "NameOfBoard"
        Me.NameOfBoard.HeaderText = "NameOfBoard"
        Me.NameOfBoard.Name = "NameOfBoard"
        '
        'SeatNumber
        '
        Me.SeatNumber.DataPropertyName = "SeatNumber"
        Me.SeatNumber.HeaderText = "SeatNumber"
        Me.SeatNumber.Name = "SeatNumber"
        '
        'ExamCenter
        '
        Me.ExamCenter.DataPropertyName = "ExamCenter"
        Me.ExamCenter.HeaderText = "ExamCenter"
        Me.ExamCenter.Name = "ExamCenter"
        '
        'YearOfPassing
        '
        Me.YearOfPassing.DataPropertyName = "YearOfPassing"
        Me.YearOfPassing.HeaderText = "YearOfPassing"
        Me.YearOfPassing.Name = "YearOfPassing"
        '
        'NameOfSchool
        '
        Me.NameOfSchool.DataPropertyName = "NameOfSchool"
        Me.NameOfSchool.HeaderText = "NameOfSchool"
        Me.NameOfSchool.Name = "NameOfSchool"
        '
        'TotalMarks
        '
        Me.TotalMarks.DataPropertyName = "TotalMarks"
        Me.TotalMarks.HeaderText = "TotalMarks"
        Me.TotalMarks.Name = "TotalMarks"
        '
        'ObtainMarks
        '
        Me.ObtainMarks.DataPropertyName = "ObtainMarks"
        Me.ObtainMarks.HeaderText = "ObtainMarks"
        Me.ObtainMarks.Name = "ObtainMarks"
        '
        'PECNumber
        '
        Me.PECNumber.DataPropertyName = "PECNumber"
        Me.PECNumber.HeaderText = "PECNumber"
        Me.PECNumber.Name = "PECNumber"
        '
        'PECDate
        '
        Me.PECDate.DataPropertyName = "PECDate"
        Me.PECDate.HeaderText = "PECDate"
        Me.PECDate.Name = "PECDate"
        '
        'FECNumber
        '
        Me.FECNumber.DataPropertyName = "FECNumber"
        Me.FECNumber.HeaderText = "FECNumber"
        Me.FECNumber.Name = "FECNumber"
        '
        'FECDate
        '
        Me.FECDate.DataPropertyName = "FECDate"
        Me.FECDate.HeaderText = "FECDate"
        Me.FECDate.Name = "FECDate"
        '
        'grdEnrollment
        '
        Me.grdEnrollment.Controls.Add(Me.frmPrint)
        Me.grdEnrollment.Controls.Add(Me.btnCancel)
        Me.grdEnrollment.Controls.Add(Me.txtObtainMarksTo)
        Me.grdEnrollment.Controls.Add(Me.txtObtainMarksFrom)
        Me.grdEnrollment.Controls.Add(Me.Label1)
        Me.grdEnrollment.Controls.Add(Me.txtPassingYear)
        Me.grdEnrollment.Controls.Add(Me.cmbSearch)
        Me.grdEnrollment.Controls.Add(Me.Label2)
        Me.grdEnrollment.Controls.Add(Me.txtSearch)
        Me.grdEnrollment.Controls.Add(Me.btn_Exit)
        Me.grdEnrollment.Controls.Add(Me.Label12)
        Me.grdEnrollment.Controls.Add(Me.btnSearch)
        Me.grdEnrollment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEnrollment.Location = New System.Drawing.Point(0, 0)
        Me.grdEnrollment.Name = "grdEnrollment"
        Me.grdEnrollment.Size = New System.Drawing.Size(261, 510)
        Me.grdEnrollment.TabIndex = 2
        Me.grdEnrollment.TabStop = False
        Me.grdEnrollment.Text = "Enrollment Information"
        '
        'frmPrint
        '
        Me.frmPrint.Image = Global.stu_enroll.My.Resources.Resources._32px_Crystal_Clear_action_viewmagfit
        Me.frmPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.frmPrint.Location = New System.Drawing.Point(121, 155)
        Me.frmPrint.Name = "frmPrint"
        Me.frmPrint.Size = New System.Drawing.Size(79, 30)
        Me.frmPrint.TabIndex = 348
        Me.frmPrint.Text = "     Print"
        Me.frmPrint.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.stu_enroll.My.Resources.Resources.Cancel
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(123, 191)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 30)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "   Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtObtainMarksTo
        '
        Me.txtObtainMarksTo.Location = New System.Drawing.Point(148, 105)
        Me.txtObtainMarksTo.Name = "txtObtainMarksTo"
        Me.txtObtainMarksTo.Size = New System.Drawing.Size(52, 20)
        Me.txtObtainMarksTo.TabIndex = 6
        '
        'txtObtainMarksFrom
        '
        Me.txtObtainMarksFrom.Location = New System.Drawing.Point(84, 105)
        Me.txtObtainMarksFrom.Name = "txtObtainMarksFrom"
        Me.txtObtainMarksFrom.Size = New System.Drawing.Size(52, 20)
        Me.txtObtainMarksFrom.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ObtainMarks"
        '
        'txtPassingYear
        '
        Me.txtPassingYear.Location = New System.Drawing.Point(84, 79)
        Me.txtPassingYear.Name = "txtPassingYear"
        Me.txtPassingYear.Size = New System.Drawing.Size(118, 20)
        Me.txtPassingYear.TabIndex = 3
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"EnrollmentID", "FormNo", "Gender"})
        Me.cmbSearch.Location = New System.Drawing.Point(13, 19)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(180, 21)
        Me.cmbSearch.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PassingYear"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(13, 46)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(180, 20)
        Me.txtSearch.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 380)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 347
        '
        'frmRptEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 510)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmRptEnrollment"
        Me.Text = "frmRptEnrollment"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdEnrollment.ResumeLayout(False)
        Me.grdEnrollment.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents grdEnrollment As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassingYear As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtObtainMarksFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtObtainMarksTo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents EnrollmentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollegeID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacultyID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents City1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PinCode1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents City2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PinCode2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Handicape As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nationality As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cast As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCast As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Minority As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Religion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameOfBoard As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeatNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExamCenter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearOfPassing As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameOfSchool As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalMarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObtainMarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PECNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PECDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents frmPrint As System.Windows.Forms.Button
End Class
