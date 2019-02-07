<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BillingButton = New System.Windows.Forms.Button()
        Me.AppointmentButton = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(14, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 28)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "501 Westminster Avenue Fulton MO  65251 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact: (573)-592-9128 | VeterinaryCli" &
    "nic@animalcare.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Veterinary Clinic Information System"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(262, 185)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(143, 23)
        Me.ExitButton.TabIndex = 36
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'BillingButton
        '
        Me.BillingButton.Location = New System.Drawing.Point(262, 127)
        Me.BillingButton.Name = "BillingButton"
        Me.BillingButton.Size = New System.Drawing.Size(143, 23)
        Me.BillingButton.TabIndex = 35
        Me.BillingButton.Text = "&Billing"
        Me.BillingButton.UseVisualStyleBackColor = True
        '
        'AppointmentButton
        '
        Me.AppointmentButton.Location = New System.Drawing.Point(262, 94)
        Me.AppointmentButton.Name = "AppointmentButton"
        Me.AppointmentButton.Size = New System.Drawing.Size(143, 27)
        Me.AppointmentButton.TabIndex = 34
        Me.AppointmentButton.Text = "Schedule &Appointment"
        Me.AppointmentButton.UseVisualStyleBackColor = True
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(262, 64)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(143, 24)
        Me.RegisterButton.TabIndex = 33
        Me.RegisterButton.Text = "Register &Patient"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.Location = New System.Drawing.Point(262, 156)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(143, 23)
        Me.AboutButton.TabIndex = 40
        Me.AboutButton.Text = "&About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "By: Manoj Ghimire"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 287)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BillingButton)
        Me.Controls.Add(Me.AppointmentButton)
        Me.Controls.Add(Me.RegisterButton)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents BillingButton As Button
    Friend WithEvents AppointmentButton As Button
    Friend WithEvents RegisterButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents Label3 As Label
End Class
