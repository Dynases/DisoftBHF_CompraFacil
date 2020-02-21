Imports ENTITY

Public Interface ICajaCambio
    Function Listar(IdCaja As Integer) As List(Of VCajaCambio)
    Function GuardarCajaCambio(listIdCaja As List(Of VCajaCambio), idCaja As Integer) As Boolean
End Interface
