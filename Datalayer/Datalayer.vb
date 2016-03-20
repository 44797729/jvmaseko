Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Reflection 
Imports System.Data.SqlClient
Imports System.Configuration


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
        Dim folder As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\")

        'Dim folder = "C:\unisa\ICT3611\ASSIGNMENT 1\Assignment1\Datalayer\Flatfiles\"
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

        Using tfp As New TextFieldParser(filename)
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

    'In this Assignment we are going to use MS Access to store Data. 
#Region "Assignment 2"


#Region "Connection objects"
    ReadOnly strCon As [String] = ConfigurationManager.ConnectionStrings("GoAml").ConnectionString
    Private cmd As SqlCommand
    Private con As SqlConnection
    Private da As SqlDataAdapter
#End Region

#Region "Athletes"
    Public Function Report_AC_DESC(AC_DESC As String) As DataTable
        con = New SqlConnection(strCon)
        cmd = New SqlCommand()
        cmd.CommandType = System.Data.CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cmd.Connection = con
        cmd.CommandText = "[motovate].[spx_Search_AC_DESC]"
        cmd.Parameters.Add("@AC_DESC", SqlDbType.VarChar).Value = AC_DESC

        Dim dt As New DataTable()
        da = New SqlDataAdapter()
        da.SelectCommand = cmd


        Try
            con.Open()
            da.Fill(dt)
        Catch ex As SqlException
            Throw ex
        Finally
            con.Close()
        End Try
        Return dt

    End Function
    Public Function CheckUserExistance(_sUSERNAME As [String]) As Integer
        Me.con = New SqlConnection(Me.strCon)

        Me.cmd = New SqlCommand()

        Me.cmd.CommandText = "sp_CheckUserExistance"

        Me.cmd.CommandType = CommandType.StoredProcedure

        Me.cmd.Connection = Me.con

        Me.cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = _sUSERNAME

        Me.cmd.Parameters.Add("@RESULTS", SqlDbType.Int)

        Me.cmd.Parameters("@RESULTS").Direction = ParameterDirection.Output

        Dim isValid As Integer = 0

        Try
            Me.con.Open()

            Me.cmd.ExecuteNonQuery()

            isValid = CInt(Me.cmd.Parameters("@RESULTS").Value)
        Catch ex As SqlException
            Throw ex
        Finally
            Me.con.Close()
        End Try
        Return isValid
    End Function
    Public Function AuthonticateUser(sUsername As [String], sPassword As [String]) As Integer
        Me.con = New SqlConnection(Me.strCon)

        Me.cmd = New SqlCommand()

        Me.cmd.CommandText = "sp_Authonticateuser"

        Me.cmd.CommandType = CommandType.StoredProcedure

        Me.cmd.Connection = Me.con

        Me.cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = sUsername

        Me.cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = sPassword

        Me.cmd.Parameters.Add("@RESULTS", SqlDbType.Int)

        Me.cmd.Parameters("@RESULTS").Direction = ParameterDirection.Output

        Dim isValid As Integer = 0


        Try
            Me.con.Open()

            Me.cmd.ExecuteNonQuery()

        Catch ex As SqlException
            Throw ex
        Finally
            Me.con.Close()
        End Try
        Return isValid
    End Function

#End Region

#Region "Events"

#End Region



 

#End Region

End Class
