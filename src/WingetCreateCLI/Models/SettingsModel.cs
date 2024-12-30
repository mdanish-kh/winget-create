//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Microsoft.WingetCreateCLI.Models.Settings
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// Telemetry settings
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Telemetry
    {
        /// <summary>
        /// Controls whether telemetry events are written
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disable", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Disable { get; set; } = false;


    }

    /// <summary>
    /// Controls the clean up interval of installer cache and logs
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CleanUp
    {
        /// <summary>
        /// Controls the interval in days for clean up of old files and folders
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intervalInDays", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1, int.MaxValue)]
        public int IntervalInDays { get; set; } = 7;

        /// <summary>
        /// Controls whether clean up is disabled
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disable", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Disable { get; set; } = false;


    }

    /// <summary>
    /// Windows Package Manager Repository settings
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class WindowsPackageManagerRepository
    {
        /// <summary>
        /// Specifies the name of the Windows Package Manager Repository owner
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Owner { get; set; } = "microsoft";

        /// <summary>
        /// Specifies the name of the Windows Package Manager Repository
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; } = "winget-pkgs";


    }

    /// <summary>
    /// Output manifest settings
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Manifest
    {
        /// <summary>
        /// Specifies the format of the manifest file
        /// </summary>
        [Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ManifestFormat Format { get; set; } = Microsoft.WingetCreateCLI.Models.Settings.ManifestFormat.Yaml;


    }

    /// <summary>
    /// Visual settings
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Visual
    {
        /// <summary>
        /// Controls whether paths displayed on the console are substituted with environment variables
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anonymizePaths", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AnonymizePaths { get; set; } = true;


    }

    /// <summary>
    /// Pull request settings
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PullRequest
    {
        /// <summary>
        /// Controls whether the pull request is opened in the browser on submission
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openInBrowser", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool OpenInBrowser { get; set; } = true;


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SettingsManifest
    {
        /// <summary>
        /// The settings json schema
        /// </summary>
        [Newtonsoft.Json.JsonProperty("$schema", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Schema { get; set; } = "https://aka.ms/wingetcreate-settings.schema.0.1.json";

        [Newtonsoft.Json.JsonProperty("Telemetry", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public Telemetry Telemetry { get; set; } = new Telemetry();

        [Newtonsoft.Json.JsonProperty("CleanUp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public CleanUp CleanUp { get; set; } = new CleanUp();

        [Newtonsoft.Json.JsonProperty("WindowsPackageManagerRepository", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public WindowsPackageManagerRepository WindowsPackageManagerRepository { get; set; } = new WindowsPackageManagerRepository();

        [Newtonsoft.Json.JsonProperty("Manifest", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public Manifest Manifest { get; set; } = new Manifest();

        [Newtonsoft.Json.JsonProperty("Visual", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public Visual Visual { get; set; } = new Visual();

        [Newtonsoft.Json.JsonProperty("PullRequest", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        public PullRequest PullRequest { get; set; } = new PullRequest();


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum ManifestFormat
    {

        [System.Runtime.Serialization.EnumMember(Value = @"yaml")]
        Yaml = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"json")]
        Json = 1,


    }
}