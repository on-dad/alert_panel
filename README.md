# AlertPanels Unity Package

The **AlertPanels Unity Package** provides an easy way to manage and display alert panels in your Unity projects. This package includes pre-built alert panels for **Info**, **Warning**, **Error**, and **Confirmation** dialogs, complete with optional callback functions for additional functionality.

## Installation

1. **Import the package**: Download and import the AlertPanels Unity Package into your Unity project.
2. **Add the Alert Panel to your scene**:
   - Navigate to the `Prefabs` folder.
   - Drag and drop the `Canvas_AlertPanel` prefab into your scene.

## Usage

To display alert panels, use the `AlertManager` singleton. You can also pass callback functions to be executed when the alert panel is closed or when the user interacts with it (e.g., clicking "OK", "Yes", or "No").

### Example Script

Here’s an example script demonstrating how to use the `AlertManager` to display different types of alert panels:

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.ondad.alertpanels
{
    public class TestAlert : MonoBehaviour
    {
        public void ShowAlertPanelInfo()
        {
            AlertManager.GetInstance().ShowInfoPanel("This is an Info Panel");
        }

        public void ShowAlertPanelWarning()
        {
            AlertManager.GetInstance().ShowWarningPanel("This is a Warning Panel");
        }

        public void ShowAlertPanelError()
        {
            AlertManager.GetInstance().ShowErrorPanel("This is an Error Panel");
        }

        public void ShowPanelConfirmation()
        {
            AlertManager.GetInstance().ShowConfirmationPanel("Are you sure?");
        }
    }
}
