Public Class frmforgotpassword

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim con As New clsUser
        datagrid.AutoGenerateColumns = False
        datagrid.DataSource = con.password(TextBox1.Text).Tables(0)

    End Sub

    Private Sub frmforgotpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub
End Class