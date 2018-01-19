using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;
using System;
using Unitycoding.LoginSystem;

public class MenuOptions : MonoBehaviour
{
    System.DateTime time = System.DateTime.Now;
    public GameObject TestFindingsButton;
    public GameObject ComputerSceneTwoDateGroup;
    public GameObject ComputerSceneThreeDateGroup;
    public GameObject ComputerTwoBackButton;
    public GameObject ComputerThreeBackButton;
    public GameObject phase5WeightEvaluationSaved02Text;
    public GameObject phase5WeightEvaluationSaved03Text;
    public GameObject phase5BodyWeightUsualWeightInputGroup;
    public GameObject Phase5AnalyseDietTranscribeText;
    public GameObject Phase5EnergyAndNutrientsTranscribeText;
    public GameObject Phase5EnergyActualTranscribeText;
    public GameObject BMICalculatorGroup;
    public GameObject weightChangeCalculatorGroup;
    public GameObject physicalExamButton;
    public GameObject PresentFindingsButton;
    public GameObject AssessmentFormGroup;
    public GameObject AdmissionFormGroup;
    public GameObject ProgressNotesPage1Group;
    public GameObject ProgressNotesPage2Group;
    public GameObject Phase3CompletionInfoGroup;
    public GameObject rayCastBlockImage;
    public GameObject ClinpadRayCastBlockImage;
    public GameObject biochemicalCorrectAnswer01Text;
    public GameObject biochemicalCorrectAnswer02Text;
    public GameObject clientHistoryCorrectAnswer00Text;
    public GameObject clientHistoryCorrectAnswer01Text;
    public GameObject clientHistoryCorrectAnswer02Text;
    public GameObject clientHistoryCorrectAnswer03Text;
    public GameObject clientHistoryCorrectAnswer04Text;
    public GameObject clientHistoryCorrectAnswer05Text;
    public GameObject clientHistoryCorrectAnswer06Text;
    public GameObject clientHistoryCorrectAnswer07Text;
    public GameObject clientHistoryCorrectAnswer08Text;
    public GameObject clientHistoryCorrectAnswer09Text;
    public GameObject clientHistoryCorrectAnswer10Text;
    public GameObject clientHistoryCorrectAnswer11Text;
    public GameObject clientHistoryCorrectAnswer12Text;
    public GameObject clientHistoryCorrectAnswer13Text;
    public GameObject clientHistoryCorrectAnswer14Text;
    public GameObject clientHistoryCorrectAnswer15Text;
    public GameObject clientHistoryCorrectAnswer16Text;
    public GameObject clientHistoryCorrectAnswer17Text;
    public GameObject clientHistoryCorrectAnswer18Text;
    public GameObject clientHistoryCorrectAnswer19Text;
    public GameObject clientHistoryCorrectAnswer20Text;
    public GameObject clientHistoryCorrectAnswer21Text;
    public GameObject clientHistoryCorrectAnswer22Text;
    public GameObject clientHistoryCorrectAnswer23Text;
    public GameObject clientHistoryCorrectAnswer24Text;
    public GameObject clientHistoryCorrectAnswer25Text;
    public GameObject clientHistoryCorrectAnswer26Text;
    public GameObject clientHistoryCorrectAnswer27Text;
    public GameObject clientHistoryCorrectAnswer28Text;
    public GameObject clientHistoryCorrectAnswer29Text;
    public GameObject clientHistoryCorrectAnswer30Text;
    public GameObject clientHistoryCorrectAnswer31Text;
    public GameObject clientHistoryCorrectAnswer32Text;
    public GameObject clientHistoryCorrectAnswer33Text;
    public GameObject clientHistoryCorrectAnswer34Text;
    public GameObject clientHistoryCorrectAnswer35Text;
    public GameObject phase4SavedText01;
    public GameObject phase4SavedText02;
    public GameObject phase4SavedText03;
    public GameObject phase4SavedText04;
    public GameObject phase4SavedText05;
    public GameObject phase4SavedText06;
    public GameObject phase4SavedText07;
    public GameObject phase4SavedText08;
    public GameObject phase4SavedText09;
    public GameObject phase4SavedText10;
    public GameObject phase4SavedText11;
    public GameObject phase4SavedText12;
    public GameObject phase4SavedText13;
    public GameObject phase4SavedText14;
    public GameObject phase4SavedText15;
    public GameObject phase4SavedText16;
    public GameObject phase4SavedText17;
    public GameObject phase4SavedText18;
    public GameObject phase4SavedText19;
    public GameObject phase4SavedText20;
    public GameObject foodAndNutritionCorrectAnswer01Text;
    public GameObject foodAndNutritionCorrectAnswer02Text;
    public GameObject foodAndNutritionCorrectAnswer03Text;
    public GameObject foodAndNutritionCorrectAnswer04Text;
    public GameObject foodAndNutritionCorrectAnswer05Text;
    public GameObject foodAndNutritionCorrectAnswer06Text;
    public GameObject phaseTwoInteractiveButtonGroup;
    public GameObject phaseFourInteractiveButtonGroup;
    public GameObject phase5MultipleChoiceButtonGroup;
    public GameObject phase5AnalyseDietMultipleChoice01ButtonGroup;
    public GameObject phase5AnalyseDietMultipleChoice02ButtonGroup;
    public GameObject Phase5AnalyseDietFinalDecisionButtonGroup;
    public GameObject phase5EnergyAndNutrientsMultipleChoice01ButtonGroup;
    public GameObject phase5EnergyAndNutrientsMultipleChoice02ButtonGroup;
    public GameObject Phase5EnergyAndNutrientsFinalDecisionButtonGroup;
    public GameObject phase5EnergyActualMultipleChoice01ButtonGroup;
    public GameObject phase5EnergyActualWeightInputFieldGroup;
    public GameObject phase5EnergyActualMultipleChoice02ButtonGroup;
    public GameObject phase5EnergyActualMultipleChoice03ButtonGroup;
    public GameObject phase5EnergyActualMultipleChoice04ButtonGroup;
    public GameObject phase5EnergyActualFinalDecisionButtonGroup;
    public GameObject phase5BodyWeightMultipleChoice01ButtonGroup;
    public GameObject phase5BodyWeightMultipleChoice02ButtonGroup;
    public GameObject phaseFourAnthropometryInteractiveButtonGroup;
    public GameObject phaseFourClientHistoryInteractiveButtonGroup;
    public GameObject phaseFourMedicalHistoryInteractiveButtonGroup;
    public GameObject phaseFourNutritionInteractiveButtonGroup;
    public GameObject Phase4AnthropometryMultipleChoiceOption1;
    public GameObject Phase4AnthropometryMultipleChoiceOption2;
    public GameObject Phase4AnthropometryMultipleChoiceOption3;
    public GameObject Phase4ClientHistoryMultipleChoiceOption1;
    public GameObject Phase4ClientHistoryMultipleChoiceOption2;
    public GameObject Phase4ClientHistoryMultipleChoiceOption3;
    public GameObject Phase4MedicalHistoryMultipleChoiceOption1;
    public GameObject Phase4MedicalHistoryMultipleChoiceOption2;
    public GameObject Phase4MedicalHistoryMultipleChoiceOption3;
    public GameObject Phase4NutritionMultipleChoiceOption1;
    public GameObject Phase4NutritionMultipleChoiceOption2;
    public GameObject Phase4NutritionMultipleChoiceOption3;
    public GameObject phaseTwoStartInteractiveButtonGroup;
    public GameObject phaseTwoFoodAndNutritionInformationGroup;
    public GameObject biochemicalAnswersGroup;
    public GameObject medicationAnswersGroup;
    public GameObject anthropometryAnswersGroup;
    public GameObject patientInvestigationSceneGroup;
    public GameObject FoodGroupResourceGroup;
    public GameObject ReadyReckonerResourceGroup;
    public GameObject SGAFormGroup;
    public GameObject SGAFormButtonGroup;
    public GameObject ClinPadTranscribeGroup;
    public GameObject ClinPadProgressGroup;
    public GameObject ClinPadChartGroup;
    public GameObject observationsAnswerGroup;
    public GameObject ClipboardButtonGroup;
    public GameObject MedicalClipboardButtonGroup;
    public GameObject NotesComputerGroup;
    public GameObject NotesInputBox;
    public GameObject NotesSavedText;
    public GameObject ComputerSceneBackButton;
    public GameObject Phase3InputBox;
    public GameObject Phase3SavedText;
    public GameObject ClinPadNutritionalRequirementsButton;
    public GameObject TranscribeAnthropometryGroup;
    public GameObject TranscribeBiochemicalGroup;
    public GameObject TranscribeClientHistoryGroup;
    public GameObject TranscribeFoodAndNutritionGroup;
    public GameObject TranscribeNutritionDiagnosisGroup;
    public GameObject TranscribeInterventionPlanGroup;
    public GameObject TranscribeMonitoringAndEvaluationGroup;
    public GameObject InvestigationButton;
    public GameObject PatientInformationAge;
    public GameObject PatientInformationGender;
    public GameObject Phase2BiochemicalClinpadText01;
    public GameObject Phase2BiochemicalClinpadText02;
    public GameObject Phase6PartSelectionGameObject01;
    public GameObject Phase6PartSelectionGameObject02;
    public GameObject Phase6PartSelectionGameObject03;
    public GameObject Phase6PartSelectionGameObject04;
    public GameObject Phase6PartSelectionGameObject05;
    public GameObject Phase6PartSelectionGameObject06;
    public GameObject Phase6PartSelectionGameObject07;
    public GameObject Phase6PartSelectionGameObject08;
    public GameObject Phase6PartSelectionGameObject09;
    public GameObject Phase6PartSelectionGameObject10;
    public GameObject Phase6PartSelectionGameObject11;
    public GameObject Phase6Part2SelectionGameObject01;
    public GameObject Phase6Part2SelectionGameObject02;
    public GameObject Phase6Part2SelectionGameObject03;
    public GameObject Phase6Part2SelectionGameObject04;
    public GameObject Phase6Part2SelectionGameObject05;
    public GameObject Phase6Part2SelectionGameObject06;
    public GameObject Phase6Part4SelectionGameObject01;
    public GameObject Phase6Part4SelectionGameObject02;
    public GameObject Phase6Part4SelectionGameObject03;
    public GameObject Phase6Part4SelectionGameObject04;
    public GameObject Phase6Part4SelectionGameObject05;
    public GameObject Phase6Part4SelectionGameObject06;
    public GameObject Phase6Part3DropZone01;
    public GameObject Phase6Part3DropZone02;
    public GameObject Phase6Part3DropZone03;
    public GameObject Phase6Part3DropZone04;
    public GameObject Phase6Part3DropZone05;
    public GameObject Phase6Part3DropZone06;
    public GameObject Phase07Part03DropZone01;
    public GameObject Phase07Part03DropZone02;
    public GameObject Phase07Part03DropZone03;
    public GameObject Phase07Part03DropZone04;
    public GameObject Phase07Part03DropZone05;
    public GameObject Phase07Part03DropZone06;
    public GameObject Phase07Part03DropZone08;
    public GameObject Phase07Part03DropZone09;
    public GameObject Phase07Part03DropZone10;
    public GameObject Phase07Part03DropZone11;
    public GameObject Phase07Part03DropZone12;
    public GameObject Phase07Part03DropZone13;
    private List<string> Phase06Part03CausesStringArray = new List<string>();
    private List<string> Phase06Part03IncorrectCauseSelectedStringArray = new List<string>();
    public List<string> Phase3InputTextStringArray = new List<string>();
    public List<string> Phase2MedicationIncorrectStringArray = new List<string>();
    [SerializeField]
    private List<GameObject> Phase6PartOneToTwoSelectionGameObjectArray = new List<GameObject>();
    [SerializeField]
    private List<GameObject> Phase6PartTwoToThreeSelectionGameObjectArray = new List<GameObject>();
    [SerializeField]
    private List<GameObject> Phase6PartThreeToFourSelectionGameObjectArray = new List<GameObject>();
    [SerializeField]
    private List<GameObject> Phase6PartThreeDropZonesArray = new List<GameObject>();
    [SerializeField]
    private List<GameObject> Phase07Part03DropZoneArray = new List<GameObject>();
    public string[] phase3AcceptedPhrases;
    public GameObject[] phase6Part03EvidenceOptions;
    public GameObject[] phase07Part03EvidenceOptions;
    public GameObject[] medicalHistoryNameReferences;
    [SerializeField]
    private Transform[] Phase6PartTwoSelectionTransforms;
    [SerializeField]
    private Transform[] Phase6PartThreeSelectionTransforms;
    [SerializeField]
    private string[] Phase03FeedingAbilityStringArray;
    [SerializeField]
    private string[] Phase03FoodIntakeStringArray;
    [SerializeField]
    private string[] Phase03NutritionFocusedPhysicalStringArray;
    [SerializeField]
    private string[] Phase03AnthropometricMeasurementsStringArray;
    [SerializeField]
    private string[] Phase03ClientHistoryStringArray;
    public GameObject phaseThreePresentFindingsInputGroup;
    public GameObject TranscribeNutitionDiagnosisTabButton;
    public GameObject TranscribeInterventionPlanTabButton;
    public GameObject TranscribeMonitoringAndEvaluationTabButton;
    public GameObject ClinpadButton;
    public GameObject Phase1ProgressGroup;
    public GameObject Phase2ProgressGroup;
    public GameObject Phase3ProgressGroup;
    public GameObject Phase4ProgressGroup;
    public GameObject Phase5ProgressGroup;
    public GameObject Phase6ProgressGroup;
    public GameObject Phase7ProgressGroup;
    public GameObject Phase8ProgressGroup;
    public GameObject SGAFormButton;
    public Animator ClinpadHelperAnim;
    public Animator alertMessageToggleAnim;
    public Animator receivedItemMessageToggleAnim;
    public Animator clinPadAnim;
    public Animator buttonToggleAnim;
    public Animator menuToggleAnim;
    public Animator helpToggleAnim;
    public Animator hintToggleAnim;
    public Animator biochemicalWhyCorrectAnswerAnim;
    public Animator logoutToggleAnim;
    public Animator DieticianSceneAnim;
    public Animator NurseSceneAnim;
    public Animator HospitalSceneAnim;
    public Animator InvestigationSceneAnim;
    public Animator ComputerSceneAnim;
    public Animator ComputerSceneTwoAnim;
    public Animator ComputerSceneThreeAnim;
    public Animator ClipboardSceneAnim;
    public Animator MedicalClipboardSceneAnim;
    public Animator SGASceneAnim;
    public Animator ChatRightAnim;
    public Animator ChatLeftAnim;
    public Animator ChatLeftTwoAnim;
    public Animator ChatRightTwoAnim;
    public Animator ChatRightThreeAnim;
    public Animator ChatRightLargeAnim;
    public Animator BiochemicalWhyAnswerAnim;
    public Animator BicepScrollSnapAnim;
    public Animator CalfScrollSnapAnim;
    public Animator ClavicleScrollSnapAnim;
    public Animator EyeScrollSnapAnim;
    public Animator HandScrollSnapAnim;
    public Animator KneeScrollSnapAnim;
    public Animator ShoulderScrollSnapAnim;
    public Animator TempleScrollSnapAnim;
    public Animator TricepScrollSnapAnim;
    public Animator NutrionalRequirementsAnim;
    public Animator NotificationMessageBoxAnim;
    public Animator Phase2MedicationMessageBoxAnim;
    public Animator PlayerNamePromptAnim;
    public Animator ContextSensitiveClinpadHelperAnim;
    public Animator ContextSensitiveNextChatHelperAnim;
    public Animator ContextSensitiveNavigationHelperAnim;
    public Animator ContextSensitiveBackToDietitianHelperAnim;
    public Animator PhaseReachedAnim;
    public Animator Phase5BodyWeightAlertMessageGroup;
    public Animator Phase6Part01Group;
    public Animator Phase6Part02Group;
    public Animator Phase6Part03Group;
    public Animator Phase6Part04Group;
    public Animator Phase6Part05Group;
    public Animator Phase6PartOneAlertMessageGroupAnim;
    public Animator BMICalculatorAlertMessageGroupAnim;
    public Slider soundVolumeSlider;
    public Dropdown BMICalculatorSymbolDropdown;
    public InputField playerNamePromptInputField;
    public InputField BMICalculatorHeightInputField;
    public InputField BMICalculatorWeightInputField;
    public InputField WeightChangeCalculatorTypicalWeightInputField;
    public InputField WeightChangeCalculatorCurrentWeightInputField;
    public InputField Phase5BodyCurrentWeightInputField;
    public InputField Phase5BodyUsualWeightInputField;
    public Text BMICalculatorAlertMessageGroupText;
    public Text phase5WeightEvaluationPartThreeUpdatingText;
    public Text Phase5WeightEvaluationAlertMessageText;
    public Text phase5WeightEvaluationSavedText;
    public Text WeightChangeresult;
    public Text totalProgressAmountText;
    public Text BMICalculatorResult;
    public Text playerNamePromptInfoText;
    public Text playerNameClinPadText;
    public Text notificationButtonText;
    public Text notificationInformationText;
    public Text PatientInformationAnswerOneText;
    public Text MedicalHistoryAnswerOneText;
    public Text MedicalHistoryAnswerTwoText;
    public Text MedicalHistoryAnswerThreeText;
    public Text MedicalHistoryAnswerFourText;
    public Text MedicalHistoryAnswerFiveText;
    public Text MedicalHistoryAnswerSixText;
    public Text MedicalHistoryAnswerSevenText;
    public Text MedicalHistoryAnswerEightText;
    public Text MedicalHistoryAnswerNineText;
    public Text MedicalHistoryAnswerFifteenText;
    public Text MedicalHistoryAnswerSeventeenText;
    public Text MedicalHistoryAnswerTwentyTwoText;
    public Text MedicalHistoryAnswerTwentyFourText;
    public Text MedicalHistoryAnswerTwentyFiveText;
    public Text TranscribeSelectedTabHeaderText;
    public Text ClinpadBMIInfo;
    public Text BMICalculatorCurrentHeight;
    public Text BMICalculatorCurrentWeight;
    public Text BMICalculatorCurrentSymbol;
    public Text WeightChangeCalculationText;
    public Text ProgressNotesDate01Text;
    public Text ProgressNotesDate02Text;
    public Text ProgressNotesDate03Text;
    public Text ProgressNotesDate04Text;
    public Text ProgressNotesDate05Text;
    public Text ProgressNotesDate06Text;
    public Text ProgressNotesDate07Text;
    public Text ProgressNotesDate08Text;
    public Text ProgressNotesDate09Text;
    public Text ProgressNotesDate10Text;
    public Text ObservationDate01Text;
    public Text ObservationDate02Text;
    public Text ObservationDate03Text;
    public Text MedicationAnswerOneText;
    public Text MedicationAnswerTwoText;
    public Text FoodAndNutritionAnswerOneText;
    public Text FoodAndNutritionAnswerTwoText;
    public Text FoodAndNutritionAnswerThreeText;
    public Text FoodAndNutritionAnswerFourText;
    public Text WeightRecordedClinpadText;
    public Text HeightRecordedClinpadText;
    public Text ChatNextButtonText;
    public Text ChatRightText;
    public Text ChatRightLargeText;
    public Text ChatRightTwoText;
    public Text ChatRightThreeText;
    public Text ChatLeftText;
    public Text ChatLeftTwoText;
    public Text ChatLeftNameText;
    public Text ChatLeftTwoNameText;
    public Text ChatRightNameText;
    public Text ChatRightLargeNameText;
    public Text ChatRightTwoNameText;
    public Text ChatRightThreeNameText;
    public Text HintText;
    public Text BiochemicalWhySelectionQuestionText;
    public Text BiochemicalWhyIncorrectAnswer01Text;
    public Text BiochemicalWhyIncorrectAnswer02Text;
    public Text ObservationButtonText;
    public Text NotesSavedButtonText;
    public Text FoodAndNutritionRightAnswer01SelectText;
    public Text FoodAndNutritionRightAnswer02SelectText;
    public Text FoodAndNutritionRightAnswer03SelectText;
    public Text FoodAndNutritionRightAnswer04SelectText;
    public Text FoodAndNutritionWrongAnswer01SelectText;
    public Text FoodAndNutritionWrongAnswer02SelectText;
    public Text Phase3CompletionInfoGroupText;
    public Text Phase2SubmitFeedbackText;
    public Text Phase2SubmitFeedbackHeaderText;
    public Text Phase2SubmitIncorrectFeedbackListText;
    public Text PhaseReachedText;
    public Text Phase06EndText;
    private string phase5AnalyseDietCollatedText;
    private string phase5EnergyAndNutrientsCollatedText;
    private string dieteticSupervisorNameString = "John Browne - Dietetic Supervisor";
    private string nurseNameString = "Makenna Kumar - Registered Nurse";
    private string occupationalTherapistNameString = "Kenshin Buhari - Occupational Therapist";
    private string patientNameString = "Marta Haertman - Patient";
    private string playerNameString;
    public float defaultValue = 0.5f;
    private int Phase2DieticianFoodAndNutritionChatAnwersSelcted;
    private float weightValueAsFloat;
    private float patientActualWeight = 50;
    private int currentScene = 0;
    private int introConversationTracker = 0;
    private int Phase2DieticianConversationTracker = 0;
    private int Phase2NurseConversationTracker = 0;
    private int Phase2PatientConversationTracker = 0;
    private int Phase3PresentFindingsConversationTracker = 0;
    private int Phase4ConversationTracker = 0;
    private int Phase4PatientConversationTracker = 0;
    private int Phase5ConversationTracker = 0;
    private int Phase5DietitianConversationTracker = 10;
    private int Phase6ConversationTracker = 0;
    private int Phase7ConversationTracker = 0;
    private int Phase2SelectWrongAnswerBiochemicalScore;
    private int Phase2WhySelectWrongAnswerBiochemicalScore;
    private int Phase2SelectWrongAnswerMedicationScore;
    private int Phase2ComputerBiochemicalAnswersSelected;
    private int Phase6Part01SelectedAmount;
    private int Phase6Part02SelectedAmount;
    private int Phase6Part04SelectedAmount;
    private float Phase2BiochemicalAnswerSelected;
    private float Phase2BiochemicalAnswerTotal = 2;
    private int Phase2BiochemicalWhyAnswerSelected;
    private float Phase2MedicationAnswerSelected;
    private float phase2MedicationCorrectSelectedScore;
    private float phase2MedicationIncorrectSelectedScore;
    private float phase2MedicationFinalScore;
    private float Phase2MedicationCorrectAnswerTotal = 10;
    private float clientHistoryAnswersSelected;
    private float Phase2ClientHistoryAnswerTotal = 27;
    private float Phase2AnthropometryAnswerSelected;
    private float Phase2AnthropometryAnswerTotal = 3;
    private float foodAndNutritionAnswersSelected;
    private float Phase2FoodAndNutritionAnswerSelected;
    private float Phase2FoodAndNutritionAnswerTotal = 5;
    private float phase5SelectedScore;
    private float phase5Part1TotalScore = 7;
    private int BMIResultInt;
    private int Phase2SelectWrongAnswerMedicalHistoryScore;
    private int Phase2SelectWrongAnswerFoodAndNutritionScore;
    private int Phase3InputCheckScore;
    private int Phase3InputScoreTotal = 5;
    private int Phase4PatientInvestigationAnthropometryAnswersSelected = 0;
    private int gameStartConversationTracker = 0;
    private bool phase4Conversation0Done;
    private bool phase4Conversation1Done;
    private bool phase4Conversation2Done;
    private bool phase4Conversation3Done;
    private bool phase4Conversation4Done;
    private bool phase4Conversation5Done;
    private bool ClinpadHelperAnimationHasRun;
    private bool BMICalculated;
    private bool Phase2PatientHistoryCompleted;
    private bool Phase2AnthropometryCompleted;
    private bool Phase2BiochemicalCompleted;
    private bool Phase2ClientHistoryCompleted;
    private bool biochemicalCorrectAnswerSelected01;
    private bool biochemicalCorrectAnswerSelected02;
    private bool clientHistoryCorrectAnswerSelected00;
    private bool clientHistoryCorrectAnswerSelected01;
    private bool clientHistoryCorrectAnswerSelected02;
    private bool clientHistoryCorrectAnswerSelected03;
    private bool clientHistoryCorrectAnswerSelected04;
    private bool clientHistoryCorrectAnswerSelected05;
    private bool clientHistoryCorrectAnswerSelected06;
    private bool clientHistoryCorrectAnswerSelected07;
    private bool clientHistoryCorrectAnswerSelected08;
    private bool clientHistoryCorrectAnswerSelected09;
    private bool clientHistoryCorrectAnswerSelected10;
    private bool clientHistoryCorrectAnswerSelected11;
    private bool clientHistoryCorrectAnswerSelected12;
    private bool clientHistoryCorrectAnswerSelected13;
    private bool clientHistoryCorrectAnswerSelected14;
    private bool clientHistoryCorrectAnswerSelected15;
    private bool clientHistoryCorrectAnswerSelected16;
    private bool clientHistoryCorrectAnswerSelected17;
    private bool clientHistoryCorrectAnswerSelected18;
    private bool clientHistoryCorrectAnswerSelected19;
    private bool clientHistoryCorrectAnswerSelected20;
    private bool clientHistoryCorrectAnswerSelected21;
    private bool clientHistoryCorrectAnswerSelected22;
    private bool clientHistoryCorrectAnswerSelected23;
    private bool clientHistoryCorrectAnswerSelected24;
    private bool clientHistoryCorrectAnswerSelected25;
    private bool clientHistoryCorrectAnswerSelected26;
    private bool foodAndNutritionCorrectAnswerSelected01;
    private bool foodAndNutritionCorrectAnswerSelected02;
    private bool foodAndNutritionCorrectAnswerSelected03;
    private bool foodAndNutritionCorrectAnswerSelected04;
    private bool foodAndNutritionCorrectAnswerSelected05;
    private bool phase2MedicationsCorrectSelected01;
    private bool phase2MedicationsCorrectSelected02;
    private bool phase2MedicationsCorrectSelected03;
    private bool phase2MedicationsCorrectSelected04;
    private bool phase2MedicationsCorrectSelected05;
    private bool phase2MedicationsCorrectSelected06;
    private bool phase2MedicationsCorrectSelected07;
    private bool phase2MedicationsCorrectSelected08;
    private bool phase2MedicationsCorrectSelected09;
    private bool phase2MedicationsCorrectSelected10;
    private bool phase2MedicationsIncorrectSelected01;
    private bool phase2MedicationsIncorrectSelected02;
    private bool phase2MedicationsIncorrectSelected03;
    private bool phase2MedicationsIncorrectSelected04;
    private bool phase2MedicationsIncorrectSelected05;
    private bool phase2MedicationsIncorrectSelected06;
    private bool phase2MedicationsIncorrectSelected07;
    private bool phase2MedicationsIncorrectSelected08;
    private bool phase2MedicationsIncorrectSelected09;
    private bool phase2MedicationsIncorrectSelected10;
    private bool Phase2FoodAndNutritionCompleted;
    private bool Phase4PatientInvestigationAnthropometryAnswer01HasBeenSelected;
    private bool Phase4PatientInvestigationAnthropometryAnswer02HasBeenSelected;
    private bool Phase4PatientInvestigationAnthropometryAnswer03HasBeenSelected;
    private bool inChat;
    private bool canInvestigate;
    private bool canMedicalHistory;
    private bool inInvestigation;
    private bool canComputer;
    private bool canAnthropometry;
    private bool inComputer;
    private bool inComputerTwo;
    private bool inComputerThree;
    private bool notesSaved;
    private bool inClipboard;
    private bool inMedicalChart;
    private bool inClipboardObservation;
    private bool inSGAForm;
    private bool hasFoodAndNutritionInformation;
    private bool Phase2BiochemicalAnswer01HasBeenSelected;
    private bool Phase2BiochemicalWhyAnswerHasBeenSelected;
    private bool Phase2BiochemicalAnswer02HasBeenSelected;
    private bool Phase2BiochemicalAnswer03HasBeenSelected;
    private bool Phase2BiochemicalAnswer04HasBeenSelected;
    private bool Phase2BiochemicalWrongAnswer01HasBeenSelected;
    private bool Phase2BiochemicalWrongAnswer02HasBeenSelected;
    private bool Phase2BiochemicalWrongAnswer03HasBeenSelected;
    private bool Phase2BiochemicalWrongAnswer04HasBeenSelected;
    private bool Phase2BiochemicalWrongAnswer05HasBeenSelected;
    private bool Phase2BiochemicalWrongAnswer06HasBeenSelected;
    private bool Phase2BiochemicalWrongAnswer07HasBeenSelected;
    private bool Phase2BiochemicalWrongAnswer08HasBeenSelected;
    private bool Phase2MedicationAnswer01HasBeenSelected;
    private bool Phase2MedicationAnswer02HasBeenSelected;
    private bool Phase2MedicationAnswer03HasBeenSelected;
    private bool Phase2MedicationAnswer04HasBeenSelected;
    private bool Phase2MedicationAnswer05HasBeenSelected;
    private bool Phase2MedicationAnswer06SHasBeenelected;
    private bool Phase2MedicationWrongAnswer01HasBeenSelected;
    private bool Phase2MedicationWrongAnswer02HasBeenSelected;
    private bool Phase2MedicationWrongAnswer03HasBeenSelected;
    private bool Phase2MedicationWrongAnswer04HasBeenSelected;
    private bool patientInformationAnswer01HasBeenSelected;
    private bool medicalHistoryAnswer01HasBeenSelected;
    private bool medicalHistoryAnswer02HasBeenSelected;
    private bool medicalHistoryAnswer03HasBeenSelected;
    private bool medicalHistoryAnswer04HasBeenSelected;
    private bool medicalHistoryAnswer05HasBeenSelected;
    private bool medicalHistoryAnswer06HasBeenSelected;
    private bool medicalHistoryAnswer07HasBeenSelected;
    private bool medicalHistoryAnswer08HasBeenSelected;
    private bool medicalHistoryAnswer09HasBeenSelected;
    private bool medicalHistoryAnswer10HasBeenSelected;
    private bool medicalHistoryAnswer11HasBeenSelected;
    private bool medicalHistoryAnswer12HasBeenSelected;
    private bool medicalHistoryAnswer13HasBeenSelected;
    private bool medicalHistoryAnswer14HasBeenSelected;
    private bool medicalHistoryAnswer15HasBeenSelected;
    private bool medicalHistoryAnswer16HasBeenSelected;
    private bool medicalHistoryAnswer17HasBeenSelected;
    private bool medicalHistoryAnswer18HasBeenSelected;
    private bool medicalHistoryAnswer19HasBeenSelected;
    private bool medicalHistoryAnswer20HasBeenSelected;
    private bool medicalHistoryAnswer21HasBeenSelected;
    private bool medicalHistoryAnswer22HasBeenSelected;
    private bool medicalHistoryAnswer23HasBeenSelected;
    private bool medicalHistoryAnswer24HasBeenSelected;
    private bool medicalHistoryAnswer25HasBeenSelected;
    private bool medicalHistoryWrongAnswer01HasBeenSelected;
    private bool medicalHistoryWrongAnswer02HasBeenSelected;
    private bool medicalHistoryWrongAnswer03HasBeenSelected;
    private bool medicalHistoryWrongAnswer04HasBeenSelected;
    private bool medicalHistoryWrongAnswer05HasBeenSelected;
    private bool medicalHistoryWrongAnswer06HasBeenSelected;
    private bool medicalHistoryWrongAnswer07HasBeenSelected;
    private bool medicalHistoryWrongAnswer07bHasBeenSelected;
    private bool medicalHistoryWrongAnswer07cHasBeenSelected;
    private bool medicalHistoryWrongAnswer08HasBeenSelected;
    private bool medicalHistoryWrongAnswer09HasBeenSelected;
    private bool medicalHistoryWrongAnswer10HasBeenSelected;
    private bool medicalHistoryWrongAnswer11HasBeenSelected;
    private bool medicalHistoryWrongAnswer12HasBeenSelected;
    private bool medicalHistoryWrongAnswer13HasBeenSelected;
    private bool medicalHistoryWrongAnswer14HasBeenSelected;
    private bool medicalHistoryWrongAnswer15HasBeenSelected;
    private bool medicalHistoryWrongAnswer16HasBeenSelected;
    private bool medicalHistoryWrongAnswer17HasBeenSelected;
    private bool medicalHistoryWrongAnswer18HasBeenSelected;
    private bool medicalHistoryWrongAnswer19HasBeenSelected;
    private bool medicalHistoryWrongAnswer20HasBeenSelected;
    private bool medicalHistoryWrongAnswer21HasBeenSelected;
    private bool medicalHistoryWrongAnswer22HasBeenSelected;
    private bool medicalHistoryWrongAnswer23HasBeenSelected;
    private bool medicalHistoryWrongAnswer24HasBeenSelected;
    private bool medicalHistoryWrongAnswer25HasBeenSelected;
    private bool medicalHistoryWrongAnswer26HasBeenSelected;
    private bool medicalHistoryWrongAnswer27HasBeenSelected;
    private bool medicalHistoryWrongAnswer28HasBeenSelected;
    private bool Phase2FoodAndNutritionAnswer01HasBeenSelected;
    private bool Phase2FoodAndNutritionAnswer02HasBeenSelected;
    private bool Phase2FoodAndNutritionAnswer03HasBeenSelected;
    private bool Phase2FoodAndNutritionAnswer04HasBeenSelected;
    private bool Phase2FoodAndNutritionWrongAnswer01HasBeenSelected;
    private bool Phase2FoodAndNutritionWrongAnswer02HasBeenSelected;
    private bool Phase3AllFindingsPresented;
    private bool alreadySpokenPhase4;
    private bool alreadySpokenPhase5;
    private bool readNutritionalDocument;
    private bool alreadyReachedPhase3;
    private bool phase5Part1Complete;
    private bool phase5Part2Complete;
    private bool phase5Part3Complete;
    private bool phase5Toggle01AlreadySelected;
    private bool phase5Toggle02AlreadySelected;
    private bool phase5Toggle03AlreadySelected;
    private bool phase5Toggle04AlreadySelected;
    private bool phase5Toggle05AlreadySelected;
    private bool phase5Toggle06AlreadySelected;
    private bool phase5Toggle07AlreadySelected;
    private bool phase5OverallAlreadySelected;
    private bool phase2Scene4HintShown;
    private bool phase2Scene5HintShown;
    private bool phase2Scene6HintShown;
    private bool autoHints = true;
    private bool phase7SpokenWithMarta;
    private bool phase7DietaryStrategies01OptionSelected;
    private bool phase7DietaryStrategies02OptionSelected;
    private bool phase7DietaryStrategies03OptionSelected;
    public Toggle MenuButton;
    public Toggle HintMenuButton;
    public Toggle HelpMenuButton;
    public Toggle NurseNavButton;
    public Toggle PatientNavButton;
    public Toggle DieticianNavButton;
    public Toggle ClinPadTranscribeButton;
    public Toggle ClinPadChartButton;
    public Toggle ClinPadProgressButton;
    public Button ChatNextButton;
    public Button ActivateChatButton;
    public Button ActivateInvestigationButton;
    public Button ActivateComputerButton;
    public Button ActivateAnthropometryButton;
    public Button ActivateMedicalHistoryButton;
    public Text ActivateChatButtonText;
    public Text ActivateInvestigationButtonText;
    public Text ActivateComputerButtonText;
    public Text ActivateAnthropometryButtonText;
    public Text ActivateMedicalHistoryButtonText;
    public Text currentPhaseText;
    public Image totalProgressFillImage;
    public Image currentPhaseProgressFillImage;
    public Image phase2AnthropometryProgressFillImage;
    public Image phase2BiochemicalProgressFillImage;
    public Image phase2ClientHistoryProgressFillImage;
    public Image phase2FoodAndNutritionProgressFillImage;
    public Image ChatTextLeftHeaderImage;
    public Image ChatTextLeftTwoHeaderImage;
    public Image ChatTextRightHeaderImage;
    public Image ChatTextRightTwoHeaderImage;
    public Image ChatTextRightThreeHeaderImage;
    public Image ChatTextRightLargeHeaderImage;
    public Image BiochemicalRightAnswer01SelectImage;
    public Image BiochemicalRightAnswer02SelectImage;
    public Image BiochemicalWrongAnswer01SelectImage;
    public Image BiochemicalWrongAnswer02SelectImage;
    public Image BiochemicalWrongAnswer03SelectImage;
    public Image BiochemicalWrongAnswer04SelectImage;
    public Image BiochemicalWrongAnswer05SelectImage;
    public Image BiochemicalWrongAnswer06SelectImage;
    public Image BiochemicalWrongAnswer07SelectImage;
    public Image BiochemicalWrongAnswer08SelectImage;
    public Image MedicationRightAnswer01SelectImage;
    public Image MedicationRightAnswer02SelectImage;
    public Image MedicationWrongAnswer01SelectImage;
    public Image MedicationWrongAnswer02SelectImage;
    public Image MedicationWrongAnswer03SelectImage;
    public Image MedicationWrongAnswer04SelectImage;
    public Image MedicalHistoryRightAnswer01SelectImage;
    public Image MedicalHistoryRightAnswer02SelectImage;
    public Image MedicalHistoryWrongAnswer01SelectImage;
    public Image MedicalHistoryWrongAnswer02SelectImage;
    public Image Phase3CompletionInfoGroupBackgroundImage;
    public Image Phase3CompletionInfoGroupAlertBackgroundImage;
    public Image Phase3CompletionImage;
    public Image Phase2SubmitCheckBackgroundImage;
    public Image Phase2SubmitCheckFeedbackImage;
    public Image phase6Part01Selection01SelectImage;
    public Image phase6Part01Selection02SelectImage;
    public Image phase6Part01Selection03SelectImage;
    public Image phase6Part01Selection04SelectImage;
    public Image phase6Part01Selection05SelectImage;
    public Image phase6Part01Selection06SelectImage;
    public Image phase6Part01Selection07SelectImage;
    public Image phase6Part01Selection08SelectImage;
    public Image phase6Part01Selection09SelectImage;
    public Image phase6Part01Selection10SelectImage;
    public Image phase6Part01Selection11SelectImage;
    public Image phase6Part01Selection12SelectImage;
    public Image phase6Part01Selection13SelectImage;
    public Image phase6Part01Selection14SelectImage;
    public Image phase6Part01Selection15SelectImage;
    public Image phase6Part02Selection01SelectImage;
    public Image phase6Part02Selection02SelectImage;
    public Image phase6Part02Selection03SelectImage;
    public Image phase6Part02Selection04SelectImage;
    public Image phase6Part02Selection05SelectImage;
    public Image phase6Part02Selection06SelectImage;
    public Image phase6Part02Selection07SelectImage;
    public Image phase6Part02Selection08SelectImage;
    public Image phase6Part02Selection09SelectImage;
    public Image phase6Part02Selection10SelectImage;
    public Image phase6Part02Selection11SelectImage;
    public Image phase6Part04Selection01SelectImage;
    public Image phase6Part04Selection02SelectImage;
    public Image phase6Part04Selection03SelectImage;
    public Image phase6Part04Selection04SelectImage;
    public Image phase6Part04Selection05SelectImage;
    public Image phase6Part04Selection06SelectImage;
    public Animator NPCLeftNurseImage;
    public Animator NPCLeftDieticianImage;
    public Animator NPCLeftPatientImage;
    public Animator NPCRightNurseImage;
    public Animator NPCRightDieticianImage;
    public Animator NPCRightPatientImage;
    public Animator NPCRightOccupationalTherapistImage;
    public Animator SGADocumentAnim;
    public Animator Phase06Part04ConfirmationAlertAnim;
    public Sprite PatientPortraitImage;
    public Sprite NursePortraitImage;
    public Sprite DieticianPortraitImage;
    public Sprite PlayerPortraitImage;
    public Sprite OccupationalTherapistImage;
    public Sprite BiochemicalCorrectAnswerSelectedSprite;
    public Sprite BiochemicalIncorrectAnswerSelectedSprite;
    public Sprite Phase6DeselectedOptionSprite;
    public Sprite AlertIconSprite;
    public Sprite GenericClinpadNormalButtonImage;
    public Sprite GenericClinpadSelectedButtonImage;
    public Sprite GenericClinpadSelectedHeaderButtonImage;
    public Sprite GenericClinpadNormalHeaderButtonImage;
    public Sprite Phase3CompletionSprite;
    public Image NPCLeftChatPortraitImage;
    public Image NPCLeftChatTwoPortraitImage;
    public Image NPCRightChatPortrait;
    public Image NPCRightTwoChatPortrait;
    public Image NPCRightThreeChatPotrait;
    public Texture2D cursorTexture;
    public AudioSource pageTurnSource;
    public AudioSource notificationGoodSource;
    public AudioSource nextPhaseSource;
    private Color32 dietiticSupervisorChatHeaderColour = new Color32(106, 181, 67, 255);
    private Color32 nurseChatHeaderColour = new Color32(244, 66, 237, 255);
    private Color32 patientChatHeaderColour = new Color32(253, 159, 53, 255);
    private Color32 playerChatHeaderColour = new Color32(84, 164, 204, 255);
    private Color32 occupationalTherapistChatHeaderColour = new Color32(255, 82, 82, 255);
    private Color32 warningColour = new Color32(251, 10, 10, 255);
    private Color32 alertColour = new Color32(216, 127, 61, 255);
    private Color32 alreadySelectedColour = new Color32(245, 245, 245, 255);
    private Color32 alreadySelectedDarkColour = new Color32(106, 181, 67, 255);
    private bool biochemicalWhyIncorrectAnswer01Selected;
    private bool biochemicalWhyIncorrectAnswer02Selected;
    private int biochemicalWhyIncorrectAnswerSelectedScore;
    private float phase4InvestigationSelectedScore;
    private float phase4InvestigationTotalScore = 9;
    public Dropdown Phase4InvestigationDropdown01;
    public Dropdown Phase4InvestigationDropdown02;
    public Dropdown Phase4InvestigationDropdown03;
    public Dropdown Phase4InvestigationDropdown04;
    public Dropdown Phase4InvestigationDropdown05;
    public Dropdown Phase4InvestigationDropdown06;
    public Dropdown Phase4InvestigationDropdown07;
    public Dropdown Phase4InvestigationDropdown08;
    public Dropdown Phase4InvestigationDropdown09;
    public GameObject physicalExam01Option01;
    public GameObject physicalExam01Option02;
    public GameObject physicalExam01Option03;
    public GameObject physicalExam02Option01;
    public GameObject physicalExam02Option02;
    public GameObject physicalExam02Option03;
    public GameObject physicalExam03Option01;
    public GameObject physicalExam03Option02;
    public GameObject physicalExam03Option03;
    public GameObject physicalExam04Option01;
    public GameObject physicalExam04Option02;
    public GameObject physicalExam04Option03;
    public GameObject physicalExam05Option01;
    public GameObject physicalExam05Option02;
    public GameObject physicalExam05Option03;
    public GameObject physicalExam06Option01;
    public GameObject physicalExam06Option02;
    public GameObject physicalExam06Option03;
    public GameObject physicalExam07Option01;
    public GameObject physicalExam07Option02;
    public GameObject physicalExam07Option03;
    public GameObject physicalExam08Option01;
    public GameObject physicalExam08Option02;
    public GameObject physicalExam08Option03;
    public GameObject physicalExam09Option01;
    public GameObject physicalExam09Option02;
    public GameObject physicalExam09Option03;
    private bool phase4InvestigationScoreGiven01;
    private bool phase4InvestigationScoreGiven02;
    private bool phase4InvestigationScoreGiven03;
    private bool phase4InvestigationScoreGiven04;
    private bool phase4InvestigationScoreGiven05;
    private bool phase4InvestigationScoreGiven06;
    private bool phase4InvestigationScoreGiven07;
    private bool phase4InvestigationScoreGiven08;
    private bool phase4InvestigationScoreGiven09;
    private bool phase4SpeakToOT;
    private bool hasDietHistory;
    private bool phase5AnalyseDietCorrectChoiceOneSelected;
    private bool phase5AnalyseDietCorrectChoiceTwoSelected;
    private bool phase5EnergyAndNutrientsCorrectChoiceOneSelected;
    private bool phase5EnergyAndNutrientsCorrectChoiceTwoSelected;
    private bool phase5WeightEvaluationComplete;
    private bool phase5EnergyRequirementsComplete;
    private bool phase5AnalyseDietComplete;
    private bool phase5EnergyActualEvaluationComplete;
    private bool phase5EnergyActualCorrectChoiceOneSelected;
    private bool phase5EnergyActualCorrectWeightSelected;
    private bool phase5EnergyActualProteinRequirementCorrectChoiceOneSelected;
    private bool phase5EnergyActualProteinRequirementCorrectChoiceTwoSelected;
    private bool phase5EnergyActualFormulaOneSelected;
    private bool phase5EnergyActualFormulaTwoSelected;
    private bool phase5EnergyActualFormulaThreeSelected;
    private bool phase5EnergyActualPartTwoFormulaOneSelected;
    private bool phase5EnergyActualPartTwoFormulaTwoSelected;
    private bool phase5EnergyActualPartTwoFormulaThreeSelected;
    private bool phase5EnergyActualPartTwoCorrectChoiceSelected;
    private bool phase5EnergyActualPartThreeCorrectChoiceSelected;
    private bool phase5EnergyActualPartFourCorrectChoiceSelected;
    private bool phase6Part01Complete;
    private bool phase6Part02Complete;
    private bool phase6Part03Complete;
    private bool phase6Part04Complete;
    private bool phase6Part01Selection01Selected;
    private bool phase6Part01Selection02Selected;
    private bool phase6Part01Selection03Selected;
    private bool phase6Part01Selection04Selected;
    private bool phase6Part01Selection05Selected;
    private bool phase6Part01Selection06Selected;
    private bool phase6Part01Selection07Selected;
    private bool phase6Part01Selection08Selected;
    private bool phase6Part01Selection09Selected;
    private bool phase6Part01Selection10Selected;
    private bool phase6Part01Selection11Selected;
    private bool phase6Part01Selection12Selected;
    private bool phase6Part01Selection13Selected;
    private bool phase6Part01Selection14Selected;
    private bool phase6Part01Selection15Selected;
    private bool phase6Part02Selection01Selected;
    private bool phase6Part02Selection02Selected;
    private bool phase6Part02Selection03Selected;
    private bool phase6Part02Selection04Selected;
    private bool phase6Part02Selection05Selected;
    private bool phase6Part02Selection06Selected;
    private bool phase6Part02Selection07Selected;
    private bool phase6Part02Selection08Selected;
    private bool phase6Part02Selection09Selected;
    private bool phase6Part02Selection10Selected;
    private bool phase6Part02Selection11Selected;
    private bool phase6Part04Selection01Selected;
    private bool phase6Part04Selection02Selected;
    private bool phase6Part04Selection03Selected;
    private bool phase6Part04Selection04Selected;
    private bool phase6Part04Selection05Selected;
    private bool phase6Part04Selection06Selected;
    private bool phase6Part01CompleteFirstCheck;
    private string phase6nutritiondiagnosis01 = "";
    private string phase6nutritiondiagnosis02 = "";
    private string phase5formaularesultstring;
    private string phase5PartTwoFormulaResultString;
    private string phase5PartThreeFormulaResultString;
    private string phase5PartFourFormulaResultString;
    private float weightFloat;
    public GameObject investigateChatButton;
    public Button Phase5QualatativeButton;
    public Button Phase5QuantatativeButton;
    public Button Phase5EnergyActualButton;
    public Button Phase5BodyWeightButton;
    public Text phase6part01AlertMessageText;
    private int Phase6Part01CurrentTransformInt = 0;
    private int Phase6Part02CurrentTransformInt = 0;
    private int Phase6Part04CurrentTransformInt = 0;
    public Image phase07UploadBarImage;
    private bool phase07Uploading;
    private bool phase07UploadComplete;
    private float phase07LoadTime = 3f;
    public GameObject phase07UploadButton;
    public GameObject phase07UploadBarGroup;
    public Animator phase07UploadPopup;
    public Animator phase07PartTwoPopup;
    public Animator phase07PartThreePopup;
    public Text phase07UploadingText;
    private bool phase07PartTwoComplete;
    private bool phase07DietitianInitialConversationComplete;
    private bool Phase03AnthropometricMeasurementsWordalreadyfound;
    private bool Phase03ClientHistoryWordalreadyfound;
    private bool Phase03FeedingAbilityWordalreadyfound;
    private bool Phase03FoodIntakeWordalreadyfound;
    private bool Phase03NutritionFocusedPhysicalWordalreadyfound;
    public GameObject Phase03FeedingAbilityWordsCompleteBox;
    public GameObject Phase03FoodIntakeWordsCompleteBox;
    public GameObject Phase03NutriitionFocusedPhysicalWordsCompleteBox;
    public GameObject Phase03AnthropometryWordsCompleteBox;
    public GameObject Phase03ClientHistoryWordsCompleteBox;
    public Animation Phase03CompletionInfoAnimClip;
    public Animator CanExamineMessageToggleAnim;
    private bool canExamNotificationShown;
    private string playerRatingAdvancing = "Advancing";
    private string playerRatingIntermediate = "Intermediate";
    private string playerRatingNovice = "Novice";
    public string phase02BiochemicalPlayerRating;
    public string phase02BiochemicalWhyPlayerRating;
    public string phase02MedicationPlayerRating;
    public string phase02MedicalHistoryPlayerRating;
    public string phase02AnthropometryPlayerRating;
    public string phase03ParsingPlayerRating;
    public string phase04ExamPlayerRating;
    public string phase05QualatativeDietPlayerRating;
    public string phase05QuantativeDietPlayerRating;
    public string phase05EnergyActualPlayerRating;
    public string phase05BodyWeightPlayerRating;
    public string phase06Part01PlayerRating;
    public string phase06EvidencePlayerRating;
    public string phase08OverallGoalPlayerRating;
    public float phase07SelectionsScore;
    public string phase07SelectionRating;
    public string phase07FoodStrategiesRating;
    public string phase07EducationalStrategiesRating;
    public Image HospitalSceneImage;
    public Sprite HospitalSceneSprite;
    public Sprite InvestigationSceneSprite;
    private bool bmiCalculatedWrongFirstTime;
    private int phase03IncorrectScore;
    private int phase04ExamSelectionCorrect01Score;
    private int phase04ExamSelectionCorrect02Score;
    private int phase04ExamSelectionCorrect03Score;
    private int phase04ExamSelectionCorrect04Score;
    private int phase04ExamSelectionCorrect05Score;
    private int phase04ExamSelectionCorrect06Score;
    private int phase04ExamSelectionCorrect07Score;
    private int phase04ExamSelectionCorrect08Score;
    private int phase04ExamSelectionCorrect09Score;
    private int phase05QualatativeDietIncorrectScore;
    private int phase05QuantatativeDietIncorrectScore;
    private int phase05EnergyActualDietIncorrectScore;
    private int phase05BodyWeightIncorrectScore;
    private int phase06EvidenceIncorrectScore;
    private string phase06part02PotentialIssue01String = "";
    private string phase06part02PotentialIssue02String = "";
    private string phase06part02PotentialIssue03String = "";
    private string phase06part03Evidence01String = "";
    private string phase06part03Evidence02String = "";
    private string phase06part03Evidence03String = "";
    private bool phase6Part03Selection01Selected;
    private bool phase6Part03Selection02Selected;
    private bool phase6Part03Selection03Selected;
    private bool phase6Part03Selection04Selected;
    private bool phase6Part03Selection05Selected;
    private bool phase6Part03Selection06Selected;
    private bool phase6Part03Selection07Selected;
    private int phase06Part03SelectedAmount;
    public Image phase6Part03Selection01SelectImage;
    public Image phase6Part03Selection02SelectImage;
    public Image phase6Part03Selection03SelectImage;
    public Image phase6Part03Selection04SelectImage;
    public Image phase6Part03Selection05SelectImage;
    public Image phase6Part03Selection06SelectImage;
    public Image phase6Part03Selection07SelectImage;
    private string phase06CausesString;
    public Animator phase07PartOnePopup;
    public GameObject Phase07NutritionGoal01;
    public GameObject Phase07NutritionGoal02;
    public GameObject Phase07NutritionGoal03;
    public GameObject Phase07NutritionGoal04;
    public GameObject Phase07NutritionGoal05;
    public GameObject Phase07NutritionGoal06;
    public GameObject[] Phase07Selection01Group;
    public GameObject[] Phase07Selection02Group;
    public GameObject[] Phase07Selection03Group;
    public GameObject[] Phase07Selection04Group;
    public GameObject[] Phase07Selection05Group;
    public GameObject[] Phase07Selection06Group;
    private bool Phase07Part03Part01Complete;
    private bool Phase07Part03Part02Complete;
    private bool Phase07Part04Complete;
    private int phase07GoalsIncorrectScore;
    public Text phase07Part04MessageAlertText;
    public Animator Phase07Part04ConfirmationAlertAnim;
    public Animator Phase07Part05CompletedAnim;
    public Text Phase06ClinpadSavedText;
    public Text Phase07ClinpadSavedText;
    private List<string> Phase07SelectionText = new List<string>();
    public Image phase07Part02SelectImage01;
    public Image phase07Part02SelectImage02;
    public Image phase07Part02SelectImage03;
    public Image phase07Part02SelectImage04;
    public Image phase07Part02SelectImage05;
    public Image phase07Part02SelectImage06;
    private bool phase07Part02Selection01Selected;
    private bool phase07Part02Selection02Selected;
    private bool phase07Part02Selection03Selected;
    private bool phase07Part02Selection04Selected;
    private bool phase07Part02Selection05Selected;
    private bool phase07Part02Selection06Selected;
    private int phase07Part02SelectedAmount;
    public List<string> phase07FoodStrategyStringArray = new List<string>();
    public List<string> phase07EducationalStrategyStringArray = new List<string>();
    private int phase08ConversationTracker = 0;
    public Sprite DietHistoryScheduleSprite;
    public Sprite DietHistoryCrossCheckSprite;
    public Image DietHistoryImage;
    public GameObject phase08ThoughtsInputBoxGroup;
    private string phase08Selection01FoodStrategy01;
    private string phase08Selection01FoodStrategy02;
    private string phase08Selection02FoodStrategy01;
    private string phase08Selection02FoodStrategy02;
    public DropZonePhase07EducationalStrategy dropZonePhase07EducationalStrategy01;
    public DropZonePhase07EducationalStrategy dropZonePhase07EducationalStrategy02;
    public DropZonePhase07EducationalStrategy dropZonePhase07EducationalStrategy03;
    public DropZonePhase07EducationalStrategy dropZonePhase07EducationalStrategy04;
    public DropZonePhase07EducationalStrategy dropZonePhase07EducationalStrategy05;
    public DropZonePhase07EducationalStrategy dropZonePhase07EducationalStrategy06;
    public DropZonePhase07EducationalStrategy dropZonePhase07EducationalStrategy07;
    public Image NPCPatientImage;
    public Sprite NPCPatientCasualClothesSprite;
    private int Phase07TotalDropZonesSelected;
    private bool phase08Goal01AlreadyDiscussed;
    public Animator phase08EndResultsMessageAnim;
    public Text Phase08Phase02ResultText;
    public Text Phase08Phase03ResultText;
    public Text Phase08Phase04Phase05ResultText;
    public Text Phase08Phase06ResultText;
    public Text Phase08Phase07ResultText;
    public Text Phase08Phase08ResultText;
    public Text Phase08OverallResultsText;
    public Text Phase08OverallSuggestionText;
    private int phase08OverallScore;
    public Animator phase08EndResultInformationDisplayAnim;
    public Animator phase07ToPhase08TransitionAnim;
    private float phase07StrategiesScore;
    public Animator ExaminationContextHelperAnim;
    private bool examinationHelperShown;
    public int phase07EducationalStartegiesSelectionScore;
    public Text investigationBackButtonText;
    private bool phase08InsufficientFluidAddressed;
    private bool phase08InadequateEnergyAndProteinIntakeAddressed;
    private float phase06part02CombinedScore;
    private float phase04Phase05CombinedScore;
    private float phase02CombinedScore;

    // Use this for initialization
    void Start()
    {
        phase08ThoughtsInputBoxGroup.SetActive(false);
        Phase07NutritionGoal01.SetActive(false);
        Phase07NutritionGoal02.SetActive(false);
        Phase07NutritionGoal03.SetActive(false);
        Phase07NutritionGoal04.SetActive(false);
        Phase07NutritionGoal05.SetActive(false);
        Phase07NutritionGoal06.SetActive(false);
        foreach (GameObject item in Phase07Selection01Group)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in Phase07Selection02Group)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in Phase07Selection03Group)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in Phase07Selection04Group)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in Phase07Selection05Group)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in Phase07Selection06Group)
        {
            item.SetActive(false);
        }
        phase02BiochemicalPlayerRating = playerRatingAdvancing;
        phase02BiochemicalWhyPlayerRating = playerRatingAdvancing;
        phase02MedicationPlayerRating = playerRatingAdvancing;
        phase02MedicalHistoryPlayerRating = playerRatingAdvancing;
        phase02AnthropometryPlayerRating = playerRatingAdvancing;
        phase03ParsingPlayerRating = playerRatingAdvancing;
        phase04ExamPlayerRating = playerRatingAdvancing;
        phase05QualatativeDietPlayerRating = playerRatingAdvancing;
        phase05QuantativeDietPlayerRating = playerRatingAdvancing;
        phase05EnergyActualPlayerRating = playerRatingAdvancing;
        phase05BodyWeightPlayerRating = playerRatingAdvancing;
        phase06Part01PlayerRating = playerRatingAdvancing;
        phase06EvidencePlayerRating = playerRatingAdvancing;
        phase07SelectionRating = playerRatingAdvancing;
        phase07FoodStrategiesRating = playerRatingAdvancing;
        phase07EducationalStrategiesRating = playerRatingAdvancing;
        phase08OverallGoalPlayerRating = playerRatingAdvancing;
        foreach (GameObject phase6part3Evidence in phase6Part03EvidenceOptions)
        {
            phase6part3Evidence.SetActive(false);
        }
        foreach (GameObject phase07Part03Evidence in phase07Part03EvidenceOptions)
        {
            phase07Part03Evidence.SetActive(false);
        }
        Phase03FeedingAbilityWordsCompleteBox.SetActive(false);
        Phase03FoodIntakeWordsCompleteBox.SetActive(false);
        Phase03NutriitionFocusedPhysicalWordsCompleteBox.SetActive(false);
        Phase03AnthropometryWordsCompleteBox.SetActive(false);
        Phase03ClientHistoryWordsCompleteBox.SetActive(false);
        phase07UploadButton.SetActive(false);
        phase07UploadBarGroup.SetActive(false);
        ComputerSceneTwoDateGroup.SetActive(false);
        ComputerSceneThreeDateGroup.SetActive(false);
        Phase6PartSelectionGameObject01.SetActive(false);
        Phase6PartSelectionGameObject02.SetActive(false);
        Phase6PartSelectionGameObject03.SetActive(false);
        Phase6PartSelectionGameObject04.SetActive(false);
        Phase6PartSelectionGameObject05.SetActive(false);
        Phase6PartSelectionGameObject06.SetActive(false);
        Phase6PartSelectionGameObject07.SetActive(false);
        Phase6PartSelectionGameObject08.SetActive(false);
        Phase6PartSelectionGameObject09.SetActive(false);
        Phase6PartSelectionGameObject10.SetActive(false);
        Phase6PartSelectionGameObject11.SetActive(false);
        Phase6Part2SelectionGameObject01.SetActive(false);
        Phase6Part2SelectionGameObject02.SetActive(false);
        Phase6Part2SelectionGameObject03.SetActive(false);
        Phase6Part2SelectionGameObject04.SetActive(false);
        Phase6Part2SelectionGameObject05.SetActive(false);
        Phase6Part2SelectionGameObject06.SetActive(false);
        Phase6Part4SelectionGameObject01.SetActive(false);
        Phase6Part4SelectionGameObject02.SetActive(false);
        Phase6Part4SelectionGameObject03.SetActive(false);
        Phase6Part4SelectionGameObject04.SetActive(false);
        Phase6Part4SelectionGameObject05.SetActive(false);
        Phase6Part4SelectionGameObject06.SetActive(false);
        ComputerTwoBackButton.SetActive(false);
        ComputerThreeBackButton.SetActive(false);
        phase5BodyWeightUsualWeightInputGroup.SetActive(false);
        phase5WeightEvaluationSaved03Text.SetActive(false);
        phase5WeightEvaluationSaved02Text.SetActive(false);
        Phase5AnalyseDietTranscribeText.SetActive(false);
        Phase5EnergyAndNutrientsTranscribeText.SetActive(false);
        Phase5EnergyActualTranscribeText.SetActive(false);
        investigateChatButton.SetActive(false);
        phase2AnthropometryProgressFillImage.fillAmount = 0;
        phase2BiochemicalProgressFillImage.fillAmount = 0;
        phase2ClientHistoryProgressFillImage.fillAmount = 0;
        phase2FoodAndNutritionProgressFillImage.fillAmount = 0;
        ClinpadButton.SetActive(false);
        SGAFormButton.SetActive(false);
        Phase2BiochemicalClinpadText01.SetActive(false);
        Phase2BiochemicalClinpadText02.SetActive(false);
        biochemicalCorrectAnswer01Text.SetActive(false);
        biochemicalCorrectAnswer02Text.SetActive(false);
        clientHistoryCorrectAnswer00Text.SetActive(false);
        clientHistoryCorrectAnswer01Text.SetActive(false);
        clientHistoryCorrectAnswer02Text.SetActive(false);
        clientHistoryCorrectAnswer03Text.SetActive(false);
        clientHistoryCorrectAnswer04Text.SetActive(false);
        clientHistoryCorrectAnswer05Text.SetActive(false);
        clientHistoryCorrectAnswer06Text.SetActive(false);
        clientHistoryCorrectAnswer07Text.SetActive(false);
        clientHistoryCorrectAnswer08Text.SetActive(false);
        clientHistoryCorrectAnswer09Text.SetActive(false);
        clientHistoryCorrectAnswer10Text.SetActive(false);
        clientHistoryCorrectAnswer11Text.SetActive(false);
        clientHistoryCorrectAnswer12Text.SetActive(false);
        clientHistoryCorrectAnswer13Text.SetActive(false);
        clientHistoryCorrectAnswer14Text.SetActive(false);
        clientHistoryCorrectAnswer15Text.SetActive(false);
        clientHistoryCorrectAnswer16Text.SetActive(false);
        clientHistoryCorrectAnswer17Text.SetActive(false);
        clientHistoryCorrectAnswer18Text.SetActive(false);
        clientHistoryCorrectAnswer19Text.SetActive(false);
        clientHistoryCorrectAnswer20Text.SetActive(false);
        clientHistoryCorrectAnswer21Text.SetActive(false);
        clientHistoryCorrectAnswer22Text.SetActive(false);
        clientHistoryCorrectAnswer23Text.SetActive(false);
        clientHistoryCorrectAnswer24Text.SetActive(false);
        clientHistoryCorrectAnswer25Text.SetActive(false);
        clientHistoryCorrectAnswer26Text.SetActive(false);
        clientHistoryCorrectAnswer27Text.SetActive(false);
        clientHistoryCorrectAnswer28Text.SetActive(false);
        clientHistoryCorrectAnswer29Text.SetActive(false);
        clientHistoryCorrectAnswer30Text.SetActive(false);
        clientHistoryCorrectAnswer31Text.SetActive(false);
        clientHistoryCorrectAnswer32Text.SetActive(false);
        clientHistoryCorrectAnswer33Text.SetActive(false);
        clientHistoryCorrectAnswer34Text.SetActive(false);
        clientHistoryCorrectAnswer35Text.SetActive(false);
        phase4SavedText01.SetActive(false);
        phase4SavedText02.SetActive(false);
        phase4SavedText03.SetActive(false);
        phase4SavedText04.SetActive(false);
        phase4SavedText05.SetActive(false);
        phase4SavedText06.SetActive(false);
        phase4SavedText07.SetActive(false);
        phase4SavedText08.SetActive(false);
        phase4SavedText09.SetActive(false);
        phase4SavedText10.SetActive(false);
        phase4SavedText11.SetActive(false);
        phase4SavedText12.SetActive(false);
        phase4SavedText13.SetActive(false);
        phase4SavedText14.SetActive(false);
        phase4SavedText15.SetActive(false);
        phase4SavedText16.SetActive(false);
        phase4SavedText17.SetActive(false);
        phase4SavedText18.SetActive(false);
        phase4SavedText19.SetActive(false);
        phase4SavedText20.SetActive(false);
        foodAndNutritionCorrectAnswer01Text.SetActive(false);
        foodAndNutritionCorrectAnswer02Text.SetActive(false);
        foodAndNutritionCorrectAnswer03Text.SetActive(false);
        foodAndNutritionCorrectAnswer04Text.SetActive(false);
        foodAndNutritionCorrectAnswer05Text.SetActive(false);
        foodAndNutritionCorrectAnswer06Text.SetActive(false);
        //GameStart();
        BMICalculatorCurrentHeight.text = "";
        BMICalculatorCurrentWeight.text = "";
        BMICalculatorCurrentSymbol.text = "+";
        WeightChangeCalculationText.text = "";
        PresentFindingsButton.SetActive(false);
        PatientInformationGender.SetActive(false);
        PatientInformationAge.SetActive(false);
        AssessmentFormGroup.SetActive(false);
        AdmissionFormGroup.SetActive(false);
        ProgressNotesPage1Group.SetActive(false);
        ProgressNotesPage2Group.SetActive(false);
        ClinPadNutritionalRequirementsButton.SetActive(false);
        Phase4AnthropometryMultipleChoiceOption1.SetActive(false);
        Phase4AnthropometryMultipleChoiceOption2.SetActive(false);
        Phase4AnthropometryMultipleChoiceOption3.SetActive(false);
        Phase4ClientHistoryMultipleChoiceOption1.SetActive(false);
        Phase4ClientHistoryMultipleChoiceOption2.SetActive(false);
        Phase4ClientHistoryMultipleChoiceOption3.SetActive(false);
        Phase4MedicalHistoryMultipleChoiceOption1.SetActive(false);
        Phase4MedicalHistoryMultipleChoiceOption2.SetActive(false);
        Phase4MedicalHistoryMultipleChoiceOption3.SetActive(false);
        Phase4NutritionMultipleChoiceOption1.SetActive(false);
        Phase4NutritionMultipleChoiceOption2.SetActive(false);
        Phase4NutritionMultipleChoiceOption3.SetActive(false);
        phase5MultipleChoiceButtonGroup.SetActive(false);
        Phase5AnalyseDietFinalDecisionButtonGroup.SetActive(false);
        Phase5EnergyAndNutrientsFinalDecisionButtonGroup.SetActive(false);
        phase5AnalyseDietMultipleChoice01ButtonGroup.SetActive(false);
        phase5AnalyseDietMultipleChoice02ButtonGroup.SetActive(false);
        phase5EnergyAndNutrientsMultipleChoice01ButtonGroup.SetActive(false);
        phase5EnergyAndNutrientsMultipleChoice02ButtonGroup.SetActive(false);
        phase5EnergyActualMultipleChoice01ButtonGroup.SetActive(false);
        phase5EnergyActualWeightInputFieldGroup.SetActive(false);
        phase5EnergyActualMultipleChoice02ButtonGroup.SetActive(false);
        phase5EnergyActualMultipleChoice03ButtonGroup.SetActive(false);
        phase5EnergyActualMultipleChoice04ButtonGroup.SetActive(false);
        phase5EnergyActualFinalDecisionButtonGroup.SetActive(false);
        phase5BodyWeightMultipleChoice01ButtonGroup.SetActive(false);
        phase5BodyWeightMultipleChoice02ButtonGroup.SetActive(false);
        patientInvestigationSceneGroup.SetActive(false);
        Phase3CompletionInfoGroup.SetActive(false);
        Phase3SavedText.SetActive(false);
        ChangeToClinPadTranscribeOption();
        phaseThreePresentFindingsInputGroup.SetActive(false);
        ClinpadRayCastBlockImage.SetActive(false);
        NotesSavedText.SetActive(false);
        ClipboardButtonGroup.SetActive(false);
        MedicalClipboardButtonGroup.SetActive(false);
        biochemicalAnswersGroup.SetActive(false);
        medicationAnswersGroup.SetActive(false);
        anthropometryAnswersGroup.SetActive(false);
        observationsAnswerGroup.SetActive(false);
        FoodGroupResourceGroup.SetActive(false);
        ReadyReckonerResourceGroup.SetActive(false);
        SGAFormGroup.SetActive(false);
        SGAFormButtonGroup.SetActive(false);
        ActivateComputerButton.interactable = false;
        ActivateAnthropometryButton.interactable = false;
        ActivateMedicalHistoryButton.interactable = false;
        phaseTwoInteractiveButtonGroup.SetActive(false);
        phaseFourInteractiveButtonGroup.SetActive(false);
        phaseFourAnthropometryInteractiveButtonGroup.SetActive(false);
        phaseFourClientHistoryInteractiveButtonGroup.SetActive(false);
        phaseFourMedicalHistoryInteractiveButtonGroup.SetActive(false);
        phaseFourNutritionInteractiveButtonGroup.SetActive(false);
        phaseTwoFoodAndNutritionInformationGroup.SetActive(false);
        phaseTwoStartInteractiveButtonGroup.SetActive(false);
        ActivateChatButton.interactable = false;
        ActivateInvestigationButton.interactable = false;

        if (LoadExistingGame())
        {
            // Show clinpad, since the is normally enabled during the first conversation.
            ClinpadButton.SetActive(true);

            // Dietician is normally first enabled during the first conversation.
            NPCRightDieticianImage.SetBool("NPCRightDefault", false);
            NPCRightDieticianImage.SetBool("NPCRightAnimateIn", true);
        }
        else
        {
            GameStart();

            ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
            ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
            ChatTextLeftTwoHeaderImage.color = new Color32(244, 66, 241, 255);
            ChatNextButtonText.text = "ENTER NAME";
            ChatRightNameText.text = dieteticSupervisorNameString;
            ChatRightTwoNameText.text = dieteticSupervisorNameString;
            ChatLeftNameText.text = playerNameString;
            ChatLeftTwoNameText.text = nurseNameString;
            soundVolumeSlider.value = PlayerPrefs.GetFloat("SoundVolume");
            AudioListener.volume = soundVolumeSlider.value;
            ChatRightText.text = "I'm John and I'll be supervising you during your placement at University Hospital. I have your name in my records, but what would you prefer to be called?";
            NotesComputerGroup.SetActive(false);
            TranscribeClientHistoryGroup.SetActive(false);
            TranscribeAnthropometryGroup.SetActive(false);
            TranscribeFoodAndNutritionGroup.SetActive(false);
            TranscribeNutitionDiagnosisTabButton.SetActive(false);
            TranscribeInterventionPlanTabButton.SetActive(false);
            TranscribeMonitoringAndEvaluationTabButton.SetActive(false);
            weightChangeCalculatorGroup.SetActive(false);
            TranscribeAnthropometryGroupTab();
            SetDateOnProgressNotes();
        }

        // Load existing game progress if present.
        //LoadExistingGame();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>True if a phase change was processed.  i.e Progress is not starting from the beginning.</returns>
    private bool LoadExistingGame()
    {
        if (null != LoginSystem.progressToRestore)
        {
            bool phaseChanged = false;
            foreach (var datem in LoginSystem.progressToRestore)
            {
                phaseChanged = ProcessProgressToken(datem.recordName, datem.recordValue) || phaseChanged;
            }
            return phaseChanged;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Processes a record from the database to update the current game state.
    /// </summary>
    /// <param name="datemName"></param>
    /// <param name="datemValue"></param>
    /// <returns>True if at least one phase had been completed.  i.e the player doesn't need to start from the beginning.</returns>
    private bool ProcessProgressToken(string datemName, string datemValue)
    {
        LoginSystem.logger.LogInfo("[Debug]Processing token: " + datemName + ": " + datemValue);
        switch (datemName)
        {
            case "playerName":
                this.playerNameString = datemValue;
                break;
            case "phaseCompleted":
                // Set phase to resume from.
                //this.phase
                switch (datemValue)
                {
                    case "1":
                        TransitionPhase0ToPhase1();
                        TransitionPhase1ToPhase2();
                        // Nurses' station is the current room.
                        NurseNavButton.interactable = true;
                        NurseNavButton.isOn = true;
                        break;
                    case "2":
                        TransitionPhase0ToPhase1();
                        TransitionPhase1ToPhase2();
                        TransitionPhase2ToPhase3();
                        // Dietician's Office is the current room.
                        DieticianNavButton.interactable = true;
                        DieticianNavButton.isOn = true;
                        break;
                    case "3":
                        TransitionPhase0ToPhase1();
                        TransitionPhase1ToPhase2();
                        TransitionPhase2ToPhase3();
                        TransitionPhase3ToPhase4();
                        // Dietician's Office is the current room.
                        DieticianNavButton.interactable = true;
                        DieticianNavButton.isOn = true;
                        break;
                    default:
                        break;
                }
                //if ("1" == datemValue)
                //{
                //    TransitionPhase1ToPhase2();
                //}
                //break;
                return true;
            // No longer required, since this will always be a fixed value for the phase.
            //case "gameStartConversationTracker":
            //    gameStartConversationTracker = SafeParse(datemValue, 0);
            //    LoginSystem.logger.LogInfo("[Debug]gameStartConversationTracker set to: " + gameStartConversationTracker.ToString());
            //    break;
            default:
                break;
        }
        return false;
    }

    int SafeParse(string input, int failsafe)
    {
        int result = failsafe;
        if (int.TryParse(input, out result))
        {
            return result;
        }
        else
        {
            return failsafe;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            if (PhaseManagement.gamePhase == 2)
            {
                currentPhaseText.text = "3rd";
                currentPhaseProgressFillImage.fillAmount = 0;
                totalProgressFillImage.fillAmount = 0.25f;
                totalProgressAmountText.text = "25%";
                if (!alreadyReachedPhase3)
                {
                    nextPhaseSource.Play();
                    PhaseReachedAnim.SetTrigger("PhaseReached");
                    PhaseReachedText.text = "REACHED PHASE 3";
                    alreadyReachedPhase3 = true;
                }
                Phase2ProgressGroup.SetActive(false);
                Phase3PresentFindingsConversationTracker = 1;
                BMICalculatorGroup.SetActive(false);
                PhaseManagement.gamePhase = 3;
            }
            else if (PhaseManagement.gamePhase == 3)
            {
                PhaseReachedText.text = "REACHED PHASE 4";
                nextPhaseSource.Play();
                PhaseReachedAnim.SetTrigger("PhaseReached");
                currentPhaseProgressFillImage.fillAmount = 0;
                currentPhaseText.text = "4th";
                totalProgressFillImage.fillAmount = 0.375f;
                totalProgressAmountText.text = "37.5%";
                Phase3ProgressGroup.SetActive(false);
                PhaseManagement.gamePhase = 4;
            }
            else if (PhaseManagement.gamePhase == 4)
            {
                PhaseManagement.gamePhase = 5;
                nextPhaseSource.Play();
                PhaseReachedAnim.SetTrigger("PhaseReached");
                PhaseReachedText.text = "REACHED PHASE 5";
                currentPhaseText.text = "5th";
                currentPhaseProgressFillImage.fillAmount = 0;
                totalProgressFillImage.fillAmount = 0.50f;
                totalProgressAmountText.text = "50%";
                Phase4ProgressGroup.SetActive(false);
                SGAFormButton.SetActive(true);
                weightChangeCalculatorGroup.SetActive(true);
            }
            else if (PhaseManagement.gamePhase == 5)
            {
                PhaseManagement.gamePhase = 6;
                nextPhaseSource.Play();
                PhaseReachedAnim.SetTrigger("PhaseReached");
                PhaseReachedText.text = "REACHED PHASE 6";
                currentPhaseText.text = "6th";
                currentPhaseProgressFillImage.fillAmount = 0;
                totalProgressFillImage.fillAmount = 0.625f;
                totalProgressAmountText.text = "62.5%";
                Phase5ProgressGroup.SetActive(false);
                SGAFormButton.SetActive(false);
                weightChangeCalculatorGroup.SetActive(false);
                TranscribeNutitionDiagnosisTabButton.SetActive(true);
            }
            else if (PhaseManagement.gamePhase == 6)
            {
                PhaseManagement.gamePhase = 7;
                nextPhaseSource.Play();
                PhaseReachedAnim.SetTrigger("PhaseReached");
                PhaseReachedText.text = "REACHED PHASE 7";
                currentPhaseText.text = "7th";
                currentPhaseProgressFillImage.fillAmount = 0;
                totalProgressFillImage.fillAmount = 0.75f;
                totalProgressAmountText.text = "75%";
                Phase6ProgressGroup.SetActive(false);
                TranscribeInterventionPlanTabButton.SetActive(true);
            }
            else if (PhaseManagement.gamePhase == 7)
            {
                PhaseManagement.gamePhase = 8;
                nextPhaseSource.Play();
                PhaseReachedAnim.SetTrigger("PhaseReached");
                PhaseReachedText.text = "REACHED PHASE 8";
                currentPhaseText.text = "8th";
                currentPhaseProgressFillImage.fillAmount = 0;
                totalProgressFillImage.fillAmount = 0.875f;
                totalProgressAmountText.text = "87.5%";
                Phase7ProgressGroup.SetActive(false);
                NPCPatientImage.sprite = NPCPatientCasualClothesSprite;
                canComputer = false;
                canAnthropometry = false;
                canMedicalHistory = false;
            }
        }
        if (phase07Uploading == true)
        {
            phase07UploadBarGroup.SetActive(true);
            phase07UploadBarImage.fillAmount += 1f / phase07LoadTime * Time.deltaTime;
            phase07UploadButton.SetActive(false);
        }
        if (phase07UploadBarImage.fillAmount == 1)
        {
            phase07Uploading = false;
            phase07UploadComplete = true;
            phase07UploadButton.GetComponentInChildren<Text>().text = "CONTINUE";
            phase07UploadingText.text = "<b><color=#6AB543FF>COMPLETE</color></b>";
            phase07UploadButton.SetActive(true);
        }
        if (Phase2DieticianFoodAndNutritionChatAnwersSelcted >= 2)
        {
            hasFoodAndNutritionInformation = true;
        }
        if (canComputer && currentScene == 0)
        {
            ActivateComputerButton.interactable = true;
            //ActivateComputerButtonText.color = new Color32(255, 255, 255, 255);
        }
        else
        {
            ActivateComputerButton.interactable = false;
            //ActivateComputerButtonText.color = new Color32(255, 255, 255, 0);
        }
        if (canMedicalHistory && currentScene == 1)
        {
            ActivateMedicalHistoryButton.interactable = true;
            ActivateMedicalHistoryButtonText.color = new Color32(35, 35, 35, 255);
        }
        else
        {
            ActivateMedicalHistoryButton.interactable = false;
            ActivateMedicalHistoryButtonText.color = new Color32(35, 35, 35, 0);
        }
        if (canAnthropometry && currentScene == 2)
        {
            ActivateAnthropometryButton.interactable = true;
            ActivateAnthropometryButtonText.color = new Color32(35, 35, 35, 255);
        }
        else
        {
            ActivateAnthropometryButton.interactable = false;
            ActivateAnthropometryButtonText.color = new Color32(35, 35, 35, 0);
        }
        if (ActivateInvestigationButton.interactable == false)
        {
            ActivateInvestigationButtonText.color = new Color32(255, 255, 255, 0);
        }
        else
        {
            ActivateInvestigationButtonText.color = new Color32(255, 255, 255, 255);
        }
        if (ActivateChatButton.interactable == false)
        {
            ActivateChatButtonText.color = new Color32(255, 255, 255, 0);
            ActivateChatButton.image.raycastTarget = false;
            ActivateChatButtonText.raycastTarget = false;
        }
        else
        {
            ActivateChatButtonText.color = new Color32(255, 255, 255, 255);
            ActivateChatButton.image.raycastTarget = true;
            ActivateChatButtonText.raycastTarget = true;
        }
        if (ChatNextButton.interactable == false)
        {
            ChatNextButtonText.color = new Color32(255, 255, 255, 0);
        }
        else
        {
            ChatNextButtonText.color = new Color32(255, 255, 255, 255);
        }
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuToggleAnim.GetBool("MenuActivated") == true)
            {
                menuToggleAnim.SetBool("MenuActivated", false);
            }

            if (helpToggleAnim.GetBool("MenuActivated") == true)
            {
                helpToggleAnim.SetBool("MenuActivated", false);
            }

            if (hintToggleAnim.GetBool("MenuActivated") == true)
            {
                hintToggleAnim.SetBool("MenuActivated", false);
            }
        }

        if (PhaseManagement.gamePhase == 2)
        {
            //FOR ALL GAME PHASES I CAN TURN REPEAT CURRENTSCENE == x INFO INTO ITS ON FUNCTION
            //HAVE ADDED FUNCTIONALITY FOR PHASE 4, DO NOT REWRITE ONLY CHANGE TEXT INFORMATION ETC... MUCHO IMPORTANTE           

            if (!inComputer)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                biochemicalAnswersGroup.SetActive(false);
            }
            if (!inClipboard)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                medicationAnswersGroup.SetActive(false);
                anthropometryAnswersGroup.SetActive(false);
                ClipboardButtonGroup.SetActive(false);
            }
            if (!inMedicalChart)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                AssessmentFormGroup.SetActive(false);
                AdmissionFormGroup.SetActive(false);
                ProgressNotesPage1Group.SetActive(false);
                ProgressNotesPage2Group.SetActive(false);
                MedicalClipboardButtonGroup.SetActive(false);
            }

            if (inChat)
            {
                rayCastBlockImage.SetActive(true);
                ChatNextButton.interactable = true;
                ActivateChatButton.interactable = false;
            }
            else if (!inChat && currentScene != 3 && currentScene != 4 && currentScene != 5 && currentScene != 6 && currentScene != 7)
            {
                rayCastBlockImage.SetActive(false);
                ChatNextButton.interactable = false;
                ActivateChatButton.interactable = true;
            }

            if (currentScene != 4 && currentScene != 5 && currentScene != 6)
            {
                HintText.text = "If you are unsure on what to do next, speak with the Supervising Dietitian and select the Learn More option. \n \n If you have gathered all the information then you will be able to present your findings to the Supervising Dietitian. \n \n Don't forget to fill out the BMI section by using the calculator in your Clinpad, found in the Transcribe section, under the Anthropometry tab.";
                if (Phase2AnthropometryAnswerSelected == Phase2AnthropometryAnswerTotal)
                {
                    if (Phase2BiochemicalAnswerSelected == Phase2BiochemicalAnswerTotal)
                    {
                        if (clientHistoryAnswersSelected == Phase2ClientHistoryAnswerTotal)
                        {
                            if (foodAndNutritionAnswersSelected == Phase2FoodAndNutritionAnswerTotal)
                            {
                                HintText.text = "You have found all the information you need in order to present your findings to the Supervising Dietitian. Speak to John now in order to progress.";
                            }
                        }
                    }
                }
            }
            else if (currentScene == 4)
            {
                if (autoHints)
                {
                    if (!phase2Scene4HintShown)
                    {
                        if (!MenuButton.isOn)
                        {
                            HintText.text = "Select only the biochemical parameters that are relevant to your nutrition intervention. Selecting irrelevant parameters will negatively impact your overall score.";
                            MenuButton.isOn = true;
                            phase2Scene4HintShown = true;
                        }
                    }
                }
            }
            else if (currentScene == 5)
            {
                if (autoHints)
                {
                    if (!phase2Scene5HintShown)
                    {
                        if (!MenuButton.isOn)
                        {
                            HintText.text = "You can switch between the Medical History and the Observation sheets to gather more information for your Clinpad. \n \n BMI Calculator is available from the Anthropometry tab in the Transcribe section of your Clinpad.";
                            MenuButton.isOn = true;
                            phase2Scene5HintShown = true;
                        }
                    }
                }
            }
            else if (currentScene == 6)
            {
                if (autoHints)
                {
                    if (!phase2Scene6HintShown)
                    {
                        if (!MenuButton.isOn)
                        {
                            HintText.text = "All information that can be captured on your Clinpad is highlighted in the medical chart. If you think the highlighted information is relevant and important to capture for future use in your nutrition care plan, click on it to add it to your Clinpad. \n \n The Clinpad is a portable template of the nutrition care plan and has limited space, so only copy the information that is relevant and important.";
                            MenuButton.isOn = true;
                            phase2Scene6HintShown = true;
                        }
                    }
                }
            }


            if (currentScene == 0)
            {
                if (Phase2DieticianConversationTracker == 0)
                {
                    ChatNextButtonText.text = "GATHER INFO";
                    ChatRightText.text = "Hi " + playerNameString + " How can I help you?";
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", true);
                }

            }
            else if (currentScene == 1)
            {
                ChatRightNameText.text = nurseNameString;
                ChatTextRightHeaderImage.color = nurseChatHeaderColour;
                NPCRightChatPortrait.sprite = NursePortraitImage;
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightDefault", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 2)
            {
                ChatRightNameText.text = patientNameString;
                ChatNextButtonText.text = "CLOSE";
                ChatRightText.text = "Marta is not in her room at the moment, come back later if you need to talk.";
                ChatTextRightHeaderImage.color = patientChatHeaderColour;
                NPCRightChatPortrait.sprite = PatientPortraitImage;
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                //if (NPCRightPatientImage.GetBool("NPCRightAnimateOut") == true)
                //{
                //    NPCRightPatientImage.SetBool("NPCRightAnimateOut", false);
                //    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                //}
                //if (NPCRightPatientImage.GetBool("NPCRightDefault") == true)
                //{
                //    NPCRightPatientImage.SetBool("NPCRightDefault", false);
                //    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                //}
            }
            else if (currentScene == 3)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
            }
            else if (currentScene == 4)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputer)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    biochemicalAnswersGroup.SetActive(true);
                }
            }
            else if (currentScene == 5)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inClipboard)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ClipboardButtonGroup.SetActive(true);
                    if (!inClipboardObservation)
                    {
                        observationsAnswerGroup.SetActive(false);
                        medicationAnswersGroup.SetActive(true);
                        anthropometryAnswersGroup.SetActive(false);
                        ObservationButtonText.text = "OBSERVATIONS";
                    }
                    else if (inClipboardObservation)
                    {
                        medicationAnswersGroup.SetActive(false);
                        anthropometryAnswersGroup.SetActive(true);
                        observationsAnswerGroup.SetActive(true);
                        ObservationButtonText.text = "MEDICATION";
                    }
                }
            }
            else if (currentScene == 6)
            {
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inMedicalChart)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    MedicalClipboardButtonGroup.SetActive(true);
                }
            }
        }

        else if (PhaseManagement.gamePhase == 3)
        {
            //FOR ALL GAME PHASES I CAN TURN REPEAT CURRENTSCENE == x INFO INTO ITS ON FUNCTION
            //HAVE ADDED FUNCTIONALITY FOR PHASE 4, DO NOT REWRITE ONLY CHANGE TEXT INFORMATION ETC... MUCHO IMPORTANTE           

            if (!inComputer)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                biochemicalAnswersGroup.SetActive(false);
            }
            if (!inClipboard)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                medicationAnswersGroup.SetActive(false);
                anthropometryAnswersGroup.SetActive(false);
                ClipboardButtonGroup.SetActive(false);
            }
            if (!inMedicalChart)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                AssessmentFormGroup.SetActive(false);
                AdmissionFormGroup.SetActive(false);
                ProgressNotesPage1Group.SetActive(false);
                ProgressNotesPage2Group.SetActive(false);
                MedicalClipboardButtonGroup.SetActive(false);
            }

            if (inChat)
            {
                rayCastBlockImage.SetActive(true);
                ChatNextButton.interactable = true;
                ActivateChatButton.interactable = false;
            }
            else if (!inChat && currentScene != 3 && currentScene != 4 && currentScene != 5 && currentScene != 6)
            {
                rayCastBlockImage.SetActive(false);
                ChatNextButton.interactable = false;
                ActivateChatButton.interactable = true;
            }

            if (currentScene != 4 && currentScene != 5 && currentScene != 6)
            {
                HintText.text = "If you are unsure on what to do next, speak with the Supervising Dietician and select the Learn More option.";
            }

            if (currentScene == 0)
            {
                if (Phase2DieticianConversationTracker == 0)
                {
                    ChatNextButtonText.text = "GATHER INFO";
                    ChatRightText.text = "Hi " + playerNameString + " How can I help you?";
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", true);
                }

            }
            else if (currentScene == 1)
            {
                ChatRightNameText.text = nurseNameString;
                ChatNextButtonText.text = "CLOSE";
                ChatRightText.text = "Chat text for the nurse";
                ChatTextRightHeaderImage.color = nurseChatHeaderColour;
                NPCRightChatPortrait.sprite = NursePortraitImage;
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightDefault", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 2)
            {
                ChatRightNameText.text = patientNameString;
                ChatNextButtonText.text = "CLOSE";
                ChatRightText.text = "";
                ChatTextRightHeaderImage.color = patientChatHeaderColour;
                NPCRightChatPortrait.sprite = PatientPortraitImage;
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightDefault", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 3)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
            }
            else if (currentScene == 4)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputer)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    biochemicalAnswersGroup.SetActive(true);
                }
            }
            else if (currentScene == 5)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inClipboard)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ClipboardButtonGroup.SetActive(true);
                    if (!inClipboardObservation)
                    {
                        observationsAnswerGroup.SetActive(false);
                        medicationAnswersGroup.SetActive(true);
                        anthropometryAnswersGroup.SetActive(false);
                        ObservationButtonText.text = "OBSERVATIONS";
                    }
                    else if (inClipboardObservation)
                    {
                        medicationAnswersGroup.SetActive(false);
                        anthropometryAnswersGroup.SetActive(true);
                        observationsAnswerGroup.SetActive(true);
                        ObservationButtonText.text = "MEDICATION";
                    }
                }
            }
            else if (currentScene == 6)
            {
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inMedicalChart)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    MedicalClipboardButtonGroup.SetActive(true);
                }
            }
        }
        else if (PhaseManagement.gamePhase == 4)
        //FOR ALL GAME PHASES I CAN TURN REPEAT CURRENTSCENE == x INFO INTO ITS ON FUNCTION
        //FOR ALL GAME PHASES I CAN TURN REPEAT CURRENTSCENE == x INFO INTO ITS ON FUNCTION            
        {
            if (inInvestigation)
            {
                NurseNavButton.interactable = false;
                DieticianNavButton.interactable = false;
                PatientNavButton.interactable = false;
                patientInvestigationSceneGroup.SetActive(true);
            }
            if (!inInvestigation)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
            }
            if (phase4Conversation1Done && phase4Conversation2Done && phase4Conversation3Done && phase4Conversation4Done)
            {
                if (!canExamNotificationShown)
                {
                    investigateChatButton.SetActive(true);
                    CanExamineNotificationToggle();
                    canExamNotificationShown = true;
                }

            }
            if (canInvestigate && !inInvestigation)
            {
                if (phase4Conversation5Done)
                {
                    if (!examinationHelperShown)
                    {
                        ExaminationContextHelperAnim.SetTrigger("ContextSensitiveHelperActivated");
                        examinationHelperShown = true;
                    }
                    ActivateInvestigationButton.interactable = true;
                    InvestigationButton.SetActive(true);
                }
            }
            if (inInvestigation || !canInvestigate)
            {
                ActivateInvestigationButton.interactable = false;
                InvestigationButton.SetActive(false);
            }
            if (!inComputer)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                biochemicalAnswersGroup.SetActive(false);
            }
            if (!inClipboard)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                medicationAnswersGroup.SetActive(false);
                anthropometryAnswersGroup.SetActive(false);
                ClipboardButtonGroup.SetActive(false);
            }
            if (!inMedicalChart)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                MedicalClipboardButtonGroup.SetActive(false);
            }
            if (inChat)
            {
                rayCastBlockImage.SetActive(true);
                ChatNextButton.interactable = true;
                ActivateChatButton.interactable = false;
            }
            else if (!inChat && currentScene != 3 && currentScene != 4 && currentScene != 5 && currentScene != 6)
            {
                rayCastBlockImage.SetActive(false);
                ChatNextButton.interactable = false;
                ActivateChatButton.interactable = true;
            }
            if (currentScene != 3)
            {
                HintText.text = "Martha has arrived back to her room and now you can speak with her.";
            }
            if (currentScene == 0)
            {
                canInvestigate = false;
                ChatRightNameText.text = dieteticSupervisorNameString;
                ChatNextButtonText.text = "NEXT";
                ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                NPCRightChatPortrait.sprite = DieticianPortraitImage;
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightOccupationalTherapistImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightOccupationalTherapistImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightOccupationalTherapistImage.SetBool("NPCRightAnimateOut", true);
                }
            }
            else if (currentScene == 1)
            {
                canInvestigate = false;
                ChatRightNameText.text = nurseNameString;
                ChatNextButtonText.text = "MORE";
                ChatTextRightHeaderImage.color = nurseChatHeaderColour;
                NPCRightChatPortrait.sprite = NursePortraitImage;
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightDefault", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightOccupationalTherapistImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightOccupationalTherapistImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightOccupationalTherapistImage.SetBool("NPCRightAnimateOut", true);
                }
            }
            else if (currentScene == 2)
            {
                HospitalSceneImage.sprite = InvestigationSceneSprite;
                canInvestigate = true;
                ChatNextButtonText.text = "CONTINUE";
                if (!phase4SpeakToOT)
                {
                    if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                    {
                        NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                        NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                    }
                    if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                    {
                        NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                        NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                    }
                    //if (NPCRightPatientImage.GetBool("NPCRightAnimateOut") == true)
                    //{
                    //    NPCRightPatientImage.SetBool("NPCRightAnimateOut", false);
                    //    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                    //}
                    //if (NPCRightPatientImage.GetBool("NPCRightDefault") == true)
                    //{
                    //    NPCRightPatientImage.SetBool("NPCRightDefault", false);
                    //    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                    //}
                    if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                    {
                        NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                        NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                    }
                }
                else
                {
                    if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                    {
                        NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                        NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                    }
                    if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                    {
                        NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                        NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                    }
                    if (NPCRightOccupationalTherapistImage.GetBool("NPCRightAnimateOut") == true)
                    {
                        NPCRightOccupationalTherapistImage.SetBool("NPCRightAnimateOut", false);
                        NPCRightOccupationalTherapistImage.SetBool("NPCRightAnimateIn", true);
                    }
                    if (NPCRightOccupationalTherapistImage.GetBool("NPCRightDefault") == true)
                    {
                        NPCRightOccupationalTherapistImage.SetBool("NPCRightDefault", false);
                        NPCRightOccupationalTherapistImage.SetBool("NPCRightAnimateIn", true);
                    }
                }

            }
            else if (currentScene == 4)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputer)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    biochemicalAnswersGroup.SetActive(true);
                }
            }
            else if (currentScene == 5)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightOccupationalTherapistImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightOccupationalTherapistImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightOccupationalTherapistImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inClipboard)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ClipboardButtonGroup.SetActive(true);
                    if (!inClipboardObservation)
                    {
                        observationsAnswerGroup.SetActive(false);
                        medicationAnswersGroup.SetActive(true);
                        anthropometryAnswersGroup.SetActive(false);
                        ObservationButtonText.text = "OBSERVATIONS";
                    }
                    else if (inClipboardObservation)
                    {
                        medicationAnswersGroup.SetActive(false);
                        anthropometryAnswersGroup.SetActive(true);
                        observationsAnswerGroup.SetActive(true);
                        ObservationButtonText.text = "MEDICATION";
                    }
                }
            }
            else if (currentScene == 6)
            {
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inMedicalChart)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    MedicalClipboardButtonGroup.SetActive(true);
                }
            }
        }
        else if (PhaseManagement.gamePhase == 5)
        {
            //FOR ALL GAME PHASES I CAN TURN REPEAT CURRENTSCENE == x INFO INTO ITS ON FUNCTION
            //HAVE ADDED FUNCTIONALITY FOR PHASE 4, DO NOT REWRITE ONLY CHANGE TEXT INFORMATION ETC... MUCHO IMPORTANTE           

            if (!inComputer)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                biochemicalAnswersGroup.SetActive(false);
            }
            if (!inClipboard)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                medicationAnswersGroup.SetActive(false);
                anthropometryAnswersGroup.SetActive(false);
                ClipboardButtonGroup.SetActive(false);
            }
            if (!inMedicalChart)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                AssessmentFormGroup.SetActive(false);
                AdmissionFormGroup.SetActive(false);
                ProgressNotesPage1Group.SetActive(false);
                ProgressNotesPage2Group.SetActive(false);
                MedicalClipboardButtonGroup.SetActive(false);
            }
            if (!inSGAForm)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                HintText.text = "You may now fill out the rest of the SGA Form, which can be found in the Supervising Dietitian's office. \n \n Informatiopn from Marta's examination have been filled out based on the results you enter during the exam.";
            }
            else if (inSGAForm)
            {
                NurseNavButton.interactable = false;
                DieticianNavButton.interactable = false;
                PatientNavButton.interactable = false;
                ActivateChatButton.interactable = false;
                HintText.text = "Click on the column A, B, or C based on the information you have gathered thus far. If you wish to select a different column the previously selected will be automatically deselected.";
            }
            if (inChat)
            {
                rayCastBlockImage.SetActive(true);
                //ChatNextButton.interactable = true;
                ActivateChatButton.interactable = false;
            }
            else if (!inChat && currentScene != 3 && currentScene != 4 && currentScene != 5 && currentScene != 6 && currentScene != 7)
            {
                rayCastBlockImage.SetActive(false);
                ChatNextButton.interactable = false;
                ActivateChatButton.interactable = true;
            }
            if (currentScene != 4 && currentScene != 5 && currentScene != 6 && currentScene != 7)
            {
                HintText.text = "If you are unsure on what to do next, speak with the Supervising Dietician in order to analyse and evaluate the information you have gathered.";
            }
            if (currentScene == 0)
            {
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 1)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightDefault", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 2)
            {
                HospitalSceneImage.sprite = HospitalSceneSprite;
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightDefault", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 3)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
            }
            else if (currentScene == 4)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputer)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    biochemicalAnswersGroup.SetActive(true);
                }
            }
            else if (currentScene == 5)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inClipboard)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ClipboardButtonGroup.SetActive(true);
                    if (!inClipboardObservation)
                    {
                        observationsAnswerGroup.SetActive(false);
                        medicationAnswersGroup.SetActive(true);
                        anthropometryAnswersGroup.SetActive(false);
                        ObservationButtonText.text = "OBSERVATIONS";
                    }
                    else if (inClipboardObservation)
                    {
                        medicationAnswersGroup.SetActive(false);
                        anthropometryAnswersGroup.SetActive(true);
                        observationsAnswerGroup.SetActive(true);
                        ObservationButtonText.text = "MEDICATION";
                    }
                }
            }
            else if (currentScene == 6)
            {
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inMedicalChart)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    MedicalClipboardButtonGroup.SetActive(true);
                }
            }
            else if (currentScene == 7)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inSGAForm)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ActivateChatButton.interactable = false;
                }
            }
        }
        else if (PhaseManagement.gamePhase == 6)
        {
            //FOR ALL GAME PHASES I CAN TURN REPEAT CURRENTSCENE == x INFO INTO ITS ON FUNCTION
            //HAVE ADDED FUNCTIONALITY FOR PHASE 4, DO NOT REWRITE ONLY CHANGE TEXT INFORMATION ETC... MUCHO IMPORTANTE           

            if (!inComputer)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                biochemicalAnswersGroup.SetActive(false);
            }
            if (!inComputerTwo)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                ComputerTwoBackButton.SetActive(false);
            }
            if (!inClipboard)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                medicationAnswersGroup.SetActive(false);
                anthropometryAnswersGroup.SetActive(false);
                ClipboardButtonGroup.SetActive(false);
            }
            if (!inMedicalChart)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                AssessmentFormGroup.SetActive(false);
                AdmissionFormGroup.SetActive(false);
                ProgressNotesPage1Group.SetActive(false);
                ProgressNotesPage2Group.SetActive(false);
                MedicalClipboardButtonGroup.SetActive(false);
            }
            if (inChat)
            {
                rayCastBlockImage.SetActive(true);
                ChatNextButton.interactable = true;
                ActivateChatButton.interactable = false;
            }
            else if (!inChat && currentScene != 3 && currentScene != 4 && currentScene != 5 && currentScene != 6 && currentScene != 7 && currentScene != 8)
            {
                rayCastBlockImage.SetActive(false);
                ChatNextButton.interactable = false;
                ActivateChatButton.interactable = true;
            }
            if (currentScene != 4 && currentScene != 5 && currentScene != 6 && currentScene != 7 && currentScene != 8)
            {
                HintText.text = "If you are unsure on what to do next, speak with the Supervising Dietician and he will direct you to the computer where you can continue your nutritional diagnosis.";
            }
            if (currentScene == 0)
            {
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", true);
                }

            }
            else if (currentScene == 1)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightDefault", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 2)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightDefault", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 3)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
            }
            else if (currentScene == 4)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputer)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    biochemicalAnswersGroup.SetActive(true);
                }
            }
            else if (currentScene == 5)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inClipboard)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ClipboardButtonGroup.SetActive(true);
                    if (!inClipboardObservation)
                    {
                        observationsAnswerGroup.SetActive(false);
                        medicationAnswersGroup.SetActive(true);
                        anthropometryAnswersGroup.SetActive(false);
                        ObservationButtonText.text = "OBSERVATIONS";
                    }
                    else if (inClipboardObservation)
                    {
                        medicationAnswersGroup.SetActive(false);
                        anthropometryAnswersGroup.SetActive(true);
                        observationsAnswerGroup.SetActive(true);
                        ObservationButtonText.text = "MEDICATION";
                    }
                }
            }
            else if (currentScene == 6)
            {
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inMedicalChart)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    MedicalClipboardButtonGroup.SetActive(true);
                }
            }
            else if (currentScene == 7)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inSGAForm)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ActivateChatButton.interactable = false;
                }
            }
            else if (currentScene == 8)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputerTwo)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ComputerTwoBackButton.SetActive(true);
                    HintText.text = "Once you have completed all steps on the computer press the BACK button and speak with John, the Supervising Dietitian, to find out what to do next.";
                }
            }
            else if (currentScene == 9)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputerThree)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ComputerThreeBackButton.SetActive(true);
                }
            }
        }
        else if (PhaseManagement.gamePhase == 7)
        {
            //FOR ALL GAME PHASES I CAN TURN REPEAT CURRENTSCENE == x INFO INTO ITS ON FUNCTION
            //HAVE ADDED FUNCTIONALITY FOR PHASE 4, DO NOT REWRITE ONLY CHANGE TEXT INFORMATION ETC... MUCHO IMPORTANTE           

            if (!inComputer)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                biochemicalAnswersGroup.SetActive(false);
            }
            if (!inComputerTwo)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                ComputerTwoBackButton.SetActive(false);
            }
            if (!inComputerThree)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                ComputerThreeBackButton.SetActive(false);
            }
            if (!inClipboard)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                medicationAnswersGroup.SetActive(false);
                anthropometryAnswersGroup.SetActive(false);
                ClipboardButtonGroup.SetActive(false);
            }
            if (!inMedicalChart)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                AssessmentFormGroup.SetActive(false);
                AdmissionFormGroup.SetActive(false);
                ProgressNotesPage1Group.SetActive(false);
                ProgressNotesPage2Group.SetActive(false);
                MedicalClipboardButtonGroup.SetActive(false);
            }
            if (!inSGAForm)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                HintText.text = "You may now fill out the rest of the SGA Form, which can be found in the Supervising Dietitian's office. \n \n Informatiopn from Marta's examination have been filled out based on the results you enter during the exam.";
            }
            else if (inSGAForm)
            {
                NurseNavButton.interactable = false;
                DieticianNavButton.interactable = false;
                PatientNavButton.interactable = false;
                ActivateChatButton.interactable = false;
                HintText.text = "Click on the column A, B, or C based on the information you have gathered thus far. If you wish to select a different column the previously selected will be automatically deselected.";
            }
            if (inChat)
            {
                rayCastBlockImage.SetActive(true);
                ChatNextButton.interactable = true;
                ActivateChatButton.interactable = false;
            }
            else if (!inChat && currentScene != 3 && currentScene != 4 && currentScene != 5 && currentScene != 6 && currentScene != 7 && currentScene != 8 && currentScene != 9)
            {
                rayCastBlockImage.SetActive(false);
                ChatNextButton.interactable = false;
                ActivateChatButton.interactable = true;
            }
            if (currentScene != 4 && currentScene != 5 && currentScene != 6 && currentScene != 7 && currentScene != 8 && currentScene != 9)
            {
                HintText.text = "If you are unsure on what to do next, speak with the Supervising Dietician and he will direct you to the computer where you can create a plan for Marta.";
            }
            if (currentScene == 0)
            {
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 1)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightDefault", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 2)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightDefault", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 3)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
            }
            else if (currentScene == 4)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputer)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    biochemicalAnswersGroup.SetActive(true);
                }
            }
            else if (currentScene == 5)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inClipboard)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ClipboardButtonGroup.SetActive(true);
                    if (!inClipboardObservation)
                    {
                        observationsAnswerGroup.SetActive(false);
                        medicationAnswersGroup.SetActive(true);
                        anthropometryAnswersGroup.SetActive(false);
                        ObservationButtonText.text = "OBSERVATIONS";
                    }
                    else if (inClipboardObservation)
                    {
                        medicationAnswersGroup.SetActive(false);
                        anthropometryAnswersGroup.SetActive(true);
                        observationsAnswerGroup.SetActive(true);
                        ObservationButtonText.text = "MEDICATION";
                    }
                }
            }
            else if (currentScene == 6)
            {
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inMedicalChart)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    MedicalClipboardButtonGroup.SetActive(true);
                }
            }
            else if (currentScene == 7)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inSGAForm)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ActivateChatButton.interactable = false;
                }
            }
            else if (currentScene == 8)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputerTwo)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ComputerTwoBackButton.SetActive(true);
                }
            }
            else if (currentScene == 9)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputerThree)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ComputerThreeBackButton.SetActive(true);
                    if (Phase7ConversationTracker < 1000)
                    {
                        HintText.text = "Once you have completed selecting your top 2 goals, and the selecting your 2 food related and 1 educational related strategies per goal, make sure you explain these to Marta before she is discharged later today.";
                    }
                    else if (Phase7ConversationTracker > 999)
                    {
                        HintText.text = "Now that you have completed your goals and strategies, you can leave the hospital using the  <b><color=#0E78A5FF>LEAVE HOSPITAL</color></b> button to wait for Marta to return and see the results.";
                    }
                }
            }
        }
        else if (PhaseManagement.gamePhase == 8)
        {
            //FOR ALL GAME PHASES I CAN TURN REPEAT CURRENTSCENE == x INFO INTO ITS ON FUNCTION
            //HAVE ADDED FUNCTIONALITY FOR PHASE 4, DO NOT REWRITE ONLY CHANGE TEXT INFORMATION ETC... MUCHO IMPORTANTE           

            if (!inComputer)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                biochemicalAnswersGroup.SetActive(false);
            }
            if (!inComputerTwo)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                ComputerTwoBackButton.SetActive(false);
            }
            if (!inComputerThree)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                ComputerThreeBackButton.SetActive(false);
            }
            if (!inClipboard)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                medicationAnswersGroup.SetActive(false);
                anthropometryAnswersGroup.SetActive(false);
                ClipboardButtonGroup.SetActive(false);
            }
            if (!inMedicalChart)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                AssessmentFormGroup.SetActive(false);
                AdmissionFormGroup.SetActive(false);
                ProgressNotesPage1Group.SetActive(false);
                ProgressNotesPage2Group.SetActive(false);
                MedicalClipboardButtonGroup.SetActive(false);
            }
            if (!inSGAForm)
            {
                NurseNavButton.interactable = true;
                DieticianNavButton.interactable = true;
                PatientNavButton.interactable = true;
                HintText.text = "You may now fill out the rest of the SGA Form, which can be found in the Supervising Dietitian's office. \n \n Informatiopn from Marta's examination have been filled out based on the results you enter during the exam.";
            }
            else if (inSGAForm)
            {
                NurseNavButton.interactable = false;
                DieticianNavButton.interactable = false;
                PatientNavButton.interactable = false;
                ActivateChatButton.interactable = false;
                HintText.text = "Click on the column A, B, or C based on the information you have gathered thus far. If you wish to select a different column the previously selected will be automatically deselected.";
            }
            if (inChat)
            {
                rayCastBlockImage.SetActive(true);
                ChatNextButton.interactable = true;
                ActivateChatButton.interactable = false;
            }
            else if (!inChat && currentScene != 3 && currentScene != 4 && currentScene != 5 && currentScene != 6 && currentScene != 7 && currentScene != 8 && currentScene != 9)
            {
                rayCastBlockImage.SetActive(false);
                ChatNextButton.interactable = false;
                ActivateChatButton.interactable = true;
            }
            if (currentScene != 4 && currentScene != 5 && currentScene != 6 && currentScene != 7 && currentScene != 8 && currentScene != 9)
            {
                HintText.text = "You can now talk to Marta to see how she has progressed after two weeks with your suggested goals and strategies. You can find Marta in the dietitians' office.";
            }
            if (currentScene == 0)
            {
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightDefault", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCLeftDieticianImage.GetBool("NPCLeftAnimateOut") == true)
                {
                    NPCLeftDieticianImage.SetBool("NPCLeftAnimateOut", false);
                    NPCLeftDieticianImage.SetBool("NPCLeftAnimateIn", true);
                }
                if (NPCLeftDieticianImage.GetBool("NPCLeftDefault") == true)
                {
                    NPCLeftDieticianImage.SetBool("NPCLeftDefault", false);
                    NPCLeftDieticianImage.SetBool("NPCLeftAnimateIn", true);
                }
            }
            else if (currentScene == 1)
            {
                if (NPCLeftDieticianImage.GetBool("NPCLeftAnimateIn") == true)
                {
                    NPCLeftDieticianImage.SetBool("NPCLeftAnimateIn", false);
                    NPCLeftDieticianImage.SetBool("NPCLeftAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateOut") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightDefault") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightDefault", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", true);
                }
            }
            else if (currentScene == 2)
            {
                if (NPCLeftDieticianImage.GetBool("NPCLeftAnimateIn") == true)
                {
                    NPCLeftDieticianImage.SetBool("NPCLeftAnimateIn", false);
                    NPCLeftDieticianImage.SetBool("NPCLeftAnimateOut", true);
                }
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
            }
            else if (currentScene == 3)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
            }
            else if (currentScene == 4)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputer)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    biochemicalAnswersGroup.SetActive(true);
                }
            }
            else if (currentScene == 5)
            {
                if (NPCRightPatientImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inClipboard)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ClipboardButtonGroup.SetActive(true);
                    if (!inClipboardObservation)
                    {
                        observationsAnswerGroup.SetActive(false);
                        medicationAnswersGroup.SetActive(true);
                        anthropometryAnswersGroup.SetActive(false);
                        ObservationButtonText.text = "OBSERVATIONS";
                    }
                    else if (inClipboardObservation)
                    {
                        medicationAnswersGroup.SetActive(false);
                        anthropometryAnswersGroup.SetActive(true);
                        observationsAnswerGroup.SetActive(true);
                        ObservationButtonText.text = "MEDICATION";
                    }
                }
            }
            else if (currentScene == 6)
            {
                if (NPCRightNurseImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightNurseImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightNurseImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inMedicalChart)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    MedicalClipboardButtonGroup.SetActive(true);
                }
            }
            else if (currentScene == 7)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inSGAForm)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ActivateChatButton.interactable = false;
                }
            }
            else if (currentScene == 8)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputerTwo)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ComputerTwoBackButton.SetActive(true);
                }
            }
            else if (currentScene == 9)
            {
                if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
                {
                    NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                }
                if (inComputerThree)
                {
                    NurseNavButton.interactable = false;
                    DieticianNavButton.interactable = false;
                    PatientNavButton.interactable = false;
                    ComputerThreeBackButton.SetActive(true);
                    if (Phase7ConversationTracker < 1000)
                    {
                        HintText.text = "Once you have completed selecting your top 2 goals, and the selecting your 2 food related and 1 educational related strategies per goal, make sure you explain these to Marta before she is discharged later today.";
                    }
                    else if (Phase7ConversationTracker > 999)
                    {
                        HintText.text = "Now that you have completed your goals and strategies, you can leave the hospital using the  <b><color=#0E78A5FF>LEAVE HOSPITAL</color></b> button to wait for Marta to return and see the results.";
                    }
                }
            }
        }
    }

    /// <summary>
    /// Handles saving the player's current progress.
    /// </summary>
    /// <param name="phaseNumber">The number of the phase just completed.</param>
    public void PhaseTransitionSave(int phaseNumber)
    {
        // Need to save all information required to later restore
        // the game to the start of the next phase.

        var payload = new List<PersistencePayload>();
        int playerId = LoginSystem.playerId;

        switch (phaseNumber)
        {
            case 1:
                // Player name.
                // Phase completed.
                payload.Add(new PersistencePayload("playerName", this.playerNameString));
                payload.Add(new PersistencePayload("phaseCompleted", phaseNumber.ToString()));
                //payload.Add(new PersistencePayload("gameStartConversationTracker", gameStartConversationTracker.ToString()));
                Unitycoding.LoginSystem.LoginSystem.SaveProgress(payload);
                break;
            case 2:
                payload.Add(new PersistencePayload("phaseCompleted", phaseNumber.ToString()));
                Unitycoding.LoginSystem.LoginSystem.SaveProgress(payload);
                break;
            case 3:
            default:
                payload.Add(new PersistencePayload("phaseCompleted", phaseNumber.ToString()));
                Unitycoding.LoginSystem.LoginSystem.SaveProgress(payload);
                break;
        }
    }

    public void ChangeDietHistoryToSchedule()
    {
        DietHistoryImage.sprite = DietHistoryScheduleSprite;
    }

    public void ChangeDietHistoryToCrossCheck()
    {
        DietHistoryImage.sprite = DietHistoryCrossCheckSprite;
    }

    public void AutoHintsToggle()
    {
        autoHints = !autoHints;
    }

    public void Phase07StartUpload()
    {
        if (!phase07UploadComplete)
        {
            phase07Uploading = true;
        }
        else if (phase07UploadComplete)
        {
            phase07UploadPopup.SetTrigger("AnimateOut");
            phase07PartTwoPopup.SetTrigger("AnimateIn");
        }
    }

    public void Phase07Part02ToPart03()
    {
        if (phase07Part02SelectedAmount > 0)
        {
            phase07PartTwoPopup.SetTrigger("AnimateOut");
            phase07PartThreePopup.SetTrigger("AnimateIn");
            phase07PartTwoComplete = true;
        }
        else
        {
            phase6part01AlertMessageText.text = "Please select at least one goal before proceeding.";
            Phase06Part01AlertMessageToggle();
        }
    }

    public void ClinpadHelperRunAnimation()
    {
        if (!ClinpadHelperAnimationHasRun)
        {
            ClinpadHelperAnim.SetTrigger("AnimateIn");
            ClinpadHelperAnimationHasRun = true;
        }
    }

    public void BMIUpdateCurrentHeight()
    {
        BMICalculatorCurrentHeight.text = "(" + BMICalculatorHeightInputField.text + " x " + BMICalculatorHeightInputField.text + ")";
    }

    public void BMIUpdateCurrentWeight()
    {
        BMICalculatorCurrentWeight.text = BMICalculatorWeightInputField.text;
    }

    public void BMIUpdateCurrentSymbol()
    {
        if (BMICalculatorSymbolDropdown.value == 0)
        {
            BMICalculatorCurrentSymbol.text = "+";
        }
        if (BMICalculatorSymbolDropdown.value == 1)
        {
            BMICalculatorCurrentSymbol.text = "-";
        }
        if (BMICalculatorSymbolDropdown.value == 2)
        {
            BMICalculatorCurrentSymbol.text = "x";
        }
        if (BMICalculatorSymbolDropdown.value == 3)
        {
            BMICalculatorCurrentSymbol.text = "/";
        }
    }

    public void Phase2MedicationListCheck()
    {
        Phase2SubmitIncorrectFeedbackListText.text = "";
        if (phase2MedicationsCorrectSelected01)
        {
            ClientHistoryCorrectAnswer17();
        }
        if (phase2MedicationsCorrectSelected02)
        {
            ClientHistoryCorrectAnswer18();
        }
        if (phase2MedicationsCorrectSelected03)
        {
            ClientHistoryCorrectAnswer19();
        }
        if (phase2MedicationsCorrectSelected04)
        {
            ClientHistoryCorrectAnswer20();
        }
        if (phase2MedicationsCorrectSelected05)
        {
            ClientHistoryCorrectAnswer21();
        }
        if (phase2MedicationsCorrectSelected06)
        {
            ClientHistoryCorrectAnswer22();
        }
        if (phase2MedicationsCorrectSelected07)
        {
            ClientHistoryCorrectAnswer23();
        }
        if (phase2MedicationsCorrectSelected08)
        {
            ClientHistoryCorrectAnswer24();
        }
        if (phase2MedicationsCorrectSelected09)
        {
            ClientHistoryCorrectAnswer25();
        }
        if (phase2MedicationsCorrectSelected10)
        {
            ClientHistoryCorrectAnswer26();
        }
        if (phase2MedicationCorrectSelectedScore >= 10)
        {
            if (phase2MedicationIncorrectSelectedScore <= 0)
            {
                Phase2SubmitCheckBackgroundImage.color = dietiticSupervisorChatHeaderColour;
                Phase2SubmitCheckFeedbackImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase2SubmitFeedbackText.text = "You have identified all of the factors that need further investigation.";
                Phase2SubmitFeedbackHeaderText.text = "COMPLETE LIST";
                notificationGoodSource.Play();
            }
            else if (phase2MedicationIncorrectSelectedScore > 0)
            {
                Phase2SubmitCheckBackgroundImage.color = dietiticSupervisorChatHeaderColour;
                Phase2SubmitFeedbackText.text = "You have identified all of the factors that need further investigation. But you have incorrect selections and you will be penalised.";
                Phase2SubmitCheckFeedbackImage.sprite = AlertIconSprite;
                Phase2SubmitFeedbackHeaderText.text = "COMPLETE LIST + INCORRECT CHOICES";
                Phase2SubmitIncorrectFeedbackListText.text = "INCORRECT CHOICES: \n";
                foreach (string item in Phase2MedicationIncorrectStringArray)
                {
                    Phase2SubmitIncorrectFeedbackListText.text = Phase2SubmitIncorrectFeedbackListText.text + item + "\n";
                }
            }
            phase2MedicationFinalScore = phase2MedicationCorrectSelectedScore - phase2MedicationIncorrectSelectedScore;

        }
        else if (phase2MedicationCorrectSelectedScore < 10)
        {
            if (phase2MedicationIncorrectSelectedScore <= 0)
            {
                Phase2SubmitCheckBackgroundImage.color = alertColour;
                Phase2SubmitCheckFeedbackImage.sprite = AlertIconSprite;
                Phase2SubmitFeedbackText.text = "You have only identified " + phase2MedicationCorrectSelectedScore + " out of a possible 10. Please go back and select the remaining adverse effects you need to consider.";
                Phase2SubmitFeedbackHeaderText.text = "INCOMPLETE LIST";
            }
            else if (phase2MedicationIncorrectSelectedScore > 0)
            {
                Phase2SubmitCheckBackgroundImage.color = warningColour;
                Phase2SubmitFeedbackText.text = "You have only identified " + phase2MedicationCorrectSelectedScore + " out of a possible 10. Please go back and select the remaining adverse effects you need to consider. You have also selected incorrect adverse effects.";
                Phase2SubmitCheckFeedbackImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
                Phase2SubmitFeedbackHeaderText.text = "INCOMPLETE LIST + INCORRECT CHOICES";
                Phase2SubmitIncorrectFeedbackListText.text = "INCORRECT CHOICES: \n";
                foreach (string item in Phase2MedicationIncorrectStringArray)
                {
                    Phase2SubmitIncorrectFeedbackListText.text = Phase2SubmitIncorrectFeedbackListText.text + item + "\n";
                }
            }
        }
        if (phase2MedicationIncorrectSelectedScore == 1)
        {
            phase02MedicationPlayerRating = playerRatingIntermediate;
            phase08OverallScore = phase08OverallScore + 1;
        }
        else if (phase2MedicationIncorrectSelectedScore > 1)
        {
            phase02MedicationPlayerRating = playerRatingNovice;
            phase08OverallScore = phase08OverallScore + 2;
        }
        Phase2MedicationMessageBoxAnim.SetBool("MenuDefault", false);
        Phase2MedicationMessageBoxAnim.SetBool("MenuDeactivated", false);
        Phase2MedicationMessageBoxAnim.SetBool("MenuActivated", true);
    }

    public void Phase2MedicationMessageBoxClose()
    {
        Phase2MedicationMessageBoxAnim.SetBool("MenuActivated", false);
        Phase2MedicationMessageBoxAnim.SetBool("MenuDeactivated", true);
    }

    public void Phase2MedicationCorrectAddedToList01()
    {
        if (!phase2MedicationsCorrectSelected01)
        {
            phase2MedicationsCorrectSelected01 = true;
            phase2MedicationCorrectSelectedScore += 1;
        }
        else
        {
            phase2MedicationsCorrectSelected01 = false;
            phase2MedicationCorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationCorrectAddedToList02()
    {
        if (!phase2MedicationsCorrectSelected02)
        {
            phase2MedicationsCorrectSelected02 = true;
            phase2MedicationCorrectSelectedScore += 1;
        }
        else
        {
            phase2MedicationsCorrectSelected02 = false;
            phase2MedicationCorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationCorrectAddedToList03()
    {
        if (!phase2MedicationsCorrectSelected03)
        {
            phase2MedicationsCorrectSelected03 = true;
            phase2MedicationCorrectSelectedScore += 1;
        }
        else
        {
            phase2MedicationsCorrectSelected03 = false;
            phase2MedicationCorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationCorrectAddedToList04()
    {
        if (!phase2MedicationsCorrectSelected04)
        {
            phase2MedicationsCorrectSelected04 = true;
            phase2MedicationCorrectSelectedScore += 1;
        }
        else
        {
            phase2MedicationsCorrectSelected04 = false;
            phase2MedicationCorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationCorrectAddedToList05()
    {
        if (!phase2MedicationsCorrectSelected05)
        {
            phase2MedicationsCorrectSelected05 = true;
            phase2MedicationCorrectSelectedScore += 1;
        }
        else
        {
            phase2MedicationsCorrectSelected05 = false;
            phase2MedicationCorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationCorrectAddedToList06()
    {
        if (!phase2MedicationsCorrectSelected06)
        {
            phase2MedicationsCorrectSelected06 = true;
            phase2MedicationCorrectSelectedScore += 1;
        }
        else
        {
            phase2MedicationsCorrectSelected06 = false;
            phase2MedicationCorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationCorrectAddedToList07()
    {
        if (!phase2MedicationsCorrectSelected07)
        {
            phase2MedicationsCorrectSelected07 = true;
            phase2MedicationCorrectSelectedScore += 1;
        }
        else
        {
            phase2MedicationsCorrectSelected07 = false;
            phase2MedicationCorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationCorrectAddedToList08()
    {
        if (!phase2MedicationsCorrectSelected08)
        {
            phase2MedicationsCorrectSelected08 = true;
            phase2MedicationCorrectSelectedScore += 1;
        }
        else
        {
            phase2MedicationsCorrectSelected08 = false;
            phase2MedicationCorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationCorrectAddedToList09()
    {
        if (!phase2MedicationsCorrectSelected09)
        {
            phase2MedicationsCorrectSelected09 = true;
            phase2MedicationCorrectSelectedScore += 1;
        }
        else
        {
            phase2MedicationsCorrectSelected09 = false;
            phase2MedicationCorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationCorrectAddedToList10()
    {
        if (!phase2MedicationsCorrectSelected10)
        {
            phase2MedicationsCorrectSelected10 = true;
            phase2MedicationCorrectSelectedScore += 1;
        }
        else
        {
            phase2MedicationsCorrectSelected10 = false;
            phase2MedicationCorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationIncorrectAddedToList01()
    {
        if (!phase2MedicationsIncorrectSelected01)
        {
            Phase2MedicationIncorrectStringArray.Add("Dietary folic acid deficiency");
            phase2MedicationsIncorrectSelected01 = true;
            phase2MedicationIncorrectSelectedScore += 1;

        }
        else
        {
            Phase2MedicationIncorrectStringArray.Remove("Dietary folic acid deficiency");
            phase2MedicationsIncorrectSelected01 = false;
            phase2MedicationIncorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationIncorrectAddedToList02()
    {
        if (!phase2MedicationsIncorrectSelected02)
        {
            Phase2MedicationIncorrectStringArray.Add("Infection");
            phase2MedicationsIncorrectSelected02 = true;
            phase2MedicationIncorrectSelectedScore += 1;
        }
        else
        {
            Phase2MedicationIncorrectStringArray.Remove("Infection");
            phase2MedicationsIncorrectSelected02 = false;
            phase2MedicationIncorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationIncorrectAddedToList03()
    {
        if (!phase2MedicationsIncorrectSelected03)
        {
            Phase2MedicationIncorrectStringArray.Add("Headaches");
            phase2MedicationsIncorrectSelected03 = true;
            phase2MedicationIncorrectSelectedScore += 1;
        }
        else
        {
            Phase2MedicationIncorrectStringArray.Remove("Headaches");
            phase2MedicationsIncorrectSelected03 = false;
            phase2MedicationIncorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationIncorrectAddedToList04()
    {
        if (!phase2MedicationsIncorrectSelected04)
        {
            Phase2MedicationIncorrectStringArray.Add("Pyrexia");
            phase2MedicationsIncorrectSelected04 = true;
            phase2MedicationIncorrectSelectedScore += 1;
        }
        else
        {
            Phase2MedicationIncorrectStringArray.Remove("Pyrexia");
            phase2MedicationsIncorrectSelected04 = false;
            phase2MedicationIncorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationIncorrectAddedToList05()
    {
        if (!phase2MedicationsIncorrectSelected05)
        {
            Phase2MedicationIncorrectStringArray.Add("Dizziness");
            phase2MedicationsIncorrectSelected05 = true;
            phase2MedicationIncorrectSelectedScore += 1;
        }
        else
        {
            Phase2MedicationIncorrectStringArray.Remove("Dizziness");
            phase2MedicationsIncorrectSelected05 = false;
            phase2MedicationIncorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationIncorrectAddedToList06()
    {
        if (!phase2MedicationsIncorrectSelected06)
        {
            Phase2MedicationIncorrectStringArray.Add("Dyspnea");
            phase2MedicationsIncorrectSelected06 = true;
            phase2MedicationIncorrectSelectedScore += 1;
        }
        else
        {
            Phase2MedicationIncorrectStringArray.Remove("Dyspnea");
            phase2MedicationsIncorrectSelected06 = false;
            phase2MedicationIncorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationIncorrectAddedToList07()
    {
        if (!phase2MedicationsIncorrectSelected07)
        {
            Phase2MedicationIncorrectStringArray.Add("Increased sweating");
            phase2MedicationsIncorrectSelected07 = true;
            phase2MedicationIncorrectSelectedScore += 1;
        }
        else
        {
            Phase2MedicationIncorrectStringArray.Remove("Increased sweating");
            phase2MedicationsIncorrectSelected07 = false;
            phase2MedicationIncorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationIncorrectAddedToList08()
    {
        if (!phase2MedicationsIncorrectSelected08)
        {
            Phase2MedicationIncorrectStringArray.Add("Tremors");
            phase2MedicationsIncorrectSelected08 = true;
            phase2MedicationIncorrectSelectedScore += 1;
        }
        else
        {
            Phase2MedicationIncorrectStringArray.Remove("Tremors");
            phase2MedicationsIncorrectSelected08 = false;
            phase2MedicationIncorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationIncorrectAddedToList09()
    {
        if (!phase2MedicationsIncorrectSelected09)
        {
            Phase2MedicationIncorrectStringArray.Add("Phosphate deficiency");
            phase2MedicationsIncorrectSelected09 = true;
            phase2MedicationIncorrectSelectedScore += 1;
        }
        else
        {
            Phase2MedicationIncorrectStringArray.Remove("Phosphate deficiency");
            phase2MedicationsIncorrectSelected09 = false;
            phase2MedicationIncorrectSelectedScore -= 1;
        }
    }

    public void Phase2MedicationIncorrectAddedToList10()
    {
        if (!phase2MedicationsIncorrectSelected10)
        {
            Phase2MedicationIncorrectStringArray.Add("Calcium deficiency");
            phase2MedicationsIncorrectSelected10 = true;
            phase2MedicationIncorrectSelectedScore += 1;
        }
        else
        {
            Phase2MedicationIncorrectStringArray.Remove("Calcium deficiency");
            phase2MedicationsIncorrectSelected10 = false;
            phase2MedicationIncorrectSelectedScore -= 1;
        }
    }

    public void WeightChangeCalculation()
    {

        if (WeightChangeCalculatorTypicalWeightInputField.text != "")
        {
            float typicalWeightFloat = float.Parse(WeightChangeCalculatorTypicalWeightInputField.text);
            WeightChangeCalculationText.text = "";
            if (WeightChangeCalculatorCurrentWeightInputField.text != "")
            {
                float currentWeightFloat = float.Parse(WeightChangeCalculatorCurrentWeightInputField.text);
                float weightChangeAmount = (typicalWeightFloat - currentWeightFloat) / typicalWeightFloat * 100;
                WeightChangeresult.text = weightChangeAmount.ToString();
            }
        }
    }

    public void WeightChangeWeightUpdate()
    {
        if (WeightChangeCalculatorTypicalWeightInputField.text != "" && WeightChangeCalculatorCurrentWeightInputField.text != "")
        {
            WeightChangeCalculationText.text = "(" + WeightChangeCalculatorTypicalWeightInputField.text + " - " + WeightChangeCalculatorCurrentWeightInputField.text + ") " + " / " + WeightChangeCalculatorTypicalWeightInputField.text + " * 100";
        }
        else
        {
            WeightChangeCalculationText.text = "ERR";
        }
    }

    public void BMICalculation()
    {
        if (BMICalculatorHeightInputField.text != "")
        {
            float BMIHeightFloat = float.Parse(BMICalculatorHeightInputField.text);
            if (BMICalculatorWeightInputField.text != "")
            {
                float BMIWeightFloat = float.Parse(BMICalculatorWeightInputField.text);
                if (BMICalculatorSymbolDropdown.value == 0)
                {
                    float BMIHeightCMToMFloat = BMIHeightFloat * 0.01f;
                    float BMIHeightRecalculateFloat = BMIHeightCMToMFloat * BMIHeightCMToMFloat;
                    BMIResultInt = Mathf.FloorToInt(BMIWeightFloat + BMIHeightRecalculateFloat);
                    BMICalculatorResult.text = BMIResultInt.ToString();
                    ClinpadBMIInfo.text = BMIResultInt.ToString();
                }
                else if (BMICalculatorSymbolDropdown.value == 1)
                {
                    float BMIHeightCMToMFloat = BMIHeightFloat * 0.01f;
                    float BMIHeightRecalculateFloat = BMIHeightCMToMFloat * BMIHeightCMToMFloat;
                    BMIResultInt = Mathf.FloorToInt(BMIWeightFloat - BMIHeightRecalculateFloat);
                    BMICalculatorResult.text = BMIResultInt.ToString();
                    ClinpadBMIInfo.text = BMIResultInt.ToString();
                }
                else if (BMICalculatorSymbolDropdown.value == 2)
                {
                    float BMIHeightCMToMFloat = BMIHeightFloat * 0.01f;
                    float BMIHeightRecalculateFloat = BMIHeightCMToMFloat * BMIHeightCMToMFloat;
                    BMIResultInt = Mathf.FloorToInt(BMIWeightFloat * BMIHeightRecalculateFloat);
                    BMICalculatorResult.text = BMIResultInt.ToString();
                    ClinpadBMIInfo.text = BMIResultInt.ToString();
                }
                else if (BMICalculatorSymbolDropdown.value == 3)
                {
                    float BMIHeightCMToMFloat = BMIHeightFloat * 0.01f;
                    float BMIHeightRecalculateFloat = BMIHeightCMToMFloat * BMIHeightCMToMFloat;
                    BMIResultInt = Mathf.FloorToInt(BMIWeightFloat / BMIHeightRecalculateFloat);
                    BMICalculatorResult.text = BMIResultInt.ToString();
                    ClinpadBMIInfo.text = BMIResultInt.ToString();
                }
            }
            else
            {
                BMICalculatorAlertMessageGroupText.text = "Please Enter a weight in kilograms into the weight field";
                BMICalculatorAlertMessageToggle();
            }
        }
        else
        {
            BMICalculatorAlertMessageGroupText.text = "Please Enter a height in centimeters into the height field";
            BMICalculatorAlertMessageToggle();
        }
        if (!BMICalculated)
        {
            if (BMIResultInt >= 20 && BMIResultInt <= 22)
            {
                Phase2AnthropometryAnswerSelected += 1;
                phase2AnthropometryProgressFillImage.fillAmount = Phase2AnthropometryAnswerSelected / Phase2AnthropometryAnswerTotal;
                BMICalculated = true;
            }
            else
            {
                if (!bmiCalculatedWrongFirstTime)
                {
                    phase02AnthropometryPlayerRating = playerRatingIntermediate;
                    phase08OverallScore = phase08OverallScore + 1;
                    bmiCalculatedWrongFirstTime = true;
                    phase02CombinedScore++;
                }
                else
                {
                    phase02AnthropometryPlayerRating = playerRatingNovice;
                    phase08OverallScore = phase08OverallScore + 2;
                    phase02CombinedScore++;
                }
            }
        }
    }

    public void MedicalChartAdmissionForm()
    {
        if (AdmissionFormGroup.activeSelf != true)
        {
            AssessmentFormGroup.SetActive(false);
            ProgressNotesPage1Group.SetActive(false);
            ProgressNotesPage2Group.SetActive(false);
            pageTurnSource.Play();
            AdmissionFormGroup.SetActive(true);
        }
    }

    public void MedicalChartAssessmentForm()
    {
        if (AssessmentFormGroup.activeSelf != true)
        {
            AdmissionFormGroup.SetActive(false);
            ProgressNotesPage1Group.SetActive(false);
            ProgressNotesPage2Group.SetActive(false);
            pageTurnSource.Play();
            AssessmentFormGroup.SetActive(true);
        }
    }

    public void MedicalChartProgressNotesPage1Form()
    {
        if (ProgressNotesPage1Group.activeSelf != true)
        {
            AssessmentFormGroup.SetActive(false);
            AdmissionFormGroup.SetActive(false);
            ProgressNotesPage2Group.SetActive(false);
            pageTurnSource.Play();
            ProgressNotesPage1Group.SetActive(true);
        }
    }

    public void MedicalChartProgressNotesPage2Form()
    {
        if (ProgressNotesPage2Group.activeSelf != true)
        {
            AssessmentFormGroup.SetActive(false);
            AdmissionFormGroup.SetActive(false);
            ProgressNotesPage1Group.SetActive(false);
            pageTurnSource.Play();
            ProgressNotesPage2Group.SetActive(true);
        }
    }

    public void SGAFormPage()
    {
        if (SGAFormGroup.activeSelf != true)
        {
            FoodGroupResourceGroup.SetActive(false);
            ReadyReckonerResourceGroup.SetActive(false);
            SGAFormGroup.SetActive(true);
            pageTurnSource.Play();
        }
    }

    public void FoodGroupResourcePage()
    {
        if (FoodGroupResourceGroup.activeSelf != true)
        {
            ReadyReckonerResourceGroup.SetActive(false);
            SGAFormGroup.SetActive(false);
            FoodGroupResourceGroup.SetActive(true);
            pageTurnSource.Play();
        }
    }

    public void ReadyReckonerResourcePage()
    {
        if (ReadyReckonerResourceGroup.activeSelf != true)
        {
            FoodGroupResourceGroup.SetActive(false);
            SGAFormGroup.SetActive(false);
            ReadyReckonerResourceGroup.SetActive(true);
            pageTurnSource.Play();
        }
    }

    public void ShowClinPad()
    {
        if (clinPadAnim.GetBool("MoveIn") == false)
        {
            clinPadAnim.SetBool("MoveIn", true);
            ClinpadRayCastBlockImage.SetActive(true);
        }
        else
        {
            clinPadAnim.SetBool("MoveIn", false);
            ClinpadRayCastBlockImage.SetActive(false);
        }
    }

    public void ButtonToggle()
    {
        if (buttonToggleAnim.GetBool("ToggleDefault") == true)
        {
            buttonToggleAnim.SetBool("ToggleDefault", false);
        }
        else if (buttonToggleAnim.GetBool("ToggleOn") == false)
        {
            buttonToggleAnim.SetBool("ToggleOn", true);
        }
        else if (buttonToggleAnim.GetBool("ToggleOn") == true)
        {
            buttonToggleAnim.SetBool("ToggleOn", false);
        }
    }

    public void MenuToggle()
    {
        if (menuToggleAnim.GetBool("MenuDefault") == true)
        {
            menuToggleAnim.SetBool("MenuDefault", false);
            menuToggleAnim.SetBool("MenuActivated", true);
        }
        else if (menuToggleAnim.GetBool("MenuActivated") == false)
        {
            menuToggleAnim.SetBool("MenuActivated", true);
        }
        else if (menuToggleAnim.GetBool("MenuActivated") == true)
        {
            menuToggleAnim.SetBool("MenuActivated", false);
        }
    }

    public void GameStart()
    {
        if (gameStartConversationTracker == 0)
        {
            ChatNextButton.interactable = false;
            NotificationMessageBoxAnim.SetBool("MenuDefault", false);
            NotificationMessageBoxAnim.SetBool("MenuActivated", true);
            notificationGoodSource.Play();
            gameStartConversationTracker = 1;
        }
        else if (gameStartConversationTracker == 1)
        {
            notificationButtonText.text = "OK";
            notificationInformationText.text = "You are a Student Dietitian on placement at University Hospital.  It’s your second week and you are seeing a patient on your own today, with help from your supervisor and other health professionals.";
            gameStartConversationTracker = 2;
        }
        else if (gameStartConversationTracker == 2)
        {
            NotificationMessageBoxAnim.SetBool("MenuActivated", false);
            ChatStart();
            gameStartConversationTracker = 3;
            ChatNextButton.interactable = true;
        }
    }

    public void OpenSGADocument()
    {
        if (SGADocumentAnim.GetBool("MenuDefault") == true)
        {
            SGADocumentAnim.SetBool("MenuDefault", false);
            SGADocumentAnim.SetBool("MenuActivated", true);
            physicalExamButton.SetActive(false);
        }
        else if (SGADocumentAnim.GetBool("MenuActivated") == false)
        {
            SGADocumentAnim.SetBool("MenuActivated", true);
            physicalExamButton.SetActive(false);
        }
        else if (SGADocumentAnim.GetBool("MenuActivated") == true)
        {
            SGADocumentAnim.SetBool("MenuActivated", false);
            physicalExamButton.SetActive(true);
        }
    }

    public void PlayerNamePrompt()
    {
        if (gameStartConversationTracker == 3)
        {
            PlayerNamePromptAnim.SetBool("MenuDefault", false);
            PlayerNamePromptAnim.SetBool("MenuActivated", true);
            notificationGoodSource.Play();
            gameStartConversationTracker = 4;
            playerNamePromptInputField.ActivateInputField();
        }
        else if (gameStartConversationTracker == 4)
        {
            if (!ConsistsOfWhiteSpace(playerNamePromptInputField.text.ToString()) && playerNamePromptInputField.text.Length > 0)
            {
                playerNameString = playerNamePromptInputField.text;
                playerNameClinPadText.text = playerNameString;
                playerNameString.TrimEnd(' ');
                playerNameString.TrimStart(' ');
                PlayerNamePromptAnim.SetBool("MenuActivated", false);
                gameStartConversationTracker = 5;
                ChatContinue();
            }
            else
            {
                playerNamePromptInfoText.text = "Please enter a valid name";
                playerNamePromptInfoText.color = warningColour;
            }
        }
    }

    public bool ConsistsOfWhiteSpace(string s)
    {
        foreach (char c in s)
        {
            if (c != ' ') return false;
        }
        return true;
    }

    public void ChatStart()
    {
        if (PhaseManagement.gamePhase == 1)
        {
            if (ChatRightAnim.GetBool("ChatDefault") == true)
            {
                ContextSensitiveNextChatHelperAnim.SetTrigger("ContextSensitiveHelperActivated");
                NPCRightDieticianImage.SetBool("NPCRightDefault", false);
                NPCRightDieticianImage.SetBool("NPCRightAnimateIn", true);
                ChatRightAnim.SetBool("ChatDefault", false);
                ChatRightAnim.SetBool("ChatActivated", true);
                introConversationTracker = 1;
            }
        }
    }

    public void TransitionPhase3ToPhase4()
    {
        // From Q key handler.  (Used to skip phases.)
        //PhaseReachedText.text = "REACHED PHASE 4";
        //nextPhaseSource.Play();
        //PhaseReachedAnim.SetTrigger("PhaseReached");
        currentPhaseProgressFillImage.fillAmount = 0;
        currentPhaseText.text = "4th";
        totalProgressFillImage.fillAmount = 0.375f;
        totalProgressAmountText.text = "37.5%";
        Phase3ProgressGroup.SetActive(false);
        PhaseManagement.gamePhase = 4;
    }

    public void TransitionPhase2ToPhase3()
    {
        //// Internal (non-UI) related properties.
        //introConversationTracker = 15;
        //rayCastBlockImage.SetActive(false);
        //ActivateChatButton.interactable = false;
        //ActivateInvestigationButton.interactable = false;
        //ChatNextButton.interactable = false;
        //canComputer = true;
        //canAnthropometry = true;
        //canMedicalHistory = true;
        //inChat = false;

        //PhaseManagement.gamePhase = 2;

        //// UI Properties to be set upon restoration.
        //currentPhaseProgressFillImage.fillAmount = 0;
        //currentPhaseText.text = "2nd";
        //totalProgressFillImage.fillAmount = 0.125f;
        //totalProgressAmountText.text = "12.5%";
        //Phase1ProgressGroup.SetActive(false);

        //ContextSensitiveNavigationHelperAnim.SetTrigger("ContextSensitiveHelperActivated");

        // Copied from the keyboard shortcut to skip phases.  ('Q'.)
        currentPhaseText.text = "3rd";
        currentPhaseProgressFillImage.fillAmount = 0;
        totalProgressFillImage.fillAmount = 0.25f;
        totalProgressAmountText.text = "25%";
        //if (!alreadyReachedPhase3)
        //{
        //    nextPhaseSource.Play();
        //    PhaseReachedAnim.SetTrigger("PhaseReached");
        //    PhaseReachedText.text = "REACHED PHASE 3";
        //    alreadyReachedPhase3 = true;
        //}
        Phase2ProgressGroup.SetActive(false);
        Phase3PresentFindingsConversationTracker = 1;
        BMICalculatorGroup.SetActive(false);
        PhaseManagement.gamePhase = 3;
        
        alreadyReachedPhase3 = true;

        // Enable the present findings button.
        PresentFindingsButton.SetActive(true);

        // Phase 3 starts at the Dietician's Office.
        //if (isCurrentPhase)
        //{
        //    DieticianNavButton.interactable = true;
        //    DieticianNavButton.isOn = true;
        //}
    }

    public void TransitionPhase1ToPhase2()
    {
        // Internal (non-UI) related properties.
        introConversationTracker = 15;
        rayCastBlockImage.SetActive(false);
        ActivateChatButton.interactable = false;
        ActivateInvestigationButton.interactable = false;
        ChatNextButton.interactable = false;
        canComputer = true;
        canAnthropometry = true;
        canMedicalHistory = true;
        inChat = false;

        PhaseManagement.gamePhase = 2;

        // UI Properties to be set upon restoration.
        currentPhaseProgressFillImage.fillAmount = 0;
        currentPhaseText.text = "2nd";
        totalProgressFillImage.fillAmount = 0.125f;
        totalProgressAmountText.text = "12.5%";
        Phase1ProgressGroup.SetActive(false);

        //ContextSensitiveNavigationHelperAnim.SetTrigger("ContextSensitiveHelperActivated");
        // Phase 2 starts at the nurses' station.
        //if (isCurrentPhase)
        //{
        //    NurseNavButton.interactable = true;
        //    NurseNavButton.isOn = true;
        //}
    }

    public void TransitionPhase0ToPhase1()
    {
        TranscribeClientHistoryGroup.SetActive(false);
        TranscribeAnthropometryGroup.SetActive(false);
        TranscribeFoodAndNutritionGroup.SetActive(false);
        TranscribeNutitionDiagnosisTabButton.SetActive(false);
        TranscribeInterventionPlanTabButton.SetActive(false);
        TranscribeMonitoringAndEvaluationTabButton.SetActive(false);
        weightChangeCalculatorGroup.SetActive(false);
        TranscribeAnthropometryGroupTab();
        SetDateOnProgressNotes();
    }

    public void ChatContinue()
    {
        if (MenuButton.isOn)
        {
            MenuButton.isOn = false;
        }
        if (HelpMenuButton.isOn)
        {
            HelpMenuButton.isOn = false;
        }
        if (HintMenuButton.isOn)
        {
            HintMenuButton.isOn = false;
        }
        if (PhaseManagement.gamePhase == 1)
        {
            if (introConversationTracker == 1)
            {
                ChatNextButton.interactable = false;
                PlayerNamePrompt();
                introConversationTracker = 2;
            }
            else if (introConversationTracker == 2)
            {
                ChatNextButton.interactable = true;
                ChatRightTwoText.text = "Welcome " + playerNameString + "! Today, you'll be seeing Marta Haertman. She's been referred for dietetic assessment with an MST score of 2.";
                ChatRightThreeNameText.text = dieteticSupervisorNameString;
                ChatTextRightThreeHeaderImage.color = dietiticSupervisorChatHeaderColour;
                ChatRightThreeText.text = "I'll let you do the entire nutrition care plan, starting with information gathering and all the way to diagnosis and intervention. She's your patient today, but I'll be available to answer any questions you have.";
                ChatRightAnim.SetBool("ChatActivated", false);
                ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightTwoAnim.SetBool("ChatDefault", false);
                ChatRightTwoAnim.SetBool("ChatActivated", true);
                ChatNextButtonText.text = "CONTINUE";
                introConversationTracker = 3;
            }
            else if (introConversationTracker == 3)
            {
                ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightAnim.SetBool("ChatDefault", true);
                ChatRightTwoAnim.SetBool("ChatActivated", false);
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightThreeAnim.SetBool("ChatDefault", false);
                ChatRightThreeAnim.SetBool("ChatActivated", true);
                ChatRightText.text = "Here is your Clinpad, which is where you'll record your patient information. The Clinpad is set-up according to the nutrition care process for you to save relevant and important information onto. This information will be available to you when you have to write a nutrition diagnosis and write your intervention plan.";
                introConversationTracker = 4;
            }
            else if (introConversationTracker == 4)
            {
                ClinpadButton.SetActive(true);
                ContextSensitiveClinpadHelperAnim.SetTrigger("ContextSensitiveHelperActivated");
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightTwoAnim.SetBool("ChatDefault", true);
                ChatRightThreeAnim.SetBool("ChatActivated", false);
                ChatRightThreeAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightAnim.SetBool("ChatDefault", false);
                ChatRightAnim.SetBool("ChatActivated", true);
                ChatRightTwoText.text = "You can find information on Marta's condition by working through her charts, talking to other medical staff and on the computer here in my office.";
                introConversationTracker = 5;
            }

            else if (introConversationTracker == 5)
            {
                ChatRightThreeAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightThreeAnim.SetBool("ChatDefault", true);
                ChatRightAnim.SetBool("ChatActivated", false);
                ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightTwoAnim.SetBool("ChatDefault", false);
                ChatRightTwoAnim.SetBool("ChatActivated", true);
                ChatRightThreeText.text = "You will follow the usual steps from information gathering, interpretation and evaluation to identifying Marta's key nutritional concerns and decide what will be the most important nutrition problem to address in the first instance. You will then have to identify appropriate strategies for Marta to implement once she is home to address this problem.";
                introConversationTracker = 6;
            }
            else if (introConversationTracker == 6)
            {
                ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightAnim.SetBool("ChatDefault", true);
                ChatRightTwoAnim.SetBool("ChatActivated", false);
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightThreeAnim.SetBool("ChatDefault", false);
                ChatRightThreeAnim.SetBool("ChatActivated", true);
                ChatRightText.text = "Let's go meet Makenna, who will show you where the charts are located.";
                introConversationTracker = 7;
            }
            else if (introConversationTracker == 7)
            {
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightTwoAnim.SetBool("ChatDefault", true);
                ChatRightThreeAnim.SetBool("ChatActivated", false);
                ChatRightThreeAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightAnim.SetBool("ChatDefault", false);
                ChatRightAnim.SetBool("ChatActivated", true);
                ChatRightTwoText.text = "Hi Makenna, this is " + playerNameString + " who will be assessing Marta Haertman. Can you orientate " + playerNameString + " to the ward?";
                ChatNextButtonText.text = "MEET NURSE";
                introConversationTracker = 8;
            }
            else if (introConversationTracker == 8)
            {
                NurseNavButton.interactable = true;
                NurseNavButton.isOn = true;
                NPCLeftNurseImage.SetBool("NPCLeftDefault", false);
                NPCLeftNurseImage.SetBool("NPCLeftAnimateIn", true);
                ChatRightThreeAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightThreeAnim.SetBool("ChatDefault", true);
                ChatRightAnim.SetBool("ChatActivated", false);
                ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightTwoAnim.SetBool("ChatDefault", false);
                ChatRightTwoAnim.SetBool("ChatActivated", true);
                ChatTextLeftHeaderImage.color = nurseChatHeaderColour;
                ChatLeftNameText.text = nurseNameString;
                NPCLeftChatPortraitImage.sprite = NursePortraitImage;
                ChatLeftText.text = "Welcome to University Hospital, " + playerNameString + ". I'll get you orientated to the ward.";
                ChatNextButtonText.text = "SAY HI";
                introConversationTracker = 9;
            }
            else if (introConversationTracker == 9)
            {
                ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightAnim.SetBool("ChatDefault", true);
                ChatRightTwoAnim.SetBool("ChatActivated", false);
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                ChatLeftAnim.SetBool("ChatDefault", false);
                ChatLeftAnim.SetBool("ChatActivated", true);
                ChatNextButtonText.text = "CONTINUE";
                ChatTextLeftTwoHeaderImage.color = nurseChatHeaderColour;
                ChatLeftTwoNameText.text = nurseNameString;
                NPCLeftChatTwoPortraitImage.sprite = NursePortraitImage;
                ChatLeftTwoText.text = "The medical chart can be found here at the nurses' station, the bed chart is found in Marta’s room in the patient ward.";
                introConversationTracker = 10;
            }
            else if (introConversationTracker == 10)
            {
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightTwoAnim.SetBool("ChatDefault", true);
                ChatLeftAnim.SetBool("ChatActivated", false);
                ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                ChatLeftTwoAnim.SetBool("ChatDefault", false);
                ChatLeftTwoAnim.SetBool("ChatActivated", true);
                ChatRightText.text = "You'll need to check in with me several times during the day to give me a quick briefing of what you've done and get the okay to move forward.";
                introConversationTracker = 11;
            }
            else if (introConversationTracker == 11)
            {
                ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                ChatLeftAnim.SetBool("ChatDefault", true);
                ChatLeftTwoAnim.SetBool("ChatActivated", false);
                ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightAnim.SetBool("ChatDefault", false);
                ChatRightAnim.SetBool("ChatActivated", true);
                ChatRightTwoText.text = "Well, I’ve got a few patients to see, but you can check my office if you need me.";
                introConversationTracker = 12;
            }
            else if (introConversationTracker == 12)
            {
                ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                ChatLeftTwoAnim.SetBool("ChatDefault", true);
                ChatRightAnim.SetBool("ChatActivated", false);
                ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightTwoAnim.SetBool("ChatDefault", false);
                ChatRightTwoAnim.SetBool("ChatActivated", true);
                ChatLeftText.text = "And I’m usually around the nursing station if you have questions. You can visit the patient in the patient ward too.";
                introConversationTracker = 13;
            }
            else if (introConversationTracker == 13)
            {
                ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightAnim.SetBool("ChatDefault", true);
                ChatRightTwoAnim.SetBool("ChatActivated", false);
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                ChatLeftAnim.SetBool("ChatDefault", false);
                ChatLeftAnim.SetBool("ChatActivated", true);
                ChatNextButtonText.text = "LEAVE CHAT";
                introConversationTracker = 14;
            }

            else if (introConversationTracker == 14)
            {
                // Animation related changes.
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightTwoAnim.SetBool("ChatDefault", true);
                ChatLeftAnim.SetBool("ChatActivated", false);
                ChatLeftAnim.SetBool("ChatDefault", true);
                NPCLeftNurseImage.SetBool("NPCLeftAnimateIn", false);
                NPCLeftNurseImage.SetBool("NPCLeftAnimateOut", true);
                NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
                NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
                nextPhaseSource.Play();
                PhaseReachedAnim.SetTrigger("PhaseReached");

                PhaseTransitionSave(1);

                TransitionPhase1ToPhase2();

                //PhaseManagement.gamePhase = 2;

                //nextPhaseSource.Play();
                //PhaseReachedAnim.SetTrigger("PhaseReached");

                //currentPhaseProgressFillImage.fillAmount = 0;
                //currentPhaseText.text = "2nd";
                //totalProgressFillImage.fillAmount = 0.125f;
                //totalProgressAmountText.text = "12.5%";
                //Phase1ProgressGroup.SetActive(false);
                //ContextSensitiveNavigationHelperAnim.SetTrigger("ContextSensitiveHelperActivated");
            }
        }
        else if (PhaseManagement.gamePhase == 2)
        {
            if (currentScene == 0)
            {
                if (Phase2DieticianConversationTracker == 0)
                {
                    inChat = true;
                    phaseTwoStartInteractiveButtonGroup.SetActive(true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftText.text = "Hi, John. I’m not sure where to start. Where can I find more information about... (Select an option below to learn more)";
                    if (ChatRightTwoAnim.GetBool("ChatDefault") != true)
                    {
                        ChatRightTwoAnim.SetBool("ChatDefault", true);
                    }
                    if (Phase2AnthropometryAnswerSelected == Phase2AnthropometryAnswerTotal)
                    {
                        Phase2AnthropometryCompleted = true;
                        Debug.Log("Phase2AnthropometryCompleted = " + Phase2AnthropometryCompleted);
                        if (Phase2BiochemicalAnswerSelected == Phase2BiochemicalAnswerTotal)
                        {
                            Phase2BiochemicalCompleted = true;
                            Debug.Log("Phase2BiochemicalCompleted = " + Phase2BiochemicalCompleted);
                            if (clientHistoryAnswersSelected == Phase2ClientHistoryAnswerTotal)
                            {
                                Phase2ClientHistoryCompleted = true;
                                Debug.Log("Phase2ClientHistoryCompleted = " + Phase2ClientHistoryCompleted);
                                Debug.Log("foodAndNutritionAnswersSelected = " + foodAndNutritionAnswersSelected);
                                Debug.Log("Phase2FoodAndNutritionAnswerTotal = " + Phase2FoodAndNutritionAnswerTotal);
                                if (foodAndNutritionAnswersSelected == Phase2FoodAndNutritionAnswerTotal)
                                {
                                    Phase2FoodAndNutritionCompleted = true;
                                    Debug.Log("Phase2FoodAndNutritionCompleted = " + Phase2FoodAndNutritionCompleted);
                                    PresentFindingsButton.SetActive(true);
                                }
                            }
                        }
                    }
                    Phase2DieticianConversationTracker = 1;
                }
                else if (Phase2DieticianConversationTracker == 1)
                {
                    ChatLeftText.text = "Nothing right now, thanks.";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    phaseTwoStartInteractiveButtonGroup.SetActive(false);
                    Phase2DieticianConversationTracker = 2;
                }
                else if (Phase2DieticianConversationTracker == 2)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    Phase2DieticianConversationTracker = 0;
                    inChat = false;
                }
                else if (Phase2DieticianConversationTracker == 3)
                {
                    NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatLeftTwoText.text = "Nothing right now, thanks.";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phaseTwoInteractiveButtonGroup.SetActive(false);
                    Phase2DieticianConversationTracker = 301;
                }
                else if (Phase2DieticianConversationTracker == 301)
                {
                    phaseTwoInteractiveButtonGroup.SetActive(false);
                    if (ChatLeftAnim.GetBool("ChatDefault") != true)
                    {
                        ChatLeftAnim.SetBool("ChatActivated", false);
                        ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                        ChatLeftAnim.SetBool("ChatDefault", true);
                    }
                    if (ChatRightAnim.GetBool("ChatDefault") != true)
                    {
                        ChatRightAnim.SetBool("ChatActivated", false);
                        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                        ChatRightAnim.SetBool("ChatDefault", true);
                    }
                    if (ChatLeftTwoAnim.GetBool("ChatDefault") != true)
                    {
                        ChatLeftTwoAnim.SetBool("ChatActivated", false);
                        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                        ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    }
                    Phase2DieticianConversationTracker = 0;
                    inChat = false;
                }
                else if (Phase2DieticianConversationTracker == 801)
                {
                    phaseTwoFoodAndNutritionInformationGroup.SetActive(false);
                    ChatRightLargeAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightLargeAnim.SetBool("ChatDefault", true);
                    Phase2DieticianConversationTracker = 0;
                    inChat = false;
                }
                else if (Phase2DieticianConversationTracker == 4)
                {
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    ChatLeftNameText.text = playerNameString;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    ChatRightText.text = "You can go the Nurses' Station and gather information from the Medical file that is on the desk.";
                    ChatNextButtonText.text = "END CHAT";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase2DieticianConversationTracker = 301;
                }
                else if (Phase2DieticianConversationTracker == 5)
                {
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    ChatLeftNameText.text = playerNameString;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    ChatRightText.text = "You can go to the Nurses' Station and speak with Makenna, she should be in between rounds at the moment and should have the information regarding Marta's discharge plan.";
                    ChatNextButtonText.text = "END CHAT";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase2DieticianConversationTracker = 301;
                }
                else if (Phase2DieticianConversationTracker == 6)
                {
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    ChatLeftNameText.text = playerNameString;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    ChatRightText.text = "Although Marta is not in her room at the moment, you can find the information in the bed chart. Remember to calculate her BMI on your Clinpad.";
                    ChatNextButtonText.text = "END CHAT";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase2DieticianConversationTracker = 301;
                }
                else if (Phase2DieticianConversationTracker == 7)
                {
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    ChatLeftNameText.text = playerNameString;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    ChatRightText.text = "Make sure while you are here in my office that you look at the Biochemical information on the computer behind me. Once you have made your selections please fill in the notes field with as much detail as possible on why you made those selections.";
                    ChatNextButtonText.text = "END CHAT";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase2DieticianConversationTracker = 301;
                }
                else if (Phase2DieticianConversationTracker == 8)
                {
                    if (!hasFoodAndNutritionInformation)
                    {
                        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                        ChatLeftNameText.text = playerNameString;
                        NPCRightChatPortrait.sprite = DieticianPortraitImage;
                        ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                        ChatTextRightLargeHeaderImage.color = dietiticSupervisorChatHeaderColour;
                        ChatRightLargeNameText.text = dieteticSupervisorNameString;
                        ChatRightLargeText.text = "Choose only the relevant information, you will be penalised for the incorrect information.";
                        ChatNextButtonText.text = "END CHAT";
                        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                        ChatRightTwoAnim.SetBool("ChatDefault", true);
                        ChatLeftAnim.SetBool("ChatActivated", false);
                        ChatLeftAnim.SetBool("ChatDefault", true);
                        ChatRightLargeAnim.SetBool("ChatDefault", false);
                        ChatRightLargeAnim.SetBool("ChatFinishedMoveUp", true);
                        phaseTwoFoodAndNutritionInformationGroup.SetActive(true);
                        Phase2DieticianConversationTracker = 801;
                    }
                    else if (hasFoodAndNutritionInformation)
                    {
                        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                        ChatLeftNameText.text = playerNameString;
                        NPCRightChatPortrait.sprite = DieticianPortraitImage;
                        ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                        ChatRightNameText.text = dieteticSupervisorNameString;
                        ChatRightText.text = "You have all the food and nutrition information.";
                        ChatNextButtonText.text = "END CHAT";
                        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                        ChatRightTwoAnim.SetBool("ChatDefault", true);
                        ChatLeftAnim.SetBool("ChatActivated", false);
                        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                        ChatRightAnim.SetBool("ChatDefault", false);
                        ChatRightAnim.SetBool("ChatActivated", true);
                        Phase2DieticianConversationTracker = 301;
                    }
                }
            }
            if (currentScene == 1)
            {
                if (Phase2NurseConversationTracker == 0)
                {
                    inChat = true;
                    ChatRightNameText.text = nurseNameString;
                    ChatTextRightHeaderImage.color = nurseChatHeaderColour;
                    NPCRightChatPortrait.sprite = NursePortraitImage;
                    ChatRightText.text = "How may I help you " + playerNameString + "?";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftText.text = "Hi Makenna. Do you know what Marta's discharge plan is?";
                    ChatNextButtonText.text = "CONTINUE";
                    Phase2NurseConversationTracker = 1;
                }
                else if (Phase2NurseConversationTracker == 1)
                {
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatRightTwoNameText.text = nurseNameString;
                    ChatTextRightTwoHeaderImage.color = nurseChatHeaderColour;
                    NPCRightTwoChatPortrait.sprite = NursePortraitImage;
                    ChatRightTwoText.text = "The Doctor said Marta will be discharged within the next 5 days.";
                    Phase2NurseConversationTracker = 2;
                }
                else if (Phase2NurseConversationTracker == 2)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftTwoText.text = "Thanks, and how is Marta eating? Is she having all her food?";
                    Phase2NurseConversationTracker = 3;
                }
                else if (Phase2NurseConversationTracker == 3)
                {
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatRightText.text = "I have noticed that Marta is struggling to finish her meals, <b><color=#6AB543FF>she usually only eats half her food</color></b>.";
                    foodAndNutritionCorrectAnswer06Text.SetActive(true);
                    Phase2NurseConversationTracker = 4;
                }
                else if (Phase2NurseConversationTracker == 4)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatLeftText.text = "Thank you, talk to you later";
                    Phase2NurseConversationTracker = 5;
                }
                else if (Phase2NurseConversationTracker == 5)
                {
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase2NurseConversationTracker = 6;
                }
                else if (Phase2NurseConversationTracker == 6)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    Phase2NurseConversationTracker = 0;
                    inChat = false;
                }
            }
            if (currentScene == 2)
            {
                if (Phase2PatientConversationTracker == 0)
                {
                    inChat = true;
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase2PatientConversationTracker = 1;
                }
                else if (Phase2PatientConversationTracker == 1)
                {
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    inChat = false;
                    Phase2PatientConversationTracker = 0;
                }
            }
        }
        else if (PhaseManagement.gamePhase == 3)
        {
            if (Phase3PresentFindingsConversationTracker == 1)
            {
                NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                ChatLeftNameText.text = playerNameString;
                ChatRightTwoText.text = "Well, you're eager! I like that. Now let's see if you're discerning. You're not going to talk to Marta about everything you already have gathered. What additional information do you need to gather from Marta to get a clearer picture of her nutritional concerns?";
                ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightAnim.SetBool("ChatDefault", true);
                ChatLeftAnim.SetBool("ChatActivated", false);
                ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightTwoAnim.SetBool("ChatDefault", false);
                ChatRightTwoAnim.SetBool("ChatActivated", true);
                Phase3CompletionInfoGroup.SetActive(false);
                Phase3PresentFindingsConversationTracker = 2;
            }
            else if (Phase3PresentFindingsConversationTracker == 2)
            {
                phaseThreePresentFindingsInputGroup.SetActive(true);
                ChatNextButtonText.text = "CANCEL";
                NPCRightChatPortrait.sprite = DieticianPortraitImage;
                ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                ChatRightNameText.text = dieteticSupervisorNameString;
                ChatRightText.text = "If you need more information do not forget to check your Clinpad. Come back when you are ready to present your findings.";
                ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                ChatLeftAnim.SetBool("ChatDefault", true);
                ChatRightTwoAnim.SetBool("ChatActivated", false);
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                Phase3PresentFindingsConversationTracker = 3;
            }
            else if (Phase3PresentFindingsConversationTracker == 3)
            {
                phaseThreePresentFindingsInputGroup.SetActive(false);
                ChatNextButtonText.text = "END CHAT";
                ChatLeftText.text = "I just want to go over a few of my findings first. I will be back shortly.";
                ChatLeftAnim.SetBool("ChatDefault", false);
                ChatLeftAnim.SetBool("ChatActivated", true);
                Phase3PresentFindingsConversationTracker = 4;
            }
            else if (Phase3PresentFindingsConversationTracker == 4)
            {
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightTwoAnim.SetBool("ChatDefault", true);
                ChatLeftAnim.SetBool("ChatActivated", false);
                ChatLeftAnim.SetBool("ChatDefault", true);
                inChat = false;
                Phase3PresentFindingsConversationTracker = 0;
                Phase2DieticianConversationTracker = 0;
                PhaseManagement.gamePhase = 2;
            }

            else if (Phase3PresentFindingsConversationTracker == 5)
            {
                phaseThreePresentFindingsInputGroup.SetActive(false);
                ChatNextButtonText.text = "END CHAT";
                NPCRightChatPortrait.sprite = DieticianPortraitImage;
                ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                ChatRightNameText.text = dieteticSupervisorNameString;
                ChatRightText.text = "Well done, you have presented enough information to move onto the next phase of your investigation. Marta should be back in her room now.";
                ChatRightAnim.SetBool("ChatDefault", false);
                ChatRightAnim.SetBool("ChatActivated", true);
                Phase3PresentFindingsConversationTracker = 6;
                notificationGoodSource.Play();
            }
            else if (Phase3PresentFindingsConversationTracker == 6)
            {
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightTwoAnim.SetBool("ChatDefault", true);
                ChatRightAnim.SetBool("ChatActivated", false);
                ChatRightAnim.SetBool("ChatDefault", true);
                inChat = false;
                PhaseManagement.gamePhase = 4;
                PhaseReachedText.text = "REACHED PHASE 4";
                nextPhaseSource.Play();
                PhaseReachedAnim.SetTrigger("PhaseReached");
                currentPhaseProgressFillImage.fillAmount = 0;
                currentPhaseText.text = "4th";
                totalProgressFillImage.fillAmount = 0.375f;
                totalProgressAmountText.text = "37.5%";
                Phase3ProgressGroup.SetActive(false);
                PhaseTransitionSave(3);
            }
        }
        else if (PhaseManagement.gamePhase == 4)
        {
            if (currentScene == 0)
            {
                ChatLeftNameText.text = playerNameString;
                ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                ChatRightNameText.text = dieteticSupervisorNameString;
                ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                NPCRightChatPortrait.sprite = DieticianPortraitImage;
                ChatLeftTwoNameText.text = playerNameString;
                ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                ChatRightTwoNameText.text = dieteticSupervisorNameString;
                ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
                if (phase4Conversation0Done)
                {
                    if (!alreadySpokenPhase4)
                    {
                        if (Phase4ConversationTracker == 0)
                        {
                            inChat = true;
                            ChatNextButtonText.text = "CONTINUE";
                            ChatRightAnim.SetBool("ChatDefault", false);
                            ChatRightAnim.SetBool("ChatActivated", true);
                            ChatRightText.text = "Hi, how can I help you?";
                            ChatLeftText.text = "I just spoke with Marta and she mentioned that you had already spoken about her diet history. I was wondering if I could have a copy for my Clinpad.";
                            Phase4ConversationTracker = 1;
                        }
                        else if (Phase4ConversationTracker == 1)
                        {
                            ChatNextButtonText.text = "Receive Document";
                            ChatRightAnim.SetBool("ChatActivated", false);
                            ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                            ChatLeftAnim.SetBool("ChatDefault", false);
                            ChatLeftAnim.SetBool("ChatActivated", true);
                            Phase4ConversationTracker = 2;
                        }
                        else if (Phase4ConversationTracker == 2)
                        {
                            ChatRightTwoText.text = "Here is the document, you can check it from the Chart section of your ClinPad.";
                            ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                            ChatRightAnim.SetBool("ChatDefault", true);
                            ChatLeftAnim.SetBool("ChatActivated", false);
                            ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                            ChatRightTwoAnim.SetBool("ChatDefault", false);
                            ChatRightTwoAnim.SetBool("ChatActivated", true);
                            ClinPadNutritionalRequirementsButton.SetActive(true);
                            Phase4ConversationTracker = 3;
                        }
                        else if (Phase4ConversationTracker == 3)
                        {
                            ReceivedItemToggle();
                            hasDietHistory = true;
                            ChatLeftTwoText.text = "Thank you very much, I am going to head back over to Marta now.";
                            ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                            ChatLeftAnim.SetBool("ChatDefault", true);
                            ChatRightTwoAnim.SetBool("ChatActivated", false);
                            ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                            ChatLeftTwoAnim.SetBool("ChatDefault", false);
                            ChatLeftTwoAnim.SetBool("ChatActivated", true);
                            ChatNextButtonText.text = "END CHAT";
                            Phase4ConversationTracker = 4;
                        }
                        else if (Phase4ConversationTracker == 4)
                        {
                            ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                            ChatRightTwoAnim.SetBool("ChatDefault", true);
                            ChatLeftTwoAnim.SetBool("ChatActivated", false);
                            ChatLeftTwoAnim.SetBool("ChatDefault", true);
                            inChat = false;
                            Phase4ConversationTracker = 0;
                            alreadySpokenPhase4 = true;
                            phase4SpeakToOT = true;
                            Phase4PatientConversationTracker = 600;
                        }
                    }
                    else if (alreadySpokenPhase4)
                    {
                        if (Phase4ConversationTracker == 0)
                        {
                            inChat = true;
                            ChatRightNameText.text = dieteticSupervisorNameString;
                            ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                            ChatNextButtonText.text = "CONTINUE";
                            NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                            NPCRightChatPortrait.sprite = DieticianPortraitImage;
                            ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                            ChatLeftNameText.text = playerNameString;
                            ChatRightAnim.SetBool("ChatDefault", false);
                            ChatRightAnim.SetBool("ChatActivated", true);
                            ChatRightText.text = "Is there something else I can help you with?";
                            ChatLeftText.text = "I was wondering how to access the Diet History from the Clinpad?";
                            Phase4ConversationTracker = 1;
                        }
                        else if (Phase4ConversationTracker == 1)
                        {
                            ChatRightTwoNameText.text = dieteticSupervisorNameString;
                            ChatRightTwoText.text = "Just open your Clinpad and select the Chart section, there you will find a button to open up the document.";
                            ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                            NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
                            ChatRightAnim.SetBool("ChatActivated", false);
                            ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                            ChatLeftAnim.SetBool("ChatDefault", false);
                            ChatLeftAnim.SetBool("ChatActivated", true);
                            ChatNextButtonText.text = "CONTINUE";
                            Phase4ConversationTracker = 2;
                        }
                        else if (Phase4ConversationTracker == 2)
                        {
                            ChatLeftTwoNameText.text = playerNameString;
                            NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                            ChatLeftTwoText.text = "Thank you.";
                            ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                            ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                            ChatRightAnim.SetBool("ChatDefault", true);
                            ChatLeftAnim.SetBool("ChatActivated", false);
                            ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                            ChatRightTwoAnim.SetBool("ChatDefault", false);
                            ChatRightTwoAnim.SetBool("ChatActivated", true);
                            ChatNextButtonText.text = "END CHAT";
                            Phase4ConversationTracker = 3;
                        }
                        else if (Phase4ConversationTracker == 3)
                        {
                            ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                            ChatLeftAnim.SetBool("ChatDefault", true);
                            ChatRightTwoAnim.SetBool("ChatActivated", false);
                            ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                            ChatLeftTwoAnim.SetBool("ChatDefault", false);
                            ChatLeftTwoAnim.SetBool("ChatActivated", true);
                            ChatNextButtonText.text = "GOOD BYE";
                            Phase4ConversationTracker = 4;
                        }
                        else if (Phase4ConversationTracker == 4)
                        {
                            ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                            ChatRightTwoAnim.SetBool("ChatDefault", true);
                            ChatLeftTwoAnim.SetBool("ChatActivated", false);
                            ChatLeftTwoAnim.SetBool("ChatDefault", true);
                            inChat = false;
                            Phase4ConversationTracker = 0;
                        }
                    }
                }
                else
                {
                    if (Phase4ConversationTracker == 0)
                    {
                        inChat = true;
                        ChatRightNameText.text = dieteticSupervisorNameString;
                        ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                        ChatNextButtonText.text = "CONTINUE";
                        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                        NPCRightChatPortrait.sprite = DieticianPortraitImage;
                        ChatTextLeftHeaderImage.color = new Color32(84, 164, 204, 255);
                        ChatLeftNameText.text = playerNameString;
                        ChatRightAnim.SetBool("ChatDefault", false);
                        ChatRightAnim.SetBool("ChatActivated", true);
                        ChatRightText.text = "Hi, how can I help you?";
                        ChatLeftText.text = "I was just wondering what I should do now?";
                        Phase4ConversationTracker = 1;
                    }
                    else if (Phase4ConversationTracker == 1)
                    {
                        ChatRightAnim.SetBool("ChatActivated", false);
                        ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                        ChatLeftAnim.SetBool("ChatDefault", false);
                        ChatLeftAnim.SetBool("ChatActivated", true);
                        Phase4ConversationTracker = 2;
                    }
                    else if (Phase4ConversationTracker == 2)
                    {
                        ChatRightTwoText.text = "Marta is back in her room now so you can chat to her and do your examination.";
                        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                        ChatRightAnim.SetBool("ChatDefault", true);
                        ChatLeftAnim.SetBool("ChatActivated", false);
                        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                        ChatRightTwoAnim.SetBool("ChatDefault", false);
                        ChatRightTwoAnim.SetBool("ChatActivated", true);
                        Phase4ConversationTracker = 3;
                    }
                    else if (Phase4ConversationTracker == 3)
                    {
                        ChatLeftTwoText.text = "Thank you very much, I will go and talk to her now.";
                        ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                        ChatLeftAnim.SetBool("ChatDefault", true);
                        ChatRightTwoAnim.SetBool("ChatActivated", false);
                        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                        ChatLeftTwoAnim.SetBool("ChatDefault", false);
                        ChatLeftTwoAnim.SetBool("ChatActivated", true);
                        ChatNextButtonText.text = "END CHAT";
                        Phase4ConversationTracker = 4;
                    }
                    else if (Phase4ConversationTracker == 4)
                    {
                        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                        ChatRightTwoAnim.SetBool("ChatDefault", true);
                        ChatLeftTwoAnim.SetBool("ChatActivated", false);
                        ChatLeftTwoAnim.SetBool("ChatDefault", true);
                        inChat = false;
                        Phase4ConversationTracker = 0;
                    }
                }
            }
            if (currentScene == 1)
            {
                if (Phase4ConversationTracker == 0)
                {
                    inChat = true;
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatRightNameText.text = nurseNameString;
                    ChatTextRightHeaderImage.color = nurseChatHeaderColour;
                    NPCRightChatPortrait.sprite = NursePortraitImage;
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatRightTwoNameText.text = nurseNameString;
                    ChatTextRightTwoHeaderImage.color = nurseChatHeaderColour;
                    NPCRightTwoChatPortrait.sprite = NursePortraitImage;
                    ChatNextButtonText.text = "ANY INFO?";
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatLeftText.text = "Hi, I as wondering if there was any information you could please give me?";
                    ChatRightText.text = "If you haven't yet you can speak with Marta in the Patient Ward and you can also complete your examination.";
                    Phase4ConversationTracker = 1;
                }
                else if (Phase4ConversationTracker == 1)
                {
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase4ConversationTracker = 2;
                }
                else if (Phase4ConversationTracker == 2)
                {
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    Phase4ConversationTracker = 0;
                    inChat = false;
                }
            }
            if (currentScene == 2)
            {
                if (Phase4PatientConversationTracker == 0)
                {
                    inChat = true;
                    ChatRightText.text = "Hello.";
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatRightNameText.text = patientNameString;
                    ChatTextRightHeaderImage.color = patientChatHeaderColour;
                    NPCRightChatPortrait.sprite = PatientPortraitImage;
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatRightTwoNameText.text = patientNameString;
                    ChatTextRightTwoHeaderImage.color = patientChatHeaderColour;
                    NPCRightTwoChatPortrait.sprite = PatientPortraitImage;
                    ChatNextButtonText.text = "CONTINUE";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatLeftText.text = "Good morning, Marta. I'm " + playerNameString + ", the student dietitian. My supervisor asked me to come and to talk to you about your food and nutrition. Is this a good time?";
                    Phase4PatientConversationTracker = 1;
                }
                else if (Phase4PatientConversationTracker == 1)
                {
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatRightTwoText.text = "Oh, good morning, " + playerNameString + ". My joints are really painful but I think I should be fine.";
                    ChatNextButtonText.text = "CONTINUE";
                    Phase4PatientConversationTracker = 2;
                }
                else if (Phase4PatientConversationTracker == 2)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    ChatLeftTwoText.text = "I'm sorry to hear that. That must be uncomfortable?";
                    ChatNextButtonText.text = "CONTINUE";
                    Phase4PatientConversationTracker = 3;
                }
                else if (Phase4PatientConversationTracker == 3)
                {
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatRightText.text = "Yes it is, I feel like I just don’t want to move at all.";
                    Phase4PatientConversationTracker = 4;
                }
                else if (Phase4PatientConversationTracker == 4)
                {
                    ChatLeftText.text = "I should only need about 30 minutes for this interview, and we can stop at any time if you need to. Does that sound alright to you?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 5;
                }
                else if (Phase4PatientConversationTracker == 5)
                {
                    ChatRightTwoText.text = "I think I can manage that. It’s nice to have some company, too.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 6;
                }
                else if (Phase4PatientConversationTracker == 6)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 7;

                }
                else if (Phase4PatientConversationTracker == 7)
                {
                    ChatLeftTwoText.text = "Thank you Marta. Firstly I would like to explain the role of the dietitian and the purpose of my visit. All patients admitted to University Hospital are screened for possible eating and nutrition issues and through this screening you were referred to the dietitian. As your Dietitian, I’m going to review what you’ve been eating and what factors influence your eating choices, and then come up with some recommendations to help improve your nutrition.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 8;
                }
                else if (Phase4PatientConversationTracker == 8)
                {
                    inChat = true;
                    ChatLeftTwoText.text = "Thank you Marta. Firstly I would like to explain the role of the dietitian and the purpose of my visit. All patients admitted to University Hospital are screened for possible eating and nutrition issues and through this screening you were referred to the dietitian. As your Dietitian, I’m going to review what you’ve been eating and what factors influence your eating choices, and then come up with some recommendations to help improve your nutrition.";
                    ChatNextButtonText.text = "ASK QUESTION";
                    ChatLeftText.text = "Choose what you would like to talk to Marta about by clicking on one of the following options:";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phaseFourInteractiveButtonGroup.SetActive(true);
                }
                else if (Phase4PatientConversationTracker == 100)
                {
                    ChatRightText.text = "Can you please talk to the Dietitian about this? He was here earlier asking what I usually eat.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 101;
                }
                else if (Phase4PatientConversationTracker == 101)
                {
                    ChatLeftTwoText.text = "No problem, I will speak to him and get back to you.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 102;
                }
                else if (Phase4PatientConversationTracker == 102)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase4PatientConversationTracker = 8;
                    phase4Conversation0Done = true;
                    inChat = false;
                }
                else if (Phase4PatientConversationTracker == 110)
                {
                    ChatRightText.text = "That's fine, go ahead.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 111;
                }
                else if (Phase4PatientConversationTracker == 111)
                {
                    ChatLeftTwoText.text = "Have you any issues with preparing or cooking meals?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 112;

                }
                else if (Phase4PatientConversationTracker == 112)
                {
                    ChatRightTwoText.text = "I just don’t feel like cooking anymore. I’m always very tired. Hanz and I shared the cooking until he became very sick. After that, I <color=#6AB543FF>ordered meals from a local home care meal delivery service</color> as it was too difficult to nurse Hanz and to do all the cooking. I know the meal delivery service is probably for much older people than me, but I just couldn’t manage, and the social worker from the hospital thought it would be a good idea. Since Hanz passed away I kept the meals going for me. I just <color=#6AB543FF>wasn’t that interested in cooking or eating.</color>";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase4SavedText02.SetActive(true);
                    phase4SavedText03.SetActive(true);
                    phase4SavedText04.SetActive(true);
                    Phase4PatientConversationTracker = 113;
                }
                else if (Phase4PatientConversationTracker == 113)
                {
                    ChatRightText.text = "Plus, its nice to have a quick chat with the drivers when they deliver the meal, they always ask how I am. I usually ring the day before the meal is delivered. I always get the dessert they have. Sometimes with the meal and other times with just a soup. I do have to <color=#6AB543FF>prepare food for myself on the weekend</color> because the meals are only delivered Monday to Friday. It’s a bit hard, but much better than if I had to do it all week.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 114;
                }
                else if (Phase4PatientConversationTracker == 114)
                {
                    ChatLeftText.text = "Who does the grocery shopping?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 115;
                }
                else if (Phase4PatientConversationTracker == 115)
                {
                    ChatRightTwoText.text = "I do, with the help from my friend who drives me to the plaza <color=#6AB543FF>once a week to buy the week’s groceries.</color>";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase4SavedText05.SetActive(true);
                    Phase4PatientConversationTracker = 116;
                }
                else if (Phase4PatientConversationTracker == 116)
                {
                    ChatLeftTwoText.text = "Has the amount of food you usually eat changed at all recently?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 117;
                }
                else if (Phase4PatientConversationTracker == 117)
                {
                    ChatRightText.text = "No, not recently. I think I have been eating the same way for while, but I probably don’t eat as much as when I was younger. I just don’t feel hungry at all. I even find the meals a bit big for me lately and <color=#6AB543FF>struggle to eat the whole meal.</color>";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase4SavedText06.SetActive(true);
                    Phase4PatientConversationTracker = 118;
                }
                else if (Phase4PatientConversationTracker == 118)
                {
                    ChatLeftText.text = "Are you currently restricting your food choices in any way?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 119;
                }
                else if (Phase4PatientConversationTracker == 119)
                {
                    ChatRightTwoText.text = "Well I <color=#6AB543FF>won’t drink any orange juice - all that citrus. Can’t be good for my arthritis</color>, right? And I have lactose intolerance. I get <color=#6AB543FF>terrible bloating and pain if I drink too much milk</color>. I <color=#6AB543FF>avoid custard and yogurt</color>, too. Anything with cow’s milk. Well, almost anything. I <color=#6AB543FF>can have cheese</color> alright. And a bit of cream on dessert. Every once in a while I <color=#6AB543FF>can even have an ice cream</color> if I’ve been careful.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase4SavedText07.SetActive(true);
                    phase4SavedText08.SetActive(true);
                    phase4SavedText09.SetActive(true);
                    phase4SavedText10.SetActive(true);
                    phase4SavedText11.SetActive(true);
                    Phase4PatientConversationTracker = 120;
                }
                else if (Phase4PatientConversationTracker == 120)
                {
                    ChatLeftTwoText.text = "You mentioned to the dietitian you were taking fish oil supplements. Are there any other kinds of supplements you are taking?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 121;
                }
                else if (Phase4PatientConversationTracker == 121)
                {
                    ChatRightText.text = "Yes, that’s right I do take fish oil capsules. The only other thing I can think of is I take a fibre supplement called Metamucil. It comes in these little sachets and I take one of them every day.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 122;
                }
                else if (Phase4PatientConversationTracker == 122)
                {
                    ChatLeftText.text = "Thank you, that's all the questions I have about your food intake.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase4PatientConversationTracker = 123;
                }
                else if (Phase4PatientConversationTracker == 123)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase4Conversation1Done = true;
                    inChat = false;
                    Phase4PatientConversationTracker = 8;
                }
                else if (Phase4PatientConversationTracker == 200)
                {
                    ChatRightText.text = "That’s fine, go ahead.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 201;
                }
                else if (Phase4PatientConversationTracker == 201)
                {
                    ChatLeftTwoText.text = "Have you experienced any symptoms that have affected your appetite?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 202;
                }
                else if (Phase4PatientConversationTracker == 202)
                {
                    ChatRightTwoText.text = "Sometimes I get <color=#6AB543FF>nausea and a very dry mouth</color>. It’s not all the time and can come and go at any time. It makes me not want to eat.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase4SavedText12.SetActive(true);
                    Phase4PatientConversationTracker = 203;
                }
                else if (Phase4PatientConversationTracker == 203)
                {
                    ChatLeftText.text = "How are your bowels now?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 204;
                }
                else if (Phase4PatientConversationTracker == 204)
                {
                    ChatRightText.text = "What do you mean?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 205;
                }
                else if (Phase4PatientConversationTracker == 205)
                {
                    ChatLeftTwoText.text = "Have you experienced any problems going to the toilet?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 206;
                }
                else if (Phase4PatientConversationTracker == 206)
                {
                    ChatRightTwoText.text = "I seem to be okay. I went two times already this morning.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 207;
                }
                else if (Phase4PatientConversationTracker == 207)
                {
                    ChatLeftText.text = "Have you been experiencing any diarrhoea?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 208;
                }
                else if (Phase4PatientConversationTracker == 208)
                {
                    ChatRightText.text = "No, nothing like that.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 209;
                }
                else if (Phase4PatientConversationTracker == 209)
                {
                    ChatLeftTwoText.text = "Have you been experiencing any constipation?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 210;
                }
                else if (Phase4PatientConversationTracker == 210)
                {
                    ChatRightTwoText.text = "Yes, this really is a problem. I go to the toilet every day but it’s difficult to go. I strain quite a bit and it’s very uncomfortable";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 211;
                }
                else if (Phase4PatientConversationTracker == 211)
                {
                    ChatLeftText.text = "Have you been experiencing any vomiting?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 212;
                }
                else if (Phase4PatientConversationTracker == 212)
                {
                    ChatRightText.text = "<color=#6AB543FF>No vomiting</color>, I just feel sick every now and again, but nothing regular.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase4SavedText13.SetActive(true);
                    Phase4PatientConversationTracker = 213;
                }
                else if (Phase4PatientConversationTracker == 213)
                {
                    ChatLeftTwoText.text = "Have you experienced any issues that have affected your ability to eat?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 214;
                }
                else if (Phase4PatientConversationTracker == 214)
                {
                    ChatRightTwoText.text = "It is <color=#6AB543FF>very difficult for me to reach items, and to cut my food with a knife. It’s also hard to to open cans and bottles</color>.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase4SavedText14.SetActive(true);
                    Phase4PatientConversationTracker = 215;
                }
                else if (Phase4PatientConversationTracker == 215)
                {
                    ChatLeftText.text = "Do you go out and do some sort of regular exercise?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 216;
                }
                else if (Phase4PatientConversationTracker == 216)
                {
                    ChatRightText.text = "Not really, I find my joints are too painful.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 217;
                }
                else if (Phase4PatientConversationTracker == 217)
                {
                    ChatLeftTwoText.text = "So have you had any issues with your daily activities and energy levels over the past two weeks?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 218;
                }
                else if (Phase4PatientConversationTracker == 218)
                {
                    ChatRightTwoText.text = "I am very tired and I don’t have much energy most days, but I’ve felt this way for a long time, so it is no different over the past two weeks.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 219;
                }
                else if (Phase4PatientConversationTracker == 219)
                {
                    ChatLeftText.text = "Can you tell me about your mobility and managing your normal daily activities.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 220;
                }
                else if (Phase4PatientConversationTracker == 220)
                {
                    ChatRightText.text = "I do struggle walking for long periods and when my arthritis is very bad I can’t walk outside the house. I manage to get to see my <color=#6AB543FF>Physiotherapist once a week</color> and enjoy my hydrotherapy sessions. What really frustrates me is the arthritis in my hands. I can’t hold objects very well and now I <color=#6AB543FF>can’t drive</color> as it is too difficult to hold onto the steering wheel.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase4SavedText15.SetActive(true);
                    phase4SavedText16.SetActive(true);
                    Phase4PatientConversationTracker = 221;
                }
                else if (Phase4PatientConversationTracker == 221)
                {
                    ChatLeftTwoText.text = "Thank you for that Marta.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase4PatientConversationTracker = 222;
                }
                else if (Phase4PatientConversationTracker == 222)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase4Conversation2Done = true;
                    inChat = false;
                    Phase4PatientConversationTracker = 8;
                }
                else if (Phase4PatientConversationTracker == 300)
                {
                    ChatRightText.text = "That’s fine, go ahead.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 301;
                }
                else if (Phase4PatientConversationTracker == 301)
                {
                    ChatLeftTwoText.text = "Can you tell me about your home situation?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 302;
                }
                else if (Phase4PatientConversationTracker == 302)
                {
                    ChatRightTwoText.text = "I <color=#6AB543FF>live alone in my own home</color>. My husband Hanz died about 6 months ago, from lung cancer. I miss him very much. He was 65 years old. I was Hanz’s caretaker in the last two years of his life as he needed to have surgery and regular chemotherapy and radiotherapy.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase4SavedText17.SetActive(true);
                    Phase4PatientConversationTracker = 303;
                }
                else if (Phase4PatientConversationTracker == 303)
                {
                    ChatLeftText.text = "I’m sorry to hear that Marta, it sounds like you miss him a lot.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 304;
                }
                else if (Phase4PatientConversationTracker == 304)
                {
                    ChatRightText.text = "Yes, I do miss him dearly.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 305;
                }
                else if (Phase4PatientConversationTracker == 305)
                {
                    ChatLeftTwoText.text = "Have you any family close by?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 306;
                }
                else if (Phase4PatientConversationTracker == 306)
                {
                    ChatRightTwoText.text = "I have two children. One is away at university and the other lives in another state. All my other family are in the Netherlands.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 307;
                }
                else if (Phase4PatientConversationTracker == 307)
                {
                    ChatLeftText.text = "I see, can you tell me about your work situation?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 308;
                }
                else if (Phase4PatientConversationTracker == 308)
                {
                    ChatRightText.text = "I don’t work anymore. I stopped work about 4 years ago, as the stiffness in my hands and elbows were getting worse. I worked in the payroll office at the mining company. That’s where Hanz worked as a welder. We both worked there for many years. He retired before me though, about 5 years ago, when he was about 60 years old, as the job became too physically demanding for him.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 309;
                }
                else if (Phase4PatientConversationTracker == 309)
                {
                    ChatLeftTwoText.text = "Okay, so do you have any friends around that are supportive and can help you out around the house or with shopping?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 310;
                }
                else if (Phase4PatientConversationTracker == 310)
                {
                    ChatRightTwoText.text = "I made a lot of friends throughout my work life. I have one friend who takes me to the mall once a week and helps me with grocery shopping.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 311;
                }
                else if (Phase4PatientConversationTracker == 311)
                {
                    ChatLeftText.text = "That’s lovely. Do you have any budget limitations around purchasing food?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 312;
                }
                else if (Phase4PatientConversationTracker == 312)
                {
                    ChatRightText.text = "I am a pensioner, so I do <color=#6AB543FF>have to be careful about money</color>.  Hanz and I did have a retirement fund and received a part pension, but with all the medical expenses I have little savings left, so now I receive the full aged pension.  I do own my own home so my pension is mainly spent on council rates, electricity, water and food.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 313;
                }
                else if (Phase4PatientConversationTracker == 313)
                {
                    ChatLeftTwoText.text = "Okay, and the last question I have is do you smoke or have you ever smoked?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 314;
                }
                else if (Phase4PatientConversationTracker == 314)
                {
                    ChatRightTwoText.text = "No, I don’t smoke. I have never smoked.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase4SavedText18.SetActive(true);
                    Phase4PatientConversationTracker = 315;
                }
                else if (Phase4PatientConversationTracker == 315)
                {
                    ChatLeftText.text = "Thanks for that Marta.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase4PatientConversationTracker = 316;
                }
                else if (Phase4PatientConversationTracker == 316)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase4Conversation3Done = true;
                    inChat = false;
                    Phase4PatientConversationTracker = 8;
                }
                else if (Phase4PatientConversationTracker == 400)
                {
                    ChatRightText.text = "I should be okay for a few minutes.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 401;
                }
                else if (Phase4PatientConversationTracker == 401)
                {
                    ChatLeftTwoText.text = "Marta, for this physical examination I need to look at the muscle and fat stores on your body. This will take about 10 minutes to perform. This will require me to touch your face, arms, legs, shoulders and the back of your shoulders whilst you are sitting out of bed. I need to look at the fat stores under your eyes and on your upper arms. First I will be looking at the muscles around your temples and then around your collar bone and your shoulder. Next I will look at the muscles around your knee and then your calf.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 402;
                }
                else if (Phase4PatientConversationTracker == 402)
                {
                    ChatLeftText.text = "I will then look at the muscle between your thumb and forefinger. I will also look if there is any fluid around your feet and ankles as this can be related to your body’s nutrition.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 403;
                }
                else if (Phase4PatientConversationTracker == 403)
                {
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    inChat = false;
                    phase4Conversation5Done = true;
                    Phase4PatientConversationTracker = 8;
                }
                else if (Phase4PatientConversationTracker == 500)
                {

                    ChatRightText.text = "That’s fine, go ahead.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 501;
                }
                else if (Phase4PatientConversationTracker == 501)
                {
                    ChatLeftTwoText.text = "Have you noticed any changes to your weight?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 502;
                }
                else if (Phase4PatientConversationTracker == 502)
                {
                    ChatRightTwoText.text = "I think I am the same weight as I’ve  been for the past couple of years but I have noticed that my arms and legs are <color=#6AB543FF>getting thinner and my clothes are a bit looser</color>. It’s been happening for a little while.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase4SavedText19.SetActive(true);
                    Phase4PatientConversationTracker = 503;
                }
                else if (Phase4PatientConversationTracker == 503)
                {
                    ChatLeftText.text = "Do you know what your usual weight is?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 504;
                }
                else if (Phase4PatientConversationTracker == 504)
                {
                    ChatRightText.text = "I usually weigh 59.0kg";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 505;
                }
                else if (Phase4PatientConversationTracker == 505)
                {
                    ChatLeftTwoText.text = "Have you always been the same weight through your adult life?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 506;
                }
                else if (Phase4PatientConversationTracker == 506)
                {
                    ChatRightTwoText.text = "I was a little overweight in my 50s and think I weighed about 67 kg but gradually over time I lost weight to about 59kg";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 507;
                }
                else if (Phase4PatientConversationTracker == 507)
                {
                    ChatLeftText.text = "Have you noticed any change to your weight in the last 6 months?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 508;
                }
                else if (Phase4PatientConversationTracker == 508)
                {
                    ChatRightText.text = "Well I was <color=#6AB543FF>59kg 6 months ago and two weeks ago my weight was 54.0kg.</color>";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase4SavedText20.SetActive(true);
                    Phase4PatientConversationTracker = 509;
                }
                else if (Phase4PatientConversationTracker == 509)
                {
                    ChatLeftTwoText.text = "Have you noticed any change to your weight over the past two weeks?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 510;
                }
                else if (Phase4PatientConversationTracker == 510)
                {
                    ChatRightTwoText.text = "No, not over the past two weeks. I think my weight has stayed the same. The nurses did weigh me when I came into hospital and wrote it in their records.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 511;
                }
                else if (Phase4PatientConversationTracker == 511)
                {
                    ChatLeftText.text = "Thanks, that is all I wanted to ask you about for the time being.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 512;
                }
                else if (Phase4PatientConversationTracker == 512)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase4Conversation4Done = true;
                    inChat = false;
                    Phase4PatientConversationTracker = 8;
                }
                else if (Phase4PatientConversationTracker == 600)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatRightNameText.text = occupationalTherapistNameString;
                    ChatTextRightHeaderImage.color = occupationalTherapistChatHeaderColour;
                    NPCRightChatPortrait.sprite = OccupationalTherapistImage;
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatRightTwoNameText.text = occupationalTherapistNameString;
                    ChatTextRightTwoHeaderImage.color = occupationalTherapistChatHeaderColour;
                    NPCRightTwoChatPortrait.sprite = OccupationalTherapistImage;
                    inChat = true;
                    ChatLeftText.text = "Hi. You must be the Occupational Therapist. Kenshin, right? I’m " + playerNameString + ", the student dietitian looking after Marta. I’m so glad to bump into you. I would like to have a few moments of your time when you are done if that is alright with you?";
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 601;
                }
                else if (Phase4PatientConversationTracker == 601)
                {
                    ChatRightText.text = "Hi " + playerNameString + ", lovely to meet you. I've actually just completed my assessment so we can talk now if you like.";
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 602;
                }
                else if (Phase4PatientConversationTracker == 602)
                {
                    ChatLeftTwoText.text = "Thank you Kenshin, I was hoping you could provide me with some information on Marta’s ability to feed herself and how mobile she is.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 603;
                }
                else if (Phase4PatientConversationTracker == 603)
                {
                    ChatRightTwoText.text = "Certainly, Marta has limited ability left in her hands to cut food. I’m not sure if you have seen her hands but she mostly <color=#6AB543FF>manages well with a spoon and her fingers when eating</color>.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase4SavedText01.SetActive(true);
                    Phase4PatientConversationTracker = 604;
                }
                else if (Phase4PatientConversationTracker == 604)
                {
                    ChatLeftText.text = "Hmm .. Makenna said that Marta wasn’t eating all of her food. That must be why. I’ll look into the type of food she is served. Also, it says here in the notes that Marta has been provided with adaptive eating utensils and a feeding cup. Is this something that she will be discharged with?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 605;
                }
                else if (Phase4PatientConversationTracker == 605)
                {
                    ChatRightText.text = "I believe so. Well it was lovely to meet you, I need to head off.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 606;
                }
                else if (Phase4PatientConversationTracker == 606)
                {
                    ChatLeftTwoText.text = "Thank you Kenshin, have a lovely day.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase4PatientConversationTracker = 607;
                    ChatNextButtonText.text = "END CHAT";
                }
                else if (Phase4PatientConversationTracker == 607)
                {
                    NPCRightOccupationalTherapistImage.SetBool("NPCRightAnimateIn", false);
                    NPCRightOccupationalTherapistImage.SetBool("NPCRightAnimateOut", true);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    inChat = false;
                    Phase4PatientConversationTracker = 8;
                    phase4SpeakToOT = false;
                }
            }
        }
        else if (PhaseManagement.gamePhase == 5)
        {
            if (currentScene == 0)
            {
                if (Phase5DietitianConversationTracker == 0)
                {
                    inChat = true;
                    ChatNextButton.interactable = true;
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    ChatLeftNameText.text = playerNameString;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    ChatRightTwoNameText.text = dieteticSupervisorNameString;
                    NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
                    ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    ChatLeftTwoNameText.text = playerNameString;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    ChatNextButtonText.text = "CONTINUE";
                    ChatLeftText.text = "Hi John, I have completed my calculations and was wondering if you could have a look at them.";
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 1;
                }
                else if (Phase5DietitianConversationTracker == 1)
                {
                    ChatRightText.text = "Hi " + playerNameString + ", sounds good, what you need to do now is evaluate her dietary intake and work out her nutrition requirements. You will also have to evaluate her body weight. Dont forget, you can use the Resource Folder on the table behind me to help you in your analysis and choose suitable energy and protein recommendations.";
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 2;
                }
                else if (Phase5DietitianConversationTracker == 2)
                {
                    inChat = true;
                    ChatLeftTwoText.text = "I was wondering if I could start with... (select an option below)";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase5MultipleChoiceButtonGroup.SetActive(true);
                    ChatNextButtonText.text = "COME BACK";
                    Phase5DietitianConversationTracker = 3;
                }
                else if (Phase5DietitianConversationTracker == 3)
                {
                    ChatLeftText.text = "Actually I will have a look at that information once more and I will be back shortly.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase5MultipleChoiceButtonGroup.SetActive(false);
                    ChatNextButtonText.text = "END CHAT";
                    Phase5DietitianConversationTracker = 4;
                }
                else if (Phase5DietitianConversationTracker == 4)
                {
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    inChat = false;
                    Phase5DietitianConversationTracker = 0;
                }
                else if (Phase5DietitianConversationTracker == 10)
                {
                    inChat = true;
                    ChatNextButton.interactable = true;
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    ChatLeftNameText.text = playerNameString;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    ChatRightTwoNameText.text = dieteticSupervisorNameString;
                    NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
                    ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    ChatLeftTwoNameText.text = playerNameString;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    ChatNextButtonText.text = "CONTINUE";
                    ChatRightText.text = "Now that you have gathered all the relevant information from Marta it is time to analyse, interpret, and evaluate your findings. Use the Food Groups Resource in the Resource Folder and assess the quality of Marta's diet by evaluating her intake from different food groups.";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 11;
                }
                else if (Phase5DietitianConversationTracker == 11)
                {
                    ChatRightTwoText.text = "Also, calculate her energy, protein, and dietary fibre intake using the Ready Reckoner in the Resource Folder. You also must calculate her fluid intake. Once you have done this come back to me and we can go through your conclusions.";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 12;
                }
                else if (Phase5DietitianConversationTracker == 12)
                {
                    ChatNextButtonText.text = "END CHAT";
                    ChatLeftText.text = "I will go to the Resource Folder now and complete the relevant calculations. I will be back shortly.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 13;
                }
                else if (Phase5DietitianConversationTracker == 13)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    Phase5DietitianConversationTracker = 0;
                    inChat = false;
                }
                else if (Phase5DietitianConversationTracker == 100)
                {
                    ChatRightText.text = "Sure, let’s look at the quality of her diet first. What does the qualitative dietary assessment show?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 101;
                }
                else if (Phase5DietitianConversationTracker == 101)
                {
                    ChatLeftTwoText.text = "";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase5AnalyseDietMultipleChoice01ButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                    Phase5DietitianConversationTracker = 102;
                }
                else if (Phase5DietitianConversationTracker == 200)
                {
                    ChatLeftText.text = "";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase5AnalyseDietMultipleChoice02ButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                    Phase5DietitianConversationTracker = 201;
                }
                else if (Phase5DietitianConversationTracker == 300)
                {
                    ChatLeftTwoText.text = "";
                    Phase5AnalyseDietFinalDecisionButtonGroup.SetActive(true);
                    ChatNextButtonText.text = "END CHAT";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 301;
                }
                else if (Phase5DietitianConversationTracker == 301)
                {
                    ChatLeftText.text = "I want to look over some of my findings first, I will be back shortly.";
                    Phase5AnalyseDietFinalDecisionButtonGroup.SetActive(false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 302;
                }
                else if (Phase5DietitianConversationTracker == 302)
                {
                    inChat = false;
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase5AnalyseDietCorrectChoiceOneSelected = false;
                    phase5AnalyseDietCorrectChoiceTwoSelected = false;
                    Phase5DietitianConversationTracker = 2;
                }
                else if (Phase5DietitianConversationTracker == 800)
                {
                    ChatLeftTwoText.text = "";
                    Phase5EnergyAndNutrientsFinalDecisionButtonGroup.SetActive(true);
                    ChatNextButtonText.text = "END CHAT";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 801;
                }
                else if (Phase5DietitianConversationTracker == 801)
                {
                    ChatLeftText.text = "I want to look over some of my findings first, I will be back shortly.";
                    Phase5EnergyAndNutrientsFinalDecisionButtonGroup.SetActive(false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 802;
                }
                else if (Phase5DietitianConversationTracker == 802)
                {
                    inChat = false;
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase5EnergyAndNutrientsCorrectChoiceOneSelected = false;
                    phase5EnergyAndNutrientsCorrectChoiceTwoSelected = false;
                    Phase5DietitianConversationTracker = 2;
                }
                else if (Phase5DietitianConversationTracker == 400)
                {
                    ChatRightText.text = "Based on your quantitative analysis of Marta’s diet and her calculated needs, is Marta meeting her energy and protein needs?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 401;
                }
                else if (Phase5DietitianConversationTracker == 401)
                {
                    ChatLeftTwoText.text = "";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase5EnergyAndNutrientsMultipleChoice01ButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 500)
                {
                    ChatLeftText.text = "Ok, I am ready to have another look.";
                    ChatNextButtonText.text = "CONTINUE";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 501;
                }
                else if (Phase5DietitianConversationTracker == 501)
                {
                    ChatRightText.text = "Sure, let’s look at the quality of her diet first. What does the qualitative dietary assessment show?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 502;
                }
                else if (Phase5DietitianConversationTracker == 502)
                {
                    ChatLeftTwoText.text = "";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase5AnalyseDietMultipleChoice01ButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 600)
                {
                    ChatLeftText.text = "Thank you. Okay I will get back to you shortly.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase5DietitianConversationTracker = 601;
                }
                else if (Phase5DietitianConversationTracker == 601)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    if (phase5Part3Complete)
                    {
                        Phase5DietitianConversationTracker = 5000;
                    }
                    else
                    {
                        Phase5DietitianConversationTracker = 2;
                    }
                    Phase5QualatativeButton.interactable = false;
                    Phase5QualatativeButton.GetComponentInChildren<Text>().text = "COMPLETED";
                    inChat = false;
                }
                else if (Phase5DietitianConversationTracker == 1000)
                {
                    ChatLeftText.text = "Thank you. Okay I will get back to you shortly.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase5DietitianConversationTracker = 1001;
                }
                else if (Phase5DietitianConversationTracker == 1001)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    if (phase5Part3Complete)
                    {
                        Phase5DietitianConversationTracker = 5000;
                    }
                    else
                    {
                        Phase5DietitianConversationTracker = 2;
                    }
                    Phase5QuantatativeButton.interactable = false;
                    Phase5QuantatativeButton.GetComponentInChildren<Text>().text = "COMPLETED";
                    inChat = false;
                }
                else if (Phase5DietitianConversationTracker == 700)
                {
                    ChatLeftText.text = "";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase5EnergyAndNutrientsMultipleChoice02ButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 900)
                {
                    ChatLeftText.text = "Ok, I am ready to have another look.";
                    ChatNextButtonText.text = "CONTINUE";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 901;
                }
                else if (Phase5DietitianConversationTracker == 901)
                {
                    ChatRightText.text = "Based on your quantitative analysis of Marta’s diet and her calculated needs, is Marta meeting her energy and protein needs?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 902;
                }
                else if (Phase5DietitianConversationTracker == 902)
                {
                    ChatLeftTwoText.text = "";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase5EnergyAndNutrientsMultipleChoice01ButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 1100)
                {
                    ChatRightText.text = "Choose one of the following energy recommendations and calculate Marta's energy requirement.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CHOOSE";
                    Phase5DietitianConversationTracker = 1101;
                }
                else if (Phase5DietitianConversationTracker == 1101)
                {
                    ChatLeftTwoText.text = "";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase5EnergyActualMultipleChoice01ButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 1200)
                {
                    ChatLeftText.text = "";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase5EnergyActualWeightInputFieldGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 1201)
                {
                    if (phase5EnergyActualFormulaOneSelected)
                    {
                        ChatRightText.text = "That equates to " + phase5formaularesultstring + "kj.";
                    }
                    else if (phase5EnergyActualFormulaTwoSelected && phase5EnergyActualCorrectWeightSelected)
                    {
                        ChatRightText.text = "That equates to " + phase5formaularesultstring + "kj. ";
                    }
                    else if (phase5EnergyActualFormulaTwoSelected && !phase5EnergyActualCorrectWeightSelected)
                    {
                        ChatRightText.text = "That equates to " + phase5formaularesultstring + "kj.";
                    }
                    else if (phase5EnergyActualFormulaThreeSelected)
                    {
                        ChatRightText.text = "That equates to " + phase5formaularesultstring + "kj.";
                    }
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 1202;
                }
                else if (Phase5DietitianConversationTracker == 1202)
                {
                    ChatRightTwoText.text = "Now let's look at the following protein recommendations and calculate Marta's protein requirement.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase5DietitianConversationTracker = 1203;
                }
                else if (Phase5DietitianConversationTracker == 1203)
                {
                    ChatLeftText.text = "";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatNextButton.interactable = false;
                    phase5EnergyActualMultipleChoice02ButtonGroup.SetActive(true);
                }
                else if (Phase5DietitianConversationTracker == 1204)
                {
                    if (phase5EnergyActualPartTwoFormulaOneSelected)
                    {
                        ChatRightTwoText.text = "That works out to be " + phase5PartTwoFormulaResultString + " grams. ";
                    }
                    else if (phase5EnergyActualPartTwoFormulaTwoSelected)
                    {
                        ChatRightTwoText.text = "That works out to be " + phase5PartTwoFormulaResultString + " grams.";
                    }
                    else if (phase5EnergyActualPartTwoFormulaThreeSelected && phase5EnergyActualCorrectWeightSelected)
                    {
                        ChatRightTwoText.text = "That works out to be " + phase5PartTwoFormulaResultString + " grams.";
                    }
                    else if (phase5EnergyActualPartTwoFormulaThreeSelected && !phase5EnergyActualCorrectWeightSelected)
                    {
                        ChatRightTwoText.text = "That works out to be " + phase5PartTwoFormulaResultString + " grams.";
                    }
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase5DietitianConversationTracker = 1205;
                }
                else if (Phase5DietitianConversationTracker == 1205)
                {
                    ChatRightThreeText.text = "Okay now that you have calculated Marta's energy and protein requirements, let's take a look at her fibre requirements. Which of the following dietary fibre recommendations will best meet Marta's needs?";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightThreeAnim.SetBool("ChatDefault", false);
                    ChatRightThreeAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 1206;
                }
                else if (Phase5DietitianConversationTracker == 1206)
                {
                    ChatLeftText.text = "";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatRightThreeAnim.SetBool("ChatActivated", false);
                    ChatRightThreeAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase5EnergyActualMultipleChoice03ButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 1207)
                {
                    ChatRightTwoText.text = "Which of the following fluid recommendations will best meet Marta's needs?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 1208;
                }
                else if (Phase5DietitianConversationTracker == 1208)
                {
                    ChatLeftText.text = "";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase5EnergyActualMultipleChoice04ButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 1209)
                {
                    ChatRightTwoText.text = "Do you want save this information to your ClinPad or go back and reevaluate?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CHOOSE";
                    Phase5DietitianConversationTracker = 1210;
                }
                else if (Phase5DietitianConversationTracker == 1210)
                {
                    ChatLeftText.text = "";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase5EnergyActualFinalDecisionButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 1300)
                {
                    ChatLeftTwoText.text = "Okay, thank you for that. I will talk to you shortly.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase5DietitianConversationTracker = 1301;
                }
                else if (Phase5DietitianConversationTracker == 1301)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    if (phase5Part3Complete)
                    {
                        Phase5DietitianConversationTracker = 5000;
                    }
                    else
                    {
                        Phase5DietitianConversationTracker = 2;
                    }
                    Phase5EnergyActualButton.interactable = false;
                    Phase5EnergyActualButton.GetComponentInChildren<Text>().text = "COMPLETED";
                    inChat = false;
                }
                else if (Phase5DietitianConversationTracker == 1400)
                {
                    ChatLeftTwoText.text = "Could I please have the questions again to fix my mistakes.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 1401;
                }
                else if (Phase5DietitianConversationTracker == 1401)
                {
                    ChatLeftText.text = "What was the first question again, John?";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 1100;
                }
                else if (Phase5DietitianConversationTracker == 2000)
                {
                    ChatRightText.text = "I see you have calculated Marta's body mass index as 21 kg/m2, how would you evaluate this?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 2001;
                }
                else if (Phase5DietitianConversationTracker == 2001)
                {
                    ChatLeftTwoText.text = "";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase5BodyWeightMultipleChoice01ButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 2002)
                {
                    ChatLeftText.text = "";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase5BodyWeightMultipleChoice02ButtonGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 2003)
                {
                    ChatLeftTwoText.text = "";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase5BodyWeightUsualWeightInputGroup.SetActive(true);
                    ChatNextButton.interactable = false;
                }
                else if (Phase5DietitianConversationTracker == 2004)
                {
                    if (phase5EnergyRequirementsComplete && phase5AnalyseDietComplete && phase5EnergyActualEvaluationComplete)
                    {
                        ChatRightText.text = "Well done, you correctly assessed Marta’s diet and identified the key nutrients that she may be lacking. You can now complete the SGA form located on the desk behind me.";
                        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                        ChatLeftTwoAnim.SetBool("ChatDefault", true);
                        ChatRightTwoAnim.SetBool("ChatActivated", false);
                        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                        ChatRightAnim.SetBool("ChatDefault", false);
                        ChatRightAnim.SetBool("ChatActivated", true);
                        phase5WeightEvaluationComplete = true;
                        Phase5DietitianConversationTracker = 2005;
                        ChatNextButtonText.text = "NEXT";
                        phase5Part3Complete = true;
                    }
                    else
                    {
                        ChatRightText.text = "Well done, you correctly assessed Marta’s diet and identified the key nutrients that she may be lacking. When you are ready come back to me and we will complete the other evaluations.";
                        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                        ChatLeftTwoAnim.SetBool("ChatDefault", true);
                        ChatRightTwoAnim.SetBool("ChatActivated", false);
                        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                        ChatRightAnim.SetBool("ChatDefault", false);
                        ChatRightAnim.SetBool("ChatActivated", true);
                        phase5WeightEvaluationComplete = true;
                        Phase5DietitianConversationTracker = 2005;
                    }
                    if (phase05BodyWeightIncorrectScore == 1)
                    {
                        phase05BodyWeightPlayerRating = playerRatingIntermediate;
                        phase08OverallScore = phase08OverallScore + 1;
                    }
                    else if (phase05BodyWeightIncorrectScore > 1)
                    {
                        phase05BodyWeightPlayerRating = playerRatingNovice;
                        phase08OverallScore = phase08OverallScore + 2;
                    }
                }
                else if (Phase5DietitianConversationTracker == 2005)
                {
                    ChatLeftTwoText.text = "Okay, thank you for that. I will talk to you shortly.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase5DietitianConversationTracker = 2006;
                }
                else if (Phase5DietitianConversationTracker == 2006)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase5BodyWeightButton.interactable = false;
                    Phase5BodyWeightButton.GetComponentInChildren<Text>().text = "COMPLETED";
                    inChat = false;
                    if (phase5Part3Complete)
                    {
                        Phase5DietitianConversationTracker = 5000;
                    }
                    else
                    {
                        Phase5DietitianConversationTracker = 2;
                    }
                }
                else if (Phase5DietitianConversationTracker == 5000)
                {
                    inChat = true;
                    ChatRightText.text = "Hi, how can I help you?";
                    ChatNextButton.interactable = true;
                    ChatNextButtonText.text = "NEXT";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 5001;
                }
                else if (Phase5DietitianConversationTracker == 5001)
                {
                    ChatLeftText.text = "I was just wondering now that I have finished the evaluations, what would be my next step?";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 5002;
                }
                else if (Phase5DietitianConversationTracker == 5002)
                {
                    ChatRightTwoText.text = "Check the Resource Folder on the desk behind me and complete the SGA Form. Once you have completed that come and see me to discuss the next thing you need to do.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 5003;
                }
                else if (Phase5DietitianConversationTracker == 5003)
                {
                    ChatLeftTwoText.text = "Thanks. I will complete the form now.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase5DietitianConversationTracker = 5004;
                    ChatNextButtonText.text = "END CHAT";
                }
                else if (Phase5DietitianConversationTracker == 5004)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase5DietitianConversationTracker = 5000;
                    inChat = false;
                }
                //if (!readNutritionalDocument) {
                //    if (!alreadySpokenPhase5)
                //    {
                //        if (Phase5ConversationTracker == 0)
                //        {
                //            inChat = true;
                //            ChatRightNameText.text = dieteticSupervisorNameString;
                //            ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                //            ChatNextButtonText.text = "CONTINUE";
                //            NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                //            NPCRightChatPortrait.sprite = DieticianPortraitImage;
                //            ChatTextLeftHeaderImage.color = new Color32(84, 164, 204, 255);
                //            ChatLeftNameText.text = playerNameString;
                //            ChatRightAnim.SetBool("ChatDefault", false);
                //            ChatRightAnim.SetBool("ChatActivated", true);
                //            ChatRightText.text = "Hi, I want to talk to you about the patients nutritional requirements.";
                //            ChatLeftText.text = "Sure, lets get down to business";
                //            Phase5ConversationTracker = 1;
                //        }
                //        else if (Phase5ConversationTracker == 1)
                //        {
                //            ChatNextButtonText.text = "Receive Document";
                //            ChatRightAnim.SetBool("ChatActivated", false);
                //            ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                //            ChatLeftAnim.SetBool("ChatDefault", false);
                //            ChatLeftAnim.SetBool("ChatActivated", true);
                //            Phase5ConversationTracker = 2;
                //        }
                //        else if (Phase5ConversationTracker == 2)
                //        {
                //            ChatRightTwoText.text = "Here is the document, you can check it from your ClinPad and then come back to me when you are ready to answer some questions.";
                //            ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                //            ChatRightAnim.SetBool("ChatDefault", true);
                //            ChatLeftAnim.SetBool("ChatActivated", false);
                //            ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                //            ChatRightTwoAnim.SetBool("ChatDefault", false);
                //            ChatRightTwoAnim.SetBool("ChatActivated", true);
                //            ClinPadNutritionalRequirementsButton.SetActive(true);
                //            Phase5ConversationTracker = 3;
                //        }
                //        else if (Phase5ConversationTracker == 3)
                //        {
                //            ReceivedItemToggle();
                //            ChatLeftTwoText.text = "Ok I will have a look at it now and get back to you";
                //            ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                //            ChatLeftAnim.SetBool("ChatDefault", true);
                //            ChatRightTwoAnim.SetBool("ChatActivated", false);
                //            ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                //            ChatLeftTwoAnim.SetBool("ChatDefault", false);
                //            ChatLeftTwoAnim.SetBool("ChatActivated", true);
                //            ChatNextButtonText.text = "END CHAT";
                //            Phase5ConversationTracker = 4;
                //        }
                //        else if (Phase5ConversationTracker == 4) {
                //            ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                //            ChatRightTwoAnim.SetBool("ChatDefault", true);
                //            ChatLeftTwoAnim.SetBool("ChatActivated", false);
                //            ChatLeftTwoAnim.SetBool("ChatDefault", true);
                //            inChat = false;
                //            Phase5ConversationTracker = 0;
                //            alreadySpokenPhase5 = true;
                //        }
                //    }
                //    else if (alreadySpokenPhase5) {
                //        if (Phase5ConversationTracker == 0)
                //        {
                //            inChat = true;
                //            ChatRightNameText.text = dieteticSupervisorNameString;
                //            ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                //            ChatNextButtonText.text = "Not Yet";
                //            NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                //            NPCRightChatPortrait.sprite = DieticianPortraitImage;
                //            ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                //            ChatLeftNameText.text = playerNameString;
                //            ChatRightAnim.SetBool("ChatDefault", false);
                //            ChatRightAnim.SetBool("ChatActivated", true);
                //            ChatRightText.text = "Have you read the nutritional requirements of the patient yet?";
                //            ChatLeftText.text = "No, not yet";
                //            Phase5ConversationTracker = 1;
                //        }
                //        else if (Phase5ConversationTracker == 1) {
                //            ChatRightTwoNameText.text = dieteticSupervisorNameString;
                //            ChatRightTwoText.text = "OK, well you come back to me once you have read the document";
                //            ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                //            NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
                //            ChatRightAnim.SetBool("ChatActivated", false);
                //            ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                //            ChatLeftAnim.SetBool("ChatDefault", false);
                //            ChatLeftAnim.SetBool("ChatActivated", true);
                //            ChatNextButtonText.text = "Continue";
                //            Phase5ConversationTracker = 2;
                //        }
                //        else if (Phase5ConversationTracker == 2)
                //        {
                //            ChatLeftTwoNameText.text = playerNameString;
                //            NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                //            ChatLeftTwoText.text = "No problem, will do";
                //            ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                //            ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                //            ChatRightAnim.SetBool("ChatDefault", true);
                //            ChatLeftAnim.SetBool("ChatActivated", false);
                //            ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                //            ChatRightTwoAnim.SetBool("ChatDefault", false);
                //            ChatRightTwoAnim.SetBool("ChatActivated", true);
                //            ChatNextButtonText.text = "END CHAT";
                //            Phase5ConversationTracker = 3;
                //        }
                //        else if (Phase5ConversationTracker == 3)
                //        {
                //            ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                //            ChatLeftAnim.SetBool("ChatDefault", true);
                //            ChatRightTwoAnim.SetBool("ChatActivated", false);
                //            ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                //            ChatLeftAnim.SetBool("ChatDefault", false);
                //            ChatLeftAnim.SetBool("ChatActivated", true);
                //            ChatNextButtonText.text = "GOOD BYE";
                //            Phase5ConversationTracker = 4;
                //        }
                //        else if (Phase5ConversationTracker == 4) {
                //            ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                //            ChatRightTwoAnim.SetBool("ChatDefault", true);
                //            ChatLeftAnim.SetBool("ChatActivated", false);
                //            ChatLeftAnim.SetBool("ChatDefault", true);
                //            inChat = false;
                //            Phase5ConversationTracker = 0;
                //        }
                //    }
                //}
            }
            if (currentScene == 1)
            {
                ChatRightNameText.text = nurseNameString;
                ChatTextRightHeaderImage.color = nurseChatHeaderColour;
                NPCRightChatPortrait.sprite = NursePortraitImage;
                ChatRightTwoNameText.text = nurseNameString;
                ChatTextRightTwoHeaderImage.color = nurseChatHeaderColour;
                NPCRightTwoChatPortrait.sprite = NursePortraitImage;
                ChatLeftNameText.text = playerNameString;
                ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                ChatLeftTwoNameText.text = playerNameString;
                ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                if (Phase5ConversationTracker == 0)
                {
                    inChat = true;
                    ChatNextButton.interactable = true;
                    ChatRightText.text = "Hi, how can I help you?";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase5ConversationTracker = 1;
                    ChatNextButtonText.text = "CONTINUE";
                }
                else if (Phase5ConversationTracker == 1)
                {
                    ChatLeftText.text = "I was wondering what the next step would be?";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase5ConversationTracker = 2;
                }
                else if (Phase5ConversationTracker == 2)
                {
                    ChatRightTwoText.text = "I believe that John was looking for you, I think he wants to talk to you about what you have learnt about Marta so far.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase5ConversationTracker = 3;
                }
                else if (Phase5ConversationTracker == 3)
                {
                    ChatLeftTwoText.text = "Okay, thanks for that. I will go have a chat to him now.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase5ConversationTracker = 4;
                }
                else if (Phase5ConversationTracker == 4)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase5ConversationTracker = 0;
                    inChat = false;
                }
            }
            if (currentScene == 2)
            {
                ChatRightNameText.text = patientNameString;
                ChatTextRightHeaderImage.color = patientChatHeaderColour;
                NPCRightChatPortrait.sprite = PatientPortraitImage;
                ChatRightTwoNameText.text = patientNameString;
                ChatTextRightTwoHeaderImage.color = patientChatHeaderColour;
                NPCRightTwoChatPortrait.sprite = PatientPortraitImage;
                ChatLeftNameText.text = playerNameString;
                ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                ChatLeftTwoNameText.text = playerNameString;
                ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                if (Phase5ConversationTracker == 0)
                {
                    inChat = true;
                    ChatNextButton.interactable = true;
                    ChatRightText.text = playerNameString + " have you got all the information you need? I'm starting to feel tired now.";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase5ConversationTracker = 1;
                }
                else if (Phase5ConversationTracker == 1)
                {
                    ChatLeftText.text = "Yes thank you for your patience Marta. I'm going to check my findings with my supervisor and will be back to provide you with some guidance on how to help you with your concerns. Is that okay?";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase5ConversationTracker = 2;
                }
                else if (Phase5ConversationTracker == 2)
                {
                    ChatRightTwoText.text = "That sounds good, thank you.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase5ConversationTracker = 3;
                }
                else if (Phase5ConversationTracker == 3)
                {
                    ChatLeftTwoText.text = "Good, you get some rest now.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase5ConversationTracker = 4;
                }
                else if (Phase5ConversationTracker == 4)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    inChat = false;
                    Phase5ConversationTracker = 0;
                }
            }
        }
        else if (PhaseManagement.gamePhase == 6)
        {
            if (currentScene == 0)
            {
                if (Phase6ConversationTracker == 0)
                {
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                    ChatRightTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    inChat = true;
                    ChatRightText.text = "Hi " + playerNameString + ", how can I help you?";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase6ConversationTracker = 1;
                }
                else if (Phase6ConversationTracker == 1)
                {
                    ChatLeftText.text = "Hi again John, I was wondering what my next step would be?";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase6ConversationTracker = 2;
                }
                else if (Phase6ConversationTracker == 2)
                {
                    ChatRightTwoText.text = "Now that you have finished with the SGA form, you can use the computer to select the most pertinent problems and provide the evidence that backs up your claims.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase6ConversationTracker = 3;
                }
                else if (Phase6ConversationTracker == 3)
                {
                    ChatLeftTwoText.text = "No problem, I will look into that now.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase6ConversationTracker = 4;
                }
                else if (Phase6ConversationTracker == 4)
                {
                    inChat = false;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase6ConversationTracker = 0;
                }
            }
            else if (currentScene == 1)
            {
                ChatRightNameText.text = nurseNameString;
                ChatTextRightHeaderImage.color = nurseChatHeaderColour;
                NPCRightChatPortrait.sprite = NursePortraitImage;
                ChatRightTwoNameText.text = nurseNameString;
                ChatTextRightTwoHeaderImage.color = nurseChatHeaderColour;
                NPCRightTwoChatPortrait.sprite = NursePortraitImage;
                ChatLeftNameText.text = playerNameString;
                ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                ChatLeftTwoNameText.text = playerNameString;
                ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                if (Phase6ConversationTracker == 0)
                {
                    inChat = true;
                    ChatRightText.text = "Hi " + playerNameString + ", is there something I can do for you?";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase6ConversationTracker = 1;
                }
                else if (Phase6ConversationTracker == 1)
                {
                    ChatLeftText.text = "Hi. Yes I was wondering if you could tell me what to do next?";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase6ConversationTracker = 2;
                }
                else if (Phase6ConversationTracker == 2)
                {
                    ChatRightTwoText.text = "I think John would like to talk to you. He should know what your next step should be.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase6ConversationTracker = 3;
                }
                else if (Phase6ConversationTracker == 3)
                {
                    ChatLeftTwoText.text = "Thanks, I will go and talk to him now. Bye.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase6ConversationTracker = 4;
                }
                else if (Phase6ConversationTracker == 4)
                {
                    inChat = false;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase6ConversationTracker = 0;
                }
            }
            else if (currentScene == 2)
            {
                ChatRightNameText.text = patientNameString;
                ChatTextRightHeaderImage.color = patientChatHeaderColour;
                NPCRightChatPortrait.sprite = PatientPortraitImage;
                ChatRightTwoNameText.text = patientNameString;
                ChatTextRightTwoHeaderImage.color = patientChatHeaderColour;
                NPCRightTwoChatPortrait.sprite = PatientPortraitImage;
                ChatLeftNameText.text = playerNameString;
                ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                ChatLeftTwoNameText.text = playerNameString;
                ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                if (Phase6ConversationTracker == 0)
                {
                    inChat = true;
                    ChatRightText.text = "Hello " + playerNameString + ".";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase6ConversationTracker = 1;
                }
                else if (Phase6ConversationTracker == 1)
                {
                    ChatLeftText.text = "Hello Marta. I was just following up to see how you were before I spoke to the supervising dietitian.";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase6ConversationTracker = 2;
                }
                else if (Phase6ConversationTracker == 2)
                {
                    ChatRightTwoText.text = "I am feeling okay, thank you for checking in on me.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase6ConversationTracker = 3;
                }
                else if (Phase6ConversationTracker == 3)
                {
                    ChatLeftTwoText.text = "That's good to hear, I will speak to John now and make sure we get you completely back on track.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase6ConversationTracker = 4;
                }
                else if (Phase6ConversationTracker == 4)
                {
                    inChat = false;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase6ConversationTracker = 0;
                }
            }
        }
        else if (PhaseManagement.gamePhase == 7)
        {
            if (currentScene == 0)
            {
                if (Phase7ConversationTracker == 0)
                {
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                    ChatRightTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    inChat = true;
                    ChatRightText.text = "Hi " + playerNameString + ", good to see you progressing.";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase7ConversationTracker = 1;
                }
                else if (Phase7ConversationTracker == 1)
                {
                    ChatLeftText.text = "Thank you. I've identified Marta’s main nutrition problems and potential causes. Can I start and develop a nutrition intervention plan for her now?";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 2;
                }
                else if (Phase7ConversationTracker == 2)
                {
                    ChatRightTwoText.text = "That’s good, let’s take a look at what you came up with for her in terms of her nutrition problems and the causes thereof.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 3;
                }
                else if (Phase7ConversationTracker == 3)
                {
                    if (phase06part02PotentialIssue03String != "")
                    {
                        ChatLeftTwoText.text = "What I have is " + phase06part02PotentialIssue01String + ", " + phase06part02PotentialIssue02String + " and " + phase06part02PotentialIssue03String + ".";
                    }
                    else if (phase06part02PotentialIssue02String != "" && phase06part02PotentialIssue03String == "")
                    {
                        ChatLeftTwoText.text = "What I have is " + phase06part02PotentialIssue01String + " and " + phase06part02PotentialIssue02String + ".";
                    }
                    else if (phase06part02PotentialIssue02String == "")
                    {
                        ChatLeftTwoText.text = "What I have is " + phase06part02PotentialIssue01String + ".";
                    }
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 4;
                }
                else if (Phase7ConversationTracker == 4)
                {
                    ChatRightText.text = "Okay, so what you can do now is go to the computer and start working on strategies for Marta to help resolve her nutrition problems. Remember that Marta will be discharged later today or tomorrow and then come back for a review in two weeks to the outpatient’s clinic.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase7ConversationTracker = 5;
                }
                else if (Phase7ConversationTracker == 5)
                {
                    inChat = false;
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    phase07DietitianInitialConversationComplete = true;
                    Phase7ConversationTracker = 0;
                }
                else if (Phase7ConversationTracker == 100)
                {
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                    ChatRightTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    inChat = true;
                    ChatRightText.text = "Hi " + playerNameString + ", all done on the computer?";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase7ConversationTracker = 101;
                }
                else if (Phase7ConversationTracker == 101)
                {
                    ChatLeftText.text = "Yep, I have identified some strategies for Marta to help resolve her nutrition problems. How do I proceed with this now?";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 102;
                }
                else if (Phase7ConversationTracker == 102)
                {
                    ChatRightTwoText.text = "Okay " + playerNameString + ", go back to Marta now and discuss your suggested strategies with her and also explain to her why she needs to make these changes.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 103;
                }
                else if (Phase7ConversationTracker == 103)
                {
                    ChatLeftTwoText.text = "That sounds good, thank you John.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase7ConversationTracker = 104;
                }
                else if (Phase7ConversationTracker == 104)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase7ConversationTracker = 100;
                    inChat = false;
                }
                else if (Phase7ConversationTracker == 1000)
                {
                    ChatRightNameText.text = dieteticSupervisorNameString;
                    ChatTextRightHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCRightChatPortrait.sprite = DieticianPortraitImage;
                    ChatRightTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    inChat = true;
                    ChatRightText.text = "Hi " + playerNameString + ", how can I help you?";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase7ConversationTracker = 1001;
                }
                else if (Phase7ConversationTracker == 1001)
                {
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 1002;
                    ChatLeftText.text = "Just letting you know that I have finished speaking with Marta, and I will be back in two weeks to see her progression.";
                }
                else if (Phase7ConversationTracker == 1002)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 1003;
                    ChatRightTwoText.text = "Thanks for letting me know, I will see you in two weeks and see how the plan for Marta is shaping up. Goodbye.";
                }
                else if (Phase7ConversationTracker == 1003)
                {
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 1004;
                    ChatLeftTwoText.text = "See you later.";
                }
                else if (Phase7ConversationTracker == 1004)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase7ConversationTracker = 1000;
                    inChat = false;
                }
            }
            else if (currentScene == 1)
            {
                ChatRightNameText.text = nurseNameString;
                ChatTextRightHeaderImage.color = nurseChatHeaderColour;
                NPCRightChatPortrait.sprite = NursePortraitImage;
                ChatRightTwoNameText.text = nurseNameString;
                ChatTextRightTwoHeaderImage.color = nurseChatHeaderColour;
                NPCRightTwoChatPortrait.sprite = NursePortraitImage;
                ChatLeftNameText.text = playerNameString;
                ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                ChatLeftTwoNameText.text = playerNameString;
                ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                if (Phase7ConversationTracker == 0)
                {
                    inChat = true;
                    ChatRightText.text = "Hi " + playerNameString + ", is there something I can do for you?";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase7ConversationTracker = 1;
                }
                else if (Phase7ConversationTracker == 1)
                {
                    ChatLeftText.text = "Hi. Yes before I speak to John I was wondering if there is anything you can tell me about Marta?";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 2;
                }
                else if (Phase7ConversationTracker == 2)
                {
                    ChatRightTwoText.text = "I think once you speak to John and finalise your assessment, you can speak to Marta and discuss ongoing strategies before she is discharged.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 3;
                }
                else if (Phase7ConversationTracker == 3)
                {
                    ChatLeftTwoText.text = "Thank you for that, I will go and speak to John now.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase7ConversationTracker = 4;
                }
                else if (Phase7ConversationTracker == 4)
                {
                    inChat = false;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase7ConversationTracker = 0;
                }
                else if (Phase7ConversationTracker == 100)
                {
                    inChat = true;
                    ChatRightText.text = "Hi " + playerNameString + ", are you on your way to speak to Marta about her nutrition goals? She is being discharged today.";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase7ConversationTracker = 101;
                }
                else if (Phase7ConversationTracker == 101)
                {
                    ChatLeftText.text = "Yep, finished to goals on the computer and John's office and will go and speak to Marta now.";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 102;
                }
                else if (Phase7ConversationTracker == 102)
                {
                    ChatRightTwoText.text = "Okay, good idea. Bye.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 103;
                }
                else if (Phase7ConversationTracker == 103)
                {
                    ChatLeftTwoText.text = "Bye.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase7ConversationTracker = 104;
                }
                else if (Phase7ConversationTracker == 104)
                {
                    inChat = false;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase7ConversationTracker = 100;
                }
                else if (Phase7ConversationTracker == 1000)
                {
                    inChat = true;
                    ChatRightText.text = "Hi " + playerNameString + ", is there something I can do for you?";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase7ConversationTracker = 1001;
                }
                else if (Phase7ConversationTracker == 1001)
                {
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 1002;
                    ChatLeftText.text = "Just letting you know that I have finished speaking with Marta, and I will be back in two weeks to see how she is progressing.";
                }
                else if (Phase7ConversationTracker == 1002)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 1003;
                    ChatRightTwoText.text = "Thanks for letting me know, I will see you in two weeks and see how the plan for Marta is shaping up. Goodbye.";
                }
                else if (Phase7ConversationTracker == 1003)
                {
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 1004;
                    ChatLeftTwoText.text = "See you later.";
                }
                else if (Phase7ConversationTracker == 1004)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase7ConversationTracker = 1000;
                    inChat = false;
                }
            }
            else if (currentScene == 2)
            {
                ChatRightNameText.text = patientNameString;
                ChatTextRightHeaderImage.color = patientChatHeaderColour;
                NPCRightChatPortrait.sprite = PatientPortraitImage;
                ChatRightTwoNameText.text = patientNameString;
                ChatTextRightTwoHeaderImage.color = patientChatHeaderColour;
                NPCRightTwoChatPortrait.sprite = PatientPortraitImage;
                ChatLeftNameText.text = playerNameString;
                ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                ChatLeftTwoNameText.text = playerNameString;
                ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                if (Phase7ConversationTracker == 0)
                {
                    inChat = true;
                    ChatRightText.text = "Hello " + playerNameString + ".";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase7ConversationTracker = 1;
                }
                else if (Phase7ConversationTracker == 1)
                {
                    ChatLeftText.text = "Hello Marta, do you remember me? It’s " + playerNameString + ", the student dietitian. I was here earlier asking questions on your food intake?. I am just letting you know that I am going to speak with the Dietitian to plan your nutritional goals and I will be back to see you before you leave to give you a plan I want you to follow.";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 2;
                }
                else if (Phase7ConversationTracker == 2)
                {
                    ChatRightTwoText.text = "Yes, I remember you. Thank you for letting me know. I am just going to rest for a bit.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 3;
                }
                else if (Phase7ConversationTracker == 3)
                {
                    ChatLeftTwoText.text = "No worries Marta, I will be back shortly.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase7ConversationTracker = 4;
                }
                else if (Phase7ConversationTracker == 4)
                {
                    inChat = false;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase7SpokenWithMarta = true;
                    Phase7ConversationTracker = 0;
                }
                else if (Phase7ConversationTracker == 100)
                {
                    inChat = true;
                    if (!phase7SpokenWithMarta)
                    {
                        ChatLeftText.text = "Hello Marta, do you remember me? It’s " + playerNameString + ", the student dietitian. I was here earlier asking questions on your food intake?";
                    }
                    else
                    {
                        ChatLeftText.text = "Hello Marta, I finished speaking with John, the Dietitian. Do you have som to discuss my findings with you?";
                    }
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase7ConversationTracker = 101;
                }
                else if (Phase7ConversationTracker == 101)
                {
                    ChatRightText.text = "Oh, hello " + playerNameString + ". Yes I remember you, come on in.";
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 102;
                }
                else if (Phase7ConversationTracker == 102)
                {
                    ChatLeftTwoText.text = "Thank you, I understand you will go home soon so I was hoping we could talk about some changes you may be able to make at home with what you eat and drink to help you with your health, is that alright?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 103;
                }
                else if (Phase7ConversationTracker == 103)
                {
                    ChatRightTwoText.text = "Yes sure, I would appreciate some ideas on how to eat better and help keep my body strong.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 104;
                }
                else if (Phase7ConversationTracker == 104)
                {
                    ChatLeftText.text = "Okay good, well first of all I would like to explain to you why you need to make some changes to the way you eat. What I have noticed is that you have lost some muscle and fat stores from your body over the last few months and that you are not eating as well as you used to.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 105;
                }
                else if (Phase7ConversationTracker == 105)
                {
                    ChatRightText.text = "Yes, it’s been a bit of a struggle with these hands of mine. They don’t work as well as they use to you see.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 106;
                }
                else if (Phase7ConversationTracker == 106)
                {
                    ChatLeftTwoText.text = "It sounds like you have been having a hard time with the loss of some of the function of your hands.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 107;
                }
                else if (Phase7ConversationTracker == 107)
                {
                    ChatRightTwoText.text = "Yes, It has been hard.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 108;
                }
                else if (Phase7ConversationTracker == 108)
                {
                    if (phase7DietaryStrategies01OptionSelected && !phase7DietaryStrategies02OptionSelected && !phase7DietaryStrategies03OptionSelected)
                    {
                        ChatLeftText.text = "Well you see when we don’t eat enough food to support our body’s needs we start to loose muscle and fat stores. When muscle stores are lost we grow weaker and our bodies are not so good to fight back all types of disease when we get sick compared to when we have enough muscle stores. We also are not able to do all the things we used to do like cleaning, going for a walk, cooking and so on. Now you also have RA which makes it even more difficult for you to do your daily activities. So we want to make sure that your muscle stores are at the right level to give you strength to do your daily activities.";
                        Phase7ConversationTracker = 200;
                    }
                    else if (!phase7DietaryStrategies01OptionSelected && phase7DietaryStrategies02OptionSelected && !phase7DietaryStrategies03OptionSelected)
                    {
                        ChatLeftText.text = "Well you see when we don’t eat enough food that contains roughage or fibre your stools can get hard and difficult to pass. We find roughage or fibre in fruit and vegetables and also in wholegrains and legumes like beans, lentils and peas.  There are two types of fibre we get, the one type forms a gel in our bowels and helps to makes our stools softer and we get this in the flesh of fruit and vegetables and in some grains like oats.";
                        Phase7ConversationTracker = 300;
                    }
                    else if (!phase7DietaryStrategies01OptionSelected && !phase7DietaryStrategies02OptionSelected && phase7DietaryStrategies03OptionSelected)
                    {
                        ChatLeftText.text = "So I don’t know if you know that more than 70% of our bodies are made up of fluid and for our bodies to work properly we need to make sure that we keep our body’s fluid level up. This is also sometimes referred to as we need to make sure we are well hydrated. If we don’t take enough fluids in everyday our fluid stores become low and our organs like our heart and kidneys, as well as our brain don’t work that well anymore.";
                        Phase7ConversationTracker = 400;
                    }
                    else
                    {
                        if (phase7DietaryStrategies01OptionSelected && phase7DietaryStrategies02OptionSelected && !phase7DietaryStrategies03OptionSelected)
                        {
                            ChatLeftText.text = "Well you see when we don’t eat enough food to support our body’s needs we start to lose muscle and fat stores. When muscle stores are lost we grow weaker and our bodies can’t fight back all types of disease so well when we get sick as when we have enough muscle stores. We also are not able to do all the things we used to do like cleaning, going for a walk, cooking and so on. Now you also have RA which also makes it even more difficult for you to do your daily activities.";
                            Phase7ConversationTracker = 500;
                        }
                        else if (phase7DietaryStrategies01OptionSelected && !phase7DietaryStrategies02OptionSelected && phase7DietaryStrategies03OptionSelected)
                        {
                            ChatLeftText.text = "Well you see when we don’t eat enough food to support our body’s needs we start to lose muscle and fat stores. When muscle stores are lost we grow weaker and our bodies can’t fight back all types of disease so well when we get sick as when we have enough muscle stores. We also are not able to do all the things we used to do like cleaning, going for a walk, cooking and so on. Now you also have RA which also makes it even more difficult for you to do your daily activities.";
                            Phase7ConversationTracker = 600;
                        }
                        else if (!phase7DietaryStrategies01OptionSelected && phase7DietaryStrategies02OptionSelected && phase7DietaryStrategies03OptionSelected)
                        {
                            ChatLeftText.text = "When we don’t eat enough food that contains roughage or fibre your stools can get hard and difficult to pass. We find roughage or fibre in fruit and vegetables and also in whole grains.  There are two types of fibre we get, the one type forms like a gel in our bowels and helps to make our stools softer and we get this in the flesh of fruit and vegetables and in some grains like oats.  The other type helps to move the stool through the bowel and we get this mostly in the skin of fruit and edible skin of vegetables and also in the hulls of grain.";
                            Phase7ConversationTracker = 700;
                        }
                        else if (phase7DietaryStrategies01OptionSelected && phase7DietaryStrategies02OptionSelected && phase7DietaryStrategies03OptionSelected)
                        {
                            ChatLeftText.text = "Well you see when we don’t eat enough food to support our body’s needs we start to lose muscle and fat stores. When muscle stores are lost we grow weaker and our bodies can’t fight back all types of disease so well when we get sick as when we have enough muscle stores. We also are not able to do all the things we used to do like cleaning, going for a walk, cooking and so on. Now you also have RA which also makes it even more difficult for you to do your daily activities.";
                            Phase7ConversationTracker = 800;
                        }

                    }
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                }
                else if (Phase7ConversationTracker == 200)
                {
                    ChatLeftTwoText.text = "Also we want to make sure you eat enough food so you have more energy during the day. Does that make sense?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 201;
                }
                else if (Phase7ConversationTracker == 201)
                {
                    ChatRightText.text = "Oh I see, so I need to build up my muscles to give me more strength and eat more so I have more energy?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 202;
                }
                else if (Phase7ConversationTracker == 202)
                {
                    ChatLeftText.text = "Yes, that’s right.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 203;
                }
                else if (Phase7ConversationTracker == 203)
                {
                    ChatRightTwoText.text = "Well, I just don’t feel hungry that much so I guess that is why I’m not eating enough. I also feel nauseous a lot of the time.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 204;
                }
                else if (Phase7ConversationTracker == 204)
                {
                    string foodRelatedStrategiesList = "";
                    foreach (string stringItem in phase07FoodStrategyStringArray)
                    {
                        foodRelatedStrategiesList = foodRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftTwoText.text = "Yes, so I’ve come up with some strategies for you which will help you with this. They are: " + foodRelatedStrategiesList;
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 205;
                }
                else if (Phase7ConversationTracker == 205)
                {
                    string educationalRelatedStrategiesList = "";
                    foreach (string stringItem in phase07EducationalStrategyStringArray)
                    {
                        educationalRelatedStrategiesList = educationalRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftText.text = "I also have some information for you here to take home on: " + educationalRelatedStrategiesList;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 206;
                }
                else if (Phase7ConversationTracker == 206)
                {
                    ChatRightText.text = "Thank you, I’ll see how I manage, will I see you again?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 207;
                }
                else if (Phase7ConversationTracker == 207)
                {
                    ChatLeftTwoText.text = "Yes, I would like to see you again in two weeks. Will you be able to come in?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 208;
                }
                else if (Phase7ConversationTracker == 208)
                {
                    ChatRightTwoText.text = "Yes, I should be able to manage that.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 209;
                }
                else if (Phase7ConversationTracker == 209)
                {
                    ChatLeftText.text = "Oh good, thank you Marta, I’ll see you then soon.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 210;
                }
                else if (Phase7ConversationTracker == 210)
                {
                    ChatRightText.text = "Thank you " + playerNameString + ", have a good day.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase7ConversationTracker = 211;
                }
                else if (Phase7ConversationTracker == 211)
                {
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    inChat = false;
                    Phase7ConversationTracker = 1000;
                    phase07ToPhase08TransitionAnim.SetTrigger("AnimateIn");
                    StartCoroutine("Phase07ToPhase08GamephaseTransition");
                }
                else if (Phase7ConversationTracker == 300)
                {
                    ChatLeftTwoText.text = "The other type of fibre helps to move the stool through the bowel and we get this mostly in the skin of fruit and edible skin of vegetables and also in the hulls of grain. What is important to remember when we eat more fibre is to also drink more fluids as fibre attracts water in the bowels and this can make the stool harder if there is not enough fluid to help form a nice and soft stool. Does that makes sense?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 301;
                }
                else if (Phase7ConversationTracker == 301)
                {
                    ChatRightText.text = "Oh I see, so I need to eat more fruit and vegetables and whole grains to help with my constipation?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 302;
                }
                else if (Phase7ConversationTracker == 302)
                {
                    ChatLeftText.text = "Yes that’s right and also drink more fluids like water, tea and so on.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 303;
                }
                else if (Phase7ConversationTracker == 303)
                {
                    ChatRightTwoText.text = "Right, I guess my problem is that I just don’t feel hungry that much so that is why I’m not eating enough. I also feel nauseous a lot of the time.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 304;
                }
                else if (Phase7ConversationTracker == 304)
                {
                    string foodRelatedStrategiesList = "";
                    foreach (string stringItem in phase07FoodStrategyStringArray)
                    {
                        foodRelatedStrategiesList = foodRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftTwoText.text = "Yes, so I’ve come up with some strategies for you which will help you with this. They are:" + foodRelatedStrategiesList;
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 305;
                }
                else if (Phase7ConversationTracker == 305)
                {
                    string educationalRelatedStrategiesList = "";
                    foreach (string stringItem in phase07EducationalStrategyStringArray)
                    {
                        educationalRelatedStrategiesList = educationalRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftText.text = "I also have some information for you here to take home on: " + educationalRelatedStrategiesList;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 206;
                }
                else if (Phase7ConversationTracker == 400)
                {
                    ChatLeftTwoText.text = "So we have to make sure we get enough fluids in during the day. Does that makes sense?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 401;
                }
                else if (Phase7ConversationTracker == 401)
                {
                    ChatRightText.text = "Okay, so I need to make sure I drink enough water so my body can work properly?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 402;
                }
                else if (Phase7ConversationTracker == 402)
                {
                    ChatLeftText.text = "Yes that’s right, any fluids like water, tea, milk and so on.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 403;
                }
                else if (Phase7ConversationTracker == 403)
                {
                    ChatRightTwoText.text = "Right, I guess my problem is that I just don’t feel hungry that much so that is why I’m not eating and drinking enough. I also feel nauseous a lot of the time.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 404;
                }
                else if (Phase7ConversationTracker == 404)
                {
                    string foodRelatedStrategiesList = "";
                    foreach (string stringItem in phase07FoodStrategyStringArray)
                    {
                        foodRelatedStrategiesList = foodRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftTwoText.text = "Yes, so I’ve come up with some strategies for you which will help you with this. They are: " + foodRelatedStrategiesList;
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 405;
                }
                else if (Phase7ConversationTracker == 405)
                {
                    string educationalRelatedStrategiesList = "";
                    foreach (string stringItem in phase07EducationalStrategyStringArray)
                    {
                        educationalRelatedStrategiesList = educationalRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftText.text = "I also have some information for you here to take home on:" + educationalRelatedStrategiesList;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 206;
                }
                else if (Phase7ConversationTracker == 406)
                {
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                }
                else if (Phase7ConversationTracker == 500)
                {
                    ChatLeftTwoText.text = "So we want to make sure that your muscle stores at the right level so that it doesn’t also contribute to your ability to do your daily activities. Also we want to make sure you eat enough food so you have more energy during the day. Does that makes sense?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 501;
                }
                else if (Phase7ConversationTracker == 501)
                {
                    ChatRightText.text = "Oh I see, so I need to build up my muscles to give me more strength and eat more so I have more energy?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 502;
                }
                else if (Phase7ConversationTracker == 502)
                {
                    ChatLeftText.text = "Correct. Also, when we don’t eat enough food that contains roughage or fibre your stools can get hard and difficult to pass. We find roughage or fibre in fruit and vegetables and also in wholegrains. There are two types of fibre we get, the one type forms like a gel in our bowels and helps to makes our stools softer and we get this in the flesh of fruit and vegetables and in some grains like oats. The other type helps to move the stool through the bowel and we get this mostly in the skin of fruit and edible skin of vegetables and also in the hulls of grain.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 503;
                }
                else if (Phase7ConversationTracker == 503)
                {
                    ChatLeftTwoText.text = "What is important to remember when we eat more fibre is to also drink more fluids as fibre attracts water in the bowels and this can make the stool harder if there is not enough fluid to help form a nice and soft stool. Okay?";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 504;
                }
                else if (Phase7ConversationTracker == 504)
                {
                    ChatRightText.text = "Oh I see, so I need to eat more fruit and vegetables and whole grains to help with my constipation?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 505;
                }
                else if (Phase7ConversationTracker == 505)
                {
                    ChatLeftText.text = "Yes that’s right and also drink more fluids like water, tea and so on.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 506;
                }
                else if (Phase7ConversationTracker == 506)
                {
                    ChatRightTwoText.text = "Right, I guess my problem is that I just don’t feel hungry that much so that is why I’m not eating and drinking enough. I also feel nauseous a lot of the time.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 507;
                }
                else if (Phase7ConversationTracker == 507)
                {
                    string foodRelatedStrategiesList = "";
                    foreach (string stringItem in phase07FoodStrategyStringArray)
                    {
                        foodRelatedStrategiesList = foodRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftTwoText.text = "Yes, so I’ve come up with some strategies for you which will help you with this. They are: " + foodRelatedStrategiesList;
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 508;
                }
                else if (Phase7ConversationTracker == 508)
                {
                    string educationalRelatedStrategiesList = "";
                    foreach (string stringItem in phase07EducationalStrategyStringArray)
                    {
                        educationalRelatedStrategiesList = educationalRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftText.text = "I also have some information for you here to take home on:" + educationalRelatedStrategiesList;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 509;
                }
                else if (Phase7ConversationTracker == 509)
                {
                    ChatRightText.text = "Thank you, I’ll see how I manage, will I see you again?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 510;
                }
                else if (Phase7ConversationTracker == 510)
                {
                    ChatLeftTwoText.text = "Yes, I would like to see you again in two weeks. Will you be able to come in?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 511;
                }
                else if (Phase7ConversationTracker == 511)
                {
                    ChatRightTwoText.text = "Yes, I should be able to manage that.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 512;
                }
                else if (Phase7ConversationTracker == 512)
                {
                    ChatLeftText.text = "Oh good, thank you Marta, I’ll see you then soon.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 513;
                }
                else if (Phase7ConversationTracker == 513)
                {
                    ChatRightText.text = "Thank you " + playerNameString + ", have a good day.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase7ConversationTracker = 514;
                }
                else if (Phase7ConversationTracker == 514)
                {
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    Phase7ConversationTracker = 1000;
                    inChat = false;
                    phase07ToPhase08TransitionAnim.SetTrigger("AnimateIn");
                    StartCoroutine("Phase07ToPhase08GamephaseTransition");
                }
                else if (Phase7ConversationTracker == 600)
                {
                    ChatLeftTwoText.text = "So we want to make sure that your muscle stores at the right level so that it doesn’t also contribute to your ability to do your daily activities. Also we want to make sure you eat enough food so you have more energy during the day. Does that makes sense?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 601;
                }
                else if (Phase7ConversationTracker == 601)
                {
                    ChatRightText.text = "Oh I see, so I need to build up my muscles to give me more strength and eat more so I have more energy?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 602;
                }
                else if (Phase7ConversationTracker == 602)
                {
                    ChatLeftText.text = "Correct. So I don’t know if you know that more than 70% of our bodies are made up of fluid and for our bodies to work properly we need to make sure that we keep our body’s fluid level up. This is also sometimes referred to as we need to make sure we are well hydrated. If we don’t take enough fluids in everyday our fluid stores become low and our organs like our heart and kidneys, as well as our brain don’t work that well anymore.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 603;
                }
                else if (Phase7ConversationTracker == 603)
                {
                    ChatLeftTwoText.text = "So we have to make sure we get enough fluids in during the day. Are you okay with this?";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 604;
                }
                else if (Phase7ConversationTracker == 604)
                {
                    ChatRightText.text = "Okay, so I need to make sure I drink enough water so my body can work properly?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 605;
                }
                else if (Phase7ConversationTracker == 605)
                {
                    ChatLeftText.text = "Yes that’s right, any fluids like water, tea, milk and so on.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 606;
                }
                else if (Phase7ConversationTracker == 606)
                {
                    ChatRightTwoText.text = "Right, I guess my problem is that I just don’t feel hungry that much so that is why I’m not eating and drinking enough. I also feel nauseous a lot of the time.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 607;
                }
                else if (Phase7ConversationTracker == 607)
                {
                    string foodRelatedStrategiesList = "";
                    foreach (string stringItem in phase07FoodStrategyStringArray)
                    {
                        foodRelatedStrategiesList = foodRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftTwoText.text = "Yes, so I’ve come up with some strategies for you which will help you with this. They are: " + foodRelatedStrategiesList;
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 608;
                }
                else if (Phase7ConversationTracker == 608)
                {
                    string educationalRelatedStrategiesList = "";
                    foreach (string stringItem in phase07EducationalStrategyStringArray)
                    {
                        educationalRelatedStrategiesList = educationalRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftText.text = "I also have some information for you here to take home on:" + educationalRelatedStrategiesList;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 509;
                }
                else if (Phase7ConversationTracker == 700)
                {
                    ChatLeftTwoText.text = "What is important to remember when we eat more fibre is to also drink more fluids as fibre attracts water in the bowels and this can make the stool harder if there is not enough fluid to help form a nice and soft stool. Does that makes sense?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 701;
                }
                else if (Phase7ConversationTracker == 701)
                {
                    ChatRightText.text = "Oh I see, so I need to eat more fruit and vegetables and whole grains to help with my constipation?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 702;
                }
                else if (Phase7ConversationTracker == 702)
                {
                    ChatLeftText.text = "Yes that’s right and also drink more fluids like water, tea and so on.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 703;
                }
                else if (Phase7ConversationTracker == 703)
                {
                    ChatLeftTwoText.text = "So I don’t know if you know that more than 70% of our bodies are made up of fluid and for our bodies to work properly we need to make sure that we keep our body’s fluid level up. This is also sometimes referred to as we need to make sure we are well hydrated. If we don’t take enough fluids in everyday our fluid stores become low and our organs like our heart and kidneys, as well as our brain don’t work that well anymore. So we have to make sure we get enough fluids in during the day.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 704;
                }
                else if (Phase7ConversationTracker == 704)
                {
                    ChatRightText.text = "Okay, so I need to make sure I drink enough water so my body can work properly?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 705;
                }
                else if (Phase7ConversationTracker == 705)
                {
                    ChatLeftText.text = "Yes that’s right, any fluids like water, tea, milk and so on.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 706;
                }
                else if (Phase7ConversationTracker == 706)
                {
                    ChatRightTwoText.text = "Right, I guess my problem is that I just don’t feel hungry that much so that is why I’m not eating and drinking enough. I also feel nauseous a lot of the time.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 707;
                }
                else if (Phase7ConversationTracker == 707)
                {
                    string foodRelatedStrategiesList = "";
                    foreach (string stringItem in phase07FoodStrategyStringArray)
                    {
                        foodRelatedStrategiesList = foodRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftTwoText.text = "Yes, so I’ve come up with some strategies for you which will help you with this. They are: " + foodRelatedStrategiesList;
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 708;
                }
                else if (Phase7ConversationTracker == 708)
                {
                    string educationalRelatedStrategiesList = "";
                    foreach (string stringItem in phase07EducationalStrategyStringArray)
                    {
                        educationalRelatedStrategiesList = educationalRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftText.text = "I also have some information for you here to take home on:" + educationalRelatedStrategiesList;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 509;
                }
                else if (Phase7ConversationTracker == 800)
                {
                    ChatLeftTwoText.text = "So we want to make sure that your muscle stores at the right level so that it doesn’t also contribute to your ability to do your daily activities. Also we want to make sure you eat enough food so you have more energy during the day. Does that makes sense?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 801;
                }
                else if (Phase7ConversationTracker == 801)
                {
                    ChatRightText.text = "Oh I see, so I need to build up my muscles to give me more strength and eat more so I have more energy?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 802;
                }
                else if (Phase7ConversationTracker == 802)
                {
                    ChatLeftText.text = "Correct. Also, when we don’t eat enough food that contains roughage or fibre your stools can get hard and difficult to pass. We find roughage or fibre in fruit and vegetables and also in whole grains. There are two types of fibre we get, the one type forms like a gel in our bowels and helps to make our stools softer and we get this in the flesh of fruit and vegetables and in some grains like oats. The other type helps to move the stool through the bowel and we get this mostly in the skin of fruit and edible skin of vegetables and also in the hulls of grain.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 803;
                }
                else if (Phase7ConversationTracker == 803)
                {
                    ChatLeftTwoText.text = "What is important to remember when we eat more fibre is to also drink more fluids as fibre attracts water in the bowels and this can make the stool harder if there is not enough fluid to help form a nice and soft stool.  Does that makes sense?";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 804;
                }
                else if (Phase7ConversationTracker == 804)
                {
                    ChatRightText.text = "Oh I see, so I need to eat more fruit and vegetables and whole grains to help with my constipation?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 805;
                }
                else if (Phase7ConversationTracker == 805)
                {
                    ChatLeftText.text = "Yes that’s right and also drink more fluids like water, tea and so on.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 806;
                }
                else if (Phase7ConversationTracker == 806)
                {
                    ChatLeftTwoText.text = "So I don’t know if you know that more than 70% of our bodies are made up of fluid and for our bodies to work properly we need to make sure that we keep our body’s fluid level up. This is also sometimes referred to as we need to make sure we are well hydrated. If we don’t take enough fluids in everyday our fluid stores become low and our organs like our heart and kidneys, as well as our brain don’t work that well anymore. So we have to make sure we get enough fluids in during the day.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 807;
                }
                else if (Phase7ConversationTracker == 807)
                {
                    ChatRightText.text = "Okay, so I need to make sure I drink enough water so my body can work properly?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    Phase7ConversationTracker = 808;
                }
                else if (Phase7ConversationTracker == 808)
                {
                    ChatLeftText.text = "Yes that’s right, any fluids like water, tea, milk and so on.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 809;
                }
                else if (Phase7ConversationTracker == 809)
                {
                    ChatRightTwoText.text = "Right, I guess my problem is that I just don’t feel hungry that much so that is why I’m not eating and drinking enough. I also feel nauseas a lot of the time.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 810;
                }
                else if (Phase7ConversationTracker == 810)
                {
                    string foodRelatedStrategiesList = "";
                    foreach (string stringItem in phase07FoodStrategyStringArray)
                    {
                        foodRelatedStrategiesList = foodRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftTwoText.text = "Yes, so I’ve come up with some strategies for you which will help you with this. They are: " + foodRelatedStrategiesList;
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 811;
                }
                else if (Phase7ConversationTracker == 811)
                {
                    string educationalRelatedStrategiesList = "";
                    foreach (string stringItem in phase07EducationalStrategyStringArray)
                    {
                        educationalRelatedStrategiesList = educationalRelatedStrategiesList + "\n" + stringItem;
                    }
                    ChatLeftText.text = "I also have some information for you here to take home on:" + educationalRelatedStrategiesList;
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 812;
                }
                else if (Phase7ConversationTracker == 812)
                {
                    ChatRightText.text = "Thank you, I’ll see how I manage, will I see you again?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 813;
                }
                else if (Phase7ConversationTracker == 813)
                {
                    ChatLeftTwoText.text = "Yes, I would like to see you again in two weeks. Will you be able to come in?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 814;
                }
                else if (Phase7ConversationTracker == 814)
                {
                    ChatRightTwoText.text = "Yes I should be able to manage that.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 815;
                }
                else if (Phase7ConversationTracker == 815)
                {
                    ChatLeftText.text = "Oh good, thank you Marta, I’ll see you then soon.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 816;
                }
                else if (Phase7ConversationTracker == 816)
                {
                    ChatRightText.text = "Thank you " + playerNameString + ", have a good day.";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "END CHAT";
                    Phase7ConversationTracker = 817;
                }
                else if (Phase7ConversationTracker == 817)
                {
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    Phase7ConversationTracker = 1000;
                    inChat = false;
                    phase07ToPhase08TransitionAnim.SetTrigger("AnimateIn");
                    StartCoroutine("Phase07ToPhase08GamephaseTransition");
                }
                else if (Phase7ConversationTracker == 1000)
                {
                    inChat = true;
                    ChatRightText.text = "Hi " + playerNameString + ", was there something else you needed?";
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    Phase7ConversationTracker = 1001;
                }
                else if (Phase7ConversationTracker == 1001)
                {
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 1002;
                    ChatLeftText.text = "Just checking up to make sure that you understood all the information I gave you.";
                }
                else if (Phase7ConversationTracker == 1002)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 1003;
                    ChatRightTwoText.text = "Thank you. Yes I understood it completely and have access to the information. I will see you in two weeks.";
                }
                else if (Phase7ConversationTracker == 1003)
                {
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    Phase7ConversationTracker = 1004;
                    ChatLeftTwoText.text = "Yes you will. I can't wait to see you looking and feeling better, bye for now.";
                }
                else if (Phase7ConversationTracker == 1004)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    Phase7ConversationTracker = 1000;
                    inChat = false;
                }
            }
        }
        else if (PhaseManagement.gamePhase == 8)
        {
            if (currentScene == 0)
            {
                ChatRightNameText.text = patientNameString;
                ChatTextRightHeaderImage.color = patientChatHeaderColour;
                NPCRightChatPortrait.sprite = PatientPortraitImage;
                ChatRightTwoNameText.text = patientNameString;
                ChatTextRightTwoHeaderImage.color = patientChatHeaderColour;
                NPCRightTwoChatPortrait.sprite = PatientPortraitImage;
                if (phase08ConversationTracker == 0)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    inChat = true;
                    ChatLeftText.text = "Hello Marta, lovely to see you again. Thank you for coming in today.";
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    ChatNextButtonText.text = "CONTINUE";
                    phase08ConversationTracker = 1;
                }
                else if (phase08ConversationTracker == 1)
                {
                    ChatRightText.text = "Hello " + playerNameString + ", good to see you too.";
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2;
                }
                else if (phase08ConversationTracker == 2)
                {
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftTwoText.text = "Marta, this is John, you may remember him from when you were in hospital. He is my supervisor and will sit in during this session, are you happy with that?";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3;
                }
                else if (phase08ConversationTracker == 3)
                {
                    ChatRightTwoText.text = "Yes sure. Hello John.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 4;
                }
                else if (phase08ConversationTracker == 4)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "Hello Marta.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 5;
                }
                else if (phase08ConversationTracker == 5)
                {
                    ChatLeftTwoText.text = "So today we will be revisiting the goals and strategies we set for you just before your discharge a couple of weeks ago. Is that alright with you?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 6;
                }
                else if (phase08ConversationTracker == 6)
                {
                    ChatRightText.text = "Yes, that sounds good.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 7;
                }
                else if (phase08ConversationTracker == 7)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftText.text = "Good, so I first would like to ask how you managed to " + Phase07Part03DropZoneArray.First().GetComponent<DropZonePhase07>().goalString01 + ". We decided you were going to " + phase07FoodStrategyStringArray[0] + " and " + phase07FoodStrategyStringArray[1] + ". How did you manage to make these changes?";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone01))
                    {
                        if (Phase07Part03DropZone01.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                        {
                            phase08Selection01FoodStrategy01 = "have cordial";
                            if (Phase07Part03DropZone01.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                            {
                                phase08ConversationTracker = 100;
                            }
                            else if (Phase07Part03DropZone01.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "orange juice, due to my arthritis";
                                phase08ConversationTracker = 200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone01.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "milky tea and coffee, due to my lactose intolerance";
                                phase08ConversationTracker = 200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone01.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                        {
                            phase08Selection01FoodStrategy01 = "add more butter";
                            if (Phase07Part03DropZone01.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                            {
                                phase08ConversationTracker = 100;
                            }
                            else if (Phase07Part03DropZone01.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "orange juice, due to my arthritis";
                                phase07StrategiesScore += 1;
                                phase08ConversationTracker = 200;
                            }
                            else if (Phase07Part03DropZone01.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "milky tea and coffee, due to my lactose intolerance";
                                phase08ConversationTracker = 200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone01.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                        {
                            phase08ConversationTracker = 300;
                            phase07StrategiesScore += 2;
                        }
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone02))
                    {
                        if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                        {
                            phase08Selection01FoodStrategy01 = "yogurt";
                            if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                            {
                                phase08ConversationTracker = 1100;
                            }
                            else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "open the legumes";
                                phase08ConversationTracker = 1200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "buy the bars";
                                phase08ConversationTracker = 1200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                        {
                            phase08Selection01FoodStrategy01 = "ham";
                            if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                            {
                                phase08ConversationTracker = 1100;
                            }
                            else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "open the legumes";
                                phase08ConversationTracker = 1200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "buy the bars";
                                phase08ConversationTracker = 1200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                        {
                            phase08ConversationTracker = 1300;
                            phase07StrategiesScore += 2;
                        }
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone03))
                    {
                        phase08InadequateEnergyAndProteinIntakeAddressed = true;
                        if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                        {
                            phase08Selection01FoodStrategy01 = "milk";
                            if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                            {
                                phase08ConversationTracker = 2100;
                            }
                            else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "have all the delivered meal";
                                phase08ConversationTracker = 2200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "buy the supplements";
                                phase08ConversationTracker = 2200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                        {
                            phase08Selection01FoodStrategy01 = "cheese";
                            if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                            {
                                phase08ConversationTracker = 2100;
                            }
                            else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "have all the delivered meal";
                                phase08ConversationTracker = 2200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "buy the supplements";
                                phase08ConversationTracker = 2200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                        {
                            phase08ConversationTracker = 2300;
                            phase07StrategiesScore += 2;
                        }
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone04))
                    {
                        phase08InsufficientFluidAddressed = true;
                        if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                        {
                            phase08Selection01FoodStrategy01 = "milk";
                            if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                            {
                                phase08ConversationTracker = 3100;
                            }
                            else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "having 8 glasses of water";
                                phase08ConversationTracker = 3200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "replacing my tea with water";
                                phase08ConversationTracker = 3200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                        {
                            phase08Selection01FoodStrategy01 = "cordial";
                            if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                            {
                                phase08ConversationTracker = 3100;
                            }
                            else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "having 8 glasses of water";
                                phase08ConversationTracker = 3200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "replacing my tea with water";
                                phase08ConversationTracker = 3200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                        {
                            phase08ConversationTracker = 3300;
                            phase07StrategiesScore += 2;
                        }
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone05))
                    {
                        if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                        {
                            phase08Selection01FoodStrategy01 = "have crackers and cheese";
                            if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                            {
                                phase08ConversationTracker = 4100;
                            }
                            else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "cold meal";
                                phase08ConversationTracker = 4200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "no butter on my bread";
                                phase08ConversationTracker = 4200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                        {
                            phase08Selection01FoodStrategy01 = "smaller meals and snacks";
                            if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                            {
                                phase08ConversationTracker = 4100;
                            }
                            else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "cold meal";
                                phase08ConversationTracker = 4200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "no butter on my bread";
                                phase08ConversationTracker = 4200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                        {
                            phase08ConversationTracker = 4300;
                            phase07StrategiesScore += 2;
                        }
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                        {
                            phase08Selection01FoodStrategy01 = "have crackers and cheese";
                            if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                            {
                                phase08ConversationTracker = 5100;
                            }
                            else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "cold meal";
                                phase08ConversationTracker = 5200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "no butter on my bread";
                                phase08ConversationTracker = 5200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                        {
                            phase08Selection01FoodStrategy01 = "smaller meals and snacks";
                            if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                            {
                                phase08ConversationTracker = 5100;
                            }
                            else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection01FoodStrategy02 = "cold meal";
                                phase08ConversationTracker = 5200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection01FoodStrategy02 = "no butter on my bread";
                                phase08ConversationTracker = 5200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                        {
                            phase08ConversationTracker = 5300;
                            phase07StrategiesScore += 2;
                        }
                    }
                    //    ^^^^^^^   HAVE A SECTION HERE THAT SETS THE CONVERSATION TRACKER TO THE FIRST GOAL SELECTED THEN THE FOOD STRATEGY = EXAMPLE IF GOAL 1 = AND THEN STRATEGIES SELECTED1 ARE 1 & 2 = 100, 1 AND 3 / 1 AND 4 / 2 AND 3 / 2 AND 4 == 200, 3 AND 4 == 300)
                }
                else if (phase08ConversationTracker == 100)
                {
                    ChatRightTwoText.text = "I was able to take cordial instead of water with my tablets and add more butter to my bread.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 101;
                }
                else if (phase08ConversationTracker == 101)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "Although Marta was able to make these changes you need to check her weight gain to evaluate if this was an appropriate strategy for her.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 102;
                }
                else if (phase08ConversationTracker == 102)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftText.text = "That's great that you have been able to make these changes Marta. Do you know if your weight has increased over the past fortnight?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 103;
                }
                else if (phase08ConversationTracker == 103)
                {
                    ChatRightText.text = "I have not lost any weight but I haven't gained much weight either.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 104;
                }
                else if (phase08ConversationTracker == 104)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that these strategies were only partly successful. Write down your thoughts in the following textbox on why it may not have resulted in weight gain for Marta.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 105;
                }
                else if (phase08ConversationTracker == 105)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 400;
                }
                else if (phase08ConversationTracker == 200)
                {
                    ChatRightTwoText.text = "I was able to " + phase08Selection01FoodStrategy01 + " but did not have " + phase08Selection01FoodStrategy02 + ".";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08Goal01AlreadyDiscussed = true;
                    phase08ConversationTracker = 201;
                }
                else if (phase08ConversationTracker == 201)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It sounds like Marta could not implement all the changes you suggested. You need to check her weight gain and energy levels to evaluate if her nutrition problems are starting to resolve.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 202;
                }
                else if (phase08ConversationTracker == 202)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftText.text = "Marta, it sounds like some of the strategies were not ideal for you. Do you know if your weight has changed much over the last couple of weeks?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 203;
                }
                else if (phase08ConversationTracker == 203)
                {
                    ChatRightText.text = "I actually think that I might have lost a little bit of weight.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 204;
                }
                else if (phase08ConversationTracker == 204)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that the strategies you suggested for Marta was not successful. Write down your thoughts why it may not have resulted in weight gain for Marta using the text box.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 205;
                }
                else if (phase08ConversationTracker == 205)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 400;
                }
                else if (phase08ConversationTracker == 300)
                {
                    ChatRightTwoText.text = "I didn’t drink orange juice as I was too scared that it will upset my arthritis and couldn't manage the milky tea and coffee as I was scared of my lactose intolerance.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 301;
                }
                else if (phase08ConversationTracker == 301)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that you have missed some of Marta’s concerns in your identification of appropriate and individualised strategies for Marta. This inability to follow a client-centred approach has resulted in non-compliance from Marta and potentially a deterioration of her nutritional concerns. Take this opportunity to write down your thoughts on what you would do differently if you had to provide new strategies for Marta and what suggestions you will give to her.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 302;
                }
                else if (phase08ConversationTracker == 302)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 400;
                }
                else if (phase08ConversationTracker == 400)
                {
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    if (dropZonePhase07EducationalStrategy01.phase07EducationalStrategy01Selected == true)
                    {
                        ChatRightText.text = "Yes I was able to make some of the changes you suggested.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy01.educationalStrategyString01 + ". How did you manage this change?";
                        phase08ConversationTracker = 401;
                    }
                    else if (dropZonePhase07EducationalStrategy01.phase07EducationalStrategy02Selected == true)
                    {
                        ChatRightText.text = "Yes I was able to eat my favourite foods.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy01.educationalStrategyString02 + ". How did you manage this change?";
                        phase08ConversationTracker = 410;
                    }
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                }
                else if (phase08ConversationTracker == 401)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                }
                else if (phase08ConversationTracker == 402)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "Although Marta was able to make these changes, you need to evaluate her energy levels and functional ability to evaluate if further education is needed.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 403;
                }
                else if (phase08ConversationTracker == 403)
                {
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftTwoText.text = "That's great that you have been able to make these changes Marta. What has your energy levels been like the past couple of weeks? Have you been able to do your normal daily activities?";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 404;
                }
                else if (phase08ConversationTracker == 404)
                {
                    ChatRightTwoText.text = "It's been alright I guess. It seems a bit better but I still feel my strength is not how it always was.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 405;
                }
                else if (phase08ConversationTracker == 405)
                {
                    ChatLeftText.text = "It seems that this strategy was only partly successful, write down your thoughts why it may not have resulted in restoration of energy and strength levels for Marta using the text box.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 406;
                }
                else if (phase08ConversationTracker == 406)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone02))
                    {
                        phase08ConversationTracker = 1000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone03))
                    {
                        phase08InadequateEnergyAndProteinIntakeAddressed = true;
                        phase08ConversationTracker = 2000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone04))
                    {
                        phase08InsufficientFluidAddressed = true;
                        phase08ConversationTracker = 3000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone05))
                    {
                        phase08ConversationTracker = 4000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        phase08ConversationTracker = 5000;
                    }
                    else
                    {
                        phase08ConversationTracker = 6000;
                    }
                }
                else if (phase08ConversationTracker == 410)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 411;
                }
                else if (phase08ConversationTracker == 411)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "Although Marta followed your advice, there is a risk that her overall energy intake did not improve. You will need to check her energy levels and functional ability.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 412;
                }
                else if (phase08ConversationTracker == 412)
                {
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftTwoText.text = "That's great that you have been able to make these changes Marta. What has your energy levels been like the past couple of weeks? Have you been able to do your normal daily activities?";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 413;
                }
                else if (phase08ConversationTracker == 413)
                {
                    ChatRightTwoText.text = "That's what I can't understand. I've made an effort to eat my favourite foods but I don't seem to have more energy.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 414;
                }
                else if (phase08ConversationTracker == 414)
                {
                    ChatLeftText.text = "It seems that this strategy was not successful, write down your thoughts why it may not have resulted in restoration of energy and strength levels for Marta using the text box.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 415;
                }
                else if (phase08ConversationTracker == 415)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone02))
                    {
                        phase08ConversationTracker = 1000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone03))
                    {
                        phase08InadequateEnergyAndProteinIntakeAddressed = true;
                        phase08ConversationTracker = 2000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone04))
                    {
                        phase08InsufficientFluidAddressed = true;
                        phase08ConversationTracker = 3000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone05))
                    {
                        phase08ConversationTracker = 4000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        phase08ConversationTracker = 5000;
                    }
                    else
                    {
                        phase08ConversationTracker = 6000;
                    }
                }
                else if (phase08ConversationTracker == 1000)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    GameObject phase07Part03SecondResult = Phase07Part03DropZoneArray[2];
                    ChatLeftText.text = "Next, I would like to ask how you managed to " + phase07Part03SecondResult.GetComponent<DropZonePhase07>().goalString01 + ". We decided you were going to " + phase07FoodStrategyStringArray[2] + " and " + phase07FoodStrategyStringArray[3] + ". How did you manage to make these changes?";
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone02))
                    {
                        if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                        {
                            phase08Selection02FoodStrategy01 = "yogurt";
                            if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                            {
                                phase08ConversationTracker = 1100;
                            }
                            else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection02FoodStrategy02 = "open the legumes";
                                phase08ConversationTracker = 1200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection02FoodStrategy02 = "buy the bars";
                                phase08ConversationTracker = 1200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                        {
                            phase08Selection02FoodStrategy01 = "ham";
                            if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                            {
                                phase08ConversationTracker = 1100;
                            }
                            else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection02FoodStrategy02 = "open the legumes";
                                phase08ConversationTracker = 1200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection02FoodStrategy02 = "buy the bars";
                                phase08ConversationTracker = 1200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone02.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                        {
                            phase08ConversationTracker = 1300;
                            phase07StrategiesScore += 2;
                        }
                    }
                }
                else if (phase08ConversationTracker == 1100)
                {
                    ChatRightTwoText.text = "I tried to make these changes, although I sometimes found it hard to have the whole serve.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1101;
                }
                else if (phase08ConversationTracker == 1101)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "To evaluate whether these changes has resulted in an improvement of Marta's nutritional concerns, you need to check her strength and weight gain.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1102;
                }
                else if (phase08ConversationTracker == 1102)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftText.text = "It sounds like you've really made an effort to increase your protein intake Marta which is good. What is your strength levels like and have you gained any weight?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1103;
                }
                else if (phase08ConversationTracker == 1103)
                {
                    ChatRightText.text = "I have not lost any weight but I haven't gained much weight either and my strength levels is not quite what is was in the past.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1104;
                }
                else if (phase08ConversationTracker == 1104)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that your strategies were only partly successful, write down your thoughts why it may not have resulted in restoration of energy and strength levels for Marta using the text box.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1105;
                }
                else if (phase08ConversationTracker == 1105)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 1400;
                }
                else if (phase08ConversationTracker == 1200)
                {
                    if (phase08Goal01AlreadyDiscussed)
                    {
                        ChatRightTwoText.text = "I was able to have some of the " + phase08Selection02FoodStrategy01 + " but couldn't manage to " + phase08Selection02FoodStrategy02 + ".";
                    }
                    else if (!phase08Goal01AlreadyDiscussed)
                    {
                        ChatRightTwoText.text = "I was able to have some of the " + phase08Selection01FoodStrategy01 + " but couldn't manage to " + phase08Selection01FoodStrategy02 + ".";
                    }
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08Goal01AlreadyDiscussed = true;
                    phase08ConversationTracker = 1201;
                }
                else if (phase08ConversationTracker == 1201)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It sounds like Marta could not implement all the changes you suggested. You need to check her weight gain and strength to evaluate if her nutrition problems are starting to resolve.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1202;
                }
                else if (phase08ConversationTracker == 1202)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftText.text = "Marta it sounds like you've been able to implement some changes but that there were also some you struggled with. Do you feel your strength has increased over the past couple of weeks and do you know if you gained any weight?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1203;
                }
                else if (phase08ConversationTracker == 1203)
                {
                    ChatRightText.text = "I don't think I've lost more weight but my strength levels remains low.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1204;
                }
                else if (phase08ConversationTracker == 1204)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that your strategies were only partly successful, write down your thoughts why it may not have resulted in restoration of energy and strength levels for Marta using the text box.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1205;
                }
                else if (phase08ConversationTracker == 1205)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 1400;
                }
                else if (phase08ConversationTracker == 1300)
                {
                    ChatRightTwoText.text = "Well I couldn't open the tin of legumes, my hands just didn't want to work with me and I found the bars was just too expensive for me.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1301;
                }
                else if (phase08ConversationTracker == 1301)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that you have missed some of Marta’s concerns in your identification of appropriate and individualised strategies for Marta. This inability to follow a client-centred approach has resulted in non-compliance from Marta and potentially a deterioration of her nutritional concerns. Take this opportunity to write down your thoughts on what you would do differently if you had to provide new strategies for Marta and what suggestions you will give to her.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1302;
                }
                else if (phase08ConversationTracker == 1302)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 1400;
                }
                else if (phase08ConversationTracker == 1400)
                {
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    if (dropZonePhase07EducationalStrategy02.phase07EducationalStrategy01Selected == true)
                    {
                        ChatRightText.text = "I tried to make these changes but I didn't have the appetite sometimes to have so much food at once.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy02.educationalStrategyString01 + ". How did you manage this change?";
                        phase08ConversationTracker = 1401;
                    }
                    else if (dropZonePhase07EducationalStrategy02.phase07EducationalStrategy02Selected == true)
                    {
                        ChatRightText.text = "Well I tried to have more fruit and vegetables, my girlfriend gave me this great idea to vitaminise them so I've started to have a fruit and vegetable smoothie for morning tea instead of my tea.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy02.educationalStrategyString02 + ". How did you manage this change?";
                        phase08ConversationTracker = 1410;
                    }
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                }
                else if (phase08ConversationTracker == 1401)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1402;
                }
                else if (phase08ConversationTracker == 1402)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "It sounds like Marta did put an effort in to follow your advice but struggled to implement it. How can you tailor this advice so that Marta can achieve this? Take this opportunity to write down how you may adapt your education to help Marta achieve her protein requirement?";
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1403;
                }
                else if (phase08ConversationTracker == 1403)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone03))
                    {
                        phase08InadequateEnergyAndProteinIntakeAddressed = true;
                        phase08ConversationTracker = 2000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone04))
                    {
                        phase08InsufficientFluidAddressed = true;
                        phase08ConversationTracker = 3000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone05))
                    {
                        phase08ConversationTracker = 4000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        phase08ConversationTracker = 5000;
                    }
                    else
                    {
                        phase08ConversationTracker = 6000;
                    }
                }
                else if (phase08ConversationTracker == 1410)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1411;
                }
                else if (phase08ConversationTracker == 1411)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "It sounds like Marta did put an effort in to follow your advice but may not have increased her protein intake in the process. How will you change your advice to Marta to make sure she increases her protein intake? Take this opportunity to write down how you will adapt your education to help Marta meet her protein needs.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 1412;
                }
                else if (phase08ConversationTracker == 1412)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone03))
                    {
                        phase08InadequateEnergyAndProteinIntakeAddressed = true;
                        phase08ConversationTracker = 2000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone04))
                    {
                        phase08InsufficientFluidAddressed = true;
                        phase08ConversationTracker = 3000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone05))
                    {
                        phase08ConversationTracker = 4000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        phase08ConversationTracker = 5000;
                    }
                    else
                    {
                        phase08ConversationTracker = 6000;
                    }
                }
                else if (phase08ConversationTracker == 2000)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    GameObject phase07Part03SecondResult = Phase07Part03DropZoneArray[2];
                    ChatLeftText.text = "Next, I would like to ask how you managed to " + phase07Part03SecondResult.GetComponent<DropZonePhase07>().goalString01 + ". We decided you were going to " + phase07FoodStrategyStringArray[2] + " and " + phase07FoodStrategyStringArray[3] + ". How did you manage to make these changes?";
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone03))
                    {
                        if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                        {
                            phase08Selection02FoodStrategy01 = "milk";
                            if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                            {
                                phase08ConversationTracker = 2100;
                            }
                            else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection02FoodStrategy02 = "have all of the delivered meal";
                                phase08ConversationTracker = 2200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection02FoodStrategy02 = "buy the supplements";
                                phase08ConversationTracker = 2200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                        {
                            phase08Selection02FoodStrategy01 = "cheese";
                            if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                            {
                                phase08ConversationTracker = 2100;
                            }
                            else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection02FoodStrategy02 = "have all of the delivered meal";
                                phase08ConversationTracker = 2200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection02FoodStrategy02 = "buy the supplements";
                                phase08ConversationTracker = 2200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone03.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                        {
                            phase08ConversationTracker = 2300;
                            phase07StrategiesScore += 2;
                        }
                    }
                }
                else if (phase08ConversationTracker == 2100)
                {
                    ChatRightTwoText.text = "Yes I was able to make these changes and found them easy enough to include in my diet. I actually like a warm mug of milk before bed.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2101;
                }
                else if (phase08ConversationTracker == 2101)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "Although Marta was able to make these changes you need to check her weight gain and energy levels to evaluate if this was an appropriate strategy for her.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2102;
                }
                else if (phase08ConversationTracker == 2102)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftText.text = "Marta it sounds like you've really made an effort to follow these strategies. How has your energy levels been the past couple of weeks and do you know if you gained any weight?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2103;
                }
                else if (phase08ConversationTracker == 2103)
                {
                    ChatRightText.text = "Yes my energy levels are much better and I feel I can do more now without getting so tired. I have actually gained some weight too.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2104;
                }
                else if (phase08ConversationTracker == 2104)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "This is a good outcome for Marta, you have been able to help her increase her energy and protein intake by taking her specific needs into consideration. ";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2105;
                }
                else if (phase08ConversationTracker == 2105)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 2400;
                }
                else if (phase08ConversationTracker == 2200)
                {
                    if (phase08Goal01AlreadyDiscussed)
                    {
                        ChatRightTwoText.text = "I was able to have the " + phase08Selection02FoodStrategy01 + " but couldn't manage to " + phase08Selection02FoodStrategy02 + ".";
                    }
                    else if (!phase08Goal01AlreadyDiscussed)
                    {
                        ChatRightTwoText.text = "I was able to have the " + phase08Selection01FoodStrategy01 + " but couldn't manage to " + phase08Selection01FoodStrategy02 + ".";
                    }
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08Goal01AlreadyDiscussed = true;
                    phase08ConversationTracker = 2201;
                }
                else if (phase08ConversationTracker == 2201)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It sounds like Marta could not implement all the changes you suggested. You need to check her weight gain and energy levels to evaluate if her nutrition problems are starting to resolve.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2202;
                }
                else if (phase08ConversationTracker == 2202)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftText.text = "Marta it sounds like you've been able to implement some changes but that there were also some you struggled with. How has your energy levels been the past couple of weeks and do you know if you gained any weight?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2203;
                }
                else if (phase08ConversationTracker == 2203)
                {
                    ChatRightText.text = "My energy levels have improved somewhat but is not back to where it was. I have not lost any more weight luckily.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2204;
                }
                else if (phase08ConversationTracker == 2204)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that this strategy was only partly successful, write down your thoughts why it may not have resulted in restoration of energy levels and weight gain for Marta using the text box.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2205;
                }
                else if (phase08ConversationTracker == 2205)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 2400;
                }
                else if (phase08ConversationTracker == 2300)
                {
                    ChatRightTwoText.text = "Oh I tried to have all of the delivered meal at once but I had to force feed myself as I just didn't feel like eating. I only tried this once and I didn't really get to have the supplements either as it was too expensive for me.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2301;
                }
                else if (phase08ConversationTracker == 2301)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that you have missed some of Marta’s concerns in your identification of appropriate and individualised strategies for Marta. This inability to follow a client-centred approach has resulted in non-compliance from Marta and potentially a deterioration of her nutritional concerns. Take this opportunity to write down your thoughts on what you would do differently if you had to provide new strategies for Marta and what suggestions you will give to her.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2302;
                }
                else if (phase08ConversationTracker == 2302)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 2400;
                }
                else if (phase08ConversationTracker == 2400)
                {
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    if (dropZonePhase07EducationalStrategy03.phase07EducationalStrategy01Selected == true)
                    {
                        ChatRightText.text = "This really worked well for me. I found it easy to have small snacks between my meals. I like having a bit of nuts or cheese and crackers some days.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy03.educationalStrategyString01 + ". How did you manage this change?";
                        phase08ConversationTracker = 2401;
                    }
                    else if (dropZonePhase07EducationalStrategy03.phase07EducationalStrategy02Selected == true)
                    {
                        ChatRightText.text = "I actually struggled to eat more, I tried a few times to have more vegetables at dinner and have more food at breakfast but I couldn't keep this up as my appetite just isn't good.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy03.educationalStrategyString02 + ". How did you manage this change?";
                        phase08ConversationTracker = 2410;
                    }
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                }
                else if (phase08ConversationTracker == 2401)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2402;
                }
                else if (phase08ConversationTracker == 2402)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "It sounds like this was an appropriate strategy for Marta and easy to implement.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2403;
                }
                else if (phase08ConversationTracker == 2403)
                {
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftTwoText.text = "Well done Marta, it is good to hear that you were able to include more snacks in-between your meals. This is a strategy that you can keep up to ensure you get enough calories in everyday.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2404;
                }
                else if (phase08ConversationTracker == 2404)
                {
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone04))
                    {
                        phase08InsufficientFluidAddressed = true;
                        phase08ConversationTracker = 3000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone05))
                    {
                        phase08ConversationTracker = 4000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        phase08ConversationTracker = 5000;
                    }
                    else
                    {
                        phase08ConversationTracker = 6000;
                    }
                }
                else if (phase08ConversationTracker == 2410)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2411;
                }
                else if (phase08ConversationTracker == 2411)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "It seems that this strategy did not help Marta to have more energy and protein in her diet. How will you change your advice to Marta to make sure she increases her protein and energy intake? Take this opportunity to write down how you will adapt your education to help Marta meet her needs.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 2412;
                }
                else if (phase08ConversationTracker == 2412)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone04))
                    {
                        phase08InsufficientFluidAddressed = true;
                        phase08ConversationTracker = 3000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone05))
                    {
                        phase08ConversationTracker = 4000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        phase08ConversationTracker = 5000;
                    }
                    else
                    {
                        phase08ConversationTracker = 6000;
                    }
                }
                else if (phase08ConversationTracker == 3000)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    GameObject phase07Part03SecondResult = Phase07Part03DropZoneArray[2];
                    ChatLeftText.text = "Next, I would like to ask how you managed to " + phase07Part03SecondResult.GetComponent<DropZonePhase07>().goalString01 + ". We decided you were going to " + phase07FoodStrategyStringArray[2] + " and " + phase07FoodStrategyStringArray[3] + ". How did you manage to make these changes?";
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone04))
                    {
                        if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                        {
                            phase08Selection02FoodStrategy01 = "milk";
                            if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                            {
                                phase08ConversationTracker = 3100;
                            }
                            else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection02FoodStrategy02 = "having 8 glasses of water";
                                phase08ConversationTracker = 3200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection02FoodStrategy02 = "replacing my tea with water";
                                phase08ConversationTracker = 3200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                        {
                            phase08Selection02FoodStrategy01 = "cordial";
                            if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                            {
                                phase08ConversationTracker = 3100;
                            }
                            else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection02FoodStrategy02 = "having 8 glasses of water";
                                phase08ConversationTracker = 3200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection02FoodStrategy02 = "replacing my tea with water";
                                phase08ConversationTracker = 3200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone04.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                        {
                            phase08ConversationTracker = 3300;
                            phase07StrategiesScore += 2;
                        }
                    }
                }
                else if (phase08ConversationTracker == 3100)
                {
                    ChatRightTwoText.text = "Yes I have been able to include the milk at bedtime and had cordial between meals some days.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3101;
                }
                else if (phase08ConversationTracker == 3101)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "Sounds like Marta was able to follow your strategies. You also need to check her hydration status.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3102;
                }
                else if (phase08ConversationTracker == 3102)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftText.text = "I'm really glad to hear that you managed these changes Marta. Have you had any of your bloods done lately?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3103;
                }
                else if (phase08ConversationTracker == 3103)
                {
                    ChatRightText.text = "I have yes, my doctor said all my levels are good now.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3104;
                }
                else if (phase08ConversationTracker == 3104)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "This is a good outcome for Marta, you have been able to help her improve her hydration status as it sounds like her electrolyte levels are now normal.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3105;
                }
                else if (phase08ConversationTracker == 3105)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 3400;
                }
                else if (phase08ConversationTracker == 3200)
                {
                    if (phase08Goal01AlreadyDiscussed)
                    {
                        ChatRightTwoText.text = "I was able to have " + phase08Selection02FoodStrategy01 + " but I struggled with " + phase08Selection02FoodStrategy02 + ".";
                    }
                    else if (!phase08Goal01AlreadyDiscussed)
                    {
                        ChatRightTwoText.text = "I was able to have " + phase08Selection01FoodStrategy01 + " but I struggled with " + phase08Selection01FoodStrategy02 + ".";
                    }
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08Goal01AlreadyDiscussed = true;
                    phase08ConversationTracker = 3201;
                }
                else if (phase08ConversationTracker == 3201)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that you have missed some of Marta's preferences or had unrealistic strategies. You will need to check Marta's hydration status.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3202;
                }
                else if (phase08ConversationTracker == 3202)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftText.text = "We'll look at other strategies for you then Marta. Have you had any of your bloods done lately?";
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3203;
                }
                else if (phase08ConversationTracker == 3203)
                {
                    ChatRightText.text = "I have yes, my doctor said my salt is still a bit high and has asked me if I drink enough fluids.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3204;
                }
                else if (phase08ConversationTracker == 3204)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that this strategy was only partly successful, write down your thoughts why it may not have resulted in restoration of her hydration status using the text box.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3205;
                }
                else if (phase08ConversationTracker == 3205)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 3400;
                }
                else if (phase08ConversationTracker == 3300)
                {
                    ChatRightTwoText.text = "I tried to include more water, I just felt really full at meal times with having so much water. I couldn't really replace my tea with water, I love my tea.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3301;
                }
                else if (phase08ConversationTracker == 3301)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that the strategies you gave Marta did not consider her preferences or were unrealistic. Take a moment to write down what you will do differently next time if you have to provide strategies for Marta to improve her hydration status.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3302;
                }
                else if (phase08ConversationTracker == 3302)
                {
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 3400;
                }
                else if (phase08ConversationTracker == 3400)
                {
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    if (dropZonePhase07EducationalStrategy04.phase07EducationalStrategy01Selected == true)
                    {
                        ChatRightText.text = "Yes, I have been more aware of trying to get some fluids in between my meals, I find having them with my meals filled me up and I couldn't really eat all of my food.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy04.educationalStrategyString01 + ". How did you manage this change?";
                        phase08ConversationTracker = 3401;
                    }
                    else if (dropZonePhase07EducationalStrategy04.phase07EducationalStrategy02Selected == true)
                    {
                        ChatRightText.text = "Well this I found challenging. I really like my tea and didn't want to give this up and just have water. I just couldn't have eight cups of water a day.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy04.educationalStrategyString02 + ". How did you manage this change?";
                        phase08ConversationTracker = 3410;
                    }
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                }
                else if (phase08ConversationTracker == 3401)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3402;
                }
                else if (phase08ConversationTracker == 3402)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "It sounds like this education helped Marta and she was able to implement it during times that worked for her.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3403;
                }
                else if (phase08ConversationTracker == 3403)
                {
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    ChatLeftTwoText.text = "Well done Marta, it is good to hear that you were able to have more fluids in-between your meals. This is a strategy that you can keep up to ensure you get fluids in everyday.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3404;
                }
                else if (phase08ConversationTracker == 3404)
                {
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone05))
                    {
                        phase08ConversationTracker = 4000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        phase08ConversationTracker = 5000;
                    }
                    else
                    {
                        phase08ConversationTracker = 6000;
                    }
                }
                else if (phase08ConversationTracker == 3410)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3411;
                }
                else if (phase08ConversationTracker == 3411)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "It seems that this education may have resulted in misinformation to Marta on how to include more fluids in her diet. How will you change your advice to Marta to make sure she meets her fuild needs? Take this opportunity to write down how you will adapt your education to help Marta meet her needs.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 3412;
                }
                else if (phase08ConversationTracker == 3412)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone05))
                    {
                        phase08ConversationTracker = 4000;
                    }
                    else if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        phase08ConversationTracker = 5000;
                    }
                    else
                    {
                        phase08ConversationTracker = 6000;
                    }
                }
                else if (phase08ConversationTracker == 4000)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    print(Phase07Part03DropZoneArray[2].name);
                    GameObject phase07Part03SecondResult = Phase07Part03DropZoneArray[2];
                    ChatLeftText.text = "Next, I would like to ask how you managed to " + phase07Part03SecondResult.GetComponent<DropZonePhase07>().goalString01 + ". We decided you were going to " + phase07FoodStrategyStringArray[2] + " and " + phase07FoodStrategyStringArray[3] + ". How did you manage to make these changes?";
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone05))
                    {
                        if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                        {
                            phase08Selection02FoodStrategy01 = "have crackers and cheese";
                            if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                            {
                                phase08ConversationTracker = 4100;
                            }
                            else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection02FoodStrategy02 = "cold meal";
                                phase08ConversationTracker = 4200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection02FoodStrategy02 = "no butter on my bread";
                                phase08ConversationTracker = 4200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                        {
                            phase08Selection02FoodStrategy01 = "smaller meals and snacks";
                            if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                            {
                                phase08ConversationTracker = 4100;
                            }
                            else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection02FoodStrategy02 = "cold meal";
                                phase08ConversationTracker = 4200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection02FoodStrategy02 = "no butter on my bread";
                                phase08ConversationTracker = 4200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone05.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                        {
                            phase08ConversationTracker = 4300;
                            phase07StrategiesScore += 2;
                        }
                    }
                }
                else if (phase08ConversationTracker == 4100)
                {
                    ChatRightTwoText.text = "Yes I found this really helpful, especially on the days that I felt a bit sick in the stomach. I would then have cheese and crackers for morning tea and a smaller lunch.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 4101;
                }
                else if (phase08ConversationTracker == 4101)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "Although these strategies were easy for Marta to implement, the goal was not a top priority to address in the first instance and can be incorporated as a strategy for a more pertinent goal. Think of how you could address Marta's nutrition impact symptoms as part of a goal that has a higher priority in the short-term. Use the textbox to write down your thoughts.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 4102;
                }
                else if (phase08ConversationTracker == 4102)
                {
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                }
                else if (phase08ConversationTracker == 4200)
                {
                    if (phase08Goal01AlreadyDiscussed)
                    {
                        ChatRightTwoText.text = "I was able to have " + phase08Selection02FoodStrategy01 + " but I struggled with " + phase08Selection02FoodStrategy02 + ".";
                    }
                    else if (!phase08Goal01AlreadyDiscussed)
                    {
                        ChatRightTwoText.text = "I was able to have " + phase08Selection01FoodStrategy01 + " but I struggled with " + phase08Selection01FoodStrategy02 + ".";
                    }
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08Goal01AlreadyDiscussed = true;
                    phase08ConversationTracker = 4201;
                }
                else if (phase08ConversationTracker == 4201)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that you have missed some of Marta's preferences or had unrealistic strategies. Additionally, this goal was not a top priority to address in the first instance and can be incorportated as a strategy for a more pertinent goal. Think of how you could address Marta's nutrition impact symptoms as part of a goal that has a higher priority in the short-term. Use the textbox to write down your thoughts.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 4202;
                }
                else if (phase08ConversationTracker == 4202)
                {
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                }
                else if (phase08ConversationTracker == 4300)
                {
                    ChatRightTwoText.text = "Oh I didn't really like the cold meal at lunch and I find the bread too dry without my butter. So I only tried this once, it didn't really seem to be of much help either.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 4301;
                }
                else if (phase08ConversationTracker == 4301)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It seems that you have missed some of Marta’s concerns in your identification of appropriate and individualised strategies for Marta which has resulted in non-compliance. Additionally, this goal was not a top priority to address in the first instance.  Think of how you could address Marta's nutrition impact symptoms as part of a goal that has a higher priority in the short-term. Use the textbox to write down your thoughts.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 4302;
                }
                else if (phase08ConversationTracker == 4302)
                {
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 4400;
                }
                else if (phase08ConversationTracker == 4400)
                {
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    if (dropZonePhase07EducationalStrategy05.phase07EducationalStrategy01Selected == true)
                    {
                        ChatRightText.text = "I found this advice really helped me to cope better with my nausea.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy04.educationalStrategyString01 + ". How did you manage this change?";
                        phase08ConversationTracker = 4401;
                    }
                    else if (dropZonePhase07EducationalStrategy05.phase07EducationalStrategy02Selected == true)
                    {
                        ChatRightText.text = "I don't think this really affected my nausea and I do like my coffee with my breakfast and tea with my lunch.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy04.educationalStrategyString02 + ". How did you manage this change?";
                        phase08ConversationTracker = 4410;
                    }
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                }
                else if (phase08ConversationTracker == 4401)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 4402;
                }
                else if (phase08ConversationTracker == 4402)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "Although this was helpful advice for Marta, the goal was not a top priority in the short-term. Consider how this education can be adapted to ensure Marta still meets her needs.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 4403;
                }
                else if (phase08ConversationTracker == 4403)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        phase08ConversationTracker = 5000;
                    }
                    else
                    {
                        phase08ConversationTracker = 6000;
                    }
                }
                else if (phase08ConversationTracker == 4410)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 4411;
                }
                else if (phase08ConversationTracker == 4411)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "This education was not appropriate for Marta and the goal was not a top priority to address in the short-term. Consider how this education can be adapted to ensure Marta still meets her needs.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 4412;
                }
                else if (phase08ConversationTracker == 4412)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        phase08ConversationTracker = 5000;
                    }
                    else
                    {
                        phase08ConversationTracker = 6000;
                    }
                }
                else if (phase08ConversationTracker == 5000)
                {
                    ChatLeftNameText.text = playerNameString;
                    ChatTextLeftHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
                    GameObject phase07Part03SecondResult = Phase07Part03DropZoneArray[2];
                    ChatLeftText.text = "Next, I would like to ask how you managed to " + phase07Part03SecondResult.GetComponent<DropZonePhase07>().goalString01 + ". We decided you were going to " + phase07FoodStrategyStringArray[2] + " and " + phase07FoodStrategyStringArray[3] + ". How did you manage to make these changes?";
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    if (Phase07Part03DropZoneArray.Contains(Phase07Part03DropZone06))
                    {
                        if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                        {
                            phase08Selection02FoodStrategy01 = "nothing";
                            if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                            {
                                phase08ConversationTracker = 5100;
                            }
                            else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection02FoodStrategy02 = "can't open the tinned fish";
                                phase08ConversationTracker = 5200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection02FoodStrategy02 = "don't know what to replace the delivered meal with in the week";
                                phase08ConversationTracker = 5200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy02Selected)
                        {
                            phase08Selection02FoodStrategy01 = "nuffin";
                            if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy01Selected)
                            {
                                phase08ConversationTracker = 5100;
                            }
                            else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                            {
                                phase08Selection02FoodStrategy02 = "can't open the tinned fish";
                                phase08ConversationTracker = 5200;
                                phase07StrategiesScore += 1;
                            }
                            else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy04Selected)
                            {
                                phase08Selection02FoodStrategy02 = "don't know what to replace the delivered meal with in the week";
                                phase08ConversationTracker = 5200;
                                phase07StrategiesScore += 1;
                            }
                        }
                        else if (Phase07Part03DropZone06.GetComponent<DropZonePhase07>().phase07FoodStrategy03Selected)
                        {
                            phase08ConversationTracker = 5300;
                            phase07StrategiesScore += 2;
                        }
                    }
                }
                else if (phase08ConversationTracker == 5100)
                {
                    ChatRightTwoText.text = "Oh I am actually happy with the meals I have on the weekends, I cope well with them and can't afford too many ready-made frozen meals.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 5101;
                }
                else if (phase08ConversationTracker == 5101)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It sounds like the strategies for Marta was not appropriate which resulted in non-compliance. This goal was also not a top priority to address in the short-term. Careful consideration of her needs and her current meals will help you assess the importance of this goal and these strategies.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 5102;
                }
                else if (phase08ConversationTracker == 5102)
                {
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                }
                else if (phase08ConversationTracker == 5200)
                {
                    if (phase08Goal01AlreadyDiscussed)
                    {
                        ChatRightTwoText.text = "I found this a bit challenging as I feel I cope well with my weekend meals as it currently is and " + phase08Selection02FoodStrategy02 + ".";
                    }
                    else if (!phase08Goal01AlreadyDiscussed)
                    {
                        ChatRightTwoText.text = "I found this a bit challenging as I feel I cope well with my weekend meals as it currently is and " + phase08Selection01FoodStrategy02 + ".";
                    }
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08Goal01AlreadyDiscussed = true;
                    phase08ConversationTracker = 5201;
                }
                else if (phase08ConversationTracker == 5201)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It sounds like the strategies for Marta was not appropriate which resulted in non-compliance. This goal was also not a top priority to address in the short-term. Careful consideration of her needs and her current meals will help you assess the importance of this goal and these strategies.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 5202;
                }
                else if (phase08ConversationTracker == 5202)
                {
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                }
                else if (phase08ConversationTracker == 5300)
                {
                    ChatRightTwoText.text = "I couldn't make these changes as I can't open the tinned fish and don't know what to replace my weekday meal with.";
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightTwoAnim.SetBool("ChatDefault", false);
                    ChatRightTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 5301;
                }
                else if (phase08ConversationTracker == 5301)
                {
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftTwoText.text = "It sounds like the strategies for Marta was not appropriate which resulted in non-compliance. This goal was also not a top priority to address in the short-term. Careful consideration of her needs and her current meals will help you assess the importance of this goal and these strategies.";
                    ChatLeftAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 5302;
                }
                else if (phase08ConversationTracker == 5302)
                {
                    ChatRightTwoAnim.SetBool("ChatActivated", false);
                    ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 5400;
                }
                else if (phase08ConversationTracker == 5400)
                {
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftTwoNameText.text = playerNameString;
                    ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
                    if (dropZonePhase07EducationalStrategy05.phase07EducationalStrategy01Selected == true)
                    {
                        ChatRightText.text = "Yes I have continued with receiving my meals, it is a real help for me.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy04.educationalStrategyString01 + ". How did you manage this change?";
                        phase08ConversationTracker = 5401;
                    }
                    else if (dropZonePhase07EducationalStrategy05.phase07EducationalStrategy02Selected == true)
                    {
                        ChatRightText.text = "Oh I just don't have the energy at this point in time t prepare meals in bulk so I couldn'y get to this.";
                        ChatLeftTwoText.text = "Okay Marta, so the next strategy we spoke about was to " + dropZonePhase07EducationalStrategy04.educationalStrategyString02 + ". How did you manage this change?";
                        phase08ConversationTracker = 5410;
                    }
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                }
                else if (phase08ConversationTracker == 5401)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    phase08ConversationTracker = 5402;
                }
                else if (phase08ConversationTracker == 5402)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "Marta already had home delivered meals in place. Although it is good to confirm as an alternative, another education strategy which will add to her current knowledge and skills to improve her nutrition status would be more appropriate. This goal was also not a top priority to address in the short-term as Marta is coping well with her current food.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 5403;
                }
                else if (phase08ConversationTracker == 5403)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 6000;
                }
                else if (phase08ConversationTracker == 5410)
                {
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatRightAnim.SetBool("ChatDefault", false);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    phase08ConversationTracker = 5411;
                }
                else if (phase08ConversationTracker == 5411)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = "This education was not appropriate for Marta and the goal was not a top priority to address in the short-term. Consider how this education can be adapted to ensure Marta still meets her needs.";
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatRightAnim.SetBool("ChatActivated", false);
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 5412;
                }
                else if (phase08ConversationTracker == 5412)
                {
                    ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatRightAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    phase08ThoughtsInputBoxGroup.GetComponentInChildren<Text>().text = "";
                    phase08ThoughtsInputBoxGroup.SetActive(true);
                    phase08ConversationTracker = 6000;
                }
                else if (phase08ConversationTracker == 6000)
                {
                    phase08ThoughtsInputBoxGroup.SetActive(false);
                    ChatLeftTwoNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatTwoPortraitImage.sprite = DieticianPortraitImage;
                    if (!phase08InsufficientFluidAddressed)
                    {
                        ChatLeftTwoText.text = "You missed that Marta was dehydrated in hospital. This was an important nutrition concern to address and will result in a more favourable outcome for Marta.";
                        if (!phase08InadequateEnergyAndProteinIntakeAddressed)
                        {
                            ChatLeftTwoText.text = ChatLeftTwoText.text + " Marta is moderately malnourished and not meeting her energy and protein needs. She needs to increase her energy and protein intake using energy and nutrient rich meals and snacks. She also complains of appetite loss, so prescribing food that is not big in volume but rich in energy and nutrients will be important to consider.";
                        }
                    }
                    else if (phase08InsufficientFluidAddressed && !phase08InadequateEnergyAndProteinIntakeAddressed)
                    {
                        ChatLeftTwoText.text = "Marta is moderately malnourished and not meeting her energy and protein needs. She needs to increase her energy and protein intake using energy and nutrient rich meals and snacks. She also complains of appetite loss, so prescribing food that is not big in volume but rich in energy and nutrients will be important to consider.";
                    }
                    else if (phase08InsufficientFluidAddressed && phase08InadequateEnergyAndProteinIntakeAddressed)
                    {
                        ChatLeftTwoText.text = "Okay, let's continue.";
                    }
                    ChatLeftTwoAnim.SetBool("ChatDefault", false);
                    ChatLeftTwoAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 6001;
                }
                else if (phase08ConversationTracker == 6001)
                {
                    ChatLeftNameText.text = dieteticSupervisorNameString;
                    ChatTextLeftHeaderImage.color = dietiticSupervisorChatHeaderColour;
                    NPCLeftChatPortraitImage.sprite = DieticianPortraitImage;
                    ChatLeftText.text = playerNameString + ", you have now provided nutrition care for Marta and experienced her progress at two week follow-up. Her progress to date links to your ability to identify key nutritional concerns to address in the short therm. Let’s look at your overall performance through each step in the nutrition care process.";
                    ChatLeftTwoAnim.SetBool("ChatActivated", false);
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                    ChatLeftAnim.SetBool("ChatDefault", false);
                    ChatLeftAnim.SetBool("ChatActivated", true);
                    phase08ConversationTracker = 6002;
                    ChatNextButtonText.text = "END CHAT";
                }
                else if (phase08ConversationTracker == 6002)
                {
                    ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", false);
                    ChatLeftTwoAnim.SetBool("ChatDefault", true);
                    ChatLeftAnim.SetBool("ChatActivated", false);
                    ChatLeftAnim.SetBool("ChatDefault", true);
                    inChat = false;
                    Phase08EndResultsMessageToggle();
                    StartCoroutine("Phase08DelayAnimation");
                }
            }
        }
    }

    void SetDateOnProgressNotes()
    {
        System.DateTime PreviousTime2daysAgo = time.AddDays(-2);
        ProgressNotesDate01Text.text = PreviousTime2daysAgo.ToString("MMM dd") + ", 1:30pm";
        ProgressNotesDate02Text.text = PreviousTime2daysAgo.ToString("MMM dd") + ", 3:10pm";
        ProgressNotesDate03Text.text = PreviousTime2daysAgo.ToString("MMM dd") + ", 3:30pm";
        ProgressNotesDate04Text.text = PreviousTime2daysAgo.ToString("MMM dd") + ", 6:10pm";
        ProgressNotesDate05Text.text = PreviousTime2daysAgo.ToString("MMM dd") + ", 9:15pm";
        ObservationDate01Text.text = PreviousTime2daysAgo.ToString("dd MMMMMMMMMMMM");
        ObservationDate02Text.text = PreviousTime2daysAgo.ToString("dd MMMMMMMMMMMM");
        ObservationDate03Text.text = PreviousTime2daysAgo.ToString("dd MMMMMMMMMMMM");
        System.DateTime PreviousTime1dayAgo = time.AddDays(-1);
        ProgressNotesDate06Text.text = PreviousTime1dayAgo.ToString("MMM dd") + ", 6:00am";
        ProgressNotesDate07Text.text = PreviousTime1dayAgo.ToString("MMM dd") + ", 9:15am";
        ProgressNotesDate08Text.text = PreviousTime1dayAgo.ToString("MMM dd") + ", 10:30am";
        ProgressNotesDate09Text.text = PreviousTime1dayAgo.ToString("MMM dd") + ", 12:30pm";
        ProgressNotesDate10Text.text = PreviousTime1dayAgo.ToString("MMM dd") + ", 3:00pm";
    }

    public void BicepScrollSnapToggle()
    {
        if (BicepScrollSnapAnim.GetBool("ScrollSnapDefault"))
        {
            BicepScrollSnapAnim.SetBool("ScrollSnapDefault", false);
            BicepScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
        else if (BicepScrollSnapAnim.GetBool("ScrollSnapAnimateIn"))
        {
            BicepScrollSnapAnim.SetBool("ScrollSnapAnimateIn", false);
            BicepScrollSnapAnim.SetBool("ScrollSnapAnimateOut", true);
        }
        else if (BicepScrollSnapAnim.GetBool("ScrollSnapAnimateOut"))
        {
            BicepScrollSnapAnim.SetBool("ScrollSnapAnimateOut", false);
            BicepScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
    }

    public void CalfScrollSnapToggle()
    {
        if (CalfScrollSnapAnim.GetBool("ScrollSnapDefault"))
        {
            CalfScrollSnapAnim.SetBool("ScrollSnapDefault", false);
            CalfScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
        else if (CalfScrollSnapAnim.GetBool("ScrollSnapAnimateIn"))
        {
            CalfScrollSnapAnim.SetBool("ScrollSnapAnimateIn", false);
            CalfScrollSnapAnim.SetBool("ScrollSnapAnimateOut", true);
        }
        else if (CalfScrollSnapAnim.GetBool("ScrollSnapAnimateOut"))
        {
            CalfScrollSnapAnim.SetBool("ScrollSnapAnimateOut", false);
            CalfScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
    }

    public void ClavicleScrollSnapToggle()
    {
        if (ClavicleScrollSnapAnim.GetBool("ScrollSnapDefault"))
        {
            ClavicleScrollSnapAnim.SetBool("ScrollSnapDefault", false);
            ClavicleScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
        else if (ClavicleScrollSnapAnim.GetBool("ScrollSnapAnimateIn"))
        {
            ClavicleScrollSnapAnim.SetBool("ScrollSnapAnimateIn", false);
            ClavicleScrollSnapAnim.SetBool("ScrollSnapAnimateOut", true);
        }
        else if (ClavicleScrollSnapAnim.GetBool("ScrollSnapAnimateOut"))
        {
            ClavicleScrollSnapAnim.SetBool("ScrollSnapAnimateOut", false);
            ClavicleScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
    }

    public void EyeScrollSnapToggle()
    {
        if (EyeScrollSnapAnim.GetBool("ScrollSnapDefault"))
        {
            EyeScrollSnapAnim.SetBool("ScrollSnapDefault", false);
            EyeScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
        else if (EyeScrollSnapAnim.GetBool("ScrollSnapAnimateIn"))
        {
            EyeScrollSnapAnim.SetBool("ScrollSnapAnimateIn", false);
            EyeScrollSnapAnim.SetBool("ScrollSnapAnimateOut", true);
        }
        else if (EyeScrollSnapAnim.GetBool("ScrollSnapAnimateOut"))
        {
            EyeScrollSnapAnim.SetBool("ScrollSnapAnimateOut", false);
            EyeScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
    }

    public void HandScrollSnapToggle()
    {
        if (HandScrollSnapAnim.GetBool("ScrollSnapDefault"))
        {
            HandScrollSnapAnim.SetBool("ScrollSnapDefault", false);
            HandScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
        else if (HandScrollSnapAnim.GetBool("ScrollSnapAnimateIn"))
        {
            HandScrollSnapAnim.SetBool("ScrollSnapAnimateIn", false);
            HandScrollSnapAnim.SetBool("ScrollSnapAnimateOut", true);
        }
        else if (HandScrollSnapAnim.GetBool("ScrollSnapAnimateOut"))
        {
            HandScrollSnapAnim.SetBool("ScrollSnapAnimateOut", false);
            HandScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
    }

    public void KneeScrollSnapToggle()
    {
        if (KneeScrollSnapAnim.GetBool("ScrollSnapDefault"))
        {
            KneeScrollSnapAnim.SetBool("ScrollSnapDefault", false);
            KneeScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
        else if (KneeScrollSnapAnim.GetBool("ScrollSnapAnimateIn"))
        {
            KneeScrollSnapAnim.SetBool("ScrollSnapAnimateIn", false);
            KneeScrollSnapAnim.SetBool("ScrollSnapAnimateOut", true);
        }
        else if (KneeScrollSnapAnim.GetBool("ScrollSnapAnimateOut"))
        {
            KneeScrollSnapAnim.SetBool("ScrollSnapAnimateOut", false);
            KneeScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
    }

    public void ShoulderScrollSnapToggle()
    {
        if (ShoulderScrollSnapAnim.GetBool("ScrollSnapDefault"))
        {
            ShoulderScrollSnapAnim.SetBool("ScrollSnapDefault", false);
            ShoulderScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
        else if (ShoulderScrollSnapAnim.GetBool("ScrollSnapAnimateIn"))
        {
            ShoulderScrollSnapAnim.SetBool("ScrollSnapAnimateIn", false);
            ShoulderScrollSnapAnim.SetBool("ScrollSnapAnimateOut", true);
        }
        else if (ShoulderScrollSnapAnim.GetBool("ScrollSnapAnimateOut"))
        {
            ShoulderScrollSnapAnim.SetBool("ScrollSnapAnimateOut", false);
            ShoulderScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
    }

    public void TempleScrollSnapToggle()
    {
        if (TempleScrollSnapAnim.GetBool("ScrollSnapDefault"))
        {
            TempleScrollSnapAnim.SetBool("ScrollSnapDefault", false);
            TempleScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
        else if (TempleScrollSnapAnim.GetBool("ScrollSnapAnimateIn"))
        {
            TempleScrollSnapAnim.SetBool("ScrollSnapAnimateIn", false);
            TempleScrollSnapAnim.SetBool("ScrollSnapAnimateOut", true);
        }
        else if (TempleScrollSnapAnim.GetBool("ScrollSnapAnimateOut"))
        {
            TempleScrollSnapAnim.SetBool("ScrollSnapAnimateOut", false);
            TempleScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
    }

    public void TricepScrollSnapToggle()
    {
        if (TricepScrollSnapAnim.GetBool("ScrollSnapDefault"))
        {
            TricepScrollSnapAnim.SetBool("ScrollSnapDefault", false);
            TricepScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
        else if (TricepScrollSnapAnim.GetBool("ScrollSnapAnimateIn"))
        {
            TricepScrollSnapAnim.SetBool("ScrollSnapAnimateIn", false);
            TricepScrollSnapAnim.SetBool("ScrollSnapAnimateOut", true);
        }
        else if (TricepScrollSnapAnim.GetBool("ScrollSnapAnimateOut"))
        {
            TricepScrollSnapAnim.SetBool("ScrollSnapAnimateOut", false);
            TricepScrollSnapAnim.SetBool("ScrollSnapAnimateIn", true);
        }
    }

    public void HelpToggle()
    {
        if (helpToggleAnim.GetBool("MenuDefault") == true)
        {
            helpToggleAnim.SetBool("MenuDefault", false);
            helpToggleAnim.SetBool("MenuActivated", true);
        }
        else if (helpToggleAnim.GetBool("MenuActivated") == false)
        {
            helpToggleAnim.SetBool("MenuActivated", true);
        }
        else if (helpToggleAnim.GetBool("MenuActivated") == true)
        {
            helpToggleAnim.SetBool("MenuActivated", false);
        }
    }

    public void HintToggle()
    {
        if (hintToggleAnim.GetBool("MenuDefault") == true)
        {
            hintToggleAnim.SetBool("MenuDefault", false);
            hintToggleAnim.SetBool("MenuActivated", true);
        }
        else if (hintToggleAnim.GetBool("MenuActivated") == false)
        {
            hintToggleAnim.SetBool("MenuActivated", true);
        }
        else if (hintToggleAnim.GetBool("MenuActivated") == true)
        {
            hintToggleAnim.SetBool("MenuActivated", false);
        }
    }

    public void logOutToggle()
    {
        if (logoutToggleAnim.GetBool("MenuDefault") == true)
        {
            logoutToggleAnim.SetBool("MenuDefault", false);
            logoutToggleAnim.SetBool("MenuActivated", true);
        }
        else if (logoutToggleAnim.GetBool("MenuActivated") == false)
        {
            logoutToggleAnim.SetBool("MenuActivated", true);
        }
        else if (logoutToggleAnim.GetBool("MenuActivated") == true)
        {
            logoutToggleAnim.SetBool("MenuActivated", false);
        }
    }

    public void AlertMessageToggle()
    {
        if (alertMessageToggleAnim.GetBool("MenuDefault") == true)
        {
            alertMessageToggleAnim.SetBool("MenuDefault", false);
            alertMessageToggleAnim.SetBool("MenuActivated", true);
        }
        else if (alertMessageToggleAnim.GetBool("MenuActivated") == false)
        {
            alertMessageToggleAnim.SetBool("MenuActivated", true);
        }
        else if (alertMessageToggleAnim.GetBool("MenuActivated") == true)
        {
            alertMessageToggleAnim.SetBool("MenuActivated", false);
        }
    }

    public void CanExamineNotificationToggle()
    {
        if (CanExamineMessageToggleAnim.GetBool("MenuDefault") == true)
        {
            CanExamineMessageToggleAnim.SetBool("MenuDefault", false);
            CanExamineMessageToggleAnim.SetBool("MenuActivated", true);
        }
        else if (CanExamineMessageToggleAnim.GetBool("MenuActivated") == false)
        {
            CanExamineMessageToggleAnim.SetBool("MenuActivated", true);
        }
        else if (CanExamineMessageToggleAnim.GetBool("MenuActivated") == true)
        {
            CanExamineMessageToggleAnim.SetBool("MenuActivated", false);
        }
    }

    public void Phase06Part04AlertMessageToggle()
    {
        if (Phase06Part04ConfirmationAlertAnim.GetBool("MenuDefault") == true)
        {
            Phase06Part04ConfirmationAlertAnim.SetBool("MenuDefault", false);
            Phase06Part04ConfirmationAlertAnim.SetBool("MenuActivated", true);
        }
        else if (Phase06Part04ConfirmationAlertAnim.GetBool("MenuActivated") == false)
        {
            Phase06Part04ConfirmationAlertAnim.SetBool("MenuActivated", true);
        }
        else if (Phase06Part04ConfirmationAlertAnim.GetBool("MenuActivated") == true)
        {
            Phase06Part04ConfirmationAlertAnim.SetBool("MenuActivated", false);
        }
    }

    public void Phase07Part04AlertMessageToggle()
    {
        if (Phase07Part04ConfirmationAlertAnim.GetBool("MenuDefault") == true)
        {
            Phase07Part04ConfirmationAlertAnim.SetBool("MenuDefault", false);
            Phase07Part04ConfirmationAlertAnim.SetBool("MenuActivated", true);
        }
        else if (Phase07Part04ConfirmationAlertAnim.GetBool("MenuActivated") == false)
        {
            Phase07Part04ConfirmationAlertAnim.SetBool("MenuActivated", true);
        }
        else if (Phase07Part04ConfirmationAlertAnim.GetBool("MenuActivated") == true)
        {
            Phase07Part04ConfirmationAlertAnim.SetBool("MenuActivated", false);
        }
    }

    public void Phase07CompleteCheck()
    {
        Phase07Part04Complete = true;
        phase07PartThreePopup.SetTrigger("AnimateOut");
        Phase07Part05CompletedAnim.SetTrigger("AnimateIn");
    }

    public void phase06CompleteCheck()
    {
        if (phase6Part04Complete)
        {
            PhaseManagement.gamePhase = 7;
            nextPhaseSource.Play();
            PhaseReachedAnim.SetTrigger("PhaseReached");
            PhaseReachedText.text = "REACHED PHASE 7";
            currentPhaseText.text = "7th";
            currentPhaseProgressFillImage.fillAmount = 0;
            totalProgressFillImage.fillAmount = 0.75f;
            totalProgressAmountText.text = "75%";
            Phase6ProgressGroup.SetActive(false);
            TranscribeInterventionPlanTabButton.SetActive(true);
        }
    }

    public void BMICalculatorAlertMessageToggle()
    {
        if (BMICalculatorAlertMessageGroupAnim.GetBool("MenuDefault") == true)
        {
            BMICalculatorAlertMessageGroupAnim.SetBool("MenuDefault", false);
            BMICalculatorAlertMessageGroupAnim.SetBool("MenuActivated", true);
        }
        else if (BMICalculatorAlertMessageGroupAnim.GetBool("MenuActivated") == false)
        {
            BMICalculatorAlertMessageGroupAnim.SetBool("MenuActivated", true);
        }
        else if (BMICalculatorAlertMessageGroupAnim.GetBool("MenuActivated") == true)
        {
            BMICalculatorAlertMessageGroupAnim.SetBool("MenuActivated", false);
        }
    }

    public void Phase06Part01AlertMessageToggle()
    {
        if (Phase6PartOneAlertMessageGroupAnim.GetBool("MenuDefault") == true)
        {
            Phase6PartOneAlertMessageGroupAnim.SetBool("MenuDefault", false);
            Phase6PartOneAlertMessageGroupAnim.SetBool("MenuActivated", true);
        }
        else if (Phase6PartOneAlertMessageGroupAnim.GetBool("MenuActivated") == false)
        {
            Phase6PartOneAlertMessageGroupAnim.SetBool("MenuActivated", true);
        }
        else if (Phase6PartOneAlertMessageGroupAnim.GetBool("MenuActivated") == true)
        {
            Phase6PartOneAlertMessageGroupAnim.SetBool("MenuActivated", false);
        }
    }

    public void Phase08EndResultsMessageToggle()
    {
        if (phase08EndResultsMessageAnim.GetBool("MenuDefault") == true)
        {
            phase08EndResultsMessageAnim.SetBool("MenuDefault", false);
            phase08EndResultsMessageAnim.SetBool("MenuActivated", true);
        }
        else if (phase08EndResultsMessageAnim.GetBool("MenuActivated") == false)
        {
            phase08EndResultsMessageAnim.SetBool("MenuActivated", true);
        }
        else if (phase08EndResultsMessageAnim.GetBool("MenuActivated") == true)
        {
            phase08EndResultsMessageAnim.SetBool("MenuActivated", false);
        }
    }

    public void Phase5WeightEvaluationAlertMessageToggle()
    {
        if (Phase5BodyWeightAlertMessageGroup.GetBool("MenuDefault") == true)
        {
            Phase5BodyWeightAlertMessageGroup.SetBool("MenuDefault", false);
            Phase5BodyWeightAlertMessageGroup.SetBool("MenuActivated", true);
        }
        else if (Phase5BodyWeightAlertMessageGroup.GetBool("MenuActivated") == false)
        {
            Phase5BodyWeightAlertMessageGroup.SetBool("MenuActivated", true);
        }
        else if (Phase5BodyWeightAlertMessageGroup.GetBool("MenuActivated") == true)
        {
            Phase5BodyWeightAlertMessageGroup.SetBool("MenuActivated", false);
        }
    }

    public void ReceivedItemToggle()
    {
        if (receivedItemMessageToggleAnim.GetBool("MenuDefault") == true)
        {
            receivedItemMessageToggleAnim.SetBool("MenuDefault", false);
            receivedItemMessageToggleAnim.SetBool("MenuActivated", true);
        }
        else if (receivedItemMessageToggleAnim.GetBool("MenuActivated") == false)
        {
            receivedItemMessageToggleAnim.SetBool("MenuActivated", true);
        }
        else if (receivedItemMessageToggleAnim.GetBool("MenuActivated") == true)
        {
            receivedItemMessageToggleAnim.SetBool("MenuActivated", false);
        }
    }

    public void NutritionalRequirementsToggle()
    {
        if (NutrionalRequirementsAnim.GetBool("NutritionalRequirementsDefault") == true)
        {
            NutrionalRequirementsAnim.SetBool("NutritionalRequirementsDefault", false);
            NutrionalRequirementsAnim.SetBool("NutritionalRequirementsAnimateIn", true);
            notificationGoodSource.Play();
        }
        else if (NutrionalRequirementsAnim.GetBool("NutritionalRequirementsAnimateIn") == true)
        {
            NutrionalRequirementsAnim.SetBool("NutritionalRequirementsAnimateIn", false);
            NutrionalRequirementsAnim.SetBool("NutritionalRequirementsAnimateOut", true);
        }
        else if (NutrionalRequirementsAnim.GetBool("NutritionalRequirementsAnimateOut") == true)
        {
            NutrionalRequirementsAnim.SetBool("NutritionalRequirementsAnimateOut", false);
            NutrionalRequirementsAnim.SetBool("NutritionalRequirementsAnimateIn", true);
        }
    }


    public void BiochemicalCorrectAnswerSelectedToggle()
    {
        if (!Phase2BiochemicalWhyAnswerHasBeenSelected)
        {
            if (BiochemicalWhyAnswerAnim.GetBool("MenuDefault") == true)
            {
                BiochemicalWhyAnswerAnim.SetBool("MenuDefault", false);
                BiochemicalWhyAnswerAnim.SetBool("MenuActivated", true);
            }
            else if (BiochemicalWhyAnswerAnim.GetBool("MenuActivated") == false)
            {
                BiochemicalWhyAnswerAnim.SetBool("MenuActivated", true);
            }
            else if (BiochemicalWhyAnswerAnim.GetBool("MenuActivated") == true)
            {
                BiochemicalWhyAnswerAnim.SetBool("MenuActivated", false);
            }
        }
    }

    public void Phase06Part02Restart()
    {
        phase6Part01Selection01Selected = false;
        phase6Part01Selection02Selected = false;
        phase6Part01Selection03Selected = false;
        phase6Part01Selection04Selected = false;
        phase6Part01Selection05Selected = false;
        phase6Part01Selection06Selected = false;
        phase6Part01Selection07Selected = false;
        phase6Part01Selection08Selected = false;
        phase6Part01Selection09Selected = false;
        phase6Part01Selection10Selected = false;
        phase6Part01Selection11Selected = false;
        phase6Part01Selection12Selected = false;
        phase6Part01Selection13Selected = false;
        phase6Part01Selection14Selected = false;
        phase6Part01Selection15Selected = false;
        phase6Part01Selection01SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection02SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection03SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection04SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection05SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection06SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection07SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection08SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection09SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection10SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection11SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection12SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection13SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection14SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection15SelectImage.sprite = Phase6DeselectedOptionSprite;
        Phase6Part01SelectedAmount = 0;
        phase6Part01Complete = false;
        Phase6Part01CurrentTransformInt = 0;
        Phase6Part02CurrentTransformInt = 0;
        Phase07NutritionGoal01.SetActive(false);
        Phase07NutritionGoal02.SetActive(false);
        Phase07NutritionGoal03.SetActive(false);
        Phase07NutritionGoal04.SetActive(false);
        Phase07NutritionGoal05.SetActive(false);
        Phase07NutritionGoal06.SetActive(false);
        phase6Part02Selection01Selected = false;
        phase6Part02Selection02Selected = false;
        phase6Part02Selection03Selected = false;
        phase6Part02Selection04Selected = false;
        phase6Part02Selection05Selected = false;
        phase6Part02Selection06Selected = false;
        phase6Part02Selection07Selected = false;
        phase6Part02Selection08Selected = false;
        phase6Part02Selection09Selected = false;
        phase6Part02Selection10Selected = false;
        phase6Part02Selection11Selected = false;
        phase6Part02Selection01SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection02SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection03SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection04SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection05SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection06SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection07SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection08SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection09SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection10SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection11SelectImage.sprite = Phase6DeselectedOptionSprite;
        Phase6Part02SelectedAmount = 0;
        foreach (GameObject phase6Part01GameObject in Phase6PartOneToTwoSelectionGameObjectArray)
        {
            phase6Part01GameObject.SetActive(false);
        }
        Phase6PartOneToTwoSelectionGameObjectArray.Clear();
        Phase6Part02Group.SetTrigger("AnimateOut");
        Phase6Part01Group.SetTrigger("AnimateIn");
        phase6Part01Complete = false;
        phase6Part02Complete = false;
        phase6Part03Complete = false;
        phase6Part04Complete = false;
    }

    public void Phase06Part01Selection01()
    {
        if (!phase6Part01Selection01Selected)
        {
            if (Phase6Part01SelectedAmount < 5)
            {
                phase6Part01Selection01Selected = true;
                phase6Part01Selection01SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartOneToTwoSelectionGameObjectArray.Add(Phase6PartSelectionGameObject01);
                Phase07NutritionGoal04.SetActive(true);
                Phase6Part01SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part01Selection01Selected = false;
            phase6Part01Selection01SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartOneToTwoSelectionGameObjectArray.Remove(Phase6PartSelectionGameObject01);
            Phase07NutritionGoal04.SetActive(false);
            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part01Selection02()
    {
        if (!phase6Part01Selection02Selected)
        {
            if (Phase6Part01SelectedAmount < 5)
            {
                phase6Part01Selection02Selected = true;
                phase6Part01Selection02SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartOneToTwoSelectionGameObjectArray.Add(Phase6PartSelectionGameObject02);
                Phase6Part01SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part01Selection02Selected = false;
            phase6Part01Selection02SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartOneToTwoSelectionGameObjectArray.Remove(Phase6PartSelectionGameObject02);
            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part01Selection03()
    {
        if (!phase6Part01Selection03Selected)
        {
            if (phase6Part01Selection05Selected)
            {
                phase6part01AlertMessageText.text = "RECONSIDER THE APPROPRIATENESS OF YOUR SELECTED NUTRITION PROBLEMS";
                Phase06Part01AlertMessageToggle();
            }
            else if (phase6Part01Selection15Selected)
            {
                phase6part01AlertMessageText.text = "RECONSIDER THE APPROPRIATENESS OF YOUR SELECTED NUTRITION PROBLEMS";
                Phase06Part01AlertMessageToggle();
            }
            else
            {
                if (Phase6Part01SelectedAmount < 5)
                {
                    phase6Part01Selection03Selected = true;
                    phase6Part01Selection03SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                    Phase6PartOneToTwoSelectionGameObjectArray.Add(Phase6PartSelectionGameObject03);
                    Phase6Part01SelectedAmount++;
                }
                else
                {
                    phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                    Phase06Part01AlertMessageToggle();
                }
            }
        }
        else
        {
            phase6Part01Selection03Selected = false;
            phase6Part01Selection03SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartOneToTwoSelectionGameObjectArray.Remove(Phase6PartSelectionGameObject03);
            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part01Selection04()
    {
        if (!phase6Part01Selection04Selected)
        {
            if (phase6Part01Selection05Selected)
            {
                phase6part01AlertMessageText.text = "RECONSIDER THE APPROPRIATENESS OF YOUR SELECTED NUTRITION PROBLEMS";
                Phase06Part01AlertMessageToggle();
            }
            else if (phase6Part01Selection15Selected)
            {
                phase6part01AlertMessageText.text = "RECONSIDER THE APPROPRIATENESS OF YOUR SELECTED NUTRITION PROBLEMS";
                Phase06Part01AlertMessageToggle();
            }
            else
            {
                if (Phase6Part01SelectedAmount < 5)
                {
                    phase6Part01Selection04Selected = true;
                    phase6Part01Selection04SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                    Phase6PartOneToTwoSelectionGameObjectArray.Add(Phase6PartSelectionGameObject04);
                    Phase6Part01SelectedAmount++;
                }
                else
                {
                    phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                    Phase06Part01AlertMessageToggle();
                }
            }
        }
        else
        {
            phase6Part01Selection04Selected = false;
            phase6Part01Selection04SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartOneToTwoSelectionGameObjectArray.Remove(Phase6PartSelectionGameObject04);
            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part01Selection05()
    {
        if (!phase6Part01Selection05Selected)
        {
            if (phase6Part01Selection03Selected)
            {
                phase6part01AlertMessageText.text = "RECONSIDER THE APPROPRIATENESS OF YOUR SELECTED NUTRITION PROBLEMS";
                Phase06Part01AlertMessageToggle();
            }
            else if (phase6Part01Selection04Selected)
            {
                phase6part01AlertMessageText.text = "RECONSIDER THE APPROPRIATENESS OF YOUR SELECTED NUTRITION PROBLEMS";
                Phase06Part01AlertMessageToggle();
            }
            else
            {
                if (Phase6Part01SelectedAmount < 5)
                {
                    phase6Part01Selection05Selected = true;
                    phase6Part01Selection05SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                    Phase6PartOneToTwoSelectionGameObjectArray.Add(Phase6PartSelectionGameObject05);
                    Phase6Part01SelectedAmount++;
                }
                else
                {
                    phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                    Phase06Part01AlertMessageToggle();
                }
            }
        }
        else
        {
            phase6Part01Selection05Selected = false;
            phase6Part01Selection05SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartOneToTwoSelectionGameObjectArray.Remove(Phase6PartSelectionGameObject05);
            Phase6Part01SelectedAmount--;
        }

    }

    public void Phase06Part01Selection06()
    {
        if (!phase6Part01Selection06Selected)
        {
            if (Phase6Part01SelectedAmount < 5)
            {
                phase6Part01Selection06Selected = true;
                phase6Part01Selection06SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartOneToTwoSelectionGameObjectArray.Add(Phase6PartSelectionGameObject06);
                Phase6Part01SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part01Selection06Selected = false;
            phase6Part01Selection06SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartOneToTwoSelectionGameObjectArray.Remove(Phase6PartSelectionGameObject06);
            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part01Selection07()
    {
        if (!phase6Part01Selection07Selected)
        {
            if (Phase6Part01SelectedAmount < 5)
            {
                phase6Part01Selection07Selected = true;
                phase6Part01Selection07SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartOneToTwoSelectionGameObjectArray.Add(Phase6PartSelectionGameObject07);
                Phase6Part01SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part01Selection07Selected = false;
            phase6Part01Selection07SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartOneToTwoSelectionGameObjectArray.Remove(Phase6PartSelectionGameObject07);
            Phase6Part01SelectedAmount--;
        }

    }

    public void Phase06Part01Selection08()
    {
        if (!phase6Part01Selection08Selected)
        {
            if (Phase6Part01SelectedAmount < 5)
            {
                phase6Part01Selection08Selected = true;
                phase6Part01Selection08SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartOneToTwoSelectionGameObjectArray.Add(Phase6PartSelectionGameObject08);
                Phase6Part01SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part01Selection08Selected = false;
            phase6Part01Selection08SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartOneToTwoSelectionGameObjectArray.Remove(Phase6PartSelectionGameObject08);
            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part01Selection09()
    {
        if (!phase6Part01Selection09Selected)
        {
            if (Phase6Part01SelectedAmount < 5)
            {
                phase6Part01Selection09Selected = true;
                phase6Part01Selection09SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part01SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part01Selection09Selected = false;
            phase6Part01Selection09SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part01Selection10()
    {
        if (!phase6Part01Selection10Selected)
        {
            if (Phase6Part01SelectedAmount < 5)
            {
                phase6Part01Selection10Selected = true;
                phase6Part01Selection10SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartOneToTwoSelectionGameObjectArray.Add(Phase6PartSelectionGameObject09);
                Phase6Part01SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part01Selection10Selected = false;
            phase6Part01Selection10SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartOneToTwoSelectionGameObjectArray.Remove(Phase6PartSelectionGameObject09);
            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part01Selection11()
    {
        if (!phase6Part01Selection11Selected)
        {
            if (Phase6Part01SelectedAmount < 5)
            {
                phase6Part01Selection11Selected = true;
                phase6Part01Selection11SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartOneToTwoSelectionGameObjectArray.Add(Phase6PartSelectionGameObject10);
                Phase6Part01SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part01Selection11Selected = false;
            phase6Part01Selection11SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartOneToTwoSelectionGameObjectArray.Remove(Phase6PartSelectionGameObject10);
            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part01Selection12()
    {
        if (!phase6Part01Selection12Selected)
        {
            if (Phase6Part01SelectedAmount < 5)
            {
                phase6Part01Selection12Selected = true;
                phase6Part01Selection12SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part01SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part01Selection12Selected = false;
            phase6Part01Selection12SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part01Selection13()
    {
        if (!phase6Part01Selection13Selected)
        {
            if (Phase6Part01SelectedAmount < 5)
            {
                phase6Part01Selection13Selected = true;
                phase6Part01Selection13SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part01SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part01Selection13Selected = false;
            phase6Part01Selection13SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part01SelectedAmount--;
        }

    }

    public void Phase06Part01Selection14()
    {
        if (!phase6Part01Selection14Selected)
        {
            if (Phase6Part01SelectedAmount < 5)
            {
                phase6Part01Selection14Selected = true;
                phase6Part01Selection14SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part01SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part01Selection14Selected = false;
            phase6Part01Selection14SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part01Selection15()
    {
        if (!phase6Part01Selection15Selected)
        {
            if (phase6Part01Selection03Selected)
            {
                phase6part01AlertMessageText.text = "RECONSIDER THE APPROPRIATENESS OF YOUR SELECTED NUTRITION PROBLEMS";
                Phase06Part01AlertMessageToggle();
            }
            else if (phase6Part01Selection04Selected)
            {
                phase6part01AlertMessageText.text = "RECONSIDER THE APPROPRIATENESS OF YOUR SELECTED NUTRITION PROBLEMS";
                Phase06Part01AlertMessageToggle();
            }
            else
            {
                if (Phase6Part01SelectedAmount < 5)
                {
                    phase6Part01Selection15Selected = true;
                    phase6Part01Selection15SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                    Phase6PartOneToTwoSelectionGameObjectArray.Add(Phase6PartSelectionGameObject11);
                    Phase6Part01SelectedAmount++;
                }
                else
                {
                    phase6part01AlertMessageText.text = "Please only select up to Five (5) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                    Phase06Part01AlertMessageToggle();
                }
            }
        }
        else
        {
            phase6Part01Selection15Selected = false;
            phase6Part01Selection15SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartOneToTwoSelectionGameObjectArray.Remove(Phase6PartSelectionGameObject11);

            Phase6Part01SelectedAmount--;
        }
    }

    public void Phase06Part02Selection01()
    {
        if (!phase6Part02Selection01Selected)
        {
            if (Phase6Part02SelectedAmount < 3)
            {
                phase6Part02Selection01Selected = true;
                phase6Part02Selection01SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part02SelectedAmount++;
                phase06part02CombinedScore += 2;

            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part02Selection01Selected = false;
            phase6Part02Selection01SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part02SelectedAmount--;
            phase06part02CombinedScore -= 2;
        }
    }

    public void Phase06Part02Selection02()
    {
        if (!phase6Part02Selection02Selected)
        {
            if (Phase6Part02SelectedAmount < 3)
            {
                phase6Part02Selection02Selected = true;
                phase6Part02Selection02SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartTwoToThreeSelectionGameObjectArray.Add(Phase6Part2SelectionGameObject02);
                Phase6PartThreeToFourSelectionGameObjectArray.Add(Phase6Part4SelectionGameObject02);
                Phase6PartThreeDropZonesArray.Add(Phase6Part3DropZone02);
                Phase6Part02SelectedAmount++;
                if (phase06part02PotentialIssue01String == "")
                {
                    phase06part02PotentialIssue01String = "Insufficient fluid intake";
                }
                else if (phase06part02PotentialIssue01String != "" && phase06part02PotentialIssue02String == "")
                {
                    phase06part02PotentialIssue02String = "Insufficient fluid intake";
                }
                else if (phase06part02PotentialIssue01String != "" && phase06part02PotentialIssue02String != "" && phase06part02PotentialIssue03String == "")
                {
                    phase06part02PotentialIssue03String = "Insufficient fluid intake";
                }
                if (phase06part03Evidence01String == "")
                {
                    phase06part03Evidence01String = "meeting less than 60% of her needs, increased serum potassium and sodium levels.";
                }
                else if (phase06part03Evidence01String != "" && phase06part03Evidence02String == "")
                {
                    phase06part03Evidence02String = "meeting less than 60% of her needs, increased serum potassium and sodium levels.";
                }
                else if (phase06part03Evidence01String != "" && phase06part03Evidence02String != "" && phase06part03Evidence03String == "")
                {
                    phase06part03Evidence03String = "meeting less than 60% of her needs, increased serum potassium and sodium levels.";
                }
                Phase07NutritionGoal04.SetActive(true);
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part02Selection02Selected = false;
            phase6Part02Selection02SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartTwoToThreeSelectionGameObjectArray.Remove(Phase6Part2SelectionGameObject02);
            Phase6PartThreeToFourSelectionGameObjectArray.Remove(Phase6Part4SelectionGameObject02);
            Phase6PartThreeDropZonesArray.Remove(Phase6Part3DropZone02);
            Phase6Part02SelectedAmount--;
            if (phase06part02PotentialIssue03String == "Insufficient fluid intake")
            {
                phase06part02PotentialIssue03String = "";
            }
            else if (phase06part02PotentialIssue02String == "Insufficient fluid intake")
            {
                phase06part02PotentialIssue02String = "";
            }
            else if (phase06part02PotentialIssue01String == "Insufficient fluid intake")
            {
                phase06part02PotentialIssue01String = "";
            }
            if (phase06part03Evidence03String == "meeting less than 60% of her needs, increased serum potassium and sodium levels.")
            {
                phase06part03Evidence03String = "";
            }
            else if (phase06part03Evidence02String == "meeting less than 60% of her needs, increased serum potassium and sodium levels.")
            {
                phase06part03Evidence02String = "";
            }
            else if (phase06part03Evidence01String == "meeting less than 60% of her needs, increased serum potassium and sodium levels.")
            {
                phase06part03Evidence01String = "";
            }
            Phase07NutritionGoal04.SetActive(false);
        }
    }
    public void Phase06Part02Selection03()
    {
        if (!phase6Part02Selection03Selected)
        {
            phase06part02CombinedScore += 1;
            if (Phase6Part02SelectedAmount < 3)
            {
                phase6Part02Selection03Selected = true;
                phase6Part02Selection03SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartTwoToThreeSelectionGameObjectArray.Add(Phase6Part2SelectionGameObject03);
                Phase6PartThreeToFourSelectionGameObjectArray.Add(Phase6Part4SelectionGameObject03);
                Phase6PartThreeDropZonesArray.Add(Phase6Part3DropZone03);
                Phase6Part02SelectedAmount++;
                if (phase06part02PotentialIssue01String == "")
                {
                    phase06part02PotentialIssue01String = "Insufficient energy intake";
                }
                else if (phase06part02PotentialIssue01String != "" && phase06part02PotentialIssue02String == "")
                {
                    phase06part02PotentialIssue02String = "Insufficient energy intake";
                }
                else if (phase06part02PotentialIssue01String != "" && phase06part02PotentialIssue02String != "" && phase06part02PotentialIssue03String == "")
                {
                    phase06part02PotentialIssue03String = "Insufficient energy intake";
                }
                if (phase06part03Evidence01String == "")
                {
                    phase06part03Evidence01String = "meeting less than 75 % of her needs, recent weight loss of 8.5%";
                }
                else if (phase06part03Evidence01String != "" && phase06part03Evidence02String == "")
                {
                    phase06part03Evidence02String = "meeting less than 75 % of her needs, recent weight loss of 8.5%";
                }
                else if (phase06part03Evidence01String != "" && phase06part03Evidence02String != "" && phase06part03Evidence03String == "")
                {
                    phase06part03Evidence03String = "meeting less than 75 % of her needs, recent weight loss of 8.5%";
                }
                Phase07NutritionGoal01.SetActive(true);
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase06part02CombinedScore -= 1;
            phase6Part02Selection03Selected = false;
            phase6Part02Selection03SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartTwoToThreeSelectionGameObjectArray.Remove(Phase6Part2SelectionGameObject03);
            Phase6PartThreeToFourSelectionGameObjectArray.Remove(Phase6Part4SelectionGameObject03);
            Phase6PartThreeDropZonesArray.Remove(Phase6Part3DropZone03);
            Phase6Part02SelectedAmount--;
            if (phase06part02PotentialIssue03String == "Insufficient energy intake")
            {
                phase06part02PotentialIssue03String = "";
            }
            else if (phase06part02PotentialIssue02String == "Insufficient energy intake")
            {
                phase06part02PotentialIssue02String = "";
            }
            else if (phase06part02PotentialIssue01String == "Insufficient energy intake")
            {
                phase06part02PotentialIssue01String = "";
            }
            if (phase06part03Evidence03String == "meeting less than 75 % of her needs, recent weight loss of 8.5%")
            {
                phase06part03Evidence03String = "";
            }
            else if (phase06part03Evidence02String == "meeting less than 75 % of her needs, recent weight loss of 8.5%")
            {
                phase06part03Evidence02String = "";
            }
            else if (phase06part03Evidence01String == "meeting less than 75 % of her needs, recent weight loss of 8.5%")
            {
                phase06part03Evidence01String = "";
            }
            Phase07NutritionGoal01.SetActive(false);
        }
    }
    public void Phase06Part02Selection04()
    {
        if (!phase6Part02Selection04Selected)
        {
            phase06part02CombinedScore += 1;
            if (Phase6Part02SelectedAmount < 3)
            {
                phase6Part02Selection04Selected = true;
                phase6Part02Selection04SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartTwoToThreeSelectionGameObjectArray.Add(Phase6Part2SelectionGameObject04);
                Phase6PartThreeToFourSelectionGameObjectArray.Add(Phase6Part4SelectionGameObject04);
                Phase6PartThreeDropZonesArray.Add(Phase6Part3DropZone04);
                Phase6Part02SelectedAmount++;
                if (phase06part02PotentialIssue01String == "")
                {
                    phase06part02PotentialIssue01String = "Insufficient protein intake";
                }
                else if (phase06part02PotentialIssue01String != "" && phase06part02PotentialIssue02String == "")
                {
                    phase06part02PotentialIssue02String = "Insufficient protein intake";
                }
                else if (phase06part02PotentialIssue01String != "" && phase06part02PotentialIssue02String != "" && phase06part02PotentialIssue03String == "")
                {
                    phase06part02PotentialIssue03String = "Insufficient protein intake";
                }
                if (phase06part03Evidence01String == "")
                {
                    phase06part03Evidence01String = "meeting less than 67% of her needs.";
                }
                else if (phase06part03Evidence01String != "" && phase06part03Evidence02String == "")
                {
                    phase06part03Evidence02String = "meeting less than 67% of her needs.";
                }
                else if (phase06part03Evidence01String != "" && phase06part03Evidence02String != "" && phase06part03Evidence03String == "")
                {
                    phase06part03Evidence03String = "meeting less than 67% of her needs.";
                }
                Phase07NutritionGoal02.SetActive(true);
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase06part02CombinedScore -= 1;
            phase6Part02Selection04Selected = false;
            phase6Part02Selection04SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartTwoToThreeSelectionGameObjectArray.Remove(Phase6Part2SelectionGameObject04);
            Phase6PartThreeToFourSelectionGameObjectArray.Remove(Phase6Part4SelectionGameObject04);
            Phase6PartThreeDropZonesArray.Remove(Phase6Part3DropZone04);
            Phase6Part02SelectedAmount--;
            if (phase06part02PotentialIssue03String == "Insufficient protein intake")
            {
                phase06part02PotentialIssue03String = "";
            }
            else if (phase06part02PotentialIssue02String == "Insufficient protein intake")
            {
                phase06part02PotentialIssue02String = "";
            }
            else if (phase06part02PotentialIssue01String == "Insufficient protein intake")
            {
                phase06part02PotentialIssue01String = "";
            }
            if (phase06part03Evidence03String == "meeting less than 67% of her needs.")
            {
                phase06part03Evidence03String = "";
            }
            else if (phase06part03Evidence02String == "meeting less than 67% of her needs.")
            {
                phase06part03Evidence02String = "";
            }
            else if (phase06part03Evidence01String == "meeting less than 67% of her needs.")
            {
                phase06part03Evidence01String = "";
            }
            Phase07NutritionGoal02.SetActive(false);
        }
    }
    public void Phase06Part02Selection05()
    {
        if (!phase6Part02Selection05Selected)
        {
            if (Phase6Part02SelectedAmount < 3)
            {
                phase6Part02Selection05Selected = true;
                phase6Part02Selection05SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartTwoToThreeSelectionGameObjectArray.Add(Phase6Part2SelectionGameObject05);
                Phase6PartThreeToFourSelectionGameObjectArray.Add(Phase6Part4SelectionGameObject05);
                Phase6PartThreeDropZonesArray.Add(Phase6Part3DropZone05);
                Phase6Part02SelectedAmount++;
                if (phase06part02PotentialIssue01String == "")
                {
                    phase06part02PotentialIssue01String = "Insufficient energy and protein intake";
                }
                else if (phase06part02PotentialIssue01String != "" && phase06part02PotentialIssue02String == "")
                {
                    phase06part02PotentialIssue02String = "Insufficient energy and protein intake";
                }
                else if (phase06part02PotentialIssue01String != "" && phase06part02PotentialIssue02String != "" && phase06part02PotentialIssue03String == "")
                {
                    phase06part02PotentialIssue03String = "Insufficient energy and protein intake";
                }
                if (phase06part03Evidence01String == "")
                {
                    phase06part03Evidence01String = "meeting less than 75% of her energy and less than 67% of her protein needs, recent weight loss of 8.5%";
                }
                else if (phase06part03Evidence01String != "" && phase06part03Evidence02String == "")
                {
                    phase06part03Evidence02String = "meeting less than 75% of her energy and less than 67% of her protein needs, recent weight loss of 8.5%";
                }
                else if (phase06part03Evidence01String != "" && phase06part03Evidence02String != "" && phase06part03Evidence03String == "")
                {
                    phase06part03Evidence03String = "meeting less than 75% of her energy and less than 67% of her protein needs, recent weight loss of 8.5%";
                }
                if (!phase6Part02Selection11Selected)
                {
                    Phase07NutritionGoal03.SetActive(true);
                }
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part02Selection05Selected = false;
            phase6Part02Selection05SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartTwoToThreeSelectionGameObjectArray.Remove(Phase6Part2SelectionGameObject05);
            Phase6PartThreeToFourSelectionGameObjectArray.Remove(Phase6Part4SelectionGameObject05);
            Phase6PartThreeDropZonesArray.Remove(Phase6Part3DropZone05);
            Phase6Part02SelectedAmount--;
            if (phase06part02PotentialIssue03String == "Insufficient energy and protein intake")
            {
                phase06part02PotentialIssue03String = "";
            }
            else if (phase06part02PotentialIssue02String == "Insufficient energy and protein intake")
            {
                phase06part02PotentialIssue02String = "";
            }
            else if (phase06part02PotentialIssue01String == "Insufficient energy and protein intake")
            {
                phase06part02PotentialIssue01String = "";
            }
            if (phase06part03Evidence03String == "meeting less than 75% of her energy and less than 67% of her protein needs, recent weight loss of 8.5%")
            {
                phase06part03Evidence03String = "";
            }
            else if (phase06part03Evidence02String == "meeting less than 75% of her energy and less than 67% of her protein needs, recent weight loss of 8.5%")
            {
                phase06part03Evidence02String = "";
            }
            else if (phase06part03Evidence01String == "meeting less than 75% of her energy and less than 67% of her protein needs, recent weight loss of 8.5%")
            {
                phase06part03Evidence01String = "";
            }
            if (!phase6Part02Selection11Selected)
            {
                Phase07NutritionGoal03.SetActive(false);
            }
        }
    }
    public void Phase06Part02Selection06()
    {
        if (!phase6Part02Selection06Selected)
        {
            if (Phase6Part02SelectedAmount < 3)
            {
                phase6Part02Selection06Selected = true;
                phase6Part02Selection06SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part02SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part02Selection06Selected = false;
            phase6Part02Selection06SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part02SelectedAmount--;
        }
    }
    public void Phase06Part02Selection07()
    {
        if (!phase6Part02Selection07Selected)
        {
            if (Phase6Part02SelectedAmount < 3)
            {
                phase6Part02Selection07Selected = true;
                phase6Part02Selection07SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part02SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part02Selection07Selected = false;
            phase6Part02Selection07SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part02SelectedAmount--;
        }
    }
    public void Phase06Part02Selection08()
    {
        if (!phase6Part02Selection08Selected)
        {
            if (Phase6Part02SelectedAmount < 3)
            {
                phase6Part02Selection08Selected = true;
                phase6Part02Selection08SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part02SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part02Selection08Selected = false;
            phase6Part02Selection08SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part02SelectedAmount--;
        }
    }
    public void Phase06Part02Selection09()
    {
        if (!phase6Part02Selection09Selected)
        {
            if (Phase6Part02SelectedAmount < 3)
            {
                phase6Part02Selection09Selected = true;
                phase6Part02Selection09SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part02SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part02Selection09Selected = false;
            phase6Part02Selection09SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part02SelectedAmount--;
        }
    }
    public void Phase06Part02Selection10()
    {
        if (!phase6Part02Selection10Selected)
        {
            if (Phase6Part02SelectedAmount < 3)
            {
                phase6Part02Selection10Selected = true;
                phase6Part02Selection10SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part02SelectedAmount++;
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }

        }
        else
        {
            phase6Part02Selection10Selected = false;
            phase6Part02Selection10SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part02SelectedAmount--;
        }
    }
    public void Phase06Part02Selection11()
    {
        if (!phase6Part02Selection11Selected)
        {
            if (Phase6Part02SelectedAmount < 3)
            {
                phase6Part02Selection11Selected = true;
                phase6Part02Selection11SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6PartTwoToThreeSelectionGameObjectArray.Add(Phase6Part2SelectionGameObject06);
                Phase6PartThreeToFourSelectionGameObjectArray.Add(Phase6Part4SelectionGameObject06);
                Phase6PartThreeDropZonesArray.Add(Phase6Part3DropZone06);
                Phase6Part02SelectedAmount++;
                if (phase06part02PotentialIssue01String == "")
                {
                    phase06part02PotentialIssue01String = "Malnourished";
                }
                else if (phase06part02PotentialIssue01String != "" && phase06part02PotentialIssue02String == "")
                {
                    phase06part02PotentialIssue02String = "Malnourished";
                }
                else if (phase06part02PotentialIssue01String != "" && phase06part02PotentialIssue02String != "" && phase06part02PotentialIssue03String == "")
                {
                    phase06part02PotentialIssue03String = "Malnourished";
                }
                if (phase06part03Evidence01String == "")
                {
                    phase06part03Evidence01String = "having a BMI of < 22 kg/m2, an SGA score of B, wasting of temple, clavicle, shoulder, and calf.";
                }
                else if (phase06part03Evidence01String != "" && phase06part03Evidence02String == "")
                {
                    phase06part03Evidence02String = "having a BMI of < 22 kg/m2, an SGA score of B, wasting of temple, clavicle, shoulder, and calf.";
                }
                else if (phase06part03Evidence01String != "" && phase06part03Evidence02String != "" && phase06part03Evidence03String == "")
                {
                    phase06part03Evidence03String = "having a BMI of < 22 kg/m2, an SGA score of B, wasting of temple, clavicle, shoulder, and calf.";
                }
                if (!phase6Part02Selection05Selected)
                {
                    Phase07NutritionGoal03.SetActive(true);
                }
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) problems. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part02Selection11Selected = false;
            phase6Part02Selection11SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6PartTwoToThreeSelectionGameObjectArray.Remove(Phase6Part2SelectionGameObject06);
            Phase6PartThreeToFourSelectionGameObjectArray.Remove(Phase6Part4SelectionGameObject06);
            Phase6PartThreeDropZonesArray.Remove(Phase6Part3DropZone06);
            Phase6Part02SelectedAmount--;
            if (phase06part02PotentialIssue03String == "Malnourished")
            {
                phase06part02PotentialIssue03String = "";
            }
            else if (phase06part02PotentialIssue02String == "Malnourished")
            {
                phase06part02PotentialIssue02String = "";
            }
            else if (phase06part02PotentialIssue01String == "Malnourished")
            {
                phase06part02PotentialIssue01String = "";
            }
            if (phase06part03Evidence03String == "having a BMI of < 22 kg/m2, an SGA score of B, wasting of temple, clavicle, shoulder, and calf.")
            {
                phase06part03Evidence03String = "";
            }
            else if (phase06part03Evidence02String == "having a BMI of < 22 kg/m2, an SGA score of B, wasting of temple, clavicle, shoulder, and calf.")
            {
                phase06part03Evidence02String = "";
            }
            else if (phase06part03Evidence01String == "having a BMI of < 22 kg/m2, an SGA score of B, wasting of temple, clavicle, shoulder, and calf.")
            {
                phase06part03Evidence01String = "";
            }
            if (!phase6Part02Selection05Selected)
            {
                Phase07NutritionGoal03.SetActive(false);
            }
        }
    }

    public void Phase06Part03Selection01()
    {
        if (!phase6Part03Selection01Selected)
        {
            if (phase06Part03SelectedAmount < 3)
            {
                phase6Part03Selection01Selected = true;
                Phase06Part03IncorrectCauseSelectedStringArray.Add("Although Rheumatoid Arthritis can increase energy needs, this is less likely to be the root cause for Marta’s current nutrition problem/s.");
                phase6Part03Selection01SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                phase06Part03SelectedAmount++;
            }
            else if (phase06Part03SelectedAmount > 2)
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) causes as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part03Selection01Selected = false;
            phase6Part03Selection01SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase06Part03IncorrectCauseSelectedStringArray.Remove("Although Rheumatoid Arthritis can increase energy needs, this is less likely to be the root cause for Marta’s current nutrition problem/s.");
            phase06Part03SelectedAmount--;
        }
    }

    public void Phase06Part03Selection02()
    {
        if (!phase6Part03Selection02Selected)
        {
            if (phase06Part03SelectedAmount < 3)
            {
                phase6Part03Selection02Selected = true;
                Phase06Part03CausesStringArray.Add("Reduced intake due to some of the nutrition-impact symptoms she is experiencing such as appetite loss and nausea.");
                Phase07NutritionGoal05.SetActive(true);
                phase6Part03Selection02SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                phase06Part03SelectedAmount++;
            }
            else if (phase06Part03SelectedAmount > 2)
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) causes as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part03Selection02Selected = false;
            phase6Part03Selection02SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase07NutritionGoal05.SetActive(false);
            Phase06Part03CausesStringArray.Remove("Reduced intake due to some of the nutrition-impact symptoms she is experiencing such as appetite loss and nausea.");
            phase06Part03SelectedAmount--;
        }
    }

    public void Phase06Part03Selection03()
    {
        if (!phase6Part03Selection03Selected)
        {
            if (phase06Part03SelectedAmount < 3)
            {
                phase6Part03Selection03Selected = true;
                Phase06Part03CausesStringArray.Add("Reduced ability to prepare food and feed herself due to complications of Rheumatoid Arthritis.");
                phase6Part03Selection03SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase07NutritionGoal06.SetActive(true);
                phase06Part03SelectedAmount++;
            }
            else if (phase06Part03SelectedAmount > 2)
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) causes as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part03Selection03Selected = false;
            phase6Part03Selection03SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase06Part03CausesStringArray.Remove("Reduced ability to prepare food and feed herself due to complications of Rheumatoid Arthritis.");
            Phase07NutritionGoal06.SetActive(false);
            phase06Part03SelectedAmount--;
        }
    }

    public void Phase06Part03Selection04()
    {
        if (!phase6Part03Selection04Selected)
        {
            if (phase06Part03SelectedAmount < 3)
            {
                phase6Part03Selection04Selected = true;
                Phase06Part03IncorrectCauseSelectedStringArray.Add("Not knowing how much food and the types of food she needs on a daily basis is important, however there are more important options.");
                phase6Part03Selection04SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                phase06Part03SelectedAmount++;
            }
            else if (phase06Part03SelectedAmount > 2)
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) causes as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part03Selection04Selected = false;
            phase6Part03Selection04SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase06Part03IncorrectCauseSelectedStringArray.Remove("Not knowing how much food and the types of food she needs on a daily basis is important, however there are more important options.");
            phase06Part03SelectedAmount--;
        }
    }

    public void Phase06Part03Selection05()
    {
        if (!phase6Part03Selection05Selected)
        {
            if (phase06Part03SelectedAmount < 3)
            {
                phase6Part03Selection05Selected = true;
                Phase06Part03IncorrectCauseSelectedStringArray.Add("Marta has a friend who can take her to do her grocery shopping thus this not likely the cause of her current state.");
                phase6Part03Selection05SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                phase06Part03SelectedAmount++;
            }
            else if (phase06Part03SelectedAmount > 2)
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) causes as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part03Selection05Selected = false;
            phase6Part03Selection05SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase06Part03IncorrectCauseSelectedStringArray.Remove("Marta has a friend who can take her to do her grocery shopping thus this not likely the cause of her current state.");
            phase06Part03SelectedAmount--;
        }
    }

    public void Phase06Part03Selection06()
    {
        if (!phase6Part03Selection06Selected)
        {
            if (phase06Part03SelectedAmount < 3)
            {
                phase6Part03Selection06Selected = true;
                Phase06Part03IncorrectCauseSelectedStringArray.Add("Although Marta is on a full pension there are cheaper food options that she can purchase and are therefore highly likely to meet her needs.");
                phase6Part03Selection06SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                phase06Part03SelectedAmount++;
            }
            else if (phase06Part03SelectedAmount > 2)
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) causes as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part03Selection06Selected = false;
            phase6Part03Selection06SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase06Part03IncorrectCauseSelectedStringArray.Remove("Although Marta is on a full pension there are cheaper food options that she can purchase and are therefore highly likely to meet her needs.");
            phase06Part03SelectedAmount--;
        }
    }

    public void Phase06Part03Selection07()
    {
        if (!phase6Part03Selection07Selected)
        {
            if (phase06Part03SelectedAmount < 3)
            {
                phase6Part03Selection07Selected = true;
                Phase06Part03IncorrectCauseSelectedStringArray.Add("Marta has an extensive social network on which she can call if she needs help, she also receives food from a home delivery service in the week. This is therefore less likely to be a cause of her current state.");
                phase6Part03Selection07SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                phase06Part03SelectedAmount++;
            }
            else if (phase06Part03SelectedAmount > 2)
            {
                phase6part01AlertMessageText.text = "Please only select up to Three (3) causes as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part03Selection07Selected = false;
            phase6Part03Selection07SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase06Part03IncorrectCauseSelectedStringArray.Remove("Marta has an extensive social network on which she can call if she needs help, she also receives food from a home delivery service in the week. This is therefore less likely to be a cause of her current state.");
            phase06Part03SelectedAmount--;
        }
    }

    public void Phase06Part04Selection01()
    {
        if (!phase6Part04Selection01Selected)
        {
            if (Phase6Part04SelectedAmount < 2)
            {
                phase6Part04Selection01Selected = true;
                phase6Part04Selection01SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part04SelectedAmount++;
                if (phase6nutritiondiagnosis01 != "")
                {
                    phase6nutritiondiagnosis02 = "Insufficient fibre intake";
                }
                else if (phase6nutritiondiagnosis01 == "")
                {
                    phase6nutritiondiagnosis01 = "Insufficient fibre intake";
                }
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Two (2) problems as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part04Selection01Selected = false;
            phase6Part04Selection01SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part04SelectedAmount--;
            if (phase6nutritiondiagnosis02 != "")
            {
                phase6nutritiondiagnosis02 = "";
            }
            else if (phase6nutritiondiagnosis01 != "")
            {
                phase6nutritiondiagnosis01 = "";
            }
        }
    }
    public void Phase06Part04Selection02()
    {
        if (!phase6Part04Selection02Selected)
        {
            if (Phase6Part04SelectedAmount < 2)
            {
                phase6Part04Selection02Selected = true;
                phase6Part04Selection02SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part04SelectedAmount++;
                if (phase6nutritiondiagnosis01 != "")
                {
                    phase6nutritiondiagnosis02 = "Insufficient fluid intake";
                }
                else if (phase6nutritiondiagnosis01 == "")
                {
                    phase6nutritiondiagnosis01 = "Insufficient fluid intake";
                }
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Two (2) problems as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part04Selection02Selected = false;
            phase6Part04Selection02SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part04SelectedAmount--;
            if (phase6nutritiondiagnosis02 != "")
            {
                phase6nutritiondiagnosis02 = "";
            }
            else if (phase6nutritiondiagnosis01 != "")
            {
                phase6nutritiondiagnosis01 = "";
            }
        }
    }
    public void Phase06Part04Selection03()
    {
        if (!phase6Part04Selection03Selected)
        {
            if (Phase6Part04SelectedAmount < 2)
            {
                phase6Part04Selection03Selected = true;
                phase6Part04Selection03SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part04SelectedAmount++;
                if (phase6nutritiondiagnosis01 != "")
                {
                    phase6nutritiondiagnosis02 = "Insufficient energy intake";
                }
                else if (phase6nutritiondiagnosis01 == "")
                {
                    phase6nutritiondiagnosis01 = "Insufficient energy intake";
                }
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Two (2) problems as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part04Selection03Selected = false;
            phase6Part04Selection03SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part04SelectedAmount--;
            if (phase6nutritiondiagnosis02 != "")
            {
                phase6nutritiondiagnosis02 = "";
            }
            else if (phase6nutritiondiagnosis01 != "")
            {
                phase6nutritiondiagnosis01 = "";
            }
        }
    }
    public void Phase06Part04Selection04()
    {
        if (!phase6Part04Selection04Selected)
        {
            if (Phase6Part04SelectedAmount < 2)
            {
                phase6Part04Selection04Selected = true;
                phase6Part04Selection04SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part04SelectedAmount++;
                if (phase6nutritiondiagnosis01 != "")
                {
                    phase6nutritiondiagnosis02 = "Insufficient protein intake";
                }
                else if (phase6nutritiondiagnosis01 == "")
                {
                    phase6nutritiondiagnosis01 = "Insufficient protein intake";
                }
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Two (2) problems as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part04Selection04Selected = false;
            phase6Part04Selection04SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part04SelectedAmount--;
            if (phase6nutritiondiagnosis02 != "")
            {
                phase6nutritiondiagnosis02 = "";
            }
            else if (phase6nutritiondiagnosis01 != "")
            {
                phase6nutritiondiagnosis01 = "";
            }
        }
    }
    public void Phase06Part04Selection05()
    {
        if (!phase6Part04Selection05Selected)
        {
            if (Phase6Part04SelectedAmount < 2)
            {
                phase6Part04Selection05Selected = true;
                phase6Part04Selection05SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part04SelectedAmount++;
                if (phase6nutritiondiagnosis01 != "")
                {
                    phase6nutritiondiagnosis02 = "Insufficient energy and protein intake";
                }
                else if (phase6nutritiondiagnosis01 == "")
                {
                    phase6nutritiondiagnosis01 = "Insufficient energy and protein intake";
                }
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Two (2) problems as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part04Selection05Selected = false;
            phase6Part04Selection05SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part04SelectedAmount--;
            if (phase6nutritiondiagnosis02 != "")
            {
                phase6nutritiondiagnosis02 = "";
            }
            else if (phase6nutritiondiagnosis01 != "")
            {
                phase6nutritiondiagnosis01 = "";
            }
        }
    }
    public void Phase06Part04Selection06()
    {
        if (!phase6Part04Selection06Selected)
        {
            if (Phase6Part04SelectedAmount < 2)
            {
                phase6Part04Selection06Selected = true;
                phase6Part04Selection06SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
                Phase6Part04SelectedAmount++;
                if (phase6nutritiondiagnosis01 != "")
                {
                    phase6nutritiondiagnosis02 = "Malnourished";
                }
                else if (phase6nutritiondiagnosis01 == "")
                {
                    phase6nutritiondiagnosis01 = "Malnourished";
                }
            }
            else
            {
                phase6part01AlertMessageText.text = "Please only select up to Two (2) problems as your top choices. If you are happy with your selection press  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else
        {
            phase6Part04Selection06Selected = false;
            phase6Part04Selection06SelectImage.sprite = Phase6DeselectedOptionSprite;
            Phase6Part04SelectedAmount--;
            if (phase6nutritiondiagnosis02 != "")
            {
                phase6nutritiondiagnosis02 = "";
            }
            else if (phase6nutritiondiagnosis01 != "")
            {
                phase6nutritiondiagnosis01 = "";
            }
        }
    }

    public void Phase06Part01CompleteCheck()
    {
        if (phase6Part01Selection09Selected || phase6Part01Selection12Selected || phase6Part01Selection13Selected || phase6Part01Selection14Selected)
        {
            if (!phase6Part01CompleteFirstCheck)
            {
                phase6part01AlertMessageText.text = "Carefully consider whether the nutrition problems you have selected can be resolved through nutrition intervention only.";
                Phase06Part01AlertMessageToggle();
                phase06EvidencePlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
                phase6Part01CompleteFirstCheck = true;
            }
            else if (phase6Part01CompleteFirstCheck)
            {
                phase6part01AlertMessageText.text = "Functional problems such as constipation and physical ability can be influenced by factors unrelated to nutrition. It is therefore recommended to rather focus on a problem that relates to food or nutrient intake in the first instance as these can be resolved through nutrition intervention. Please try again.";
                Phase06Part01AlertMessageToggle();
                phase08OverallScore = phase08OverallScore + 2;
                phase06EvidencePlayerRating = playerRatingNovice;
            }
        }
        else
        {
            Phase6Part01Group.SetTrigger("AnimateOut");
            Phase6Part02Group.SetTrigger("AnimateIn");
            foreach (GameObject phase6Part01GameObject in Phase6PartOneToTwoSelectionGameObjectArray)
            {
                phase6Part01GameObject.SetActive(true);
                Transform currentTransform = Phase6PartTwoSelectionTransforms[Phase6Part01CurrentTransformInt];
                phase6Part01GameObject.transform.position = new Vector2(currentTransform.position.x, currentTransform.position.y);
                Phase6Part01CurrentTransformInt++;
                Debug.Log(Phase6Part01CurrentTransformInt + " " + currentTransform);
            }
            phase6Part01Complete = true;
        }
    }

    public void Phase06Part02CompleteCheck()
    {
        if (Phase6Part02SelectedAmount > 0)
        {
            if (phase6Part02Selection06Selected)
            {
                phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + "Although Marta has increased energy needs in this case it may rather be a cause of her current state than the problem that needs to be resolved.";
                Phase06Part01AlertMessageToggle();
                if (phase6Part02Selection07Selected)
                {
                    phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Carbohydrate is not the only macronutrient that Marta is lacking in and in this particular case there are other problems that would take priority.";
                    if (phase6Part02Selection08Selected)
                    {
                        phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta is not having enough calcium rich foods in her diet she is taking a calcium supplement which helps her to achieve her requirements. This problem therefore has a lower priority.";
                    }
                    else if (phase6Part02Selection10Selected)
                    {
                        phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta is underweight there are other problems relating directly to food and nutrition that if resolved will also improve Marta’s weight.";
                    }
                    else if (phase6Part02Selection11Selected)
                    {
                        phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta may not be aware of her nutritional needs this may be a cause of her current state rather than the problem that needs to be resolved.";
                    }

                }
                else if (phase6Part02Selection08Selected)
                {
                    phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta is not having enough calcium rich foods in her diet she is taking a calcium supplement which helps her to achieve her requirements. This problem therefore has a lower priority.";
                    if (phase6Part02Selection10Selected)
                    {
                        phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta is underweight there are other problems relating directly to food and nutrition that if resolved will also improve Marta’s weight.";
                    }
                    else if (phase6Part02Selection11Selected)
                    {
                        phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta may not be aware of her nutritional needs this may be a cause of her current state rather than the problem that needs to be resolved.";
                    }
                }
                else if (phase6Part02Selection10Selected)
                {
                    phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta is underweight there are other problems relating directly to food and nutrition that if resolved will also improve Marta’s weight.";
                    if (phase6Part02Selection11Selected)
                    {
                        phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta may not be aware of her nutritional needs this may be a cause of her current state rather than the problem that needs to be resolved.";
                    }
                }
                else if (phase6Part02Selection11Selected)
                {
                    phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta may not be aware of her nutritional needs this may be a cause of her current state rather than the problem that needs to be resolved.";
                }
            }
            else if (phase6Part02Selection07Selected)
            {
                phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + "Carbohydrate is not the only macronutrient that Marta is lacking in and in this particular case there are other problems that would take priority.";
                Phase06Part01AlertMessageToggle();
                if (phase6Part02Selection08Selected)
                {
                    phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta is not having enough calcium rich foods in her diet she is taking a calcium supplement which helps her to achieve her requirements. This problem therefore has a lower priority.";
                    if (phase6Part02Selection10Selected)
                    {
                        phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta is underweight there are other problems relating directly to food and nutrition that if resolved will also improve Marta’s weight.";
                    }
                    else if (phase6Part02Selection11Selected)
                    {
                        phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta may not be aware of her nutritional needs this may be a cause of her current state rather than the problem that needs to be resolved.";
                    }
                }
                else if (phase6Part02Selection10Selected)
                {
                    phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta is underweight there are other problems relating directly to food and nutrition that if resolved will also improve Marta’s weight.";
                    if (phase6Part02Selection11Selected)
                    {
                        phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta may not be aware of her nutritional needs this may be a cause of her current state rather than the problem that needs to be resolved.";
                    }
                }
                else if (phase6Part02Selection11Selected)
                {
                    phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta may not be aware of her nutritional needs this may be a cause of her current state rather than the problem that needs to be resolved.";
                }
            }
            else if (phase6Part02Selection08Selected)
            {
                phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + "Although Marta is not having enough calcium rich foods in her diet she is taking a calcium supplement which helps her to achieve her requirements. This problem therefore has a lower priority.";
                Phase06Part01AlertMessageToggle();
                if (phase6Part02Selection10Selected)
                {
                    phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta is underweight there are other problems relating directly to food and nutrition that if resolved will also improve Marta’s weight.";
                    if (phase6Part02Selection11Selected)
                    {
                        phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta may not be aware of her nutritional needs this may be a cause of her current state rather than the problem that needs to be resolved.";
                    }
                }
                else if (phase6Part02Selection11Selected)
                {
                    phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta may not be aware of her nutritional needs this may be a cause of her current state rather than the problem that needs to be resolved.";
                }
            }
            else if (phase6Part02Selection10Selected)
            {
                phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + "Although Marta is underweight there are other problems relating directly to food and nutrition that if resolved will also improve Marta’s weight.";
                Phase06Part01AlertMessageToggle();
                if (phase6Part02Selection11Selected)
                {
                    phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + " Although Marta may not be aware of her nutritional needs this may be a cause of her current state rather than the problem that needs to be resolved.";
                }
            }
            else if (phase6Part02Selection01Selected)
            {
                phase6part01AlertMessageText.text = "Although Marta has problems with her fibre intake, there are more pressing issues to be resolved.";
                Phase06Part01AlertMessageToggle();
            }
            else
            {
                Phase6Part02Group.SetTrigger("AnimateOut");
                Phase6Part03Group.SetTrigger("AnimateIn");
                foreach (GameObject phase6Part02GameObject in Phase6PartTwoToThreeSelectionGameObjectArray)
                {
                    phase6Part02GameObject.SetActive(true);
                    Transform currentTransform = Phase6PartThreeSelectionTransforms[Phase6Part02CurrentTransformInt];
                    phase6Part02GameObject.transform.position = new Vector2(currentTransform.position.x, currentTransform.position.y);
                    Phase6Part02CurrentTransformInt++;
                    Debug.Log(Phase6Part02CurrentTransformInt + " " + currentTransform);
                }
                phase6Part02Complete = true;
                phase6part01AlertMessageText.text = "";
            }
        }
        else
        {
            phase6part01AlertMessageText.text = "Please select at least one potential issue before continuing. If the one you want is not available press the restart button to select again.";
            Phase06Part01AlertMessageToggle();
        }

    }

    public void Phase06Part03NewCompleteCheck()
    {
        phase6part01AlertMessageText.text = "";
        if (Phase06Part03IncorrectCauseSelectedStringArray.Count() > 0)
        {
            foreach (string incorrectCause in Phase06Part03IncorrectCauseSelectedStringArray)
            {
                phase6part01AlertMessageText.text = phase6part01AlertMessageText.text + incorrectCause + "\n";
            }
            phase6part01AlertMessageText.text = "Please select different causes as these causes are not valid:\n\n" + phase6part01AlertMessageText.text;
            Phase06Part01AlertMessageToggle();
        }
        else
        {
            if (Phase06Part03CausesStringArray.Count > 0)
            {
                foreach (string cause in Phase06Part03CausesStringArray)
                {
                    phase06CausesString = phase06CausesString + cause + "\n";
                }
                phase6Part03Complete = true;
                Phase6Part03Group.SetTrigger("AnimateOut");
                Phase6Part04Group.SetTrigger("AnimateIn");
            }
            else
            {
                phase6part01AlertMessageText.text = "Please select at least one cause before continuing.";
                Phase06Part01AlertMessageToggle();
            }
        }
    }

    public void Phase07Part03CompleteCheck()
    {
        foreach (GameObject dropZone in Phase07Part03DropZoneArray)
        {
            if (dropZone.GetComponent<DropZonePhase07>() != null)
            {
                if (!dropZone.GetComponent<DropZonePhase07>().dropZoneComplete)
                {
                    Phase07Part03Part01Complete = false;
                    phase07GoalsIncorrectScore++;
                }
                else
                {
                    Phase07Part03Part01Complete = true;
                }
            }
            else if (dropZone.GetComponent<DropZonePhase07EducationalStrategy>() != null)
            {
                if (!dropZone.GetComponent<DropZonePhase07EducationalStrategy>().dropZoneComplete)
                {
                    Phase07Part03Part02Complete = false;
                    phase07GoalsIncorrectScore++;
                }
                else
                {
                    Phase07Part03Part02Complete = true;
                }
            }
        }
        if (!Phase07Part03Part01Complete)
        {
            phase6part01AlertMessageText.text = "You have not provided all of the strategies for the goals, please go back and try again.";
            Phase06Part01AlertMessageToggle();
        }
        else if (!Phase07Part03Part02Complete)
        {
            phase6part01AlertMessageText.text = "You have provided all the food stategies, but still need to provide the educational strategies.";
            Phase06Part01AlertMessageToggle();
        }
        else if (Phase07Part03Part01Complete && Phase07Part03Part02Complete)
        {
            string foodRelatedStrategies = "";
            string educationalRelatedStrategies = "";
            foreach (string stringItem in phase07FoodStrategyStringArray)
            {
                foodRelatedStrategies = foodRelatedStrategies + "\n" + stringItem;
            }
            foreach (string eduStringItem in phase07EducationalStrategyStringArray)
            {
                educationalRelatedStrategies = educationalRelatedStrategies + "\n" + eduStringItem;
            }
            foreach (string stringText in Phase07SelectionText)
            {
                Phase07ClinpadSavedText.text = Phase07ClinpadSavedText.text + stringText;
            }
            phase02CombinedScore = phase2MedicationIncorrectSelectedScore + Phase2SelectWrongAnswerBiochemicalScore + Phase2WhySelectWrongAnswerBiochemicalScore + Phase2SelectWrongAnswerMedicalHistoryScore;
            if (phase02CombinedScore < 3)
            {
                Phase08Phase02ResultText.text = "You demonstrated the ability to distinguish between relevant and irrelevant as well as important and unimportant nutrition information.";
            }
            else if (phase02CombinedScore > 2 && phase02CombinedScore < 6)
            {
                Phase08Phase02ResultText.text = "You mostly demonstrated the ability to distinguish between relevant and irrelevant as well as important and unimportant nutrition information.";
            }
            else if (phase02CombinedScore > 5)
            {
                Phase08Phase02ResultText.text = "You mostly failed to demonstrate the ability to distinguish between relevant and irrelevant as well as important and unimportant nutrition information.";
            }
            if (phase07Part02SelectedAmount > 1)
            {
                phase07SelectionsScore = phase07SelectionsScore / 2;
            }
            if (phase07SelectionsScore < 3 && phase07SelectionsScore > 1)
            {
                phase07SelectionRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
                Phase08Phase07ResultText.text = "You identified some of the most important goals to address Marta's key nutrition problems.";
            }
            else if (phase07SelectionsScore <= 1)
            {
                phase07SelectionRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 2;
                Phase08Phase07ResultText.text = "You failed to indentify the most important goals to address Marta's key nutrition problems.";
            }
            else if (phase07SelectionsScore >= 3)
            {
                Phase08Phase07ResultText.text = "You identified the most important goals to address Marta's key nutrition problems.";
            }
            phase04Phase05CombinedScore = phase04Phase05CombinedScore + phase05EnergyActualDietIncorrectScore + phase05BodyWeightIncorrectScore + phase05QualatativeDietIncorrectScore + phase05QuantatativeDietIncorrectScore;
            if (phase04Phase05CombinedScore > 3)
            {
                Phase08Phase04Phase05ResultText.text = "You failed to demonstrate the ability to draw appropriate interpretations from your analysis linking to Marta's individualised needs.";
            }
            else if (phase04Phase05CombinedScore > 1 && phase04Phase05CombinedScore < 4)
            {
                Phase08Phase04Phase05ResultText.text = "You managed to demonstrate the ability to draw appropriate interpretations from your analysis linking to Marta's individualised needs with some errors in some sections.";
            }
            else if (phase04Phase05CombinedScore < 2)
            {
                Phase08Phase04Phase05ResultText.text = "You flawlessly demonstrated the ability to draw appropriate interpretations from your analysis linking to Marta's individualised needs.";
            }
            Phase07ClinpadSavedText.text = "Goals: " + Phase07ClinpadSavedText.text + "\n Food related strategies: " + foodRelatedStrategies + "\n Educational related strategies: " + educationalRelatedStrategies;
            phase07Part04MessageAlertText.text = Phase07ClinpadSavedText.text;
            Phase07Part04AlertMessageToggle();
            Phase7ConversationTracker = 100;
            if (Phase6Part02SelectedAmount > 1)
            {
                phase06part02CombinedScore = phase06part02CombinedScore / 2;
            }
            if (phase06part02CombinedScore == 1)
            {
                phase06Part01PlayerRating = playerRatingIntermediate;
            }
            else if (phase06part02CombinedScore == 2)
            {
                phase06Part01PlayerRating = playerRatingNovice;
            }
            phase06part02CombinedScore = phase06EvidenceIncorrectScore + phase06part02CombinedScore;
            if (phase06part02CombinedScore > 3)
            {
                Phase08Phase06ResultText.text = "Your nutrition problem/s did not reflect an appropriate interpretation or prioritisation of Marta's assessment data.";
            }
            else if (phase06part02CombinedScore < 4 && phase06part02CombinedScore > 1)
            {
                Phase08Phase06ResultText.text = "Your nutrition problem/s somewhat reflect an appropriate interpretation or prioritisation of Marta's assessment data.";
            }
            else if (phase06part02CombinedScore < 2)
            {
                Phase08Phase06ResultText.text = "Your nutrition problem/s accurately reflects an appropriate interpretation or prioritisation of Marta's assessment data.";
            }
            if (phase07EducationalStartegiesSelectionScore == 1)
            {
                phase07EducationalStrategiesRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (phase07EducationalStartegiesSelectionScore > 1)
            {
                phase07EducationalStrategiesRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 2;
            }
            if (phase07Part02SelectedAmount > 1)
            {
                phase07StrategiesScore = phase07StrategiesScore / 2;
            }
            if (phase07StrategiesScore > 0 && phase07StrategiesScore < 1)
            {
                phase07FoodStrategiesRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (phase07StrategiesScore > 0.99f)
            {
                phase07FoodStrategiesRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 2;
            }
            float phase07CombinedScore = phase07StrategiesScore + phase07EducationalStartegiesSelectionScore - phase07SelectionsScore;
            if (phase07CombinedScore > 4)
            {
                Phase08Phase08ResultText.text = "You did not demonstrate following a patient centered approach in your chosen dietary strategies.";
            }
            else if (phase07CombinedScore > 2 && phase07CombinedScore < 5)
            {
                Phase08Phase08ResultText.text = "You demonstrated following a patient-centered approach in some, but not all, of your chosen dietary strategies.";
            }
            else if (phase07CombinedScore < 3)
            {
                Phase08Phase08ResultText.text = "You demonstrated following a patient-centered approach in all of your chosen dietary strategies.";
            }
            if (phase08OverallScore > 14)
            {
                Phase08OverallResultsText.text = playerRatingNovice;
                phase08OverallGoalPlayerRating = playerRatingNovice;
                Phase08OverallSuggestionText.text = "Please Play Again";
            }
            else if (phase08OverallScore > 9 && phase08OverallScore < 15)
            {
                Phase08OverallResultsText.text = playerRatingIntermediate;
                phase08OverallGoalPlayerRating = playerRatingIntermediate;
                Phase08OverallSuggestionText.text = "Please Play Again";
            }
            else if (phase08OverallScore < 10)
            {
                Phase08OverallResultsText.text = playerRatingAdvancing;
                Phase08OverallSuggestionText.text = "Well Done";
            }
        }
    }

    public void Phase06Part04CompleteCheck()
    {
        foreach (GameObject dropZone in Phase6PartThreeDropZonesArray)
        {
            if (!dropZone.GetComponent<DropZone>().dropZoneComplete)
            {
                phase6Part04Complete = false;
                phase06EvidenceIncorrectScore++;
            }
            else
            {
                phase6Part04Complete = true;
                if (phase06part02PotentialIssue02String == "")
                {
                    Phase06EndText.text = "Based on your selection, you have identified the following nutrition problem and their evidence, as well as potential causes for the problem:\n" + phase06part02PotentialIssue01String + ", supported by evidence of " + phase06part03Evidence01String + "\r\nPotential causes include: " + phase06CausesString;
                }
                else if (phase06part02PotentialIssue02String != "" && phase06part02PotentialIssue03String == "")
                {
                    Phase06EndText.text = "Based on your selection, you have identified the following nutrition problems and their evidence, as well as potential causes for the problems:\n" + phase06part02PotentialIssue01String + ", supported by evidence of " + phase06part03Evidence01String + ".\r\n" + phase06part02PotentialIssue02String + ", supported by evidence of " + phase06part03Evidence02String + ".\r\n Potential causes include: " + phase06CausesString;
                }
                else if (phase06part02PotentialIssue03String != "")
                {
                    Phase06EndText.text = "Based on your selection, you have identified the following nutrition problems and their evidence, as well as potential causes for the problems:\n" + phase06part02PotentialIssue01String + ", supported by evidence of " + phase06part03Evidence01String + ".\r\n" + phase06part02PotentialIssue01String + ", supported by evidence of " + phase06part03Evidence01String + ".\n" + phase06part02PotentialIssue02String + ", supported by evidence of " + phase06part03Evidence02String + ".\r\n\n Potential causes include: " + phase06CausesString;
                }
                Phase06ClinpadSavedText.text = Phase06EndText.text;
            }
        }
        if (!phase6Part04Complete)
        {
            phase6part01AlertMessageText.text = "You have not provided all of the evidence for your chosen problems, please go back and try again.";
            Phase06Part01AlertMessageToggle();
        }
        else
        {
            if (phase06EvidenceIncorrectScore == 3)
            {
                phase06EvidencePlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (phase06EvidenceIncorrectScore > 3)
            {
                phase06EvidencePlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 2;
            }
            foreach (GameObject phase6Part04GameObject in Phase6PartThreeToFourSelectionGameObjectArray)
            {
                phase6Part04GameObject.SetActive(true);
                Transform currentTransform = Phase6PartTwoSelectionTransforms[Phase6Part04CurrentTransformInt];
                phase6Part04GameObject.transform.position = new Vector2(currentTransform.position.x, currentTransform.position.y);
                Phase6Part04CurrentTransformInt++;
            }
            if (phase6Part02Selection01Selected)
            {
                phase7DietaryStrategies02OptionSelected = true;
            }
            if (phase6Part02Selection02Selected)
            {
                phase7DietaryStrategies03OptionSelected = true;
            }
            if (phase6Part02Selection03Selected)
            {
                phase7DietaryStrategies01OptionSelected = true;
            }
            if (phase6Part02Selection04Selected)
            {
                phase7DietaryStrategies01OptionSelected = true;
            }
            if (phase6Part02Selection05Selected)
            {
                phase7DietaryStrategies01OptionSelected = true;
            }
            if (phase6Part02Selection11Selected)
            {
                phase7DietaryStrategies01OptionSelected = true;
            }

            Phase06Part04AlertMessageToggle();
        }
    }

    public void Phase06Part04CompleteCheckPartTwo()
    {
        Phase06Part04AlertMessageToggle();
        Phase6Part04Group.SetTrigger("AnimateOut");
        Phase6Part05Group.SetTrigger("AnimateIn");
    }

    public void Phase06Part04ResetChoices()
    {
        Phase06Part04AlertMessageToggle();
        phase6Part01Selection01Selected = false;
        phase6Part01Selection02Selected = false;
        phase6Part01Selection03Selected = false;
        phase6Part01Selection04Selected = false;
        phase6Part01Selection05Selected = false;
        phase6Part01Selection06Selected = false;
        phase6Part01Selection07Selected = false;
        phase6Part01Selection08Selected = false;
        phase6Part01Selection09Selected = false;
        phase6Part01Selection10Selected = false;
        phase6Part01Selection11Selected = false;
        phase6Part01Selection12Selected = false;
        phase6Part01Selection13Selected = false;
        phase6Part01Selection14Selected = false;
        phase6Part01Selection15Selected = false;
        phase6Part02Selection01Selected = false;
        phase6Part02Selection02Selected = false;
        phase6Part02Selection03Selected = false;
        phase6Part02Selection04Selected = false;
        phase6Part02Selection05Selected = false;
        phase6Part02Selection06Selected = false;
        phase6Part02Selection07Selected = false;
        phase6Part02Selection08Selected = false;
        phase6Part02Selection09Selected = false;
        phase6Part02Selection10Selected = false;
        phase6Part02Selection11Selected = false;
        phase6Part03Selection01Selected = false;
        phase6Part03Selection02Selected = false;
        phase6Part03Selection03Selected = false;
        phase6Part03Selection04Selected = false;
        phase6Part03Selection05Selected = false;
        phase6Part03Selection06Selected = false;
        phase6Part03Selection07Selected = false;
        phase6Part01Selection01SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection02SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection03SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection04SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection05SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection06SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection07SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection08SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection09SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection10SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection11SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection12SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection13SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection14SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part01Selection15SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection01SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection02SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection03SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection04SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection05SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection06SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection07SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection08SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection09SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection10SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part02Selection11SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part03Selection01SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part03Selection02SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part03Selection03SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part03Selection04SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part03Selection05SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part03Selection06SelectImage.sprite = Phase6DeselectedOptionSprite;
        phase6Part03Selection07SelectImage.sprite = Phase6DeselectedOptionSprite;
        Phase6Part01SelectedAmount = 0;
        Phase6Part02SelectedAmount = 0;
        phase06Part03SelectedAmount = 0;
        Phase6Part04Group.SetTrigger("AnimateOut");
        Phase6Part01Group.SetTrigger("AnimateIn");
        phase6part01AlertMessageText.text = "";
        Phase07Part03DropZoneArray.Clear();
        Phase07NutritionGoal01.SetActive(false);
        Phase07NutritionGoal02.SetActive(false);
        Phase07NutritionGoal03.SetActive(false);
        Phase07NutritionGoal04.SetActive(false);
        Phase07NutritionGoal05.SetActive(false);
        Phase07NutritionGoal06.SetActive(false);
        foreach (GameObject item in Phase07Selection01Group)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in Phase07Selection02Group)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in Phase07Selection03Group)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in Phase07Selection04Group)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in Phase07Selection05Group)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in Phase07Selection06Group)
        {
            item.SetActive(false);
        }
        foreach (GameObject phase6Part01GameObject in Phase6PartOneToTwoSelectionGameObjectArray)
        {
            phase6Part01GameObject.SetActive(false);
        }
        foreach (GameObject phase6Part02GameObject in Phase6PartTwoToThreeSelectionGameObjectArray)
        {
            phase6Part02GameObject.SetActive(false);
        }
        Phase06Part03IncorrectCauseSelectedStringArray.Clear();
        Phase6PartThreeToFourSelectionGameObjectArray.Clear();
        Phase6PartOneToTwoSelectionGameObjectArray.Clear();
        Phase6PartTwoToThreeSelectionGameObjectArray.Clear();
        Phase06Part03CausesStringArray.Clear();
        Phase6Part01CurrentTransformInt = 0;
        Phase6Part02CurrentTransformInt = 0;
        phase06part03Evidence01String = "";
        phase06part03Evidence02String = "";
        phase06part03Evidence03String = "";
        phase06part02PotentialIssue01String = "";
        phase06part02PotentialIssue02String = "";
        phase06part02PotentialIssue03String = "";
        phase06CausesString = "";
        phase6Part01Complete = false;
        phase6Part02Complete = false;
        phase6Part03Complete = false;
        phase6Part04Complete = false;
    }

    public void Phase06Part04CompleteCheckStage01()
    {
        if (Phase6Part04SelectedAmount > 0)
        {
            Phase06Part04AlertMessageToggle();
        }
        else
        {
            phase6part01AlertMessageText.text = "Please select up to two (2) choices before continuing on. Once you have made your selection press the  <b><color=#54A4CCFF>CHECK</color></b>  button to continue.";
            Phase06Part01AlertMessageToggle();
        }
    }

    public void Phase06Part04CompleteCheckStage02()
    {
        Phase06Part04AlertMessageToggle();
        phase6Part04Complete = true;
        Phase6Part04Group.SetTrigger("AnimateOut");
        Phase6Part05Group.SetTrigger("AnimateIn");
    }

    public void Phase07Part02Select01()
    {
        if (!phase07Part02Selection01Selected)
        {
            if (phase07Part02SelectedAmount < 2)
            {
                phase07Part02SelectImage01.sprite = BiochemicalCorrectAnswerSelectedSprite;
                foreach (GameObject item in Phase07Selection01Group)
                {
                    item.SetActive(true);
                }
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone01);
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone08);
                Phase07SelectionText.Add("Increase total energy intake. ");
                phase07Part02SelectedAmount++;
                phase07Part02Selection01Selected = true;
                phase07SelectionsScore = phase07SelectionsScore + 2;
            }
            else if (phase07Part02SelectedAmount > 1)
            {
                phase6part01AlertMessageText.text = "Only selected your top 2 choices, if you are happy with your selections press confirm to move to the next section.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else if (phase07Part02Selection01Selected)
        {
            phase07Part02SelectImage01.sprite = Phase6DeselectedOptionSprite;
            foreach (GameObject item in Phase07Selection01Group)
            {
                item.SetActive(false);
            }
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone01);
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone08);
            Phase07SelectionText.Remove("Increase total energy intake. ");
            phase07Part02SelectedAmount--;
            phase07Part02Selection01Selected = false;
            phase07SelectionsScore = phase07SelectionsScore - 2;
        }
    }

    public void Phase07Part02Select02()
    {
        if (!phase07Part02Selection02Selected)
        {
            if (phase07Part02SelectedAmount < 2)
            {
                phase07Part02SelectImage02.sprite = BiochemicalCorrectAnswerSelectedSprite;
                foreach (GameObject item in Phase07Selection02Group)
                {
                    item.SetActive(true);
                }
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone02);
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone09);
                Phase07SelectionText.Add("Increase dietary protein intake. ");
                phase07Part02SelectedAmount++;
                phase07Part02Selection02Selected = true;
                phase07SelectionsScore = phase07SelectionsScore + 2;
            }
            else if (phase07Part02SelectedAmount > 1)
            {
                phase6part01AlertMessageText.text = "Only selected your top 2 choices, if you are happy with your selections press confirm to move to the next section.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else if (phase07Part02Selection02Selected)
        {
            phase07Part02SelectImage02.sprite = Phase6DeselectedOptionSprite;
            foreach (GameObject item in Phase07Selection02Group)
            {
                item.SetActive(false);
            }
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone02);
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone09);
            Phase07SelectionText.Remove("Increase dietary protein intake. ");
            phase07Part02Selection02Selected = false;
            phase07Part02SelectedAmount--;
            phase07SelectionsScore = phase07SelectionsScore - 2;
        }
    }

    public void Phase07Part02Select03()
    {
        if (!phase07Part02Selection03Selected)
        {
            if (phase07Part02SelectedAmount < 2)
            {
                phase07Part02SelectImage03.sprite = BiochemicalCorrectAnswerSelectedSprite;
                foreach (GameObject item in Phase07Selection03Group)
                {
                    item.SetActive(true);
                }
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone03);
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone10);
                Phase07SelectionText.Add("Increase total energy and dietary protein intake. ");
                phase07Part02Selection03Selected = true;
                phase07Part02SelectedAmount++;
                phase07SelectionsScore = phase07SelectionsScore + 3;
            }
            else if (phase07Part02SelectedAmount > 1)
            {
                phase6part01AlertMessageText.text = "Only selected your top 2 choices, if you are happy with your selections press confirm to move to the next section.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else if (phase07Part02Selection03Selected)
        {
            phase07Part02SelectImage03.sprite = Phase6DeselectedOptionSprite;
            foreach (GameObject item in Phase07Selection03Group)
            {
                item.SetActive(false);
            }
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone03);
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone10);
            Phase07SelectionText.Remove("Increase total energy and dietary protein intake. ");
            phase07Part02Selection03Selected = false;
            phase07Part02SelectedAmount--;
            phase07SelectionsScore = phase07SelectionsScore - 3;
        }
    }

    public void Phase07Part02Select04()
    {
        if (!phase07Part02Selection04Selected)
        {
            if (phase07Part02SelectedAmount < 2)
            {
                phase07Part02SelectImage04.sprite = BiochemicalCorrectAnswerSelectedSprite;
                foreach (GameObject item in Phase07Selection04Group)
                {
                    item.SetActive(true);
                }
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone04);
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone11);
                Phase07SelectionText.Add("Increase fluid intake. ");
                phase07Part02Selection04Selected = true;
                phase07Part02SelectedAmount++;
                phase07SelectionsScore = phase07SelectionsScore + 3;
            }
            else if (phase07Part02SelectedAmount > 1)
            {
                phase6part01AlertMessageText.text = "Only selected your top 2 choices, if you are happy with your selections press confirm to move to the next section.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else if (phase07Part02Selection04Selected)
        {
            phase07Part02SelectImage04.sprite = Phase6DeselectedOptionSprite;
            foreach (GameObject item in Phase07Selection04Group)
            {
                item.SetActive(false);
            }
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone04);
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone11);
            Phase07SelectionText.Remove("Increase fluid intake. ");
            phase07Part02Selection04Selected = false;
            phase07Part02SelectedAmount--;
            phase07SelectionsScore = phase07SelectionsScore - 3;
        }
    }

    public void Phase07Part02Select05()
    {
        if (!phase07Part02Selection05Selected)
        {
            if (phase07Part02SelectedAmount < 2)
            {
                phase07Part02SelectImage05.sprite = BiochemicalCorrectAnswerSelectedSprite;
                foreach (GameObject item in Phase07Selection05Group)
                {
                    item.SetActive(true);
                }
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone05);
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone12);
                Phase07SelectionText.Add("Minimize nutrition impact symptoms to improve oral intake. ");
                phase07Part02Selection05Selected = true;
                phase07Part02SelectedAmount++;
                phase07SelectionsScore = phase07SelectionsScore + 2;
            }
            else if (phase07Part02SelectedAmount > 1)
            {
                phase6part01AlertMessageText.text = "Only selected your top 2 choices, if you are happy with your selections press confirm to move to the next section.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else if (phase07Part02Selection05Selected)
        {
            phase07Part02SelectImage05.sprite = Phase6DeselectedOptionSprite;
            foreach (GameObject item in Phase07Selection05Group)
            {
                item.SetActive(false);
            }
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone05);
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone12);
            Phase07SelectionText.Remove("Minimize nutrition impact symptoms to improve oral intake. ");
            phase07Part02Selection05Selected = false;
            phase07Part02SelectedAmount--;
            phase07SelectionsScore = phase07SelectionsScore - 2;
        }
    }

    public void Phase07Part02Select06()
    {
        if (!phase07Part02Selection06Selected)
        {
            if (phase07Part02SelectedAmount < 2)
            {
                phase07Part02SelectImage06.sprite = BiochemicalCorrectAnswerSelectedSprite;
                foreach (GameObject item in Phase07Selection06Group)
                {
                    item.SetActive(true);
                }
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone06);
                Phase07Part03DropZoneArray.Add(Phase07Part03DropZone13);
                Phase07SelectionText.Add("Assist with improved self-feeding ability. ");
                phase07Part02Selection06Selected = true;
                phase07Part02SelectedAmount++;
                phase07SelectionsScore = phase07SelectionsScore + 1;
            }
            else if (phase07Part02SelectedAmount > 1)
            {
                phase6part01AlertMessageText.text = "Only selected your top 2 choices, if you are happy with your selections press confirm to move to the next section.";
                Phase06Part01AlertMessageToggle();
            }
        }
        else if (phase07Part02Selection06Selected)
        {
            phase07Part02SelectImage06.sprite = Phase6DeselectedOptionSprite;
            foreach (GameObject item in Phase07Selection06Group)
            {
                item.SetActive(false);
            }
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone06);
            Phase07Part03DropZoneArray.Remove(Phase07Part03DropZone13);
            Phase07SelectionText.Remove("Assist with improved self-feeding ability. ");
            phase07Part02Selection06Selected = false;
            phase07Part02SelectedAmount--;
            phase07SelectionsScore = phase07SelectionsScore - 1;
        }
    }

    public void BiochemicalCorrectAnswer01Selected()
    {
        if (!Phase2BiochemicalAnswer01HasBeenSelected)
        {
            BiochemicalRightAnswer01SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
            Phase2BiochemicalAnswerSelected += 1;
            Phase2ComputerBiochemicalAnswersSelected += 1;
            Phase2BiochemicalAnswer01HasBeenSelected = true;
            if (Phase2ComputerBiochemicalAnswersSelected >= 2)
            {
                BiochemicalCorrectAnswerSelectedToggle();
            }
        }
    }

    public void BiochemicalCorrectAnswer02Selected()
    {
        if (!Phase2BiochemicalAnswer02HasBeenSelected)
        {
            BiochemicalRightAnswer02SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
            Phase2BiochemicalAnswerSelected += 1;
            Phase2ComputerBiochemicalAnswersSelected += 1;
            Phase2BiochemicalAnswer02HasBeenSelected = true;
            if (Phase2ComputerBiochemicalAnswersSelected >= 2)
            {
                BiochemicalCorrectAnswerSelectedToggle();
                ComputerSceneBackButton.SetActive(false);
            }
        }
    }

    public void BiochemicalCorrectAnswer03Selected()
    {
        if (!Phase2BiochemicalAnswer03HasBeenSelected)
        {
            Phase2BiochemicalAnswerSelected += 1;
            biochemicalCorrectAnswer01Text.SetActive(true);
            phase2BiochemicalProgressFillImage.fillAmount = Phase2BiochemicalAnswerSelected / Phase2BiochemicalAnswerTotal;
            Phase2BiochemicalAnswer03HasBeenSelected = true;
        }
    }

    public void BiochemicalCorrectAnswer04Selected()
    {
        if (!Phase2BiochemicalAnswer04HasBeenSelected)
        {
            Phase2BiochemicalAnswerSelected += 1;
            biochemicalCorrectAnswer02Text.SetActive(true);
            phase2BiochemicalProgressFillImage.fillAmount = Phase2BiochemicalAnswerSelected / Phase2BiochemicalAnswerTotal;
            Phase2BiochemicalAnswer04HasBeenSelected = true;
        }
    }

    public void BiochemicalWhyCorrectAnswerPopUpToggle()
    {
        biochemicalWhyCorrectAnswerAnim.SetBool("MenuActivated", false);
        biochemicalWhyCorrectAnswerAnim.SetBool("MenuDeactivated", true);
    }

    public void BiochemicalWhyCorrectAnswer01Selected()
    {
        if (!Phase2BiochemicalWhyAnswerHasBeenSelected)
        {
            Phase2BiochemicalWhyAnswerSelected += 1;
            BiochemicalWhyAnswerAnim.SetBool("MenuActivated", false);
            biochemicalWhyCorrectAnswerAnim.SetBool("MenuDefault", false);
            biochemicalWhyCorrectAnswerAnim.SetBool("MenuActivated", true);
            NotesComputerGroup.SetActive(true);
            Phase2BiochemicalWhyAnswerHasBeenSelected = true;
            Phase2BiochemicalClinpadText01.SetActive(true);
            Phase2BiochemicalClinpadText02.SetActive(true);
            phase2BiochemicalProgressFillImage.fillAmount = Phase2BiochemicalAnswerSelected / Phase2BiochemicalAnswerTotal;
            notificationGoodSource.Play();
        }
    }

    public void BiochemicalIncorrectAnswer01Selected()
    {
        if (!Phase2BiochemicalWrongAnswer01HasBeenSelected)
        {
            Phase2SelectWrongAnswerBiochemicalScore += 1;
            if (Phase2SelectWrongAnswerBiochemicalScore <= 1)
            {
                HintText.text = "This is incorrect, reconsider your option.";
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore >= 2)
            {
                HintText.text = "This is incorrect, carefully consider which parameters will be influenced by the nutritional intervention.";
            }
            if (Phase2SelectWrongAnswerBiochemicalScore == 1)
            {
                phase02BiochemicalPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore > 1)
            {
                phase02BiochemicalPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            BiochemicalWrongAnswer01SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            Phase2BiochemicalWrongAnswer01HasBeenSelected = true;

        }
    }

    public void BiochemicalIncorrectAnswer02Selected()
    {
        if (!Phase2BiochemicalWrongAnswer02HasBeenSelected)
        {
            Phase2SelectWrongAnswerBiochemicalScore += 1;
            if (Phase2SelectWrongAnswerBiochemicalScore <= 1)
            {
                HintText.text = "This is incorrect, reconsider your option.";
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore >= 2)
            {
                HintText.text = "This is incorrect, carefully consider which parameters will be influenced by the nutritional intervention.";
            }
            if (Phase2SelectWrongAnswerBiochemicalScore == 1)
            {
                phase02BiochemicalPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore > 1)
            {
                phase02BiochemicalPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            BiochemicalWrongAnswer02SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            Phase2BiochemicalWrongAnswer02HasBeenSelected = true;
        }
    }

    public void BiochemicalIncorrectAnswer03Selected()
    {
        if (!Phase2BiochemicalWrongAnswer03HasBeenSelected)
        {
            Phase2SelectWrongAnswerBiochemicalScore += 1;
            if (Phase2SelectWrongAnswerBiochemicalScore <= 1)
            {
                HintText.text = "This is incorrect, reconsider your option.";
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore >= 2)
            {
                HintText.text = "This is incorrect, carefully consider which parameters will be influenced by the nutritional intervention.";
            }
            if (Phase2SelectWrongAnswerBiochemicalScore == 1)
            {
                phase02BiochemicalPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore > 1)
            {
                phase02BiochemicalPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            BiochemicalWrongAnswer03SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            Phase2BiochemicalWrongAnswer03HasBeenSelected = true;
        }
    }

    public void BiochemicalIncorrectAnswer04Selected()
    {
        if (!Phase2BiochemicalWrongAnswer04HasBeenSelected)
        {
            Phase2SelectWrongAnswerBiochemicalScore += 1;
            if (Phase2SelectWrongAnswerBiochemicalScore <= 1)
            {
                HintText.text = "This is incorrect, reconsider your option.";
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore >= 2)
            {
                HintText.text = "This is incorrect, carefully consider which parameters will be influenced by the nutritional intervention.";
            }
            if (Phase2SelectWrongAnswerBiochemicalScore == 1)
            {
                phase02BiochemicalPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore > 1)
            {
                phase02BiochemicalPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            BiochemicalWrongAnswer04SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            Phase2BiochemicalWrongAnswer04HasBeenSelected = true;
        }
    }

    public void BiochemicalIncorrectAnswer05Selected()
    {
        if (!Phase2BiochemicalWrongAnswer05HasBeenSelected)
        {
            Phase2SelectWrongAnswerBiochemicalScore += 1;
            if (Phase2SelectWrongAnswerBiochemicalScore <= 1)
            {
                HintText.text = "This is incorrect, reconsider your option.";
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore >= 2)
            {
                HintText.text = "This is incorrect, carefully consider which parameters will be influenced by the nutritional intervention.";
            }
            if (Phase2SelectWrongAnswerBiochemicalScore == 1)
            {
                phase02BiochemicalPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore > 1)
            {
                phase02BiochemicalPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            BiochemicalWrongAnswer05SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            Phase2BiochemicalWrongAnswer05HasBeenSelected = true;
        }
    }

    public void BiochemicalIncorrectAnswer06Selected()
    {
        if (!Phase2BiochemicalWrongAnswer06HasBeenSelected)
        {
            Phase2SelectWrongAnswerBiochemicalScore += 1;
            if (Phase2SelectWrongAnswerBiochemicalScore <= 1)
            {
                HintText.text = "This is incorrect, reconsider your option.";
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore >= 2)
            {
                HintText.text = "This is incorrect, carefully consider which parameters will be influenced by the nutritional intervention.";
            }
            if (Phase2SelectWrongAnswerBiochemicalScore == 1)
            {
                phase02BiochemicalPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore > 1)
            {
                phase02BiochemicalPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            BiochemicalWrongAnswer06SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            Phase2BiochemicalWrongAnswer06HasBeenSelected = true;
        }
    }

    public void BiochemicalIncorrectAnswer07Selected()
    {
        if (!Phase2BiochemicalWrongAnswer07HasBeenSelected)
        {
            Phase2SelectWrongAnswerBiochemicalScore += 1;
            if (Phase2SelectWrongAnswerBiochemicalScore <= 1)
            {
                HintText.text = "This is incorrect, reconsider your option.";
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore >= 2)
            {
                HintText.text = "This is incorrect, carefully consider which parameters will be influenced by the nutritional intervention.";
            }
            if (Phase2SelectWrongAnswerBiochemicalScore == 1)
            {
                phase02BiochemicalPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore > 1)
            {
                phase02BiochemicalPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            BiochemicalWrongAnswer07SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            Phase2BiochemicalWrongAnswer07HasBeenSelected = true;
        }
    }

    public void BiochemicalIncorrectAnswer08Selected()
    {
        if (!Phase2BiochemicalWrongAnswer08HasBeenSelected)
        {
            Phase2SelectWrongAnswerBiochemicalScore += 1;
            if (Phase2SelectWrongAnswerBiochemicalScore <= 1)
            {
                HintText.text = "This is incorrect, reconsider your option.";
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore >= 2)
            {
                HintText.text = "This is incorrect, carefully consider which parameters will be influenced by the nutritional intervention.";
            }
            if (Phase2SelectWrongAnswerBiochemicalScore == 1)
            {
                phase02BiochemicalPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerBiochemicalScore > 1)
            {
                phase02BiochemicalPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            BiochemicalWrongAnswer08SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            Phase2BiochemicalWrongAnswer08HasBeenSelected = true;
        }
    }

    public void BiochemicalWhyIncorrectAnswerSelected()
    {
        BiochemicalWhySelectionQuestionText.color = warningColour;
        BiochemicalWhySelectionQuestionText.text = "This is incorrect, carefully consider Marta's Medical History.";
        biochemicalWhyIncorrectAnswer01Selected = true;
        BiochemicalWhyIncorrectAnswer01Text.color = alreadySelectedColour;
        biochemicalWhyIncorrectAnswerSelectedScore += 1;
        if (biochemicalWhyIncorrectAnswerSelectedScore == 1)
        {
            phase02BiochemicalWhyPlayerRating = playerRatingIntermediate;
            phase08OverallScore = phase08OverallScore + 1;
        }
        else if (biochemicalWhyIncorrectAnswerSelectedScore > 1)
        {
            phase02BiochemicalWhyPlayerRating = playerRatingNovice;
            phase08OverallScore = phase08OverallScore + 1;
        }
    }

    public void BiochemicalWhyIncorrectAnswer02Selected()
    {

        BiochemicalWhySelectionQuestionText.color = warningColour;
        BiochemicalWhySelectionQuestionText.text = "This is incorrect, carefully consider Marta's Medical History ";
        biochemicalWhyIncorrectAnswer02Selected = true;
        BiochemicalWhyIncorrectAnswer02Text.color = alreadySelectedColour;
        biochemicalWhyIncorrectAnswerSelectedScore += 1;
        if (biochemicalWhyIncorrectAnswerSelectedScore == 1)
        {
            phase02BiochemicalWhyPlayerRating = playerRatingIntermediate;
            phase08OverallScore = phase08OverallScore + 1;
        }
        else if (biochemicalWhyIncorrectAnswerSelectedScore > 1)
        {
            phase02BiochemicalWhyPlayerRating = playerRatingNovice;
            phase08OverallScore = phase08OverallScore + 1;
        }
    }

    public void MedicationCorrectAnswer01Selected()
    {
        if (!Phase2MedicationAnswer01HasBeenSelected)
        {
            MedicationRightAnswer01SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
            MedicationAnswerOneText.text = "Correct Answer 1 Text";
            Phase2MedicationAnswerSelected += 1;
            Phase2MedicationAnswer01HasBeenSelected = true;
        }
    }

    public void MedicationCorrectAnswer02Selected()
    {
        if (!Phase2MedicationAnswer02HasBeenSelected)
        {
            MedicationRightAnswer02SelectImage.sprite = BiochemicalCorrectAnswerSelectedSprite;
            MedicationAnswerTwoText.text = "Correct Answer 2 Text";
            Phase2MedicationAnswerSelected += 1;
            Phase2MedicationAnswer02HasBeenSelected = true;
        }

    }

    public void MedicationIncorrectAnswer01Selected()
    {
        if (!Phase2MedicationWrongAnswer01HasBeenSelected)
        {
            HintText.text = "This is not the right answer, try the other thing please 01";
            Phase2SelectWrongAnswerMedicationScore += 1;
            MedicationWrongAnswer01SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            if (Phase2SelectWrongAnswerMedicationScore < 3)
            {
                MenuButton.isOn = true;
            }
            Phase2MedicationWrongAnswer01HasBeenSelected = true;
        }

    }

    public void MedicationIncorrectAnswer02Selected()
    {
        if (!Phase2MedicationWrongAnswer02HasBeenSelected)
        {
            HintText.text = "This is not the right answer, try the other thing please 02";
            Phase2SelectWrongAnswerMedicationScore += 1;
            MedicationWrongAnswer02SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            if (Phase2SelectWrongAnswerMedicationScore < 3)
            {
                MenuButton.isOn = true;
            }
            Phase2MedicationWrongAnswer02HasBeenSelected = true;
        }
    }

    public void MedicationIncorrectAnswer03Selected()
    {
        if (!Phase2MedicationWrongAnswer03HasBeenSelected)
        {
            HintText.text = "This is not the right answer, try the other thing please 03";
            Phase2SelectWrongAnswerMedicationScore += 1;
            MedicationWrongAnswer03SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            if (Phase2SelectWrongAnswerMedicationScore < 3)
            {
                MenuButton.isOn = true;
            }
            Phase2MedicationWrongAnswer03HasBeenSelected = true;
        }
    }

    public void MedicationIncorrectAnswer04Selected()
    {
        if (!Phase2MedicationWrongAnswer04HasBeenSelected)
        {
            HintText.text = "This is not the right answer, try the other thing please 04";
            Phase2SelectWrongAnswerMedicationScore += 1;
            MedicationWrongAnswer04SelectImage.sprite = BiochemicalIncorrectAnswerSelectedSprite;
            if (Phase2SelectWrongAnswerMedicationScore < 3)
            {
                MenuButton.isOn = true;
            }
            Phase2MedicationWrongAnswer04HasBeenSelected = true;
        }
    }

    public void ClientHistoryCorrectAnswer00()
    {
        if (!clientHistoryCorrectAnswerSelected00)
        {
            clientHistoryCorrectAnswer00Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected00 = true;
        }
    }

    public void PatientInformationCorrectAnswer01Selected()
    {
        if (!medicalHistoryAnswer01HasBeenSelected)
        {
            PatientInformationAnswerOneText.text = patientNameString;
            PatientInformationAge.SetActive(true);
            PatientInformationGender.SetActive(true);
            Phase2PatientHistoryCompleted = true;
            foreach (GameObject item in medicalHistoryNameReferences)
            {
                item.GetComponent<Text>().color = alreadySelectedDarkColour;
                item.GetComponent<Button>().interactable = false;
            }
            medicalHistoryAnswer01HasBeenSelected = true;
        }
    }

    public void ClientHistoryCorrectAnswer01()
    {
        if (!clientHistoryCorrectAnswerSelected01)
        {
            clientHistoryCorrectAnswer01Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected01 = true;
        }
    }

    public void ClientHistoryCorrectAnswer02()
    {
        if (!clientHistoryCorrectAnswerSelected02)
        {
            clientHistoryCorrectAnswer02Text.SetActive(true);
            clientHistoryCorrectAnswer03Text.SetActive(true);
            clientHistoryCorrectAnswer04Text.SetActive(true);
            clientHistoryCorrectAnswer05Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected02 = true;
        }
    }

    public void ClientHistoryCorrectAnswer03()
    {
        if (!clientHistoryCorrectAnswerSelected03)
        {
            clientHistoryCorrectAnswer06Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected03 = true;
        }
    }

    public void ClientHistoryCorrectAnswer04()
    {
        if (!clientHistoryCorrectAnswerSelected04)
        {
            clientHistoryCorrectAnswer07Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected04 = true;
        }
    }

    public void ClientHistoryCorrectAnswer05()
    {
        if (!clientHistoryCorrectAnswerSelected05)
        {
            clientHistoryCorrectAnswer08Text.SetActive(true);
            clientHistoryCorrectAnswer09Text.SetActive(true);
            clientHistoryCorrectAnswer10Text.SetActive(true);
            clientHistoryCorrectAnswer11Text.SetActive(true);
            clientHistoryCorrectAnswer12Text.SetActive(true);
            clientHistoryCorrectAnswer13Text.SetActive(true);
            clientHistoryCorrectAnswer14Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected05 = true;
        }
    }

    public void ClientHistoryCorrectAnswer06()
    {
        if (!clientHistoryCorrectAnswerSelected06)
        {
            clientHistoryCorrectAnswer15Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected06 = true;
        }
    }

    public void ClientHistoryCorrectAnswer07()
    {
        if (!clientHistoryCorrectAnswerSelected07)
        {
            clientHistoryCorrectAnswer16Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected07 = true;
        }
    }

    public void ClientHistoryCorrectAnswer08()
    {
        if (!clientHistoryCorrectAnswerSelected08)
        {
            clientHistoryCorrectAnswer17Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected08 = true;
        }
    }

    public void ClientHistoryCorrectAnswer09()
    {
        if (!clientHistoryCorrectAnswerSelected09)
        {
            clientHistoryCorrectAnswer18Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected09 = true;
        }
    }

    public void ClientHistoryCorrectAnswer10()
    {
        if (!clientHistoryCorrectAnswerSelected10)
        {
            clientHistoryCorrectAnswer19Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected10 = true;
        }
    }

    public void ClientHistoryCorrectAnswer11()
    {
        if (!clientHistoryCorrectAnswerSelected11)
        {
            clientHistoryCorrectAnswer20Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected11 = true;
        }
    }

    public void ClientHistoryCorrectAnswer12()
    {
        if (!clientHistoryCorrectAnswerSelected12)
        {
            clientHistoryCorrectAnswer21Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected12 = true;
        }
    }

    public void ClientHistoryCorrectAnswer13()
    {
        if (!clientHistoryCorrectAnswerSelected13)
        {
            clientHistoryCorrectAnswer22Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected13 = true;
        }
    }

    public void ClientHistoryCorrectAnswer14()
    {
        if (!clientHistoryCorrectAnswerSelected14)
        {
            clientHistoryCorrectAnswer23Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected14 = true;
        }
    }

    public void ClientHistoryCorrectAnswer15()
    {
        if (!clientHistoryCorrectAnswerSelected15)
        {
            clientHistoryCorrectAnswer24Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected15 = true;
        }
    }

    public void ClientHistoryCorrectAnswer16()
    {
        if (!clientHistoryCorrectAnswerSelected16)
        {
            clientHistoryCorrectAnswer25Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected16 = true;
        }
    }

    public void ClientHistoryCorrectAnswer17()
    {
        if (!clientHistoryCorrectAnswerSelected17)
        {
            clientHistoryCorrectAnswer26Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected17 = true;
        }
    }

    public void ClientHistoryCorrectAnswer18()
    {
        if (!clientHistoryCorrectAnswerSelected18)
        {
            clientHistoryCorrectAnswer27Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected18 = true;
        }
    }

    public void ClientHistoryCorrectAnswer19()
    {
        if (!clientHistoryCorrectAnswerSelected19)
        {
            clientHistoryCorrectAnswer27Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected19 = true;
        }
    }

    public void ClientHistoryCorrectAnswer20()
    {
        if (!clientHistoryCorrectAnswerSelected20)
        {
            clientHistoryCorrectAnswer28Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected20 = true;
        }
    }

    public void ClientHistoryCorrectAnswer21()
    {
        if (!clientHistoryCorrectAnswerSelected21)
        {
            clientHistoryCorrectAnswer29Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected21 = true;
        }
    }

    public void ClientHistoryCorrectAnswer22()
    {
        if (!clientHistoryCorrectAnswerSelected22)
        {
            clientHistoryCorrectAnswer30Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected22 = true;
        }
    }

    public void ClientHistoryCorrectAnswer23()
    {
        if (!clientHistoryCorrectAnswerSelected23)
        {
            clientHistoryCorrectAnswer31Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected23 = true;
        }
    }

    public void ClientHistoryCorrectAnswer24()
    {
        if (!clientHistoryCorrectAnswerSelected24)
        {
            clientHistoryCorrectAnswer32Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected24 = true;
        }
    }

    public void ClientHistoryCorrectAnswer25()
    {
        if (!clientHistoryCorrectAnswerSelected25)
        {
            clientHistoryCorrectAnswer33Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected25 = true;
        }
    }

    public void ClientHistoryCorrectAnswer26()
    {
        if (!clientHistoryCorrectAnswerSelected26)
        {
            clientHistoryCorrectAnswer34Text.SetActive(true);
            clientHistoryAnswersSelected += 1;
            phase2ClientHistoryProgressFillImage.fillAmount = clientHistoryAnswersSelected / Phase2ClientHistoryAnswerTotal;
            clientHistoryCorrectAnswerSelected26 = true;
        }
    }

    public void FoodAndNutritionCorrectAnswer01()
    {
        if (!foodAndNutritionCorrectAnswerSelected01)
        {
            foodAndNutritionCorrectAnswer01Text.SetActive(true);
            foodAndNutritionAnswersSelected += 1;
            phase2FoodAndNutritionProgressFillImage.fillAmount = foodAndNutritionAnswersSelected / Phase2FoodAndNutritionAnswerTotal;
            foodAndNutritionCorrectAnswerSelected01 = true;
        }
    }

    public void FoodAndNutritionCorrectAnswer02()
    {
        if (!foodAndNutritionCorrectAnswerSelected02)
        {
            foodAndNutritionCorrectAnswer02Text.SetActive(true);
            foodAndNutritionAnswersSelected += 1;
            phase2FoodAndNutritionProgressFillImage.fillAmount = foodAndNutritionAnswersSelected / Phase2FoodAndNutritionAnswerTotal;
            foodAndNutritionCorrectAnswerSelected02 = true;
        }
    }

    public void FoodAndNutritionCorrectAnswer03()
    {
        if (!foodAndNutritionCorrectAnswerSelected03)
        {
            foodAndNutritionCorrectAnswer03Text.SetActive(true);
            foodAndNutritionAnswersSelected += 1;
            phase2FoodAndNutritionProgressFillImage.fillAmount = foodAndNutritionAnswersSelected / Phase2FoodAndNutritionAnswerTotal;
            foodAndNutritionCorrectAnswerSelected03 = true;
        }
    }

    public void FoodAndNutritionCorrectAnswer04()
    {
        if (!foodAndNutritionCorrectAnswerSelected04)
        {
            foodAndNutritionCorrectAnswer04Text.SetActive(true);
            foodAndNutritionAnswersSelected += 1;
            phase2FoodAndNutritionProgressFillImage.fillAmount = foodAndNutritionAnswersSelected / Phase2FoodAndNutritionAnswerTotal;
            foodAndNutritionCorrectAnswerSelected04 = true;
        }
    }

    public void FoodAndNutritionCorrectAnswer05()
    {
        if (!foodAndNutritionCorrectAnswerSelected05)
        {
            foodAndNutritionCorrectAnswer05Text.SetActive(true);
            foodAndNutritionAnswersSelected += 1;
            phase2FoodAndNutritionProgressFillImage.fillAmount = foodAndNutritionAnswersSelected / Phase2FoodAndNutritionAnswerTotal;
            foodAndNutritionCorrectAnswerSelected05 = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer01Selected()
    {
        if (!medicalHistoryWrongAnswer01HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer01HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer02Selected()
    {
        if (!medicalHistoryWrongAnswer02HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer02HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer03Selected()
    {
        if (!medicalHistoryWrongAnswer03HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer03HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer04Selected()
    {
        if (!medicalHistoryWrongAnswer04HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer04HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer05Selected()
    {
        if (!medicalHistoryWrongAnswer05HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer05HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer06Selected()
    {
        if (!medicalHistoryWrongAnswer06HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer06HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer07Selected()
    {
        if (!medicalHistoryWrongAnswer07HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer07HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer07bSelected()
    {
        if (!medicalHistoryWrongAnswer07bHasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer07bHasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer07cSelected()
    {
        if (!medicalHistoryWrongAnswer07cHasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer07cHasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer08Selected()
    {
        if (!medicalHistoryWrongAnswer08HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer08HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer09Selected()
    {
        if (!medicalHistoryWrongAnswer09HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer09HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer10Selected()
    {
        if (!medicalHistoryWrongAnswer10HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer10HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer11Selected()
    {
        if (!medicalHistoryWrongAnswer11HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer11HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer12Selected()
    {
        if (!medicalHistoryWrongAnswer12HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer12HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer13Selected()
    {
        if (!medicalHistoryWrongAnswer13HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer13HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer14Selected()
    {
        if (!medicalHistoryWrongAnswer14HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer14HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer15Selected()
    {
        if (!medicalHistoryWrongAnswer15HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer15HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer16Selected()
    {
        if (!medicalHistoryWrongAnswer16HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer16HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer17Selected()
    {
        if (!medicalHistoryWrongAnswer17HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer17HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer18Selected()
    {
        if (!medicalHistoryWrongAnswer18HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer18HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer19Selected()
    {
        if (!medicalHistoryWrongAnswer19HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer19HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer20Selected()
    {
        if (!medicalHistoryWrongAnswer20HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer20HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer21Selected()
    {
        if (!medicalHistoryWrongAnswer21HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer21HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer22Selected()
    {
        if (!medicalHistoryWrongAnswer22HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer22HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer23Selected()
    {
        if (!medicalHistoryWrongAnswer23HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer23HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer24Selected()
    {
        if (!medicalHistoryWrongAnswer24HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer24HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer25Selected()
    {
        if (!medicalHistoryWrongAnswer25HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer25HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer26Selected()
    {
        if (!medicalHistoryWrongAnswer26HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer26HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer27Selected()
    {
        if (!medicalHistoryWrongAnswer27HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer27HasBeenSelected = true;
        }
    }

    public void MedicalHistoryIncorrectAnswer28Selected()
    {
        if (!medicalHistoryWrongAnswer28HasBeenSelected)
        {
            HintText.text = "This information is not relevant and will not be saved to your ClinPad.";
            Phase2SelectWrongAnswerMedicalHistoryScore += 1;
            if (Phase2SelectWrongAnswerMedicalHistoryScore == 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase2SelectWrongAnswerMedicalHistoryScore > 1)
            {
                phase02MedicalHistoryPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 1;
            }
            MenuButton.isOn = true;
            medicalHistoryWrongAnswer28HasBeenSelected = true;
        }
    }

    public void FoodAndNutritionCorrectAnswer28Selected()
    {
        if (!Phase2FoodAndNutritionAnswer01HasBeenSelected)
        {
            FoodAndNutritionRightAnswer01SelectText.color = new Color32(106, 181, 67, 255);
            FoodAndNutritionAnswerOneText.text = "Correct Answer 1 Text";
            Phase2FoodAndNutritionAnswerSelected += 1;
            Phase2FoodAndNutritionAnswer01HasBeenSelected = true;
        }
    }

    public void FoodAndNutritionCorrectAnswer02Selected()
    {
        if (!Phase2FoodAndNutritionAnswer02HasBeenSelected)
        {
            FoodAndNutritionRightAnswer02SelectText.color = new Color32(106, 181, 67, 255);
            FoodAndNutritionAnswerTwoText.text = "Correct Answer 2 Text";
            Phase2FoodAndNutritionAnswerSelected += 1;
            Phase2FoodAndNutritionAnswer02HasBeenSelected = true;
        }
    }

    public void FoodAndNutritionCorrectAnswer03Selected()
    {
        if (!Phase2FoodAndNutritionAnswer03HasBeenSelected)
        {
            FoodAndNutritionRightAnswer03SelectText.color = new Color32(106, 181, 67, 255);
            FoodAndNutritionAnswerThreeText.text = "Correct Answer 3 Text";
            Phase2FoodAndNutritionAnswerSelected += 1;
            Phase2FoodAndNutritionAnswer03HasBeenSelected = true;
            Phase2DieticianFoodAndNutritionChatAnwersSelcted += 1;
        }
    }

    public void FoodAndNutritionCorrectAnswer04Selected()
    {
        if (!Phase2FoodAndNutritionAnswer04HasBeenSelected)
        {
            FoodAndNutritionRightAnswer04SelectText.color = new Color32(106, 181, 67, 255);
            FoodAndNutritionAnswerFourText.text = "Correct Answer 4 Text";
            Phase2FoodAndNutritionAnswerSelected += 1;
            Phase2FoodAndNutritionAnswer04HasBeenSelected = true;
            Phase2DieticianFoodAndNutritionChatAnwersSelcted += 1;
        }
    }

    public void FoodAndNutritionIncorrectAnswer01Selected()
    {
        if (!Phase2FoodAndNutritionWrongAnswer01HasBeenSelected)
        {
            HintText.text = "FOOD! This is not the right answer, try the other thing please 01";
            Phase2SelectWrongAnswerFoodAndNutritionScore += 1;
            FoodAndNutritionWrongAnswer01SelectText.color = new Color32(216, 53, 53, 255);
            if (Phase2SelectWrongAnswerFoodAndNutritionScore < 3)
            {
                MenuButton.isOn = true;
            }
            Phase2FoodAndNutritionWrongAnswer01HasBeenSelected = true;
        }
    }

    public void FoodAndNutritionIncorrectAnswer02Selected()
    {
        if (!Phase2FoodAndNutritionWrongAnswer02HasBeenSelected)
        {
            HintText.text = "FOOD! This is not the right answer, try the other thing please 02";
            Phase2SelectWrongAnswerFoodAndNutritionScore += 1;
            FoodAndNutritionWrongAnswer02SelectText.color = new Color32(216, 53, 53, 255);
            if (Phase2SelectWrongAnswerFoodAndNutritionScore < 3)
            {
                MenuButton.isOn = true;
            }
            Phase2FoodAndNutritionWrongAnswer02HasBeenSelected = true;
        }
    }

    public void PatientInvestigationAnthropometryAnswer01Selected()
    {
        if (!Phase4PatientInvestigationAnthropometryAnswer01HasBeenSelected)
        {
            Phase4PatientInvestigationAnthropometryAnswer01HasBeenSelected = true;
            Phase4PatientInvestigationAnthropometryAnswersSelected += 1;
        }
    }

    public void PatientInvestigationAnthropometryAnswer02Selected()
    {
        if (!Phase4PatientInvestigationAnthropometryAnswer02HasBeenSelected)
        {
            Phase4PatientInvestigationAnthropometryAnswer02HasBeenSelected = true;
            Phase4PatientInvestigationAnthropometryAnswersSelected += 1;
        }
    }

    public void PatientInvestigationAnthropometryAnswer03Selected()
    {
        if (!Phase4PatientInvestigationAnthropometryAnswer03HasBeenSelected)
        {
            Phase4PatientInvestigationAnthropometryAnswer03HasBeenSelected = true;
            Phase4PatientInvestigationAnthropometryAnswersSelected += 1;
        }
    }

    public void ChangeSceneToInvestigation()
    {
        inInvestigation = true;
        ActivateInvestigationButton.interactable = false;
        currentScene = 3;
        NPCRightPatientImage.SetBool("NPCRightAnimateIn", false);
        NPCRightPatientImage.SetBool("NPCRightAnimateOut", true);
        HintText.text = "Do not forget to fill out the examination section of the SGA Form by clicking the  <b><color=#0473A1FF>CONDUCT EXAM</color></b>  button at the bottom of the screen.";
        if (inChat)
        {
            inChat = false;
        }
        ActivateChatButton.interactable = false;
        if (InvestigationSceneAnim.GetBool("InvestigationSceneDefault") == true || InvestigationSceneAnim.GetBool("InvestigationSceneAnimateOut") == true)
        {
            InvestigationSceneAnim.SetBool("InvestigationSceneDefault", false);
            InvestigationSceneAnim.SetBool("InvestigationSceneAnimateOut", false);
            InvestigationSceneAnim.SetBool("InvestigationSceneAnimateIn", true);
        }
    }

    public void ChangeSceneToComputer()
    {
        if (PhaseManagement.gamePhase == 6)
        {
            currentScene = 8;
            inComputerTwo = true;
            ComputerSceneTwoDateGroup.SetActive(true);
            if (inChat)
            {
                inChat = false;
            }
            ActivateChatButton.interactable = false;
            if (ComputerSceneTwoAnim.GetBool("InvestigationSceneDefault") == true || ComputerSceneTwoAnim.GetBool("InvestigationSceneAnimateOut") == true)
            {
                ComputerSceneTwoAnim.SetBool("InvestigationSceneDefault", false);
                ComputerSceneTwoAnim.SetBool("InvestigationSceneAnimateOut", false);
                ComputerSceneTwoAnim.SetBool("InvestigationSceneAnimateIn", true);
            }
            if (!phase6Part01Complete)
            {
                Phase6Part01Group.SetTrigger("AnimateIn");
            }
            else if (phase6Part01Complete && !phase6Part02Complete)
            {
                Phase6Part02Group.SetTrigger("AnimateIn");
            }
            else if (phase6Part01Complete && phase6Part02Complete && !phase6Part03Complete)
            {
                Phase6Part03Group.SetTrigger("AnimateIn");
            }
            else if (phase6Part01Complete && phase6Part02Complete && phase6Part03Complete && !phase6Part04Complete)
            {
                Phase6Part04Group.SetTrigger("AnimateIn");
            }
            else if (phase6Part01Complete && phase6Part02Complete && phase6Part03Complete && phase6Part04Complete)
            {
                Phase6Part05Group.SetTrigger("AnimateIn");
            }
        }
        else if (PhaseManagement.gamePhase == 7)
        {
            currentScene = 9;
            inComputerThree = true;
            ComputerSceneThreeDateGroup.SetActive(true);
            if (inChat)
            {
                inChat = false;
            }
            ActivateChatButton.interactable = false;
            if (ComputerSceneThreeAnim.GetBool("InvestigationSceneDefault") == true || ComputerSceneThreeAnim.GetBool("InvestigationSceneAnimateOut") == true)
            {
                ComputerSceneThreeAnim.SetBool("InvestigationSceneDefault", false);
                ComputerSceneThreeAnim.SetBool("InvestigationSceneAnimateOut", false);
                ComputerSceneThreeAnim.SetBool("InvestigationSceneAnimateIn", true);
            }
            if (phase07DietitianInitialConversationComplete)
            {
                phase07PartOnePopup.SetTrigger("AnimateOut");
                if (!phase07UploadComplete)
                {
                    phase07UploadPopup.SetTrigger("AnimateIn");
                    if (!phase07Uploading)
                    {
                        phase07UploadButton.SetActive(true);
                    }
                }
                else if (phase07UploadComplete && !phase07PartTwoComplete)
                {
                    phase07PartTwoPopup.SetTrigger("AnimateIn");
                }
                else if (Phase07Part04Complete)
                {
                    Phase07Part05CompletedAnim.SetTrigger("AnimateIn");
                }
                else if (Phase07Part03Part01Complete && Phase07Part03Part02Complete)
                {
                    Phase07Part04AlertMessageToggle();
                }
                else if (phase07PartTwoComplete)
                {
                    phase07PartThreePopup.SetTrigger("AnimateIn");
                }
            }
            else
            {
                phase07PartOnePopup.SetTrigger("AnimateIn");
            }
        }
        else
        {
            currentScene = 4;
            inComputer = true;
            if (inChat)
            {
                inChat = false;
            }
            ActivateChatButton.interactable = false;
            if (ComputerSceneAnim.GetBool("InvestigationSceneDefault") == true || ComputerSceneAnim.GetBool("InvestigationSceneAnimateOut") == true)
            {
                ComputerSceneAnim.SetBool("InvestigationSceneDefault", false);
                ComputerSceneAnim.SetBool("InvestigationSceneAnimateOut", false);
                ComputerSceneAnim.SetBool("InvestigationSceneAnimateIn", true);
            }
        }
    }

    public void ChangeSceneToClipboard()
    {
        currentScene = 5;
        inClipboard = true;
        if (InvestigationButton.activeSelf == true)
        {
            InvestigationButton.SetActive(false);
        }
        if (inChat)
        {
            inChat = false;
        }
        ActivateChatButton.interactable = false;
        if (ClipboardSceneAnim.GetBool("InvestigationSceneDefault") == true || ClipboardSceneAnim.GetBool("InvestigationSceneAnimateOut") == true)
        {
            ClipboardSceneAnim.SetBool("InvestigationSceneDefault", false);
            ClipboardSceneAnim.SetBool("InvestigationSceneAnimateOut", false);
            ClipboardSceneAnim.SetBool("InvestigationSceneAnimateIn", true);
        }
    }

    public void ChangeSceneToMedicalChart()
    {
        currentScene = 6;
        inMedicalChart = true;
        if (inChat)
        {
            inChat = false;
        }
        AssessmentFormGroup.SetActive(true);
        ActivateChatButton.interactable = false;
        if (MedicalClipboardSceneAnim.GetBool("InvestigationSceneDefault") == true || MedicalClipboardSceneAnim.GetBool("InvestigationSceneAnimateOut") == true)
        {
            MedicalClipboardSceneAnim.SetBool("InvestigationSceneDefault", false);
            MedicalClipboardSceneAnim.SetBool("InvestigationSceneAnimateOut", false);
            MedicalClipboardSceneAnim.SetBool("InvestigationSceneAnimateIn", true);
        }
    }

    public void ChangeSceneToSGAForm()
    {
        currentScene = 7;
        inSGAForm = true;
        if (inChat)
        {
            inChat = false;
        }
        ActivateChatButton.interactable = false;
        if (SGASceneAnim.GetBool("InvestigationSceneDefault") == true || SGASceneAnim.GetBool("InvestigationSceneAnimateOut") == true)
        {
            SGASceneAnim.SetBool("InvestigationSceneDefault", false);
            SGASceneAnim.SetBool("InvestigationSceneAnimateOut", false);
            SGASceneAnim.SetBool("InvestigationSceneAnimateIn", true);
        }
        if (NPCRightDieticianImage.GetBool("NPCRightAnimateIn") == true)
        {
            NPCRightDieticianImage.SetBool("NPCRightAnimateIn", false);
            NPCRightDieticianImage.SetBool("NPCRightAnimateOut", true);
        }
        NurseNavButton.interactable = false;
        DieticianNavButton.interactable = false;
        PatientNavButton.interactable = false;
        FoodGroupResourceGroup.SetActive(true);
        SGAFormButtonGroup.SetActive(true);
    }

    public void ChangeSceneFromSGAForm()
    {
        if (SGASceneAnim.GetBool("InvestigationSceneAnimateIn") == true)
        {
            SGASceneAnim.SetBool("InvestigationSceneAnimateIn", false);
            SGASceneAnim.SetBool("InvestigationSceneAnimateOut", true);
        }
        NPCRightDieticianImage.SetBool("NPCRightAnimateOut", false);
        NPCRightDieticianImage.SetBool("NPCRightAnimateIn", true);
        FoodGroupResourceGroup.SetActive(false);
        ReadyReckonerResourceGroup.SetActive(false);
        SGAFormGroup.SetActive(false);
        SGAFormButtonGroup.SetActive(false);
        NurseNavButton.interactable = true;
        DieticianNavButton.interactable = true;
        PatientNavButton.interactable = true;
        ActivateChatButton.interactable = true;
        currentScene = 0;
        inSGAForm = false;
        Phase5CompleteCheck();
    }

    public void ChangeSceneFromMedicalChart()
    {

        if (MedicalClipboardSceneAnim.GetBool("InvestigationSceneAnimateIn") == true)
        {
            MedicalClipboardSceneAnim.SetBool("InvestigationSceneAnimateIn", false);
            MedicalClipboardSceneAnim.SetBool("InvestigationSceneAnimateOut", true);
        }
        AssessmentFormGroup.SetActive(false);
        AdmissionFormGroup.SetActive(false);
        ProgressNotesPage1Group.SetActive(false);
        ProgressNotesPage2Group.SetActive(false);
        currentScene = 1;
        inMedicalChart = false;
    }

    public void ChangeSceneFromInvestigation()
    {
        currentScene = 2;
        inInvestigation = false;
        patientInvestigationSceneGroup.SetActive(false);
        NPCRightPatientImage.SetBool("NPCRightAnimateOut", false);
        NPCRightPatientImage.SetBool("NPCRightAnimateIn", true);
        if (InvestigationSceneAnim.GetBool("InvestigationSceneAnimateIn") == true)
        {
            InvestigationSceneAnim.SetBool("InvestigationSceneAnimateIn", false);
            InvestigationSceneAnim.SetBool("InvestigationSceneAnimateOut", true);
        }
        if (phase4InvestigationSelectedScore == phase4InvestigationTotalScore)
        {
            if (phase4Conversation1Done && phase4Conversation2Done && phase4Conversation3Done && phase4Conversation4Done && phase4Conversation5Done)
            {
                PhaseManagement.gamePhase = 5;
                nextPhaseSource.Play();
                PhaseReachedAnim.SetTrigger("PhaseReached");
                PhaseReachedText.text = "REACHED PHASE 5";
                currentPhaseText.text = "5th";
                currentPhaseProgressFillImage.fillAmount = 0;
                totalProgressFillImage.fillAmount = 0.50f;
                totalProgressAmountText.text = "50%";
                Phase4ProgressGroup.SetActive(false);
                SGAFormButton.SetActive(true);
                weightChangeCalculatorGroup.SetActive(true);
            }
        }
    }

    public void ChangeSceneFromComputer()
    {
        if (PhaseManagement.gamePhase == 6)
        {
            if (ComputerSceneTwoAnim.GetBool("InvestigationSceneAnimateIn") == true)
            {
                ComputerSceneTwoAnim.SetBool("InvestigationSceneAnimateIn", false);
                ComputerSceneTwoAnim.SetBool("InvestigationSceneAnimateOut", true);
            }
            currentScene = 0;
            inComputerTwo = false;
            ComputerSceneTwoDateGroup.SetActive(false);
            if (Phase6Part01Group.GetCurrentAnimatorStateInfo(0).IsName("NutritionalDiagnosisAnimateIn"))
            {
                Phase6Part01Group.SetTrigger("AnimateOut");
            }
            if (Phase6Part02Group.GetCurrentAnimatorStateInfo(0).IsName("NutritionalDiagnosisAnimateIn"))
            {
                Phase6Part02Group.SetTrigger("AnimateOut");
            }
            if (Phase6Part03Group.GetCurrentAnimatorStateInfo(0).IsName("NutritionalDiagnosisAnimateIn"))
            {
                Phase6Part03Group.SetTrigger("AnimateOut");
            }
            if (Phase6Part04Group.GetCurrentAnimatorStateInfo(0).IsName("NutritionalDiagnosisAnimateIn"))
            {
                Phase6Part04Group.SetTrigger("AnimateOut");
            }
            if (Phase6Part05Group.GetCurrentAnimatorStateInfo(0).IsName("NutritionalDiagnosisAnimateIn"))
            {
                Phase6Part05Group.SetTrigger("AnimateOut");
            }
        }
        else if (PhaseManagement.gamePhase == 7)
        {
            if (ComputerSceneThreeAnim.GetBool("InvestigationSceneAnimateIn") == true)
            {
                ComputerSceneThreeAnim.SetBool("InvestigationSceneAnimateIn", false);
                ComputerSceneThreeAnim.SetBool("InvestigationSceneAnimateOut", true);
            }
            currentScene = 0;
            inComputerThree = false;
            ComputerSceneThreeDateGroup.SetActive(false);
            if (phase07UploadPopup.GetCurrentAnimatorStateInfo(0).IsName("NutritionalDiagnosisAnimateIn"))
            {
                phase07UploadPopup.SetTrigger("AnimateOut");
            }
            if (phase07PartOnePopup.GetCurrentAnimatorStateInfo(0).IsName("NutritionalDiagnosisAnimateIn"))
            {
                phase07PartOnePopup.SetTrigger("AnimateOut");
            }
            if (phase07PartTwoPopup.GetCurrentAnimatorStateInfo(0).IsName("NutritionalDiagnosisAnimateIn"))
            {
                phase07PartTwoPopup.SetTrigger("AnimateOut");
            }
            if (phase07PartThreePopup.GetCurrentAnimatorStateInfo(0).IsName("NutritionalDiagnosisAnimateIn"))
            {
                phase07PartThreePopup.SetTrigger("AnimateOut");
            }
            if (Phase07Part04ConfirmationAlertAnim.GetBool("MenuActivated") == true)
            {
                Phase07Part04ConfirmationAlertAnim.SetBool("MenuActivated", false);
            }
            if (Phase07Part05CompletedAnim.GetCurrentAnimatorStateInfo(0).IsName("NutritionalDiagnosisAnimateIn"))
            {
                Phase07Part05CompletedAnim.SetTrigger("AnimateOut");
            }
        }
        else
        {
            if (ComputerSceneAnim.GetBool("InvestigationSceneAnimateIn") == true)
            {
                ComputerSceneAnim.SetBool("InvestigationSceneAnimateIn", false);
                ComputerSceneAnim.SetBool("InvestigationSceneAnimateOut", true);
            }
            currentScene = 0;
            inComputer = false;
            biochemicalAnswersGroup.SetActive(false);
        }
    }

    public void ChangeSceneFromClipboard()
    {
        if (ClipboardSceneAnim.GetBool("InvestigationSceneAnimateIn") == true)
        {
            ClipboardSceneAnim.SetBool("InvestigationSceneAnimateIn", false);
            ClipboardSceneAnim.SetBool("InvestigationSceneAnimateOut", true);
        }
        if (InvestigationButton.activeSelf == false)
        {
            InvestigationButton.SetActive(true);
        }
        anthropometryAnswersGroup.SetActive(false);
        medicationAnswersGroup.SetActive(false);
        observationsAnswerGroup.SetActive(false);
        ClipboardButtonGroup.SetActive(false);
        currentScene = 2;
        inClipboard = false;
    }

    public void ChangeSceneToNurse()
    {
        if (ChatRightAnim.GetBool("ChatActivated") == true || ChatRightAnim.GetBool("ChatFinishedMoveUp") == true || ChatRightAnim.GetBool("ChatFinishedOld") == true || ChatRightAnim.GetBool("ChatRestart") == true)
        {
            ChatRightAnim.SetBool("ChatActivated", false);
            ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
            ChatRightAnim.SetBool("ChatFinishedOld", false);
            ChatRightAnim.SetBool("ChatRestart", false);
            ChatRightAnim.SetBool("ChatDefault", true);
        }
        if (currentScene == 0)
        {
            NurseSceneAnim.SetTrigger("DieticianToNurse");
            DieticianSceneAnim.SetTrigger("DieticianToNurse");
            HospitalSceneAnim.SetTrigger("DieticianToNurse");
            currentScene = 1;
            if (inChat)
            {
                inChat = false;
            }
        }
        if (currentScene == 2)
        {
            HospitalSceneAnim.SetTrigger("HospitalToNurse");
            NurseSceneAnim.SetTrigger("HospitalToNurse");
            DieticianSceneAnim.SetTrigger("HospitalToNurse");
            currentScene = 1;
            if (inChat)
            {
                inChat = false;
            }
        }
    }

    public void ChangeSceneToDietician()
    {
        if (ChatRightAnim.GetBool("ChatActivated") == true || ChatRightAnim.GetBool("ChatFinishedMoveUp") == true || ChatRightAnim.GetBool("ChatFinishedOld") == true || ChatRightAnim.GetBool("ChatRestart") == true)
        {
            ChatRightAnim.SetBool("ChatActivated", false);
            ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
            ChatRightAnim.SetBool("ChatFinishedOld", false);
            ChatRightAnim.SetBool("ChatRestart", false);
            ChatRightAnim.SetBool("ChatDefault", true);
        }
        if (currentScene == 1)
        {
            NurseSceneAnim.SetTrigger("NurseToDietician");
            DieticianSceneAnim.SetTrigger("NurseToDietician");
            HospitalSceneAnim.SetTrigger("NurseToDietician");
            currentScene = 0;
            if (inChat)
            {
                inChat = false;
            }
        }
        if (currentScene == 2)
        {
            HospitalSceneAnim.SetTrigger("HospitalToDietician");
            DieticianSceneAnim.SetTrigger("HospitalToDietician");
            NurseSceneAnim.SetTrigger("HospitalToDietician");
            currentScene = 0;
            if (inChat)
            {
                inChat = false;
            }
        }
    }

    public void ChangeSceneToHospital()
    {
        //Phase2DieticianConversationTracker = 0;
        //Phase2NurseConversationTracker = 0;
        if (ChatRightAnim.GetBool("ChatActivated") == true || ChatRightAnim.GetBool("ChatFinishedMoveUp") == true || ChatRightAnim.GetBool("ChatFinishedOld") == true || ChatRightAnim.GetBool("ChatRestart") == true)
        {
            ChatRightAnim.SetBool("ChatActivated", false);
            ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
            ChatRightAnim.SetBool("ChatFinishedOld", false);
            ChatRightAnim.SetBool("ChatRestart", false);
            ChatRightAnim.SetBool("ChatDefault", true);
        }
        if (currentScene == 0)
        {
            if (inChat)
            {
                inChat = false;
            }
            DieticianSceneAnim.SetTrigger("DieticianToHospital");
            HospitalSceneAnim.SetTrigger("DieticianToHospital");
            NurseSceneAnim.SetTrigger("DieticianToHospital");
            currentScene = 2;
        }
        if (currentScene == 1)
        {
            if (inChat)
            {
                inChat = false;
            }
            NurseSceneAnim.SetTrigger("NurseToHospital");
            HospitalSceneAnim.SetTrigger("NurseToHospital");
            DieticianSceneAnim.SetTrigger("NurseToHospital");

            currentScene = 2;
        }
    }

    public void OnSoundVolumeChange()
    {
        AudioListener.volume = soundVolumeSlider.value;
        PlayerPrefs.SetFloat("SoundVolume", soundVolumeSlider.value);
    }

    public void ResetSettingDefaults()
    {
        soundVolumeSlider.value = defaultValue;
        buttonToggleAnim.SetBool("ToggleOn", true);
    }

    public void QuitToMenu()
    {
        PhaseManagement.gamePhase = 1;
        SceneManager.LoadScene("login_SCENE");
    }

    public void ChangeToClinPadTranscribeOption()
    {
        ClinPadTranscribeButton.image.sprite = GenericClinpadSelectedButtonImage;
        ClinPadChartButton.image.sprite = GenericClinpadNormalButtonImage;
        ClinPadProgressButton.image.sprite = GenericClinpadNormalButtonImage;
        if (ClinPadTranscribeGroup.activeSelf != true)
        {
            ClinPadTranscribeGroup.SetActive(true);
        }

        if (ClinPadProgressGroup.activeSelf == true)
        {
            ClinPadProgressGroup.SetActive(false);
        }

        if (ClinPadChartGroup.activeSelf == true)
        {
            ClinPadChartGroup.SetActive(false);
        }
    }
    public void ChangeToClinPadChartOption()
    {
        ClinPadTranscribeButton.image.sprite = GenericClinpadNormalButtonImage;
        ClinPadChartButton.image.sprite = GenericClinpadSelectedButtonImage;
        ClinPadProgressButton.image.sprite = GenericClinpadNormalButtonImage;
        if (ClinPadTranscribeGroup.activeSelf == true)
        {
            ClinPadTranscribeGroup.SetActive(false);
        }

        if (ClinPadProgressGroup.activeSelf == true)
        {
            ClinPadProgressGroup.SetActive(false);
        }

        if (ClinPadChartGroup.activeSelf != true)
        {
            ClinPadChartGroup.SetActive(true);
        }
    }
    public void ChangeToClinPadProgressOption()
    {
        ClinPadTranscribeButton.image.sprite = GenericClinpadNormalButtonImage;
        ClinPadChartButton.image.sprite = GenericClinpadNormalButtonImage;
        ClinPadProgressButton.image.sprite = GenericClinpadSelectedButtonImage;
        if (ClinPadTranscribeGroup.activeSelf == true)
        {
            ClinPadTranscribeGroup.SetActive(false);
        }

        if (ClinPadProgressGroup.activeSelf != true)
        {
            ClinPadProgressGroup.SetActive(true);
        }

        if (ClinPadChartGroup.activeSelf == true)
        {
            ClinPadChartGroup.SetActive(false);
        }
    }

    public void TranscribeAnthropometryGroupTab()
    {
        TranscribeSelectedTabHeaderText.text = "Anthropometry - Saved Information";
        TranscribeBiochemicalGroup.SetActive(false);
        TranscribeClientHistoryGroup.SetActive(false);
        TranscribeFoodAndNutritionGroup.SetActive(false);
        TranscribeNutritionDiagnosisGroup.SetActive(false);
        TranscribeInterventionPlanGroup.SetActive(false);
        TranscribeMonitoringAndEvaluationGroup.SetActive(false);
        TranscribeAnthropometryGroup.SetActive(true);
    }

    public void TranscribeBiochemicalGroupTab()
    {
        TranscribeSelectedTabHeaderText.text = "Biochemical - Saved Information";
        TranscribeAnthropometryGroup.SetActive(false);
        TranscribeClientHistoryGroup.SetActive(false);
        TranscribeFoodAndNutritionGroup.SetActive(false);
        TranscribeNutritionDiagnosisGroup.SetActive(false);
        TranscribeInterventionPlanGroup.SetActive(false);
        TranscribeMonitoringAndEvaluationGroup.SetActive(false);
        TranscribeBiochemicalGroup.SetActive(true);
    }

    public void TranscribeClientHistoryGroupTab()
    {
        TranscribeSelectedTabHeaderText.text = "Client History - Saved Information";
        TranscribeAnthropometryGroup.SetActive(false);
        TranscribeBiochemicalGroup.SetActive(false);
        TranscribeFoodAndNutritionGroup.SetActive(false);
        TranscribeNutritionDiagnosisGroup.SetActive(false);
        TranscribeInterventionPlanGroup.SetActive(false);
        TranscribeMonitoringAndEvaluationGroup.SetActive(false);
        TranscribeClientHistoryGroup.SetActive(true);
    }

    public void TranscribeFoodAndNutritionGroupTab()
    {
        TranscribeSelectedTabHeaderText.text = "Food & Nutrition - Saved Information";
        TranscribeAnthropometryGroup.SetActive(false);
        TranscribeBiochemicalGroup.SetActive(false);
        TranscribeClientHistoryGroup.SetActive(false);
        TranscribeNutritionDiagnosisGroup.SetActive(false);
        TranscribeInterventionPlanGroup.SetActive(false);
        TranscribeMonitoringAndEvaluationGroup.SetActive(false);
        TranscribeFoodAndNutritionGroup.SetActive(true);
    }

    public void TranscribeNutritionDiagnosisGroupTab()
    {
        TranscribeSelectedTabHeaderText.text = "Nutrition Diagnosis - Saved Information";
        TranscribeAnthropometryGroup.SetActive(false);
        TranscribeBiochemicalGroup.SetActive(false);
        TranscribeClientHistoryGroup.SetActive(false);
        TranscribeFoodAndNutritionGroup.SetActive(false);
        TranscribeInterventionPlanGroup.SetActive(false);
        TranscribeMonitoringAndEvaluationGroup.SetActive(false);
        TranscribeNutritionDiagnosisGroup.SetActive(true);
    }

    public void TranscribeInterventionPlanGroupTab()
    {
        TranscribeSelectedTabHeaderText.text = "Intervention Plan - Saved Information";
        TranscribeAnthropometryGroup.SetActive(false);
        TranscribeBiochemicalGroup.SetActive(false);
        TranscribeClientHistoryGroup.SetActive(false);
        TranscribeFoodAndNutritionGroup.SetActive(false);
        TranscribeNutritionDiagnosisGroup.SetActive(false);
        TranscribeInterventionPlanGroup.SetActive(true);
        TranscribeMonitoringAndEvaluationGroup.SetActive(false);
    }

    public void TranscribeMonitoringAndEvaluationGroupTab()
    {
        TranscribeSelectedTabHeaderText.text = "Monitoring & Evaluation - Saved Information";
        TranscribeAnthropometryGroup.SetActive(false);
        TranscribeBiochemicalGroup.SetActive(false);
        TranscribeClientHistoryGroup.SetActive(false);
        TranscribeFoodAndNutritionGroup.SetActive(false);
        TranscribeNutritionDiagnosisGroup.SetActive(false);
        TranscribeInterventionPlanGroup.SetActive(false);
        TranscribeMonitoringAndEvaluationGroup.SetActive(true);
    }

    public void ChangeToClipboardObservationOption()
    {
        if (!inClipboardObservation)
        {
            medicationAnswersGroup.SetActive(false);
            anthropometryAnswersGroup.SetActive(true);
            observationsAnswerGroup.SetActive(true);
            inClipboardObservation = true;
        }
        else if (inClipboardObservation)
        {
            observationsAnswerGroup.SetActive(false);
            medicationAnswersGroup.SetActive(false);
            anthropometryAnswersGroup.SetActive(true);
            inClipboardObservation = false;
        }
    }

    public void NotesSave()
    {
        if (!notesSaved)
        {
            if (NotesInputBox.GetComponent<InputField>().text.Length > 5)
            {
                NotesSavedButtonText.text = "Edit";
                NotesSavedText.GetComponent<Text>().text = NotesInputBox.GetComponent<InputField>().text;
                NotesInputBox.SetActive(false);
                NotesSavedText.SetActive(true);
                notesSaved = true;
                ComputerSceneBackButton.SetActive(true);
                ContextSensitiveBackToDietitianHelperAnim.SetTrigger("ContextSensitiveHelperActivated");
            }
            else if (NotesInputBox.GetComponent<InputField>().text.Length <= 5)
            {
                HintText.text = "Please input at least 6 characters before saving your notes. This text will be saved and be supplementary to you overall score.";
                MenuButton.isOn = true;
            }
        }
        else if (notesSaved)
        {
            NotesSavedButtonText.text = "Save";
            NotesSavedText.SetActive(false);
            NotesInputBox.SetActive(true);
            notesSaved = false;
            ComputerSceneBackButton.SetActive(false);
        }
    }

    public void PatientWeightRecord()
    {
        WeightRecordedClinpadText.text = "54.0kgs";
        Phase2AnthropometryAnswerSelected += 1;
        phase2AnthropometryProgressFillImage.fillAmount = Phase2AnthropometryAnswerSelected / Phase2AnthropometryAnswerTotal;
        //if (PatientWeightInputField.text != "")
        //{
        //    if (!patientWeightRecorded)
        //    {
        //        PatientWeightSaveInputButtonText.text = "Edit";
        //        PatientWeightInputField.interactable = false;
        //        PatientWeightRecordedInputText.text = PatientWeightInputField.text;
        //        float.TryParse(PatientWeightRecordedInputText.text, out weightValueAsFloat);
        //        Debug.Log("Patient Weight as float: " + weightValueAsFloat);
        //        WeightRecordedClinpadText.text = "Recorded patient weight is " + weightValueAsFloat + "kgs";
        //        patientWeightRecorded = true;
        //    }
        //    else if (patientWeightRecorded)
        //    {
        //        PatientWeightSaveInputButtonText.text = "Record";
        //        PatientWeightInputField.interactable = true;
        //        patientWeightRecorded = false;
        //    }
        //}
        //else if (PatientWeightInputField.text == "")
        //{
        //    AlertMessageToggle();
        //}
        //if (weightValueAsFloat <= (patientActualWeight + 10f) && weightValueAsFloat >= (patientActualWeight - 10f))
        //{
        //    Phase2AnthropometryAnswerSelected += 1;
        //    Phase2AnthropometryProgressFillImage.fillAmount = Phase2AnthropometryAnswerSelected / Phase2AnthropometryAnswerTotal;
        //    AnthropometryProgressCurrentAmountText.text = Phase2AnthropometryAnswerSelected.ToString();
        //}
        //else {
        //    Phase2AnthropometryAnswerSelected = 0;
        //    Phase2AnthropometryProgressFillImage.fillAmount = Phase2AnthropometryAnswerSelected / Phase2AnthropometryAnswerTotal;
        //    AnthropometryProgressCurrentAmountText.text = Phase2AnthropometryAnswerSelected.ToString();
        //}
    }

    public void PatientHeightRecord()
    {
        HeightRecordedClinpadText.text = "160cm";
        Phase2AnthropometryAnswerSelected += 1;
        phase2AnthropometryProgressFillImage.fillAmount = Phase2AnthropometryAnswerSelected / Phase2AnthropometryAnswerTotal;
    }

    public void StartPhase2LearnMore()
    {
        NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
        ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
        ChatRightTwoNameText.text = dieteticSupervisorNameString;
        ChatRightTwoText.text = "How is everything coming along? Is there something I can help you with?";
        phaseTwoStartInteractiveButtonGroup.SetActive(false);
        phaseTwoInteractiveButtonGroup.SetActive(true);
        ChatRightAnim.SetBool("ChatActivated", false);
        ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
        ChatLeftAnim.SetBool("ChatDefault", false);
        ChatLeftAnim.SetBool("ChatActivated", true);
        Phase2DieticianConversationTracker = 3;
    }

    public void PresentFindings()
    {
        NPCRightTwoChatPortrait.sprite = DieticianPortraitImage;
        ChatTextRightTwoHeaderImage.color = dietiticSupervisorChatHeaderColour;
        ChatRightTwoNameText.text = dieteticSupervisorNameString;
        ChatLeftText.text = "Hi, John. I think I have the background information I need. Anything else I should know before talking to Marta?";
        phaseTwoStartInteractiveButtonGroup.SetActive(false);
        ChatRightAnim.SetBool("ChatActivated", false);
        ChatRightAnim.SetBool("ChatFinishedMoveUp", true);
        ChatLeftAnim.SetBool("ChatDefault", false);
        ChatLeftAnim.SetBool("ChatActivated", true);
        ChatNextButtonText.text = "PRESENT FINDINGS";
        
        

        //PhaseManagement.gamePhase = 3;
        //currentPhaseText.text = "3rd";
        //currentPhaseProgressFillImage.fillAmount = 0;
        //totalProgressFillImage.fillAmount = 0.25f;
        //totalProgressAmountText.text = "25%";
        if (!alreadyReachedPhase3)
        {
            // Save progress.
            PhaseTransitionSave(2);

            nextPhaseSource.Play();
            PhaseReachedAnim.SetTrigger("PhaseReached");
            PhaseReachedText.text = "REACHED PHASE 3";
            //alreadyReachedPhase3 = true;
        }

        // New way to transition phases.
        TransitionPhase2ToPhase3();

        //Phase2ProgressGroup.SetActive(false);
        //Phase3PresentFindingsConversationTracker = 1;
        //BMICalculatorGroup.SetActive(false);

        //PhaseManagement.gamePhase = 3;

        // Original.
        //PhaseManagement.gamePhase = 3;
        //currentPhaseText.text = "3rd";
        //currentPhaseProgressFillImage.fillAmount = 0;
        //totalProgressFillImage.fillAmount = 0.25f;
        //totalProgressAmountText.text = "25%";
        //if (!alreadyReachedPhase3)
        //{
        //    nextPhaseSource.Play();
        //    PhaseReachedAnim.SetTrigger("PhaseReached");
        //    PhaseReachedText.text = "REACHED PHASE 3";
        //    alreadyReachedPhase3 = true;
        //}
        //Phase2ProgressGroup.SetActive(false);
        //Phase3PresentFindingsConversationTracker = 1;
        //BMICalculatorGroup.SetActive(false);
    }

    public void StartBiochemicalInvestigation()
    {
        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
        ChatLeftNameText.text = playerNameString;
        ChatLeftTwoText.text = "... where I can find the Medical File.";
        ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
        ChatLeftTwoNameText.text = playerNameString;
        NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
        ChatNextButtonText.text = "TALK";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatLeftTwoAnim.SetBool("ChatDefault", false);
        ChatLeftTwoAnim.SetBool("ChatActivated", true);
        phaseTwoInteractiveButtonGroup.SetActive(false);
        Phase2DieticianConversationTracker = 4;
    }

    public void StartMedicationInvestigation()
    {
        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
        ChatLeftNameText.text = playerNameString;
        ChatLeftTwoText.text = "... Where can I find information on Marta's discharge plan?";
        ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
        ChatLeftTwoNameText.text = playerNameString;
        NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
        ChatNextButtonText.text = "TALK";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatLeftTwoAnim.SetBool("ChatDefault", false);
        ChatLeftTwoAnim.SetBool("ChatActivated", true);
        phaseTwoInteractiveButtonGroup.SetActive(false);
        Phase2DieticianConversationTracker = 5;
    }

    public void StartMedicalHistoryInvestigation()
    {
        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
        ChatLeftNameText.text = playerNameString;
        ChatLeftTwoText.text = "... Marta's weight and her recent observations.";
        ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
        ChatLeftTwoNameText.text = playerNameString;
        NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
        ChatNextButtonText.text = "TALK";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatLeftTwoAnim.SetBool("ChatDefault", false);
        ChatLeftTwoAnim.SetBool("ChatActivated", true);
        phaseTwoInteractiveButtonGroup.SetActive(false);
        Phase2DieticianConversationTracker = 6;
    }

    public void StartAnthropmetryInvestigation()
    {
        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
        ChatLeftNameText.text = playerNameString;
        ChatLeftTwoText.text = "... Biochemical parameters and information and where it is located.";
        ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
        ChatLeftTwoNameText.text = playerNameString;
        NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
        ChatNextButtonText.text = "TALK";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatLeftTwoAnim.SetBool("ChatDefault", false);
        ChatLeftTwoAnim.SetBool("ChatActivated", true);
        phaseTwoInteractiveButtonGroup.SetActive(false);
        Phase2DieticianConversationTracker = 7;
    }

    public void StartFoodAndNutritionInvestigation()
    {
        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
        ChatLeftNameText.text = playerNameString;
        ChatLeftTwoText.text = "I need a hand getting started with the Food and Nutrition side of things, please.";
        ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
        ChatLeftTwoNameText.text = playerNameString;
        NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
        ChatNextButtonText.text = "TALK";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatLeftTwoAnim.SetBool("ChatDefault", false);
        ChatLeftTwoAnim.SetBool("ChatActivated", true);
        phaseTwoInteractiveButtonGroup.SetActive(false);
        Phase2DieticianConversationTracker = 8;
    }

    public void StartPatientAnthropometryInvestigation()
    {
        ChatLeftNameText.text = playerNameString;
        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
        ChatRightNameText.text = patientNameString;
        ChatTextRightHeaderImage.color = patientChatHeaderColour;
        NPCRightChatPortrait.sprite = PatientPortraitImage;
        ChatLeftTwoNameText.text = playerNameString;
        ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
        NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
        ChatRightTwoNameText.text = patientNameString;
        ChatTextRightTwoHeaderImage.color = patientChatHeaderColour;
        NPCRightTwoChatPortrait.sprite = PatientPortraitImage;
        ChatNextButtonText.text = "CONTINUE";
        ChatRightNameText.text = patientNameString;
        phaseFourInteractiveButtonGroup.SetActive(false);
        ChatLeftText.text = "I'm going to ask you a few questions about your food intake. I need to know how much you have been eating.";
        if (!hasDietHistory)
        {
            Phase4PatientConversationTracker = 100;
        }
        else
        {
            Phase4PatientConversationTracker = 110;
        }
    }
    public void StartPatientClientHistoryInvestigation()
    {
        ChatLeftNameText.text = playerNameString;
        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
        ChatRightNameText.text = patientNameString;
        ChatTextRightHeaderImage.color = patientChatHeaderColour;
        NPCRightChatPortrait.sprite = PatientPortraitImage;
        ChatLeftTwoNameText.text = playerNameString;
        ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
        NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
        ChatRightTwoNameText.text = patientNameString;
        ChatTextRightTwoHeaderImage.color = patientChatHeaderColour;
        NPCRightTwoChatPortrait.sprite = PatientPortraitImage;
        ChatNextButtonText.text = "CONTINUE";
        phaseFourInteractiveButtonGroup.SetActive(false);
        ChatLeftText.text = "I’m going to ask you a few questions about any physical or movement difficulties, such as tiredness or muscle aches, that could be related to your nutrition.";
        Phase4PatientConversationTracker = 200;
    }
    public void StartPatientMedicalHistoryInvestigation()
    {
        ChatLeftNameText.text = playerNameString;
        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
        ChatRightNameText.text = patientNameString;
        ChatTextRightHeaderImage.color = patientChatHeaderColour;
        NPCRightChatPortrait.sprite = PatientPortraitImage;
        ChatLeftTwoNameText.text = playerNameString;
        ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
        NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
        ChatRightTwoNameText.text = patientNameString;
        ChatTextRightTwoHeaderImage.color = patientChatHeaderColour;
        NPCRightTwoChatPortrait.sprite = PatientPortraitImage;
        ChatLeftText.text = "I’m going to ask you a few questions about your personal and social history.";
        ChatNextButtonText.text = "CONTINUE";
        phaseFourInteractiveButtonGroup.SetActive(false);
        Phase4PatientConversationTracker = 300;
    }
    public void StartPatientNutritionInvestigation()
    {
        ChatLeftNameText.text = playerNameString;
        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
        ChatRightNameText.text = patientNameString;
        ChatTextRightHeaderImage.color = patientChatHeaderColour;
        NPCRightChatPortrait.sprite = PatientPortraitImage;
        ChatLeftTwoNameText.text = playerNameString;
        ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
        NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
        ChatRightTwoNameText.text = patientNameString;
        ChatTextRightTwoHeaderImage.color = patientChatHeaderColour;
        NPCRightTwoChatPortrait.sprite = PatientPortraitImage;
        ChatLeftText.text = "I need to ask you a few questions about your weight history.";
        ChatNextButtonText.text = "CONTINUE";
        phaseFourInteractiveButtonGroup.SetActive(false);
        Phase4PatientConversationTracker = 500;
    }
    public void StartExaminationInvestigation()
    {
        ChatLeftNameText.text = playerNameString;
        ChatTextLeftHeaderImage.color = playerChatHeaderColour;
        NPCLeftChatPortraitImage.sprite = PlayerPortraitImage;
        ChatRightNameText.text = patientNameString;
        ChatTextRightHeaderImage.color = patientChatHeaderColour;
        NPCRightChatPortrait.sprite = PatientPortraitImage;
        ChatLeftTwoNameText.text = playerNameString;
        ChatTextLeftTwoHeaderImage.color = playerChatHeaderColour;
        NPCLeftChatTwoPortraitImage.sprite = PlayerPortraitImage;
        ChatRightTwoNameText.text = patientNameString;
        ChatTextRightTwoHeaderImage.color = patientChatHeaderColour;
        NPCRightTwoChatPortrait.sprite = PatientPortraitImage;
        ChatLeftText.text = "I need to do a physical examination to assess the muscle and fat stores on your body. Are you feeling okay enough for a brief physical examination?";
        ChatNextButtonText.text = "NEXT";
        phaseFourInteractiveButtonGroup.SetActive(false);
        Phase4PatientConversationTracker = 400;
    }

    public void Phase04CheckExamScore()
    {
        if (phase4InvestigationSelectedScore > 8)
        {
            int Phase04ExamScore = phase04ExamSelectionCorrect01Score + phase04ExamSelectionCorrect02Score + phase04ExamSelectionCorrect03Score + phase04ExamSelectionCorrect04Score + phase04ExamSelectionCorrect05Score + phase04ExamSelectionCorrect06Score + phase04ExamSelectionCorrect07Score + phase04ExamSelectionCorrect08Score + phase04ExamSelectionCorrect09Score;
            phase04Phase05CombinedScore = Phase04ExamScore;
            if (Phase04ExamScore < 8 && Phase04ExamScore > 4)
            {

                phase04ExamPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (Phase04ExamScore < 5)
            {
                phase04ExamPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 2;
            }
            investigationBackButtonText.text = "FINISH";
        }
    }

    public void ReloadGame()
    {
        PhaseManagement.gamePhase = 1;
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void Phase4DropdownOptionSelected01()
    {
        if (Phase4InvestigationDropdown01.value > 0)
        {
            if (!phase4InvestigationScoreGiven01)
            {
                phase4InvestigationSelectedScore += 1;
            }
            if (Phase4InvestigationDropdown01.value == 1)
            {
                physicalExam01Option01.SetActive(true);
                physicalExam01Option02.SetActive(false);
                physicalExam01Option03.SetActive(false);
                phase04ExamSelectionCorrect01Score = 0;
            }
            else if (Phase4InvestigationDropdown01.value == 2)
            {
                physicalExam01Option01.SetActive(false);
                physicalExam01Option02.SetActive(true);
                physicalExam01Option03.SetActive(false);
                phase04ExamSelectionCorrect01Score = 1;
            }
            else if (Phase4InvestigationDropdown01.value == 3)
            {
                physicalExam01Option01.SetActive(false);
                physicalExam01Option02.SetActive(false);
                physicalExam01Option03.SetActive(true);
                phase04ExamSelectionCorrect01Score = 0;
            }
        }
        phase4InvestigationScoreGiven01 = true;
    }

    public void Phase4DropdownOptionSelected02()
    {
        if (Phase4InvestigationDropdown02.value > 0)
        {
            if (!phase4InvestigationScoreGiven02)
            {
                phase4InvestigationSelectedScore += 1;
            }
            if (Phase4InvestigationDropdown02.value == 1)
            {
                physicalExam02Option01.SetActive(true);
                physicalExam02Option02.SetActive(false);
                physicalExam02Option03.SetActive(false);
                phase04ExamSelectionCorrect02Score = 0;
            }
            else if (Phase4InvestigationDropdown02.value == 2)
            {
                physicalExam02Option01.SetActive(false);
                physicalExam02Option02.SetActive(true);
                physicalExam02Option03.SetActive(false);
                phase04ExamSelectionCorrect02Score = 1;
            }
            else if (Phase4InvestigationDropdown02.value == 3)
            {
                physicalExam02Option01.SetActive(false);
                physicalExam02Option02.SetActive(false);
                physicalExam02Option03.SetActive(true);
                phase04ExamSelectionCorrect02Score = 0;
            }
        }
        phase4InvestigationScoreGiven02 = true;
    }
    public void Phase4DropdownOptionSelected03()
    {
        if (Phase4InvestigationDropdown03.value > 0)
        {
            if (!phase4InvestigationScoreGiven03)
            {
                phase4InvestigationSelectedScore += 1;
            }
            if (Phase4InvestigationDropdown03.value == 1)
            {
                physicalExam03Option01.SetActive(true);
                physicalExam03Option02.SetActive(false);
                physicalExam03Option03.SetActive(false);
                phase04ExamSelectionCorrect03Score = 0;
            }
            else if (Phase4InvestigationDropdown03.value == 2)
            {
                physicalExam03Option01.SetActive(false);
                physicalExam03Option02.SetActive(true);
                physicalExam03Option03.SetActive(false);
                phase04ExamSelectionCorrect03Score = 1;
            }
            else if (Phase4InvestigationDropdown03.value == 3)
            {
                physicalExam03Option01.SetActive(false);
                physicalExam03Option02.SetActive(false);
                physicalExam03Option03.SetActive(true);
                phase04ExamSelectionCorrect03Score = 0;
            }
        }
        phase4InvestigationScoreGiven03 = true;
    }

    public void Phase4DropdownOptionSelected04()
    {
        if (Phase4InvestigationDropdown04.value > 0)
        {
            if (!phase4InvestigationScoreGiven04)
            {
                phase4InvestigationSelectedScore += 1;
            }
            if (Phase4InvestigationDropdown04.value == 1)
            {
                physicalExam04Option01.SetActive(true);
                physicalExam04Option02.SetActive(false);
                physicalExam04Option03.SetActive(false);
                phase04ExamSelectionCorrect04Score = 0;
            }
            else if (Phase4InvestigationDropdown04.value == 2)
            {
                physicalExam04Option01.SetActive(false);
                physicalExam04Option02.SetActive(true);
                physicalExam04Option03.SetActive(false);
                phase04ExamSelectionCorrect04Score = 1;
            }
            else if (Phase4InvestigationDropdown04.value == 3)
            {
                physicalExam04Option01.SetActive(false);
                physicalExam04Option02.SetActive(false);
                physicalExam04Option03.SetActive(true);
                phase04ExamSelectionCorrect04Score = 0;
            }
        }
        phase4InvestigationScoreGiven04 = true;
    }

    public void Phase4DropdownOptionSelected05()
    {
        if (Phase4InvestigationDropdown05.value > 0)
        {
            if (!phase4InvestigationScoreGiven05)
            {
                phase4InvestigationSelectedScore += 1;
            }
            if (Phase4InvestigationDropdown05.value == 1)
            {
                physicalExam05Option01.SetActive(true);
                physicalExam05Option02.SetActive(false);
                physicalExam05Option03.SetActive(false);
                phase04ExamSelectionCorrect05Score = 0;
            }
            else if (Phase4InvestigationDropdown05.value == 2)
            {
                physicalExam05Option01.SetActive(false);
                physicalExam05Option02.SetActive(true);
                physicalExam05Option03.SetActive(false);
                phase04ExamSelectionCorrect05Score = 1;
            }
            else if (Phase4InvestigationDropdown05.value == 3)
            {
                physicalExam05Option01.SetActive(false);
                physicalExam05Option02.SetActive(false);
                physicalExam05Option03.SetActive(true);
                phase04ExamSelectionCorrect05Score = 0;
            }
        }
        phase4InvestigationScoreGiven05 = true;
    }

    public void Phase4DropdownOptionSelected06()
    {
        if (Phase4InvestigationDropdown06.value > 0)
        {
            if (!phase4InvestigationScoreGiven06)
            {
                phase4InvestigationSelectedScore += 1;
            }
            if (Phase4InvestigationDropdown06.value == 1)
            {
                physicalExam06Option01.SetActive(true);
                physicalExam06Option02.SetActive(false);
                physicalExam06Option03.SetActive(false);
                phase04ExamSelectionCorrect06Score = 0;
            }
            else if (Phase4InvestigationDropdown06.value == 2)
            {
                physicalExam06Option01.SetActive(false);
                physicalExam06Option02.SetActive(true);
                physicalExam06Option03.SetActive(false);
                phase04ExamSelectionCorrect06Score = 1;
            }
            else if (Phase4InvestigationDropdown06.value == 3)
            {
                physicalExam06Option01.SetActive(false);
                physicalExam06Option02.SetActive(false);
                physicalExam06Option03.SetActive(true);
                phase04ExamSelectionCorrect06Score = 0;
            }
        }
        phase4InvestigationScoreGiven06 = true;
    }
    public void Phase4DropdownOptionSelected07()
    {
        if (Phase4InvestigationDropdown07.value > 0)
        {
            if (!phase4InvestigationScoreGiven07)
            {
                phase4InvestigationSelectedScore += 1;
            }
            if (Phase4InvestigationDropdown07.value == 1)
            {
                physicalExam07Option01.SetActive(true);
                physicalExam07Option02.SetActive(false);
                physicalExam07Option03.SetActive(false);
                phase04ExamSelectionCorrect07Score = 0;
            }
            else if (Phase4InvestigationDropdown07.value == 2)
            {
                physicalExam07Option01.SetActive(false);
                physicalExam07Option02.SetActive(true);
                physicalExam07Option03.SetActive(false);
                phase04ExamSelectionCorrect07Score = 1;
            }
            else if (Phase4InvestigationDropdown07.value == 3)
            {
                physicalExam07Option01.SetActive(false);
                physicalExam07Option02.SetActive(false);
                physicalExam07Option03.SetActive(true);
                phase04ExamSelectionCorrect07Score = 0;
            }
        }
        phase4InvestigationScoreGiven07 = true;
    }
    public void Phase4DropdownOptionSelected08()
    {
        if (Phase4InvestigationDropdown08.value > 0)
        {
            if (!phase4InvestigationScoreGiven08)
            {
                phase4InvestigationSelectedScore += 1;
            }
            if (Phase4InvestigationDropdown08.value == 1)
            {
                physicalExam08Option01.SetActive(true);
                physicalExam08Option02.SetActive(false);
                physicalExam08Option03.SetActive(false);
                phase04ExamSelectionCorrect08Score = 0;
            }
            else if (Phase4InvestigationDropdown08.value == 2)
            {
                physicalExam08Option01.SetActive(false);
                physicalExam08Option02.SetActive(true);
                physicalExam08Option03.SetActive(false);
                phase04ExamSelectionCorrect08Score = 1;
            }
            else if (Phase4InvestigationDropdown08.value == 3)
            {
                physicalExam08Option01.SetActive(false);
                physicalExam08Option02.SetActive(false);
                physicalExam08Option03.SetActive(true);
                phase04ExamSelectionCorrect08Score = 0;
            }
        }
        phase4InvestigationScoreGiven08 = true;
    }
    public void Phase4DropdownOptionSelected09()
    {
        if (Phase4InvestigationDropdown09.value > 0)
        {
            if (!phase4InvestigationScoreGiven09)
            {
                phase4InvestigationSelectedScore += 1;
            }
            if (Phase4InvestigationDropdown09.value == 1)
            {
                physicalExam09Option01.SetActive(true);
                physicalExam09Option02.SetActive(false);
                physicalExam09Option03.SetActive(false);
                phase04ExamSelectionCorrect09Score = 0;
            }
            else if (Phase4InvestigationDropdown09.value == 2)
            {
                physicalExam09Option01.SetActive(false);
                physicalExam09Option02.SetActive(true);
                physicalExam09Option03.SetActive(false);
                phase04ExamSelectionCorrect09Score = 1;
            }
            else if (Phase4InvestigationDropdown09.value == 3)
            {
                physicalExam09Option01.SetActive(false);
                physicalExam09Option02.SetActive(false);
                physicalExam09Option03.SetActive(true);
                phase04ExamSelectionCorrect09Score = 0;
            }
        }
        phase4InvestigationScoreGiven09 = true;
    }

    public void Phase5AnalyseDietOptionSelected()
    {
        ChatNextButtonText.text = "CONTINUE";
        phase5MultipleChoiceButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatLeftText.text = "Hi John, can I look at the quality of Marta's diet first please.";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatLeftAnim.SetBool("ChatDefault", false);
        ChatLeftAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 100;
    }

    public void Phase5EnergyAndNutrientsOptionSelected()
    {
        ChatNextButtonText.text = "CONTINUE";
        phase5MultipleChoiceButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatLeftText.text = "I want to look at the quantitative dietary assessment please.";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatLeftAnim.SetBool("ChatDefault", false);
        ChatLeftAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 400;
    }
    public void Phase5EnergyActualOptionSelected()
    {
        ChatNextButtonText.text = "CONTINUE";
        phase5MultipleChoiceButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatLeftText.text = "Can we look at the energy needs of Marta please.";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatLeftAnim.SetBool("ChatDefault", false);
        ChatLeftAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 1100;
    }
    public void Phase5EvaluateBodyWeightOptionSelected()
    {
        ChatNextButtonText.text = "CONTINUE";
        phase5MultipleChoiceButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatLeftText.text = "I would like to evaluate Marta's body weight please.";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatLeftAnim.SetBool("ChatDefault", false);
        ChatLeftAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 2000;
    }
    public void Phase5AnalyseDietPartOneOptionA()
    {
        ChatLeftTwoText.text = "Well, my calculations show that Marta’s intake of food from all the food groups were below her requirements.";
        ChatRightTwoText.text = "Okay so what conclusion can you make from this evaluation regarding her nutrient intake?";
        phase5AnalyseDietMultipleChoice01ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 200;
        phase5AnalyseDietCollatedText = "Your qualitative dietary assessment summary indicates that Marta’s intake of food from all the food groups were below her requirements and ";
        phase5AnalyseDietCorrectChoiceOneSelected = true;
    }

    public void Phase5AnalyseDietPartOneOptionB()
    {
        ChatLeftTwoText.text = "Well it seems to me that Marta is almost meeting her requirements for the ‘Meat and Alternatives’ and the ‘Cereals and breads’ food groups but for the other food groups she is below her requirement.";
        ChatRightTwoText.text = "Okay so what conclusion can you make from this evaluation regarding her nutrient intake?";
        phase5AnalyseDietMultipleChoice01ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 200;
        phase5AnalyseDietCollatedText = "Your qualitative dietary assessment summary indicates that Marta is almost meeting her requirements for the ‘Meat and Alternatives’ and the ‘Cereals and breads’ food groups but for the other food groups she is below her requirements and ";
    }

    public void Phase5AnalyseDietPartOneOptionC()
    {
        ChatLeftTwoText.text = "From my calculations, it looks like Marta is just meeting her requirements for the ‘Cereal and breads’ as well as the ‘Meat and alternatives’ food groups but for the other food groups she is below her requirements.";
        ChatRightText.text = "Okay so what conclusion can you make from this evaluation regarding her nutrient intake?";
        phase5AnalyseDietMultipleChoice01ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 200;
        phase5AnalyseDietCollatedText = "Your qualitative dietary assessment summary indicates that Marta is just meeting her requirements for the ‘Cereal and breads’ as well as the ‘Meat and alternatives’ food groups but for the other food groups she is below her requirements and ";
    }

    public void Phase5AnalyseDietPartTwoOptionA()
    {
        phase5AnalyseDietCollatedText = phase5AnalyseDietCollatedText + "her diet is low in energy, protein, and fibre, as well as most micronutrients.";
        ChatRightText.text = "Are you happy to save your evaluation of \"" + phase5AnalyseDietCollatedText + "\" to your Clinpad, do you want to make a different evaluation or come back later?";
        ChatNextButtonText.text = "CHOOSE";
        ChatLeftText.text = "I would say that her diet is low in energy, protein, and fibre, as well as most micronutrients.";
        phase5AnalyseDietMultipleChoice02ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 300;
        phase5AnalyseDietCorrectChoiceTwoSelected = true;
    }

    public void Phase5AnalyseDietPartTwoOptionB()
    {
        phase5AnalyseDietCollatedText = phase5AnalyseDietCollatedText + " I believe that her diet is low in energy and micronutrients but her fibre and protein intake is sufficient.";
        ChatRightText.text = "Are you happy to save your evaluation of \"" + phase5AnalyseDietCollatedText + "\" to your Clinpad, do you want to make a different evaluation or come back later?";
        ChatNextButtonText.text = "CHOOSE";
        phase5AnalyseDietMultipleChoice02ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 300;
    }

    public void Phase5AnalyseDietPartTwoOptionC()
    {
        phase5AnalyseDietCollatedText = phase5AnalyseDietCollatedText + " well her diet is probably low in most micronutrients, but her energy, protein, and fibre intake is sufficient.";
        ChatRightTwoText.text = "Are you happy to save your evaluation of \"" + phase5AnalyseDietCollatedText + "\" to your Clinpad, do you want to make a different evaluation or come back later?";
        ChatNextButtonText.text = "CHOOSE";
        phase5AnalyseDietMultipleChoice02ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 300;
    }

    public void Phase5EnergyAndNutrientsPartOneOptionA()
    {
        ChatLeftTwoText.text = "No, Marta is meeting around 73% of her energy needs and less than 67% of her protein needs.";
        ChatRightTwoText.text = "Based on your quantitative analysis of Marta’s diet and her calculated needs, is Marta meeting her fibre and fluid needs?";
        phase5EnergyAndNutrientsMultipleChoice01ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 700;
        phase5EnergyAndNutrientsCollatedText = "Marta is meeting around 73% of her energy needs and less than 67% of her protein needs and ";
        phase5EnergyAndNutrientsCorrectChoiceOneSelected = true;
    }

    public void Phase5EnergyAndNutrientsPartOneOptionB()
    {
        ChatLeftTwoText.text = "Partly, Marta is meeting 73% of her protein needs but only 67% of her energy needs.";
        ChatRightTwoText.text = "Based on your quantitative analysis of Marta’s diet and her calculated needs, is Marta meeting her fibre and fluid needs?";
        phase5EnergyAndNutrientsMultipleChoice01ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 700;
        phase5EnergyAndNutrientsCollatedText = "Marta is meeting 73% of her protein needs but only 67% of her energy needs and ";
    }

    public void Phase5EnergyAndNutrientsPartOneOptionC()
    {
        ChatLeftTwoText.text = "Partly, Marta is meeting 90% of her energy needs but less than 67% of her protein needs.";
        ChatRightTwoText.text = "Based on your quantitative analysis of Marta’s diet and her calculated needs, is Marta meeting her fibre and fluid needs?";
        phase5EnergyAndNutrientsMultipleChoice01ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 700;
        phase5EnergyAndNutrientsCollatedText = "Marta is meeting 90% of her energy needs but less than 67% of her protein needs and ";
    }

    public void Phase5EnergyAndNutrientsPartTwoOptionA()
    {
        phase5EnergyAndNutrientsCollatedText = phase5EnergyAndNutrientsCollatedText + "is meeting less than 38% of her fibre and fluid requirement";
        ChatRightText.text = "Are you happy to save your evaluation of \"" + phase5EnergyAndNutrientsCollatedText + "\" to your Clinpad, do you want to make a different evaluation or come back later?";
        ChatNextButtonText.text = "CHOOSE";
        phase5EnergyAndNutrientsMultipleChoice02ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 800;
    }

    public void Phase5EnergyAndNutrientsPartTwoOptionB()
    {
        phase5EnergyAndNutrientsCollatedText = phase5EnergyAndNutrientsCollatedText + "is meeting less than 60% of her fibre and fluid needs";
        ChatRightText.text = "Are you happy to save your evaluation of \"" + phase5EnergyAndNutrientsCollatedText + "\" to your Clinpad, do you want to make a different evaluation or come back later?";
        ChatNextButtonText.text = "CHOOSE";
        phase5EnergyAndNutrientsMultipleChoice02ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 800;
        phase5EnergyAndNutrientsCorrectChoiceTwoSelected = true;
    }

    public void Phase5EnergyAndNutrientsPartTwoOptionC()
    {
        phase5EnergyAndNutrientsCollatedText = phase5EnergyAndNutrientsCollatedText + "is having less than 38% of her fibre requirement and only meeting around 43% of her fluid requirement.";
        ChatRightText.text = "Are you happy to save your evaluation of \"" + phase5EnergyAndNutrientsCollatedText + "\" to your Clinpad, do you want to make a different evaluation or come back later?";
        ChatNextButtonText.text = "CHOOSE";
        phase5EnergyAndNutrientsMultipleChoice02ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 800;
    }

    public void Phase5EnergyActualPartOneOptionA()
    {
        ChatNextButtonText.text = "CONTINUE";
        ChatRightTwoText.text = "What weight will you use to calculate Marta’s requirement?";
        ChatLeftTwoText.text = "Guidelines for an Adult not in the acute setting.";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice01ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        phase5EnergyActualFormulaOneSelected = true;
        Phase5DietitianConversationTracker = 1200;
    }

    public void Phase5EnergyActualPartOneOptionB()
    {
        ChatNextButtonText.text = "CONTINUE";
        ChatRightTwoText.text = "What weight will you use to calculate Marta’s requirement?";
        ChatLeftTwoText.text = "Guidelines for an Adult needing to restore energy and protein stores.";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice01ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        phase5EnergyActualCorrectChoiceOneSelected = true;
        phase5EnergyActualFormulaTwoSelected = true;
        Phase5DietitianConversationTracker = 1200;
    }

    public void Phase5EnergyActualPartOneOptionC()
    {
        ChatNextButtonText.text = "CONTINUE";
        ChatRightTwoText.text = "What weight will you use to calculate Marta’s requirement?";
        ChatLeftTwoText.text = "Guidelines for an Adult in acute critical care.";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice01ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        phase5EnergyActualFormulaThreeSelected = true;
        Phase5DietitianConversationTracker = 1200;
    }

    public void Phase5EnergyActualPartTwoOptionA()
    {
        ChatLeftText.text = "Guidelines for an Adult not in the acute setting.";
        ChatRightText.text = "Ok, let's work out that formula.";
        ChatNextButtonText.text = "WORK OUT";
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice02ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        phase5EnergyActualPartTwoFormulaOneSelected = true;
        Phase5EnergyActualPartTwoFormulaOneWorking();
        Phase5DietitianConversationTracker = 1204;
    }
    public void Phase5EnergyActualPartTwoOptionB()
    {
        ChatLeftText.text = "Guidelines for an Adult needing to restore energy and protein stores.";
        ChatRightText.text = "Ok, let's work out that formula.";
        ChatNextButtonText.text = "WORK OUT";
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice02ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        phase5EnergyActualPartTwoFormulaTwoSelected = true;
        Phase5EnergyActualPartTwoFormulaTwoWorking();
        Phase5DietitianConversationTracker = 1204;
    }
    public void Phase5EnergyActualPartTwoOptionC()
    {
        ChatLeftText.text = "Guidelines for an Adult with underlying inflammation and poorly nourished.";
        ChatRightText.text = "Ok, let's work out that formula.";
        ChatNextButtonText.text = "WORK OUT";
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice02ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        phase5EnergyActualPartTwoFormulaThreeSelected = true;
        Phase5EnergyActualPartTwoFormulaThreeWorking();
        phase5EnergyActualPartTwoCorrectChoiceSelected = true;
        Phase5DietitianConversationTracker = 1204;
    }
    public void Phase5EnergyActualPartThreeOptionA()
    {
        ChatLeftText.text = "Minimum fibre intake of 25g/d.";
        ChatRightText.text = "Ok, let's move onto the next question.";
        ChatRightThreeAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightThreeAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice03ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        phase5EnergyActualPartThreeCorrectChoiceSelected = true;
        Phase5DietitianConversationTracker = 1207;
    }
    public void Phase5EnergyActualPartThreeOptionB()
    {
        ChatLeftText.text = "Minimum fibre intake of 38g/d.";
        ChatRightText.text = "Ok, let's move onto the next question.";
        ChatRightThreeAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightThreeAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice03ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        Phase5DietitianConversationTracker = 1207;
    }
    public void Phase5EnergyActualPartThreeOptionC()
    {
        ChatLeftText.text = "Minimum fibre intake of 50g/d.";
        ChatRightText.text = "Ok, let's move onto the next question.";
        ChatRightThreeAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightThreeAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice03ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        Phase5DietitianConversationTracker = 1207;
    }
    public void Phase5EnergyActualPartFourOptionA()
    {
        ChatLeftText.text = "2.8L from food and fluid.";
        ChatRightText.text = "Okay, you have now completed all the necessary calculations in this section.";
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice04ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        Phase5DietitianConversationTracker = 1209;
    }
    public void Phase5EnergyActualPartFourOptionB()
    {
        ChatLeftText.text = "2.1L as adequate intake from fluid only.";
        ChatRightText.text = "Okay, you have now completed all the necessary calculations in this section.";
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice04ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        Phase5DietitianConversationTracker = 1209;
    }
    public void Phase5EnergyActualPartFourOptionC()
    {
        ChatLeftText.text = "35-45 ml/kg/day ≈ 1.9-2.4L/d fluid intake.";
        ChatRightText.text = "Okay, you have now completed all the necessary calculations in this section.";
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        phase5EnergyActualMultipleChoice04ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        phase5EnergyActualPartFourCorrectChoiceSelected = true;
        Phase5DietitianConversationTracker = 1209;
    }

    public void Phase5EnergyActualWeightInputSave()
    {
        weightFloat = float.Parse(phase5EnergyActualWeightInputFieldGroup.GetComponent<InputField>().text);
        if (weightFloat == 54)
        {
            phase5EnergyActualCorrectWeightSelected = true;
        }
        if (phase5EnergyActualFormulaOneSelected)
        {
            Phase5EnergyActualFormulaOneWorking();
        }
        else if (phase5EnergyActualFormulaTwoSelected)
        {
            Phase5EnergyActualFormulaTwoWorking();
        }
        else if (phase5EnergyActualFormulaThreeSelected)
        {
            Phase5EnergyActualFormulaThreeWorking();
        }
        phase5EnergyActualWeightInputFieldGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatLeftText.text = weightFloat + "kgs";
        Phase5DietitianConversationTracker = 1201;
    }

    public void Phase5EnergyActualFormulaOneWorking()
    {
        float formulaResult = ((38 * weightFloat) + 2755) * 1.3f;
        phase5formaularesultstring = formulaResult.ToString();
    }

    public void Phase5EnergyActualFormulaTwoWorking()
    {
        float formulaResult01 = 125 * weightFloat;
        float formulaResult02 = 145 * weightFloat;
        phase5formaularesultstring = formulaResult01.ToString() + "kj - " + formulaResult02.ToString();
    }
    public void Phase5EnergyActualFormulaThreeWorking()
    {
        float formulaResult = 105 * weightFloat;
        phase5formaularesultstring = formulaResult.ToString();
    }
    public void Phase5EnergyActualPartTwoFormulaOneWorking()
    {
        float formulaResult01 = 0.8f * weightFloat;
        float formulaResult02 = 1 * weightFloat;
        phase5PartTwoFormulaResultString = formulaResult01.ToString() + " - " + formulaResult02.ToString();
    }
    public void Phase5EnergyActualPartTwoFormulaTwoWorking()
    {
        float formulaResult01 = 1.2f * weightFloat;
        float formulaResult02 = 1.5f * weightFloat;
        phase5PartTwoFormulaResultString = formulaResult01.ToString() + " - " + formulaResult02.ToString();
    }
    public void Phase5EnergyActualPartTwoFormulaThreeWorking()
    {
        float formulaResult01 = 1.5f * weightFloat;
        float formulaResult02 = 2 * weightFloat;
        phase5PartTwoFormulaResultString = formulaResult01.ToString() + " - " + formulaResult02.ToString();
    }
    public void Phase5WeightEvaluationPartOneOptionA()
    {
        Phase5WeightEvaluationAlertMessageText.text = "This is not the correct evaluation, carefully consider the recommended ranges applicable for elderly individuals.";
        phase05BodyWeightIncorrectScore++;
        Phase5WeightEvaluationAlertMessageToggle();
    }
    public void Phase5WeightEvaluationPartOneOptionB()
    {
        phase5WeightEvaluationSavedText.text = phase5WeightEvaluationSavedText.text + ", underweight";
        ChatLeftTwoText.text = "I would index Marta's BMI as underweight.";
        ChatRightTwoText.text = "Ok next question, considering Marta’s recommended body mass index ranges, what will be a healthy weight range for her?";
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        phase5BodyWeightMultipleChoice01ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        Phase5DietitianConversationTracker = 2002;
    }
    public void Phase5WeightEvaluationPartOneOptionC()
    {
        Phase5WeightEvaluationAlertMessageText.text = "This is not the correct evaluation, carefully consider the recommended ranges applicable for elderly individuals.";
        phase05BodyWeightIncorrectScore++;
        Phase5WeightEvaluationAlertMessageToggle();
    }
    public void Phase5WeightEvaluationPartTwoOptionA()
    {
        Phase5WeightEvaluationAlertMessageText.text = "This weight range is not ideal for Marta, carefully consider the recommended ranges applicable for elderly individuals.";
        phase05BodyWeightIncorrectScore++;
        Phase5WeightEvaluationAlertMessageToggle();
    }
    public void Phase5WeightEvaluationPartTwoOptionB()
    {
        Phase5WeightEvaluationAlertMessageText.text = "This weight range is not ideal for Marta, carefully consider the recommended ranges applicable for elderly individuals.";
        phase05BodyWeightIncorrectScore++;
        Phase5WeightEvaluationAlertMessageToggle();
    }
    public void Phase5WeightEvaluationPartTwoOptionC()
    {
        phase5WeightEvaluationSaved02Text.SetActive(true);
        ChatLeftText.text = "An ideal weight range for Marta would be between 61 and 79 kilograms.";
        ChatRightText.text = "Correct. Lastly, let's calculate Marta's recent weight loss.";
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        phase5BodyWeightMultipleChoice02ButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        Phase5DietitianConversationTracker = 2003;
    }

    public void Phase5WeightEvaluationPartThreeFormulaUpdate()
    {
        if (Phase5BodyUsualWeightInputField.text != null && Phase5BodyCurrentWeightInputField.text != null)
        {
            phase5WeightEvaluationPartThreeUpdatingText.text = Phase5BodyUsualWeightInputField.text + " - " + Phase5BodyCurrentWeightInputField.text + " / " + Phase5BodyUsualWeightInputField.text + " x 100";
        }
    }

    public void Phase5WeightEvaluationPartThreeFormulaWorking()
    {
        if (Phase5BodyUsualWeightInputField.text != "")
        {
            if (Phase5BodyCurrentWeightInputField.text != "")
            {
                int usualWeightInt = int.Parse(Phase5BodyUsualWeightInputField.text.ToString());
                int currentWeightInt = int.Parse(Phase5BodyCurrentWeightInputField.text.ToString());
                if (usualWeightInt == 59)
                {
                    if (currentWeightInt == 54)
                    {
                        phase5BodyWeightUsualWeightInputGroup.SetActive(false);
                        ChatNextButton.interactable = true;
                        ChatLeftTwoText.text = "59kg - 54kg / 59kg x 100 = 8.5% weight loss";
                        ChatRightTwoText.text = "That is correct and has been saved to your Clinpad.";
                        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                        ChatRightAnim.SetBool("ChatDefault", true);
                        ChatLeftTwoAnim.SetBool("ChatActivated", false);
                        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                        ChatRightTwoAnim.SetBool("ChatDefault", false);
                        ChatRightTwoAnim.SetBool("ChatActivated", true);
                        phase5WeightEvaluationSaved03Text.SetActive(true);
                        Phase5DietitianConversationTracker = 2004;
                    }
                    else
                    {
                        Phase5WeightEvaluationAlertMessageText.text = "You have entered the correct value for Marta's usual weight but added the wrong current weight, please enter the correct amount.";
                        Phase5WeightEvaluationAlertMessageToggle();
                    }
                }
                else
                {
                    Phase5WeightEvaluationAlertMessageText.text = "You have entered the incorrect value for Marta's usual weight, please try again.";
                    Phase5WeightEvaluationAlertMessageToggle();
                }
            }
        }
    }

    public void Phase5AnalyseDietSaveToClinpad()
    {
        if (phase5AnalyseDietCorrectChoiceOneSelected && phase5AnalyseDietCorrectChoiceTwoSelected)
        {
            Phase5AnalyseDietTranscribeText.SetActive(true);
            if (phase5EnergyRequirementsComplete && phase5WeightEvaluationComplete && phase5EnergyActualEvaluationComplete)
            {
                ChatLeftTwoText.text = "I would like to save the information to the Clinpad please.";
                ChatRightTwoText.text = "Well done, you correctly assessed Marta’s diet and identified the key nutrients that she may be lacking. You can now complete the SGA form located on the desk behind me.";
                ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightAnim.SetBool("ChatDefault", true);
                ChatLeftTwoAnim.SetBool("ChatActivated", false);
                ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightTwoAnim.SetBool("ChatDefault", false);
                ChatRightTwoAnim.SetBool("ChatActivated", true);
                phase5AnalyseDietComplete = true;
                Phase5AnalyseDietFinalDecisionButtonGroup.SetActive(false);
                ChatNextButton.interactable = true;
                Phase5DietitianConversationTracker = 600;
                phase5Part3Complete = true;
            }
            else
            {
                ChatLeftTwoText.text = "I would like to save the information to the Clinpad please.";
                ChatRightTwoText.text = "Well done, you correctly assessed Marta’s diet and identified the key nutrients that she may be lacking. When you are ready come back to me and we will complete the other evaluations.";
                ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightAnim.SetBool("ChatDefault", true);
                ChatLeftTwoAnim.SetBool("ChatActivated", false);
                ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightTwoAnim.SetBool("ChatDefault", false);
                ChatRightTwoAnim.SetBool("ChatActivated", true);
                phase5AnalyseDietComplete = true;
                Phase5AnalyseDietFinalDecisionButtonGroup.SetActive(false);
                ChatNextButton.interactable = true;
                Phase5DietitianConversationTracker = 600;
            }
            if (phase05QualatativeDietIncorrectScore == 1)
            {
                phase05QualatativeDietPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
            }
            else if (phase05QualatativeDietIncorrectScore > 1)
            {
                phase05QualatativeDietPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 2;
            }
        }
        else
        {
            ChatLeftTwoText.text = "I would like to save the information to the Clinpad please.";
            ChatRightTwoText.text = "Mmmm, you seem to have made an error in your assessment. You probably need to revisit Marta’s diet and reconsider your evaluation.";
            ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
            ChatRightAnim.SetBool("ChatDefault", true);
            ChatLeftTwoAnim.SetBool("ChatActivated", false);
            ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
            ChatRightTwoAnim.SetBool("ChatDefault", false);
            ChatRightTwoAnim.SetBool("ChatActivated", true);
            Phase5AnalyseDietFinalDecisionButtonGroup.SetActive(false);
            ChatNextButton.interactable = true;
            phase5AnalyseDietCorrectChoiceOneSelected = false;
            phase5AnalyseDietCorrectChoiceTwoSelected = false;
            ChatNextButtonText.text = "TRY AGAIN";
            Phase5DietitianConversationTracker = 500;
            phase05QualatativeDietIncorrectScore++;
        }
    }

    public void Phase5AnalyseDietReevaluate()
    {
        ChatRightTwoText.text = "No problem, we can analyse the qualatative aspects of Marta's diet again.";
        ChatLeftTwoText.text = "I would like to reevaluate, could I please have the questions again.";
        Phase5AnalyseDietFinalDecisionButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        phase5AnalyseDietCorrectChoiceOneSelected = false;
        phase5AnalyseDietCorrectChoiceTwoSelected = false;
        ChatNextButtonText.text = "TRY AGAIN";
        Phase5DietitianConversationTracker = 500;
    }

    public void Phase5EnergyAndNutrientsSaveToClinpad()
    {
        if (phase5EnergyAndNutrientsCorrectChoiceOneSelected && phase5EnergyAndNutrientsCorrectChoiceTwoSelected)
        {
            Phase5EnergyAndNutrientsTranscribeText.SetActive(true);
            if (phase5AnalyseDietComplete && phase5WeightEvaluationComplete && phase5EnergyActualEvaluationComplete)
            {
                ChatLeftTwoText.text = "I would like to save the information to the Clinpad please.";
                ChatRightTwoText.text = "Well done. Since Marta is slowly losing weight while she is having 90% of the lower end of her energy requirement this indicates that her need is likely higher veering towards the upper end of her energy requirement. Go to the desk behind me to complete the SGA form when you are ready.";
                ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightAnim.SetBool("ChatDefault", true);
                ChatLeftTwoAnim.SetBool("ChatActivated", false);
                ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightTwoAnim.SetBool("ChatDefault", false);
                ChatRightTwoAnim.SetBool("ChatActivated", true);
                phase5EnergyRequirementsComplete = true;
                Phase5EnergyAndNutrientsFinalDecisionButtonGroup.SetActive(false);
                ChatNextButton.interactable = true;
                phase5Part3Complete = true;
                Phase5DietitianConversationTracker = 1000;
            }
            else
            {
                ChatLeftTwoText.text = "I would like to save the information to the Clinpad please.";
                ChatRightTwoText.text = "Well done. Since Marta is slowly losing weight while she is having 90% of the lower end of her energy requirement this indicates that her need is likely higher veering towards the upper end of her energy requirement. You still need to complete the other evaluations, come back to me when you are ready.";
                ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightAnim.SetBool("ChatDefault", true);
                ChatLeftTwoAnim.SetBool("ChatActivated", false);
                ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightTwoAnim.SetBool("ChatDefault", false);
                ChatRightTwoAnim.SetBool("ChatActivated", true);
                phase5EnergyRequirementsComplete = true;
                Phase5EnergyAndNutrientsFinalDecisionButtonGroup.SetActive(false);
                ChatNextButton.interactable = true;
                Phase5DietitianConversationTracker = 1000;
            }
            if (phase05QuantatativeDietIncorrectScore == 1)
            {
                phase05QuantativeDietPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;

            }
            else if (phase05QuantatativeDietIncorrectScore > 1)
            {
                phase05QuantativeDietPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 2;
            }
        }
        else
        {
            ChatLeftTwoText.text = "I would like to save the information to the Clinpad please.";
            ChatRightTwoText.text = "This does not seem correct, carefully consider the energy and protein requirement you used. Consider her weight history to help identify the correct requirement.";
            ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
            ChatRightAnim.SetBool("ChatDefault", true);
            ChatLeftTwoAnim.SetBool("ChatActivated", false);
            ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
            ChatRightTwoAnim.SetBool("ChatDefault", false);
            ChatRightTwoAnim.SetBool("ChatActivated", true);
            phase5EnergyAndNutrientsCorrectChoiceOneSelected = false;
            phase5EnergyAndNutrientsCorrectChoiceTwoSelected = false;
            Phase5EnergyAndNutrientsFinalDecisionButtonGroup.SetActive(false);
            ChatNextButton.interactable = true;
            Phase5DietitianConversationTracker = 900;
            ChatNextButtonText.text = "TRY AGAIN";
            phase05QuantatativeDietIncorrectScore++;
        }
    }

    public void Phase5EnergyAndNutrientsReevaluate()
    {
        ChatRightTwoText.text = "No problem, we can look at the quantatative side of Marta's diet once more.";
        ChatLeftTwoText.text = "I would like to reevaluate, could I please have the questions again.";
        Phase5EnergyAndNutrientsFinalDecisionButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightAnim.SetBool("ChatDefault", true);
        ChatLeftTwoAnim.SetBool("ChatActivated", false);
        ChatLeftTwoAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightTwoAnim.SetBool("ChatDefault", false);
        ChatRightTwoAnim.SetBool("ChatActivated", true);
        Phase5DietitianConversationTracker = 900;
        Phase5EnergyAndNutrientsFinalDecisionButtonGroup.SetActive(false);
        phase5EnergyAndNutrientsCorrectChoiceOneSelected = false;
        phase5EnergyAndNutrientsCorrectChoiceTwoSelected = false;
        ChatNextButtonText.text = "TRY AGAIN";
    }

    public void Phase5EnergyActualSaveToClinpad()
    {
        if (phase5EnergyActualCorrectChoiceOneSelected && phase5EnergyActualCorrectWeightSelected && phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualPartThreeCorrectChoiceSelected && phase5EnergyActualPartTwoCorrectChoiceSelected)
        {
            Phase5EnergyActualTranscribeText.SetActive(true);
            if (phase5AnalyseDietComplete && phase5EnergyRequirementsComplete && phase5WeightEvaluationComplete)
            {
                ChatLeftText.text = "I would like to save the information to the Clinpad please.";
                ChatRightText.text = "Well done, you chose the correct requirements based on best evidence and Marta’s underlying condition. You can now finish the SGA Form located on the desk behind me in the resource folder.";
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightTwoAnim.SetBool("ChatDefault", true);
                ChatLeftAnim.SetBool("ChatActivated", false);
                ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightAnim.SetBool("ChatDefault", false);
                ChatRightAnim.SetBool("ChatActivated", true);
                phase5EnergyActualEvaluationComplete = true;
                phase5EnergyActualFinalDecisionButtonGroup.SetActive(false);
                ChatNextButton.interactable = true;
                phase5Part3Complete = true;
                Phase5DietitianConversationTracker = 1300;
            }
            else
            {
                ChatLeftTwoText.text = "I would like to save the information to the Clinpad please.";
                ChatRightText.text = "Well done, you chose the correct requirements based on best evidence and Marta’s underlying condition. When you are ready you can finish your evaluation of the other sections.";
                ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
                ChatRightTwoAnim.SetBool("ChatDefault", true);
                ChatLeftAnim.SetBool("ChatActivated", false);
                ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
                ChatRightAnim.SetBool("ChatDefault", false);
                ChatRightAnim.SetBool("ChatActivated", true);
                phase5EnergyActualEvaluationComplete = true;
                phase5EnergyActualFinalDecisionButtonGroup.SetActive(false);
                ChatNextButton.interactable = true;
                Phase5DietitianConversationTracker = 1300;
            }
            if (phase05EnergyActualDietIncorrectScore == 1)
            {
                phase05EnergyActualPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;

            }
            else if (phase05QuantatativeDietIncorrectScore > 1)
            {
                phase05EnergyActualPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 2;
            }
        }
        else
        {
            ChatRightText.text = "Hmmm, some of your requirements do not seem correct.";
            if (!phase5EnergyActualCorrectChoiceOneSelected && !phase5EnergyActualPartTwoCorrectChoiceSelected && !phase5EnergyActualPartThreeCorrectChoiceSelected && !phase5EnergyActualPartFourCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your energy, protein, dietary fibre, and fluid recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualPartTwoCorrectChoiceSelected && !phase5EnergyActualPartThreeCorrectChoiceSelected && !phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualCorrectChoiceOneSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your protein, dietary fibre, and fluid recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualPartThreeCorrectChoiceSelected && !phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualCorrectChoiceOneSelected && phase5EnergyActualPartTwoCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your dietary fibre, and fluid recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualPartTwoCorrectChoiceSelected && phase5EnergyActualCorrectChoiceOneSelected && phase5EnergyActualPartThreeCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your fluid recommendation.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualPartThreeCorrectChoiceSelected && phase5EnergyActualPartTwoCorrectChoiceSelected && phase5EnergyActualCorrectChoiceOneSelected && phase5EnergyActualPartFourCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your fluid recommendation.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualPartTwoCorrectChoiceSelected && phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualPartThreeCorrectChoiceSelected && phase5EnergyActualCorrectChoiceOneSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your fluid recommendation.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualCorrectChoiceOneSelected && phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualPartThreeCorrectChoiceSelected && phase5EnergyActualPartTwoCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your fluid recommendation.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualPartTwoCorrectChoiceSelected && !phase5EnergyActualPartFourCorrectChoiceSelected && !phase5EnergyActualPartThreeCorrectChoiceSelected && phase5EnergyActualCorrectChoiceOneSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your dietary and fluid recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualPartThreeCorrectChoiceSelected && !phase5EnergyActualPartTwoCorrectChoiceSelected && phase5EnergyActualCorrectChoiceOneSelected && phase5EnergyActualPartFourCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your protein and dietary recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualPartTwoCorrectChoiceSelected && !phase5EnergyActualCorrectChoiceOneSelected && phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualPartThreeCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your energy and protein recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualCorrectChoiceOneSelected && !phase5EnergyActualPartTwoCorrectChoiceSelected && !phase5EnergyActualPartThreeCorrectChoiceSelected && phase5EnergyActualPartFourCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your energy, protein, and dietary recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualCorrectChoiceOneSelected && !phase5EnergyActualPartTwoCorrectChoiceSelected && !phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualPartThreeCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your energy, protein, and fluid recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualCorrectChoiceOneSelected && !phase5EnergyActualPartThreeCorrectChoiceSelected && !phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualPartTwoCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your energy, protein, and fluid recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualCorrectChoiceOneSelected && !phase5EnergyActualPartThreeCorrectChoiceSelected && phase5EnergyActualPartTwoCorrectChoiceSelected && phase5EnergyActualPartFourCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your energy and dietary recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualCorrectChoiceOneSelected && !phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualPartTwoCorrectChoiceSelected && phase5EnergyActualPartThreeCorrectChoiceSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your energy and fluid recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualPartTwoCorrectChoiceSelected && !phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualPartThreeCorrectChoiceSelected && phase5EnergyActualCorrectChoiceOneSelected)
            {
                ChatRightText.text = ChatRightText.text + " Carefully consider your protein and fluid recommendations.";
                if (!phase5EnergyActualCorrectWeightSelected)
                {
                    ChatRightText.text = ChatRightText.text + " Also you selected the incorrect weight.";
                }
            }
            else if (!phase5EnergyActualCorrectWeightSelected && phase5EnergyActualPartTwoCorrectChoiceSelected && phase5EnergyActualPartFourCorrectChoiceSelected && phase5EnergyActualPartThreeCorrectChoiceSelected && phase5EnergyActualCorrectChoiceOneSelected)
            {
                ChatRightText.text = "All of your recommendations were correct however you inputted the incorrect weight. Make sure to check your Clinpad.";
            }
            ChatLeftText.text = "I would like to save the information to the Clinpad please.";
            ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
            ChatRightTwoAnim.SetBool("ChatDefault", true);
            ChatLeftAnim.SetBool("ChatActivated", false);
            ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
            ChatRightAnim.SetBool("ChatDefault", false);
            ChatRightAnim.SetBool("ChatActivated", true);
            phase5EnergyActualFinalDecisionButtonGroup.SetActive(false);
            ChatNextButton.interactable = true;
            phase5EnergyActualCorrectChoiceOneSelected = false;
            phase5EnergyActualPartTwoCorrectChoiceSelected = false;
            phase5EnergyActualPartThreeCorrectChoiceSelected = false;
            phase5EnergyActualPartFourCorrectChoiceSelected = false;
            phase5EnergyActualCorrectWeightSelected = false;
            ChatNextButtonText.text = "TRY AGAIN";
            Phase5DietitianConversationTracker = 1400;
            phase05EnergyActualDietIncorrectScore++;
        }
    }

    public void Phase5EnergyActualReevaluate()
    {
        ChatLeftText.text = "I would like to reevaluate, could I please have the questions again.";
        ChatRightText.text = "No problem, we can go through the evaluation again.";
        phase5EnergyActualFinalDecisionButtonGroup.SetActive(false);
        ChatNextButton.interactable = true;
        ChatRightTwoAnim.SetBool("ChatFinishedMoveUp", false);
        ChatRightTwoAnim.SetBool("ChatDefault", true);
        ChatLeftAnim.SetBool("ChatActivated", false);
        ChatLeftAnim.SetBool("ChatFinishedMoveUp", true);
        ChatRightAnim.SetBool("ChatDefault", false);
        ChatRightAnim.SetBool("ChatActivated", true);
        phase5EnergyActualCorrectChoiceOneSelected = false;
        phase5EnergyActualPartTwoCorrectChoiceSelected = false;
        phase5EnergyActualPartThreeCorrectChoiceSelected = false;
        phase5EnergyActualPartFourCorrectChoiceSelected = false;
        phase5EnergyActualCorrectWeightSelected = false;
        ChatNextButtonText.text = "TRY AGAIN";
        Phase5DietitianConversationTracker = 1400;
    }

    public void Phase5CompleteCheck()
    {
        if (phase5Part1Complete && phase5Part2Complete && phase5Part3Complete)
        {
            PhaseManagement.gamePhase = 6;
            nextPhaseSource.Play();
            PhaseReachedAnim.SetTrigger("PhaseReached");
            currentPhaseProgressFillImage.fillAmount = 0;
            currentPhaseText.text = "6th";
            totalProgressFillImage.fillAmount = 0.625f;
            totalProgressAmountText.text = "62.5%";
            TranscribeNutitionDiagnosisTabButton.SetActive(true);
            PhaseReachedText.text = "REACHED PHASE 6";
            Phase5ProgressGroup.SetActive(false);
            SGAFormButton.SetActive(false);
        }
    }

    public void Phase5ToggleSelected01()
    {
        if (!phase5Toggle01AlreadySelected)
        {
            phase5SelectedScore += 1;
        }
        if (phase5SelectedScore == phase5Part1TotalScore)
        {
            phase5Part1Complete = true;
        }
    }

    public void Phase5ToggleSelected02()
    {
        if (!phase5Toggle02AlreadySelected)
        {
            phase5SelectedScore += 1;
        }
        if (phase5SelectedScore == phase5Part1TotalScore)
        {
            phase5Part1Complete = true;
        }
    }

    public void Phase5ToggleSelected03()
    {
        if (!phase5Toggle03AlreadySelected)
        {
            phase5SelectedScore += 1;
        }
        if (phase5SelectedScore == phase5Part1TotalScore)
        {
            phase5Part1Complete = true;
        }
    }

    public void Phase5ToggleSelected04()
    {
        if (!phase5Toggle04AlreadySelected)
        {
            phase5SelectedScore += 1;
        }
        if (phase5SelectedScore == phase5Part1TotalScore)
        {
            phase5Part1Complete = true;
        }
    }

    public void Phase5ToggleSelected05()
    {
        if (!phase5Toggle05AlreadySelected)
        {
            phase5SelectedScore += 1;
        }
        if (phase5SelectedScore == phase5Part1TotalScore)
        {
            phase5Part1Complete = true;
        }
    }

    public void Phase5ToggleSelected06()
    {
        if (!phase5Toggle06AlreadySelected)
        {
            phase5SelectedScore += 1;
        }
        if (phase5SelectedScore == phase5Part1TotalScore)
        {
            phase5Part1Complete = true;
        }
    }

    public void Phase5ToggleSelected07()
    {
        if (!phase5Toggle07AlreadySelected)
        {
            phase5SelectedScore += 1;
        }
        if (phase5SelectedScore == phase5Part1TotalScore)
        {
            phase5Part1Complete = true;
        }
    }

    public void Phase5SOverallSelected()
    {
        if (!phase5OverallAlreadySelected)
        {
            phase5Part2Complete = true;
            phase5OverallAlreadySelected = true;
        }
    }

    public void SavePhase3InputText()
    {
        Phase3SavedText.GetComponent<Text>().text = Phase3InputBox.GetComponent<InputField>().text.ToLower();

        CheckPhase3String();
    }

    public void CheckPhase3String()
    {
        Phase3InputTextStringArray = Phase3SavedText.GetComponent<Text>().text.Split(new string[] { ", " }, System.StringSplitOptions.None).Distinct().ToList();
        foreach (string word in Phase3InputTextStringArray)
        {
            if (phase3AcceptedPhrases.Contains(word))
            {
                if (Phase03AnthropometricMeasurementsStringArray.Contains(word))
                {
                    if (!Phase03AnthropometricMeasurementsWordalreadyfound)
                    {
                        Phase3InputCheckScore++;
                        Phase03AnthropometryWordsCompleteBox.SetActive(true);
                        Phase03AnthropometricMeasurementsWordalreadyfound = true;
                    }
                }
                else if (Phase03ClientHistoryStringArray.Contains(word))
                {
                    if (!Phase03ClientHistoryWordalreadyfound)
                    {
                        Phase3InputCheckScore++;
                        Phase03ClientHistoryWordsCompleteBox.SetActive(true);
                        Phase03ClientHistoryWordalreadyfound = true;
                    }
                }
                else if (Phase03FeedingAbilityStringArray.Contains(word))
                {
                    if (!Phase03FeedingAbilityWordalreadyfound)
                    {
                        Phase3InputCheckScore++;
                        Phase03FeedingAbilityWordsCompleteBox.SetActive(true);
                        Phase03FeedingAbilityWordalreadyfound = true;
                    }
                }
                else if (Phase03FoodIntakeStringArray.Contains(word))
                {
                    if (!Phase03FoodIntakeWordalreadyfound)
                    {
                        Phase3InputCheckScore++;
                        Phase03FoodIntakeWordsCompleteBox.SetActive(true);
                        Phase03FoodIntakeWordalreadyfound = true;
                    }
                }
                else if (Phase03NutritionFocusedPhysicalStringArray.Contains(word))
                {
                    if (!Phase03NutritionFocusedPhysicalWordalreadyfound)
                    {
                        Phase3InputCheckScore++;
                        Phase03NutriitionFocusedPhysicalWordsCompleteBox.SetActive(true);
                        Phase03NutritionFocusedPhysicalWordalreadyfound = true;
                    }
                }
            }
            else
            {
                phase03IncorrectScore++;
            }
        }
        if (Phase3InputCheckScore >= Phase3InputScoreTotal)
        {
            Phase3CompletionInfoGroupText.text = "You have presented all findings";
            Phase3CompletionInfoGroupBackgroundImage.color = new Color32(60, 172, 81, 255);
            Phase3CompletionInfoGroupAlertBackgroundImage.color = new Color32(88, 218, 83, 255);
            Phase3CompletionImage.sprite = Phase3CompletionSprite;
            hasFoodAndNutritionInformation = true;
            TestFindingsButton.SetActive(false);
            Phase3PresentFindingsConversationTracker = 5;
            ChatNextButtonText.text = "CONTINUE";
            notificationGoodSource.Play();
            if (phase03IncorrectScore > 2 && phase03IncorrectScore < 6)
            {
                phase03ParsingPlayerRating = playerRatingIntermediate;
                phase08OverallScore = phase08OverallScore + 1;
                Phase08Phase03ResultText.text = "You demonstrated the ability to identify some gaps in the nutrition information you already gathered and picking up some cues from Marta that needed further investigation.";
            }
            else if (phase03IncorrectScore > 5)
            {
                phase03ParsingPlayerRating = playerRatingNovice;
                phase08OverallScore = phase08OverallScore + 2;
                Phase08Phase03ResultText.text = "You had difficulty in identifying gaps in the nutrition information you already gathered and difficulty picking up cues from Marta that needed further investigation.";
            }
            else if (phase03IncorrectScore < 3)
            {
                Phase08Phase03ResultText.text = "You flawlessly demonstrated the ability to identify gaps in the nutrition information you already gathered and picking up cues from Marta that needed further investigation.";
            }
        }
        else
        {
            Phase3CompletionInfoGroupText.text = "You have been able to identify " + Phase3InputCheckScore + " out of " + Phase3InputScoreTotal + " overarching nutritional concerns for Marta. What else will be important to clarify?";
            Phase3CompletionInfoGroupBackgroundImage.color = new Color32(251, 3, 3, 255);
            Phase3CompletionInfoGroupAlertBackgroundImage.color = new Color32(255, 75, 75, 255);
            phase03IncorrectScore++;
        }
        Phase3CompletionInfoGroup.SetActive(true);
        Phase03CompletionInfoAnimClip.Play("Phase03CompletionInfoAnimateIn");
    }

    IEnumerator WaitOneFrame()
    {
        yield return new WaitForSeconds(0.02f);
        ChatNextButton.onClick.Invoke();
    }

    IEnumerator Phase08DelayAnimation()
    {
        yield return new WaitForSeconds(1f);
        phase08EndResultInformationDisplayAnim.SetTrigger("AnimateIn");
    }

    IEnumerator Phase07ToPhase08GamephaseTransition()
    {
        yield return new WaitForSecondsRealtime(1f);
        NPCPatientImage.sprite = NPCPatientCasualClothesSprite;
        yield return new WaitForSecondsRealtime(3f);
        PhaseManagement.gamePhase = 8;
        nextPhaseSource.Play();
        PhaseReachedAnim.SetTrigger("PhaseReached");
        PhaseReachedText.text = "REACHED PHASE 8";
        currentPhaseText.text = "8th";
        currentPhaseProgressFillImage.fillAmount = 0;
        totalProgressFillImage.fillAmount = 0.875f;
        totalProgressAmountText.text = "87.5%";
        Phase7ProgressGroup.SetActive(false);
        NPCPatientImage.sprite = NPCPatientCasualClothesSprite;
        DieticianNavButton.isOn = true;
        canComputer = false;
        canAnthropometry = false;
        canMedicalHistory = false;
        SGAFormButton.SetActive(false);
    }
}