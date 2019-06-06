using xOwl_Annotations;
using xOwl_Excel_Connector;

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

    [BusinessClass(BaseUri = "http://xowl.org/specparam#", IsComplex = true, Position = "Paramètre spec")]
    public class SpecParameter : Identifiable
    {
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


		[CellConfiguration(Position = new int[] { 36, 5 })]
        public double PressionAlimentationNominale { get; set; }
        [CellConfiguration(Position = new int[] { 37, 5 })]
        public double PressionRetourNominale { get; set; }
        [CellConfiguration(Position = new int[] { 39, 5 })]
        public double PressionAlimentationDimensionnmentSV { get; set; }
        [CellConfiguration(Position = new int[] { 40, 5 })]
        public double PressionRetourDimensionnementSV { get; set; }

		[CellConfiguration(Position = new int[] { 44, 5 })]
        public double TemperatureFluide { get; set; }
        [CellConfiguration(Position = new int[] { 45, 5 })]
        public double TemperatureReferenceFluide1 { get; set; }
        [CellConfiguration(Position = new int[] { 46, 5 })]
        public double TemperatureReferenceFluide2 { get; set; }

        [CellConfiguration(Position = new int[] { 49, 5 })]
        public double AccumulateurTemperatureMinimaleVariationsVolume { get; set; }
        [CellConfiguration(Position = new int[] { 50, 5 })]
        public double AccumulateurTemperatureMaximaleVariationsVolume { get; set; }
        [CellConfiguration(Position = new int[] { 51, 5 })]
        public double AccumulateurDureeCompenserFuitesExternes { get; set; }

    }


    [BusinessClass(BaseUri = "http://xowl.org/sectionverin#", IsComplex = true, Position = "section vérin")]
    public class SectionVerin : Identifiable
    {
    	[CellConfiguration(Position = new int[] { 18, 5 })]
        public double FrottementsJointsEstimes { get; set; }
        [CellConfiguration(Position = new int[] { 19, 5 })]
        public double DpOuvertureClapetIsolementRetour { get; set; }
        [CellConfiguration(Position = new int[] { 20, 5 })]
        public double DiametreTige { get; set; }

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


	[BusinessClass(BaseUri = "http://xowl.org/sectionblochyd#", IsComplex = true, Position = "section bloc hyd")]
    public class SectionBlocHyd : Identifiable
    {
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

		[CellConfiguration(Position = new int[] { 33, 3 })]
        public double SectionEquivalenteBloc { get; set; }
        [CellConfiguration(Position = new int[] { 34, 3 })]
        public double DebitPointPerformance { get; set; }
        [CellConfiguration(Position = new int[] { 35, 3 })]
        public double PerteChargeBlocPointPerformance { get; set; }

    }

    [BusinessClass(BaseUri = "http://xowl.org/ehsv#", IsComplex = true, Position = "EHSV")]
    public class EHSV : Identifiable
    {

		[CellConfiguration(Position = new int[] { 25, 3 })]
        public double AmortissementMaximalPerfos { get; set; }
		
		[CellConfiguration(Position = new int[] { 27, 3 })]
        public double PressionMoyenneBlocHydraulique { get; set; }

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

		[CellConfiguration(Position = new int[] { 54, 3 })]
        public double DeltaPDisponible { get; set; }

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


		[CellConfiguration(Position = new int[] { 71, 3 })]
        public double RepartionPertesChargeChargeAaerodynamiquePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 72, 3 })]
        public double RepartionPertesChargeServovalvePoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 73, 3 })]
        public double RepartionPertesChargeBlocHydrauliquePoint1 { get; set; }

		[CellConfiguration(Position = new int[] { 71, 4 })]
        public double RepartionPertesChargeChargeAaerodynamiquePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 72, 4 })]
        public double RepartionPertesChargeServovalvePoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 73, 4 })]
        public double RepartionPertesChargeBlocHydrauliquePoint2 { get; set; }

        [CellConfiguration(Position = new int[] { 71, 5 })]
        public double RepartionPertesChargeChargeAaerodynamiquePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 72, 5 })]
        public double RepartionPertesChargeServovalvePoint3 { get; set; }
        [CellConfiguration(Position = new int[] { 73, 5 })]
        public double RepartionPertesChargeBlocHydrauliquePoint3 { get; set; }
    }

	[BusinessClass(BaseUri = "http://xowl.org/accumulateur#", IsComplex = true, Position = "Accumulateur")]
    public class Accumulateur : Identifiable
    {

		[CellConfiguration(Position = new int[] { 21, 3 })]
        public double LongueurPercagesBloc { get; set; }
        [CellConfiguration(Position = new int[] { 22, 3 })]
        public double CoefficientDilatationThermiqueFluide { get; set; }

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

		[CellConfiguration(Position = new int[] { 30, 1 })]
        public int FuitesStatiquesGouttes { get; set; }
        [CellConfiguration(Position = new int[] { 30, 3 })]
        public int FuitesStatiquesSecondes { get; set; }

        [CellConfiguration(Position = new int[] { 39, 3 })]
        public int ResFuitesDynNombreCycles { get; set; }
        [CellConfiguration(Position = new int[] { 40, 3 })]
        public int ResFuitesDynNombreGouttes { get; set; }
        [CellConfiguration(Position = new int[] { 41, 3 })]
        public int ResFuitesDynVolumeFuitesDynamiques { get; set; }

        [CellConfiguration(Position = new int[] { 43, 3 })]
        public int ResFuitesStatiquesNombreGouttes { get; set; }
        [CellConfiguration(Position = new int[] { 44, 3 })]
        public int ResFuitesStatiquesVolumeFuitesStatiques { get; set; }
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


	[BusinessClass(BaseUri = "http://xowl.org/courbeseffortvitesse#", IsComplex = true, Position = "Courbes effort vitesse")]
    public class CourbesEffortVitesse : Identifiable
    {
    	[CellConfiguration(Position = new int[] { 24, 4 })]
        public double CoefficientAmortissementNominal { get; set; }
        [CellConfiguration(Position = new int[] { 27, 4 })]
        public double SectionEquivalenteServovalve { get; set; }

		[CellConfiguration(Position = new int[] { 36, 4 })]
        public double ResultatsSCseuleSectionEquivalentBlocServovalveNominal { get; set; }

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

        [CellConfiguration(Position = new int[] { 40, 5 })]
        public double ResultatsSCseuleAmortissementNominalPoint1 { get; set; }
        [CellConfiguration(Position = new int[] { 41, 5 })]
        public double ResultatsSCseuleAmortissementNominalPoint2 { get; set; }
        [CellConfiguration(Position = new int[] { 42, 5 })]
        public double ResultatsSCseuleAmortissementNominalPoint3 { get; set; }
		


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


		[CellConfiguration(Position = new int[] { 75, 4 })]
        public double VitesseChocEnButeeSectionEquivalentBlocServovalve { get; set; }
        [CellConfiguration(Position = new int[] { 76, 4 })]
        public double VitesseChocEnButeeDeltaPMmax { get; set; }
        [CellConfiguration(Position = new int[] { 77, 4 })]
        public double VitesseChocEnButeeVitesseMaxTmaxQmaxEHSV { get; set; }

		[CellConfiguration(Position = new int[] { 81, 3 })]
        public double EffortVitesseServovalveMaxiKamoMiniErreur { get; set; }
        [CellConfiguration(Position = new int[] { 82, 3 })]
        public double EffortVitesseServovalveMaxiKamoMiniVitesse { get; set; }
        [CellConfiguration(Position = new int[] { 83, 3 })]
        public double EffortVitesseServovalveMaxiKamoMiniEffort { get; set; }

    }




}
