Public Class Velocity
    Private adapter As New CartridgeDataSetTableAdapters.ChronoDataTableAdapter
    Public Shared Property LastError As String

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

    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Name"
            Return table
        End Get
    End Property

    Public Function Delete(ByVal Id As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(Id)
        Return rowsAffected > 0
    End Function
End Class
