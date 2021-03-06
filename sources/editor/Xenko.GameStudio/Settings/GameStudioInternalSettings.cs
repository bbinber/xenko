// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Collections.Generic;
using System.Windows;

using Xenko.Core.Assets.Editor.Settings;
using Xenko.Core.Settings;

namespace Xenko.GameStudio
{
    public static class GameStudioInternalSettings
    {
        public static SettingsContainer SettingsContainer => InternalSettings.SettingsContainer;
        
        public static SettingsKey<List<MRUAdditionalData>> MostRecentlyUsedSessionsData = new SettingsKey<List<MRUAdditionalData>>("Internal/MostRecentlyUsedSessionsData", SettingsContainer, () => new List<MRUAdditionalData>());
        public static SettingsKey<bool> WindowMaximized = new SettingsKey<bool>("Internal/WindowMaximized", SettingsContainer, false);
        public static SettingsKey<int> WindowWidth = new SettingsKey<int>("Internal/WindowWidth", SettingsContainer, (int)SystemParameters.WorkArea.Width);
        public static SettingsKey<int> WindowHeight = new SettingsKey<int>("Internal/WindowHeight", SettingsContainer, (int)SystemParameters.WorkArea.Height);
        public static SettingsKey<int> WorkAreaWidth = new SettingsKey<int>("Internal/WorkAreaWidth", SettingsContainer, (int)SystemParameters.WorkArea.Width);
        public static SettingsKey<int> WorkAreaHeight = new SettingsKey<int>("Internal/WorkAreaHeight", SettingsContainer, (int)SystemParameters.WorkArea.Height);
        public static SettingsKey<bool> SessionExplorerPanelVisible = new SettingsKey<bool>("Internal/SessionExplorerPanelVisible", SettingsContainer, true);
        public static SettingsKey<bool> AssetViewPanelVisible = new SettingsKey<bool>("Internal/AssetViewPanelVisible", SettingsContainer, true);
        public static SettingsKey<bool> ReferencesPanelVisible = new SettingsKey<bool>("Internal/ReferencesPanelVisible", SettingsContainer, true);
        public static SettingsKey<bool> AssetPreviewPanelVisible = new SettingsKey<bool>("Internal/AssetPreviewPanelVisible", SettingsContainer, true);
        public static SettingsKey<bool> PropertyGridPanelVisible = new SettingsKey<bool>("Internal/PropertyGridPanelVisible", SettingsContainer, true);
        public static SettingsKey<bool> ActionHistoryPanelVisible = new SettingsKey<bool>("Internal/ActionHistoryPanelVisible", SettingsContainer, true);
        public static SettingsKey<bool> AssetLogPanelVisible = new SettingsKey<bool>("Internal/AssetLogPanelVisible", SettingsContainer, true);
        public static SettingsKey<bool> BuildLogPanelVisible = new SettingsKey<bool>("Internal/BuildLogPanelVisible", SettingsContainer, true);

