Imports libCommon.Comunes
Imports manDB
Public Class clsCliente

  Public Shared Function SavePersonal(ByRef rCliente As manDB.clsInfoCliente) As libCommon.Comunes.Result
    Try
      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK
      Try

        'Dim LCliente As New manDB.clsInfoCliente
        'LCliente = rCliente.Clone
        'objResult = Cliente_Load(rCliente.Personal.GuidCliente, rCliente)
        'If objResult <> Result.OK Then Exit Try

        objDB = New libDB.clsAcceso
        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = clsPersona.Save(objDB, rCliente.Personal)
        If objResult <> Result.OK Then Exit Try

        objResult = Save_InfoProducto(objDB, rCliente.Personal.GuidCliente, rCliente.ListaProductos)
        If objResult <> Result.OK Then Exit Try


      Catch ex As Exception
        Call Print_msg(ex.Message)
      Finally
        If objDB IsNot Nothing Then
          If objResult <> Result.OK Then
            objDB.CloseDB()
          Else
            objResult = objDB.CloseDB()
          End If
        End If
      End Try


      Return objResult
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Shared Function Save_InfoProducto(ByVal vObjDB As libDB.clsAcceso, ByVal GuidCliente As Guid, ByVal vProductos As List(Of clsInfoProducto)) As Result
    Try
      If vProductos IsNot Nothing Then
        For Each producto In vProductos
          If clsProducto.Save(vObjDB, GuidCliente, producto) <> Result.OK Then Return Result.NOK
        Next
      End If
      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function Cliente_Load(ByVal vGuidCliente As Guid, ByRef rCliente As manDB.clsInfoCliente) As Result
    Try

      Dim vResult As Result
      Dim vIdCliente As Integer


      If clsPersona.FindGuid(vGuidCliente, vIdCliente) = True Then
        vResult = Init(rCliente, vGuidCliente)
        Return vResult
      Else
        'crea un Cliente vacio con vGuid. 
      End If

      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Shared Function Init(ByRef rInfoCliente As manDB.clsInfoCliente, ByVal GuidCliente As Guid) As Result
    Try

      Dim objDB As libDB.clsAcceso = Nothing
      Dim objResult As Result = Result.OK

      Try
        rInfoCliente = New clsInfoCliente
        rInfoCliente.Personal.GuidCliente = GuidCliente

        objDB = New libDB.clsAcceso

        objResult = objDB.OpenDB(Entorno.DB_SLocal_ConnectionString)
        If objResult <> Result.OK Then Exit Try

        objResult = Init(objDB, rInfoCliente, GuidCliente)
        If objResult <> Result.OK Then Exit Try

      Catch ex As Exception
        Call Print_msg(ex.Message)
        objResult = Result.ErrorEx

      Finally
        If objDB IsNot Nothing Then
          If objResult <> Result.OK Then
            objDB.CloseDB()
          Else
            objResult = objDB.CloseDB()
          End If
        End If
      End Try

      Return objResult

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try

  End Function

  Private Shared Function Init(ByVal ObjDB As libDB.clsAcceso, ByRef rInfoCliente As clsInfoCliente, ByVal GuidCliente As Guid, Optional ByRef intCodeError As Integer = -1) As Result
    Try

      Dim objResult As Result

      objResult = clsPersona.Init(ObjDB, rInfoCliente.Personal, GuidCliente)
      If objResult <> Result.OK Then Return objResult


      ''Productos
      objResult = clsProducto.Init(ObjDB, rInfoCliente.ListaProductos, GuidCliente)
      If objResult <> Result.OK Then Return objResult

      Return Result.OK

    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  
End Class
