Public Class BusinessLayer


    Public Sub Convert_DataTable_To_CSV(ByVal dtable As DataTable, ByVal pathFilename As String, ByVal sepChar As String)

        Dim obj As New Datalayer.Datalayer()
        Try
            obj.Convert_DataTable_To_CSV(dtable, pathFilename, sepChar) 

        Catch ex As Exception

        End Try


    End Sub


    Public Function ConvertCsvToDatatable(ByVal dtable As DataTable, ByVal pathFilename As String, ByVal sepChar As String)

        Dim obj As New Datalayer.Datalayer()
        Try
            Return obj.ConvertCsvToDatatable(dtable, pathFilename, sepChar)

        Catch ex As Exception

        End Try
    End Function

    Public Function Getdata()
        Dim obj As New Datalayer.Datalayer()
        Try
            Return obj.Getdata()

        Catch ex As Exception

        End Try
    End Function
 


    Public Function ConvertCsvToDatatableExtended(Filename As String) As DataTable
        Dim obj As New Datalayer.Datalayer()
        Try
            Return obj.ConvertCsvToDatatableExtended(Filename)

        Catch ex As Exception
        Finally
            obj = Nothing
        End Try
    End Function


End Class
