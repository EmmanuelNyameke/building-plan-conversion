<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlans
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
        lblHeading = New Label()
        lblNumber = New Label()
        txtNumber = New TextBox()
        picPlan = New PictureBox()
        grpUnitType = New GroupBox()
        radMeters = New RadioButton()
        radInches = New RadioButton()
        grpSystemType = New GroupBox()
        radMetricImperial = New RadioButton()
        radImperialMetric = New RadioButton()
        lblConversion = New Label()
        lblConverted = New Label()
        btnDisplay = New Button()
        btnClear = New Button()
        btnCancel = New Button()
        btnOk = New Button()
        CType(picPlan, ComponentModel.ISupportInitialize).BeginInit()
        grpUnitType.SuspendLayout()
        grpSystemType.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(70, 21)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(275, 28)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Building Plans Conversion"
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Font = New Font("Goudy Old Style", 14.25F, FontStyle.Bold)
        lblNumber.Location = New Point(109, 203)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(62, 23)
        lblNumber.TabIndex = 1
        lblNumber.Text = "Label1"
        lblNumber.Visible = False
        ' 
        ' txtNumber
        ' 
        txtNumber.Font = New Font("Goudy Old Style", 14.25F, FontStyle.Bold)
        txtNumber.Location = New Point(296, 200)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(38, 30)
        txtNumber.TabIndex = 2
        txtNumber.TextAlign = HorizontalAlignment.Center
        txtNumber.Visible = False
        ' 
        ' picPlan
        ' 
        picPlan.Dock = DockStyle.Right
        picPlan.Image = My.Resources.Resources.building
        picPlan.Location = New Point(470, 0)
        picPlan.Name = "picPlan"
        picPlan.Size = New Size(370, 529)
        picPlan.SizeMode = PictureBoxSizeMode.StretchImage
        picPlan.TabIndex = 3
        picPlan.TabStop = False
        ' 
        ' grpUnitType
        ' 
        grpUnitType.Controls.Add(radMeters)
        grpUnitType.Controls.Add(radInches)
        grpUnitType.Font = New Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpUnitType.Location = New Point(100, 70)
        grpUnitType.Name = "grpUnitType"
        grpUnitType.Size = New Size(200, 50)
        grpUnitType.TabIndex = 4
        grpUnitType.TabStop = False
        grpUnitType.Text = "Unit Type:"
        ' 
        ' radMeters
        ' 
        radMeters.AutoSize = True
        radMeters.Location = New Point(104, 25)
        radMeters.Name = "radMeters"
        radMeters.Size = New Size(72, 25)
        radMeters.TabIndex = 1
        radMeters.TabStop = True
        radMeters.Text = "Meters"
        radMeters.UseVisualStyleBackColor = True
        ' 
        ' radInches
        ' 
        radInches.AutoSize = True
        radInches.Location = New Point(9, 25)
        radInches.Name = "radInches"
        radInches.Size = New Size(71, 25)
        radInches.TabIndex = 0
        radInches.TabStop = True
        radInches.Text = "Inches"
        radInches.UseVisualStyleBackColor = True
        ' 
        ' grpSystemType
        ' 
        grpSystemType.Controls.Add(radMetricImperial)
        grpSystemType.Controls.Add(radImperialMetric)
        grpSystemType.Font = New Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpSystemType.Location = New Point(100, 261)
        grpSystemType.Name = "grpSystemType"
        grpSystemType.Size = New Size(200, 107)
        grpSystemType.TabIndex = 5
        grpSystemType.TabStop = False
        grpSystemType.Text = "System Type:"
        grpSystemType.Visible = False
        ' 
        ' radMetricImperial
        ' 
        radMetricImperial.AutoSize = True
        radMetricImperial.Checked = True
        radMetricImperial.Location = New Point(9, 80)
        radMetricImperial.Name = "radMetricImperial"
        radMetricImperial.Size = New Size(147, 25)
        radMetricImperial.TabIndex = 1
        radMetricImperial.TabStop = True
        radMetricImperial.Text = "Metric to Imperial"
        radMetricImperial.UseVisualStyleBackColor = True
        ' 
        ' radImperialMetric
        ' 
        radImperialMetric.AutoSize = True
        radImperialMetric.Location = New Point(9, 34)
        radImperialMetric.Name = "radImperialMetric"
        radImperialMetric.Size = New Size(147, 25)
        radImperialMetric.TabIndex = 0
        radImperialMetric.Text = "Imperial to Metric"
        radImperialMetric.UseVisualStyleBackColor = True
        ' 
        ' lblConversion
        ' 
        lblConversion.AutoSize = True
        lblConversion.Font = New Font("Goudy Old Style", 14.25F, FontStyle.Bold)
        lblConversion.Location = New Point(109, 420)
        lblConversion.Name = "lblConversion"
        lblConversion.Size = New Size(104, 23)
        lblConversion.TabIndex = 2
        lblConversion.Text = "Conversion:"
        lblConversion.Visible = False
        ' 
        ' lblConverted
        ' 
        lblConverted.AutoSize = True
        lblConverted.Font = New Font("Goudy Old Style", 14.25F, FontStyle.Bold)
        lblConverted.Location = New Point(218, 420)
        lblConverted.Name = "lblConverted"
        lblConverted.Size = New Size(91, 23)
        lblConverted.TabIndex = 6
        lblConverted.Text = "Converted"
        lblConverted.Visible = False
        ' 
        ' btnDisplay
        ' 
        btnDisplay.BackColor = Color.White
        btnDisplay.Font = New Font("Goudy Old Style", 12F, FontStyle.Bold)
        btnDisplay.Location = New Point(109, 471)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(75, 35)
        btnDisplay.TabIndex = 7
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = False
        btnDisplay.Visible = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.Font = New Font("Goudy Old Style", 12F, FontStyle.Bold)
        btnClear.Location = New Point(225, 471)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 35)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        btnClear.Visible = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.Font = New Font("Goudy Old Style", 12F, FontStyle.Bold)
        btnCancel.Location = New Point(221, 144)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 30)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnOk
        ' 
        btnOk.BackColor = Color.White
        btnOk.Font = New Font("Goudy Old Style", 12F, FontStyle.Bold)
        btnOk.Location = New Point(105, 144)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(75, 30)
        btnOk.TabIndex = 9
        btnOk.Text = "OK"
        btnOk.UseVisualStyleBackColor = False
        ' 
        ' frmPlans
        ' 
        AcceptButton = btnDisplay
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = btnClear
        ClientSize = New Size(840, 529)
        Controls.Add(btnCancel)
        Controls.Add(btnOk)
        Controls.Add(btnClear)
        Controls.Add(btnDisplay)
        Controls.Add(lblConverted)
        Controls.Add(lblConversion)
        Controls.Add(grpSystemType)
        Controls.Add(grpUnitType)
        Controls.Add(picPlan)
        Controls.Add(txtNumber)
        Controls.Add(lblNumber)
        Controls.Add(lblHeading)
        Font = New Font("Goudy Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "frmPlans"
        Text = "Building Plan Conversion"
        CType(picPlan, ComponentModel.ISupportInitialize).EndInit()
        grpUnitType.ResumeLayout(False)
        grpUnitType.PerformLayout()
        grpSystemType.ResumeLayout(False)
        grpSystemType.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents picPlan As PictureBox
    Friend WithEvents grpUnitType As GroupBox
    Friend WithEvents grpSystemType As GroupBox
    Friend WithEvents radMeters As RadioButton
    Friend WithEvents radInches As RadioButton
    Friend WithEvents radMetricImperial As RadioButton
    Friend WithEvents radImperialMetric As RadioButton
    Friend WithEvents lblConversion As Label
    Friend WithEvents lblConverted As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button

End Class
