
Imports System.Data.SqlClient


Public Class frmCollege
    Dim ID As Integer
    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillGrid("")
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
        cmbSearch.SelectedIndex = 0
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SplitContainer1.Panel1Collapsed = True
        SplitContainer1.Panel2Collapsed = False
        ID = 0
        clear()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtCollegeName.Text = "" Then
            MessageBox.Show("Please Enter College Name", "College", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCollegeName.Focus()
            Return
        End If
        If txtAddress.Text = "" Then
            MessageBox.Show("Please Enter Address", "College", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAddress.Focus()
            Return
        End If
        If txtMobileNo.Text = "" Then
            MessageBox.Show("Please Enter MobileNo", "College", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMobileNo.Focus()
            Return
        End If
        Dim obj As New clsCollege
        If ID = 0 Then
            obj.Insert(txtCollegeName.Text, txtAddress.Text, txtPhoneNo.Text, txtMobileNo.Text, txtEmail.Text, txtWebsite.Text)
            MessageBox.Show("Record Save Sucessfully..", "College", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            obj.update(ID, txtCollegeName.Text, txtAddress.Text, txtPhoneNo.Text, txtMobileNo.Text, txtEmail.Text, txtWebsite.Text)
            MessageBox.Show("Record Update Sucessfully..", "College", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Dim obj As New clsCollege()
        dataGrid.AutoGenerateColumns = True
        dataGrid.DataSource = obj.SelectAllWhere(_where).Tables(0)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If dataGrid.SelectedRows.Count > 0 Then
            Dim obj As New clsCollege()
            obj.Delete(Convert.ToInt32(dataGrid.SelectedRows(0).Cells("CollegeID").Value))
            MessageBox.Show("Record Delete Succesfully")
            fillGrid("")
        End If
    End Sub

    Private Sub dataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellDoubleClick
        clear()
        If dataGrid.SelectedRows.Count > 0 Then
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False
            ID = Convert.ToInt32(dataGrid.SelectedRows(0).Cells("CollegeID").Value)
            txtCollegeName.Text = dataGrid.SelectedRows(0).Cells("CollegeName").Value.ToString()
            txtAddress.Text = dataGrid.SelectedRows(0).Cells("Address").Value.ToString()
            txtPhoneNo.Text = dataGrid.SelectedRows(0).Cells("PhoneNo").Value.ToString()
            txtMobileNo.Text = dataGrid.SelectedRows(0).Cells("MobileNo").Value.ToString()
            txtEmail.Text = dataGrid.SelectedRows(0).Cells("EmailID").Value.ToString()
            txtWebsite.Text = dataGrid.SelectedRows(0).Cells("Website").Value.ToString()
        End If
    End Sub
    Private Sub clear()
        txtCollegeName.Text = ""
        txtAddress.Text = ""
        txtPhoneNo.Text = ""
        txtMobileNo.Text = ""
        txtEmail.Text = ""
        txtWebsite.Text = ""
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGrid.CellContentClick

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If (cmbSearch.Text <> "") Then
            fillGrid(" and " & cmbSearch.Text & " like '" & txtSearch.Text & "%'")
        End If
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub


    Private Sub cmbCollegeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtSubjectName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCollegeName.TextChanged

    End Sub
End Class