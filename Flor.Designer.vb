<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Flor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEliminarFlor = New System.Windows.Forms.Button()
        Me.BtnActualizarFlor = New System.Windows.Forms.Button()
        Me.BtnAgregarFlor = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.CmbxTemporada = New System.Windows.Forms.ComboBox()
        Me.TemporadaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Floreria20DataSet1 = New PFR_Floreria.Floreria20DataSet1()
        Me.CmbxTipo = New System.Windows.Forms.ComboBox()
        Me.TipoFlorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdtemporadaflorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtipoflorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlorTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.FlorTableAdapter()
        Me.TemporadaTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.TemporadaTableAdapter()
        Me.Tipo_FlorTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Tipo_FlorTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TemporadaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoFlorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(536, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 22)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("212 Orion Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(601, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FLOR"
        '
        'BtnEliminarFlor
        '
        Me.BtnEliminarFlor.BackColor = System.Drawing.Color.Black
        Me.BtnEliminarFlor.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarFlor.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarFlor.Location = New System.Drawing.Point(686, 269)
        Me.BtnEliminarFlor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminarFlor.Name = "BtnEliminarFlor"
        Me.BtnEliminarFlor.Size = New System.Drawing.Size(99, 43)
        Me.BtnEliminarFlor.TabIndex = 23
        Me.BtnEliminarFlor.Text = "ELIMINAR"
        Me.BtnEliminarFlor.UseVisualStyleBackColor = False
        '
        'BtnActualizarFlor
        '
        Me.BtnActualizarFlor.BackColor = System.Drawing.Color.Black
        Me.BtnActualizarFlor.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarFlor.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarFlor.Location = New System.Drawing.Point(554, 269)
        Me.BtnActualizarFlor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizarFlor.Name = "BtnActualizarFlor"
        Me.BtnActualizarFlor.Size = New System.Drawing.Size(110, 43)
        Me.BtnActualizarFlor.TabIndex = 22
        Me.BtnActualizarFlor.Text = "ACTUALIZAR"
        Me.BtnActualizarFlor.UseVisualStyleBackColor = False
        '
        'BtnAgregarFlor
        '
        Me.BtnAgregarFlor.BackColor = System.Drawing.Color.Black
        Me.BtnAgregarFlor.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarFlor.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarFlor.Location = New System.Drawing.Point(435, 269)
        Me.BtnAgregarFlor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarFlor.Name = "BtnAgregarFlor"
        Me.BtnAgregarFlor.Size = New System.Drawing.Size(101, 43)
        Me.BtnAgregarFlor.TabIndex = 21
        Me.BtnAgregarFlor.Text = "AGREGAR"
        Me.BtnAgregarFlor.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(432, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Costo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(432, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Temporada"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(432, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Tipo"
        '
        'TxtColor
        '
        Me.TxtColor.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColor.Location = New System.Drawing.Point(539, 96)
        Me.TxtColor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(246, 31)
        Me.TxtColor.TabIndex = 31
        '
        'TxtCosto
        '
        Me.TxtCosto.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCosto.Location = New System.Drawing.Point(539, 136)
        Me.TxtCosto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(246, 31)
        Me.TxtCosto.TabIndex = 32
        '
        'CmbxTemporada
        '
        Me.CmbxTemporada.DataSource = Me.TemporadaBindingSource
        Me.CmbxTemporada.DisplayMember = "descripcion"
        Me.CmbxTemporada.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxTemporada.FormattingEnabled = True
        Me.CmbxTemporada.Location = New System.Drawing.Point(539, 182)
        Me.CmbxTemporada.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxTemporada.Name = "CmbxTemporada"
        Me.CmbxTemporada.Size = New System.Drawing.Size(246, 26)
        Me.CmbxTemporada.TabIndex = 33
        Me.CmbxTemporada.ValueMember = "id"
        '
        'TemporadaBindingSource
        '
        Me.TemporadaBindingSource.DataMember = "Temporada"
        Me.TemporadaBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'Floreria20DataSet1
        '
        Me.Floreria20DataSet1.DataSetName = "Floreria20DataSet1"
        Me.Floreria20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbxTipo
        '
        Me.CmbxTipo.DataSource = Me.TipoFlorBindingSource
        Me.CmbxTipo.DisplayMember = "descripcion"
        Me.CmbxTipo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxTipo.FormattingEnabled = True
        Me.CmbxTipo.Location = New System.Drawing.Point(539, 224)
        Me.CmbxTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxTipo.Name = "CmbxTipo"
        Me.CmbxTipo.Size = New System.Drawing.Size(246, 26)
        Me.CmbxTipo.TabIndex = 34
        Me.CmbxTipo.ValueMember = "id"
        '
        'TipoFlorBindingSource
        '
        Me.TipoFlorBindingSource.DataMember = "Tipo_Flor"
        Me.TipoFlorBindingSource.DataSource = Me.Floreria20DataSet1
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.IdtemporadaflorDataGridViewTextBoxColumn, Me.IdtipoflorDataGridViewTextBoxColumn, Me.EmpleadocreaDataGridViewTextBoxColumn, Me.EmpleadoactualizaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FlorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(33, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(367, 243)
        Me.DataGridView1.TabIndex = 35
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
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "color"
        Me.ColorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.Width = 125
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.Width = 125
        '
        'IdtemporadaflorDataGridViewTextBoxColumn
        '
        Me.IdtemporadaflorDataGridViewTextBoxColumn.DataPropertyName = "id_temporada_flor"
        Me.IdtemporadaflorDataGridViewTextBoxColumn.HeaderText = "id_temporada_flor"
        Me.IdtemporadaflorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdtemporadaflorDataGridViewTextBoxColumn.Name = "IdtemporadaflorDataGridViewTextBoxColumn"
        Me.IdtemporadaflorDataGridViewTextBoxColumn.Width = 125
        '
        'IdtipoflorDataGridViewTextBoxColumn
        '
        Me.IdtipoflorDataGridViewTextBoxColumn.DataPropertyName = "id_tipo_flor"
        Me.IdtipoflorDataGridViewTextBoxColumn.HeaderText = "id_tipo_flor"
        Me.IdtipoflorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdtipoflorDataGridViewTextBoxColumn.Name = "IdtipoflorDataGridViewTextBoxColumn"
        Me.IdtipoflorDataGridViewTextBoxColumn.Width = 125
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
        'FlorBindingSource
        '
        Me.FlorBindingSource.DataMember = "Flor"
        Me.FlorBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'FlorTableAdapter
        '
        Me.FlorTableAdapter.ClearBeforeFill = True
        '
        'TemporadaTableAdapter
        '
        Me.TemporadaTableAdapter.ClearBeforeFill = True
        '
        'Tipo_FlorTableAdapter
        '
        Me.Tipo_FlorTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.pictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-176, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 49)
        Me.Panel1.TabIndex = 52
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(915, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(61, 49)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 70
        Me.pictureBox1.TabStop = False
        '
        'Flor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(799, 351)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbxTipo)
        Me.Controls.Add(Me.CmbxTemporada)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.TxtColor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnEliminarFlor)
        Me.Controls.Add(Me.BtnActualizarFlor)
        Me.Controls.Add(Me.BtnAgregarFlor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Flor"
        Me.Text = "Flor"
        CType(Me.TemporadaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoFlorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEliminarFlor As Button
    Friend WithEvents BtnActualizarFlor As Button
    Friend WithEvents BtnAgregarFlor As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents CmbxTemporada As ComboBox
    Friend WithEvents CmbxTipo As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Floreria20DataSet1 As Floreria20DataSet1
    Friend WithEvents FlorBindingSource As BindingSource
    Friend WithEvents FlorTableAdapter As Floreria20DataSet1TableAdapters.FlorTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdtemporadaflorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdtipoflorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TemporadaBindingSource As BindingSource
    Friend WithEvents TemporadaTableAdapter As Floreria20DataSet1TableAdapters.TemporadaTableAdapter
    Friend WithEvents TipoFlorBindingSource As BindingSource
    Friend WithEvents Tipo_FlorTableAdapter As Floreria20DataSet1TableAdapters.Tipo_FlorTableAdapter
    Friend WithEvents Panel1 As Panel
    Private WithEvents pictureBox1 As PictureBox
End Class
