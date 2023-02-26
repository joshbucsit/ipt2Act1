Imports System.Data.OleDb
Module Module1
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\josh\3B-2ndSem\IPT-2\Activities\ipt2Act1\ipt2Act1\bin\Debug\Database2.mdb")

    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function
End Module
