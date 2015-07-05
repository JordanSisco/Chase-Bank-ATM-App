<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFastCash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFastCash))
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn40 = New System.Windows.Forms.Button()
        Me.btn60 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn20
        '
        Me.btn20.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn20.Location = New System.Drawing.Point(13, 109)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(133, 58)
        Me.btn20.TabIndex = 2
        Me.btn20.Text = "$20"
        Me.ToolTip1.SetToolTip(Me.btn20, "Click here to withdraw $20 from your account.")
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn40
        '
        Me.btn40.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn40.Location = New System.Drawing.Point(170, 109)
        Me.btn40.Name = "btn40"
        Me.btn40.Size = New System.Drawing.Size(133, 58)
        Me.btn40.TabIndex = 3
        Me.btn40.Text = "$40"
        Me.ToolTip1.SetToolTip(Me.btn40, "Click here to withdraw $40 from your account")
        Me.btn40.UseVisualStyleBackColor = True
        '
        'btn60
        '
        Me.btn60.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn60.Location = New System.Drawing.Point(331, 109)
        Me.btn60.Name = "btn60"
        Me.btn60.Size = New System.Drawing.Size(133, 58)
        Me.btn60.TabIndex = 4
        Me.btn60.Text = "$60"
        Me.ToolTip1.SetToolTip(Me.btn60, "Click here to withdraw $60 from your account")
        Me.btn60.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(135, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 45)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Do you have a question? Go to www.chase.com/support ")
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(170, 192)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(133, 58)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Go Back"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Click here to go back to the Main Menu")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "How much would you like to withdraw?"
        '
        'frmFastCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(475, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn60)
        Me.Controls.Add(Me.btn40)
        Me.Controls.Add(Me.btn20)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmFastCash"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chase Bank-Fast Cash"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btn20 As System.Windows.Forms.Button
    Private WithEvents btn40 As System.Windows.Forms.Button
    Private WithEvents btn60 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
