<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAgregarVenta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbxCliente = New System.Windows.Forms.ComboBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Floreria20DataSet1 = New PFR_Floreria.Floreria20DataSet1()
        Me.CmbxTipoVenta = New System.Windows.Forms.ComboBox()
        Me.TipoVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbxTipoPago = New System.Windows.Forms.ComboBox()
        Me.TipoPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.VentaTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClienteTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.ClienteTableAdapter()
        Me.Tipo_VentaTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Tipo_VentaTableAdapter()
        Me.Tipo_PagoTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Tipo_PagoTableAdapter()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("212 Orion Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VENTA"
        '
        'BtnAgregarVenta
        '
        Me.BtnAgregarVenta.BackColor = System.Drawing.Color.Black
        Me.BtnAgregarVenta.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarVenta.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarVenta.Location = New System.Drawing.Point(434, 434)
        Me.BtnAgregarVenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarVenta.Name = "BtnAgregarVenta"
        Me.BtnAgregarVenta.Size = New System.Drawing.Size(111, 38)
        Me.BtnAgregarVenta.TabIndex = 32
        Me.BtnAgregarVenta.Text = "AGREGAR"
        Me.BtnAgregarVenta.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(430, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Fecha Venta"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(536, 237)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(178, 31)
        Me.DateTimePicker1.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(430, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 18)
        Me.Label4.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(431, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 18)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(431, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Tipo Venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(431, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 18)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Tipo Pago"
        '
        'CmbxCliente
        '
        Me.CmbxCliente.DataSource = Me.ClienteBindingSource
        Me.CmbxCliente.DisplayMember = "nombre"
        Me.CmbxCliente.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxCliente.FormattingEnabled = True
        Me.CmbxCliente.Location = New System.Drawing.Point(536, 287)
        Me.CmbxCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxCliente.Name = "CmbxCliente"
        Me.CmbxCliente.Size = New System.Drawing.Size(178, 26)
        Me.CmbxCliente.TabIndex = 44
        Me.CmbxCliente.ValueMember = "id"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'Floreria20DataSet1
        '
        Me.Floreria20DataSet1.DataSetName = "Floreria20DataSet1"
        Me.Floreria20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbxTipoVenta
        '
        Me.CmbxTipoVenta.DataSource = Me.TipoVentaBindingSource
        Me.CmbxTipoVenta.DisplayMember = "descripcion"
        Me.CmbxTipoVenta.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxTipoVenta.FormattingEnabled = True
        Me.CmbxTipoVenta.Location = New System.Drawing.Point(536, 325)
        Me.CmbxTipoVenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxTipoVenta.Name = "CmbxTipoVenta"
        Me.CmbxTipoVenta.Size = New System.Drawing.Size(178, 26)
        Me.CmbxTipoVenta.TabIndex = 45
        Me.CmbxTipoVenta.ValueMember = "id"
        '
        'TipoVentaBindingSource
        '
        Me.TipoVentaBindingSource.DataMember = "Tipo_Venta"
        Me.TipoVentaBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'CmbxTipoPago
        '
        Me.CmbxTipoPago.DataSource = Me.TipoPagoBindingSource
        Me.CmbxTipoPago.DisplayMember = "descripcion"
        Me.CmbxTipoPago.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxTipoPago.FormattingEnabled = True
        Me.CmbxTipoPago.Location = New System.Drawing.Point(536, 370)
        Me.CmbxTipoPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxTipoPago.Name = "CmbxTipoPago"
        Me.CmbxTipoPago.Size = New System.Drawing.Size(178, 26)
        Me.CmbxTipoPago.TabIndex = 46
        Me.CmbxTipoPago.ValueMember = "id"
        '
        'TipoPagoBindingSource
        '
        Me.TipoPagoBindingSource.DataMember = "Tipo_Pago"
        Me.TipoPagoBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(116, 118)
        Me.TxtCantidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(148, 31)
        Me.TxtCantidad.TabIndex = 47
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArticulo.Location = New System.Drawing.Point(116, 81)
        Me.TxtArticulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.Size = New System.Drawing.Size(148, 31)
        Me.TxtArticulo.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 18)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Articulo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 18)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Cantidad"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.Descripcion, Me.Cantidad, Me.Costo})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Location = New System.Drawing.Point(12, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(391, 273)
        Me.DataGridView1.TabIndex = 51
        '
        'Clave
        '
        Me.Clave.HeaderText = "Clave"
        Me.Clave.MinimumWidth = 6
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        Me.Clave.Width = 125
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 125
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 125
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.MinimumWidth = 6
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Width = 125
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "Venta"
        Me.VentaBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.pictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 49)
        Me.Panel1.TabIndex = 55
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Tipo_VentaTableAdapter
        '
        Me.Tipo_VentaTableAdapter.ClearBeforeFill = True
        '
        'Tipo_PagoTableAdapter
        '
        Me.Tipo_PagoTableAdapter.ClearBeforeFill = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(701, 2)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(61, 49)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 70
        Me.pictureBox1.TabStop = False
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(758, 531)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtArticulo)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.CmbxTipoPago)
        Me.Controls.Add(Me.CmbxTipoVenta)
        Me.Controls.Add(Me.CmbxCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAgregarVenta)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Venta"
        Me.Text = "Venta"
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAgregarVenta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbxCliente As ComboBox
    Friend WithEvents CmbxTipoVenta As ComboBox
    Friend WithEvents CmbxTipoPago As ComboBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtArticulo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Floreria20DataSet1 As Floreria20DataSet1
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As Floreria20DataSet1TableAdapters.VentaTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As Floreria20DataSet1TableAdapters.ClienteTableAdapter
    Friend WithEvents TipoVentaBindingSource As BindingSource
    Friend WithEvents Tipo_VentaTableAdapter As Floreria20DataSet1TableAdapters.Tipo_VentaTableAdapter
    Friend WithEvents TipoPagoBindingSource As BindingSource
    Friend WithEvents Tipo_PagoTableAdapter As Floreria20DataSet1TableAdapters.Tipo_PagoTableAdapter
    Private WithEvents pictureBox1 As PictureBox
End Class
