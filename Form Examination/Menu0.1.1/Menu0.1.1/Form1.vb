Public Class Form1
    Dim quaspag, quabur, quapizz, quafries, quacoke, quatea As Integer


    Private totalwithoutfee As Integer
    Private downpaymentAm As Integer
    Private Function CalculateTotalPrice() As Integer
        Dim burgerprice As Integer = 50
        Dim spagprice As Integer = 100
        Dim pizzaprice As Integer = 500
        Dim friesprice As Integer = 40
        Dim cokeprice As Integer = 30
        Dim teaprice As Integer = 30

        Dim totalSum As Integer = 0

        If chkbur.Checked Then
            totalSum += quabur * burgerprice
        Else
            quabur = 0
        End If

        If chkspag.Checked Then
            totalSum += quaspag * spagprice
        Else
            quaspag = 0
        End If

        If chkpizz.Checked Then
            totalSum += quapizz * pizzaprice
        Else
            quapizz = 0
        End If

        If chkfries.Checked Then
            totalSum += quafries * friesprice
        Else
            quafries = 0
        End If

        If chkcoke.Checked Then
            totalSum += quacoke * cokeprice
        Else
            quacoke = 0
        End If

        If chktea.Checked Then
            totalSum += quatea * teaprice
        Else
            quatea = 0
        End If

        Return totalSum
    End Function

    Private Sub CalculateAndDisplayTotalPrice()
        Dim totalSum As Integer = CalculateTotalPrice()
        Dim monthlyFee As Integer = 0

        If radcalcu.Checked Then
            monthlyFee = CInt(totalSum * 0.2)
            txtchange.Text = monthlyFee.ToString()
        End If
    End Sub

    Private Sub chkspag_CheckedChanged(sender As Object, e As EventArgs) Handles chkspag.CheckedChanged
        If chkspag.Checked Then
            txtspag.Text = 1
            btnspag1.Enabled = True
            btnspag2.Enabled = True
        Else
            txtspag.Clear()
            quaspag = 0
            btnspag1.Enabled = False
            btnspag2.Enabled = False
        End If
    End Sub

    Private Sub btnspag1_Click(sender As Object, e As EventArgs) Handles btnspag1.Click
        quaspag = quaspag - 1
        txtspag.Text = quaspag

        If quaspag < 1 Then
            chkspag.Checked = False
        End If
    End Sub

    Private Sub btnspag2_Click(sender As Object, e As EventArgs) Handles btnspag2.Click
        quaspag = quaspag + 1
        txtspag.Text = quaspag
    End Sub

    Private Sub chkbur_CheckedChanged(sender As Object, e As EventArgs) Handles chkbur.CheckedChanged
        If chkbur.Checked Then
            txtbur.Text = 1
            btnbur1.Enabled = True
            btnbur2.Enabled = True
        Else
            txtbur.Clear()
            quabur = 0
            btnbur1.Enabled = False
            btnbur2.Enabled = False
        End If
    End Sub

    Private Sub btnbur1_Click(sender As Object, e As EventArgs) Handles btnbur1.Click
        quabur = quabur - 1
        txtbur.Text = quabur

        If quabur < 1 Then
            chkbur.Checked = False
        End If
    End Sub

    Private Sub btnbur2_Click(sender As Object, e As EventArgs) Handles btnbur2.Click
        quabur = quabur + 1
        txtbur.Text = quabur
    End Sub

    Private Sub chkpizz_CheckedChanged(sender As Object, e As EventArgs) Handles chkpizz.CheckedChanged
        If chkpizz.Checked Then
            txtpizz.Text = 1
            btnpizz1.Enabled = True
            btnpizz2.Enabled = True
        Else
            txtpizz.Clear()
            quapizz = 0
            btnpizz1.Enabled = False
            btnpizz2.Enabled = False
        End If
    End Sub

    Private Sub btnpizz1_Click(sender As Object, e As EventArgs) Handles btnpizz1.Click
        quapizz = quapizz - 1
        txtpizz.Text = quapizz

        If quapizz < 1 Then
            chkpizz.Checked = False
        End If
    End Sub

    Private Sub btnpizz2_Click(sender As Object, e As EventArgs) Handles btnpizz2.Click
        quapizz = quapizz + 1
        txtpizz.Text = quapizz
    End Sub

    Private Sub chkfries_CheckedChanged(sender As Object, e As EventArgs) Handles chkfries.CheckedChanged
        If chkfries.Checked Then
            txtfries.Text = 1
            btnfries1.Enabled = True
            btnfries2.Enabled = True
        Else
            txtfries.Clear()
            quafries = 0
            btnfries1.Enabled = False
            btnfries2.Enabled = False
        End If
    End Sub

    Private Sub btnfries1_Click(sender As Object, e As EventArgs) Handles btnfries1.Click
        quafries = quafries - 1
        txtfries.Text = quafries

        If quafries < 1 Then
            chkfries.Checked = False
        End If
    End Sub

    Private Sub btnfries2_Click(sender As Object, e As EventArgs) Handles btnfries2.Click
        quafries = quafries + 1
        txtfries.Text = quafries
    End Sub

    Private Sub chkcoke_CheckedChanged(sender As Object, e As EventArgs) Handles chkcoke.CheckedChanged
        If chkcoke.Checked Then
            txtcoke.Text = 1
            btncoke1.Enabled = True
            btncoke2.Enabled = True
        Else
            txtcoke.Clear()
            quacoke = 0
            btncoke1.Enabled = False
            btncoke2.Enabled = False
        End If
    End Sub

    Private Sub btncoke1_Click(sender As Object, e As EventArgs) Handles btncoke1.Click
        quacoke = quacoke - 1
        txtcoke.Text = quacoke

        If quacoke < 1 Then
            chkcoke.Checked = False
        End If
    End Sub

    Private Sub btncoke2_Click(sender As Object, e As EventArgs) Handles btncoke2.Click
        quacoke = quacoke + 1
        txtcoke.Text = quacoke
    End Sub

    Private Sub chktea_CheckedChanged(sender As Object, e As EventArgs) Handles chktea.CheckedChanged
        If chktea.Checked Then
            txttea.Text = 1
            btntea1.Enabled = True
            btntea2.Enabled = True
        Else
            txttea.Clear()
            quatea = 0
            btntea1.Enabled = False
            btntea2.Enabled = False
        End If
    End Sub

    Private Sub btntea1_Click(sender As Object, e As EventArgs) Handles btntea1.Click
        quatea = quatea - 1
        txttea.Text = quatea

        If quatea < 1 Then
            chktea.Checked = False
        End If
    End Sub

    Private Sub btntea2_Click(sender As Object, e As EventArgs) Handles btntea2.Click
        quatea = quatea + 1
        txttea.Text = quatea
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Dim Answer As DialogResult

        Answer = MessageBox.Show("Bibili ka ba talaga o nagsasayang ka ng oras?", "CLEAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Answer = DialogResult.Yes Then
            txtbur.Clear()
            txtspag.Clear()
            txtfries.Clear()
            txtpizz.Clear()
            txtcoke.Clear()
            txttea.Clear()
            txttotal.Clear()
            txtpay.Clear()
            txtchange.Clear()
            chkbur.Checked() = False
            chkspag.Checked() = False
            chkpizz.Checked() = False
            chkfries.Checked() = False
            chkcoke.Checked() = False
            chktea.Checked() = False
            radcalcu.Checked = False
            radcash.Checked = False
            btncalcu.Enabled = False
            lbpay.Text = "Payment"
            lbchange.Text = "Change"
        End If

    End Sub

    Private cashAm As Integer
    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        If radcash.Checked Then
            Dim totalSum As Integer = CalculateTotalPrice()
            txttotal.Text = totalSum.ToString()
            btnpay.Enabled = True
        End If
    End Sub

    Private Sub radcash_CheckedChanged(sender As Object, e As EventArgs) Handles radcash.CheckedChanged
        If radcash.Checked Then
            lbpay.Text = "Payment"
            lbchange.Text = "Change"
            btncalcu.Enabled = False
            txtpay.Clear()
            txtchange.Clear()
            btnsub.Enabled = True
        End If
    End Sub

    Private Sub radcalcu_CheckedChanged(sender As Object, e As EventArgs) Handles radcalcu.CheckedChanged
        If radcalcu.Checked Then
            lbpay.Text = "Downpayment"
            lbchange.Text = "Monthly Fee"
            btncalcu.Enabled = True
            txtpay.Clear()
            txtchange.Clear()
            txttotal.Clear()
            btnsub.Enabled() = False
            btnpay.Enabled() = True
        Else
            lbpay.Text = "Cash"
            lbchange.Text = "Change"
            btncalcu.Enabled = False
        End If
    End Sub

    Private Sub btncalcu_Click(sender As Object, e As EventArgs) Handles btncalcu.Click
        totalwithoutfee = CalculateTotalPrice()

        If radcalcu.Checked Then
            Dim downpayment As Integer
            If Integer.TryParse(txtpay.Text, downpayment) Then
                downpaymentAm = downpayment
                Dim remainingtotal As Integer = totalwithoutfee - downpayment
                Dim monthlyfee As Integer = remainingtotal / 3
                txttotal.Text = totalwithoutfee.ToString()
                txtchange.Text = monthlyfee.ToString()
            Else
                MessageBox.Show("Pay your amount of downpayment firt.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Dim totalSum As Integer = CalculateTotalPrice()
            txttotal.Text = totalSum.ToString()
            txtchange.Text = "0"
        End If
    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        Dim totalSum As Integer
        Dim monthlyfee As Integer

        If radcash.Checked Then
            totalSum = CInt(txttotal.Text)

            If Integer.TryParse(txtpay.Text, cashAm) Then
                If cashAm < totalSum Then
                    MessageBox.Show("Not enough amount, Sorry :'(", "Payment Unsuccessful.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim change As Integer = cashAm - totalSum
                    txtchange.Text = change.ToString()
                    MessageBox.Show("Payment record successfully." & vbCrLf &
                                    "Cash Amount: PHP " & cashAm.ToString() & vbCrLf &
                                    "Total Amount: PHP " & totalSum.ToString() & vbCrLf &
                                    "Change: PHP " & change.ToString(), "Payment Info.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Pay first before we record your order.Thank You :).", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf radcalcu.Checked Then
            If downpaymentAm > 0 Then
                totalSum = totalwithoutfee
                monthlyfee = CInt(txtchange.Text)

                MessageBox.Show("Installment Success" & vbCrLf &
                                "Total Amount: PHP " & totalSum.ToString() & vbCrLf &
                                "Monthly Fee: PHP " & monthlyfee.ToString(), "Payment Info.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Input your downpayment to proceed recoding of your order. Thank You :).", "Invalid Info.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


End Class
