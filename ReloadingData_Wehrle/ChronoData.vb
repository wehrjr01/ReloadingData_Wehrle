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
        Dim velocityRow As CartridgeDataSet.ChronoDataRow
        Dim row As CartridgeDataSet.LoadBulletRow
        Dim velTotal As Double = 0
        Dim count As Integer = 0
        Dim avgVelocity As Double
        Dim squares As New List(Of Double)
        Dim squareAvg As Double = 0
        Dim velDiff As Double = 0
        Dim stdDev As Double = 0

        row = mLoad.FindByLoadId(LoadId)
        txtLoadNum.Text = row.LoadId.ToString
        txtCal.Text = row.CartName.ToString
        txtBullet.Text = row.Brand.ToString
        txtBulWeight.Text = row.Weight.ToString
        txtPowName.Text = row.PowderName.ToString
        txtPowWeight.Text = row.Powder_Weight.ToString
        txtCoal.Text = row.OAL.ToString

        For Each velocityRow In CartridgeDataSet.ChronoData.Rows
            count += 1
            velTotal += velocityRow.Velocity
        Next
        avgVelocity = velTotal / count

        For Each velocityRow In CartridgeDataSet.ChronoData.Rows
            velDiff = velocityRow.Velocity - avgVelocity
            squares.Add(Math.Pow(velDiff, 2))
        Next
        squareAvg = squares.Average()
        stdDev = Math.Sqrt(squareAvg)
        txtStdDev.Text = stdDev.ToString
        txtAvgVel.Text = avgVelocity.ToString
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
            'Me.BulletTableAdapter.Fill(Me.CartridgeDataSet.Bullet)

        Else
            txtInputVelocity.Text = ""
            lblStatus.Text = "Cannot add velocity," & Velocity.LastError
            txtInputVelocity.Focus()
            Return
        End If
    End Sub
End Class