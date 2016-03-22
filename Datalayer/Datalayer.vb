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

        Using adp As New SqlDataAdapter("select * from [Customer.csv]", cnStr)
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
    Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
  System.Environment.CurrentDirectory & "\AthleteManagement.mdb"
    Private cmdole As OleDbCommand
    Private conole As OleDbConnection
    Private daole As OleDbDataAdapter


#End Region

#Region "Athletes"
    Public Function GetAthlete(AC_DESC As String) As DataTable
        conole = New OleDbConnection(strConnectionString)
        cmdole = New OleDbCommand()
        cmdole.CommandType = System.Data.CommandType.StoredProcedure
        cmdole.CommandTimeout = 0
        cmdole.Connection = conole
        cmdole.CommandText = "select * from Athlete"
        Dim dt As New DataTable()
        daole = New OleDbDataAdapter()
        daole.SelectCommand = cmdole
        Try
            conole.Open()
            daole.Fill(dt)
        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            conole.Close()
        End Try
        Return dt

    End Function



    Public Function AddAthelete(model As AtheleteModel) As Integer
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "INSERT INTO  Athletes values (?,?,?,?,?,?)"

        Me.cmdole.CommandType = CommandType.Text

        Me.cmdole.Connection = Me.conole

        Me.cmdole.Parameters.Add("@Athleteid", SqlDbType.UniqueIdentifier).Value = model.Athleteid

        Me.cmdole.Parameters.Add("@AthleteFirstname", SqlDbType.VarChar).Value = model.AthleteFirstname

        Me.cmdole.Parameters.Add("@AthleteSurname", SqlDbType.VarChar).Value = model.AthleteSurname

        Me.cmdole.Parameters.Add("@AthleteGender", SqlDbType.VarChar).Value = model.AthleteGender

        Me.cmdole.Parameters.Add("@AthleteDateofBirth", SqlDbType.Date).Value = model.AthleteDateofBirth

        Me.cmdole.Parameters.Add("@Athleteid", SqlDbType.Int).Value = model.Athleteid

        Me.cmdole.Parameters.Add("@Datejoined", SqlDbType.Date).Value = model.Datejoined

        Dim isValid As Integer = 0

        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()
        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try
        Return isValid
    End Function
    Public Function UpdateAthelete(_sUSERNAME As [String]) As Integer
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "sp_CheckUserExistance"

        Me.cmdole.CommandType = CommandType.StoredProcedure

        Me.cmdole.Connection = Me.conole

        Me.cmdole.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = _sUSERNAME

        Me.cmdole.Parameters.Add("@RESULTS", SqlDbType.Int)

        Me.cmdole.Parameters("@RESULTS").Direction = ParameterDirection.Output

        Dim isValid As Integer = 0

        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()

            isValid = CInt(Me.cmdole.Parameters("@RESULTS").Value)
        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try
        Return isValid
    End Function
    Public Function DeleteAthlete(sUsername As [String], sPassword As [String]) As Integer
        Me.conole = New OleDbConnection(Me.strConnectionString)

        Me.cmdole = New OleDbCommand()

        Me.cmdole.CommandText = "sp_Authonticateuser"

        Me.cmdole.CommandType = CommandType.StoredProcedure

        Me.cmdole.Connection = Me.conole

        Me.cmdole.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = sUsername

        Me.cmdole.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = sPassword

        Me.cmdole.Parameters.Add("@RESULTS", SqlDbType.Int)

        Me.cmdole.Parameters("@RESULTS").Direction = ParameterDirection.Output

        Dim isValid As Integer = 0


        Try
            Me.conole.Open()

            Me.cmdole.ExecuteNonQuery()

        Catch ex As OleDb.OleDbException
            Throw ex
        Finally
            Me.conole.Close()
        End Try
        Return isValid
    End Function

#End Region

#Region "Events"

#End Region


#End Region

End Class
