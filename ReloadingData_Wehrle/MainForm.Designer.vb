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
        Me.btnAddComponent = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cboBulletWeight = New System.Windows.Forms.ComboBox()
        Me.btnAddLoad = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.cboPowders = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.radHandgun = New System.Windows.Forms.RadioButton()
        Me.radRifle = New System.Windows.Forms.RadioButton()
        Me.btnViewChrono = New System.Windows.Forms.Button()
        Me.cboLoadId = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.btnDeleteLoad = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        'btnAddComponent
        '
        Me.btnAddComponent.Location = New System.Drawing.Point(33, 269)
        Me.btnAddComponent.Name = "btnAddComponent"
        Me.btnAddComponent.Size = New System.Drawing.Size(100, 23)
        Me.btnAddComponent.TabIndex = 1
        Me.btnAddComponent.Text = "Add Components"
        Me.btnAddComponent.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 360)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(682, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'cboBulletWeight
        '
        Me.cboBulletWeight.FormattingEnabled = True
        Me.cboBulletWeight.Location = New System.Drawing.Point(12, 170)
        Me.cboBulletWeight.Name = "cboBulletWeight"
        Me.cboBulletWeight.Size = New System.Drawing.Size(121, 21)
        Me.cboBulletWeight.TabIndex = 3
        '
        'btnAddLoad
        '
        Me.btnAddLoad.Location = New System.Drawing.Point(33, 298)
        Me.btnAddLoad.Name = "btnAddLoad"
        Me.btnAddLoad.Size = New System.Drawing.Size(100, 23)
        Me.btnAddLoad.TabIndex = 4
        Me.btnAddLoad.Text = "Add Load"
        Me.btnAddLoad.UseVisualStyleBackColor = True
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
        Me.btnView.Location = New System.Drawing.Point(33, 240)
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
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(219, 54)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(441, 225)
        Me.ListBox1.TabIndex = 15
        '
        'radHandgun
        '
        Me.radHandgun.AutoSize = True
        Me.radHandgun.Location = New System.Drawing.Point(25, 54)
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
        Me.radRifle.Location = New System.Drawing.Point(25, 78)
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(682, 24)
        Me.MenuStrip1.TabIndex = 51
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 382)
        Me.Controls.Add(Me.btnDeleteLoad)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboLoadId)
        Me.Controls.Add(Me.btnViewChrono)
        Me.Controls.Add(Me.radRifle)
        Me.Controls.Add(Me.radHandgun)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboPowders)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddLoad)
        Me.Controls.Add(Me.cboBulletWeight)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnAddComponent)
        Me.Controls.Add(Me.cboDiameter)
        Me.Name = "MainForm"
        Me.Text = "Reloading Database"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboDiameter As ComboBox
    Friend WithEvents btnAddComponent As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents cboBulletWeight As ComboBox
    Friend WithEvents btnAddLoad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents cboPowders As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents radHandgun As RadioButton
    Friend WithEvents radRifle As RadioButton
    Friend WithEvents btnViewChrono As Button
    Friend WithEvents cboLoadId As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnExit As Button
    Friend WithEvents btnDeleteLoad As Button
End Class
