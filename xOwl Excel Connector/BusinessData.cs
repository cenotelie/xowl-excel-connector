using xOwl_Annotations;
using xOwl_Excel_Connector;

/// <summary>
/// Business Data
/// </summary>
namespace BusinessData
{
    /// <summary>
    /// Spec EHSA_v1.xslx
    /// Feuille Spec
    /// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/spec/spec#", Position = "Spec", ProcessId = "collins_process", TaskId = "spec_params")]
    public class Spec : Identifiable
    {
        /*
		Section 1 DONNEES GENERALES
		*/
        [PushConfiguration(Position = new int[] { 4, 4 })]
        public string AircraftType { get; set; }
        [PushConfiguration(Position = new int[] { 5, 4 })]
        public string System { get; set; }
        [PushConfiguration(Position = new int[] { 6, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 4, 3 })]
        public string TypeDeServocommande { get; set; }
        [PushConfiguration(Position = new int[] { 7, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 7, 3 })]
        public string NombreActionneurParSurface { get; set; }

        /*
		Section 2 SPACE ENVELOP and WEIGHT
		*/
        [PushConfiguration(Position = new int[] { 10, 4 })] //Format "(Length, Width, Height)" en (mm mm mm)
        public string SpaceEnvelop { get; set; }
        [PushConfiguration(Position = new int[] { 11, 4 })]
        public int DistanceBetweenAttachments { get; set; }
        [PushConfiguration(Position = new int[] { 12, 4 })]
        public int MaximumWeight { get; set; }
        [PushConfiguration(Position = new int[] { 13, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 16, 3 })]
        [StaticPerformanceConfiguration(Position = new int[] { 15, 5 })]
        public double AngleBraquageGouverneExtension { get; set; }
        [PushConfiguration(Position = new int[] { 14, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 17, 3 })]
        [StaticPerformanceConfiguration(Position = new int[] { 16, 5 })]
        public double AngleBraquageGouverneRetractionNegatif { get; set; }
        [PushConfiguration(Position = new int[] { 15, 4 })]
        [StaticPerformanceConfiguration(Position = new int[] { 11, 5 })]
        public double ExtensionStroke { get; set; }
        [PushConfiguration(Position = new int[] { 16, 4 })]
        [StaticPerformanceConfiguration(Position = new int[] { 12, 5 })]
        public double RetractionStroke { get; set; }

        /*
		Section 3 FUNCTIONAL REQUIREMENTS
		*/
        [PushConfiguration(Position = new int[] { 19, 4 })]
        public string ActuatorModes { get; set; }
        [PushConfiguration(Position = new int[] { 20, 4 })]
        public string ControlInterface { get; set; }
        [PushConfiguration(Position = new int[] { 21, 4 })]
        public string ControlSignalMagnitude { get; set; } //Format " +/- 8" en (mA) ?

        /*
		Section 4 PERFORMANCE
		*/

        [PushConfiguration(Position = new int[] { 23, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 21, 3 })]
        [StaticPerformanceConfiguration(Position = new int[] { 34, 5 })]
        public double SupplyPressure { get; set; }
        [PushConfiguration(Position = new int[] { 24, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 22, 3 })]
        [StaticPerformanceConfiguration(Position = new int[] { 35, 5 })]
        public double ReturnPressure { get; set; }
        [PushConfiguration(Position = new int[] { 25, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 23, 3 })]
        public double SupplyProofPressure { get; set; }
        [PushConfiguration(Position = new int[] { 26, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 24, 3 })]
        public double ReturnProofPressure { get; set; }
        [PushConfiguration(Position = new int[] { 27, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 25, 3 })]
        [StaticPerformanceConfiguration(Position = new int[] { 10, 5 })]
        public double LimitLoad { get; set; }
        [PushConfiguration(Position = new int[] { 28, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 26, 3 })]
        public double StallLoadExtension { get; set; }
        [PushConfiguration(Position = new int[] { 29, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 27, 3 })]
        public double StallLoadRetraction { get; set; }
        [PushConfiguration(Position = new int[] { 30, 4 })]
        [PowerRamDataConfiguration(Position = new int[] { 32, 3 })]
        [StaticPerformanceConfiguration(Position = new int[] { 20, 5 })]
        public double DampingCoefficient { get; set; }
        [PushConfiguration(Position = new int[] { 31, 4 })]
        [StaticPerformanceConfiguration(Position = new int[] { 30, 5 })]
        public double MaxPowerPointLoad { get; set; }
        [PushConfiguration(Position = new int[] { 32, 4 })]
        [StaticPerformanceConfiguration(Position = new int[] { 30, 1 })]
        public double MaxPowerPointSpeed { get; set; }
        [PushConfiguration(Position = new int[] { 33, 4 })]
        [StaticPerformanceConfiguration(Position = new int[] { 30, 7 })]
        public double MinFluidTemperature { get; set; }
        [PushConfiguration(Position = new int[] { 34, 4 })]
        [StaticPerformanceConfiguration(Position = new int[] { 42, 5 })]
        public double MaxFluidTemperature { get; set; }

