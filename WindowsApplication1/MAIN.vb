Public Class MAIN

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
        LOGIN.Show()
    End Sub

    Private Sub btnnhanvien_Click(sender As Object, e As EventArgs) Handles btnnhanvien.Click
        NHANVIEN.Show()
    End Sub

    Private Sub btnkhachhang_Click(sender As Object, e As EventArgs) Handles btnkhachhang.Click
        KHACHHANG.Show()
    End Sub

    Private Sub btnsanpham_Click(sender As Object, e As EventArgs) Handles btnsanpham.Click
        SANPHAM.Show()
    End Sub
End Class