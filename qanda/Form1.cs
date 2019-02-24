using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace qanda
{
    public partial class QandAForm : Form
    {
        private List<string[]> qandas;
        private int qIndex;
        private bool[] shown;
        private int qShown;
        private Random rnd;
        private bool showingQ;
        private bool showingA;


        public QandAForm()
        {
            InitializeComponent();
            KeyPreview = true;
            rnd = new Random((int)DateTime.Now.Ticks);
            init();
        }


        private void init()
        {
            startButton.Enabled = false;
            prevButton.Enabled = false;
            revealButton.Enabled = false;
            nextButton.Enabled = false;

            qShown = 0;
            showingQ = showingA = false;
        }


        private void loadButton_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                init();
                loadFile(fd.FileName);
                prepare();

                this.ActiveControl = null;
            }
        }


        private void prepare()
        {
            startButton.Enabled = false;
            if (qandas != null)
            {
                startButton.Enabled = (qandas.Count > 0);
            }
        }


        private void loadFile(string filename)
        {
            qandas = new List<string[]>();

            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                string q = sr.ReadLine();

                // ignore empty lines before questions
                if (q == string.Empty) continue;
                if (q == null) break;

                string a = sr.ReadLine();
                if (a == null) break;

                qandas.Add(new string[] { q, a });
            }

            statusText.Text = qandas.Count.ToString() + " Questions and Answers loaded.";
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            shown = new bool[qandas.Count];
            qShown = 0;
            qIndex = -1;
            pickNextQuestion();
            showQuestion();
        }


        private void revealButton_Click(object sender, EventArgs e)
        {
            showAnswer();
        }


        private bool allAnswered()
        {
            if (!rndCheckBox.Checked)
                return (qIndex >= qandas.Count - 1);
            return (qShown >= qandas.Count - 1);
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            if (pickNextQuestion())
            {
                if (qIndex < qandas.Count)
                {
                    showQuestion();
                }
            }
        }


        private bool pickNextQuestion()
        {
            if (rndCheckBox.Checked)
            {
                if (qShown < qandas.Count)
                {
                    int r;
                    do
                    {
                        r = rnd.Next(qandas.Count);
                    } while (shown[r]);
                    qIndex = r;
                }
                else
                {
                    nextButton.Enabled = false;
                    statusText.Text = "Completed all questions.";
                    return false;
                }
            }
            else
            {
                if (qIndex < qandas.Count - 1)
                {
                    qIndex++;
                    if (qIndex > 0)
                        prevButton.Enabled = true;
                }
                else
                {
                    nextButton.Enabled = false;
                    statusText.Text = "Completed all questions.";
                    return false;
                }
            }
            return true;
        }


        private void prevButton_Click(object sender, EventArgs e)
        {
            if (qIndex > 0)
            {
                qIndex--;
                showQuestion();
                revealButton.Enabled = true;
            }
            else
            {
                qIndex = 0;
                prevButton.Enabled = false;
            }
        }


        private void showQuestion()
        {
            if (qandas[qIndex].Length > 0)
            {
                qText.Text = qandas[qIndex][0];
                showingQ = true;
                aText.Text = "";
                showingA = false;

                qShown++;
                shown[qIndex] = true;

                revealButton.Enabled = true;
                statusText.Text = "Question #" + (qIndex + 1).ToString();

                // next button only if there is an unasked question
                nextButton.Enabled = !allAnswered();
                // no previous button when questions are randomised or on the first one
                prevButton.Enabled = qIndex > 0 && !rndCheckBox.Checked;
            }
            else
            {
                revealButton.Enabled = false;
                statusText.Text = "Missing question in the text file!";
            }
        }


        private void showAnswer()
        {
            if (qandas[qIndex].Length > 1)
            {
                aText.Text = qandas[qIndex][1];
                showingA = true;
            }
            else
            {
                statusText.Text = "Missing answer in the text file!";
            }
            revealButton.Enabled = false;
        }


        private void rndCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // disabling random resets to the first question
            if (!rndCheckBox.Checked)
            {
                statusText.Text = "Disabled Random Order...";
            }
            else
            {
                statusText.Text = "Enabled Random Order...";
            }

            // reset as though we have just loaded new questions
            qText.Text = "";
            aText.Text = "";
            init();
            prepare();
        }


        private void QandAForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                if (!showingA)
                {
                    if (!showingQ)
                    {
                        // space to start
                        startButton_Click(null, null);
                        e.Handled = true;
                    }
                    else
                    {
                        // space to reveal
                        revealButton_Click(null, null);
                        e.Handled = true;
                    }
                }
                else
                {
                    // space for next
                    nextButton_Click(null, null);
                    e.Handled = true;
                }

                this.ActiveControl = null;
            }
        }
    }
}
