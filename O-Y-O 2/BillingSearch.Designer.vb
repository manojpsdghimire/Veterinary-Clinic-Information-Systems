<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillingSearch))
        Me.PatientSearchComboBox = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.searchPatientLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientSearchComboBox
        '
        Me.PatientSearchComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PatientSearchComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PatientSearchComboBox.FormattingEnabled = True
        Me.PatientSearchComboBox.Location = New System.Drawing.Point(122, 76)
        Me.PatientSearchComboBox.Name = "PatientSearchComboBox"
        Me.PatientSearchComboBox.Size = New System.Drawing.Size(148, 21)
        Me.PatientSearchComboBox.TabIndex = 5
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(245, 104)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(125, 13)
        Me.LinkLabel1.TabIndex = 38
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "View Registered Patients"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(276, 74)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(94, 23)
        Me.SearchButton.TabIndex = 37
        Me.SearchButton.Text = "Se&arch"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'searchPatientLabel
        '
        Me.searchPatientLabel.AutoSize = True
        Me.searchPatientLabel.Location = New System.Drawing.Point(28, 79)
        Me.searchPatientLabel.Name = "searchPatientLabel"
        Me.searchPatientLabel.Size = New System.Drawing.Size(88, 13)
        Me.searchPatientLabel.TabIndex = 36
        Me.searchPatientLabel.Text = " Enter Patient ID."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(122, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'BillingSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 137)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PatientSearchComboBox)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.searchPatientLabel)
        Me.Name = "BillingSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BillingSearch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PatientSearchComboBox As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents SearchButton As Button
    Friend WithEvents searchPatientLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
