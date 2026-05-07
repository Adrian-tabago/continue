Public Class FormSearch
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbSearchCategory.Items.Clear()
        cmbSearchCategory.Items.Add("All")
        cmbSearchCategory.Items.Add("Noise")
        cmbSearchCategory.Items.Add("Dispute")
        cmbSearchCategory.Items.Add("Infrastructure")
        cmbSearchCategory.Items.Add("Others")

        cmbSearchCategory.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim nameSearch As String = txtSearchName.Text.ToLower()
        Dim categorySearch As String = cmbSearchCategory.Text.ToLower()

        dgvSearchResults.Rows.Clear()

        For Each row As DataGridViewRow In FormStatus.dataStatus.Rows

            If row.IsNewRow = False Then

                Dim name As String = row.Cells(0).Value.ToString().ToLower()
                Dim category As String = row.Cells(3).Value.ToString().ToLower()

                'DEFAULT: assume match
                Dim isMatch As Boolean = True

                'CHECK NAME
                If nameSearch <> "" Then
                    If name.Contains(nameSearch) = False Then
                        isMatch = False
                    End If
                End If

                'CHECK CATEGORY
                If categorySearch <> "all" And categorySearch <> "" Then
                    If category <> categorySearch Then
                        isMatch = False
                    End If
                End If

                'ADD TO GRID IF MATCHED
                If isMatch = True Then
                    dgvSearchResults.Rows.Add(
                    row.Cells(0).Value,
                    row.Cells(1).Value,
                    row.Cells(2).Value,
                    row.Cells(3).Value,
                    row.Cells(4).Value,
                    row.Cells(5).Value
                )
                End If

            End If

        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click


        txtSearchName.Clear()
        cmbSearchCategory.SelectedIndex = 0
        dgvSearchResults.Rows.Clear()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearchName.TextChanged

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        FormStatus.Show()
        Me.Hide()

    End Sub

    Private Sub cmbSearchCategory_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbSearchCategory_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub
End Class