<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dropType = New System.Windows.Forms.ComboBox()
        Me.txtRestore = New System.Windows.Forms.TextBox()
        Me.lblRestore = New System.Windows.Forms.Label()
        Me.txtHealing = New System.Windows.Forms.TextBox()
        Me.lblHealing = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtCrit = New System.Windows.Forms.TextBox()
        Me.lblCrit = New System.Windows.Forms.Label()
        Me.txtHit = New System.Windows.Forms.TextBox()
        Me.lblHit = New System.Windows.Forms.Label()
        Me.txtMight = New System.Windows.Forms.TextBox()
        Me.lblMight = New System.Windows.Forms.Label()
        Me.txtRange = New System.Windows.Forms.TextBox()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.txtWeaponType = New System.Windows.Forms.TextBox()
        Me.lblWeaponType = New System.Windows.Forms.Label()
        Me.txtDurability = New System.Windows.Forms.TextBox()
        Me.lblDurability = New System.Windows.Forms.Label()
        Me.lblImage = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.dropItem = New System.Windows.Forms.ComboBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.btnNewItem = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.grpStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(32, 409)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open File"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(175, 409)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(320, 409)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpStats
        '
        Me.grpStats.Controls.Add(Me.Panel1)
        Me.grpStats.Controls.Add(Me.dropType)
        Me.grpStats.Controls.Add(Me.txtRestore)
        Me.grpStats.Controls.Add(Me.lblRestore)
        Me.grpStats.Controls.Add(Me.txtHealing)
        Me.grpStats.Controls.Add(Me.lblHealing)
        Me.grpStats.Controls.Add(Me.txtWeight)
        Me.grpStats.Controls.Add(Me.lblWeight)
        Me.grpStats.Controls.Add(Me.txtCrit)
        Me.grpStats.Controls.Add(Me.lblCrit)
        Me.grpStats.Controls.Add(Me.txtHit)
        Me.grpStats.Controls.Add(Me.lblHit)
        Me.grpStats.Controls.Add(Me.txtMight)
        Me.grpStats.Controls.Add(Me.lblMight)
        Me.grpStats.Controls.Add(Me.txtRange)
        Me.grpStats.Controls.Add(Me.lblRange)
        Me.grpStats.Controls.Add(Me.txtWeaponType)
        Me.grpStats.Controls.Add(Me.lblWeaponType)
        Me.grpStats.Controls.Add(Me.txtDurability)
        Me.grpStats.Controls.Add(Me.lblDurability)
        Me.grpStats.Controls.Add(Me.lblImage)
        Me.grpStats.Controls.Add(Me.txtName)
        Me.grpStats.Controls.Add(Me.lblName)
        Me.grpStats.Controls.Add(Me.lblType)
        Me.grpStats.Location = New System.Drawing.Point(32, 77)
        Me.grpStats.Name = "grpStats"
        Me.grpStats.Size = New System.Drawing.Size(363, 326)
        Me.grpStats.TabIndex = 3
        Me.grpStats.TabStop = False
        Me.grpStats.Text = "Item Stats"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(81, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(84, 78)
        Me.Panel1.TabIndex = 25
        '
        'dropType
        '
        Me.dropType.FormattingEnabled = True
        Me.dropType.Location = New System.Drawing.Point(78, 24)
        Me.dropType.Name = "dropType"
        Me.dropType.Size = New System.Drawing.Size(87, 21)
        Me.dropType.TabIndex = 24
        '
        'txtRestore
        '
        Me.txtRestore.Location = New System.Drawing.Point(249, 300)
        Me.txtRestore.Name = "txtRestore"
        Me.txtRestore.Size = New System.Drawing.Size(88, 20)
        Me.txtRestore.TabIndex = 23
        '
        'lblRestore
        '
        Me.lblRestore.AutoSize = True
        Me.lblRestore.Location = New System.Drawing.Point(114, 303)
        Me.lblRestore.Name = "lblRestore"
        Me.lblRestore.Size = New System.Drawing.Size(127, 13)
        Me.lblRestore.TabIndex = 22
        Me.lblRestore.Text = "HP restore (Consumable):"
        '
        'txtHealing
        '
        Me.txtHealing.Location = New System.Drawing.Point(249, 267)
        Me.txtHealing.Name = "txtHealing"
        Me.txtHealing.Size = New System.Drawing.Size(88, 20)
        Me.txtHealing.TabIndex = 21
        '
        'lblHealing
        '
        Me.lblHealing.AutoSize = True
        Me.lblHealing.Location = New System.Drawing.Point(128, 270)
        Me.lblHealing.Name = "lblHealing"
        Me.lblHealing.Size = New System.Drawing.Size(113, 13)
        Me.lblHealing.TabIndex = 20
        Me.lblHealing.Text = "Base healing (Staves):"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(249, 235)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(88, 20)
        Me.txtWeight.TabIndex = 19
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(199, 238)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(44, 13)
        Me.lblWeight.TabIndex = 18
        Me.lblWeight.Text = "Weight:"
        '
        'txtCrit
        '
        Me.txtCrit.Location = New System.Drawing.Point(249, 202)
        Me.txtCrit.Name = "txtCrit"
        Me.txtCrit.Size = New System.Drawing.Size(88, 20)
        Me.txtCrit.TabIndex = 17
        '
        'lblCrit
        '
        Me.lblCrit.AutoSize = True
        Me.lblCrit.Location = New System.Drawing.Point(218, 205)
        Me.lblCrit.Name = "lblCrit"
        Me.lblCrit.Size = New System.Drawing.Size(25, 13)
        Me.lblCrit.TabIndex = 16
        Me.lblCrit.Text = "Crit:"
        '
        'txtHit
        '
        Me.txtHit.Location = New System.Drawing.Point(249, 169)
        Me.txtHit.Name = "txtHit"
        Me.txtHit.Size = New System.Drawing.Size(88, 20)
        Me.txtHit.TabIndex = 15
        '
        'lblHit
        '
        Me.lblHit.AutoSize = True
        Me.lblHit.Location = New System.Drawing.Point(218, 172)
        Me.lblHit.Name = "lblHit"
        Me.lblHit.Size = New System.Drawing.Size(23, 13)
        Me.lblHit.TabIndex = 14
        Me.lblHit.Text = "Hit:"
        '
        'txtMight
        '
        Me.txtMight.Location = New System.Drawing.Point(249, 135)
        Me.txtMight.Name = "txtMight"
        Me.txtMight.Size = New System.Drawing.Size(88, 20)
        Me.txtMight.TabIndex = 13
        '
        'lblMight
        '
        Me.lblMight.AutoSize = True
        Me.lblMight.Location = New System.Drawing.Point(207, 138)
        Me.lblMight.Name = "lblMight"
        Me.lblMight.Size = New System.Drawing.Size(36, 13)
        Me.lblMight.TabIndex = 12
        Me.lblMight.Text = "Might:"
        '
        'txtRange
        '
        Me.txtRange.Location = New System.Drawing.Point(249, 99)
        Me.txtRange.Name = "txtRange"
        Me.txtRange.Size = New System.Drawing.Size(88, 20)
        Me.txtRange.TabIndex = 11
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(201, 102)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(42, 13)
        Me.lblRange.TabIndex = 10
        Me.lblRange.Text = "Range:"
        '
        'txtWeaponType
        '
        Me.txtWeaponType.Location = New System.Drawing.Point(249, 63)
        Me.txtWeaponType.Name = "txtWeaponType"
        Me.txtWeaponType.Size = New System.Drawing.Size(88, 20)
        Me.txtWeaponType.TabIndex = 9
        '
        'lblWeaponType
        '
        Me.lblWeaponType.AutoSize = True
        Me.lblWeaponType.Location = New System.Drawing.Point(190, 66)
        Me.lblWeaponType.Name = "lblWeaponType"
        Me.lblWeaponType.Size = New System.Drawing.Size(53, 13)
        Me.lblWeaponType.TabIndex = 8
        Me.lblWeaponType.Text = "Item type:"
        '
        'txtDurability
        '
        Me.txtDurability.Location = New System.Drawing.Point(249, 26)
        Me.txtDurability.Name = "txtDurability"
        Me.txtDurability.Size = New System.Drawing.Size(88, 20)
        Me.txtDurability.TabIndex = 7
        '
        'lblDurability
        '
        Me.lblDurability.AutoSize = True
        Me.lblDurability.Location = New System.Drawing.Point(190, 29)
        Me.lblDurability.Name = "lblDurability"
        Me.lblDurability.Size = New System.Drawing.Size(53, 13)
        Me.lblDurability.TabIndex = 6
        Me.lblDurability.Text = "Durability:"
        '
        'lblImage
        '
        Me.lblImage.AutoSize = True
        Me.lblImage.Location = New System.Drawing.Point(14, 116)
        Me.lblImage.Name = "lblImage"
        Me.lblImage.Size = New System.Drawing.Size(61, 13)
        Me.lblImage.TabIndex = 5
        Me.lblImage.Text = "Item image:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(77, 63)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(88, 20)
        Me.txtName.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(16, 66)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Item name:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(1, 27)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(74, 13)
        Me.lblType.TabIndex = 1
        Me.lblType.Text = "Item category:"
        '
        'dropItem
        '
        Me.dropItem.FormattingEnabled = True
        Me.dropItem.Location = New System.Drawing.Point(87, 39)
        Me.dropItem.Name = "dropItem"
        Me.dropItem.Size = New System.Drawing.Size(121, 21)
        Me.dropItem.TabIndex = 4
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(51, 42)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(30, 13)
        Me.lblItem.TabIndex = 5
        Me.lblItem.Text = "Item:"
        '
        'btnNewItem
        '
        Me.btnNewItem.Location = New System.Drawing.Point(214, 37)
        Me.btnNewItem.Name = "btnNewItem"
        Me.btnNewItem.Size = New System.Drawing.Size(75, 23)
        Me.btnNewItem.TabIndex = 6
        Me.btnNewItem.Text = "New Item"
        Me.btnNewItem.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(294, 37)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 449)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNewItem)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.dropItem)
        Me.Controls.Add(Me.grpStats)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "Form1"
        Me.Text = "Item Editor"
        Me.grpStats.ResumeLayout(False)
        Me.grpStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpen As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpStats As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblType As Label
    Friend WithEvents txtRestore As TextBox
    Friend WithEvents lblRestore As Label
    Friend WithEvents txtHealing As TextBox
    Friend WithEvents lblHealing As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtCrit As TextBox
    Friend WithEvents lblCrit As Label
    Friend WithEvents txtHit As TextBox
    Friend WithEvents lblHit As Label
    Friend WithEvents txtMight As TextBox
    Friend WithEvents lblMight As Label
    Friend WithEvents txtRange As TextBox
    Friend WithEvents lblRange As Label
    Friend WithEvents txtWeaponType As TextBox
    Friend WithEvents lblWeaponType As Label
    Friend WithEvents txtDurability As TextBox
    Friend WithEvents lblDurability As Label
    Friend WithEvents lblImage As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents dropItem As ComboBox
    Friend WithEvents lblItem As Label
    Friend WithEvents dropType As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNewItem As Button
    Friend WithEvents btnDelete As Button
End Class
