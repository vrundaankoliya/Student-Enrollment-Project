<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_Name = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_export_enroll = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_stud_list = New System.Windows.Forms.Button
        Me.btn_statistics = New System.Windows.Forms.Button
        Me.btn_transfer_stud = New System.Windows.Forms.Button
        Me.btn_modify = New System.Windows.Forms.Button
        Me.btn_entry = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(139, 31)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(402, 57)
        Me.lbl_Name.TabIndex = 1
        Me.lbl_Name.Text = "Welcome to the 'Enrollment /Registration' Program" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please select your task from t" & _
            "he following avaliable options" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_export_enroll)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(325, 379)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 100)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Export Section"
        '
        'btn_export_enroll
        '
        Me.btn_export_enroll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export_enroll.Location = New System.Drawing.Point(91, 30)
        Me.btn_export_enroll.Name = "btn_export_enroll"
        Me.btn_export_enroll.Size = New System.Drawing.Size(98, 50)
        Me.btn_export_enroll.TabIndex = 8
        Me.btn_export_enroll.Text = "Export Enrolled Students" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_export_enroll.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_stud_list)
        Me.GroupBox1.Controls.Add(Me.btn_statistics)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(325, 242)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 117)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Section"
        '
        'btn_stud_list
        '
        Me.btn_stud_list.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stud_list.Location = New System.Drawing.Point(26, 35)
        Me.btn_stud_list.Name = "btn_stud_list"
        Me.btn_stud_list.Size = New System.Drawing.Size(115, 54)
        Me.btn_stud_list.TabIndex = 5
        Me.btn_stud_list.Text = "Student List Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_stud_list.UseVisualStyleBackColor = True
        '
        'btn_statistics
        '
        Me.btn_statistics.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_statistics.Location = New System.Drawing.Point(170, 35)
        Me.btn_statistics.Name = "btn_statistics"
        Me.btn_statistics.Size = New System.Drawing.Size(111, 54)
        Me.btn_statistics.TabIndex = 6
        Me.btn_statistics.Text = "Student Statistics Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_statistics.UseVisualStyleBackColor = True
        '
        'btn_transfer_stud
        '
        Me.btn_transfer_stud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transfer_stud.Location = New System.Drawing.Point(423, 165)
        Me.btn_transfer_stud.Name = "btn_transfer_stud"
        Me.btn_transfer_stud.Size = New System.Drawing.Size(103, 50)
        Me.btn_transfer_stud.TabIndex = 13
        Me.btn_transfer_stud.Text = "Transfered Student" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_transfer_stud.UseVisualStyleBackColor = True
        '
        'btn_modify
        '
        Me.btn_modify.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modify.Location = New System.Drawing.Point(495, 91)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(111, 50)
        Me.btn_modify.TabIndex = 12
        Me.btn_modify.Text = "Modify Enrollment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_modify.UseVisualStyleBackColor = True
        '
        'btn_entry
        '
        Me.btn_entry.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entry.Location = New System.Drawing.Point(332, 91)
        Me.btn_entry.Name = "btn_entry"
        Me.btn_entry.Size = New System.Drawing.Size(115, 50)
        Me.btn_entry.TabIndex = 11
        Me.btn_entry.Text = "Enrollment Form Entry"
        Me.btn_entry.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.stu_enroll.My.Resources.Resources.Untitled
        Me.PictureBox1.Location = New System.Drawing.Point(73, 177)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 115)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 517)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_transfer_stud)
        Me.Controls.Add(Me.btn_modify)
        Me.Controls.Add(Me.btn_entry)
        Me.Controls.Add(Me.lbl_Name)
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_export_enroll As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_stud_list As System.Windows.Forms.Button
    Friend WithEvents btn_statistics As System.Windows.Forms.Button
    Friend WithEvents btn_transfer_stud As System.Windows.Forms.Button
    Friend WithEvents btn_modify As System.Windows.Forms.Button
    Friend WithEvents btn_entry As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
