Option Strict On
Option Explicit On

Public Class Loads
    Private adapter As New CartridgeDataSetTableAdapters.LoadsTableAdapter
    Private comboAdapter As New CartridgeDataSetTableAdapters.LoadBulletTableAdapter
    Private veladapter As New CartridgeDataSetTableAdapters.ChronoDataTableAdapter
    Public Shared Property LastError As String

    Public Function Insert(ByVal cartName As String,
                           ByVal bulletId As Integer,
                           ByVal primer As String,
                           ByVal powderName As String,
                           ByVal powderWeight As Decimal,
                           ByVal oAL As Decimal,
                           ByVal notes As String) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(cartName, bulletId, primer, powderName, powderWeight, oAL, notes)
            Return True

        Catch ex As Exception
            LastError = ex.Message
            Return False

        End Try
    End Function
    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property



    'Public Function Update(ByVal typeId As Short,
    '                       ByVal description As String,
    '                       ByVal licensed As Boolean,
    '                       ByVal custId As Short,
    '                       ByVal Scheduled As DateTime,
    '                       ByVal apptId As Integer) As Boolean
    '    'update a row into the appointments table. Return true if successful.
    '    'if an exception is thrown, lasterror will hold an error messate.
    '    LastError = String.Empty
    '    Try
    '        adapter.Update(typeId, description, licensed, custId, Scheduled, apptId)
    '        Return True
    '    Catch ex As Exception
    '        LastError = ex.Message
    '        Return False
    '    End Try
    'End Function



    Public Function FindByLoadId(ByVal loadId As Integer) As CartridgeDataSet.LoadBulletRow
        Dim table As CartridgeDataSet.LoadBulletDataTable
        table = comboAdapter.GetDataInnerJoinLoadBullet
        Return table.FindByLoadId(loadId)
    End Function

    Public Function CheckForVelocities(ByVal LoadId As Integer) As Integer
        Dim tableV As CartridgeDataSet.ChronoDataDataTable
        tableV = veladapter.GetDataByLoadId(LoadId)
        Return tableV.Count
    End Function

    Public Function Delete(ByVal loadId As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(loadId)
        Return rowsAffected > 0
    End Function

End Class
