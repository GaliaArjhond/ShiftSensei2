<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteAccount
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbNurseName = New System.Windows.Forms.ComboBox()
        Me.rtbReason = New System.Windows.Forms.RichTextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(-8, -5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 127)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(200, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 34)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Delete Account"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 170)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nurse Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 253)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Reason for Deletion: "
        '
        'cmbNurseName
        '
        Me.cmbNurseName.FormattingEnabled = True
        Me.cmbNurseName.Location = New System.Drawing.Point(261, 167)
        Me.cmbNurseName.Name = "cmbNurseName"
        Me.cmbNurseName.Size = New System.Drawing.Size(296, 27)
        Me.cmbNurseName.TabIndex = 5
        '
        'rtbReason
        '
        Me.rtbReason.Location = New System.Drawing.Point(261, 253)
        Me.rtbReason.Name = "rtbReason"
        Me.rtbReason.Size = New System.Drawing.Size(296, 192)
        Me.rtbReason.TabIndex = 7
        Me.rtbReason.Text = ""
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(60, 477)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(178, 34)
        Me.btndelete.TabIndex = 9
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(379, 477)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 34)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DeleteAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 545)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.rtbReason)
        Me.Controls.Add(Me.cmbNurseName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "DeleteAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteAccount"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbNurseName As ComboBox
    Friend WithEvents rtbReason As RichTextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents Button2 As Button
End Class
