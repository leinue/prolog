﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWin
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Codebox = New System.Windows.Forms.TextBox()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListenerBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DebugBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Codebox
        '
        Me.Codebox.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Codebox.Location = New System.Drawing.Point(2, 21)
        Me.Codebox.Multiline = True
        Me.Codebox.Name = "Codebox"
        Me.Codebox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Codebox.Size = New System.Drawing.Size(389, 206)
        Me.Codebox.TabIndex = 0
        Me.Codebox.Text = "human(kate,a)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "human(bill)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "likes(kate,bill)"
        '
        'ResultBox
        '
        Me.ResultBox.Location = New System.Drawing.Point(2, 372)
        Me.ResultBox.Multiline = True
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ResultBox.Size = New System.Drawing.Size(389, 107)
        Me.ResultBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Dispel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Listener:"
        '
        'ListenerBox
        '
        Me.ListenerBox.Location = New System.Drawing.Point(2, 261)
        Me.ListenerBox.Multiline = True
        Me.ListenerBox.Name = "ListenerBox"
        Me.ListenerBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ListenerBox.Size = New System.Drawing.Size(389, 56)
        Me.ListenerBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Result:"
        '
        'DebugBox
        '
        Me.DebugBox.Location = New System.Drawing.Point(411, 43)
        Me.DebugBox.Multiline = True
        Me.DebugBox.Name = "DebugBox"
        Me.DebugBox.ReadOnly = True
        Me.DebugBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DebugBox.Size = New System.Drawing.Size(238, 426)
        Me.DebugBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(410, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Debug"
        '
        'MainWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 485)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DebugBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListenerBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.Codebox)
        Me.Name = "MainWin"
        Me.Text = "Prolog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Codebox As System.Windows.Forms.TextBox
    Friend WithEvents ResultBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListenerBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DebugBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class