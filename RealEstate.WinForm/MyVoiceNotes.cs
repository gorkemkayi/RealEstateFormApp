using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate.WinForm
{
    public partial class MyVoiceNotes : Form
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private string outputFilePath;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        DataTable _voiceNotesTable;
        public MyVoiceNotes()
        {
            InitializeComponent();
        }

        private void btnStartRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SesKayitlari");
                string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SesKayitlari");
                Directory.CreateDirectory(folder);

                outputFilePath = Path.Combine(folder, $"kayit_{DateTime.Now:yyyyMMdd_HHmmss}.wav");

                waveIn = new WaveInEvent();
                waveIn.WaveFormat = new WaveFormat(44100, 1);
                writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);

                waveIn.DataAvailable += (s, a) =>
                {
                    writer.Write(a.Buffer, 0, a.BytesRecorded);
                };
                waveIn.RecordingStopped += (s, a) =>
                {
                    writer?.Dispose();
                    waveIn?.Dispose();
                };
                waveIn.StartRecording();

                txtPath.Text = "Kayit Basladi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnStopRecord_Click(object sender, EventArgs e)
        {
            try
            {
                waveIn?.StopRecording();
                txtPath.Text = $"Kayit Tamamlandi. Dosya: {outputFilePath}";

                DataRow row = _voiceNotesTable.NewRow();
                row["#"] = _voiceNotesTable.Rows.Count + 1;
                row["Kayıt"] = outputFilePath;
                _voiceNotesTable.Rows.Add(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void MyVoiceNotes_Load(object sender, EventArgs e)
        {
            _voiceNotesTable = new DataTable();
            _voiceNotesTable.Columns.Add("#", typeof(int));
            _voiceNotesTable.Columns.Add("Kayıt", typeof(string));

            string voiceFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SesKayitlari");
            Directory.CreateDirectory(voiceFolderPath);

            var files = Directory.GetFiles(voiceFolderPath, "*.wav");
            int index = 1;
            foreach (var file in files)
            {
                DataRow row = _voiceNotesTable.NewRow();
                row["#"] = index++;
                row["Kayıt"] = file;
                _voiceNotesTable.Rows.Add(row);
            }

            dataGridViewVoice.DataSource = _voiceNotesTable;
        }

        private void dataGridViewVoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>0)
            {
                string filePath = _voiceNotesTable.Rows[e.RowIndex]["Kayıt"].ToString();

                try
                {
                    outputDevice?.Stop();
                    outputDevice?.Dispose();
                    audioFile?.Dispose();

                    outputDevice = new WaveOutEvent();
                    audioFile = new AudioFileReader(filePath);
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
    }
}
