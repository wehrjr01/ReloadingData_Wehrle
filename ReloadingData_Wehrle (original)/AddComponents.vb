Public Class AddComponents

    Private Shared mComponents() As String = {"Cartridge", "Powder", "Bullet"}

    Public Shared Function GetComponents() As String()
        Dim length As Integer = mComponents.Length
        Dim array(length - 1) As String

        For j As Integer = 0 To length - 1 Step 1
            array(j) = mComponents(j)

        Next
        Return array
    End Function

    ''' <summary>
    '''     Fills the drop down box For items To add
    ''' </summary>

    Private Sub AddComponents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboComponentType.DataSource = AddComponents.GetComponents

    End Sub

    Private Sub cboComponentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComponentType.SelectedIndexChanged
        txt1.Enabled = True
        txt2.Enabled = True
        txt3.Enabled = True
        txt4.Enabled = True

        If cboComponentType.SelectedItem = "Bullet" Then
            lbl1.Text = "Brand"
            lbl2.Text = "Diameter"
            lbl3.Text = "Weight"
            lbl4.Text = "Type"
            dgvAddComponents.DataSource = BulletBindingSource
            Me.BulletTableAdapter.Fill(Me.CartridgeDataSet.Bullet)
        ElseIf cboComponentType.SelectedItem = "Cartridge" Then
            lbl1.Text = "Caliber"
            lbl2.Text = "Name"
            lbl3.Text = ""
            lbl4.Text = ""
            txt3.Enabled = False
            txt4.Enabled = False
            dgvAddComponents.DataSource = CartridgeBindingSource
            Me.CartridgeTableAdapter.Fill(Me.CartridgeDataSet.Cartridge)
        ElseIf cboComponentType.SelectedItem = "Powder" Then
            lbl1.Text = "Manufacturer"
            lbl2.Text = "Name"
            lbl3.Text = ""
            lbl4.Text = ""
            txt3.Enabled = False
            txt4.Enabled = False
            dgvAddComponents.DataSource = PowderBindingSource
            Me.PowderTableAdapter.Fill(Me.CartridgeDataSet.Powder)
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cboComponentType.SelectedItem = "Cartridge" Then

        End If
    End Sub
End Class