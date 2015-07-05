<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PIN))
        Me.btnPINEnter = New System.Windows.Forms.Button()
        Me.btnPINExit = New System.Windows.Forms.Button()
        Me.txtPINEnter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPINEnter
        '
        Me.btnPINEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPINEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPINEnter.Location = New System.Drawing.Point(69, 121)
        Me.btnPINEnter.Name = "btnPINEnter"
        Me.btnPINEnter.Size = New System.Drawing.Size(102, 44)
        Me.btnPINEnter.TabIndex = 0
        Me.btnPINEnter.Text = "Enter"
        Me.ToolTip1.SetToolTip(Me.btnPINEnter, "Press this button if your PIN is in the appropriate textbox to proceed.")
        Me.btnPINEnter.UseVisualStyleBackColor = True
        '
        'btnPINExit
        '
        Me.btnPINExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPINExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPINExit.Location = New System.Drawing.Point(180, 121)
        Me.btnPINExit.Name = "btnPINExit"
        Me.btnPINExit.Size = New System.Drawing.Size(102, 44)
        Me.btnPINExit.TabIndex = 1
        Me.btnPINExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.btnPINExit, "Press this to go back to the Login page.")
        Me.btnPINExit.UseVisualStyleBackColor = True
        '
        'txtPINEnter
        '
        Me.txtPINEnter.Location = New System.Drawing.Point(69, 81)
        Me.txtPINEnter.Name = "txtPINEnter"
        Me.txtPINEnter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPINEnter.Size = New System.Drawing.Size(67, 20)
        Me.txtPINEnter.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtPINEnter, "Enter your PIN in this textbox.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PIN:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(69, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 44)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Do you have a question? Go to www.chase.com/support ")
        '
        'PIN
        '
        Me.AcceptButton = Me.btnPINEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnPINExit
        Me.ClientSize = New System.Drawing.Size(313, 180)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPINEnter)
        Me.Controls.Add(Me.btnPINExit)
        Me.Controls.Add(Me.btnPINEnter)
        Me.Name = "PIN"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chase Bank-PIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPINEnter As System.Windows.Forms.Button
    Friend WithEvents btnPINExit As System.Windows.Forms.Button
    Friend WithEvents txtPINEnter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
