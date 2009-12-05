using System;
using System.Windows.Forms;
using SHDocVw;

namespace Procrasterminator
{
    enum ProcrastinationMode
    {
        AGGRESSIVE,
        TOLERANT,
        OFF
    }

    public partial class MainForm : Form
    {
        private ProcrastinationMode mode;
        private int toleranceMinutes;
        private int toleranceSeconds = 10;
        private bool isPlayingVideo = false;
        private FormPlayVideo formPlay;

        private int elapsedProcrastinationTime;

        #region Construtor
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();

            //inicializa os modos
            mode = ProcrastinationMode.AGGRESSIVE;
            aggressiveToolStripMenuItem.Checked = true;
            radioButtonAggressive.Checked = true;

            //inicializa o tempo
            textBoxTolerantMinutes.Text = toleranceMinutes.ToString();
            textBoxTolerantSeconds.Text = toleranceSeconds.ToString();

        }
        #endregion

        #region Minimização da Janela para o Tray
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        #endregion

        #region Fecho da Janela

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit Procrasterminator?", "Exit Application",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                      MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
        #endregion

        #region Actualização do Modo

        private void UpdateModeControls()
        {
            aggressiveToolStripMenuItem.Checked = false;
            tolerantToolStripMenuItem.Checked = false;
            offToolStripMenuItem.Checked = false;

            radioButtonAggressive.Checked = false;
            radioButtonTolerant.Checked = false;
            radioButtonOff.Checked = false;

            switch(mode)
            {
                case ProcrastinationMode.AGGRESSIVE:
                    aggressiveToolStripMenuItem.Checked = true;
                    radioButtonAggressive.Checked = true;
                    break;
                case ProcrastinationMode.TOLERANT:
                    tolerantToolStripMenuItem.Checked = true;
                    radioButtonTolerant.Checked = true;
                    break;
                case ProcrastinationMode.OFF:
                    offToolStripMenuItem.Checked = true;
                    radioButtonOff.Checked = true;
                    break;
            }
        }

        private void ChangeToAgressiveMode(object sender, EventArgs e)
        {
            mode = ProcrastinationMode.AGGRESSIVE;

            //garante as selecções do modo correcto
            UpdateModeControls();

        }

        private void ChangeToTolerantMode(object sender, EventArgs e)
        {
            mode = ProcrastinationMode.TOLERANT;

            //garante as selecções do modo correcto
            UpdateModeControls();

        }

        private void ChangeToOffMode(object sender, EventArgs e)
        {
            mode = ProcrastinationMode.OFF;

            //garante as selecções do modo correcto
            UpdateModeControls();

        }
        #endregion

        #region Validação das caixas de tempo
        private void textBoxTolerantSeconds_Leave(object sender, EventArgs e)
        {
            int value;

            bool isValid = Int32.TryParse(textBoxTolerantSeconds.Text, out value);

            if (isValid)
            {
                toleranceSeconds = value;

                if (toleranceSeconds > 60)
                {
                    toleranceMinutes += toleranceSeconds / 60;
                    textBoxTolerantMinutes.Text = toleranceMinutes.ToString();
                    toleranceSeconds = toleranceSeconds % 60;
                    textBoxTolerantSeconds.Text = toleranceSeconds.ToString();
                }
            }
            else
                textBoxTolerantSeconds.Text = toleranceSeconds.ToString();
        }

        private void textBoxTolerantMinutes_Leave(object sender, EventArgs e)
        {
            int value;

            bool isValid = Int32.TryParse(textBoxTolerantMinutes.Text, out value);
            
            if (isValid)
                toleranceMinutes = value;
            else
                textBoxTolerantMinutes.Text = toleranceMinutes.ToString();
        }

        private void textBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13:
                    e.Handled = true;
                    labelTitle.Focus();
                    break;
            }
        }
        #endregion

        #region Interacção com a lista de palavras-chave

        private void buttonAddKeyword_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((textBoxAddKeyword.Text)))
            {
                listViewKeyword.Items.Add(textBoxAddKeyword.Text);
                textBoxAddKeyword.Text = "";
            }
        }

        private void buttonRemoveKeyword_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove the selected item(s)?",
                                                  "Remove items", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                  MessageBoxDefaultButton.Button2);
            if(result == DialogResult.Yes)
            {
                foreach (ListViewItem item in listViewKeyword.SelectedItems)
                {
                    listViewKeyword.Items.Remove(item);
                }
            }
        }
    #endregion

        #region Controlo periódico de procrastinação
        private void timerController_Tick(object sender, EventArgs e)
        {
            CheckInternetExplorerWindows();
            //CheckMozillaFireFoxWindows();
        }

        private void CheckInternetExplorerWindows()
        {
            foreach (InternetExplorer iexplorer in new ShellWindowsClass())
            {
                foreach (ListViewItem keyword in listViewKeyword.Items)
                {
                    if (iexplorer.LocationURL.ToLower().Contains(keyword.Text.ToLower()))
                    {
                        switch (mode)
                        {
                            case ProcrastinationMode.AGGRESSIVE:
                                ShowVideo();
                                break;
                            case ProcrastinationMode.TOLERANT:
                                elapsedProcrastinationTime++;

                                if (elapsedProcrastinationTime >= toleranceMinutes * 60 + toleranceSeconds)
                                {
                                    ShowVideo();
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void ShowVideo()
        {
            if(formPlay == null || !formPlay.IsPlayingVideo())
            {
                isPlayingVideo = true;
                formPlay = new FormPlayVideo("boom.avi");

                elapsedProcrastinationTime = 0;

                //KillInternetExplorerWindows();
            }
        }


        private void KillInternetExplorerWindows()
        {
            foreach (InternetExplorer iexplorer in new ShellWindowsClass())
            {
                foreach (ListViewItem keyword in listViewKeyword.Items)
                {
                    if (iexplorer.LocationURL.ToLower().Contains(keyword.Text.ToLower()))
                    {
                        iexplorer.Quit();
                    }
                }
            }
        }

        #endregion
    }
}
