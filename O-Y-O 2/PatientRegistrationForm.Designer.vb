<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientRegistrationForm
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
        Me.components = New System.ComponentModel.Container()
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim Animal_NameLabel As System.Windows.Forms.Label
        Dim Animal_KindLabel As System.Windows.Forms.Label
        Dim BreedLabel As System.Windows.Forms.Label
        Dim Weight__In__Lbs_Label As System.Windows.Forms.Label
        Dim Date_of_BirthLabel As System.Windows.Forms.Label
        Dim The_OwnerLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientRegistrationForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Date_of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PatientInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientInformationDataSet = New O_Y_O_2.PatientInformationDataSet()
        Me.Weight__In__Lbs_TextBox = New System.Windows.Forms.TextBox()
        Me.BreedTextBox = New System.Windows.Forms.TextBox()
        Me.Animal_KindTextBox = New System.Windows.Forms.TextBox()
        Me.Animal_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.The_OwnerTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Area_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PatientInformationTableAdapter = New O_Y_O_2.PatientInformationDataSetTableAdapters.PatientInformationTableAdapter()
        Me.TableAdapterManager = New O_Y_O_2.PatientInformationDataSetTableAdapters.TableAdapterManager()
        Patient_IDLabel = New System.Windows.Forms.Label()
        Animal_NameLabel = New System.Windows.Forms.Label()
        Animal_KindLabel = New System.Windows.Forms.Label()
        BreedLabel = New System.Windows.Forms.Label()
        Weight__In__Lbs_Label = New System.Windows.Forms.Label()
        Date_of_BirthLabel = New System.Windows.Forms.Label()
        The_OwnerLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PatientInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientInformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Location = New System.Drawing.Point(11, 31)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(57, 13)
        Patient_IDLabel.TabIndex = 30
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Animal_NameLabel
        '
        Animal_NameLabel.AutoSize = True
        Animal_NameLabel.Location = New System.Drawing.Point(216, 31)
        Animal_NameLabel.Name = "Animal_NameLabel"
        Animal_NameLabel.Size = New System.Drawing.Size(72, 13)
        Animal_NameLabel.TabIndex = 32
        Animal_NameLabel.Text = "Animal Name:"
        '
        'Animal_KindLabel
        '
        Animal_KindLabel.AutoSize = True
        Animal_KindLabel.Location = New System.Drawing.Point(11, 57)
        Animal_KindLabel.Name = "Animal_KindLabel"
        Animal_KindLabel.Size = New System.Drawing.Size(65, 13)
        Animal_KindLabel.TabIndex = 34
        Animal_KindLabel.Text = "Animal Kind:"
        '
        'BreedLabel
        '
        BreedLabel.AutoSize = True
        BreedLabel.Location = New System.Drawing.Point(216, 60)
        BreedLabel.Name = "BreedLabel"
        BreedLabel.Size = New System.Drawing.Size(38, 13)
        BreedLabel.TabIndex = 36
        BreedLabel.Text = "Breed:"
        '
        'Weight__In__Lbs_Label
        '
        Weight__In__Lbs_Label.AutoSize = True
        Weight__In__Lbs_Label.Location = New System.Drawing.Point(11, 83)
        Weight__In__Lbs_Label.Name = "Weight__In__Lbs_Label"
        Weight__In__Lbs_Label.Size = New System.Drawing.Size(85, 13)
        Weight__In__Lbs_Label.TabIndex = 38
        Weight__In__Lbs_Label.Text = "Weight (In  Lbs):"
        '
        'Date_of_BirthLabel
        '
        Date_of_BirthLabel.AutoSize = True
        Date_of_BirthLabel.Location = New System.Drawing.Point(216, 87)
        Date_of_BirthLabel.Name = "Date_of_BirthLabel"
        Date_of_BirthLabel.Size = New System.Drawing.Size(69, 13)
        Date_of_BirthLabel.TabIndex = 40
        Date_of_BirthLabel.Text = "Date of Birth:"
        '
        'The_OwnerLabel
        '
        The_OwnerLabel.AutoSize = True
        The_OwnerLabel.Location = New System.Drawing.Point(32, 26)
        The_OwnerLabel.Name = "The_OwnerLabel"
        The_OwnerLabel.Size = New System.Drawing.Size(63, 13)
        The_OwnerLabel.TabIndex = 42
        The_OwnerLabel.Text = "The Owner:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(32, 56)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 44
        AddressLabel.Text = "Address:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(118, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Date_of_BirthLabel)
        Me.GroupBox1.Controls.Add(Weight__In__Lbs_Label)
        Me.GroupBox1.Controls.Add(Me.Date_of_BirthDateTimePicker)
        Me.GroupBox1.Controls.Add(BreedLabel)
        Me.GroupBox1.Controls.Add(Me.Weight__In__Lbs_TextBox)
        Me.GroupBox1.Controls.Add(Animal_KindLabel)
        Me.GroupBox1.Controls.Add(Me.BreedTextBox)
        Me.GroupBox1.Controls.Add(Animal_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Animal_KindTextBox)
        Me.GroupBox1.Controls.Add(Patient_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Animal_NameTextBox)
        Me.GroupBox1.Controls.Add(Me.Patient_IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 124)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient's Information"
        '
        'Date_of_BirthDateTimePicker
        '
        Me.Date_of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientInformationBindingSource, "Date of Birth", True))
        Me.Date_of_BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_of_BirthDateTimePicker.Location = New System.Drawing.Point(307, 83)
        Me.Date_of_BirthDateTimePicker.Name = "Date_of_BirthDateTimePicker"
        Me.Date_of_BirthDateTimePicker.Size = New System.Drawing.Size(156, 20)
        Me.Date_of_BirthDateTimePicker.TabIndex = 41
        '
        'PatientInformationBindingSource
        '
        Me.PatientInformationBindingSource.DataMember = "PatientInformation"
        Me.PatientInformationBindingSource.DataSource = Me.PatientInformationDataSet
        '
        'PatientInformationDataSet
        '
        Me.PatientInformationDataSet.DataSetName = "PatientInformationDataSet"
        Me.PatientInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Weight__In__Lbs_TextBox
        '
        Me.Weight__In__Lbs_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInformationBindingSource, "Weight (In_ Lbs)", True))
        Me.Weight__In__Lbs_TextBox.Location = New System.Drawing.Point(102, 80)
        Me.Weight__In__Lbs_TextBox.Name = "Weight__In__Lbs_TextBox"
        Me.Weight__In__Lbs_TextBox.Size = New System.Drawing.Size(97, 20)
        Me.Weight__In__Lbs_TextBox.TabIndex = 39
        Me.Weight__In__Lbs_TextBox.Tag = "Animal Weight Not Provided"
        '
        'BreedTextBox
        '
        Me.BreedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInformationBindingSource, "Breed", True))
        Me.BreedTextBox.Location = New System.Drawing.Point(307, 57)
        Me.BreedTextBox.Name = "BreedTextBox"
        Me.BreedTextBox.Size = New System.Drawing.Size(156, 20)
        Me.BreedTextBox.TabIndex = 37
        Me.BreedTextBox.Tag = "Animal Breed Not Provided"
        '
        'Animal_KindTextBox
        '
        Me.Animal_KindTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInformationBindingSource, "Animal Kind", True))
        Me.Animal_KindTextBox.Location = New System.Drawing.Point(102, 54)
        Me.Animal_KindTextBox.Name = "Animal_KindTextBox"
        Me.Animal_KindTextBox.Size = New System.Drawing.Size(97, 20)
        Me.Animal_KindTextBox.TabIndex = 35
        Me.Animal_KindTextBox.Tag = "Animal Kind not Provided"
        '
        'Animal_NameTextBox
        '
        Me.Animal_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInformationBindingSource, "Animal Name", True))
        Me.Animal_NameTextBox.Location = New System.Drawing.Point(307, 28)
        Me.Animal_NameTextBox.Name = "Animal_NameTextBox"
        Me.Animal_NameTextBox.Size = New System.Drawing.Size(156, 20)
        Me.Animal_NameTextBox.TabIndex = 33
        Me.Animal_NameTextBox.Tag = "Animal Name Not Provided"
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInformationBindingSource, "Patient ID", True))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(102, 28)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.ReadOnly = True
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(97, 20)
        Me.Patient_IDTextBox.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(177, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "New Patient Registration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.The_OwnerTextBox)
        Me.GroupBox2.Controls.Add(Me.AddressTextBox)
        Me.GroupBox2.Controls.Add(AddressLabel)
        Me.GroupBox2.Controls.Add(The_OwnerLabel)
        Me.GroupBox2.Controls.Add(Me.Area_CodeTextBox)
        Me.GroupBox2.Controls.Add(Me.NumberTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(483, 128)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Owner's Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(222, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 12)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "(Number)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(115, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 12)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "(Area Code)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(32, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "-"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(338, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'The_OwnerTextBox
        '
        Me.The_OwnerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInformationBindingSource, "The Owner", True))
        Me.The_OwnerTextBox.Location = New System.Drawing.Point(123, 23)
        Me.The_OwnerTextBox.Name = "The_OwnerTextBox"
        Me.The_OwnerTextBox.Size = New System.Drawing.Size(200, 20)
        Me.The_OwnerTextBox.TabIndex = 43
        Me.The_OwnerTextBox.Tag = "Owner Not Provided"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInformationBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(123, 49)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 45
        Me.AddressTextBox.Tag = "Address Not Provided"
        '
        'Area_CodeTextBox
        '
        Me.Area_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInformationBindingSource, "Area Code", True))
        Me.Area_CodeTextBox.Location = New System.Drawing.Point(123, 75)
        Me.Area_CodeTextBox.Name = "Area_CodeTextBox"
        Me.Area_CodeTextBox.Size = New System.Drawing.Size(47, 20)
        Me.Area_CodeTextBox.TabIndex = 47
        Me.Area_CodeTextBox.Tag = "Area Code Not Provided"
        '
        'NumberTextBox
        '
        Me.NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInformationBindingSource, "Number", True))
        Me.NumberTextBox.Location = New System.Drawing.Point(194, 75)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(129, 20)
        Me.NumberTextBox.TabIndex = 49
        Me.NumberTextBox.Tag = "Number Not Provided"
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SubmitButton.Location = New System.Drawing.Point(88, 343)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(146, 40)
        Me.SubmitButton.TabIndex = 28
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CancelButton.Location = New System.Drawing.Point(264, 343)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(146, 40)
        Me.CancelButton.TabIndex = 29
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'PatientInformationTableAdapter
        '
        Me.PatientInformationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PatientInformationTableAdapter = Me.PatientInformationTableAdapter
        Me.TableAdapterManager.UpdateOrder = O_Y_O_2.PatientInformationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PatientRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 401)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PatientRegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PatientRegistrationForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PatientInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents PatientInformationBindingSource As BindingSource
    Friend WithEvents PatientInformationDataSet As PatientInformationDataSet
    Friend WithEvents PatientInformationTableAdapter As PatientInformationDataSetTableAdapters.PatientInformationTableAdapter
    Friend WithEvents TableAdapterManager As PatientInformationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents The_OwnerTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Area_CodeTextBox As TextBox
    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents Patient_IDTextBox As TextBox
    Friend WithEvents Animal_NameTextBox As TextBox
    Friend WithEvents Animal_KindTextBox As TextBox
    Friend WithEvents BreedTextBox As TextBox
    Friend WithEvents Weight__In__Lbs_TextBox As TextBox
    Friend WithEvents Date_of_BirthDateTimePicker As DateTimePicker
End Class
