using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCropHelper
{
    public partial class MainForm : Form
    {
        private int _ratioWidth;
        private int _ratioHeight;
        private int _sourceWidth;
        private int _sourceHeight;
        private int _destinationWidth;
        private int _destinationHeight;


        public MainForm()
        {
            InitializeComponent();
        }

        private void txtSourceWidth_TextChanged(object sender, EventArgs e)
        {
            OnInputChanged();
        }

        private void txtSourceHeight_TextChanged(object sender, EventArgs e)
        {
            OnInputChanged();
        }

        private void OnInputChanged()
        {
            _ratioWidth = GetIntOrZero(txtRatioWidth.Text);
            _ratioHeight = GetIntOrZero(txtRatioHeight.Text);

            if(_ratioWidth <= 0 || _ratioHeight <= 0)
            {
                MessageBox.Show("Please enter some positive ratio values.");
                return;
            }

            _sourceWidth = GetIntOrZero(txtSourceWidth.Text);
            _sourceHeight = GetIntOrZero(txtSourceHeight.Text);

            _destinationWidth = _sourceHeight * _ratioWidth / _ratioHeight;
            if(_destinationWidth < _sourceWidth)
            {
                _destinationWidth = _sourceWidth;
            }

            _destinationHeight = _sourceWidth * _ratioHeight / _ratioWidth;
            if(_destinationHeight < _sourceHeight)
            {
                _destinationHeight = _sourceHeight;
            }

            txtDestinationWidth.Text = _destinationWidth.ToString();
            txtDestinationHeight.Text = _destinationHeight.ToString();
        }

        private int GetIntOrZero(string text)
        {
            if (int.TryParse(text, out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        private void txtDestinationWidth_Click(object sender, EventArgs e)
        {
            txtDestinationWidth.SelectAll();
            txtDestinationWidth.Focus();
        }

        private void txtDestinationHeight_Click(object sender, EventArgs e)
        {
            txtDestinationHeight.SelectAll();
            txtDestinationHeight.Focus();
        }

        private void txtSourceWidth_Click(object sender, EventArgs e)
        {
            //txtSourceWidth.SelectAll();
            //txtSourceWidth.Focus();
        }

        private void txtSourceHeight_Click(object sender, EventArgs e)
        {
            //txtSourceHeight.SelectAll();
            //txtSourceHeight.Focus();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application helps you to enlarge an image to a given ratio by adding to the width or the height.\nFill in the ratio and the initial image width and height and get your resulting values from the right side.", "About Image Crop Helper");
        }
    }
}
