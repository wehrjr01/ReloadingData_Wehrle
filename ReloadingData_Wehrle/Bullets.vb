Option Strict On
Option Explicit On

Public Class Bullets
    Private adapter As New CartridgeDataSetTableAdapters.BulletTableAdapter
    Public Shared Property LastError As String
    ''' <summary>
    ''' insert function for the bullets class
    ''' </summary>
    ''' <param name="ID"></param>
    ''' <param name="diam"></param>
    ''' <param name="brand"></param>
    ''' <param name="weight"></param>
    ''' <param name="type"></param>
    ''' <param name="rifle"></param>
    ''' <returns>last error when insert command fails</returns>
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
    ''' <summary>
    ''' items property gets the bullets from the table and sorts them by diameter
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Diameter"
            Return table
        End Get
    End Property

End Class
