Imports System.Data.OleDb
Imports System.Data

Module MdlDeklarasi
    Public objcmd As OleDbCommand
    Public objda As OleDbDataAdapter
    Public objdr As OleDbDataReader
    Public strsql As String
    Public objds As New DataSet
    Public objdt As New DataTable
End Module

Namespace CLS
    Public Class clsDatabaseConnection
        Dim strsql = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbuascovidkelurahan.accdb")
        Dim Connect As New OleDbConnection(strsql)

        Public Function Open() As OleDbConnection
            Connect.Open()
            Return Connect
        End Function

        Public Function Close() As OleDbConnection
            Connect.Close()
            Return Connect
        End Function
    End Class
End Namespace
