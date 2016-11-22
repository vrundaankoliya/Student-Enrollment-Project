
Imports System.Data.SqlClient


Public Class frmCourse
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
        If txtCourseName.Text = "" Then
            MessageBox.Show("Please Enter Course Name", "Course", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCourseName.Focus()
            Return
        End If
        If txtCourseCode.Text = "" Then
            MessageBox.Show("Please Enter Course Code", "Course", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCourseCode.Focus()
            Return
        End If
        Dim obj As New clsCourse
        If ID = 0 Then
            obj.Insert(txtCourseCode.Text, txtCourseName.Text, txtRemark.Text)
            MessageBox.Show("Record Save Sucessfully..", "Course", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            obj.update(ID, txtCourseCode.Text, txtCourseName.Text, txtRemark.Text)
            MessageBox.Show("Record Update Sucessfully..", "Course", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Dim obj As New clsCourse()
        dataGrid.AutoGenerateColumns = False
        dataGrid.DataSource = obj.SelectAllWhere(_where).Tables(0)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dataGrid.SelectedRows.Count > 0 Then
            Dim obj As New clsCourse()
            obj.Delete(Convert.ToInt32(dataGrid.SelectedRows(0).Cells("CourseID").Value))
            MessageBox.Show("Record Delete Succesfully")
            fillGrid("")
        End If
    End Sub

    Private Sub dataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGrid.CellDoubleClick
        clear()
        If dataGrid.SelectedRows.Count > 0 Then
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False
            ID = Convert.ToInt32(dataGrid.SelectedRows(0).Cells("CourseID").Value)

            txtCourseCode.Text = dataGrid.SelectedRows(0).Cells("CourseCode").Value.ToString()
            txtCourseName.Text = dataGrid.SelectedRows(0).Cells("CourseName").Value.ToString()
            txtRemark.Text = dataGrid.SelectedRows(0).Cells("Remark").Value.ToString()

        End If
    End Sub
    Private Sub clear()

        txtCourseCode.Text = ""
        txtCourseName.Text = ""
        txtRemark.Text = ""
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click


        If (cmbSearch.Text <> "") Then
            fillGrid(" and " & cmbSearch.Text & " like '" & txtSearch.Text & "%'")
        End If
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub dataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGrid.CellContentClick

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class