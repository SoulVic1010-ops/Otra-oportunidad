namespace pryProyecto
{
    internal static class Program
    {

        static void Main()
        {
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {

                    Application.Run(new frmPrincipal());

                }
            }

		}
    }
}