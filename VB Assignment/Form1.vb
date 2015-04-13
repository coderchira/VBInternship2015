Public Class Form1
    Dim CompleteProductList As List(Of Product)
    Dim updatedList As List(Of Product)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Disable all the buttons and filters
        btnSearch.Enabled = False
        fltrByBrand.Enabled = False
        fltrByColor.Enabled = False
        btnRemoveFltr.Enabled = False
        'Fill the ProductList
        CompleteProductList = ProductsList.MyProductList()
        'Set visibility of product details listbox to false
        lstBxProdDetails.Visible = False

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        lblError.Text = ""
        lstBoxProductNames.Items.Clear()
        lstBxProdDetails.Items.Clear()
        'Enable the Search button
        btnSearch.Enabled = True
        'Disable the remove filter button
        btnRemoveFltr.Enabled = False
        'Clear the items in filter and disable the filters
        fltrByBrand.Items.Clear()
        fltrByColor.Items.Clear()
        fltrByBrand.Enabled = False
        fltrByColor.Enabled = False

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Clear items of filters whenever a fresh search is perfomed
        fltrByBrand.Items.Clear()
        fltrByColor.Items.Clear()

        'Declare and store the searched text in a variable
        Dim ProdNameSearched As String
        ProdNameSearched = txtSearch.Text

        'Compare the text searched with product items
        For Each prodItem In CompleteProductList
            If prodItem.Name.ToLower.Contains(ProdNameSearched.ToLower()) Or
                prodItem.Brand.ToLower.Contains(ProdNameSearched.ToLower()) Or
                prodItem.Color.ToLower.Contains(ProdNameSearched.ToLower()) Then
                lstBoxProductNames.Items.Add(prodItem)
                lstBoxProductNames.ValueMember = "Name"

                'Filter by Brand
                If Not fltrByBrand.Items.Contains(prodItem.Brand) Then
                    fltrByBrand.Items.Add(prodItem.Brand)
                    fltrByBrand.Enabled = True
                End If

                'Filter by Color
                If Not fltrByColor.Items.Contains(prodItem.Color) Then
                    fltrByColor.Items.Add(prodItem.Color)
                    fltrByColor.Enabled = True
                End If
            End If
        Next
        'Display the error message when the product searched for is not found
        If (lstBoxProductNames.Items.Count) = 0 Then
            lblError.Text = "Sorry, Product you searched for could not be found"
            lblError.ForeColor = Color.Blue
        End If
        btnSearch.Enabled = False
    End Sub

    'Display the product details in second listbox
    Private Sub lstBoxProductNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxProductNames.SelectedIndexChanged
        lstBxProdDetails.Visible = True
        lstBxProdDetails.Items.Clear()
        lstBxProdDetails.Items.Add(lstBoxProductNames.SelectedItem.Name)
        lstBxProdDetails.Items.Add(lstBoxProductNames.SelectedItem.Brand)
        lstBxProdDetails.Items.Add(lstBoxProductNames.SelectedItem.Color)
    End Sub

    'Display the results for filtered brand name
    Private Sub fltrBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fltrByBrand.SelectedIndexChanged
        updatedList = New List(Of Product)
        'Check the value of selected filter item
        If Not fltrByBrand.SelectedItem Is Nothing Then
            For Each item In CompleteProductList
                'Equate the brand and color of the selected item with the product brand and color
                If item.Brand = (fltrByBrand.SelectedItem) Or
                    item.Color = (fltrByColor.SelectedItem) Then
                    If updatedList.Count = 0 Then
                        'Add the item only if count of current items in list is zero
                        updatedList.Add(item)
                    ElseIf Not updatedList.Contains(item) Then
                        'Add item if the updated list doesn't contain the item already
                        updatedList.Add(item)
                    Else
                        Debug.WriteLine("Item " & item.Name & " already added")
                    End If
                End If
            Next
            lstBoxProductNames.Items.Clear()
            lstBxProdDetails.Items.Clear()
            'Display the updated list in the listbox
            For Each item In updatedList
                lstBoxProductNames.Items.Add(item)
                lstBoxProductNames.ValueMember = "Name"
            Next
        End If
        'Enable the Remove Filter button
        btnRemoveFltr.Enabled = True
    End Sub

    'Display the results for filtered color name
    Private Sub fltrByColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fltrByColor.SelectedIndexChanged
        updatedList = New List(Of Product)
        'Check the value of selected filter item
        If Not fltrByColor.SelectedItem Is Nothing Then
            For Each item In CompleteProductList
                'Equate the brand and color of the selected item with the product brand and color
                If item.Color = (fltrByColor.SelectedItem) Or
                    item.Brand = (fltrByBrand.SelectedItem) Then
                    If updatedList.Count = 0 Then
                        'Add the item only if count of current items in list is zero
                        updatedList.Add(item)
                    ElseIf Not updatedList.Contains(item) Then
                        'Add item if the updated list doesn't contain the item already
                        updatedList.Add(item)
                    Else
                        Debug.WriteLine("Item " & item.Name & " already added")
                    End If
                End If
            Next
            lstBoxProductNames.Items.Clear()
            lstBxProdDetails.Items.Clear()
            'Display the updated list in the listbox
            For Each item In updatedList
                lstBoxProductNames.Items.Add(item)
                lstBoxProductNames.ValueMember = "Name"
            Next
        End If
        'Enable the Remove Filter button
        btnRemoveFltr.Enabled = True
    End Sub

    Private Sub btnRemoveFltr_Click(sender As Object, e As EventArgs) Handles btnRemoveFltr.Click
        lstBoxProductNames.Items.Clear()
        lstBxProdDetails.Items.Clear()
        lstBxProdDetails.Visible = False
        fltrByBrand.Text = "Filter by Brand"
        fltrByColor.Text = "Filter by Color"
        'Set the search result equivalent to original result
        btnSearch_Click(sender, e)
    End Sub
End Class
