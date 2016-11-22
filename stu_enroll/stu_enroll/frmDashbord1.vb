Public Class frmDashbord1

    Private Sub frmDashbord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obj As New clsEnrollment
        lblTotalEnrollment.Text = obj.Count().ToString()

        Dim obj1 As New clsCourse
        lblTotalCourse.Text = obj1.Count().ToString()


        Dim obj2 As New clsFaculty
        lblTotalFaculty.Text = obj2.Count().ToString()

        Dim obj3 As New clsSubject
        lblTotalSubject.Text = obj3.Count().ToString()

        Dim obj4 As New clsCollege
        lblTotalCollege.Text = obj4.Count().ToString()


    End Sub

    Private Sub frmDashbord_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        Dim obj As New frmUser
        obj.MdiParent = Me.MdiParent
        obj.WindowState = FormWindowState.Maximized
        obj.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFaculty.Click
        Dim obj As New frmFaculty
        obj.MdiParent = Me.MdiParent
        obj.WindowState = FormWindowState.Maximized
        obj.Show()
    End Sub

    Private Sub btnCollege_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollege.Click
        Dim obj As New frmCollege
        obj.MdiParent = Me.MdiParent
        obj.WindowState = FormWindowState.Maximized
        obj.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCourse.Click, Button1.Click
        Dim obj As New frmCourse
        obj.MdiParent = Me.MdiParent
        obj.WindowState = FormWindowState.Maximized
        obj.Show()
    End Sub

    Private Sub btnSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubject.Click
        Dim obj As New frmSubject
        obj.MdiParent = Me.MdiParent
        obj.WindowState = FormWindowState.Maximized
        obj.Show()
    End Sub

    Private Sub btnEnrollment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnrollment.Click
        Dim obj As New frmEnrollment
        obj.MdiParent = Me.MdiParent
        obj.WindowState = FormWindowState.Maximized
        obj.Show()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmDashbord_Load(sender, e)
    End Sub

   
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class