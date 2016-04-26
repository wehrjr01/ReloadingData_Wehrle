Public Class btnViewAll
    Dim mBullet As New Bullets
    Dim mLoads As New Loads
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
        Else
            MessageBox.Show("Please select a load to view chrono data")
            Return
        End If

    End Sub


    Public Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated

        'need to clear the text boxes and drop downs here

        Me.LoadsTableAdapter.Fill(Me.CartridgeDataSet.Loads)

        'Fill the cartridge combo box.
        cboCartridge.DataSource = mLoads.Items
        cboCartridge.DisplayMember = "CartName"
        cboCartridge.ValueMember = "CartName"
        cboCartridge.SelectedIndex = -1




    End Sub

    Private Sub mnuItmAddComponents_Click(sender As Object, e As EventArgs) Handles mnuItmAddComponents.Click
        AddComponents.ShowDialog()
    End Sub

    Private Sub mnuItmAddLoad_Click(sender As Object, e As EventArgs) Handles mnuItmAddLoad.Click
        AddLoad.ShowDialog()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If txtLoadId.Text <> "" Then
            Me.LoadsTableAdapter.FillByLoadId(Me.CartridgeDataSet.Loads, txtLoadId.Text)
        Else Me.LoadsTableAdapter.FillByCartName(Me.CartridgeDataSet.Loads, cboCartridge.Text)
        End If
        cboCartridge.SelectedIndex = -1
        txtLoadId.Text = ""
    End Sub

    Private Sub DeleteLoadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteLoadsToolStripMenuItem.Click
        DeleteLoadForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.LoadsTableAdapter.Fill(Me.CartridgeDataSet.Loads)
    End Sub
End Class
