Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Options
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
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
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.speedNew = New System.Windows.Forms.NumericUpDown()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.debugEnable = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.enemySpeedNew = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.reloadNew = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.spawnRateNew = New System.Windows.Forms.NumericUpDown()
        CType(Me.speedNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemySpeedNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reloadNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spawnRateNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Options"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Speed"
        '
        'speedNew
        '
        Me.speedNew.Location = New System.Drawing.Point(103, 77)
        Me.speedNew.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.speedNew.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.speedNew.Name = "speedNew"
        Me.speedNew.Size = New System.Drawing.Size(120, 20)
        Me.speedNew.TabIndex = 5
        Me.speedNew.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(12, 373)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(275, 49)
        Me.saveBtn.TabIndex = 6
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Debug mode"
        '
        'debugEnable
        '
        Me.debugEnable.AutoSize = True
        Me.debugEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debugEnable.Location = New System.Drawing.Point(103, 109)
        Me.debugEnable.Name = "debugEnable"
        Me.debugEnable.Size = New System.Drawing.Size(67, 17)
        Me.debugEnable.TabIndex = 8
        Me.debugEnable.Text = "Disabled"
        Me.debugEnable.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enemy Speed"
        '
        'enemySpeedNew
        '
        Me.enemySpeedNew.Location = New System.Drawing.Point(103, 141)
        Me.enemySpeedNew.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.enemySpeedNew.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.enemySpeedNew.Name = "enemySpeedNew"
        Me.enemySpeedNew.Size = New System.Drawing.Size(120, 20)
        Me.enemySpeedNew.TabIndex = 10
        Me.enemySpeedNew.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Reload Speed"
        '
        'reloadNew
        '
        Me.reloadNew.Enabled = False
        Me.reloadNew.Location = New System.Drawing.Point(103, 174)
        Me.reloadNew.Name = "reloadNew"
        Me.reloadNew.Size = New System.Drawing.Size(120, 20)
        Me.reloadNew.TabIndex = 12
        Me.reloadNew.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Spawn Rate"
        '
        'spawnRateNew
        '
        Me.spawnRateNew.Enabled = False
        Me.spawnRateNew.Location = New System.Drawing.Point(103, 207)
        Me.spawnRateNew.Name = "spawnRateNew"
        Me.spawnRateNew.Size = New System.Drawing.Size(120, 20)
        Me.spawnRateNew.TabIndex = 14
        Me.spawnRateNew.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Options
        '
        Me.ClientSize = New System.Drawing.Size(299, 436)
        Me.Controls.Add(Me.spawnRateNew)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.reloadNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.enemySpeedNew)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.debugEnable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.speedNew)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Options"
        Me.Text = "Options"
        CType(Me.speedNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemySpeedNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reloadNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spawnRateNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents speedNew As NumericUpDown
    Friend WithEvents saveBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents debugEnable As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents enemySpeedNew As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents reloadNew As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents spawnRateNew As NumericUpDown
End Class
