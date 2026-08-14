Imports System.Data.SqlClient
Imports System.IO
Module Module1
    Dim mynew As String
    Public cuname As String

    Public ConStr As String = "Data Source=(LocalDB)\MSSQLLocalDB; INITIAL CATALOG=StudioTaher;INTEGRATED SECURITY=True;"
    Public NewConn As New SqlConnection(ConStr)

    'Public Sub mycreatefolderone()

    '    If My.Settings.mycreatefo = True Then Return
    '    If Directory.Exists(Application.StartupPath & "\" & "mystudio") Then Return
    '    Directory.CreateDirectory(Application.StartupPath & "\" & "mystudio")
    '    My.Settings.mycreatefo = True
    '    My.Settings.Save()
    'End Sub
    'Public Sub createfolderday()
    '    mynew = Date.Today.ToString("yyyy-MM-dd")
    '    If Directory.Exists(Application.StartupPath & "mystudio" & "\" & mynew) Then Return
    '    Directory.CreateDirectory(Application.StartupPath & "mystudio" & "\" & mynew)
    '    My.Settings.mycreatechak = (Application.StartupPath & "mystudio" & "\" & mynew)
    '    My.Settings.Save()
    'End Sub

    '  الاسكي الى التحویل
    Function Str2Int(ByVal InStrng As Object) As String
        Dim StrLn As Integer
        Dim Cntr As Integer
        Dim NewStr As String

        Str2Int = ""
        StrLn = Len(InStrng)
        If StrLn = 0 Then Exit Function
        NewStr = ""
        For Cntr = 1 To StrLn
            Select Case Mid(InStrng, Cntr, 1)
                Case "0" To "z"
                    NewStr = NewStr & Asc(Mid(InStrng, Cntr, 1))
            End Select
        Next Cntr
        Str2Int = NewStr
    End Function

    '  التشویش دالة
    Public Function Obfuscate(ByVal origText As String) As String
        Dim textBytes As Byte() =
        System.Text.Encoding.Unicode.GetBytes(origText)
        For counter As Integer = 0 To textBytes.Length - 1
            If (textBytes(counter) > 31) And (textBytes(counter) < 127) Then
                textBytes(counter) += CByte(counter Mod 31 + 1)
                If (textBytes(counter) > 126) Then
                    textBytes(counter) -= CByte(95)
                End If
            End If
        Next counter
        Return System.Text.Encoding.Unicode.GetChars(textBytes)
    End Function
End Module
