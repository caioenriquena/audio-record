using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace GravadorAudioApp
{
    public partial class Form1 : Form
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private string filePath;
        private bool isRecording = false;
        private Timer recordingTimer; // Timer para o tempo de gravação
        private int recordingSeconds = 0; // Contador do tempo de gravação

        public Form1()
        {
            InitializeComponent();

            // Inicializa o Timer
            recordingTimer = new Timer
            {
                Interval = 1000 // Atualiza a cada 1 segundo
            };
            recordingTimer.Tick += RecordingTimer_Tick; // Associa o evento Tick
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAudioDevices();
        }

        private void LoadAudioDevices()
        {
            var devices = new MMDeviceEnumerator().EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToList();
            foreach (var device in devices)
            {
                comboBoxDevices.Items.Add(device.FriendlyName);
            }

            if (comboBoxDevices.Items.Count > 0)
            {
                comboBoxDevices.SelectedIndex = 0;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBoxDevices.SelectedItem == null)
            {
                MessageBox.Show("Selecione um dispositivo de gravação.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Arquivos de Áudio WAV|*.wav",
                FileName = "gravacao.wav"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                StartRecording();
            }
        }

        private void StartRecording()
        {
            if (isRecording) return;

            isRecording = true;
            recordingSeconds = 0; // Reinicia o contador de tempo

            var selectedDevice = comboBoxDevices.SelectedItem.ToString();
            var enumerator = new MMDeviceEnumerator();
            var device = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active)
                                   .FirstOrDefault(d => d.FriendlyName == selectedDevice);

            if (device == null)
            {
                MessageBox.Show("Dispositivo de gravação não encontrado.");
                return;
            }

            waveIn = new WaveInEvent
            {
                DeviceNumber = comboBoxDevices.SelectedIndex,
                WaveFormat = new WaveFormat(44100, 1)
            };

            waveIn.DataAvailable += OnDataAvailable;
            waveIn.RecordingStopped += OnRecordingStopped;

            writer = new WaveFileWriter(filePath, waveIn.WaveFormat);

            waveIn.StartRecording();

            recordingTimer.Start(); // Inicia o Timer
            labelStatus.Text = "Gravando...";
            labelTimer.Text = "00:00"; // Reseta o tempo
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            writer?.Write(e.Buffer, 0, e.BytesRecorded);
        }

        private void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            writer?.Dispose();
            waveIn?.Dispose();

            recordingTimer.Stop(); // Para o Timer
            isRecording = false;

            labelStatus.Text = "Gravação concluída.";
            labelTimer.Text = "00:00"; // Reseta o contador
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void RecordingTimer_Tick(object sender, EventArgs e)
        {
            recordingSeconds++;
            int minutes = recordingSeconds / 60;
            int seconds = recordingSeconds % 60;

            // Atualiza o tempo no Label
            labelTimer.Text = $"{minutes:D2}:{seconds:D2}";
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (waveIn != null && isRecording)
            {
                waveIn.StopRecording();
            }
        }
    }
}
