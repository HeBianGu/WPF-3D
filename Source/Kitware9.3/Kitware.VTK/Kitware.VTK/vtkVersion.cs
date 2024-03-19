using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVersion
	/// </summary>
	/// <remarks>
	///    Versioning class for vtk
	///
	/// Holds methods for defining/determining the current vtk version
	/// (major, minor, build).
	///
	/// @warning
	/// This file will change frequently to update the VTKSourceVersion which
	/// timestamps a particular source release.
	/// </remarks>
	// Token: 0x02000B88 RID: 2952
	public class vtkVersion : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601ECC7 RID: 126151 RVA: 0x002BADE5 File Offset: 0x002B8FE5
		static vtkVersion()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVersion.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVersion"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601ECC8 RID: 126152 RVA: 0x002BAE0D File Offset: 0x002B900D
		public vtkVersion(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601ECC9 RID: 126153
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVersion_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECCA RID: 126154 RVA: 0x002BAE1C File Offset: 0x002B901C
		public new static vtkVersion New()
		{
			vtkVersion result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVersion.vtkVersion_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVersion)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECCB RID: 126155 RVA: 0x002BAE70 File Offset: 0x002B9070
		public vtkVersion() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVersion.vtkVersion_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601ECCC RID: 126156 RVA: 0x002BAEB4 File Offset: 0x002B90B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601ECCD RID: 126157
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVersion_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECCE RID: 126158 RVA: 0x002BAEC0 File Offset: 0x002B90C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVersion.vtkVersion_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601ECCF RID: 126159
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVersion_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECD0 RID: 126160 RVA: 0x002BAEE0 File Offset: 0x002B90E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVersion.vtkVersion_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601ECD1 RID: 126161
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVersion_GetVTKBuildVersion_03();

		/// <summary>
		/// Return the version of vtk this object is a part of.
		/// A variety of methods are included. GetVTKSourceVersion returns a string
		/// with an identifier which timestamps a particular source tree.
		/// </summary>
		// Token: 0x0601ECD2 RID: 126162 RVA: 0x002BAEFC File Offset: 0x002B90FC
		public static int GetVTKBuildVersion()
		{
			return vtkVersion.vtkVersion_GetVTKBuildVersion_03();
		}

		// Token: 0x0601ECD3 RID: 126163
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVersion_GetVTKMajorVersion_04();

		/// <summary>
		/// Return the version of vtk this object is a part of.
		/// A variety of methods are included. GetVTKSourceVersion returns a string
		/// with an identifier which timestamps a particular source tree.
		/// </summary>
		// Token: 0x0601ECD4 RID: 126164 RVA: 0x002BAF18 File Offset: 0x002B9118
		public static int GetVTKMajorVersion()
		{
			return vtkVersion.vtkVersion_GetVTKMajorVersion_04();
		}

		// Token: 0x0601ECD5 RID: 126165
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVersion_GetVTKMinorVersion_05();

		/// <summary>
		/// Return the version of vtk this object is a part of.
		/// A variety of methods are included. GetVTKSourceVersion returns a string
		/// with an identifier which timestamps a particular source tree.
		/// </summary>
		// Token: 0x0601ECD6 RID: 126166 RVA: 0x002BAF34 File Offset: 0x002B9134
		public static int GetVTKMinorVersion()
		{
			return vtkVersion.vtkVersion_GetVTKMinorVersion_05();
		}

		// Token: 0x0601ECD7 RID: 126167
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVersion_GetVTKSourceVersion_06();

		/// <summary>
		/// Return the version of vtk this object is a part of.
		/// A variety of methods are included. GetVTKSourceVersion returns a string
		/// with an identifier which timestamps a particular source tree.
		/// </summary>
		// Token: 0x0601ECD8 RID: 126168 RVA: 0x002BAF50 File Offset: 0x002B9150
		public static string GetVTKSourceVersion()
		{
			string s = Marshal.PtrToStringAnsi(vtkVersion.vtkVersion_GetVTKSourceVersion_06());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601ECD9 RID: 126169
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVersion_GetVTKVersion_07();

		/// <summary>
		/// Return the version of vtk this object is a part of.
		/// A variety of methods are included. GetVTKSourceVersion returns a string
		/// with an identifier which timestamps a particular source tree.
		/// </summary>
		// Token: 0x0601ECDA RID: 126170 RVA: 0x002BAF84 File Offset: 0x002B9184
		public static string GetVTKVersion()
		{
			string s = Marshal.PtrToStringAnsi(vtkVersion.vtkVersion_GetVTKVersion_07());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601ECDB RID: 126171
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVersion_GetVTKVersionFull_08();

		/// <summary>
		/// Return the version of vtk this object is a part of.
		/// A variety of methods are included. GetVTKSourceVersion returns a string
		/// with an identifier which timestamps a particular source tree.
		/// </summary>
		// Token: 0x0601ECDC RID: 126172 RVA: 0x002BAFB8 File Offset: 0x002B91B8
		public static string GetVTKVersionFull()
		{
			string s = Marshal.PtrToStringAnsi(vtkVersion.vtkVersion_GetVTKVersionFull_08());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601ECDD RID: 126173
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVersion_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECDE RID: 126174 RVA: 0x002BAFEC File Offset: 0x002B91EC
		public override int IsA(string type)
		{
			return vtkVersion.vtkVersion_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601ECDF RID: 126175
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVersion_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECE0 RID: 126176 RVA: 0x002BB00C File Offset: 0x002B920C
		public new static int IsTypeOf(string type)
		{
			return vtkVersion.vtkVersion_IsTypeOf_10(type);
		}

		// Token: 0x0601ECE1 RID: 126177
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVersion_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECE2 RID: 126178 RVA: 0x002BB028 File Offset: 0x002B9228
		public new vtkVersion NewInstance()
		{
			vtkVersion result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVersion.vtkVersion_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVersion)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ECE3 RID: 126179
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVersion_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECE4 RID: 126180 RVA: 0x002BB084 File Offset: 0x002B9284
		public new static vtkVersion SafeDownCast(vtkObjectBase o)
		{
			vtkVersion vtkVersion = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVersion.vtkVersion_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVersion = (vtkVersion)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVersion.Register(null);
				}
			}
			return vtkVersion;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002100 RID: 8448
		public new const string MRFullTypeName = "Kitware.VTK.vtkVersion";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002101 RID: 8449
		public new static readonly string MRClassNameKey = "class vtkVersion";
	}
}
