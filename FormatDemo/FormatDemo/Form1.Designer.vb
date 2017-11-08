<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFullDateTimeFormat = New System.Windows.Forms.Button()
        Me.btnPercentFormat = New System.Windows.Forms.Button()
        Me.btnLongTimeFormat = New System.Windows.Forms.Button()
        Me.btnExponentialFormat = New System.Windows.Forms.Button()
        Me.btnShortTimeFormat = New System.Windows.Forms.Button()
        Me.btnCurrencyFormat = New System.Windows.Forms.Button()
        Me.btnFixedPointFormat = New System.Windows.Forms.Button()
        Me.btnLongDateFormat = New System.Windows.Forms.Button()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.btnShortDateFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtUserEntry = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFullDateTimeFormat)
        Me.GroupBox1.Controls.Add(Me.btnPercentFormat)
        Me.GroupBox1.Controls.Add(Me.btnLongTimeFormat)
        Me.GroupBox1.Controls.Add(Me.btnExponentialFormat)
        Me.GroupBox1.Controls.Add(Me.btnShortTimeFormat)
        Me.GroupBox1.Controls.Add(Me.btnCurrencyFormat)
        Me.GroupBox1.Controls.Add(Me.btnFixedPointFormat)
        Me.GroupBox1.Controls.Add(Me.btnLongDateFormat)
        Me.GroupBox1.Controls.Add(Me.btnNumberFormat)
        Me.GroupBox1.Controls.Add(Me.btnShortDateFormat)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 227)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Format"
        '
        'btnFullDateTimeFormat
        '
        Me.btnFullDateTimeFormat.Location = New System.Drawing.Point(210, 165)
        Me.btnFullDateTimeFormat.Name = "btnFullDateTimeFormat"
        Me.btnFullDateTimeFormat.Size = New System.Drawing.Size(103, 23)
        Me.btnFullDateTimeFormat.TabIndex = 9
        Me.btnFullDateTimeFormat.Text = "Full Date/Time (F)"
        Me.btnFullDateTimeFormat.UseVisualStyleBackColor = True
        '
        'btnPercentFormat
        '
        Me.btnPercentFormat.Location = New System.Drawing.Point(43, 165)
        Me.btnPercentFormat.Name = "btnPercentFormat"
        Me.btnPercentFormat.Size = New System.Drawing.Size(121, 23)
        Me.btnPercentFormat.TabIndex = 8
        Me.btnPercentFormat.Text = "Percent Format (p)"
        Me.btnPercentFormat.UseVisualStyleBackColor = True
        '
        'btnLongTimeFormat
        '
        Me.btnLongTimeFormat.Location = New System.Drawing.Point(210, 136)
        Me.btnLongTimeFormat.Name = "btnLongTimeFormat"
        Me.btnLongTimeFormat.Size = New System.Drawing.Size(103, 23)
        Me.btnLongTimeFormat.TabIndex = 7
        Me.btnLongTimeFormat.Text = "Long Time (T)"
        Me.btnLongTimeFormat.UseVisualStyleBackColor = True
        '
        'btnExponentialFormat
        '
        Me.btnExponentialFormat.Location = New System.Drawing.Point(43, 107)
        Me.btnExponentialFormat.Name = "btnExponentialFormat"
        Me.btnExponentialFormat.Size = New System.Drawing.Size(121, 23)
        Me.btnExponentialFormat.TabIndex = 6
        Me.btnExponentialFormat.Text = "Exponential format (e)"
        Me.btnExponentialFormat.UseVisualStyleBackColor = True
        '
        'btnShortTimeFormat
        '
        Me.btnShortTimeFormat.Location = New System.Drawing.Point(210, 107)
        Me.btnShortTimeFormat.Name = "btnShortTimeFormat"
        Me.btnShortTimeFormat.Size = New System.Drawing.Size(103, 23)
        Me.btnShortTimeFormat.TabIndex = 5
        Me.btnShortTimeFormat.Text = "Short Time (t)"
        Me.btnShortTimeFormat.UseVisualStyleBackColor = True
        '
        'btnCurrencyFormat
        '
        Me.btnCurrencyFormat.Location = New System.Drawing.Point(43, 136)
        Me.btnCurrencyFormat.Name = "btnCurrencyFormat"
        Me.btnCurrencyFormat.Size = New System.Drawing.Size(121, 23)
        Me.btnCurrencyFormat.TabIndex = 4
        Me.btnCurrencyFormat.Text = "Currency Format (c)"
        Me.btnCurrencyFormat.UseVisualStyleBackColor = True
        '
        'btnFixedPointFormat
        '
        Me.btnFixedPointFormat.Location = New System.Drawing.Point(43, 78)
        Me.btnFixedPointFormat.Name = "btnFixedPointFormat"
        Me.btnFixedPointFormat.Size = New System.Drawing.Size(121, 23)
        Me.btnFixedPointFormat.TabIndex = 3
        Me.btnFixedPointFormat.Text = "Fixed-point format (f)"
        Me.btnFixedPointFormat.UseVisualStyleBackColor = True
        '
        'btnLongDateFormat
        '
        Me.btnLongDateFormat.Location = New System.Drawing.Point(210, 78)
        Me.btnLongDateFormat.Name = "btnLongDateFormat"
        Me.btnLongDateFormat.Size = New System.Drawing.Size(103, 23)
        Me.btnLongDateFormat.TabIndex = 2
        Me.btnLongDateFormat.Text = "Long Date (D)"
        Me.btnLongDateFormat.UseVisualStyleBackColor = True
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Location = New System.Drawing.Point(43, 49)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(121, 23)
        Me.btnNumberFormat.TabIndex = 1
        Me.btnNumberFormat.Text = "Number format (n)"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'btnShortDateFormat
        '
        Me.btnShortDateFormat.Location = New System.Drawing.Point(210, 49)
        Me.btnShortDateFormat.Name = "btnShortDateFormat"
        Me.btnShortDateFormat.Size = New System.Drawing.Size(103, 23)
        Me.btnShortDateFormat.TabIndex = 0
        Me.btnShortDateFormat.Text = "Short date (d)"
        Me.btnShortDateFormat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a number or date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Formatted"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(171, 98)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(169, 23)
        Me.lblResult.TabIndex = 3
        '
        'txtUserEntry
        '
        Me.txtUserEntry.Location = New System.Drawing.Point(190, 34)
        Me.txtUserEntry.Name = "txtUserEntry"
        Me.txtUserEntry.Size = New System.Drawing.Size(100, 20)
        Me.txtUserEntry.TabIndex = 4
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Red
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnExit.Location = New System.Drawing.Point(371, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(43, 38)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(426, 395)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.txtUserEntry)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFullDateTimeFormat As System.Windows.Forms.Button
    Friend WithEvents btnPercentFormat As System.Windows.Forms.Button
    Friend WithEvents btnLongTimeFormat As System.Windows.Forms.Button
    Friend WithEvents btnExponentialFormat As System.Windows.Forms.Button
    Friend WithEvents btnShortTimeFormat As System.Windows.Forms.Button
    Friend WithEvents btnCurrencyFormat As System.Windows.Forms.Button
    Friend WithEvents btnFixedPointFormat As System.Windows.Forms.Button
    Friend WithEvents btnLongDateFormat As System.Windows.Forms.Button
    Friend WithEvents btnNumberFormat As System.Windows.Forms.Button
    Friend WithEvents btnShortDateFormat As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtUserEntry As System.Windows.Forms.TextBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button

End Class
