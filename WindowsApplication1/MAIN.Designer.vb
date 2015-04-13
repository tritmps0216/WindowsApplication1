<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAIN
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
        Me.btnnhanvien = New System.Windows.Forms.Button()
        Me.btnkhachhang = New System.Windows.Forms.Button()
        Me.btnsanpham = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnnhanvien
        '
        Me.btnnhanvien.Location = New System.Drawing.Point(49, 12)
        Me.btnnhanvien.Name = "btnnhanvien"
        Me.btnnhanvien.Size = New System.Drawing.Size(137, 84)
        Me.btnnhanvien.TabIndex = 0
        Me.btnnhanvien.Text = "NHÂN VIÊN"
        Me.btnnhanvien.UseVisualStyleBackColor = True
        '
        'btnkhachhang
        '
        Me.btnkhachhang.Location = New System.Drawing.Point(49, 102)
        Me.btnkhachhang.Name = "btnkhachhang"
        Me.btnkhachhang.Size = New System.Drawing.Size(137, 88)
        Me.btnkhachhang.TabIndex = 1
        Me.btnkhachhang.Text = "KHÁCH HÀNG"
        Me.btnkhachhang.UseVisualStyleBackColor = True
        '
        'btnsanpham
        '
        Me.btnsanpham.Location = New System.Drawing.Point(49, 196)
        Me.btnsanpham.Name = "btnsanpham"
        Me.btnsanpham.Size = New System.Drawing.Size(137, 85)
        Me.btnsanpham.TabIndex = 2
        Me.btnsanpham.Text = "SẢN PHẨM"
        Me.btnsanpham.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(75, 318)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 3
        Me.btnthoat.Text = "THOÁT"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 372)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnsanpham)
        Me.Controls.Add(Me.btnkhachhang)
        Me.Controls.Add(Me.btnnhanvien)
        Me.Name = "MAIN"
        Me.Text = "MAIN"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnnhanvien As System.Windows.Forms.Button
    Friend WithEvents btnkhachhang As System.Windows.Forms.Button
    Friend WithEvents btnsanpham As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
End Class
