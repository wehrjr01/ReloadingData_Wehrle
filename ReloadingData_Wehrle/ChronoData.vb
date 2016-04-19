Option Strict On
Option Explicit On


Public Class ChronoData

    Public Property LoadId As Integer

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ChronoData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CartridgeDataSet.ChronoData' table. You can move, or remove it, as needed.
        Me.ChronoDataTableAdapter.Fill(Me.CartridgeDataSet.ChronoData)
        'TODO: This line of code loads data into the 'CartridgeDataSet.Cartridge' table. You can move, or remove it, as needed.
        Me.CartridgeTableAdapter.Fill(Me.CartridgeDataSet.Cartridge)

        ChronoDataTableAdapter.FillByLoadId(CartridgeDataSet.ChronoData, LoadId)


    End Sub
End Class