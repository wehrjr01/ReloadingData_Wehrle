Option Strict On
Option Explicit On


Public Class ChronoData

    Public Property LoadId As Integer

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ChronoData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChronoDataTableAdapter.FillByLoadId(CartridgeDataSet.ChronoData, LoadId)


    End Sub
End Class