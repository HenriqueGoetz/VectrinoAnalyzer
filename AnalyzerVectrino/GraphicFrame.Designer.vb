<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphicFrame
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
        Dim ChartArea13 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend13 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea14 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend14 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea15 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend15 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series15 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxCor = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea13.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea13)
        Legend13.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend13)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series13.ChartArea = "ChartArea1"
        Series13.Legend = "Legend1"
        Series13.Name = "Series1"
        Me.Chart1.Series.Add(Series13)
        Me.Chart1.Size = New System.Drawing.Size(900, 450)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        ChartArea14.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea14)
        Legend14.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend14)
        Me.Chart2.Location = New System.Drawing.Point(937, 12)
        Me.Chart2.Name = "Chart2"
        Series14.ChartArea = "ChartArea1"
        Series14.Legend = "Legend1"
        Series14.Name = "Series1"
        Me.Chart2.Series.Add(Series14)
        Me.Chart2.Size = New System.Drawing.Size(900, 450)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "Chart2"
        '
        'Chart3
        '
        ChartArea15.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea15)
        Legend15.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend15)
        Me.Chart3.Location = New System.Drawing.Point(12, 474)
        Me.Chart3.Name = "Chart3"
        Series15.ChartArea = "ChartArea1"
        Series15.Legend = "Legend1"
        Series15.Name = "Series1"
        Me.Chart3.Series.Add(Series15)
        Me.Chart3.Size = New System.Drawing.Size(900, 450)
        Me.Chart3.TabIndex = 2
        Me.Chart3.Text = "Chart3"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.txtBoxCor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(937, 474)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 450)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correlation to filter: "
        '
        'txtBoxCor
        '
        Me.txtBoxCor.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCor.Location = New System.Drawing.Point(488, 33)
        Me.txtBoxCor.Name = "txtBoxCor"
        Me.txtBoxCor.Size = New System.Drawing.Size(165, 75)
        Me.txtBoxCor.TabIndex = 0
        Me.txtBoxCor.Text = "80"
        Me.txtBoxCor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(664, 33)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(211, 75)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(28, 145)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(847, 277)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GraphicFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "GraphicFrame"
        Me.Text = "Graphics"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtBoxCor As TextBox
    Friend WithEvents Label1 As Label
End Class
