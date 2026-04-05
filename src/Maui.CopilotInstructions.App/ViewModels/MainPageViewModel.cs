namespace Maui.CopilotInstructions.App.ViewModels
{
    public class MainPageViewModel
    {
        #region Constructor

        public MainPageViewModel()
        {
        }

        #endregion

        #region Properties

        public string Name { get; set; } = string.Empty;

        #endregion

        #region Public Methods

        public void SetName(string name)
        {
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
        }

        #endregion
    }
}