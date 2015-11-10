using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class score : Form, View
    {
        public score()
        {
            InitializeComponent();
        }
        public void Score(int s_new)
        {
            lblscore.Text = Convert.ToString(s_new);
        }
        public void Notify(Model m)
        {
            Score(((TwoZeroFourEightModel)m).getSum());
        }
    }
}
