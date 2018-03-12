using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StaCatalina.Clases;
using System.Globalization;
namespace StaCatalina.Forms
{
    public partial class Frm_Vtos : Form
    {
        #region variables

            private enum Col_Vtos
            {
               CANTIDAD=0,
                VTO
           
            }
            private List<Entities.Tables.STKVENCIMIENTO> _listVto = new List<Entities.Tables.STKVENCIMIENTO>();
            CultureInfo culture = new CultureInfo("en-US");
            private string _codigoArticuloVto;
            private string _descripArticuloVto;

            public List<Entities.Tables.STKVENCIMIENTO> ListVto
                {
                    get
                    {
                        return _listVto;
                    }

                    set
                    {
                        _listVto = value;
                    }
                }

            public string CodigoArticuloVto
            {
                get
                {
                    return _codigoArticuloVto;
                }

                set
                {
                    _codigoArticuloVto = value;
                }
            }

            public string DescripArticuloVto
            {
                get
                {
                    return _descripArticuloVto;
                }

                set
                {
                    _descripArticuloVto = value;
                }
            }

  



        public Frm_Vtos()
        {
            InitializeComponent();
        }


        #endregion

        #region Calendar
        public class CalendarColumn : DataGridViewColumn
        {
            public CalendarColumn()
                : base(new CalendarCell())
            {
            }

            public override DataGridViewCell CellTemplate
            {
                get
                {
                    return base.CellTemplate;
                }
                set
                {
                    // Ensure that the cell used for the template is a CalendarCell.
                    if (value != null &&
                        !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                    {
                        throw new InvalidCastException("Must be a CalendarCell");
                    }
                    base.CellTemplate = value;
                }
            }
        }

        public class CalendarCell : DataGridViewTextBoxCell
        {

            public CalendarCell()
                : base()
            {
                // Use the short date format.
                this.Style.Format = "d";
            }

            public override void InitializeEditingControl(int rowIndex, object
                initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                // Set the value of the editing control to the current cell value.
                base.InitializeEditingControl(rowIndex, initialFormattedValue,
                    dataGridViewCellStyle);
                CalendarEditingControl ctl =
                    DataGridView.EditingControl as CalendarEditingControl;
                // Use the default row value when Value property is null.
                if (this.Value == null)
                {
                    ctl.Value = (DateTime)this.DefaultNewRowValue;
                }
                else
                {
                    ctl.Value = (DateTime)this.Value;
                }
            }

            public override Type EditType
            {
                get
                {
                    // Return the type of the editing control that CalendarCell uses.
                    return typeof(CalendarEditingControl);
                }
            }

            public override Type ValueType
            {
                get
                {
                    // Return the type of the value that CalendarCell contains.

                    return typeof(DateTime);
                }
            }

            public override object DefaultNewRowValue
            {
                get
                {
                    // Use the current date and time as the default value.
                    return DateTime.Now;
                }
            }
        }

        class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
        {
            DataGridView dataGridView;
            private bool valueChanged = false;
            int rowIndex;

            public CalendarEditingControl()
            {
                this.Format = DateTimePickerFormat.Short;
            }

            // Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
            // property.
            public object EditingControlFormattedValue
            {
                get
                {
                    return this.Value.ToShortDateString();
                }
                set
                {
                    if (value is String)
                    {
                        try
                        {
                            // This will throw an exception of the string is 
                            // null, empty, or not in the format of a date.
                            this.Value = DateTime.Parse((String)value);
                        }
                        catch
                        {
                            // In the case of an exception, just use the 
                            // default value so we're not left with a null
                            // value.
                            this.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            this.Show();
                        }
                    }
                }
            }

            // Implements the 
            // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
            public object GetEditingControlFormattedValue(
                DataGridViewDataErrorContexts context)
            {
                return EditingControlFormattedValue;
            }

            // Implements the 
            // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
            public void ApplyCellStyleToEditingControl(
                DataGridViewCellStyle dataGridViewCellStyle)
            {
                this.Font = dataGridViewCellStyle.Font;
                this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
                this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;

            }

            // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
            // property.
            public int EditingControlRowIndex
            {
                get
                {
                    return rowIndex;
                }
                set
                {
                    rowIndex = value;
                }
            }

            // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
            // method.
            public bool EditingControlWantsInputKey(
                Keys key, bool dataGridViewWantsInputKey)
            {
                // Let the DateTimePicker handle the keys listed.
                switch (key & Keys.KeyCode)
                {
                    case Keys.Left:
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Right:
                    case Keys.Home:
                    case Keys.End:
                    case Keys.PageDown:
                    case Keys.PageUp:
                        return true;
                    default:
                        return !dataGridViewWantsInputKey;
                }
            }

            // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
            // method.
            public void PrepareEditingControlForEdit(bool selectAll)
            {
                // No preparation needs to be done.
            }

            // Implements the IDataGridViewEditingControl
            // .RepositionEditingControlOnValueChange property.
            public bool RepositionEditingControlOnValueChange
            {
                get
                {
                    return false;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlDataGridView property.
            public DataGridView EditingControlDataGridView
            {
                get
                {
                    return dataGridView;
                }
                set
                {
                    dataGridView = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlValueChanged property.
            public bool EditingControlValueChanged
            {
                get
                {
                    return valueChanged;
                }
                set
                {
                    valueChanged = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingPanelCursor property.
            public Cursor EditingPanelCursor
            {
                get
                {
                    return base.Cursor;
                }
            }

            protected override void OnValueChanged(EventArgs eventargs)
            {
                // Notify the DataGridView that the contents of the cell
                // have changed.
                valueChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
                base.OnValueChanged(eventargs);
            }
        }




        #endregion

        #region Funciones
        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46) // Si no es numerico y si no es espacio EL 46 ES EL PUNTO
            {
                // Invalidar la accion
                e.Handled = true;
                // Enviar el sonido de beep de windows
                System.Media.SystemSounds.Beep.Play();
            }
        }

        #endregion

        #region Eventos
        private void Frm_Vtos_Load(object sender, EventArgs e)
        {

            //calendar
            CalendarColumn col = new CalendarColumn();

            this.dataGridViewVtos.Columns.Add(col);
            this.dataGridViewVtos.Columns[(int)Col_Vtos.VTO].Name = "FechaVto";
            this.dataGridViewVtos.Columns[(int)Col_Vtos.VTO].HeaderText = "Fecha Vencimiento";
            //this.dataGridViewVtos.Columns[(int)Col_Vtos.VTO].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewVtos.Columns[(int)Col_Vtos.VTO].Width = 130;
            this.dataGridViewVtos.Columns[(int)Col_Vtos.VTO].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //calendar


            //CARGO LA LISTA AL GRID Y BORRO SUS DATOS...            
            this.dataGridViewVtos.Rows.Clear();
            int indice;
            foreach (Entities.Tables.STKVENCIMIENTO item in _listVto)
            {
                indice = dataGridViewVtos.Rows.Add();
                dataGridViewVtos.Rows[indice].Cells[(int)Col_Vtos.CANTIDAD].Value = item.CANTIDAD; //CANTIDAD
                dataGridViewVtos.Rows[indice].Cells[(int)Col_Vtos.VTO].Value = item.VTO; //VTO
            
            }

            this.labelCodigoArticulo.Text = _codigoArticuloVto;
            labelDescripArticulo.Text = _descripArticuloVto;


            _listVto.Clear(); //ES PORQUE EN ESTA LISTA VUELVO A CARGAR LOS DATOS ACTUALIZADOS PARA ENVIARLOS AL FORM PRINCIPAL
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.Tables.STKVENCIMIENTO _item;
                for (int i = 0; i < dataGridViewVtos.Rows.Count - 1; i++)
                {
                    _item = new Entities.Tables.STKVENCIMIENTO();
                    _item.ARTICULO_ID =_codigoArticuloVto;
                    _item.CANTIDAD = Convert.ToDecimal(dataGridViewVtos.Rows[i].Cells[(int)Col_Vtos.CANTIDAD].Value.ToString(),culture);
                    _item.VTO = Convert.ToDateTime(dataGridViewVtos.Rows[i].Cells[(int)Col_Vtos.VTO].Value.ToString());

                    _listVto.Add(_item);
                }

                DialogResult = DialogResult.OK;
                this.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewVtos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewVtos.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_Vtos.CANTIDAD)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }
        }
                
        private void dataGridViewVtos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewVtos.IsCurrentCellDirty)
                dataGridViewVtos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion

    }
}
