using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace API_Nothing_Wrong.Doc_Liste_Unités
{
    public class units
    {
        public string Nom { get; set; }
        public string[] stats { get; set; }
        public string sauvegarde_invulnérable { get; set; }
        public string[] ls_arme_distance { get; set; }
        public string[] ls_arme_melee { get; set; }
        public string[] ls_capacités { get; set; }
        public string roi_pourpre { get; set; }
        public string blessé { get; set; }
        public string[] composition_unité { get; set; }
        public string[] mot_clés { get; set; }
    }
    public class weapons
    {
        public string[] stats { get; set; }
        public string[] mot_clés { get; set; }
    }

    internal class Lst_unités
    {
        List<units> LS_ThousandSonsUnits = new List<units>();

        public void Ajoute_Unité(string nom, string[] stats, string si, string[] distance, string[] melee, string[] abilities, string wounded, string[] unit_compo, string[] keywords)
        {
            LS_ThousandSonsUnits.Add(new units
            {
                Nom = nom,
                stats = stats,
                sauvegarde_invulnérable = si,
                ls_arme_distance = distance,
                ls_arme_melee = melee,
                ls_capacités = abilities,
                blessé = wounded,
                composition_unité = unit_compo,
                mot_clés = keywords,
            }
            );
        }
    }

    class prog
    {
        static void Main(string[] args)
        {
            Lst_unités lstunits = new Lst_unités();
            lstunits.Ajoute_Unité("Ahriman",new string[] {"6", "4", "3+", "5", "6+", "1"}, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" },"N/A",new string[] {"1", "130"}, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Chaos", "Tzeentch", "Ahriman" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" , "140" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Exalted sorcerer", new string[] { "6", "4", "3+", "5", "6+", "1" }, "4+", new string[] { "Astral blast","Inferno bolt pistol", "Plasma pistol - standart", "Plasma pistol - supercharge", "Warpflame pistol"  }, new string[] { "Force weapon", "Prosperine khopesh" }, new string[] { "Leader", "Cabal of sorcerers 2", "Arcane shield (psychic)", "Rebind rubricae (psychic)" }, "N/A", new string[] { "1" , "100" }, new string[] { "Infantry", "Character", "Psyker", "Fly", "Chaos", "Tzeentch", "Exalted sorcerer" });
            lstunits.Ajoute_Unité("Exalted sorcerer on disc of tzeentch", new string[] { "12", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Arcane fire", "Inferno bolt pistol", "Plasma pistol - standart", "Plasma pistol - supercharge", "Warpflame pistol" }, new string[] { "Force weapon", "Prosperine khopesh" }, new string[] { "Leader", "Cabal of sorcerers 2", "Arcane shield (psychic)", "Binding tendrils (psychic)" }, "N/A", new string[] { "1" , "115" }, new string[] { "Infantry", "Character", "Psyker", "Fly", "Chaos", "Tzeentch", "Exalted sorcerer on disc of tzeentch" });
            lstunits.Ajoute_Unité("Infernal master", new string[] { "6", "4", "3+", "4", "6+", "1" }, "5+", new string[] { "Inferno bolt pistol", "Screamer invocation - witchfire", "Screamer invocation - focused witchfire" }, new string[] { "Force weapon" }, new string[] { "Leader", "Cabal of sorcerers 2", "Malefic maelstrom (psychic)", "Glimpse of eternity (psychic)" }, "N/A", new string[] { "1" , "90" }, new string[] { "Infantry", "Character", "Psyker", "Chaos", "Tzeentch", "Infernal master" });
            lstunits.Ajoute_Unité("Magnus the Red", new string[] { "14", "11", "2+", "16", "5+", "6" }, "4+", new string[] { "Gaze of magnus", "Tzeentch firestorm" }, new string[] { "Blade of Magnus - strike", "Blade of Magnus - sweep" }, new string[] { "Deadly demise D6", "Cabal of sorcerers 4", "Crimson king", "Lord of the planet of the sorcerers" }, "1-6", new string[] { "1" , "440" }, new string[] { "Monster", "Character", "Psyker", "Fly","Epic hero", "Chaos", "Daemon", "Tzeentch", "Primarch", "Magnus the Red" });
            lstunits.Ajoute_Unité("Mutalith vortex beast", new string[] { "10", "10", "4+", "13", "6+", "4" }, "5+", new string[] { "Warp vortex - blast", "Warp vortex - beam", "Warp vortex - torrent" }, new string[] { "Betentaled maw", "Mutalith claws" }, new string[] { "Deadly demise D6", "Feel no pain 5+", "Mutating vortex (Aura)", "Immaterial flare (aura)" }, "1-4", new string[] { "1", "165" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Rubric marines", new string[] { "5", "4", "3+", "2", "6+", "2" }, "5+", new string[] { "Inferno bolt pistol", "Inferno boltgun", "Plasma pistol - standart", "Plasma pistol - supercharge", "Soulreaper cannon", "Warpflame pistol", "Warpflammer", "Warpsmite" }, new string[] { "Close combat weapon", "Force weapon" }, new string[] { "Cabal of sorcerers 1", "Bringers of change", "Icon of Flame" }, "N/A", new string[] { "1", "4", "105", "1", "5-9", "210" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Scarab occult terminator", new string[] { "5", "5", "2+", "3", "6+", "1" }, "4+", new string[] { "Heavy warpflamer", "Hellfyre missile rack", "Inferno combi-bolter", "Soulreaper cannon", "Warsmite" }, new string[] { "Force weapon", "Prosperine khopesh" }, new string[] { "Deep strike", "Cabal of sorcerers 1", "Implacable guardians" }, "N/A", new string[] { "1", "4", "215", "1", "5-9" }, new string[] { "Infantry", "Terminator", "Chaos", "Tzeentch", "Scarab occult terminators", "SOS - Psyker" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
            lstunits.Ajoute_Unité("Ahriman on disc of tzeentch", new string[] { "10", "4", "3+", "6", "6+", "1" }, "4+", new string[] { "Inferno bolt pistol", "Pyschic stalk" }, new string[] { "Black Staff of Ahriman" }, new string[] { "Leader", "Ahriman", "Cabal of sorcerers 3", "Rubric Lord", "Arch-Sorcerer of Tzeentch (psychic)" }, "N/A", new string[] { "1" }, new string[] { "Infantry", "Character", "Epic hero", "Psyker", "Fly", "Chaos", "Tzeentch", "Ahriman on disc of tzeentch" });
        }
    }
}
