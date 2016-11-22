
Imports System.Data.SqlClient


Public Class frmFaculty
    Dim ID As Integer
    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillGrid("")
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
        cmbSearch.SelectedIndex = 0
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
        If txtFacultyCode.Text = "" Then
            MessageBox.Show("Please Enter FacutyCode", "Faculty", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFacultyCode.Focus()
            Return
        End If
        If txtFacultyName.Text = "" Then
            MessageBox.Show("Please Enter FacultyName", "Faculty", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFacultyName.Focus()
            Return
        End If
        Dim obj As New clsFaculty
        If ID = 0 Then
            obj.Insert(txtFacultyCode.Text, txtFacultyName.Text, txtRemark.Text)
            MessageBox.Show("Record Save Sucessfully..", "College", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            obj.update(ID, txtFacultyCode.Text, txtFacultyName.Text, txtRemark.Text)
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
        Dim obj As New clsFaculty()
        dataGrid.AutoGenerateColumns = False
        dataGrid.DataSource = obj.SelectAllWhere(_where).Tables(0)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dataGrid.SelectedRows.Count > 0 Then
            Dim obj As New clsFaculty()
            obj.Delete(Convert.ToInt32(dataGrid.SelectedRows(0).Cells("FacultyID").Value))
            MessageBox.Show("Record Delete Succesfully")
            fillGrid("")
        End If
    End Sub

    Private Sub dataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellDoubleClick
        clear()
        If dataGrid.SelectedRows.Count > 0 Then
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False
            ID = Convert.ToInt32(dataGrid.SelectedRows(0).Cells("FacultyID").Value)
            txtFacultyCode.Text = dataGrid.SelectedRows(0).Cells("FacultyCode").Value.ToString()
            txtFacultyName.Text = dataGrid.SelectedRows(0).Cells("FacultyName").Value.ToString()
            txtRemark.Text = dataGrid.SelectedRows(0).Cells("Remark").Value.ToString()
           
        End If
    End Sub
    Private Sub clear()
        txtFacultyCode.Text = ""
        txtFacultyName.Text = ""
        txtRemark.Text = ""
        
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If (cmbSearch.Text <> "") Then
            fillGrid(" and " & cmbSearch.Text & " like '" & txtSearch.Text & "%'")
        End If

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()


    End Sub

    Private Sub txtRemark_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemark.TextChanged

    End Sub

    Private Sub txtFacultyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFacultyName.TextChanged
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txtFacultyCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFacultyCode.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class