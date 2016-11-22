Imports System.Data.SqlClient
Public Class clsFaculty
    Dim objSCon As SqlConnection
    Dim objComm As SqlCommand
    Dim objAdpter As SqlDataAdapter

    Public Function SelectAll() As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblFaculty", objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function

    Public Function SelectAllWhere(ByVal _where As String) As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblFaculty where 1=1 " + _where, objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function


    Public Function Delete(ByVal ID As Integer) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim objComm As New SqlCommand("Delete from [tblFaculty] where FacultyID=" & ID, objSCon)
        Return objComm.ExecuteNonQuery()
    End Function

    Public Function Insert(ByVal _FacultyCode As String, ByVal _FacultyName As String, ByVal _Remark As String) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "INSERT INTO [tblFaculty] ([FacultyCode] ,[FacultyName],[Remark]) VALUES('" & _FacultyCode & "', '" & _FacultyName & "','" & _Remark & "')"
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery()


    End Function

    Public Function update(ByVal _FacultyID As Integer, ByVal _FacultyCode As String, ByVal _FacultyName As String, ByVal _Remark As String) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "UPDATE dbo.tblFaculty set FacultyCode='" & _FacultyCode & "', FacultyName ='" & _FacultyName & "',Remark= '" & _Remark & "' where FacultyID=" & _FacultyID
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery
    End Function

    Public Function Count() As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim objComm As New SqlCommand("select count(*) from tblFaculty", objSCon)
        Return Convert.ToInt32(objComm.ExecuteScalar())
    End Function


End Class