        /*
		Section 5 DUTY CYCLE
		*/
        [PushConfiguration(Position = new int[] { 38, 4 })]
        public int UsefulLife { get; set; } //int suffisant?
        [PushConfiguration(Position = new int[] { 39, 4 })]
        public string EquivalentPermanentCycle { get; set; } //Format sine 1Hz +/- 2mm
        [PushConfiguration(Position = new int[] { 40, 4 })]
        public int PermanentLoad { get; set; } //int suffisant?

    }

    /// <summary>
    /// Spec EHSA_v1.xslx
    /// Feuille Actuator Key characteristics
    /// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/spec/actuatorkeycharacteristics#", Position = "Actuator Key characteristics", ProcessId = "collins_process", TaskId = "akct")]
    public class ActuatorKeyCharacteristics : Identifiable
    {
        /*
		Cartouche Identification
		*/
        /*
        [PushConfiguration(Position = new int[] { 7, 2 })] //Expected column B
        public string Programme { get; set; }
        [PushConfiguration(Position = new int[] { 8, 2 })]
        public string Author { get; set; }
        [PushConfiguration(Position = new int[] { 9, 2 })]
        public string Date { get; set; }
        [PushConfiguration(Position = new int[] { 10, 2 })]
        public string Version { get; set; }
        */
        /*
		Cartouche Actuator Key characteristics Aileron
		*/
        //Power lane
        [PushConfiguration(Position = new int[] { 17, 2 })]
        public string ActuatorType { get; set; } //(balanced/unbalanced sections)
        [PushConfiguration(Position = new int[] { 18, 2 })]
        public double RodDiameter { get; set; }
        [PushConfiguration(Position = new int[] { 19, 2 })]
        public double PistonDiameter { get; set; }

        //Attachments
        [PushConfiguration(Position = new int[] { 22, 2 })]
        public string TypeRodEnd { get; set; } //(male/femelle)
        [PushConfiguration(Position = new int[] { 23, 2 })]
        public double PinToPinDistance { get; set; }

        //Hydraulic block
        [PushConfiguration(Position = new int[] { 26, 2 })]
        public double SelectedTubeDiameter { get; set; }

        //Servovalve
        [PushConfiguration(Position = new int[] { 29, 2 })]
        public double EHSVMinFlow { get; set; }

        //Acumulator
        [PushConfiguration(Position = new int[] { 32, 2 })]
        public double MinimumAcumulatorPressure { get; set; }
        [PushConfiguration(Position = new int[] { 33, 2 })]
        public double MinimumAccumulatorVolume { get; set; }
    }

