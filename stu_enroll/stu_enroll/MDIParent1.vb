Imports System.Windows.Forms

Public Class frmMDI
    Private Sub menuItemUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemUser.Click
        Dim obj As New frmUser
        obj.MdiParent = Me
        obj.WindowState = FormWindowState.Maximized
        obj.Show()
    End Sub

    Private Sub frmMDI_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub menuItemCollge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemCollge.Click
        Dim obj As New frmCollege
        obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        Dim obj As New frmCourse
        obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem.Click
        Dim obj As New frmFaculty
        obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub EnrollmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectToolStripMenuItem.Click
        Dim obj As New frmSubject
        obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New frmUser
        obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub btnCollege_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New frmCollege
        obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub frmMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obj As New frmDashbord1
        obj.MdiParent = Me
        obj.WindowState = FormWindowState.Maximized
        obj.Show()

    End Sub

    Private Sub frmMDI_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

    End Sub

    Private Sub EnrollmentToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentToolStripMenuItem2.Click
        Dim obj As New frmEnrollment
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub MarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EnrollmentToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentToolStripMenuItem.Click
        Dim obj As New frmRptEnrollment
        obj.MdiParent = Me
        obj.Show()
    End Sub
End Class
