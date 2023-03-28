Imports libCommon.Comunes
Module Entorno

  Public Const NameSoftware As String = "NA"


  Private Const NAMEDB As String = "bdcli.mdb"


  Private Const BKP_FOLDER As String = "bkpdb"
  Private Const CONFIG_FOLDER As String = "config"
  Private Const TEMP_FOLDER As String = "temp"
  Private Const EXPORT_FOLDER As String = "export"
  Private Const IMPORT_FOLDER As String = "import"
  Private Const MODEL_FOLDER As String = "model"

  Public App_path As String = String.Empty
  Public DB_path As String = String.Empty
  Private BKPDB_path As String = String.Empty
  Public CONFIG_PATH As String = String.Empty
  Public TEMP_PATH As String = String.Empty
  Public EXPORT_PATH As String = String.Empty
  Public IMPORT_PATH As String = String.Empty
  Public MODEL_PATH As String = String.Empty

  Private dbpw As String = String.Empty
  Public DB_SLocal_ConnectionString As String = String.Empty

  Public g_TipoPago As New List(Of manDB.clsTipoPago)
  Public g_Cuotas As New List(Of clsCuota)


  Public g_Today As Date 'TODO: crear fecha para saber si se cambia la fecha de la pc con respecto al ultimo uso

  Public g_debug As Boolean = True


  'Public Enum GRUPOS As Integer
  '  NA = 0
  '  A = 1
  '  B = 2
  '  C = 3
  '  D = 4
  '  E = 5
  '  F = 6
  '  G = 7
  '  H = 8
  '  I = 9
  '  J = 10
  '  K = 11
  '  L = 12
  'End Enum

  Public Enum CATEGORIA As Integer
    NA = 0
    PRINCIPAL = 1
    SECUNDARIO = 2
  End Enum
  Public Function init() As Result
    Try


      App_path = My.Application.Info.DirectoryPath
      If App_path.Contains("SourceCode") Then
        Dim tmop As String = App_path.Substring(0, App_path.IndexOf("SourceCode"))
        App_path = IO.Path.Combine(tmop, "work")
      End If

      'App_path = "c:\repositorio\personal\smallAdmin\work\"
      'Database'
      DB_path = IO.Path.Combine(App_path, NameDB)
      If IO.File.Exists(DB_path) = False Then
        MsgBox("Database missing")
      End If
      DB_SLocal_ConnectionString = GetAccessConectionStringDBS(DB_path)

      If g_debug Then
        g_Today = New Date(2020, 12, 31)
      Else
        g_Today = Today
      End If

      'LIB COMMON
      SetFecha(g_Today)
      'BKP FOLDER
      BKPDB_path = IO.Path.Combine(App_path, bkp_Folder)
      If Not IO.Directory.Exists(BKPDB_path) Then
        IO.Directory.CreateDirectory(BKPDB_path)
      End If
      Dim vresult As Result = bkpDatabase()
      If vresult <> Result.OK Then Return vresult

      'CONFIG FOLDER
      CONFIG_PATH = IO.Path.Combine(App_path, CONFIG_FOLDER)
      If Not IO.Directory.Exists(CONFIG_PATH) Then
        MsgBox("No existe carpeta config, No se puede continuar")
        Return Result.NOK
      End If

      'MODEL_PATH
      MODEL_PATH = IO.Path.Combine(App_path, MODEL_FOLDER)
      If Not IO.Directory.Exists(MODEL_PATH) Then
        MsgBox("No existe carpeta model, No se puede continuar")
        Return Result.NOK
      End If

      'TEMP FOLDER
      TEMP_PATH = IO.Path.Combine(App_path, TEMP_FOLDER)
      If Not IO.Directory.Exists(TEMP_PATH) Then
        IO.Directory.CreateDirectory(TEMP_PATH)
      End If

      'EXPORT FOLDER
      Dim Folder As String = String.Empty
      If LoadExportFolder(Folder) = Result.OK Then
        EXPORT_PATH = Folder
      Else
        EXPORT_PATH = IO.Path.Combine(App_path, EXPORT_FOLDER)
        If Not IO.Directory.Exists(EXPORT_PATH) Then
          IO.Directory.CreateDirectory(EXPORT_PATH)
        End If
      End If

      'IMPORT_PATH
      Folder = String.Empty
      If LoadImportFolder(Folder) = Result.OK Then
        IMPORT_PATH = Folder
      Else
        IMPORT_PATH = IO.Path.Combine(App_path, IMPORT_FOLDER)
        If Not IO.Directory.Exists(IMPORT_PATH) Then
          IO.Directory.CreateDirectory(IMPORT_PATH)
        End If
      End If

      CargarTipoPago(g_TipoPago)
      CargarCuotas(g_Cuotas)
      

      Call ActualizarCuotasVencidas()

      Return Result.OK
    Catch ex As Exception
      MsgBox(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Private Function GetAccessConectionStringDBS(ByVal vPathDB As String) As String
    Try

      Return libDB.clsAcceso.GetConectionString_MAccess(vPathDB, dbpw)

    Catch ex As Exception
      Print_msg(ex.Message)
      Return ""
    End Try
  End Function

  Public Function GetVersion() As String
    Try
      Return String.Format("Version:{0}.{1}.{2}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build)
    Catch ex As Exception
      Print_msg(ex.Message)
      Return "Version:--"
    End Try
  End Function

  Private Function bkpDatabase() As Result
    Try
      Dim name As String = GetHoy.ToString("dd") & ".bk"
      IO.File.Copy(DB_path, IO.Path.Combine(BKPDB_path, name), True)
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.NOK
    End Try
  End Function

  Public Function GuardarTipoPago(ByRef rListTipoListaPago As List(Of manDB.clsTipoPago)) As Result

    Try
      MsgBox("FALTA CARGAR PARAMETROS!")
      Return Result.NOK
      Dim Fila As Integer
      Dim objResult As Result

      Fila = FreeFile()

      If rListTipoListaPago Is Nothing Then
        rListTipoListaPago = New List(Of manDB.clsTipoPago)
      End If

      Try
        FileOpen(Fila, IO.Path.Combine(CONFIG_PATH, "TipoPagos.inf"), OpenMode.Output)
        Dim auxstr As String = ""

        auxstr = rListTipoListaPago.Count.ToString
        WriteLine(Fila, auxstr)
        For i = 0 To rListTipoListaPago.Count - 1
          auxstr = rListTipoListaPago(i).Nombre
          WriteLine(Fila, auxstr)
          auxstr = CInt(rListTipoListaPago(i).PermiteCuotas).ToString
          WriteLine(Fila, auxstr)
          auxstr = CStr(rListTipoListaPago(i).GuidTipo.ToString)
          WriteLine(Fila, auxstr)
        Next
        objResult = Result.OK

      Catch ex As Exception
        Print_msg(ex.Message)
        objResult = Result.ErrorEx
      Finally
        FileClose(Fila)
      End Try

      Return objResult

    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try


  End Function

  Public Function CargarTipoPago(ByRef rListTipoPago As List(Of manDB.clsTipoPago), Optional ByVal ShowMessage As Boolean = False) As Result

    Try
      Dim objResult As Result
      Dim Fila As Integer
      Fila = FreeFile()

      If rListTipoPago Is Nothing Then
        rListTipoPago = New List(Of manDB.clsTipoPago)
      Else
        rListTipoPago.Clear()
      End If

      Try

        FileOpen(Fila, IO.Path.Combine(CONFIG_PATH, "TipoPagos.inf"), OpenMode.Input)
        Dim auxstr As String = ""
        Dim auxTipoPago As manDB.clsTipoPago

        Input(Fila, auxstr)

        objResult = Result.OK
        For i = 0 To Val(auxstr) - 1
          Try
            auxTipoPago = New manDB.clsTipoPago
            Input(Fila, auxstr)
            auxTipoPago.Nombre = auxstr
            Input(Fila, auxstr)
            Dim aux As Integer = CInt(auxstr)
            If aux <= 0 Then
              auxTipoPago.PermiteCuotas = False
            Else
              auxTipoPago.PermiteCuotas = True
            End If
            Input(Fila, auxstr)
            auxTipoPago.NombreCodigo1 = auxstr
            Input(Fila, auxstr)
            auxTipoPago.NombreCodigo2 = auxstr
            Input(Fila, auxstr)
            auxTipoPago.NombreCodigo3 = auxstr
            Input(Fila, auxstr)
            auxTipoPago.NombreCodigo4 = auxstr
            Input(Fila, auxstr)
            auxTipoPago.GuidTipo = New Guid(auxstr)
            rListTipoPago.Add(auxTipoPago)
          Catch ex As Exception
            objResult = Result.ErrorEx
            Exit For
          End Try
        Next


      Catch ex As Exception
        Print_msg(ex.Message)
        Return Result.ErrorEx

      Finally
        FileClose(Fila)

        If objResult <> Result.OK Then
          If ShowMessage = True Then
            MsgBox("_EL_ARCHIVO_NO_FUE_CARGADO_CORRECTAMENTE", MsgBoxStyle.Information)
          End If


        End If


      End Try

      Return objResult

    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try

  End Function

  Public Function GuardarCuotas(ByRef rListCuotas As List(Of clsCuota)) As Result

    Try

      Dim Fila As Integer
      Dim objResult As Result

      Fila = FreeFile()

      If rListCuotas Is Nothing Then
        rListCuotas = New List(Of clsCuota)
      End If

      Try
        FileOpen(Fila, IO.Path.Combine(CONFIG_PATH, "Cuotas.inf"), OpenMode.Output)
        Dim auxstr As String = ""

        auxstr = rListCuotas.Count.ToString
        WriteLine(Fila, auxstr)
        For i = 0 To rListCuotas.Count - 1
          auxstr = rListCuotas(i).Nombre
          WriteLine(Fila, auxstr)
          auxstr = CStr(rListCuotas(i).GuidCuota.ToString)
          WriteLine(Fila, auxstr)
          auxstr = rListCuotas(i).Cantidad.ToString
          WriteLine(Fila, auxstr)
        Next
        objResult = Result.OK

      Catch ex As Exception
        Print_msg(ex.Message)
        objResult = Result.ErrorEx
      Finally
        FileClose(Fila)
      End Try

      Return objResult

    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try


  End Function

  Public Function CargarCuotas(ByRef rListCuotas As List(Of clsCuota), Optional ByVal ShowMessage As Boolean = False) As Result

    Try
      Dim objResult As Result
      Dim Fila As Integer
      Fila = FreeFile()

      If rListCuotas Is Nothing Then
        rListCuotas = New List(Of clsCuota)
      Else
        rListCuotas.Clear()
      End If

      Try

        FileOpen(Fila, IO.Path.Combine(CONFIG_PATH, "Cuotas.inf"), OpenMode.Input)
        Dim auxstr As String = ""
        Dim auxTipoPago As clsCuota

        Input(Fila, auxstr)

        objResult = Result.OK
        For i = 0 To Val(auxstr) - 1
          Try
            auxTipoPago = New clsCuota
            Input(Fila, auxstr)
            auxTipoPago.Nombre = auxstr
            Input(Fila, auxstr)
            auxTipoPago.GuidCuota = New Guid(auxstr)
            Input(Fila, auxstr)
            auxTipoPago.Cantidad = CInt(auxstr)
            rListCuotas.Add(auxTipoPago)
          Catch ex As Exception
            objResult = Result.ErrorEx
            Exit For
          End Try
        Next


      Catch ex As Exception
        Print_msg(ex.Message)
        Return Result.ErrorEx

      Finally
        FileClose(Fila)

        If objResult <> Result.OK Then
          If ShowMessage = True Then
            MsgBox("_EL_ARCHIVO_NO_FUE_CARGADO_CORRECTAMENTE", MsgBoxStyle.Information)
          End If


        End If


      End Try

      Return objResult

    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try

  End Function

  Public Function LoadExportFolder(ByRef rPath As String) As Result
    Try
      Dim lineas As New List(Of String)
      Dim vResult As Result = Load(IO.Path.Combine(CONFIG_PATH, "options.dat"), lineas)
      If vResult <> Result.OK Then Return Result.NOK
      If lineas(1).Trim Is Nothing Then Return Result.NOK
      If Not IO.Directory.Exists(lineas(1)) Then Return Result.NOK
      rPath = lineas(1).Trim
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

  Public Function LoadImportFolder(ByRef rPath As String) As Result
    Try
      Dim lineas As New List(Of String)
      Dim vResult As Result = Load(IO.Path.Combine(CONFIG_PATH, "options.dat"), lineas)
      If vResult <> Result.OK Then Return Result.NOK
      If lineas(2).Trim Is Nothing Then Return Result.NOK
      If Not IO.Directory.Exists(lineas(2)) Then Return Result.NOK
      rPath = lineas(2).Trim
      Return Result.OK
    Catch ex As Exception
      Print_msg(ex.Message)
      Return Result.ErrorEx
    End Try
  End Function

 



End Module
