<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Arreglo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Arreglo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminarArreglo = New System.Windows.Forms.Button()
        Me.BtnActualizarArreglo = New System.Windows.Forms.Button()
        Me.BtnAgregarArreglo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtColorArreglo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecioArreglo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbxTipoArreglo = New System.Windows.Forms.ComboBox()
        Me.TipoArregloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Floreria20DataSet1 = New PFR_Floreria.Floreria20DataSet1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbxTamanio = New System.Windows.Forms.ComboBox()
        Me.TamanioArregloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdtipoarregloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtamanioarregloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArregloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArregloTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.ArregloTableAdapter()
        Me.ArregloBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipo_ArregloTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Tipo_ArregloTableAdapter()
        Me.Tamanio_ArregloTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Tamanio_ArregloTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNombreArreglo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TipoArregloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TamanioArregloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArregloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArregloBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("212 Orion Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(555, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ARREGLO"
        '
        'BtnEliminarArreglo
        '
        Me.BtnEliminarArreglo.BackColor = System.Drawing.Color.Black
        Me.BtnEliminarArreglo.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarArreglo.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarArreglo.Location = New System.Drawing.Point(664, 340)
        Me.BtnEliminarArreglo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminarArreglo.Name = "BtnEliminarArreglo"
        Me.BtnEliminarArreglo.Size = New System.Drawing.Size(104, 39)
        Me.BtnEliminarArreglo.TabIndex = 27
        Me.BtnEliminarArreglo.Text = "ELIMINAR"
        Me.BtnEliminarArreglo.UseVisualStyleBackColor = False
        '
        'BtnActualizarArreglo
        '
        Me.BtnActualizarArreglo.BackColor = System.Drawing.Color.Black
        Me.BtnActualizarArreglo.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarArreglo.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarArreglo.Location = New System.Drawing.Point(526, 339)
        Me.BtnActualizarArreglo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizarArreglo.Name = "BtnActualizarArreglo"
        Me.BtnActualizarArreglo.Size = New System.Drawing.Size(127, 41)
        Me.BtnActualizarArreglo.TabIndex = 26
        Me.BtnActualizarArreglo.Text = "ACTUALIZAR"
        Me.BtnActualizarArreglo.UseVisualStyleBackColor = False
        '
        'BtnAgregarArreglo
        '
        Me.BtnAgregarArreglo.BackColor = System.Drawing.Color.Black
        Me.BtnAgregarArreglo.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarArreglo.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarArreglo.Location = New System.Drawing.Point(411, 339)
        Me.BtnAgregarArreglo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarArreglo.Name = "BtnAgregarArreglo"
        Me.BtnAgregarArreglo.Size = New System.Drawing.Size(102, 41)
        Me.BtnAgregarArreglo.TabIndex = 25
        Me.BtnAgregarArreglo.Text = "AGREGAR"
        Me.BtnAgregarArreglo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(521, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 24
        '
        'TxtColorArreglo
        '
        Me.TxtColorArreglo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColorArreglo.Location = New System.Drawing.Point(500, 152)
        Me.TxtColorArreglo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtColorArreglo.Name = "TxtColorArreglo"
        Me.TxtColorArreglo.Size = New System.Drawing.Size(250, 31)
        Me.TxtColorArreglo.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Precio"
        '
        'TxtPrecioArreglo
        '
        Me.TxtPrecioArreglo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioArreglo.Location = New System.Drawing.Point(500, 200)
        Me.TxtPrecioArreglo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPrecioArreglo.Name = "TxtPrecioArreglo"
        Me.TxtPrecioArreglo.Size = New System.Drawing.Size(250, 31)
        Me.TxtPrecioArreglo.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(416, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 18)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Tipo "
        '
        'CmbxTipoArreglo
        '
        Me.CmbxTipoArreglo.DataSource = Me.TipoArregloBindingSource
        Me.CmbxTipoArreglo.DisplayMember = "descripcion"
        Me.CmbxTipoArreglo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxTipoArreglo.FormattingEnabled = True
        Me.CmbxTipoArreglo.Location = New System.Drawing.Point(500, 248)
        Me.CmbxTipoArreglo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxTipoArreglo.Name = "CmbxTipoArreglo"
        Me.CmbxTipoArreglo.Size = New System.Drawing.Size(250, 26)
        Me.CmbxTipoArreglo.TabIndex = 37
        Me.CmbxTipoArreglo.ValueMember = "id"
        '
        'TipoArregloBindingSource
        '
        Me.TipoArregloBindingSource.DataMember = "Tipo_Arreglo"
        Me.TipoArregloBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'Floreria20DataSet1
        '
        Me.Floreria20DataSet1.DataSetName = "Floreria20DataSet1"
        Me.Floreria20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 18)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Tamaño"
        '
        'CmbxTamanio
        '
        Me.CmbxTamanio.DataSource = Me.TamanioArregloBindingSource
        Me.CmbxTamanio.DisplayMember = "descripcion"
        Me.CmbxTamanio.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxTamanio.FormattingEnabled = True
        Me.CmbxTamanio.Location = New System.Drawing.Point(500, 289)
        Me.CmbxTamanio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxTamanio.Name = "CmbxTamanio"
        Me.CmbxTamanio.Size = New System.Drawing.Size(250, 26)
        Me.CmbxTamanio.TabIndex = 39
        Me.CmbxTamanio.ValueMember = "id"
        '
        'TamanioArregloBindingSource
        '
        Me.TamanioArregloBindingSource.DataMember = "Tamanio_Arreglo"
        Me.TamanioArregloBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.IdtipoarregloDataGridViewTextBoxColumn, Me.IdtamanioarregloDataGridViewTextBoxColumn, Me.EmpleadocreaDataGridViewTextBoxColumn, Me.EmpleadoactualizaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ArregloBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(15, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(371, 257)
        Me.DataGridView1.TabIndex = 40
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "color"
        Me.ColorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.Width = 125
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.Width = 125
        '
        'IdtipoarregloDataGridViewTextBoxColumn
        '
        Me.IdtipoarregloDataGridViewTextBoxColumn.DataPropertyName = "id_tipo_arreglo"
        Me.IdtipoarregloDataGridViewTextBoxColumn.HeaderText = "id_tipo_arreglo"
        Me.IdtipoarregloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdtipoarregloDataGridViewTextBoxColumn.Name = "IdtipoarregloDataGridViewTextBoxColumn"
        Me.IdtipoarregloDataGridViewTextBoxColumn.Width = 125
        '
        'IdtamanioarregloDataGridViewTextBoxColumn
        '
        Me.IdtamanioarregloDataGridViewTextBoxColumn.DataPropertyName = "id_tamanio_arreglo"
        Me.IdtamanioarregloDataGridViewTextBoxColumn.HeaderText = "id_tamanio_arreglo"
        Me.IdtamanioarregloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdtamanioarregloDataGridViewTextBoxColumn.Name = "IdtamanioarregloDataGridViewTextBoxColumn"
        Me.IdtamanioarregloDataGridViewTextBoxColumn.Width = 125
        '
        'EmpleadocreaDataGridViewTextBoxColumn
        '
        Me.EmpleadocreaDataGridViewTextBoxColumn.DataPropertyName = "empleado_crea"
        Me.EmpleadocreaDataGridViewTextBoxColumn.HeaderText = "empleado_crea"
        Me.EmpleadocreaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmpleadocreaDataGridViewTextBoxColumn.Name = "EmpleadocreaDataGridViewTextBoxColumn"
        Me.EmpleadocreaDataGridViewTextBoxColumn.Width = 125
        '
        'EmpleadoactualizaDataGridViewTextBoxColumn
        '
        Me.EmpleadoactualizaDataGridViewTextBoxColumn.DataPropertyName = "empleado_actualiza"
        Me.EmpleadoactualizaDataGridViewTextBoxColumn.HeaderText = "empleado_actualiza"
        Me.EmpleadoactualizaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmpleadoactualizaDataGridViewTextBoxColumn.Name = "EmpleadoactualizaDataGridViewTextBoxColumn"
        Me.EmpleadoactualizaDataGridViewTextBoxColumn.Width = 125
        '
        'ArregloBindingSource
        '
        Me.ArregloBindingSource.DataMember = "Arreglo"
        Me.ArregloBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'ArregloTableAdapter
        '
        Me.ArregloTableAdapter.ClearBeforeFill = True
        '
        'ArregloBindingSource1
        '
        Me.ArregloBindingSource1.DataMember = "Arreglo"
        Me.ArregloBindingSource1.DataSource = Me.Floreria20DataSet1
        '
        'Tipo_ArregloTableAdapter
        '
        Me.Tipo_ArregloTableAdapter.ClearBeforeFill = True
        '
        'Tamanio_ArregloTableAdapter
        '
        Me.Tamanio_ArregloTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(416, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Nombre"
        '
        'TxtNombreArreglo
        '
        Me.TxtNombreArreglo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreArreglo.Location = New System.Drawing.Point(500, 104)
        Me.TxtNombreArreglo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombreArreglo.Name = "TxtNombreArreglo"
        Me.TxtNombreArreglo.Size = New System.Drawing.Size(250, 31)
        Me.TxtNombreArreglo.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.pictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 49)
        Me.Panel1.TabIndex = 43
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(719, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(61, 49)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 70
        Me.pictureBox1.TabStop = False
        '
        'Arreglo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 406)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtNombreArreglo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbxTamanio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbxTipoArreglo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPrecioArreglo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtColorArreglo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnEliminarArreglo)
        Me.Controls.Add(Me.BtnActualizarArreglo)
        Me.Controls.Add(Me.BtnAgregarArreglo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Arreglo"
        Me.Text = "Arreglo"
        CType(Me.TipoArregloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TamanioArregloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArregloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArregloBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminarArreglo As Button
    Friend WithEvents BtnActualizarArreglo As Button
    Friend WithEvents BtnAgregarArreglo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtColorArreglo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPrecioArreglo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbxTipoArreglo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbxTamanio As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Floreria20DataSet1 As Floreria20DataSet1
    Friend WithEvents ArregloBindingSource As BindingSource
    Friend WithEvents ArregloTableAdapter As Floreria20DataSet1TableAdapters.ArregloTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdtipoarregloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdtamanioarregloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArregloBindingSource1 As BindingSource
    Friend WithEvents TipoArregloBindingSource As BindingSource
    Friend WithEvents Tipo_ArregloTableAdapter As Floreria20DataSet1TableAdapters.Tipo_ArregloTableAdapter
    Friend WithEvents TamanioArregloBindingSource As BindingSource
    Friend WithEvents Tamanio_ArregloTableAdapter As Floreria20DataSet1TableAdapters.Tamanio_ArregloTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNombreArreglo As TextBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents pictureBox1 As PictureBox
End Class
