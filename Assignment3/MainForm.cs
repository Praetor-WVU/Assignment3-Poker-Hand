using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms.VisualStyles;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        List<int> deck = new List<int>();
        int[] hand = new int[5];
        const string INIT_DIR= @"C:\Users\cleva\source\repos\Assignment3\Assignment3\Saved Hands";
        public MainForm()
        {
            InitializeComponent();
        }
        private void DealHand()
        {
            deck.Clear();
            for (int i = 0; i < 52; i++)
            {
                deck.Add(i);
            }
            deck.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                PictureBox? temp = (PictureBox?)this.Controls["picCard" + (i + 1).ToString()];
                temp.Image = imglstDeck.Images[deck[i]];
                hand[i] = deck[i];
            }
            deck.RemoveRange(0, 5);
        }
        private void DealHand(int[] givenHand)
        {
            for (int i = 0; i < 5; i++)
            {
                if (givenHand[i] == -1)
                {
                    PictureBox? temp = (PictureBox?)this.Controls["picCard" + (i + 1).ToString()];
                    temp.Image = imglstDeck.Images[deck[0]];
                    hand[i] = deck[0];
                    deck.RemoveAt(0);
                }
            }
        }
        private void UpdateHand()
        {
            for (int i =0; i < 5; i++)
            {
                PictureBox? temp = (PictureBox?)this.Controls["picCard" + (i + 1).ToString()];
                temp.Image = imglstDeck.Images[hand[i]];
            }
        }
        private void LoadHand(String fileName)
        {
            try
            {
                using (StreamReader reader = new(fileName))
                {
                    string? line = string.Empty;
                    for (int i = 0; i < 5; i++)
                    {
                        line = reader.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            hand[i] = int.Parse(line);
                        }
                    }
                    UpdateHand();
                }
            }
            catch
            {
                MessageBox.Show("Failed to load saved hand.");
            }
        }
        private void SaveHand(String filename)
        {
            try
            {
                using (StreamWriter writer = new(filename))
                {
                    foreach (int i in hand)
                    {
                        writer.WriteLine(i);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to save file.");
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DealHand();
            safiSaveHand.InitialDirectory = INIT_DIR;
            opfiLoadHand.InitialDirectory = INIT_DIR;
        }
        private void btnDeal_Click(object sender, EventArgs e)
        {
            if (chkKeep1.Checked || chkKeep2.Checked || chkKeep3.Checked || chkKeep4.Checked || chkKeep5.Checked)
            {
                int[] temp = new int[5];
                if (chkKeep1.Checked)
                {
                    temp[0] = 0;
                }
                else
                {
                    temp[0] = -1;
                }
                if (chkKeep2.Checked)
                {
                    temp[1] = 0;
                }
                else
                {
                    temp[1] = -1;
                }
                if (chkKeep3.Checked)
                {
                    temp[2] = 0;
                }
                else
                {
                    temp[2] = -1;
                }
                if (chkKeep4.Checked)
                {
                    temp[3] = 0;
                }
                else
                {
                    temp[3] = -1;
                }
                if (chkKeep5.Checked)
                {
                    temp[4] = 0;
                }
                else
                {
                    temp[4] = -1;
                }
                DealHand(temp);
            }
            else
            {
                DealHand();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName;
            if (safiSaveHand.ShowDialog() == DialogResult.OK)
            {
                fileName = safiSaveHand.FileName;
                SaveHand(fileName);
            }
            else
            {
                MessageBox.Show("Cancelled save.");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string fileName;
            if (opfiLoadHand.ShowDialog() == DialogResult.OK)
            {
                fileName = opfiLoadHand.FileName;
                LoadHand(fileName);
            }
            else
            {
                MessageBox.Show("Cancelled load.");
            }
        }
    }
    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random? Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }
    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}