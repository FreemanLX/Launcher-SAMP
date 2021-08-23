using System.Windows.Forms;

namespace LauncherSAMPInt
{
    public static class Algorithms
    {
        public static class Moving
        {

            public static void UserControls_Child(UserControl from_user, UserControl to_user)
            {
                from_user.Hide();
                from_user.Controls.Add(to_user);
            }

            public static void UserControls(UserControl from_user, UserControl to_user)
            {
                from_user.Hide();
                to_user.Show();
                from_user.Dispose();
            }
        }

    }
}
