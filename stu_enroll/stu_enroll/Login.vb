Imports System.Data.SqlClient
Imports System.Text.RegularExpressions


Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Dim obj As New clsUser()
        Dim ds As New DataSet
        ds = obj.SelectAllWhere(" and UserName = '" + txt_userid.Text + "' and Password ='" + txt_password.Text + "'")
        If (ds.Tables(0).Rows.Count = 0) Then
            ''MsgBox.Show("Invalid Autantication")
            MessageBox.Show("Invalid Autantication")
            clear()
        Else
            Dim objFrom As New frmMDI
            objFrom.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
    Private Sub clear()
        txt_userid.Text = ""
        txt_password.Text = ""
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmforgot As New frmforgotpassword
        frmforgot.ShowDialog()




        'Dim obj As New clsUser()
        'Dim ds As New DataSet
        'ds = obj.SelectAllWhere(" and UserName = '" + txt_userid.Text + "' and Password ='" + txt_password.Text + "'")
        'If (ds.Tables(0).Rows.Count = 0) Then
        '    ''MsgBox.Show("Invalid Autantication")
        '    MessageBox.Show("Invalid Autantication")
        '    clear()
        'Else
        '    ' Dim objFrom As New frmMDI
        '    'objFrom.Show()
        '    'Me.Hide()
        'End If
    End Sub

End Class