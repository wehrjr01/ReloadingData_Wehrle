Option Strict On
Option Explicit On

Public Class ModifyLoad

    Public Property loadId As Integer
    Dim mBullet As New Bullets
    Dim mPowder As New Powders
    Dim mCaliber As New Cartridge
    Dim mdiameter As Decimal
    Dim mrifle As Boolean
    Dim mload As New Loads

    ''' <summary>
    ''' Page load event, fills the bullets available data table and the combo boxes with the selected load to be modified's data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ModifyLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As CartridgeDataSet.LoadBulletRow
        row = mload.FindByLoadId(loadId)

        'Fill the caliber combo box.
        cboCaliberName.DataSource = mCaliber.Items
        cboCaliberName.DisplayMember = "Name"
        cboCaliberName.ValueMember = "Name"

        'Fill the powder combo box.
        cboPowders.DataSource = mPowder.Items
        cboPowders.DisplayMember = "Name"
        cboPowders.ValueMember = "Name"

        cboCaliberName.Text = row.CartName.ToString
        cboPowders.SelectedValue = row.PowderName.ToString
        txtPowderWeight.Text = row.Powder_Weight.ToString
        txtOal.Text = row.OAL.ToString
        txtNotes.Text = row.Notes.ToString
        txtPrimer.Text = row.Primer.ToString
        lblLoadId.Text = "You are modifying load # " & loadId.ToString

    End Sub
    ''' <summary>
    ''' handles the return button to close the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()

    End Sub
    ''' <summary>
    ''' caliber combo box changed- updates the bullet dgv based on the selected caliber so that only useable bullets can be selected
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboCaliberName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCaliberName.SelectedIndexChanged
        Try
            Dim selectedCaliber As String
            selectedCaliber = cboCaliberName.Text
            Dim table As New CartridgeDataSet.CartridgeDataTable
            Dim adapter As New CartridgeDataSetTableAdapters.CartridgeTableAdapter
            table = adapter.GetDataByName(selectedCaliber)
            Dim row As CartridgeDataSet.CartridgeRow = table.FindByName(selectedCaliber)
            mdiameter = row.Caliber
            mrifle = row.Rifle
            Me.BulletTableAdapter.FillByDia_Rifle(Me.CartridgeDataSet.Bullet, mdiameter, mrifle)
        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' update button handler, verifies inputs for valid data then attempts to update the load, message box gives status of the attempted update
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUpdateLoad_Click(sender As Object, e As EventArgs) Handles btnUpdateLoad.Click
        Dim powWeight As Decimal
        Dim coal As Decimal
        Dim bulletID As Integer
        Dim notes As String
        errProvider.Clear()

        notes = txtNotes.Text
        If txtPrimer.Text = "" Then
            errProvider.SetError(txtPrimer, "Enter a primer")
            Return
        End If
        If cboCaliberName.SelectedIndex = -1 Then
            errProvider.SetError(cboCaliberName, "Choose Cartridge Name")
            Return

        End If
        If cboPowders.SelectedIndex = -1 Then
            errProvider.SetError(cboPowders, "Choose a Powder")
            Return
        End If

        If (Not Decimal.TryParse(txtPowderWeight.Text, powWeight)) Then
            errProvider.SetError(txtPowderWeight, "Enter a valid weight in grains")
            txtPowderWeight.Focus()
            Return
        End If
        If (powWeight < 0) Then
            errProvider.SetError(txtPowderWeight, "Enter a valid weight in grains")
            txtPowderWeight.Focus()
            Return
        End If

        If (Not Decimal.TryParse(txtOal.Text, coal)) Then
            errProvider.SetError(txtOal, "Enter a valid length in inches")
            txtOal.Focus()
            Return
        End If
        If (coal < 0) Then
            errProvider.SetError(txtOal, "Enter a valid length in inches")
            txtOal.Focus()
            Return
        End If

        If dgvBullets.SelectedRows.Count > 0 Then
            bulletID = CInt(dgvBullets.SelectedRows(0).Cells(0).Value)
        Else
            errProvider.SetError(dgvBullets, "Select a bullet for the load")
            Return
        End If

        If mload.Update(cboCaliberName.Text, bulletID, txtPrimer.Text.ToString, cboPowders.Text, powWeight, coal, notes, loadId) Then

            lblStatus.Text = "Load # " & loadId.ToString & "  updated in database"
        Else
            lblStatus.Text = "Cannot update Load"
        End If

    End Sub
    ''' <summary>
    ''' clear form sub to empty all the boxes on the form
    ''' </summary>
    Private Sub clearForm()
        cboCaliberName.SelectedIndex = -1
        cboPowders.SelectedIndex = -1
        txtPowderWeight.Text = ""
        txtOal.Text = ""
        txtPrimer.Text = ""
        txtNotes.Text = ""
    End Sub
End Class
