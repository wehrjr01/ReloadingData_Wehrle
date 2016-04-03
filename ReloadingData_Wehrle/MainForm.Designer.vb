<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.cboDiameter = New System.Windows.Forms.ComboBox()
        Me.cboBulletWeight = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.cboPowders = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radHandgun = New System.Windows.Forms.RadioButton()
        Me.radRifle = New System.Windows.Forms.RadioButton()
        Me.btnViewChrono = New System.Windows.Forms.Button()
        Me.cboLoadId = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuItmFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddComponentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItmAddComponents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItmAddLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.btnDeleteLoad = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboDiameter
        '
        Me.cboDiameter.FormattingEnabled = True
        Me.cboDiameter.Location = New System.Drawing.Point(12, 138)
        Me.cboDiameter.Name = "cboDiameter"
        Me.cboDiameter.Size = New System.Drawing.Size(121, 21)
        Me.cboDiameter.TabIndex = 0
        '
        'cboBulletWeight
        '
        Me.cboBulletWeight.FormattingEnabled = True
        Me.cboBulletWeight.Location = New System.Drawing.Point(12, 170)
        Me.cboBulletWeight.Name = "cboBulletWeight"
        Me.cboBulletWeight.Size = New System.Drawing.Size(121, 21)
        Me.cboBulletWeight.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bullet Diameter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Bullet Weight"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(26, 288)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(100, 23)
        Me.btnView.TabIndex = 7
        Me.btnView.Text = "View Loads"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'cboPowders
        '
        Me.cboPowders.FormattingEnabled = True
        Me.cboPowders.Location = New System.Drawing.Point(12, 207)
        Me.cboPowders.Name = "cboPowders"
        Me.cboPowders.Size = New System.Drawing.Size(121, 21)
        Me.cboPowders.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Powder Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 13
        '
        'radHandgun
        '
        Me.radHandgun.AutoSize = True
        Me.radHandgun.Checked = True
        Me.radHandgun.Location = New System.Drawing.Point(17, 19)
        Me.radHandgun.Name = "radHandgun"
        Me.radHandgun.Size = New System.Drawing.Size(101, 17)
        Me.radHandgun.TabIndex = 16
        Me.radHandgun.TabStop = True
        Me.radHandgun.Text = "Handgun Loads"
        Me.radHandgun.UseVisualStyleBackColor = True
        '
        'radRifle
        '
        Me.radRifle.AutoSize = True
        Me.radRifle.Location = New System.Drawing.Point(17, 42)
        Me.radRifle.Name = "radRifle"
        Me.radRifle.Size = New System.Drawing.Size(78, 17)
        Me.radRifle.TabIndex = 17
        Me.radRifle.TabStop = True
        Me.radRifle.Text = "Rifle Loads"
        Me.radRifle.UseVisualStyleBackColor = True
        '
        'btnViewChrono
        '
        Me.btnViewChrono.Location = New System.Drawing.Point(219, 288)
        Me.btnViewChrono.Name = "btnViewChrono"
        Me.btnViewChrono.Size = New System.Drawing.Size(102, 23)
        Me.btnViewChrono.TabIndex = 18
        Me.btnViewChrono.Text = "View Chrono Data"
        Me.btnViewChrono.UseVisualStyleBackColor = True
        '
        'cboLoadId
        '
        Me.cboLoadId.FormattingEnabled = True
        Me.cboLoadId.Location = New System.Drawing.Point(12, 108)
        Me.cboLoadId.Name = "cboLoadId"
        Me.cboLoadId.Size = New System.Drawing.Size(121, 21)
        Me.cboLoadId.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(135, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Load Number"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItmFile, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(682, 24)
        Me.MenuStrip1.TabIndex = 51
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuItmFile
        '
        Me.mnuItmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddComponentsToolStripMenuItem, Me.mnuItmExit})
        Me.mnuItmFile.Name = "mnuItmFile"
        Me.mnuItmFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuItmFile.Text = "File"
        '
        'AddComponentsToolStripMenuItem
        '
        Me.AddComponentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItmAddComponents, Me.mnuItmAddLoad})
        Me.AddComponentsToolStripMenuItem.Name = "AddComponentsToolStripMenuItem"
        Me.AddComponentsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddComponentsToolStripMenuItem.Text = "Add"
        '
        'mnuItmAddComponents
        '
        Me.mnuItmAddComponents.Name = "mnuItmAddComponents"
        Me.mnuItmAddComponents.Size = New System.Drawing.Size(143, 22)
        Me.mnuItmAddComponents.Text = "Components"
        '
        'mnuItmAddLoad
        '
        Me.mnuItmAddLoad.Name = "mnuItmAddLoad"
        Me.mnuItmAddLoad.Size = New System.Drawing.Size(143, 22)
        Me.mnuItmAddLoad.Text = "Load"
        '
        'mnuItmExit
        '
        Me.mnuItmExit.Name = "mnuItmExit"
        Me.mnuItmExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItmExit.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(559, 288)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(101, 23)
        Me.BtnExit.TabIndex = 52
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'btnDeleteLoad
        '
        Me.btnDeleteLoad.Location = New System.Drawing.Point(370, 288)
        Me.btnDeleteLoad.Name = "btnDeleteLoad"
        Me.btnDeleteLoad.Size = New System.Drawing.Size(129, 23)
        Me.btnDeleteLoad.TabIndex = 53
        Me.btnDeleteLoad.Text = "Delete Selected Load"
        Me.btnDeleteLoad.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(219, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(441, 254)
        Me.DataGridView1.TabIndex = 54
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radHandgun)
        Me.GroupBox1.Controls.Add(Me.radRifle)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(122, 68)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Load Type"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 382)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDeleteLoad)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboLoadId)
        Me.Controls.Add(Me.btnViewChrono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboPowders)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboBulletWeight)
        Me.Controls.Add(Me.cboDiameter)
        Me.Name = "MainForm"
        Me.Text = "Reloading Database"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboDiameter As ComboBox
    Friend WithEvents cboBulletWeight As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents cboPowders As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents radHandgun As RadioButton
    Friend WithEvents radRifle As RadioButton
    Friend WithEvents btnViewChrono As Button
    Friend WithEvents cboLoadId As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuItmFile As ToolStripMenuItem
    Friend WithEvents mnuItmExit As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnExit As Button
    Friend WithEvents btnDeleteLoad As Button
    Friend WithEvents AddComponentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuItmAddComponents As ToolStripMenuItem
    Friend WithEvents mnuItmAddLoad As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
End Class
