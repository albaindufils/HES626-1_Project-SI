namespace TP1_UC3_2022_v2 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"faculty_payment")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TP1_UC3_WS_2022_V2.PropertySchema.username), XPath = @"/*[local-name()='faculty_payment' and namespace-uri()='']/*[local-name()='username' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::TP1_UC3_WS_2022_V2.PropertySchema.amount), XPath = @"/*[local-name()='faculty_payment' and namespace-uri()='']/*[local-name()='amount' and namespace-uri()='']", XsdType = @"double")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"faculty_payment"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TP1_UC3_WS_2022_V2.PropertySchema.PropertySchema", typeof(global::TP1_UC3_WS_2022_V2.PropertySchema.PropertySchema))]
    public sealed class faculties_payment : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://TP1_UC3_WS_2022_V2.PropertySchema"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://TP1_UC3_WS_2022_V2.PropertySchema"" location=""TP1_UC3_WS_2022_V2.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""faculty_payment"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:username"" xpath=""/*[local-name()='faculty_payment' and namespace-uri()='']/*[local-name()='username' and namespace-uri()='']"" />
          <b:property name=""ns0:amount"" xpath=""/*[local-name()='faculty_payment' and namespace-uri()='']/*[local-name()='amount' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""username"" type=""xs:string"" />
        <xs:element name=""amount"" type=""xs:double"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public faculties_payment() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "faculty_payment";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
