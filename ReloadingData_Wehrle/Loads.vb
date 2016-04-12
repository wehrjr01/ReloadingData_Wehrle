Option Strict On
Option Explicit On

Public Class Loads
    Private adapter As New CartridgeDataSetTableAdapters.LoadsTableAdapter
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


    'Public Shared Function CombinedDateTime(ByVal aDate As DateTime, ByVal aTime As DateTime) As DateTime
    '    Dim ts As New TimeSpan(aTime.Hour, aTime.Minute, 0)
    '    Return aDate.Add(ts)
    'End Function

    'Public Function GetByCustomerId(ByVal custId As Short) As DataTable
    '    Dim table As DataTable = adapter.GetData()
    '    table.DefaultView.RowFilter = "CustId = " & custId
    '    Return table
    'End Function


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



    'Public Function FindByApptId(ByVal apptId As Short) As RepairServicesDataSet.AppointmentsRow
    '    Dim table As RepairServicesDataSet.AppointmentsDataTable
    '    table = adapter.GetData()
    '    Return table.FindByApptId(apptId)
    'End Function

    Public Function Delete(ByVal loadId As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(loadId)
        Return rowsAffected > 0
    End Function
    'Public ReadOnly Property AppointmentList As DataTable
    '    Get
    '        Dim listAdapter As New RepairServicesDataSetTableAdapters.AppointmentListTableAdapter
    '        Return listAdapter.GetData()
    '    End Get
    'End Property


End Class
