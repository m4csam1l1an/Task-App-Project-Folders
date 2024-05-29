namespace Task_App
{
    static class CurrentPath
    {
        public static string GetPath()
        {
            string currentDirectory = Environment.CurrentDirectory;

            // Get the full path of the currently executing assembly
            string currentAssemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //Console.WriteLine("Current Directory: " + currentDirectory);
            //Console.WriteLine("Current Assembly Path: " + currentAssemblyPath);

            int binIndex = currentDirectory.IndexOf("bin", StringComparison.OrdinalIgnoreCase);


            if (binIndex != -1)
            {
                // Extract the path up to the "bin" directory
                string newPath = currentDirectory.Substring(0, binIndex);

                // Console.WriteLine("Path without everything after bin: " + newPath);
                return newPath;
            }
            else
            {
                // Console.WriteLine("bin directory not found in the path.");
                return currentDirectory;
            }
        }
    }
}
