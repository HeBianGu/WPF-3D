using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRemoveGhosts
	/// </summary>
	/// <remarks>
	///    Remove ghost points, cells and arrays
	///
	///
	/// Removes ghost points, cells and associated data arrays. Works on
	/// vtkPolyDatas and vtkUnstructuredGrids.
	/// </remarks>
	// Token: 0x0200053A RID: 1338
	public class vtkRemoveGhosts : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EE97 RID: 61079 RVA: 0x0014C723 File Offset: 0x0014A923
		static vtkRemoveGhosts()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRemoveGhosts.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRemoveGhosts"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EE98 RID: 61080 RVA: 0x0014C74B File Offset: 0x0014A94B
		public vtkRemoveGhosts(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EE99 RID: 61081
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveGhosts_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE9A RID: 61082 RVA: 0x0014C75C File Offset: 0x0014A95C
		public new static vtkRemoveGhosts New()
		{
			vtkRemoveGhosts result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveGhosts.vtkRemoveGhosts_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveGhosts)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE9B RID: 61083 RVA: 0x0014C7B0 File Offset: 0x0014A9B0
		public vtkRemoveGhosts() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRemoveGhosts.vtkRemoveGhosts_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EE9C RID: 61084 RVA: 0x0014C7F4 File Offset: 0x0014A9F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EE9D RID: 61085
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemoveGhosts_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE9E RID: 61086 RVA: 0x0014C800 File Offset: 0x0014AA00
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRemoveGhosts.vtkRemoveGhosts_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EE9F RID: 61087
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemoveGhosts_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEA0 RID: 61088 RVA: 0x0014C820 File Offset: 0x0014AA20
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRemoveGhosts.vtkRemoveGhosts_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EEA1 RID: 61089
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemoveGhosts_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEA2 RID: 61090 RVA: 0x0014C83C File Offset: 0x0014AA3C
		public override int IsA(string type)
		{
			return vtkRemoveGhosts.vtkRemoveGhosts_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600EEA3 RID: 61091
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemoveGhosts_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEA4 RID: 61092 RVA: 0x0014C85C File Offset: 0x0014AA5C
		public new static int IsTypeOf(string type)
		{
			return vtkRemoveGhosts.vtkRemoveGhosts_IsTypeOf_04(type);
		}

		// Token: 0x0600EEA5 RID: 61093
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveGhosts_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEA6 RID: 61094 RVA: 0x0014C878 File Offset: 0x0014AA78
		public new vtkRemoveGhosts NewInstance()
		{
			vtkRemoveGhosts result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveGhosts.vtkRemoveGhosts_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveGhosts)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EEA7 RID: 61095
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveGhosts_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EEA8 RID: 61096 RVA: 0x0014C8D4 File Offset: 0x0014AAD4
		public new static vtkRemoveGhosts SafeDownCast(vtkObjectBase o)
		{
			vtkRemoveGhosts vtkRemoveGhosts = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveGhosts.vtkRemoveGhosts_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRemoveGhosts = (vtkRemoveGhosts)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRemoveGhosts.Register(null);
				}
			}
			return vtkRemoveGhosts;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400116C RID: 4460
		public new const string MRFullTypeName = "Kitware.VTK.vtkRemoveGhosts";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400116D RID: 4461
		public new static readonly string MRClassNameKey = "class vtkRemoveGhosts";
	}
}
