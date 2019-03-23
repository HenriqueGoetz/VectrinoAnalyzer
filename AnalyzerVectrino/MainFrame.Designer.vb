<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrame
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
        Me.btnLoadVel = New System.Windows.Forms.Button()
        Me.btnLoadCor = New System.Windows.Forms.Button()
        Me.lblVel = New System.Windows.Forms.Label()
        Me.lblCor = New System.Windows.Forms.Label()
        Me.btnShowGraphic = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLoadVel
        '
        Me.btnLoadVel.Location = New System.Drawing.Point(39, 41)
        Me.btnLoadVel.Name = "btnLoadVel"
        Me.btnLoadVel.Size = New System.Drawing.Size(123, 42)
        Me.btnLoadVel.TabIndex = 0
        Me.btnLoadVel.Text = "Load .vel"
        Me.btnLoadVel.UseVisualStyleBackColor = True
        '
        'btnLoadCor
        '
        Me.btnLoadCor.Enabled = False
        Me.btnLoadCor.Location = New System.Drawing.Point(39, 105)
        Me.btnLoadCor.Name = "btnLoadCor"
        Me.btnLoadCor.Size = New System.Drawing.Size(123, 42)
        Me.btnLoadCor.TabIndex = 1
        Me.btnLoadCor.Text = "Load .cor"
        Me.btnLoadCor.UseVisualStyleBackColor = True
        '
        'lblVel
        '
        Me.lblVel.AutoSize = True
        Me.lblVel.Location = New System.Drawing.Point(180, 54)
        Me.lblVel.Name = "lblVel"
        Me.lblVel.Size = New System.Drawing.Size(93, 17)
        Me.lblVel.TabIndex = 3
        Me.lblVel.Text = "Need to load."
        '
        'lblCor
        '
        Me.lblCor.AutoSize = True
        Me.lblCor.Location = New System.Drawing.Point(180, 118)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(93, 17)
        Me.lblCor.TabIndex = 4
        Me.lblCor.Text = "Need to load."
        '
        'btnShowGraphic
        '
        Me.btnShowGraphic.Enabled = False
        Me.btnShowGraphic.Location = New System.Drawing.Point(331, 55)
        Me.btnShowGraphic.Name = "btnShowGraphic"
        Me.btnShowGraphic.Size = New System.Drawing.Size(200, 80)
        Me.btnShowGraphic.TabIndex = 2
        Me.btnShowGraphic.Text = "Show Graphic"
        Me.btnShowGraphic.UseVisualStyleBackColor = True
        '
        'MainFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 193)
        Me.Controls.Add(Me.btnShowGraphic)
        Me.Controls.Add(Me.lblCor)
        Me.Controls.Add(Me.lblVel)
        Me.Controls.Add(Me.btnLoadCor)
        Me.Controls.Add(Me.btnLoadVel)
        Me.Name = "MainFrame"
        Me.Text = "Vectrino Analyser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadVel As Button
    Friend WithEvents btnLoadCor As Button
    Friend WithEvents lblVel As Label
    Friend WithEvents lblCor As Label
    Friend WithEvents btnShowGraphic As Button
End Class
