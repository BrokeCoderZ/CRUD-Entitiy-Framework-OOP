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

' Repository generic untuk semua entity (T harus class)
Public Class Repository(Of T As Class)
    Implements IRepository(Of T)

    ' Context database (koneksi ke DB)
    Private ReadOnly _context As AppDbContext

    ' Representasi tabel dari entity T
    Private ReadOnly _dbSet As DbSet(Of T)

    ' Constructor: inject context & ambil DbSet
    Public Sub New(context As AppDbContext)
        _context = context
        _dbSet = _context.Set(Of T)()
    End Sub

    ' Ambil semua data dari tabel
    Public Function GetAll() As List(Of T) Implements IRepository(Of T).GetAll
        Return _dbSet.ToList()
    End Function

    ' Ambil data berdasarkan ID
    Public Function GetById(id As Integer) As T Implements IRepository(Of T).GetById
        Return _dbSet.Find(id)
    End Function

    ' Tambah data baru ke database
    Public Sub Insert(entity As T) Implements IRepository(Of T).Insert
        _dbSet.Add(entity)
    End Sub

    ' Update data (ubah state jadi Modified)
    Public Sub Update(entity As T) Implements IRepository(Of T).Update
        _context.Entry(entity).State = EntityState.Modified
    End Sub

    ' Hapus data berdasarkan ID
    Public Sub Delete(id As Integer) Implements IRepository(Of T).Delete
        Dim entity = _dbSet.Find(id)

        ' Jika data ditemukan, maka dihapus
        If entity IsNot Nothing Then
            _dbSet.Remove(entity)
        End If
    End Sub
End Class