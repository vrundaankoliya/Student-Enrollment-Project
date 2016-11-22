
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmSubject
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
        If txtSubjectName.Text = "" Then
            MessageBox.Show("Please Enter SubjectName", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSubjectName.Focus()
            Return
        End If
        If txtTotalMarks.Text = "" Then
            MessageBox.Show("Please Enter TotalMarks", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTotalMarks.Focus()
            Return
        End If
        Dim obj As New clsSubject
        If ID = 0 Then
            obj.Insert(txtSubjectName.Text, txtSubjectCode.Text, Convert.ToDouble(txtTotalMarks.Text), txtRemarks.Text)
            MessageBox.Show("Record Save Sucessfully..", "College", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            obj.update(ID, txtSubjectName.Text, txtSubjectCode.Text, Convert.ToDouble(txtTotalMarks.Text), txtRemarks.Text)
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
        Dim obj As New clsSubject()
        dataGrid.AutoGenerateColumns = False
        dataGrid.DataSource = obj.SelectAllWhere(_where).Tables(0)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dataGrid.SelectedRows.Count > 0 Then
            Dim obj As New clsSubject()
            obj.Delete(Convert.ToInt32(dataGrid.SelectedRows(0).Cells("SubjectID").Value))
            MessageBox.Show("Record Delete Succesfully")
            fillGrid("")
        End If
    End Sub

    Private Sub dataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGrid.CellDoubleClick
        clear()
        If dataGrid.SelectedRows.Count > 0 Then
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False
            ID = Convert.ToInt32(dataGrid.SelectedRows(0).Cells("SubjectID").Value)
            txtSubjectCode.Text = dataGrid.SelectedRows(0).Cells("SubjectCode").Value.ToString()
            txtSubjectName.Text = dataGrid.SelectedRows(0).Cells("SubjectName").Value.ToString()
            txtTotalMarks.Text = dataGrid.SelectedRows(0).Cells("TotalMarks").Value.ToString()
            txtRemarks.Text = dataGrid.SelectedRows(0).Cells("Remarks").Value.ToString()
        End If
    End Sub
    Private Sub clear()
        txtSubjectName.Text = ""
        txtSubjectCode.Text = ""
        txtTotalMarks.Text = ""
        txtRemarks.Text = ""
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click, cmbSearch.SelectedIndexChanged
        If (cmbSearch.Text <> "") Then
            fillGrid(" and " & cmbSearch.Text & " like '" & txtSearch.Text & "%'")
        End If
    End Sub

    Private Sub txtTotalMarks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalMarks.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSubject_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click

    End Sub

    Private Sub dataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGrid.CellContentClick

    End Sub

    Private Sub txtSubjectName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectName.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub frmPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String = String.Empty
        If (cmbSearch.Text <> "") Then
            str = " and " & cmbSearch.Text & " like '" & txtSearch.Text & "%'"
        End If
        Dim obj As New clsSubject()
        Dim ds As New DataSet()
        ds = obj.SelectAllWhere(str)
        ds.Tables(0).TableName = "Subject"

        Dim CryRPT As New ReportDocument()
        Dim strpath As String = String.Empty

        strpath = Application.StartupPath
        CryRPT.Load(strpath & "\\rptSubject.rpt")

        CryRPT.SetDataSource(ds)
        Dim objreportviewer As New frmReportViewer()
        objreportviewer.CrystalReportViewer1.ReportSource = CryRPT
        objreportviewer.Show()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class