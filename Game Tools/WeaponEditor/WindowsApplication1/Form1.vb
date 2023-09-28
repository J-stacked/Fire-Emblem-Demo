Public Class Form1
    Public Class Item 'define needed types for items
        Public Property itemName As String
        Public Property itemType As Integer
        Public Property itemImage As String
        Public Property itemDurability As Integer
        Public Property weaponType As Integer
        Public Property itemRange As Integer
        Public Property itemMight As Integer
        Public Property itemHit As Integer
        Public Property itemCrit As Integer
        Public Property itemWeight As Integer
        Public Property itemBaseHeal As Integer
        Public Property itemHPRestore As Integer
    End Class

    Public itemArray As New List(Of Item) 'define list
    Public itemIteration As Integer = 0
    Public itemObject As New Item
    Public arrayInts(6) As Integer
    Public arrayString(6) As String

    Private Sub initObject()
        With itemObject
            .itemName = " "
            .itemType = 0
            .itemImage = " "
            .itemDurability = 0
            .weaponType = 0
            .itemRange = 0
            .itemMight = 0
            .itemHit = 0
            .itemCrit = 0
            .itemWeight = 0
            .itemBaseHeal = 0
            .itemHPRestore = 0
        End With
    End Sub

    Private Sub printObjectData()
        With itemObject
            Console.WriteLine(.itemName)
            Console.WriteLine(.itemType)
            Console.WriteLine(.itemImage)
            Console.WriteLine(.itemDurability)
            Console.WriteLine(.weaponType)
            Console.WriteLine(.itemRange)
            Console.WriteLine(.itemMight)
            Console.WriteLine(.itemHit)
            Console.WriteLine(.itemCrit)
            Console.WriteLine(.itemWeight)
            Console.WriteLine(.itemBaseHeal)
            Console.WriteLine(.itemHPRestore)
        End With
    End Sub

    Private Sub SaveCurrentData()
        'add code to write back to the file here
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String
        Dim fileReader As System.IO.StreamReader
        Dim currentLine As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Text files (*.txt*)|*.txt*|Text files (*.txt*)|*.txt*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then ' what to do if file is valid
            strFileName = fd.FileName
            fileReader = My.Computer.FileSystem.OpenTextFileReader(strFileName)
            Try
                currentLine = fileReader.ReadLine()
                Do Until (currentLine = "****FILE_END****")
                    currentLine = fileReader.ReadLine()
                    Console.WriteLine(currentLine)
                    If (currentLine = "**Item_Start") Then
                        currentLine = fileReader.ReadLine()
                        dropItem.Items.Add(currentLine) 'add item to drop down list
                        itemObject = New Item()
                        initObject()
                        itemObject.itemName = currentLine 'assign value in the format "0 iron sword"
                        itemObject.itemType = fileReader.ReadLine() 'assign item type as next read line
                        itemObject.itemImage = fileReader.ReadLine() 'assign image file
                        fileReader.ReadLine() 'skip one line
                        itemObject.itemDurability = fileReader.ReadLine()
                        If (itemObject.itemType = 0) Then
                            itemObject.weaponType = fileReader.ReadLine()
                        End If
                        arrayString = fileReader.ReadLine().Split(" ")
                        For index = 0 To arrayString.GetUpperBound(0)
                            arrayInts(index) = CInt(arrayString(index))
                        Next
                        If (itemObject.itemType = 0) Then                'weapons
                            Console.WriteLine("Weapon!")
                            itemObject.itemRange = arrayInts(0)
                            itemObject.itemMight = arrayInts(1)
                            itemObject.itemHit = arrayInts(2)
                            itemObject.itemCrit = arrayInts(3)
                            itemObject.itemWeight = arrayInts(4)
                        ElseIf (itemObject.itemType = 1) Then            'staves
                            Console.WriteLine("Stave!!")
                            itemObject.itemRange = arrayInts(0)
                            itemObject.itemBaseHeal = arrayInts(1)
                        Else                                             'consumables
                            Console.WriteLine("Consumable!")
                            itemObject.itemHPRestore = arrayInts(0)
                        End If
                        itemArray.Add(itemObject)
                        printObjectData()
                    End If
                Loop
            Catch ex As Exception
                MsgBox("Bruh exception thrown")
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'add code to save item file
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "PNG Files (*.png*)|*.png*|PNG Files (*.png*)|*.png*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Panel1.BackgroundImage = New Bitmap(strFileName)
            Console.WriteLine(strFileName)
            arrayString = strFileName.Split("\")
            itemArray(dropItem.SelectedIndex).itemImage = arrayString(arrayString.GetUpperBound(0) - 1) + "\" + arrayString(arrayString.GetUpperBound(0))
        End If
    End Sub

    Private Sub btnNewItem_Click(sender As Object, e As EventArgs) Handles btnNewItem.Click
        If (txtName.Text.Length > 0) Then
            dropItem.Items.Add(dropItem.Items.Count.ToString + " " + txtName.Text)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dropType.Items.Add("Sword") 'weapon type 0
        dropType.Items.Add("Lance") '1
        dropType.Items.Add("Axe") '2
        dropType.Items.Add("Bow") '3
        dropType.Items.Add("Light Magic") '4
        dropType.Items.Add("Anima Magic") '5
        dropType.Items.Add("Dark Magic") '6
        dropType.Items.Add("Stave") 'item type 1 (index 7)
        dropType.Items.Add("Consumable") 'item type 2 (index 8)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'add code to delete currently selected item from array
    End Sub

    Private Sub updateItem()
        With itemArray(dropItem.SelectedIndex)
            .itemName = txtName.Text
            .itemType = CInt(txtWeaponType.Text)
            .itemImage = .itemImage 'change once images display correctly
            .itemDurability = CInt(txtDurability.Text)
            If (.itemType = 0) Then
                .weaponType = dropType.SelectedIndex
            End If
            .itemRange = CInt(txtRange.Text)
            .itemMight = CInt(txtMight.Text)
            .itemHit = CInt(txtHit.Text)
            .itemCrit = CInt(txtCrit.Text)
            .itemWeight = CInt(txtWeight.Text)
            .itemBaseHeal = CInt(txtHealing.Text)
            .itemHPRestore = CInt(txtRestore.Text)
        End With
    End Sub
    Private Sub dropItem_Click(sender As Object, e As EventArgs) Handles dropItem.Click
        Try
            updateItem()
        Catch ex As Exception
            Console.WriteLine("value doesn't exist yet")
        End Try
    End Sub
    Private Sub dropItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropItem.SelectedIndexChanged
        ' Console.WriteLine(CStr(dropItem.SelectedIndex) + " Yo wtf" + )

        txtName.Text = itemArray(dropItem.SelectedIndex).itemName
        If (itemArray(dropItem.SelectedIndex).itemType = 0) Then
            dropType.SelectedIndex = itemArray(dropItem.SelectedIndex).weaponType
        ElseIf (itemArray(dropItem.SelectedIndex).itemType = 1) Then
            dropType.SelectedIndex = 7
        Else
            dropType.SelectedIndex = 8
        End If
        txtDurability.Text = itemArray(dropItem.SelectedIndex).itemDurability
        txtWeaponType.Text = itemArray(dropItem.SelectedIndex).itemType
        txtRange.Text = itemArray(dropItem.SelectedIndex).itemRange
        txtMight.Text = itemArray(dropItem.SelectedIndex).itemMight
        txtHit.Text = itemArray(dropItem.SelectedIndex).itemHit
        txtCrit.Text = itemArray(dropItem.SelectedIndex).itemCrit
        txtWeight.Text = itemArray(dropItem.SelectedIndex).itemWeight
        txtHealing.Text = itemArray(dropItem.SelectedIndex).itemBaseHeal
        txtRestore.Text = itemArray(dropItem.SelectedIndex).itemHPRestore

        'Panel1.BackgroundImage = New Bitmap("E:\Fire Emblem Recreation\Java (Eclipse version)\Resources\" + itemArray(dropItem.SelectedIndex).itemImage)
    End Sub
End Class
