﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLoad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCaliberName = New System.Windows.Forms.ComboBox()
        Me.cboPowders = New System.Windows.Forms.ComboBox()
        Me.txtPowderWeight = New System.Windows.Forms.TextBox()
        Me.txtOal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvBullets = New System.Windows.Forms.DataGridView()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiameterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BulletId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RifleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BulletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CartridgeDataSet = New ReloadingData_Wehrle.CartridgeDataSet()
        Me.BulletTableAdapter = New ReloadingData_Wehrle.CartridgeDataSetTableAdapters.BulletTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBullets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartridgeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(435, 352)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(115, 23)
        Me.btnReturn.TabIndex = 33
        Me.btnReturn.Text = "Return To Home"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(73, 17)
        Me.RadioButton2.TabIndex = 32
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Rifle Load"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(96, 17)
        Me.RadioButton1.TabIndex = 31
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Handgun Load"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Powder Name"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(313, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Add Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Caliber"
        '
        'cboCaliberName
        '
        Me.cboCaliberName.FormattingEnabled = True
        Me.cboCaliberName.Location = New System.Drawing.Point(16, 100)
        Me.cboCaliberName.Name = "cboCaliberName"
        Me.cboCaliberName.Size = New System.Drawing.Size(121, 21)
        Me.cboCaliberName.Sorted = True
        Me.cboCaliberName.TabIndex = 21
        '
        'cboPowders
        '
        Me.cboPowders.FormattingEnabled = True
        Me.cboPowders.Location = New System.Drawing.Point(11, 316)
        Me.cboPowders.Name = "cboPowders"
        Me.cboPowders.Size = New System.Drawing.Size(121, 21)
        Me.cboPowders.TabIndex = 34
        '
        'txtPowderWeight
        '
        Me.txtPowderWeight.Location = New System.Drawing.Point(11, 352)
        Me.txtPowderWeight.Name = "txtPowderWeight"
        Me.txtPowderWeight.Size = New System.Drawing.Size(121, 20)
        Me.txtPowderWeight.TabIndex = 36
        '
        'txtOal
        '
        Me.txtOal.Location = New System.Drawing.Point(292, 319)
        Me.txtOal.Name = "txtOal"
        Me.txtOal.Size = New System.Drawing.Size(121, 20)
        Me.txtOal.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Powder Weight"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(432, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Length"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 65)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cartridge Type"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(266, 10)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(297, 102)
        Me.txtNotes.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Notes:"
        '
        'dgvBullets
        '
        Me.dgvBullets.AllowUserToAddRows = False
        Me.dgvBullets.AllowUserToDeleteRows = False
        Me.dgvBullets.AutoGenerateColumns = False
        Me.dgvBullets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBullets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BrandDataGridViewTextBoxColumn, Me.DiameterDataGridViewTextBoxColumn, Me.BulletId, Me.WeightDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.RifleDataGridViewCheckBoxColumn})
        Me.dgvBullets.DataSource = Me.BulletBindingSource
        Me.dgvBullets.Location = New System.Drawing.Point(16, 155)
        Me.dgvBullets.Name = "dgvBullets"
        Me.dgvBullets.ReadOnly = True
        Me.dgvBullets.RowHeadersVisible = False
        Me.dgvBullets.Size = New System.Drawing.Size(571, 131)
        Me.dgvBullets.TabIndex = 45
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "Brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        Me.BrandDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiameterDataGridViewTextBoxColumn
        '
        Me.DiameterDataGridViewTextBoxColumn.DataPropertyName = "Diameter"
        Me.DiameterDataGridViewTextBoxColumn.HeaderText = "Diameter"
        Me.DiameterDataGridViewTextBoxColumn.Name = "DiameterDataGridViewTextBoxColumn"
        Me.DiameterDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BulletId
        '
        Me.BulletId.DataPropertyName = "BulletId"
        Me.BulletId.HeaderText = "BulletId"
        Me.BulletId.Name = "BulletId"
        Me.BulletId.ReadOnly = True
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RifleDataGridViewCheckBoxColumn
        '
        Me.RifleDataGridViewCheckBoxColumn.DataPropertyName = "Rifle"
        Me.RifleDataGridViewCheckBoxColumn.HeaderText = "Rifle"
        Me.RifleDataGridViewCheckBoxColumn.Name = "RifleDataGridViewCheckBoxColumn"
        Me.RifleDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'BulletBindingSource
        '
        Me.BulletBindingSource.DataMember = "Bullet"
        Me.BulletBindingSource.DataSource = Me.CartridgeDataSet
        '
        'CartridgeDataSet
        '
        Me.CartridgeDataSet.DataSetName = "CartridgeDataSet"
        Me.CartridgeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BulletTableAdapter
        '
        Me.BulletTableAdapter.ClearBeforeFill = True
        '
        'AddLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 387)
        Me.Controls.Add(Me.dgvBullets)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtOal)
        Me.Controls.Add(Me.txtPowderWeight)
        Me.Controls.Add(Me.cboPowders)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCaliberName)
        Me.Name = "AddLoad"
        Me.Text = "AddLoad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBullets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartridgeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReturn As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCaliberName As ComboBox
    Friend WithEvents cboPowders As ComboBox
    Friend WithEvents txtPowderWeight As TextBox
    Friend WithEvents txtOal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvBullets As DataGridView
    Friend WithEvents CartridgeDataSet As CartridgeDataSet
    Friend WithEvents BulletBindingSource As BindingSource
    Friend WithEvents BulletTableAdapter As CartridgeDataSetTableAdapters.BulletTableAdapter
    Friend WithEvents BrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiameterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BulletId As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RifleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
