using System.Xml.Serialization;


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SFERA_B2G_EventMessage  : ISferaMessage {
    
    private MessageHeader messageHeaderField;
    
    private object[] itemsField;
    
    /// <remarks/>
    public MessageHeader MessageHeader {
        get {
            return this.messageHeaderField;
        }
        set {
            this.messageHeaderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("B2G_StatusReport", typeof(B2G_StatusReport))]
    [System.Xml.Serialization.XmlElementAttribute("SessionTermination", typeof(SessionTermination))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class MessageHeader : ISferaMessage
{

    private TrainIdentification_ComplexType trainIdentificationField;
    
    private MessageReference messageReferenceField;
    
    private Sender senderField;
    
    private Recipient recipientField;
    
    private string sFERA_versionField;
    
    private string message_IDField;
    
    private System.DateTime timestampField;
    
    private string sourceDeviceField;
    
    private string destinationDeviceField;
    
    private string correlation_IDField;
    
    private string nID_OPERATIONALField;
    
    private string nID_ENGINEField;
    
    private string europeanVehicleNumberField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public MessageReference MessageReference {
        get {
            return this.messageReferenceField;
        }
        set {
            this.messageReferenceField = value;
        }
    }
    
    /// <remarks/>
    public Sender Sender {
        get {
            return this.senderField;
        }
        set {
            this.senderField = value;
        }
    }
    
    /// <remarks/>
    public Recipient Recipient {
        get {
            return this.recipientField;
        }
        set {
            this.recipientField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SFERA_version {
        get {
            return this.sFERA_versionField;
        }
        set {
            this.sFERA_versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string message_ID {
        get {
            return this.message_IDField;
        }
        set {
            this.message_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sourceDevice {
        get {
            return this.sourceDeviceField;
        }
        set {
            this.sourceDeviceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string destinationDevice {
        get {
            return this.destinationDeviceField;
        }
        set {
            this.destinationDeviceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string correlation_ID {
        get {
            return this.correlation_IDField;
        }
        set {
            this.correlation_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NID_OPERATIONAL {
        get {
            return this.nID_OPERATIONALField;
        }
        set {
            this.nID_OPERATIONALField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NID_ENGINE {
        get {
            return this.nID_ENGINEField;
        }
        set {
            this.nID_ENGINEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string EuropeanVehicleNumber {
        get {
            return this.europeanVehicleNumberField;
        }
        set {
            this.europeanVehicleNumberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("TrainIdentification", Namespace="", IsNullable=false)]
public partial class TrainIdentification_ComplexType : ISferaMessage {
    
    private TAF_TAP_ID_ComplexType tAF_TAP_IDField;
    
    private OTN_ID_ComplexType oTN_IDField;
    
    /// <remarks/>
    public TAF_TAP_ID_ComplexType TAF_TAP_ID {
        get {
            return this.tAF_TAP_IDField;
        }
        set {
            this.tAF_TAP_IDField = value;
        }
    }
    
    /// <remarks/>
    public OTN_ID_ComplexType OTN_ID {
        get {
            return this.oTN_IDField;
        }
        set {
            this.oTN_IDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("TAF_TAP_ID", Namespace="", IsNullable=false)]
public partial class TAF_TAP_ID_ComplexType {
    
    private ObjectType objectTypeField;
    
    private string companyField;
    
    private string coreField;
    
    private string variantField;
    
    private string timetableYearField;
    
    private System.DateTime startDateField;
    
    public TAF_TAP_ID_ComplexType() {
        this.objectTypeField = ObjectType.TR;
    }
    
    /// <remarks/>
    public ObjectType ObjectType {
        get {
            return this.objectTypeField;
        }
        set {
            this.objectTypeField = value;
        }
    }
    
    /// <remarks/>
    public string Company {
        get {
            return this.companyField;
        }
        set {
            this.companyField = value;
        }
    }
    
    /// <remarks/>
    public string Core {
        get {
            return this.coreField;
        }
        set {
            this.coreField = value;
        }
    }
    
    /// <remarks/>
    public string Variant {
        get {
            return this.variantField;
        }
        set {
            this.variantField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string TimetableYear {
        get {
            return this.timetableYearField;
        }
        set {
            this.timetableYearField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime StartDate {
        get {
            return this.startDateField;
        }
        set {
            this.startDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum ObjectType {
    
    /// <remarks/>
    TR,
    
    /// <remarks/>
    PA,
    
    /// <remarks/>
    CR,
    
    /// <remarks/>
    PR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TrainType {
    
    private TrainInformation trainInformationField;
    
    private TrainLocationInformation trainLocationInformationField;
    
    private string orderField;
    
    /// <remarks/>
    public TrainInformation TrainInformation {
        get {
            return this.trainInformationField;
        }
        set {
            this.trainInformationField = value;
        }
    }
    
    /// <remarks/>
    public TrainLocationInformation TrainLocationInformation {
        get {
            return this.trainLocationInformationField;
        }
        set {
            this.trainLocationInformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string order {
        get {
            return this.orderField;
        }
        set {
            this.orderField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TrainInformation {
    
    private string companyField;
    
    private string operationalTrainNumberField;
    
    private System.DateTime startDateField;
    
    private bool startDateFieldSpecified;
    
    private string additionalTrainNumberField;
    
    private ATP_System_Identifier aTP_System_IdentifierField;
    
    private string trainLengthField;
    
    private string trainCategoryCodeField;
    
    /// <remarks/>
    public string Company {
        get {
            return this.companyField;
        }
        set {
            this.companyField = value;
        }
    }
    
    /// <remarks/>
    public string OperationalTrainNumber {
        get {
            return this.operationalTrainNumberField;
        }
        set {
            this.operationalTrainNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime StartDate {
        get {
            return this.startDateField;
        }
        set {
            this.startDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool StartDateSpecified {
        get {
            return this.startDateFieldSpecified;
        }
        set {
            this.startDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string AdditionalTrainNumber {
        get {
            return this.additionalTrainNumberField;
        }
        set {
            this.additionalTrainNumberField = value;
        }
    }
    
    /// <remarks/>
    public ATP_System_Identifier ATP_System_Identifier {
        get {
            return this.aTP_System_IdentifierField;
        }
        set {
            this.aTP_System_IdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string trainLength {
        get {
            return this.trainLengthField;
        }
        set {
            this.trainLengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trainCategoryCode {
        get {
            return this.trainCategoryCodeField;
        }
        set {
            this.trainCategoryCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ATP_System_Identifier {
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TrainLocationInformation {
    
    private SegmentClaim[] segmentClaimField;
    
    private PositionSpeed positionSpeedField;
    
    private NextTimingPointTrainInformation[] nextTimingPointTrainInformationField;
    
    private PreviousTimingPointTrainInformation[] previousTimingPointTrainInformationField;
    
    private LastPassedKmRef lastPassedKmRefField;
    
    private LastPassedSignal lastPassedSignalField;
    
    private object averageSpeedField;
    
    private string maxSpeedTrackField;
    
    private Delay delayField;
    
    private System.DateTime dateTimeMeasurementField;
    
    private bool dateTimeMeasurementFieldSpecified;
    
    private string lineIdentifierField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SegmentClaim")]
    public SegmentClaim[] SegmentClaim {
        get {
            return this.segmentClaimField;
        }
        set {
            this.segmentClaimField = value;
        }
    }
    
    /// <remarks/>
    public PositionSpeed PositionSpeed {
        get {
            return this.positionSpeedField;
        }
        set {
            this.positionSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NextTimingPointTrainInformation")]
    public NextTimingPointTrainInformation[] NextTimingPointTrainInformation {
        get {
            return this.nextTimingPointTrainInformationField;
        }
        set {
            this.nextTimingPointTrainInformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PreviousTimingPointTrainInformation")]
    public PreviousTimingPointTrainInformation[] PreviousTimingPointTrainInformation {
        get {
            return this.previousTimingPointTrainInformationField;
        }
        set {
            this.previousTimingPointTrainInformationField = value;
        }
    }
    
    /// <remarks/>
    public LastPassedKmRef LastPassedKmRef {
        get {
            return this.lastPassedKmRefField;
        }
        set {
            this.lastPassedKmRefField = value;
        }
    }
    
    /// <remarks/>
    public LastPassedSignal LastPassedSignal {
        get {
            return this.lastPassedSignalField;
        }
        set {
            this.lastPassedSignalField = value;
        }
    }
    
    /// <remarks/>
    public object AverageSpeed {
        get {
            return this.averageSpeedField;
        }
        set {
            this.averageSpeedField = value;
        }
    }
    
    /// <remarks/>
    public string MaxSpeedTrack {
        get {
            return this.maxSpeedTrackField;
        }
        set {
            this.maxSpeedTrackField = value;
        }
    }
    
    /// <remarks/>
    public Delay Delay {
        get {
            return this.delayField;
        }
        set {
            this.delayField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime DateTimeMeasurement {
        get {
            return this.dateTimeMeasurementField;
        }
        set {
            this.dateTimeMeasurementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DateTimeMeasurementSpecified {
        get {
            return this.dateTimeMeasurementFieldSpecified;
        }
        set {
            this.dateTimeMeasurementFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string lineIdentifier {
        get {
            return this.lineIdentifierField;
        }
        set {
            this.lineIdentifierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SegmentClaim : SegmentProfileIdentification_ComplexType {
    
    private SegmentOccupationStatus segmentOccupationStatusField;
    
    private uint sP_VersionMajorField;
    
    private uint sP_VersionMinorField;
    
    private SegmentClaimSP_Direction sP_DirectionField;
    
    private bool sP_DirectionFieldSpecified;
    
    private double startLocationField;
    
    private bool startLocationFieldSpecified;
    
    private double endLocationField;
    
    private bool endLocationFieldSpecified;
    
    private SP_GenericArea_ComplexTypeStartEndQualifier startEndQualifierField;
    
    private bool startEndQualifierFieldSpecified;
    
    /// <remarks/>
    public SegmentOccupationStatus SegmentOccupationStatus {
        get {
            return this.segmentOccupationStatusField;
        }
        set {
            this.segmentOccupationStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint SP_VersionMajor {
        get {
            return this.sP_VersionMajorField;
        }
        set {
            this.sP_VersionMajorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint SP_VersionMinor {
        get {
            return this.sP_VersionMinorField;
        }
        set {
            this.sP_VersionMinorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public SegmentClaimSP_Direction SP_Direction {
        get {
            return this.sP_DirectionField;
        }
        set {
            this.sP_DirectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SP_DirectionSpecified {
        get {
            return this.sP_DirectionFieldSpecified;
        }
        set {
            this.sP_DirectionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double startLocation {
        get {
            return this.startLocationField;
        }
        set {
            this.startLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startLocationSpecified {
        get {
            return this.startLocationFieldSpecified;
        }
        set {
            this.startLocationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double endLocation {
        get {
            return this.endLocationField;
        }
        set {
            this.endLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endLocationSpecified {
        get {
            return this.endLocationFieldSpecified;
        }
        set {
            this.endLocationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public SP_GenericArea_ComplexTypeStartEndQualifier startEndQualifier {
        get {
            return this.startEndQualifierField;
        }
        set {
            this.startEndQualifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startEndQualifierSpecified {
        get {
            return this.startEndQualifierFieldSpecified;
        }
        set {
            this.startEndQualifierFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SegmentOccupationStatus {
    
    private ClaimTypeType claimTypeField;
    
    private LeavingEnteringStatusType leavingEnteringStatusField;
    
    private bool leavingEnteringStatusFieldSpecified;
    
    private bool sameDirectionField;
    
    private bool sameDirectionFieldSpecified;
    
    /// <remarks/>
    public ClaimTypeType ClaimType {
        get {
            return this.claimTypeField;
        }
        set {
            this.claimTypeField = value;
        }
    }
    
    /// <remarks/>
    public LeavingEnteringStatusType LeavingEnteringStatus {
        get {
            return this.leavingEnteringStatusField;
        }
        set {
            this.leavingEnteringStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LeavingEnteringStatusSpecified {
        get {
            return this.leavingEnteringStatusFieldSpecified;
        }
        set {
            this.leavingEnteringStatusFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool SameDirection {
        get {
            return this.sameDirectionField;
        }
        set {
            this.sameDirectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SameDirectionSpecified {
        get {
            return this.sameDirectionFieldSpecified;
        }
        set {
            this.sameDirectionFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlRootAttribute("ClaimType", Namespace="", IsNullable=false)]
public enum ClaimTypeType {
    
    /// <remarks/>
    Planned,
    
    /// <remarks/>
    Reserved,
    
    /// <remarks/>
    ReservedImplicit,
    
    /// <remarks/>
    Occupied,
    
    /// <remarks/>
    Unknown,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlRootAttribute("LeavingEnteringStatus", Namespace="", IsNullable=false)]
public enum LeavingEnteringStatusType {
    
    /// <remarks/>
    Entering,
    
    /// <remarks/>
    Leaving,
    
    /// <remarks/>
    Crossing,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum SegmentClaimSP_Direction {
    
    /// <remarks/>
    Nominal,
    
    /// <remarks/>
    Reverse,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum SP_GenericArea_ComplexTypeStartEndQualifier {
    
    /// <remarks/>
    Starts,
    
    /// <remarks/>
    Ends,
    
    /// <remarks/>
    StartsEnds,
    
    /// <remarks/>
    WholeSP,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("RequestFromSegmentProfile", Namespace="", IsNullable=false)]
public partial class SegmentProfileIdentification_ComplexType {
    
    private SP_Zone_ComplexType sP_ZoneField;
    
    private string sP_IDField;
    
    /// <remarks/>
    public SP_Zone_ComplexType SP_Zone {
        get {
            return this.sP_ZoneField;
        }
        set {
            this.sP_ZoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SP_ID {
        get {
            return this.sP_IDField;
        }
        set {
            this.sP_IDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("SP_Zone", Namespace="", IsNullable=false)]
public partial class SP_Zone_ComplexType {
    
    private string iM_IDField;
    
    private short nID_CField;
    
    private bool nID_CFieldSpecified;
    
    /// <remarks/>
    public string IM_ID {
        get {
            return this.iM_IDField;
        }
        set {
            this.iM_IDField = value;
        }
    }
    
    /// <remarks/>
    public short NID_C {
        get {
            return this.nID_CField;
        }
        set {
            this.nID_CField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NID_CSpecified {
        get {
            return this.nID_CFieldSpecified;
        }
        set {
            this.nID_CFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class PositionSpeed : SegmentProfileIdentification_ComplexType {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private GNSS_DynamicPosition_ComplexType gNSS_DynamicPositionField;
    
    private LastAbsoluteOdometryPoint lastAbsoluteOdometryPointField;
    
    private double locationField;
    
    private decimal speedField;
    
    private bool speedFieldSpecified;
    
    private double location_PositiveErrorMarginField;
    
    private bool location_PositiveErrorMarginFieldSpecified;
    
    private string location_NegativeErrorMarginField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public GNSS_DynamicPosition_ComplexType GNSS_DynamicPosition {
        get {
            return this.gNSS_DynamicPositionField;
        }
        set {
            this.gNSS_DynamicPositionField = value;
        }
    }
    
    /// <remarks/>
    public LastAbsoluteOdometryPoint LastAbsoluteOdometryPoint {
        get {
            return this.lastAbsoluteOdometryPointField;
        }
        set {
            this.lastAbsoluteOdometryPointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal speed {
        get {
            return this.speedField;
        }
        set {
            this.speedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool speedSpecified {
        get {
            return this.speedFieldSpecified;
        }
        set {
            this.speedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location_PositiveErrorMargin {
        get {
            return this.location_PositiveErrorMarginField;
        }
        set {
            this.location_PositiveErrorMarginField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool location_PositiveErrorMarginSpecified {
        get {
            return this.location_PositiveErrorMarginFieldSpecified;
        }
        set {
            this.location_PositiveErrorMarginFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string location_NegativeErrorMargin {
        get {
            return this.location_NegativeErrorMarginField;
        }
        set {
            this.location_NegativeErrorMarginField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("GNSS_DynamicPosition", Namespace="", IsNullable=false)]
public partial class GNSS_DynamicPosition_ComplexType {
    
    private decimal latitudeField;
    
    private decimal longitudeField;
    
    private decimal altitudeField;
    
    private bool altitudeFieldSpecified;
    
    private decimal headingField;
    
    private bool headingFieldSpecified;
    
    private decimal gNSS_precisionField;
    
    private bool gNSS_precisionFieldSpecified;
    
    private System.DateTime timestampField;
    
    private bool timestampFieldSpecified;
    
    private double antennaDistanceFromFrontOfTrainField;
    
    private bool antennaDistanceFromFrontOfTrainFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal latitude {
        get {
            return this.latitudeField;
        }
        set {
            this.latitudeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal longitude {
        get {
            return this.longitudeField;
        }
        set {
            this.longitudeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal altitude {
        get {
            return this.altitudeField;
        }
        set {
            this.altitudeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool altitudeSpecified {
        get {
            return this.altitudeFieldSpecified;
        }
        set {
            this.altitudeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal heading {
        get {
            return this.headingField;
        }
        set {
            this.headingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool headingSpecified {
        get {
            return this.headingFieldSpecified;
        }
        set {
            this.headingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal GNSS_precision {
        get {
            return this.gNSS_precisionField;
        }
        set {
            this.gNSS_precisionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool GNSS_precisionSpecified {
        get {
            return this.gNSS_precisionFieldSpecified;
        }
        set {
            this.gNSS_precisionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timestampSpecified {
        get {
            return this.timestampFieldSpecified;
        }
        set {
            this.timestampFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double antennaDistanceFromFrontOfTrain {
        get {
            return this.antennaDistanceFromFrontOfTrainField;
        }
        set {
            this.antennaDistanceFromFrontOfTrainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool antennaDistanceFromFrontOfTrainSpecified {
        get {
            return this.antennaDistanceFromFrontOfTrainFieldSpecified;
        }
        set {
            this.antennaDistanceFromFrontOfTrainFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LastAbsoluteOdometryPoint : SegmentProfileIdentification_ComplexType {
    
    private double locationField;
    
    private bool locationFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool locationSpecified {
        get {
            return this.locationFieldSpecified;
        }
        set {
            this.locationFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NextTimingPointTrainInformation {
    
    private SP_Zone_ComplexType sP_ZoneField;
    
    private string tP_IDField;
    
    private string tP_abbreviationField;
    
    private NextTimingPointTrainInformationTP_StopSkipPass tP_StopSkipPassField;
    
    private bool tP_StopSkipPassFieldSpecified;
    
    private System.DateTime forecastedArrivalField;
    
    private bool forecastedArrivalFieldSpecified;
    
    private System.DateTime forecastedDepartureField;
    
    private bool forecastedDepartureFieldSpecified;
    
    /// <remarks/>
    public SP_Zone_ComplexType SP_Zone {
        get {
            return this.sP_ZoneField;
        }
        set {
            this.sP_ZoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TP_ID {
        get {
            return this.tP_IDField;
        }
        set {
            this.tP_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TP_abbreviation {
        get {
            return this.tP_abbreviationField;
        }
        set {
            this.tP_abbreviationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NextTimingPointTrainInformationTP_StopSkipPass TP_StopSkipPass {
        get {
            return this.tP_StopSkipPassField;
        }
        set {
            this.tP_StopSkipPassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TP_StopSkipPassSpecified {
        get {
            return this.tP_StopSkipPassFieldSpecified;
        }
        set {
            this.tP_StopSkipPassFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime forecastedArrival {
        get {
            return this.forecastedArrivalField;
        }
        set {
            this.forecastedArrivalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool forecastedArrivalSpecified {
        get {
            return this.forecastedArrivalFieldSpecified;
        }
        set {
            this.forecastedArrivalFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime forecastedDeparture {
        get {
            return this.forecastedDepartureField;
        }
        set {
            this.forecastedDepartureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool forecastedDepartureSpecified {
        get {
            return this.forecastedDepartureFieldSpecified;
        }
        set {
            this.forecastedDepartureFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum NextTimingPointTrainInformationTP_StopSkipPass {
    
    /// <remarks/>
    Stopping_Point,
    
    /// <remarks/>
    Skipped_Stopping_Point,
    
    /// <remarks/>
    Passing_Point,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class PreviousTimingPointTrainInformation {
    
    private SP_Zone_ComplexType sP_ZoneField;
    
    private string tP_IDField;
    
    private string tP_abbreviationField;
    
    private NextTimingPointTrainInformationTP_StopSkipPass tP_StopSkipPassField;
    
    private bool tP_StopSkipPassFieldSpecified;
    
    private System.DateTime arrivalTimeField;
    
    private bool arrivalTimeFieldSpecified;
    
    private System.DateTime departureTimeField;
    
    private bool departureTimeFieldSpecified;
    
    /// <remarks/>
    public SP_Zone_ComplexType SP_Zone {
        get {
            return this.sP_ZoneField;
        }
        set {
            this.sP_ZoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TP_ID {
        get {
            return this.tP_IDField;
        }
        set {
            this.tP_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TP_abbreviation {
        get {
            return this.tP_abbreviationField;
        }
        set {
            this.tP_abbreviationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NextTimingPointTrainInformationTP_StopSkipPass TP_StopSkipPass {
        get {
            return this.tP_StopSkipPassField;
        }
        set {
            this.tP_StopSkipPassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TP_StopSkipPassSpecified {
        get {
            return this.tP_StopSkipPassFieldSpecified;
        }
        set {
            this.tP_StopSkipPassFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime arrivalTime {
        get {
            return this.arrivalTimeField;
        }
        set {
            this.arrivalTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool arrivalTimeSpecified {
        get {
            return this.arrivalTimeFieldSpecified;
        }
        set {
            this.arrivalTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime departureTime {
        get {
            return this.departureTimeField;
        }
        set {
            this.departureTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool departureTimeSpecified {
        get {
            return this.departureTimeFieldSpecified;
        }
        set {
            this.departureTimeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LastPassedKmRef {
    
    private double kmRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double kmRef {
        get {
            return this.kmRefField;
        }
        set {
            this.kmRefField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LastPassedSignal {
    
    private string signal_ID_PhysicalField;
    
    private string signal_ID_ObjectField;
    
    private bool atSignalField;
    
    private bool atSignalFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string signal_ID_Physical {
        get {
            return this.signal_ID_PhysicalField;
        }
        set {
            this.signal_ID_PhysicalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string signal_ID_Object {
        get {
            return this.signal_ID_ObjectField;
        }
        set {
            this.signal_ID_ObjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool AtSignal {
        get {
            return this.atSignalField;
        }
        set {
            this.atSignalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AtSignalSpecified {
        get {
            return this.atSignalFieldSpecified;
        }
        set {
            this.atSignalFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Delay {
    
    private string delay1Field;
    
    private DelayDelayCategory delayCategoryField;
    
    private bool delayCategoryFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("Delay", DataType="duration")]
    public string Delay1 {
        get {
            return this.delay1Field;
        }
        set {
            this.delay1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DelayDelayCategory DelayCategory {
        get {
            return this.delayCategoryField;
        }
        set {
            this.delayCategoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DelayCategorySpecified {
        get {
            return this.delayCategoryFieldSpecified;
        }
        set {
            this.delayCategoryFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum DelayDelayCategory {
    
    /// <remarks/>
    Measured,
    
    /// <remarks/>
    Expected,
    
    /// <remarks/>
    Upcoming,
    
    /// <remarks/>
    Unknown,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SP_GenericPoint_ComplexType {
    
    private string identifierField;
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class PhysicalCharacteristics_ComplexType {
    
    private PhysicalCharacteristics_NSPs[] physicalCharacteristics_NSPsField;
    
    private double horizontalOffsetField;
    
    private bool horizontalOffsetFieldSpecified;
    
    private double verticalOffsetField;
    
    private bool verticalOffsetFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PhysicalCharacteristics_NSPs")]
    public PhysicalCharacteristics_NSPs[] PhysicalCharacteristics_NSPs {
        get {
            return this.physicalCharacteristics_NSPsField;
        }
        set {
            this.physicalCharacteristics_NSPsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double horizontalOffset {
        get {
            return this.horizontalOffsetField;
        }
        set {
            this.horizontalOffsetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool horizontalOffsetSpecified {
        get {
            return this.horizontalOffsetFieldSpecified;
        }
        set {
            this.horizontalOffsetFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double verticalOffset {
        get {
            return this.verticalOffsetField;
        }
        set {
            this.verticalOffsetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool verticalOffsetSpecified {
        get {
            return this.verticalOffsetFieldSpecified;
        }
        set {
            this.verticalOffsetFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class PhysicalCharacteristics_NSPs : NSPList_ComplexType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("BFC_NSPs", Namespace="", IsNullable=false)]
public partial class NSPList_ComplexType {
    
    private NetworkSpecificParameter[] networkSpecificParameterField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificParameter")]
    public NetworkSpecificParameter[] NetworkSpecificParameter {
        get {
            return this.networkSpecificParameterField;
        }
        set {
            this.networkSpecificParameterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NetworkSpecificParameter {
    
    private string nameField;
    
    private string valueField;
    
    private string descriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Error_ComplexType {
    
    private string errorCodeField;
    
    private System.Xml.XmlQualifiedName xPathField;
    
    private string additionalInfoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string errorCode {
        get {
            return this.errorCodeField;
        }
        set {
            this.errorCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName XPath {
        get {
            return this.xPathField;
        }
        set {
            this.xPathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string additionalInfo {
        get {
            return this.additionalInfoField;
        }
        set {
            this.additionalInfoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("ATP_SystemsStart", Namespace="", IsNullable=false)]
public partial class ATPSystems_ComplexType {
    
    private ATP_System_Identifier[] aTP_System_IdentifierField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ATP_System_Identifier")]
    public ATP_System_Identifier[] ATP_System_Identifier {
        get {
            return this.aTP_System_IdentifierField;
        }
        set {
            this.aTP_System_IdentifierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TC_Identifier_ComplexType {
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    private string tC_IDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("KeeperShortNameVKM", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("TC_RU_ID", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TC_ID {
        get {
            return this.tC_IDField;
        }
        set {
            this.tC_IDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    KeeperShortNameVKM,
    
    /// <remarks/>
    TC_RU_ID,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("OTN_ID", Namespace="", IsNullable=false)]
public partial class OTN_ID_ComplexType {
    
    private string companyField;
    
    private string operationalTrainNumberField;
    
    private string additionalTrainNumberField;
    
    private System.DateTime startDateField;
    
    /// <remarks/>
    public string Company {
        get {
            return this.companyField;
        }
        set {
            this.companyField = value;
        }
    }
    
    /// <remarks/>
    public string OperationalTrainNumber {
        get {
            return this.operationalTrainNumberField;
        }
        set {
            this.operationalTrainNumberField = value;
        }
    }
    
    /// <remarks/>
    public string AdditionalTrainNumber {
        get {
            return this.additionalTrainNumberField;
        }
        set {
            this.additionalTrainNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime StartDate {
        get {
            return this.startDateField;
        }
        set {
            this.startDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class MessageReference {
    
    private string messageTypeField;
    
    private string messageTypeVersionField;
    
    private string messageIdentifierField;
    
    private System.DateTime messageDateTimeField;
    
    /// <remarks/>
    public string MessageType {
        get {
            return this.messageTypeField;
        }
        set {
            this.messageTypeField = value;
        }
    }
    
    /// <remarks/>
    public string MessageTypeVersion {
        get {
            return this.messageTypeVersionField;
        }
        set {
            this.messageTypeVersionField = value;
        }
    }
    
    /// <remarks/>
    public string MessageIdentifier {
        get {
            return this.messageIdentifierField;
        }
        set {
            this.messageIdentifierField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime MessageDateTime {
        get {
            return this.messageDateTimeField;
        }
        set {
            this.messageDateTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Sender {
    
    private string cI_InstanceNumberField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string CI_InstanceNumber {
        get {
            return this.cI_InstanceNumberField;
        }
        set {
            this.cI_InstanceNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Recipient {
    
    private string cI_InstanceNumberField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string CI_InstanceNumber {
        get {
            return this.cI_InstanceNumberField;
        }
        set {
            this.cI_InstanceNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class B2G_StatusReport {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private PositionSpeed positionSpeedField;
    
    private PreviousTimingPoint previousTimingPointField;
    
    private TimingPointEstimation[] timingPointEstimationField;
    
    private AdhesionConditionsChange adhesionConditionsChangeField;
    
    private ExpectedCurrentData[] expectedCurrentDataField;
    
    private TrainCharacteristicsChange trainCharacteristicsChangeField;
    
    private PlaintextMessage plaintextMessageField;
    
    private JP_InUse jP_InUseField;
    
    private C_DAS_C_Shown c_DAS_C_ShownField;
    
    private TrainReadyStatus trainReadyStatusField;
    
    private DelayNotice delayNoticeField;
    
    private InterruptionPoint interruptionPointField;
    
    private EnergyData energyDataField;
    
    private NSPList_ComplexType[] statusReport_NSPsField;
    
    private string identifierField;
    
    private DAS_ModesComplexTypeDAS_drivingMode dAS_drivingModeField;
    
    private bool dAS_drivingModeFieldSpecified;
    
    private B2G_StatusReportATO_State aTO_StateField;
    
    private bool aTO_StateFieldSpecified;
    
    private bool jP_SP_ConsistencyErrorField;
    
    private bool jP_SP_ConsistencyErrorFieldSpecified;
    
    private bool nextStoppingPointSkipField;
    
    private bool nextStoppingPointSkipFieldSpecified;
    
    private bool slipSlideReportedField;
    
    private bool slipSlideReportedFieldSpecified;
    
    private bool operationalConditionsFulfillmentField;
    
    private bool operationalConditionsFulfillmentFieldSpecified;
    
    private bool trainMovingField;
    
    private bool trainMovingFieldSpecified;
    
    private bool unableToStopField;
    
    private bool unableToStopFieldSpecified;
    
    private string driverIDField;
    
    private bool routingErrorField;
    
    private bool routingErrorFieldSpecified;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public PositionSpeed PositionSpeed {
        get {
            return this.positionSpeedField;
        }
        set {
            this.positionSpeedField = value;
        }
    }
    
    /// <remarks/>
    public PreviousTimingPoint PreviousTimingPoint {
        get {
            return this.previousTimingPointField;
        }
        set {
            this.previousTimingPointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TimingPointEstimation")]
    public TimingPointEstimation[] TimingPointEstimation {
        get {
            return this.timingPointEstimationField;
        }
        set {
            this.timingPointEstimationField = value;
        }
    }
    
    /// <remarks/>
    public AdhesionConditionsChange AdhesionConditionsChange {
        get {
            return this.adhesionConditionsChangeField;
        }
        set {
            this.adhesionConditionsChangeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ExpectedCurrentData")]
    public ExpectedCurrentData[] ExpectedCurrentData {
        get {
            return this.expectedCurrentDataField;
        }
        set {
            this.expectedCurrentDataField = value;
        }
    }
    
    /// <remarks/>
    public TrainCharacteristicsChange TrainCharacteristicsChange {
        get {
            return this.trainCharacteristicsChangeField;
        }
        set {
            this.trainCharacteristicsChangeField = value;
        }
    }
    
    /// <remarks/>
    public PlaintextMessage PlaintextMessage {
        get {
            return this.plaintextMessageField;
        }
        set {
            this.plaintextMessageField = value;
        }
    }
    
    /// <remarks/>
    public JP_InUse JP_InUse {
        get {
            return this.jP_InUseField;
        }
        set {
            this.jP_InUseField = value;
        }
    }
    
    /// <remarks/>
    public C_DAS_C_Shown C_DAS_C_Shown {
        get {
            return this.c_DAS_C_ShownField;
        }
        set {
            this.c_DAS_C_ShownField = value;
        }
    }
    
    /// <remarks/>
    public TrainReadyStatus TrainReadyStatus {
        get {
            return this.trainReadyStatusField;
        }
        set {
            this.trainReadyStatusField = value;
        }
    }
    
    /// <remarks/>
    public DelayNotice DelayNotice {
        get {
            return this.delayNoticeField;
        }
        set {
            this.delayNoticeField = value;
        }
    }
    
    /// <remarks/>
    public InterruptionPoint InterruptionPoint {
        get {
            return this.interruptionPointField;
        }
        set {
            this.interruptionPointField = value;
        }
    }
    
    /// <remarks/>
    public EnergyData EnergyData {
        get {
            return this.energyDataField;
        }
        set {
            this.energyDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("StatusReport_NSPs")]
    public NSPList_ComplexType[] StatusReport_NSPs {
        get {
            return this.statusReport_NSPsField;
        }
        set {
            this.statusReport_NSPsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DAS_ModesComplexTypeDAS_drivingMode DAS_drivingMode {
        get {
            return this.dAS_drivingModeField;
        }
        set {
            this.dAS_drivingModeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DAS_drivingModeSpecified {
        get {
            return this.dAS_drivingModeFieldSpecified;
        }
        set {
            this.dAS_drivingModeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public B2G_StatusReportATO_State ATO_State {
        get {
            return this.aTO_StateField;
        }
        set {
            this.aTO_StateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ATO_StateSpecified {
        get {
            return this.aTO_StateFieldSpecified;
        }
        set {
            this.aTO_StateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool JP_SP_ConsistencyError {
        get {
            return this.jP_SP_ConsistencyErrorField;
        }
        set {
            this.jP_SP_ConsistencyErrorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool JP_SP_ConsistencyErrorSpecified {
        get {
            return this.jP_SP_ConsistencyErrorFieldSpecified;
        }
        set {
            this.jP_SP_ConsistencyErrorFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool nextStoppingPointSkip {
        get {
            return this.nextStoppingPointSkipField;
        }
        set {
            this.nextStoppingPointSkipField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool nextStoppingPointSkipSpecified {
        get {
            return this.nextStoppingPointSkipFieldSpecified;
        }
        set {
            this.nextStoppingPointSkipFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool slipSlideReported {
        get {
            return this.slipSlideReportedField;
        }
        set {
            this.slipSlideReportedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slipSlideReportedSpecified {
        get {
            return this.slipSlideReportedFieldSpecified;
        }
        set {
            this.slipSlideReportedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool operationalConditionsFulfillment {
        get {
            return this.operationalConditionsFulfillmentField;
        }
        set {
            this.operationalConditionsFulfillmentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool operationalConditionsFulfillmentSpecified {
        get {
            return this.operationalConditionsFulfillmentFieldSpecified;
        }
        set {
            this.operationalConditionsFulfillmentFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool trainMoving {
        get {
            return this.trainMovingField;
        }
        set {
            this.trainMovingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool trainMovingSpecified {
        get {
            return this.trainMovingFieldSpecified;
        }
        set {
            this.trainMovingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool unableToStop {
        get {
            return this.unableToStopField;
        }
        set {
            this.unableToStopField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool unableToStopSpecified {
        get {
            return this.unableToStopFieldSpecified;
        }
        set {
            this.unableToStopFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string driverID {
        get {
            return this.driverIDField;
        }
        set {
            this.driverIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool routingError {
        get {
            return this.routingErrorField;
        }
        set {
            this.routingErrorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool routingErrorSpecified {
        get {
            return this.routingErrorFieldSpecified;
        }
        set {
            this.routingErrorFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class PreviousTimingPoint : TimingPointIdentification_ComplexType {
    
    private PreviousTimingPointTP_Pass_Stop_Depart tP_Pass_Stop_DepartField;
    
    private bool tP_Pass_Stop_DepartFieldSpecified;
    
    private PreviousTimingPointTP_Accurate_Stopping tP_Accurate_StoppingField;
    
    private bool tP_Accurate_StoppingFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public PreviousTimingPointTP_Pass_Stop_Depart TP_Pass_Stop_Depart {
        get {
            return this.tP_Pass_Stop_DepartField;
        }
        set {
            this.tP_Pass_Stop_DepartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TP_Pass_Stop_DepartSpecified {
        get {
            return this.tP_Pass_Stop_DepartFieldSpecified;
        }
        set {
            this.tP_Pass_Stop_DepartFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public PreviousTimingPointTP_Accurate_Stopping TP_Accurate_Stopping {
        get {
            return this.tP_Accurate_StoppingField;
        }
        set {
            this.tP_Accurate_StoppingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TP_Accurate_StoppingSpecified {
        get {
            return this.tP_Accurate_StoppingFieldSpecified;
        }
        set {
            this.tP_Accurate_StoppingFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum PreviousTimingPointTP_Pass_Stop_Depart {
    
    /// <remarks/>
    Passed,
    
    /// <remarks/>
    Stopped,
    
    /// <remarks/>
    Departed,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum PreviousTimingPointTP_Accurate_Stopping {
    
    /// <remarks/>
    Undershoot,
    
    /// <remarks/>
    Accurate,
    
    /// <remarks/>
    Overshoot,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("StationAheadSign", Namespace="", IsNullable=false)]
public partial class TimingPointIdentification_ComplexType {
    
    private SP_Zone_ComplexType sP_ZoneField;
    
    private string tP_IDField;
    
    /// <remarks/>
    public SP_Zone_ComplexType SP_Zone {
        get {
            return this.sP_ZoneField;
        }
        set {
            this.sP_ZoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TP_ID {
        get {
            return this.tP_IDField;
        }
        set {
            this.tP_IDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TimingPointEstimation {
    
    private SP_Zone_ComplexType sP_ZoneField;
    
    private string tP_IDField;
    
    private System.DateTime forecastedArrivalField;
    
    /// <remarks/>
    public SP_Zone_ComplexType SP_Zone {
        get {
            return this.sP_ZoneField;
        }
        set {
            this.sP_ZoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TP_ID {
        get {
            return this.tP_IDField;
        }
        set {
            this.tP_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime forecastedArrival {
        get {
            return this.forecastedArrivalField;
        }
        set {
            this.forecastedArrivalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class AdhesionConditionsChange {
    
    private AdhesionConditionsChangeNewAdhesionConditions newAdhesionConditionsField;
    
    private adhesionCategoryType lowAdhesionCategoryField;
    
    private bool lowAdhesionCategoryFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AdhesionConditionsChangeNewAdhesionConditions newAdhesionConditions {
        get {
            return this.newAdhesionConditionsField;
        }
        set {
            this.newAdhesionConditionsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public adhesionCategoryType lowAdhesionCategory {
        get {
            return this.lowAdhesionCategoryField;
        }
        set {
            this.lowAdhesionCategoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool lowAdhesionCategorySpecified {
        get {
            return this.lowAdhesionCategoryFieldSpecified;
        }
        set {
            this.lowAdhesionCategoryFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum AdhesionConditionsChangeNewAdhesionConditions {
    
    /// <remarks/>
    Better,
    
    /// <remarks/>
    Worse,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum adhesionCategoryType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Dry Rail")]
    DryRail,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Dry Rail (Medium)")]
    DryRailMedium,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Dry Rail (Low)")]
    DryRailLow,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Low Adhesion")]
    LowAdhesion,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Very Low Adhesion")]
    VeryLowAdhesion,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Extremely Low Adhesion")]
    ExtremelyLowAdhesion,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ExpectedCurrentData {
    
    private System.DateTime startTimeField;
    
    private bool startTimeFieldSpecified;
    
    private System.DateTime endTimeField;
    
    private bool endTimeFieldSpecified;
    
    private decimal expectedConsumptionCurrentField;
    
    private decimal expectedRegenerativeCurrentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime startTime {
        get {
            return this.startTimeField;
        }
        set {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startTimeSpecified {
        get {
            return this.startTimeFieldSpecified;
        }
        set {
            this.startTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime endTime {
        get {
            return this.endTimeField;
        }
        set {
            this.endTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endTimeSpecified {
        get {
            return this.endTimeFieldSpecified;
        }
        set {
            this.endTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal expectedConsumptionCurrent {
        get {
            return this.expectedConsumptionCurrentField;
        }
        set {
            this.expectedConsumptionCurrentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal expectedRegenerativeCurrent {
        get {
            return this.expectedRegenerativeCurrentField;
        }
        set {
            this.expectedRegenerativeCurrentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TrainCharacteristicsChange : TC_Identifier_ComplexType {
    
    private TC_ChangeFeatures tC_ChangeFeaturesField;
    
    /// <remarks/>
    public TC_ChangeFeatures TC_ChangeFeatures {
        get {
            return this.tC_ChangeFeaturesField;
        }
        set {
            this.tC_ChangeFeaturesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TC_ChangeFeatures : TC_Features_ComplexType {
    
    private UnavailableTractionType[] unavailableTractionTypeField;
    
    private decimal remainingEnginePowerField;
    
    private bool remainingEnginePowerFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("UnavailableTractionType")]
    public UnavailableTractionType[] UnavailableTractionType {
        get {
            return this.unavailableTractionTypeField;
        }
        set {
            this.unavailableTractionTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal remainingEnginePower {
        get {
            return this.remainingEnginePowerField;
        }
        set {
            this.remainingEnginePowerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool remainingEnginePowerSpecified {
        get {
            return this.remainingEnginePowerFieldSpecified;
        }
        set {
            this.remainingEnginePowerFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class UnavailableTractionType : TractionType_ComplexType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("TFC_TractionType", Namespace="", IsNullable=false)]
public partial class TractionType_ComplexType {
    
    private object itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Electrical", typeof(TractionType_ComplexTypeElectrical))]
    [System.Xml.Serialization.XmlElementAttribute("Powerless", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("Self-propelled", typeof(object))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType1 ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TractionType_ComplexTypeElectrical : Voltage_ComplexType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("EstimatedVoltageStart", Namespace="", IsNullable=false)]
public partial class Voltage_ComplexType {
    
    private int voltageValueField;
    
    private decimal frequencyField;
    
    private byte nID_CTRACTIONField;
    
    private bool nID_CTRACTIONFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int voltageValue {
        get {
            return this.voltageValueField;
        }
        set {
            this.voltageValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal frequency {
        get {
            return this.frequencyField;
        }
        set {
            this.frequencyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte NID_CTRACTION {
        get {
            return this.nID_CTRACTIONField;
        }
        set {
            this.nID_CTRACTIONField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NID_CTRACTIONSpecified {
        get {
            return this.nID_CTRACTIONFieldSpecified;
        }
        set {
            this.nID_CTRACTIONFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    Electrical,
    
    /// <remarks/>
    Powerless,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Self-propelled")]
    Selfpropelled,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("TC_Features", Namespace="", IsNullable=false)]
public partial class TC_Features_ComplexType {
    
    private Train_ATP_Systems train_ATP_SystemsField;
    
    private TractionForceCurve_ComplexType[] tractionForceCurveField;
    
    private BrakingForceCurve_ComplexType[] brakingForceCurveField;
    
    private VehicleData[] vehicleDataField;
    
    private NSPList_ComplexType[] tC_Features_NSPsField;
    
    private string trainLengthField;
    
    private string trainMaxSpeedField;
    
    private int trainWeightField;
    
    private bool trainWeightFieldSpecified;
    
    private double comfortableAccelerationField;
    
    private bool comfortableAccelerationFieldSpecified;
    
    private double comfortableBrakingField;
    
    private bool comfortableBrakingFieldSpecified;
    
    private double maximumRegenerativeForceField;
    
    private bool maximumRegenerativeForceFieldSpecified;
    
    private double maximumRegenerativeBrakingField;
    
    private bool maximumRegenerativeBrakingFieldSpecified;
    
    private double enginePowerField;
    
    private bool enginePowerFieldSpecified;
    
    private double rolloutCoefficientAField;
    
    private bool rolloutCoefficientAFieldSpecified;
    
    private double rolloutCoefficientBField;
    
    private bool rolloutCoefficientBFieldSpecified;
    
    private double rolloutCoefficientCField;
    
    private bool rolloutCoefficientCFieldSpecified;
    
    private string rollingStockTypeField;
    
    private decimal brakedWeightPercentageField;
    
    private bool brakedWeightPercentageFieldSpecified;
    
    private string brakingReactionTimeField;
    
    private int tractionReactionTimeField;
    
    private bool tractionReactionTimeFieldSpecified;
    
    private decimal rotatingMassFactorField;
    
    private bool rotatingMassFactorFieldSpecified;
    
    private int enginesField;
    
    private bool enginesFieldSpecified;
    
    private int wagonsField;
    
    private bool wagonsFieldSpecified;
    
    private decimal trp_beField;
    
    private bool trp_beFieldSpecified;
    
    private decimal trp_bwField;
    
    private bool trp_bwFieldSpecified;
    
    private decimal trp_aeField;
    
    private bool trp_aeFieldSpecified;
    
    private decimal trp_awField;
    
    private bool trp_awFieldSpecified;
    
    private NC_TrainType nC_TrainField;
    
    private bool nC_TrainFieldSpecified;
    
    private NC_CDTrainType nC_CDTrainField;
    
    private bool nC_CDTrainFieldSpecified;
    
    private string trainCategoryCodeField;
    
    private string displayNameField;
    
    private TC_Features_ComplexTypeAxleLoadCategory axleLoadCategoryField;
    
    private bool axleLoadCategoryFieldSpecified;
    
    private double positionOfLastPantographField;
    
    private bool positionOfLastPantographFieldSpecified;
    
    /// <remarks/>
    public Train_ATP_Systems Train_ATP_Systems {
        get {
            return this.train_ATP_SystemsField;
        }
        set {
            this.train_ATP_SystemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TractionForceCurve")]
    public TractionForceCurve_ComplexType[] TractionForceCurve {
        get {
            return this.tractionForceCurveField;
        }
        set {
            this.tractionForceCurveField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BrakingForceCurve")]
    public BrakingForceCurve_ComplexType[] BrakingForceCurve {
        get {
            return this.brakingForceCurveField;
        }
        set {
            this.brakingForceCurveField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("VehicleData")]
    public VehicleData[] VehicleData {
        get {
            return this.vehicleDataField;
        }
        set {
            this.vehicleDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TC_Features_NSPs")]
    public NSPList_ComplexType[] TC_Features_NSPs {
        get {
            return this.tC_Features_NSPsField;
        }
        set {
            this.tC_Features_NSPsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string trainLength {
        get {
            return this.trainLengthField;
        }
        set {
            this.trainLengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string trainMaxSpeed {
        get {
            return this.trainMaxSpeedField;
        }
        set {
            this.trainMaxSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int trainWeight {
        get {
            return this.trainWeightField;
        }
        set {
            this.trainWeightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool trainWeightSpecified {
        get {
            return this.trainWeightFieldSpecified;
        }
        set {
            this.trainWeightFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double comfortableAcceleration {
        get {
            return this.comfortableAccelerationField;
        }
        set {
            this.comfortableAccelerationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool comfortableAccelerationSpecified {
        get {
            return this.comfortableAccelerationFieldSpecified;
        }
        set {
            this.comfortableAccelerationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double comfortableBraking {
        get {
            return this.comfortableBrakingField;
        }
        set {
            this.comfortableBrakingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool comfortableBrakingSpecified {
        get {
            return this.comfortableBrakingFieldSpecified;
        }
        set {
            this.comfortableBrakingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double maximumRegenerativeForce {
        get {
            return this.maximumRegenerativeForceField;
        }
        set {
            this.maximumRegenerativeForceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maximumRegenerativeForceSpecified {
        get {
            return this.maximumRegenerativeForceFieldSpecified;
        }
        set {
            this.maximumRegenerativeForceFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double maximumRegenerativeBraking {
        get {
            return this.maximumRegenerativeBrakingField;
        }
        set {
            this.maximumRegenerativeBrakingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maximumRegenerativeBrakingSpecified {
        get {
            return this.maximumRegenerativeBrakingFieldSpecified;
        }
        set {
            this.maximumRegenerativeBrakingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double enginePower {
        get {
            return this.enginePowerField;
        }
        set {
            this.enginePowerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool enginePowerSpecified {
        get {
            return this.enginePowerFieldSpecified;
        }
        set {
            this.enginePowerFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double rolloutCoefficientA {
        get {
            return this.rolloutCoefficientAField;
        }
        set {
            this.rolloutCoefficientAField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool rolloutCoefficientASpecified {
        get {
            return this.rolloutCoefficientAFieldSpecified;
        }
        set {
            this.rolloutCoefficientAFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double rolloutCoefficientB {
        get {
            return this.rolloutCoefficientBField;
        }
        set {
            this.rolloutCoefficientBField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool rolloutCoefficientBSpecified {
        get {
            return this.rolloutCoefficientBFieldSpecified;
        }
        set {
            this.rolloutCoefficientBFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double rolloutCoefficientC {
        get {
            return this.rolloutCoefficientCField;
        }
        set {
            this.rolloutCoefficientCField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool rolloutCoefficientCSpecified {
        get {
            return this.rolloutCoefficientCFieldSpecified;
        }
        set {
            this.rolloutCoefficientCFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rollingStockType {
        get {
            return this.rollingStockTypeField;
        }
        set {
            this.rollingStockTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal brakedWeightPercentage {
        get {
            return this.brakedWeightPercentageField;
        }
        set {
            this.brakedWeightPercentageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool brakedWeightPercentageSpecified {
        get {
            return this.brakedWeightPercentageFieldSpecified;
        }
        set {
            this.brakedWeightPercentageFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
    public string brakingReactionTime {
        get {
            return this.brakingReactionTimeField;
        }
        set {
            this.brakingReactionTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int tractionReactionTime {
        get {
            return this.tractionReactionTimeField;
        }
        set {
            this.tractionReactionTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tractionReactionTimeSpecified {
        get {
            return this.tractionReactionTimeFieldSpecified;
        }
        set {
            this.tractionReactionTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal rotatingMassFactor {
        get {
            return this.rotatingMassFactorField;
        }
        set {
            this.rotatingMassFactorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool rotatingMassFactorSpecified {
        get {
            return this.rotatingMassFactorFieldSpecified;
        }
        set {
            this.rotatingMassFactorFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int engines {
        get {
            return this.enginesField;
        }
        set {
            this.enginesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool enginesSpecified {
        get {
            return this.enginesFieldSpecified;
        }
        set {
            this.enginesFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int wagons {
        get {
            return this.wagonsField;
        }
        set {
            this.wagonsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool wagonsSpecified {
        get {
            return this.wagonsFieldSpecified;
        }
        set {
            this.wagonsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal trp_be {
        get {
            return this.trp_beField;
        }
        set {
            this.trp_beField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool trp_beSpecified {
        get {
            return this.trp_beFieldSpecified;
        }
        set {
            this.trp_beFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal trp_bw {
        get {
            return this.trp_bwField;
        }
        set {
            this.trp_bwField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool trp_bwSpecified {
        get {
            return this.trp_bwFieldSpecified;
        }
        set {
            this.trp_bwFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal trp_ae {
        get {
            return this.trp_aeField;
        }
        set {
            this.trp_aeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool trp_aeSpecified {
        get {
            return this.trp_aeFieldSpecified;
        }
        set {
            this.trp_aeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal trp_aw {
        get {
            return this.trp_awField;
        }
        set {
            this.trp_awField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool trp_awSpecified {
        get {
            return this.trp_awFieldSpecified;
        }
        set {
            this.trp_awFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NC_TrainType NC_Train {
        get {
            return this.nC_TrainField;
        }
        set {
            this.nC_TrainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NC_TrainSpecified {
        get {
            return this.nC_TrainFieldSpecified;
        }
        set {
            this.nC_TrainFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NC_CDTrainType NC_CDTrain {
        get {
            return this.nC_CDTrainField;
        }
        set {
            this.nC_CDTrainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NC_CDTrainSpecified {
        get {
            return this.nC_CDTrainFieldSpecified;
        }
        set {
            this.nC_CDTrainFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trainCategoryCode {
        get {
            return this.trainCategoryCodeField;
        }
        set {
            this.trainCategoryCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName {
        get {
            return this.displayNameField;
        }
        set {
            this.displayNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public TC_Features_ComplexTypeAxleLoadCategory axleLoadCategory {
        get {
            return this.axleLoadCategoryField;
        }
        set {
            this.axleLoadCategoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool axleLoadCategorySpecified {
        get {
            return this.axleLoadCategoryFieldSpecified;
        }
        set {
            this.axleLoadCategoryFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double positionOfLastPantograph {
        get {
            return this.positionOfLastPantographField;
        }
        set {
            this.positionOfLastPantographField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool positionOfLastPantographSpecified {
        get {
            return this.positionOfLastPantographFieldSpecified;
        }
        set {
            this.positionOfLastPantographFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Train_ATP_Systems : ATPSystems_ComplexType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("TractionForceCurve", Namespace="", IsNullable=false)]
public partial class TractionForceCurve_ComplexType {
    
    private TractionForceCurveDataPoint[] tractionForceCurveDataPointField;
    
    private NSPList_ComplexType[] tFC_NSPsField;
    
    private TractionType_ComplexType tFC_TractionTypeField;
    
    private string identifierField;
    
    private int tFC_estimatedVoltageField;
    
    private bool tFC_estimatedVoltageFieldSpecified;
    
    private decimal tFC_maxCurrentValueField;
    
    private bool tFC_maxCurrentValueFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TractionForceCurveDataPoint")]
    public TractionForceCurveDataPoint[] TractionForceCurveDataPoint {
        get {
            return this.tractionForceCurveDataPointField;
        }
        set {
            this.tractionForceCurveDataPointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TFC_NSPs")]
    public NSPList_ComplexType[] TFC_NSPs {
        get {
            return this.tFC_NSPsField;
        }
        set {
            this.tFC_NSPsField = value;
        }
    }
    
    /// <remarks/>
    public TractionType_ComplexType TFC_TractionType {
        get {
            return this.tFC_TractionTypeField;
        }
        set {
            this.tFC_TractionTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int TFC_estimatedVoltage {
        get {
            return this.tFC_estimatedVoltageField;
        }
        set {
            this.tFC_estimatedVoltageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TFC_estimatedVoltageSpecified {
        get {
            return this.tFC_estimatedVoltageFieldSpecified;
        }
        set {
            this.tFC_estimatedVoltageFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TFC_maxCurrentValue {
        get {
            return this.tFC_maxCurrentValueField;
        }
        set {
            this.tFC_maxCurrentValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TFC_maxCurrentValueSpecified {
        get {
            return this.tFC_maxCurrentValueFieldSpecified;
        }
        set {
            this.tFC_maxCurrentValueFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TractionForceCurveDataPoint {
    
    private decimal speedField;
    
    private decimal tractionForceField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal speed {
        get {
            return this.speedField;
        }
        set {
            this.speedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal tractionForce {
        get {
            return this.tractionForceField;
        }
        set {
            this.tractionForceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("BrakingForceCurve", Namespace="", IsNullable=false)]
public partial class BrakingForceCurve_ComplexType {
    
    private BrakingForceCurveDataPoint[] brakingForceCurveDataPointField;
    
    private ATP_System_Identifier[] aTP_System_IdentifierField;
    
    private BFC_TractionType[] bFC_TractionTypeField;
    
    private NSPList_ComplexType[] bFC_NSPsField;
    
    private string identifierField;
    
    private decimal highest_BFC_AdhesionRateField;
    
    private bool highest_BFC_AdhesionRateFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BrakingForceCurveDataPoint")]
    public BrakingForceCurveDataPoint[] BrakingForceCurveDataPoint {
        get {
            return this.brakingForceCurveDataPointField;
        }
        set {
            this.brakingForceCurveDataPointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ATP_System_Identifier")]
    public ATP_System_Identifier[] ATP_System_Identifier {
        get {
            return this.aTP_System_IdentifierField;
        }
        set {
            this.aTP_System_IdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BFC_TractionType")]
    public BFC_TractionType[] BFC_TractionType {
        get {
            return this.bFC_TractionTypeField;
        }
        set {
            this.bFC_TractionTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BFC_NSPs")]
    public NSPList_ComplexType[] BFC_NSPs {
        get {
            return this.bFC_NSPsField;
        }
        set {
            this.bFC_NSPsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal highest_BFC_AdhesionRate {
        get {
            return this.highest_BFC_AdhesionRateField;
        }
        set {
            this.highest_BFC_AdhesionRateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool highest_BFC_AdhesionRateSpecified {
        get {
            return this.highest_BFC_AdhesionRateFieldSpecified;
        }
        set {
            this.highest_BFC_AdhesionRateFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class BrakingForceCurveDataPoint {
    
    private decimal speedField;
    
    private decimal brakingForceField;
    
    private double maximumRegenerativeForceField;
    
    private bool maximumRegenerativeForceFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal speed {
        get {
            return this.speedField;
        }
        set {
            this.speedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal brakingForce {
        get {
            return this.brakingForceField;
        }
        set {
            this.brakingForceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double maximumRegenerativeForce {
        get {
            return this.maximumRegenerativeForceField;
        }
        set {
            this.maximumRegenerativeForceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maximumRegenerativeForceSpecified {
        get {
            return this.maximumRegenerativeForceFieldSpecified;
        }
        set {
            this.maximumRegenerativeForceFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class BFC_TractionType : TractionType_ComplexType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class VehicleData {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LocoData", typeof(LocoData))]
    [System.Xml.Serialization.XmlElementAttribute("WagonData", typeof(WagonData))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LocoData {
    
    private string tractionPositionInTrainField;
    
    private string locoWeightField;
    
    private string lengthOverBuffersField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string TractionPositionInTrain {
        get {
            return this.tractionPositionInTrainField;
        }
        set {
            this.tractionPositionInTrainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string LocoWeight {
        get {
            return this.locoWeightField;
        }
        set {
            this.locoWeightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string LengthOverBuffers {
        get {
            return this.lengthOverBuffersField;
        }
        set {
            this.lengthOverBuffersField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class WagonData {
    
    private int wagonTrainPositionField;
    
    private bool wagonTrainPositionFieldSpecified;
    
    private int wagonMaxSpeedField;
    
    private bool wagonMaxSpeedFieldSpecified;
    
    private string totalLoadWeightField;
    
    private string wagonWeightEmptyField;
    
    private string lengthOverBuffersField;
    
    /// <remarks/>
    public int WagonTrainPosition {
        get {
            return this.wagonTrainPositionField;
        }
        set {
            this.wagonTrainPositionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool WagonTrainPositionSpecified {
        get {
            return this.wagonTrainPositionFieldSpecified;
        }
        set {
            this.wagonTrainPositionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public int WagonMaxSpeed {
        get {
            return this.wagonMaxSpeedField;
        }
        set {
            this.wagonMaxSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool WagonMaxSpeedSpecified {
        get {
            return this.wagonMaxSpeedFieldSpecified;
        }
        set {
            this.wagonMaxSpeedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string TotalLoadWeight {
        get {
            return this.totalLoadWeightField;
        }
        set {
            this.totalLoadWeightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string WagonWeightEmpty {
        get {
            return this.wagonWeightEmptyField;
        }
        set {
            this.wagonWeightEmptyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string LengthOverBuffers {
        get {
            return this.lengthOverBuffersField;
        }
        set {
            this.lengthOverBuffersField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum NC_TrainType {
    
    /// <remarks/>
    Freight_Train_P_Position,
    
    /// <remarks/>
    Freight_Train_G_Position,
    
    /// <remarks/>
    Passenger_Train,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum NC_CDTrainType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("80mm")]
    Item80mm,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("100mm")]
    Item100mm,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("130mm")]
    Item130mm,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("150mm")]
    Item150mm,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("165mm")]
    Item165mm,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("180mm")]
    Item180mm,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("210mm")]
    Item210mm,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("225mm")]
    Item225mm,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("245mm")]
    Item245mm,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("275mm")]
    Item275mm,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("300mm")]
    Item300mm,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum TC_Features_ComplexTypeAxleLoadCategory {
    
    /// <remarks/>
    A,
    
    /// <remarks/>
    HS17,
    
    /// <remarks/>
    B1,
    
    /// <remarks/>
    B2,
    
    /// <remarks/>
    C2,
    
    /// <remarks/>
    C3,
    
    /// <remarks/>
    C4,
    
    /// <remarks/>
    D2,
    
    /// <remarks/>
    D3,
    
    /// <remarks/>
    D4,
    
    /// <remarks/>
    D4XL,
    
    /// <remarks/>
    E4,
    
    /// <remarks/>
    E5,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class PlaintextMessage {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private string identifierField;
    
    private string messageStringField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string messageString {
        get {
            return this.messageStringField;
        }
        set {
            this.messageStringField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class JP_InUse {
    
    private string jP_VersionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string JP_Version {
        get {
            return this.jP_VersionField;
        }
        set {
            this.jP_VersionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class C_DAS_C_Shown {
    
    private string identifierField;
    
    private string message_IDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string message_ID {
        get {
            return this.message_IDField;
        }
        set {
            this.message_IDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TrainReadyStatus {
    
    private TrainReady trainReadyField;
    
    private LocationIdent trainLocationField;
    
    private TrainDelay trainDelayField;
    
    private DelayCode delayCauseField;
    
    private bool delayCauseFieldSpecified;
    
    private string preciseDelayCauseField;
    
    private System.DateTime trainReadyTimeField;
    
    private bool trainReadyTimeFieldSpecified;
    
    /// <remarks/>
    public TrainReady TrainReady {
        get {
            return this.trainReadyField;
        }
        set {
            this.trainReadyField = value;
        }
    }
    
    /// <remarks/>
    public LocationIdent TrainLocation {
        get {
            return this.trainLocationField;
        }
        set {
            this.trainLocationField = value;
        }
    }
    
    /// <remarks/>
    public TrainDelay TrainDelay {
        get {
            return this.trainDelayField;
        }
        set {
            this.trainDelayField = value;
        }
    }
    
    /// <remarks/>
    public DelayCode DelayCause {
        get {
            return this.delayCauseField;
        }
        set {
            this.delayCauseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DelayCauseSpecified {
        get {
            return this.delayCauseFieldSpecified;
        }
        set {
            this.delayCauseFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string PreciseDelayCause {
        get {
            return this.preciseDelayCauseField;
        }
        set {
            this.preciseDelayCauseField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime TrainReadyTime {
        get {
            return this.trainReadyTimeField;
        }
        set {
            this.trainReadyTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TrainReadyTimeSpecified {
        get {
            return this.trainReadyTimeFieldSpecified;
        }
        set {
            this.trainReadyTimeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum TrainReady {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("InterruptionLocation", Namespace="", IsNullable=false)]
public partial class LocationIdent {
    
    private CountryCodeISO countryCodeISOField;
    
    private string locationPrimaryCodeField;
    
    private string primaryLocationNameField;
    
    private LocationSubsidiaryIdentification locationSubsidiaryIdentificationField;
    
    /// <remarks/>
    public CountryCodeISO CountryCodeISO {
        get {
            return this.countryCodeISOField;
        }
        set {
            this.countryCodeISOField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string LocationPrimaryCode {
        get {
            return this.locationPrimaryCodeField;
        }
        set {
            this.locationPrimaryCodeField = value;
        }
    }
    
    /// <remarks/>
    public string PrimaryLocationName {
        get {
            return this.primaryLocationNameField;
        }
        set {
            this.primaryLocationNameField = value;
        }
    }
    
    /// <remarks/>
    public LocationSubsidiaryIdentification LocationSubsidiaryIdentification {
        get {
            return this.locationSubsidiaryIdentificationField;
        }
        set {
            this.locationSubsidiaryIdentificationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CountryCodeISO {
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LocationSubsidiaryIdentification {
    
    private LocationSubsidiaryCode locationSubsidiaryCodeField;
    
    private string allocationCompanyField;
    
    private string locationSubsidiaryNameField;
    
    /// <remarks/>
    public LocationSubsidiaryCode LocationSubsidiaryCode {
        get {
            return this.locationSubsidiaryCodeField;
        }
        set {
            this.locationSubsidiaryCodeField = value;
        }
    }
    
    /// <remarks/>
    public string AllocationCompany {
        get {
            return this.allocationCompanyField;
        }
        set {
            this.allocationCompanyField = value;
        }
    }
    
    /// <remarks/>
    public string LocationSubsidiaryName {
        get {
            return this.locationSubsidiaryNameField;
        }
        set {
            this.locationSubsidiaryNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LocationSubsidiaryCode {
    
    private LocationSubsidiaryCodeLocationSubsidiaryTypeCode locationSubsidiaryTypeCodeField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public LocationSubsidiaryCodeLocationSubsidiaryTypeCode LocationSubsidiaryTypeCode {
        get {
            return this.locationSubsidiaryTypeCodeField;
        }
        set {
            this.locationSubsidiaryTypeCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum LocationSubsidiaryCodeLocationSubsidiaryTypeCode {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("6")]
    Item6,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("7")]
    Item7,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("8")]
    Item8,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("9")]
    Item9,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("10")]
    Item10,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("11")]
    Item11,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("12")]
    Item12,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("13")]
    Item13,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("14")]
    Item14,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("15")]
    Item15,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("16")]
    Item16,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("17")]
    Item17,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("18")]
    Item18,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("19")]
    Item19,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("20")]
    Item20,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("21")]
    Item21,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("22")]
    Item22,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("23")]
    Item23,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("24")]
    Item24,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("25")]
    Item25,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("26")]
    Item26,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("27")]
    Item27,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("28")]
    Item28,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("29")]
    Item29,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("30")]
    Item30,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("32")]
    Item32,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("33")]
    Item33,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("34")]
    Item34,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("35")]
    Item35,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("36")]
    Item36,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("37")]
    Item37,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("38")]
    Item38,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("39")]
    Item39,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("40")]
    Item40,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("41")]
    Item41,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("42")]
    Item42,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("43")]
    Item43,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("44")]
    Item44,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("45")]
    Item45,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("46")]
    Item46,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("47")]
    Item47,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("48")]
    Item48,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("49")]
    Item49,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("50")]
    Item50,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("51")]
    Item51,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("52")]
    Item52,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("53")]
    Item53,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("54")]
    Item54,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("55")]
    Item55,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("56")]
    Item56,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("57")]
    Item57,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("58")]
    Item58,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("66")]
    Item66,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("90")]
    Item90,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("99")]
    Item99,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TrainDelay {
    
    private string againstBookedField;
    
    private string againstReferencedField;
    
    /// <remarks/>
    public string AgainstBooked {
        get {
            return this.againstBookedField;
        }
        set {
            this.againstBookedField = value;
        }
    }
    
    /// <remarks/>
    public string AgainstReferenced {
        get {
            return this.againstReferencedField;
        }
        set {
            this.againstReferencedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlRootAttribute("DelayCause", Namespace="", IsNullable=false)]
public enum DelayCode {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("11")]
    Item11,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("10")]
    Item10,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("12")]
    Item12,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("13")]
    Item13,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("14")]
    Item14,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("18")]
    Item18,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("19")]
    Item19,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("20")]
    Item20,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("21")]
    Item21,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("22")]
    Item22,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("23")]
    Item23,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("24")]
    Item24,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("25")]
    Item25,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("28")]
    Item28,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("29")]
    Item29,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("31")]
    Item31,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("30")]
    Item30,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("32")]
    Item32,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("39")]
    Item39,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("40")]
    Item40,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("41")]
    Item41,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("50")]
    Item50,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("51")]
    Item51,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("52")]
    Item52,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("53")]
    Item53,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("54")]
    Item54,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("58")]
    Item58,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("59")]
    Item59,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("60")]
    Item60,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("61")]
    Item61,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("62")]
    Item62,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("63")]
    Item63,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("64")]
    Item64,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("68")]
    Item68,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("70")]
    Item70,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("69")]
    Item69,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("71")]
    Item71,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("80")]
    Item80,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("81")]
    Item81,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("82")]
    Item82,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("83")]
    Item83,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("84")]
    Item84,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("89")]
    Item89,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("90")]
    Item90,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("91")]
    Item91,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("92")]
    Item92,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("93")]
    Item93,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("94")]
    Item94,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("95")]
    Item95,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DelayNotice {
    
    private DelayCode delayCauseField;
    
    private bool delayCauseFieldSpecified;
    
    private string preciseDelayCauseField;
    
    private LocationIdent trainLocationField;
    
    /// <remarks/>
    public DelayCode DelayCause {
        get {
            return this.delayCauseField;
        }
        set {
            this.delayCauseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DelayCauseSpecified {
        get {
            return this.delayCauseFieldSpecified;
        }
        set {
            this.delayCauseFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string PreciseDelayCause {
        get {
            return this.preciseDelayCauseField;
        }
        set {
            this.preciseDelayCauseField = value;
        }
    }
    
    /// <remarks/>
    public LocationIdent TrainLocation {
        get {
            return this.trainLocationField;
        }
        set {
            this.trainLocationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class InterruptionPoint {
    
    private LocationIdent interruptionLocationField;
    
    private string detailedDescriptionOfLocationField;
    
    private Interruption interruptionField;
    
    private InterruptionDuration interruptionDurationField;
    
    private string[] remarksField;
    
    /// <remarks/>
    public LocationIdent InterruptionLocation {
        get {
            return this.interruptionLocationField;
        }
        set {
            this.interruptionLocationField = value;
        }
    }
    
    /// <remarks/>
    public string DetailedDescriptionOfLocation {
        get {
            return this.detailedDescriptionOfLocationField;
        }
        set {
            this.detailedDescriptionOfLocationField = value;
        }
    }
    
    /// <remarks/>
    public Interruption Interruption {
        get {
            return this.interruptionField;
        }
        set {
            this.interruptionField = value;
        }
    }
    
    /// <remarks/>
    public InterruptionDuration InterruptionDuration {
        get {
            return this.interruptionDurationField;
        }
        set {
            this.interruptionDurationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Remarks")]
    public string[] Remarks {
        get {
            return this.remarksField;
        }
        set {
            this.remarksField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Interruption {
    
    private DelayCode interruptionReasonField;
    
    private bool interruptionReasonFieldSpecified;
    
    private System.DateTime interruptionDateTimeField;
    
    private string[] interruptionDescriptionField;
    
    private string internalReferenceIdentifierField;
    
    /// <remarks/>
    public DelayCode InterruptionReason {
        get {
            return this.interruptionReasonField;
        }
        set {
            this.interruptionReasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool InterruptionReasonSpecified {
        get {
            return this.interruptionReasonFieldSpecified;
        }
        set {
            this.interruptionReasonFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime InterruptionDateTime {
        get {
            return this.interruptionDateTimeField;
        }
        set {
            this.interruptionDateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InterruptionDescription")]
    public string[] InterruptionDescription {
        get {
            return this.interruptionDescriptionField;
        }
        set {
            this.interruptionDescriptionField = value;
        }
    }
    
    /// <remarks/>
    public string InternalReferenceIdentifier {
        get {
            return this.internalReferenceIdentifierField;
        }
        set {
            this.internalReferenceIdentifierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class InterruptionDuration {
    
    private System.DateTime earliestEndDateTimeField;
    
    private bool earliestEndDateTimeFieldSpecified;
    
    private System.DateTime latestEndDateTimeField;
    
    private bool latestEndDateTimeFieldSpecified;
    
    /// <remarks/>
    public System.DateTime EarliestEndDateTime {
        get {
            return this.earliestEndDateTimeField;
        }
        set {
            this.earliestEndDateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EarliestEndDateTimeSpecified {
        get {
            return this.earliestEndDateTimeFieldSpecified;
        }
        set {
            this.earliestEndDateTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime LatestEndDateTime {
        get {
            return this.latestEndDateTimeField;
        }
        set {
            this.latestEndDateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LatestEndDateTimeSpecified {
        get {
            return this.latestEndDateTimeFieldSpecified;
        }
        set {
            this.latestEndDateTimeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class EnergyData {
    
    private int measuredVoltageField;
    
    private bool measuredVoltageFieldSpecified;
    
    private decimal measuredCurrentField;
    
    private bool measuredCurrentFieldSpecified;
    
    private decimal autonomyField;
    
    private bool autonomyFieldSpecified;
    
    private double maxPowerField;
    
    private bool maxPowerFieldSpecified;
    
    private string setValueTractionBrakingField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int measuredVoltage {
        get {
            return this.measuredVoltageField;
        }
        set {
            this.measuredVoltageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measuredVoltageSpecified {
        get {
            return this.measuredVoltageFieldSpecified;
        }
        set {
            this.measuredVoltageFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal measuredCurrent {
        get {
            return this.measuredCurrentField;
        }
        set {
            this.measuredCurrentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measuredCurrentSpecified {
        get {
            return this.measuredCurrentFieldSpecified;
        }
        set {
            this.measuredCurrentFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal autonomy {
        get {
            return this.autonomyField;
        }
        set {
            this.autonomyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool autonomySpecified {
        get {
            return this.autonomyFieldSpecified;
        }
        set {
            this.autonomyFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double maxPower {
        get {
            return this.maxPowerField;
        }
        set {
            this.maxPowerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxPowerSpecified {
        get {
            return this.maxPowerFieldSpecified;
        }
        set {
            this.maxPowerFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string setValueTractionBraking {
        get {
            return this.setValueTractionBrakingField;
        }
        set {
            this.setValueTractionBrakingField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum DAS_ModesComplexTypeDAS_drivingMode {
    
    /// <remarks/>
    Inactive,
    
    /// <remarks/>
    Timetable,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Read-Only")]
    ReadOnly,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("DAS not connected to ATP")]
    DASnotconnectedtoATP,
    
    /// <remarks/>
    GoA1,
    
    /// <remarks/>
    GoA2,
    
    /// <remarks/>
    GoA3,
    
    /// <remarks/>
    GoA4,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum B2G_StatusReportATO_State {
    
    /// <remarks/>
    Unknown,
    
    /// <remarks/>
    CO,
    
    /// <remarks/>
    NA,
    
    /// <remarks/>
    AV,
    
    /// <remarks/>
    RE,
    
    /// <remarks/>
    EG,
    
    /// <remarks/>
    DE,
    
    /// <remarks/>
    FA,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SessionTermination {
    
    private SessionTerminationSessionTerminationReason sessionTerminationReasonField;
    
    private bool sessionTerminationReasonFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public SessionTerminationSessionTerminationReason sessionTerminationReason {
        get {
            return this.sessionTerminationReasonField;
        }
        set {
            this.sessionTerminationReasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sessionTerminationReasonSpecified {
        get {
            return this.sessionTerminationReasonFieldSpecified;
        }
        set {
            this.sessionTerminationReasonFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum SessionTerminationSessionTerminationReason {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("End of Journey reached")]
    EndofJourneyreached,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("DAS-TS/ATO-TS Termination Request")]
    DASTSATOTSTerminationRequest,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Last SP left")]
    LastSPleft,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Cab closed")]
    Cabclosed,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("TRN or train length not valid")]
    TRNortrainlengthnotvalid,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("ETCS-OB in NL")]
    ETCSOBinNL,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("ETCS-OB in SH")]
    ETCSOBinSH,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("ATO-TS Handover cancelled")]
    ATOTSHandovercancelled,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SFERA_B2G_ReplyMessage : ISferaMessage
{

    private MessageHeader messageHeaderField;
    
    private B2G_ReplyPayload b2G_ReplyPayloadField;
    
    /// <remarks/>
    public MessageHeader MessageHeader {
        get {
            return this.messageHeaderField;
        }
        set {
            this.messageHeaderField = value;
        }
    }
    
    /// <remarks/>
    public B2G_ReplyPayload B2G_ReplyPayload {
        get {
            return this.b2G_ReplyPayloadField;
        }
        set {
            this.b2G_ReplyPayloadField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class B2G_ReplyPayload {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("B2G_MessageResponse", typeof(B2G_MessageResponse))]
    [System.Xml.Serialization.XmlElementAttribute("B2G_StatusReport", typeof(B2G_StatusReport))]
    [System.Xml.Serialization.XmlElementAttribute("PlaintextMessage", typeof(PlaintextMessage))]
    [System.Xml.Serialization.XmlElementAttribute("Reported_DAS_DrivingMode", typeof(Reported_DAS_DrivingMode))]
    [System.Xml.Serialization.XmlElementAttribute("SessionTermination", typeof(SessionTermination))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class B2G_MessageResponse {
    
    private B2G_Error[] b2G_ErrorField;
    
    private B2G_MessageResponseResult resultField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("B2G_Error")]
    public B2G_Error[] B2G_Error {
        get {
            return this.b2G_ErrorField;
        }
        set {
            this.b2G_ErrorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public B2G_MessageResponseResult result {
        get {
            return this.resultField;
        }
        set {
            this.resultField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class B2G_Error : Error_ComplexType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum B2G_MessageResponseResult {
    
    /// <remarks/>
    OK,
    
    /// <remarks/>
    ERROR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Reported_DAS_DrivingMode {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private DAS_ModesComplexTypeDAS_drivingMode dAS_drivingModeField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DAS_ModesComplexTypeDAS_drivingMode DAS_drivingMode {
        get {
            return this.dAS_drivingModeField;
        }
        set {
            this.dAS_drivingModeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SFERA_B2G_RequestMessage : ISferaMessage
{

    private MessageHeader messageHeaderField;
    
    private object itemField;
    
    /// <remarks/>
    public MessageHeader MessageHeader {
        get {
            return this.messageHeaderField;
        }
        set {
            this.messageHeaderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("B2G_Request", typeof(B2G_Request))]
    [System.Xml.Serialization.XmlElementAttribute("HandshakeRequest", typeof(HandshakeRequest))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class B2G_Request {
    
    private SP_Request[] sP_RequestField;
    
    private TC_Request[] tC_RequestField;
    
    private JP_Request[] jP_RequestField;
    
    private C_DAS_C_AdviceRequest[] c_DAS_C_AdviceRequestField;
    
    private PlaintextMessageRequest[] plaintextMessageRequestField;
    
    private ForceDrivingModeChangeRequest[] forceDrivingModeChangeRequestField;
    
    private PositionSpeedRequest[] positionSpeedRequestField;
    
    private RelatedTrainInformationRequest[] relatedTrainInformationRequestField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SP_Request")]
    public SP_Request[] SP_Request {
        get {
            return this.sP_RequestField;
        }
        set {
            this.sP_RequestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TC_Request")]
    public TC_Request[] TC_Request {
        get {
            return this.tC_RequestField;
        }
        set {
            this.tC_RequestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("JP_Request")]
    public JP_Request[] JP_Request {
        get {
            return this.jP_RequestField;
        }
        set {
            this.jP_RequestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("C_DAS_C_AdviceRequest")]
    public C_DAS_C_AdviceRequest[] C_DAS_C_AdviceRequest {
        get {
            return this.c_DAS_C_AdviceRequestField;
        }
        set {
            this.c_DAS_C_AdviceRequestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PlaintextMessageRequest")]
    public PlaintextMessageRequest[] PlaintextMessageRequest {
        get {
            return this.plaintextMessageRequestField;
        }
        set {
            this.plaintextMessageRequestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ForceDrivingModeChangeRequest")]
    public ForceDrivingModeChangeRequest[] ForceDrivingModeChangeRequest {
        get {
            return this.forceDrivingModeChangeRequestField;
        }
        set {
            this.forceDrivingModeChangeRequestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PositionSpeedRequest")]
    public PositionSpeedRequest[] PositionSpeedRequest {
        get {
            return this.positionSpeedRequestField;
        }
        set {
            this.positionSpeedRequestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RelatedTrainInformationRequest")]
    public RelatedTrainInformationRequest[] RelatedTrainInformationRequest {
        get {
            return this.relatedTrainInformationRequestField;
        }
        set {
            this.relatedTrainInformationRequestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SP_Request : SegmentProfileIdentification_ComplexType {
    
    private uint sP_VersionMajorField;
    
    private bool sP_VersionMajorFieldSpecified;
    
    private uint sP_VersionMinorField;
    
    private bool sP_VersionMinorFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint SP_VersionMajor {
        get {
            return this.sP_VersionMajorField;
        }
        set {
            this.sP_VersionMajorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SP_VersionMajorSpecified {
        get {
            return this.sP_VersionMajorFieldSpecified;
        }
        set {
            this.sP_VersionMajorFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint SP_VersionMinor {
        get {
            return this.sP_VersionMinorField;
        }
        set {
            this.sP_VersionMinorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SP_VersionMinorSpecified {
        get {
            return this.sP_VersionMinorFieldSpecified;
        }
        set {
            this.sP_VersionMinorFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TC_Request : TC_Identifier_ComplexType {
    
    private uint tC_VersionMajorField;
    
    private bool tC_VersionMajorFieldSpecified;
    
    private uint tC_VersionMinorField;
    
    private bool tC_VersionMinorFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint TC_VersionMajor {
        get {
            return this.tC_VersionMajorField;
        }
        set {
            this.tC_VersionMajorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TC_VersionMajorSpecified {
        get {
            return this.tC_VersionMajorFieldSpecified;
        }
        set {
            this.tC_VersionMajorFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint TC_VersionMinor {
        get {
            return this.tC_VersionMinorField;
        }
        set {
            this.tC_VersionMinorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TC_VersionMinorSpecified {
        get {
            return this.tC_VersionMinorFieldSpecified;
        }
        set {
            this.tC_VersionMinorFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class JP_Request {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private SegmentProfileIdentification_ComplexType requestFromSegmentProfileField;
    
    private JP_InUse jP_InUseField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public SegmentProfileIdentification_ComplexType RequestFromSegmentProfile {
        get {
            return this.requestFromSegmentProfileField;
        }
        set {
            this.requestFromSegmentProfileField = value;
        }
    }
    
    /// <remarks/>
    public JP_InUse JP_InUse {
        get {
            return this.jP_InUseField;
        }
        set {
            this.jP_InUseField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class C_DAS_C_AdviceRequest {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private C_DAS_C_Shown c_DAS_C_ShownField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public C_DAS_C_Shown C_DAS_C_Shown {
        get {
            return this.c_DAS_C_ShownField;
        }
        set {
            this.c_DAS_C_ShownField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class PlaintextMessageRequest {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private LastPlaintextMessage lastPlaintextMessageField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public LastPlaintextMessage LastPlaintextMessage {
        get {
            return this.lastPlaintextMessageField;
        }
        set {
            this.lastPlaintextMessageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LastPlaintextMessage {
    
    private string identifierField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ForceDrivingModeChangeRequest {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private LastForceStatusChangeMessage lastForceStatusChangeMessageField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public LastForceStatusChangeMessage LastForceStatusChangeMessage {
        get {
            return this.lastForceStatusChangeMessageField;
        }
        set {
            this.lastForceStatusChangeMessageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LastForceStatusChangeMessage {
    
    private string identifierField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class PositionSpeedRequest {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class RelatedTrainInformationRequest {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class HandshakeRequest {
    
    private DAS_ModesComplexType[] dAS_OperatingModesSupportedField;
    
    private bool statusReportsEnabledField;
    
    private bool statusReportsEnabledFieldSpecified;
    
    private string additionalInfoField;
    
    private relatedTrainRequestType relatedTrainRequestField;
    
    private bool relatedTrainRequestFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DAS_OperatingModesSupported")]
    public DAS_ModesComplexType[] DAS_OperatingModesSupported {
        get {
            return this.dAS_OperatingModesSupportedField;
        }
        set {
            this.dAS_OperatingModesSupportedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool statusReportsEnabled {
        get {
            return this.statusReportsEnabledField;
        }
        set {
            this.statusReportsEnabledField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool statusReportsEnabledSpecified {
        get {
            return this.statusReportsEnabledFieldSpecified;
        }
        set {
            this.statusReportsEnabledFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string additionalInfo {
        get {
            return this.additionalInfoField;
        }
        set {
            this.additionalInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public relatedTrainRequestType relatedTrainRequest {
        get {
            return this.relatedTrainRequestField;
        }
        set {
            this.relatedTrainRequestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool relatedTrainRequestSpecified {
        get {
            return this.relatedTrainRequestFieldSpecified;
        }
        set {
            this.relatedTrainRequestFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("DAS_Mode", Namespace="", IsNullable=false)]
public partial class DAS_ModesComplexType {
    
    private DAS_ModesComplexTypeDAS_drivingMode dAS_drivingModeField;
    
    private DAS_ModesComplexTypeDAS_architecture dAS_architectureField;
    
    private DAS_ModesComplexTypeDAS_connectivity dAS_connectivityField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DAS_ModesComplexTypeDAS_drivingMode DAS_drivingMode {
        get {
            return this.dAS_drivingModeField;
        }
        set {
            this.dAS_drivingModeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DAS_ModesComplexTypeDAS_architecture DAS_architecture {
        get {
            return this.dAS_architectureField;
        }
        set {
            this.dAS_architectureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DAS_ModesComplexTypeDAS_connectivity DAS_connectivity {
        get {
            return this.dAS_connectivityField;
        }
        set {
            this.dAS_connectivityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum DAS_ModesComplexTypeDAS_architecture {
    
    /// <remarks/>
    GroundAdviceCalculation,
    
    /// <remarks/>
    BoardAdviceCalculation,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum DAS_ModesComplexTypeDAS_connectivity {
    
    /// <remarks/>
    Standalone,
    
    /// <remarks/>
    Connected,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum relatedTrainRequestType {
    
    /// <remarks/>
    None,
    
    /// <remarks/>
    OwnTrain,
    
    /// <remarks/>
    RelatedTrains,
    
    /// <remarks/>
    OwnTrainAndRelatedTrains,
    
    /// <remarks/>
    OwnTrainAndOrRelatedTrains,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SFERA_G2B_EventMessage : ISferaMessage
{

    private MessageHeader messageHeaderField;
    
    private G2B_EventPayload g2B_EventPayloadField;
    
    /// <remarks/>
    public MessageHeader MessageHeader {
        get {
            return this.messageHeaderField;
        }
        set {
            this.messageHeaderField = value;
        }
    }
    
    /// <remarks/>
    public G2B_EventPayload G2B_EventPayload {
        get {
            return this.g2B_EventPayloadField;
        }
        set {
            this.g2B_EventPayloadField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class G2B_EventPayload {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("C_DAS_C_Advice", typeof(C_DAS_C_Advice))]
    [System.Xml.Serialization.XmlElementAttribute("ForceDrivingModeChange", typeof(ForceDrivingModeChange))]
    [System.Xml.Serialization.XmlElementAttribute("JourneyProfile", typeof(JourneyProfile))]
    [System.Xml.Serialization.XmlElementAttribute("PlaintextMessage", typeof(PlaintextMessage))]
    [System.Xml.Serialization.XmlElementAttribute("RelatedTrainInformation", typeof(RelatedTrainInformation))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class C_DAS_C_Advice {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private SegmentProfileInfo segmentProfileInfoField;
    
    private string identifierField;
    
    private C_DAS_C_AdviceAdviceType adviceTypeField;
    
    private decimal optimalSpeedField;
    
    private bool optimalSpeedFieldSpecified;
    
    private decimal deltaSpeedField;
    
    private bool deltaSpeedFieldSpecified;
    
    private string locationTextField;
    
    private string reasonTextField;
    
    private AdvisedSpeedReasonCode reasonCodeField;
    
    private bool reasonCodeFieldSpecified;
    
    private System.DateTime startValidityField;
    
    private bool startValidityFieldSpecified;
    
    private System.DateTime endValidityField;
    
    private bool endValidityFieldSpecified;
    
    private decimal percentageField;
    
    private bool percentageFieldSpecified;
    
    private System.DateTime earliestDepartureAdviceTimeField;
    
    private bool earliestDepartureAdviceTimeFieldSpecified;
    
    private System.DateTime latestDepartureAdviceTimeField;
    
    private bool latestDepartureAdviceTimeFieldSpecified;
    
    private string referenceIDAbsField;
    
    private string startStationShortField;
    
    private string startStationLongField;
    
    private double startKmField;
    
    private bool startKmFieldSpecified;
    
    private int startLineField;
    
    private bool startLineFieldSpecified;
    
    private string startSignalField;
    
    private string endStationShortField;
    
    private string endStationLongField;
    
    private double endKmField;
    
    private bool endKmFieldSpecified;
    
    private int endLineField;
    
    private bool endLineFieldSpecified;
    
    private string endSignalField;
    
    private string endStationShortAbsField;
    
    private string endStationLongAbsField;
    
    private double endKmAbsField;
    
    private bool endKmAbsFieldSpecified;
    
    private int endLineAbsField;
    
    private bool endLineAbsFieldSpecified;
    
    private string endSignalAbsField;
    
    private System.DateTime endValidityAbsField;
    
    private bool endValidityAbsFieldSpecified;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public SegmentProfileInfo SegmentProfileInfo {
        get {
            return this.segmentProfileInfoField;
        }
        set {
            this.segmentProfileInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public C_DAS_C_AdviceAdviceType adviceType {
        get {
            return this.adviceTypeField;
        }
        set {
            this.adviceTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal optimalSpeed {
        get {
            return this.optimalSpeedField;
        }
        set {
            this.optimalSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool optimalSpeedSpecified {
        get {
            return this.optimalSpeedFieldSpecified;
        }
        set {
            this.optimalSpeedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal deltaSpeed {
        get {
            return this.deltaSpeedField;
        }
        set {
            this.deltaSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deltaSpeedSpecified {
        get {
            return this.deltaSpeedFieldSpecified;
        }
        set {
            this.deltaSpeedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string locationText {
        get {
            return this.locationTextField;
        }
        set {
            this.locationTextField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string reasonText {
        get {
            return this.reasonTextField;
        }
        set {
            this.reasonTextField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AdvisedSpeedReasonCode reasonCode {
        get {
            return this.reasonCodeField;
        }
        set {
            this.reasonCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool reasonCodeSpecified {
        get {
            return this.reasonCodeFieldSpecified;
        }
        set {
            this.reasonCodeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime startValidity {
        get {
            return this.startValidityField;
        }
        set {
            this.startValidityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startValiditySpecified {
        get {
            return this.startValidityFieldSpecified;
        }
        set {
            this.startValidityFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime endValidity {
        get {
            return this.endValidityField;
        }
        set {
            this.endValidityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endValiditySpecified {
        get {
            return this.endValidityFieldSpecified;
        }
        set {
            this.endValidityFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal percentage {
        get {
            return this.percentageField;
        }
        set {
            this.percentageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool percentageSpecified {
        get {
            return this.percentageFieldSpecified;
        }
        set {
            this.percentageFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime earliestDepartureAdviceTime {
        get {
            return this.earliestDepartureAdviceTimeField;
        }
        set {
            this.earliestDepartureAdviceTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool earliestDepartureAdviceTimeSpecified {
        get {
            return this.earliestDepartureAdviceTimeFieldSpecified;
        }
        set {
            this.earliestDepartureAdviceTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime latestDepartureAdviceTime {
        get {
            return this.latestDepartureAdviceTimeField;
        }
        set {
            this.latestDepartureAdviceTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool latestDepartureAdviceTimeSpecified {
        get {
            return this.latestDepartureAdviceTimeFieldSpecified;
        }
        set {
            this.latestDepartureAdviceTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string referenceIDAbs {
        get {
            return this.referenceIDAbsField;
        }
        set {
            this.referenceIDAbsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string startStationShort {
        get {
            return this.startStationShortField;
        }
        set {
            this.startStationShortField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string startStationLong {
        get {
            return this.startStationLongField;
        }
        set {
            this.startStationLongField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double startKm {
        get {
            return this.startKmField;
        }
        set {
            this.startKmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startKmSpecified {
        get {
            return this.startKmFieldSpecified;
        }
        set {
            this.startKmFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int startLine {
        get {
            return this.startLineField;
        }
        set {
            this.startLineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startLineSpecified {
        get {
            return this.startLineFieldSpecified;
        }
        set {
            this.startLineFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string startSignal {
        get {
            return this.startSignalField;
        }
        set {
            this.startSignalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string endStationShort {
        get {
            return this.endStationShortField;
        }
        set {
            this.endStationShortField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string endStationLong {
        get {
            return this.endStationLongField;
        }
        set {
            this.endStationLongField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double endKm {
        get {
            return this.endKmField;
        }
        set {
            this.endKmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endKmSpecified {
        get {
            return this.endKmFieldSpecified;
        }
        set {
            this.endKmFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int endLine {
        get {
            return this.endLineField;
        }
        set {
            this.endLineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endLineSpecified {
        get {
            return this.endLineFieldSpecified;
        }
        set {
            this.endLineFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string endSignal {
        get {
            return this.endSignalField;
        }
        set {
            this.endSignalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string endStationShortAbs {
        get {
            return this.endStationShortAbsField;
        }
        set {
            this.endStationShortAbsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string endStationLongAbs {
        get {
            return this.endStationLongAbsField;
        }
        set {
            this.endStationLongAbsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double endKmAbs {
        get {
            return this.endKmAbsField;
        }
        set {
            this.endKmAbsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endKmAbsSpecified {
        get {
            return this.endKmAbsFieldSpecified;
        }
        set {
            this.endKmAbsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int endLineAbs {
        get {
            return this.endLineAbsField;
        }
        set {
            this.endLineAbsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endLineAbsSpecified {
        get {
            return this.endLineAbsFieldSpecified;
        }
        set {
            this.endLineAbsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string endSignalAbs {
        get {
            return this.endSignalAbsField;
        }
        set {
            this.endSignalAbsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime endValidityAbs {
        get {
            return this.endValidityAbsField;
        }
        set {
            this.endValidityAbsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endValidityAbsSpecified {
        get {
            return this.endValidityAbsFieldSpecified;
        }
        set {
            this.endValidityAbsFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SegmentProfileInfo : SegmentProfileIdentification_ComplexType {
    
    private NextSP nextSPField;
    
    private double startLocationField;
    
    private bool startLocationFieldSpecified;
    
    private double endLocationField;
    
    private bool endLocationFieldSpecified;
    
    /// <remarks/>
    public NextSP NextSP {
        get {
            return this.nextSPField;
        }
        set {
            this.nextSPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double startLocation {
        get {
            return this.startLocationField;
        }
        set {
            this.startLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startLocationSpecified {
        get {
            return this.startLocationFieldSpecified;
        }
        set {
            this.startLocationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double endLocation {
        get {
            return this.endLocationField;
        }
        set {
            this.endLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endLocationSpecified {
        get {
            return this.endLocationFieldSpecified;
        }
        set {
            this.endLocationFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NextSP {
    
    private SP_Zone_ComplexType sP_ZoneField;
    
    private ATOTS_ContactInfo aTOTS_ContactInfoField;
    
    private string sP_IDField;
    
    private Signal_ComplexTypeDirectionOfApplicationOnSP directionOfApplicationOnSPField;
    
    private bool directionOfApplicationOnSPFieldSpecified;
    
    /// <remarks/>
    public SP_Zone_ComplexType SP_Zone {
        get {
            return this.sP_ZoneField;
        }
        set {
            this.sP_ZoneField = value;
        }
    }
    
    /// <remarks/>
    public ATOTS_ContactInfo ATOTS_ContactInfo {
        get {
            return this.aTOTS_ContactInfoField;
        }
        set {
            this.aTOTS_ContactInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SP_ID {
        get {
            return this.sP_IDField;
        }
        set {
            this.sP_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public Signal_ComplexTypeDirectionOfApplicationOnSP directionOfApplicationOnSP {
        get {
            return this.directionOfApplicationOnSPField;
        }
        set {
            this.directionOfApplicationOnSPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool directionOfApplicationOnSPSpecified {
        get {
            return this.directionOfApplicationOnSPFieldSpecified;
        }
        set {
            this.directionOfApplicationOnSPFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ATOTS_ContactInfo {
    
    private short nID_CField;
    
    private bool nID_CFieldSpecified;
    
    private string aTOTS_IDField;
    
    /// <remarks/>
    public short NID_C {
        get {
            return this.nID_CField;
        }
        set {
            this.nID_CField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NID_CSpecified {
        get {
            return this.nID_CFieldSpecified;
        }
        set {
            this.nID_CFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ATOTS_ID {
        get {
            return this.aTOTS_IDField;
        }
        set {
            this.aTOTS_IDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum Signal_ComplexTypeDirectionOfApplicationOnSP {
    
    /// <remarks/>
    Nominal,
    
    /// <remarks/>
    Reverse,
    
    /// <remarks/>
    Both,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum C_DAS_C_AdviceAdviceType {
    
    /// <remarks/>
    StopAdvice,
    
    /// <remarks/>
    AccelerationAdvice,
    
    /// <remarks/>
    ConstantspeedAdvice,
    
    /// <remarks/>
    CoastingAdvice,
    
    /// <remarks/>
    OperationalBrakingAdvice,
    
    /// <remarks/>
    ElectricalBrakingAdvice,
    
    /// <remarks/>
    EndOfAdvice,
    
    /// <remarks/>
    DepartureAdvice,
    
    /// <remarks/>
    TextAdvice,
    
    /// <remarks/>
    DeleteAdvice,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum AdvisedSpeedReasonCode {
    
    /// <remarks/>
    followTrain,
    
    /// <remarks/>
    trainFollowing,
    
    /// <remarks/>
    merge2nd,
    
    /// <remarks/>
    merge1st,
    
    /// <remarks/>
    overtakeTrain,
    
    /// <remarks/>
    followTrainOvertakeTrain,
    
    /// <remarks/>
    beingOvertaken,
    
    /// <remarks/>
    trainFollowingBeingOvertaken,
    
    /// <remarks/>
    trainCrossing,
    
    /// <remarks/>
    passTrain,
    
    /// <remarks/>
    beingPassed,
    
    /// <remarks/>
    timeSupplementRequired,
    
    /// <remarks/>
    energyOptimisation,
    
    /// <remarks/>
    endOfReason,
    
    /// <remarks/>
    nationalUse1,
    
    /// <remarks/>
    nationalUse2,
    
    /// <remarks/>
    nationalUse3,
    
    /// <remarks/>
    nationalUse4,
    
    /// <remarks/>
    nationalUse5,
    
    /// <remarks/>
    nationalUse6,
    
    /// <remarks/>
    nationalUse7,
    
    /// <remarks/>
    nationalUse8,
    
    /// <remarks/>
    nationalUse9,
    
    /// <remarks/>
    nationalUse10,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ForceDrivingModeChange {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private string identifierField;
    
    private DAS_ModesComplexTypeDAS_drivingMode dAS_drivingModeField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DAS_ModesComplexTypeDAS_drivingMode DAS_drivingMode {
        get {
            return this.dAS_drivingModeField;
        }
        set {
            this.dAS_drivingModeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class JourneyProfile {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private SegmentProfileList[] segmentProfileListField;
    
    private NSPList_ComplexType[] general_JP_InformationField;
    
    private InterruptionPoint interruptionPointField;
    
    private JourneyProfileJP_Status jP_StatusField;
    
    private bool jP_StatusFieldSpecified;
    
    private string jP_VersionField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SegmentProfileList")]
    public SegmentProfileList[] SegmentProfileList {
        get {
            return this.segmentProfileListField;
        }
        set {
            this.segmentProfileListField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("General_JP_Information_NSP", IsNullable=false)]
    public NSPList_ComplexType[] General_JP_Information {
        get {
            return this.general_JP_InformationField;
        }
        set {
            this.general_JP_InformationField = value;
        }
    }
    
    /// <remarks/>
    public InterruptionPoint InterruptionPoint {
        get {
            return this.interruptionPointField;
        }
        set {
            this.interruptionPointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public JourneyProfileJP_Status JP_Status {
        get {
            return this.jP_StatusField;
        }
        set {
            this.jP_StatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool JP_StatusSpecified {
        get {
            return this.jP_StatusFieldSpecified;
        }
        set {
            this.jP_StatusFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string JP_Version {
        get {
            return this.jP_VersionField;
        }
        set {
            this.jP_VersionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SegmentProfileList : SegmentProfileIdentification_ComplexType {
    
    private TimingPointConstraints[] timingPointConstraintsField;
    
    private TemporaryConstraints[] temporaryConstraintsField;
    
    private TemporarySignalConstraints[] temporarySignalConstraintsField;
    
    private TrainCharacteristicsRef[] trainCharacteristicsRefField;
    
    private ChangeReason changeReasonField;
    
    private JP_ContextInformation jP_ContextInformationField;
    
    private uint sP_VersionMajorField;
    
    private uint sP_VersionMinorField;
    
    private SegmentClaimSP_Direction sP_DirectionField;
    
    private bool sP_DirectionFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TimingPointConstraints")]
    public TimingPointConstraints[] TimingPointConstraints {
        get {
            return this.timingPointConstraintsField;
        }
        set {
            this.timingPointConstraintsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TemporaryConstraints")]
    public TemporaryConstraints[] TemporaryConstraints {
        get {
            return this.temporaryConstraintsField;
        }
        set {
            this.temporaryConstraintsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TemporarySignalConstraints")]
    public TemporarySignalConstraints[] TemporarySignalConstraints {
        get {
            return this.temporarySignalConstraintsField;
        }
        set {
            this.temporarySignalConstraintsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TrainCharacteristicsRef")]
    public TrainCharacteristicsRef[] TrainCharacteristicsRef {
        get {
            return this.trainCharacteristicsRefField;
        }
        set {
            this.trainCharacteristicsRefField = value;
        }
    }
    
    /// <remarks/>
    public ChangeReason ChangeReason {
        get {
            return this.changeReasonField;
        }
        set {
            this.changeReasonField = value;
        }
    }
    
    /// <remarks/>
    public JP_ContextInformation JP_ContextInformation {
        get {
            return this.jP_ContextInformationField;
        }
        set {
            this.jP_ContextInformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint SP_VersionMajor {
        get {
            return this.sP_VersionMajorField;
        }
        set {
            this.sP_VersionMajorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint SP_VersionMinor {
        get {
            return this.sP_VersionMinorField;
        }
        set {
            this.sP_VersionMinorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public SegmentClaimSP_Direction SP_Direction {
        get {
            return this.sP_DirectionField;
        }
        set {
            this.sP_DirectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SP_DirectionSpecified {
        get {
            return this.sP_DirectionFieldSpecified;
        }
        set {
            this.sP_DirectionFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TimingPointConstraints {
    
    private TimingPointReference timingPointReferenceField;
    
    private StoppingPointInformation stoppingPointInformationField;
    
    private NSPList_ComplexType[] timingPointConstraints_NSPsField;
    
    private System.DateTime tP_latestArrivalTimeField;
    
    private bool tP_latestArrivalTimeFieldSpecified;
    
    private System.DateTime tP_PlannedLatestArrivalTimeField;
    
    private bool tP_PlannedLatestArrivalTimeFieldSpecified;
    
    private string arrivalWindowField;
    
    private bool aimEarlyArrivalField;
    
    private bool aimEarlyArrivalFieldSpecified;
    
    private TimingPointConstraintsTP_alignment tP_alignmentField;
    
    private bool tP_alignmentFieldSpecified;
    
    private NextTimingPointTrainInformationTP_StopSkipPass tP_StopSkipPassField;
    
    private bool tP_StopSkipPassFieldSpecified;
    
    private TimingPointConstraintsTP_Information tP_InformationField;
    
    private bool tP_InformationFieldSpecified;
    
    private bool daylightSavingField;
    
    private bool daylightSavingFieldSpecified;
    
    /// <remarks/>
    public TimingPointReference TimingPointReference {
        get {
            return this.timingPointReferenceField;
        }
        set {
            this.timingPointReferenceField = value;
        }
    }
    
    /// <remarks/>
    public StoppingPointInformation StoppingPointInformation {
        get {
            return this.stoppingPointInformationField;
        }
        set {
            this.stoppingPointInformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TimingPointConstraints_NSPs")]
    public NSPList_ComplexType[] TimingPointConstraints_NSPs {
        get {
            return this.timingPointConstraints_NSPsField;
        }
        set {
            this.timingPointConstraints_NSPsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime TP_latestArrivalTime {
        get {
            return this.tP_latestArrivalTimeField;
        }
        set {
            this.tP_latestArrivalTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TP_latestArrivalTimeSpecified {
        get {
            return this.tP_latestArrivalTimeFieldSpecified;
        }
        set {
            this.tP_latestArrivalTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime TP_PlannedLatestArrivalTime {
        get {
            return this.tP_PlannedLatestArrivalTimeField;
        }
        set {
            this.tP_PlannedLatestArrivalTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TP_PlannedLatestArrivalTimeSpecified {
        get {
            return this.tP_PlannedLatestArrivalTimeFieldSpecified;
        }
        set {
            this.tP_PlannedLatestArrivalTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
    public string arrivalWindow {
        get {
            return this.arrivalWindowField;
        }
        set {
            this.arrivalWindowField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool aimEarlyArrival {
        get {
            return this.aimEarlyArrivalField;
        }
        set {
            this.aimEarlyArrivalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool aimEarlyArrivalSpecified {
        get {
            return this.aimEarlyArrivalFieldSpecified;
        }
        set {
            this.aimEarlyArrivalFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public TimingPointConstraintsTP_alignment TP_alignment {
        get {
            return this.tP_alignmentField;
        }
        set {
            this.tP_alignmentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TP_alignmentSpecified {
        get {
            return this.tP_alignmentFieldSpecified;
        }
        set {
            this.tP_alignmentFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NextTimingPointTrainInformationTP_StopSkipPass TP_StopSkipPass {
        get {
            return this.tP_StopSkipPassField;
        }
        set {
            this.tP_StopSkipPassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TP_StopSkipPassSpecified {
        get {
            return this.tP_StopSkipPassFieldSpecified;
        }
        set {
            this.tP_StopSkipPassFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public TimingPointConstraintsTP_Information TP_Information {
        get {
            return this.tP_InformationField;
        }
        set {
            this.tP_InformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TP_InformationSpecified {
        get {
            return this.tP_InformationFieldSpecified;
        }
        set {
            this.tP_InformationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool daylightSaving {
        get {
            return this.daylightSavingField;
        }
        set {
            this.daylightSavingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool daylightSavingSpecified {
        get {
            return this.daylightSavingFieldSpecified;
        }
        set {
            this.daylightSavingFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TimingPointReference {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("StoppingZoneReference", typeof(StoppingZone_ComplexType))]
    [System.Xml.Serialization.XmlElementAttribute("TP_ID_Reference", typeof(TimingPointIdentification_ComplexType))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("StoppingZone", Namespace="", IsNullable=false)]
public partial class StoppingZone_ComplexType {
    
    private SP_Zone_ComplexType sP_ZoneField;
    
    private string identifierField;
    
    private string nameField;
    
    /// <remarks/>
    public SP_Zone_ComplexType SP_Zone {
        get {
            return this.sP_ZoneField;
        }
        set {
            this.sP_ZoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class StoppingPointInformation {
    
    private StopType[] stopTypeField;
    
    private System.DateTime departureTimeField;
    
    private System.DateTime earliestDepartureTimeField;
    
    private bool earliestDepartureTimeFieldSpecified;
    
    private System.DateTime plannedDepartureTimeField;
    
    private bool plannedDepartureTimeFieldSpecified;
    
    private bool trainHoldField;
    
    private bool trainHoldFieldSpecified;
    
    private string minimumDwellTimeField;
    
    private bool leaveASAPField;
    
    private bool leaveASAPFieldSpecified;
    
    private string departureAuthorisationTypeField;
    
    private string changedStoppingLocationAlertField;
    
    private StoppingPointInformationOpeningDoorSide openingDoorSideField;
    
    private bool openingDoorSideFieldSpecified;
    
    private bool centralisedOpeningField;
    
    private bool centralisedOpeningFieldSpecified;
    
    private bool automaticClosingField;
    
    private bool automaticClosingFieldSpecified;
    
    private bool daylightSavingField;
    
    private bool daylightSavingFieldSpecified;
    
    private bool relaxedCouplerField;
    
    private bool relaxedCouplerFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("StopType")]
    public StopType[] StopType {
        get {
            return this.stopTypeField;
        }
        set {
            this.stopTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime departureTime {
        get {
            return this.departureTimeField;
        }
        set {
            this.departureTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime earliestDepartureTime {
        get {
            return this.earliestDepartureTimeField;
        }
        set {
            this.earliestDepartureTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool earliestDepartureTimeSpecified {
        get {
            return this.earliestDepartureTimeFieldSpecified;
        }
        set {
            this.earliestDepartureTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime plannedDepartureTime {
        get {
            return this.plannedDepartureTimeField;
        }
        set {
            this.plannedDepartureTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool plannedDepartureTimeSpecified {
        get {
            return this.plannedDepartureTimeFieldSpecified;
        }
        set {
            this.plannedDepartureTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool trainHold {
        get {
            return this.trainHoldField;
        }
        set {
            this.trainHoldField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool trainHoldSpecified {
        get {
            return this.trainHoldFieldSpecified;
        }
        set {
            this.trainHoldFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
    public string minimumDwellTime {
        get {
            return this.minimumDwellTimeField;
        }
        set {
            this.minimumDwellTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool leaveASAP {
        get {
            return this.leaveASAPField;
        }
        set {
            this.leaveASAPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool leaveASAPSpecified {
        get {
            return this.leaveASAPFieldSpecified;
        }
        set {
            this.leaveASAPFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string departureAuthorisationType {
        get {
            return this.departureAuthorisationTypeField;
        }
        set {
            this.departureAuthorisationTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string changedStoppingLocationAlert {
        get {
            return this.changedStoppingLocationAlertField;
        }
        set {
            this.changedStoppingLocationAlertField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public StoppingPointInformationOpeningDoorSide openingDoorSide {
        get {
            return this.openingDoorSideField;
        }
        set {
            this.openingDoorSideField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool openingDoorSideSpecified {
        get {
            return this.openingDoorSideFieldSpecified;
        }
        set {
            this.openingDoorSideFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool centralisedOpening {
        get {
            return this.centralisedOpeningField;
        }
        set {
            this.centralisedOpeningField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool centralisedOpeningSpecified {
        get {
            return this.centralisedOpeningFieldSpecified;
        }
        set {
            this.centralisedOpeningFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool automaticClosing {
        get {
            return this.automaticClosingField;
        }
        set {
            this.automaticClosingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool automaticClosingSpecified {
        get {
            return this.automaticClosingFieldSpecified;
        }
        set {
            this.automaticClosingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool daylightSaving {
        get {
            return this.daylightSavingField;
        }
        set {
            this.daylightSavingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool daylightSavingSpecified {
        get {
            return this.daylightSavingFieldSpecified;
        }
        set {
            this.daylightSavingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool relaxedCoupler {
        get {
            return this.relaxedCouplerField;
        }
        set {
            this.relaxedCouplerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool relaxedCouplerSpecified {
        get {
            return this.relaxedCouplerFieldSpecified;
        }
        set {
            this.relaxedCouplerFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class StopType {
    
    private StopTypeStopTypePurpose stopTypePurposeField;
    
    private string stopTypeDetailsField;
    
    private bool plannedStopField;
    
    private bool plannedStopFieldSpecified;
    
    private bool mandatoryStopField;
    
    private bool mandatoryStopFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public StopTypeStopTypePurpose stopTypePurpose {
        get {
            return this.stopTypePurposeField;
        }
        set {
            this.stopTypePurposeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string stopTypeDetails {
        get {
            return this.stopTypeDetailsField;
        }
        set {
            this.stopTypeDetailsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool plannedStop {
        get {
            return this.plannedStopField;
        }
        set {
            this.plannedStopField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool plannedStopSpecified {
        get {
            return this.plannedStopFieldSpecified;
        }
        set {
            this.plannedStopFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool mandatoryStop {
        get {
            return this.mandatoryStopField;
        }
        set {
            this.mandatoryStopField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mandatoryStopSpecified {
        get {
            return this.mandatoryStopFieldSpecified;
        }
        set {
            this.mandatoryStopFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum StopTypeStopTypePurpose {
    
    /// <remarks/>
    Commercial,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Non Commercial Traffic Management")]
    NonCommercialTrafficManagement,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Non Commercial RU")]
    NonCommercialRU,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Non Commercial IM")]
    NonCommercialIM,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Non Commercial Safety")]
    NonCommercialSafety,
    
    /// <remarks/>
    Other,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum StoppingPointInformationOpeningDoorSide {
    
    /// <remarks/>
    None,
    
    /// <remarks/>
    Right,
    
    /// <remarks/>
    Left,
    
    /// <remarks/>
    Both,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum TimingPointConstraintsTP_alignment {
    
    /// <remarks/>
    Front,
    
    /// <remarks/>
    Middle,
    
    /// <remarks/>
    Rear,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum TimingPointConstraintsTP_Information {
    
    /// <remarks/>
    None,
    
    /// <remarks/>
    End_of_Journey,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TemporaryConstraints : TemporaryConstraints_ComplexType {
    
    private object[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    private TemporaryConstraintReason[] temporaryConstraintReasonField;
    
    private TemporaryConstraintsTemporaryConstraintType temporaryConstraintTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalSpeedRestriction", typeof(AdditionalSpeedRestriction))]
    [System.Xml.Serialization.XmlElementAttribute("AdvisedSpeed", typeof(AdvisedSpeed))]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedVoltageConstraint", typeof(EstimatedVoltageConstraint))]
    [System.Xml.Serialization.XmlElementAttribute("LowAdhesion", typeof(LowAdhesion))]
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificConstraint", typeof(NSPList_ComplexType))]
    [System.Xml.Serialization.XmlElementAttribute("PowerAdvice", typeof(PowerAdvice))]
    [System.Xml.Serialization.XmlElementAttribute("RegenerationTotalCurrent", typeof(TotalCurrent_ComplexType))]
    [System.Xml.Serialization.XmlElementAttribute("TractionTotalCurrent", typeof(TotalCurrent_ComplexType))]
    [System.Xml.Serialization.XmlElementAttribute("Unavailable_DAS_OperatingModes", typeof(Unavailable_DAS_OperatingModes))]
    [System.Xml.Serialization.XmlElementAttribute("Wind", typeof(Wind))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TemporaryConstraintReason")]
    public TemporaryConstraintReason[] TemporaryConstraintReason {
        get {
            return this.temporaryConstraintReasonField;
        }
        set {
            this.temporaryConstraintReasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public TemporaryConstraintsTemporaryConstraintType temporaryConstraintType {
        get {
            return this.temporaryConstraintTypeField;
        }
        set {
            this.temporaryConstraintTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class AdditionalSpeedRestriction {
    
    private bool aSR_FrontField;
    
    private bool aSR_FrontFieldSpecified;
    
    private decimal aSR_SpeedField;
    
    private bool aSR_SpeedFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ASR_Front {
        get {
            return this.aSR_FrontField;
        }
        set {
            this.aSR_FrontField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ASR_FrontSpecified {
        get {
            return this.aSR_FrontFieldSpecified;
        }
        set {
            this.aSR_FrontFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ASR_Speed {
        get {
            return this.aSR_SpeedField;
        }
        set {
            this.aSR_SpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ASR_SpeedSpecified {
        get {
            return this.aSR_SpeedFieldSpecified;
        }
        set {
            this.aSR_SpeedFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class AdvisedSpeed {
    
    private decimal speedField;
    
    private bool speedFieldSpecified;
    
    private decimal maxAdvisedSpeedField;
    
    private bool maxAdvisedSpeedFieldSpecified;
    
    private decimal minAdvisedSpeedField;
    
    private bool minAdvisedSpeedFieldSpecified;
    
    private AdvisedSpeedReasonCode reasonCodeField;
    
    private bool reasonCodeFieldSpecified;
    
    private string reasonTextField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal speed {
        get {
            return this.speedField;
        }
        set {
            this.speedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool speedSpecified {
        get {
            return this.speedFieldSpecified;
        }
        set {
            this.speedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal maxAdvisedSpeed {
        get {
            return this.maxAdvisedSpeedField;
        }
        set {
            this.maxAdvisedSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxAdvisedSpeedSpecified {
        get {
            return this.maxAdvisedSpeedFieldSpecified;
        }
        set {
            this.maxAdvisedSpeedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal minAdvisedSpeed {
        get {
            return this.minAdvisedSpeedField;
        }
        set {
            this.minAdvisedSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool minAdvisedSpeedSpecified {
        get {
            return this.minAdvisedSpeedFieldSpecified;
        }
        set {
            this.minAdvisedSpeedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AdvisedSpeedReasonCode reasonCode {
        get {
            return this.reasonCodeField;
        }
        set {
            this.reasonCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool reasonCodeSpecified {
        get {
            return this.reasonCodeFieldSpecified;
        }
        set {
            this.reasonCodeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string reasonText {
        get {
            return this.reasonTextField;
        }
        set {
            this.reasonTextField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class EstimatedVoltageConstraint {
    
    private int voltageValueField;
    
    private bool voltageValueFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int voltageValue {
        get {
            return this.voltageValueField;
        }
        set {
            this.voltageValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool voltageValueSpecified {
        get {
            return this.voltageValueFieldSpecified;
        }
        set {
            this.voltageValueFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LowAdhesion {
    
    private adhesionCategoryType lowAdhesionCategoryField;
    
    private bool lowAdhesionCategoryFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public adhesionCategoryType lowAdhesionCategory {
        get {
            return this.lowAdhesionCategoryField;
        }
        set {
            this.lowAdhesionCategoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool lowAdhesionCategorySpecified {
        get {
            return this.lowAdhesionCategoryFieldSpecified;
        }
        set {
            this.lowAdhesionCategoryFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class PowerAdvice {
    
    private PowerAdvicePowerConsumptionChange powerConsumptionChangeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public PowerAdvicePowerConsumptionChange powerConsumptionChange {
        get {
            return this.powerConsumptionChangeField;
        }
        set {
            this.powerConsumptionChangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum PowerAdvicePowerConsumptionChange {
    
    /// <remarks/>
    Maximise,
    
    /// <remarks/>
    Minimise,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("No Advice")]
    NoAdvice,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("RegenerationTotalCurrent", Namespace="", IsNullable=false)]
public partial class TotalCurrent_ComplexType {
    
    private decimal maxCurValueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal maxCurValue {
        get {
            return this.maxCurValueField;
        }
        set {
            this.maxCurValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Unavailable_DAS_OperatingModes {
    
    private DAS_ModesComplexTypeDAS_drivingMode dAS_drivingModeField;
    
    private bool dAS_drivingModeFieldSpecified;
    
    private DAS_ModesComplexTypeDAS_architecture dAS_architectureField;
    
    private bool dAS_architectureFieldSpecified;
    
    private DAS_ModesComplexTypeDAS_connectivity dAS_connectivityField;
    
    private bool dAS_connectivityFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DAS_ModesComplexTypeDAS_drivingMode DAS_drivingMode {
        get {
            return this.dAS_drivingModeField;
        }
        set {
            this.dAS_drivingModeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DAS_drivingModeSpecified {
        get {
            return this.dAS_drivingModeFieldSpecified;
        }
        set {
            this.dAS_drivingModeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DAS_ModesComplexTypeDAS_architecture DAS_architecture {
        get {
            return this.dAS_architectureField;
        }
        set {
            this.dAS_architectureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DAS_architectureSpecified {
        get {
            return this.dAS_architectureFieldSpecified;
        }
        set {
            this.dAS_architectureFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DAS_ModesComplexTypeDAS_connectivity DAS_connectivity {
        get {
            return this.dAS_connectivityField;
        }
        set {
            this.dAS_connectivityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DAS_connectivitySpecified {
        get {
            return this.dAS_connectivityFieldSpecified;
        }
        set {
            this.dAS_connectivityFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Wind {
    
    private decimal windSpeedField;
    
    private ushort windHeadingField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal windSpeed {
        get {
            return this.windSpeedField;
        }
        set {
            this.windSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort windHeading {
        get {
            return this.windHeadingField;
        }
        set {
            this.windHeadingField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
public enum ItemsChoiceType {
    
    /// <remarks/>
    AdditionalSpeedRestriction,
    
    /// <remarks/>
    AdvisedSpeed,
    
    /// <remarks/>
    EstimatedVoltageConstraint,
    
    /// <remarks/>
    LowAdhesion,
    
    /// <remarks/>
    NetworkSpecificConstraint,
    
    /// <remarks/>
    PowerAdvice,
    
    /// <remarks/>
    RegenerationTotalCurrent,
    
    /// <remarks/>
    TractionTotalCurrent,
    
    /// <remarks/>
    Unavailable_DAS_OperatingModes,
    
    /// <remarks/>
    Wind,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TemporaryConstraintReason {
    
    private string languageField;
    
    private string messageStringField;
    
    private bool originalLanguageField;
    
    private bool originalLanguageFieldSpecified;
    
    private string temporaryConstraintReferenceField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string language {
        get {
            return this.languageField;
        }
        set {
            this.languageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string messageString {
        get {
            return this.messageStringField;
        }
        set {
            this.messageStringField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool originalLanguage {
        get {
            return this.originalLanguageField;
        }
        set {
            this.originalLanguageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool originalLanguageSpecified {
        get {
            return this.originalLanguageFieldSpecified;
        }
        set {
            this.originalLanguageFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string temporaryConstraintReference {
        get {
            return this.temporaryConstraintReferenceField;
        }
        set {
            this.temporaryConstraintReferenceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum TemporaryConstraintsTemporaryConstraintType {
    
    /// <remarks/>
    ASR,
    
    /// <remarks/>
    Low_Adhesion,
    
    /// <remarks/>
    TractionTotalCurrent,
    
    /// <remarks/>
    RegenerationTotalCurrent,
    
    /// <remarks/>
    PowerAdvice,
    
    /// <remarks/>
    EstimatedVoltage,
    
    /// <remarks/>
    Wind,
    
    /// <remarks/>
    Unavailable_DAS_OperatingModes,
    
    /// <remarks/>
    AdvisedSpeed,
    
    /// <remarks/>
    NetworkSpecificConstraint,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("JP_ContextInformation_NSP_Constraints", Namespace="", IsNullable=false)]
public partial class TemporaryConstraints_ComplexType {
    
    private double startLocationField;
    
    private bool startLocationFieldSpecified;
    
    private double endLocationField;
    
    private bool endLocationFieldSpecified;
    
    private SP_GenericArea_ComplexTypeStartEndQualifier startEndQualifierField;
    
    private System.DateTime startTimeField;
    
    private bool startTimeFieldSpecified;
    
    private System.DateTime endTimeField;
    
    private bool endTimeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double startLocation {
        get {
            return this.startLocationField;
        }
        set {
            this.startLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startLocationSpecified {
        get {
            return this.startLocationFieldSpecified;
        }
        set {
            this.startLocationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double endLocation {
        get {
            return this.endLocationField;
        }
        set {
            this.endLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endLocationSpecified {
        get {
            return this.endLocationFieldSpecified;
        }
        set {
            this.endLocationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public SP_GenericArea_ComplexTypeStartEndQualifier startEndQualifier {
        get {
            return this.startEndQualifierField;
        }
        set {
            this.startEndQualifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime startTime {
        get {
            return this.startTimeField;
        }
        set {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startTimeSpecified {
        get {
            return this.startTimeFieldSpecified;
        }
        set {
            this.startTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime endTime {
        get {
            return this.endTimeField;
        }
        set {
            this.endTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endTimeSpecified {
        get {
            return this.endTimeFieldSpecified;
        }
        set {
            this.endTimeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TemporarySignalConstraints : Signal_ComplexType {
    
    private System.DateTime startTimeField;
    
    private bool startTimeFieldSpecified;
    
    private System.DateTime endTimeField;
    
    private bool endTimeFieldSpecified;
    
    private TemporarySignalConstraintsTemporarySignalConstraintType temporarySignalConstraintTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime startTime {
        get {
            return this.startTimeField;
        }
        set {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startTimeSpecified {
        get {
            return this.startTimeFieldSpecified;
        }
        set {
            this.startTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime endTime {
        get {
            return this.endTimeField;
        }
        set {
            this.endTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endTimeSpecified {
        get {
            return this.endTimeFieldSpecified;
        }
        set {
            this.endTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public TemporarySignalConstraintsTemporarySignalConstraintType temporarySignalConstraintType {
        get {
            return this.temporarySignalConstraintTypeField;
        }
        set {
            this.temporarySignalConstraintTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum TemporarySignalConstraintsTemporarySignalConstraintType {
    
    /// <remarks/>
    TemporarySignal,
    
    /// <remarks/>
    ExistingSignalAspectModification,
    
    /// <remarks/>
    CancelledSignal,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("Signal", Namespace="", IsNullable=false)]
public partial class Signal_ComplexType {
    
    private Signal_ID signal_IDField;
    
    private SignalApplication signalApplicationField;
    
    private SignalInformation signalInformationField;
    
    private SignalFunction[] signalFunctionField;
    
    private SignalPhysicalCharacteristics signalPhysicalCharacteristicsField;
    
    private NSPList_ComplexType[] signal_NSPsField;
    
    private Signal_ComplexTypeDirectionOfApplicationOnSP directionOfApplicationOnSPField;
    
    private bool directionOfApplicationOnSPFieldSpecified;
    
    /// <remarks/>
    public Signal_ID Signal_ID {
        get {
            return this.signal_IDField;
        }
        set {
            this.signal_IDField = value;
        }
    }
    
    /// <remarks/>
    public SignalApplication SignalApplication {
        get {
            return this.signalApplicationField;
        }
        set {
            this.signalApplicationField = value;
        }
    }
    
    /// <remarks/>
    public SignalInformation SignalInformation {
        get {
            return this.signalInformationField;
        }
        set {
            this.signalInformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SignalFunction")]
    public SignalFunction[] SignalFunction {
        get {
            return this.signalFunctionField;
        }
        set {
            this.signalFunctionField = value;
        }
    }
    
    /// <remarks/>
    public SignalPhysicalCharacteristics SignalPhysicalCharacteristics {
        get {
            return this.signalPhysicalCharacteristicsField;
        }
        set {
            this.signalPhysicalCharacteristicsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signal_NSPs")]
    public NSPList_ComplexType[] Signal_NSPs {
        get {
            return this.signal_NSPsField;
        }
        set {
            this.signal_NSPsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public Signal_ComplexTypeDirectionOfApplicationOnSP directionOfApplicationOnSP {
        get {
            return this.directionOfApplicationOnSPField;
        }
        set {
            this.directionOfApplicationOnSPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool directionOfApplicationOnSPSpecified {
        get {
            return this.directionOfApplicationOnSPFieldSpecified;
        }
        set {
            this.directionOfApplicationOnSPFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Signal_ID {
    
    private string signal_ID_PhysicalField;
    
    private string signal_ID_ObjectField;
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string signal_ID_Physical {
        get {
            return this.signal_ID_PhysicalField;
        }
        set {
            this.signal_ID_PhysicalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string signal_ID_Object {
        get {
            return this.signal_ID_ObjectField;
        }
        set {
            this.signal_ID_ObjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SignalApplication {
    
    private StartSignalApplication startSignalApplicationField;
    
    private EndSignalApplication endSignalApplicationField;
    
    private ATP_System_Identifier[] signal_ATP_SystemsField;
    
    private SignalTrainCategory[] signalTrainCategoryField;
    
    private SignalTrainLength signalTrainLengthField;
    
    private ApplicableIfTrainRunsOnSP[] applicableIfTrainRunsOnSPField;
    
    /// <remarks/>
    public StartSignalApplication StartSignalApplication {
        get {
            return this.startSignalApplicationField;
        }
        set {
            this.startSignalApplicationField = value;
        }
    }
    
    /// <remarks/>
    public EndSignalApplication EndSignalApplication {
        get {
            return this.endSignalApplicationField;
        }
        set {
            this.endSignalApplicationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ATP_System_Identifier", IsNullable=false)]
    public ATP_System_Identifier[] Signal_ATP_Systems {
        get {
            return this.signal_ATP_SystemsField;
        }
        set {
            this.signal_ATP_SystemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SignalTrainCategory")]
    public SignalTrainCategory[] SignalTrainCategory {
        get {
            return this.signalTrainCategoryField;
        }
        set {
            this.signalTrainCategoryField = value;
        }
    }
    
    /// <remarks/>
    public SignalTrainLength SignalTrainLength {
        get {
            return this.signalTrainLengthField;
        }
        set {
            this.signalTrainLengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ApplicableIfTrainRunsOnSP")]
    public ApplicableIfTrainRunsOnSP[] ApplicableIfTrainRunsOnSP {
        get {
            return this.applicableIfTrainRunsOnSPField;
        }
        set {
            this.applicableIfTrainRunsOnSPField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class StartSignalApplication {
    
    private string sP_IDField;
    
    private double locationField;
    
    private bool locationFieldSpecified;
    
    private trainPartType startSignalApplicationMustBeClearedByField;
    
    private bool startSignalApplicationMustBeClearedByFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SP_ID {
        get {
            return this.sP_IDField;
        }
        set {
            this.sP_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool locationSpecified {
        get {
            return this.locationFieldSpecified;
        }
        set {
            this.locationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public trainPartType startSignalApplicationMustBeClearedBy {
        get {
            return this.startSignalApplicationMustBeClearedByField;
        }
        set {
            this.startSignalApplicationMustBeClearedByField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startSignalApplicationMustBeClearedBySpecified {
        get {
            return this.startSignalApplicationMustBeClearedByFieldSpecified;
        }
        set {
            this.startSignalApplicationMustBeClearedByFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum trainPartType {
    
    /// <remarks/>
    TrainHead,
    
    /// <remarks/>
    TrainEnd,
    
    /// <remarks/>
    TrainLastPantograph,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class EndSignalApplication {
    
    private string sP_IDField;
    
    private double locationField;
    
    private bool locationFieldSpecified;
    
    private trainPartType endSignalApplicationMustBeClearedByField;
    
    private bool endSignalApplicationMustBeClearedByFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SP_ID {
        get {
            return this.sP_IDField;
        }
        set {
            this.sP_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool locationSpecified {
        get {
            return this.locationFieldSpecified;
        }
        set {
            this.locationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public trainPartType endSignalApplicationMustBeClearedBy {
        get {
            return this.endSignalApplicationMustBeClearedByField;
        }
        set {
            this.endSignalApplicationMustBeClearedByField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endSignalApplicationMustBeClearedBySpecified {
        get {
            return this.endSignalApplicationMustBeClearedByFieldSpecified;
        }
        set {
            this.endSignalApplicationMustBeClearedByFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SignalTrainCategory {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signal_CantDeficiencyTrainCategory", typeof(SignalTrainCategorySignal_CantDeficiencyTrainCategory))]
    [System.Xml.Serialization.XmlElementAttribute("Signal_OtherTrainCategory", typeof(SignalTrainCategorySignal_OtherTrainCategory))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SignalTrainCategorySignal_CantDeficiencyTrainCategory {
    
    private NC_CDTrainType nC_CDTrainField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NC_CDTrainType NC_CDTrain {
        get {
            return this.nC_CDTrainField;
        }
        set {
            this.nC_CDTrainField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SignalTrainCategorySignal_OtherTrainCategory {
    
    private NC_TrainType nC_TrainField;
    
    private bool nC_TrainFieldSpecified;
    
    private string trainCategoryCodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NC_TrainType NC_Train {
        get {
            return this.nC_TrainField;
        }
        set {
            this.nC_TrainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NC_TrainSpecified {
        get {
            return this.nC_TrainFieldSpecified;
        }
        set {
            this.nC_TrainFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trainCategoryCode {
        get {
            return this.trainCategoryCodeField;
        }
        set {
            this.trainCategoryCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SignalTrainLength {
    
    private double minimumTrainLengthField;
    
    private bool minimumTrainLengthFieldSpecified;
    
    private double maximumTrainLengthField;
    
    private bool maximumTrainLengthFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double minimumTrainLength {
        get {
            return this.minimumTrainLengthField;
        }
        set {
            this.minimumTrainLengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool minimumTrainLengthSpecified {
        get {
            return this.minimumTrainLengthFieldSpecified;
        }
        set {
            this.minimumTrainLengthFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double maximumTrainLength {
        get {
            return this.maximumTrainLengthField;
        }
        set {
            this.maximumTrainLengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maximumTrainLengthSpecified {
        get {
            return this.maximumTrainLengthFieldSpecified;
        }
        set {
            this.maximumTrainLengthFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ApplicableIfTrainRunsOnSP {
    
    private SP_Zone_ComplexType sP_ZoneField;
    
    private string sP_IDField;
    
    private ApplicableIfTrainRunsOnSPSP_BeforeOrAfter sP_BeforeOrAfterField;
    
    private bool sP_BeforeOrAfterFieldSpecified;
    
    /// <remarks/>
    public SP_Zone_ComplexType SP_Zone {
        get {
            return this.sP_ZoneField;
        }
        set {
            this.sP_ZoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SP_ID {
        get {
            return this.sP_IDField;
        }
        set {
            this.sP_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ApplicableIfTrainRunsOnSPSP_BeforeOrAfter SP_BeforeOrAfter {
        get {
            return this.sP_BeforeOrAfterField;
        }
        set {
            this.sP_BeforeOrAfterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SP_BeforeOrAfterSpecified {
        get {
            return this.sP_BeforeOrAfterFieldSpecified;
        }
        set {
            this.sP_BeforeOrAfterFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum ApplicableIfTrainRunsOnSPSP_BeforeOrAfter {
    
    /// <remarks/>
    Before,
    
    /// <remarks/>
    After,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SignalInformation {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AvoidSpeedRange", typeof(AvoidSpeedRange))]
    [System.Xml.Serialization.XmlElementAttribute("CancelPreviousSignal", typeof(CancelPreviousSignal))]
    [System.Xml.Serialization.XmlElementAttribute("MaxSpeed", typeof(MaxSpeed))]
    [System.Xml.Serialization.XmlElementAttribute("MaxSpeedAnnouncement", typeof(MaxSpeedAnnouncement))]
    [System.Xml.Serialization.XmlElementAttribute("PowerConstraint", typeof(PowerConstraint))]
    [System.Xml.Serialization.XmlElementAttribute("SignalInformation_NSPs", typeof(NSPList_ComplexType))]
    [System.Xml.Serialization.XmlElementAttribute("StationAheadSign", typeof(TimingPointIdentification_ComplexType))]
    [System.Xml.Serialization.XmlElementAttribute("StopBeforePassingSignal", typeof(StopBeforePassingSignal))]
    [System.Xml.Serialization.XmlElementAttribute("TractionTypeTransition", typeof(TractionTypeTransition))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class AvoidSpeedRange {
    
    private decimal rangeMinSpeedField;
    
    private decimal rangeMaxSpeedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal rangeMinSpeed {
        get {
            return this.rangeMinSpeedField;
        }
        set {
            this.rangeMinSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal rangeMaxSpeed {
        get {
            return this.rangeMaxSpeedField;
        }
        set {
            this.rangeMaxSpeedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CancelPreviousSignal {
    
    private string signal_ID_PhysicalField;
    
    private string signal_ID_ObjectField;
    
    private double distanceBeforeSignalField;
    
    private bool distanceBeforeSignalFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string signal_ID_Physical {
        get {
            return this.signal_ID_PhysicalField;
        }
        set {
            this.signal_ID_PhysicalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string signal_ID_Object {
        get {
            return this.signal_ID_ObjectField;
        }
        set {
            this.signal_ID_ObjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double distanceBeforeSignal {
        get {
            return this.distanceBeforeSignalField;
        }
        set {
            this.distanceBeforeSignalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool distanceBeforeSignalSpecified {
        get {
            return this.distanceBeforeSignalFieldSpecified;
        }
        set {
            this.distanceBeforeSignalFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class MaxSpeed {
    
    private decimal speedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal speed {
        get {
            return this.speedField;
        }
        set {
            this.speedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class MaxSpeedAnnouncement {
    
    private decimal speedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal speed {
        get {
            return this.speedField;
        }
        set {
            this.speedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class PowerConstraint {
    
    private PowerConstraintPowerConstraintInstruction powerConstraintInstructionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public PowerConstraintPowerConstraintInstruction powerConstraintInstruction {
        get {
            return this.powerConstraintInstructionField;
        }
        set {
            this.powerConstraintInstructionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum PowerConstraintPowerConstraintInstruction {
    
    /// <remarks/>
    Pantograph_Down,
    
    /// <remarks/>
    Pantograph_Up,
    
    /// <remarks/>
    Main_Switch_Off,
    
    /// <remarks/>
    Main_Switch_On,
    
    /// <remarks/>
    Traction_Off,
    
    /// <remarks/>
    Traction_On,
    
    /// <remarks/>
    HVAC_Off,
    
    /// <remarks/>
    HVAC_On,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class StopBeforePassingSignal {
    
    private string stopTimeField;
    
    private bool valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
    public string stopTime {
        get {
            return this.stopTimeField;
        }
        set {
            this.stopTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public bool Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TractionTypeTransition {
    
    private TractionType_ComplexType tractionTypeTransitionElectricField;
    
    private TractionType_ComplexType tractionTypeTransitionBimodalField;
    
    /// <remarks/>
    public TractionType_ComplexType TractionTypeTransitionElectric {
        get {
            return this.tractionTypeTransitionElectricField;
        }
        set {
            this.tractionTypeTransitionElectricField = value;
        }
    }
    
    /// <remarks/>
    public TractionType_ComplexType TractionTypeTransitionBimodal {
        get {
            return this.tractionTypeTransitionBimodalField;
        }
        set {
            this.tractionTypeTransitionBimodalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public enum SignalFunction {
    
    /// <remarks/>
    entry,
    
    /// <remarks/>
    exit,
    
    /// <remarks/>
    intermediate,
    
    /// <remarks/>
    advance,
    
    /// <remarks/>
    block,
    
    /// <remarks/>
    protection,
    
    /// <remarks/>
    trainProtection,
    
    /// <remarks/>
    groupMain,
    
    /// <remarks/>
    groupIntermediate,
    
    /// <remarks/>
    groupMainAndIntermediate,
    
    /// <remarks/>
    standAloneIndicator,
    
    /// <remarks/>
    trainDestinationOnlySignal,
    
    /// <remarks/>
    intermediateExitSignal,
    
    /// <remarks/>
    entryAndExit,
    
    /// <remarks/>
    entryAndBlock,
    
    /// <remarks/>
    further,
    
    /// <remarks/>
    lxProtectionSignal,
    
    /// <remarks/>
    distantOrRepeater,
    
    /// <remarks/>
    laneChange,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SignalPhysicalCharacteristics : PhysicalCharacteristics_ComplexType {
    
    private string signalTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string signalType {
        get {
            return this.signalTypeField;
        }
        set {
            this.signalTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TrainCharacteristicsRef : TC_Identifier_ComplexType {
    
    private NSPList_ComplexType[] trainCharacteristicsRef_NSPsField;
    
    private uint tC_VersionMajorField;
    
    private uint tC_VersionMinorField;
    
    private double locationField;
    
    private string trainLengthField;
    
    private int trainWeightField;
    
    private bool trainWeightFieldSpecified;
    
    private string trainMaxSpeedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TrainCharacteristicsRef_NSPs")]
    public NSPList_ComplexType[] TrainCharacteristicsRef_NSPs {
        get {
            return this.trainCharacteristicsRef_NSPsField;
        }
        set {
            this.trainCharacteristicsRef_NSPsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint TC_VersionMajor {
        get {
            return this.tC_VersionMajorField;
        }
        set {
            this.tC_VersionMajorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint TC_VersionMinor {
        get {
            return this.tC_VersionMinorField;
        }
        set {
            this.tC_VersionMinorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string trainLength {
        get {
            return this.trainLengthField;
        }
        set {
            this.trainLengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int trainWeight {
        get {
            return this.trainWeightField;
        }
        set {
            this.trainWeightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool trainWeightSpecified {
        get {
            return this.trainWeightFieldSpecified;
        }
        set {
            this.trainWeightFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string trainMaxSpeed {
        get {
            return this.trainMaxSpeedField;
        }
        set {
            this.trainMaxSpeedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ChangeReason {
    
    private string identifierField;
    
    private double startLocationField;
    
    private bool startLocationFieldSpecified;
    
    private double endLocationField;
    
    private bool endLocationFieldSpecified;
    
    private System.DateTime startTimeField;
    
    private bool startTimeFieldSpecified;
    
    private System.DateTime endTimeField;
    
    private bool endTimeFieldSpecified;
    
    private string jP_ChangeReasonField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double startLocation {
        get {
            return this.startLocationField;
        }
        set {
            this.startLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startLocationSpecified {
        get {
            return this.startLocationFieldSpecified;
        }
        set {
            this.startLocationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double endLocation {
        get {
            return this.endLocationField;
        }
        set {
            this.endLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endLocationSpecified {
        get {
            return this.endLocationFieldSpecified;
        }
        set {
            this.endLocationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime startTime {
        get {
            return this.startTimeField;
        }
        set {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startTimeSpecified {
        get {
            return this.startTimeFieldSpecified;
        }
        set {
            this.startTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime endTime {
        get {
            return this.endTimeField;
        }
        set {
            this.endTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endTimeSpecified {
        get {
            return this.endTimeFieldSpecified;
        }
        set {
            this.endTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string JP_ChangeReason {
        get {
            return this.jP_ChangeReasonField;
        }
        set {
            this.jP_ChangeReasonField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class JP_ContextInformation {
    
    private Applicable_OTN[] applicable_OTNField;
    
    private JP_ContextInformationJP_ContextInformation_NSPs[] jP_ContextInformation_NSPsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Applicable_OTN")]
    public Applicable_OTN[] Applicable_OTN {
        get {
            return this.applicable_OTNField;
        }
        set {
            this.applicable_OTNField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("JP_ContextInformation_NSPs")]
    public JP_ContextInformationJP_ContextInformation_NSPs[] JP_ContextInformation_NSPs {
        get {
            return this.jP_ContextInformation_NSPsField;
        }
        set {
            this.jP_ContextInformation_NSPsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Applicable_OTN : TemporaryConstraints_ComplexType {
    
    private string oTNField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string OTN {
        get {
            return this.oTNField;
        }
        set {
            this.oTNField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class JP_ContextInformationJP_ContextInformation_NSPs : NSPList_ComplexType {
    
    private TemporaryConstraints_ComplexType jP_ContextInformation_NSP_ConstraintsField;
    
    /// <remarks/>
    public TemporaryConstraints_ComplexType JP_ContextInformation_NSP_Constraints {
        get {
            return this.jP_ContextInformation_NSP_ConstraintsField;
        }
        set {
            this.jP_ContextInformation_NSP_ConstraintsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum JourneyProfileJP_Status {
    
    /// <remarks/>
    Valid,
    
    /// <remarks/>
    Invalid,
    
    /// <remarks/>
    Unavailable,
    
    /// <remarks/>
    Update,
    
    /// <remarks/>
    Overwrite,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class RelatedTrainInformation {
    
    private OwnTrain ownTrainField;
    
    private Train[] trainsBeforeOwnField;
    
    private Train[] trainsAfterOwnField;
    
    private string restrictionReasonField;
    
    /// <remarks/>
    public OwnTrain OwnTrain {
        get {
            return this.ownTrainField;
        }
        set {
            this.ownTrainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Train", IsNullable=false)]
    public Train[] TrainsBeforeOwn {
        get {
            return this.trainsBeforeOwnField;
        }
        set {
            this.trainsBeforeOwnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Train", IsNullable=false)]
    public Train[] TrainsAfterOwn {
        get {
            return this.trainsAfterOwnField;
        }
        set {
            this.trainsAfterOwnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RestrictionReason {
        get {
            return this.restrictionReasonField;
        }
        set {
            this.restrictionReasonField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class OwnTrain {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private TrainLocationInformation trainLocationInformationField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public TrainLocationInformation TrainLocationInformation {
        get {
            return this.trainLocationInformationField;
        }
        set {
            this.trainLocationInformationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Train : TrainType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SFERA_G2B_ReplyMessage : ISferaMessage
{

    private MessageHeader messageHeaderField;
    
    private object itemField;
    
    /// <remarks/>
    public MessageHeader MessageHeader {
        get {
            return this.messageHeaderField;
        }
        set {
            this.messageHeaderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("G2B_ReplyPayload", typeof(G2B_ReplyPayload))]
    [System.Xml.Serialization.XmlElementAttribute("HandshakeAcknowledgement", typeof(HandshakeAcknowledgement))]
    [System.Xml.Serialization.XmlElementAttribute("HandshakeReject", typeof(HandshakeReject))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class G2B_ReplyPayload {
    
    private JourneyProfile[] journeyProfileField;
    
    private SegmentProfile[] segmentProfileField;
    
    private TrainCharacteristics[] trainCharacteristicsField;
    
    private G2B_MessageResponse g2B_MessageResponseField;
    
    private PlaintextMessage[] plaintextMessageField;
    
    private PositionSpeed[] positionSpeedField;
    
    private C_DAS_C_Advice[] c_DAS_C_AdviceField;
    
    private ForceDrivingModeChange[] forceDrivingModeChangeField;
    
    private RelatedTrainInformation[] relatedTrainInformationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("JourneyProfile")]
    public JourneyProfile[] JourneyProfile {
        get {
            return this.journeyProfileField;
        }
        set {
            this.journeyProfileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SegmentProfile")]
    public SegmentProfile[] SegmentProfile {
        get {
            return this.segmentProfileField;
        }
        set {
            this.segmentProfileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TrainCharacteristics")]
    public TrainCharacteristics[] TrainCharacteristics {
        get {
            return this.trainCharacteristicsField;
        }
        set {
            this.trainCharacteristicsField = value;
        }
    }
    
    /// <remarks/>
    public G2B_MessageResponse G2B_MessageResponse {
        get {
            return this.g2B_MessageResponseField;
        }
        set {
            this.g2B_MessageResponseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PlaintextMessage")]
    public PlaintextMessage[] PlaintextMessage {
        get {
            return this.plaintextMessageField;
        }
        set {
            this.plaintextMessageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PositionSpeed")]
    public PositionSpeed[] PositionSpeed {
        get {
            return this.positionSpeedField;
        }
        set {
            this.positionSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("C_DAS_C_Advice")]
    public C_DAS_C_Advice[] C_DAS_C_Advice {
        get {
            return this.c_DAS_C_AdviceField;
        }
        set {
            this.c_DAS_C_AdviceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ForceDrivingModeChange")]
    public ForceDrivingModeChange[] ForceDrivingModeChange {
        get {
            return this.forceDrivingModeChangeField;
        }
        set {
            this.forceDrivingModeChangeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RelatedTrainInformation")]
    public RelatedTrainInformation[] RelatedTrainInformation {
        get {
            return this.relatedTrainInformationField;
        }
        set {
            this.relatedTrainInformationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SegmentProfile : SegmentProfileIdentification_ComplexType {
    
    private SP_Points sP_PointsField;
    
    private SP_Areas sP_AreasField;
    
    private SP_Characteristics sP_CharacteristicsField;
    
    private SP_ContextInformation sP_ContextInformationField;
    
    private NextSP nextSPField;
    
    private uint sP_VersionMajorField;
    
    private uint sP_VersionMinorField;
    
    private double sP_LengthField;
    
    private string sP_NameField;
    
    private SegmentProfileSP_Status sP_StatusField;
    
    private bool sP_StatusFieldSpecified;
    
    private double distance_EoA_OffsetField;
    
    private bool distance_EoA_OffsetFieldSpecified;
    
    private byte uTC_OffsetField;
    
    private bool uTC_OffsetFieldSpecified;
    
    private decimal sP_AltitudeField;
    
    private bool sP_AltitudeFieldSpecified;
    
    private int sP_GaugeField;
    
    private bool sP_GaugeFieldSpecified;
    
    private double sP_MaxLateralDeviationField;
    
    private bool sP_MaxLateralDeviationFieldSpecified;
    
    /// <remarks/>
    public SP_Points SP_Points {
        get {
            return this.sP_PointsField;
        }
        set {
            this.sP_PointsField = value;
        }
    }
    
    /// <remarks/>
    public SP_Areas SP_Areas {
        get {
            return this.sP_AreasField;
        }
        set {
            this.sP_AreasField = value;
        }
    }
    
    /// <remarks/>
    public SP_Characteristics SP_Characteristics {
        get {
            return this.sP_CharacteristicsField;
        }
        set {
            this.sP_CharacteristicsField = value;
        }
    }
    
    /// <remarks/>
    public SP_ContextInformation SP_ContextInformation {
        get {
            return this.sP_ContextInformationField;
        }
        set {
            this.sP_ContextInformationField = value;
        }
    }
    
    /// <remarks/>
    public NextSP NextSP {
        get {
            return this.nextSPField;
        }
        set {
            this.nextSPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint SP_VersionMajor {
        get {
            return this.sP_VersionMajorField;
        }
        set {
            this.sP_VersionMajorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint SP_VersionMinor {
        get {
            return this.sP_VersionMinorField;
        }
        set {
            this.sP_VersionMinorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double SP_Length {
        get {
            return this.sP_LengthField;
        }
        set {
            this.sP_LengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SP_Name {
        get {
            return this.sP_NameField;
        }
        set {
            this.sP_NameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public SegmentProfileSP_Status SP_Status {
        get {
            return this.sP_StatusField;
        }
        set {
            this.sP_StatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SP_StatusSpecified {
        get {
            return this.sP_StatusFieldSpecified;
        }
        set {
            this.sP_StatusFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double distance_EoA_Offset {
        get {
            return this.distance_EoA_OffsetField;
        }
        set {
            this.distance_EoA_OffsetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool distance_EoA_OffsetSpecified {
        get {
            return this.distance_EoA_OffsetFieldSpecified;
        }
        set {
            this.distance_EoA_OffsetFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UTC_Offset {
        get {
            return this.uTC_OffsetField;
        }
        set {
            this.uTC_OffsetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool UTC_OffsetSpecified {
        get {
            return this.uTC_OffsetFieldSpecified;
        }
        set {
            this.uTC_OffsetFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal SP_Altitude {
        get {
            return this.sP_AltitudeField;
        }
        set {
            this.sP_AltitudeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SP_AltitudeSpecified {
        get {
            return this.sP_AltitudeFieldSpecified;
        }
        set {
            this.sP_AltitudeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int SP_Gauge {
        get {
            return this.sP_GaugeField;
        }
        set {
            this.sP_GaugeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SP_GaugeSpecified {
        get {
            return this.sP_GaugeFieldSpecified;
        }
        set {
            this.sP_GaugeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double SP_MaxLateralDeviation {
        get {
            return this.sP_MaxLateralDeviationField;
        }
        set {
            this.sP_MaxLateralDeviationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SP_MaxLateralDeviationSpecified {
        get {
            return this.sP_MaxLateralDeviationFieldSpecified;
        }
        set {
            this.sP_MaxLateralDeviationFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SP_Points {
    
    private TimingPoint[] timingPointField;
    
    private Signal_ComplexType[] signalField;
    
    private Balise[] baliseField;
    
    private VirtualBalise[] virtualBaliseField;
    
    private UnprotectedLevelCrossingStop[] unprotectedLevelCrossingStopField;
    
    private NetworkSpecificPoint[] networkSpecificPointField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TimingPoint")]
    public TimingPoint[] TimingPoint {
        get {
            return this.timingPointField;
        }
        set {
            this.timingPointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signal")]
    public Signal_ComplexType[] Signal {
        get {
            return this.signalField;
        }
        set {
            this.signalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Balise")]
    public Balise[] Balise {
        get {
            return this.baliseField;
        }
        set {
            this.baliseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("VirtualBalise")]
    public VirtualBalise[] VirtualBalise {
        get {
            return this.virtualBaliseField;
        }
        set {
            this.virtualBaliseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("UnprotectedLevelCrossingStop")]
    public UnprotectedLevelCrossingStop[] UnprotectedLevelCrossingStop {
        get {
            return this.unprotectedLevelCrossingStopField;
        }
        set {
            this.unprotectedLevelCrossingStopField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificPoint")]
    public NetworkSpecificPoint[] NetworkSpecificPoint {
        get {
            return this.networkSpecificPointField;
        }
        set {
            this.networkSpecificPointField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TimingPoint {
    
    private TP_Name[] tP_NameField;
    
    private StoppingPointLocation stoppingPointLocationField;
    
    private TimingPoint_NSPs[] timingPoint_NSPsField;
    
    private string tP_IDField;
    
    private double locationField;
    
    private string tP_abbreviationField;
    
    private string tP_typeField;
    
    private byte tP_priorityField;
    
    private bool tP_priorityFieldSpecified;
    
    private string stationTrackField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TP_Name")]
    public TP_Name[] TP_Name {
        get {
            return this.tP_NameField;
        }
        set {
            this.tP_NameField = value;
        }
    }
    
    /// <remarks/>
    public StoppingPointLocation StoppingPointLocation {
        get {
            return this.stoppingPointLocationField;
        }
        set {
            this.stoppingPointLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TimingPoint_NSPs")]
    public TimingPoint_NSPs[] TimingPoint_NSPs {
        get {
            return this.timingPoint_NSPsField;
        }
        set {
            this.timingPoint_NSPsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TP_ID {
        get {
            return this.tP_IDField;
        }
        set {
            this.tP_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TP_abbreviation {
        get {
            return this.tP_abbreviationField;
        }
        set {
            this.tP_abbreviationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TP_type {
        get {
            return this.tP_typeField;
        }
        set {
            this.tP_typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte TP_priority {
        get {
            return this.tP_priorityField;
        }
        set {
            this.tP_priorityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TP_prioritySpecified {
        get {
            return this.tP_priorityFieldSpecified;
        }
        set {
            this.tP_priorityFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string stationTrack {
        get {
            return this.stationTrackField;
        }
        set {
            this.stationTrackField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TP_Name {
    
    private string nameField;
    
    private string languageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string language {
        get {
            return this.languageField;
        }
        set {
            this.languageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class StoppingPointLocation {
    
    private StoppingZone_ComplexType stoppingZoneField;
    
    private StoppingPointApplicability stoppingPointApplicabilityField;
    
    private string identifierField;
    
    private double stopLocationToleranceField;
    
    private bool stopLocationToleranceFieldSpecified;
    
    private double distance_STP_ReachedField;
    
    private bool distance_STP_ReachedFieldSpecified;
    
    /// <remarks/>
    public StoppingZone_ComplexType StoppingZone {
        get {
            return this.stoppingZoneField;
        }
        set {
            this.stoppingZoneField = value;
        }
    }
    
    /// <remarks/>
    public StoppingPointApplicability StoppingPointApplicability {
        get {
            return this.stoppingPointApplicabilityField;
        }
        set {
            this.stoppingPointApplicabilityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double stopLocationTolerance {
        get {
            return this.stopLocationToleranceField;
        }
        set {
            this.stopLocationToleranceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool stopLocationToleranceSpecified {
        get {
            return this.stopLocationToleranceFieldSpecified;
        }
        set {
            this.stopLocationToleranceFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double distance_STP_Reached {
        get {
            return this.distance_STP_ReachedField;
        }
        set {
            this.distance_STP_ReachedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool distance_STP_ReachedSpecified {
        get {
            return this.distance_STP_ReachedFieldSpecified;
        }
        set {
            this.distance_STP_ReachedFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class StoppingPointApplicability {
    
    private RollingStockApplicability[] rollingStockApplicabilityField;
    
    private SegmentProfileIdentification_ComplexType[] stoppingPointApplicableIfPrecedingSPField;
    
    private short minimumNumberOfCarsField;
    
    private bool minimumNumberOfCarsFieldSpecified;
    
    private short maximumNumberOfCarsField;
    
    private bool maximumNumberOfCarsFieldSpecified;
    
    private double minimumTrainLengthField;
    
    private bool minimumTrainLengthFieldSpecified;
    
    private double maximumTrainLengthField;
    
    private bool maximumTrainLengthFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RollingStockApplicability")]
    public RollingStockApplicability[] RollingStockApplicability {
        get {
            return this.rollingStockApplicabilityField;
        }
        set {
            this.rollingStockApplicabilityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("StoppingPointApplicableIfPrecedingSP")]
    public SegmentProfileIdentification_ComplexType[] StoppingPointApplicableIfPrecedingSP {
        get {
            return this.stoppingPointApplicableIfPrecedingSPField;
        }
        set {
            this.stoppingPointApplicableIfPrecedingSPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public short minimumNumberOfCars {
        get {
            return this.minimumNumberOfCarsField;
        }
        set {
            this.minimumNumberOfCarsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool minimumNumberOfCarsSpecified {
        get {
            return this.minimumNumberOfCarsFieldSpecified;
        }
        set {
            this.minimumNumberOfCarsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public short maximumNumberOfCars {
        get {
            return this.maximumNumberOfCarsField;
        }
        set {
            this.maximumNumberOfCarsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maximumNumberOfCarsSpecified {
        get {
            return this.maximumNumberOfCarsFieldSpecified;
        }
        set {
            this.maximumNumberOfCarsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double minimumTrainLength {
        get {
            return this.minimumTrainLengthField;
        }
        set {
            this.minimumTrainLengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool minimumTrainLengthSpecified {
        get {
            return this.minimumTrainLengthFieldSpecified;
        }
        set {
            this.minimumTrainLengthFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double maximumTrainLength {
        get {
            return this.maximumTrainLengthField;
        }
        set {
            this.maximumTrainLengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maximumTrainLengthSpecified {
        get {
            return this.maximumTrainLengthFieldSpecified;
        }
        set {
            this.maximumTrainLengthFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class RollingStockApplicability {
    
    private string rollingStockTypeField;
    
    private byte minimumNumberOfRSTypeField;
    
    private bool minimumNumberOfRSTypeFieldSpecified;
    
    private byte maximumNumberOfRSTypeField;
    
    private bool maximumNumberOfRSTypeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rollingStockType {
        get {
            return this.rollingStockTypeField;
        }
        set {
            this.rollingStockTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte minimumNumberOfRSType {
        get {
            return this.minimumNumberOfRSTypeField;
        }
        set {
            this.minimumNumberOfRSTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool minimumNumberOfRSTypeSpecified {
        get {
            return this.minimumNumberOfRSTypeFieldSpecified;
        }
        set {
            this.minimumNumberOfRSTypeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte maximumNumberOfRSType {
        get {
            return this.maximumNumberOfRSTypeField;
        }
        set {
            this.maximumNumberOfRSTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maximumNumberOfRSTypeSpecified {
        get {
            return this.maximumNumberOfRSTypeFieldSpecified;
        }
        set {
            this.maximumNumberOfRSTypeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TimingPoint_NSPs : NSPList_ComplexType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Balise : SP_GenericPoint_ComplexType {
    
    private short nID_CField;
    
    private bool nID_CFieldSpecified;
    
    private ushort baliseGroupIdentifierField;
    
    private bool baliseGroupIdentifierFieldSpecified;
    
    private byte baliseRelativePositionField;
    
    private bool baliseRelativePositionFieldSpecified;
    
    private bool levelCrossingGuardingField;
    
    private bool levelCrossingGuardingFieldSpecified;
    
    private byte amountLevelCrossingsField;
    
    private bool amountLevelCrossingsFieldSpecified;
    
    /// <remarks/>
    public short NID_C {
        get {
            return this.nID_CField;
        }
        set {
            this.nID_CField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NID_CSpecified {
        get {
            return this.nID_CFieldSpecified;
        }
        set {
            this.nID_CFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort baliseGroupIdentifier {
        get {
            return this.baliseGroupIdentifierField;
        }
        set {
            this.baliseGroupIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool baliseGroupIdentifierSpecified {
        get {
            return this.baliseGroupIdentifierFieldSpecified;
        }
        set {
            this.baliseGroupIdentifierFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte baliseRelativePosition {
        get {
            return this.baliseRelativePositionField;
        }
        set {
            this.baliseRelativePositionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool baliseRelativePositionSpecified {
        get {
            return this.baliseRelativePositionFieldSpecified;
        }
        set {
            this.baliseRelativePositionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool levelCrossingGuarding {
        get {
            return this.levelCrossingGuardingField;
        }
        set {
            this.levelCrossingGuardingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool levelCrossingGuardingSpecified {
        get {
            return this.levelCrossingGuardingFieldSpecified;
        }
        set {
            this.levelCrossingGuardingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte amountLevelCrossings {
        get {
            return this.amountLevelCrossingsField;
        }
        set {
            this.amountLevelCrossingsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool amountLevelCrossingsSpecified {
        get {
            return this.amountLevelCrossingsFieldSpecified;
        }
        set {
            this.amountLevelCrossingsFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class VirtualBalise : SP_GenericPoint_ComplexType {
    
    private GNSS_StaticPosition_ComplexType virtualBalisePositionField;
    
    /// <remarks/>
    public GNSS_StaticPosition_ComplexType VirtualBalisePosition {
        get {
            return this.virtualBalisePositionField;
        }
        set {
            this.virtualBalisePositionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("VirtualBalisePosition", Namespace="", IsNullable=false)]
public partial class GNSS_StaticPosition_ComplexType {
    
    private decimal latitudeField;
    
    private decimal longitudeField;
    
    private decimal altitudeField;
    
    private bool altitudeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal latitude {
        get {
            return this.latitudeField;
        }
        set {
            this.latitudeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal longitude {
        get {
            return this.longitudeField;
        }
        set {
            this.longitudeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal altitude {
        get {
            return this.altitudeField;
        }
        set {
            this.altitudeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool altitudeSpecified {
        get {
            return this.altitudeFieldSpecified;
        }
        set {
            this.altitudeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class UnprotectedLevelCrossingStop : SP_GenericPoint_ComplexType {
    
    private Signal_ComplexTypeDirectionOfApplicationOnSP directionOfApplicationOnSPField;
    
    private bool directionOfApplicationOnSPFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public Signal_ComplexTypeDirectionOfApplicationOnSP directionOfApplicationOnSP {
        get {
            return this.directionOfApplicationOnSPField;
        }
        set {
            this.directionOfApplicationOnSPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool directionOfApplicationOnSPSpecified {
        get {
            return this.directionOfApplicationOnSPFieldSpecified;
        }
        set {
            this.directionOfApplicationOnSPFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NetworkSpecificPoint : SP_GenericPoint_ComplexType {
    
    private NetworkSpecificParameter[] networkSpecificParameterField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificParameter")]
    public NetworkSpecificParameter[] NetworkSpecificParameter {
        get {
            return this.networkSpecificParameterField;
        }
        set {
            this.networkSpecificParameterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SP_Areas {
    
    private SP_GenericArea_ComplexType[] platformField;
    
    private Tunnel[] tunnelField;
    
    private DecisiveGradient[] decisiveGradientField;
    
    private SP_GenericArea_ComplexType[] noStoppingAreaField;
    
    private AxleLoadSpeedProfile[] axleLoadSpeedProfileField;
    
    private PermittedBrakingDistanceArea[] permittedBrakingDistanceAreaField;
    
    private SP_GenericArea_ComplexType[] switchOffRegenerativeBrakeAreaField;
    
    private SP_GenericArea_ComplexType[] switchOffEddyCurrentBrakeAreaField;
    
    private SP_GenericArea_ComplexType[] switchOffEddyCurrentEmergencyBrakeAreaField;
    
    private SP_GenericArea_ComplexType[] switchOffMagneticShoeBrakeAreaField;
    
    private DAS_ModesUnavailabilityArea[] dAS_ModesUnavailabilityAreaField;
    
    private SP_GenericArea_ComplexType[] dynamicBrakeForceInhibitionAreaField;
    
    private LimitedDynamicBrakeForceArea[] limitedDynamicBrakeForceAreaField;
    
    private TAF_TAP_Location[] tAF_TAP_LocationField;
    
    private NetworkSpecificArea[] networkSpecificAreaField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Platform")]
    public SP_GenericArea_ComplexType[] Platform {
        get {
            return this.platformField;
        }
        set {
            this.platformField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Tunnel")]
    public Tunnel[] Tunnel {
        get {
            return this.tunnelField;
        }
        set {
            this.tunnelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DecisiveGradient")]
    public DecisiveGradient[] DecisiveGradient {
        get {
            return this.decisiveGradientField;
        }
        set {
            this.decisiveGradientField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NoStoppingArea")]
    public SP_GenericArea_ComplexType[] NoStoppingArea {
        get {
            return this.noStoppingAreaField;
        }
        set {
            this.noStoppingAreaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AxleLoadSpeedProfile")]
    public AxleLoadSpeedProfile[] AxleLoadSpeedProfile {
        get {
            return this.axleLoadSpeedProfileField;
        }
        set {
            this.axleLoadSpeedProfileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PermittedBrakingDistanceArea")]
    public PermittedBrakingDistanceArea[] PermittedBrakingDistanceArea {
        get {
            return this.permittedBrakingDistanceAreaField;
        }
        set {
            this.permittedBrakingDistanceAreaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SwitchOffRegenerativeBrakeArea")]
    public SP_GenericArea_ComplexType[] SwitchOffRegenerativeBrakeArea {
        get {
            return this.switchOffRegenerativeBrakeAreaField;
        }
        set {
            this.switchOffRegenerativeBrakeAreaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SwitchOffEddyCurrentBrakeArea")]
    public SP_GenericArea_ComplexType[] SwitchOffEddyCurrentBrakeArea {
        get {
            return this.switchOffEddyCurrentBrakeAreaField;
        }
        set {
            this.switchOffEddyCurrentBrakeAreaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SwitchOffEddyCurrentEmergencyBrakeArea")]
    public SP_GenericArea_ComplexType[] SwitchOffEddyCurrentEmergencyBrakeArea {
        get {
            return this.switchOffEddyCurrentEmergencyBrakeAreaField;
        }
        set {
            this.switchOffEddyCurrentEmergencyBrakeAreaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SwitchOffMagneticShoeBrakeArea")]
    public SP_GenericArea_ComplexType[] SwitchOffMagneticShoeBrakeArea {
        get {
            return this.switchOffMagneticShoeBrakeAreaField;
        }
        set {
            this.switchOffMagneticShoeBrakeAreaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DAS_ModesUnavailabilityArea")]
    public DAS_ModesUnavailabilityArea[] DAS_ModesUnavailabilityArea {
        get {
            return this.dAS_ModesUnavailabilityAreaField;
        }
        set {
            this.dAS_ModesUnavailabilityAreaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DynamicBrakeForceInhibitionArea")]
    public SP_GenericArea_ComplexType[] DynamicBrakeForceInhibitionArea {
        get {
            return this.dynamicBrakeForceInhibitionAreaField;
        }
        set {
            this.dynamicBrakeForceInhibitionAreaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LimitedDynamicBrakeForceArea")]
    public LimitedDynamicBrakeForceArea[] LimitedDynamicBrakeForceArea {
        get {
            return this.limitedDynamicBrakeForceAreaField;
        }
        set {
            this.limitedDynamicBrakeForceAreaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TAF_TAP_Location")]
    public TAF_TAP_Location[] TAF_TAP_Location {
        get {
            return this.tAF_TAP_LocationField;
        }
        set {
            this.tAF_TAP_LocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificArea")]
    public NetworkSpecificArea[] NetworkSpecificArea {
        get {
            return this.networkSpecificAreaField;
        }
        set {
            this.networkSpecificAreaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("DynamicBrakeForceInhibitionArea", Namespace="", IsNullable=false)]
public partial class SP_GenericArea_ComplexType {
    
    private string identifierField;
    
    private double startLocationField;
    
    private bool startLocationFieldSpecified;
    
    private double endLocationField;
    
    private bool endLocationFieldSpecified;
    
    private SP_GenericArea_ComplexTypeStartEndQualifier startEndQualifierField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double startLocation {
        get {
            return this.startLocationField;
        }
        set {
            this.startLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startLocationSpecified {
        get {
            return this.startLocationFieldSpecified;
        }
        set {
            this.startLocationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double endLocation {
        get {
            return this.endLocationField;
        }
        set {
            this.endLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endLocationSpecified {
        get {
            return this.endLocationFieldSpecified;
        }
        set {
            this.endLocationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public SP_GenericArea_ComplexTypeStartEndQualifier startEndQualifier {
        get {
            return this.startEndQualifierField;
        }
        set {
            this.startEndQualifierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Tunnel : SP_GenericArea_ComplexType {
    
    private TunnelTunnelCategory tunnelCategoryField;
    
    private bool tunnelCategoryFieldSpecified;
    
    private double tunnelFactorField;
    
    private bool tunnelFactorFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public TunnelTunnelCategory tunnelCategory {
        get {
            return this.tunnelCategoryField;
        }
        set {
            this.tunnelCategoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tunnelCategorySpecified {
        get {
            return this.tunnelCategoryFieldSpecified;
        }
        set {
            this.tunnelCategoryFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double tunnelFactor {
        get {
            return this.tunnelFactorField;
        }
        set {
            this.tunnelFactorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tunnelFactorSpecified {
        get {
            return this.tunnelFactorFieldSpecified;
        }
        set {
            this.tunnelFactorFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum TunnelTunnelCategory {
    
    /// <remarks/>
    SingleTrack,
    
    /// <remarks/>
    DoubleTrack,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Wide-crossSection")]
    WidecrossSection,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DecisiveGradient : SP_GenericArea_ComplexType {
    
    private decimal gradientValueField;
    
    private gradientDirectionType gradientDirectionField;
    
    private Signal_ComplexTypeDirectionOfApplicationOnSP directionOfApplicationOnSPField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal gradientValue {
        get {
            return this.gradientValueField;
        }
        set {
            this.gradientValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public gradientDirectionType gradientDirection {
        get {
            return this.gradientDirectionField;
        }
        set {
            this.gradientDirectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public Signal_ComplexTypeDirectionOfApplicationOnSP directionOfApplicationOnSP {
        get {
            return this.directionOfApplicationOnSPField;
        }
        set {
            this.directionOfApplicationOnSPField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum gradientDirectionType {
    
    /// <remarks/>
    Downhill,
    
    /// <remarks/>
    Uphill,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class AxleLoadSpeedProfile : SP_GenericArea_ComplexType {
    
    private TC_Features_ComplexTypeAxleLoadCategory axleLoadCategoryField;
    
    private decimal newSpeedLevelField;
    
    private bool aLSP_FrontField;
    
    private bool aLSP_FrontFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public TC_Features_ComplexTypeAxleLoadCategory axleLoadCategory {
        get {
            return this.axleLoadCategoryField;
        }
        set {
            this.axleLoadCategoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal newSpeedLevel {
        get {
            return this.newSpeedLevelField;
        }
        set {
            this.newSpeedLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ALSP_Front {
        get {
            return this.aLSP_FrontField;
        }
        set {
            this.aLSP_FrontField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ALSP_FrontSpecified {
        get {
            return this.aLSP_FrontFieldSpecified;
        }
        set {
            this.aLSP_FrontFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class PermittedBrakingDistanceArea : SP_GenericArea_ComplexType {
    
    private double permittedBrakingDistanceField;
    
    private bool permittedBrakingDistanceFieldSpecified;
    
    private PermittedBrakingDistanceAreaPBD_Brake pBD_BrakeField;
    
    private bool pBD_BrakeFieldSpecified;
    
    private decimal gradient_PBDField;
    
    private bool gradient_PBDFieldSpecified;
    
    private gradientDirectionType gradientDirection_PBDField;
    
    private bool gradientDirection_PBDFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double permittedBrakingDistance {
        get {
            return this.permittedBrakingDistanceField;
        }
        set {
            this.permittedBrakingDistanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool permittedBrakingDistanceSpecified {
        get {
            return this.permittedBrakingDistanceFieldSpecified;
        }
        set {
            this.permittedBrakingDistanceFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public PermittedBrakingDistanceAreaPBD_Brake PBD_Brake {
        get {
            return this.pBD_BrakeField;
        }
        set {
            this.pBD_BrakeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PBD_BrakeSpecified {
        get {
            return this.pBD_BrakeFieldSpecified;
        }
        set {
            this.pBD_BrakeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal gradient_PBD {
        get {
            return this.gradient_PBDField;
        }
        set {
            this.gradient_PBDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool gradient_PBDSpecified {
        get {
            return this.gradient_PBDFieldSpecified;
        }
        set {
            this.gradient_PBDFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public gradientDirectionType gradientDirection_PBD {
        get {
            return this.gradientDirection_PBDField;
        }
        set {
            this.gradientDirection_PBDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool gradientDirection_PBDSpecified {
        get {
            return this.gradientDirection_PBDFieldSpecified;
        }
        set {
            this.gradientDirection_PBDFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum PermittedBrakingDistanceAreaPBD_Brake {
    
    /// <remarks/>
    Service_Brake,
    
    /// <remarks/>
    Emergency_Brake,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DAS_ModesUnavailabilityArea : SP_GenericArea_ComplexType {
    
    private Unavailable_DAS_OperatingModes unavailable_DAS_OperatingModesField;
    
    /// <remarks/>
    public Unavailable_DAS_OperatingModes Unavailable_DAS_OperatingModes {
        get {
            return this.unavailable_DAS_OperatingModesField;
        }
        set {
            this.unavailable_DAS_OperatingModesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LimitedDynamicBrakeForceArea : SP_GenericArea_ComplexType {
    
    private ushort dynamicBrakeForceLimitField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort dynamicBrakeForceLimit {
        get {
            return this.dynamicBrakeForceLimitField;
        }
        set {
            this.dynamicBrakeForceLimitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TAF_TAP_Location : SP_GenericArea_ComplexType {
    
    private LocationIdent tAF_TAP_LocationIdentField;
    
    /// <remarks/>
    public LocationIdent TAF_TAP_LocationIdent {
        get {
            return this.tAF_TAP_LocationIdentField;
        }
        set {
            this.tAF_TAP_LocationIdentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NetworkSpecificArea : SP_GenericArea_ComplexType {
    
    private NetworkSpecificParameter[] networkSpecificParameterField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificParameter")]
    public NetworkSpecificParameter[] NetworkSpecificParameter {
        get {
            return this.networkSpecificParameterField;
        }
        set {
            this.networkSpecificParameterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SP_Characteristics {
    
    private StaticSpeedProfile[] staticSpeedProfileField;
    
    private GradientAverage gradientAverageField;
    
    private GradientSteepest gradientSteepestField;
    
    private Curves curvesField;
    
    private SuperElevation superElevationField;
    
    private RatedVoltage ratedVoltageField;
    
    private EstimatedVoltage estimatedVoltageField;
    
    private CurrentLimitation currentLimitationField;
    
    private ATP_Systems aTP_SystemsField;
    
    private NetworkSpecificCharacteristics[] networkSpecificCharacteristicsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("StaticSpeedProfile")]
    public StaticSpeedProfile[] StaticSpeedProfile {
        get {
            return this.staticSpeedProfileField;
        }
        set {
            this.staticSpeedProfileField = value;
        }
    }
    
    /// <remarks/>
    public GradientAverage GradientAverage {
        get {
            return this.gradientAverageField;
        }
        set {
            this.gradientAverageField = value;
        }
    }
    
    /// <remarks/>
    public GradientSteepest GradientSteepest {
        get {
            return this.gradientSteepestField;
        }
        set {
            this.gradientSteepestField = value;
        }
    }
    
    /// <remarks/>
    public Curves Curves {
        get {
            return this.curvesField;
        }
        set {
            this.curvesField = value;
        }
    }
    
    /// <remarks/>
    public SuperElevation SuperElevation {
        get {
            return this.superElevationField;
        }
        set {
            this.superElevationField = value;
        }
    }
    
    /// <remarks/>
    public RatedVoltage RatedVoltage {
        get {
            return this.ratedVoltageField;
        }
        set {
            this.ratedVoltageField = value;
        }
    }
    
    /// <remarks/>
    public EstimatedVoltage EstimatedVoltage {
        get {
            return this.estimatedVoltageField;
        }
        set {
            this.estimatedVoltageField = value;
        }
    }
    
    /// <remarks/>
    public CurrentLimitation CurrentLimitation {
        get {
            return this.currentLimitationField;
        }
        set {
            this.currentLimitationField = value;
        }
    }
    
    /// <remarks/>
    public ATP_Systems ATP_Systems {
        get {
            return this.aTP_SystemsField;
        }
        set {
            this.aTP_SystemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificCharacteristics")]
    public NetworkSpecificCharacteristics[] NetworkSpecificCharacteristics {
        get {
            return this.networkSpecificCharacteristicsField;
        }
        set {
            this.networkSpecificCharacteristicsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class StaticSpeedProfile {
    
    private SSP_ComplexType staticSpeedProfileStartField;
    
    private StaticSpeedProfileChange[] staticSpeedProfileChangeField;
    
    private ATP_System_Identifier[] aTP_System_IdentifierField;
    
    /// <remarks/>
    public SSP_ComplexType StaticSpeedProfileStart {
        get {
            return this.staticSpeedProfileStartField;
        }
        set {
            this.staticSpeedProfileStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("StaticSpeedProfileChange")]
    public StaticSpeedProfileChange[] StaticSpeedProfileChange {
        get {
            return this.staticSpeedProfileChangeField;
        }
        set {
            this.staticSpeedProfileChangeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ATP_System_Identifier")]
    public ATP_System_Identifier[] ATP_System_Identifier {
        get {
            return this.aTP_System_IdentifierField;
        }
        set {
            this.aTP_System_IdentifierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("StaticSpeedProfileStart", Namespace="", IsNullable=false)]
public partial class SSP_ComplexType {
    
    private SpecificSSP_ComplexType[] specificSSPField;
    
    private decimal sSP_SpeedField;
    
    private bool sSP_SpeedFieldSpecified;
    
    private bool sSP_FrontField;
    
    private bool sSP_FrontFieldSpecified;
    
    private string sSP_VisualReferenceField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SpecificSSP")]
    public SpecificSSP_ComplexType[] SpecificSSP {
        get {
            return this.specificSSPField;
        }
        set {
            this.specificSSPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal SSP_Speed {
        get {
            return this.sSP_SpeedField;
        }
        set {
            this.sSP_SpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SSP_SpeedSpecified {
        get {
            return this.sSP_SpeedFieldSpecified;
        }
        set {
            this.sSP_SpeedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool SSP_Front {
        get {
            return this.sSP_FrontField;
        }
        set {
            this.sSP_FrontField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SSP_FrontSpecified {
        get {
            return this.sSP_FrontFieldSpecified;
        }
        set {
            this.sSP_FrontFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SSP_VisualReference {
        get {
            return this.sSP_VisualReferenceField;
        }
        set {
            this.sSP_VisualReferenceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("SpecificSSP", Namespace="", IsNullable=false)]
public partial class SpecificSSP_ComplexType {
    
    private object itemField;
    
    private SpecificSSP_ComplexTypeSpecific_SSP_Category specific_SSP_CategoryField;
    
    private bool specific_SSP_CategoryFieldSpecified;
    
    private decimal v_DIFFField;
    
    private bool v_DIFFFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CantDeficiencySSP", typeof(CantDeficiencySSP))]
    [System.Xml.Serialization.XmlElementAttribute("OtherSpecificSSP", typeof(OtherSpecificSSP))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public SpecificSSP_ComplexTypeSpecific_SSP_Category specific_SSP_Category {
        get {
            return this.specific_SSP_CategoryField;
        }
        set {
            this.specific_SSP_CategoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool specific_SSP_CategorySpecified {
        get {
            return this.specific_SSP_CategoryFieldSpecified;
        }
        set {
            this.specific_SSP_CategoryFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal V_DIFF {
        get {
            return this.v_DIFFField;
        }
        set {
            this.v_DIFFField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool V_DIFFSpecified {
        get {
            return this.v_DIFFFieldSpecified;
        }
        set {
            this.v_DIFFFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CantDeficiencySSP {
    
    private NC_CDTrainType sSP_NC_CDDIFFField;
    
    private bool sSP_NC_CDDIFFFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NC_CDTrainType SSP_NC_CDDIFF {
        get {
            return this.sSP_NC_CDDIFFField;
        }
        set {
            this.sSP_NC_CDDIFFField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SSP_NC_CDDIFFSpecified {
        get {
            return this.sSP_NC_CDDIFFFieldSpecified;
        }
        set {
            this.sSP_NC_CDDIFFFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class OtherSpecificSSP {
    
    private NC_TrainType sSP_NC_DIFFField;
    
    private bool sSP_NC_DIFFFieldSpecified;
    
    private string trainCategoryCodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public NC_TrainType SSP_NC_DIFF {
        get {
            return this.sSP_NC_DIFFField;
        }
        set {
            this.sSP_NC_DIFFField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SSP_NC_DIFFSpecified {
        get {
            return this.sSP_NC_DIFFFieldSpecified;
        }
        set {
            this.sSP_NC_DIFFFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trainCategoryCode {
        get {
            return this.trainCategoryCodeField;
        }
        set {
            this.trainCategoryCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum SpecificSSP_ComplexTypeSpecific_SSP_Category {
    
    /// <remarks/>
    Cant_Deficiency_SSP,
    
    /// <remarks/>
    Other_SSP_Replaces_CDSSP,
    
    /// <remarks/>
    Other_SSP_Noreplace_CDSSP,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class StaticSpeedProfileChange : SSP_ComplexType {
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class GradientAverage {
    
    private Gradient_ComplexType gradientAverageStartField;
    
    private GradientAverageChange[] gradientAverageChangeField;
    
    /// <remarks/>
    public Gradient_ComplexType GradientAverageStart {
        get {
            return this.gradientAverageStartField;
        }
        set {
            this.gradientAverageStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("GradientAverageChange")]
    public GradientAverageChange[] GradientAverageChange {
        get {
            return this.gradientAverageChangeField;
        }
        set {
            this.gradientAverageChangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("GradientAverageStart", Namespace="", IsNullable=false)]
public partial class Gradient_ComplexType {
    
    private decimal gradientValueField;
    
    private gradientDirectionType gradientDirectionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal gradientValue {
        get {
            return this.gradientValueField;
        }
        set {
            this.gradientValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public gradientDirectionType gradientDirection {
        get {
            return this.gradientDirectionField;
        }
        set {
            this.gradientDirectionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class GradientAverageChange : Gradient_ComplexType {
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class GradientSteepest {
    
    private Gradient_ComplexType gradientSteepestStartField;
    
    private GradientSteepestChange[] gradientSteepestChangeField;
    
    /// <remarks/>
    public Gradient_ComplexType GradientSteepestStart {
        get {
            return this.gradientSteepestStartField;
        }
        set {
            this.gradientSteepestStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("GradientSteepestChange")]
    public GradientSteepestChange[] GradientSteepestChange {
        get {
            return this.gradientSteepestChangeField;
        }
        set {
            this.gradientSteepestChangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class GradientSteepestChange : Gradient_ComplexType {
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Curves {
    
    private Curve_ComplexType curveStartField;
    
    private CurveChange[] curveChangeField;
    
    /// <remarks/>
    public Curve_ComplexType CurveStart {
        get {
            return this.curveStartField;
        }
        set {
            this.curveStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CurveChange")]
    public CurveChange[] CurveChange {
        get {
            return this.curveChangeField;
        }
        set {
            this.curveChangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("CurveStart", Namespace="", IsNullable=false)]
public partial class Curve_ComplexType {
    
    private decimal curveRadiusField;
    
    private Curve_ComplexTypeCurveDirection curveDirectionField;
    
    private bool curveDirectionFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal curveRadius {
        get {
            return this.curveRadiusField;
        }
        set {
            this.curveRadiusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public Curve_ComplexTypeCurveDirection curveDirection {
        get {
            return this.curveDirectionField;
        }
        set {
            this.curveDirectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool curveDirectionSpecified {
        get {
            return this.curveDirectionFieldSpecified;
        }
        set {
            this.curveDirectionFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum Curve_ComplexTypeCurveDirection {
    
    /// <remarks/>
    Unknown,
    
    /// <remarks/>
    Left,
    
    /// <remarks/>
    Right,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CurveChange : Curve_ComplexType {
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SuperElevation {
    
    private SuperElevationStart superElevationStartField;
    
    private SuperElevationChange[] superElevationChangeField;
    
    /// <remarks/>
    public SuperElevationStart SuperElevationStart {
        get {
            return this.superElevationStartField;
        }
        set {
            this.superElevationStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SuperElevationChange")]
    public SuperElevationChange[] SuperElevationChange {
        get {
            return this.superElevationChangeField;
        }
        set {
            this.superElevationChangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SuperElevationStart {
    
    private decimal superElevationValueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal superElevationValue {
        get {
            return this.superElevationValueField;
        }
        set {
            this.superElevationValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SuperElevationChange {
    
    private double locationField;
    
    private decimal superElevationValueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal superElevationValue {
        get {
            return this.superElevationValueField;
        }
        set {
            this.superElevationValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class RatedVoltage {
    
    private Voltage_ComplexType ratedVoltageStartField;
    
    private RatedVoltageChange[] ratedVoltageChangeField;
    
    /// <remarks/>
    public Voltage_ComplexType RatedVoltageStart {
        get {
            return this.ratedVoltageStartField;
        }
        set {
            this.ratedVoltageStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RatedVoltageChange")]
    public RatedVoltageChange[] RatedVoltageChange {
        get {
            return this.ratedVoltageChangeField;
        }
        set {
            this.ratedVoltageChangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class RatedVoltageChange : Voltage_ComplexType {
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class EstimatedVoltage {
    
    private Voltage_ComplexType estimatedVoltageStartField;
    
    private EstimatedVoltageChange[] estimatedVoltageChangeField;
    
    /// <remarks/>
    public Voltage_ComplexType EstimatedVoltageStart {
        get {
            return this.estimatedVoltageStartField;
        }
        set {
            this.estimatedVoltageStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EstimatedVoltageChange")]
    public EstimatedVoltageChange[] EstimatedVoltageChange {
        get {
            return this.estimatedVoltageChangeField;
        }
        set {
            this.estimatedVoltageChangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class EstimatedVoltageChange : Voltage_ComplexType {
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CurrentLimitation {
    
    private CurrentLimitation_ComplexType currentLimitationStartField;
    
    private CurrentLimitationChange[] currentLimitationChangeField;
    
    /// <remarks/>
    public CurrentLimitation_ComplexType CurrentLimitationStart {
        get {
            return this.currentLimitationStartField;
        }
        set {
            this.currentLimitationStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CurrentLimitationChange")]
    public CurrentLimitationChange[] CurrentLimitationChange {
        get {
            return this.currentLimitationChangeField;
        }
        set {
            this.currentLimitationChangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("CurrentLimitationStart", Namespace="", IsNullable=false)]
public partial class CurrentLimitation_ComplexType {
    
    private decimal maxCurValueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal maxCurValue {
        get {
            return this.maxCurValueField;
        }
        set {
            this.maxCurValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CurrentLimitationChange : CurrentLimitation_ComplexType {
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ATP_Systems {
    
    private ATP_System_Identifier[] aTP_SystemsStartField;
    
    private ATP_SystemsChange[] aTP_SystemsChangeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ATP_System_Identifier", IsNullable=false)]
    public ATP_System_Identifier[] ATP_SystemsStart {
        get {
            return this.aTP_SystemsStartField;
        }
        set {
            this.aTP_SystemsStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ATP_SystemsChange")]
    public ATP_SystemsChange[] ATP_SystemsChange {
        get {
            return this.aTP_SystemsChangeField;
        }
        set {
            this.aTP_SystemsChangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ATP_SystemsChange : ATPSystems_ComplexType {
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NetworkSpecificCharacteristics {
    
    private NetworkSpecificParameter[] nSP_StartField;
    
    private NSP_Change[] nSP_ChangeField;
    
    private string nameField;
    
    private string descriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("NetworkSpecificParameter", IsNullable=false)]
    public NetworkSpecificParameter[] NSP_Start {
        get {
            return this.nSP_StartField;
        }
        set {
            this.nSP_StartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NSP_Change")]
    public NSP_Change[] NSP_Change {
        get {
            return this.nSP_ChangeField;
        }
        set {
            this.nSP_ChangeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NSP_Change {
    
    private NetworkSpecificParameter[] networkSpecificParameterField;
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificParameter")]
    public NetworkSpecificParameter[] NetworkSpecificParameter {
        get {
            return this.networkSpecificParameterField;
        }
        set {
            this.networkSpecificParameterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SP_ContextInformation {
    
    private LevelCrossingArea[] levelCrossingAreaField;
    
    private ConnectionTrack[] connectionTrackField;
    
    private ContactList[] contactListField;
    
    private CommunicationNetwork[] communicationNetworkField;
    
    private KilometreReferencePoint[] kilometreReferencePointField;
    
    private LineAndTrackIdentifier lineAndTrackIdentifierField;
    
    private NetworkSpecificPoint[] networkSpecificPointField;
    
    private NetworkSpecificArea[] networkSpecificAreaField;
    
    private NetworkSpecificCharacteristics[] networkSpecificCharacteristicsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LevelCrossingArea")]
    public LevelCrossingArea[] LevelCrossingArea {
        get {
            return this.levelCrossingAreaField;
        }
        set {
            this.levelCrossingAreaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ConnectionTrack")]
    public ConnectionTrack[] ConnectionTrack {
        get {
            return this.connectionTrackField;
        }
        set {
            this.connectionTrackField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContactList")]
    public ContactList[] ContactList {
        get {
            return this.contactListField;
        }
        set {
            this.contactListField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CommunicationNetwork")]
    public CommunicationNetwork[] CommunicationNetwork {
        get {
            return this.communicationNetworkField;
        }
        set {
            this.communicationNetworkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("KilometreReferencePoint")]
    public KilometreReferencePoint[] KilometreReferencePoint {
        get {
            return this.kilometreReferencePointField;
        }
        set {
            this.kilometreReferencePointField = value;
        }
    }
    
    /// <remarks/>
    public LineAndTrackIdentifier LineAndTrackIdentifier {
        get {
            return this.lineAndTrackIdentifierField;
        }
        set {
            this.lineAndTrackIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificPoint")]
    public NetworkSpecificPoint[] NetworkSpecificPoint {
        get {
            return this.networkSpecificPointField;
        }
        set {
            this.networkSpecificPointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificArea")]
    public NetworkSpecificArea[] NetworkSpecificArea {
        get {
            return this.networkSpecificAreaField;
        }
        set {
            this.networkSpecificAreaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificCharacteristics")]
    public NetworkSpecificCharacteristics[] NetworkSpecificCharacteristics {
        get {
            return this.networkSpecificCharacteristicsField;
        }
        set {
            this.networkSpecificCharacteristicsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LevelCrossingArea : SP_GenericArea_ComplexType {
    
    private string levelCrossingTypeField;
    
    private bool protectedLevelCrossingField;
    
    private bool protectedLevelCrossingFieldSpecified;
    
    private string levelCrossingDescriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string levelCrossingType {
        get {
            return this.levelCrossingTypeField;
        }
        set {
            this.levelCrossingTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool protectedLevelCrossing {
        get {
            return this.protectedLevelCrossingField;
        }
        set {
            this.protectedLevelCrossingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool protectedLevelCrossingSpecified {
        get {
            return this.protectedLevelCrossingFieldSpecified;
        }
        set {
            this.protectedLevelCrossingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string levelCrossingDescription {
        get {
            return this.levelCrossingDescriptionField;
        }
        set {
            this.levelCrossingDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ConnectionTrack : SP_GenericPoint_ComplexType {
    
    private ConnectionTrackConnectionTrackType connectionTrackTypeField;
    
    private string connectionTrackDescriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ConnectionTrackConnectionTrackType connectionTrackType {
        get {
            return this.connectionTrackTypeField;
        }
        set {
            this.connectionTrackTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string connectionTrackDescription {
        get {
            return this.connectionTrackDescriptionField;
        }
        set {
            this.connectionTrackDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum ConnectionTrackConnectionTrackType {
    
    /// <remarks/>
    ConvergenceFromRight,
    
    /// <remarks/>
    ConvergingIntoRight,
    
    /// <remarks/>
    ConvergenceFromLeft,
    
    /// <remarks/>
    ConvergingIntoLeft,
    
    /// <remarks/>
    CrossingFromRightToLeft,
    
    /// <remarks/>
    CrossingFromLeftToRight,
    
    /// <remarks/>
    CrossingALineOnLeft,
    
    /// <remarks/>
    CrossingALineOnRight,
    
    /// <remarks/>
    DivergenceIntoRight,
    
    /// <remarks/>
    DivergenceAtRight,
    
    /// <remarks/>
    DivergenceIntoLeft,
    
    /// <remarks/>
    DivergenceAtLeft,
    
    /// <remarks/>
    Unknown,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ContactList : SP_GenericArea_ComplexType {
    
    private Contact[] contactField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Contact")]
    public Contact[] Contact {
        get {
            return this.contactField;
        }
        set {
            this.contactField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Contact {
    
    private string contactIdentifierField;
    
    private string contactTypeField;
    
    private string contactRoleField;
    
    private string contactNotesField;
    
    private bool mainContactField;
    
    private bool mainContactFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contactIdentifier {
        get {
            return this.contactIdentifierField;
        }
        set {
            this.contactIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contactType {
        get {
            return this.contactTypeField;
        }
        set {
            this.contactTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contactRole {
        get {
            return this.contactRoleField;
        }
        set {
            this.contactRoleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contactNotes {
        get {
            return this.contactNotesField;
        }
        set {
            this.contactNotesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool mainContact {
        get {
            return this.mainContactField;
        }
        set {
            this.mainContactField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mainContactSpecified {
        get {
            return this.mainContactFieldSpecified;
        }
        set {
            this.mainContactFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CommunicationNetwork : SP_GenericArea_ComplexType {
    
    private string communicationNetworkTypeField;
    
    private string communicationNetworkChannelField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string communicationNetworkType {
        get {
            return this.communicationNetworkTypeField;
        }
        set {
            this.communicationNetworkTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string communicationNetworkChannel {
        get {
            return this.communicationNetworkChannelField;
        }
        set {
            this.communicationNetworkChannelField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class KilometreReferencePoint : SP_GenericPoint_ComplexType {
    
    private KM_Reference kM_ReferenceField;
    
    /// <remarks/>
    public KM_Reference KM_Reference {
        get {
            return this.kM_ReferenceField;
        }
        set {
            this.kM_ReferenceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class KM_Reference : PhysicalCharacteristics_ComplexType {
    
    private double kmRefField;
    
    private KM_ReferenceAscending ascendingField;
    
    private bool ascendingFieldSpecified;
    
    private string additionalInfoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double kmRef {
        get {
            return this.kmRefField;
        }
        set {
            this.kmRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public KM_ReferenceAscending ascending {
        get {
            return this.ascendingField;
        }
        set {
            this.ascendingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ascendingSpecified {
        get {
            return this.ascendingFieldSpecified;
        }
        set {
            this.ascendingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string additionalInfo {
        get {
            return this.additionalInfoField;
        }
        set {
            this.additionalInfoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum KM_ReferenceAscending {
    
    /// <remarks/>
    Ascending,
    
    /// <remarks/>
    Descending,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LineAndTrackIdentifier {
    
    private LineAndTrackIdentifier_ComplexType lineAndTrackIdentifierStartField;
    
    private LineAndTrackIdentifierChange[] lineAndTrackIdentifierChangeField;
    
    /// <remarks/>
    public LineAndTrackIdentifier_ComplexType LineAndTrackIdentifierStart {
        get {
            return this.lineAndTrackIdentifierStartField;
        }
        set {
            this.lineAndTrackIdentifierStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LineAndTrackIdentifierChange")]
    public LineAndTrackIdentifierChange[] LineAndTrackIdentifierChange {
        get {
            return this.lineAndTrackIdentifierChangeField;
        }
        set {
            this.lineAndTrackIdentifierChangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("LineAndTrackIdentifierStart", Namespace="", IsNullable=false)]
public partial class LineAndTrackIdentifier_ComplexType {
    
    private string lineIdentifierField;
    
    private string lineNameField;
    
    private string trackIdentifierField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string lineIdentifier {
        get {
            return this.lineIdentifierField;
        }
        set {
            this.lineIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string lineName {
        get {
            return this.lineNameField;
        }
        set {
            this.lineNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trackIdentifier {
        get {
            return this.trackIdentifierField;
        }
        set {
            this.trackIdentifierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LineAndTrackIdentifierChange : LineAndTrackIdentifier_ComplexType {
    
    private double locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum SegmentProfileSP_Status {
    
    /// <remarks/>
    Valid,
    
    /// <remarks/>
    Invalid,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TrainCharacteristics : TC_Identifier_ComplexType {
    
    private TC_Features_ComplexType tC_FeaturesField;
    
    private uint tC_VersionMajorField;
    
    private uint tC_VersionMinorField;
    
    /// <remarks/>
    public TC_Features_ComplexType TC_Features {
        get {
            return this.tC_FeaturesField;
        }
        set {
            this.tC_FeaturesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint TC_VersionMajor {
        get {
            return this.tC_VersionMajorField;
        }
        set {
            this.tC_VersionMajorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint TC_VersionMinor {
        get {
            return this.tC_VersionMinorField;
        }
        set {
            this.tC_VersionMinorField = value;
        }
    }

    public string Name { get; internal set; }
    public int Power { get; internal set; }
    public int Force { get; internal set; }
    public int Mass { get; internal set; }
    public int Length { get; internal set; }
    public int Resistance { get; internal set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class G2B_MessageResponse {
    
    private G2B_Error[] g2B_ErrorField;
    
    private B2G_MessageResponseResult resultField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("G2B_Error")]
    public G2B_Error[] G2B_Error {
        get {
            return this.g2B_ErrorField;
        }
        set {
            this.g2B_ErrorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public B2G_MessageResponseResult result {
        get {
            return this.resultField;
        }
        set {
            this.resultField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class G2B_Error : Error_ComplexType {
    
    private System.DateTime dataFirstAvailableField;
    
    private bool dataFirstAvailableFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime dataFirstAvailable {
        get {
            return this.dataFirstAvailableField;
        }
        set {
            this.dataFirstAvailableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dataFirstAvailableSpecified {
        get {
            return this.dataFirstAvailableFieldSpecified;
        }
        set {
            this.dataFirstAvailableFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class HandshakeAcknowledgement {
    
    private DAS_OperatingModeSelected dAS_OperatingModeSelectedField;
    
    private SP_Zone_ComplexType sP_ZoneField;
    
    private string timeout_ATOTS_ResponseField;
    
    private string reportingTimeField;
    
    private string additionalInfoField;
    
    private string minimumPositionUpdateRequestPeriodField;
    
    private string aTOTS_IDField;
    
    private relatedTrainRequestType relatedTrainSupportedField;
    
    private bool relatedTrainSupportedFieldSpecified;
    
    /// <remarks/>
    public DAS_OperatingModeSelected DAS_OperatingModeSelected {
        get {
            return this.dAS_OperatingModeSelectedField;
        }
        set {
            this.dAS_OperatingModeSelectedField = value;
        }
    }
    
    /// <remarks/>
    public SP_Zone_ComplexType SP_Zone {
        get {
            return this.sP_ZoneField;
        }
        set {
            this.sP_ZoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
    public string timeout_ATOTS_Response {
        get {
            return this.timeout_ATOTS_ResponseField;
        }
        set {
            this.timeout_ATOTS_ResponseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
    public string reportingTime {
        get {
            return this.reportingTimeField;
        }
        set {
            this.reportingTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string additionalInfo {
        get {
            return this.additionalInfoField;
        }
        set {
            this.additionalInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
    public string minimumPositionUpdateRequestPeriod {
        get {
            return this.minimumPositionUpdateRequestPeriodField;
        }
        set {
            this.minimumPositionUpdateRequestPeriodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ATOTS_ID {
        get {
            return this.aTOTS_IDField;
        }
        set {
            this.aTOTS_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public relatedTrainRequestType relatedTrainSupported {
        get {
            return this.relatedTrainSupportedField;
        }
        set {
            this.relatedTrainSupportedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool relatedTrainSupportedSpecified {
        get {
            return this.relatedTrainSupportedFieldSpecified;
        }
        set {
            this.relatedTrainSupportedFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DAS_OperatingModeSelected {
    
    private DAS_ModesComplexTypeDAS_architecture dAS_architectureField;
    
    private DAS_ModesComplexTypeDAS_connectivity dAS_connectivityField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DAS_ModesComplexTypeDAS_architecture DAS_architecture {
        get {
            return this.dAS_architectureField;
        }
        set {
            this.dAS_architectureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DAS_ModesComplexTypeDAS_connectivity DAS_connectivity {
        get {
            return this.dAS_connectivityField;
        }
        set {
            this.dAS_connectivityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class HandshakeReject {
    
    private SP_Zone_ComplexType sP_ZoneField;
    
    private string aTOTS_IDField;
    
    private HandshakeRejectHandshakeRejectReason handshakeRejectReasonField;
    
    private bool handshakeRejectReasonFieldSpecified;
    
    /// <remarks/>
    public SP_Zone_ComplexType SP_Zone {
        get {
            return this.sP_ZoneField;
        }
        set {
            this.sP_ZoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ATOTS_ID {
        get {
            return this.aTOTS_IDField;
        }
        set {
            this.aTOTS_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public HandshakeRejectHandshakeRejectReason handshakeRejectReason {
        get {
            return this.handshakeRejectReasonField;
        }
        set {
            this.handshakeRejectReasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool handshakeRejectReasonSpecified {
        get {
            return this.handshakeRejectReasonFieldSpecified;
        }
        set {
            this.handshakeRejectReasonFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum HandshakeRejectHandshakeRejectReason {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("ATO system version incompatible")]
    ATOsystemversionincompatible,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("SFERA version incompatible")]
    SFERAversionincompatible,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Another DAS-TS/ATO-TS in charge")]
    AnotherDASTSATOTSincharge,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("DAS-TS/ATO-TS in charge unknown")]
    DASTSATOTSinchargeunknown,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Architecture not supported")]
    Architecturenotsupported,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Connectivity not supported")]
    Connectivitynotsupported,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Architecture and connectivity not supported")]
    Architectureandconnectivitynotsupported,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SFERA_G2B_RequestMessage : ISferaMessage
{

    private MessageHeader messageHeaderField;
    
    private G2B_Request g2B_RequestField;
    
    /// <remarks/>
    public MessageHeader MessageHeader {
        get {
            return this.messageHeaderField;
        }
        set {
            this.messageHeaderField = value;
        }
    }
    
    /// <remarks/>
    public G2B_Request G2B_Request {
        get {
            return this.g2B_RequestField;
        }
        set {
            this.g2B_RequestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class G2B_Request {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DAS_DrivingModeRequest", typeof(DAS_DrivingModeRequest))]
    [System.Xml.Serialization.XmlElementAttribute("PlaintextMessageRequest", typeof(PlaintextMessageRequest))]
    [System.Xml.Serialization.XmlElementAttribute("SessionTerminationRequest", typeof(SessionTerminationRequest))]
    [System.Xml.Serialization.XmlElementAttribute("StatusReportRequest", typeof(StatusReportRequest))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DAS_DrivingModeRequest {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SessionTerminationRequest {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private string additionalInfoField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string additionalInfo {
        get {
            return this.additionalInfoField;
        }
        set {
            this.additionalInfoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class StatusReportRequest {
    
    private TrainIdentification_ComplexType trainIdentificationField;
    
    private LastStatusReportMessage lastStatusReportMessageField;
    
    /// <remarks/>
    public TrainIdentification_ComplexType TrainIdentification {
        get {
            return this.trainIdentificationField;
        }
        set {
            this.trainIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public LastStatusReportMessage LastStatusReportMessage {
        get {
            return this.lastStatusReportMessageField;
        }
        set {
            this.lastStatusReportMessageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LastStatusReportMessage {
    
    private string identifierField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string identifier {
        get {
            return this.identifierField;
        }
        set {
            this.identifierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class General_JP_Information {
    
    private NSPList_ComplexType[] general_JP_Information_NSPField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("General_JP_Information_NSP")]
    public NSPList_ComplexType[] General_JP_Information_NSP {
        get {
            return this.general_JP_Information_NSPField;
        }
        set {
            this.general_JP_Information_NSPField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NSP_Start {
    
    private NetworkSpecificParameter[] networkSpecificParameterField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NetworkSpecificParameter")]
    public NetworkSpecificParameter[] NetworkSpecificParameter {
        get {
            return this.networkSpecificParameterField;
        }
        set {
            this.networkSpecificParameterField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TrainsAfterOwn {
    
    private Train[] trainField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Train")]
    public Train[] Train {
        get {
            return this.trainField;
        }
        set {
            this.trainField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TrainsBeforeOwn {
    
    private Train[] trainField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Train")]
    public Train[] Train {
        get {
            return this.trainField;
        }
        set {
            this.trainField = value;
        }
    }
}
