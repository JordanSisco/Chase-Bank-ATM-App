<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFastCash = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.groupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.groupBox1.Controls.Add(Me.btnFastCash)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.btnLogOut)
        Me.groupBox1.Controls.Add(Me.btnDeposit)
        Me.groupBox1.Controls.Add(Me.btnWithdraw)
        Me.groupBox1.Controls.Add(Me.btnBalance)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(22, 92)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(342, 240)
        Me.groupBox1.TabIndex = 20
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "What would you like to do?"
        '
        'btnFastCash
        '
        Me.btnFastCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFastCash.Location = New System.Drawing.Point(185, 20)
        Me.btnFastCash.Name = "btnFastCash"
        Me.btnFastCash.Size = New System.Drawing.Size(133, 58)
        Me.btnFastCash.TabIndex = 1
        Me.btnFastCash.Text = "Fast Cash"
        Me.ToolTip1.SetToolTip(Me.btnFastCash, "In a hurry? Click here to withdraw money.")
        Me.btnFastCash.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(167, -16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Date & Time:"
        '
        'btnLogOut
        '
        Me.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(103, 166)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(133, 58)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Log Out"
        Me.ToolTip1.SetToolTip(Me.btnLogOut, "Press this to log out and go back to the Login page. ")
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.Location = New System.Drawing.Point(26, 102)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(133, 58)
        Me.btnDeposit.TabIndex = 2
        Me.btnDeposit.Text = "Deposit"
        Me.ToolTip1.SetToolTip(Me.btnDeposit, "Press this button to deposit money into your account")
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.Location = New System.Drawing.Point(185, 102)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(133, 58)
        Me.btnWithdraw.TabIndex = 3
        Me.btnWithdraw.Text = "Withdraw"
        Me.ToolTip1.SetToolTip(Me.btnWithdraw, "Press this button to withdraw money from your account.")
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnBalance
        '
        Me.btnBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalance.Location = New System.Drawing.Point(26, 20)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(133, 58)
        Me.btnBalance.TabIndex = 0
        Me.btnBalance.Text = "Balance Inquiry"
        Me.ToolTip1.SetToolTip(Me.btnBalance, "Press this button to look at your Account Balance")
        Me.btnBalance.UseVisualStyleBackColor = True
        '
        'lblHello
        '
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHello.Location = New System.Drawing.Point(18, 73)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(45, 16)
        Me.lblHello.TabIndex = 21
        Me.lblHello.Text = "Hello"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblName.Location = New System.Drawing.Point(63, 73)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 16)
        Me.lblName.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(93, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 50)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Do you have a question? Go to www.chase.com/support ")
        '
        'lblTest
        '
        Me.lblTest.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblTest.AutoSize = True
        Me.lblTest.CausesValidation = False
        Me.lblTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTest.Location = New System.Drawing.Point(63, 73)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(0, 16)
        Me.lblTest.TabIndex = 24
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnLogOut
        Me.ClientSize = New System.Drawing.Size(383, 351)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmMainMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chase Bank-Main Menu"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnFastCash As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnLogOut As System.Windows.Forms.Button
    Private WithEvents btnDeposit As System.Windows.Forms.Button
    Private WithEvents btnWithdraw As System.Windows.Forms.Button
    Private WithEvents btnBalance As System.Windows.Forms.Button
    Private WithEvents lblHello As System.Windows.Forms.Label
    Private WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents lblTest As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
