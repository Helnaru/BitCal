using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BitCal
{
	public partial class Form1 : Form
	{
		private CheckBox[] signed_cboxs;// = new CheckBox[32];
		private int n_value = 0;
		private TextBox tbox_int;

		private CheckBox[] unsigned_cboxs;
		private uint un_value = 0;
		private TextBox tbox_uint;

		private CheckBox[] opers;
		private EventHandler operEvent;
		private int crrentOperId = 0;
		private int up_value = 0;
		private int down_value = 0;
		private int result_value = 0;
		private CheckBox[] up_cboxs;
		private TextBox tbox_up;
		private CheckBox[] down_cboxs;
		private TextBox tbox_down;
		private EventHandler resultEvent;
		private CheckBox[] result_cboxs;
		private Label lb_result;
		private string[] str_opers;
		private Button btn_info;
		private Label lb_version;
		public Form1()
		{
			InitializeComponent();

			tbox_int = (TextBox)Controls["gb_viewer"].Controls["tb_int"];
			signed_cboxs = CreateBitGroup((GroupBox)Controls["gb_viewer"].Controls["gb_int_bits"],
				new EventHandler(Signed_CBox_Changed));

			tbox_uint = (TextBox)Controls["gb_viewer"].Controls["tb_uint"];
			unsigned_cboxs = CreateBitGroup((GroupBox)Controls["gb_viewer"].Controls["gb_uint_bits"],
				new EventHandler(Unsigned_CBox_Changed));

			// Operator -------------------------------------------------
			str_opers = new string[] { "&", "|", "^", "<<", ">>" };

			tbox_up = (TextBox)Controls["gb_cal"].Controls["tb_up"];
			up_cboxs = CreateBitGroup((GroupBox)Controls["gb_cal"].Controls["gb_up"],
				new EventHandler(Up_CBox_Changed));

			tbox_down = (TextBox)Controls["gb_cal"].Controls["tb_down"];
			down_cboxs = CreateBitGroup((GroupBox)Controls["gb_cal"].Controls["gb_down"],
				new EventHandler(Down_CBox_Changed));

			resultEvent = new EventHandler(Result_Changed);
			result_cboxs = CreateBitGroup((GroupBox)Controls["gb_cal"].Controls["gb_result"], resultEvent);

			lb_result = (Label)Controls["gb_cal"].Controls["label_result"];
			lb_result.Text = $"0  {str_opers[0]}  0 = 0";


			operEvent = new EventHandler(Oper_Changed);
			opers = new CheckBox[5];
			for (int i = 0; i < opers.Length; i++) {
				opers[i] = (CheckBox)Controls["gb_cal"].Controls[$"oper_{i}"];
				if (i == 0) opers[i].Checked = true;
				opers[i].CheckedChanged += operEvent;
			}

			btn_info = (Button)Controls["gb_cal"].Controls["button_info"];

			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			lb_version = (Label)Controls["gb_viewer"].Controls["label_version"];
			//lb_version.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			lb_version.Text = $"Ver {assembly.GetName().Version}";
			//btn_info.Text = $"Ver {assembly.GetName().Version}";
		}

		private static int GetIdByName(string _name)
		{
			int _fid = _name.IndexOf("_") + 1;
			string _strid = _name.Substring(_fid);

			if (int.TryParse(_strid, out int _result)) {
				return _result;
			}
			return 0;
		}

		private static CheckBox[] CreateBitGroup(GroupBox _base, EventHandler _handler)
		{
			CheckBox[] _cboxs = new CheckBox[32];

			Point _pos = new Point(4, 10);
			for (int i = 0; i < _cboxs.Length; i++) {

				_cboxs[i] = new CheckBox();
				_cboxs[i].Size = new Size(16, 16);
				_cboxs[i].Margin = new Padding(1, 1, 1, 1);
				_cboxs[i].Name = $"checkBox_{i}";
				_cboxs[i].Location = _pos;
				if (_handler != null) _cboxs[i].Click += _handler;
				_base.Controls.Add(_cboxs[i]);

				if ((i + 1) % 8 == 0) _pos.X += 20;
				else if ((i + 1) % 4 == 0) _pos.X += 18;
				else _pos.X += 16;
			}
			return _cboxs;
		}

		#region Viewer //=============================================
		private void Signed_CBox_Changed(object sender, EventArgs e)
		{
			int value = GetIdByName(((CheckBox)sender).Name);
			int _id = (signed_cboxs.Length - value - 1);
			if (((CheckBox)sender).Checked) {

				n_value |= (1 << _id);
			}
			else {
				n_value &= ~(1 << _id);
			}
			tbox_int.Text = $"{n_value}";
		}
		private void Unsigned_CBox_Changed(object sender, EventArgs e)
		{
			int value = GetIdByName(((CheckBox)sender).Name);

			int _id = (unsigned_cboxs.Length - value - 1);
			if (((CheckBox)sender).Checked) {

				un_value |= ((uint)1 << _id);
			}
			else {
				un_value &= ~((uint)1 << _id);
			}
			tbox_uint.Text = $"{un_value}";
		}

		private void SignedInt_value_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(((TextBox)sender).Text, out int _val)) {
				if (n_value != _val) {
					n_value = _val;
					for (int i = 0; i < signed_cboxs.Length; i++) {
						signed_cboxs[signed_cboxs.Length - i - 1].Checked = ((n_value >> i) & 1) == 1;
					}
				}
			}
		}
		private void UnsignedInt_value_TextChanged(object sender, EventArgs e)
		{
			if (uint.TryParse(((TextBox)sender).Text, out uint _val)) {
				if (un_value != _val) {
					un_value = _val;
					for (int i = 0; i < unsigned_cboxs.Length; i++) {
						unsigned_cboxs[unsigned_cboxs.Length - i - 1].Checked = ((un_value >> i) & 1) == 1;
					}
				}
			}
		}

		private void SignedInt_value_KeyPress(object sender, KeyPressEventArgs e)
		{
			int _pos = ((TextBox)sender).SelectionStart;
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back)
				&& !(n_value > 0 && _pos == 0 && e.KeyChar == '-');
		}
		private void UnsignedInt_value_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
		#endregion // Viewer =======================================================

		#region Operator //=======================================
		private void Result_Changed(object sender, EventArgs e)
		{
			int _id = GetIdByName(((CheckBox)sender).Name);
			bool _isChecked = result_cboxs[_id].Checked;
			result_cboxs[_id].CheckedChanged -= resultEvent;
			result_cboxs[_id].Checked = ((result_value >> (31 -_id)) & 1) == 1;
			result_cboxs[_id].CheckedChanged += resultEvent;
		}
		private void SetResult()
		{
			switch (crrentOperId) {
				case 0: result_value = up_value & down_value; break;
				case 1: result_value = up_value | down_value; break;
				case 2: result_value = up_value ^ down_value; break;
				case 3: result_value = up_value << down_value; break;
				case 4: result_value = up_value >> down_value; break;
			}

			for (int i = 0; i < up_cboxs.Length; i++) {
				result_cboxs[result_cboxs.Length - i - 1].Checked = ((result_value >> i) & 1) == 1;
			}
			lb_result.Text = $"{up_value}  {str_opers[crrentOperId]}  {down_value} = {result_value}";
		}

		private void Oper_Changed(object sender, EventArgs e)
		{
			int _id = GetIdByName(((CheckBox)sender).Name);
			if (opers[_id].Checked) {
				if (crrentOperId != _id) {
					crrentOperId = _id;
				}
			}

			for (int i = 0; i < opers.Length; i++) {
				opers[i].CheckedChanged -= operEvent;
				opers[i].Checked = false;
			}
			opers[_id].Checked = true;
			for (int i = 0; i < opers.Length; i++) {
				opers[i].CheckedChanged += operEvent;
			}
			SetResult();
		}

		private void Up_CBox_Changed(object sender, EventArgs e)
		{
			int value = GetIdByName(((CheckBox)sender).Name);
			int _id = (up_cboxs.Length - value - 1);
			if (((CheckBox)sender).Checked) {

				up_value |= (1 << _id);
			}
			else {
				up_value &= ~(1 << _id);
			}
			tbox_up.Text = $"{up_value}";
			SetResult();
		}

		private void Down_CBox_Changed(object sender, EventArgs e)
		{
			int value = GetIdByName(((CheckBox)sender).Name);
			int _id = (down_cboxs.Length - value - 1);
			if (((CheckBox)sender).Checked) {

				down_value |= (1 << _id);
			}
			else {
				down_value &= ~(1 << _id);
			}
			tbox_down.Text = $"{down_value}";
			SetResult();
		}

		private void Up_value_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(((TextBox)sender).Text, out int _val)) {
				if (up_value != _val) {
					up_value = _val;
					for (int i = 0; i < up_cboxs.Length; i++) {
						up_cboxs[signed_cboxs.Length - i - 1].Checked = ((up_value >> i) & 1) == 1;
					}
				}
				SetResult();
			}
		}
		private void Down_value_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(((TextBox)sender).Text, out int _val)) {
				if (down_value != _val) {
					down_value = _val;
					for (int i = 0; i < down_cboxs.Length; i++) {
						down_cboxs[signed_cboxs.Length - i - 1].Checked = ((down_value >> i) & 1) == 1;
					}
				}
				SetResult();
			}
		}

		private void Up_value_KeyPress(object sender, KeyPressEventArgs e)
		{
			int _pos = ((TextBox)sender).SelectionStart;
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back)
				&& !(up_value > 0 && _pos == 0 && e.KeyChar == '-');
		}
		private void Down_value_KeyPress(object sender, KeyPressEventArgs e)
		{
			int _pos = ((TextBox)sender).SelectionStart;
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back)
				&& !(down_value > 0 && _pos == 0 && e.KeyChar == '-');
		}
		#endregion // Operator========================================




		private void CheckBox_Changed_test(object sender, EventArgs e)
		{
			string _name = ((CheckBox)sender).Name;
			int _fid = _name.IndexOf("_") + 1;
			string _strid = _name.Substring(_fid);
			int value = int.Parse(_strid);
			//if (((CheckBox)sender).Checked) {
			//	((CheckBox)sender).i.Image = Properties.Resources.On;
			//}
			//else {
			//	((CheckBox)sender).Image = Properties.Resources.Off;
			//}
		}
	}
}
