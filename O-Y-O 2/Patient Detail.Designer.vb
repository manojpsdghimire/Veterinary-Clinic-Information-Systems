<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Detail
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
        Me.PatientInformationDataSet = New O_Y_O_2.PatientInformationDataSet()
        Me.PatientInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientInformationTableAdapter = New O_Y_O_2.PatientInformationDataSetTableAdapters.PatientInformationTableAdapter()
        Me.TableAdapterManager = New O_Y_O_2.PatientInformationDataSetTableAdapters.TableAdapterManager()
        Me.PatientInformationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PatientInformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientInformationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientInformationDataSet
        '
        Me.PatientInformationDataSet.DataSetName = "PatientInformationDataSet"
        Me.PatientInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientInformationBindingSource
        '
        Me.PatientInformationBindingSource.DataMember = "PatientInformation"
        Me.PatientInformationBindingSource.DataSource = Me.PatientInformationDataSet
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
        'PatientInformationDataGridView
        '
        Me.PatientInformationDataGridView.AutoGenerateColumns = False
        Me.PatientInformationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientInformationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.PatientInformationDataGridView.DataSource = Me.PatientInformationBindingSource
        Me.PatientInformationDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PatientInformationDataGridView.Name = "PatientInformationDataGridView"
        Me.PatientInformationDataGridView.ReadOnly = True
        Me.PatientInformationDataGridView.Size = New System.Drawing.Size(1043, 431)
        Me.PatientInformationDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Animal Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Animal Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Animal Kind"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Animal Kind"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Breed"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Breed"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Weight (In_ Lbs)"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Weight (In_ Lbs)"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Date of Birth"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date of Birth"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "The Owner"
        Me.DataGridViewTextBoxColumn7.HeaderText = "The Owner"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Area Code"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Area Code"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Number"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Number"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'Patient_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 430)
        Me.Controls.Add(Me.PatientInformationDataGridView)
        Me.MaximizeBox = False
        Me.Name = "Patient_Detail"
        Me.Text = "Patient_Detail"
        CType(Me.PatientInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientInformationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PatientInformationDataSet As PatientInformationDataSet
    Friend WithEvents PatientInformationBindingSource As BindingSource
    Friend WithEvents PatientInformationTableAdapter As PatientInformationDataSetTableAdapters.PatientInformationTableAdapter
    Friend WithEvents TableAdapterManager As PatientInformationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientInformationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
