
Imports System.Data.SqlClient


Public Class frmEnrollment
    Dim ID As Integer
    Private Sub frmEnrollment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbCity1.SelectedIndex = 0
        cmbCity2.SelectedIndex = 0
        cmbPassingYear.SelectedIndex = 0
        cmbGender.SelectedIndex = 0

        fillGrid("")
        fillcombo()
        cmbSearch.SelectedIndex = 0
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        SplitContainer1.Panel1Collapsed = True
        SplitContainer1.Panel2Collapsed = False
        ID = 0
        clear()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtFirstName.Text = "" Then
            MessageBox.Show("Please Enter First Name", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFirstName.Focus()
            Return
        End If
        If txtObtainMarks.Text = "" Then
            MessageBox.Show("Please Enter Obtain Marks", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtObtainMarks.Focus()
            Return
        End If
        If txtTotalMarks.Text = "" Then
            MessageBox.Show("Please Enter Total marks", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTotalMarks.Focus()
            Return
        End If
        If txtMiddleName.Text = "" Then
            MessageBox.Show("Please Enter MiddleName", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMiddleName.Focus()
            Return
        End If
        If txtAddress1.Text = "" Then
            MessageBox.Show("Please Enter Address1", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAddress1.Focus()
            Return
        End If
        If txtCast.Text = "" Then
            MessageBox.Show("Please Enter Cast", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCast.Focus()
            Return
        End If
        Dim obj As New clsEnrollment
        If ID = 0 Then
            obj.Insert(Convert.ToInt32(cmbCollege.SelectedValue), Convert.ToInt32(cmbCourse.SelectedValue), Convert.ToInt32(cmbFaculty.SelectedValue), txtFormNo.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress1.Text, CmbCity1.Text, txtPincode1.Text, txtMobileNo1.Text, txtPhoneNo1.Text, txtAddress2.Text, cmbCity2.Text, txtPinCode2.Text, txtMobileNo2.Text, TxtPhoneNo2.Text, DTPDateOfBirth.Value, cmbGender.Text, chkHandicape.Checked, txtNationality.Text, txtCast.Text, txtSubCast.Text, txtMinority.Text, txtReligion.Text, txtNameOfBoard.Text, txtSeatNumber.Text, txtExamCenter.Text, cmbPassingYear.Text, txtNameOfSchool.Text, Convert.ToInt32(txtTotalMarks.Text), Convert.ToInt32(txtObtainMarks.Text), txtPECNumber.Text, DTPFECDate.Value, txtFECNumber.Text, DTPFECDate.Value)
            MessageBox.Show("Record Save Sucessfully..", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            obj.update(ID, Convert.ToInt32(cmbCollege.SelectedValue), Convert.ToInt32(cmbCourse.SelectedValue), Convert.ToInt32(cmbFaculty.SelectedValue), txtFormNo.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress1.Text, CmbCity1.Text, txtPincode1.Text, txtMobileNo1.Text, txtPhoneNo1.Text, txtAddress2.Text, cmbCity2.Text, txtPinCode2.Text, txtMobileNo2.Text, TxtPhoneNo2.Text, DTPDateOfBirth.Value, cmbGender.Text, chkHandicape.Checked, txtNationality.Text, txtCast.Text, txtSubCast.Text, txtMinority.Text, txtReligion.Text, txtNameOfBoard.Text, txtSeatNumber.Text, txtExamCenter.Text, cmbPassingYear.Text, txtNameOfSchool.Text, Convert.ToInt32(txtTotalMarks.Text), Convert.ToInt32(txtObtainMarks.Text), txtPECNumber.Text, DTPFECDate.Value, txtFECNumber.Text, DTPFECDate.Value)
            MessageBox.Show("Record Update Sucessfully..", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        fillGrid("")
        clear()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        clear()
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub fillGrid(ByVal _where As String)
        Dim obj As New clsEnrollment()
        dataGrid.AutoGenerateColumns = False
        dataGrid.DataSource = obj.SelectAllWhere(_where).Tables(0)
    End Sub
    Private Sub fillcombo()
        Dim objCollege As New clsCollege
        cmbCollege.DisplayMember = "CollegeName"
        cmbCollege.ValueMember = "CollegeID"
        cmbCollege.DataSource = objCollege.SelectAll().Tables(0)

        Dim objFaculty As New clsFaculty
        cmbFaculty.DisplayMember = "FacultyName"
        cmbFaculty.ValueMember = "FacultyID"
        cmbFaculty.DataSource = objFaculty.SelectAll().Tables(0)

        Dim objCourse As New clsCourse
        cmbCourse.DisplayMember = "CourseName"
        cmbCourse.ValueMember = "CourseID"
        cmbCourse.DataSource = objCourse.SelectAll().Tables(0)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dataGrid.SelectedRows.Count > 0 Then
            Dim obj As New clsEnrollment()
            obj.Delete(Convert.ToInt32(dataGrid.SelectedRows(0).Cells("EnrollmentID").Value))
            MessageBox.Show("Record Delete Succesfully")
            fillGrid("")
        End If
    End Sub

    Private Sub dataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGrid.CellDoubleClick
        clear()
        If dataGrid.SelectedRows.Count > 0 Then
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False
            ID = Convert.ToInt32(dataGrid.SelectedRows(0).Cells("EnrollmentID").Value)
            cmbCollege.SelectedValue = Convert.ToInt32(dataGrid.SelectedRows(0).Cells("CollegeID").Value)
            cmbCourse.SelectedValue = Convert.ToInt32(dataGrid.SelectedRows(0).Cells("CourseID").Value.ToString())
            cmbFaculty.SelectedValue = Convert.ToInt32(dataGrid.SelectedRows(0).Cells("FacultyID").Value.ToString())
            txtFormNo.Text = dataGrid.SelectedRows(0).Cells("FormNo").Value.ToString()
            txtFirstName.Text = dataGrid.SelectedRows(0).Cells("FirstName").Value.ToString()
            txtMiddleName.Text = dataGrid.SelectedRows(0).Cells("MiddleName").Value.ToString()
            txtLastName.Text = dataGrid.SelectedRows(0).Cells("LastName").Value.ToString()
            txtAddress1.Text = dataGrid.SelectedRows(0).Cells("Address1").Value.ToString()
            CmbCity1.Text = dataGrid.SelectedRows(0).Cells("City1").Value.ToString()
            txtPincode1.Text = dataGrid.SelectedRows(0).Cells("Pincode1").Value.ToString()
            txtMobileNo1.Text = dataGrid.SelectedRows(0).Cells("MobileNo1").Value.ToString()
            txtPhoneNo1.Text = dataGrid.SelectedRows(0).Cells("PhoneNo1").Value.ToString()
            txtAddress2.Text = dataGrid.SelectedRows(0).Cells("Address2").Value.ToString()
            cmbCity2.Text = dataGrid.SelectedRows(0).Cells("City2").Value.ToString()
            txtPinCode2.Text = dataGrid.SelectedRows(0).Cells("PinCode2").Value.ToString()
            txtMobileNo2.Text = dataGrid.SelectedRows(0).Cells("MobileNo2").Value.ToString()
            TxtPhoneNo2.Text = dataGrid.SelectedRows(0).Cells("PhoneNo2").Value.ToString()
            DTPDateOfBirth.Value = Convert.ToDateTime(dataGrid.SelectedRows(0).Cells("DateOfBirth").Value.ToString())
            cmbGender.Text = dataGrid.SelectedRows(0).Cells("Gender").Value.ToString()
            chkHandicape.Checked = Convert.ToBoolean(dataGrid.SelectedRows(0).Cells("Handicape").Value.ToString())
            txtNationality.Text = dataGrid.SelectedRows(0).Cells("Nationality").Value.ToString()
            txtCast.Text = dataGrid.SelectedRows(0).Cells("Cast").Value.ToString()
            txtSubCast.Text = dataGrid.SelectedRows(0).Cells("SubCast").Value.ToString()
            txtMinority.Text = dataGrid.SelectedRows(0).Cells("Minority").Value.ToString()
            txtReligion.Text = dataGrid.SelectedRows(0).Cells("Religion").Value.ToString()
            txtNameOfBoard.Text = dataGrid.SelectedRows(0).Cells("NameOfBoard").Value.ToString()
            txtSeatNumber.Text = dataGrid.SelectedRows(0).Cells("SeatNumber").Value.ToString()
            txtExamCenter.Text = dataGrid.SelectedRows(0).Cells("ExamCenter").Value.ToString()
            cmbPassingYear.Text = dataGrid.SelectedRows(0).Cells("YearOfPassing").Value.ToString()
            txtNameOfSchool.Text = dataGrid.SelectedRows(0).Cells("NameOfSchool").Value.ToString()
            txtTotalMarks.Text = dataGrid.SelectedRows(0).Cells("TotalMarks").Value.ToString()
            txtObtainMarks.Text = dataGrid.SelectedRows(0).Cells("ObtainMarks").Value.ToString()
            txtPECNumber.Text = dataGrid.SelectedRows(0).Cells("PECNumber").Value.ToString()
            dtpPECDate.Value = Convert.ToDateTime(dataGrid.SelectedRows(0).Cells("PECDate").Value)
            txtFECNumber.Text = dataGrid.SelectedRows(0).Cells("FECNumber").Value.ToString()
            DTPFECDate.Text = dataGrid.SelectedRows(0).Cells("FECDate").Value.ToString()
        End If
    End Sub
    Private Sub clear()
        txtFormNo.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtAddress1.Text = ""
        txtPincode1.Text = ""
        txtMobileNo1.Text = ""
        txtPhoneNo1.Text = ""
        txtAddress2.Text = ""
        txtPinCode2.Text = ""
        txtMobileNo2.Text = ""
        TxtPhoneNo2.Text = ""
        txtNationality.Text = ""
        txtCast.Text = ""
        txtSubCast.Text = ""
        txtMinority.Text = ""
        txtReligion.Text = ""
        txtNameOfBoard.Text = ""
        txtSeatNumber.Text = ""
        txtExamCenter.Text = ""
        txtNameOfSchool.Text = ""
        txtTotalMarks.Text = ""
        txtObtainMarks.Text = ""
        txtPECNumber.Text = ""
        txtFECNumber.Text = ""
    End Sub

    Private Sub frmEnrollment_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub chkSameAsAbouve_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSameAsAbouve.CheckedChanged
        If (chkSameAsAbouve.Checked = True) Then
            txtAddress2.Text = txtAddress1.Text
            cmbCity2.Text = CmbCity1.Text
            txtPinCode2.Text = txtPincode1.Text
            txtMobileNo2.Text = txtMobileNo1.Text
            TxtPhoneNo2.Text = txtPhoneNo1.Text
        Else
            txtAddress2.Text = ""
            txtPinCode2.Text = ""
            txtMobileNo2.Text = ""
            TxtPhoneNo2.Text = ""
        End If
    End Sub


    Private Sub txtTotalMarks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalMarks.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If (cmbSearch.Text <> "") Then
            fillGrid(" and " & cmbSearch.Text & " like '" & txtSearch.Text & "%'")
        End If
    End Sub


    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

End Class