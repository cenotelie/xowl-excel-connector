using xOwl_Annotations;
using xOwl_Excel_Connector;

/// <summary>
/// Business Data
/// </summary>
namespace BusinessData
{
    /*
    [BusinessClass(BaseUri = "http://xowl.org/requirement#")]
    public class Requirement : Identifiable
    {
        [CellConfiguration(CellsAfter = 1)]
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    [BusinessClass(BaseUri = "http://xowl.org/function#")]
    public class Function : Identifiable
    {
        public string Name { get; set; }
        public double Priority { get; set; }
    }

    [BusinessClass(BaseUri = "http://xowl.org/components#")]
    public class Component : Identifiable
    {
        [CellConfiguration(CellsAfter = 2)]
        public string Name { get; set; }

        public int Complexity { get; set; }
    }*/
	
	
	/// <summary>
	/// Aileron_static_perfo_TBS.xls
	/// Feuille Paramètre spec
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/specparam#", IsComplex = true, Position = "Paramètre spec", ProcessId = "collins", TaskId = "spec_params")]
    public class SpecParameter : Identifiable
    {
		/*
		Cartouche haut, description et réf produit
		*/
		/*[CellConfiguration(Position = new int[] { 1, 2 })]
        public string Projet { get; set; }
        [CellConfiguration(Position = new int[] { 2, 2 })]
        public string Produit { get; set; }
        [CellConfiguration(Position = new int[] { 3, 2 })]
        public string RefSpecification { get; set; }
        [CellConfiguration(Position = new int[] { 1, 14 })]
        public string DateMAJ { get; set; }
        [CellConfiguration(Position = new int[] { 2, 14 })]
        public string NumVersion { get; set; }
		[CellConfiguration(Position = new int[] { 3, 14 })]
        public string Emetteur { get; set; }*/

		/*
		Cartouche spécification client : Définitions (Unités SI)
		*/
        [CellConfiguration(Position = new int[] { 10, 5 })]
        public double ChargeArret { get; set; }
        [CellConfiguration(Position = new int[] { 11, 5 })]
        public double ChargeNominaleExtention { get; set; }
        [CellConfiguration(Position = new int[] { 12, 5 })]
        public double ChargeNominaleRetraction { get; set; }
        [CellConfiguration(Position = new int[] { 13, 5 })]
        public double CourseButeeExtension { get; set; }
        [CellConfiguration(Position = new int[] { 14, 5 })]
        public double CourseButeeRetraction { get; set; }
		[CellConfiguration(Position = new int[] { 15, 5 })]
        public double DeflectionGouverneExtension { get; set; }
        [CellConfiguration(Position = new int[] { 16, 5 })]
        public double DeflectionGouverneRetraction { get; set; }
        [CellConfiguration(Position = new int[] { 17, 5 })]
        public double EntraxeZero { get; set; }
        [CellConfiguration(Position = new int[] { 18, 5 })]
        public double BrasLevier { get; set; }
        [CellConfiguration(Position = new int[] { 19, 5 })]
        public double AngleZero { get; set; }
        [CellConfiguration(Position = new int[] { 20, 5 })]
        public double CoefficientAmortissementMini { get; set; }
		
        [CellConfiguration(Position = new int[] { 22, 5 })]
        public double InertieGourverne { get; set; }
        [CellConfiguration(Position = new int[] { 23, 5 })]
        public double MasseEquivalente { get; set; }
        [CellConfiguration(Position = new int[] { 24, 5 })]
        public double RaideurAttacheCoteFixe { get; set; }
        [CellConfiguration(Position = new int[] { 25, 5 })]
        public double RaideurAttacheCoteMobile { get; set; }

		/*
		Cartouche Points de performance (Unités SI)
		*/
		[CellConfiguration(Position = new int[] { 30, 1 })]
        public double PointsPerformanceVitesse1 { get; set; }
        [CellConfiguration(Position = new int[] { 31, 1 })]
        public double PointsPerformanceVitesse2 { get; set; }
        [CellConfiguration(Position = new int[] { 32, 1 })]
        public double PointsPerformanceVitesse3 { get; set; }
        [CellConfiguration(Position = new int[] { 30, 3 })]
        public double PointsPerformancePosition1 { get; set; }
        [CellConfiguration(Position = new int[] { 31, 3 })]
        public double PointsPerformancePosition2 { get; set; }
        [CellConfiguration(Position = new int[] { 32, 3 })]
        public double PointsPerformancePosition3 { get; set; }
        [CellConfiguration(Position = new int[] { 30, 5 })]
        public double PointsPerformanceEffort1 { get; set; }
        [CellConfiguration(Position = new int[] { 31, 5 })]
        public double PointsPerformanceEffort2 { get; set; }
        [CellConfiguration(Position = new int[] { 32, 5 })]
        public double PointsPerformanceEffort3 { get; set; }
        [CellConfiguration(Position = new int[] { 30, 7 })]
        public double PointsPerformanceTemperature1 { get; set; }
        [CellConfiguration(Position = new int[] { 31, 7 })]
        public double PointsPerformanceTemperature2 { get; set; }
        [CellConfiguration(Position = new int[] { 32, 7 })]
        public double PointsPerformanceTemperature3 { get; set; }

		/*
		Cartouche Pressions (Unités SI)
		*/
		[CellConfiguration(Position = new int[] { 36, 5 })]
        public double PressionAlimentationNominale { get; set; }
        [CellConfiguration(Position = new int[] { 37, 5 })]
        public double PressionRetourNominale { get; set; }
		
        [CellConfiguration(Position = new int[] { 39, 5 })]
        public double PressionAlimentationDimensionnmentSV { get; set; }
        [CellConfiguration(Position = new int[] { 40, 5 })]
        public double PressionRetourDimensionnementSV { get; set; }

		/*
		Cartouche Températures
		*/
		[CellConfiguration(Position = new int[] { 44, 5 })]
        public double TemperatureFluide { get; set; }
        [CellConfiguration(Position = new int[] { 45, 5 })]
        public double TemperatureReferenceFluide1 { get; set; }
        [CellConfiguration(Position = new int[] { 46, 5 })]
        public double TemperatureReferenceFluide2 { get; set; }

		/*
		Cartouche Accumulateur
		*/
        [CellConfiguration(Position = new int[] { 49, 5 })]
        public double AccumulateurTemperatureMinimaleVariationsVolume { get; set; }
        [CellConfiguration(Position = new int[] { 50, 5 })]
        public double AccumulateurTemperatureMaximaleVariationsVolume { get; set; }
        [CellConfiguration(Position = new int[] { 51, 5 })]
        public double AccumulateurDureeCompenserFuitesExternes { get; set; }

    }

	/// <summary>
	/// Aileron_static_perfo_TBS.xls
	/// Feuille section vérin
	/// Calcul de la section nécessaire pour obtenir la charge d'arrêt
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/sectionverin#", IsComplex = true, Position = "section vérin", ProcessId = "collins", TaskId = "section_verin")]
    public class SectionVerin : Identifiable
    {
        /*
        Cartouche Paramètres de la spécification utiles pour le calcul 
        */
        [CellConfiguration(Position = new int[] { 10, 5 })]
        public double ChargeArretSouhaitee { get; set; }
        [CellConfiguration(Position = new int[] { 11, 5 })]
        public double PressionAlimentationNominale { get; set; }
        [CellConfiguration(Position = new int[] { 12, 5 })]
        public double PressionRetourNominale { get; set; }

        /*
		Cartouche Paramètres internes (Unités SI)
		*/
        [CellConfiguration(Position = new int[] { 18, 5 })]
        public double FrottementsJointsEstimes { get; set; }
        [CellConfiguration(Position = new int[] { 19, 5 })]
        public double DpOuvertureClapetIsolementRetour { get; set; }
        [CellConfiguration(Position = new int[] { 20, 5 })]
        public double DiametreTige { get; set; }

		/*
		Cartouche Résultats (Unités SI)
		*/
		[CellConfiguration(Position = new int[] { 26, 5 })]
        public double DifferentielPressionDisponible { get; set; }
        [CellConfiguration(Position = new int[] { 27, 5 })]
        public double SectionUtile { get; set; }
        [CellConfiguration(Position = new int[] { 28, 5 })]
        public double CalculDiametreAlesage { get; set; }
        [CellConfiguration(Position = new int[] { 29, 5 })]
        public double DiametreAlesageChoisi { get; set; }
        [CellConfiguration(Position = new int[] { 30, 5 })]
        public double CalculSectionReelle { get; set; }
        [CellConfiguration(Position = new int[] { 31, 5 })]
        public double VerificationChargeArret { get; set; }

    }

	/// <summary>
	/// Aileron_static_perfo_TBS.xls
	/// Feuille section bloc hyd
	/// Calcul des pertes de charge dans le bloc hydraulique
	/// </summary>
	[BusinessClass(BaseUri = "http://xowl.org/sectionblochyd#", IsComplex = true, Position = "section bloc hyd")]
    public class SectionBlocHyd : Identifiable
    {
		
		/*
		Cartouche Paramètres internes (Unités SI)
		*/
    	[CellConfiguration(Position = new int[] { 16, 3 })]
        public double SkydrolDensityTFluideReference { get; set; }
        [CellConfiguration(Position = new int[] { 17, 3 })]
        public double PressureDropCoefficientUSI { get; set; }

		[CellConfiguration(Position = new int[] { 22, 3 })]
        public double DiametrePercagesActif { get; set; }
        [CellConfiguration(Position = new int[] { 23, 3 })]
        public double NombreRestrictionsActif { get; set; }

        [CellConfiguration(Position = new int[] { 26, 3 })]
        public double DiametrePercagesAmorti { get; set; }
        [CellConfiguration(Position = new int[] { 27, 3 })]
        public double NombreRestrictionsAmorti { get; set; }

		/*
		Cartouche Calcul préliminaire (Unités SI)
		*/
		[CellConfiguration(Position = new int[] { 33, 3 })]
        public double SectionEquivalenteBloc { get; set; }
        [CellConfiguration(Position = new int[] { 34, 3 })]
        public double DebitPointPerformance { get; set; }
        [CellConfiguration(Position = new int[] { 35, 3 })]
        public double PerteChargeBlocPointPerformance { get; set; }

    }

	/// <summary>
	/// Aileron_static_perfo_TBS.xls
	/// Feuille EHSV
	/// Calcul du débit servovalve
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/ehsv#", IsComplex = true, Position = "EHSV")]
    public class EHSV : Identifiable
    {

		/*
		Cartouche Paramètres internes (Unités SI)
		*/
		[CellConfiguration(Position = new int[] { 25, 3 })]
        public double AmortissementMaximalPerfos { get; set; }
		
		[CellConfiguration(Position = new int[] { 27, 3 })]
        public double PressionMoyenneBlocHydraulique { get; set; }

