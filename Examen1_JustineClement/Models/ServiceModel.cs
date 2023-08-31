namespace Examen1_JustineClement.Models
{
    public class ServiceModel
    {
		public int Id { get; set; }

		public string Name { get; set; }

		public string Type { get; set; }

		public string Description { get; set; }

		public static List<ServiceModel> GetService()
		{
			List<ServiceModel> serviceList = new List<ServiceModel>
			{
				new ServiceModel { Id = 1, Name = "Analyse de Données", Type = "Data Analysis",
					Description = "Nous fournissions des solutions d'analyse de données basées sur l'intelligence artificielle pour aider votre entreprise à prendre des décisions éclairées." },
				new ServiceModel { Id = 2, Name = "Traitement du Langage Naturel",  Type = "Natural Language Processing", 
					Description = "Notre expertise en traitement de langage naturel permet de transformer vos données textuelles en informations exploitables." },
				new ServiceModel { Id = 3, Name = "Vision par Ordinateur",  Type = "Computer Vision", 
					Description = "Nos solutions de vision par ordinateur utilisent l'intelligence artificielle pour analyser et interpréter des images et vidéos." }
			};

			return serviceList;
		}
	}
}
