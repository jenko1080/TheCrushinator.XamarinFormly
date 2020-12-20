using System;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TheCrushinator.XamarinFormly.Utilities
{
    /// <summary>
    /// JSON reading and writing helpers
    /// TODO: Use System.Text.Json when available: https://github.com/dotnet/runtime/issues/31326
    /// </summary>
    public static class JsonResourceHelpers
    {
        public static T ResourceToModel<T>(string fileName) where T : new()
        {
            String contents = ResourceLoader.GetEmbeddedResourceString(System.Reflection.Assembly.GetCallingAssembly(), fileName);

			var resource = JsonConvert.DeserializeObject<T>(contents);

            return resource;
        }

		/// <summary>
		/// Attempts to find and return the given resource from within the specified assembly.
		/// </summary>
		/// <returns>The embedded resource stream.</returns>
		/// <param name="assembly">Assembly.</param>
		/// <param name="resourceFileName">Resource file name.</param>
		public static Stream GetEmbeddedResourceStream(Assembly assembly, string resourceFileName)
		{
			var resourceNames = assembly.GetManifestResourceNames();

			var resourcePaths = resourceNames
				.Where(x => x.EndsWith(resourceFileName, StringComparison.CurrentCultureIgnoreCase))
				.ToArray();

			if (!resourcePaths.Any())
			{
				throw new Exception(string.Format("Resource ending with {0} not found.", resourceFileName));
			}

			if (resourcePaths.Count() > 1)
			{
				throw new Exception(string.Format("Multiple resources ending with {0} found: {1}{2}", resourceFileName, Environment.NewLine, string.Join(Environment.NewLine, resourcePaths)));
			}

			return assembly.GetManifestResourceStream(resourcePaths.Single());
		}

		/// <summary>
		/// Attempts to find and return the given resource from within the specified assembly.
		/// </summary>
		/// <returns>The embedded resource as a byte array.</returns>
		/// <param name="assembly">Assembly.</param>
		/// <param name="resourceFileName">Resource file name.</param>
		public static byte[] GetEmbeddedResourceBytes(Assembly assembly, string resourceFileName)
		{
			var stream = GetEmbeddedResourceStream(assembly, resourceFileName);

			using (var memoryStream = new MemoryStream())
			{
				stream.CopyTo(memoryStream);
				return memoryStream.ToArray();
			}
		}

		/// <summary>
		/// Attempts to find and return the given resource from within the specified assembly.
		/// </summary>
		/// <returns>The embedded resource as a string.</returns>
		/// <param name="assembly">Assembly.</param>
		/// <param name="resourceFileName">Resource file name.</param>
		public static string GetEmbeddedResourceString(Assembly assembly, string resourceFileName)
		{
			var stream = GetEmbeddedResourceStream(assembly, resourceFileName);

			using (var streamReader = new StreamReader(stream))
			{
				return streamReader.ReadToEnd();
			}
		}
    }
}
