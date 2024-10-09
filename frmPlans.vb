' Program Name: Building Plans Conversion
' Date: October 5, 2024
' Author: K Bola
' Purpose: This application converts inches to meters or from meters to inches when building plans need to be converted between imperial and metric system
Public Class frmPlans
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If (radInches.Checked) Then
            lblNumber.Text = "Number of Inches:"
            lblNumber.Visible = True
            txtNumber.Visible = True
            grpSystemType.Visible = True
            lblConversion.Visible = True
            lblConverted.Visible = True
            btnDisplay.Visible = True
            btnClear.Visible = True
            btnOk.Enabled = False
        Else
            lblNumber.Text = "Number of Meters:"
            lblNumber.Visible = True
            txtNumber.Visible = True
            grpSystemType.Visible = True
            lblConversion.Visible = True
            lblConverted.Visible = True
            btnDisplay.Visible = True
            btnClear.Visible = True
            btnOk.Enabled = False
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lblNumber.Text = ""
        lblNumber.Visible = False
        txtNumber.Visible = False
        txtNumber.Clear()
        grpSystemType.Visible = False
        lblConversion.Visible = False
        lblConverted.Visible = False
        lblConverted.Text = ""
        btnDisplay.Visible = False
        btnClear.Visible = False
        btnOk.Enabled = True

    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Const _cdblInch As Double = 0.0254
        Const _cdblMeter As Double = 39.37008
        Dim dblNumber As Double
        Dim dblConversion As Double
        If (IsNumeric(txtNumber.Text)) Then
            dblNumber = Convert.ToDouble(txtNumber.Text)
            If (radInches.Checked And dblNumber > 0.0 And radImperialMetric.Checked Or radMetricImperial.Checked) Then
                dblConversion = _cdblInch * dblNumber
                lblConverted.Text = dblConversion.ToString("N3") & " Inches."
            ElseIf (radMeters.Checked And dblNumber > 0.0 And radMetricImperial.Checked Or radImperialMetric.Checked) Then
                dblConversion = _cdblMeter * dblNumber
                lblConverted.Text = dblConversion.ToString("N3") & " Meters"
            Else
                MsgBox("Enter a Number Greater Than Zero", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
            End If
        Else
            MsgBox("Enter a Number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnCancel.PerformClick()
    End Sub
    Private Sub frmPlans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblConverted.Text = ""
    End Sub
End Class
