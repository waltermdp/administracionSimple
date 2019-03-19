Imports libCommon.Comunes
Module modInOut

  Public Function GetCuerpoVISADebito(ByVal vLineas As List(Of String), ByRef rMovimiento As List(Of clsInfoMovimiento)) As Result
    Try

      rMovimiento = New List(Of clsInfoMovimiento)
      If vLineas.Count <= 0 Then Return Result.OK
      If vLineas.GetRange(1, vLineas.Count - 2).TrueForAll(Function(c) c.First = "1" AndAlso c.Last = "*") = False Then Return Result.NOK
      Dim aux As String = String.Empty
      Dim movimiento As clsInfoMovimiento
      For Each linea In vLineas.GetRange(1, vLineas.Count - 2)
        movimiento = New clsInfoMovimiento
        With movimiento
          .NumeroTarjeta = linea.Substring(1, 16) 'num tar
          .NumeroComprobante = linea.Substring(20, 8) 'num comprobante
          .Fecha = linea.Substring(28, 8) 'fecha
          aux = linea.Substring(36, 4) 'c transac = 0005
          .Importe = linea.Substring(40, 15) 'importe incluye 2 dec
          .IdentificadorDebito = linea.Substring(55, 15) 'identificador debito
          '11 espacios
          .Param1 = linea.Substring(81, 1) 'param1
          '2 espacio 
          .Param2 = linea.Substring(84, 1) 'param2
          '15 espacios
          .Codigo = linea.Substring(100, 3) 'codigo
          .Detalle = linea.Substring(103, 46) 'descripcion OJO no se si es hasta el final o hay espacion fijo en el final
        End With
        rMovimiento.Add(movimiento)
      Next


      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetCuerpoVISACredito(ByVal vLineas As List(Of String), ByRef rMovimiento As List(Of clsInfoMovimiento)) As Result
    Try

      rMovimiento = New List(Of clsInfoMovimiento)
      If vLineas.Count <= 0 Then Return Result.OK
      If vLineas.GetRange(1, vLineas.Count - 2).TrueForAll(Function(c) c.First = "1" AndAlso c.Last = "*") = False Then Return Result.NOK
      Dim aux As String = String.Empty
      Dim movimiento As clsInfoMovimiento
      For Each linea In vLineas.GetRange(1, vLineas.Count - 2)
        movimiento = New clsInfoMovimiento
        With movimiento
          .NumeroTarjeta = linea.Substring(26, 16) 'num tar
          '.NumeroComprobante = linea.Substring(20, 8) 'num comprobante
          '.Fecha = linea.Substring(28, 8) 'fecha
          'aux = linea.Substring(36, 4) 'c transac = 0005
          .Importe = linea.Substring(62, 15) 'importe incluye 2 dec
          .IdentificadorDebito = linea.Substring(79, 15) 'identificador debito
          ''11 espacios
          '.Param1 = linea.Substring(81, 1) 'param1
          ''2 espacio 
          '.Param2 = linea.Substring(84, 1) 'param2
          ''15 espacios
          '.Codigo = linea.Substring(100, 3) 'codigo
          '.Detalle = linea.Substring(103, 46) 'descripcion OJO no se si es hasta el final o hay espacion fijo en el final
        End With
        rMovimiento.Add(movimiento)
      Next


      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetCuerpoCBU(ByVal vLineas As List(Of String), ByRef rMovimiento As List(Of clsInfoMovimiento)) As Result
    Try

      rMovimiento = New List(Of clsInfoMovimiento)
      If vLineas.Count <= 0 Then Return Result.OK
      'If vLineas.GetRange(1, vLineas.Count - 2).TrueForAll(Function(c) c.First = "1" AndAlso c.Last = "*") = False Then Return Result.NOK
      Dim aux As String = String.Empty
      Dim movimiento As clsInfoMovimiento
      For Each linea In vLineas.GetRange(1, vLineas.Count - 8) ' header mas tail
        movimiento = New clsInfoMovimiento
        With movimiento
          .NumeroTarjeta = linea.Substring(51, 26) 'CBU
          .IdentificadorDebito = linea.Substring(28, 22) 'Identificador
          .Fecha = linea.Substring(78, 8) 'Fecha Compensacion
          .Param1 = linea.Substring(112, 10) 'Concepto
          .Param2 = linea.Substring(123, 9) 'Importe del vencimiento
          .Importe = linea.Substring(133, 9) 'Importe cobrado
          .Detalle = linea.Substring(143, 56) 'Detalle

          '.NumeroTarjeta = linea.Substring(26, 16) 'num tar
          '.NumeroComprobante = linea.Substring(20, 8) 'num comprobante
          '.Fecha = linea.Substring(28, 8) 'fecha
          'aux = linea.Substring(36, 4) 'c transac = 0005
          '.Importe = linea.Substring(62, 15) 'importe incluye 2 dec
          '.IdentificadorDebito = linea.Substring(79, 15) 'identificador debito
          ''11 espacios
          '.Param1 = linea.Substring(81, 1) 'param1
          ''2 espacio 
          '.Param2 = linea.Substring(84, 1) 'param2
          ''15 espacios
          '.Codigo = linea.Substring(100, 3) 'codigo
          '.Detalle = linea.Substring(103, 46) 'descripcion OJO no se si es hasta el final o hay espacion fijo en el final
        End With
        rMovimiento.Add(movimiento)
      Next


      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function GetCuerpoFirstData(ByVal vLineas As List(Of String), ByRef rMovimiento As List(Of clsInfoMovimiento)) As Result
    Try

      rMovimiento = New List(Of clsInfoMovimiento)
      If vLineas.Count <= 0 Then Return Result.OK
      'primer linea de header
      'If vLineas.GetRange(1, vLineas.Count - 2).TrueForAll(Function(c) c.First = "1" AndAlso c.Last = "*") = False Then Return Result.NOK
      Dim aux As String = String.Empty
      Dim movimiento As clsInfoMovimiento
      For Each linea In vLineas.GetRange(1, vLineas.Count - 8) ' header mas tail
        movimiento = New clsInfoMovimiento
        With movimiento
          .NumeroTarjeta = linea.Substring(3, 16)
          .IdentificadorDebito = linea.Substring(26, 12) 'Identificador
          .Importe = linea.Substring(40, 11) 'Importe cobrado
          .Codigo = linea.Substring(58, 2) 'codigo Rechazo
          .NumeroComprobante = CInt(linea.Substring(71, 40)).ToString  'DATO AUXILIAR
          .Fecha = linea.Substring(111, 6) 'Fecha Compensacion
          '.Detalle = linea.Substring(143, 56) 'Detalle

        End With
        rMovimiento.Add(movimiento)
      Next


      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function


  Public Function SetCuerpo(ByRef rLineas As List(Of String), ByVal vMovimientos As List(Of clsInfoMovimiento)) As Result
    Try
      If vMovimientos.Count <= 0 Then Return Result.OK
      'If vLineas.TrueForAll(Function(c) c.First = "1" AndAlso c.Last = "*") = False Then Return Result.NOK
      Dim auxMov As String = String.Empty
      Dim movimiento As clsInfoMovimiento
      For Each movimiento In vMovimientos
        auxMov = auxMov.Insert(0, "1")
        auxMov = auxMov.Insert(1, movimiento.NumeroTarjeta)
        auxMov = auxMov.Insert(17, "   ")
        auxMov = auxMov.Insert(20, movimiento.NumeroComprobante)
        'linea.Substring(1, 16) 'num tar
        'linea.Substring(20, 8) 'num comprobante
        'linea.Substring(28, 8) 'fecha
        'linea.Substring(36, 4) 'c transac = 0005
        'linea.Substring(40, 15) 'importe incluye 2 dec
        'linea.Substring(55, 15) 'identificador debito
        ''11 espacios
        'linea.Substring(66, 1) 'param1
        ''2 espacio 
        'linea.Substring(68, 1) 'param2
        ''15 espacios
        'linea.Substring(83, 3) 'codigo
        'linea.Substring(86, 46) 'descripcion OJO no se si es hasta el final o hay espacion fijo en el final

      Next


      Return Result.OK
    Catch ex As Exception
      Call Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function
End Module
