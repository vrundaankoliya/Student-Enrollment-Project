Imports System.Data.SqlClient
Public Class clsEnrollment
    Dim objSCon As SqlConnection
    Dim objComm As SqlCommand
    Dim objAdpter As SqlDataAdapter

    Public Function SelectAll() As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblEnrollment", objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function

    Public Function SelectAllWhere(ByVal _where As String) As DataSet
        Dim objDS As New DataSet()
        objSCon = New SqlConnection(New clsConnection().GetConnectionString())
        objSCon.Open()
        objAdpter = New SqlDataAdapter("select * from dbo.tblEnrollment where 1=1 " + _where, objSCon)
        objAdpter.Fill(objDS)
        Return objDS
    End Function


    Public Function Delete(ByVal ID As Integer) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim objComm As New SqlCommand("Delete from [tblEnrollment] where EnrollmentID=" & ID, objSCon)
        Return objComm.ExecuteNonQuery()
    End Function

    Public Function Insert(ByVal _CollegeID As Integer, ByVal _CourseID As Integer, ByVal _FacultyID As Integer, ByVal _FormNo As String, ByVal _FirstName As String, ByVal _MiddleName As String, ByVal _LastName As String, ByVal _Address1 As String, ByVal _City1 As String, ByVal _Pincode1 As String, ByVal _MobileNO1 As String, ByVal _PhoneNo1 As String, ByVal _Address2 As String, ByVal _City2 As String, ByVal _Pincode2 As String, ByVal _MobileNo2 As String, ByVal _PhoneNo2 As String, ByVal _DateOfBirth As DateTime, ByVal _Gender As String, ByVal _Handicape As Boolean, ByVal _Nationality As String, ByVal _Cast As String, ByVal _SubCast As String, ByVal _Minority As String, ByVal _Religion As String, ByVal _NameOfBoard As String, ByVal _SeatNumber As String, ByVal _ExamCenter As String, ByVal _YearOfPassing As String, ByVal _NameOfSchool As String, ByVal _TotalMarks As Double, ByVal _ObtainMarks As Double, ByVal _PECNumber As String, ByVal _PECDate As DateTime, ByVal _FECNumber As String, ByVal _FECDate As DateTime) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        Dim xx As Int32
        If (_Handicape = True) Then
            xx = 1
        Else
            xx = 0
        End If
        str = "INSERT INTO tblEnrollment ([CollegeID] ,[CourseID],[FacultyID] ,[FormNo],[FirstName],[MiddleName],[LastName],[Address1],[City1],[Pincode1],[MobileNO1],[PhoneNo1],[Address2],[City2],[Pincode2],[MobileNo2],[PhoneNo2],[DateOfBirth],[Gender],[Handicape],[Nationality],[Cast],[SubCast],[Minority],[Religion],[NameOfBoard],[SeatNumber],[ExamCenter],[YearOfPassing],[NameOfSchool],[TotalMarks],[ObtainMarks],[PECNumber],[PECDate],[FECNumber],[FECDate]) VALUES(" & _CollegeID & ", " & _CourseID & ", " & _FacultyID & ",'" & _FormNo & "','" & _FirstName & "','" & _MiddleName & "','" & _LastName & "','" & _Address1 & "','" & _City1 & "','" & _Pincode1 & "','" & _MobileNO1 & "','" & _PhoneNo1 & "','" & _Address2 & "','" & _City2 & "','" & _Pincode2 & "','" & _MobileNo2 & "','" & _PhoneNo2 & "','" & _DateOfBirth.ToString("yyyy-MM-dd") & "','" & _Gender & "'," & xx & ",'" & _Nationality & "','" & _Cast & "','" & _SubCast & "','" & _Minority & "','" & _Religion & "','" & _NameOfBoard & "','" & _SeatNumber & "','" & _ExamCenter & "','" & _YearOfPassing & "','" & _NameOfSchool & "'," & _TotalMarks & "," & _ObtainMarks & ",'" & _PECNumber & "','" & _PECDate.ToString("yyyy-MM-dd") & "','" & _FECNumber & "','" & _FECDate.ToString("yyyy-MM-dd") & "')"
        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery()


    End Function

    Public Function update(ByVal _EnrollmentID As Integer, ByVal _CollegeID As Integer, ByVal _CourseID As Integer, ByVal _FacultyID As Integer, ByVal _FormNo As String, ByVal _FirstName As String, ByVal _MiddleName As String, ByVal _LastName As String, ByVal _Address1 As String, ByVal _City1 As String, ByVal _Pincode1 As String, ByVal _MobileNO1 As String, ByVal _PhoneNo1 As String, ByVal _Address2 As String, ByVal _City2 As String, ByVal _Pincode2 As String, ByVal _MobileNo2 As String, ByVal _PhoneNo2 As String, ByVal _DateOfBirth As DateTime, ByVal _Gender As String, ByVal _Handicape As Boolean, ByVal _Nationality As String, ByVal _Cast As String, ByVal _SubCast As String, ByVal _Minority As String, ByVal _Religion As String, ByVal _NameOfBoard As String, ByVal _SeatNumber As String, ByVal _ExamCenter As String, ByVal _YearOfPassing As String, ByVal _NameOfSchool As String, ByVal _TotalMarks As Double, ByVal _ObtainMarks As Double, ByVal _PECNumber As String, ByVal _PECDate As DateTime, ByVal _FECNumber As String, ByVal _FECDate As DateTime) As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim str As String
        str = "UPDATE dbo.tblEnrollment set CollegeID='" & _CollegeID & "', CourseID ='" & _CourseID & "',FormNo= '" & _FormNo & "',FirstName='" & _FirstName & "',MiddleName='" & _MiddleName & "',LastName='" & _LastName & "', Address1='" & _Address1 & "',City1='" & _City1 & "',Pincode1='" & _Pincode1 & "',MobileNO1='" & _MobileNO1 & "',PhoneNo1='" & _PhoneNo1 & "',Address2='" & _Address2 & "',City2='" & _City2 & "',MobileNo2='" & _MobileNo2 & "',PhoneNo2='" & _PhoneNo2 & "',DateOfBirth='" & _DateOfBirth.ToString("yyyy-MM-dd") & "',Gender ='" & _Gender & "',Handicape ='" & _Handicape & "',Nationality ='" & _Nationality & "',Cast ='" & _Cast & "',SubCast ='" & _SubCast & "',Minority ='" & _Minority & "',Religion ='" & _Religion & "',NameOfBoard ='" & _NameOfBoard & "',SeatNumber ='" & _SeatNumber & "',ExamCenter ='" & _ExamCenter & "',YearOfPassing ='" & _YearOfPassing & "',NameOfSchool ='" & _NameOfSchool & "',TotalMarks ='" & _TotalMarks & "',ObtainMarks ='" & _ObtainMarks & "',PECNumber ='" & _PECNumber & "',PECDate ='" & _PECDate.ToString("yyyy-MM-dd") & "', FECNumber ='" & _FECNumber & "', FECDate ='" & _FECDate.ToString("yyyy-MM-dd") & "' where EnrollmentID=" & _EnrollmentID

        Dim objComm As New SqlCommand(str, objSCon)
        Return objComm.ExecuteNonQuery

    End Function

    Public Function Count() As Integer
        Dim c As New clsConnection()
        objSCon = New SqlConnection(c.GetConnectionString())
        objSCon.Open()
        Dim objComm As New SqlCommand("select count(*) from tblEnrollment", objSCon)
        Return Convert.ToInt32(objComm.ExecuteScalar())
    End Function

End Class