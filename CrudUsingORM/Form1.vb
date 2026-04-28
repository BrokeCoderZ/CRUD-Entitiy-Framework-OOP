' ====================================================
' Source code ini hanya sebagai bahan refrensi saja
' Semua SC yang saya berikan tidak dipungut biaya
'
' Oh iya Subreker Channel UMKM dibawh om
' Youtube : https://www.youtube.com/@DeveloperNgantuk
' 
' Terimakasih banyak dan selamat belajar....!!!!!!
'====================================================
Public Class Form1

    Private service As New ProductService()
    Private selectedId As Integer = 0

    ' LOAD FORM
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        SetInitialState()
    End Sub

    ' LOAD DATA
    Private Sub LoadData()
        dgvProducts.DataSource = service.GetAll()

        dgvProducts.Columns("Id").HeaderText = "ID"
        dgvProducts.Columns("Name").HeaderText = "Nama Produk"
        dgvProducts.Columns("Price").HeaderText = "Harga"
        dgvProducts.Columns("Stock").HeaderText = "Stok"
        dgvProducts.Columns("CreatedAt").HeaderText = "Tanggal Dibuat"
    End Sub
    ' STATE BUTTON
    Private Sub SetInitialState()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub SetEditState()
        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    ' CLEAR FORM
    Private Sub ClearForm()
        txtName.Clear()
        txtPrice.Clear()
        txtStock.Clear()
        selectedId = 0
        SetInitialState()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub
    ' VALIDASI ANGKA
    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' hanya angka + dot
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        ' hanya angka
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    ' INSERT
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            service.Create(txtName.Text, txtPrice.Text, txtStock.Text)

            LoadData()
            ClearForm()

            MessageBox.Show("Data berhasil disimpan")

        Catch ex As Exception
            Clipboard.SetText(ex.Message)
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ' UPDATE
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If selectedId = 0 Then
                MessageBox.Show("Pilih data terlebih dahulu")
                Return
            End If

            service.Update(selectedId, txtName.Text, txtPrice.Text, txtStock.Text)

            LoadData()
            ClearForm()

            MessageBox.Show("Data berhasil diupdate")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ' DELETE
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If selectedId = 0 Then
                MessageBox.Show("Pilih data terlebih dahulu")
                Return
            End If

            Dim confirm = MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo)

            If confirm = DialogResult.Yes Then
                service.Delete(selectedId)
                LoadData()
                ClearForm()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ' CLICK GRID
    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvProducts.Rows(e.RowIndex)

            selectedId = CInt(row.Cells("Id").Value)
            txtName.Text = row.Cells("Name").Value.ToString()
            txtPrice.Text = row.Cells("Price").Value.ToString()
            txtStock.Text = row.Cells("Stock").Value.ToString()

            SetEditState()
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(keyword) Then
            dgvProducts.DataSource = Nothing
            lblRowCount.Text = "0 produk ditemukan"
            lblRowCount.ForeColor = Color.Black
            LoadData()
            Return
        End If

        Using db As New AppDbContext()

            Dim data = db.Products.
            Where(Function(x) x.Name.Contains(keyword)).
            ToList()

            dgvProducts.DataSource = data

            If data.Count > 0 Then
                lblRowCount.Text = data.Count.ToString() & " produk ditemukan"
                lblRowCount.ForeColor = Color.Green
            Else
                lblRowCount.Text = data.Count.ToString() & " produk ditemukan"
                lblRowCount.ForeColor = Color.Red
            End If

        End Using
    End Sub
End Class