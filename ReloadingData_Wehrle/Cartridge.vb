Option Strict On
Option Explicit On

Public Class Cartridge
    Private adapter As New CartridgeDataSetTableAdapters.CartridgeTableAdapter

    Public Shared Property LastError As String
    ''' <summary>
    ''' insert command for adding cartridge to table
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="caliber"></param>
    ''' <param name="rifle"></param>
    ''' <returns>last error - exception message if insert fails</returns>
    Public Function Insert(ByVal name As String,
                           ByVal caliber As Decimal,
                           ByVal rifle As Boolean) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(name, caliber, rifle)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False

        End Try
    End Function
    ''' <summary>
    ''' returns the itms in the table sorted by caliber
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Caliber"
            Return table
        End Get
    End Property
    ''' <summary>
    ''' delete function - not used yet, for my later implementation once I have the orphan rows checking implemented
    ''' </summary>
    ''' <param name="cartName"></param>
    ''' <returns>the number of rows affected by the delete command</returns>
    Public Function Delete(ByVal cartName As String) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(cartName)
        Return rowsAffected > 0
    End Function

End Class
