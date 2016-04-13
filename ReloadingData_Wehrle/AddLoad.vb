

Public Class AddLoad
    Dim mBullet As New Bullets
    Dim mPowder As New Powders
    Dim mCaliber As New Cartridge
    Dim mdiameter As Decimal
    Dim mrifle As Boolean



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
        mdiameter = 0.3
        mrifle = True

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




    'If cboMemberName.SelectedIndex = -1 Then Exit Sub
    '    'Get the Member_Id value associated with the selected member
    '    Dim member_Id As Short = CShort(cboMemberName.SelectedValue)
    '    'Fill the payments grid, passing it the member ID.
    '    PaymentsTableAdapter.MemberPayments(KarateDataSet.Payments, member_Id)
    'End Sub





End Class