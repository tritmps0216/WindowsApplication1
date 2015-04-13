Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class NHANVIEN
    Dim tb As New DataTable
    Dim kn As String = "workstation id=tritm-ps02164.mssql.somee.com;packet size=4096;user id=ps02164;pwd=trivt1995;data source=tritm-ps02164.mssql.somee.com;persist security info=False;initial catalog=tritm-ps02164"
    Private Sub NHANVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim kn1 As New SqlConnection(kn)
        Dim sqlAdapter As New SqlDataAdapter("Select * from NhanVien", kn1)

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
        Dim sqladapter As New SqlDataAdapter("select * from NhanVien", kn1)
        Try
            sqladapter.Fill(tb)
        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        kn1.Close()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim kn1 As SqlConnection = New SqlConnection(kn)
        Dim A As String = "insert into NhanVien values (@MaNV,@TenNV,@User,@Password,@Email)"
        Dim B As New SqlCommand(A, kn1)
        kn1.Open()

        B.Parameters.AddWithValue("@MaNV", txtmanv.Text)
        B.Parameters.AddWithValue("@TenNV", txttennv.Text)
        B.Parameters.AddWithValue("@User", txtusername.Text)
        B.Parameters.AddWithValue("@Password", txtpassword.Text)
        B.Parameters.AddWithValue("@Email", txtemail.Text)

        B.ExecuteNonQuery()

        MessageBox.Show("Đã thêm thành công")

        Dim C As SqlDataAdapter = New SqlDataAdapter("Select * from NhanVien", kn1)
        tb.Clear()

        C.Fill(tb)
        DataGridView1.DataSource = tb.DefaultView

    End Sub

    Private Sub btndon_Click(sender As Object, e As EventArgs) Handles btndon.Click
        txtmanv.Clear()
        txttennv.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtemail.Clear()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    'xóa dữ liệu
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim kn1 As New SqlConnection(kn)
        kn1.Open()
        Dim xoa As String = "delete from NhanVien where Ma_NV = @MaNV"
        Dim cmd As SqlCommand = New SqlCommand(xoa, kn1)
        Try
            cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text)
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

    Private Sub NHANVIEN_Load()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim hienthi As Integer = DataGridView1.CurrentCell.RowIndex
        txtmanv.Text = DataGridView1.Item(0, hienthi).Value
        txttennv.Text = DataGridView1.Item(1, hienthi).Value
        txtusername.Text = DataGridView1.Item(2, hienthi).Value
        txtpassword.Text = DataGridView1.Item(3, hienthi).Value
        txtemail.Text = DataGridView1.Item(4, hienthi).Value
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim kn1 As New SqlConnection(kn)
        kn1.Open()
        Dim sua As String = "update NhanVien Set Ten_NV = @TenNV, user = @user, password = @password, Email = @Email where Ma_NV = @MaNV"
        Dim sua1 As New SqlCommand(sua, kn1)
        Try
            sua1.Parameters.AddWithValue("@MaNV", txtmanv.Text)
            sua1.Parameters.AddWithValue("@TenNV", txttennv.Text)
            sua1.Parameters.AddWithValue("@user", txtusername.Text)
            sua1.Parameters.AddWithValue("@password", txtpassword.Text)
            sua1.Parameters.AddWithValue("@Email", txtemail.Text)
            sua1.ExecuteNonQuery()
            kn1.Close()
            MessageBox.Show("thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loaddata()
    End Sub
End Class