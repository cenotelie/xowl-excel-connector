using xOwl_Annotations;
using xOwl_Excel_Connector;

/// <summary>
/// Business Data
/// </summary>
namespace BusinessData
{
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
    }
	
	
	/// <summary>
	/// Aileron_static_perfo_TBS.xls
	/// Feuille Paramètre spec
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/specparam#", IsComplex = true, Position = "Paramètre spec")]
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
    [BusinessClass(BaseUri = "http://xowl.org/sectionverin#", IsComplex = true, Position = "section vérin")]
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
	/// Spec EHSA.xslx
	/// Feuille Feuil1
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/specehsa#", IsComplex = true, Position = "Feuil1")]
    public class SpecEHSA : Identifiable
    {
		/*
		Section 1 ACTUATOR APPLICATION
		*/
    	[CellConfiguration(Position = new int[] { 4, 4 })]
        public string AircraftType { get; set; }
        [CellConfiguration(Position = new int[] { 5, 4 })]
        public string System { get; set; }
		
		/*
		Section 2 SPACE ENVELOP and WEIGHT
		*/
    	[CellConfiguration(Position = new int[] { 7, 4 })] //Format "(Length, Width, Height)" en (mm mm mm)
        public string SpaceEnvelop { get; set; }
        [CellConfiguration(Position = new int[] { 8, 4 })]
        public double DistanceBetweenAttachments { get; set; }
		[CellConfiguration(Position = new int[] { 9, 4 })]
        public double MaximumWeight { get; set; }
 
		/*
		Section 3 FUNCTIONAL REQUIREMENTS
		*/
    	[CellConfiguration(Position = new int[] { 11, 4 })] 
        public string ActuatorModes { get; set; }
        [CellConfiguration(Position = new int[] { 12, 4 })]
        public string ControlInterface { get; set; }
		[CellConfiguration(Position = new int[] { 13, 4 })]
        public string ControlSignalMagnitude { get; set; } //Format " +/- 8" en (mA) ?
		
		/*
		Section 4 PERFORMANCE
		*/
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
        public double MaximumRunUpTime { get; set; } //int suffisant?
		
		/*
		Section 5 DUTY CYCLE
		*/
    	[CellConfiguration(Position = new int[] { 32, 4 })] 
        public double UsefulLife { get; set; } //int suffisant?
        [CellConfiguration(Position = new int[] { 33, 4 })]
        public string EquivalentPermanentCycle { get; set; } //Format sine 1Hz +/- 2mm
		[CellConfiguration(Position = new int[] { 34, 4 })]
        public double PermanentLoad { get; set; } //int suffisant?

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
        public int NombreDActionneurParSurface { get; set; } 
		[CellConfiguration(Position = new int[] { 8, 3 })]
        public int DimensionnementEnFatigue { get; set; } 
		
		/*
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
		
		/*
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
		*/
		
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
		
		/*
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
		*/
		
	}
	
	/// <summary>
	/// Power_ram_sizing.xlsx
	/// Feuille Donnees Partie Validation 
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/powerramsizing/validationdonnees#", IsComplex = true, Position = "Donnees")]
    public class PowerRamSizingValidationDonnees : Identifiable
    {
		/*
		Cartouche Données générales
		*/
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
		
		/*
		Cartouche Données plan d'encombrement
		*/
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
		/*
		Cartouche Données dimensionnement en statique
		*/
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
		
	}
	
	/// <summary>
	/// Power_ram_sizing.xlsx
	/// Feuille Donnees Partie Source 
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/powerramsizing/sourcesdonnees#", IsComplex = true, Position = "Donnees")]
    public class PowerRamSizingSourceDonnees : Identifiable
    {
		/*
		Cartouche Données générales
		*/
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
		
		/*
		Cartouche Données plan d'encombrement
		*/
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
		
		/*
		Cartouche Données dimensionnement en statique
		*/
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
		
	}

	/// <summary>
	/// Power_ram_sizing.xlsx
	/// Feuille Donnees Partie Commentaires 
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/powerramsizing/commentairesdonnees#", IsComplex = true, Position = "Donnees")]
    public class PowerRamSizingCommentairesDonnees : Identifiable
    {
		/*
		Cartouche Données générales
		*/
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
		
		/*
		Cartouche Données plan d'encombrement
		*/
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
		/*
		Cartouche Données dimensionnement en statique
		*/
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
		
	}
	
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
    [BusinessClass(BaseUri = "http://xowl.org/kdd/kdd#", IsComplex = true, Position = "KDD")]
    public class KDD : Identifiable
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
		Cartouche KDD Aileron
		*/
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
		
		/*
		Cartouche Reference  documents
		*/
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
	}
	
	/// <summary>
	/// KDD.xlsm
	/// Feuille Actuator Key characteristics
	/// </summary>
    [BusinessClass(BaseUri = "http://xowl.org/kdd/actuatorkeycharacteristics#", IsComplex = true, Position = "Actuator Key characteristics")]
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

		/*
		Cartouche Actuator Key characteristics Tool1 output
		*/
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
		
		/*
		Cartouche Actuator Key characteristics Tool2 output
		*/
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
	}
	
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
