' ====================================================
' Source code ini hanya sebagai bahan refrensi saja
' Semua SC yang saya berikan tidak dipungut biaya
'
' Oh iya Subreker Channel UMKM dibawh om
' Youtube : https://www.youtube.com/@DeveloperNgantuk
' 
' Terimakasih banyak dan selamat belajar....!!!!!!
'====================================================
Public Interface IRepository(Of T)
    Function GetAll() As List(Of T)
    Function GetById(id As Integer) As T
    Sub Insert(entity As T)
    Sub Update(entity As T)
    Sub Delete(id As Integer)
End Interface