Public Class MainForm
    Dim mBullet As New Bullets
    Dim mPowder As New Powders
    Dim selectedLoad As String




    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuItmExit.Click
        Me.Close()
    End Sub


    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btnViewChrono_Click(sender As Object, e As EventArgs) Handles btnViewChrono.Click
        If dgvLoadList.SelectedRows.Count > 0 Then
            Dim loadId As Integer = CInt(dgvLoadList.SelectedRows(0).Cells(0).Value)
            Dim frm As New ChronoData
            frm.LoadId = loadId
            frm.ShowDialog()
            ' dgvAppointments.DataSource = mAppointments.Items
        Else
            MessageBox.Show("Please select a load to view chrono data")
            Return
        End If

        ChronoData.ShowDialog()
    End Sub


    Public Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated
        'TODO: This line of code loads data into the 'CartridgeDataSet.Loads' table. You can move, or remove it, as needed.
        Me.LoadsTableAdapter.Fill(Me.CartridgeDataSet.Loads)
        'Fill the caliber combo box.
        cboDiameter.DataSource = mBullet.Items
        cboDiameter.DisplayMember = "Diameter"
        cboDiameter.ValueMember = "BulletId"

        'Fill the powder combo box.
        cboPowders.DataSource = mPowder.Items
        cboPowders.DisplayMember = "Name"
        cboPowders.ValueMember = "Name"

        'Fill the bullet weight combo box
        cboBulletWeight.DataSource = mBullet.Items
        cboBulletWeight.DisplayMember = "Weight"
        cboBulletWeight.ValueMember = "BulletId"

    End Sub

    Private Sub mnuItmAddComponents_Click(sender As Object, e As EventArgs) Handles mnuItmAddComponents.Click
        AddComponents.ShowDialog()
    End Sub

    Private Sub mnuItmAddLoad_Click(sender As Object, e As EventArgs) Handles mnuItmAddLoad.Click
        AddLoad.ShowDialog()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Me.LoadsTableAdapter.FillbyLoadId(CartridgeDataSet.Loads, txtLoadId.Text)
    End Sub

    Private Sub DeleteLoadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteLoadsToolStripMenuItem.Click
        DeleteLoadForm.ShowDialog()
    End Sub
End Class
