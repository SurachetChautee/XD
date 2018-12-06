<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lab_1
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
        Me.d = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_tax = New System.Windows.Forms.Label()
        Me.lbl_total2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'd
        '
        Me.d.BackColor = System.Drawing.Color.Salmon
        Me.d.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.d.Location = New System.Drawing.Point(104, 140)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(188, 53)
        Me.d.TabIndex = 0
        Me.d.Text = "เงินเดือน"
        Me.d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Salmon
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(104, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เงินเดือนทั้งหมด 12 เดือน"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Salmon
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(104, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 53)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ภาษีที่ต้องชำระ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Salmon
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(104, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 53)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "เงินคงได้เหลือหลังหักภาษี"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(335, 140)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 53)
        Me.TextBox1.TabIndex = 1
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.Snow
        Me.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_total.Location = New System.Drawing.Point(332, 203)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(279, 53)
        Me.lbl_total.TabIndex = 0
        '
        'lbl_tax
        '
        Me.lbl_tax.BackColor = System.Drawing.Color.Snow
        Me.lbl_tax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_tax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_tax.Location = New System.Drawing.Point(332, 267)
        Me.lbl_tax.Name = "lbl_tax"
        Me.lbl_tax.Size = New System.Drawing.Size(279, 53)
        Me.lbl_tax.TabIndex = 0
        '
        'lbl_total2
        '
        Me.lbl_total2.BackColor = System.Drawing.Color.Snow
        Me.lbl_total2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_total2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_total2.Location = New System.Drawing.Point(332, 335)
        Me.lbl_total2.Name = "lbl_total2"
        Me.lbl_total2.Size = New System.Drawing.Size(279, 53)
        Me.lbl_total2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(332, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 55)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(494, 429)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 55)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "ปิดโปรแกรม"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lab_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 610)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_total2)
        Me.Controls.Add(Me.lbl_tax)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.d)
        Me.Name = "lab_1"
        Me.Text = "lab_1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents d As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_tax As Label
    Friend WithEvents lbl_total2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
