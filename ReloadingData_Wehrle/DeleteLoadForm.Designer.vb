<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteLoadForm
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
        Me.dgvLoads = New System.Windows.Forms.DataGridView()
        Me.CartridgeDataSet = New ReloadingData_Wehrle.CartridgeDataSet()
        Me.LoadsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadsTableAdapter = New ReloadingData_Wehrle.CartridgeDataSetTableAdapters.LoadsTableAdapter()
        Me.LoadIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BulletIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PowderNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PowderWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartridgeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLoads
        '
        Me.dgvLoads.AllowUserToAddRows = False
        Me.dgvLoads.AllowUserToDeleteRows = False
        Me.dgvLoads.AutoGenerateColumns = False
        Me.dgvLoads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoads.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoadIdDataGridViewTextBoxColumn, Me.CartNameDataGridViewTextBoxColumn, Me.BulletIdDataGridViewTextBoxColumn, Me.PrimerDataGridViewTextBoxColumn, Me.PowderNameDataGridViewTextBoxColumn, Me.PowderWeightDataGridViewTextBoxColumn, Me.OALDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn})
        Me.dgvLoads.DataSource = Me.LoadsBindingSource
        Me.dgvLoads.Location = New System.Drawing.Point(12, 62)
        Me.dgvLoads.Name = "dgvLoads"
        Me.dgvLoads.ReadOnly = True
        Me.dgvLoads.Size = New System.Drawing.Size(842, 280)
        Me.dgvLoads.TabIndex = 0
        '
        'CartridgeDataSet
        '
        Me.CartridgeDataSet.DataSetName = "CartridgeDataSet"
        Me.CartridgeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoadsBindingSource
        '
        Me.LoadsBindingSource.DataMember = "Loads"
        Me.LoadsBindingSource.DataSource = Me.CartridgeDataSet
        '
        'LoadsTableAdapter
        '
        Me.LoadsTableAdapter.ClearBeforeFill = True
        '
        'LoadIdDataGridViewTextBoxColumn
        '
        Me.LoadIdDataGridViewTextBoxColumn.DataPropertyName = "LoadId"
        Me.LoadIdDataGridViewTextBoxColumn.HeaderText = "LoadId"
        Me.LoadIdDataGridViewTextBoxColumn.Name = "LoadIdDataGridViewTextBoxColumn"
        Me.LoadIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CartNameDataGridViewTextBoxColumn
        '
        Me.CartNameDataGridViewTextBoxColumn.DataPropertyName = "CartName"
        Me.CartNameDataGridViewTextBoxColumn.HeaderText = "CartName"
        Me.CartNameDataGridViewTextBoxColumn.Name = "CartNameDataGridViewTextBoxColumn"
        Me.CartNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BulletIdDataGridViewTextBoxColumn
        '
        Me.BulletIdDataGridViewTextBoxColumn.DataPropertyName = "BulletId"
        Me.BulletIdDataGridViewTextBoxColumn.HeaderText = "BulletId"
        Me.BulletIdDataGridViewTextBoxColumn.Name = "BulletIdDataGridViewTextBoxColumn"
        Me.BulletIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimerDataGridViewTextBoxColumn
        '
        Me.PrimerDataGridViewTextBoxColumn.DataPropertyName = "Primer"
        Me.PrimerDataGridViewTextBoxColumn.HeaderText = "Primer"
        Me.PrimerDataGridViewTextBoxColumn.Name = "PrimerDataGridViewTextBoxColumn"
        Me.PrimerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PowderNameDataGridViewTextBoxColumn
        '
        Me.PowderNameDataGridViewTextBoxColumn.DataPropertyName = "PowderName"
        Me.PowderNameDataGridViewTextBoxColumn.HeaderText = "PowderName"
        Me.PowderNameDataGridViewTextBoxColumn.Name = "PowderNameDataGridViewTextBoxColumn"
        Me.PowderNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PowderWeightDataGridViewTextBoxColumn
        '
        Me.PowderWeightDataGridViewTextBoxColumn.DataPropertyName = "Powder Weight"
        Me.PowderWeightDataGridViewTextBoxColumn.HeaderText = "Powder Weight"
        Me.PowderWeightDataGridViewTextBoxColumn.Name = "PowderWeightDataGridViewTextBoxColumn"
        Me.PowderWeightDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OALDataGridViewTextBoxColumn
        '
        Me.OALDataGridViewTextBoxColumn.DataPropertyName = "OAL"
        Me.OALDataGridViewTextBoxColumn.HeaderText = "OAL"
        Me.OALDataGridViewTextBoxColumn.Name = "OALDataGridViewTextBoxColumn"
        Me.OALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(360, 21)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete Load"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DeleteLoadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 354)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgvLoads)
        Me.Name = "DeleteLoadForm"
        Me.Text = "DeleteLoadForm"
        CType(Me.dgvLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartridgeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLoads As DataGridView
    Friend WithEvents CartridgeDataSet As CartridgeDataSet
    Friend WithEvents LoadsBindingSource As BindingSource
    Friend WithEvents LoadsTableAdapter As CartridgeDataSetTableAdapters.LoadsTableAdapter
    Friend WithEvents LoadIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CartNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BulletIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PowderNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PowderWeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
End Class
