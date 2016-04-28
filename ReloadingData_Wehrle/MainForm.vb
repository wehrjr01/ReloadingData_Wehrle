'JAY WEHRLE
'FINAL PROJECT: RELOADING DATABASE
'4-28-2016
'USER INTERFACE FOR STORING RELOADING DATA FOR HANDLOADING
Option Strict On
Option Explicit On
Public Class MainForm
    Dim mBullet As New Bullets
    Dim mLoads As New Loads
    Dim selectedLoad As String
    Dim bulletId As Integer
    ''' <summary>
    ''' handles the tool strip exit button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuItmExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' handles the exit button on the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' view chrono data, opens the chrono window with the selected row as the target load. Checks for unselected row and returns a message box if none is chosed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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

    ''' <summary>
    ''' page load and page and page activated- 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated

        'clear the load id text box 
        txtLoadId.Text = ""
        Me.LoadsTableAdapter.Fill(Me.CartridgeDataSet.Loads)

        'Fill the cartridge search combo box and leaves it on -1 selected index
        cboCartridge.DataSource = mLoads.Items
        cboCartridge.DisplayMember = "CartName"
        cboCartridge.ValueMember = "CartName"
        cboCartridge.SelectedIndex = -1




    End Sub
    ''' <summary>
    ''' handles the add components item in the menu strip- opens the add form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuItmAddComponents_Click(sender As Object, e As EventArgs) Handles mnuItmAddComponents.Click
        AddComponents.ShowDialog()
    End Sub
    ''' <summary>
    ''' handles the add load menu strip item- opens the add load window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuItmAddLoad_Click(sender As Object, e As EventArgs) Handles mnuItmAddLoad.Click
        AddLoad.ShowDialog()
    End Sub
    ''' <summary>
    ''' handles the find button click in the search section- fills the DGV based on search selections
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        errProvider.Clear()
        If txtLoadId.Text <> "" Then
            If (Not Integer.TryParse(txtLoadId.Text, bulletId)) Then
                errProvider.SetError(txtLoadId, "Enter a valid ID number")
                txtLoadId.Focus()
                Return
            End If
            If (bulletId < 0) Then
                errProvider.SetError(txtLoadId, "Enter a valid ID number")
                txtLoadId.Focus()
                Return
            End If
            Me.LoadsTableAdapter.FillByLoadId(Me.CartridgeDataSet.Loads, bulletId)
        Else Me.LoadsTableAdapter.FillByCartName(Me.CartridgeDataSet.Loads, cboCartridge.Text)
        End If
        cboCartridge.SelectedIndex = -1
        txtLoadId.Text = ""
    End Sub
    ''' <summary>
    ''' handles the delete loads menu item- opens the delete form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteLoadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteLoadsToolStripMenuItem.Click
        DeleteLoadForm.ShowDialog()
    End Sub
    ''' <summary>
    ''' handles the view all button. This will fill the DGV with all the loads in the database
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Me.LoadsTableAdapter.Fill(Me.CartridgeDataSet.Loads)
    End Sub
    ''' <summary>
    ''' opens the about screen when about from the menu strip is selected
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
    ''' <summary>
    ''' modify button handler- loads the modify form when a load is selected from the dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If dgvLoadList.SelectedRows.Count > 0 Then
            Dim loadId As Integer = CInt(dgvLoadList.SelectedRows(0).Cells(0).Value)
            Dim frm As New ModifyLoad
            frm.LoadId = loadId
            frm.ShowDialog()
        Else
            MessageBox.Show("Please select a load to modify")
            Return
        End If
    End Sub
End Class
