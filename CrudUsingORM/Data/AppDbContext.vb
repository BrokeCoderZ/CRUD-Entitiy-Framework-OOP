' ====================================================
' Source code ini hanya sebagai bahan refrensi saja
' Semua SC yang saya berikan tidak dipungut biaya
'
' Oh iya Subreker Channel UMKM dibawh om
' Youtube : https://www.youtube.com/@DeveloperNgantuk
' 
' Terimakasih banyak dan selamat belajar....!!!!!!
'====================================================
Imports System.Data.Entity

' DbContext utama untuk akses database (Entity Framework)
Public Class AppDbContext
    Inherits DbContext

    ' Constructor: gunakan connection string "AppDbContext" dari config
    Public Sub New()
        MyBase.New("name=AppDbContext")
    End Sub

    ' Representasi tabel "Products" di database
    Public Property Products As DbSet(Of Product)
End Class