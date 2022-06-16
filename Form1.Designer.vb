<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbnhundred = New System.Windows.Forms.RadioButton()
        Me.rbnsixty = New System.Windows.Forms.RadioButton()
        Me.rbnfifty = New System.Windows.Forms.RadioButton()
        Me.rbntwentyfive = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAmountpaid = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbnhundred)
        Me.GroupBox1.Controls.Add(Me.rbnsixty)
        Me.GroupBox1.Controls.Add(Me.rbnfifty)
        Me.GroupBox1.Controls.Add(Me.rbntwentyfive)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Percentage payable"
        '
        'rbnhundred
        '
        Me.rbnhundred.AutoSize = True
        Me.rbnhundred.Checked = True
        Me.rbnhundred.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbnhundred.Location = New System.Drawing.Point(149, 70)
        Me.rbnhundred.Name = "rbnhundred"
        Me.rbnhundred.Size = New System.Drawing.Size(77, 26)
        Me.rbnhundred.TabIndex = 3
        Me.rbnhundred.TabStop = True
        Me.rbnhundred.Text = "100%"
        Me.rbnhundred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbnhundred.UseVisualStyleBackColor = True
        '
        'rbnsixty
        '
        Me.rbnsixty.AutoSize = True
        Me.rbnsixty.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbnsixty.Location = New System.Drawing.Point(149, 38)
        Me.rbnsixty.Name = "rbnsixty"
        Me.rbnsixty.Size = New System.Drawing.Size(66, 26)
        Me.rbnsixty.TabIndex = 2
        Me.rbnsixty.Text = "60%"
        Me.rbnsixty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbnsixty.UseVisualStyleBackColor = True
        '
        'rbnfifty
        '
        Me.rbnfifty.AutoSize = True
        Me.rbnfifty.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbnfifty.Location = New System.Drawing.Point(17, 70)
        Me.rbnfifty.Name = "rbnfifty"
        Me.rbnfifty.Size = New System.Drawing.Size(66, 26)
        Me.rbnfifty.TabIndex = 1
        Me.rbnfifty.Text = "50%"
        Me.rbnfifty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbnfifty.UseVisualStyleBackColor = True
        '
        'rbntwentyfive
        '
        Me.rbntwentyfive.AutoSize = True
        Me.rbntwentyfive.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbntwentyfive.Location = New System.Drawing.Point(17, 38)
        Me.rbntwentyfive.Name = "rbntwentyfive"
        Me.rbntwentyfive.Size = New System.Drawing.Size(66, 26)
        Me.rbntwentyfive.TabIndex = 0
        Me.rbntwentyfive.Text = "25%"
        Me.rbntwentyfive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbntwentyfive.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(654, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GHANA COMMUNICATION TECHNOLOGY UNIVERSITY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(289, 78)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(367, 116)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Welcome to the GCTU fee payment platform. Enter you Index Number, Credit card num" &
    "ber,and Pin then the percentage you want to pay and press the button below." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(557, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Pay"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Amount Paid:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(6, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Balance:"
        '
        'txtAmountpaid
        '
        Me.txtAmountpaid.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAmountpaid.Location = New System.Drawing.Point(114, 53)
        Me.txtAmountpaid.Name = "txtAmountpaid"
        Me.txtAmountpaid.ReadOnly = True
        Me.txtAmountpaid.Size = New System.Drawing.Size(148, 22)
        Me.txtAmountpaid.TabIndex = 9
        Me.txtAmountpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBalance
        '
        Me.txtBalance.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBalance.Location = New System.Drawing.Point(114, 91)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(148, 22)
        Me.txtBalance.TabIndex = 10
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBalance)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtAmountpaid)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 252)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 139)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Receipt "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(18, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Student ID:"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStudentID.Location = New System.Drawing.Point(116, 77)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(148, 22)
        Me.txtStudentID.TabIndex = 6
        Me.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(668, 421)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "GCTU Fees Payment Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbnhundred As RadioButton
    Friend WithEvents rbnsixty As RadioButton
    Friend WithEvents rbnfifty As RadioButton
    Friend WithEvents rbntwentyfive As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAmountpaid As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudentID As TextBox
End Class
