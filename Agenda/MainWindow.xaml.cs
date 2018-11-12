using Agenda.Contexto;
using Agenda.Model;
using System.Windows;

namespace Agenda
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EncerrarBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CadastrarBtn_Click(object sender, RoutedEventArgs e)
        {
            if (nomeTbx.Text != "" && emailTbx.Text != "" && telefoneTbx.Text != ""){
                Contato contato = new Contato()
                {
                    Nome = nomeTbx.Text,
                    Email = emailTbx.Text,
                    Telefone = telefoneTbx.Text
                };
                using (var contexto = new AgendaContexto())
                {
                    contexto.Contatos.Add(contato);
                    contexto.SaveChanges();
                    MessageBox.Show("Contato cadastrado!");
                    nomeTbx.Text = "";
                    emailTbx.Text = "";
                    telefoneTbx.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            } 
        }
    }
}
