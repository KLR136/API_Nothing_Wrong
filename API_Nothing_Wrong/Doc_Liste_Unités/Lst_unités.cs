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
        public string Nom { get; set; }
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
    internal class Lst_armes
    {
        List<weapons> LS_ThousandSonsWeapons = new List<weapons>();

        public void Ajoute_Arme(string nom, string[] stats, string[] keywords)
        {
            LS_ThousandSonsWeapons.Add(new weapons
            {
                Nom = nom,
                stats = stats,
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
            Lst_armes larme = new Lst_armes();
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
            larme.Ajoute_Arme("Inferno bolt pistol", new string[] { "12'", "1", "2+", "4", "-1", "1" }, new string[] { "Pistol" });
            larme.Ajoute_Arme("Pyschic Stalk", new string[] { "18'", "1", "2+", "6", "-1", "D6" }, new string[] { "Precision", "Psychic" });
            larme.Ajoute_Arme("Black Staff of Ahriman", new string[] { "Melee", "5", "2+", "7", "-1", "3" }, new string[] { "Psychic" });
            larme.Ajoute_Arme("Astral Blast", new string[] { "18'", "D6", "2+", "6", "-2", "D3" }, new string[] { "Blast", "Devastating wounds", "Psychic" });
            larme.Ajoute_Arme("Plasma pistol – standard", new string[] { "12'", "1", "2+", "7", "-2", "1" }, new string[] { "Pistol" });
            larme.Ajoute_Arme("Plasma pistol – supercharge", new string[] { "12'", "1", "2+", "8", "-2", "2" }, new string[] { "Pistol", "Hazardous" });
            larme.Ajoute_Arme("Warpflame pistol", new string[] { "12'", "D6", "N/A", "3", "-1", "1" }, new string[] { "Ignores cover", "Pistol", "Torrent" });
            larme.Ajoute_Arme("Heavy Force weapon", new string[] { "Melee", "5", "2+", "6", "-1", "D3" }, new string[] { "Psychic" });
            larme.Ajoute_Arme("Prosperine khopesh", new string[] { "Melee", "4", "3+", "5", "-2", "2" }, new string[] { });
            larme.Ajoute_Arme("Screamer invocation - witchfire", new string[] { "18'", "2D3", "N/A", "6", "-2", "1" }, new string[] { "Psychic", "Torrent" });
            larme.Ajoute_Arme("Screamer invocation - focused witchfire", new string[] { "18'", "2D6", "N/A", "6", "-2", "1" }, new string[] { "Hazardous", "Psychic", "Torrent" });
            larme.Ajoute_Arme("Gaze of Magnus", new string[] { "24'", "3D3", "2+", "9", "-2", "3" }, new string[] { "Devastating wounds", "Psychic" });
            larme.Ajoute_Arme("Tzeentch's Firestorm", new string[] { "24'", "D6+3", "2+", "5", "-1", "2" }, new string[] { "Blast", "Psychic" });
            larme.Ajoute_Arme("Blade of Magnus - strike", new string[] { "Melee", "7", "2+", "16", "-3", "3" }, new string[] { "Devastating wounds", "Psychic" });
            larme.Ajoute_Arme("Blade of Magnus - sweep", new string[] { "Melee", "14", "2+", "8", "-1", "1" }, new string[] { "Psychic" });
            larme.Ajoute_Arme("Warp vortex - blast", new string[] { "24'", "D6+3", "3+", "9", "-2", "2" }, new string[] { "Blast" });
            larme.Ajoute_Arme("Warp vortex - beam", new string[] { "24'", "1", "3+", "18", "-4", "D6+6" }, new string[] { "Devastating wounds" });
            larme.Ajoute_Arme("Warp vortex - torrent", new string[] { "12'", "2D6", "N/A", "6", "-1", "1" }, new string[] { "Ignores cover", "Torrent" });
            larme.Ajoute_Arme("Inferno bolt gun", new string[] { "24'", "2", "3+", "4", "-1", "1" }, new string[] { });
            larme.Ajoute_Arme("Soulreaper cannon", new string[] { "24'", "6", "2+", "6", "-1", "1" }, new string[] { "Devastating wounds" });
            larme.Ajoute_Arme("Warpsmite", new string[] { "18'", "2", "3+", "6", "-3", "1" }, new string[] { "Anti-infantry 4+", "Devastating wounds", "Pistol", "Psychic" });
            larme.Ajoute_Arme("Warpflamer", new string[] { "12'", "D6", "N/A", "4", "-1", "1" }, new string[] { "Ignores cover", "Torrent" });
            larme.Ajoute_Arme("Close combat weapon", new string[] { "Melee", "3", "3+", "4", "0", "1" }, new string[] { });
            larme.Ajoute_Arme("Heavy warpflamer", new string[] { "12'", "D6", "N/A", "5", "-2", "1" }, new string[] { "Ignores cover", "Torrent" });
            larme.Ajoute_Arme("Hellfyre missile rack", new string[] { "36'", "2", "3+", "10", "-2", "3" }, new string[] { });
            larme.Ajoute_Arme("Heavy Inferno combi-bolter", new string[] { "24'", "6", "3+", "6", "-1", "1" }, new string[] { "Devastating wounds" });
            larme.Ajoute_Arme("Autopistol", new string[] { "12'", "1", "4+", "3", "0", "1" }, new string[] { "Pistol" });
            larme.Ajoute_Arme("Chainswords", new string[] { "Melee", "3", "4+", "4", "0", "1" }, new string[] { });
            larme.Ajoute_Arme("Tzaangor blades", new string[] { "Melee", "2", "4+", "5", "-1", "1" }, new string[] { });
            larme.Ajoute_Arme("Blessed chainsword", new string[] { "Melee", "4", "4+", "4", "0", "1" }, new string[] { });
            larme.Ajoute_Arme("Fatecaster greatbow", new string[] { "30'", "2", "4+", "5", "-1", "2" }, new string[] { "Lethal hits", "Precision" });
            larme.Ajoute_Arme("Light close combat weapon", new string[] { "Melee", "2", "4+", "4", "0", "1" }, new string[] { });
            larme.Ajoute_Arme("Divining spear", new string[] { "Melee", "3", "4+", "5", "-2", "1" }, new string[] { "Lance", "Precision" });
            larme.Ajoute_Arme("Mutation orbs", new string[] { "18'", "D6", "3+", "9", "0", "1" }, new string[] { "Blast", "Devastating wounds", "Psychic" });
            larme.Ajoute_Arme("Shaman's stave", new string[] { "Melee", "3", "3+", "5", "-1", "D3" }, new string[] { "Psychic" });
            larme.Ajoute_Arme("Infernal cannon", new string[] { "24'", "6", "2+", "5", "-1", "2" }, new string[] { });
            larme.Ajoute_Arme("Hellforged weapons - strike", new string[] { "Melee", "6", "2+", "8", "-2", "3" }, new string[] { "Psychic" });
            larme.Ajoute_Arme("Hellforged weapons - sweep", new string[] { "Melee", "14", "2+", "6", "0", "1" }, new string[] { "Psychic" });
            larme.Ajoute_Arme("Cultist firearm", new string[] { "24'", "1", "4+", "3", "0", "1" }, new string[] { });
            larme.Ajoute_Arme("Flamer", new string[] { "12'", "D6", "N/A", "4", "0", "1" }, new string[] { });
            larme.Ajoute_Arme("Grenade launcher - frag", new string[] { "24'", "D3", "4+", "4", "0", "1" }, new string[] { "Blast" });
            larme.Ajoute_Arme("Grenade launcher - krak", new string[] { "24'", "1", "4+", "9", "-2", "D3" }, new string[] { });
            larme.Ajoute_Arme("Heavy stubber", new string[] { "36'", "3", "4+", "4", "0", "0" }, new string[] { "Rapid fire 3" });
            larme.Ajoute_Arme("Brutal assault weapon", new string[] { "Melee", "2", "4+", "3", "0", "1" }, new string[] { });
            larme.Ajoute_Arme("Fires of the Abyss", new string[] { "12'", "2D6", "2+", "5", "-1", "1" }, new string[] { "Pistol", "Psychic", "Sustained hits 3" });
            larme.Ajoute_Arme("Force weapon", new string[] { "Melee", "4", "3+", "6", "-1", "D3" }, new string[] { });
            larme.Ajoute_Arme("Coruscating flames", new string[] { "18'", "3", "3+", "4", "-2", "2" }, new string[] { "Anti-monster 4+", "Anti-Vehicle 4+", "Devastating wounds", "Psychic" });
            larme.Ajoute_Arme("Betentacled maw", new string[] { "Melee", "15", "3+", "7", "0", "1" }, new string[] { });
            larme.Ajoute_Arme("Mutalith claws", new string[] { "Melee", "5", "3+", "9", "-2", "4" }, new string[] { });
            larme.Ajoute_Arme("Magma Cutter", new string[] { "6'", "2", "3+", "9", "-4", "D6" }, new string[] { "Melta 2" });
            larme.Ajoute_Arme("Lasher tendrils", new string[] { "Melee", "6", "3+", "7", "-1", "1" }, new string[] { "Extra attacks" });
            larme.Ajoute_Arme("Maulerfiend fists", new string[] { "Melee", "6", "3+", "14", "-2", "D6+1" }, new string[] { });
            larme.Ajoute_Arme("Baleflamer", new string[] { "12'", "D6+3", "N/A", "6", "-1", "2" }, new string[] { "Ignores cover", "Torrent" });
            larme.Ajoute_Arme("Hades autocannon", new string[] { "36'", "6", "3+", "8", "-1", "2" }, new string[] { });
            larme.Ajoute_Arme("Heldrake claws", new string[] { "Melee", "5", "3+", "7", "-1", "2" }, new string[] { "Anti-fly 2", "Devastating wounds" });
            larme.Ajoute_Arme("Heavy flamer", new string[] { "12'", "D6", "N/A", "5", "-1", "1" }, new string[] { "Ignores cover", "Torrent" });
            larme.Ajoute_Arme("Helbrute plasma cannon", new string[] { "36'", "D3", "3+", "8", "-3", "3" }, new string[] { "Blast", "Hazardous" });
            larme.Ajoute_Arme("Missile launcher - frag", new string[] { "48'", "D6", "3+", "4", "-1", "1" }, new string[] { "Blast" });
            larme.Ajoute_Arme("Missile launcher - krak", new string[] { "48'", "1", "3+", "9", "-2", "D6" }, new string[] {  });
            larme.Ajoute_Arme("Multi-melta", new string[] { "18'", "2", "3+", "9", "-4", "D6" }, new string[] { "Melta 2" });
            larme.Ajoute_Arme("Twin autocannon", new string[] { "48'", "2", "3+", "9", "-1", "3" }, new string[] { "Twin-linked" });
            larme.Ajoute_Arme("Twin inferno heavy bolter", new string[] { "36'", "3+", "3", "5", "-2", "2" }, new string[] { "Twin-linked" });
            larme.Ajoute_Arme("Twin lascannon", new string[] { "48'", "1", "3+", "12", "-3", "D6+1" }, new string[] { "Sustained hits 1", "Twin-linked" });
            larme.Ajoute_Arme("Heavy close combat weapon", new string[] { "Melee", "5", "3+", "6", "0", "1" }, new string[] {  });
            larme.Ajoute_Arme("Helbrute fist", new string[] { "Melee", "5", "3+", "12", "-2", "3" }, new string[] {  });
            larme.Ajoute_Arme("Helbrute hammer", new string[] { "Melee", "5", "4+", "14", "-3", "D6+1" }, new string[] {  });
            larme.Ajoute_Arme("Power scourge", new string[] {"Melee", "5", "3+", "7", "-1", "2"}, new string[] { });
            larme.Ajoute_Arme("Ectoplasma cannon", new string[] { "36'", "D3", "3+", "10", "-3", "3" }, new string[] { "Blast" });
            larme.Ajoute_Arme("Forgefiend claws", new string[] { "Melee", "3", "3+", "6", "0", "1" }, new string[] { });
            larme.Ajoute_Arme("Forgefiend jaws", new string[] { "Melee", "5", "3+", "7", "0", "2" }, new string[] { });
            larme.Ajoute_Arme("Defiler cannon", new string[] { "48'", "D6+3", "3+", "10", "-1", "3" }, new string[] { "Blast" });
            larme.Ajoute_Arme("Havoc launcher", new string[] { "48'", "D6", "3+", "5", "0", "1" }, new string[] { "Blast" });
            larme.Ajoute_Arme("Inferno combi-bolter", new string[] { "24'", "2", "3+", "4", "-1", "1" }, new string[] { "Rapid fire 2" });
            larme.Ajoute_Arme("Armoured tracks", new string[] { "Melee", "3", "4+", "6", "0", "1" }, new string[] { });
            larme.Ajoute_Arme("Armoured tracks - Land raider", new string[] { "Melee", "6", "4+", "8", "0", "1" }, new string[] { });
            larme.Ajoute_Arme("Hideous mutations", new string[] { "Melee", "D6+2", "4+", "5", "-1", "2" }, new string[] { });
            larme.Ajoute_Arme("Inferno combi-weapon", new string[] { "24'", "1", "4+", "4", "-1", "1" }, new string[] { "Anti-infantry 4+", "Devastating wounds", "Rapid fire 1" });
            larme.Ajoute_Arme("Reaper autocannon", new string[] { "24'", "1", "4+", "4", "-1", "1" }, new string[] { "Anti-infantry 4+", "Devastating wounds", "Rapid fire 1" });
            larme.Ajoute_Arme("Twin heavy flamer", new string[] { "12'", "D6", "N/A", "5", "-1", "1" }, new string[] { "Ignore cover", "Torrent", "Twin-linked" });
            larme.Ajoute_Arme("Defiler claws", new string[] { "Melee", "5", "3+", "16", "-3", "D6+1" }, new string[] { });
            larme.Ajoute_Arme("Defiler scourge", new string[] { "Melee", "3", "3+", "12", "-1", "2" }, new string[] { });
            larme.Ajoute_Arme("Demolisher autocannon", new string[] { "24'", "D6+3", "3+", "14", "-3", "D6" }, new string[] { "Blast" });
            larme.Ajoute_Arme("Lascannon", new string[] { "48'", "1", "3+", "9", "-1", "3" }, new string[] { "Rapid fire 2" });
            larme.Ajoute_Arme("Predator autocannon", new string[] { "48'", "4", "3+", "9", "-1", "3" }, new string[] { "Rapid fire 2" });
            larme.Ajoute_Arme("Predator twin lascannon", new string[] { "48'", "1", "3+", "14", "-2", "D6+1" }, new string[] { "Twin-liked" });
            larme.Ajoute_Arme("Soulshatter lascannon", new string[] { "48'", "2", "3+", "12", "-3", "D6+1" }, new string[] { });
        }
    }
}
