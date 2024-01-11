using API_Nothing_Wrong.Doc_Liste_Unités;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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
using System.Xml;
using System.Xml.Serialization;

namespace API_Nothing_Wrong
{
    // using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Catalogue));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Catalogue)serializer.Deserialize(reader);
// }

public class Catalogue { 

	[XmlElement(ElementName="publications")] 
	public Publications Publications { get; set; } 

	[XmlElement(ElementName="profileTypes")] 
	public ProfileTypes ProfileTypes { get; set; } 

	[XmlElement(ElementName="categoryEntries")] 
	public CategoryEntries CategoryEntries { get; set; } 

	[XmlElement(ElementName="selectionEntries")] 
	public SelectionEntries SelectionEntries { get; set; } 

	[XmlElement(ElementName="entryLinks")] 
	public EntryLinks EntryLinks { get; set; } 

	[XmlElement(ElementName="sharedSelectionEntries")] 
	public SharedSelectionEntries SharedSelectionEntries { get; set; } 

	[XmlElement(ElementName="sharedSelectionEntryGroups")] 
	public SharedSelectionEntryGroups SharedSelectionEntryGroups { get; set; } 

	[XmlElement(ElementName="sharedRules")] 
	public SharedRules SharedRules { get; set; } 

	[XmlElement(ElementName="sharedProfiles")] 
	public SharedProfiles SharedProfiles { get; set; } 

	[XmlElement(ElementName="catalogueLinks")] 
	public CatalogueLinks CatalogueLinks { get; set; } 

	[XmlElement(ElementName="costTypes")] 
	public CostTypes CostTypes { get; set; } 

	[XmlAttribute(AttributeName="xmlns")] 
	public string Xmlns { get; set; } 

	[XmlAttribute(AttributeName="id")] 
	public string Id { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; } 

	[XmlAttribute(AttributeName="revision")] 
	public int Revision { get; set; } 

	[XmlAttribute(AttributeName="battleScribeVersion")] 
	public DateTime BattleScribeVersion { get; set; } 

	[XmlAttribute(AttributeName="library")] 
	public bool Library { get; set; } 

	[XmlAttribute(AttributeName="gameSystemId")] 
	public string GameSystemId { get; set; } 

	[XmlAttribute(AttributeName="gameSystemRevision")] 
	public int GameSystemRevision { get; set; } 

	[XmlAttribute(AttributeName="type")] 
	public string Type { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
			Main();
        }

        private void Liste_unités_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public static void Main()
        {
            string xmlData = @"<Categories>
                                <CategoryEntry id=""1"" name=""Category1"" hidden=""false"" />
                                <CategoryEntry id=""2"" name=""Category2"" hidden=""true"" />
                                <CategoryEntry id=""3"" name=""Category3"" hidden=""false"" />
                           </Categories>";

            List<string> classNames = GetClassNamesFromXml(xmlData);

            foreach (string className in classNames)
            {
                Console.WriteLine(className);
            }

            WriteClassNamesToFile(classNames);
        }

        public static List<string> GetClassNamesFromXml(string xmlData)
        {
            List<string> classNames = new List<string>();

            using (StringReader stringReader = new StringReader(xmlData))
            {
                using (XmlReader xmlReader = XmlReader.Create(stringReader))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(CategoryEntry));
                }
            }

            return classNames;
        }

        public static void WriteClassNamesToFile(List<string> classNames)
        {
            string directoryPath = "ClassNames";
            Directory.CreateDirectory(directoryPath);

            foreach (string className in classNames)
            {
                string filePath = Path.Combine(directoryPath, $"{className}.txt");
                File.WriteAllText(filePath, className);
            }
        }
    }
}
