Option Strict On
Option Explicit On

Public Class Loads
    Private adapter As New CartridgeDataSetTableAdapters.LoadsTableAdapter
    Private comboAdapter As New CartridgeDataSetTableAdapters.LoadBulletTableAdapter
    Private veladapter As New CartridgeDataSetTableAdapters.ChronoDataTableAdapter
    Public Shared Property LastError As String
    ''' <summary>
    ''' insert function for adding a load to the table
    ''' </summary>
    ''' <param name="cartName"></param>
    ''' <param name="bulletId"></param>
    ''' <param name="primer"></param>
    ''' <param name="powderName"></param>
    ''' <param name="powderWeight"></param>
    ''' <param name="oAL"></param>
    ''' <param name="notes"></param>
    ''' <returns>last error exception message if insert fails</returns>
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
    ''' <summary>
    ''' items property, gets all the loads in the table
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property


    ''' <summary>
    ''' update function for modifying a load
    ''' </summary>
    ''' <param name="cartName"></param>
    ''' <param name="bulletId"></param>
    ''' <param name="primer"></param>
    ''' <param name="powderName"></param>
    ''' <param name="powderWeight"></param>
    ''' <param name="oAL"></param>
    ''' <param name="notes"></param>
    ''' <param name="loadId"></param>
    ''' <returns> lasterror exception message or true if successful</returns>
    Public Function Update(ByVal cartName As String,
                           ByVal bulletId As Integer,
                           ByVal primer As String,
                           ByVal powderName As String,
                           ByVal powderWeight As Decimal,
                           ByVal oAL As Decimal,
                           ByVal notes As String,
                           ByVal loadId As Integer) As Boolean
        'update a row into the loads table. Return true if successful.
        'if an exception is thrown, lasterror will hold an error messate.
        LastError = String.Empty
        Try
            adapter.Update(cartName, bulletId, primer, powderName, powderWeight, oAL, notes, loadId)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function


    ''' <summary>
    '''findby load id from the innerjoined table of loads and bullets
    ''' </summary>
    ''' <param name="loadId"></param>
    ''' <returns>loadbullet table information for the given loadId</returns>
    Public Function FindByLoadId(ByVal loadId As Integer) As CartridgeDataSet.LoadBulletRow
        Dim table As CartridgeDataSet.LoadBulletDataTable
        table = comboAdapter.GetDataInnerJoinLoadBullet
        Return table.FindByLoadId(loadId)
    End Function
    ''' <summary>
    ''' check for velocities tied to a load id prevents leaving orphan velocity table items
    ''' </summary>
    ''' <param name="LoadId"></param>
    ''' <returns>the number of items with that loadid</returns>
    Public Function CheckForVelocities(ByVal LoadId As Integer) As Integer
        Dim tableV As CartridgeDataSet.ChronoDataDataTable
        tableV = veladapter.GetDataByLoadId(LoadId)
        Return tableV.Count
    End Function
    ''' <summary>
    ''' delete function for the loads table
    ''' </summary>
    ''' <param name="loadId"></param>
    ''' <returns>the number of rows affected by the delete</returns>
    Public Function Delete(ByVal loadId As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(loadId)
        Return rowsAffected > 0
    End Function

End Class
