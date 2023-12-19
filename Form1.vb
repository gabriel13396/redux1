Public Class Form1
    ' Defines the class product with two properties known as name and quantity (string and integer) 
    Class Product
        Public Property Name As String
        Public Property Quantity As Integer
    End Class
    ' Declares the inventory as a certain product
    Private inventory As New List(Of Product)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub submitbutton_Click(sender As Object, e As EventArgs) Handles submitbutton.Click
        ' defines the value of productname and quantity
        Dim productName As String = txtProductName.Text
        Dim quantity As Integer

        If Integer.TryParse(txtQuantity.Text, quantity) Then
            If quantity >= 0 Then
                ' creates a new product 
                Dim newProduct As New Product With {.Name = productName, .Quantity = quantity}

                ' inserts the specified products into the text box
                inventory.Add(newProduct)

                ' clears the text boxes if needed
                txtProductName.Clear()
                txtQuantity.Clear()

                ' Display the updated inventory in the ListBox
                UpdateInventoryListBox()
                ' shows an error if the value given is in the negatives
            Else
                MessageBox.Show("Please enter a non-negative quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' shows an error if the value is not valid (ex. letters instead of numbers)
            MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub UpdateInventoryListBox()
        ' clears the inventory when the button is clicked
        lstInventory.Items.Clear()
        For Each product In inventory
            ' adds the quantity to the specified product
            lstInventory.Items.Add($"{product.Name} - {product.Quantity}")
        Next
    End Sub
    ' label for instructions
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtProductName.TextChanged

    End Sub
    ' label for instructions
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click



    End Sub
    'label for instructions
    Private Sub txtSearchProductName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProductName.TextChanged

    End Sub
    ' makes a new instance for the button used to search for specific products
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' defines the buttons and the text boxes needed to find each product and quantity
        Dim searchProductName As String = txtSearchProductName.Text
        Dim foundProduct As Product = inventory.Find(Function(p) p.Name = searchProductName)
        ' if the product is found, then show on a messagebox
        If foundProduct IsNot Nothing Then
            MessageBox.Show($"Product Name: {foundProduct.Name}{vbCrLf}Quantity: {foundProduct.Quantity}", "Found Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' if not, then show an error saying that the product was not found
        Else
            MessageBox.Show("Product was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub addStock_Click(sender As Object, e As EventArgs) Handles addStock.Click
        ' defines the quantity to add integer, while using the same productname textbox
        Dim productName As String = txtProductName.Text
        Dim quantityToAdd As Integer
        ' if it is greater than 0, then it will attempt to find the product needed ij the inventory list
        If Integer.TryParse(txtQuantityUpdate.Text, quantityToAdd) Then
            If quantityToAdd > 0 Then
                ' finds the product in the inventory list
                Dim productToUpdate As Product = inventory.Find(Function(p) p.Name = productName)
                ' used to update the stock or quantity
                If productToUpdate IsNot Nothing Then
                    productToUpdate.Quantity += quantityToAdd
                    MessageBox.Show($"Stock added. New Quantity: {productToUpdate.Quantity}", "The Stock is now Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' if not found, show error saying it is not found
                    MessageBox.Show("Product was not found.", "Product was Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                ' clears the text boxes as needed in the list
                txtProductName.Clear()
                txtQuantityUpdate.Clear()

                ' updates the inventory display/list
                UpdateInventoryListBox()
            Else
                ' error if you do not add a quantity that is positive
                MessageBox.Show("Please enter a positive quantity to add.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' shows another error if the quantity is not a valid number
            MessageBox.Show("Please enter a valid quantity to add.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lowstock_Click(sender As Object, e As EventArgs) Handles lowstock.Click
        ' creates a list for the low stock products
        Dim lowStockProducts As New List(Of Product)

        ' shows the inventory list 
        For Each product In inventory
            If product.Quantity < 5 Then
                lowStockProducts.Add(product)
            End If
        Next

        ' displays/shows the list of the low stocked products
        If lowStockProducts.Count > 0 Then
            Dim lowStockMessage As String = "Low Stock Products:" & vbCrLf
            For Each lowStockProduct In lowStockProducts
                lowStockMessage &= $"{lowStockProduct.Name} - {lowStockProduct.Quantity}" & vbCrLf
            Next
            ' creates a messagebox saying which products are considered to be low stocked
            MessageBox.Show(lowStockMessage, "Low Stock Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' shows if none of the products are less than 5 (aka low stocked)
            MessageBox.Show("Currently no low stock products found.", "Low Stock Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ViewInventory_Click(sender As Object, e As EventArgs) Handles ViewInventory.Click
        ' Create a message to display the complete inventory
        Dim inventoryMessage As String = "Complete Inventory:" & vbCrLf
        For Each product In inventory
            inventoryMessage &= $"{product.Name} - {product.Quantity}" & vbCrLf
        Next

        ' Display the complete inventory
        If inventory.Count > 0 Then
            MessageBox.Show(inventoryMessage, "View All Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Inventory is currently empty.", "Currently in the Inventory:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class

