
Imports System.Data.SqlClient


Public Class frmUser
    Dim ID As Integer
    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillGrid()
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SplitContainer1.Panel1Collapsed = True
        SplitContainer1.Panel2Collapsed = False
        ID = 0
        clear()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please Enter Name", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtName.Focus()
            Return
        End If
        If txtPassword.Text = "" Then
            MessageBox.Show("Please Enter Password", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Focus()
            Return
        End If
        If txtAddress.Text = "" Then
            MessageBox.Show("Please Enter Address", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAddress.Focus()
            Return
        End If
        Dim obj As New clsUser
        If ID = 0 Then
            obj.Insert(txtName.Text, txtPassword.Text, txtMobile.Text, txtAddress.Text)
            MessageBox.Show("Record Save Sucessfully..", "Emloyee", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            obj.update(ID, txtName.Text, txtPassword.Text, txtMobile.Text, txtAddress.Text)
            MessageBox.Show("Record Update Sucessfully..", "Emloyee", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        fillGrid()
        clear()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        clear()
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub fillGrid()
        Dim obj As New clsUser()
        dataGrid.AutoGenerateColumns = False
        dataGrid.DataSource = obj.SelectAll().Tables(0)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If dataGrid.SelectedRows.Count > 0 Then
            Dim obj As New clsUser()
            obj.Delete(Convert.ToInt32(dataGrid.SelectedRows(0).Cells("UserID").Value))
            MessageBox.Show("Record Delete Succesfully")
            fillGrid()
        End If
    End Sub

    Private Sub dataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGrid.CellDoubleClick
        clear()
        If dataGrid.SelectedRows.Count > 0 Then
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False
            ID = Convert.ToInt32(dataGrid.SelectedRows(0).Cells("UserID").Value)
            txtName.Text = dataGrid.SelectedRows(0).Cells("UserName").Value.ToString()
            txtPassword.Text = dataGrid.SelectedRows(0).Cells("Password").Value.ToString()
            txtMobile.Text = dataGrid.SelectedRows(0).Cells("MobileNo").Value.ToString()
            txtAddress.Text = dataGrid.SelectedRows(0).Cells("Address").Value.ToString()
        End If
    End Sub
    Private Sub clear()
        txtName.Text = ""
        txtPassword.Text = ""
        txtMobile.Text = ""
        txtAddress.Text = ""
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub dataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGrid.CellContentClick

    End Sub

    Private Sub frmUser_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub txtMobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobile.TextChanged

    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class