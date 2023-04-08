using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NotePad
{
    public partial class NotePad : Form
    {
        string currentLocation;
        bool saved;
        public NotePad()
        {
            InitializeComponent();
            currentLocation = string.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            currentLocation = string.Empty;
            saved = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            currentLocation = string.Empty;
            saved = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved) return;
            DialogResult result = MessageBox.Show("You have unsaved changes. Close anyway?", "Unsaved Changes!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentLocation == string.Empty)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.CreatePrompt = false;
                saveFileDialog.ShowDialog(this);

                if (saveFileDialog.FileName == string.Empty) return;

                if (saveFileDialog.OpenFile() != null)
                {
                    Stream fs = saveFileDialog.OpenFile();
                    fs.SetLength(0);
                    this.Text = saveFileDialog.FileName;
                    StreamWriter sw = new StreamWriter(fs);
                    string[] lines = richTextBox1.Lines;
                    for (int i = 0; i < lines.Length; i++)
                    {
                        sw.WriteLine(lines[i]);
                    }
                    sw.Close();
                    fs.Close();
                }
                currentLocation = Path.GetFullPath(saveFileDialog.FileName);
            }
            else
            {
                FileStream fs = new FileStream(currentLocation, FileMode.Truncate);
                StreamWriter sw = new StreamWriter(fs);
                string[] lines = richTextBox1.Lines;
                for (int i = 0; i < lines.Length; i++)
                {
                    sw.WriteLine(lines[i]);
                }
                this.Text = Path.GetFileName(currentLocation);
                sw.Close();
                fs.Close();
            }
            saved = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            string[] words = richTextBox1.Text.Split(new char[] { ' ', '\n' });
            int wordsCount = 0;
            for (int i = 0; i < words.Count(); i++)
            {
                if (words[i] != "" && words[i] != ",")
                {
                    wordsCount++;
                }
            }
            label2.Text = wordsCount.ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.CheckPathExists = true;
            ofd.ShowDialog();

            if (ofd.FileName == string.Empty) return;

            Stream fs = ofd.OpenFile();

            StreamReader sr = new StreamReader(fs);
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
            {
                string? temp = sr.ReadLine(); // тук въпросителната казва че може този temp да не съществува
                if(temp != null) // тук проверяваме дали съществува, и ако съществува го запазваме
                    lines.Add(temp);
            }
            richTextBox1.Lines = lines.ToArray();

            sr.Close();
            fs.Close();
            saved = true;
            currentLocation = Path.GetFullPath(ofd.FileName);
            this.Text = Path.GetFileName(currentLocation);
        }
    }
}