    /// <summary>
    /// Power_ram_sizing.xlsx
    /// Feuille Donnees
    /// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/powerramsizing/donnees#", Position = "Donnees", ProcessId = "collins_process", TaskId = "prs")]
    public class PowerRamSizingDonnees : Identifiable
    {
        /*
		Cartouche Données générales
		*/
        [PushConfiguration(Position = new int[] { 4, 3 })]
        [ActuatorConfiguration(Position = new int[] { 17, 2 })]
        public string TypeDeServocommande { get; set; }
        [PushConfiguration(Position = new int[] { 5, 3 })]
        public string TypeAccrocheCoteBati { get; set; }
        [PushConfiguration(Position = new int[] { 6, 3 })]
        [ActuatorConfiguration(Position = new int[] { 22, 2 })]
        public string ChoixDeLEmbout { get; set; }
        [PushConfiguration(Position = new int[] { 7, 3 })]
        public int NombreActionneurParSurface { get; set; }
        [PushConfiguration(Position = new int[] { 8, 3 })]
        public bool DimensionnementEnFatigue { get; set; }

        /*
		Cartouche Données plan d'encombrement
		*/
        [PushConfiguration(Position = new int[] { 11, 3 })]
        public double Surcourse { get; set; }

        [PushConfiguration(Position = new int[] { 13, 3 })]
        public double AncrageServocommandeAQ { get; set; }
        [PushConfiguration(Position = new int[] { 14, 3 })]
        public double MoyeuGourverneRQB { get; set; }
        [PushConfiguration(Position = new int[] { 15, 3 })]
        public double EntraxeNeutreE0AB0 { get; set; }
        [PushConfiguration(Position = new int[] { 16, 3 })]
        public double AngleBraquageGouverneExtension { get; set; }
        [PushConfiguration(Position = new int[] { 17, 3 })]
        public double AngleBraquageGouverneRetractionNegatif { get; set; }

        /*
		Cartouche Données dimensionnement en statique
		*/
        [PushConfiguration(Position = new int[] { 21, 3 })]
        public double PressionEntreeStatique { get; set; }
        [PushConfiguration(Position = new int[] { 22, 3 })]
        public double PressionSortieStatique { get; set; }
        [PushConfiguration(Position = new int[] { 23, 3 })]
        //[PowerRamDataConfiguration(Position = new int[] { 23, 3 })]
        public double SurpressionEntree { get; set; }
        [PushConfiguration(Position = new int[] { 24, 3 })]
        //[PowerRamDataConfiguration(Position = new int[] { 24, 3 })]
        public double SurpressionSortie { get; set; }
        [PushConfiguration(Position = new int[] { 25, 3 })]
        public double ChargeLimite { get; set; }
        [PushConfiguration(Position = new int[] { 26, 3 })]
        public double ChargeArretExtension { get; set; }
        [PushConfiguration(Position = new int[] { 27, 3 })]
        public double ChargeArretRetraction { get; set; }
        [PushConfiguration(Position = new int[] { 28, 3 })]
        [StaticPerformanceConfiguration(Position = new int[] { 22, 5 })]
        public double InertieGouverne { get; set; }
        [PushConfiguration(Position = new int[] { 29, 3 })]
        [StaticPerformanceConfiguration(Position = new int[] { 25, 5 })]
        public double RaideurCoteGouverne { get; set; }
        [PushConfiguration(Position = new int[] { 30, 3 })]
        [StaticPerformanceConfiguration(Position = new int[] { 24, 5 })]
        public double RaideurCoteBati { get; set; }
        [PushConfiguration(Position = new int[] { 31, 3 })]
        public double CoupleRafaleVentSol { get; set; }
        [PushConfiguration(Position = new int[] { 32, 3 })]
        public double CoefficientAmortissement { get; set; }
    }

    /// <summary>
    /// Power_ram_sizing.xlsx
    /// Feuille Schema LP symetrique 1 
    /// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/powerramsizing/schemalpsymetrique#", Position = "Schema LP symetrique 1")]
    public class PowerRamSizingSchemaLPSymetrique : Identifiable
    {
        /*
		Cartouche Dimensions caractéristiques
		*/
        [PushConfiguration(Position = new int[] { 34, 10 })]
        [HydraulicBlockConfiguration(Position = new int[] { 15, 3 })]
        [ActuatorConfiguration(Position = new int[] { 23, 2 })]
        public double SectionUtile { get; set; }
        [PushConfiguration(Position = new int[] { 35, 10 })]
        public double ToileTige { get; set; }
        [PushConfiguration(Position = new int[] { 36, 10 })]
        [ActuatorConfiguration(Position = new int[] { 18, 2 })]
        [HydraulicBlockConfiguration(Position = new int[] { 22, 3 })]
        public double DiametresTige { get; set; }
        [PushConfiguration(Position = new int[] { 37, 10 })]
        [ActuatorConfiguration(Position = new int[] { 19, 2 })]
        public double DiametresPiston { get; set; }

