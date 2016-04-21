<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChronoData
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLoadNum = New System.Windows.Forms.TextBox()
        Me.txtPowName = New System.Windows.Forms.TextBox()
        Me.txtPowWeight = New System.Windows.Forms.TextBox()
        Me.txtBulWeight = New System.Windows.Forms.TextBox()
        Me.txtBullet = New System.Windows.Forms.TextBox()
        Me.txtCal = New System.Windows.Forms.TextBox()
        Me.txtCoal = New System.Windows.Forms.TextBox()
        Me.txtInputVelocity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpNewVelocity = New System.Windows.Forms.DateTimePicker()
        Me.btnAddVelocity = New System.Windows.Forms.Button()
        Me.txtStdDev = New System.Windows.Forms.TextBox()
        Me.txtAvgVel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedVelocityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvVelocity = New System.Windows.Forms.DataGridView()
        Me.VelocityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChronoDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CartridgeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CartridgeDataSet = New ReloadingData_Wehrle.CartridgeDataSet()
        Me.CartridgeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.CartridgeTableAdapter = New ReloadingData_Wehrle.CartridgeDataSetTableAdapters.CartridgeTableAdapter()
        Me.ChronoDataTableAdapter = New ReloadingData_Wehrle.CartridgeDataSetTableAdapters.ChronoDataTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvVelocity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChronoDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartridgeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartridgeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartridgeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Load Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Powder Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Bullet Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Caliber"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Powder Weight"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Length"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Bullet Weight"
        '
        'txtLoadNum
        '
        Me.txtLoadNum.Location = New System.Drawing.Point(95, 55)
        Me.txtLoadNum.Name = "txtLoadNum"
        Me.txtLoadNum.Size = New System.Drawing.Size(100, 20)
        Me.txtLoadNum.TabIndex = 35
        '
        'txtPowName
        '
        Me.txtPowName.Location = New System.Drawing.Point(95, 159)
        Me.txtPowName.Name = "txtPowName"
        Me.txtPowName.Size = New System.Drawing.Size(100, 20)
        Me.txtPowName.TabIndex = 36
        '
        'txtPowWeight
        '
        Me.txtPowWeight.Location = New System.Drawing.Point(95, 189)
        Me.txtPowWeight.Name = "txtPowWeight"
        Me.txtPowWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtPowWeight.TabIndex = 37
        '
        'txtBulWeight
        '
        Me.txtBulWeight.Location = New System.Drawing.Point(95, 133)
        Me.txtBulWeight.Name = "txtBulWeight"
        Me.txtBulWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtBulWeight.TabIndex = 38
        '
        'txtBullet
        '
        Me.txtBullet.Location = New System.Drawing.Point(95, 107)
        Me.txtBullet.Name = "txtBullet"
        Me.txtBullet.Size = New System.Drawing.Size(100, 20)
        Me.txtBullet.TabIndex = 39
        '
        'txtCal
        '
        Me.txtCal.Location = New System.Drawing.Point(95, 81)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New System.Drawing.Size(100, 20)
        Me.txtCal.TabIndex = 40
        '
        'txtCoal
        '
        Me.txtCoal.Location = New System.Drawing.Point(95, 215)
        Me.txtCoal.Name = "txtCoal"
        Me.txtCoal.Size = New System.Drawing.Size(100, 20)
        Me.txtCoal.TabIndex = 41
        '
        'txtInputVelocity
        '
        Me.txtInputVelocity.Location = New System.Drawing.Point(9, 57)
        Me.txtInputVelocity.Name = "txtInputVelocity"
        Me.txtInputVelocity.Size = New System.Drawing.Size(100, 20)
        Me.txtInputVelocity.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Velocity (FPS)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpNewVelocity)
        Me.GroupBox1.Controls.Add(Me.btnAddVelocity)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtInputVelocity)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 124)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add A Velocity"
        '
        'dtpNewVelocity
        '
        Me.dtpNewVelocity.Location = New System.Drawing.Point(9, 83)
        Me.dtpNewVelocity.Name = "dtpNewVelocity"
        Me.dtpNewVelocity.Size = New System.Drawing.Size(200, 20)
        Me.dtpNewVelocity.TabIndex = 52
        '
        'btnAddVelocity
        '
        Me.btnAddVelocity.Location = New System.Drawing.Point(129, 54)
        Me.btnAddVelocity.Name = "btnAddVelocity"
        Me.btnAddVelocity.Size = New System.Drawing.Size(75, 23)
        Me.btnAddVelocity.TabIndex = 45
        Me.btnAddVelocity.Text = "Add"
        Me.btnAddVelocity.UseVisualStyleBackColor = True
        '
        'txtStdDev
        '
        Me.txtStdDev.Location = New System.Drawing.Point(486, 198)
        Me.txtStdDev.Name = "txtStdDev"
        Me.txtStdDev.Size = New System.Drawing.Size(100, 20)
        Me.txtStdDev.TabIndex = 46
        '
        'txtAvgVel
        '
        Me.txtAvgVel.Location = New System.Drawing.Point(284, 198)
        Me.txtAvgVel.Name = "txtAvgVel"
        Me.txtAvgVel.Size = New System.Drawing.Size(100, 20)
        Me.txtAvgVel.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(212, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Avg. Velocity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(403, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "STD Deviation"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(650, 24)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Menu"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedVelocityToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteSelectedVelocityToolStripMenuItem
        '
        Me.DeleteSelectedVelocityToolStripMenuItem.Name = "DeleteSelectedVelocityToolStripMenuItem"
        Me.DeleteSelectedVelocityToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.DeleteSelectedVelocityToolStripMenuItem.Text = "Delete Selected Velocity"
        '
        'dgvVelocity
        '
        Me.dgvVelocity.AutoGenerateColumns = False
        Me.dgvVelocity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVelocity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VelocityDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.dgvVelocity.DataSource = Me.ChronoDataBindingSource
        Me.dgvVelocity.Location = New System.Drawing.Point(215, 29)
        Me.dgvVelocity.Name = "dgvVelocity"
        Me.dgvVelocity.RowHeadersVisible = False
        Me.dgvVelocity.Size = New System.Drawing.Size(205, 150)
        Me.dgvVelocity.TabIndex = 51
        '
        'VelocityDataGridViewTextBoxColumn
        '
        Me.VelocityDataGridViewTextBoxColumn.DataPropertyName = "Velocity"
        Me.VelocityDataGridViewTextBoxColumn.HeaderText = "Velocity"
        Me.VelocityDataGridViewTextBoxColumn.Name = "VelocityDataGridViewTextBoxColumn"
        Me.VelocityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChronoDataBindingSource
        '
        Me.ChronoDataBindingSource.DataMember = "ChronoData"
        Me.ChronoDataBindingSource.DataSource = Me.CartridgeDataSetBindingSource
        '
        'CartridgeDataSetBindingSource
        '
        Me.CartridgeDataSetBindingSource.DataSource = Me.CartridgeDataSet
        Me.CartridgeDataSetBindingSource.Position = 0
        '
        'CartridgeDataSet
        '
        Me.CartridgeDataSet.DataSetName = "CartridgeDataSet"
        Me.CartridgeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CartridgeBindingSource
        '
        Me.CartridgeBindingSource.DataMember = "Cartridge"
        Me.CartridgeBindingSource.DataSource = Me.CartridgeDataSetBindingSource
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(422, 301)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(105, 25)
        Me.btnReturn.TabIndex = 52
        Me.btnReturn.Text = "Return To Main"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'CartridgeTableAdapter
        '
        Me.CartridgeTableAdapter.ClearBeforeFill = True
        '
        'ChronoDataTableAdapter
        '
        Me.ChronoDataTableAdapter.ClearBeforeFill = True
        '
        'ChronoData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 385)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.dgvVelocity)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAvgVel)
        Me.Controls.Add(Me.txtStdDev)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCoal)
        Me.Controls.Add(Me.txtCal)
        Me.Controls.Add(Me.txtBullet)
        Me.Controls.Add(Me.txtBulWeight)
        Me.Controls.Add(Me.txtPowWeight)
        Me.Controls.Add(Me.txtPowName)
        Me.Controls.Add(Me.txtLoadNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ChronoData"
        Me.Text = "ChronoData"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvVelocity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChronoDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartridgeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartridgeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartridgeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLoadNum As TextBox
    Friend WithEvents txtPowName As TextBox
    Friend WithEvents txtPowWeight As TextBox
    Friend WithEvents txtBulWeight As TextBox
    Friend WithEvents txtBullet As TextBox
    Friend WithEvents txtCal As TextBox
    Friend WithEvents txtCoal As TextBox
    Friend WithEvents txtInputVelocity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddVelocity As Button
    Friend WithEvents txtStdDev As TextBox
    Friend WithEvents txtAvgVel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvVelocity As DataGridView
    Friend WithEvents CartridgeDataSet As CartridgeDataSet
    Friend WithEvents Velocity1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CartridgeDataSetBindingSource As BindingSource
    Friend WithEvents CartridgeBindingSource As BindingSource
    Friend WithEvents CartridgeTableAdapter As CartridgeDataSetTableAdapters.CartridgeTableAdapter
    Friend WithEvents ChronoDataBindingSource As BindingSource
    Friend WithEvents ChronoDataTableAdapter As CartridgeDataSetTableAdapters.ChronoDataTableAdapter
    Friend WithEvents VelocityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dtpNewVelocity As DateTimePicker
    Friend WithEvents btnReturn As Button
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteSelectedVelocityToolStripMenuItem As ToolStripMenuItem
End Class
