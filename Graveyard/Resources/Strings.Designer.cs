﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HDT.Plugins.Graveyard.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HDT.Plugins.Graveyard.Resources.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dragoncaller Alanna.
        /// </summary>
        public static string Alanna {
            get {
                return ResourceManager.GetString("Alanna", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Dragoncaller Alanna&apos;, show spells that cost 5 or more that have been played..
        /// </summary>
        public static string AlannaDescription {
            get {
                return ResourceManager.GetString("AlannaDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Anyfin.
        /// </summary>
        public static string Anyfin {
            get {
                return ResourceManager.GetString("Anyfin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Anyfin Can Happen&apos;, show murlocs that have died and display minimum and maximum possible damage.
        /// </summary>
        public static string AnyfinDescription {
            get {
                return ResourceManager.GetString("AnyfinDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Caverns Below.
        /// </summary>
        public static string Caverns {
            get {
                return ResourceManager.GetString("Caverns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;The Caverns Below&apos;, count all minions played.
        /// </summary>
        public static string CavernsDescription {
            get {
                return ResourceManager.GetString("CavernsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deathrattle.
        /// </summary>
        public static string Deathrattle {
            get {
                return ResourceManager.GetString("Deathrattle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Twilight&apos;s Call&apos;, show the deathrattle minions that have died.
        /// </summary>
        public static string DeathrattleDescription {
            get {
                return ResourceManager.GetString("DeathrattleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Discard.
        /// </summary>
        public static string Discard {
            get {
                return ResourceManager.GetString("Discard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Cruel Dinomancer&apos;, show summon chance of friendly minions that have been discarded.
        /// </summary>
        public static string DiscardDescription {
            get {
                return ResourceManager.GetString("DiscardDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Discarded Minions.
        /// </summary>
        public static string DiscardTitle {
            get {
                return ResourceManager.GetString("DiscardTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Friendly.
        /// </summary>
        public static string Friendly {
            get {
                return ResourceManager.GetString("Friendly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All friendly minions that have died..
        /// </summary>
        public static string FriendlyDescription {
            get {
                return ResourceManager.GetString("FriendlyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Graveyard.
        /// </summary>
        public static string Graveyard {
            get {
                return ResourceManager.GetString("Graveyard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays minions that have died this game. Includes specialized displays:
        ///- Deathrattle minions (Nine Lives/Da Undatakah/Twilight&apos;s Call/N&apos;Zoth)
        ///- Taunt minions (Hadronox)
        ///- Demons (Bloodreaver Gul&apos;dan)
        ///- Resurrection chance (Catrina Muerte/Mass Resurrection/Wild Priest cards)
        ///- Murloc minions with a damage calculator for Anyfin Can Happen
        ///- Discard retrieve chance (Soulwarden/Cruel Dinomancer) 
        ///- Treant deaths (Mulchmuncher)
        ///- Mech deaths (Kangor&apos;s Endless Army)
        ///- 5-cost spells (Dragoncaller Alann [rest of string was truncated]&quot;;.
        /// </summary>
        public static string GraveyardDescription {
            get {
                return ResourceManager.GetString("GraveyardDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bloodreaver Gul&apos;dan.
        /// </summary>
        public static string Guldan {
            get {
                return ResourceManager.GetString("Guldan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Bloodreaver Gul&apos;dan&apos;, show demons that have died.
        /// </summary>
        public static string GuldanDescription {
            get {
                return ResourceManager.GetString("GuldanDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hadronox.
        /// </summary>
        public static string Hadronox {
            get {
                return ResourceManager.GetString("Hadronox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Hadronox&apos;, show the friendly taunt minions that have died.
        /// </summary>
        public static string HadronoxDescription {
            get {
                return ResourceManager.GetString("HadronoxDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kangor&apos;s Endless Army.
        /// </summary>
        public static string Kangor {
            get {
                return ResourceManager.GetString("Kangor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Kangor&apos;s Endless Army&apos;, show summon chance of friendly (base) Mechs that have died.
        /// </summary>
        public static string KangorDescription {
            get {
                return ResourceManager.GetString("KangorDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kazakus.
        /// </summary>
        public static string Kazakus {
            get {
                return ResourceManager.GetString("Kazakus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Also display for resurrect chances with Kazakus..
        /// </summary>
        public static string KazakusDescription {
            get {
                return ResourceManager.GetString("KazakusDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lock Graveyards.
        /// </summary>
        public static string Lock {
            get {
                return ResourceManager.GetString("Lock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mulchmuncher.
        /// </summary>
        public static string Mulchmuncher {
            get {
                return ResourceManager.GetString("Mulchmuncher", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains at least one &apos;Mulchmuncher&apos;, count Treants that have died.
        /// </summary>
        public static string MulchmuncherDescription {
            get {
                return ResourceManager.GetString("MulchmuncherDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to N&apos;Zoth.
        /// </summary>
        public static string NZoth {
            get {
                return ResourceManager.GetString("NZoth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;N&apos;Zoth, the Corruptor&apos;, show the deathrattle minions that have died.
        /// </summary>
        public static string NZothDescription {
            get {
                return ResourceManager.GetString("NZothDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opacity.
        /// </summary>
        public static string Opacity {
            get {
                return ResourceManager.GetString("Opacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opponent.
        /// </summary>
        public static string Opponent {
            get {
                return ResourceManager.GetString("Opponent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All enemy minions that have died.
        /// </summary>
        public static string OpponentDescription {
            get {
                return ResourceManager.GetString("OpponentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resurrect.
        /// </summary>
        public static string Resurrect {
            get {
                return ResourceManager.GetString("Resurrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Resurrect&apos;, &apos;Onyx Bishop&apos;, &apos;Eternal Servitude&apos;, or &apos;Lesser Diamond Spellstone&apos;, show the resurrect chance of friendly  minions that have died.
        /// </summary>
        public static string ResurrectDescription {
            get {
                return ResourceManager.GetString("ResurrectDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scale.
        /// </summary>
        public static string Scale {
            get {
                return ResourceManager.GetString("Scale", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings.
        /// </summary>
        public static string Settings {
            get {
                return ResourceManager.GetString("Settings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Graveyard Settings.
        /// </summary>
        public static string SettingsTitle {
            get {
                return ResourceManager.GetString("SettingsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shudderwock.
        /// </summary>
        public static string Shudderwock {
            get {
                return ResourceManager.GetString("Shudderwock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Shudderwock&apos;, show battlecry minions that have been played.
        /// </summary>
        public static string ShudderwockDescription {
            get {
                return ResourceManager.GetString("ShudderwockDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Soulwarden.
        /// </summary>
        public static string Soulwarden {
            get {
                return ResourceManager.GetString("Soulwarden", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Soulwarden&apos;, show chance of retrieving friendly cards that have been discarded.
        /// </summary>
        public static string SoulwardenDescription {
            get {
                return ResourceManager.GetString("SoulwardenDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tess Greymane.
        /// </summary>
        public static string TessGreymane {
            get {
                return ResourceManager.GetString("TessGreymane", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Tess Greymane&apos;, show all cards from other classes played this game..
        /// </summary>
        public static string TessGreymaneDescription {
            get {
                return ResourceManager.GetString("TessGreymaneDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unlock Graveyards.
        /// </summary>
        public static string Unlock {
            get {
                return ResourceManager.GetString("Unlock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Witching Hour.
        /// </summary>
        public static string WitchingHour {
            get {
                return ResourceManager.GetString("WitchingHour", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When the deck contains &apos;Witching Hour&apos;, show summon chance of friendly Beasts that have died.
        /// </summary>
        public static string WitchingHourDescription {
            get {
                return ResourceManager.GetString("WitchingHourDescription", resourceCulture);
            }
        }
    }
}