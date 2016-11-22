Public Class User

    Private Sub btn_entry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_entry.Click
        Enrollment_Details.Show()

    End Sub

    Private Sub btn_modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modify.Click
        Modify_Enrollment.Show()

    End Sub

    Private Sub btn_transfer_stud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_transfer_stud.Click
        Student_Transfer_Options.Show()

    End Sub

    Private Sub btn_stud_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stud_list.Click
        Student_List_Report.Show()

    End Sub

    Private Sub btn_statistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_statistics.Click
        Student_Statistics_Report.Show()

    End Sub

    Private Sub btn_export_enroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export_enroll.Click
        Export_Student_Data.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class