Imports System.Data.SqlClient
Public Class clsCollege
    Dim objSCon As SqlConnection
    Dim objComm As SqlCommand
    Dim objAdpter As SqlDataAdapter

    Public Function SelectAll() As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblCollege", objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function

    Public Function SelectAllWhere(ByVal _where As String) As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblCollege where 1=1 " + _where, objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function


    Public Function Delete(ByVal ID As Integer) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim objComm As New SqlCommand("Delete from [tblCollege] where CollegeID=" & ID, objSCon)
        Return objComm.ExecuteNonQuery()
    End Function

    Public Function Insert(ByVal _CollegeName As String, ByVal _Address As String, ByVal _PhoneNo As String, ByVal _MobileNo As String, ByVal _EmailID As String, ByVal _Website As String) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "INSERT INTO [tblCollege] ([CollegeName] ,[Address],[PhoneNo],[MobileNo],[EmailID],[Website]) VALUES('" & _CollegeName & "', '" & _Address & "','" & _PhoneNo & "','" & _MobileNo & "','" & _EmailID & "','" & _Website & "')"
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery()


    End Function

    Public Function update(ByVal _CollegeID As Integer, ByVal _CollegeName As String, ByVal _Address As String, ByVal _PhoneNo As String, ByVal _MobileNo As String, ByVal _EmailID As String, ByVal _Website As String) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "UPDATE dbo.tblCollege set CollegeName='" & _CollegeName & "', Address ='" & _Address & "',PhoneNo= '" & _PhoneNo & "',MobileNo='" & _MobileNo & "',EmailID='" & _EmailID & "',Website='" & _Website & "' where CollegeID=" & _CollegeID
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery
    End Function

    Public Function Count() As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim objComm As New SqlCommand("select count(*) from tblCollege", objSCon)
        Return Convert.ToInt32(objComm.ExecuteScalar())
    End Function


End Class
