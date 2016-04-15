<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddComponents
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
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.cboComponentType = New System.Windows.Forms.ComboBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.radRifle = New System.Windows.Forms.RadioButton()
        Me.dgvComponents = New System.Windows.Forms.DataGridView()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CartridgeDataSet = New ReloadingData_Wehrle.CartridgeDataSet()
        Me.CartridgeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BulletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BulletTableAdapter = New ReloadingData_Wehrle.CartridgeDataSetTableAdapters.BulletTableAdapter()
        Me.CartridgeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CartridgeTableAdapter = New ReloadingData_Wehrle.CartridgeDataSetTableAdapters.CartridgeTableAdapter()
        Me.PowderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PowderTableAdapter = New ReloadingData_Wehrle.CartridgeDataSetTableAdapters.PowderTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.CartridgeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartridgeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartridgeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(668, 199)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(39, 13)
        Me.lbl4.TabIndex = 81
        Me.lbl4.Text = "Label4"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(668, 163)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(39, 13)
        Me.lbl3.TabIndex = 80
        Me.lbl3.Text = "Label3"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(668, 128)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(39, 13)
        Me.lbl2.TabIndex = 79
        Me.lbl2.Text = "Label2"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(668, 92)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(39, 13)
        Me.lbl1.TabIndex = 78
        Me.lbl1.Text = "Label1"
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(753, 192)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(121, 20)
        Me.txt4.TabIndex = 5
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(753, 121)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(121, 20)
        Me.txt2.TabIndex = 3
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(753, 156)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(121, 20)
        Me.txt3.TabIndex = 4
        '
        'cboComponentType
        '
        Me.cboComponentType.FormattingEnabled = True
        Me.cboComponentType.Location = New System.Drawing.Point(145, 54)
        Me.cboComponentType.Name = "cboComponentType"
        Me.cboComponentType.Size = New System.Drawing.Size(121, 21)
        Me.cboComponentType.TabIndex = 44
        Me.cboComponentType.TabStop = False
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(753, 86)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(121, 20)
        Me.txt1.TabIndex = 2
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(753, 336)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(115, 23)
        Me.btnReturn.TabIndex = 8
        Me.btnReturn.Text = "Return To Home"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 69
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(753, 307)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add Selection"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'radRifle
        '
        Me.radRifle.AutoSize = True
        Me.radRifle.Location = New System.Drawing.Point(6, 19)
        Me.radRifle.Name = "radRifle"
        Me.radRifle.Size = New System.Drawing.Size(46, 17)
        Me.radRifle.TabIndex = 6
        Me.radRifle.TabStop = True
        Me.radRifle.Text = "Rifle"
        Me.radRifle.UseVisualStyleBackColor = True
        '
        'dgvComponents
        '
        Me.dgvComponents.AllowUserToAddRows = False
        Me.dgvComponents.AllowUserToDeleteRows = False
        Me.dgvComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComponents.Location = New System.Drawing.Point(12, 89)
        Me.dgvComponents.Name = "dgvComponents"
        Me.dgvComponents.ReadOnly = True
        Me.dgvComponents.RowHeadersVisible = False
        Me.dgvComponents.Size = New System.Drawing.Size(650, 211)
        Me.dgvComponents.TabIndex = 82
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 373)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(896, 22)
        Me.StatusStrip1.TabIndex = 83
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(668, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(753, 54)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 1
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton1.TabIndex = 85
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Handgun"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'CartridgeDataSet
        '
        Me.CartridgeDataSet.DataSetName = "CartridgeDataSet"
        Me.CartridgeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CartridgeDataSetBindingSource
        '
        Me.CartridgeDataSetBindingSource.DataSource = Me.CartridgeDataSet
        Me.CartridgeDataSetBindingSource.Position = 0
        '
        'BulletBindingSource
        '
        Me.BulletBindingSource.DataMember = "Bullet"
        Me.BulletBindingSource.DataSource = Me.CartridgeDataSet
        '
        'BulletTableAdapter
        '
        Me.BulletTableAdapter.ClearBeforeFill = True
        '
        'CartridgeBindingSource
        '
        Me.CartridgeBindingSource.DataMember = "Cartridge"
        Me.CartridgeBindingSource.DataSource = Me.CartridgeDataSet
        '
        'CartridgeTableAdapter
        '
        Me.CartridgeTableAdapter.ClearBeforeFill = True
        '
        'PowderBindingSource
        '
        Me.PowderBindingSource.DataMember = "Powder"
        Me.PowderBindingSource.DataSource = Me.CartridgeDataSet
        '
        'PowderTableAdapter
        '
        Me.PowderTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radRifle)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(753, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 63)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(668, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Load Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Choose Component Type"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(26, 320)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 89
        Me.btnDelete.Text = "Update Component"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'AddComponents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 395)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvComponents)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.cboComponentType)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "AddComponents"
        Me.Text = "AddComponents"
        CType(Me.dgvComponents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.CartridgeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartridgeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartridgeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents cboComponentType As ComboBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents radRifle As RadioButton
    Friend WithEvents dgvComponents As DataGridView
    Friend WithEvents errProvider As ErrorProvider
    Friend WithEvents CartridgeDataSetBindingSource As BindingSource
    Friend WithEvents CartridgeDataSet As CartridgeDataSet
    Friend WithEvents BulletBindingSource As BindingSource
    Friend WithEvents BulletTableAdapter As CartridgeDataSetTableAdapters.BulletTableAdapter
    Friend WithEvents CartridgeBindingSource As BindingSource
    Friend WithEvents CartridgeTableAdapter As CartridgeDataSetTableAdapters.CartridgeTableAdapter
    Friend WithEvents PowderBindingSource As BindingSource
    Friend WithEvents PowderTableAdapter As CartridgeDataSetTableAdapters.PowderTableAdapter
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDelete As Button
End Class
