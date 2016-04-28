Option Strict On
Option Explicit On


Public Class Powders
    Private adapter As New CartridgeDataSetTableAdapters.PowderTableAdapter
    Public Shared Property LastError As String
    ''' <summary>
    ''' insert function for the powder class 
    ''' </summary>
    ''' <param name="manufacturer"></param>
    ''' <param name="name"></param>
    ''' <param name="rifle"></param>
    ''' <returns>last error if fails, true boolean if successfull addition</returns>
    Public Function Insert(ByVal manufacturer As String,
                           ByVal name As String,
                           ByVal rifle As Boolean) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(manufacturer, name, rifle)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False

        End Try
    End Function
    ''' <summary>
    ''' itms property of powders
    ''' </summary>
    ''' <returns>all the powders in the table sorted by name</returns>
    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Name"
            Return table
        End Get
    End Property

    ''' <summary>
    ''' delete function - not in use yet due to orphan rows potential
    ''' </summary>
    ''' <param name="powderName"></param>
    ''' <returns>number of rows affected by the delete</returns>

    Public Function Delete(ByVal powderName As String) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(powderName)
        Return rowsAffected > 0
    End Function


End Class
