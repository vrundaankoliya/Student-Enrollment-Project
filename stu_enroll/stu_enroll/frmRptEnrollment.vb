Imports CrystalDecisions.CrystalReports.Engine

Public Class frmRptEnrollment

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dataGrid.DataSource = Nothing
        dataGrid.Refresh()
        Dim str As String = String.Empty
        If (cmbSearch.Text <> "") Then
            str = " and " & cmbSearch.Text & " like '" & txtSearch.Text & "%'"
        End If
        If txtPassingYear.Text <> "" Then
            str += " and YearOfPassing like '" & txtPassingYear.Text & "'"
        End If
        If txtObtainMarksFrom.Text <> "" And txtObtainMarksTo.Text <> "" Then
            str += " and ObtainMarks >= '" & txtObtainMarksFrom.Text & "'" & " and ObtainMarks <= '" & txtObtainMarksTo.Text & "'"
        End If
        fillGrid(str)
    End Sub
    Private Sub fillGrid(ByVal _where As String)
        Dim obj As New clsEnrollment()
        dataGrid.AutoGenerateColumns = False
        dataGrid.DataSource = obj.SelectAllWhere(_where).Tables(0)
    End Sub

    Private Sub grdEnrollment_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEnrollment.Enter

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub dataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGrid.CellContentClick

    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged

    End Sub

    Private Sub frmRptEnrollment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmPrint.Click
        Dim str As String = String.Empty
        If (cmbSearch.Text <> "") Then
            str = " and " & cmbSearch.Text & " like '" & txtSearch.Text & "%'"
        End If
        If txtPassingYear.Text <> "" Then
            str += " and YearOfPassing like '" & txtPassingYear.Text & "'"
        End If
        If txtObtainMarksFrom.Text <> "" And txtObtainMarksTo.Text <> "" Then
            str += " and ObtainMarks >= '" & txtObtainMarksFrom.Text & "'" & " and ObtainMarks <= '" & txtObtainMarksTo.Text & "'"
        End If

        Dim obj As New clsEnrollment()
        Dim ds As New DataSet()
        ds = obj.SelectAllWhere(str)
        ds.Tables(0).TableName = "Enrollment"

        Dim CryRPT As New ReportDocument()
        Dim strpath As String = String.Empty

        strpath = Application.StartupPath
        CryRPT.Load(strpath & "\\rptEnrollment.rpt")
        ' Tips &  Trik bagaimana mendapatkan uang di internet ==> http://bukugeratis.4shared.com <==
        CryRPT.SetDataSource(ds)
        Dim objreportviewer As New frmReportViewer()
        objreportviewer.CrystalReportViewer1.ReportSource = CryRPT
        objreportviewer.Show()
    End Sub
End Class