        /*
		Schéma valeurs résultats
		*/
        [PushConfiguration(Position = new int[] { 12, 25 })]
        public double R1 { get; set; }
        [PushConfiguration(Position = new int[] { 32, 25 })]
        [ActuatorConfiguration(Position = new int[] { 26, 2 })]
        public double R2 { get; set; }
        [PushConfiguration(Position = new int[] { 34, 25 })]
        public double R3 { get; set; }
        [PushConfiguration(Position = new int[] { 10, 46 })]
        [ActuatorConfiguration(Position = new int[] { 23, 10 })]
        public double R4 { get; set; }
        [PushConfiguration(Position = new int[] { 31, 46 })]
        public double R5 { get; set; }
        [PushConfiguration(Position = new int[] { 12, 50 })]
        public double R6 { get; set; }
        [PushConfiguration(Position = new int[] { 32, 51 })]
        public double R7 { get; set; }
        [PushConfiguration(Position = new int[] { 31, 56 })]
        public double R8 { get; set; }
        [PushConfiguration(Position = new int[] { 31, 63 })]
        public double R9 { get; set; }
        [PushConfiguration(Position = new int[] { 31, 69 })]
        public double R10 { get; set; }
        [PushConfiguration(Position = new int[] { 12, 74 })]
        public double R11 { get; set; }
        [PushConfiguration(Position = new int[] { 22, 89 })]
        public double R12 { get; set; }
        [PushConfiguration(Position = new int[] { 31, 91 })]
        public double R13 { get; set; }
    }

    [BusinessClass(BaseUri = "http://xowl.org/aileron/param_spec#", Position = "Paramètre spec", ProcessId = "collins_process", TaskId = "static_perf")]
    public class ParametreSpec : Identifiable
    {
        [PushConfiguration(Position = new int[] { 10, 5 })]
        public double ChargeArret { get; set; }
        [PushConfiguration(Position = new int[] { 11, 5 })]
        public double CourseNominalExtension { get; set; }
        [PushConfiguration(Position = new int[] { 12, 5 })]
        public double CourseNominalRetraction { get; set; }
        [PushConfiguration(Position = new int[] { 15, 5 })]
        public double DeflectionGouverneExtension { get; set; }
        [PushConfiguration(Position = new int[] { 16, 5 })]
        public double DeflectionGouverneRetraction { get; set; }
        [PushConfiguration(Position = new int[] { 20, 5 })]
        public double CoefficientAmortissement { get; set; }
        [PushConfiguration(Position = new int[] { 22, 5 })]
        public double InertieGouverne { get; set; }
        [PushConfiguration(Position = new int[] { 24, 5 })]
        public double RaideurAttacheCoteFixe { get; set; }
        [PushConfiguration(Position = new int[] { 25, 5 })]
        public double RaideurAttacheCoteMobile { get; set; }
        [PushConfiguration(Position = new int[] { 30, 1 })]
        public double Vitesse { get; set; }
        [PushConfiguration(Position = new int[] { 30, 3 })]
        public double Position { get; set; }
        [PushConfiguration(Position = new int[] { 30, 5 })]
        [ActuatorConfiguration(Position = new int[] { 29, 2 })]
        public double Effort { get; set; }
        [PushConfiguration(Position = new int[] { 30, 7 })]
        public double Temperature { get; set; }
        [PushConfiguration(Position = new int[] { 34, 5 })]
        [ActuatorConfiguration(Position = new int[] { 32, 2 })]
        public double PressionAlimentationNominale { get; set; }
        [PushConfiguration(Position = new int[] { 35, 5 })]
        [ActuatorConfiguration(Position = new int[] { 33, 2 })]
        public double PressionRetourNominale { get; set; }
    }
}
