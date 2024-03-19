using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDynamicLoader
	/// </summary>
	/// <remarks>
	///    class interface to system dynamic libraries
	///
	/// vtkDynamicLoader provides a portable interface to loading dynamic
	/// libraries into a process.
	/// </remarks>
	/// <seealso>
	///
	/// A more portable and lightweight solution is kwsys::DynamicLoader
	/// </seealso>
	// Token: 0x02000B50 RID: 2896
	public class vtkDynamicLoader : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E40A RID: 123914 RVA: 0x002ACC5D File Offset: 0x002AAE5D
		static vtkDynamicLoader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDynamicLoader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDynamicLoader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E40B RID: 123915 RVA: 0x002ACC85 File Offset: 0x002AAE85
		public vtkDynamicLoader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E40C RID: 123916
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDynamicLoader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E40D RID: 123917 RVA: 0x002ACC94 File Offset: 0x002AAE94
		public new static vtkDynamicLoader New()
		{
			vtkDynamicLoader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDynamicLoader.vtkDynamicLoader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDynamicLoader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E40E RID: 123918 RVA: 0x002ACCE8 File Offset: 0x002AAEE8
		public vtkDynamicLoader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDynamicLoader.vtkDynamicLoader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E40F RID: 123919 RVA: 0x002ACD2C File Offset: 0x002AAF2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E410 RID: 123920
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDynamicLoader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E411 RID: 123921 RVA: 0x002ACD38 File Offset: 0x002AAF38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDynamicLoader.vtkDynamicLoader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601E412 RID: 123922
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDynamicLoader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E413 RID: 123923 RVA: 0x002ACD58 File Offset: 0x002AAF58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDynamicLoader.vtkDynamicLoader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601E414 RID: 123924
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDynamicLoader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E415 RID: 123925 RVA: 0x002ACD74 File Offset: 0x002AAF74
		public override int IsA(string type)
		{
			return vtkDynamicLoader.vtkDynamicLoader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601E416 RID: 123926
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDynamicLoader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E417 RID: 123927 RVA: 0x002ACD94 File Offset: 0x002AAF94
		public new static int IsTypeOf(string type)
		{
			return vtkDynamicLoader.vtkDynamicLoader_IsTypeOf_04(type);
		}

		// Token: 0x0601E418 RID: 123928
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDynamicLoader_LastError_05();

		/// <summary>
		/// Return the last error produced from a calls made on this class.
		/// </summary>
		// Token: 0x0601E419 RID: 123929 RVA: 0x002ACDB0 File Offset: 0x002AAFB0
		public static string LastError()
		{
			string s = Marshal.PtrToStringAnsi(vtkDynamicLoader.vtkDynamicLoader_LastError_05());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601E41A RID: 123930
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDynamicLoader_LibExtension_06();

		/// <summary>
		/// Return the library extension for the given architecture
		/// </summary>
		// Token: 0x0601E41B RID: 123931 RVA: 0x002ACDE4 File Offset: 0x002AAFE4
		public static string LibExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkDynamicLoader.vtkDynamicLoader_LibExtension_06());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601E41C RID: 123932
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDynamicLoader_LibPrefix_07();

		/// <summary>
		/// Return the library prefix for the given architecture
		/// </summary>
		// Token: 0x0601E41D RID: 123933 RVA: 0x002ACE18 File Offset: 0x002AB018
		public static string LibPrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkDynamicLoader.vtkDynamicLoader_LibPrefix_07());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601E41E RID: 123934
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDynamicLoader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E41F RID: 123935 RVA: 0x002ACE4C File Offset: 0x002AB04C
		public new vtkDynamicLoader NewInstance()
		{
			vtkDynamicLoader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDynamicLoader.vtkDynamicLoader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDynamicLoader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E420 RID: 123936
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDynamicLoader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E421 RID: 123937 RVA: 0x002ACEA8 File Offset: 0x002AB0A8
		public new static vtkDynamicLoader SafeDownCast(vtkObjectBase o)
		{
			vtkDynamicLoader vtkDynamicLoader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDynamicLoader.vtkDynamicLoader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDynamicLoader = (vtkDynamicLoader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDynamicLoader.Register(null);
				}
			}
			return vtkDynamicLoader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400207C RID: 8316
		public new const string MRFullTypeName = "Kitware.VTK.vtkDynamicLoader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400207D RID: 8317
		public new static readonly string MRClassNameKey = "class vtkDynamicLoader";
	}
}
