using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAssemblyPaths
	/// </summary>
	/// <remarks>
	///    a list of lists of props representing an assembly hierarchy
	///
	/// vtkAssemblyPaths represents an assembly hierarchy as a list of
	/// vtkAssemblyPath. Each path represents the complete path from the
	/// top level assembly (if any) down to the leaf prop.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAssemblyPath vtkAssemblyNode vtkPicker vtkAssembly vtkProp
	/// </seealso>
	// Token: 0x0200080F RID: 2063
	public class vtkAssemblyPaths : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015368 RID: 86888 RVA: 0x001E06DB File Offset: 0x001DE8DB
		static vtkAssemblyPaths()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssemblyPaths.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssemblyPaths"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015369 RID: 86889 RVA: 0x001E0703 File Offset: 0x001DE903
		public vtkAssemblyPaths(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601536A RID: 86890
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyPaths_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601536B RID: 86891 RVA: 0x001E0714 File Offset: 0x001DE914
		public new static vtkAssemblyPaths New()
		{
			vtkAssemblyPaths result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyPaths.vtkAssemblyPaths_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyPaths)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601536C RID: 86892 RVA: 0x001E0768 File Offset: 0x001DE968
		public vtkAssemblyPaths() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAssemblyPaths.vtkAssemblyPaths_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601536D RID: 86893 RVA: 0x001E07AC File Offset: 0x001DE9AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601536E RID: 86894
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssemblyPaths_AddItem_01(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Add a path to the list.
		/// </summary>
		// Token: 0x0601536F RID: 86895 RVA: 0x001E07B8 File Offset: 0x001DE9B8
		public void AddItem(vtkAssemblyPath p)
		{
			vtkAssemblyPaths.vtkAssemblyPaths_AddItem_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06015370 RID: 86896
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAssemblyPaths_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Override the standard GetMTime() to check for the modified times
		/// of the paths.
		/// </summary>
		// Token: 0x06015371 RID: 86897 RVA: 0x001E07E8 File Offset: 0x001DE9E8
		public override ulong GetMTime()
		{
			return vtkAssemblyPaths.vtkAssemblyPaths_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x06015372 RID: 86898
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyPaths_GetNextItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next path in the list.
		/// </summary>
		// Token: 0x06015373 RID: 86899 RVA: 0x001E0808 File Offset: 0x001DEA08
		public vtkAssemblyPath GetNextItem()
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyPaths.vtkAssemblyPaths_GetNextItem_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		// Token: 0x06015374 RID: 86900
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssemblyPaths_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015375 RID: 86901 RVA: 0x001E0878 File Offset: 0x001DEA78
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAssemblyPaths.vtkAssemblyPaths_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06015376 RID: 86902
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssemblyPaths_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015377 RID: 86903 RVA: 0x001E0898 File Offset: 0x001DEA98
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAssemblyPaths.vtkAssemblyPaths_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06015378 RID: 86904
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssemblyPaths_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015379 RID: 86905 RVA: 0x001E08B4 File Offset: 0x001DEAB4
		public override int IsA(string type)
		{
			return vtkAssemblyPaths.vtkAssemblyPaths_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601537A RID: 86906
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssemblyPaths_IsItemPresent_07(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Determine whether a particular path is present. If the return value is
		/// 0, the object was not found. If the object was found, the location is
		/// the return value-1.
		/// </summary>
		// Token: 0x0601537B RID: 86907 RVA: 0x001E08D4 File Offset: 0x001DEAD4
		public int IsItemPresent(vtkAssemblyPath p)
		{
			return vtkAssemblyPaths.vtkAssemblyPaths_IsItemPresent_07(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601537C RID: 86908
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssemblyPaths_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601537D RID: 86909 RVA: 0x001E0908 File Offset: 0x001DEB08
		public new static int IsTypeOf(string type)
		{
			return vtkAssemblyPaths.vtkAssemblyPaths_IsTypeOf_08(type);
		}

		// Token: 0x0601537E RID: 86910
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyPaths_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601537F RID: 86911 RVA: 0x001E0924 File Offset: 0x001DEB24
		public new vtkAssemblyPaths NewInstance()
		{
			vtkAssemblyPaths result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyPaths.vtkAssemblyPaths_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyPaths)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015380 RID: 86912
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssemblyPaths_RemoveItem_11(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Remove a path from the list.
		/// </summary>
		// Token: 0x06015381 RID: 86913 RVA: 0x001E0980 File Offset: 0x001DEB80
		public void RemoveItem(vtkAssemblyPath p)
		{
			vtkAssemblyPaths.vtkAssemblyPaths_RemoveItem_11(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06015382 RID: 86914
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssemblyPaths_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015383 RID: 86915 RVA: 0x001E09B0 File Offset: 0x001DEBB0
		public new static vtkAssemblyPaths SafeDownCast(vtkObjectBase o)
		{
			vtkAssemblyPaths vtkAssemblyPaths = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssemblyPaths.vtkAssemblyPaths_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPaths = (vtkAssemblyPaths)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPaths.Register(null);
				}
			}
			return vtkAssemblyPaths;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001866 RID: 6246
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssemblyPaths";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001867 RID: 6247
		public new static readonly string MRClassNameKey = "class vtkAssemblyPaths";
	}
}
