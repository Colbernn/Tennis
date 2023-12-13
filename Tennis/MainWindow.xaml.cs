using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tennis.DAO;
using Tennis.Models;

namespace Tennis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
			// Supposons que vous ayez déjà récupéré un court de votre base de données

			CourtDAO courtDAO = new CourtDAO();
			Court court = courtDAO.Find(1);

			// Définir le DataContext de la fenêtre sur l'instance du court (pour pouvoir le lier dans XAML si nécessaire)
			DataContext = this;

			// Appeler une méthode pour mettre à jour le texte (peut être appelé après avoir récupéré les données de la base de données)
			if (court != null)
			{
				// Formater le texte en fonction des données du court
				txtCourtInfo.Text = $"Nom du court : {court.nbSpectators}";
			}
			else
			{
				// Si le court n'est pas trouvé, afficher un message
				txtCourtInfo.Text = "Court non trouvé.";
			}
		}

		// Méthode pour mettre à jour le texte dans le TextBlock
		
    }
}
