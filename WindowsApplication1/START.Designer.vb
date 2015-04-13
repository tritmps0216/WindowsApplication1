<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class START
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(START))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnbatdau = New System.Windows.Forms.Button()
        Me.btnthaot = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(54, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnbatdau
        '
        Me.btnbatdau.Location = New System.Drawing.Point(404, 77)
        Me.btnbatdau.Name = "btnbatdau"
        Me.btnbatdau.Size = New System.Drawing.Size(133, 34)
        Me.btnbatdau.TabIndex = 1
        Me.btnbatdau.Text = "BẮT ĐẦU"
        Me.btnbatdau.UseVisualStyleBackColor = True
        '
        'btnthaot
        '
        Me.btnthaot.Location = New System.Drawing.Point(404, 171)
        Me.btnthaot.Name = "btnthaot"
        Me.btnthaot.Size = New System.Drawing.Size(133, 30)
        Me.btnthaot.TabIndex = 2
        Me.btnthaot.Text = "THOÁT"
        Me.btnthaot.UseVisualStyleBackColor = True
        '
        'START
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 299)
        Me.Controls.Add(Me.btnthaot)
        Me.Controls.Add(Me.btnbatdau)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "START"
        Me.Text = "START"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnbatdau As System.Windows.Forms.Button
    Friend WithEvents btnthaot As System.Windows.Forms.Button
End Class
