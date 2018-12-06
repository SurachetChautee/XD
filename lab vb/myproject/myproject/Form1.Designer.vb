<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_tax = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมตัวอย่างการคิดค่าแรง"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SandyBrown
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 47)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชั่วโมงการทำงาน"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SandyBrown
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 47)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "อัตราค่าจ้างต่อชั่วโมง"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SandyBrown
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 47)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "คิดเป็นเงิน"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SandyBrown
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 47)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "หักเสียภาษี ณ ที่จ่าย 3%"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_tax
        '
        Me.lbl_tax.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_tax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_tax.Location = New System.Drawing.Point(293, 334)
        Me.lbl_tax.Name = "lbl_tax"
        Me.lbl_tax.Size = New System.Drawing.Size(258, 47)
        Me.lbl_tax.TabIndex = 4
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(293, 268)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(258, 47)
        Me.lbl_total.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(293, 128)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 54)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(293, 195)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(258, 54)
        Me.TextBox2.TabIndex = 2
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(213, 434)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(105, 50)
        Me.btn1.TabIndex = 5
        Me.btn1.Text = "คำนวณ"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(476, 434)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(105, 50)
        Me.btn3.TabIndex = 7
        Me.btn3.Text = "ปิด"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(341, 434)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(105, 50)
        Me.btn2.TabIndex = 6
        Me.btn2.Text = "เครียร์"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 558)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_tax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_tax As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
End Class
