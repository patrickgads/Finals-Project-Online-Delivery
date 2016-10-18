Class MainWindow
    Private Sub form2(sender As Object, e As EventArgs) Handles form1.Activated
        Const PRICE_SUPER_CHEESY_BURGER As Double = 160
        Const PRICE_CLASSIC_BURGER As Double = 100
        Const PRICE_DOUBLE_CLASSIC_BURGER As Double = 140
        Const PRICE_ULTIMATE_BURGER As Double = 160

        Dim subtotal As Double = 0
        Dim total As Double = 0
    End Sub

    Private Sub form1_Load(sender As Object, e As RoutedEventArgs) Handles form1.Loaded
        InitializeVariables()
        ClearTheCustomerSelections()
        ClearTheReceipt()
    End Sub

    Private Sub InitializeVariables()
        Dim subtotal As Double = 0
        Dim total As Double = 0

        subtotal = 0
        total = 0
    End Sub

    Private Sub ClearTheCustomerSelections()
        rbSCB.IsChecked = True
        ckEC.IsChecked = False
        ckP.IsChecked = False
        ck_EB.IsChecked = False

        rbSB.IsChecked = True
        ckIT.IsChecked = False
    End Sub

    Private Sub ClearTheReceipt()
        lstOrders.Items.Clear()
        lstTotal.Items.Clear()
    End Sub

    Private Sub ComputeCurrentSelection()
        Const PRICE_SUPER_CHEESY_BURGER As Double = 160
        Const PRICE_CLASSIC_BURGER As Double = 100
        Const PRICE_DOUBLE_CLASSIC_BURGER As Double = 140
        Const PRICE_ULTIMATE_BURGER As Double = 160
        Const PRICE_EXTRA_CHEESE As Double = 20
        Const PRICE_PICKLES As Double = 25
        Const PRICE_EXTRA_BACON As Double = 30

        Const PRICE_STEAKBUR As Double = 180
        Const PRICE_STEAKBURJ As Double = 150
        Const PRICE_CHICK As Double = 170
        Const PRICE_PORK As Double = 170
        Const PRICE_ICEDTEA As Double = 35
        Const PRICE_FOURS As Double = 30
        Const PRICE_SODAS As Double = 30

        Dim subtotal As Double = 0
        Dim total As Double = 0

        If rbSCB.IsChecked Then
            subtotal += PRICE_SUPER_CHEESY_BURGER
            Dim SuperCheesyBurger As String
            PRICE_SUPER_CHEESY_BURGER.ToString(("C") & "Super Cheesy Burger")
            lstOrders.Items.Add(SuperCheesyBurger)
        End If

        If rbCB.IsChecked Then
            subtotal += PRICE_CLASSIC_BURGER
            Dim ClassicBurger As String
            PRICE_CLASSIC_BURGER.ToString(("C") & "Classic Burger")
            lstOrders.Items.Add(ClassicBurger)
        End If

        If rbDCB.IsChecked Then
            subtotal += PRICE_DOUBLE_CLASSIC_BURGER
            Dim DoubleClassicBurger As String
            PRICE_DOUBLE_CLASSIC_BURGER.ToString(("C") & "Double Classic Burger")
            lstOrders.Items.Add(DoubleClassicBurger)
        End If

        If rbUB.IsChecked Then
            subtotal += PRICE_ULTIMATE_BURGER
            Dim UltimateBurger As String
            PRICE_ULTIMATE_BURGER.ToString(("C") & "Ultimate Burger")
            lstOrders.Items.Add(UltimateBurger)
        End If

        If ckEC.IsChecked Then
            subtotal += PRICE_EXTRA_CHEESE
            Dim ExtraCheese As String
            PRICE_EXTRA_CHEESE.ToString(("C") & "Extra Cheese")
            lstOrders.Items.Add(ExtraCheese)
        End If

        If ckP.IsChecked Then
            subtotal += PRICE_PICKLES
            Dim Pickles As String
            PRICE_PICKLES.ToString(("C") & "Pickles")
            lstOrders.Items.Add(Pickles)
        End If

        If ck_EB.IsChecked Then
            subtotal += PRICE_EXTRA_BACON
            Dim ExtraBacon As String
            PRICE_EXTRA_BACON.ToString(("C") & "Extra Bacon")
            lstOrders.Items.Add(ExtraBacon)
        End If
        ' -------------------------------------------------------------------------------------
        If rbSB.IsChecked Then
            subtotal += PRICE_STEAKBUR
            Dim SteakBurrito As String
            PRICE_STEAKBUR.ToString(("C") & "Steak Burrito")
            lstOrders.Items.Add(SteakBurrito)
        End If

        If rbSBJ.IsChecked Then
            subtotal += PRICE_STEAKBURJ
            Dim SteakBurJ As String
            PRICE_STEAKBURJ.ToString(("C") & "Steak Burrito Jr.")
            lstOrders.Items.Add(SteakBurJ)
        End If

        If rbCB.IsChecked Then
            subtotal += PRICE_CHICK
            Dim ChickenBurrito As String
            PRICE_CHICK.ToString(("C") & "Chicken Burrito")
            lstOrders.Items.Add(ChickenBurrito)
        End If

        If rbPB.IsChecked Then
            subtotal += PRICE_PORK
            Dim PorkBur As String
            PRICE_PORK.ToString(("C") & "Pork Burrito")
            lstOrders.Items.Add(PorkBur)
        End If

        If ckIT.IsChecked Then
            subtotal += PRICE_ICEDTEA
            Dim IcedTea As String
            PRICE_ICEDTEA.ToString(("C") & "Iced Tea")
            lstOrders.Items.Add(IcedTea)
        End If

        If ckFS.IsChecked Then
            subtotal += PRICE_FOURS
            Dim FourSeason As String
            PRICE_FOURS.ToString(("C") & "Four Season")
            lstOrders.Items.Add(FourSeason)
        End If

        If ckS.IsChecked Then
            subtotal += PRICE_SODAS
            Dim Sodas As String
            PRICE_SODAS.ToString(("C") & "Sodas")
            lstOrders.Items.Add(Sodas)
        End If

    End Sub

    Private Sub UpdateTotal()
        Const PRICE_SUPER_CHEESY_BURGER As Double = 160
        Const PRICE_CLASSIC_BURGER As Double = 100
        Const PRICE_DOUBLE_CLASSIC_BURGER As Double = 140
        Const PRICE_ULTIMATE_BURGER As Double = 160
        Const PRICE_EXTRA_CHEESE As Double = 20
        Const PRICE_PICKLES As Double = 25
        Const PRICE_EXTRA_BACON As Double = 30

        Const PRICE_STEAKBUR As Double = 180
        Const PRICE_STEAKBURJ As Double = 150
        Const PRICE_CHICK As Double = 170
        Const PRICE_PORK As Double = 170
        Const PRICE_ICEDTEA As Double = 35
        Const PRICE_FOURS As Double = 30
        Const PRICE_SODAS As Double = 30

        Dim subtotal As Double = 0
        Dim total As Double = 0

        If rbSCB.IsChecked Then
            subtotal += PRICE_SUPER_CHEESY_BURGER
            Dim SuperCheesyBurger As String =
            PRICE_SUPER_CHEESY_BURGER.ToString(("C") & "Super Cheesy Burger")
            lstOrders.Items.Add(SuperCheesyBurger)
        End If

        If rbCB.IsChecked Then
            subtotal += PRICE_CLASSIC_BURGER
            Dim ClassicBurger As String =
            PRICE_CLASSIC_BURGER.ToString(("C") & "Classic Burger")
            lstOrders.Items.Add(ClassicBurger)
        End If

        If rbDCB.IsChecked Then
            subtotal += PRICE_DOUBLE_CLASSIC_BURGER
            Dim DoubleClassicBurger As String =
            PRICE_DOUBLE_CLASSIC_BURGER.ToString(("C") & "Double Classic Burger")
            lstOrders.Items.Add(DoubleClassicBurger)
        End If

        If rbUB.IsChecked Then
            subtotal += PRICE_ULTIMATE_BURGER
            Dim UltimateBurger As String =
            PRICE_ULTIMATE_BURGER.ToString(("C") & "Ultimate Burger")
            lstOrders.Items.Add(UltimateBurger)
        End If

        If ckEC.IsChecked Then
            subtotal += PRICE_EXTRA_CHEESE
            Dim ExtraCheese As String =
            PRICE_EXTRA_CHEESE.ToString(("C") & "Extra Cheese")
            lstOrders.Items.Add(ExtraCheese)
        End If

        If ckP.IsChecked Then
            subtotal += PRICE_PICKLES
            Dim Pickles As String =
            PRICE_PICKLES.ToString(("C") & "Pickles")
            lstOrders.Items.Add(Pickles)
        End If

        If ck_EB.IsChecked Then
            subtotal += PRICE_EXTRA_BACON
            Dim ExtraBacon As String =
            PRICE_EXTRA_BACON.ToString(("C") & "Extra Bacon")
            lstOrders.Items.Add(ExtraBacon)
        End If
        ' -------------------------------------------------------------------------------------
        If rbSB.IsChecked Then
            subtotal += PRICE_STEAKBUR
            Dim SteakBurrito As String =
            PRICE_STEAKBUR.ToString(("C") & "Steak Burrito")
            lstOrders.Items.Add(SteakBurrito)
        End If

        If rbSBJ.IsChecked Then
            subtotal += PRICE_STEAKBURJ
            Dim SteakBurJ As String =
            PRICE_STEAKBURJ.ToString(("C") & "Steak Burrito Jr.")
            lstOrders.Items.Add(SteakBurJ)
        End If

        If rbCB.IsChecked Then
            subtotal += PRICE_CHICK
            Dim ChickenBurrito As String =
            PRICE_CHICK.ToString(("C") & "Chicken Burrito")
            lstOrders.Items.Add(ChickenBurrito)
        End If

        If rbPB.IsChecked Then
            subtotal += PRICE_PORK
            Dim PorkBur As String =
            PRICE_PORK.ToString(("C") & "Pork Burrito")
            lstOrders.Items.Add(PorkBur)
        End If

        If ckIT.IsChecked Then
            subtotal += PRICE_ICEDTEA
            Dim IcedTea As String =
            PRICE_ICEDTEA.ToString(("C") & "Iced Tea")
            lstOrders.Items.Add(IcedTea)
        End If

        If ckFS.IsChecked Then
            subtotal += PRICE_FOURS
            Dim FourSeason As String =
            PRICE_FOURS.ToString(("C") & "Four Season")
            lstOrders.Items.Add(FourSeason)
        End If

        If ckS.IsChecked Then
            subtotal += PRICE_SODAS
            Dim Sodas As String =
            PRICE_SODAS.ToString(("C") & "Sodas")
            lstOrders.Items.Add(Sodas)
        End If


        lstTotal.Items.Clear()
        lstTotal.Items.Add("SUB TOTAL = " & subtotal.ToString("C"))
        total = subtotal
        lstTotal.Items.Add("TOTAL = " & total.ToString("C"))
        lstOrders.Items.Add("-----------------------------")
    End Sub

    Private Sub btnATC_Click(sender As Object, e As RoutedEventArgs) Handles btnATC.Click
        Const PRICE_SUPER_CHEESY_BURGER As Double = 160
        Const PRICE_CLASSIC_BURGER As Double = 100
        Const PRICE_DOUBLE_CLASSIC_BURGER As Double = 140
        Const PRICE_ULTIMATE_BURGER As Double = 160
        Const PRICE_EXTRA_CHEESE As Double = 20
        Const PRICE_PICKLES As Double = 25
        Const PRICE_EXTRA_BACON As Double = 30

        Const PRICE_STEAKBUR As Double = 180
        Const PRICE_STEAKBURJ As Double = 150
        Const PRICE_CHICK As Double = 170
        Const PRICE_PORK As Double = 170
        Const PRICE_ICEDTEA As Double = 35
        Const PRICE_FOURS As Double = 30
        Const PRICE_SODAS As Double = 30

        Dim subtotal As Double = 0
        Dim total As Double = 0

        ComputeCurrentSelection()
        UpdateTotal()
        ClearTheCustomerSelections()
    End Sub

    Private Sub btnClr_Click(sender As Object, e As RoutedEventArgs) Handles btnClr.Click
        InitializeVariables()
        ClearTheCustomerSelections()
        ClearTheReceipt()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As RoutedEventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
