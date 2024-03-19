using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPProjectSphereFilter
	/// </summary>
	/// <remarks>
	///    A filter to 'unroll' a sphere.  The
	/// unroll longitude is -180.
	///
	///
	/// </remarks>
	// Token: 0x0200052A RID: 1322
	public class vtkPProjectSphereFilter : vtkProjectSphereFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EC67 RID: 60519 RVA: 0x001499BB File Offset: 0x00147BBB
		static vtkPProjectSphereFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPProjectSphereFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPProjectSphereFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EC68 RID: 60520 RVA: 0x001499E3 File Offset: 0x00147BE3
		public vtkPProjectSphereFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EC69 RID: 60521
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPProjectSphereFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC6A RID: 60522 RVA: 0x001499F4 File Offset: 0x00147BF4
		public new static vtkPProjectSphereFilter New()
		{
			vtkPProjectSphereFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPProjectSphereFilter.vtkPProjectSphereFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPProjectSphereFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC6B RID: 60523 RVA: 0x00149A48 File Offset: 0x00147C48
		public vtkPProjectSphereFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPProjectSphereFilter.vtkPProjectSphereFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EC6C RID: 60524 RVA: 0x00149A8C File Offset: 0x00147C8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EC6D RID: 60525
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPProjectSphereFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC6E RID: 60526 RVA: 0x00149A98 File Offset: 0x00147C98
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPProjectSphereFilter.vtkPProjectSphereFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EC6F RID: 60527
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPProjectSphereFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC70 RID: 60528 RVA: 0x00149AB8 File Offset: 0x00147CB8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPProjectSphereFilter.vtkPProjectSphereFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EC71 RID: 60529
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPProjectSphereFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC72 RID: 60530 RVA: 0x00149AD4 File Offset: 0x00147CD4
		public override int IsA(string type)
		{
			return vtkPProjectSphereFilter.vtkPProjectSphereFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600EC73 RID: 60531
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPProjectSphereFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC74 RID: 60532 RVA: 0x00149AF4 File Offset: 0x00147CF4
		public new static int IsTypeOf(string type)
		{
			return vtkPProjectSphereFilter.vtkPProjectSphereFilter_IsTypeOf_04(type);
		}

		// Token: 0x0600EC75 RID: 60533
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPProjectSphereFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC76 RID: 60534 RVA: 0x00149B10 File Offset: 0x00147D10
		public new vtkPProjectSphereFilter NewInstance()
		{
			vtkPProjectSphereFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPProjectSphereFilter.vtkPProjectSphereFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPProjectSphereFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EC77 RID: 60535
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPProjectSphereFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC78 RID: 60536 RVA: 0x00149B6C File Offset: 0x00147D6C
		public new static vtkPProjectSphereFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPProjectSphereFilter vtkPProjectSphereFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPProjectSphereFilter.vtkPProjectSphereFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPProjectSphereFilter = (vtkPProjectSphereFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPProjectSphereFilter.Register(null);
				}
			}
			return vtkPProjectSphereFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001143 RID: 4419
		public new const string MRFullTypeName = "Kitware.VTK.vtkPProjectSphereFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001144 RID: 4420
		public new static readonly string MRClassNameKey = "class vtkPProjectSphereFilter";
	}
}
