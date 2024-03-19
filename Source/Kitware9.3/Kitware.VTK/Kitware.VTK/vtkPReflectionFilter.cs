using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPReflectionFilter
	/// </summary>
	/// <remarks>
	///    parallel version of vtkReflectionFilter
	///
	/// vtkPReflectionFilter is a parallel version of vtkReflectionFilter which takes
	/// into consideration the full dataset bounds for performing the reflection.
	/// </remarks>
	// Token: 0x0200052D RID: 1325
	public class vtkPReflectionFilter : vtkReflectionFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600ECB9 RID: 60601 RVA: 0x00149FEE File Offset: 0x001481EE
		static vtkPReflectionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPReflectionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPReflectionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600ECBA RID: 60602 RVA: 0x0014A016 File Offset: 0x00148216
		public vtkPReflectionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600ECBB RID: 60603
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPReflectionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECBC RID: 60604 RVA: 0x0014A024 File Offset: 0x00148224
		public new static vtkPReflectionFilter New()
		{
			vtkPReflectionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPReflectionFilter.vtkPReflectionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPReflectionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECBD RID: 60605 RVA: 0x0014A078 File Offset: 0x00148278
		public vtkPReflectionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPReflectionFilter.vtkPReflectionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600ECBE RID: 60606 RVA: 0x0014A0BC File Offset: 0x001482BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600ECBF RID: 60607
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPReflectionFilter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the parallel controller.
		/// </summary>
		// Token: 0x0600ECC0 RID: 60608 RVA: 0x0014A0C8 File Offset: 0x001482C8
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPReflectionFilter.vtkPReflectionFilter_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600ECC1 RID: 60609
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPReflectionFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECC2 RID: 60610 RVA: 0x0014A138 File Offset: 0x00148338
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPReflectionFilter.vtkPReflectionFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600ECC3 RID: 60611
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPReflectionFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECC4 RID: 60612 RVA: 0x0014A158 File Offset: 0x00148358
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPReflectionFilter.vtkPReflectionFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600ECC5 RID: 60613
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPReflectionFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECC6 RID: 60614 RVA: 0x0014A174 File Offset: 0x00148374
		public override int IsA(string type)
		{
			return vtkPReflectionFilter.vtkPReflectionFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600ECC7 RID: 60615
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPReflectionFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECC8 RID: 60616 RVA: 0x0014A194 File Offset: 0x00148394
		public new static int IsTypeOf(string type)
		{
			return vtkPReflectionFilter.vtkPReflectionFilter_IsTypeOf_05(type);
		}

		// Token: 0x0600ECC9 RID: 60617
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPReflectionFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECCA RID: 60618 RVA: 0x0014A1B0 File Offset: 0x001483B0
		public new vtkPReflectionFilter NewInstance()
		{
			vtkPReflectionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPReflectionFilter.vtkPReflectionFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPReflectionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600ECCB RID: 60619
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPReflectionFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECCC RID: 60620 RVA: 0x0014A20C File Offset: 0x0014840C
		public new static vtkPReflectionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPReflectionFilter vtkPReflectionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPReflectionFilter.vtkPReflectionFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPReflectionFilter = (vtkPReflectionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPReflectionFilter.Register(null);
				}
			}
			return vtkPReflectionFilter;
		}

		// Token: 0x0600ECCD RID: 60621
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPReflectionFilter_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the parallel controller.
		/// </summary>
		// Token: 0x0600ECCE RID: 60622 RVA: 0x0014A28C File Offset: 0x0014848C
		public void SetController(vtkMultiProcessController arg0)
		{
			vtkPReflectionFilter.vtkPReflectionFilter_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001151 RID: 4433
		public new const string MRFullTypeName = "Kitware.VTK.vtkPReflectionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001152 RID: 4434
		public new static readonly string MRClassNameKey = "class vtkPReflectionFilter";
	}
}
