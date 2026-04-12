using System.Collections.Generic;

namespace LightBulb.Localization;

public partial class LocalizationManager
{
    private static readonly IReadOnlyDictionary<string, string> TraditionalChineseLocalization =
        new Dictionary<string, string>
        {
            // Dashboard (儀表板)
            [nameof(SunsetLabel)] = "日落",
            [nameof(SunriseLabel)] = "日出",
            [nameof(SunsetTransitionTooltip)] = "日落過渡開始於 **{0}**，結束於 **{1}**",
            [nameof(SunriseTransitionTooltip)] = "日出過渡開始於 **{0}**，結束於 **{1}**",
            [nameof(OffsetTooltipHeader)] = "目前的色溫和亮度值已套用偏移量：",
            [nameof(TemperatureOffsetLabel)] = "色溫偏移：",
            [nameof(BrightnessOffsetLabel)] = "亮度偏移：",
            [nameof(ClickToResetLabel)] = "點擊重設",
            [nameof(OffsetLabel)] = "偏移",

            // Main window (主視窗)
            [nameof(ToggleLightBulbTooltip)] = "開啟/關閉 LightBulb",
            [nameof(HideToTrayTooltip)] = "隱藏 LightBulb 至系統匣",
            [nameof(PreviewText)] = "預覽",
            [nameof(StopPreviewTooltip)] = "停止預覽",
            [nameof(StartPreviewTooltip)] = "預覽 24 小時循環",
            [nameof(SettingsText)] = "設定",
            [nameof(OpenSettingsTooltip)] = "開啟設定",

            // Settings dialog (設定對話框)
            [nameof(ResetButton)] = "重設",
            [nameof(ResetTooltip)] = "將所有設定恢復為預設值",
            [nameof(CancelButton)] = "取消",
            [nameof(SaveButton)] = "儲存",

            // Settings tabs (設定分頁)
            [nameof(GeneralTabName)] = "一般",
            [nameof(LocationTabName)] = "位置",
            [nameof(AdvancedTabName)] = "進階",
            [nameof(AppWhitelistTabName)] = "應用程式白名單",
            [nameof(HotkeysTabName)] = "快捷鍵",

            // Advanced settings tab (進階設定分頁)
            [nameof(ThemeLabel)] = "主題",
            [nameof(ThemeTooltip)] = "偏好的使用者介面主題",
            [nameof(LanguageLabel)] = "語言",
            [nameof(LanguageTooltip)] = "偏好的使用者介面語言",
            [nameof(StartWithWindowsLabel)] = "隨 Windows 啟動",
            [nameof(StartWithWindowsTooltip)] = "在 Windows 啟動時執行 LightBulb",
            [nameof(AutoUpdateLabel)] = "自動更新",
            [nameof(AutoUpdateTooltip)] = "自動將 LightBulb 更新至最新版本",
            [nameof(DefaultToDayConfigLabel)] = "預設為日間設定",
            [nameof(DefaultToDayConfigTooltip)] =
                "當 LightBulb 被停用或暫停時，恢復設定的日間色溫和亮度，而非預設的顯示器色彩值",
            [nameof(PauseWhenFullscreenLabel)] = "全螢幕時暫停",
            [nameof(PauseWhenFullscreenTooltip)] = "當任何全螢幕視窗位於前景時暫停 LightBulb",
            [nameof(GammaSmoothingLabel)] = "色彩平滑過渡",
            [nameof(GammaSmoothingTooltip)] = "在啟用或停用 LightBulb 時緩慢過渡，給眼睛適應的時間",
            [nameof(GammaPollingLabel)] = "色彩輪詢",
            [nameof(GammaPollingTooltip)] = "定期強制刷新顯示器色彩值，防止其他程式覆寫",

            // General settings tab (一般設定分頁)
            [nameof(DayTemperatureLabel)] = "日間色溫：",
            [nameof(DayTemperatureTooltip)] = "白天的色溫",
            [nameof(NightTemperatureLabel)] = "夜間色溫：",
            [nameof(NightTemperatureTooltip)] = "夜晚的色溫",
            [nameof(DayBrightnessLabel)] = "日間亮度：",
            [nameof(DayBrightnessTooltip)] = """
                白天的亮度

                注意：此亮度設定套用於色彩值，而非顯示器的實際物理亮度。
                若您的電腦已能根據光線環境自動調整螢幕亮度（筆記型電腦常見），建議將兩個亮度設定都保持在 100%，以停用 LightBulb 的亮度控制。
                """,
            [nameof(NightBrightnessLabel)] = "夜間亮度：",
            [nameof(NightBrightnessTooltip)] = """
                夜晚的亮度

                注意：此亮度設定套用於色彩值，而非顯示器的實際物理亮度。
                若您的電腦已能根據光線環境自動調整螢幕亮度（筆記型電腦常見），建議將兩個亮度設定都保持在 100%，以停用 LightBulb 的亮度控制。
                """,
            [nameof(TransitionDurationLabel)] = "過渡時長：",
            [nameof(TransitionDurationTooltip)] = "從日間設定切換至夜間設定所需的時間",
            [nameof(TransitionOffsetLabel)] = "過渡偏移：",
            [nameof(TransitionOffsetTooltip)] = "指定過渡開始時間相對於日出和日落的提前或延後量",

            // Location settings tab (位置設定分頁)
            [nameof(SolarConfigLabel)] = "日照設定：",
            [nameof(ManualLabel)] = "手動",
            [nameof(ManualTooltip)] = "手動設定日出和日落時間",
            [nameof(LocationBasedLabel)] = "依據位置",
            [nameof(LocationBasedTooltip)] = "設定您的位置，並以此自動計算日出和日落時間",
            [nameof(SunriseTimeLabel)] = "日出：",
            [nameof(SunsetTimeLabel)] = "日落：",
            [nameof(YourLocationLabel)] = "您的位置：",
            [nameof(AutoDetectLocationTooltip)] = "嘗試依據您的 IP 位址自動偵測位置",
            [nameof(LocationQueryTooltip)] = """
                使用地理座標或搜尋關鍵字指定您的位置

                有效輸入範例：
                **41.25, -120.9762**
                **41.25°N, 120.9762°W**
                **New York, USA（美國紐約）**
                **Germany（德國）**
                """,
            [nameof(SetLocationTooltip)] = "設定位置",
            [nameof(LocationErrorText)] = "解析位置時發生錯誤，請重試",

            // Hot key settings tab (快捷鍵設定分頁)
            [nameof(ToggleLightBulbHotkeyLabel)] = "切換 LightBulb",
            [nameof(ToggleLightBulbHotkeyTooltip)] = "用於開啟/關閉 LightBulb 的全域快捷鍵",
            [nameof(ToggleWindowLabel)] = "切換視窗",
            [nameof(ToggleWindowHotkeyTooltip)] = "用於顯示/隱藏 LightBulb 主視窗的全域快捷鍵",
            [nameof(IncreaseTemperatureOffsetLabel)] = "增加色溫偏移 ↑",
            [nameof(IncreaseTemperatureOffsetTooltip)] = "用於增加目前色溫偏移量的全域快捷鍵",
            [nameof(DecreaseTemperatureOffsetLabel)] = "減少色溫偏移 ↓",
            [nameof(DecreaseTemperatureOffsetTooltip)] = "用於減少目前色溫偏移量的全域快捷鍵",
            [nameof(IncreaseBrightnessOffsetLabel)] = "增加亮度偏移 ↑",
            [nameof(IncreaseBrightnessOffsetTooltip)] = "用於增加目前亮度偏移量的全域快捷鍵",
            [nameof(DecreaseBrightnessOffsetLabel)] = "減少亮度偏移 ↓",
            [nameof(DecreaseBrightnessOffsetTooltip)] = "用於減少目前亮度偏移量的全域快捷鍵",
            [nameof(ResetOffsetLabel)] = "重設偏移",
            [nameof(ResetOffsetHotkeyTooltip)] = "用於重設目前色溫和亮度偏移量的全域快捷鍵",

            // Application whitelist settings tab (應用程式白名單設定分頁)
            [nameof(AppWhitelistLabel)] = "應用程式白名單",
            [nameof(RefreshAppsTooltip)] = "重新整理執行中的應用程式",
            [nameof(PauseForWhitelistedTooltip)] = "當選定的應用程式之一位於前景時暫停 LightBulb",

            // Tray icon context menu (系統匣圖示右鍵選單)
            [nameof(TrayShowMenuItem)] = "顯示",
            [nameof(TrayHideMenuItem)] = "隱藏",
            [nameof(TraySettingsMenuItem)] = "設定",
            [nameof(TrayEnableMenuItem)] = "啟用",
            [nameof(TrayDisableOnlyMenuItem)] = "停用",
            [nameof(TrayDisableMenuItem)] = "停用...",
            [nameof(TrayDisableUntilSunriseMenuItem)] = "直到日出",
            [nameof(TrayDisableFor1DayMenuItem)] = "停用 1 天",
            [nameof(TrayDisableFor12HoursMenuItem)] = "停用 12 小時",
            [nameof(TrayDisableFor6HoursMenuItem)] = "停用 6 小時",
            [nameof(TrayDisableFor3HoursMenuItem)] = "停用 3 小時",
            [nameof(TrayDisableFor1HourMenuItem)] = "停用 1 小時",
            [nameof(TrayDisableFor30MinutesMenuItem)] = "停用 30 分鐘",
            [nameof(TrayDisableFor15MinutesMenuItem)] = "停用 15 分鐘",
            [nameof(TrayDisableFor5MinutesMenuItem)] = "停用 5 分鐘",
            [nameof(TrayDisableFor1MinuteMenuItem)] = "停用 1 分鐘",
            [nameof(TrayExitMenuItem)] = "結束",
            [nameof(TrayTooltipDisabled)] = "已停用",

            // Dialog messages (對話框訊息)
            [nameof(UpdateAvailableTitle)] = "可用更新",
            [nameof(UpdateAvailableMessage)] = """
                已下載更新至 {0} v{1}。
                您想現在安裝嗎？
                """,
            [nameof(InstallButton)] = "安裝",
            [nameof(CloseButton)] = "關閉",
            [nameof(UkraineSupportTitle)] = "感謝您支持烏克蘭！",
            [nameof(UkraineSupportMessage)] = """
                當俄羅斯對我的國家發動種族滅絕戰爭時，我感激每一位繼續站在烏克蘭一側、支持我們爭取自由的人。

                旁觀者選擇保持中立，受傷害的終究是平民百姓。點擊「了解更多」查看您可以提供協助的方式。
                """,
            [nameof(LearnMoreButton)] = "了解更多",
            [nameof(UnstableBuildTitle)] = "不穩定版本警告",
            [nameof(UnstableBuildMessage)] = """
                您正在使用 {0} 的開發版本。這些版本未經充分測試，可能包含錯誤。

                開發版本已停用自動更新。若您想切換至穩定版本，請手動下載。
                """,
            [nameof(SeeReleasesButton)] = "查看發布版本",
            [nameof(LimitedGammaRangeTitle)] = "色彩範圍受限",
            [nameof(LimitedGammaRangeMessage)] = """
                {0} 偵測到此系統未啟用擴展色彩範圍控制。
                這可能導致某些色彩設定無法正常運作。

                按下「修正」以解鎖色彩範圍。可能需要系統管理員權限。
                """,
            [nameof(FixButton)] = "修正",
            [nameof(WelcomeTitle)] = "歡迎使用！",
            [nameof(WelcomeMessage)] = """
                感謝您安裝 {0}！
                為了獲得最個人化的體驗，請設定您偏好的日照設定。

                按下「確定」開啟設定。
                """,
            [nameof(OkButton)] = "確定",
        };
}
