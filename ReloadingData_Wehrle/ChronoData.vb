Option Strict On
Option Explicit On


Public Class ChronoData
    Dim mLoad As New Loads
    Dim mVelocity As New Velocity
    Public Property LoadId As Integer

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ChronoData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChronoDataTableAdapter.FillByLoadId(CartridgeDataSet.ChronoData, LoadId)
        Dim row As CartridgeDataSet.LoadBulletRow
        row = mLoad.FindByLoadId(LoadId)
        txtLoadNum.Text = row.LoadId.ToString
        txtCal.Text = row.CartName.ToString
        txtBullet.Text = row.Brand.ToString
        txtBulWeight.Text = row.Weight.ToString
        txtPowName.Text = row.PowderName.ToString
        txtPowWeight.Text = row.Powder_Weight.ToString
        txtCoal.Text = row.OAL.ToString
        recalculate()

    End Sub
    Public Sub recalculate()

        Dim velocityRow As CartridgeDataSet.ChronoDataRow
        Dim velTotal As Double = 0
        Dim count As Integer = 0
        Dim avgVelocity As Double
        Dim squares As New List(Of Double)
        Dim squareAvg As Double = 0
        Dim velDiff As Double = 0
        Dim stdDev As Double = 0

        For Each velocityRow In CartridgeDataSet.ChronoData.Rows
            count += 1
            velTotal += velocityRow.Velocity
        Next
        If count > 0 Then ' this prevents an exception if there is no velocity data to display
            avgVelocity = velTotal / count

            For Each velocityRow In CartridgeDataSet.ChronoData.Rows
                velDiff = velocityRow.Velocity - avgVelocity
                squares.Add(Math.Pow(velDiff, 2))
            Next
            squareAvg = squares.Average()
            stdDev = Math.Sqrt(squareAvg)
            txtStdDev.Text = stdDev.ToString("N2")
            txtAvgVel.Text = avgVelocity.ToString("N2")
        End If
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnAddVelocity_Click(sender As Object, e As EventArgs) Handles btnAddVelocity.Click
        Dim velo As Integer
        errProvider.Clear()

        If (Not Integer.TryParse(txtInputVelocity.Text, velo)) Then
            errProvider.SetError(txtInputVelocity, "Enter a valid velocity")
            txtInputVelocity.Focus()
            Return
        End If
        If (velo < 0) Then
            errProvider.SetError(txtInputVelocity, "Enter a valid velocity")
            txtInputVelocity.Focus()
            Return
        End If

        If mVelocity.Insert(velo, CInt(txtLoadNum.Text.ToString), dtpNewVelocity.Value) = True Then
            txtInputVelocity.Text = ""
            lblStatus.Text = "Velocity added successfully"
            ChronoDataTableAdapter.FillByLoadId(CartridgeDataSet.ChronoData, LoadId)

        Else
            txtInputVelocity.Text = ""
            lblStatus.Text = "Cannot add velocity," & Velocity.LastError
            txtInputVelocity.Focus()
            Return
        End If
        recalculate()
    End Sub



    Private Sub DeleteSelectedVelocityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedVelocityToolStripMenuItem.Click
        If dgvVelocity.SelectedRows.Count > 0 Then
            Dim Id As Integer = CInt(dgvVelocity.SelectedRows(0).Cells(0).Value)
            Dim delvel As New Velocity
            If delvel.Delete(Id) Then
                recalculate()
                ChronoDataTableAdapter.FillByLoadId(CartridgeDataSet.ChronoData, LoadId)
            Else
                lblStatus.Text = "Velocity not deleted"
            End If
        End If
    End Sub


End Class

