<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flor_Arreglo
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Flor_Arreglo))
        Me.BtnEliminarFlorArreglo = New System.Windows.Forms.Button()
        Me.BtnActualizarFlorArreglo = New System.Windows.Forms.Button()
        Me.BtnAgregarFlorArreglo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbxArreglo = New System.Windows.Forms.ComboBox()
        Me.ArregloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Floreria20DataSet1 = New PFR_Floreria.Floreria20DataSet1()
        Me.CmbxFlor = New System.Windows.Forms.ComboBox()
        Me.FlorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlorArregloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Flor_ArregloTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.Flor_ArregloTableAdapter()
        Me.ArregloTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.ArregloTableAdapter()
        Me.FlorTableAdapter = New PFR_Floreria.Floreria20DataSet1TableAdapters.FlorTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdarregloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdflorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlorArregloBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtCantidadFlorArreglo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ArregloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlorArregloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlorArregloBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminarFlorArreglo
        '
        Me.BtnEliminarFlorArreglo.BackColor = System.Drawing.Color.Black
        Me.BtnEliminarFlorArreglo.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarFlorArreglo.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarFlorArreglo.Location = New System.Drawing.Point(699, 261)
        Me.BtnEliminarFlorArreglo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminarFlorArreglo.Name = "BtnEliminarFlorArreglo"
        Me.BtnEliminarFlorArreglo.Size = New System.Drawing.Size(93, 41)
        Me.BtnEliminarFlorArreglo.TabIndex = 31
        Me.BtnEliminarFlorArreglo.Text = "ELIMINAR"
        Me.BtnEliminarFlorArreglo.UseVisualStyleBackColor = False
        '
        'BtnActualizarFlorArreglo
        '
        Me.BtnActualizarFlorArreglo.BackColor = System.Drawing.Color.Black
        Me.BtnActualizarFlorArreglo.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarFlorArreglo.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarFlorArreglo.Location = New System.Drawing.Point(569, 261)
        Me.BtnActualizarFlorArreglo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizarFlorArreglo.Name = "BtnActualizarFlorArreglo"
        Me.BtnActualizarFlorArreglo.Size = New System.Drawing.Size(112, 41)
        Me.BtnActualizarFlorArreglo.TabIndex = 30
        Me.BtnActualizarFlorArreglo.Text = "ACTUALIZAR"
        Me.BtnActualizarFlorArreglo.UseVisualStyleBackColor = False
        '
        'BtnAgregarFlorArreglo
        '
        Me.BtnAgregarFlorArreglo.BackColor = System.Drawing.Color.Black
        Me.BtnAgregarFlorArreglo.Font = New System.Drawing.Font("212 Orion Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarFlorArreglo.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarFlorArreglo.Location = New System.Drawing.Point(457, 261)
        Me.BtnAgregarFlorArreglo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarFlorArreglo.Name = "BtnAgregarFlorArreglo"
        Me.BtnAgregarFlorArreglo.Size = New System.Drawing.Size(96, 41)
        Me.BtnAgregarFlorArreglo.TabIndex = 29
        Me.BtnAgregarFlorArreglo.Text = "AGREGAR"
        Me.BtnAgregarFlorArreglo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("212 Orion Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(577, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "FLOR ARREGLO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(458, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(458, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Arreglo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(458, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Flor"
        '
        'CmbxArreglo
        '
        Me.CmbxArreglo.DataSource = Me.ArregloBindingSource
        Me.CmbxArreglo.DisplayMember = "nombre"
        Me.CmbxArreglo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxArreglo.FormattingEnabled = True
        Me.CmbxArreglo.Location = New System.Drawing.Point(552, 157)
        Me.CmbxArreglo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxArreglo.Name = "CmbxArreglo"
        Me.CmbxArreglo.Size = New System.Drawing.Size(225, 26)
        Me.CmbxArreglo.TabIndex = 37
        Me.CmbxArreglo.ValueMember = "id"
        '
        'ArregloBindingSource
        '
        Me.ArregloBindingSource.DataMember = "Arreglo"
        Me.ArregloBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'Floreria20DataSet1
        '
        Me.Floreria20DataSet1.DataSetName = "Floreria20DataSet1"
        Me.Floreria20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbxFlor
        '
        Me.CmbxFlor.DataSource = Me.FlorBindingSource
        Me.CmbxFlor.DisplayMember = "color"
        Me.CmbxFlor.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbxFlor.FormattingEnabled = True
        Me.CmbxFlor.Location = New System.Drawing.Point(552, 202)
        Me.CmbxFlor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbxFlor.Name = "CmbxFlor"
        Me.CmbxFlor.Size = New System.Drawing.Size(225, 26)
        Me.CmbxFlor.TabIndex = 38
        Me.CmbxFlor.ValueMember = "id"
        '
        'FlorBindingSource
        '
        Me.FlorBindingSource.DataMember = "Flor"
        Me.FlorBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'FlorArregloBindingSource
        '
        Me.FlorArregloBindingSource.DataMember = "Flor_Arreglo"
        Me.FlorArregloBindingSource.DataSource = Me.Floreria20DataSet1
        '
        'Flor_ArregloTableAdapter
        '
        Me.Flor_ArregloTableAdapter.ClearBeforeFill = True
        '
        'ArregloTableAdapter
        '
        Me.ArregloTableAdapter.ClearBeforeFill = True
        '
        'FlorTableAdapter
        '
        Me.FlorTableAdapter.ClearBeforeFill = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.IdarregloDataGridViewTextBoxColumn, Me.IdflorDataGridViewTextBoxColumn, Me.EmpleadocreaDataGridViewTextBoxColumn, Me.EmpleadoactualizaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FlorArregloBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(25, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(391, 276)
        Me.DataGridView1.TabIndex = 39
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
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.Width = 125
        '
        'IdarregloDataGridViewTextBoxColumn
        '
        Me.IdarregloDataGridViewTextBoxColumn.DataPropertyName = "id_arreglo"
        Me.IdarregloDataGridViewTextBoxColumn.HeaderText = "id_arreglo"
        Me.IdarregloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdarregloDataGridViewTextBoxColumn.Name = "IdarregloDataGridViewTextBoxColumn"
        Me.IdarregloDataGridViewTextBoxColumn.Width = 125
        '
        'IdflorDataGridViewTextBoxColumn
        '
        Me.IdflorDataGridViewTextBoxColumn.DataPropertyName = "id_flor"
        Me.IdflorDataGridViewTextBoxColumn.HeaderText = "id_flor"
        Me.IdflorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdflorDataGridViewTextBoxColumn.Name = "IdflorDataGridViewTextBoxColumn"
        Me.IdflorDataGridViewTextBoxColumn.Width = 125
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
        'FlorArregloBindingSource1
        '
        Me.FlorArregloBindingSource1.DataMember = "Flor_Arreglo"
        Me.FlorArregloBindingSource1.DataSource = Me.Floreria20DataSet1
        '
        'TxtCantidadFlorArreglo
        '
        Me.TxtCantidadFlorArreglo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadFlorArreglo.Location = New System.Drawing.Point(552, 109)
        Me.TxtCantidadFlorArreglo.Name = "TxtCantidadFlorArreglo"
        Me.TxtCantidadFlorArreglo.Size = New System.Drawing.Size(225, 31)
        Me.TxtCantidadFlorArreglo.TabIndex = 40
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.pictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-117, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(945, 49)
        Me.Panel1.TabIndex = 53
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(862, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(61, 49)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 70
        Me.pictureBox1.TabStop = False
        '
        'Flor_Arreglo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 401)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtCantidadFlorArreglo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbxFlor)
        Me.Controls.Add(Me.CmbxArreglo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEliminarFlorArreglo)
        Me.Controls.Add(Me.BtnActualizarFlorArreglo)
        Me.Controls.Add(Me.BtnAgregarFlorArreglo)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Flor_Arreglo"
        Me.Text = "Flor_Arreglo"
        CType(Me.ArregloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floreria20DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlorArregloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlorArregloBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEliminarFlorArreglo As Button
    Friend WithEvents BtnActualizarFlorArreglo As Button
    Friend WithEvents BtnAgregarFlorArreglo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbxArreglo As ComboBox
    Friend WithEvents CmbxFlor As ComboBox
    Friend WithEvents Floreria20DataSet1 As Floreria20DataSet1
    Friend WithEvents FlorArregloBindingSource As BindingSource
    Friend WithEvents Flor_ArregloTableAdapter As Floreria20DataSet1TableAdapters.Flor_ArregloTableAdapter
    Friend WithEvents ArregloBindingSource As BindingSource
    Friend WithEvents ArregloTableAdapter As Floreria20DataSet1TableAdapters.ArregloTableAdapter
    Friend WithEvents FlorBindingSource As BindingSource
    Friend WithEvents FlorTableAdapter As Floreria20DataSet1TableAdapters.FlorTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdarregloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdflorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlorArregloBindingSource1 As BindingSource
    Friend WithEvents TxtCantidadFlorArreglo As TextBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents pictureBox1 As PictureBox
End Class
