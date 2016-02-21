Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Datalayer

    Public Sub Convert_DataTable_To_CSV(ByVal dtable As DataTable, ByVal pathFilename As String, ByVal sepChar As String)
        Dim writer As System.IO.StreamWriter
        Try
            writer = New System.IO.StreamWriter(pathFilename)

            Dim _sep As String = ""
            Dim builder As New System.Text.StringBuilder
            For Each col As DataColumn In dtable.Columns
                builder.Append(_sep).Append(col.ColumnName)
                _sep = sepChar
            Next
            writer.WriteLine(builder.ToString())

            For Each row As DataRow In dtable.Rows
                _sep = ""
                builder = New System.Text.StringBuilder

                For Each col As DataColumn In dtable.Columns
                    builder.Append(_sep).Append(row(col.ColumnName))
                    _sep = sepChar
                Next
                writer.WriteLine(builder.ToString())
            Next
        Catch ex As Exception

        Finally
            If Not writer Is Nothing Then writer.Close()
        End Try
    End Sub

    Public Function Getdata()
        Return ConvertCsvToDatatable()
    End Function


    Public Function ConvertCsvToDatatable()

        Dim folder = "C:\unisa\ICT3611\ASSIGNMENT 1\Assignment1\Datalayer\Flatfiles\"
        Dim cnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & folder & ";Extended Properties=""text;HDR=No;FMT=Delimited"";"

        Dim dssample As New DataTable

        Using adp As New OleDbDataAdapter("select * from [Customer.csv]", cnStr)
            adp.Fill(dssample)
        End Using
        Return dssample
    End Function
    Public Function ConvertCsvToDatatableExtended(filename As String) As DataTable
        '   Dim fileName = "C:\unisa\ICT3611\ASSIGNMENT 1\Assignment1\Datalayer\Flatfiles\Customer.csv"
        Dim delimiters As String = ","
        Dim firstRowContainsFieldNames As Boolean = True
        Dim result As New DataTable()

        Using tfp As New TextFieldParser(fileName)
            tfp.SetDelimiters(delimiters)

            ' Get Some Column Names
            If Not tfp.EndOfData Then
                Dim fields As String() = tfp.ReadFields()

                For i As Integer = 0 To fields.Count() - 1
                    If firstRowContainsFieldNames Then
                        result.Columns.Add(fields(i))
                    Else
                        result.Columns.Add("Col" + i)
                    End If
                Next

                ' If first line is data then add it
                If Not firstRowContainsFieldNames Then
                    result.Rows.Add(fields)
                End If
            End If

            ' Get Remaining Rows
            While Not tfp.EndOfData
                result.Rows.Add(tfp.ReadFields())
            End While
        End Using

        Return result
    End Function
End Class
