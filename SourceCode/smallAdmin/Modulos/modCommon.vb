Imports libCommon.Comunes
Imports manDB
Module modCommon

  Private Const strFormatoAnsiStdFecha As String = "yyyy/MM/dd HH:mm:ss"



  Public Function GetNameOfTipoPago(ByVal vGuid As Guid) As String
    Try
      If g_TipoPago Is Nothing Then Return "--"
      For Each item In g_TipoPago
        If item.GuidTipo = vGuid Then
          Return item.ToString
        End If
      Next
      Return "--"
    Catch ex As Exception
      libCommon.Comunes.Print_msg(ex.Message)
      Return "--"
    End Try
  End Function

  Public Function GetProximoPago(ByVal vGuidProducto As Guid, ByVal NumComprobante As Integer, ByVal vValorCuota As Decimal, ByVal vNumCuota As Integer, ByVal vFechaVenta As Date, ByVal vPrimerVencimiento As Date, Optional ByVal vFechaVencimiento As Date = Nothing) As manDB.clsInfoPagos
    Try
      Dim pago As New manDB.clsInfoPagos
      pago.EstadoPago = libCommon.Comunes.E_EstadoPago.Debe
      pago.GuidProducto = vGuidProducto
      pago.GuidPago = Guid.NewGuid
      pago.FechaPago = Date.MaxValue ' Vencimiento(auxCuotas, datePrimerPago.Value)
      If vFechaVencimiento = Nothing Then
        pago.VencimientoCuota = Vencimiento(vPrimerVencimiento)
      Else
        pago.VencimientoCuota = vFechaVencimiento
      End If
      pago.NumCuota = vNumCuota
      pago.ValorCuota = vValorCuota
      pago.NumComprobante = NumComprobante


      Return pago
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      Return Nothing
    End Try
  End Function

  Public Function Vencimiento(ByVal PrimerPago As Date, Optional ByVal fechaInicial As Date = Nothing) As Date
    Try
      If fechaInicial = Nothing Then
        fechaInicial = GetHoy()
      End If
      Dim DiaDePago As Integer = PrimerPago.Day
      fechaInicial = fechaInicial.AddMonths(1)
      If PrimerPago.Day > DateTime.DaysInMonth(fechaInicial.Year, fechaInicial.Month) Then
        DiaDePago = DateTime.DaysInMonth(fechaInicial.Year, fechaInicial.Month)
      End If
      Dim auxFecha As New Date(fechaInicial.Year, fechaInicial.Month, DiaDePago)

      Return auxFecha
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      Return PrimerPago
    End Try
  End Function

  Public Function DebePeriodoActual(ByVal lstPagos As List(Of manDB.clsInfoPagos)) As Boolean
    Try
      Dim pagadas As Integer = 0
      If lstPagos.Where(Function(c) c.EstadoPago = 1).ToList.Count <= 0 Then Return True
      Dim auxpago As manDB.clsInfoPagos = lstPagos.Where(Function(c) c.EstadoPago = 1).OrderBy(Function(c) c.NumCuota).ToList.Last
      If GetHoy() < auxpago.VencimientoCuota Then
        Return False
      End If
      Return True
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      Return True
    End Try
  End Function

  Public Function FillString(ByVal texto As String, ByVal lenFinal As Integer, ByVal caracter As Char) As String
    Try
      If caracter = String.Empty Then Return texto

      For i As Integer = 0 To lenFinal - texto.Length
        texto = texto.Insert(0, caracter)
      Next
      Return texto
    Catch ex As Exception
      Call libCommon.Comunes.Print_msg(ex.Message)
      Return texto
    End Try
  End Function

  Public Sub ActualizarCuotasVencidas()
    Try
      ''Marcar los pagos vencidos como Vencidos y crear un nuevo talon de pago
      'Dim vResult As libCommon.Comunes.Result
      'Dim lstPago As New List(Of manDB.clsInfoPagos)
      'Dim aux As New clsListPagos
      'aux.Cfg_Filtro = "where (Pagos.VencimientoCuota < #" & Format(GetHoy, strFormatoAnsiStdFecha) & "#) and Pagos.EstadoPago=0"
      'aux.RefreshData()
      'lstPago.AddRange(aux.Items)
      'For Each item In aux.Items
      '  item.EstadoPago = E_EstadoPago.Vencido
      '  vResult = clsPago.Save(item)
      '  If vResult <> Result.OK Then
      '    MsgBox("Fallo update pago")
      '    Exit Sub
      '  End If
      '  Dim objProducto As New manDB.clsInfoProducto
      '  vResult = clsProducto.Load(item.GuidProducto, objProducto)
      '  If vResult <> Result.OK Then
      '    MsgBox("Fallo load producto")
      '    Exit Sub
      '  End If
      '  Dim newpago As manDB.clsInfoPagos = GetProximoPago(item.GuidProducto, objProducto.NumComprobante, objProducto.ValorCuotaFija, item.NumCuota, objProducto.FechaVenta, objProducto.FechaPrimerPago)
      '  If newpago IsNot Nothing Then
      '    vResult = clsPago.Save(newpago)
      '  Else
      '    MsgBox("Fallo guardar newpago")
      '  End If
      'Next

    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

  Public Function ConvStr2Dec(ByVal vText As String, ByRef rValor As Decimal) As Boolean
    Try
      If Not IsNumeric(vText.Trim) Then Return False

      If Not Decimal.TryParse(vText.Trim, Globalization.NumberStyles.AllowDecimalPoint, Globalization.CultureInfo.InvariantCulture, rValor) Then
        Return False
      End If

      'Dim esCorrecto As Boolean = Decimal.TryParse(vText, rValor)
      'If esCorrecto = False Then Return False

      Dim auxString As String = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:N2}", Math.Truncate(rValor * 100) / 100)
      rValor = Math.Truncate(rValor * 100) / 100 ' FormatNumber(rValor, 2)
      Return True
    Catch ex As Exception
      Print_msg(ex.Message)
      Return False
    End Try
  End Function


  '1-agregar fecha como parametro, generar proximo pago
  '2- una barra loca de espera
  Public Sub AplicarCuota(ByVal nCuotas As Integer, ByVal vGuidProducto As Guid, ByVal vFechaPago As Date)
    Try
      Dim vResult As libCommon.Comunes.Result
      Dim auxPago As clsInfoPagos = Nothing
      Dim lstPagos As New List(Of manDB.clsInfoPagos)
      Dim lstProducto = New clsListProductos
      lstProducto = New clsListProductos
      lstProducto.Cfg_Filtro = "where GuidProducto={" & vGuidProducto.ToString & "}"
      lstProducto.RefreshData()
      Dim Producto As New clsInfoProducto
      If lstProducto.Items.Count <= 0 Then
        MsgBox("No existe el producto")
        Exit Sub
      End If
      Producto = lstProducto.Items.First.Clone

      vResult = clsPago.Load(lstPagos, vGuidProducto)
      If vResult <> Result.OK Then
        MsgBox("Fallo cargar pagos")
        Exit Sub
      End If
      While (nCuotas > 0) 'lstPagos.Exists(Function(c) c.EstadoPago = E_EstadoPago.Debe))

        Dim index As Integer = lstPagos.FindIndex(Function(c) c.EstadoPago = E_EstadoPago.Debe)
        If index < 0 Then
          MsgBox("No se encontro cuota debe")
          Exit Sub
        End If
        lstPagos(index).EstadoPago = E_EstadoPago.Pago
        lstPagos(index).FechaPago = vFechaPago

        vResult = clsPago.Save(lstPagos(index))
        If vResult <> Result.OK Then
          MsgBox("Fallo guardar pagos")
          Exit Sub
        End If
        Dim cuotasPagadas As Integer = lstPagos.Where(Function(c) c.EstadoPago = E_EstadoPago.Pago).Count
        If cuotasPagadas < Producto.TotalCuotas Then
          auxPago = GetProximoPago(vGuidProducto, Producto.NumComprobante, Producto.ValorCuotaFija, lstPagos(index).NumCuota + 1, Producto.FechaVenta, lstPagos(index).VencimientoCuota)
          If auxPago IsNot Nothing Then
            vResult = clsPago.Save(auxPago)
            If vResult <> Result.OK Then
              MsgBox("Fallo guardar nuevo pago")
              Exit Sub
            End If
          End If
        End If

        lstPagos.Clear()
        vResult = clsPago.Load(lstPagos, vGuidProducto)
        If vResult <> Result.OK Then
          MsgBox("Fallo cargar pagos")
          Exit Sub
        End If
        auxPago = Nothing
        nCuotas = nCuotas - 1
      End While
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub

 


  Public Sub AplicarPago(ByVal vProducto As clsInfoProducto, ByVal numCuotasACancelar As Integer, ByVal vFechaPago As Date)
    Try
      Dim vResult As Result
      If vProducto.GuidProducto = Guid.Empty Then
        MsgBox("Debe seleccionar un producto")
        Exit Sub
      End If

      Dim lstPagos As New List(Of manDB.clsInfoPagos)
      vResult = clsPago.Load(lstPagos, vProducto.GuidProducto)
      If vResult <> Result.OK Then
        MsgBox("Fallo cargar pagos")
        Exit Sub
      End If
      Dim NumCuotasPagas As Integer = 0
      For Each cuota In lstPagos
        If cuota.EstadoPago = E_EstadoPago.Pago Then NumCuotasPagas += 1
      Next

      If (vProducto.TotalCuotas > 0) AndAlso NumCuotasPagas >= vProducto.TotalCuotas Then
        MsgBox("No hay cuotas pendientes, no se puede aplicar un pago")
        Exit Sub
      End If


      Dim rsta As MsgBoxResult
      If Not DebePeriodoActual(lstPagos) Then
        rsta = MsgBox("Las cuotas estan al dia, desea continuar?", MsgBoxStyle.YesNo)
        If rsta <> MsgBoxResult.Yes Then Exit Sub

      End If
      'If chkPagoParcial.Checked = True Then
      '  Call IngresarPagoParcial(m_CurrentProducto)
      '  Exit Sub
      'End If
      Dim nPagar As Integer = numCuotasACancelar
      'collectar la informacion a mostrar antes de aplicar el pago elgido
      Dim vInfoPersona As New ClsInfoPersona
      If clsPersona.Load(vProducto.GuidCliente, vInfoPersona) <> Result.OK Then
        MsgBox("No se puede cargar la informacion del cliente")
        Exit Sub
      End If

      Dim msg As String = String.Format("Se apilca un pago a: " & vbNewLine & _
                                        "Nombre: {0}" & vbNewLine & _
                                        "DNI: {1}" & vbNewLine & _
                                        "Metodo Pago: {2}" & vbNewLine & _
                                        "Numero: {3}" & vbNewLine & _
                                        "Valor Cuota: {4}" & vbNewLine & _
                                         "Fecha: {5}" & vbNewLine & " Desea continuar?.", vInfoPersona.ToString, vInfoPersona.NumCliente, GetNameOfTipoPago(vProducto.GuidTipoPago), vProducto.NumComprobante, vProducto.ValorCuotaFija, vFechaPago)

      rsta = MsgBox(msg, MsgBoxStyle.YesNo)
      If rsta = MsgBoxResult.Yes Then


        Call AplicarCuota(nPagar, vProducto.GuidProducto, Today)

      End If
    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



  Public Sub RevertirUltimoPago(ByVal vProducto As clsInfoProducto)
    Try
      Dim vResult As Result

      If vProducto.GuidProducto = Guid.Empty Then
        MsgBox("Debe seleccionar un producto")
        Exit Sub
      End If

      Dim lstPagos As New List(Of manDB.clsInfoPagos)
      vResult = clsPago.Load(lstPagos, vProducto.GuidProducto)
      If vResult <> Result.OK Then
        MsgBox("Fallo cargar pagos")
        Exit Sub
      End If
      Dim NumCuotasPagas As Integer = 0
      For Each cuota In lstPagos
        If cuota.EstadoPago = E_EstadoPago.Pago Then NumCuotasPagas += 1
      Next

      If vProducto.TotalCuotas > 0 AndAlso NumCuotasPagas <= 0 Then
        MsgBox("No hay ningun pago aplicado para eliminar")
        Exit Sub
      End If

      Dim vInfoPersona As New ClsInfoPersona
      If clsPersona.Load(vProducto.GuidCliente, vInfoPersona) <> Result.OK Then
        MsgBox("No se puede cargar la informacion del cliente")
        Exit Sub
      End If

      Dim rsta As MsgBoxResult
      Dim msg As String = String.Format("Se descontara el ultimo pago a: " & vbNewLine & _
                                       "Nombre: {0}" & vbNewLine & _
                                       "DNI: {1}" & vbNewLine & _
                                       "Metodo Pago: {2}" & vbNewLine & _
                                       "Numero: {3}" & vbNewLine & _
                                       "Valor Cuota: {4}" & vbNewLine & _
                                        "Fecha: {5}" & vbNewLine & " Desea continuar?.", vInfoPersona.ToString, vInfoPersona.NumCliente, GetNameOfTipoPago(vProducto.GuidTipoPago), vProducto.NumComprobante, vProducto.ValorCuotaFija, GetAhora)

      rsta = MsgBox(msg, MsgBoxStyle.YesNo)
      If rsta = MsgBoxResult.Yes Then

        vResult = clsPago.Load(lstPagos, vProducto.GuidProducto)
        If vResult <> Result.OK Then
          MsgBox("Fallo cargar pagos")
          Exit Sub
        End If

        Dim auxPago As clsInfoPagos = Nothing
        For Each pago In lstPagos.OrderBy(Function(c) c.NumCuota).Reverse
          If pago.EstadoPago = E_EstadoPago.Debe Then 'pago.EstadoPago = E_EstadoPago.Pago OrElse pago.EstadoPago = E_EstadoPago.PagoParcial Then
            pago.EstadoPago = E_EstadoPago.Anulo_Editado
            vResult = clsPago.Save(pago)
            If vResult <> Result.OK Then
              MsgBox("Fallo guardar pagos")
              Exit Sub
            End If
            Exit For
          End If
        Next

        For Each pago In lstPagos.OrderBy(Function(c) c.NumCuota).Reverse
          If pago.EstadoPago = E_EstadoPago.Pago OrElse pago.EstadoPago = E_EstadoPago.PagoParcial Then
            pago.EstadoPago = E_EstadoPago.Debe
            vResult = clsPago.Save(pago)
            If vResult <> Result.OK Then
              MsgBox("Fallo guardar pagos")
              Exit Sub
            End If
            Exit For

          End If
        Next








      End If


    Catch ex As Exception
      Call Print_msg(ex.Message)
    End Try
  End Sub



End Module
