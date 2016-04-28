Option Strict On
Option Explicit On

Public Class DeleteLoadForm
    Dim mload As New Loads
    ''' <summary>
    ''' form load fills the table with all the loads in the table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteLoadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.LoadsTableAdapter.Fill(Me.CartridgeDataSet.Loads)

    End Sub
    ''' <summary>
    ''' delete button code - deletes the selected load from the table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvLoads.SelectedRows.Count > 0 Then
            Dim selectedLoad As Integer = CInt(dgvLoads.SelectedRows(0).Cells(0).Value)
            If mload.CheckForVelocities(selectedLoad) > 0 Then
                MessageBox.Show("You must delete the chrono data before deleting the load")
                Return
            End If
            If mload.Delete(selectedLoad) Then
                'dgvComponents.DataSource = mCartridge.Items
                Me.LoadsTableAdapter.Fill(Me.CartridgeDataSet.Loads)
            Else
                MessageBox.Show("Unable to delete this load")
            End If
        End If
    End Sub
End Class