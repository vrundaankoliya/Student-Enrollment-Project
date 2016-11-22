Imports System.Data.SqlClient
Public Class clsUser
    Dim objSCon As SqlConnection
    Dim objComm As SqlCommand
    Dim objAdpter As SqlDataAdapter

    Public Function SelectAll() As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblUser", objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function

    Public Function password(ByVal uid As String) As DataSet
        Dim objDS As New DataSet()
        'Dim pass As String

        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblUser where UserName=" + uid, objSCon)
        objAdpter.Fill(objDS)

        Return objDS
    End Function

    Public Function SelectAllWhere(ByVal _where As String) As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblUser where 1=1 " + _where, objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function


    Public Function Delete(ByVal ID As Integer) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())

        objSCon.Open()
        Dim objComm As New SqlCommand("Delete from [tblUser] where UserID=" & ID, objSCon)
        Return objComm.ExecuteNonQuery()
    End Function

    Public Function Insert(ByVal _UserName As String, ByVal _Password As String, ByVal _MobileNo As String, ByVal _Address As String) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "INSERT INTO [tblUser] ([UserName] ,[Password],[MobileNo],[Address]) VALUES('" & _UserName & "', '" & _Password & "','" & _MobileNo & "','" & _Address & "')"
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery()


    End Function

    Public Function update(ByVal _UserID As Integer, ByVal _UserName As String, ByVal _Password As String, ByVal _MobileNo As String, ByVal _Address As String) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "UPDATE dbo.tblUser set UserName='" & _UserName & "', Password ='" & _Password & "',MobileNo= '" & _MobileNo & "',Address='" & _Address & "' where UserID=" & _UserID
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery
    End Function

End Class
