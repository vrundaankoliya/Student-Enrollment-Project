
Imports System.Data.SqlClient
Public Class clsCourse
    Dim objSCon As SqlConnection
    Dim objComm As SqlCommand
    Dim objAdpter As SqlDataAdapter

    Public Function SelectAll() As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblCourse", objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function

    Public Function SelectAllWhere(ByVal _where As String) As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblCourse where 1=1 " + _where, objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function


    Public Function Delete(ByVal ID As Integer) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim objComm As New SqlCommand("Delete from [tblCourse] where CourseID=" & ID, objSCon)
        Return objComm.ExecuteNonQuery()
    End Function

    Public Function Insert(ByVal _CourseCode As String, ByVal _CourseName As String, ByVal _Remark As String) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "INSERT INTO [tblCourse] ([CourseCode],[CourseName] ,[Remark]) VALUES('" & _CourseCode & "', '" & _CourseName & "','" & _Remark & "')"
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery()


    End Function

    Public Function update(ByVal _CorseID As Integer, ByVal _CourseCode As String, ByVal _CourseName As String, ByVal _Remark As String) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "UPDATE dbo.tblCourse set CourseCode='" & _CourseCode & "', CourseName ='" & _CourseName & "',Remark= '" & _Remark & "'where CourseID=" & _CorseID
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery
    End Function

    Public Function Count() As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim objComm As New SqlCommand("select count(*) from tblCourse", objSCon)
        Return Convert.ToInt32(objComm.ExecuteScalar())
    End Function

End Class
