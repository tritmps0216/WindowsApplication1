Imports System.Data.SqlClient

Public Class LOGIN

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim chuoiketnoi As String = "workstation id=tritm-ps02164.mssql.somee.com;packet size=4096;user id=ps02164;pwd=trivt1995;data source=tritm-ps02164.mssql.somee.com;persist security info=False;initial catalog=tritm-ps02164"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where user='" & txtusername.Text & "' and password='" & txtpassword.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng Nhập Thành Công")
                Me.Hide()
                MAIN.Show()
            Else
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu")
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Hide()
        START.Show()
    End Sub
End Class
