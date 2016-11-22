
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Enrollment_Details
    Dim con As New SqlConnection("Data Source=ABC-PC;Initial Catalog=programm;Integrated Security=True;User ID=sa;Password=123")
    'Dim cmd As New SqlCommand("select * from tblUser", con)
    'Dim da As New SqlDataAdapter
    'Dim ds As New Data.DataSet

    Dim cmd1 As New SqlCommand("select FacultyCode from tblFaculty", con)
    Dim cmd2 As New SqlCommand("select FacultyName from tblFaculty", con)
    Dim da1 As New SqlDataAdapter(cmd1)
    Dim dt1 As New DataTable()
    Dim da2 As New SqlDataAdapter(cmd2)
    Dim dt2 As New DataTable()
    Private Sub Enrollment_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connection()

        da2.Fill(dt2)
        If dt2.Rows.Count > 0 Then
            cmb_faculty.DataSource = dt2
            cmb_faculty.DisplayMember = "FacultyName"
        Else
            MessageBox.Show("Empty")
        End If

        da1.Fill(dt1)
        If dt1.Rows.Count > 0 Then
            cmb_facultycode.DataSource = dt1
            cmb_facultycode.DisplayMember = "FacultyCode"
        Else
            MessageBox.Show("Empty")
        End If
        ' cmb_facultycode.SelectedItem = cmb_faculty.SelectedItem

        Dim cmd3 As New SqlCommand("select CourseName from tblCourse", con)
        Dim da3 As New SqlDataAdapter(cmd3)
        Dim dt3 As New DataTable()

        da3.Fill(dt3)
        If dt3.Rows.Count > 0 Then
            cmb_course.DataSource = dt3
            cmb_course.DisplayMember = "CourseName"
        Else
            MessageBox.Show("Empty")
        End If

        Dim cmd4 As New SqlCommand("select CourseCode from tblCourse", con)
        Dim da4 As New SqlDataAdapter(cmd4)
        Dim dt4 As New DataTable()

        da4.Fill(dt4)
        If dt4.Rows.Count > 0 Then
            cmb_coursecode.DataSource = dt4
            cmb_coursecode.DisplayMember = "CourseCode"
        Else
            MessageBox.Show("Empty")
        End If

        Dim cmd_year As New SqlCommand("select Remark from tblCourse", con)
        Dim da_year As New SqlDataAdapter(cmd_year)
        Dim dt_year As New DataTable()

        da_year.Fill(dt_year)
        If dt_year.Rows.Count > 0 Then
            cmb_cour_year.DataSource = dt_year
            cmb_cour_year.DisplayMember = "Remark"
        Else
            MessageBox.Show("Empty")
        End If

        Dim cmd5 As New SqlCommand("select CollegeName from tblCollege", con)
        Dim da5 As New SqlDataAdapter(cmd5)
        Dim dt5 As New DataTable()

        da5.Fill(dt5)
        If dt5.Rows.Count > 0 Then
            cmb_collegename.DataSource = dt5
            cmb_collegename.DisplayMember = "CollegeName"
        Else
            MessageBox.Show("Empty")
        End If

        Dim cmd6 As New SqlCommand("select CollegeID from tblCollege", con)
        Dim da6 As New SqlDataAdapter(cmd6)
        Dim dt6 As New DataTable()

        da6.Fill(dt6)
        If dt6.Rows.Count > 0 Then
            cmb_collegecode.DataSource = dt6
            cmb_collegecode.DisplayMember = "CollegeID"
        Else
            MessageBox.Show("Empty")
        End If
    End Sub
    'Sub connection()
    '    con.Open()
    '    da = New SqlDataAdapter(cmd)
    '    da.Fill(ds)
    '    con.Close()
    'End Sub




    Private Sub btn_cancel_ed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()

    End Sub


    Private Sub btn_ok_ed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        New_Enrollment_Form.Show()
    End Sub
End Class