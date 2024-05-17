namespace HelldiversLoadoutGenerator
{
    internal static class Constants
    {
        public static readonly IReadOnlyList<string> Primaries = Array.AsReadOnly(
            new string[] {
                "AR-23 Liberator (Assault)",
                "AR-23P Liberator Penetrator (Assault)",
                "AR-23C Liberator Concussive (Assault)",
                "AR-61 Tenderizer (Assault)",
                "BR-14 Adjudicator (Assault)",
                "R-63 Diligence (Marksman)",
                "R-63CS Diligence Counter Sniper (Marksman)",
                "MP-98 Knight (Submachine)",
                "SMG-37 Defender (Submachine)",
                "SMG-72 Pummeler (Submachine)",
                "SG-8 Punisher (Shotgun)",
                "SG-8S Slugger (Shotgun)",
                "SG-225 Breaker (Shotgun)",
                "SG-225SP Breaker Spray&Pray (Shotgun)",
                "SG-225IE Breaker Incendiary (Shotgun)",
                "CB-9 Exploding Crossbow (Explosive)",
                "JAR-5 Dominator (Explosive)",
                "R-36 Eruptor (Explosive)",
                "SG-8P Punisher Plasma (Energy)",
                "ARC-12 Blitzer (Energy)",
                "LAS-5 Scythe (Energy)",
                "LAS-16 Sickle (Energy)",
                "PLAS-1 Scorcher (Energy)",
                "PLAS-101 Purifier (Energy)"
            }
        );

        public static readonly IReadOnlyList<string> Secondaries = Array.AsReadOnly(
            new string[] {
                "P-2 Peacemaker (Pistol)",
                "P-19 Redeemer (Pistol)",
                "GP-31 Grenade Pistol (Pistol)",
                "LAS-7 Dagger (Pistol)",
                "P-113 Verdict (Pistol)",
                "P-4 Senator (Pistol)"
            }
        );

        public static readonly IReadOnlyList<string> Grenades = Array.AsReadOnly(
            new string[] {
                "G-6 Frag (Standard)",
                "G-12 High Explosive (Standard)",
                "G-10 Incendiary (Standard)",
                "G-16 Impact (Special)",
                "G-13 Incendiary Impact (Special)",
                "G-23 Stun (Special)",
                "G-3 Smoke (Special)",
                "G-123 Thermite (Special)"
            }
        );

        public static readonly IReadOnlyList<string> Armors = Array.AsReadOnly(
            new string[] {
                "FS-37 Ravager (Light, Engineering Kit)",
                "CE-74 Breaker (Light, Engineering Kit)",
                "CE-67 Titan (Light, Engineering Kit)",
                "CM-21 Trench Paramedic (Light, Med-Kit)",
                "CE-07 Demolition Specialist (Light, Engineering Kit)",
                "FS-38 Eradicator (Light, Fortified)",
                "EX-00 Prototype X (Light, Electrical Conduit)",
                "SC-37 Legionnaire (Light, Servo-Assisted)",
                "B-08 Light Gunner (Light, Extra Padding)",
                "SC-30 Trailblazer Scout (Light, Scout)",
                "SC-34 Infiltrator (Light, Scout)",
                "SA-25 Steel Trooper (Medium, Servo-Assisted)",
                "SA-12 Servo Assisted (Medium, Servo-Assisted)",
                "CE-35 Trench Engineer (Medium, Engineering Kit)",
                "CE-27 Ground Breaker (Medium, Engineering Kit)",
                "CM-09 Bonesnapper (Medium, Med-Kit)",
                "CM-10 Clinician (Medium, Med-Kit)",
                "SC-15 Drone Master (Medium, Engineering Kit)",
                "EX-03 Prototype 3 (Medium, Electrical Conduit)",
                "EX-16 Prototype 16 (Medium, Electrical Conduit)",
                "FS-34 Exterminator (Medium, Fortified)",
                "DP-40 Hero Of The Federation (Medium, Democracy Protects)",
                "DP-11 Champion Of The People (Medium, Democracy Protects)",
                "CM-14 Physician (Medium, Med-Kit)",
                "CE-81 Juggernaut (Medium, Engineering Kit)",
                "DP-53 Savior Of The Free (Medium, Democracy Protects)",
                "B-24 Enforcer (Medium, Fortified)",
                "B-01 Tactical (Medium, Extra Padding)",
                "CW-9 White Wolf (Medium, Extra Padding)",
                "SA-04 Combat Technician (Medium, Scout)",
                "FS-55 Devastator (Heavy, Fortified)",
                "CW-22 Kodiak (Heavy, Fortified)",
                "SA-32 Dynamo (Heavy, Servo-Assisted)",
                "CM-17 Butcher (Heavy, Med-Kit)",
                "FS-61 Dreadnought (Heavy, Servo-Assisted)",
                "B-27 Fortified Commando (Heavy, Extra Padding)",
                "FS-05 Marksman (Heavy, Fortified)",
                "FS-11 Executioner (Heavy, Fortified)",
                "CE-64 Grenadier (Heavy, Engineering Kit)",
                "FS-23 Battle Master (Heavy, Fortified)",
                "CW-36 Winter Warrior (Heavy, Servo-Assisted)"
            }
        );

        public static readonly IReadOnlyList<string> Weapons = Array.AsReadOnly(
            new string[] {
                "Machine Gun (Weapon)",
                "Anti-Materiel Rifle (Weapon)",
                "Stalwart (Weapon)",
                "Expendable Anti-Tank (Weapon)",
                "Flamethrower (Weapon)",
                "Heavy Machine Gun (Weapon)",
                "Railgun (Weapon)",
                "Grenade Launcher (Weapon)",
                "Laser Cannon (Weapon)",
                "Arc Thrower (Weapon)",
                "Quasar Cannon (Weapon)"
            }
        );

        public static readonly IReadOnlyList<string> WeaponsWithBackpack = Array.AsReadOnly(
            new string[] {
                "Recoilless Rifle (Weapon & Pack)",
                "Autocannon (Weapon & Pack)",
                "Airburst Rocket Launcher (Weapon & Pack)",
                "Spear (Weapon & Pack)"
            }
        );

        public static readonly IReadOnlyList<string> Backpacks = Array.AsReadOnly(
            new string[] {
                "Jump Pack (Backpack)",
                "Supply Pack (Backpack)",
                "Guard Dog Rover (Backpack)",
                "Ballistic Shield (Backpack)",
                "Shield Generator (Backpack)",
                "Guard Dog (Backpack)"
            }
        );

        public static readonly IReadOnlyList<string> Offensives = Array.AsReadOnly(
            new string[] {
                "Orbital Gatling Barrage (Offense)",
                "Orbital Airburst Strike (Offense)",
                "Orbital 120MM HE Barrage (Offense)",
                "Orbital 380MM HE Barrage (Offense)",
                "Orbital Laser (Offense)",
                "Orbital Railcannon Strike (Offense)",
                "Orbital Precision Strike (Offense)",
                "Orbital Gas Strike (Offense)",
                "Orbital EMS Strike (Offense)",
                "Orbital Smoke Strike (Offense)",
                "Eagle Strafing Run (Offense)",
                "Eagle Airstrike (Offense)",
                "Eagle Cluster Bomb (Offense)",
                "Eagle Napalm Airstrike (Offense)",
                "Eagle Smoke Strike (Offense)",
                "Eagle 110MM Rocket Pods (Offense)",
                "Eagle 500KG Bomb (Offense)"
            }
        );

        public static readonly IReadOnlyList<string> Defensives = Array.AsReadOnly(
            new string[] {
                "HMG Emplacement (Defense)",
                "Shield Generator Relay (Defense)",
                "Tesla Tower (Defense)",
                "Anti-Personnel Minefield (Defense)",
                "Incendiary Mines (Defense)",
                "Machine Gun Sentry (Defense)",
                "Gatling Sentry (Defense)",
                "Mortar Sentry (Defense)",
                "Autocannon Sentry (Defense)",
                "Rocket Sentry (Defense)",
                "EMS Mortar Sentry (Defense)",
                "Patriot Exosuit (Defense)"
            }
        );
    }
}
