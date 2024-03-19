using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <remarks>
	///  Helper class for readers and importer that need to load more than one resource
	///
	/// ## Introduction
	///
	/// `vtkURILoader` is a class that will load URIs,
	/// giving `vtkResourceStream`s from resolved resource.
	/// URI logic (parsing, resolution) is implemented in `vtkURI`.
	///
	/// Some formats, such as GLTF, may refer to external resources through URIs. This URI loader
	/// can be used to solve this problem.
	///
	/// `vtkURILoader` provides "file" and "data" URIs loading.
	/// "file" URIs loading only supports localhost.
	/// More schemes may be supported in future versions.
	///
	/// ## Base URI
	///
	/// Base URI, specified in [RFC3986#5](https://datatracker.ietf.org/doc/html/rfc3986#section-5),
	/// is a concept that enable URIs to refer to relative resources from a base resource.
	/// For example, you can have a file that needs to look for another file next to it.
	/// The best way to implement this, is to have the first file as the base URI, and the referenced
	/// file as a relative reference.
	///
	/// To set a local file as base URI, you should use `SetBaseFileName`, and for a local directory,
	/// you should use `SetBaseDirectory`. These functions generate a "file" URI from given path.
	/// For example, calling `SetBaseFileName(".")` will generate the following URI:
	/// `"file:///&lt;absolute-current-working-directory&gt;/."`.
	/// These functions should be used because they handle some platform specific details, such as adding
	/// a `/` at the beginning of the path on Windows, percent-encoding, resolving relative paths,
	/// "." and "..", checking that path exists and actual filesystem entry type is coherent.
	///
	/// If the loader has no base URI, it can only load full URIs. See `vtkURI` for more information.
	///
	/// ## Basic usage
	///
	/// Here is a basic example of `vtkURILoader` usage:
	/// ```cpp
	/// vtkNew&lt;vtkURILoader&gt; loader;
	/// loader-&gt;SetBaseFileName("."); // Set current working directory as the base URI
	/// // This Load call will parse the string to a vtkURI. In that case, the URI only has a path.
	/// // Then it will be resolved from base URI. In that case, the current working directory:
	/// // "file:///&lt;cwd&gt;/." + "example.txt" == "file:///&lt;cwd&gt;/example.txt"
	/// // Then it will call the `DoLoad` function. This DoLoad function will check URI scheme,
	/// // here "file", and call the right loading function. In that case LoadFile will be called.
	/// // LoadFile will create a vtkFileResourceStream and open it on URI path.
	/// auto stream = loader-&gt;Load("example.txt");
	/// // stream is opened on ./example.txt... Or it is null, in case of error.
	///
	/// // When loading a full URI, base URI is ignored (see vtkURI::Resolve and RFC specs)
	/// auto other = loader-&gt;Load("data:;base64,AAAA");
	/// // other is a vtkMemoryResourceStream on the decoded base64 data. Here, 3 bytes, all equal to 0.
	/// ```
	///
	/// Note that in previous example, `loader-&gt;Load()` actually returns a `vtkResourceStream`,
	/// the real type can be accessed through `SafeDownCast`.
	///
	/// ## Usage in readers
	///
	/// When implementing a reader, you should use `vtkURILoader` if the format can contain URIs.
	/// Here are the global guidelines of URI loader support in a reader:
	/// - The function should be named `SetURILoader`.
	/// - Depending on the format, the reader may require an URI loader, or just optionally use it.
	/// - The reader may use a default constructed URI loader by default. This would enable full URI
	///   loading, such as "data" URIs.
	/// - When reading from a file name, using `SetFileName` function, the reader should internally
	///   open a `vtkFileResourceStream` on the file and create a `vtkURILoader` with a base URI set to
	///   `FileName`, then use the same code as the resource stream based reading. This prevents
	///   code duplication.
	///
	/// ## Extension
	///
	/// `vtkURILoader::DoLoad` is responsible of actually loading a full URI.
	/// It is a virtual function, so it can be reimplemented to let the user support additional schemes.
	/// In case you want do support additional scheme, URI scheme and host should be case-insensitive
	/// as specified in [RFC3986#6.2.2.1](https://datatracker.ietf.org/doc/html/rfc3986#section-6.2.2.1).
	///
	/// `vtkURILoader::LoadFile` and `vtkURILoader::LoadData` are the actual implementation of "file"
	/// and "data" URI loading.
	/// </remarks>
	// Token: 0x02000736 RID: 1846
	public class vtkURILoader : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060133DB RID: 78811 RVA: 0x001B34A7 File Offset: 0x001B16A7
		static vtkURILoader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkURILoader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkURILoader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060133DC RID: 78812 RVA: 0x001B34CF File Offset: 0x001B16CF
		public vtkURILoader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060133DD RID: 78813
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkURILoader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133DE RID: 78814 RVA: 0x001B34E0 File Offset: 0x001B16E0
		public new static vtkURILoader New()
		{
			vtkURILoader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkURILoader.vtkURILoader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkURILoader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133DF RID: 78815 RVA: 0x001B3534 File Offset: 0x001B1734
		public vtkURILoader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkURILoader.vtkURILoader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060133E0 RID: 78816 RVA: 0x001B3578 File Offset: 0x001B1778
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060133E1 RID: 78817
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkURILoader_GetBaseURI_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// @brief Get base URI
		/// @return the pointer on base URI, may be nullptr.
		/// </summary>
		// Token: 0x060133E2 RID: 78818 RVA: 0x001B3584 File Offset: 0x001B1784
		public vtkURI GetBaseURI()
		{
			vtkURI vtkURI = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkURILoader.vtkURILoader_GetBaseURI_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkURI = (vtkURI)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkURI.Register(null);
				}
			}
			return vtkURI;
		}

		// Token: 0x060133E3 RID: 78819
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkURILoader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133E4 RID: 78820 RVA: 0x001B35F4 File Offset: 0x001B17F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkURILoader.vtkURILoader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060133E5 RID: 78821
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkURILoader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133E6 RID: 78822 RVA: 0x001B3614 File Offset: 0x001B1814
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkURILoader.vtkURILoader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060133E7 RID: 78823
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkURILoader_HasBaseURI_04(HandleRef pThis);

		/// <summary>
		/// Check if loader as a base URI
		/// </summary>
		// Token: 0x060133E8 RID: 78824 RVA: 0x001B3630 File Offset: 0x001B1830
		public bool HasBaseURI()
		{
			return vtkURILoader.vtkURILoader_HasBaseURI_04(base.GetCppThis()) != 0;
		}

		// Token: 0x060133E9 RID: 78825
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkURILoader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133EA RID: 78826 RVA: 0x001B3658 File Offset: 0x001B1858
		public override int IsA(string type)
		{
			return vtkURILoader.vtkURILoader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060133EB RID: 78827
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkURILoader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133EC RID: 78828 RVA: 0x001B3678 File Offset: 0x001B1878
		public new static int IsTypeOf(string type)
		{
			return vtkURILoader.vtkURILoader_IsTypeOf_06(type);
		}

		// Token: 0x060133ED RID: 78829
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkURILoader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133EE RID: 78830 RVA: 0x001B3694 File Offset: 0x001B1894
		public new vtkURILoader NewInstance()
		{
			vtkURILoader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkURILoader.vtkURILoader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkURILoader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060133EF RID: 78831
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkURILoader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133F0 RID: 78832 RVA: 0x001B36F0 File Offset: 0x001B18F0
		public new static vtkURILoader SafeDownCast(vtkObjectBase o)
		{
			vtkURILoader vtkURILoader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkURILoader.vtkURILoader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkURILoader = (vtkURILoader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkURILoader.Register(null);
				}
			}
			return vtkURILoader;
		}

		// Token: 0x060133F1 RID: 78833
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkURILoader_SetBaseDirectory_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dirpath);

		/// <summary>
		/// @brief Higher level way to set the base URI to an existing directory
		///
		/// This generates a file URI on the absolute path of the specified directory `"."` file.
		/// `path` must refer to an existing directory.
		///
		/// @param dirpath File path to use as base URI.
		/// `dirpath` may be relative, it will be automatically transformed into an absolute path.
		/// @return true if path can be resolved, false otherwise
		/// </summary>
		// Token: 0x060133F2 RID: 78834 RVA: 0x001B3770 File Offset: 0x001B1970
		public bool SetBaseDirectory(string dirpath)
		{
			return vtkURILoader.vtkURILoader_SetBaseDirectory_10(base.GetCppThis(), dirpath) != 0;
		}

		// Token: 0x060133F3 RID: 78835
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkURILoader_SetBaseFileName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filepath);

		/// <summary>
		/// @brief Higher level way to set the base URI to an existing file
		///
		/// This generates a file URI on the absolute path of the specified filepath.
		/// `filepath` must refer to an existing file.
		///
		/// @param filepath File path to use as base URI.
		/// `filepath` may be relative, it will be automatically transformed into an absolute path.
		/// @return true if filename can be resolved, false otherwise
		/// </summary>
		// Token: 0x060133F4 RID: 78836 RVA: 0x001B3798 File Offset: 0x001B1998
		public bool SetBaseFileName(string filepath)
		{
			return vtkURILoader.vtkURILoader_SetBaseFileName_11(base.GetCppThis(), filepath) != 0;
		}

		// Token: 0x060133F5 RID: 78837
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkURILoader_SetBaseURI_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string uri);

		/// <summary>
		/// @brief Set base URI to use
		///
		/// URI must be an absolute URI.
		/// It will be used by `Resolve` and `Load(const vtkURI*)` functions
		/// to resolve relative references.
		///
		/// It may be `nullptr`. `HasBaseURI` is a more explicit way to check that.
		///
		/// `SetBaseURI(const std::string&amp; uri)` parses the URI from a string
		/// and then do the same as `SetBaseURI(vtkURI* uri)`.
		///
		/// Base URI is manipulated as a non-const `vtkURI` because loader keep a owning reference on it.
		///
		/// @param uri A string to parse, or an existing URI. Empty string is the same as nullptr.
		/// Existing URI Reference count will be increased.
		/// @return `true` if uri is a suitable base URI (i.e. is `absolute`).
		/// </summary>
		// Token: 0x060133F6 RID: 78838 RVA: 0x001B37C0 File Offset: 0x001B19C0
		public bool SetBaseURI(string uri)
		{
			return vtkURILoader.vtkURILoader_SetBaseURI_12(base.GetCppThis(), uri) != 0;
		}

		// Token: 0x060133F7 RID: 78839
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkURILoader_SetBaseURI_13(HandleRef pThis, HandleRef uri);

		/// <summary>
		/// @brief Set base URI to use
		///
		/// URI must be an absolute URI.
		/// It will be used by `Resolve` and `Load(const vtkURI*)` functions
		/// to resolve relative references.
		///
		/// It may be `nullptr`. `HasBaseURI` is a more explicit way to check that.
		///
		/// `SetBaseURI(const std::string&amp; uri)` parses the URI from a string
		/// and then do the same as `SetBaseURI(vtkURI* uri)`.
		///
		/// Base URI is manipulated as a non-const `vtkURI` because loader keep a owning reference on it.
		///
		/// @param uri A string to parse, or an existing URI. Empty string is the same as nullptr.
		/// Existing URI Reference count will be increased.
		/// @return `true` if uri is a suitable base URI (i.e. is `absolute`).
		/// </summary>
		// Token: 0x060133F8 RID: 78840 RVA: 0x001B37E8 File Offset: 0x001B19E8
		public bool SetBaseURI(vtkURI uri)
		{
			return vtkURILoader.vtkURILoader_SetBaseURI_13(base.GetCppThis(), (uri == null) ? default(HandleRef) : uri.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001638 RID: 5688
		public new const string MRFullTypeName = "Kitware.VTK.vtkURILoader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001639 RID: 5689
		public new static readonly string MRClassNameKey = "class vtkURILoader";
	}
}