		/*
		Cartouche Effort d'amortissement (Unités SI)
		*/
    	[CellConfiguration(Position = new int[] { 36, 3 })]
        public double EffortAmortissementVitesseServocommandePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 37, 3 })]
        public double EffortAmortissementEffortAmortissementPoint1 { get; set; }
     	[CellConfiguration(Position = new int[] { 36, 4 })]
        public double EffortAmortissementVitesseServocommandePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 37, 4 })]
        public double EffortAmortissementEffortAmortissementPoint2 { get; set; }   	
		[CellConfiguration(Position = new int[] { 36, 5 })]
        public double EffortAmortissementVitesseServocommandePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 37, 5 })]
        public double EffortAmortissementEffortAmortissementPoint3 { get; set; }

		/*
		Cartouche Bilan des pertes de charge (Unités SI)
		*/
		//Point 1
		[CellConfiguration(Position = new int[] { 41, 3 })]
        public double BilanPertesChargeDebitUtilePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 42, 3 })]
        public double BilanPertesChargeDPFrottementsJointsSCactivePoint1 { get; set; }

        [CellConfiguration(Position = new int[] { 44, 3 })]
        public double BilanPertesChargeDPBlocHydrauliqueAmontPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 45, 3 })]
        public double BilanPertesChargeDPEffortAmortissementPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 46, 3 })]
        public double BilanPertesChargeDPEffortAeroPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 47, 3 })]
        public double BilanPertesChargeDPReturnValvePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 48, 3 })]
        public double BilanPertesChargePertesChargeTotalesPoint1 { get; set; }

		//Point 2
		[CellConfiguration(Position = new int[] { 41, 4 })]
        public double BilanPertesChargeDebitUtilePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 42, 4 })]
        public double BilanPertesChargeDPFrottementsJointsSCactivePoint2 { get; set; }

        [CellConfiguration(Position = new int[] { 44, 4 })]
        public double BilanPertesChargeDPBlocHydrauliqueAmontPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 45, 4 })]
        public double BilanPertesChargeDPEffortAmortissementPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 46, 4 })]
        public double BilanPertesChargeDPEffortAeroPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 47, 4 })]
        public double BilanPertesChargeDPReturnValvePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 48, 4 })]
        public double BilanPertesChargePertesChargeTotalesPoint2 { get; set; }

		//Point3
		[CellConfiguration(Position = new int[] { 41, 5 })]
        public double BilanPertesChargeDebitUtilePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 42, 5 })]
        public double BilanPertesChargeDPFrottementsJointsSCactivePoint3 { get; set; }

        [CellConfiguration(Position = new int[] { 44, 5 })]
        public double BilanPertesChargeDPBlocHydrauliqueAmontPoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 45, 5 })]
        public double BilanPertesChargeDPEffortAmortissementPoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 46, 5 })]
        public double BilanPertesChargeDPEffortAeroPoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 47, 5 })]
        public double BilanPertesChargeDPReturnValvePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 48, 5 })]
        public double BilanPertesChargePertesChargeTotalesPoint3 { get; set; }

		/*
		Cartouche DP disponible (Unités SI)
		*/
		[CellConfiguration(Position = new int[] { 54, 3 })]
        public double DeltaPDisponible { get; set; }

		/*
		Cartouche Débit servovalve (Unités SI)
		*/
		//Point1
		[CellConfiguration(Position = new int[] { 58, 3 })]
        public double DebitServovalveDebitUtileMiniREALTempPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 59, 3 })]
        public double DebitServovalvePerteChargeServovalvePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 60, 3 })]
        public double DebitServovalveSectionEuivalenteServovalvePoint1 { get; set; }
        
		[CellConfiguration(Position = new int[] { 62, 3 })]
        public double DebitServovalveDeltaPNominalPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 63, 3 })]
        public double DebitServovalveDebitMiniREALTempPoint1 { get; set; }

        [CellConfiguration(Position = new int[] { 65, 3 })]
        public double DebitServovalveDebitNominalTfluidePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 66, 3 })]
        public double DebitServovalveDebitNominalTrefPoint1 { get; set; }

		//Point2
		[CellConfiguration(Position = new int[] { 58, 4 })]
        public double DebitServovalveDebitUtileMiniREALTempPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 59, 4 })]
        public double DebitServovalvePerteChargeServovalvePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 60, 4 })]
        public double DebitServovalveSectionEuivalenteServovalvePoint2 { get; set; }
        
		[CellConfiguration(Position = new int[] { 62, 4 })]
        public double DebitServovalveDeltaPNominalPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 63, 4 })]
        public double DebitServovalveDebitMiniREALTempPoint2 { get; set; }

        [CellConfiguration(Position = new int[] { 65, 4 })]
        public double DebitServovalveDebitNominalTfluidePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 66, 4 })]
        public double DebitServovalveDebitNominalTrefPoint2 { get; set; }

		//Point3
        [CellConfiguration(Position = new int[] { 58, 5 })]
        public double DebitServovalveDebitUtileMiniREALTempPoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 59, 5 })]
        public double DebitServovalvePerteChargeServovalvePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 60, 5 })]
        public double DebitServovalveSectionEuivalenteServovalvePoint3 { get; set; }
        
		[CellConfiguration(Position = new int[] { 62, 5 })]
        public double DebitServovalveDeltaPNominalPoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 63, 5 })]
        public double DebitServovalveDebitMiniREALTempPoint3 { get; set; }

        [CellConfiguration(Position = new int[] { 65, 5 })]
        public double DebitServovalveDebitNominalTfluidePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 66, 5 })]
        public double DebitServovalveDebitNominalTrefPoint3 { get; set; }

		/*
		Cartouche Répartion des pertes de charge (Unités SI)
		*/
		//Point1
		[CellConfiguration(Position = new int[] { 71, 3 })]
        public double RepartionPertesChargeChargeAaerodynamiquePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 72, 3 })]
        public double RepartionPertesChargeServovalvePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 73, 3 })]
        public double RepartionPertesChargeBlocHydrauliquePoint1 { get; set; }

		//Point2
		[CellConfiguration(Position = new int[] { 71, 4 })]
        public double RepartionPertesChargeChargeAaerodynamiquePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 72, 4 })]
        public double RepartionPertesChargeServovalvePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 73, 4 })]
        public double RepartionPertesChargeBlocHydrauliquePoint2 { get; set; }

		//Point3
        [CellConfiguration(Position = new int[] { 71, 5 })]
        public double RepartionPertesChargeChargeAaerodynamiquePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 72, 5 })]
        public double RepartionPertesChargeServovalvePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 73, 5 })]
        public double RepartionPertesChargeBlocHydrauliquePoint3 { get; set; }
    }

	/// <summary>
	/// Aileron_static_perfo_TBS.xls
	/// Feuille Accumulateur
	/// Dimensionnement de l'accumulateur
	/// </summary>
	[BusinessClass(BaseUri = "http://xowl.org/accumulateur#", IsComplex = true, Position = "Accumulateur")]
    public class Accumulateur : Identifiable
    {
		/*
		Cartouche Paramètres internes (Unités SI)
		*/
		[CellConfiguration(Position = new int[] { 21, 3 })]
        public double LongueurPercagesBloc { get; set; }
        [CellConfiguration(Position = new int[] { 22, 3 })]
        public double CoefficientDilatationThermiqueFluide { get; set; }
		//Fuites dyn
        [CellConfiguration(Position = new int[] { 25, 1 })]
        public int FuitesDynCycles { get; set; }
        [CellConfiguration(Position = new int[] { 26, 1 })]
        public int FuitesDynGouttes { get; set; }
		
		[CellConfiguration(Position = new int[] { 25, 3 })]
        public double FuitesDynGouttesParPalier { get; set; }
        [CellConfiguration(Position = new int[] { 26, 3 })]
        public double FuitesDynMCube { get; set; }
        [CellConfiguration(Position = new int[] { 27, 3 })]
        public double FuitesDynPourcentageCourse { get; set; }
        [CellConfiguration(Position = new int[] { 28, 3 })]
        public double FuitesDynHz { get; set; }
		//Fuites statiques
		[CellConfiguration(Position = new int[] { 30, 1 })]
        public int FuitesStatiquesGouttes { get; set; }
        [CellConfiguration(Position = new int[] { 30, 3 })]
        public int FuitesStatiquesSecondes { get; set; }

		/*
		Cartouche Résultats (Unités SI) - Estimation des fuites externes et internes
		*/
		//Fuites dyn
        [CellConfiguration(Position = new int[] { 39, 3 })]
        public int ResFuitesDynNombreCycles { get; set; }
        [CellConfiguration(Position = new int[] { 40, 3 })]
        public int ResFuitesDynNombreGouttes { get; set; }
        [CellConfiguration(Position = new int[] { 41, 3 })]
        public int ResFuitesDynVolumeFuitesDynamiques { get; set; }
		//fuites statiques
        [CellConfiguration(Position = new int[] { 43, 3 })]
        public int ResFuitesStatiquesNombreGouttes { get; set; }
        [CellConfiguration(Position = new int[] { 44, 3 })]
        public int ResFuitesStatiquesVolumeFuitesStatiques { get; set; }
		//fuites totales
        [CellConfiguration(Position = new int[] { 45, 3 })]
        public int ResFuitesTotales { get; set; }

        [CellConfiguration(Position = new int[] { 47, 3 })]
        public int ResVolumeVerin { get; set; }
        [CellConfiguration(Position = new int[] { 48, 3 })]
        public int ResVolumeBlocHydraulique { get; set; }
        [CellConfiguration(Position = new int[] { 49, 3 })]
        public int ResVolumeCompensationVariationsVolume { get; set; }
        [CellConfiguration(Position = new int[] { 50, 3 })]
        public int ResVolumeAccumulateur { get; set; }

	}

	/// <summary>
	/// Aileron_static_perfo_TBS.xls
	/// Feuille Courbes effort vitesse
	/// Calcul des courbes effort / vitesse
	/// </summary>
	[BusinessClass(BaseUri = "http://xowl.org/courbeseffortvitesse#", IsComplex = true, Position = "Courbes effort vitesse")]
    public class CourbesEffortVitesse : Identifiable
    {
		/*
		Cartouche Paramètres internes (Unités SI)
		*/
    	[CellConfiguration(Position = new int[] { 24, 4 })]
        public double CoefficientAmortissementNominal { get; set; }
        [CellConfiguration(Position = new int[] { 27, 4 })]
        public double SectionEquivalenteServovalve { get; set; }

		/*
		Cartouche Résultats ( SC seule) (Unités SI)
		*/
		[CellConfiguration(Position = new int[] { 36, 4 })]
        public double ResultatsSCseuleSectionEquivalentBlocServovalveNominal { get; set; }

		//Pour le point de perfo
        [CellConfiguration(Position = new int[] { 40, 1 })]
        public double ResultatsSCseulePourPointPerfoVitessePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 40, 2 })]
        public double ResultatsSCseulePourPointPerfoEffortPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 41, 1 })]
        public double ResultatsSCseulePourPointPerfoVitessePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 41, 2 })]
        public double ResultatsSCseulePourPointPerfoEffortPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 42, 1 })]
        public double ResultatsSCseulePourPointPerfoVitessePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 42, 2 })]
        public double ResultatsSCseulePourPointPerfoEffortPoint3 { get; set; }

		//Pression nominale
        [CellConfiguration(Position = new int[] { 40, 3 })]
        public double ResultatsSCseulePressionNominaleVitessePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 40, 4 })]
        public double ResultatsSCseulePressionNominaleEffortPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 41, 3 })]
        public double ResultatsSCseulePressionNominaleVitessePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 41, 4 })]
        public double ResultatsSCseulePressionNominaleEffortPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 42, 3 })]
        public double ResultatsSCseulePressionNominaleVitessePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 42, 4 })]
        public double ResultatsSCseulePressionNominaleEffortPoint3 { get; set; }

		//Amortissement nominal
        [CellConfiguration(Position = new int[] { 40, 5 })]
        public double ResultatsSCseuleAmortissementNominalPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 41, 5 })]
        public double ResultatsSCseuleAmortissementNominalPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 42, 5 })]
        public double ResultatsSCseuleAmortissementNominalPoint3 { get; set; }
		
		/*
		Cartouche Débit EHSV sous 350 bars et ...°C (Unités SI)
		*/
		//Mini
		[CellConfiguration(Position = new int[] { 48, 4 })]
        public double ResultatsSectionEquivalentBlocServovalveMini { get; set; }

		[CellConfiguration(Position = new int[] { 52, 1 })]
        public double ResultatsMiniPourPointPerfoVitessePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 52, 2 })]
        public double ResultatsMiniPourPointPerfoEffortPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 53, 1 })]
        public double ResultatsMiniPourPointPerfoVitessePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 53, 2 })]
        public double ResultatsMiniPourPointPerfoEffortPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 54, 1 })]
        public double ResultatsMiniPourPointPerfoVitessePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 54, 2 })]
        public double ResultatsMiniPourPointPerfoEffortPoint3 { get; set; }

		[CellConfiguration(Position = new int[] { 52, 3 })]
        public double ResultatsMiniPressionNominaleVitessePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 52, 4 })]
        public double ResultatsMiniPressionNominaleEffortPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 53, 3 })]
        public double ResultatsMiniPressionNominaleVitessePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 53, 4 })]
        public double ResultatsMiniPressionNominaleEffortPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 54, 3 })]
        public double ResultatsMiniPressionNominaleVitessePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 54, 4 })]
        public double ResultatsMiniPressionNominaleEffortPoint3 { get; set; }

		[CellConfiguration(Position = new int[] { 52, 5 })]
        public double ResultatsMiniAmortissementMaxiPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 53, 5 })]
        public double ResultatsMiniAmortissementMaxiPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 54, 5 })]
        public double ResultatsMiniAmortissementMaxiPoint3 { get; set; }

        [CellConfiguration(Position = new int[] { 52, 8 })]
        public double ResultatsMiniDebitPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 53, 8 })]
        public double ResultatsMiniDebitPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 54, 8 })]
        public double ResultatsMiniDebitPoint3 { get; set; }

		//Nominal
		[CellConfiguration(Position = new int[] { 56, 4 })]
        public double ResultatsSectionEquivalentBlocServovalveNominal { get; set; }

		[CellConfiguration(Position = new int[] { 60, 1 })]
        public double ResultatsNominalPourPointPerfoVitessePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 60, 2 })]
        public double ResultatsNominalPourPointPerfoEffortPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 61, 1 })]
        public double ResultatsNominalPourPointPerfoVitessePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 61, 2 })]
        public double ResultatsNominalPourPointPerfoEffortPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 62, 1 })]
        public double ResultatsNominalPourPointPerfoVitessePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 62, 2 })]
        public double ResultatsNominalPourPointPerfoEffortPoint3 { get; set; }

		[CellConfiguration(Position = new int[] { 60, 3 })]
        public double ResultatsNominalPressionNominaleVitessePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 60, 4 })]
        public double ResultatsNominalPressionNominaleEffortPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 61, 3 })]
        public double ResultatsNominalPressionNominaleVitessePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 61, 4 })]
        public double ResultatsNominalPressionNominaleEffortPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 62, 3 })]
        public double ResultatsNominalPressionNominaleVitessePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 62, 4 })]
        public double ResultatsNominalPressionNominaleEffortPoint3 { get; set; }

		[CellConfiguration(Position = new int[] { 60, 5 })]
        public double ResultatsNominalAmortissementNominalPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 61, 5 })]
        public double ResultatsNominalAmortissementNominalPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 62, 5 })]
        public double ResultatsNominalAmortissementNominalPoint3 { get; set; }

        [CellConfiguration(Position = new int[] { 60, 8 })]
        public double ResultatsNominalDebitPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 61, 8 })]
        public double ResultatsNominalDebitPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 62, 8 })]
        public double ResultatsNominalDebitPoint3 { get; set; }

		//Maxi
		[CellConfiguration(Position = new int[] { 64, 4 })]
        public double ResultatsSectionEquivalentBlocServovalveMaxi { get; set; }

		[CellConfiguration(Position = new int[] { 68, 1 })]
        public double ResultatsMaxiPourPointPerfoVitessePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 68, 2 })]
        public double ResultatsMaxiPourPointPerfoEffortPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 69, 1 })]
        public double ResultatsMaxiPourPointPerfoVitessePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 69, 2 })]
        public double ResultatsMaxiPourPointPerfoEffortPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 70, 1 })]
        public double ResultatsMaxiPourPointPerfoVitessePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 70, 2 })]
        public double ResultatsMaxiPourPointPerfoEffortPoint3 { get; set; }

		[CellConfiguration(Position = new int[] { 68, 3 })]
        public double ResultatsMaxiPressionNominaleVitessePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 68, 4 })]
        public double ResultatsMaxiPressionNominaleEffortPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 69, 3 })]
        public double ResultatsMaxiPressionNominaleVitessePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 69, 4 })]
        public double ResultatsMaxiPressionNominaleEffortPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 70, 3 })]
        public double ResultatsMaxiPressionNominaleVitessePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 70, 4 })]
        public double ResultatsMaxiPressionNominaleEffortPoint3 { get; set; }

		[CellConfiguration(Position = new int[] { 68, 5 })]
        public double ResultatsMaxiAmortissementMiniPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 69, 5 })]
        public double ResultatsMaxiAmortissementMiniPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 70, 5 })]
        public double ResultatsMaxiAmortissementMiniPoint3 { get; set; }

        [CellConfiguration(Position = new int[] { 68, 8 })]
        public double ResultatsMaxiDebitPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 69, 8 })]
        public double ResultatsMaxiDebitPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 70, 8 })]
        public double ResultatsMaxiDebitPoint3 { get; set; }

		/*
		Cartouche Vitesse pour choc en butée (Unités SI)
		*/
		[CellConfiguration(Position = new int[] { 75, 4 })]
        public double VitesseChocEnButeeSectionEquivalentBlocServovalve { get; set; }
        [CellConfiguration(Position = new int[] { 76, 4 })]
        public double VitesseChocEnButeeDeltaPMmax { get; set; }
        [CellConfiguration(Position = new int[] { 77, 4 })]
        public double VitesseChocEnButeeVitesseMaxTmaxQmaxEHSV { get; set; }

		/*
		Cartouche Effort/Vitesse pour Servovalve Maxi (@ +95°C) et Kamo mini
		*/
		[CellConfiguration(Position = new int[] { 81, 3 })]
        public double EffortVitesseServovalveMaxiKamoMiniErreur { get; set; }
        [CellConfiguration(Position = new int[] { 82, 3 })]
        public double EffortVitesseServovalveMaxiKamoMiniVitesse { get; set; }
        [CellConfiguration(Position = new int[] { 83, 3 })]
        public double EffortVitesseServovalveMaxiKamoMiniEffort { get; set; }

    }


	/// <summary>
	/// Spec EHSA_v1.xslx
	/// Feuille Spec
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/specehsa#", IsComplex = true, Position = "Spec")]
    public class SpecEHSA : Identifiable
    {
		/*
		Section 1 DONNEES GENERALES
		*/
    	[CellConfiguration(Position = new int[] { 4, 4 })]
        public string AircraftType { get; set; }
        [CellConfiguration(Position = new int[] { 5, 4 })]
        public string System { get; set; }
		[CellConfiguration(Position = new int[] { 6, 4 })]
        public string TypeDeServocommande { get; set; }
		[CellConfiguration(Position = new int[] { 7, 4 })]
        public string NombreActionneurParSurface { get; set; }
		
		/*
		Section 2 SPACE ENVELOP and WEIGHT
		*/
    	[CellConfiguration(Position = new int[] { 10, 4 })] //Format "(Length, Width, Height)" en (mm mm mm)
        public string SpaceEnvelop { get; set; }
        [CellConfiguration(Position = new int[] { 11, 4 })]
        public double DistanceBetweenAttachments { get; set; }
		[CellConfiguration(Position = new int[] { 12, 4 })]
        public double MaximumWeight { get; set; }
		[CellConfiguration(Position = new int[] { 13, 4 })]
        public double AngleBraquageGouverneExtension { get; set; }
		[CellConfiguration(Position = new int[] { 14, 4 })]
        public double AngleBraquageGouverneRetractionNegatif { get; set; }
		[CellConfiguration(Position = new int[] { 15, 4 })]
        public double ExtensionStroke { get; set; }
		[CellConfiguration(Position = new int[] { 16, 4 })]
        public double RetractionStroke { get; set; }
 
		/*
		Section 3 FUNCTIONAL REQUIREMENTS
		*/
    	[CellConfiguration(Position = new int[] { 19, 4 })] 
        public string ActuatorModes { get; set; }
        [CellConfiguration(Position = new int[] { 20, 4 })]
        public string ControlInterface { get; set; }
		[CellConfiguration(Position = new int[] { 21, 4 })]
        public string ControlSignalMagnitude { get; set; } //Format " +/- 8" en (mA) ?
		
		/*
		Section 4 PERFORMANCE
		*/
    	/*
		Ancienne feuille
		[CellConfiguration(Position = new int[] { 15, 4 })] 
        public double StallLoad { get; set; } //int suffisant?
        [CellConfiguration(Position = new int[] { 16, 4 })]
        public double LimitLoadNoDeformation { get; set; } //int suffisant?
		[CellConfiguration(Position = new int[] { 17, 4 })]
        public double UltimateLoadNoRupture { get; set; } //int suffisant?
		[CellConfiguration(Position = new int[] { 18, 4 })]
        public double MaximumRateWithoutLoad { get; set; } //int suffisant?
		[CellConfiguration(Position = new int[] { 19, 4 })]
        public double MaximumRateWithHalfStallLoad { get; set; } //int suffisant?
		//Info : damping load F = F0 + KV²
		[CellConfiguration(Position = new int[] { 21, 4 })] 
        public double MinimumDampingF0 { get; set; } //int suffisant?
        [CellConfiguration(Position = new int[] { 22, 4 })]
        public double MaximumDampingF0 { get; set; } //int suffisant?
		[CellConfiguration(Position = new int[] { 23, 4 })]
        public double MinimumDampingK { get; set; } //int suffisant?
		[CellConfiguration(Position = new int[] { 24, 4 })]
        public double MaximumDampingK { get; set; } //int suffisant?
		[CellConfiguration(Position = new int[] { 25, 4 })]
        public string FunctionnalStroke { get; set; } //Format [-40 ; 40] en mm mm
		[CellConfiguration(Position = new int[] { 26, 4 })] 
        public double StabilityGainMargin { get; set; } //int suffisant?
        [CellConfiguration(Position = new int[] { 27, 4 })]
        public double StabilityPhaseMargin { get; set; } //int suffisant?
		[CellConfiguration(Position = new int[] { 28, 4 })]
        public double MechanicalStiffness { get; set; } //int suffisant?
		[CellConfiguration(Position = new int[] { 29, 4 })]
        public double FrequencyResponse { get; set; } //int suffisant?
		[CellConfiguration(Position = new int[] { 30, 4 })]
        public double MaximumRunUpTime { get; set; } //int suffisant?*/
		
		[CellConfiguration(Position = new int[] { 23, 4 })] 
        public double SupplyPressure { get; set; }
		[CellConfiguration(Position = new int[] { 24, 4 })] 
        public double ReturnPressure { get; set; }
		[CellConfiguration(Position = new int[] { 25, 4 })] 
        public double SupplyProofPressure { get; set; }
		[CellConfiguration(Position = new int[] { 26, 4 })] 
        public double ReturnProofPressure { get; set; }
		[CellConfiguration(Position = new int[] { 27, 4 })] 
        public double LimitLoad { get; set; }
		[CellConfiguration(Position = new int[] { 28, 4 })] 
        public double StallLoadExtension { get; set; }
		[CellConfiguration(Position = new int[] { 29, 4 })] 
        public double StallLoadRetraction { get; set; }
		[CellConfiguration(Position = new int[] { 30, 4 })] 
        public double DampingCoefficient { get; set; }
		[CellConfiguration(Position = new int[] { 31, 4 })] 
        public double MaxPowerPointLoad { get; set; }
		[CellConfiguration(Position = new int[] { 32, 4 })] 
        public double MaxPowerPointSpeed { get; set; }
		[CellConfiguration(Position = new int[] { 33, 4 })] 
        public double MinFluidTemperature { get; set; }
		[CellConfiguration(Position = new int[] { 34, 4 })] 
        public double MaxFluidTemperature { get; set; }
		
		/*
		Section 5 DUTY CYCLE
		*/
    	[CellConfiguration(Position = new int[] { 38, 4 })] 
        public double UsefulLife { get; set; } //int suffisant?
        [CellConfiguration(Position = new int[] { 39, 4 })]
        public string EquivalentPermanentCycle { get; set; } //Format sine 1Hz +/- 2mm
		[CellConfiguration(Position = new int[] { 40, 4 })]
        public double PermanentLoad { get; set; } //int suffisant?

	}
		
	/// <summary>
	/// Spec EHSA_v1.xslx
	/// Feuille Actuator Key characteristics
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/specehsa/actuatorkeycharacteristics#", IsComplex = true, Position = "Actuator Key characteristics")]
    public class ActuatorKeyCharacteristics : Identifiable
    {
		/*
		Cartouche Identification
		*/
		[CellConfiguration(Position = new int[] { 7, 2 })] //Expected column B
        public string Programme { get; set; }
		[CellConfiguration(Position = new int[] { 8, 2 })] 
        public string Author { get; set; }
		[CellConfiguration(Position = new int[] { 9, 2 })] 
        public string Date { get; set; }
		[CellConfiguration(Position = new int[] { 10, 2 })] 
        public string Version { get; set; }
		/*
		Cartouche Actuator Key characteristics Aileron
		*/
		//Power lane
		[CellConfiguration(Position = new int[] { 17, 2 })] 
        public string ActuatorType { get; set; } //(balanced/unbalanced sections)
		[CellConfiguration(Position = new int[] { 18, 2 })] 
        public double RodDiameter { get; set; }
		[CellConfiguration(Position = new int[] { 19, 2 })] 
        public double PistonDiameter { get; set; }
 
		//Attachments
		[CellConfiguration(Position = new int[] { 22, 2 })] 
        public string TypeRodEnd { get; set; } //(male/femelle)
		/*[CellConfiguration(Position = new int[] { 22, 2 })] 
        public string StructureBearingType { get; set; } //(auto lub, roller)
		[CellConfiguration(Position = new int[] { 23, 2 })] 
        public string SurfaceBearingType { get; set; } //(auto lub, roller)*/
		[CellConfiguration(Position = new int[] { 23, 2 })] 
        public double PinToPinDistance { get; set; }
 
		//Hydraulic block
		[CellConfiguration(Position = new int[] { 26, 2 })] 
        public double SelectedTubeDiameter { get; set; }
 
		//Servovalve
		[CellConfiguration(Position = new int[] { 29, 2 })] 
        public double EHSVMinFlow { get; set; }

		//Acumulator
		[CellConfiguration(Position = new int[] { 32, 2 })] 
        public double MinimumAcumulatorPressure { get; set; }
		[CellConfiguration(Position = new int[] { 33, 2 })] 
        public double MinimumAccumulatorVolume { get; set; }

		/*
		Cartouche Actuator Key characteristics Tool1 output
		*/
		//Power lane
		[CellConfiguration(Position = new int[] { 17, 3 })] 
        public string ActuatorTypeTool1 { get; set; } //(balanced/unbalanced sections)
		[CellConfiguration(Position = new int[] { 18, 3 })] 
        public double RodDiameterTool1 { get; set; }
		[CellConfiguration(Position = new int[] { 19, 3 })] 
        public double PistonDiameterTool1 { get; set; }
 
		//Attachments
		[CellConfiguration(Position = new int[] { 22, 3 })] 
        public string TypeRodEndTool1 { get; set; } //(male/femelle)
		/*[CellConfiguration(Position = new int[] { 22, 3 })] 
        public string StructureBearingTypeTool1 { get; set; } //(auto lub, roller)
		[CellConfiguration(Position = new int[] { 23, 3 })] 
        public string SurfaceBearingTypeTool1 { get; set; } //(auto lub, roller)*/
		[CellConfiguration(Position = new int[] { 23, 3 })] 
        public double PinToPinDistanceTool1 { get; set; }
 
		//Hydraulic block
		[CellConfiguration(Position = new int[] { 26, 3 })] 
        public double SelectedTubeDiameterTool1 { get; set; }
 
		//Servovalve
		[CellConfiguration(Position = new int[] { 29, 3 })] 
        public double EHSVMinFlowTool1 { get; set; }

		//Acumulator
		[CellConfiguration(Position = new int[] { 32, 3 })] 
        public double MinimumAcumulatorPressureTool1 { get; set; }
		[CellConfiguration(Position = new int[] { 33, 3 })] 
        public double MinimumAccumulatorVolumeTool1 { get; set; }
		
		/*
		Cartouche Actuator Key characteristics Tool2 output
		*/
		//Power lane
		[CellConfiguration(Position = new int[] { 17, 4 })] 
        public string ActuatorTypeTool2 { get; set; } //(balanced/unbalanced sections)
		[CellConfiguration(Position = new int[] { 18, 4 })] 
        public double RodDiameterTool2 { get; set; }
		[CellConfiguration(Position = new int[] { 19, 4 })] 
        public double PistonDiameterTool2 { get; set; }
 
		//Attachments
		[CellConfiguration(Position = new int[] { 22, 4 })] 
        public string TypeRodEndTool2 { get; set; } //(male/femelle)
		/*[CellConfiguration(Position = new int[] { 22, 4 })] 
        public string StructureBearingTypeTool2 { get; set; } //(auto lub, roller)
		[CellConfiguration(Position = new int[] { 23, 4 })] 
        public string SurfaceBearingTypeTool2 { get; set; } //(auto lub, roller)*/
		[CellConfiguration(Position = new int[] { 23, 4 })] 
        public double PinToPinDistanceTool2 { get; set; }
 
		//Hydraulic block
		[CellConfiguration(Position = new int[] { 26, 4 })] 
        public double SelectedTubeDiameterTool2 { get; set; }
 
		//Servovalve
		[CellConfiguration(Position = new int[] { 29, 4 })] 
        public double EHSVMinFlowTool2 { get; set; }

		//Acumulator
		[CellConfiguration(Position = new int[] { 32, 4 })] 
        public double MinimumAcumulatorPressureTool2 { get; set; }
		[CellConfiguration(Position = new int[] { 33, 4 })] 
        public double MinimumAccumulatorVolumeTool2 { get; set; }
	}
	
	/// <summary>
	/// Spec EHSA_v1.xslx
	/// Feuille PFCA Spec
	/// </summary>
	/// FIXME check types
    [BusinessClass(BaseUri = "http://xowl.org/specehsa/pfcaspec#", IsComplex = true, Position = "PFCA Spec")]
    public class PFCASpec : Identifiable
    {
		/*
		Section 1 Functions
		*/
		
		//Values Aileron IB
		[CellConfiguration(Position = new int[] { 6, 4 })] 
        public double FunctionActiveModeValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 7, 4 })] 
        public double FunctionDampedModeValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 8, 4 })] 
        public double FunctionBlockedModeValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 9, 4 })] 
        public double FunctionMaintenanceModeValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 10, 4 })] 
        public double FunctionAntiExtensionSpoilerValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 11, 4 })] 
        public double FunctionSurfaceEndStopValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 12, 4 })] 
        public double FunctionLoadOrPressureSensingValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 13, 4 })] 
        public double FunctionDroopFunctionValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 14, 4 })] 
        public double FunctionREUModesAndFunctionsValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 15, 4 })] 
        public double FunctionMotorDriveElectronicModesAndFunctionsValueAileronIB { get; set; }
		
		//Values Aileron OB
		[CellConfiguration(Position = new int[] { 6, 5 })] 
        public double FunctionActiveModeValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 7, 5 })] 
        public double FunctionDampedModeValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 8, 5 })] 
        public double FunctionBlockedModeValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 9, 5 })] 
        public double FunctionMaintenanceModeValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 10, 5 })] 
        public double FunctionAntiExtensionSpoilerValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 11, 5 })] 
        public double FunctionSurfaceEndStopValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 12, 5 })] 
        public double FunctionLoadOrPressureSensingValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 13, 5 })] 
        public double FunctionDroopFunctionValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 14, 5 })] 
        public double FunctionREUModesAndFunctionsValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 15, 5 })] 
        public double FunctionMotorDriveElectronicModesAndFunctionsValueAileronOB { get; set; }
		
		//Values Elevator
		[CellConfiguration(Position = new int[] { 6, 6 })] 
        public double FunctionActiveModeValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 7, 6 })] 
        public double FunctionDampedModeValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 8, 6 })] 
        public double FunctionBlockedModeValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 9, 6 })] 
        public double FunctionMaintenanceModeValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 10, 6 })] 
        public double FunctionAntiExtensionSpoilerValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 11, 6 })] 
        public double FunctionSurfaceEndStopValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 12, 6 })] 
        public double FunctionLoadOrPressureSensingValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 13, 6 })] 
        public double FunctionDroopFunctionValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 14, 6 })] 
        public double FunctionREUModesAndFunctionsValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 15, 6 })] 
        public double FunctionMotorDriveElectronicModesAndFunctionsValueElevator { get; set; }
		
		//Values Rudder
		[CellConfiguration(Position = new int[] { 6, 7 })] 
        public double FunctionActiveModeValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 7, 7 })] 
        public double FunctionDampedModeValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 8, 7 })] 
        public double FunctionBlockedModeValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 9, 7 })] 
        public double FunctionMaintenanceModeValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 10, 7 })] 
        public double FunctionAntiExtensionSpoilerValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 11, 7 })] 
        public double FunctionSurfaceEndStopValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 12, 7 })] 
        public double FunctionLoadOrPressureSensingValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 13, 7 })] 
        public double FunctionDroopFunctionValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 14, 7 })] 
        public double FunctionREUModesAndFunctionsValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 15, 7 })] 
        public double FunctionMotorDriveElectronicModesAndFunctionsValueRudder { get; set; }
		
		//Values Spoiler
		[CellConfiguration(Position = new int[] { 6, 8 })] 
        public double FunctionActiveModeValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 7, 8 })] 
        public double FunctionDampedModeValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 8, 8 })] 
        public double FunctionBlockedModeValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 9, 8 })] 
        public double FunctionMaintenanceModeValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 10, 8 })] 
        public double FunctionAntiExtensionSpoilerValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 11, 8 })] 
        public double FunctionSurfaceEndStopValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 12, 8 })] 
        public double FunctionLoadOrPressureSensingValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 13, 8 })] 
        public double FunctionDroopFunctionValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 14, 8 })] 
        public double FunctionREUModesAndFunctionsValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 15, 8 })] 
        public double FunctionMotorDriveElectronicModesAndFunctionsValueSpoiler { get; set; }
		
		//Units
		[CellConfiguration(Position = new int[] { 6, 9 })] 
        public string FunctionActiveModeUnit { get; set; }
		[CellConfiguration(Position = new int[] { 7, 9 })] 
        public string FunctionDampedModeUnit { get; set; }
		[CellConfiguration(Position = new int[] { 8, 9 })] 
        public string FunctionBlockedModeUnit { get; set; }
		[CellConfiguration(Position = new int[] { 9, 9 })] 
        public string FunctionMaintenanceModeUnit { get; set; }
		[CellConfiguration(Position = new int[] { 10, 9 })] 
        public string FunctionAntiExtensionSpoilerUnit { get; set; }
		[CellConfiguration(Position = new int[] { 11, 9 })] 
        public string FunctionSurfaceEndStopUnit { get; set; }
		[CellConfiguration(Position = new int[] { 12, 9 })] 
        public string FunctionLoadOrPressureSensingUnit { get; set; }
		[CellConfiguration(Position = new int[] { 13, 9 })] 
        public string FunctionDroopFunctionUnit { get; set; }
		[CellConfiguration(Position = new int[] { 14, 9 })] 
        public string FunctionREUModesAndFunctionsUnit { get; set; }
		[CellConfiguration(Position = new int[] { 15, 9 })] 
        public string FunctionMotorDriveElectronicModesAndFunctionsUnit { get; set; }
		
		//Comments
		[CellConfiguration(Position = new int[] { 6, 10 })] 
        public string FunctionActiveModeComments { get; set; }
		[CellConfiguration(Position = new int[] { 7, 10 })] 
        public string FunctionDampedModeComments { get; set; }
		[CellConfiguration(Position = new int[] { 8, 10 })] 
        public string FunctionBlockedModeComments { get; set; }
		[CellConfiguration(Position = new int[] { 9, 10 })] 
        public string FunctionMaintenanceModeComments { get; set; }
		[CellConfiguration(Position = new int[] { 10, 10 })] 
        public string FunctionAntiExtensionSpoilerComments { get; set; }
		[CellConfiguration(Position = new int[] { 11, 10 })] 
        public string FunctionSurfaceEndStopComments { get; set; }
		[CellConfiguration(Position = new int[] { 12, 10 })] 
        public string FunctionLoadOrPressureSensingComments { get; set; }
		[CellConfiguration(Position = new int[] { 13, 10 })] 
        public string FunctionDroopFunctionComments { get; set; }
		[CellConfiguration(Position = new int[] { 14, 10 })] 
        public string FunctionREUModesAndFunctionsComments { get; set; }
		[CellConfiguration(Position = new int[] { 15, 10 })] 
        public string FunctionMotorDriveElectronicModesAndFunctionsComments { get; set; }
		
		//Status
		[CellConfiguration(Position = new int[] { 6, 11 })] 
        public string FunctionActiveModeStatus { get; set; }
		[CellConfiguration(Position = new int[] { 7, 11 })] 
        public string FunctionDampedModeStatus { get; set; }
		[CellConfiguration(Position = new int[] { 8, 11 })] 
        public string FunctionBlockedModeStatus { get; set; }
		[CellConfiguration(Position = new int[] { 9, 11 })] 
        public string FunctionMaintenanceModeStatus { get; set; }
		[CellConfiguration(Position = new int[] { 10, 11 })] 
        public string FunctionAntiExtensionSpoilerStatus { get; set; }
		[CellConfiguration(Position = new int[] { 11, 11 })] 
        public string FunctionSurfaceEndStopStatus { get; set; }
		[CellConfiguration(Position = new int[] { 12, 11 })] 
        public string FunctionLoadOrPressureSensingStatus { get; set; }
		[CellConfiguration(Position = new int[] { 13, 11 })] 
        public string FunctionDroopFunctionStatus { get; set; }
		[CellConfiguration(Position = new int[] { 14, 11 })] 
        public string FunctionREUModesAndFunctionsStatus { get; set; }
		[CellConfiguration(Position = new int[] { 15, 11 })] 
        public string FunctionMotorDriveElectronicModesAndFunctionsStatus { get; set; }
		
		/*
		Section 2 Installation
		*/
		
		//Values Aileron IB
		[CellConfiguration(Position = new int[] { 16, 4 })] 
        public string InstallationConfigurationValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 17, 4 })] 
        public double InstallationEnvelopeValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 18, 4 })] 
        public double InstallationStrokeValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 19, 4 })] 
        public double InstallationAttachmentPointsCoordinatesValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 20, 4 })] 
        public string InstallationTypeAttachmentsValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 21, 4 })] 
        public string InstallationElectricalConnectionDefinitionValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 22, 4 })] 
        public string InstallationHydraulicInterfaceDefinitionValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 23, 4 })] 
        public double InstallationSurfaceInertiaValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 24, 4 })] 
        public double InstallationAttachmentStiffnessValueAileronIB { get; set; }
		
		//Values Aileron OB
		[CellConfiguration(Position = new int[] { 16, 5 })] 
        public string InstallationConfigurationValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 17, 5 })] 
        public double InstallationEnvelopeValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 18, 5 })] 
        public double InstallationStrokeValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 19, 5 })] 
        public double InstallationAttachmentPointsCoordinatesValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 20, 5 })] 
        public string InstallationTypeAttachmentsValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 21, 5 })] 
        public string InstallationElectricalConnectionDefinitionValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 22, 5 })] 
        public string InstallationHydraulicInterfaceDefinitionValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 23, 5 })] 
        public double InstallationSurfaceInertiaValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 24, 5 })] 
        public double InstallationAttachmentStiffnessValueAileronOB { get; set; }
		
		//Values Elevator
		[CellConfiguration(Position = new int[] { 16, 6 })] 
        public string InstallationConfigurationValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 17, 6 })] 
        public double InstallationEnvelopeValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 18, 6 })] 
        public double InstallationStrokeValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 19, 6 })] 
        public double InstallationAttachmentPointsCoordinatesValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 20, 6 })] 
        public string InstallationTypeAttachmentsValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 21, 6 })] 
        public string InstallationElectricalConnectionDefinitionValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 22, 6 })] 
        public string InstallationHydraulicInterfaceDefinitionValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 23, 6 })] 
        public double InstallationSurfaceInertiaValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 24, 6 })] 
        public double InstallationAttachmentStiffnessValueElevator { get; set; }
		
		//Values Rudder
		[CellConfiguration(Position = new int[] { 16, 7 })] 
        public string InstallationConfigurationValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 17, 7 })] 
        public double InstallationEnvelopeValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 18, 7 })] 
        public double InstallationStrokeValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 19, 7 })] 
        public double InstallationAttachmentPointsCoordinatesValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 20, 7 })] 
        public string InstallationTypeAttachmentsValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 21, 7 })] 
        public string InstallationElectricalConnectionDefinitionValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 22, 7 })] 
        public string InstallationHydraulicInterfaceDefinitionValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 23, 7 })] 
        public double InstallationSurfaceInertiaValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 24, 7 })] 
        public double InstallationAttachmentStiffnessValueRudder { get; set; }
		
		//Values Spoiler
		[CellConfiguration(Position = new int[] { 16, 8 })] 
        public string InstallationConfigurationValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 17, 8 })] 
        public double InstallationEnvelopeValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 18, 8 })] 
        public double InstallationStrokeValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 19, 8 })] 
        public double InstallationAttachmentPointsCoordinatesValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 20, 8 })] 
        public string InstallationTypeAttachmentsValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 21, 8 })] 
        public string InstallationElectricalConnectionDefinitionValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 22, 8 })] 
        public string InstallationHydraulicInterfaceDefinitionValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 23, 8 })] 
        public double InstallationSurfaceInertiaValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 24, 8 })] 
        public double InstallationAttachmentStiffnessValueSpoiler { get; set; }
		
		//Units
		[CellConfiguration(Position = new int[] { 16, 9 })] 
        public string InstallationConfigurationUnit { get; set; }
		[CellConfiguration(Position = new int[] { 17, 9 })] 
        public string InstallationEnvelopeUnit { get; set; }
		[CellConfiguration(Position = new int[] { 18, 9 })] 
        public string InstallationStrokeUnit { get; set; }
		[CellConfiguration(Position = new int[] { 19, 9 })] 
        public string InstallationAttachmentPointsCoordinatesUnit { get; set; }
		[CellConfiguration(Position = new int[] { 20, 9 })] 
        public string InstallationTypeAttachmentsUnit { get; set; }
		[CellConfiguration(Position = new int[] { 21, 9 })] 
        public string InstallationElectricalConnectionDefinitionUnit { get; set; }
		[CellConfiguration(Position = new int[] { 22, 9 })] 
        public string InstallationHydraulicInterfaceDefinitionUnit { get; set; }
		[CellConfiguration(Position = new int[] { 23, 9 })] 
        public string InstallationSurfaceInertiaUnit { get; set; }
		[CellConfiguration(Position = new int[] { 24, 9 })] 
        public string InstallationAttachmentStiffnessUnit { get; set; }
		
		//Comments
		[CellConfiguration(Position = new int[] { 16, 10 })] 
        public string InstallationConfigurationComments { get; set; }
		[CellConfiguration(Position = new int[] { 17, 10 })] 
        public string InstallationEnvelopeComments { get; set; }
		[CellConfiguration(Position = new int[] { 18, 10 })] 
        public string InstallationStrokeComments { get; set; }
		[CellConfiguration(Position = new int[] { 19, 10 })] 
        public string InstallationAttachmentPointsCoordinatesComments { get; set; }
		[CellConfiguration(Position = new int[] { 20, 10 })] 
        public string InstallationTypeAttachmentsComments { get; set; }
		[CellConfiguration(Position = new int[] { 21, 10 })] 
        public string InstallationElectricalConnectionDefinitionComments { get; set; }
		[CellConfiguration(Position = new int[] { 22, 10 })] 
        public string InstallationHydraulicInterfaceDefinitionComments { get; set; }
		[CellConfiguration(Position = new int[] { 23, 10 })] 
        public string InstallationSurfaceInertiaComments { get; set; }
		[CellConfiguration(Position = new int[] { 24, 10 })] 
        public string InstallationAttachmentStiffnessComments { get; set; }
		
		//Status
		[CellConfiguration(Position = new int[] { 16, 11 })] 
        public string InstallationConfigurationStatus { get; set; }
		[CellConfiguration(Position = new int[] { 17, 11 })] 
        public string InstallationEnvelopeStatus { get; set; }
		[CellConfiguration(Position = new int[] { 18, 11 })] 
        public string InstallationStrokeStatus { get; set; }
		[CellConfiguration(Position = new int[] { 19, 11 })] 
        public string InstallationAttachmentPointsCoordinatesStatus { get; set; }
		[CellConfiguration(Position = new int[] { 20, 11 })] 
        public string InstallationTypeAttachmentsStatus { get; set; }
		[CellConfiguration(Position = new int[] { 21, 11 })] 
        public string InstallationElectricalConnectionDefinitionStatus { get; set; }
		[CellConfiguration(Position = new int[] { 22, 11 })] 
        public string InstallationHydraulicInterfaceDefinitionStatus { get; set; }
		[CellConfiguration(Position = new int[] { 23, 11 })] 
        public string InstallationSurfaceInertiaStatus { get; set; }
		[CellConfiguration(Position = new int[] { 24, 11 })] 
        public string InstallationAttachmentStiffnessStatus { get; set; }
		
		/*
		Section 3 Performances
		*/
		
		//Values Aileron IB
		[CellConfiguration(Position = new int[] { 25, 4 })] 
        public double PerformancesLimitLoadValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 26, 4 })] 
        public double PerformancesMaximumOperatingLoad100ValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 27, 4 })] 
        public double PerformancesMaximumOperatingLoad70ValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 28, 4 })] 
        public double PerformancesLoadVsRateValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 29, 4 })] 
        public double PerformancesDampingCoefficientValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 30, 4 })] 
        public double PerformancesLoadMaintainedContinuouslyValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 31, 4 })] 
        public double PerformancesLoadMaintainedMomentarilyValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 32, 4 })] 
        public double PerformancesBacklashValueAileronIB { get; set; }
		
		//Values Aileron OB
		[CellConfiguration(Position = new int[] { 25, 5 })] 
        public double PerformancesLimitLoadValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 26, 5 })] 
        public double PerformancesMaximumOperatingLoad100ValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 27, 5 })] 
        public double PerformancesMaximumOperatingLoad70ValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 28, 5 })] 
        public double PerformancesLoadVsRateValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 29, 5 })] 
        public double PerformancesDampingCoefficientValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 30, 5 })] 
        public double PerformancesLoadMaintainedContinuouslyValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 31, 5 })] 
        public double PerformancesLoadMaintainedMomentarilyValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 32, 5 })] 
        public double PerformancesBacklashValueAileronOB { get; set; }
		
		//Values Elevator
		[CellConfiguration(Position = new int[] { 25, 6 })] 
        public double PerformancesLimitLoadValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 26, 6 })] 
        public double PerformancesMaximumOperatingLoad100ValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 27, 6 })] 
        public double PerformancesMaximumOperatingLoad70ValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 28, 6 })] 
        public double PerformancesLoadVsRateValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 29, 6 })] 
        public double PerformancesDampingCoefficientValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 30, 6 })] 
        public double PerformancesLoadMaintainedContinuouslyValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 31, 6 })] 
        public double PerformancesLoadMaintainedMomentarilyValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 32, 6 })] 
        public double PerformancesBacklashValueElevator { get; set; }
	
		//Values Rudder
		[CellConfiguration(Position = new int[] { 25, 7 })] 
        public double PerformancesLimitLoadValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 26, 7 })] 
        public double PerformancesMaximumOperatingLoad100ValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 27, 7 })] 
        public double PerformancesMaximumOperatingLoad70ValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 28, 7 })] 
        public double PerformancesLoadVsRateValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 29, 7 })] 
        public double PerformancesDampingCoefficientValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 30, 7 })] 
        public double PerformancesLoadMaintainedContinuouslyValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 31, 7 })] 
        public double PerformancesLoadMaintainedMomentarilyValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 32, 7 })] 
        public double PerformancesBacklashValueRudder { get; set; }
		
		//Values Spoiler
		[CellConfiguration(Position = new int[] { 25, 8 })] 
        public double PerformancesLimitLoadValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 26, 8 })] 
        public double PerformancesMaximumOperatingLoad100ValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 27, 8 })] 
        public double PerformancesMaximumOperatingLoad70ValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 28, 8 })] 
        public double PerformancesLoadVsRateValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 29, 8 })] 
        public double PerformancesDampingCoefficientValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 30, 8 })] 
        public double PerformancesLoadMaintainedContinuouslyValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 31, 8 })] 
        public double PerformancesLoadMaintainedMomentarilyValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 32, 8 })] 
        public double PerformancesBacklashValueSpoiler { get; set; }
		
		//Units
		[CellConfiguration(Position = new int[] { 25, 9 })] 
        public string PerformancesLimitLoadUnit { get; set; }
		[CellConfiguration(Position = new int[] { 26, 9 })] 
        public string PerformancesMaximumOperatingLoad100Unit { get; set; }
		[CellConfiguration(Position = new int[] { 27, 9 })] 
        public string PerformancesMaximumOperatingLoad70Unit { get; set; }
		[CellConfiguration(Position = new int[] { 28, 9 })] 
        public string PerformancesLoadVsRateUnit { get; set; }
		[CellConfiguration(Position = new int[] { 29, 9 })] 
        public string PerformancesDampingCoefficientUnit { get; set; }
		[CellConfiguration(Position = new int[] { 30, 9 })] 
        public string PerformancesLoadMaintainedContinuouslyUnit { get; set; }
		[CellConfiguration(Position = new int[] { 31, 9 })] 
        public string PerformancesLoadMaintainedMomentarilyUnit { get; set; }
		[CellConfiguration(Position = new int[] { 32, 9 })] 
        public string PerformancesBacklashUnit { get; set; }
		
		//Comments
		[CellConfiguration(Position = new int[] { 25, 10 })] 
        public string PerformancesLimitLoadComments { get; set; }
		[CellConfiguration(Position = new int[] { 26, 10 })] 
        public string PerformancesMaximumOperatingLoad100Comments { get; set; }
		[CellConfiguration(Position = new int[] { 27, 10 })] 
        public string PerformancesMaximumOperatingLoad70Comments { get; set; }
		[CellConfiguration(Position = new int[] { 28, 10 })] 
        public string PerformancesLoadVsRateComments { get; set; }
		[CellConfiguration(Position = new int[] { 29, 10 })] 
        public string PerformancesDampingCoefficientComments { get; set; }
		[CellConfiguration(Position = new int[] { 30, 10 })] 
        public string PerformancesLoadMaintainedContinuouslyComments { get; set; }
		[CellConfiguration(Position = new int[] { 31, 10 })] 
        public string PerformancesLoadMaintainedMomentarilyComments { get; set; }
		[CellConfiguration(Position = new int[] { 32, 10 })] 
        public string PerformancesBacklashComments { get; set; }
		
		//Status
		[CellConfiguration(Position = new int[] { 25, 11 })] 
        public string PerformancesLimitLoadStatus { get; set; }
		[CellConfiguration(Position = new int[] { 26, 11 })] 
        public string PerformancesMaximumOperatingLoad100Status { get; set; }
		[CellConfiguration(Position = new int[] { 27, 11 })] 
        public string PerformancesMaximumOperatingLoad70Status { get; set; }
		[CellConfiguration(Position = new int[] { 28, 11 })] 
        public string PerformancesLoadVsRateStatus { get; set; }
		[CellConfiguration(Position = new int[] { 29, 11 })] 
        public string PerformancesDampingCoefficientStatus { get; set; }
		[CellConfiguration(Position = new int[] { 30, 11 })] 
        public string PerformancesLoadMaintainedContinuouslyStatus { get; set; }
		[CellConfiguration(Position = new int[] { 31, 11 })] 
        public string PerformancesLoadMaintainedMomentarilyStatus { get; set; }
		[CellConfiguration(Position = new int[] { 32, 11 })] 
        public string PerformancesBacklashStatus { get; set; }
		
		/*
		Section 4 Stressing and life
		*/
		
		//Values Aileron IB
		[CellConfiguration(Position = new int[] { 33, 4 })] 
        public string StressingAndLifeFlightDefinitionValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 34, 4 })] 
        public string StressingAndLifeNumberFlightAndFlightHoursValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 35, 4 })] 
        public string StressingAndLifeNumberAircraftPressurizationValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 36, 4 })] 
        public string StressingAndLifeNumberAircraftElectricalPowerOnOffValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 37, 4 })] 
        public string StressingAndLifeGroundWindGustDefinitionValueAileronIB { get; set; }
		
		//Values Aileron OB
		[CellConfiguration(Position = new int[] { 33, 5 })] 
        public string StressingAndLifeFlightDefinitionValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 34, 5 })] 
        public string StressingAndLifeNumberFlightAndFlightHoursValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 35, 5 })] 
        public string StressingAndLifeNumberAircraftPressurizationValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 36, 5 })] 
        public string StressingAndLifeNumberAircraftElectricalPowerOnOffValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 37, 5 })] 
        public string StressingAndLifeGroundWindGustDefinitionValueAileronOB { get; set; }
		
		//Values Elevator
		[CellConfiguration(Position = new int[] { 33, 6 })] 
        public string StressingAndLifeFlightDefinitionValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 34, 6 })] 
        public string StressingAndLifeNumberFlightAndFlightHoursValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 35, 6 })] 
        public string StressingAndLifeNumberAircraftPressurizationValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 36, 6 })] 
        public string StressingAndLifeNumberAircraftElectricalPowerOnOffValueElevator{ get; set; }
		[CellConfiguration(Position = new int[] { 37, 6 })] 
        public string StressingAndLifeGroundWindGustDefinitionValueElevator { get; set; }
		
		//Values Rudder
		[CellConfiguration(Position = new int[] { 33, 7 })] 
        public string StressingAndLifeFlightDefinitionValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 34, 7 })] 
        public string StressingAndLifeNumberFlightAndFlightHoursValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 35, 7 })] 
        public string StressingAndLifeNumberAircraftPressurizationValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 36, 7 })] 
        public string StressingAndLifeNumberAircraftElectricalPowerOnOffValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 37, 7 })] 
        public string StressingAndLifeGroundWindGustDefinitionValueRudder { get; set; }
		
		//Values Spoiler
		[CellConfiguration(Position = new int[] { 33, 8 })] 
        public string StressingAndLifeFlightDefinitionValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 34, 8 })] 
        public string StressingAndLifeNumberFlightAndFlightHoursValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 35, 8 })] 
        public string StressingAndLifeNumberAircraftPressurizationValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 36, 8 })] 
        public string StressingAndLifeNumberAircraftElectricalPowerOnOffValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 37, 8 })] 
        public string StressingAndLifeGroundWindGustDefinitionValueSpoiler { get; set; }
		
		//Units
		[CellConfiguration(Position = new int[] { 33, 9 })] 
        public string StressingAndLifeFlightDefinitionUnit { get; set; }
		[CellConfiguration(Position = new int[] { 34, 9 })] 
        public string StressingAndLifeNumberFlightAndFlightHoursUnit { get; set; }
		[CellConfiguration(Position = new int[] { 35, 9 })] 
        public string StressingAndLifeNumberAircraftPressurizationUnit { get; set; }
		[CellConfiguration(Position = new int[] { 36, 9 })] 
        public string StressingAndLifeNumberAircraftElectricalPowerOnOffUnit { get; set; }
		[CellConfiguration(Position = new int[] { 37, 9 })] 
        public string StressingAndLifeGroundWindGustDefinitionUnit { get; set; }
		
		//Comments
		[CellConfiguration(Position = new int[] { 33, 10 })] 
        public string StressingAndLifeFlightDefinitionComments { get; set; }
		[CellConfiguration(Position = new int[] { 34, 10 })] 
        public string StressingAndLifeNumberFlightAndFlightHoursComments { get; set; }
		[CellConfiguration(Position = new int[] { 35, 10 })] 
        public string StressingAndLifeNumberAircraftPressurizationComments { get; set; }
		[CellConfiguration(Position = new int[] { 36, 10 })] 
        public string StressingAndLifeNumberAircraftElectricalPowerOnOffVComments { get; set; }
		[CellConfiguration(Position = new int[] { 37, 10 })] 
        public string StressingAndLifeGroundWindGustDefinitionComments { get; set; }
		
		//Status
		[CellConfiguration(Position = new int[] { 33, 11 })] 
        public string StressingAndLifeFlightDefinitionStatus { get; set; }
		[CellConfiguration(Position = new int[] { 34, 11 })] 
        public string StressingAndLifeNumberFlightAndFlightHoursStatus { get; set; }
		[CellConfiguration(Position = new int[] { 35, 11 })] 
        public string StressingAndLifeNumberAircraftPressurizationStatus { get; set; }
		[CellConfiguration(Position = new int[] { 36, 11 })] 
        public string StressingAndLifeNumberAircraftElectricalPowerOnOffStatus { get; set; }
		[CellConfiguration(Position = new int[] { 37, 11 })] 
        public string StressingAndLifeGroundWindGustDefinitionStatus { get; set; }
		
		
		/*
		Section 5 Safety - Reliability
		*/
		
		//Values Aileron IB
		[CellConfiguration(Position = new int[] { 38, 4 })] 
        public string SafetyReliabilityMTBFValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 39, 4 })] 
        public string SafetyReliabilityFailuresRatesActuatorDisconnectValueAileronIB { get; set; }	
		[CellConfiguration(Position = new int[] { 40, 4 })] 
        public string SafetyReliabilityFailureRatesLossActiveModeValueAileronIB { get; set; }	
		[CellConfiguration(Position = new int[] { 41, 4 })] 
        public string SafetyReliabilityFailureRatesLossDampingModeValueAileronIB { get; set; }	
		[CellConfiguration(Position = new int[] { 42, 4 })] 
        public string SafetyReliabilityFailureRatesRunawayValueAileronIB { get; set; }	
		[CellConfiguration(Position = new int[] { 43, 4 })] 
        public string SafetyReliabilityFailureRatesOscillationsValueAileronIB { get; set; }			

		//Values Aileron OB
		[CellConfiguration(Position = new int[] { 38, 5 })] 
        public string SafetyReliabilityMTBFValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 39, 5 })] 
        public string SafetyReliabilityFailuresRatesActuatorDisconnectValueAileronOB { get; set; }	
		[CellConfiguration(Position = new int[] { 40, 5 })] 
        public string SafetyReliabilityFailureRatesLossActiveModeValueAileronOB { get; set; }	
		[CellConfiguration(Position = new int[] { 41, 5 })] 
        public string SafetyReliabilityFailureRatesLossDampingModeValueAileronOB { get; set; }	
		[CellConfiguration(Position = new int[] { 42, 5 })] 
        public string SafetyReliabilityFailureRatesRunawayValueAileronOB { get; set; }	
		[CellConfiguration(Position = new int[] { 43, 5 })] 
        public string SafetyReliabilityFailureRatesOscillationsValueAileronOB { get; set; }
		
		//Values Elevator
		[CellConfiguration(Position = new int[] { 38, 6 })] 
        public string SafetyReliabilityMTBFValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 39, 6 })] 
        public string SafetyReliabilityFailuresRatesActuatorDisconnectValueElevator { get; set; }	
		[CellConfiguration(Position = new int[] { 40, 6 })] 
        public string SafetyReliabilityFailureRatesLossActiveModeValueElevator { get; set; }	
		[CellConfiguration(Position = new int[] { 41, 6 })] 
        public string SafetyReliabilityFailureRatesLossDampingModeValueElevator { get; set; }	
		[CellConfiguration(Position = new int[] { 42, 6 })] 
        public string SafetyReliabilityFailureRatesRunawayValueElevator { get; set; }	
		[CellConfiguration(Position = new int[] { 43, 6 })] 
        public string SafetyReliabilityFailureRatesOscillationsValueElevator { get; set; }
		
		//Values Rudder
		[CellConfiguration(Position = new int[] { 38, 7 })] 
        public string SafetyReliabilityMTBFValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 39, 7 })] 
        public string SafetyReliabilityFailuresRatesActuatorDisconnectValueRudder { get; set; }	
		[CellConfiguration(Position = new int[] { 40, 7 })] 
        public string SafetyReliabilityFailureRatesLossActiveModeValueRudder { get; set; }	
		[CellConfiguration(Position = new int[] { 41, 7 })] 
        public string SafetyReliabilityFailureRatesLossDampingModeValueRudder { get; set; }	
		[CellConfiguration(Position = new int[] { 42, 7 })] 
        public string SafetyReliabilityFailureRatesRunawayValueRudder { get; set; }	
		[CellConfiguration(Position = new int[] { 43, 7 })] 
        public string SafetyReliabilityFailureRatesOscillationsValueRudder { get; set; }
		
		//Values Spoiler
		[CellConfiguration(Position = new int[] { 38, 8 })] 
        public string SafetyReliabilityMTBFValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 39, 8 })] 
        public string SafetyReliabilityFailuresRatesActuatorDisconnectValueSpoiler { get; set; }	
		[CellConfiguration(Position = new int[] { 40, 8 })] 
        public string SafetyReliabilityFailureRatesLossActiveModeValueSpoiler { get; set; }	
		[CellConfiguration(Position = new int[] { 41, 8 })] 
        public string SafetyReliabilityFailureRatesLossDampingModeValueSpoiler { get; set; }	
		[CellConfiguration(Position = new int[] { 42, 8 })] 
        public string SafetyReliabilityFailureRatesRunawayValueSpoiler { get; set; }	
		[CellConfiguration(Position = new int[] { 43, 8 })] 
        public string SafetyReliabilityFailureRatesOscillationsValueSpoiler { get; set; }
		
		//Units
		[CellConfiguration(Position = new int[] { 38, 9 })] 
        public string SafetyReliabilityMTBFUnit { get; set; }
		[CellConfiguration(Position = new int[] { 39, 9 })] 
        public string SafetyReliabilityFailuresRatesActuatorDisconnectUnit { get; set; }	
		[CellConfiguration(Position = new int[] { 40, 9 })] 
        public string SafetyReliabilityFailureRatesLossActiveModeUnit { get; set; }	
		[CellConfiguration(Position = new int[] { 41, 9 })] 
        public string SafetyReliabilityFailureRatesLossDampingModeUnit { get; set; }	
		[CellConfiguration(Position = new int[] { 42, 9 })] 
        public string SafetyReliabilityFailureRatesRunawayUnit{ get; set; }	
		[CellConfiguration(Position = new int[] { 43, 9 })] 
        public string SafetyReliabilityFailureRatesOscillationsUnit { get; set; }
		
		//Comments
		[CellConfiguration(Position = new int[] { 38, 10 })] 
        public string SafetyReliabilityMTBFComments { get; set; }
		[CellConfiguration(Position = new int[] { 39, 10 })] 
        public string SafetyReliabilityFailuresRatesActuatorDisconnectComments { get; set; }	
		[CellConfiguration(Position = new int[] { 40, 10 })] 
        public string SafetyReliabilityFailureRatesLossActiveModeComments { get; set; }	
		[CellConfiguration(Position = new int[] { 41, 10 })] 
        public string SafetyReliabilityFailureRatesLossDampingModeComments { get; set; }	
		[CellConfiguration(Position = new int[] { 42, 10 })] 
        public string SafetyReliabilityFailureRatesRunawayComments{ get; set; }	
		[CellConfiguration(Position = new int[] { 43, 10 })] 
        public string SafetyReliabilityFailureRatesOscillationsComments { get; set; }
		
		//Status
		[CellConfiguration(Position = new int[] { 38, 11 })] 
        public string SafetyReliabilityMTBFStatus { get; set; }
		[CellConfiguration(Position = new int[] { 39, 11 })] 
        public string SafetyReliabilityFailuresRatesActuatorDisconnectStatus { get; set; }	
		[CellConfiguration(Position = new int[] { 40, 11 })] 
        public string SafetyReliabilityFailureRatesLossActiveModeStatus { get; set; }	
		[CellConfiguration(Position = new int[] { 41, 11 })] 
        public string SafetyReliabilityFailureRatesLossDampingModeStatus { get; set; }	
		[CellConfiguration(Position = new int[] { 42, 11 })] 
        public string SafetyReliabilityFailureRatesRunawayStatus { get; set; }	
		[CellConfiguration(Position = new int[] { 43, 11 })] 
        public string SafetyReliabilityFailureRatesOscillationsStatus { get; set; }

		/*
		Section 6 Power supply
		*/
		
		//Values Aileron IB
		[CellConfiguration(Position = new int[] { 44, 4 })] 
        public string PowerSupplyHydraulicPowerCharacteristicsValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 45, 4 })] 
        public string PowerSupplyFluidTemperatureValueAileronIB { get; set; }
		[CellConfiguration(Position = new int[] { 46, 4 })] 
        public string PowerSupplyElectricalPowerCharacteristicsValueAileronIB { get; set; }
		
		//Values Aileron OB
		[CellConfiguration(Position = new int[] { 44, 5 })] 
        public string PowerSupplyHydraulicPowerCharacteristicsValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 45, 5 })] 
        public string PowerSupplyFluidTemperatureValueAileronOB { get; set; }
		[CellConfiguration(Position = new int[] { 46, 5 })] 
        public string PowerSupplyElectricalPowerCharacteristicsValueAileronOB { get; set; }
		
		//Values Elevator
		[CellConfiguration(Position = new int[] { 44, 6 })] 
        public string PowerSupplyHydraulicPowerCharacteristicsValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 45, 6 })] 
        public string PowerSupplyFluidTemperatureValueElevator { get; set; }
		[CellConfiguration(Position = new int[] { 46, 6 })] 
        public string PowerSupplyElectricalPowerCharacteristicsValueElevator { get; set; }
		
		//Values Rudder
		[CellConfiguration(Position = new int[] { 44, 7 })] 
        public string PowerSupplyHydraulicPowerCharacteristicsValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 45, 7 })] 
        public string PowerSupplyFluidTemperatureValueRudder { get; set; }
		[CellConfiguration(Position = new int[] { 46, 7 })] 
        public string PowerSupplyElectricalPowerCharacteristicsValueRudder { get; set; }
		
		//Values Spoiler
		[CellConfiguration(Position = new int[] { 44, 8 })] 
        public string PowerSupplyHydraulicPowerCharacteristicsValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 45, 8 })] 
        public string PowerSupplyFluidTemperatureValueSpoiler { get; set; }
		[CellConfiguration(Position = new int[] { 46, 8 })] 
        public string PowerSupplyElectricalPowerCharacteristicsValueSpoiler { get; set; }
		
		//Units
		[CellConfiguration(Position = new int[] { 44, 9 })] 
        public string PowerSupplyHydraulicPowerCharacteristicsUnit { get; set; }
		[CellConfiguration(Position = new int[] { 45, 9 })] 
        public string PowerSupplyFluidTemperatureUnit { get; set; }
		[CellConfiguration(Position = new int[] { 46, 9 })] 
        public string PowerSupplyElectricalPowerCharacteristicsUnit { get; set; }
		
		//Comments
		[CellConfiguration(Position = new int[] { 44, 10 })] 
        public string PowerSupplyHydraulicPowerCharacteristicsComments { get; set; }
		[CellConfiguration(Position = new int[] { 45, 10 })] 
        public string PowerSupplyFluidTemperatureComments { get; set; }
		[CellConfiguration(Position = new int[] { 46, 10 })] 
        public string PowerSupplyElectricalPowerCharacteristicsComments { get; set; }
		
		//Status
		[CellConfiguration(Position = new int[] { 44, 11 })] 
        public string PowerSupplyHydraulicPowerCharacteristicsStatus { get; set; }
		[CellConfiguration(Position = new int[] { 45, 11 })] 
        public string PowerSupplyFluidTemperatureStatus { get; set; }
		[CellConfiguration(Position = new int[] { 46, 11 })] 
        public string PowerSupplyElectricalPowerCharacteristicsStatus { get; set; }
		
		/*
		Section 7 Environment
		*/
		
		//Values Aileron IB
		[CellConfiguration(Position = new int[] { 47, 4 })] 
        public string EnvironmentDOorMILCategoriesValueAileronIB { get; set; }
		 
		//Values Aileron OB
		[CellConfiguration(Position = new int[] { 47, 5 })] 
        public string EnvironmentDOorMILCategoriesValueAileronOB { get; set; }
		
		//Values Elevator
		[CellConfiguration(Position = new int[] { 47, 6 })] 
        public string EnvironmentDOorMILCategoriesValueElevator { get; set; }
		
		//Values Rudder
		[CellConfiguration(Position = new int[] { 47, 7 })] 
        public string EnvironmentDOorMILCategoriesValueRudder { get; set; }
		
		//Values Spoiler
		[CellConfiguration(Position = new int[] { 47, 8 })] 
        public string EnvironmentDOorMILCategoriesValueSpoiler { get; set; }
		
		//Unit
		[CellConfiguration(Position = new int[] { 47, 9 })] 
        public string EnvironmentDOorMILCategoriesUnit { get; set; }
		
		//Comments
		[CellConfiguration(Position = new int[] { 47, 10 })] 
        public string EnvironmentDOorMILCategoriesComments { get; set; }
		
		//Status
		[CellConfiguration(Position = new int[] { 47, 11 })] 
        public string EnvironmentDOorMILCategoriesStatus { get; set; }
		 
	}
	
	/// <summary>
	/// Spec EHSA_v1.xslx
	/// Feuille Compliance Analysis
	/// </summary>
	[BusinessClass(BaseUri = "http://xowl.org/specehsa/complianceanalysis#",Position = "Compliance Analysis")]
    public class ComplianceAnalysis : Identifiable
    {
        [CellConfiguration(CellsAfter = 8)]
		public string empty { get; set; }
        public string SpecificationParagraph { get; set; }
        public string RequirementReferenceTheme { get; set; }
        public string RequirementTitle { get; set; }
		public string ComplianceStatement { get; set; } 
		public string UTASComments { get; set; } 
    }
	
	/// <summary>
	/// Power_ram_sizing.xlsx
	/// Feuille Donnees
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/powerramsizing/donnees#", IsComplex = true, Position = "Donnees")]
    public class PowerRamSizingDonnees : Identifiable
    {
		/*
		Cartouche Données générales
		*/
    	[CellConfiguration(Position = new int[] { 4, 3 })] 
        public string TypeDeServocommande { get; set; }
		[CellConfiguration(Position = new int[] { 5, 3 })] 
        public string TypeAccrocheCoteBati { get; set; }
        [CellConfiguration(Position = new int[] { 6, 3 })]
        public string ChoixDeLEmbout { get; set; } 
		[CellConfiguration(Position = new int[] { 7, 3 })]
        public int NombreActionneurParSurface { get; set; } 
		[CellConfiguration(Position = new int[] { 8, 3 })]
        public int DimensionnementEnFatigue { get; set; } 
		
		
		//Validation des données
		[CellConfiguration(Position = new int[] { 4, 7 })] 
        public string TypeDeServocommandeValidation { get; set; } //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 5, 7 })] 
        public string TypeAccrocheCoteBatiValidation { get; set; } //Format BOOLEAN  (Y/N)
        [CellConfiguration(Position = new int[] { 6, 7 })]
        public string ChoixDeLEmboutValidation { get; set; } //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 7, 7 })]
        public string NombreDActionneurParSurfaceValidation { get; set; } //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 8, 7 })]
        public string DimensionnementEnFatigueValidation { get; set; } //Format BOOLEAN  (Y/N)
		
		//Source
		[CellConfiguration(Position = new int[] { 4, 8 })] 
        public string TypeDeServocommandeSource { get; set; } // Enum {"Exigence client","Hypothèse interne","Autre","TBC"," "}
		[CellConfiguration(Position = new int[] { 5, 8 })] 
        public string TypeAccrocheCoteBatiSource { get; set; }
        [CellConfiguration(Position = new int[] { 6, 8 })]
        public string ChoixDeLEmboutSource { get; set; } 
		[CellConfiguration(Position = new int[] { 7, 8 })]
        public string NombreDActionneurParSurfaceSource { get; set; } 
		[CellConfiguration(Position = new int[] { 8, 8 })]
        public string DimensionnementEnFatigueSource { get; set; } 
		
		//Commentaires
		[CellConfiguration(Position = new int[] { 4, 9 })] 
        public string TypeDeServocommandeCommentaire { get; set; } 
		[CellConfiguration(Position = new int[] { 5, 9 })] 
        public string TypeAccrocheCoteBatiCommentaire { get; set; }
        [CellConfiguration(Position = new int[] { 6, 9 })]
        public string ChoixDeLEmboutCommentaire { get; set; } 
		[CellConfiguration(Position = new int[] { 7, 9 })]
        public string NombreDActionneurParSurfaceCommentaire { get; set; } 
		[CellConfiguration(Position = new int[] { 8, 9 })]
        public string DimensionnementEnFatigueCommentaire { get; set; } 
		*/
		
		/*
		Cartouche Données plan d'encombrement
		*/
    	[CellConfiguration(Position = new int[] { 11, 3 })] 
        public double Surcourse { get; set; }
		
		[CellConfiguration(Position = new int[] { 13, 3 })] 
        public double AncrageServocommandeAQ { get; set; }
        [CellConfiguration(Position = new int[] { 14, 3 })]
        public double MoyeuGourverneRQB { get; set; } 
		[CellConfiguration(Position = new int[] { 15, 3 })]
        public double EntraxeNeutreE0AB0 { get; set; } 
		[CellConfiguration(Position = new int[] { 16, 3 })]
        public double AngleBraquageGouverneExtension { get; set; }
		[CellConfiguration(Position = new int[] { 17, 3 })] 
        public double AngleBraquageGouverneRetractionNegatif { get; set; }
		
		
		//Validation des données
		[CellConfiguration(Position = new int[] { 11, 7 })] 
        public string SurcourseValidation { get; set; } //Format BOOLEAN  (Y/N)
		
		[CellConfiguration(Position = new int[] { 13, 7 })] 
        public string AncrageServocommandeAQValidation { get; set; } //Format BOOLEAN  (Y/N)
        [CellConfiguration(Position = new int[] { 14, 7 })]
        public string MoyeuGourverneRQBValidation { get; set; }  //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 15, 7 })]
        public string EntraxeNeutreE0AB0Validation { get; set; } //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 16, 7 })]
        public string AngleBraquageGouverneExtensionValidation { get; set; } //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 17, 7 })] 
        public string AngleBraquageGouverneRetractionNegatifValidation { get; set; } //Format BOOLEAN  (Y/N)
		
		//Source
		[CellConfiguration(Position = new int[] { 11, 8 })] 
        public string SurcourseSource { get; set; } // Enum {"Exigence client","Hypothèse interne","Autre","TBC"," "}
		
		[CellConfiguration(Position = new int[] { 13, 8 })] 
        public string AncrageServocommandeAQSource { get; set; }
        [CellConfiguration(Position = new int[] { 14, 8 })]
        public string MoyeuGourverneRQBSource { get; set; } 
		[CellConfiguration(Position = new int[] { 15, 8 })]
        public string EntraxeNeutreE0AB0Source { get; set; } 
		[CellConfiguration(Position = new int[] { 16, 8 })]
        public string AngleBraquageGouverneExtensionSource { get; set; }
		[CellConfiguration(Position = new int[] { 17, 8 })] 
        public string AngleBraquageGouverneRetractionNegatifSource { get; set; }
		
		//Commentaires
		[CellConfiguration(Position = new int[] { 11, 9 })] 
        public string SurcourseCommentaire { get; set; }
		
		[CellConfiguration(Position = new int[] { 13, 9 })] 
        public string AncrageServocommandeAQCommentaire { get; set; }
        [CellConfiguration(Position = new int[] { 14, 9 })]
        public string MoyeuGourverneRQBCommentaire { get; set; } 
		[CellConfiguration(Position = new int[] { 15, 9 })]
        public string EntraxeNeutreE0AB0Commentaire { get; set; } 
		[CellConfiguration(Position = new int[] { 16, 9 })]
        public string AngleBraquageGouverneExtensionCommentaire { get; set; }
		[CellConfiguration(Position = new int[] { 17, 9 })] 
        public string AngleBraquageGouverneRetractionNegatifCommentaire { get; set; }
		
		
		/*
		Cartouche Données dimensionnement en statique
		*/
    	[CellConfiguration(Position = new int[] { 21, 3 })] 
        public double PressionEntreeStatique { get; set; }
		[CellConfiguration(Position = new int[] { 22, 3 })] 
        public double PressionSortieStatique { get; set; }
		[CellConfiguration(Position = new int[] { 23, 3 })] 
        public double SurpressionEntree { get; set; }
		[CellConfiguration(Position = new int[] { 24, 3 })] 
        public double SurpressionSortie { get; set; }
		[CellConfiguration(Position = new int[] { 25, 3 })] 
        public double ChargeLimite { get; set; }
		[CellConfiguration(Position = new int[] { 26, 3 })] 
        public double ChargeArretExtension { get; set; }
		[CellConfiguration(Position = new int[] { 27, 3 })] 
        public double ChargeArretRetraction { get; set; }
		[CellConfiguration(Position = new int[] { 28, 3 })] 
        public double InertieGouverne { get; set; }
		[CellConfiguration(Position = new int[] { 29, 3 })] 
        public double RaideurCoteGouverne { get; set; }
		[CellConfiguration(Position = new int[] { 30, 3 })] 
        public double RaideurCoteBati { get; set; }
		[CellConfiguration(Position = new int[] { 31, 3 })] 
        public double CoupleRafaleVentSol { get; set; }
		[CellConfiguration(Position = new int[] { 32, 3 })] 
        public double CoefficientAmortissement { get; set; }
		
		
		//Validation des données
		[CellConfiguration(Position = new int[] { 21, 7 })] 
        public string PressionEntreeStatiqueValidation { get; set; } //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 22, 7 })] 
        public string PressionSortieStatiqueValidation { get; set; }
		[CellConfiguration(Position = new int[] { 23, 7 })] 
        public string SurpressionEntreeValidation { get; set; }
		[CellConfiguration(Position = new int[] { 24, 7 })] 
        public string SurpressionSortieValidation { get; set; }
		[CellConfiguration(Position = new int[] { 25, 7 })] 
        public string ChargeLimiteValidation { get; set; }
		[CellConfiguration(Position = new int[] { 26, 7 })] 
        public string ChargeArretExtensionValidation { get; set; }
		[CellConfiguration(Position = new int[] { 27, 7 })] 
        public string ChargeArretRetractionValidation { get; set; }
		[CellConfiguration(Position = new int[] { 28, 7 })] 
        public string InertieGouverneValidation { get; set; }
		[CellConfiguration(Position = new int[] { 29, 7 })] 
        public string RaideurCoteGouverneValidation { get; set; }
		[CellConfiguration(Position = new int[] { 30, 7 })] 
        public string RaideurCoteBatiValidation { get; set; }
		[CellConfiguration(Position = new int[] { 31, 7 })] 
        public string CoupleRafaleVentSolValidation { get; set; }
		[CellConfiguration(Position = new int[] { 32, 7 })] 
        public string CoefficientAmortissementValidation { get; set; }
		
		//Source
		[CellConfiguration(Position = new int[] { 21, 8 })] 
        public string PressionEntreeStatiqueSource { get; set; }  // Enum {"Exigence client","Hypothèse interne","Autre","TBC"," "}
		[CellConfiguration(Position = new int[] { 22, 8 })] 
        public string PressionSortieStatiqueSource { get; set; }
		[CellConfiguration(Position = new int[] { 23, 8 })] 
        public string SurpressionEntreeSource { get; set; }
		[CellConfiguration(Position = new int[] { 24, 8 })] 
        public string SurpressionSortieSource { get; set; }
		[CellConfiguration(Position = new int[] { 25, 8 })] 
        public string ChargeLimiteSource { get; set; }
		[CellConfiguration(Position = new int[] { 26, 8 })] 
        public string ChargeArretExtensionSource { get; set; }
		[CellConfiguration(Position = new int[] { 27, 8 })] 
        public string ChargeArretRetractionSource { get; set; }
		[CellConfiguration(Position = new int[] { 28, 8 })] 
        public string InertieGouverneSource { get; set; }
		[CellConfiguration(Position = new int[] { 29, 8 })] 
        public string RaideurCoteGouverneSource { get; set; }
		[CellConfiguration(Position = new int[] { 30, 8 })] 
        public string RaideurCoteBatiSource { get; set; }
		[CellConfiguration(Position = new int[] { 31, 8 })] 
        public string CoupleRafaleVentSolSource { get; set; }
		[CellConfiguration(Position = new int[] { 32, 8 })] 
        public string CoefficientAmortissementSource { get; set; }
		
		//Commentaires
		[CellConfiguration(Position = new int[] { 21, 9 })] 
        public string PressionEntreeStatiqueCommentaire { get; set; } 
		[CellConfiguration(Position = new int[] { 22, 9 })] 
        public string PressionSortieStatiqueCommentaire { get; set; }
		[CellConfiguration(Position = new int[] { 23, 9 })] 
        public string SurpressionEntreeCommentaire { get; set; }
		[CellConfiguration(Position = new int[] { 24, 9 })] 
        public string SurpressionSortieCommentaire { get; set; }
		[CellConfiguration(Position = new int[] { 25, 9 })] 
        public string ChargeLimiteCommentaire { get; set; }
		[CellConfiguration(Position = new int[] { 26, 9 })] 
        public string ChargeArretExtensionCommentaire { get; set; }
		[CellConfiguration(Position = new int[] { 27, 9 })] 
        public string ChargeArretRetractionCommentaire { get; set; }
		[CellConfiguration(Position = new int[] { 28, 9 })] 
        public string InertieGouverneCommentaire { get; set; }
		[CellConfiguration(Position = new int[] { 29, 9 })] 
        public string RaideurCoteGouverneCommentaire { get; set; }
		[CellConfiguration(Position = new int[] { 30, 9 })] 
        public string RaideurCoteBatiCommentaire { get; set; }
		[CellConfiguration(Position = new int[] { 31, 9 })] 
        public string CoupleRafaleVentSolCommentaire { get; set; }
		[CellConfiguration(Position = new int[] { 32, 9 })] 
        public string CoefficientAmortissementCommentaire { get; set; }
		
	}
	
	/// <summary>
	/// Power_ram_sizing.xlsx
	/// Feuille Donnees Partie Validation 
	/// </summary>
    /*[BusinessClass(BaseUri = "http://xowl.org/powerramsizing/validationdonnees#", IsComplex = true, Position = "Donnees")]
    public class PowerRamSizingValidationDonnees : Identifiable
    {
		
		//Cartouche Données générales
		
		[CellConfiguration(Position = new int[] { 4, 7 })] 
        public string TypeDeServocommande { get; set; } //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 5, 7 })] 
        public string TypeAccrocheCoteBati { get; set; } //Format BOOLEAN  (Y/N)
        [CellConfiguration(Position = new int[] { 6, 7 })]
        public string ChoixDeLEmbout { get; set; } //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 7, 7 })]
        public string NombreDActionneurParSurface { get; set; } //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 8, 7 })]
        public string DimensionnementEnFatigue { get; set; } //Format BOOLEAN  (Y/N)
		
		
		//Cartouche Données plan d'encombrement
		
		[CellConfiguration(Position = new int[] { 11, 7 })] 
        public string Surcourse { get; set; } //Format BOOLEAN  (Y/N)
		
		[CellConfiguration(Position = new int[] { 13, 7 })] 
        public string AncrageServocommandeAQ { get; set; } //Format BOOLEAN  (Y/N)
        [CellConfiguration(Position = new int[] { 14, 7 })]
        public string MoyeuGourverneRQB { get; set; }  //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 15, 7 })]
        public string EntraxeNeutreE0AB0 { get; set; } //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 16, 7 })]
        public string AngleBraquageGouverneExtension { get; set; } //Format BOOLEAN  (Y/N)
		[CellConfiguration(Position = new int[] { 17, 7 })] 
        public string AngleBraquageGouverneRetractionNegatif { get; set; } //Format BOOLEAN  (Y/N)
		
		//Cartouche Données dimensionnement en statique
		
		[CellConfiguration(Position = new int[] { 21, 7 })] 
        public string PressionEntreeStatique { get; set; }
		[CellConfiguration(Position = new int[] { 22, 7 })] 
        public string PressionSortieStatique { get; set; }
		[CellConfiguration(Position = new int[] { 23, 7 })] 
        public string SurpressionEntree { get; set; }
		[CellConfiguration(Position = new int[] { 24, 7 })] 
        public string SurpressionSortie { get; set; }
		[CellConfiguration(Position = new int[] { 25, 7 })] 
        public string ChargeLimite { get; set; }
		[CellConfiguration(Position = new int[] { 26, 7 })] 
        public string ChargeArretExtension { get; set; }
		[CellConfiguration(Position = new int[] { 27, 7 })] 
        public string ChargeArretRetraction { get; set; }
		[CellConfiguration(Position = new int[] { 28, 7 })] 
        public string InertieGouverne { get; set; }
		[CellConfiguration(Position = new int[] { 29, 7 })] 
        public string RaideurCoteGouverne { get; set; }
		[CellConfiguration(Position = new int[] { 30, 7 })] 
        public string RaideurCoteBati { get; set; }
		[CellConfiguration(Position = new int[] { 31, 7 })] 
        public string CoupleRafaleVentSol { get; set; }
		[CellConfiguration(Position = new int[] { 32, 7 })] 
        public string CoefficientAmortissement { get; set; }
		
	}*/
	
	/// <summary>
	/// Power_ram_sizing.xlsx
	/// Feuille Donnees Partie Source 
	/// </summary>
    /*[BusinessClass(BaseUri = "http://xowl.org/powerramsizing/sourcesdonnees#", IsComplex = true, Position = "Donnees")]
    public class PowerRamSizingSourceDonnees : Identifiable
    {
		
		//Cartouche Données générales
		
		[CellConfiguration(Position = new int[] { 4, 8 })] 
        public string TypeDeServocommande { get; set; } // Enum {"Exigence client","Hypothèse interne","Autre","TBC"," "}
		[CellConfiguration(Position = new int[] { 5, 8 })] 
        public string TypeAccrocheCoteBati { get; set; }
        [CellConfiguration(Position = new int[] { 6, 8 })]
        public string ChoixDeLEmbout { get; set; } 
		[CellConfiguration(Position = new int[] { 7, 8 })]
        public string NombreDActionneurParSurface { get; set; } 
		[CellConfiguration(Position = new int[] { 8, 8 })]
        public string DimensionnementEnFatigue { get; set; } 
		
		
		//Cartouche Données plan d'encombrement
		
		[CellConfiguration(Position = new int[] { 11, 8 })] 
        public string Surcourse { get; set; } // Enum {"Exigence client","Hypothèse interne","Autre","TBC"," "}
		
		[CellConfiguration(Position = new int[] { 13, 8 })] 
        public string AncrageServocommandeAQ { get; set; }
        [CellConfiguration(Position = new int[] { 14, 8 })]
        public string MoyeuGourverneRQB { get; set; } 
		[CellConfiguration(Position = new int[] { 15, 8 })]
        public string EntraxeNeutreE0AB0 { get; set; } 
		[CellConfiguration(Position = new int[] { 16, 8 })]
        public string AngleBraquageGouverneExtension { get; set; }
		[CellConfiguration(Position = new int[] { 17, 8 })] 
        public string AngleBraquageGouverneRetractionNegatif { get; set; }
		
		
		//Cartouche Données dimensionnement en statique
		
		[CellConfiguration(Position = new int[] { 21, 8 })] 
        public string PressionEntreeStatique { get; set; }  // Enum {"Exigence client","Hypothèse interne","Autre","TBC"," "}
		[CellConfiguration(Position = new int[] { 22, 8 })] 
        public string PressionSortieStatique { get; set; }
		[CellConfiguration(Position = new int[] { 23, 8 })] 
        public string SurpressionEntree { get; set; }
		[CellConfiguration(Position = new int[] { 24, 8 })] 
        public string SurpressionSortie { get; set; }
		[CellConfiguration(Position = new int[] { 25, 8 })] 
        public string ChargeLimite { get; set; }
		[CellConfiguration(Position = new int[] { 26, 8 })] 
        public string ChargeArretExtension { get; set; }
		[CellConfiguration(Position = new int[] { 27, 8 })] 
        public string ChargeArretRetraction { get; set; }
		[CellConfiguration(Position = new int[] { 28, 8 })] 
        public string InertieGouverne { get; set; }
		[CellConfiguration(Position = new int[] { 29, 8 })] 
        public string RaideurCoteGouverne { get; set; }
		[CellConfiguration(Position = new int[] { 30, 8 })] 
        public string RaideurCoteBati { get; set; }
		[CellConfiguration(Position = new int[] { 31, 8 })] 
        public string CoupleRafaleVentSol { get; set; }
		[CellConfiguration(Position = new int[] { 32, 8 })] 
        public string CoefficientAmortissement { get; set; }
		
	}*/

	/// <summary>
	/// Power_ram_sizing.xlsx
	/// Feuille Donnees Partie Commentaires 
	/// </summary>
    /*[BusinessClass(BaseUri = "http://xowl.org/powerramsizing/commentairesdonnees#", IsComplex = true, Position = "Donnees")]
    public class PowerRamSizingCommentairesDonnees : Identifiable
    {
		
		//Cartouche Données générales
		
		[CellConfiguration(Position = new int[] { 4, 9 })] 
        public string TypeDeServocommande { get; set; } 
		[CellConfiguration(Position = new int[] { 5, 9 })] 
        public string TypeAccrocheCoteBati { get; set; }
        [CellConfiguration(Position = new int[] { 6, 9 })]
        public string ChoixDeLEmbout { get; set; } 
		[CellConfiguration(Position = new int[] { 7, 9 })]
        public string NombreDActionneurParSurface { get; set; } 
		[CellConfiguration(Position = new int[] { 8, 9 })]
        public string DimensionnementEnFatigue { get; set; } 
		
		
		//Cartouche Données plan d'encombrement
		
		[CellConfiguration(Position = new int[] { 11, 9 })] 
        public string Surcourse { get; set; }
		
		[CellConfiguration(Position = new int[] { 13, 9 })] 
        public string AncrageServocommandeAQ { get; set; }
        [CellConfiguration(Position = new int[] { 14, 9 })]
        public string MoyeuGourverneRQB { get; set; } 
		[CellConfiguration(Position = new int[] { 15, 9 })]
        public string EntraxeNeutreE0AB0 { get; set; } 
		[CellConfiguration(Position = new int[] { 16, 9 })]
        public string AngleBraquageGouverneExtension { get; set; }
		[CellConfiguration(Position = new int[] { 17, 9 })] 
        public string AngleBraquageGouverneRetractionNegatif { get; set; }
		
		//Cartouche Données dimensionnement en statique
		
		[CellConfiguration(Position = new int[] { 21, 9 })] 
        public string PressionEntreeStatique { get; set; } 
		[CellConfiguration(Position = new int[] { 22, 9 })] 
        public string PressionSortieStatique { get; set; }
		[CellConfiguration(Position = new int[] { 23, 9 })] 
        public string SurpressionEntree { get; set; }
		[CellConfiguration(Position = new int[] { 24, 9 })] 
        public string SurpressionSortie { get; set; }
		[CellConfiguration(Position = new int[] { 25, 9 })] 
        public string ChargeLimite { get; set; }
		[CellConfiguration(Position = new int[] { 26, 9 })] 
        public string ChargeArretExtension { get; set; }
		[CellConfiguration(Position = new int[] { 27, 9 })] 
        public string ChargeArretRetraction { get; set; }
		[CellConfiguration(Position = new int[] { 28, 9 })] 
        public string InertieGouverne { get; set; }
		[CellConfiguration(Position = new int[] { 29, 9 })] 
        public string RaideurCoteGouverne { get; set; }
		[CellConfiguration(Position = new int[] { 30, 9 })] 
        public string RaideurCoteBati { get; set; }
		[CellConfiguration(Position = new int[] { 31, 9 })] 
        public string CoupleRafaleVentSol { get; set; }
		[CellConfiguration(Position = new int[] { 32, 9 })] 
        public string CoefficientAmortissement { get; set; }
		
	}*/
	
	/// <summary>
	/// Power_ram_sizing.xlsx
	/// Feuille Schema LP symetrique 1 
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/powerramsizing/schemalpsymetrique#", IsComplex = true, Position = "Schema LP symetrique 1")]
    public class PowerRamSizingSchemaLPSymetrique : Identifiable
    {
		/*
		Cartouche Dimensions caractéristiques
		*/
		[CellConfiguration(Position = new int[] { 34, 10 })] 
        public double SectionUtile { get; set; } 
		[CellConfiguration(Position = new int[] { 35, 10 })] 
        public double ToileTige { get; set; }
        [CellConfiguration(Position = new int[] { 36, 10 })]
        public double DiametresTige { get; set; } 
		[CellConfiguration(Position = new int[] { 38, 10 })]
        public double DiametresPiston { get; set; } 
		
		/*
		Schéma valeurs résultats
		*/
		[CellConfiguration(Position = new int[] { 12, 25 })] 
        public double R1 { get; set; } 
		[CellConfiguration(Position = new int[] { 32, 25 })] 
        public double R2 { get; set; }
        [CellConfiguration(Position = new int[] { 34, 25 })]
        public double R3 { get; set; } 
		[CellConfiguration(Position = new int[] { 10, 46 })]
        public double R4 { get; set; } 
		[CellConfiguration(Position = new int[] { 31, 46 })] 
        public double R5 { get; set; } 
		[CellConfiguration(Position = new int[] { 12, 50 })] 
        public double R6 { get; set; }
        [CellConfiguration(Position = new int[] { 32, 51 })]
        public double R7 { get; set; } 
		[CellConfiguration(Position = new int[] { 31, 54 })]
        public double R8 { get; set; } 
		[CellConfiguration(Position = new int[] { 31, 63 })] 
        public double R9 { get; set; } 
		[CellConfiguration(Position = new int[] { 31, 69 })] 
        public double R10 { get; set; }
        [CellConfiguration(Position = new int[] { 12, 74 })]
        public double R11 { get; set; } 
		[CellConfiguration(Position = new int[] { 22, 89 })]
        public double R12 { get; set; } 
		[CellConfiguration(Position = new int[] { 31, 91 })]
        public double R13 { get; set; } 			
	}
	
	/// <summary>
	/// KDD.xlsm
	/// Feuille KDD
	/// </summary>
    /*[BusinessClass(BaseUri = "http://xowl.org/kdd/kdd#", IsComplex = true, Position = "KDD")]
    public class KDD : Identifiable
    {
		
		//Cartouche Identification
		
		[CellConfiguration(Position = new int[] { 7, 2 })] //Expected column B
        public string Programme { get; set; }
		[CellConfiguration(Position = new int[] { 8, 2 })] 
        public string Author { get; set; }
		[CellConfiguration(Position = new int[] { 9, 2 })] 
        public string Date { get; set; }
		[CellConfiguration(Position = new int[] { 10, 2 })] 
        public string Version { get; set; }
		
		//Cartouche KDD Aileron
		
		[CellConfiguration(Position = new int[] { 15, 2 })]
        public double SuppyPressure { get; set; }
		[CellConfiguration(Position = new int[] { 16, 2 })]
        public double ReturnPressure { get; set; }
		[CellConfiguration(Position = new int[] { 17, 2 })]
        public double ProofPressure { get; set; }
		
		[CellConfiguration(Position = new int[] { 20, 2 })]
        public double StructureSurfacePivotDistance { get; set; }
		[CellConfiguration(Position = new int[] { 21, 2 })]
        public double SurfacePivotActuatorAttachmentDistance { get; set; }
		[CellConfiguration(Position = new int[] { 22, 2 })]
        public double PinToPinDistanceNeutral { get; set; }
		[CellConfiguration(Position = new int[] { 23, 2 })]
        public double ExtensionStroke { get; set; }
		[CellConfiguration(Position = new int[] { 24, 2 })]
        public double RetractionStroke { get; set; }
		[CellConfiguration(Position = new int[] { 25, 2 })]
        public double StallLoadExtension { get; set; }
		[CellConfiguration(Position = new int[] { 26, 2 })]
        public double StallLoadRetraction { get; set; }
		[CellConfiguration(Position = new int[] { 27, 2 })]
        public double LimitLoad { get; set; }

		[CellConfiguration(Position = new int[] { 29, 2 })]
        public double MaxPowerPointLoad { get; set; }
		[CellConfiguration(Position = new int[] { 30, 2 })]
        public double MaxPowerPointSpeed { get; set; }
		[CellConfiguration(Position = new int[] { 31, 2 })]
        public double DampingCoefficient { get; set; }
		[CellConfiguration(Position = new int[] { 32, 2 })]
        public double MinFluidTemperature { get; set; }
		[CellConfiguration(Position = new int[] { 33, 2 })]
        public double MaxFluidTemperature { get; set; }
		
		
		//Cartouche Reference  documents
		
		[CellConfiguration(Position = new int[] { 15, 3 })]
        public string SuppyPressureRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 16, 3 })]
        public string ReturnPressureRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 17, 3 })]
        public string ProofPressureRefDocuments { get; set; }
		
		[CellConfiguration(Position = new int[] { 20, 3 })]
        public string StructureSurfacePivotDistanceRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 21, 3 })]
        public string SurfacePivotActuatorAttachmentDistanceRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 22, 3 })]
        public string PinToPinDistanceNeutralRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 23, 3 })]
        public string ExtensionStrokeRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 24, 3 })]
        public string RetractionStrokeRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 25, 3 })]
        public string StallLoadExtensionRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 26, 3 })]
        public string StallLoadRetractionRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 27, 3 })]
        public string LimitLoadRefDocuments { get; set; }

		[CellConfiguration(Position = new int[] { 29, 3 })]
        public string MaxPowerPointLoadRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 30, 3 })]
        public string MaxPowerPointSpeedRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 31, 3 })]
        public string DampingCoefficientRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 32, 3 })]
        public string MinFluidTemperatureRefDocuments { get; set; }
		[CellConfiguration(Position = new int[] { 33, 3 })]
        public string MaxFluidTemperatureRefDocuments { get; set; }
	}*/
	
	/// <summary>
	/// KDD.xlsm
	/// Feuille Actuator Key characteristics
	/// </summary>
    /*[BusinessClass(BaseUri = "http://xowl.org/kdd/actuatorkeycharacteristics#", IsComplex = true, Position = "Actuator Key characteristics")]
    public class ActuatorKeyCharacteristics : Identifiable
    {
		//Cartouche Identification
		
		[CellConfiguration(Position = new int[] { 7, 2 })] //Expected column B
        public string Programme { get; set; }
		[CellConfiguration(Position = new int[] { 8, 2 })] 
        public string Author { get; set; }
		[CellConfiguration(Position = new int[] { 9, 2 })] 
        public string Date { get; set; }
		[CellConfiguration(Position = new int[] { 10, 2 })] 
        public string Version { get; set; }
		
		//Cartouche Actuator Key characteristics Aileron
		
		//Power lane
		[CellConfiguration(Position = new int[] { 16, 2 })] 
        public string ActuatorType { get; set; } //(balanced/unbalanced sections)
		[CellConfiguration(Position = new int[] { 17, 2 })] 
        public double RodDiameter { get; set; }
		[CellConfiguration(Position = new int[] { 18, 2 })] 
        public double PistonDiameter { get; set; }
 
		//Attachments
		[CellConfiguration(Position = new int[] { 21, 2 })] 
        public string TypeRodEnd { get; set; } //(male/femelle)
		[CellConfiguration(Position = new int[] { 22, 2 })] 
        public string StructureBearingType { get; set; } //(auto lub, roller)
		[CellConfiguration(Position = new int[] { 23, 2 })] 
        public string SurfaceBearingType { get; set; } //(auto lub, roller)
 
		[CellConfiguration(Position = new int[] { 25, 2 })] 
        public double SelectedTubeDiameter { get; set; }
 
		//Servovalve
		[CellConfiguration(Position = new int[] { 28, 2 })] 
        public double EHSVMinFlow { get; set; }

		//Acumulator
		[CellConfiguration(Position = new int[] { 31, 2 })] 
        public double MinimumAcumulatorPressure { get; set; }
		[CellConfiguration(Position = new int[] { 32, 2 })] 
        public double MinimumAccumulatorVolume { get; set; }

		
		//Cartouche Actuator Key characteristics Tool1 output
		
		//Power lane
		[CellConfiguration(Position = new int[] { 16, 3 })] 
        public string ActuatorTypeTool1 { get; set; } //(balanced/unbalanced sections)
		[CellConfiguration(Position = new int[] { 17, 3 })] 
        public double RodDiameterTool1 { get; set; }
		[CellConfiguration(Position = new int[] { 18, 3 })] 
        public double PistonDiameterTool1 { get; set; }
 
		//Attachments
		[CellConfiguration(Position = new int[] { 21, 3 })] 
        public string TypeRodEndTool1 { get; set; } //(male/femelle)
		[CellConfiguration(Position = new int[] { 22, 3 })] 
        public string StructureBearingTypeTool1 { get; set; } //(auto lub, roller)
		[CellConfiguration(Position = new int[] { 23, 3 })] 
        public string SurfaceBearingTypeTool1 { get; set; } //(auto lub, roller)
 
		[CellConfiguration(Position = new int[] { 25, 3 })] 
        public double SelectedTubeDiameterTool1 { get; set; }
 
		//Servovalve
		[CellConfiguration(Position = new int[] { 28, 3 })] 
        public double EHSVMinFlowTool1 { get; set; }

		//Acumulator
		[CellConfiguration(Position = new int[] { 31, 3 })] 
        public double MinimumAcumulatorPressureTool1 { get; set; }
		[CellConfiguration(Position = new int[] { 32, 3 })] 
        public double MinimumAccumulatorVolumeTool1 { get; set; }
		
		
		//Cartouche Actuator Key characteristics Tool2 output
		
		//Power lane
		[CellConfiguration(Position = new int[] { 16, 4 })] 
        public string ActuatorTypeTool2 { get; set; } //(balanced/unbalanced sections)
		[CellConfiguration(Position = new int[] { 17, 4 })] 
        public double RodDiameterTool2 { get; set; }
		[CellConfiguration(Position = new int[] { 18, 4 })] 
        public double PistonDiameterTool2 { get; set; }
 
		//Attachments
		[CellConfiguration(Position = new int[] { 21, 4 })] 
        public string TypeRodEndTool2 { get; set; } //(male/femelle)
		[CellConfiguration(Position = new int[] { 22, 4 })] 
        public string StructureBearingTypeTool2 { get; set; } //(auto lub, roller)
		[CellConfiguration(Position = new int[] { 23, 4 })] 
        public string SurfaceBearingTypeTool2 { get; set; } //(auto lub, roller)
 
		[CellConfiguration(Position = new int[] { 25, 4 })] 
        public double SelectedTubeDiameterTool2 { get; set; }
 
		//Servovalve
		[CellConfiguration(Position = new int[] { 28, 4 })] 
        public double EHSVMinFlowTool2 { get; set; }

		//Acumulator
		[CellConfiguration(Position = new int[] { 31, 4 })] 
        public double MinimumAcumulatorPressureTool2 { get; set; }
		[CellConfiguration(Position = new int[] { 32, 4 })] 
        public double MinimumAccumulatorVolumeTool2 { get; set; }
	}*/
	
	/// <summary>
	/// Activities_planning.xlsx
	/// Feuille Action list
	/// </summary>
	[BusinessClass(BaseUri = "http://xowl.org/activitiesplanning/action#",Position = "Action list")]
    public class ActionList : Identifiable
    {
        [CellConfiguration(CellsAfter = 5)]
        public string Numero { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
		public string TargetDate { get; set; }
		public string Status { get; set; } //enum {"Not Started","On going","Bocked","Closed"}
    }
}
