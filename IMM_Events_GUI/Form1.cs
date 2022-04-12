namespace IMM_Events_GUI
{
    public partial class Form1 : Form
    {
        private ParallelSummator ps;
        public Form1()
        {
            InitializeComponent();
            ps = new ParallelSummator((long)nudN.Value);
            ps.NextStep += OnNextStep;
            ps.ResultReady += OnResultReady;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            lblResult.Text = "";
            ps.Start();
        }

        private void OnResultReady()
        {
            if (lblResult.InvokeRequired)
            {
                lblResult.Invoke(OnResultReady);
            }
            else
            {
                progressBar1.Value = 100;
                lblResult.Text = ps?.Result.ToString();
                //ps.NextStep -= OnNextStep;
                //ps.ResultReady -= OnResultReady;
            }
        }

        private void OnNextStep()
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(OnNextStep);
            }
            else
            {
                progressBar1.Value++;
            }
        }

        private void nudN_ValueChanged(object sender, EventArgs e)
        {
            ps.N = (long)nudN.Value;
        }
    }
}