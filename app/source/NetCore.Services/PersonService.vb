Imports NetCore.Entities
Imports NetCore.Repository

Public Class PersonService
    Private ReadOnly _repository As PersonRepository = New PersonRepository()
    Public Function GetAll() As PersonEntity()
        Return _repository.GetAll()
    End Function

    Public Function GetById(dni As String) As PersonEntity
        Dim person As PersonEntity = _repository.GetAll().FirstOrDefault(Function(p) p.Dni = dni)
        Return person
    End Function
End Class
