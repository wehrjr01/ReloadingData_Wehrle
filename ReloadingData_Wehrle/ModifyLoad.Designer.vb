<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyLoad
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrimer = New System.Windows.Forms.TextBox()
        Me.dgvBullets = New System.Windows.Forms.DataGridView()
        Me.BulletIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiameterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RifleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BulletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CartridgeDataSet = New ReloadingData_Wehrle.CartridgeDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOal = New System.Windows.Forms.TextBox()
        Me.txtPowderWeight = New System.Windows.Forms.TextBox()
        Me.cboPowders = New System.Windows.Forms.ComboBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdateLoad = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCaliberName = New System.Windows.Forms.ComboBox()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BulletTableAdapter = New ReloadingData_Wehrle.CartridgeDataSetTableAdapters.BulletTableAdapter()
        Me.lblLoadId = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvBullets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartridgeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 381)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(796, 22)
        Me.StatusStrip1.TabIndex = 66
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(564, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Primer"
        '
        'txtPrimer
        '
        Me.txtPrimer.Location = New System.Drawing.Point(437, 143)
        Me.txtPrimer.Name = "txtPrimer"
        Me.txtPrimer.Size = New System.Drawing.Size(121, 20)
        Me.txtPrimer.TabIndex = 64
        '
        'dgvBullets
        '
        Me.dgvBullets.AllowUserToAddRows = False
        Me.dgvBullets.AllowUserToDeleteRows = False
        Me.dgvBullets.AutoGenerateColumns = False
        Me.dgvBullets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBullets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BulletIdDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.DiameterDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.RifleDataGridViewCheckBoxColumn})
        Me.dgvBullets.DataSource = Me.BulletBindingSource
        Me.dgvBullets.Location = New System.Drawing.Point(12, 186)
        Me.dgvBullets.Name = "dgvBullets"
        Me.dgvBullets.ReadOnly = True
        Me.dgvBullets.Size = New System.Drawing.Size(639, 131)
        Me.dgvBullets.TabIndex = 63
        '
        'BulletIdDataGridViewTextBoxColumn
        '
        Me.BulletIdDataGridViewTextBoxColumn.DataPropertyName = "BulletId"
        Me.BulletIdDataGridViewTextBoxColumn.HeaderText = "BulletId"
        Me.BulletIdDataGridViewTextBoxColumn.Name = "BulletIdDataGridViewTextBoxColumn"
        Me.BulletIdDataGridViewTextBoxColumn.ReadOnly = True
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(198, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(242, 5)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(321, 77)
        Me.txtNotes.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(369, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Length"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Powder Weight"
        '
        'txtOal
        '
        Me.txtOal.Location = New System.Drawing.Point(242, 143)
        Me.txtOal.Name = "txtOal"
        Me.txtOal.Size = New System.Drawing.Size(121, 20)
        Me.txtOal.TabIndex = 58
        '
        'txtPowderWeight
        '
        Me.txtPowderWeight.Location = New System.Drawing.Point(12, 143)
        Me.txtPowderWeight.Name = "txtPowderWeight"
        Me.txtPowderWeight.Size = New System.Drawing.Size(121, 20)
        Me.txtPowderWeight.TabIndex = 57
        '
        'cboPowders
        '
        Me.cboPowders.FormattingEnabled = True
        Me.cboPowders.Location = New System.Drawing.Point(12, 104)
        Me.cboPowders.Name = "cboPowders"
        Me.cboPowders.Size = New System.Drawing.Size(121, 21)
        Me.cboPowders.TabIndex = 56
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(437, 333)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(115, 23)
        Me.btnReturn.TabIndex = 55
        Me.btnReturn.Text = "Return To Home"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Powder Name"
        '
        'btnUpdateLoad
        '
        Me.btnUpdateLoad.Location = New System.Drawing.Point(12, 333)
        Me.btnUpdateLoad.Name = "btnUpdateLoad"
        Me.btnUpdateLoad.Size = New System.Drawing.Size(100, 23)
        Me.btnUpdateLoad.TabIndex = 51
        Me.btnUpdateLoad.Text = "Update Load"
        Me.btnUpdateLoad.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Caliber"
        '
        'cboCaliberName
        '
        Me.cboCaliberName.FormattingEnabled = True
        Me.cboCaliberName.Location = New System.Drawing.Point(12, 61)
        Me.cboCaliberName.Name = "cboCaliberName"
        Me.cboCaliberName.Size = New System.Drawing.Size(121, 21)
        Me.cboCaliberName.Sorted = True
        Me.cboCaliberName.TabIndex = 49
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'BulletTableAdapter
        '
        Me.BulletTableAdapter.ClearBeforeFill = True
        '
        'lblLoadId
        '
        Me.lblLoadId.AutoSize = True
        Me.lblLoadId.Location = New System.Drawing.Point(13, 24)
        Me.lblLoadId.Name = "lblLoadId"
        Me.lblLoadId.Size = New System.Drawing.Size(0, 13)
        Me.lblLoadId.TabIndex = 67
        '
        'ModifyLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 403)
        Me.Controls.Add(Me.lblLoadId)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrimer)
        Me.Controls.Add(Me.dgvBullets)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtOal)
        Me.Controls.Add(Me.txtPowderWeight)
        Me.Controls.Add(Me.cboPowders)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnUpdateLoad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCaliberName)
        Me.Name = "ModifyLoad"
        Me.Text = "ModifyLoad"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvBullets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartridgeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrimer As TextBox
    Friend WithEvents dgvBullets As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOal As TextBox
    Friend WithEvents txtPowderWeight As TextBox
    Friend WithEvents cboPowders As ComboBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdateLoad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCaliberName As ComboBox
    Friend WithEvents CartridgeDataSet As CartridgeDataSet
    Friend WithEvents BulletBindingSource As BindingSource
    Friend WithEvents BulletTableAdapter As CartridgeDataSetTableAdapters.BulletTableAdapter
    Friend WithEvents errProvider As ErrorProvider
    Friend WithEvents BulletIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiameterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RifleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents lblLoadId As Label
End Class
