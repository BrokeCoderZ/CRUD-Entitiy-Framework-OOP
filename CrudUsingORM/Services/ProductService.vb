' ====================================================
' Source code ini hanya sebagai bahan refrensi saja
' Semua SC yang saya berikan tidak dipungut biaya
'
' Oh iya Subreker Channel UMKM dibawh om
' Youtube : https://www.youtube.com/@DeveloperNgantuk
' 
' Terimakasih banyak dan selamat belajar....!!!!!!
'====================================================
Public Class ProductService

    Public Function GetAll() As List(Of Product)
        Using db As New AppDbContext()
            Dim repo As New Repository(Of Product)(db)
            Return repo.GetAll()
        End Using
    End Function

    Public Sub Create(name As String, priceText As String, stockText As String)

        Dim price As Decimal
        Dim stock As Integer

        If String.IsNullOrWhiteSpace(name) Then
            Throw New Exception("Nama wajib diisi")
        End If

        If Not Decimal.TryParse(priceText, price) Then
            Throw New Exception("Harga tidak valid")
        End If

        If Not Integer.TryParse(stockText, stock) Then
            Throw New Exception("Stock tidak valid")
        End If

        Using db As New AppDbContext()
            Dim repo As New Repository(Of Product)(db)

            Dim product As New Product With {
            .Name = name.Trim(),
            .Price = price,
            .Stock = stock,
            .CreatedAt = DateTime.Now
        }
            repo.Insert(product)
            db.SaveChanges()
        End Using

    End Sub

    Public Sub Update(id As Integer, name As String, priceText As String, stockText As String)

        Using db As New AppDbContext()
            Dim repo As New Repository(Of Product)(db)
            Dim product = repo.GetById(id)

            If product Is Nothing Then
                Throw New Exception("Data tidak ditemukan")
            End If

            Dim price As Decimal
            Dim stock As Integer

            If Not Decimal.TryParse(priceText, price) Then
                Throw New Exception("Harga tidak valid")
            End If

            If Not Integer.TryParse(stockText, stock) Then
                Throw New Exception("Stock tidak valid")
            End If

            product.Name = name.Trim()
            product.Price = price
            product.Stock = stock

            repo.Update(product)
            db.SaveChanges()
        End Using

    End Sub

    Public Sub Delete(id As Integer)
        Using db As New AppDbContext()
            Dim repo As New Repository(Of Product)(db)
            repo.Delete(id)
            db.SaveChanges()
        End Using
    End Sub

End Class