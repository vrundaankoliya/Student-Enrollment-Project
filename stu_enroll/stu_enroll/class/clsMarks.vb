Imports System.Data.SqlClient
Public Class clsMarks
    Dim objSCon As SqlConnection
    Dim objComm As SqlCommand
    Dim objAdpter As SqlDataAdapter

    Public Function SelectAll() As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblMarks", objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function

    Public Function SelectAllWhere(ByVal _where As String) As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblMarks where 1=1 " + _where, objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function


    Public Function Delete(ByVal ID As Integer) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim objComm As New SqlCommand("Delete from [tblMarks] where MarkID=" & ID, objSCon)
        Return objComm.ExecuteNonQuery()
    End Function

    Public Function Insert(ByVal _SubjectID As String, ByVal _EnrollmentID As Char, ByVal _TotalMarks As Integer, ByVal _ObtainMarks As Integer) As Integer

        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "INSERT INTO [SubjectID] ([EnrollmentID] ,[TotalMarks],[ObtainMarks]) VALUES('" & _SubjectID & "', '" & _EnrollmentID & "','" & _TotalMarks & "','" & _ObtainMarks & "')"
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery()


    End Function

    Public Function update(ByVal _MarkID As Integer, ByVal _SubjectID As String, ByVal _EnrollmentID As String, ByVal _TotalMarks As Integer, ByVal _ObtainMarks As Integer) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "UPDATE dbo.tblMarks set _SubjectID='" & _SubjectID & "', _EnrollmentID ='" & _EnrollmentID & "',_TotalMarks= '" & _TotalMarks & "', _ObtainMarks='" & _ObtainMarks & "' where MarkID=" & _MarkID
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery
    End Function

End Class
