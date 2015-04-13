Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class SANPHAM
    Dim tb As New DataTable
    Dim kn As String = "workstation id=tritm-ps02164.mssql.somee.com;packet size=4096;user id=ps02164;pwd=trivt1995;data source=tritm-ps02164.mssql.somee.com;persist security info=False;initial catalog=tritm-ps02164"
    Private Sub SANPHAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim kn1 As New SqlConnection(kn)
        Dim sqlAdapter As New SqlDataAdapter("Select * from SanPham", kn1)

        Try
            kn1.Open()
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        kn1.Close()
    End Sub
    Public Sub loaddata()
        Dim kn1 As New SqlConnection(kn)
        Dim sqladapter As New SqlDataAdapter("select * from SanPham", kn1)
        Try
            sqladapter.Fill(tb)
        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        kn1.Close()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim kn1 As SqlConnection = New SqlConnection(kn)
        Dim A As String = "insert into SanPham values (@MaSP,@TenSP,@SLSP,@GiaTien)"
        Dim B As New SqlCommand(A, kn1)
        kn1.Open()
        Try
            B.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            B.Parameters.AddWithValue("@TenSP", txttensp.Text)
            B.Parameters.AddWithValue("@SLSP", txtsoluongsanpham.Text)
            B.Parameters.AddWithValue("@GiaTien", txtgiatien.Text)

            B.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Đã thêm thành công")
            End Try 
        Dim C As SqlDataAdapter = New SqlDataAdapter("Select * from Sanpham", kn1)
            tb.Clear()

            C.Fill(tb)
            DataGridView1.DataSource = tb.DefaultView

    End Sub
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim kn1 As New SqlConnection(kn)
        kn1.Open()
        Dim xoa As String = "delete from SanPham where Ma_SP = @MaSP"
        Dim cmd As SqlCommand = New SqlCommand(xoa, kn1)
        Try
            cmd.Parameters.AddWithValue("@MaSP", txtmasp.Text)
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

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim kn1 As New SqlConnection(kn)
        kn1.Open()
        Dim sua As String = "update SanPham Set Ten_SP = @Ten_SP, SLuong_SP = @SLSP, GiaTien_SP = @GiaTien where Ma_SP = @MaSP"
        Dim sua1 As New SqlCommand(sua, kn1)
        Try
            sua1.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            sua1.Parameters.AddWithValue("@Ten_SP", txttensp.Text)
            sua1.Parameters.AddWithValue("@SLSP", txtsoluongsanpham.Text)
            sua1.Parameters.AddWithValue("@GiaTien", txtgiatien.Text)
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

    Private Sub btndon_Click(sender As Object, e As EventArgs) Handles btndon.Click
        txtmasp.Clear()
        txttensp.Clear()
        txtsoluongsanpham.Clear()
        txtgiatien.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim hienthi As Integer = DataGridView1.CurrentCell.RowIndex
        txtmasp.Text = DataGridView1.Item(0, hienthi).Value
        txttensp.Text = DataGridView1.Item(1, hienthi).Value
        txtsoluongsanpham.Text = DataGridView1.Item(2, hienthi).Value
        txtgiatien.Text = DataGridView1.Item(3, hienthi).Value
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
End Class