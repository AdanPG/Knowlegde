Attribute VB_Name = "Módulo1"
Private Sub Workbook_Open()

Application.ScreenUpdating = False


On Error GoTo err:
   
    Set cnn4 = New ADODB.connection
    Dim rst As ADODB.Recordset
    
    cnn4.Provider = "Microsoft.ACE.OLEDB.12.0"
    cnn4.ConnectionString = "Data Source=" & ThisWorkbook.FullName & ";Extended Properties=""Excel 12.0;HDR=Yes;"""
    cnn4.Open
    
    Set cmm4 = New ADODB.Command
    Set cmm41 = New ADODB.Command
    Set cmm42 = New ADODB.Command
    Set cmm43 = New ADODB.Command
    
    'diferentes contratos'
    cmm4.CommandType = adCmdText
    cmm4.ActiveConnection = cnn4
    cmm4.CommandText = "select count(*) from (select distinct Column4 from [base$] where Column8='FAM 2021')"
       
    'diferentes contratistas'
    cmm41.CommandType = adCmdText
    cmm41.ActiveConnection = cnn4
    cmm41.CommandText = "select count(*) from (select distinct Column20 from [base$] where Column8='FAM 2021')"
    
    'contratos sin finiquitar'
    cmm42.CommandType = adCmdText
    cmm42.ActiveConnection = cnn4
    cmm42.CommandText = "select count(*) from " _
    & "(select distinct column4 from [base$] where column8='FAM 2021' " _
    & "and column4 not in (select Column4 from[base$] where Column8='FAM 2021' and Column28 like '%-F'))"
    
    ''
    cmm43.CommandType = adCmdText
    cmm43.ActiveConnection = cnn4
    cmm43.CommandText = "select count(*) from (select distinct column20 from [base$] where column39='COSTOS' or column39='SUPERVISION' AND column8='FAM 2021' " _
    & "and column4 not in (select Column4 from[base$] where Column8='FAM 2021' and Column28 like '%-F'))"
       
       
    Set rst = cmm4.Execute
    Sheets("control").Range("e8").Value = rst.Fields(0).Value
    
    Set rst = cmm41.Execute
    Sheets("control").Range("e9").Value = rst.Fields(0).Value
    
    Set rst = cmm42.Execute
    Sheets("control").Range("e10").Value = rst.Fields(0).Value
    
    Set rst = cmm43.Execute
    Sheets("control").Range("e11").Value = rst.Fields(0).Value
    
    Application.ScreenUpdating = True


    MsgBox ("Datos actualizados")
    
    cnn4.Close
    Set cnn4 = Nothing
    Set RS4 = Nothing
    Exit Sub

err:
    MsgBox (err)
End Sub

