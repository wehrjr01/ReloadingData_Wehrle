

Public Class AddLoad
    Dim mBullet As New Bullets
    Dim mPowder As New Powders
    Dim mCaliber As New Cartridge
    Dim mdiameter As Decimal
    Dim mrifle As Boolean
    Dim mload As New Loads




    Private Sub AddLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CartridgeDataSet.Bullet' table. You can move, or remove it, as needed.
        Me.BulletTableAdapter.Fill(Me.CartridgeDataSet.Bullet)
        'Fill the caliber combo box.
        cboCaliberName.DataSource = mCaliber.Items
        cboCaliberName.DisplayMember = "Name"
        cboCaliberName.ValueMember = "Name"

        'Fill the powder combo box.
        cboPowders.DataSource = mPowder.Items
        cboPowders.DisplayMember = "Name"
        cboPowders.ValueMember = "Name"

        'TODO: This line of code loads data into the 'CartridgeDataSet.Loads' table. You can move, or remove it, as needed.
        'Dim selectedCaliber As New Cartridge
        'selectedCaliber = cboCaliberName.SelectedValue
        'mdiameter = 0.3
        'mrifle = True

        Me.BulletTableAdapter.FillByDia_Rifle(Me.CartridgeDataSet.Bullet, mdiameter, mrifle)


    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()

    End Sub

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

    Private Sub btnAddLoad_Click(sender As Object, e As EventArgs) Handles btnAddLoad.Click
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
            errProvider.SetError(cboCaliberName, "Choose a Powder")
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

        If mload.Insert(cboCaliberName.SelectedValue.ToString, bulletID, txtPrimer.Text.ToString, cboPowders.SelectedValue.ToString, powWeight, coal, notes) Then
            Me.Close()
        Else
            lblStatus.Text = "Cannot Add Load "
        End If

    End Sub






    'If cboMemberName.SelectedIndex = -1 Then Exit Sub
    '    'Get the Member_Id value associated with the selected member
    '    Dim member_Id As Short = CShort(cboMemberName.SelectedValue)
    '    'Fill the payments grid, passing it the member ID.
    '    PaymentsTableAdapter.MemberPayments(KarateDataSet.Payments, member_Id)
    'End Sub





End Class