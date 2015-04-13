<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SANPHAM
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtgiatien = New System.Windows.Forms.TextBox()
        Me.txtsoluongsanpham = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btndon = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtgiatien)
        Me.GroupBox1.Controls.Add(Me.txtsoluongsanpham)
        Me.GroupBox1.Controls.Add(Me.txttensp)
        Me.GroupBox1.Controls.Add(Me.txtmasp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 187)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SẢN PHẨM"
        '
        'txtgiatien
        '
        Me.txtgiatien.Location = New System.Drawing.Point(175, 138)
        Me.txtgiatien.Name = "txtgiatien"
        Me.txtgiatien.Size = New System.Drawing.Size(150, 20)
        Me.txtgiatien.TabIndex = 7
        '
        'txtsoluongsanpham
        '
        Me.txtsoluongsanpham.Location = New System.Drawing.Point(175, 104)
        Me.txtsoluongsanpham.Name = "txtsoluongsanpham"
        Me.txtsoluongsanpham.Size = New System.Drawing.Size(150, 20)
        Me.txtsoluongsanpham.TabIndex = 6
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(175, 65)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(150, 20)
        Me.txttensp.TabIndex = 5
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(175, 32)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(150, 20)
        Me.txtmasp.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Giá Tiền"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Số Lượng Sản Phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Sản Phẩm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm"
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(120, 205)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 1
        Me.btnthem.Text = "THÊM"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(261, 205)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 2
        Me.btnsua.Text = "SỬA"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(120, 246)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 3
        Me.btnxoa.Text = "XÓA"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btndon
        '
        Me.btndon.Location = New System.Drawing.Point(261, 246)
        Me.btndon.Name = "btndon"
        Me.btndon.Size = New System.Drawing.Size(75, 23)
        Me.btndon.TabIndex = 4
        Me.btndon.Text = "DỌN"
        Me.btndon.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 293)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(430, 262)
        Me.DataGridView1.TabIndex = 5
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(356, 583)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(87, 23)
        Me.btnthoat.TabIndex = 6
        Me.btnthoat.Text = "THOÁT"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'SANPHAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 632)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btndon)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SANPHAM"
        Me.Text = "SẢN PHẨM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtgiatien As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluongsanpham As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btndon As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnthoat As System.Windows.Forms.Button
End Class
