using UnityEngine;
using UnityEngine.UI;

namespace CarterGames.Assets.BuildVersions
{
    /// <summary>
    /// Handles a standard build information display for the normal unity text component...
    /// </summary>
    [AddComponentMenu("Carter Games/Build Versions/Build Info Display (Unity Text)")]
    public class BuildInformationDisplayText : BuildInformationDisplay
    {
        //
        //
        //  Fields
        //
        //
        
        [Tooltip("The text element to show the output on.")]
        [SerializeField] private Text displayText = default;


        //
        //
        //  Method Overrides
        //
        //
        
        /// <summary>
        /// Updates the display with the latest value...
        /// </summary>
        public override void UpdateDisplay()
        {
            displayText.text = Parse(displayFormat);
        }
    }
}