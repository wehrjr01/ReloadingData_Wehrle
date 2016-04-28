Option Strict On
Option Explicit On

Public Class AddComponents

    Private Shared mComponents() As String = {"Cartridge", "Powder", "Bullet"}
    Private mPowders As New Powders
    Private mBullets As New Bullets
    Private mCartridge As New Cartridge

    ''' <summary>
    ''' get components function that uses array to fill the combo box to select the type of component to be added. 
    ''' </summary>
    ''' <returns>an array of possible component types that can be selected</returns>
    Public Shared Function GetComponents() As String()
        Dim length As Integer = mComponents.Length
        Dim array(length - 1) As String

        For j As Integer = 0 To length - 1 Step 1
            array(j) = mComponents(j)

        Next
        Return array
    End Function

    ''' <summary>
    ''' page load event, Fills the drop down box For items To add new testing
    ''' </summary>

    Private Sub AddComponents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboComponentType.DataSource = AddComponents.GetComponents
        radRifle.Checked = True

    End Sub
    ''' <summary>
    ''' component type combo box changed- sets the input fields based on the combo box selection. Only certain inputs and types are required for each component type
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboComponentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComponentType.SelectedIndexChanged
        resetFrm()
        lblStatus.Text = ""
    End Sub
    ''' <summary>
    ''' return button handler- closes this form 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()


    End Sub
    ''' <summary>
    ''' reset from routine. Sets the form up based on the type combo box and clears all the other fields out
    ''' </summary>
    Private Sub resetFrm()
        txtID.Enabled = True
        txt1.Enabled = True
        txt2.Enabled = True
        txt3.Enabled = True
        txt4.Enabled = True
        txtID.Text = ""
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        errProvider.Clear()
        lbl1.Text = ""
        lbl2.Text = ""
        lbl3.Text = ""
        lbl4.Text = ""

        If cboComponentType.SelectedItem Is "Bullet" Then
            lbl1.Text = "Brand"
            lbl2.Text = "Diameter"
            lbl3.Text = "Weight"
            lbl4.Text = "Type"
            dgvComponents.DataSource = BulletBindingSource
            Me.BulletTableAdapter.Fill(Me.CartridgeDataSet.Bullet)
            txtID.Focus()

        ElseIf cboComponentType.SelectedItem Is "Cartridge" Then
            txtID.Enabled = False
            lbl1.Text = "Caliber"
            lbl2.Text = "Name"
            lbl3.Text = ""
            lbl4.Text = ""
            txt3.Enabled = False
            txt4.Enabled = False
            dgvComponents.DataSource = CartridgeBindingSource
            Me.CartridgeTableAdapter.Fill(Me.CartridgeDataSet.Cartridge)
            txt1.Focus()

        ElseIf cboComponentType.SelectedItem Is "Powder" Then
            txtID.Enabled = False
            lbl1.Text = "Manufacturer"
            lbl2.Text = "Name"
            lbl3.Text = ""
            lbl4.Text = ""
            txt3.Enabled = False
            txt4.Enabled = False
            dgvComponents.DataSource = PowderBindingSource
            Me.PowderTableAdapter.Fill(Me.CartridgeDataSet.Powder)
            txt1.Focus()
        End If
    End Sub
    ''' <summary>
    ''' add button function - handles adding to any of the 3 components databases
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lblStatus.Text = ""
        errProvider.Clear()

        'adds a powder item to its table
        If cboComponentType.SelectedValue Is "Powder" Then
            Dim manufacturer As String
            Dim name As String

            If txt1.Text = "" Then
                errProvider.SetError(txt1, "Enter the powder manufacturer")
                txt1.Focus()
                Return
            Else manufacturer = txt1.Text.ToString
            End If
            If txt2.Text = "" Then
                errProvider.SetError(txt2, "Enter the powder name")
                txt2.Focus()
                Return
            Else name = txt2.Text.ToString
            End If

            Dim riflechk As Boolean = radRifle.Checked
            If mPowders.Insert(manufacturer, name, riflechk) = True Then
                lblStatus.Text = "Powder added successfully"
                Me.PowderTableAdapter.Fill(Me.CartridgeDataSet.Powder)
                resetFrm()
            Else
                lblStatus.Text = "Cannot Add Powder, it already exists " & 'mPowders.LastError
                txt1.Focus()
            End If
        End If

        'adds a bullet item to its table
        If cboComponentType.SelectedValue Is "Bullet" Then
            Dim bulletId As Integer
            Dim diameter As Decimal
            Dim brand As String
            Dim weight As Integer
            Dim type As String

            If (Not Integer.TryParse(txtID.Text, bulletId)) Then
                errProvider.SetError(txtID, "Enter a valid ID number")
                txtID.Focus()
                Return
            End If
            If (bulletId < 0) Then
                errProvider.SetError(txtID, "Enter a valid ID number")
                txtID.Focus()
                Return
            End If

            If txt1.Text = "" Then
                errProvider.SetError(txt1, "Enter a brand of bullet")
                txt1.Focus()
                Return
            Else brand = txt1.Text.ToString
            End If

            If (Not Decimal.TryParse(txt2.Text, diameter)) Then
                errProvider.SetError(txt2, "Enter a valid diameter between 0 and .500")
                txt2.Focus()
                Return
            End If
            If (diameter > 0.5) Then
                errProvider.SetError(txt2, "Diameter is too large, must be .500 or smaller")
                txt2.Focus()
                Return
            End If
            If (diameter < 0) Then
                errProvider.SetError(txt2, "Diameter must be greater than 0")
                txt2.Focus()
                Return
            End If


            If (Not Integer.TryParse(txt3.Text, weight)) Then
                errProvider.SetError(txt3, "Enter a valid weight in grains")
                txt3.Focus()
                Return
            End If
            If (weight < 0) Then
                errProvider.SetError(txt3, "Weight must be greater than 0")
                txt3.Focus()
                Return
            End If

            If txt4.Text = "" Then
                errProvider.SetError(txt4, "Enter a type of bullet")
                Return
            Else type = txt4.Text.ToString
            End If

            Dim riflechk As Boolean = radRifle.Checked

            If mBullets.Insert(bulletId, diameter, brand, weight, type, riflechk) = True Then
                lblStatus.Text = "Bullet added successfully"
                Me.BulletTableAdapter.Fill(Me.CartridgeDataSet.Bullet)
                resetFrm()
            Else
                lblStatus.Text = "Cannot add bullet, it already exists " & 'Bullet.LastError
                txtID.Focus()
                Return
            End If
        End If

        'adds a cartridge to its table
        If cboComponentType.SelectedValue Is "Cartridge" Then

            Dim name As String
            Dim caliber As Decimal
            Dim riflechk As Boolean = radRifle.Checked

            If (Not Decimal.TryParse(txt1.Text, caliber)) Then
                errProvider.SetError(txt1, "Enter a valid caliber between 0 and .500")
                Return
            End If
            If (caliber > 0.5) Then
                errProvider.SetError(txt1, "Caliber is too large, must be .500 or smaller")
                Return
            End If
            If (caliber < 0) Then
                errProvider.SetError(txt1, "Caliber must be greater than 0")
                Return
            End If


            If txt2.Text = "" Then
                errProvider.SetError(txt2, "Enter the cartridge name")
                Return
            Else name = txt2.Text.ToString
            End If

            If mCartridge.Insert(name, caliber, riflechk) = True Then
                lblStatus.Text = "Cartridge added successfully"
                Me.CartridgeTableAdapter.Fill(Me.CartridgeDataSet.Cartridge)
                resetFrm()
            Else
                lblStatus.Text = "Cannot add cartridge, it already exists " '& Cartridge.LastError
                Return
            End If
        End If
    End Sub
End Class