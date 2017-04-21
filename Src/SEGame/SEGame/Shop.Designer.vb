<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shop
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.moneyBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.armourBox = New System.Windows.Forms.CheckBox()
        Me.lazerBox = New System.Windows.Forms.CheckBox()
        Me.godBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SHOP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Armour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lazer Beam"
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(12, 260)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(453, 23)
        Me.closeButton.TabIndex = 3
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Godmode"
        '
        'moneyBox
        '
        Me.moneyBox.Enabled = False
        Me.moneyBox.Location = New System.Drawing.Point(409, 12)
        Me.moneyBox.Name = "moneyBox"
        Me.moneyBox.Size = New System.Drawing.Size(56, 20)
        Me.moneyBox.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(343, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Money:"
        '
        'armourBox
        '
        Me.armourBox.AutoSize = True
        Me.armourBox.Enabled = False
        Me.armourBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.armourBox.Location = New System.Drawing.Point(190, 86)
        Me.armourBox.Name = "armourBox"
        Me.armourBox.Size = New System.Drawing.Size(127, 24)
        Me.armourBox.TabIndex = 20
        Me.armourBox.Text = "Enabled - $50"
        Me.armourBox.UseVisualStyleBackColor = True
        '
        'lazerBox
        '
        Me.lazerBox.AutoSize = True
        Me.lazerBox.Enabled = False
        Me.lazerBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lazerBox.Location = New System.Drawing.Point(190, 152)
        Me.lazerBox.Name = "lazerBox"
        Me.lazerBox.Size = New System.Drawing.Size(136, 24)
        Me.lazerBox.TabIndex = 21
        Me.lazerBox.Text = "Enabled - $100"
        Me.lazerBox.UseVisualStyleBackColor = True
        '
        'godBox
        '
        Me.godBox.AutoSize = True
        Me.godBox.Enabled = False
        Me.godBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.godBox.Location = New System.Drawing.Point(190, 217)
        Me.godBox.Name = "godBox"
        Me.godBox.Size = New System.Drawing.Size(136, 24)
        Me.godBox.TabIndex = 22
        Me.godBox.Text = "Enabled - $500"
        Me.godBox.UseVisualStyleBackColor = True
        '
        'Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 295)
        Me.Controls.Add(Me.godBox)
        Me.Controls.Add(Me.lazerBox)
        Me.Controls.Add(Me.armourBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.moneyBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Shop"
        Me.Text = "Shop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents moneyBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents armourBox As System.Windows.Forms.CheckBox
    Friend WithEvents lazerBox As System.Windows.Forms.CheckBox
    Friend WithEvents godBox As System.Windows.Forms.CheckBox
End Class
