
using Microsoft.Maui.Platform;
namespace AppMAUIGallery.Libraries
{
    public class KeyboardFix
    {
        public static void HideKeyboard()
        {

#if ANDROID
     if(Platform.CurrentActivity.CurrentFocus!=null){
    
     Platform.CurrentActivity.HideKeyboard(Platform.CurrentActivity.CurrentFocus);
     }
#endif

        }
    }
}
