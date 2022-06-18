using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlandSpace.Client;

public partial class ScreenMainMenu : Form
{
    public ScreenMainMenu()
    {
        InitializeComponent();
    }


    private void cmdStartNewGameSession_Click(object sender, EventArgs e)
    {
        Global.Game.StartGameSession();
    }
}
