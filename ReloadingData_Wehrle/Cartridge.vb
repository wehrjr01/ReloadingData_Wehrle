Public Class Cartridge
    Private adapter As New CartridgeDataSetTableAdapters.CartridgeTableAdapter

    Public Shared Property LastError As String

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

    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Caliber"
            Return table
        End Get
    End Property



End Class
