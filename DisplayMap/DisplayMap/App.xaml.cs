using System.Configuration;
using System.Data;
using System.Windows;

namespace DisplayMap
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ApiKey = "AAPTxy8BH1VEsoebNVZXo8HurDKgIm8llQRMuEoGtGX9W2o46dAW6hITSlhMJPivhQU5WvwcYe3FwxLLHIjtVA7eSaa4lYvtLFJvSstdxItQeUq9K27OTA-02U03tiU7-DohWDqMo1CzKj0aeLflwp6xKWyd-jKx_YO8i-RaBUobIjWyEgYNw5yx44fUf4LMWMnpLKxpD6czBPvruLYzr60MR8SAfMajFvRtl4q8yXK-vdA.AT1_UDPBRDmA";
        }
    }

}
