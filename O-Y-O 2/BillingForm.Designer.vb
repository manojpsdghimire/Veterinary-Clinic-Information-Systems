<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillingForm))
        Me.BillPrintButton = New System.Windows.Forms.Button()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Animal_NameTextBox = New System.Windows.Forms.TextBox()
        Me.The_OwnerTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.CreditcardRadioButton = New System.Windows.Forms.RadioButton()
        Me.CashRadioButton = New System.Windows.Forms.RadioButton()
        Me.DebitCardRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BillingColseButton = New System.Windows.Forms.Button()
        Me.NewOrderButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ItemAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.EmergencyRadioButton = New System.Windows.Forms.RadioButton()
        Me.TreatmentRadioButton = New System.Windows.Forms.RadioButton()
        Me.GeneralRadioButton = New System.Windows.Forms.RadioButton()
        Me.PreventiveCureRadioButton = New System.Windows.Forms.RadioButton()
        Me.RegularRadioButton = New System.Windows.Forms.RadioButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItemPrinter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewOrderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BillPrintButton
        '
        Me.BillPrintButton.Location = New System.Drawing.Point(342, 518)
        Me.BillPrintButton.Name = "BillPrintButton"
        Me.BillPrintButton.Size = New System.Drawing.Size(97, 23)
        Me.BillPrintButton.TabIndex = 100
        Me.BillPrintButton.Text = "&Print"
        Me.BillPrintButton.UseVisualStyleBackColor = True
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(14, 131)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.ReadOnly = True
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(135, 20)
        Me.Patient_IDTextBox.TabIndex = 95
        '
        'Animal_NameTextBox
        '
        Me.Animal_NameTextBox.Location = New System.Drawing.Point(14, 157)
        Me.Animal_NameTextBox.Name = "Animal_NameTextBox"
        Me.Animal_NameTextBox.ReadOnly = True
        Me.Animal_NameTextBox.Size = New System.Drawing.Size(135, 20)
        Me.Animal_NameTextBox.TabIndex = 96
        '
        'The_OwnerTextBox
        '
        Me.The_OwnerTextBox.Location = New System.Drawing.Point(270, 93)
        Me.The_OwnerTextBox.Name = "The_OwnerTextBox"
        Me.The_OwnerTextBox.ReadOnly = True
        Me.The_OwnerTextBox.Size = New System.Drawing.Size(175, 20)
        Me.The_OwnerTextBox.TabIndex = 97
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(270, 119)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.Size = New System.Drawing.Size(175, 20)
        Me.AddressTextBox.TabIndex = 98
        '
        'Contact_NumberTextBox
        '
        Me.Contact_NumberTextBox.Location = New System.Drawing.Point(270, 145)
        Me.Contact_NumberTextBox.Name = "Contact_NumberTextBox"
        Me.Contact_NumberTextBox.ReadOnly = True
        Me.Contact_NumberTextBox.Size = New System.Drawing.Size(175, 20)
        Me.Contact_NumberTextBox.TabIndex = 99
        '
        'CreditcardRadioButton
        '
        Me.CreditcardRadioButton.AutoSize = True
        Me.CreditcardRadioButton.Checked = True
        Me.CreditcardRadioButton.Location = New System.Drawing.Point(206, 362)
        Me.CreditcardRadioButton.Name = "CreditcardRadioButton"
        Me.CreditcardRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.CreditcardRadioButton.TabIndex = 94
        Me.CreditcardRadioButton.TabStop = True
        Me.CreditcardRadioButton.Text = "C&redit Card"
        Me.CreditcardRadioButton.UseVisualStyleBackColor = True
        '
        'CashRadioButton
        '
        Me.CashRadioButton.AutoSize = True
        Me.CashRadioButton.Location = New System.Drawing.Point(136, 360)
        Me.CashRadioButton.Name = "CashRadioButton"
        Me.CashRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.CashRadioButton.TabIndex = 84
        Me.CashRadioButton.TabStop = True
        Me.CashRadioButton.Text = "&Cash"
        Me.CashRadioButton.UseVisualStyleBackColor = True
        '
        'DebitCardRadioButton
        '
        Me.DebitCardRadioButton.AutoSize = True
        Me.DebitCardRadioButton.Location = New System.Drawing.Point(309, 362)
        Me.DebitCardRadioButton.Name = "DebitCardRadioButton"
        Me.DebitCardRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.DebitCardRadioButton.TabIndex = 93
        Me.DebitCardRadioButton.TabStop = True
        Me.DebitCardRadioButton.Text = "&Debit Card"
        Me.DebitCardRadioButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Payment Type "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(122, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(181, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Billing System"
        '
        'BillingColseButton
        '
        Me.BillingColseButton.Location = New System.Drawing.Point(239, 517)
        Me.BillingColseButton.Name = "BillingColseButton"
        Me.BillingColseButton.Size = New System.Drawing.Size(97, 24)
        Me.BillingColseButton.TabIndex = 89
        Me.BillingColseButton.Text = "&Cancel"
        Me.BillingColseButton.UseVisualStyleBackColor = True
        '
        'NewOrderButton
        '
        Me.NewOrderButton.Location = New System.Drawing.Point(26, 517)
        Me.NewOrderButton.Name = "NewOrderButton"
        Me.NewOrderButton.Size = New System.Drawing.Size(100, 24)
        Me.NewOrderButton.TabIndex = 87
        Me.NewOrderButton.Text = "&New Order"
        Me.NewOrderButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SubTotalTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TaxTextBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TotalTextBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 378)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 102)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.Location = New System.Drawing.Point(119, 14)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.ReadOnly = True
        Me.SubTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubTotalTextBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SubTotal"
        '
        'TaxTextBox
        '
        Me.TaxTextBox.Location = New System.Drawing.Point(119, 40)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.ReadOnly = True
        Me.TaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TaxTextBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tax "
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(119, 66)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Due"
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(136, 517)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(97, 24)
        Me.SummaryButton.TabIndex = 88
        Me.SummaryButton.Text = "&Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ItemAmountTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CalculateButton)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 174)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Information"
        '
        'ItemAmountTextBox
        '
        Me.ItemAmountTextBox.Location = New System.Drawing.Point(87, 128)
        Me.ItemAmountTextBox.Name = "ItemAmountTextBox"
        Me.ItemAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ItemAmountTextBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Item Amount"
        '
        'CalculateButton
        '
        Me.CalculateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CalculateButton.Location = New System.Drawing.Point(24, 63)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(142, 37)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "&Calculate Selection"
        Me.CalculateButton.UseVisualStyleBackColor = False
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(65, 30)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Quantity"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.EmergencyRadioButton)
        Me.GroupBox3.Controls.Add(Me.TreatmentRadioButton)
        Me.GroupBox3.Controls.Add(Me.GeneralRadioButton)
        Me.GroupBox3.Controls.Add(Me.PreventiveCureRadioButton)
        Me.GroupBox3.Controls.Add(Me.RegularRadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(240, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 144)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Visit Purpose"
        '
        'EmergencyRadioButton
        '
        Me.EmergencyRadioButton.AutoSize = True
        Me.EmergencyRadioButton.Location = New System.Drawing.Point(20, 112)
        Me.EmergencyRadioButton.Name = "EmergencyRadioButton"
        Me.EmergencyRadioButton.Size = New System.Drawing.Size(78, 17)
        Me.EmergencyRadioButton.TabIndex = 4
        Me.EmergencyRadioButton.TabStop = True
        Me.EmergencyRadioButton.Text = "&Emergency"
        Me.EmergencyRadioButton.UseVisualStyleBackColor = True
        '
        'TreatmentRadioButton
        '
        Me.TreatmentRadioButton.AutoSize = True
        Me.TreatmentRadioButton.Location = New System.Drawing.Point(20, 92)
        Me.TreatmentRadioButton.Name = "TreatmentRadioButton"
        Me.TreatmentRadioButton.Size = New System.Drawing.Size(112, 17)
        Me.TreatmentRadioButton.TabIndex = 3
        Me.TreatmentRadioButton.TabStop = True
        Me.TreatmentRadioButton.Text = "&Treatment Service"
        Me.TreatmentRadioButton.UseVisualStyleBackColor = True
        '
        'GeneralRadioButton
        '
        Me.GeneralRadioButton.AutoSize = True
        Me.GeneralRadioButton.Location = New System.Drawing.Point(20, 72)
        Me.GeneralRadioButton.Name = "GeneralRadioButton"
        Me.GeneralRadioButton.Size = New System.Drawing.Size(101, 17)
        Me.GeneralRadioButton.TabIndex = 2
        Me.GeneralRadioButton.TabStop = True
        Me.GeneralRadioButton.Text = "&General Surgery"
        Me.GeneralRadioButton.UseVisualStyleBackColor = True
        '
        'PreventiveCureRadioButton
        '
        Me.PreventiveCureRadioButton.AutoSize = True
        Me.PreventiveCureRadioButton.Location = New System.Drawing.Point(20, 54)
        Me.PreventiveCureRadioButton.Name = "PreventiveCureRadioButton"
        Me.PreventiveCureRadioButton.Size = New System.Drawing.Size(101, 17)
        Me.PreventiveCureRadioButton.TabIndex = 1
        Me.PreventiveCureRadioButton.TabStop = True
        Me.PreventiveCureRadioButton.Text = "&Preventive Cure"
        Me.PreventiveCureRadioButton.UseVisualStyleBackColor = True
        '
        'RegularRadioButton
        '
        Me.RegularRadioButton.AutoSize = True
        Me.RegularRadioButton.Checked = True
        Me.RegularRadioButton.Location = New System.Drawing.Point(20, 31)
        Me.RegularRadioButton.Name = "RegularRadioButton"
        Me.RegularRadioButton.Size = New System.Drawing.Size(114, 17)
        Me.RegularRadioButton.TabIndex = 0
        Me.RegularRadioButton.TabStop = True
        Me.RegularRadioButton.Text = " &Regular Check-up"
        Me.RegularRadioButton.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(472, 24)
        Me.MenuStrip.TabIndex = 101
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ToolStripSeparator1, Me.PrintToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CalculateToolStripMenuItem.Text = "&Calculate"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(122, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPreviewToolStripMenuItem, Me.PrintToolStripMenuItemPrinter})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print P&review"
        '
        'PrintToolStripMenuItemPrinter
        '
        Me.PrintToolStripMenuItemPrinter.Name = "PrintToolStripMenuItemPrinter"
        Me.PrintToolStripMenuItemPrinter.Size = New System.Drawing.Size(143, 22)
        Me.PrintToolStripMenuItemPrinter.Text = "Prin&t"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(122, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewOrderToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'NewOrderToolStripMenuItem1
        '
        Me.NewOrderToolStripMenuItem1.Name = "NewOrderToolStripMenuItem1"
        Me.NewOrderToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.NewOrderToolStripMenuItem1.Text = "&New Order"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 483)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Appointment:"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(247, 483)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(39, 13)
        Me.DateLabel.TabIndex = 103
        Me.DateLabel.Text = "Label8"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(332, 483)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(39, 13)
        Me.TimeLabel.TabIndex = 104
        Me.TimeLabel.Text = "Label9"
        '
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 581)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.BillPrintButton)
        Me.Controls.Add(Me.Patient_IDTextBox)
        Me.Controls.Add(Me.Animal_NameTextBox)
        Me.Controls.Add(Me.The_OwnerTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.CashRadioButton)
        Me.Controls.Add(Me.Contact_NumberTextBox)
        Me.Controls.Add(Me.CreditcardRadioButton)
        Me.Controls.Add(Me.DebitCardRadioButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BillingColseButton)
        Me.Controls.Add(Me.NewOrderButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BillingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BillingForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BillPrintButton As Button
    Friend WithEvents Patient_IDTextBox As TextBox
    Friend WithEvents Animal_NameTextBox As TextBox
    Friend WithEvents The_OwnerTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Contact_NumberTextBox As TextBox
    Friend WithEvents CreditcardRadioButton As RadioButton
    Friend WithEvents CashRadioButton As RadioButton
    Friend WithEvents DebitCardRadioButton As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BillingColseButton As Button
    Friend WithEvents NewOrderButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents SubTotalTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TaxTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SummaryButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ItemAmountTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EmergencyRadioButton As RadioButton
    Friend WithEvents TreatmentRadioButton As RadioButton
    Friend WithEvents GeneralRadioButton As RadioButton
    Friend WithEvents PreventiveCureRadioButton As RadioButton
    Friend WithEvents RegularRadioButton As RadioButton
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItemPrinter As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewOrderToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents TimeLabel As Label
End Class
