<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTitleBar = New System.Windows.Forms.Panel()
        Me.lblAppSubtitle = New System.Windows.Forms.Label()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.lblSectionForm = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlTable = New System.Windows.Forms.Panel()
        Me.pnlTableHeader = New System.Windows.Forms.Panel()
        Me.lblSectionTable = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.pnlTableFooter = New System.Windows.Forms.Panel()
        Me.lblRowCount = New System.Windows.Forms.Label()
        Me.pnlTitleBar.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlTable.SuspendLayout()
        Me.pnlTableHeader.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTableFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.pnlTitleBar.Controls.Add(Me.lblAppSubtitle)
        Me.pnlTitleBar.Controls.Add(Me.lblAppTitle)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.pnlTitleBar.Size = New System.Drawing.Size(660, 64)
        Me.pnlTitleBar.TabIndex = 0
        '
        'lblAppSubtitle
        '
        Me.lblAppSubtitle.AutoSize = True
        Me.lblAppSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAppSubtitle.Location = New System.Drawing.Point(22, 36)
        Me.lblAppSubtitle.Name = "lblAppSubtitle"
        Me.lblAppSubtitle.Size = New System.Drawing.Size(214, 15)
        Me.lblAppSubtitle.TabIndex = 0
        Me.lblAppSubtitle.Text = "Tambah, ubah, atau hapus data produk"
        '
        'lblAppTitle
        '
        Me.lblAppTitle.AutoSize = True
        Me.lblAppTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppTitle.ForeColor = System.Drawing.Color.White
        Me.lblAppTitle.Location = New System.Drawing.Point(20, 10)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(453, 25)
        Me.lblAppTitle.TabIndex = 1
        Me.lblAppTitle.Text = "CRUD MENGGUNAKAN ENTITIY FRAMEWORK + OOP"
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlForm.Controls.Add(Me.lblSectionForm)
        Me.pnlForm.Controls.Add(Me.lblName)
        Me.pnlForm.Controls.Add(Me.txtName)
        Me.pnlForm.Controls.Add(Me.lblPrice)
        Me.pnlForm.Controls.Add(Me.txtPrice)
        Me.pnlForm.Controls.Add(Me.lblStock)
        Me.pnlForm.Controls.Add(Me.txtStock)
        Me.pnlForm.Location = New System.Drawing.Point(20, 80)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlForm.Size = New System.Drawing.Size(620, 190)
        Me.pnlForm.TabIndex = 1
        '
        'lblSectionForm
        '
        Me.lblSectionForm.AutoSize = True
        Me.lblSectionForm.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblSectionForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblSectionForm.Location = New System.Drawing.Point(16, 14)
        Me.lblSectionForm.Name = "lblSectionForm"
        Me.lblSectionForm.Size = New System.Drawing.Size(75, 13)
        Me.lblSectionForm.TabIndex = 0
        Me.lblSectionForm.Text = "FORM INPUT"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(16, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(82, 15)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Nama Produk"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(16, 60)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(586, 25)
        Me.txtName.TabIndex = 0
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(16, 100)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(66, 15)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Harga (Rp)"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.White
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(16, 120)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(286, 25)
        Me.txtPrice.TabIndex = 1
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblStock.Location = New System.Drawing.Point(316, 100)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(33, 15)
        Me.lblStock.TabIndex = 3
        Me.lblStock.Text = "Stok"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.White
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStock.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtStock.Location = New System.Drawing.Point(316, 120)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(286, 25)
        Me.txtStock.TabIndex = 2
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.Transparent
        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Controls.Add(Me.btnUpdate)
        Me.pnlButtons.Controls.Add(Me.btnDelete)
        Me.pnlButtons.Controls.Add(Me.btnClear)
        Me.pnlButtons.Location = New System.Drawing.Point(20, 280)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(620, 50)
        Me.pnlButtons.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(0, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(140, 40)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "  Simpan"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(150, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(140, 40)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "  Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(300, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(140, 40)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "  Hapus"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(450, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 40)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "  Reset Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'pnlTable
        '
        Me.pnlTable.BackColor = System.Drawing.Color.White
        Me.pnlTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTable.Controls.Add(Me.pnlTableHeader)
        Me.pnlTable.Controls.Add(Me.dgvProducts)
        Me.pnlTable.Controls.Add(Me.pnlTableFooter)
        Me.pnlTable.Location = New System.Drawing.Point(20, 345)
        Me.pnlTable.Name = "pnlTable"
        Me.pnlTable.Size = New System.Drawing.Size(620, 310)
        Me.pnlTable.TabIndex = 3
        '
        'pnlTableHeader
        '
        Me.pnlTableHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlTableHeader.Controls.Add(Me.lblSectionTable)
        Me.pnlTableHeader.Controls.Add(Me.lblSearch)
        Me.pnlTableHeader.Controls.Add(Me.txtSearch)
        Me.pnlTableHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTableHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlTableHeader.Name = "pnlTableHeader"
        Me.pnlTableHeader.Size = New System.Drawing.Size(618, 50)
        Me.pnlTableHeader.TabIndex = 0
        '
        'lblSectionTable
        '
        Me.lblSectionTable.AutoSize = True
        Me.lblSectionTable.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblSectionTable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblSectionTable.Location = New System.Drawing.Point(14, 17)
        Me.lblSectionTable.Name = "lblSectionTable"
        Me.lblSectionTable.Size = New System.Drawing.Size(97, 13)
        Me.lblSectionTable.TabIndex = 0
        Me.lblSectionTable.Text = "DAFTAR PRODUK"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(338, 16)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(31, 15)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Cari:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(372, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(230, 23)
        Me.txtSearch.TabIndex = 7
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.White
        Me.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProducts.ColumnHeadersHeight = 40
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducts.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProducts.EnableHeadersVisualStyles = False
        Me.dgvProducts.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvProducts.Location = New System.Drawing.Point(0, 50)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowTemplate.Height = 38
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(618, 222)
        Me.dgvProducts.TabIndex = 8
        '
        'pnlTableFooter
        '
        Me.pnlTableFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlTableFooter.Controls.Add(Me.lblRowCount)
        Me.pnlTableFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTableFooter.Location = New System.Drawing.Point(0, 272)
        Me.pnlTableFooter.Name = "pnlTableFooter"
        Me.pnlTableFooter.Size = New System.Drawing.Size(618, 36)
        Me.pnlTableFooter.TabIndex = 9
        '
        'lblRowCount
        '
        Me.lblRowCount.AutoSize = True
        Me.lblRowCount.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblRowCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblRowCount.Location = New System.Drawing.Point(14, 10)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(114, 15)
        Me.lblRowCount.TabIndex = 0
        Me.lblRowCount.Text = "0 produk ditemukan"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 675)
        Me.Controls.Add(Me.pnlTitleBar)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlTable)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produk CRUD Menggunakan ORM EF - YT : Developer Ngantuk"
        Me.pnlTitleBar.ResumeLayout(False)
        Me.pnlTitleBar.PerformLayout()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlTable.ResumeLayout(False)
        Me.pnlTableHeader.ResumeLayout(False)
        Me.pnlTableHeader.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTableFooter.ResumeLayout(False)
        Me.pnlTableFooter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    ' ===== CONTROL DECLARATIONS =====
    Friend WithEvents pnlTitleBar As System.Windows.Forms.Panel
    Friend WithEvents lblAppTitle As System.Windows.Forms.Label
    Friend WithEvents lblAppSubtitle As System.Windows.Forms.Label
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblSectionForm As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents pnlTable As System.Windows.Forms.Panel
    Friend WithEvents pnlTableHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSectionTable As System.Windows.Forms.Label
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents pnlTableFooter As System.Windows.Forms.Panel
    Friend WithEvents lblRowCount As System.Windows.Forms.Label
End Class