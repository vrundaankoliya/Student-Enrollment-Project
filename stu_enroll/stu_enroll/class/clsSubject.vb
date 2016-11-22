Imports System.Data.SqlClient
Public Class clsSubject
    Dim objSCon As SqlConnection
    Dim objComm As SqlCommand
    Dim objAdpter As SqlDataAdapter

    Public Function SelectAll() As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblSubject", objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function

    Public Function SelectAllWhere(ByVal _where As String) As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblSubject where 1=1 " + _where, objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function


    Public Function Delete(ByVal ID As Integer) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim objComm As New SqlCommand("Delete from [tblSubject] where SubjectID=" & ID, objSCon)
        Return objComm.ExecuteNonQuery()
    End Function

    Public Function Insert(ByVal _SubjectName As String, ByVal _SubjectCode As String, ByVal _TotalMarks As Double, ByVal _Remarks As String)
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "INSERT INTO dbo.tblSubject ([SubjectName],[SubjectCode],[TotalMarks] ,[Remarks]) VALUES('" & _SubjectName & "','" & _SubjectCode & "', " & _TotalMarks & ",'" & _Remarks & "')"
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery()


    End Function

    Public Function update(ByVal _SubjectID As Integer, ByVal _SubjectName As String, ByVal _SubjectCode As String, ByVal _TotalMarks As Double, ByVal _Remarks As String) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "UPDATE dbo.tblSubject set SubjectName='" & _SubjectName & "',SubjectCode ='" & _SubjectCode & "', TotalMarks = " & _TotalMarks & ", Remarks = '" & _Remarks & "' where SubjectID=" & _SubjectID
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery
    End Function

    Public Function Count() As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim objComm As New SqlCommand("select count(*) from tblSubject", objSCon)
        Return Convert.ToInt32(objComm.ExecuteScalar())
    End Function


End Class