        /// <summary>
        /// Default Game Studio layout when no editors are opened.
        /// </summary>
        internal const string DefaultLayout = "<?xml version=\"1.0\"?><LayoutRoot xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><RootPanel Orientation=\"Horizontal\"><LayoutPanel Orientation=\"Vertical\"><LayoutPanel Orientation=\"Horizontal\"><LayoutAnchorablePane DockWidth=\"240\"><LayoutAnchorable AutoHideMinWidth=\"100\" AutoHideMinHeight=\"100\" Title=\"Solution explorer\" IsSelected=\"True\" ContentId=\"SolutionExplorer\" LastActivationTimeStamp=\"09/08/2016 20:59:42\" /></LayoutAnchorablePane><LayoutDocumentPane><LayoutAnchorable AutoHideMinWidth=\"100\" AutoHideMinHeight=\"100\" Title=\"Asset view\" IsSelected=\"True\" IsLastFocusedDocument=\"True\" ContentId=\"AssetView\" LastActivationTimeStamp=\"09/08/2016 20:59:41\" /></LayoutDocumentPane></LayoutPanel><LayoutAnchorablePane DockHeight=\"195\"><LayoutAnchorable AutoHideMinWidth=\"100\" AutoHideMinHeight=\"100\" Title=\"References\" ContentId=\"References\" /><LayoutAnchorable AutoHideMinWidth=\"100\" AutoHideMinHeight=\"100\" IsSelected=\"True\" ContentId=\"AssetLog\"/><LayoutAnchorable AutoHideMinWidth=\"100\" AutoHideMinHeight=\"100\" ContentId=\"BuildLog\"/></LayoutAnchorablePane></LayoutPanel><LayoutPanel Orientation=\"Vertical\" DockWidth=\"400\"><LayoutAnchorablePane DockHeight=\"2*\"><LayoutAnchorable AutoHideMinWidth=\"100\" AutoHideMinHeight=\"100\" Title=\"Property grid\" IsSelected=\"True\" ContentId=\"PropertyGrid\" /></LayoutAnchorablePane><LayoutAnchorablePaneGroup Orientation=\"Horizontal\"><LayoutAnchorablePane><LayoutAnchorable AutoHideMinWidth=\"100\" AutoHideMinHeight=\"100\" Title=\"Asset preview\" IsSelected=\"True\" ContentId=\"AssetPreview\" /><LayoutAnchorable AutoHideMinWidth=\"100\" AutoHideMinHeight=\"100\" Title=\"Action history\" ContentId=\"ActionHistory\" /></LayoutAnchorablePane></LayoutAnchorablePaneGroup></LayoutPanel></RootPanel><TopSide /><RightSide /><LeftSide /><BottomSide /><FloatingWindows /><Hidden /></LayoutRoot>";
        /// <summary>
        /// Default Game Studio layout with editors opened.
        /// </summary>
        internal const string DefaultEditorLayout = "<?xml version=\"1.0\"?><LayoutRoot xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><RootPanel Orientation=\"Horizontal\"><LayoutPanel Orientation=\"Vertical\"><LayoutPanel Orientation=\"Horizontal\"><LayoutDocumentPane /></LayoutPanel><LayoutAnchorablePaneGroup Orientation=\"Horizontal\" DockHeight=\"300\"><LayoutAnchorablePane DockWidth=\"1*\"><LayoutAnchorable Title=\"Solution explorer\" ContentId=\"SolutionExplorer\" /></LayoutAnchorablePane><LayoutAnchorablePane  DockWidth=\"3*\"><LayoutAnchorable Title=\"Asset view\" IsSelected=\"True\" ContentId=\"AssetView\"/><LayoutAnchorable ContentId=\"AssetLog\" /><LayoutAnchorable ContentId=\"BuildLog\" /></LayoutAnchorablePane></LayoutAnchorablePaneGroup></LayoutPanel><LayoutPanel Orientation=\"Vertical\" DockWidth=\"400\"><LayoutAnchorablePane DockHeight=\"4*\"><LayoutAnchorable Title=\"Property grid\" IsSelected=\"True\" ContentId=\"PropertyGrid\" /></LayoutAnchorablePane><LayoutAnchorablePaneGroup Orientation=\"Horizontal\" DockHeight=\"2*\"><LayoutAnchorablePane><LayoutAnchorable Title=\"Asset preview\" ContentId=\"AssetPreview\" /><LayoutAnchorable Title=\"Action history\" ContentId=\"ActionHistory\" /><LayoutAnchorable Title=\"References\" ContentId=\"References\" IsSelected=\"True\" /></LayoutAnchorablePane></LayoutAnchorablePaneGroup></LayoutPanel></RootPanel><TopSide /><RightSide /><LeftSide /><BottomSide /><FloatingWindows /><Hidden /></LayoutRoot>";
    }
}
