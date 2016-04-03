Option Strict On
Option Explicit On

Public Class Bullets
    Private adapter As New CartridgeDataSetTableAdapters.BulletTableAdapter
    Public Shared Property LastError As String

    Public Function Insert(ByVal ID As Integer,
                          ByVal diam As Decimal,
                           ByVal brand As String,
                           ByVal weight As Integer,
                           ByVal type As String,
                           ByVal rifle As Boolean) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(ID, brand, diam, weight, type, rifle)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False

        End Try
    End Function
    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Diameter"
            Return table
        End Get
    End Property



End Class
