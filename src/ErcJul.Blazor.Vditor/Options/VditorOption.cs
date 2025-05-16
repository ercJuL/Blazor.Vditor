namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

public class VditorOption
{
    [JsonPropertyName("rtl")]
    public bool? Rtl { get; set; }// = false;

    [JsonPropertyName("undoDelay")]
    public uint? UndoDelay { get; set; }

    // public string? lutePath { get; set; }
    [JsonPropertyName("value")]
    public string? Value { get; set; }// = string.Empty;

    [JsonPropertyName("debugger")]
    public bool? Debugger { get; set; }// = false;

    [JsonPropertyName("typewriterMode")]
    public bool? TypewriterMode { get; set; }//= false;

    [JsonPropertyName("height")]
    public uint? Height { get; set; }

    [JsonPropertyName("minHeight")]
    public uint? MinHeight { get; set; }

    [JsonPropertyName("width")]
    public uint? Width { get; set; }

    [JsonPropertyName("placeholder")]
    public string? Placeholder { get; set; }// = string.Empty;

    [JsonPropertyName("language")]
    public LanguageEnum? Language { get; set; }//= LanguageEnum.SimplifiedChinese;

    [JsonPropertyName("i18n")]
    public I18nOption? I18n { get; set; }

    [JsonPropertyName("fullscreen")]
    public FullScreenOption? FullScreen { get; set; }//= new();

    [JsonPropertyName("toolbar")]
    public List<MenuItem>? Toolbar { get; set; }

    [JsonPropertyName("resize")]
    public ResizeOption? Resize { get; set; }

    [JsonPropertyName("counter")]
    public CounterOption? Counter { get; set; }

    [JsonPropertyName("cache")]
    public CacheOption? Cache { get; set; }//= new();

    [JsonPropertyName("mode")]
    public EditModeEnum? Mode { get; set; }//= EditModeEnum.WYSIWYG;

    [JsonPropertyName("preview")]
    public PreviewOption? Preview { get; set; }

    [JsonPropertyName("link")]
    public LinkOption? Link { get; set; }

    [JsonPropertyName("image")]
    public ImageOption? Image { get; set; }

    [JsonPropertyName("hint")]
    public HintOption? Hint { get; set; }

    [JsonPropertyName("toolbarConfig")]
    public ToolbarConfigOption? ToolbarConfig { get; set; }

    [JsonPropertyName("comment")]
    public CommentOption? Comment { get; set; }

    [JsonPropertyName("theme")]
    public ThemeEnum? Theme { get; set; }//= ThemeEnum.Classic;

    [JsonPropertyName("icon")]
    public IconEnum? Icon { get; set; }

    [JsonPropertyName("upload")]
    public UploadOption? Upload { get; set; }//= new();

    [JsonPropertyName("classes")]
    public ClassesOption? Classes { get; set; }

    [JsonPropertyName("cdn")]
    public string? Cdn { get; set; }//= $"https://unpkg.com/vditor@{Constant.VditorVersion}";

    [JsonPropertyName("tab")]
    public string? Tab { get; set; }// = "\t";

    [JsonPropertyName("outline")]
    public OutLineOption? OutLine { get; set; }

    [JsonPropertyName("customRender")]
    public List<CustomRenderOption>? CustomRenders { get; set; }

    [JsonIgnore]
    public Action? After { get; set; }

    [JsonIgnore]
    public Action<string>? Input { get; set; }

    [JsonIgnore]
    public Action<string>? Focus { get; set; }

    [JsonIgnore]
    public Action<string>? Blur { get; set; }

    [JsonIgnore]
    public Action<KeyEvent>? KeyDown { get; set; }

    [JsonIgnore]
    public Action<string>? Esc { get; set; }

    [JsonIgnore]
    public Action<string>? CtrlEnter { get; set; }

    [JsonIgnore]
    public Action<string>? Select { get; set; }

    [JsonIgnore]
    public Action<string>? unSelect { get; set; }
}
