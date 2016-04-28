Option Strict On
Option Explicit On


Public Class AddLoad
    Dim mBullet As New Bullets
    Dim mPowder As New Powders
    Dim mCaliber As New Cartridge
    Dim mdiameter As Decimal
    Dim mrifle As Boolean
    Dim mload As New Loads
    ''' <summary>
    ''' Page load event, fills the bullets available data table and the combo boxes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Fill the caliber combo box.
        cboCaliberName.DataSource = mCaliber.Items
        cboCaliberName.DisplayMember = "Name"
        cboCaliberName.ValueMember = "Name"

        'Fill the powder combo box.
        cboPowders.DataSource = mPowder.Items
        cboPowders.DisplayMember = "Name"
        cboPowders.ValueMember = "Name"

        Me.BulletTableAdapter.FillByDia_Rifle(Me.CartridgeDataSet.Bullet, 0, mrifle)
        clearForm()

    End Sub
    ''' <summary>
    ''' handles the return button click to return to the main form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()

    End Sub
    ''' <summary>
    ''' updates the dgv of bullets that work with the selected caliber when the combo box is changed
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
    ''' handles the add load button click - checks for proper inputs then adds the load to the table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddLoad_Click(sender As Object, e As EventArgs) Handles btnAddLoad.Click
        Dim powWeight As Decimal
        Dim coal As Decimal
        Dim bulletID As Integer
        Dim notes As String
        Dim calname As String
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
        calname = cboCaliberName.SelectedItem.ToString
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
            errProvider.SetError(dgvBullets, "Select a bullet for the new load")
            Return
        End If

        If mload.Insert(calname, bulletID, txtPrimer.Text.ToString, cboPowders.SelectedValue.ToString, powWeight, coal, notes) Then
            clearForm()
            lblStatus.Text = "Load added to database"
        Else
            lblStatus.Text = "Cannot Add Load"
        End If

    End Sub
    ''' <summary>
    ''' clear form sub routine to empty all the boxes on the form
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