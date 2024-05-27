namespace eAgenda.WinApp.ModuloContato
{
    public partial class ListagemCompromissoControl : UserControl
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            listContatos.Items.Clear();

            foreach (Contato contato in contatos)
                listContatos.Items.Add(contato);
        }
    }
}
