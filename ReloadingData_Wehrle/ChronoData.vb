Public Class ChronoData
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ChronoData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CartridgeDataSet.ChronoData' table. You can move, or remove it, as needed.
        Me.ChronoDataTableAdapter.Fill(Me.CartridgeDataSet.ChronoData)

    End Sub
End Class