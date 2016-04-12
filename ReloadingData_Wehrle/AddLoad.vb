

Public Class AddLoad
    Dim mBullet As New Bullets
    Dim mPowder As New Powders
    Dim mCaliber As New Cartridge



    Private Sub AddLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill the caliber combo box.
        cboCaliberName.DataSource = mCaliber.Items
        cboCaliberName.DisplayMember = "Name"
        cboCaliberName.ValueMember = "Name"

        'Fill the powder combo box.
        cboPowders.DataSource = mPowder.Items
        cboPowders.DisplayMember = "Name"
        cboPowders.ValueMember = "Name"

        'Fill the bullet weight combo box
        cboBulletId.DataSource = mBullet.Items
        cboBulletId.DisplayMember = "BulletId"
        cboBulletId.ValueMember = "BulletId"
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()

    End Sub

    Private Sub cboBulletId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBulletId.SelectedIndexChanged


        If cboBulletId.SelectedIndex = -1 Then Exit Sub
        'Get the Member_Id value associated with the selected member
        Dim bullet_Id As Short = CShort(cboBulletId.SelectedValue)
        Dim fullName As String
        txtBulletInfo.Text = "test"
    End Sub


    'If cboMemberName.SelectedIndex = -1 Then Exit Sub
    '    'Get the Member_Id value associated with the selected member
    '    Dim member_Id As Short = CShort(cboMemberName.SelectedValue)
    '    'Fill the payments grid, passing it the member ID.
    '    PaymentsTableAdapter.MemberPayments(KarateDataSet.Payments, member_Id)
    'End Sub





End Class