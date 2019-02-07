Public Class BillingForm

    ' Declare string for printing 
    Dim TextToPrint As String = ""

    'Declare module-level constants.
    Const TAX_RATE_Decimal As Decimal = 0.1D
    Const PREMETIVE_CARE_PRICE_Decimal As Decimal = 415.67D
    Const GENERAL_SURGERY_PRICE_Decimal As Decimal = 390.5D
    Const TREATMENT_PRICE_Decimal As Decimal = 250D
    Const EMERGENCY__PRICE_Decimal As Decimal = 500D
    Const REGULAR_RATE_Decimal As Decimal = 50D

    'Declare module level variables for summary information
    Private SubtotalDecimal, TotalDecimal, GrandTotalDecimal As Decimal
    Private CustomerCountInteger As Integer

    'clear all function
    Private Sub clearall()
        'clears all the textboxes in this form when this function is called
        Animal_NameTextBox.Clear()
        Patient_IDTextBox.Clear()
        The_OwnerTextBox.Clear()
        AddressTextBox.Clear()
        Contact_NumberTextBox.Clear()
        ItemAmountTextBox.Clear()
        SubTotalTextBox.Clear()
        TaxTextBox.Clear()
        TotalTextBox.Clear()
        QuantityTextBox.Clear()
        CashRadioButton.Checked = True
        RegularRadioButton.Checked = True
    End Sub

    Private Sub BillingForm_FormClosed(sender As Object, e As EventArgs) Handles Me.FormClosed
        'call the clearall function to clear all the values
        clearall()
        'show the main form
        MainForm.Show()
    End Sub

    'printing bill function
    Private Sub BillPrintButton_Click(sender As Object, e As EventArgs) Handles BillPrintButton.Click
        'printing the form
        If QuantityTextBox.Text.Trim.Length = 0 Then
            MessageBox.Show("Please make your calculation first then Print", "Calculation not Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim message As DialogResult = MessageBox.Show("Would you like to preview the document first?", "Preview", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If message = DialogResult.Yes Then
                PrintPreviewToolStripMenuItem_Click(sender, e)
            End If
            PrintDialog1.ShowDialog()
        End If
    End Sub

    'clear the text boxes
    Private Sub ClearButton_Click(sender As Object, e As EventArgs)
        RegularRadioButton.Checked = True
        CreditcardRadioButton.Checked = True
        ItemAmountTextBox.Clear()
        With QuantityTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    'clears for new order
    Private Sub NewOrderButton_Click(sender As Object, e As EventArgs) Handles NewOrderButton.Click
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String
        'confirm clear the current order
        MessageString = "Clear the current order figures?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ReturnDialogResult = DialogResult.Yes Then
            ClearButton_Click(sender, e)
            SubTotalTextBox.Clear()
            TaxTextBox.Clear()
            TotalTextBox.Clear()

        End If
    End Sub
    'summary display
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Dim AverageDecimal As Decimal
        Dim MessageString As String

        If TotalDecimal <> 0 Then
            'Make sure last order is counted.
            NewOrderButton_Click(sender, e)
        End If
        If CustomerCountInteger > 0 Then
            'Calculate the average
            AverageDecimal = GrandTotalDecimal / CustomerCountInteger

            'Concatenate the message string
            MessageString = "Number of Orders: " &
                "Total Slaes: " & GrandTotalDecimal.ToString("C") &
                Environment.NewLine & Environment.NewLine &
                "Average Sale: " & AverageDecimal.ToString("C")
            MessageBox.Show(MessageString, "Billing Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageString = "No Sales date to summarize."
            MessageBox.Show(MessageString, "Billing Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'when the form closes, calls clear all function, and opens the main form
    Private Sub BillingColseButton_Click(sender As Object, e As EventArgs) Handles BillingColseButton.Click
        clearall()
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        'call caluclating function
        CalculateButton_Click(sender, e)
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        'calling the summary button
        SummaryButton_Click(sender, e)
    End Sub
    'print preview function
    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'calls bill printing function
    Private Sub PrintToolStripMenuItemPrinter_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItemPrinter.Click
        BillPrintButton_Click(sender, e)
    End Sub

    'closes the billing form
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'calls clear button function
    Private Sub NewOrderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewOrderToolStripMenuItem1.Click
        ClearButton_Click(sender, e)
    End Sub

    'shows the about form
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    'designing the printing document 
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim PrintFont As New Font("Arial", 11)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim BodyFont As New Font("Arial", 10)
        Dim BodyBold As New Font("Arial", 10, FontStyle.Bold)
        Dim AppointmentFont As New Font("Arial", 9, FontStyle.Bold)
        Dim FootFont As New Font("Arial", 8, FontStyle.Italic)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim Column1HorizontalLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = 250
        Dim Column2HorizontalLocationSingle As Single = 250
        Dim PrintLineString As String

        'Printing the name of the company 
        PrintLineString = "Veterinary Clinic Information System"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Blue, Column2HorizontalLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2
        'printing the company address
        PrintLineString = "501 Westminster Avenue"
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Green, Column2HorizontalLocationSingle + 75, VerticalPrintLocationSingle)
        'printing address
        PrintLineString = "Fulton MO, USA - 65251"
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Green, Column2HorizontalLocationSingle + 75, VerticalPrintLocationSingle)
        'printing phone number
        PrintLineString = "(573)-592-9128"
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Green, Column2HorizontalLocationSingle + 100, VerticalPrintLocationSingle)
        'printing email
        PrintLineString = "VeterinaryClinic@animalcare.com"
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Green, Column2HorizontalLocationSingle + 50, VerticalPrintLocationSingle)
        'printing some lines
        VerticalPrintLocationSingle += LineHeightSingle * 2

        'declearing the patient information and the owner information
        Dim owner As String = The_OwnerTextBox.Text
        Dim address As String = AddressTextBox.Text
        Dim patientID As String = Patient_IDTextBox.Text
        Dim PatientName As String = Animal_NameTextBox.Text
        Dim PaymentMethod As String
        If CreditcardRadioButton.Checked = True Then
            PaymentMethod = "Credit"
        ElseIf DebitCardRadioButton.Checked = True Then
            PaymentMethod = "Debit"
        Else
            PaymentMethod = "Cash"
        End If

        Dim phonenumber As String = Contact_NumberTextBox.Text
        Dim todaydate As Date = DateAndTime.Now.ToString

        'Printing owner and Patient Information
        PrintLineString = owner
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, BodyFont, Brushes.Black, Column2HorizontalLocationSingle - 150, VerticalPrintLocationSingle)
        PrintLineString = address
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, BodyFont, Brushes.Black, Column2HorizontalLocationSingle - 150, VerticalPrintLocationSingle)
        PrintLineString = "Patient ID: " + patientID
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle + 300, VerticalPrintLocationSingle)
        PrintLineString = phonenumber
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, BodyFont, Brushes.Black, Column2HorizontalLocationSingle - 150, VerticalPrintLocationSingle)
        PrintLineString = PatientName
        e.Graphics.DrawString(PrintLineString, BodyFont, Brushes.Black, Column2HorizontalLocationSingle + 325, VerticalPrintLocationSingle)
        PrintLineString = todaydate
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, BodyFont, Brushes.Black, Column2HorizontalLocationSingle - 150, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 1.5
        PrintLineString = "Payment Method: "
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, BodyFont, Brushes.Black, Column2HorizontalLocationSingle - 150, VerticalPrintLocationSingle)
        PrintLineString = PaymentMethod
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle - 20, VerticalPrintLocationSingle)

        'printing the heading for the bill
        VerticalPrintLocationSingle += LineHeightSingle
        PrintLineString = "-----------------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle - 150, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        PrintLineString = "Items"
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle - 50, VerticalPrintLocationSingle)
        PrintLineString = "Quantity"
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle + 150, VerticalPrintLocationSingle)
        PrintLineString = "Price"
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle + 350, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        PrintLineString = "-----------------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle - 150, VerticalPrintLocationSingle)

        'Printing the items quantity and the price
        VerticalPrintLocationSingle += LineHeightSingle
        If RegularRadioButton.Checked = True Then
            PrintLineString = "Regular Check-up"
        ElseIf PreventiveCureRadioButton.Checked = True Then
            PrintLineString = "Preventive Cure"
        ElseIf GeneralRadioButton.Checked = True Then
            PrintLineString = "General Surgery"
        ElseIf TreatmentRadioButton.Checked = True Then
            PrintLineString = "Treatment Service"
        ElseIf EmergencyRadioButton.Checked = True Then
            PrintLineString = "Emergency Survice"
        End If
        e.Graphics.DrawString(PrintLineString, BodyFont, Brushes.Black, Column2HorizontalLocationSingle - 50, VerticalPrintLocationSingle)
        PrintLineString = QuantityTextBox.Text
        e.Graphics.DrawString(PrintLineString, BodyFont, Brushes.Black, Column2HorizontalLocationSingle + 150, VerticalPrintLocationSingle)
        PrintLineString = ItemAmountTextBox.Text
        e.Graphics.DrawString(PrintLineString, BodyFont, Brushes.Black, Column2HorizontalLocationSingle + 350, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2
        VerticalPrintLocationSingle += LineHeightSingle * 2
        VerticalPrintLocationSingle += LineHeightSingle * 2
        'subtotal printing
        PrintLineString = "Sub-Total"
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle - 50, VerticalPrintLocationSingle)
        PrintLineString = SubTotalTextBox.Text
        e.Graphics.DrawString(PrintLineString, BodyFont, Brushes.Black, Column2HorizontalLocationSingle + 350, VerticalPrintLocationSingle)

        'subtotal printing
        VerticalPrintLocationSingle += LineHeightSingle
        PrintLineString = "Tax"
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle - 50, VerticalPrintLocationSingle)
        PrintLineString = TaxTextBox.Text
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle + 350, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        PrintLineString = "-----------------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle - 150, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        PrintLineString = "Total"
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle - 50, VerticalPrintLocationSingle)
        PrintLineString = TotalTextBox.Text
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle + 350, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        PrintLineString = "-----------------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(PrintLineString, BodyBold, Brushes.Black, Column2HorizontalLocationSingle - 150, VerticalPrintLocationSingle)

        'Appointment scheduled day and Time
        VerticalPrintLocationSingle += LineHeightSingle
        VerticalPrintLocationSingle += LineHeightSingle
        PrintLineString = "Appointment: "
        e.Graphics.DrawString(PrintLineString, AppointmentFont, Brushes.Black, Column2HorizontalLocationSingle - 50, VerticalPrintLocationSingle)
        PrintLineString = DateLabel.Text + "  at   " + TimeLabel.Text
        e.Graphics.DrawString(PrintLineString, AppointmentFont, Brushes.Blue, Column2HorizontalLocationSingle + 50, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        'Thank you note
        VerticalPrintLocationSingle += LineHeightSingle
        VerticalPrintLocationSingle += LineHeightSingle
        PrintLineString = "Thank you for visiting us! Have a good one. "
        e.Graphics.DrawString(PrintLineString, FootFont, Brushes.Black, Column2HorizontalLocationSingle + 50, VerticalPrintLocationSingle)
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'calculate and display the current amounts and add to totals

        Dim PriceDecimal, TaxDecimal, ItemAmountDecimal As Decimal
        Dim QuantityInteger As Integer

        'Find Price
        If RegularRadioButton.Checked Then
            PriceDecimal = REGULAR_RATE_Decimal
        ElseIf PreventiveCureRadioButton.Checked Then
            PriceDecimal = PREMETIVE_CARE_PRICE_Decimal
        ElseIf GeneralRadioButton.Checked Then
            PriceDecimal = GENERAL_SURGERY_PRICE_Decimal
        ElseIf EmergencyRadioButton.Checked Then
            PriceDecimal = EMERGENCY__PRICE_Decimal
        ElseIf TreatmentRadioButton.Checked Then
            PriceDecimal = TREATMENT_PRICE_Decimal
        End If

        'Calculate extended price and  add to order total

        Try
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)
            ItemAmountDecimal = PriceDecimal * QuantityInteger
            SubtotalDecimal += ItemAmountDecimal
            TaxDecimal = SubtotalDecimal * TAX_RATE_Decimal
            If CreditcardRadioButton.Checked = True Then
                TotalDecimal = (SubtotalDecimal + TaxDecimal) + 2D
            Else
                TotalDecimal = SubtotalDecimal + TaxDecimal
            End If

            ItemAmountTextBox.Text = ItemAmountDecimal.ToString("C")
            SubTotalTextBox.Text = "$" + SubtotalDecimal.ToString("N")
            TaxTextBox.Text = "$" + TaxDecimal.ToString("N")
            TotalTextBox.Text = TotalDecimal.ToString("C")
        Catch QuantityException As FormatException
            MessageBox.Show("Quantity must be numeric.", "Data Entry Error.", MessageBoxButtons.OK, MessageBoxIcon.Information)

            With QuantityTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub
End Class