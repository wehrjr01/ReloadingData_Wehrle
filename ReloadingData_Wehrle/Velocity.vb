Public Class Velocity
    Private adapter As New CartridgeDataSetTableAdapters.ChronoDataTableAdapter
    Public Shared Property LastError As String
    ''' <summary>
    ''' Insert function that allows adding velocity values to the chrono table
    ''' </summary>
    ''' <param name="velo"></param>
    ''' <param name="loadId"></param>
    ''' <param name="firedDate"></param>
    ''' <returns> a true or false value indicating if the insert worked or not</returns>
    Public Function Insert(ByVal velo As Integer,
                           ByVal loadId As Integer,
                           ByVal firedDate As Date) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(velo, loadId, firedDate)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function
    ''' <summary>
    ''' readonly functionality for the items of the chrono data
    ''' </summary>
    ''' <returns>a sorted table of chrono data by date</returns>
    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Fired Date"
            Return table
        End Get
    End Property
    ''' <summary>
    ''' delete function for removing velocity values
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <returns>the number of rows that were deleted</returns>
    Public Function Delete(ByVal Id As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(Id)
        Return rowsAffected > 0
    End Function
End Class
