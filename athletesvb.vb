Imports System.IO
Imports System.Reflection

Public Class athletesvb
    Dim table As DataTable
    Dim Selected_athlete_id As String

    Private Sub athletesvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get latest data 
        GetData()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        'table = New DataTable() 
        ' Create four typed columns in the DataTable.

        If (table Is Nothing) Then
            table = New DataTable()
            If (table.Columns.Count = 0) Then
                table.Columns.Add("Athleteid", GetType(String))
                table.Columns.Add("AthleteFirstname", GetType(String))
                table.Columns.Add("AthleteSurname", GetType(String))
                table.Columns.Add("AthleteAddress", GetType(String))
                table.Columns.Add("AthleteGender", GetType(String))
                table.Columns.Add("AthleteDateofBirth", GetType(DateTime))
                table.Columns.Add("Datejoined", GetType(DateTime))
                table.Columns.Add("amountdue", GetType(String))
                table.Columns.Add("Membershipnumber", GetType(String))

            End If

        Else
            If (table.Columns.Count = 0) Then
                table.Columns.Add("Athleteid", GetType(String))
                table.Columns.Add("AthleteFirstname", GetType(String))
                table.Columns.Add("AthleteSurname", GetType(String))
                table.Columns.Add("AthleteAddress", GetType(String))
                table.Columns.Add("AthleteGender", GetType(String))
                table.Columns.Add("AthleteDateofBirth", GetType(DateTime))
                table.Columns.Add("Datejoined", GetType(DateTime))
                table.Columns.Add("amountdue", GetType(String))
                table.Columns.Add("Membershipnumber", GetType(String))

            End If

        End If
        ' Add five rows with those columns filled in the DataTable.

        Dim gender As String

        If (rbtMale.Checked) Then
            gender = "Male"
        Else
            gender = "Female"
        End If


        Dim business As New BusinessLayer.BusinessLayer()

        Dim membershipnumber As String = GenerateMembershipNumber(dpdateofbirth.Text.Replace("/", ""))

        'Add the newly insert record into a Table 
        table.Rows.Add(System.Guid.NewGuid.ToString(), txtfirstname.Text.Replace(",", " "), txtsurname.Text.Replace(",", " "), txtaddress.Text.Replace(",", " "), gender, Convert.ToDateTime(dpdateofbirth.Text.Replace(",", " ")), Convert.ToDateTime(datejoined.Text.Replace(",", " ")), txtamountdue.Text.Replace(",", " "), membershipnumber.Replace(",", " "))

        'Get the Data in the file so that it wont be overriten 

        Try
            Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\Athletes.csv")

            business.Convert_DataTable_To_CSV(table, Paths, ",")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

            business = Nothing

        End Try

        'Get latest data 
        GetData()
    End Sub
    Private Sub GetData()

        Dim business As New BusinessLayer.BusinessLayer()
        Try
            Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\Athletes.csv")

            table = business.ConvertCsvToDatatableExtended(Paths)

            DataGridView1.DataSource = table

        Catch ex As Exception

        End Try

    End Sub
    Dim IsUpdate As Integer

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim gender As String
        IsUpdate = 1

        If (rbtMale.Checked) Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        If (Selected_athlete_id <> String.Empty) Then

            For Each row As DataRow In table.Rows
                If (Selected_athlete_id.ToString() = row.Item("Athleteid").ToString()) Then
                    table.Rows.Remove(row)
                    table.Rows.Add(Selected_athlete_id, txtfirstname.Text.Replace(",", " "), txtsurname.Text.Replace(",", " "), txtaddress.Text.Replace(",", " "), gender, Convert.ToDateTime(dpdateofbirth.Text.Replace(",", " ")), Convert.ToDateTime(datejoined.Text.Replace(",", " ")), txtamountdue.Text.Replace(",", " "), txtmembershipnumber.Text.Replace(",", " "))

                    table.AcceptChanges()

                    Dim business As New BusinessLayer.BusinessLayer()
                    Try

                        Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\Athletes.csv")

                        business.Convert_DataTable_To_CSV(table, Paths, ",")
                        GetData()
                        Selected_athlete_id = String.Empty

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        business = Nothing
                        IsUpdate = 0
                    End Try

                    MessageBox.Show("Successfully Updated")
                    Exit Sub

                End If
            Next
        Else
            MessageBox.Show("Please select the Record on the Grid")
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        'dt.Rows(rowId)("id").ToString()
        For Each row As DataRow In table.Rows
            If (Selected_athlete_id.ToString() = row.Item("Athleteid").ToString()) Then
                table.Rows.Remove(row)
                table.AcceptChanges()
                Dim business As New BusinessLayer.BusinessLayer()

                Dim Paths As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Flatfiles\Athletes.csv")

                business.Convert_DataTable_To_CSV(table, Paths, ",")
                business = Nothing
                GetData()
                Selected_athlete_id = String.Empty

                MessageBox.Show("Successfully Deleted")
                Exit Sub

            End If
        Next

    End Sub
    Private Function GenerateMembershipNumber(Dateofbith As String) As String

        Dim Final13characters As String = Now.Year().ToString().Substring(2, 2) + Dateofbith + RandomNumber(999).ToString()

        Return Final13characters + Checkdigit(Final13characters)


    End Function

    Private Function Checkdigit(MembershipNumber As String) As String

        Dim intresults As Integer

        For Each str As String In MembershipNumber

            intresults = intresults + Convert.ToInt32(str)
        Next

        intresults = intresults / 10

        Return intresults

    End Function


    Public Function RandomNumber(ByVal n As Integer) As Integer
        'initialize random number generator
        Dim r As New Random(System.DateTime.Now.Millisecond)
        Return r.Next(1, n)
    End Function
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        If (IsUpdate <> 1) Then

            Dim dgv As DataGridView = TryCast(sender, DataGridView)
            If dgv IsNot Nothing AndAlso dgv.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = dgv.SelectedRows(0)
                If row IsNot Nothing Then
                    txtfirstname.Text = row.Cells()("AthleteFirstname").Value.ToString()
                    txtsurname.Text = row.Cells()("AthleteSurname").Value.ToString()
                    txtaddress.Text = row.Cells()("AthleteAddress").Value.ToString()
                    dpdateofbirth.Text = row.Cells()("AthleteDateofBirth").Value.ToString()
                    datejoined.Text = row.Cells()("Datejoined").Value.ToString()
                    txtamountdue.Text = row.Cells()("amountdue").Value.ToString()
                    txtmembershipnumber.Text = row.Cells()("Membershipnumber").Value.ToString()


                    Selected_athlete_id = row.Cells()("Athleteid").Value.ToString()


                End If
            End If

        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub rbtMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMale.CheckedChanged

    End Sub

    Private Sub rbtfemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtfemale.CheckedChanged

    End Sub

    Private Sub dpdateofbirth_ValueChanged(sender As Object, e As EventArgs) Handles dpdateofbirth.ValueChanged

    End Sub

End Class