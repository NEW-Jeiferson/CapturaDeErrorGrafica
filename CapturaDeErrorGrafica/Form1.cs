namespace CapturaDeErrorGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNProcesar_Click(object sender, EventArgs e)
        {
           try
            {
                int Numero = int.Parse(TXTnumero.Text);
                LBLResultado.Text = "El Numero Introducido Es: " + Numero;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error Capa 8, Debes Introducir Un Numero", "Entrada Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problamente Ocurrio Un Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
               
        }
    }
}
