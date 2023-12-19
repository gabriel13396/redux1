<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtProductName = New TextBox()
        Label2 = New Label()
        txtQuantity = New TextBox()
        submitbutton = New Button()
        lstInventory = New ListBox()
        txtSearchProductName = New TextBox()
        Label3 = New Label()
        btnSearch = New Button()
        txtQuantityUpdate = New TextBox()
        addStock = New Button()
        sellStock = New Button()
        Label6 = New Label()
        lowstock = New Button()
        Label4 = New Label()
        ViewInventory = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 0
        Label1.Text = "Product Name:"
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(128, 29)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(100, 23)
        txtProductName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 2
        Label2.Text = "Quantity:"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(128, 64)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(100, 23)
        txtQuantity.TabIndex = 3
        ' 
        ' submitbutton
        ' 
        submitbutton.Location = New Point(35, 152)
        submitbutton.Name = "submitbutton"
        submitbutton.Size = New Size(90, 25)
        submitbutton.TabIndex = 4
        submitbutton.Text = "Add Product"
        submitbutton.UseVisualStyleBackColor = True
        ' 
        ' lstInventory
        ' 
        lstInventory.FormattingEnabled = True
        lstInventory.ItemHeight = 15
        lstInventory.Location = New Point(35, 220)
        lstInventory.Name = "lstInventory"
        lstInventory.Size = New Size(120, 94)
        lstInventory.TabIndex = 5
        ' 
        ' txtSearchProductName
        ' 
        txtSearchProductName.Location = New Point(536, 38)
        txtSearchProductName.Name = "txtSearchProductName"
        txtSearchProductName.Size = New Size(100, 23)
        txtSearchProductName.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(413, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 15)
        Label3.TabIndex = 7
        Label3.Text = "Search for a Product:"
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(657, 42)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 8
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtQuantityUpdate
        ' 
        txtQuantityUpdate.Location = New Point(128, 105)
        txtQuantityUpdate.Name = "txtQuantityUpdate"
        txtQuantityUpdate.Size = New Size(100, 23)
        txtQuantityUpdate.TabIndex = 10
        ' 
        ' addStock
        ' 
        addStock.Location = New Point(144, 153)
        addStock.Name = "addStock"
        addStock.Size = New Size(90, 23)
        addStock.TabIndex = 11
        addStock.Text = "Update: Add"
        addStock.UseVisualStyleBackColor = True
        ' 
        ' sellStock
        ' 
        sellStock.Location = New Point(253, 153)
        sellStock.Name = "sellStock"
        sellStock.Size = New Size(90, 23)
        sellStock.TabIndex = 12
        sellStock.Text = "Update: Sell"
        sellStock.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(21, 108)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 15)
        Label6.TabIndex = 15
        Label6.Text = "Quantity Updater:"
        ' 
        ' lowstock
        ' 
        lowstock.Location = New Point(190, 291)
        lowstock.Name = "lowstock"
        lowstock.Size = New Size(75, 23)
        lowstock.TabIndex = 16
        lowstock.Text = "Search"
        lowstock.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(190, 261)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 15)
        Label4.TabIndex = 17
        Label4.Text = "Low Stock Viewer (<5)"
        ' 
        ' ViewInventory
        ' 
        ViewInventory.Location = New Point(413, 291)
        ViewInventory.Name = "ViewInventory"
        ViewInventory.Size = New Size(75, 23)
        ViewInventory.TabIndex = 18
        ViewInventory.Text = "View"
        ViewInventory.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ViewInventory)
        Controls.Add(Label4)
        Controls.Add(lowstock)
        Controls.Add(Label6)
        Controls.Add(sellStock)
        Controls.Add(addStock)
        Controls.Add(txtQuantityUpdate)
        Controls.Add(btnSearch)
        Controls.Add(Label3)
        Controls.Add(txtSearchProductName)
        Controls.Add(lstInventory)
        Controls.Add(submitbutton)
        Controls.Add(txtQuantity)
        Controls.Add(Label2)
        Controls.Add(txtProductName)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents submitbutton As Button
    Friend WithEvents lstInventory As ListBox
    Friend WithEvents txtSearchProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtQuantityUpdate As TextBox
    Friend WithEvents addStock As Button
    Friend WithEvents sellStock As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lowstock As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ViewInventory As Button
End Class
