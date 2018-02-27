using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sis_Vendas_Mega
{
    // classe para desabilitar o X do form
    class FormCloseButtonDisabler
    {
        private const int MF_BYPOSITION = 0x400;

        private const int MF_REMOVE = 0x1000;

        private const int MF_DISABLED = 0x2;

        [DllImport("user32.dll", EntryPoint = "DrawMenuBar")]

        static extern Int32 DrawMenuBar(

        Int32 hWnd

        );

        [DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]

        static extern Int32 GetMenuItemCount(

        Int32 hMenu

        );

        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]

        static extern Int32 GetSystemMenu(

        Int32 hWnd,

        bool bRevert

        );

        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]

        static extern Int32 RemoveMenu(

        Int32 hMenu,

        Int32 nPosition,

        Int32 wFlags

        );

        public static void DisableCloseButton(int hWnd)
        {

            int hMenu;

            int menuItemCount;

            //Obtain the handle to the form's system menu

            hMenu = GetSystemMenu(hWnd, false);

            // Get the count of the items in the system menu

            menuItemCount = GetMenuItemCount(hMenu);

            // Remove the close menuitem

            RemoveMenu(hMenu, menuItemCount - 1, MF_DISABLED | MF_BYPOSITION);

            // Remove the Separator

            RemoveMenu(hMenu, menuItemCount - 2, MF_DISABLED | MF_BYPOSITION);

            // redraw the menu bar

            DrawMenuBar(hWnd);

        }

    }
}
