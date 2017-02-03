<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.nickBox = New System.Windows.Forms.TextBox()
        Me.nickLbl = New System.Windows.Forms.Label()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.ScoreDBDataSet = New SEGame.ScoreDBDataSet()
        Me.ScoreboardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScoreboardTableAdapter = New SEGame.ScoreDBDataSetTableAdapters.scoreboardTableAdapter()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        CType(Me.ScoreDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreboardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Highscores"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.ScoreboardBindingSource
        Me.ListBox1.DisplayMember = "nick"
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Location = New System.Drawing.Point(13, 62)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(148, 252)
        Me.ListBox1.TabIndex = 1
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(13, 411)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(269, 30)
        Me.closeBtn.TabIndex = 2
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'nickBox
        '
        Me.nickBox.Location = New System.Drawing.Point(76, 345)
        Me.nickBox.Name = "nickBox"
        Me.nickBox.Size = New System.Drawing.Size(206, 20)
        Me.nickBox.TabIndex = 3
        '
        'nickLbl
        '
        Me.nickLbl.AutoSize = True
        Me.nickLbl.Location = New System.Drawing.Point(12, 348)
        Me.nickLbl.Name = "nickLbl"
        Me.nickLbl.Size = New System.Drawing.Size(58, 13)
        Me.nickLbl.TabIndex = 4
        Me.nickLbl.Text = "Nickname:"
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(12, 375)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(269, 30)
        Me.saveBtn.TabIndex = 5
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'ScoreDBDataSet
        '
        Me.ScoreDBDataSet.DataSetName = "ScoreDBDataSet"
        Me.ScoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScoreboardBindingSource
        '
        Me.ScoreboardBindingSource.DataMember = "scoreboard"
        Me.ScoreboardBindingSource.DataSource = Me.ScoreDBDataSet
        '
        'ScoreboardTableAdapter
        '
        Me.ScoreboardTableAdapter.ClearBeforeFill = True
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.ScoreboardBindingSource
        Me.ListBox2.DisplayMember = "score"
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 31
        Me.ListBox2.Location = New System.Drawing.Point(167, 62)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(114, 252)
        Me.ListBox2.TabIndex = 6
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 453)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.nickLbl)
        Me.Controls.Add(Me.nickBox)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(310, 492)
        Me.MinimumSize = New System.Drawing.Size(310, 492)
        Me.Name = "Score"
        Me.Text = "Score"
        CType(Me.ScoreDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreboardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents nickBox As System.Windows.Forms.TextBox
    Friend WithEvents nickLbl As System.Windows.Forms.Label
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents ScoreDBDataSet As SEGame.ScoreDBDataSet
    Friend WithEvents ScoreboardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ScoreboardTableAdapter As SEGame.ScoreDBDataSetTableAdapters.scoreboardTableAdapter
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
End Class
