Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class KHACHHANG
    Dim tb As New DataTable
    Dim kn As String = "workstation id=tritm-ps02164.mssql.somee.com;packet size=4096;user id=ps02164;pwd=trivt1995;data source=tritm-ps02164.mssql.somee.com;persist security info=False;initial catalog=tritm-ps02164"
    Private Sub KHACHHANG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
   Dim kn1 As SqlConnection = New SqlConnection(kn)
        Dim sqladapter As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", kn1)

        kn1.Open()
        sqladapter.Fill(tb)

        DataGridView1.DataSource = tb
    End Sub
    Public Sub loaddata()
        Dim kn1 As SqlConnection = New SqlConnection(kn)
        Dim sqladapter As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", kn1)

        kn1.Open()
        sqladapter.Fill(tb)

        DataGridView1.DataSource = tb
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim kn1 As SqlConnection = New SqlConnection(kn)
        Dim A As String = "insert into KhachHang values (@MaKH,@TenKH,@SDT,@DiaChi)"
        Dim B As New SqlCommand(A, kn1)
        kn1.Open()
        Try
            B.Parameters.AddWithValue("@MaKH", txtmakh.Text)
            B.Parameters.AddWithValue("@TenKH", txttenkh.Text)
            B.Parameters.AddWithValue("@SDT", txtsdt.Text)
            B.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)
            B.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Đã thêm thành công")
        End Try
        Dim C As SqlDataAdapter = New SqlDataAdapter("Select * from KhachHang", kn1)
        tb.Clear()
        C.Fill(tb)
        DataGridView1.DataSource = tb.DefaultView

    End Sub

    Private Sub btndon_Click(sender As Object, e As EventArgs) Handles btndon.Click
        txtmakh.Clear()
        txttenkh.Clear()
        txtsdt.Clear()
        txtdiachi.Clear()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim kn1 As New SqlConnection(kn)
        kn1.Open()
        Dim xoa As String = "delete from KhachHang where Ma_KH = @MaKH"
        Dim cmd As SqlCommand = New SqlCommand(xoa, kn1)
        Try
            cmd.Parameters.AddWithValue("@MaKH", txtmakh.Text)
            cmd.ExecuteNonQuery()
            kn1.Close()
            MessageBox.Show("Xóa thành công")
        Catch ex As Exception
            MessageBox.Show("Xóa không thành công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loaddata()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
  
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim kn1 As New SqlConnection(kn)
        kn1.Open()
        Dim sua As String = "update KhachHang Set Ten_KH = @Ten_KH, SDT_KH = @SDT, DiaChi_KH = @DiaChi where Ma_KH = @MaKH"
        Dim sua1 As New SqlCommand(sua, kn1)
        Try
            sua1.Parameters.AddWithValue("@MaKH", txtmakh.Text)
            sua1.Parameters.AddWithValue("@Ten_KH", txttenkh.Text)
            sua1.Parameters.AddWithValue("@SDT", txtsdt.Text)
            sua1.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)
            sua1.ExecuteNonQuery()
            kn1.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loaddata()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim hienthi As Integer = DataGridView1.CurrentCell.RowIndex
        txtmakh.Text = DataGridView1.Item(0, hienthi).Value
        txttenkh.Text = DataGridView1.Item(1, hienthi).Value
        txtsdt.Text = DataGridView1.Item(2, hienthi).Value
        txtdiachi.Text = DataGridView1.Item(3, hienthi).Value
    End Sub
End Class
