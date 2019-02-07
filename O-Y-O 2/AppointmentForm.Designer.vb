<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppointmentForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppointmentForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CancelAppointmentButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.The_OwnerTextBox = New System.Windows.Forms.TextBox()
        Me.Appointment_TimeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientInformationDataSet1 = New O_Y_O_2.PatientInformationDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Appointment_DateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Animal_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PatientInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AppointmentSubmitButton = New System.Windows.Forms.Button()
        Me.searchPatientLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AppointmentTableAdapter = New O_Y_O_2.PatientInformationDataSetTableAdapters.AppointmentTableAdapter()
        Me.TableAdapterManager1 = New O_Y_O_2.PatientInformationDataSetTableAdapters.TableAdapterManager()
        Me.PatientInformationTableAdapter1 = New O_Y_O_2.PatientInformationDataSetTableAdapters.PatientInformationTableAdapter()
        Me.PatientInformationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PatientSearchComboBox = New System.Windows.Forms.ComboBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientInformationDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientInformationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'CancelAppointmentButton
        '
        Me.CancelAppointmentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CancelAppointmentButton.Location = New System.Drawing.Point(270, 252)
        Me.CancelAppointmentButton.Name = "CancelAppointmentButton"
        Me.CancelAppointmentButton.Size = New System.Drawing.Size(103, 39)
        Me.CancelAppointmentButton.TabIndex = 26
        Me.CancelAppointmentButton.Text = "&Cancel"
        Me.CancelAppointmentButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.The_OwnerTextBox)
        Me.GroupBox1.Controls.Add(Me.Appointment_TimeMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Appointment_DateMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Animal_NameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Patient_IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 170)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appointment Information"
        Me.GroupBox1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Animal Name"
        '
        'The_OwnerTextBox
        '
        Me.The_OwnerTextBox.Location = New System.Drawing.Point(127, 77)
        Me.The_OwnerTextBox.Name = "The_OwnerTextBox"
        Me.The_OwnerTextBox.ReadOnly = True
        Me.The_OwnerTextBox.Size = New System.Drawing.Size(148, 20)
        Me.The_OwnerTextBox.TabIndex = 32
        '
        'Appointment_TimeMaskedTextBox
        '
        Me.Appointment_TimeMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Appointment Time", True))
        Me.Appointment_TimeMaskedTextBox.Location = New System.Drawing.Point(127, 135)
        Me.Appointment_TimeMaskedTextBox.Mask = "00:00"
        Me.Appointment_TimeMaskedTextBox.Name = "Appointment_TimeMaskedTextBox"
        Me.Appointment_TimeMaskedTextBox.Size = New System.Drawing.Size(148, 20)
        Me.Appointment_TimeMaskedTextBox.TabIndex = 32
        Me.Appointment_TimeMaskedTextBox.ValidatingType = GetType(Date)
        '
        'AppointmentBindingSource
        '
        Me.AppointmentBindingSource.DataMember = "Appointment"
        Me.AppointmentBindingSource.DataSource = Me.PatientInformationDataSet1
        '
        'PatientInformationDataSet1
        '
        Me.PatientInformationDataSet1.DataSetName = "PatientInformationDataSet"
        Me.PatientInformationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Time of Appointment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "The Owner"
        '
        'Appointment_DateMaskedTextBox
        '
        Me.Appointment_DateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Appointment Date", True))
        Me.Appointment_DateMaskedTextBox.Location = New System.Drawing.Point(127, 109)
        Me.Appointment_DateMaskedTextBox.Mask = "00/00/0000"
        Me.Appointment_DateMaskedTextBox.Name = "Appointment_DateMaskedTextBox"
        Me.Appointment_DateMaskedTextBox.Size = New System.Drawing.Size(148, 20)
        Me.Appointment_DateMaskedTextBox.TabIndex = 31
        Me.Appointment_DateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Date of Appointment"
        '
        'Animal_NameTextBox
        '
        Me.Animal_NameTextBox.Location = New System.Drawing.Point(127, 54)
        Me.Animal_NameTextBox.Name = "Animal_NameTextBox"
        Me.Animal_NameTextBox.ReadOnly = True
        Me.Animal_NameTextBox.Size = New System.Drawing.Size(148, 20)
        Me.Animal_NameTextBox.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Patient Number"
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(127, 29)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.ReadOnly = True
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(148, 20)
        Me.Patient_IDTextBox.TabIndex = 30
        '
        'PatientInformationBindingSource
        '
        Me.PatientInformationBindingSource.DataMember = "PatientInformation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(122, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Schedule an Appointment"
        '
        'AppointmentSubmitButton
        '
        Me.AppointmentSubmitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AppointmentSubmitButton.Location = New System.Drawing.Point(161, 252)
        Me.AppointmentSubmitButton.Name = "AppointmentSubmitButton"
        Me.AppointmentSubmitButton.Size = New System.Drawing.Size(100, 40)
        Me.AppointmentSubmitButton.TabIndex = 22
        Me.AppointmentSubmitButton.Text = "&Submit"
        Me.AppointmentSubmitButton.UseVisualStyleBackColor = False
        Me.AppointmentSubmitButton.Visible = False
        '
        'searchPatientLabel
        '
        Me.searchPatientLabel.AutoSize = True
        Me.searchPatientLabel.Location = New System.Drawing.Point(28, 90)
        Me.searchPatientLabel.Name = "searchPatientLabel"
        Me.searchPatientLabel.Size = New System.Drawing.Size(88, 13)
        Me.searchPatientLabel.TabIndex = 27
        Me.searchPatientLabel.Text = " Enter Patient ID."
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchButton.Location = New System.Drawing.Point(276, 85)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(94, 23)
        Me.SearchButton.TabIndex = 29
        Me.SearchButton.Text = "Se&arch"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UpdateButton.Location = New System.Drawing.Point(161, 252)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(103, 39)
        Me.UpdateButton.TabIndex = 30
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        Me.UpdateButton.Visible = False
        '
        'AppointmentTableAdapter
        '
        Me.AppointmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AppointmentTableAdapter = Me.AppointmentTableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PatientInformationTableAdapter = Me.PatientInformationTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = O_Y_O_2.PatientInformationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PatientInformationTableAdapter1
        '
        Me.PatientInformationTableAdapter1.ClearBeforeFill = True
        '
        'PatientInformationBindingSource1
        '
        Me.PatientInformationBindingSource1.DataMember = "PatientInformation"
        Me.PatientInformationBindingSource1.DataSource = Me.PatientInformationDataSet1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(245, 115)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(125, 13)
        Me.LinkLabel1.TabIndex = 32
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "View Registered Patients"
        '
        'PatientSearchComboBox
        '
        Me.PatientSearchComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PatientSearchComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PatientSearchComboBox.FormattingEnabled = True
        Me.PatientSearchComboBox.Location = New System.Drawing.Point(122, 87)
        Me.PatientSearchComboBox.Name = "PatientSearchComboBox"
        Me.PatientSearchComboBox.Size = New System.Drawing.Size(148, 21)
        Me.PatientSearchComboBox.TabIndex = 33
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeleteButton.Location = New System.Drawing.Point(55, 253)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(100, 39)
        Me.DeleteButton.TabIndex = 34
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        Me.DeleteButton.Visible = False
        '
        'AppointmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 305)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.PatientSearchComboBox)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.searchPatientLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CancelAppointmentButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AppointmentSubmitButton)
        Me.MaximizeBox = False
        Me.Name = "AppointmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule an Appointment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientInformationDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientInformationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CancelAppointmentButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AppointmentSubmitButton As Button
    Friend WithEvents searchPatientLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents Patient_IDTextBox As TextBox
    Friend WithEvents Animal_NameTextBox As TextBox
    Friend WithEvents The_OwnerTextBox As TextBox
    Friend WithEvents PatientInformationDataSet As PatientInformationDataSet
    Friend WithEvents PatientInformationBindingSource As BindingSource
    Friend WithEvents PatientInformationTableAdapter As PatientInformationDataSetTableAdapters.PatientInformationTableAdapter
    Friend WithEvents TableAdapterManager As PatientInformationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UpdateButton As Button
    Friend WithEvents PatientInformationDataSet1 As PatientInformationDataSet
    Friend WithEvents AppointmentBindingSource As BindingSource
    Friend WithEvents AppointmentTableAdapter As PatientInformationDataSetTableAdapters.AppointmentTableAdapter
    Friend WithEvents TableAdapterManager1 As PatientInformationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Appointment_TimeMaskedTextBox As MaskedTextBox
    Friend WithEvents Appointment_DateMaskedTextBox As MaskedTextBox
    Friend WithEvents PatientInformationTableAdapter1 As PatientInformationDataSetTableAdapters.PatientInformationTableAdapter
    Friend WithEvents PatientInformationBindingSource1 As BindingSource
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PatientSearchComboBox As ComboBox
    Friend WithEvents DeleteButton As Button
End Class
