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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.OwTime = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.countTime = New System.Windows.Forms.Timer(Me.components)
        Me.saveTime = New System.Windows.Forms.Timer(Me.components)
        Me.checkUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.checkProcess = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbCsTxt = New System.Windows.Forms.Label()
        Me.labelCurrent = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OwTime
        '
        Me.OwTime.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.OwTime.BalloonTipText = "Overwatch Time Counter"
        Me.OwTime.BalloonTipTitle = "Now running in the background."
        Me.OwTime.Icon = CType(resources.GetObject("OwTime.Icon"), System.Drawing.Icon)
        Me.OwTime.Text = "Overwatch Counter"
        Me.OwTime.Visible = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Reset Time"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'countTime
        '
        Me.countTime.Interval = 1000
        '
        'saveTime
        '
        Me.saveTime.Interval = 300000
        '
        'checkUpdate
        '
        Me.checkUpdate.Enabled = True
        Me.checkUpdate.Interval = 3600000
        '
        'labelTotal
        '
        Me.labelTotal.AutoSize = True
        Me.labelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotal.ForeColor = System.Drawing.Color.DarkOrange
        Me.labelTotal.Location = New System.Drawing.Point(39, 108)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(109, 39)
        Me.labelTotal.TabIndex = 1
        Me.labelTotal.Text = "NULL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Time (h:m:s) :"
        '
        'checkProcess
        '
        Me.checkProcess.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(345, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Version"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(5, 216)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 29)
        Me.LinkLabel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "The time will count automatically when Overwatch is open."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ALT+TAB out of Overwatch if you're unsure."
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(408, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(66, 13)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "By Yernemm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(404, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Minimising this will hide it in the system tray. In the bottom-right corner of th" &
    "e task bar."
        '
        'lbCsTxt
        '
        Me.lbCsTxt.AutoSize = True
        Me.lbCsTxt.Location = New System.Drawing.Point(46, 151)
        Me.lbCsTxt.Name = "lbCsTxt"
        Me.lbCsTxt.Size = New System.Drawing.Size(82, 13)
        Me.lbCsTxt.TabIndex = 9
        Me.lbCsTxt.Text = "Current session:"
        '
        'labelCurrent
        '
        Me.labelCurrent.AutoSize = True
        Me.labelCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCurrent.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelCurrent.Location = New System.Drawing.Point(43, 164)
        Me.labelCurrent.Name = "labelCurrent"
        Me.labelCurrent.Size = New System.Drawing.Size(88, 31)
        Me.labelCurrent.TabIndex = 10
        Me.labelCurrent.Text = "NULL"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Changelog"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(203, 277)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 35)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Settings and Info"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 320)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.labelCurrent)
        Me.Controls.Add(Me.lbCsTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelTotal)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Overwatch Time Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OwTime As NotifyIcon
    Friend WithEvents Button1 As Button
    Friend WithEvents countTime As Timer
    Friend WithEvents saveTime As Timer
    Friend WithEvents checkUpdate As Timer
    Friend WithEvents labelTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents checkProcess As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents lbCsTxt As Label
    Friend WithEvents labelCurrent As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
